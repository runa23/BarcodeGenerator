Public Class XtraReport1

    Private Sub XtraReport1_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Me.BeforePrint
        ExcelDataSource1.FileName = Frm_Generate.path

    End Sub

    Private Sub XtraReport1_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        Frm_Generate.DgAsset.DataSource = Nothing
    End Sub
End Class