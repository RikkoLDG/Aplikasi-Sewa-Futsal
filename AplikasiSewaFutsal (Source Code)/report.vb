Public Class report

    Private Sub report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'futsal2DataSet.msmember' table. You can move, or remove it, as needed.
        Me.msmemberTableAdapter.Fill(Me.futsal2DataSet.msmember)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class