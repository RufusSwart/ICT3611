Public Class Form1

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        curdatetime = DateString + " - - " + TimeString
        Label3.Text = curdatetime
        Label4.Text = ""
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label3.Text = DateString + " - - " + TimeString
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f2 As New Form2
        If (authenticate(TextBox1.Text.ToLower(), TextBox2.Text, curdatetime)) Then
            Me.Hide()
            f2.Show()
        Else
            Label4.Text = "Unknown User Name or bad password."
        End If
    End Sub
End Class
