Imports System.Windows.Forms
Public Class Form1
    Private Sub Buttonload_Click(sender As Object, e As EventArgs) Handles Buttonload.Click
        Dim form2Instance As New Form2()
        form2Instance.Show()
    End Sub
    Private Sub Buttonexit_Click(sender As Object, e As EventArgs) Handles Buttonexit.Click
        Application.Exit()
    End Sub
    Private Sub Form2_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        WindowState = FormWindowState.Maximized
        BackColor = Color.Red
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class