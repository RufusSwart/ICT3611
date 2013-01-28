Module Module1
    Public user As String
    Public dateTime As String
    Public curdatetime As String
    Public arrData(10, 20) As String
    Public arrErrors As Integer
    Public i As Integer = 0
    Public roomType As String
    Public PaymentradioButtonChanges As Integer
    Public exstra1radioButtonChanges As Integer
    Public exstra2radioButtonChanges As Integer
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

    Function checkAvailability(ByRef room As String, ByRef startDate As String, ByRef endDate As String)
        Dim avStatus As Boolean
        Dim flag As Integer
        Dim full As Boolean
        Dim arrLength As Integer = 0

        arrLength = getArrayLength()
        If arrLength = 0 Then
            flag = 0
        Else
            For z As Integer = 0 To arrLength
                If (arrData(z, 13) = room) Then
                    If (Date.Compare(arrData(z, 14), endDate) <= 0 And Date.Compare(arrData(z, 15), startDate) >= 0) Then
                        flag = flag + 1
                    End If
                End If
            Next
        End If

        If (flag = 10) Then
            full = True
        Else
            full = False
        End If

        If (flag > 0) Then
            avStatus = False
        Else
            avStatus = True
        End If
        Return avStatus
    End Function

    Function getArrayLength()
        Dim len As Integer = 0
        For z As Integer = 0 To 9
            If (arrData(z, 0) IsNot Nothing) Then
                len = len + 1
            End If
        Next
        Return len
    End Function
End Module
