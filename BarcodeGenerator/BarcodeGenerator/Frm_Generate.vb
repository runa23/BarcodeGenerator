Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class Frm_Generate
    Public kode As String
    Private Sub Frm_Generate_Load(sender As Object, e As EventArgs) Handles Me.Load
        OpenConn()
    End Sub

    Private Sub BtnLoad_Click(sender As Object, e As EventArgs) Handles BtnLoad.Click
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

    Private Sub BtnGenerate_Click(sender As Object, e As EventArgs) Handles BtnGenerate.Click
        Dim dt As New DataTable
        Dim ds As New DataSet

        With dt
            .Columns.Add("Barcode")
            .Columns.Add("Model")
            .Columns.Add("Ukuran")
        End With

        For Each dr As DataGridViewRow In DgAsset.Rows
            dt.Rows.Add(dr.Cells(0).Value, dr.Cells(1).Value, dr.Cells(2).Value)
            If kode = "" Then
                kode = dr.Cells(0).Value
            Else
                kode = kode & "," & dr.Cells(0).Value
            End If

        Next

        FrmLapBarcode.Show()

    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        DgAsset.DataSource = Nothing
    End Sub
End Class
