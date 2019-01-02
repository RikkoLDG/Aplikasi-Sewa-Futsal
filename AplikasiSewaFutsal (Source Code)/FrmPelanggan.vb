Public Class FrmPelanggan
    Sub tampilgrid()
        sqL = "select nama, nama_team, status, kode_member, notelp from msmember"
        Tabel = Proses.ExecuteQuery(sqL)
        dgv1.DataSource = Tabel
    End Sub

    Private Sub FrmPelanggan_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        tampilgrid()
    End Sub
    Private Sub FrmPelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cari.Focus()
    End Sub

    Private Sub BtnCari_Click(sender As Object, e As EventArgs) Handles BtnCari.Click
        sqL = "select nama, nama_team, status from msmember where nama like" & Aphostrophe("%" & Cari.Text & "%")
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
                .nama.Text = dgv1.Item(0, dgv1.CurrentRow.Index).Value
                .nama_team.Text = dgv1.Item(1, dgv1.CurrentRow.Index).Value
                .status.Text = dgv1.Item(2, dgv1.CurrentRow.Index).Value
                .kode_member.Text = dgv1.Item(3, dgv1.CurrentRow.Index).Value
                .notelp.Text = dgv1.Item(4, dgv1.CurrentRow.Index).Value
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