Public Class Form4

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f1 As New Form1
        Dim f2 As New Form2
        Me.Hide()
        If currForm = "Form1" Then
            f1.Show()
        End If
        If currForm = "Form2" Then
            f2.Show()
        End If
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Enabled = False
    End Sub
End Class