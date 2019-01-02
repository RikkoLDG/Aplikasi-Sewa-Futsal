Public Class FrLaporan

    Private Sub BtnMenu_Click(sender As Object, e As EventArgs) Handles BtnMenu.Click
        Me.Close()
        Main_FromNew.Show()
    End Sub

    Private Sub LpMember_Click(sender As Object, e As EventArgs) Handles LpMember.Click
        report.Show()
    End Sub

    Private Sub LpPetugas_Click(sender As Object, e As EventArgs) Handles LpPetugas.Click
        report_petugas.Show()
    End Sub

    Private Sub LpLapagan_Click(sender As Object, e As EventArgs) Handles LpLapagan.Click
        report_lapangan.Show()
    End Sub

    Private Sub Lptransaksi_Click(sender As Object, e As EventArgs) Handles Lptransaksi.Click
        report_transaksi.Show()
    End Sub
End Class