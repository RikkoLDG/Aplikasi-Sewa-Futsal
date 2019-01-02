Public Class TambahUser
    Dim tambah As Boolean
    Dim nomor As String
    Sub isihak()
        hak.Items.Clear()
        hak.Items.Add("Karyawan")
        hak.Items.Add("Admin")
        hak.SelectedIndex = 0
    End Sub
    Sub tampilgrid()
        sqL = "select * from msuser"
        Tabel = Proses.ExecuteQuery(sqL)
        dgv1.DataSource = Tabel
    End Sub
    Sub kosong()
        idptgs.Clear()
        username.Clear()
        password.Clear()
        hak.Items.Clear()
        username.Focus()
    End Sub
    Sub BtnAwal()
        Btn1.Text = "Tambah"
        Btn2.Text = "Edit"
        Btn3.Text = "Hapus"
        Btn1.Visible = True
    End Sub
    Sub BtnSimpan()
        Btn1.Visible = False
        Btn2.Text = "Simpan"
        Btn3.Text = "Batal"
    End Sub
    Sub tutup()
        idptgs.Enabled = False
        username.Enabled = False
        password.Enabled = False
        hak.Enabled = False
    End Sub
    Sub buka()
        idptgs.Enabled = False
        username.Enabled = True
        password.Enabled = True
        hak.Enabled = True
    End Sub
    Sub isi()
        With dgv1
            isihak()
            If .RowCount > 0 Then
                idptgs.Text = .Item("idptgs", .CurrentRow.Index).Value
                username.Text = .Item("username", .CurrentRow.Index).Value
                password.Text = .Item("password", .CurrentRow.Index).Value
                Dim hak1 As String = .Item(3, .CurrentRow.Index).Value
                For i = 0 To hak.Items.Count - 1
                    Dim hak2 As String = hak.Items(i).ToString
                    If UCase(Trim(hak2)) = UCase(Trim(hak1)) Then
                        hak.SelectedIndex = i
                    End If
                Next
            End If
        End With
    End Sub
    Sub AutoNo()
        sqL = "select idptgs from msuser order by idptgs desc"
        Tabel = Proses.ExecuteQuery(sqL)
        If Tabel.Rows.Count = 0 Then
            nomor = "PG001"
        Else
            Dim nom As String = Microsoft.VisualBasic.Right(Trim(Tabel.Rows(0).Item(0).ToString), 3)
            Dim urut As String = Val(nom) + 1
            nom = urut
            Dim panjang As Byte = Len(nom)
            nomor = "PG" & Microsoft.VisualBasic.Right("000" & urut, 3)
        End If
        idptgs.Text = nomor
    End Sub
    Private Sub TambahUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnAwal()
        tampilgrid()
        tutup()
        kosong()
        username.Focus()
    End Sub

    Private Sub dgv1_Click(sender As Object, e As EventArgs)
        isi()
    End Sub

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        kosong()
        BtnAwal()
        BtnSimpan()
        AutoNo()
        tambah = True
        isihak()
        buka()
        username.Focus()
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        If Btn2.Text = "Edit" Then
            If dgv1.RowCount > 0 Then
                BtnSimpan()
                tambah = False
                isi()
                buka()
                username.Focus()
            Else
                MsgBox("Data masih kosong", vbInformation, "Isi data dahulu")
            End If
        Else
            If idptgs.Text = "" Or username.Text = "" Or password.Text = "" Or hak.Text = "" Then
                MsgBox("Data belum lengkap", vbInformation, "Isi data dahulu")
            Else
                If tambah = True Then
                    sqL = "insert into msuser (idptgs, username, password, hak)values(" & Aphostrophe(idptgs.Text) &
                        "," & Aphostrophe(username.Text) &
                        "," & Aphostrophe(password.Text) &
                        "," & Aphostrophe(hak.Text) & ")"
                    Proses.ExecuteNonQuery(sqL)
                Else
                    sqL = "Update msuser set idptgs=" & Aphostrophe(idptgs.Text) &
                        ", username=" & Aphostrophe(username.Text) &
                        ", password=" & Aphostrophe(password.Text) &
                        ", hak=" & Aphostrophe(hak.Text) &
                        "where idptgs=" & Aphostrophe(idptgs.Text)
                    Proses.ExecuteNonQuery(sqL)
                End If
                MsgBox("Data berhasil disimpan", vbInformation, "Notifikasi")
                BtnAwal()
                tampilgrid()
                kosong()
                tutup()
                username.Focus()
            End If
            End If
    End Sub

    Private Sub carimember_Click(sender As Object, e As EventArgs) Handles carimember.Click
        FrmUser.Show()
        Me.Hide()
    End Sub
    Private Sub dgv1_Click1(sender As Object, e As EventArgs) Handles dgv1.Click
        isi()
    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        If Btn3.Text = "Batal" Then
            BtnAwal()
            tutup()
            kosong()
        Else
            If idptgs.Text <> "" Then
                Dim tny As String = MsgBox("Yakin ingin menghapus data ?", vbYesNo + vbInformation, "konfirmasi")
                If tny = vbYes Then
                    sqL = "delete from msuser where idptgs='" & idptgs.Text & "'"
                    Proses.ExecuteNonQuery(sqL)
                    MsgBox("Data berhasil hapus", vbInformation, "Data sukses")
                    BtnAwal()
                    tampilgrid()
                    isihak()
                    tutup()
                    kosong()
                    nomor = ""
                End If
            End If
        End If
    End Sub
End Class