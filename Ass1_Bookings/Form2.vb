Public Class Form2

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Hide()
        logout()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Welcome " + user
        Label2.Text = "Login Time: " + dateTime
        GroupBox1.Hide()
        GroupBox2.Hide()
        GroupBox3.Hide()
        GroupBox4.Hide()
        Button1.Hide()
        Button2.Hide()
    End Sub

    Private Sub SingleBookingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SingleBookingToolStripMenuItem.Click
        GroupBox1.Show()
        GroupBox2.Show()
        GroupBox3.Show()
        GroupBox4.Show()
        GroupBox6.Hide()
        Button1.Show()
        Button2.Show()
        Button2.Show()
    End Sub

    Private Sub DoubbleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DoubbleToolStripMenuItem.Click
        GroupBox1.Show()
        GroupBox2.Show()
        GroupBox3.Show()
        GroupBox4.Show()
        Button1.Show()
        Button2.Show()
    End Sub
End Class