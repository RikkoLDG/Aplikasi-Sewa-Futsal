Public Class report_lapangan

    Private Sub report_lapangan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'futsal2DataSet.mslapangan' table. You can move, or remove it, as needed.
        Me.mslapanganTableAdapter.Fill(Me.futsal2DataSet.mslapangan)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class