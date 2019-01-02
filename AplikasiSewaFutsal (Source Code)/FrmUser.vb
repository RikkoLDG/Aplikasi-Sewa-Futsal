Public Class FrmUser
    Sub tampilgrid()
        sqL = "select idptgs, username from msuser"
        Tabel = Proses.ExecuteQuery(sqL)
        dgv1.DataSource = Tabel
    End Sub

    Private Sub FrmUser_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        tampilgrid()
    End Sub
    Private Sub FrmUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cari.Focus()
    End Sub

    Private Sub BtnCari_Click(sender As Object, e As EventArgs) Handles BtnCari.Click
        sqL = "select idptgs, username from msmember where username like" & Aphostrophe("%" & Cari.Text & "%")
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
            With TambahUser
                .idptgs.Text = dgv1.Item(0, dgv1.CurrentRow.Index).Value
                .Show()
                Me.Hide()
            End With
        End If
    End Sub
End Class