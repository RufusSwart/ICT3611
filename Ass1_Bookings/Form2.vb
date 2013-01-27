Public Class Form2

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Hide()
        logout()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Welcome " + user
        Label2.Text = "Login Time: " + dateTime
        Label17.Text = "Please fill all detail in."
        Label19.Text = ""
        GroupBox1.Hide()
        GroupBox2.Hide()
        GroupBox3.Hide()
        GroupBox4.Hide()
        GroupBox7.Hide()
        Button1.Hide()
        Button2.Hide()

    End Sub

    Private Sub SingleBookingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SingleBookingToolStripMenuItem.Click
        Label18.Hide()
        GroupBox1.Show()
        GroupBox2.Show()
        GroupBox3.Show()
        GroupBox4.Show()
        GroupBox6.Hide()
        GroupBox7.Show()
        Button1.Show()
        Button2.Show()
        Button2.Show()
        ListBox1.Items.Clear()
        ListBox1.Items.Add("Room 101")
        ListBox1.Items.Add("Room 103")
        ListBox1.Items.Add("Room 105")
        ListBox1.Items.Add("Room 107")
        ListBox1.Items.Add("Room 109")
    End Sub

    Private Sub DoubbleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DoubbleToolStripMenuItem.Click
        Label18.Hide()
        ListBox1.Items.Clear()
        GroupBox1.Show()
        GroupBox2.Show()
        GroupBox3.Show()
        GroupBox4.Show()
        GroupBox7.Show()
        Button1.Show()
        Button2.Show()
        ListBox1.Items.Add("Room 102")
        ListBox1.Items.Add("Room 104")
        ListBox1.Items.Add("Room 106")
        ListBox1.Items.Add("Room 108")
        ListBox1.Items.Add("Room 110")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        ComboBox1.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1
        ComboBox3.SelectedIndex = -1
        DateTimePicker1.Value = Now
        DateTimePicker2.Value = Now
        ListBox1.SelectedIndex = -1
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        RadioButton5.Checked = False
        RadioButton6.Checked = False
        RadioButton7.Checked = False
        RadioButton8.Checked = False
        Label17.Text = ""
    End Sub
End Class