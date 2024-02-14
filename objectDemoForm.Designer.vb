<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        DisplayText = New GroupBox()
        sampleTest = New TextBox()
        GroupBox2 = New GroupBox()
        Tahoma = New RadioButton()
        Magneto = New RadioButton()
        Garamond = New RadioButton()
        ButtonLoadPic = New Button()
        ButtonExit = New Button()
        Red = New RadioButton()
        Blue = New RadioButton()
        Green = New RadioButton()
        FontColor = New GroupBox()
        BoldItalic = New CheckBox()
        Bold = New CheckBox()
        Italic = New CheckBox()
        FontStyle = New GroupBox()
        PicLoad = New PictureBox()
        DisplayText.SuspendLayout()
        GroupBox2.SuspendLayout()
        FontColor.SuspendLayout()
        FontStyle.SuspendLayout()
        CType(PicLoad, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DisplayText
        ' 
        DisplayText.Controls.Add(sampleTest)
        DisplayText.Location = New Point(24, 25)
        DisplayText.Name = "DisplayText"
        DisplayText.Size = New Size(231, 106)
        DisplayText.TabIndex = 21
        DisplayText.TabStop = False
        DisplayText.Text = "Display Text"
        ' 
        ' sampleTest
        ' 
        sampleTest.Location = New Point(17, 41)
        sampleTest.Name = "sampleTest"
        sampleTest.Size = New Size(167, 31)
        sampleTest.TabIndex = 0
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Tahoma)
        GroupBox2.Controls.Add(Magneto)
        GroupBox2.Controls.Add(Garamond)
        GroupBox2.Location = New Point(299, 25)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(478, 106)
        GroupBox2.TabIndex = 22
        GroupBox2.TabStop = False
        GroupBox2.Text = "Font"
        ' 
        ' Tahoma
        ' 
        Tahoma.AutoSize = True
        Tahoma.Location = New Point(332, 45)
        Tahoma.Name = "Tahoma"
        Tahoma.Size = New Size(99, 29)
        Tahoma.TabIndex = 2
        Tahoma.TabStop = True
        Tahoma.Text = "Tahoma"
        Tahoma.UseVisualStyleBackColor = True
        ' 
        ' Magneto
        ' 
        Magneto.AutoSize = True
        Magneto.Location = New Point(170, 45)
        Magneto.Name = "Magneto"
        Magneto.Size = New Size(109, 29)
        Magneto.TabIndex = 1
        Magneto.TabStop = True
        Magneto.Text = "Magneto"
        Magneto.UseVisualStyleBackColor = True
        ' 
        ' Garamond
        ' 
        Garamond.AutoSize = True
        Garamond.Location = New Point(11, 45)
        Garamond.Name = "Garamond"
        Garamond.Size = New Size(121, 29)
        Garamond.TabIndex = 0
        Garamond.TabStop = True
        Garamond.Text = "Garamond"
        Garamond.UseVisualStyleBackColor = True
        ' 
        ' ButtonLoadPic
        ' 
        ButtonLoadPic.BackColor = SystemColors.ButtonHighlight
        ButtonLoadPic.Location = New Point(103, 369)
        ButtonLoadPic.Name = "ButtonLoadPic"
        ButtonLoadPic.Size = New Size(186, 56)
        ButtonLoadPic.TabIndex = 26
        ButtonLoadPic.Text = "Load Picture"
        ButtonLoadPic.TextAlign = ContentAlignment.TopLeft
        ButtonLoadPic.UseVisualStyleBackColor = False
        ' 
        ' ButtonExit
        ' 
        ButtonExit.BackColor = SystemColors.ButtonHighlight
        ButtonExit.Location = New Point(604, 375)
        ButtonExit.Name = "ButtonExit"
        ButtonExit.Size = New Size(126, 50)
        ButtonExit.TabIndex = 25
        ButtonExit.Text = "Exit"
        ButtonExit.TextAlign = ContentAlignment.TopLeft
        ButtonExit.UseVisualStyleBackColor = False
        ' 
        ' Red
        ' 
        Red.AutoSize = True
        Red.Location = New Point(29, 119)
        Red.Name = "Red"
        Red.Size = New Size(67, 29)
        Red.TabIndex = 5
        Red.TabStop = True
        Red.Text = "Red"
        Red.UseVisualStyleBackColor = True
        ' 
        ' Blue
        ' 
        Blue.AutoSize = True
        Blue.Location = New Point(29, 72)
        Blue.Name = "Blue"
        Blue.Size = New Size(70, 29)
        Blue.TabIndex = 4
        Blue.TabStop = True
        Blue.Text = "Blue"
        Blue.UseVisualStyleBackColor = True
        ' 
        ' Green
        ' 
        Green.AutoSize = True
        Green.Location = New Point(29, 28)
        Green.Name = "Green"
        Green.Size = New Size(83, 29)
        Green.TabIndex = 3
        Green.TabStop = True
        Green.Text = "Green"
        Green.UseVisualStyleBackColor = True
        ' 
        ' FontColor
        ' 
        FontColor.Controls.Add(Red)
        FontColor.Controls.Add(Blue)
        FontColor.Controls.Add(Green)
        FontColor.Location = New Point(587, 164)
        FontColor.Name = "FontColor"
        FontColor.Size = New Size(170, 187)
        FontColor.TabIndex = 28
        FontColor.TabStop = False
        FontColor.Text = "Font Color"
        ' 
        ' BoldItalic
        ' 
        BoldItalic.AutoSize = True
        BoldItalic.Location = New Point(47, 126)
        BoldItalic.Name = "BoldItalic"
        BoldItalic.Size = New Size(115, 29)
        BoldItalic.TabIndex = 8
        BoldItalic.Text = "Bold Italic"
        BoldItalic.UseVisualStyleBackColor = True
        ' 
        ' Bold
        ' 
        Bold.AutoSize = True
        Bold.Location = New Point(47, 78)
        Bold.Name = "Bold"
        Bold.Size = New Size(74, 29)
        Bold.TabIndex = 7
        Bold.Text = "Bold"
        Bold.UseVisualStyleBackColor = True
        ' 
        ' Italic
        ' 
        Italic.AutoSize = True
        Italic.Location = New Point(47, 35)
        Italic.Name = "Italic"
        Italic.Size = New Size(74, 29)
        Italic.TabIndex = 6
        Italic.Text = "Italic"
        Italic.UseVisualStyleBackColor = True
        ' 
        ' FontStyle
        ' 
        FontStyle.Controls.Add(BoldItalic)
        FontStyle.Controls.Add(Bold)
        FontStyle.Controls.Add(Italic)
        FontStyle.Location = New Point(364, 164)
        FontStyle.Name = "FontStyle"
        FontStyle.Size = New Size(186, 187)
        FontStyle.TabIndex = 29
        FontStyle.TabStop = False
        FontStyle.Text = "Font  Style"
        ' 
        ' PicLoad
        ' 
        PicLoad.Location = New Point(24, 137)
        PicLoad.Name = "PicLoad"
        PicLoad.Size = New Size(304, 226)
        PicLoad.TabIndex = 27
        PicLoad.TabStop = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(FontStyle)
        Controls.Add(FontColor)
        Controls.Add(DisplayText)
        Controls.Add(GroupBox2)
        Controls.Add(PicLoad)
        Controls.Add(ButtonLoadPic)
        Controls.Add(ButtonExit)
        Name = "Form2"
        Text = "Object Demonstrations"
        DisplayText.ResumeLayout(False)
        DisplayText.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        FontColor.ResumeLayout(False)
        FontColor.PerformLayout()
        FontStyle.ResumeLayout(False)
        FontStyle.PerformLayout()
        CType(PicLoad, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DisplayText As GroupBox
    Friend WithEvents sampleTest As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ButtonLoadPic As Button
    Friend WithEvents ButtonExit As Button
    Friend WithEvents Tahoma As RadioButton
    Friend WithEvents Magneto As RadioButton
    Friend WithEvents Garamond As RadioButton
    Friend WithEvents Red As RadioButton
    Friend WithEvents Blue As RadioButton
    Friend WithEvents Green As RadioButton
    Friend WithEvents FontColor As GroupBox
    Friend WithEvents BoldItalic As CheckBox
    Friend WithEvents Bold As CheckBox
    Friend WithEvents Italic As CheckBox
    Friend WithEvents FontStyle As GroupBox
    Friend WithEvents PicLoad As PictureBox
End Class