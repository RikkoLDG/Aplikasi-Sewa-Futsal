Public Class report_jadwal

    Private Sub report_jadwal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'futsal2DataSet2.View_Jadwal' table. You can move, or remove it, as needed.
        Me.View_JadwalTableAdapter.Fill(Me.futsal2DataSet2.View_Jadwal)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class