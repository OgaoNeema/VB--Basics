Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports System.Drawing


Public Class Form2
    Private Sub font_Enter(sender As Object, e As EventArgs) Handles Garamond.CheckedChanged,
        Magneto.CheckedChanged, Tahoma.CheckedChanged

        If Garamond.Checked Then
            sampleTest.Font = New Font("Garamond", sampleTest.Font.Size)
        ElseIf Magneto.Checked Then
            sampleTest.Font = New Font("Magneto", sampleTest.Font.Size)
        ElseIf Tahoma.Checked Then
            sampleTest.Font = New Font("Tahoma", sampleTest.Font.Size)
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonLoadPic.Click
        PicLoad.Image = My.Resources.edit1
    End Sub

    Private Sub fontColor_Enter(sender As Object, e As EventArgs) Handles Green.CheckedChanged, Blue.CheckedChanged, Red.CheckedChanged
        If Green.Checked Then
            sampleTest.ForeColor = Color.Green
        ElseIf blue.Checked Then
            sampleTest.ForeColor = Color.Blue
        ElseIf red.Checked Then
            sampleTest.ForeColor = Color.Red
        End If

    End Sub
    Private Sub extbutton_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Me.Close()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class