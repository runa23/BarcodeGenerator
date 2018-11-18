Imports System
Imports System.Data
Imports System.Data.SqlClient
Module Connection
    Public con As New SqlClient.SqlConnection
    Public Sub OpenConn()
        con = New SqlClient.SqlConnection("server=.;database=SIMARF;MultipleActiveResultSets=true;user ID=user;password=user12345")
        ' con = New SqlClient.SqlConnection("Server=192.168.1.201,1433;Database=SIMARF;MultipleActiveResultSets=True;User ID=user;Password=user12345;")
        Try
            con.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub CloseConn()
        If Not IsNothing(con) Then
            con.Close()
        End If
    End Sub
End Module
