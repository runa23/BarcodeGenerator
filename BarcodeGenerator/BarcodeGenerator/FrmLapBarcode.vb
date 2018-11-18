Public Class FrmLapBarcode

    Private Sub FrmLapBarcode_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim report As New GenerateReportvb

        'report.Parameter1.Value = Frm_Generate.kode
        'report.Parameter1.Visible = False
        'report.CreateDocument()
        'DocumentViewer1.DocumentSource = report

        GenerateReportvb1.Parameter1.Value = Frm_Generate.kode
        GenerateReportvb1.Parameter1.Visible = True
        GenerateReportvb1.CreateDocument()
        'DocumentViewer1.DocumentSource = GenerateReportvb1
    End Sub
End Class