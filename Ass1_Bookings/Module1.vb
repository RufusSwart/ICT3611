Module Module1
    Public user As String
    Public dateTime As String
    Public curdatetime As String
    Function authenticate(ByRef name As String, ByRef pass As String, ByRef time As String) As Boolean
        Dim auth As Boolean

        If ((name = "user1" And pass = "123") Or (name = "user2" And pass = "321") Or (name = "admin" And pass = "admin")) Then
            user = name
            DateTime = time
            auth = True
        Else
            auth = False
        End If

        Return auth
    End Function

    Public Sub logout()
        'Array.Clear(arrData, 0, arrData.Length)
        Form1.TextBox1.Text = ""
        Form1.TextBox2.Text = ""
        'Form1.Label4.Text = ""
        Form1.Show()
    End Sub
End Module
