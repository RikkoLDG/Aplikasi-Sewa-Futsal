Public Class PilihLapangan
    Sub tampilgrid()
        sqL = "select nama_lpgn, jenis_lpgn, kelas, harga_sewa, kode_lpgn from mslapangan"
        Tabel = Proses.ExecuteQuery(sqL)
        dgv1.DataSource = Tabel
    End Sub

    Private Sub PilihLapangan_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        tampilgrid()
    End Sub
    Private Sub PilihLapangan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cari.Focus()
    End Sub

    Private Sub BtnCari_Click(sender As Object, e As EventArgs) Handles BtnCari.Click
        sqL = "select nama_lpgn, jenis_lpgn, kelas, harga_sewa, kode_lpgn from mslapangan nama_lpgn like" & Aphostrophe("%" & Cari.Text & "%")
        Tabel = Proses.ExecuteQuery(sqL)
        If Tabel.Rows.Count > 0 Then
            MsgBox("Data Ditemukan" & Tabel.Rows.Count, vbInformation, "Notifikasi")
            dgv1.DataSource = Tabel
        Else
            MsgBox("Data Tidak Ditemukan" & Tabel.Rows.Count, vbInformation, "Notifikasi")
        End If
    End Sub
    Private Sub dgv1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellContentDoubleClick
        If dgv1.RowCount > 0 Then
            With Booking
                .kode_lpgn.Text = dgv1.Item("kode_lpgn", dgv1.CurrentRow.Index).Value
                .harga_sewa_total.Text = dgv1.Item("harga_sewa", dgv1.CurrentRow.Index).Value
                .harga_awal.Text = dgv1.Item("harga_sewa", dgv1.CurrentRow.Index).Value
                .Show()
                Me.Hide()
            End With
        End If
    End Sub

    Private Sub Batal_Click(sender As Object, e As EventArgs) Handles Batal.Click
        Me.Close()
        Booking.Show()
    End Sub
End Class