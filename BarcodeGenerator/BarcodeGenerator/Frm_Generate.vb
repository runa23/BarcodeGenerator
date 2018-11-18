Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class Frm_Generate

    Private Sub Frm_Generate_Load(sender As Object, e As EventArgs) Handles Me.Load
        OpenConn()
    End Sub

    Private Sub BtnLoad_Click(sender As Object, e As EventArgs) Handles BtnLoad.Click, BtnGenerate.Click
        Dim MyConn As System.Data.OleDb.OleDbConnection
        Dim DTSet As System.Data.DataSet
        Dim Cmd As System.Data.OleDb.OleDbDataAdapter

        Dim browse As New OpenFileDialog
        With browse
            .Filter = "Excel files(*.xlsx)|*.xlsx|Excel files(*.xls)|*.xls|All files (*.*)|*.*"
            .FilterIndex = 1
            .Title = "Import data from Excel"
        End With

        If browse.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim name As String
            name = browse.FileName
            MyConn = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source='" & name & " '; " & "Extended Properties=""Excel 8.0;HDR=YES;IMEX=1""")
            Cmd = New System.Data.OleDb.OleDbDataAdapter("select barcode,model,ukuran from [Aset$]", MyConn)
            Cmd.TableMappings.Add("Table", "Aset")
            DTSet = New DataSet
            Cmd.Fill(DTSet)
            DgAsset.DataSource = DTSet.Tables(0)
            MyConn.Close()
        End If
    End Sub
End Class
