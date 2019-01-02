Public Class report_transaksi

    Private Sub report_transaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'futsal2DataSet1.View_transaksi' table. You can move, or remove it, as needed.
        Me.View_transaksiTableAdapter.Fill(Me.futsal2DataSet1.View_transaksi)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class