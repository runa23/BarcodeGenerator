Imports System.Data.Sql
Imports System.Data.SqlClient
Imports DevExpress.DataAccess.Excel
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.Configuration

Public Class Frm_Generate
    Public kode As String
    Public path As String
    Private Sub Frm_Generate_Load(sender As Object, e As EventArgs) Handles Me.Load
        OpenConn()
        BtnGenerate.Enabled = False
        BtnClear.Enabled = False
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

            path = System.IO.Path.GetFullPath(browse.FileName)
            name = browse.FileName
            MyConn = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source='" & name & " '; " & "Extended Properties=""Excel 8.0;HDR=YES;IMEX=1""")
            Cmd = New System.Data.OleDb.OleDbDataAdapter("select barcode,model,ukuran from [Aset$]", MyConn)
            Cmd.TableMappings.Add("Table", "Aset")
            DTSet = New DataSet
            Cmd.Fill(DTSet)
            DgAsset.DataSource = DTSet.Tables(0)

            MyConn.Close()
        End If

        BtnGenerate.Enabled = True
        BtnClear.Enabled = True
        BtnLoad.Enabled = False
    End Sub

    Private Sub BtnGenerate_Click(sender As Object, e As EventArgs) Handles BtnGenerate.Click
        Dim report As New XtraReport1
        Dim excelDataSource As New ExcelDataSource
        Dim excelWorksheet As New ExcelWorksheetSettings
        Dim excelSourceOptions As New ExcelSourceOptions
        Dim detailband As New DetailBand

        excelDataSource.FileName = path
        excelWorksheet.WorksheetName = "Aset"
        excelSourceOptions.ImportSettings = excelWorksheet
        excelSourceOptions.SkipHiddenColumns = True
        excelSourceOptions.SkipHiddenRows = True
        excelDataSource.SourceOptions = excelSourceOptions

        report.DataSource = excelDataSource

        report.ShowPreview()

    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        DgAsset.DataSource = Nothing
        BtnGenerate.Enabled = False
        BtnClear.Enabled = False
        BtnLoad.Enabled = True
    End Sub

    Private Sub BtnKeluar_Click(sender As Object, e As EventArgs) Handles BtnKeluar.Click
        Application.Exit()
    End Sub
End Class
