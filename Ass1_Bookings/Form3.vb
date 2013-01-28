Public Class Form3

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        numbookings = getArrayLength()

        If (numbookings = 0) Then
            Label1.Text = "No Current bookings"
            DataGridView1.Hide()

        Else
            DataGridView1.Show()
            Try
                Dim dt As New DataTable()

                dt.Columns.Add("First Name", Type.GetType("System.String"))

                dt.Columns.Add("Last Name", Type.GetType("System.String"))

                dt.Columns.Add("Address", Type.GetType("System.String"))

                dt.Columns.Add("City", Type.GetType("System.String"))

                dt.Columns.Add("State/Provance", Type.GetType("System.String"))

                dt.Columns.Add("Postal/Zip Code", Type.GetType("System.String"))

                dt.Columns.Add("Country", Type.GetType("System.String"))

                dt.Columns.Add("E-Mail", Type.GetType("System.String"))

                dt.Columns.Add("Phone", Type.GetType("System.String"))

                dt.Columns.Add("Number of Adults", Type.GetType("System.String"))

                dt.Columns.Add("Number of Kids", Type.GetType("System.String"))

                dt.Columns.Add("Room Number", Type.GetType("System.String"))

                dt.Columns.Add("Room Type", Type.GetType("System.String"))

                dt.Columns.Add("Arrival Date", Type.GetType("System.String"))

                dt.Columns.Add("Departure Date", Type.GetType("System.String"))

                dt.Columns.Add("Payment Method", Type.GetType("System.String"))

                dt.Columns.Add("Additional Requests", Type.GetType("System.String"))

                For i As Integer = 0 To numbookings

                    dt.Rows.Add()

                    dt.Rows(dt.Rows.Count - 1)("First Name") = arrData(i, 2)

                    dt.Rows(dt.Rows.Count - 1)("Last Name") = arrData(i, 3)

                    dt.Rows(dt.Rows.Count - 1)("Address") = arrData(i, 4)

                    dt.Rows(dt.Rows.Count - 1)("City") = arrData(i, 5)

                    dt.Rows(dt.Rows.Count - 1)("State/Provance") = arrData(i, 6)

                    dt.Rows(dt.Rows.Count - 1)("Postal/Zip code") = arrData(i, 7)

                    dt.Rows(dt.Rows.Count - 1)("Country") = arrData(i, 8)

                    dt.Rows(dt.Rows.Count - 1)("E-Mail") = arrData(i, 9)

                    dt.Rows(dt.Rows.Count - 1)("Phone") = arrData(i, 10)

                    dt.Rows(dt.Rows.Count - 1)("Number of Adults") = arrData(i, 11)

                    dt.Rows(dt.Rows.Count - 1)("Number of Kids") = arrData(i, 12)

                    dt.Rows(dt.Rows.Count - 1)("Room Number") = arrData(i, 13)

                    dt.Rows(dt.Rows.Count - 1)("Room Type") = roomType

                    dt.Rows(dt.Rows.Count - 1)("Arrival Date") = arrData(i, 14)

                    dt.Rows(dt.Rows.Count - 1)("Departure Date") = arrData(i, 15)

                    dt.Rows(dt.Rows.Count - 1)("Payment Method") = arrData(i, 16)

                    If (roomType = "double") Then

                        dt.Rows(dt.Rows.Count - 1)("Additional Requests") = arrData(i, 17) + " " + arrData(i, 18)

                    Else
                        dt.Rows(dt.Rows.Count - 1)("Additional Requests") = arrData(i, 17)
                    End If
                    Label1.Text = ""
                Next

                DataGridView1.DataSource = dt
            Catch ex As Exception
                Label1.Text = ex.ToString
            End Try
        End If
    End Sub
End Class