Imports System.Text.RegularExpressions

Public Class Form2
    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Hide()
        Form1.Label4.Text = ""
        logout()
    End Sub 'LogOut Click event
    Private Sub ViewBookingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewBookingsToolStripMenuItem.Click
        Dim f3 As New Form3
        Me.Hide()
        f3.Show()
    End Sub 'Show Bookings Click event
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Welcome " + StrConv(user, VbStrConv.ProperCase)
        Label2.Text = "Login Time: " + dateTime
        DateTimePicker1.Value = Now
        DateTimePicker2.Value = DateAdd(DateInterval.Day, 7, Now)
        Label17.Text = ""
        Label21.Text = ""
        Label22.Text = ""
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
        arrErrors = 15
        ErrLabel18.Hide()
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
        ErrLabel18.Show()
        GroupBox6.Show()
        Button1.Show()
        Button2.Show()
        ListBox1.Items.Add("Room 102")
        ListBox1.Items.Add("Room 104")
        ListBox1.Items.Add("Room 106")
        ListBox1.Items.Add("Room 108")
        ListBox1.Items.Add("Room 110")
        roomType = "double"
        arrErrors = 16
        exstra2radioButtonChanges = 0
        PaymentradioButtonChanges = 0
        exstra1radioButtonChanges = 0
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        clearFormData()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim check = checkAllFields()
        Dim roomAvailable As Boolean
        If check = True Then
            Try
                roomAvailable = checkAvailability(ListBox1.SelectedItem.ToString, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date)
                If (roomAvailable = True And full = False) Then
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
                    MsgBox(arrData(i - 1, 13) + " Successfully booked! Thank you :)")
                Else
                    If roomAvailable = False Then
                        Label17.Text = "Room Not Available"
                        Label17.ForeColor = Color.Red
                    End If
                    If full = True Then
                        Label17.Text += vbCrLf & "We are fully booked!"
                    End If
                End If
            Catch ex As Exception
                Label17.Text = "You have not selected a room!"
                ErrLabel13.Text = "*"
            End Try
        Else
            Label17.Text = "Form has errors, please check!"
        End If

    End Sub
    Private Sub TextBox1_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "" Then
            ErrLabel1.Text = "*"
        Else
            ErrLabel1.Text = ""
        End If
    End Sub
    Private Sub TextBox2_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox2.TextChanged
        If TextBox2.Text = "" Then
            ErrLabel2.Text = "*"
        Else
            ErrLabel2.Text = ""
            arrErrors = arrErrors - 1
        End If
    End Sub
    Private Sub TextBox3_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox3.TextChanged
        If TextBox3.Text = "" Then
            ErrLabel3.Text = "*"
        Else
            ErrLabel3.Text = ""
            arrErrors = arrErrors - 1
        End If
    End Sub
    Private Sub TextBox4_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox4.TextChanged
        If TextBox4.Text = "" Then
            ErrLabel4.Text = "*"
        Else
            ErrLabel4.Text = ""
            arrErrors = arrErrors - 1
        End If
    End Sub
    Private Sub TextBox5_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox5.TextChanged
        If TextBox5.Text = "" Then
            ErrLabel5.Text = "*"
        Else
            ErrLabel5.Text = ""
            arrErrors = arrErrors - 1
        End If
    End Sub
    Private Sub TextBox6_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox6.TextChanged
        If TextBox6.Text = "" Then
            ErrLabel6.Text = "*"
        Else
            If Regex.IsMatch(TextBox6.Text, "^[0-9 ]+$") Then
                ErrLabel6.Text = ""
                Label21.Text = ""
                arrErrors = arrErrors - 1
            Else
                Label21.Text = "Postal code must be numbers only"
                ErrLabel6.Text = "*"
            End If
        End If
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ErrLabel7.Text = ""
        arrErrors = arrErrors - 1
    End Sub
    Private Sub TextBox7_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox7.TextChanged
        Dim email = EmailAddressCheck(TextBox7.Text)
        If TextBox7.Text = "" Then
            ErrLabel8.Text = "*"
        Else
            If email = True Then
                ErrLabel8.Text = ""
                arrErrors = arrErrors - 1
            End If
        End If
    End Sub
    Private Sub TextBox8_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox8.TextChanged
        If TextBox8.Text = TextBox7.Text Then
            ErrLabel9.Text = ""
            arrErrors = arrErrors - 1
        Else
            ErrLabel9.Text = "*"
        End If
    End Sub
    Private Sub TextBox9_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox9.TextChanged
        If TextBox9.Text = "" Then
            ErrLabel10.Text = "*"
        Else
            If Regex.IsMatch(TextBox9.Text, "^[0-9 ]+$") Then
                ErrLabel10.Text = ""
                arrErrors = arrErrors - 1
                Label22.Text = ""
            Else
                Label22.Text = "Phone must be numbers only"
                ErrLabel10.Text = "*"
            End If
        End If
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
    Private Sub RadioButton7_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles RadioButton7.CheckedChanged
        ErrLabel18.Text = ""
        If (exstra2radioButtonChanges < 1) Then
            arrErrors = arrErrors - 1
        End If
        exstra2radioButtonChanges = exstra2radioButtonChanges + 1
    End Sub
    Private Sub RadioButton8_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles RadioButton8.CheckedChanged
        ErrLabel18.Text = ""
        If (exstra2radioButtonChanges < 1) Then
            arrErrors = arrErrors - 1
        End If
        exstra2radioButtonChanges = exstra2radioButtonChanges + 1
    End Sub
    Private Sub populateErrorlabels()
        ErrLabel1.Text = "*"
        ErrLabel2.Text = "*"
        ErrLabel3.Text = "*"
        ErrLabel4.Text = "*"
        ErrLabel5.Text = "*"
        ErrLabel6.Text = "*"
        ErrLabel7.Text = "*"
        ErrLabel8.Text = "*"
        ErrLabel9.Text = "*"
        ErrLabel10.Text = "*"
        ErrLabel11.Text = "*"
        ErrLabel12.Text = "*"
        ErrLabel13.Text = "*"
        ErrLabel16.Text = "*"
        ErrLabel17.Text = "*"
        ErrLabel18.Text = "*"
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
        Label22.Text = ""
        Label21.Text = ""
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
    Function checkAllFields()
        Dim fieldFlag As Boolean = False
        If roomType = "single" Then
            If ErrLabel1.Text = "*" Or ErrLabel2.Text = "*" Or ErrLabel3.Text = "*" Or ErrLabel4.Text = "*" Or ErrLabel5.Text = "*" Or ErrLabel6.Text = "*" Or ErrLabel7.Text = "*" Or ErrLabel8.Text = "*" Or ErrLabel9.Text = "*" Or ErrLabel10.Text = "*" Or ErrLabel11.Text = "*" Or ErrLabel12.Text = "*" Or ErrLabel16.Text = "*" Or ErrLabel17.Text = "*" Then
                fieldFlag = False
            Else
                fieldFlag = True
            End If
        Else
            If ErrLabel1.Text = "*" Or ErrLabel2.Text = "*" Or ErrLabel3.Text = "*" Or ErrLabel4.Text = "*" Or ErrLabel5.Text = "*" Or ErrLabel6.Text = "*" Or ErrLabel7.Text = "*" Or ErrLabel8.Text = "*" Or ErrLabel9.Text = "*" Or ErrLabel10.Text = "*" Or ErrLabel11.Text = "*" Or ErrLabel12.Text = "*" Or ErrLabel16.Text = "*" Or ErrLabel17.Text = "*" Or ErrLabel18.Text = "*" Then
                fieldFlag = False
            Else
                fieldFlag = True
            End If
        End If

        If DateTimePicker2.Value < DateTimePicker1.Value Then
            fieldFlag = False
            If Label21.Text = "" And Label21.Text <> "Departure date must be after Arrival date!" And Label22.Text <> "Departure date must be after Arrival date!" Then
                Label21.Text = "Departure date must be after Arrival date!"
            Else
                If Label22.Text = "" And Label22.Text <> "Departure date must be after Arrival date!" And Label21.Text <> "Departure date must be after Arrival date!" Then
                    Label22.Text = "Departure date must be after Arrival date!"
                Else
                    Label17.Text += "Departure date must be after Arrival date!"
                End If
            End If
        Else
            If Label22.Text = "Departure date must be after Arrival date!" Then
                Label22.Text = ""
            End If

            If Label21.Text = "Departure date must be after Arrival date!" Then
                Label21.Text = ""
            End If
        End If

            Return fieldFlag
    End Function
    Function EmailAddressCheck(ByVal emailAddress As String) As Boolean

        Dim pattern As String = "^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" + "\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" + ".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"
        Dim emailAddressMatch As Match = Regex.Match(emailAddress, pattern)
        If emailAddressMatch.Success Then
            EmailAddressCheck = True
        Else
            EmailAddressCheck = False
        End If
        Return EmailAddressCheck
    End Function
    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        Dim f4 As New Form4
        currForm = "Form2"
        Me.Hide()
        f4.Show()
    End Sub
End Class