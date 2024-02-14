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
        Buttonexit = New Button()
        Buttonload = New Button()
        SuspendLayout()
        ' 
        ' Buttonexit
        ' 
        Buttonexit.BackColor = SystemColors.ButtonHighlight
        Buttonexit.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Buttonexit.Location = New Point(445, 275)
        Buttonexit.Name = "Buttonexit"
        Buttonexit.Size = New Size(241, 72)
        Buttonexit.TabIndex = 3
        Buttonexit.Text = "EXIT"
        Buttonexit.TextAlign = ContentAlignment.TopLeft
        Buttonexit.UseVisualStyleBackColor = False
        ' 
        ' Buttonload
        ' 
        Buttonload.BackColor = SystemColors.ButtonHighlight
        Buttonload.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Buttonload.Location = New Point(73, 268)
        Buttonload.Name = "Buttonload"
        Buttonload.Size = New Size(241, 82)
        Buttonload.TabIndex = 2
        Buttonload.Text = "Load Object Demo"
        Buttonload.TextAlign = ContentAlignment.TopLeft
        Buttonload.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(800, 450)
        Controls.Add(Buttonexit)
        Controls.Add(Buttonload)
        Name = "Form1"
        Text = "Welcoming Form"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Buttonexit As Button
    Friend WithEvents Buttonload As Button

End Class
