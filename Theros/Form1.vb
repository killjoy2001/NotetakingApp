Imports System.IO
Imports System.Collections.Generic
Imports System.Text.RegularExpressions
Imports System.Net.Http
Imports Newtonsoft.Json.Linq

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load  ' load

        AbbCheck()

        If System.IO.File.Exists("vocab1.txt") Then
            TextBox1.Text = System.IO.File.ReadAllText("vocab1.txt") ' loads vocab on TextBox1
        End If
        If System.IO.File.Exists("vocab2.txt") Then
            TextBox2.Text = System.IO.File.ReadAllText("vocab2.txt") ' loads vocab on TextBox2
        End If
        If System.IO.File.Exists("vocab3.txt") Then
            TextBox3.Text = System.IO.File.ReadAllText("vocab3.txt") ' loads vocab on TextBox3
        End If

        cbOriginalLang.Items.AddRange(New String() {"EN", "ES", "FR", "DE", "IT", "PT"})
        cbTargetLang.Items.AddRange(New String() {"EN", "ES", "FR", "DE", "IT", "PT"})

        cbOriginalLang.SelectedItem = "EN"
        cbTargetLang.SelectedItem = "ES"
    End Sub

    Private Sub richTextBox1_TextChanged(sender As Object, e As EventArgs) Handles richTextBox1.TextChanged

        Dim cursorPosition As Integer = richTextBox1.SelectionStart
        ' 
        RemoveHandler richTextBox1.TextChanged, AddressOf richTextBox1_TextChanged
        ' 
        HighlightNumbers()
        AbbReplacement()

        richTextBox1.SelectionStart = cursorPosition
        AddHandler richTextBox1.TextChanged, AddressOf richTextBox1_TextChanged
    End Sub

    ' *********************
    ' NUMBERS *************

    Private Sub HighlightNumbers() ' identifies numbers
        Dim pattern As String = "\d+"
        Dim matches As MatchCollection = Regex.Matches(richTextBox1.Text, pattern)
        Dim originalStart As Integer = richTextBox1.SelectionStart
        Dim originalLength As Integer = richTextBox1.SelectionLength

        richTextBox1.SelectAll()
        richTextBox1.SelectionBackColor = richTextBox1.BackColor

        ' highlights numbers
        For Each match As Match In matches
            richTextBox1.Select(match.Index, match.Length)
            richTextBox1.SelectionBackColor = Color.GreenYellow ' <--- u can change color here
        Next
        richTextBox1.Select(originalStart, originalLength)
    End Sub

    ' ***********************
    ' FONT SIZE *************

    ' changes font sizes according to menustrip selection
    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        richTextBox1.Font = New Font(richTextBox1.Font.FontFamily, 16) ' <- font 16
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        richTextBox1.Font = New Font(richTextBox1.Font.FontFamily, 14) ' <- font 14
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        richTextBox1.Font = New Font(richTextBox1.Font.FontFamily, 12) ' <- font 12
    End Sub

    ' *********************
    ' VOCAB TABS **********

    ' saves vocab on txt and loads it when running theros
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' saves on txt
        System.IO.File.WriteAllText("vocab1.txt", TextBox1.Text)
        System.IO.File.WriteAllText("vocab2.txt", TextBox2.Text)
        System.IO.File.WriteAllText("vocab3.txt", TextBox3.Text)
    End Sub


    ' ************************
    ' abbreviations **********

    ' path of txt file
    Dim filePath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "abbreviations.txt")

    ' dictionary
    Private abbreviations As New Dictionary(Of String, String)
    Private Sub AbbCheck()
        If File.Exists(filePath) Then
            Using reader As New StreamReader(filePath)
                Dim line As String
                abbreviations.Clear() ' cleans dic b4 loading

                While True
                    line = reader.ReadLine()
                    If line Is Nothing Then Exit While ' exits loop if nothing

                    Dim parts() As String = line.Split("="c)
                    If parts.Length = 2 Then
                        abbreviations(parts(0).Trim()) = parts(1).Trim()
                    End If
                End While
            End Using
        Else
            MessageBox.Show("File abbreviations.txt is not available, please make sure it is created on desktop", "File not found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If  'instead of just of displaying an error message, ill modofy this to create the txt doc automcly ***********************
    End Sub
    Private Sub AbbReplacement()
        Dim originalStart As Integer = richTextBox1.SelectionStart
        Dim originalText As String = richTextBox1.Text
        Dim modifiedText As String = originalText
        Dim abbReplaced As Boolean = False

        RemoveHandler richTextBox1.TextChanged, AddressOf richTextBox1_TextChanged

        ' replaces abbs
        For Each abb In abbreviations
            Dim abbKey As String = abb.Key
            Dim pattern As String = String.Format("(?<=^| )({0})(?= |$)", Regex.Escape(abbKey))

            If Regex.IsMatch(originalText, pattern) Then
                modifiedText = Regex.Replace(modifiedText, pattern, abb.Value)
                abbReplaced = True
            End If
        Next

        If abbReplaced Then
            richTextBox1.Text = modifiedText

            ' moves cursor to the last caracter after replacing a word to avoid typing in the middle of a word
            ' the only way this happends is by typing right ->, thats why SendKeys.Send("{RIGHT}")
            Dim newCursorPosition As Integer = originalStart + (modifiedText.Length - originalText.Length)
            richTextBox1.SelectionStart = newCursorPosition

            ' c#
            SendKeys.Send("{RIGHT}")


            HighlightReplacedWords()
        End If

        AddHandler richTextBox1.TextChanged, AddressOf richTextBox1_TextChanged
    End Sub

    ' this method is supposed to highlight replaced words, currently not working
    Private Sub HighlightReplacedWords()
        Dim texto As String = richTextBox1.Text
        Dim originalStart As Integer = richTextBox1.SelectionStart
        Dim lastReplacementIndex As Integer = -1

        richTextBox1.SelectAll()
        richTextBox1.SelectionBackColor = richTextBox1.BackColor

        For Each abb In abbreviations
            Dim startIndex As Integer = 0
            Dim key As String = abb.Key
            Dim value As String = abb.Value

            While startIndex < texto.Length
                startIndex = texto.IndexOf(value, startIndex)
                If startIndex = -1 Then Exit While

                richTextBox1.Select(startIndex, value.Length)
                richTextBox1.SelectionBackColor = Color.Yellow
                lastReplacementIndex = startIndex + value.Length
                startIndex += value.Length
            End While
        Next
    End Sub

    '*******************************
    ' API DeepL 

    Private Async Function TranslateText(texto As String, sourceLang As String, targetLan As String) As Task(Of String)
        Dim apiKey As String = "key here" ' API key **********************************************
        Dim url As String = "https://api-free.deepl.com/v2/translate"

        ' 
        Dim client As New HttpClient()
        Dim requestContent As New FormUrlEncodedContent(New Dictionary(Of String, String) From {
            {"auth_key", apiKey},
            {"text", texto},
            {"source_lang", sourceLang},
            {"target_lang", targetLan}
        })

        ' HTTP request
        Dim response As HttpResponseMessage = Await client.PostAsync(url, requestContent)
        Dim responseBody As String = Await response.Content.ReadAsStringAsync()

        ' JSON return
        Dim json As JObject = JObject.Parse(responseBody)
        Dim translate As String = json("translations")(0)("text").ToString()

        Return translate
    End Function

    Private Sub bSwitch_Click(sender As Object, e As EventArgs) Handles bSwitch.Click

        Dim tempOriginalLang As String = cbOriginalLang.SelectedItem.ToString()
        Dim tempTargetLang As String = cbTargetLang.SelectedItem.ToString()


        cbOriginalLang.SelectedItem = tempTargetLang
        cbTargetLang.SelectedItem = tempOriginalLang

        originalLang.Clear()
        targetLang.Clear()
    End Sub


    Private Async Sub originalLang_TextChanged(sender As Object, e As EventArgs) Handles originalLang.TextChanged

        Dim text As String = originalLang.Text

        Dim idiomaOrigen As String = cbOriginalLang.SelectedItem.ToString()
        Dim idiomaDestino As String = cbTargetLang.SelectedItem.ToString()

        ' calls API
        If Not String.IsNullOrWhiteSpace(text) Then
            Dim translat As String = Await TranslateText(text, idiomaOrigen, idiomaDestino)
            targetLang.Text = translat
        End If
    End Sub


End Class
