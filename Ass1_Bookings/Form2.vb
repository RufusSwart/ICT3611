﻿Public Class Form2

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Hide()
        logout()
    End Sub 'LogOut Click event
    Private Sub ViewBookingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewBookingsToolStripMenuItem.Click
        Me.Hide()
        Form3.Show()
    End Sub 'Show Bookings Click event

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Welcome " + user
        Label2.Text = "Login Time: " + dateTime
        Label17.Text = ""
        GroupBox1.Hide()
        GroupBox2.Hide()
        GroupBox3.Hide()
        GroupBox4.Hide()
        GroupBox7.Hide()
        Button1.Hide()
        Button2.Hide()
        populateErrorlabels()
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
        roomType = "single"
        arrErrors = 17
        PaymentradioButtonChanges = 0
        exstra1radioButtonChanges = 0
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
        roomType = "double"
        arrErrors = 18
        exstra2radioButtonChanges = 0
        PaymentradioButtonChanges = 0
        exstra1radioButtonChanges = 0
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        clearFormData()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim roomAvailable = checkAvailability(ListBox1.SelectedItem.ToString, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date)
        If (roomAvailable = True And arrErrors <= 0) Then
            Label17.Text = "Room Available"
            Label17.ForeColor = Color.Green
            arrData(i, 0) = user
            arrData(i, 1) = Now
            arrData(i, 2) = TextBox1.Text
            arrData(i, 3) = TextBox2.Text
            arrData(i, 4) = TextBox3.Text
            arrData(i, 5) = TextBox4.Text
            arrData(i, 6) = TextBox5.Text
            arrData(i, 7) = TextBox6.Text
            arrData(i, 8) = ComboBox1.SelectedItem.ToString
            arrData(i, 9) = TextBox7.Text
            arrData(i, 10) = TextBox9.Text
            arrData(i, 11) = ComboBox2.SelectedItem.ToString
            arrData(i, 12) = ComboBox3.SelectedItem.ToString
            arrData(i, 13) = ListBox1.SelectedItem.ToString
            arrData(i, 14) = DateTimePicker1.Value.Date
            arrData(i, 15) = DateTimePicker2.Value.Date

            If (RadioButton1.Checked) Then
                arrData(i, 16) = RadioButton1.Text
            End If

            If (RadioButton2.Checked) Then
                arrData(i, 16) = RadioButton2.Text
            End If

            If (RadioButton3.Checked) Then
                arrData(i, 16) = RadioButton3.Text
            End If

            If (RadioButton4.Checked) Then
                arrData(i, 16) = RadioButton4.Text
            End If

            If (RadioButton5.Checked) Then
                arrData(i, 17) = RadioButton5.Text
            End If

            If (RadioButton6.Checked) Then
                arrData(i, 17) = RadioButton6.Text
            End If

            If (roomType = "double") Then
                If (RadioButton7.Checked) Then
                    arrData(i, 18) = RadioButton7.Text
                End If

                If (RadioButton8.Checked) Then
                    arrData(i, 18) = RadioButton8.Text
                End If
            Else
                arrData(i, 18) = "null"
            End If

            i = i + 1
            Label18.Show()
            GroupBox1.Hide()
            GroupBox2.Hide()
            GroupBox3.Hide()
            GroupBox4.Hide()
            GroupBox7.Hide()
            Button1.Hide()
            Button2.Hide()
            clearFormData()
        Else
            If roomAvailable = False Then
                Label17.Text = "Room Not Available"
                Label17.ForeColor = Color.Red
            End If
            If arrErrors > 0 Then
                Dim a As Integer
                a = arrErrors
                Label17.Text += " Form has errors, please check!"
            End If
        End If
    End Sub
    Private Sub TextBox1_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox1.TextChanged
        ErrLabel1.Text = ""
        arrErrors = arrErrors - 1
    End Sub
    Private Sub TextBox2_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox2.TextChanged
        ErrLabel2.Text = ""
        arrErrors = arrErrors - 1
    End Sub
    Private Sub TextBox3_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox3.TextChanged
        ErrLabel3.Text = ""
        arrErrors = arrErrors - 1
    End Sub
    Private Sub TextBox4_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox4.TextChanged
        ErrLabel4.Text = ""
        arrErrors = arrErrors - 1
    End Sub
    Private Sub TextBox5_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox5.TextChanged
        ErrLabel5.Text = ""
        arrErrors = arrErrors - 1
    End Sub
    Private Sub TextBox6_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox6.TextChanged
        ErrLabel6.Text = ""
        arrErrors = arrErrors - 1
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ErrLabel7.Text = ""
        arrErrors = arrErrors - 1
    End Sub
    Private Sub TextBox7_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox7.TextChanged
        ErrLabel8.Text = ""
        arrErrors = arrErrors - 1
    End Sub
    Private Sub TextBox8_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox8.TextChanged
        ErrLabel9.Text = ""
        arrErrors = arrErrors - 1
    End Sub
    Private Sub TextBox9_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox9.TextChanged
        ErrLabel10.Text = ""
        arrErrors = arrErrors - 1
    End Sub
    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        ErrLabel11.Text = ""
        arrErrors = arrErrors - 1
    End Sub
    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        ErrLabel12.Text = ""
        arrErrors = arrErrors - 1
    End Sub
    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ListBox1.SelectedIndexChanged
        ErrLabel13.Text = ""
        arrErrors = arrErrors - 1
    End Sub
    Private Sub DateTimePicker1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles DateTimePicker1.ValueChanged
        ErrLabel14.Text = ""
        arrErrors = arrErrors - 1
    End Sub
    Private Sub DateTimePicker2_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles DateTimePicker2.ValueChanged
        ErrLabel15.Text = ""
        arrErrors = arrErrors - 1
    End Sub
    Private Sub RadioButton1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles RadioButton1.CheckedChanged
        ErrLabel16.Text = ""
        If (PaymentradioButtonChanges < 1) Then
            arrErrors = arrErrors - 1
        End If
        PaymentradioButtonChanges = PaymentradioButtonChanges + 1
    End Sub
    Private Sub RadioButton2_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles RadioButton2.CheckedChanged
        ErrLabel16.Text = ""
        If (PaymentradioButtonChanges < 1) Then
            arrErrors = arrErrors - 1
        End If
        PaymentradioButtonChanges = PaymentradioButtonChanges + 1
    End Sub
    Private Sub RadioButton3_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles RadioButton3.CheckedChanged
        ErrLabel16.Text = ""
        If (PaymentradioButtonChanges < 1) Then
            arrErrors = arrErrors - 1
        End If
        PaymentradioButtonChanges = PaymentradioButtonChanges + 1
    End Sub
    Private Sub RadioButton4_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles RadioButton4.CheckedChanged
        ErrLabel16.Text = ""
        If (PaymentradioButtonChanges < 1) Then
            arrErrors = arrErrors - 1
        End If
        PaymentradioButtonChanges = PaymentradioButtonChanges + 1
    End Sub
    Private Sub RadioButton5_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles RadioButton5.CheckedChanged
        ErrLabel17.Text = ""
        If (exstra1radioButtonChanges < 1) Then
            arrErrors = arrErrors - 1
        End If
        exstra1radioButtonChanges = exstra1radioButtonChanges + 1
    End Sub
    Private Sub RadioButton6_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles RadioButton6.CheckedChanged
        ErrLabel17.Text = ""
        If (exstra1radioButtonChanges < 1) Then
            arrErrors = arrErrors - 1
        End If
        exstra1radioButtonChanges = exstra1radioButtonChanges + 1
    End Sub
    Private Sub populateErrorlabels()
        ErrLabel1.Text = "Error!"
        ErrLabel2.Text = "Error!"
        ErrLabel3.Text = "Error!"
        ErrLabel4.Text = "Error!"
        ErrLabel5.Text = "Error!"
        ErrLabel6.Text = "Error!"
        ErrLabel7.Text = "Error!"
        ErrLabel8.Text = "Error!"
        ErrLabel9.Text = "Error!"
        ErrLabel10.Text = "Error!"
        ErrLabel11.Text = "Error!"
        ErrLabel12.Text = "Error!"
        ErrLabel13.Text = "Error!"
        ErrLabel14.Text = "Error!"
        ErrLabel15.Text = "Error!"
        ErrLabel16.Text = "Error!"
        ErrLabel17.Text = "Error!"
        ErrLabel18.Text = "Error!"
    End Sub

    Private Sub clearFormData()
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
        PaymentradioButtonChanges = 0
        arrErrors = 0
        populateErrorlabels()
    End Sub

End Class