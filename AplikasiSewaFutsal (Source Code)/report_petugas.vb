Public Class report_petugas

    Private Sub report_petugas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'futsal2DataSet.mspetugas' table. You can move, or remove it, as needed.
        Me.mspetugasTableAdapter.Fill(Me.futsal2DataSet.mspetugas)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class