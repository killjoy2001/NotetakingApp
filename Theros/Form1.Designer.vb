<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        MenuStrip1 = New MenuStrip()
        FontToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem2 = New ToolStripMenuItem()
        ToolStripMenuItem3 = New ToolStripMenuItem()
        ToolStripMenuItem4 = New ToolStripMenuItem()
        ToolStripMenuItem1 = New ToolStripMenuItem()
        richTextBox1 = New RichTextBox()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        TextBox1 = New TextBox()
        TabPage2 = New TabPage()
        TextBox2 = New TextBox()
        TabPage3 = New TabPage()
        TextBox3 = New TextBox()
        originalLang = New TextBox()
        targetLang = New TextBox()
        cbOriginalLang = New ComboBox()
        cbTargetLang = New ComboBox()
        Label1 = New Label()
        bSwitch = New Button()
        MenuStrip1.SuspendLayout()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        TabPage3.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {FontToolStripMenuItem, ToolStripMenuItem1})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(621, 24)
        MenuStrip1.TabIndex = 4
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FontToolStripMenuItem
        ' 
        FontToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ToolStripMenuItem2, ToolStripMenuItem3, ToolStripMenuItem4})
        FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        FontToolStripMenuItem.Size = New Size(66, 20)
        FontToolStripMenuItem.Text = "Font Size"
        ' 
        ' ToolStripMenuItem2
        ' 
        ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        ToolStripMenuItem2.Size = New Size(86, 22)
        ToolStripMenuItem2.Text = "16"
        ' 
        ' ToolStripMenuItem3
        ' 
        ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        ToolStripMenuItem3.Size = New Size(86, 22)
        ToolStripMenuItem3.Text = "14"
        ' 
        ' ToolStripMenuItem4
        ' 
        ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        ToolStripMenuItem4.Size = New Size(86, 22)
        ToolStripMenuItem4.Text = "12"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(22, 20)
        ToolStripMenuItem1.Text = " "
        ' 
        ' richTextBox1
        ' 
        richTextBox1.BorderStyle = BorderStyle.None
        richTextBox1.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        richTextBox1.Location = New Point(12, 37)
        richTextBox1.Name = "richTextBox1"
        richTextBox1.Size = New Size(407, 523)
        richTextBox1.TabIndex = 9
        richTextBox1.Text = ""
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Location = New Point(425, 37)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(188, 523)
        TabControl1.TabIndex = 10
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(TextBox1)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(180, 495)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Medical"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Dock = DockStyle.Fill
        TextBox1.Location = New Point(3, 3)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(174, 489)
        TextBox1.TabIndex = 0
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(TextBox2)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(180, 495)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Insurance"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' TextBox2
        ' 
        TextBox2.BorderStyle = BorderStyle.None
        TextBox2.Dock = DockStyle.Fill
        TextBox2.Location = New Point(3, 3)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(174, 489)
        TextBox2.TabIndex = 1
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(TextBox3)
        TabPage3.Location = New Point(4, 24)
        TabPage3.Name = "TabPage3"
        TabPage3.Size = New Size(180, 495)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Financial"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' TextBox3
        ' 
        TextBox3.BorderStyle = BorderStyle.None
        TextBox3.Dock = DockStyle.Fill
        TextBox3.Location = New Point(0, 0)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(180, 495)
        TextBox3.TabIndex = 1
        ' 
        ' originalLang
        ' 
        originalLang.Location = New Point(12, 566)
        originalLang.Multiline = True
        originalLang.Name = "originalLang"
        originalLang.Size = New Size(199, 95)
        originalLang.TabIndex = 11
        ' 
        ' targetLang
        ' 
        targetLang.Location = New Point(220, 566)
        targetLang.Multiline = True
        targetLang.Name = "targetLang"
        targetLang.Size = New Size(199, 95)
        targetLang.TabIndex = 12
        ' 
        ' cbOriginalLang
        ' 
        cbOriginalLang.ForeColor = SystemColors.ControlDark
        cbOriginalLang.FormattingEnabled = True
        cbOriginalLang.Location = New Point(425, 566)
        cbOriginalLang.Name = "cbOriginalLang"
        cbOriginalLang.Size = New Size(117, 23)
        cbOriginalLang.TabIndex = 13
        cbOriginalLang.Tag = ""
        cbOriginalLang.Text = "Entered language"
        ' 
        ' cbTargetLang
        ' 
        cbTargetLang.ForeColor = SystemColors.ControlDark
        cbTargetLang.FormattingEnabled = True
        cbTargetLang.Location = New Point(425, 595)
        cbTargetLang.Name = "cbTargetLang"
        cbTargetLang.Size = New Size(117, 23)
        cbTargetLang.TabIndex = 14
        cbTargetLang.Text = "Target language"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(432, 646)
        Label1.Name = "Label1"
        Label1.Size = New Size(75, 15)
        Label1.TabIndex = 15
        Label1.Text = "v.2.0. @hang"
        ' 
        ' bSwitch
        ' 
        bSwitch.Location = New Point(548, 580)
        bSwitch.Name = "bSwitch"
        bSwitch.Size = New Size(41, 23)
        bSwitch.TabIndex = 16
        bSwitch.Text = "↑↓"
        bSwitch.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(25), CByte(109), CByte(186))
        ClientSize = New Size(621, 673)
        Controls.Add(bSwitch)
        Controls.Add(Label1)
        Controls.Add(cbTargetLang)
        Controls.Add(cbOriginalLang)
        Controls.Add(targetLang)
        Controls.Add(originalLang)
        Controls.Add(TabControl1)
        Controls.Add(richTextBox1)
        Controls.Add(MenuStrip1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = MenuStrip1
        MaximizeBox = False
        Name = "Form1"
        Text = "Theros"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        TabPage3.ResumeLayout(False)
        TabPage3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FontToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents richTextBox1 As RichTextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents originalLang As TextBox
    Friend WithEvents targetLang As TextBox
    Friend WithEvents cbOriginalLang As ComboBox
    Friend WithEvents cbTargetLang As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents bSwitch As Button

End Class
