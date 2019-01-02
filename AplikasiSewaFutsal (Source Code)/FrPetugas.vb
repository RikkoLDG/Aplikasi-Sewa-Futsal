Public Class FrPetugas
    Dim tambah As Boolean
    Dim nomor As String
    Sub tampilgrid()
        sqL = "select * from mspetugas"
        Tabel = Proses.ExecuteQuery(sqL)
        dgv1.DataSource = Tabel
    End Sub
    Sub isijenkel()
        jenkel.Items.Clear()
        jenkel.Items.Add("Pria")
        jenkel.Items.Add("Wanita")
        jenkel.SelectedIndex = 0
    End Sub
    Sub isihak()
        hak.Items.Clear()
        hak.Items.Add("Karyawan")
        hak.Items.Add("Admin")
        hak.SelectedIndex = 0
    End Sub
    Sub isicari()
        berdasarkan.Items.Clear()
        berdasarkan.Items.Add("ID Petugas")
        berdasarkan.Items.Add("Nama")
        berdasarkan.SelectedIndex = 0
    End Sub
    Sub kosong()
        idptgs.Clear()
        nama.Clear()
        jenkel.Items.Clear()
        alamat.Clear()
        divisi.Clear()
        notelp_ptgs.Clear()
        username.Clear()
        password.Clear()
        hak.Items.Clear()
        nama.Focus()
    End Sub
    Sub BtnAwal()
        Btn1.Text = "Tambah"
        Btn2.Text = "Edit"
        Btn3.Text = "Hapus"
        Btn4.Text = "Batal"
        Btn1.Visible = True
        Btn3.Visible = True
        dgv1.Enabled = False
    End Sub
    Sub BtnSimpan()
        Btn1.Visible = False
        Btn3.Visible = False
        Btn2.Text = "Simpan"
        Btn3.Text = "Batal"
        Btn4.Text = "Batal"
    End Sub
    Sub tutup()
        idptgs.Enabled = False
        nama.Enabled = False
        jenkel.Enabled = False
        alamat.Enabled = False
        divisi.Enabled = False
        notelp_ptgs.Enabled = False
        username.Enabled = False
        password.Enabled = False
        hak.Enabled = False
        dgv1.Enabled = True
    End Sub
    Sub buka()
        idptgs.Enabled = False
        nama.Enabled = True
        jenkel.Enabled = True
        alamat.Enabled = True
        divisi.Enabled = True
        notelp_ptgs.Enabled = True
        username.Enabled = True
        password.Enabled = True
        hak.Enabled = True
    End Sub
    Sub isi()
        With dgv1
            isijenkel()
            isihak()
            If .RowCount > 0 Then
                idptgs.Text = .Item("idptgs", .CurrentRow.Index).Value
                nama.Text = .Item("nama", .CurrentRow.Index).Value
                Dim jenkel1 As String = .Item(2, .CurrentRow.Index).Value
                For i = 0 To jenkel.Items.Count - 1
                    Dim jenkel2 As String = jenkel.Items(i).ToString
                    If UCase(Trim(jenkel2)) = UCase(Trim(jenkel1)) Then
                        jenkel.SelectedIndex = i
                    End If
                Next
                alamat.Text = .Item("alamat", .CurrentRow.Index).Value
                divisi.Text = .Item("divisi", .CurrentRow.Index).Value
                notelp_ptgs.Text = .Item("notelp", .CurrentRow.Index).Value
                username.Text = .Item("username", .CurrentRow.Index).Value
                password.Text = .Item("password", .CurrentRow.Index).Value
                Dim hak1 As String = .Item(8, .CurrentRow.Index).Value
                For o = 0 To hak.Items.Count - 1
                    Dim hak2 As String = hak.Items(o).ToString
                    If UCase(Trim(hak2)) = UCase(Trim(hak1)) Then
                        hak.SelectedIndex = o
                    End If
                Next
            End If
        End With
    End Sub

    Sub AutoNo()
        sqL = "select idptgs from mspetugas order by idptgs desc"
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

    Private Sub FrPetugas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnAwal()
        tampilgrid()
        isijenkel()
        isicari()
        isihak()
        tutup()
        kosong()
        Cari.Focus()
        nomor = ""
    End Sub

    Private Sub dgv1_Click(sender As Object, e As EventArgs) Handles dgv1.Click
        isi()
    End Sub
    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        kosong()
        AutoNo()
        BtnAwal()
        BtnSimpan()
        tambah = True
        buka()
        isijenkel()
        isihak()
        nama.Focus()
    End Sub
    Private Sub Btn2_Click(sender As Object, e As EventArgs)
        If Btn2.Text = "Edit" Then
            If dgv1.RowCount > 0 Then
                BtnSimpan()
                tambah = False
                isijenkel()
                isi()
                buka()
                nama.Focus()
                nomor = idptgs.Text
            Else
                MsgBox("Data masih kosong", vbInformation, "Isi data dahulu")
            End If
        Else
            If nama.Text = "" Or alamat.Text = "" Or divisi.Text = "" Or notelp_ptgs.Text = "" Or username.Text = "" Or password.Text = "" Then
                MsgBox("Data belum lengkap", vbInformation, "Isi data dahulu")
            Else
                If tambah = True Then
                    sqL = "insert into mspetugas (idptgs, nama, jenkel, alamat, divisi, notelp, username, password, hak)values(" & Aphostrophe(idptgs.Text) &
                        "," & Aphostrophe(nama.Text) &
                        "," & Aphostrophe(jenkel.Text) &
                        "," & Aphostrophe(alamat.Text) &
                        "," & Aphostrophe(divisi.Text) &
                        "," & Aphostrophe(notelp_ptgs.Text) &
                        "," & Aphostrophe(username.Text) &
                        "," & Aphostrophe(password.Text) &
                        "," & Aphostrophe(hak.Text) & ")"
                    Proses.ExecuteNonQuery(sqL)
                Else
                    sqL = "Update mspetugas set idptgs=" & Aphostrophe(idptgs.Text) &
                        ", nama=" & Aphostrophe(nama.Text) &
                        ", jenkel=" & Aphostrophe(jenkel.Text) &
                        ", alamat=" & Aphostrophe(alamat.Text) &
                        ", divisi=" & Aphostrophe(divisi.Text) &
                        ", notelp=" & Aphostrophe(notelp_ptgs.Text) &
                        ", username=" & Aphostrophe(username.Text) &
                        ", password=" & Aphostrophe(password.Text) &
                        ", hak=" & Aphostrophe(hak.Text) &
                        "where idptgs=" & Aphostrophe(nomor)
                    Proses.ExecuteNonQuery(sqL)
                End If
                MsgBox("Data berhasil disimpan", vbInformation, "Notifikasi")
                BtnAwal()
                isijenkel()
                tampilgrid()
                kosong()
                tutup()
                Cari.Focus()
            End If
        End If
    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs)
        If Btn3.Text = "Batal" Then
            BtnAwal()
            tutup()
            kosong()
            Cari.Focus()
        Else
            If idptgs.Text <> "" Then
                Dim tny As String = MsgBox("Yakin ingin menghapus data ?", vbYesNo + vbInformation, "konfirmasi")
                If tny = vbYes Then
                    sqL = "delete from mspetugas where idptgs='" & idptgs.Text & "'"
                    Proses.ExecuteNonQuery(sqL)
                    MsgBox("Data berhasil hapus", vbInformation, "Data sukses")
                    BtnAwal()
                    tampilgrid()
                    isijenkel()
                    isicari()
                    tutup()
                    kosong()
                    Cari.Focus()
                    nomor = ""
                End If
            End If
        End If
    End Sub

    Private Sub BtnCari_Click(sender As Object, e As EventArgs) Handles BtnCari.Click
        Select Case berdasarkan.SelectedIndex
            Case 0
                sqL = "select * from mspetugas where idptgs like" & Aphostrophe("%" & Cari.Text & "%")
            Case 1
                sqL = "select * from mspetugas where nama like" & Aphostrophe("%" & Cari.Text & "%")
        End Select
        Tabel = Proses.ExecuteQuery(sqL)
        If Tabel.Rows.Count > 0 Then
            MsgBox("Data yang dicara ada...!!" & Tabel.Rows.Count, vbInformation, "Apakah ini dicari")
            dgv1.DataSource = Tabel
            isi()
            Cari.Clear()
        Else
            MsgBox("Data yang dicara ada...!!" & Tabel.Rows.Count, vbInformation, "Apakah ini dicari")
            Cari.Clear()
        End If

    End Sub

    Private Sub BtnKembali_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles Btn4.Click
        If Btn3.Text = "Batal" Then
            BtnAwal()
            tutup()
            kosong()
            Cari.Focus()
        Else
            If idptgs.Text <> "" Then
                Dim tny As String = MsgBox("Yakin ingin menghapus data ?", vbYesNo + vbInformation, "konfirmasi")
                If tny = vbYes Then
                    sqL = "delete from mspetugas where idptgs='" & idptgs.Text & "'"
                    Proses.ExecuteNonQuery(sqL)
                    MsgBox("Data berhasil hapus", vbInformation, "Data sukses")
                    BtnAwal()
                    tampilgrid()
                    isicari()
                    tutup()
                    kosong()
                    Cari.Focus()
                    nomor = ""
                End If
            End If
        End If
    End Sub

    Private Sub Btn3_Click_1(sender As Object, e As EventArgs) Handles Btn3.Click
        If idptgs.Text <> "" Then
            Dim tny As String = MsgBox("Yakin ingin menghapus data ?", vbYesNo + vbInformation, "konfirmasi")
            If tny = vbYes Then
                sqL = "delete from mspetugas where idptgs='" & idptgs.Text & "'"
                Proses.ExecuteNonQuery(sqL)
                MsgBox("Data berhasil hapus", vbInformation, "Data sukses")
                BtnAwal()
                tampilgrid()
                isicari()
                tutup()
                kosong()
                Cari.Focus()
                nomor = ""
            End If
        End If
    End Sub

    Private Sub Btn2_Click_1(sender As Object, e As EventArgs) Handles Btn2.Click
        If Btn2.Text = "Edit" Then
            If dgv1.RowCount > 0 Then
                BtnSimpan()
                tambah = False
                isi()
                buka()
                nama.Focus()
                nomor = idptgs.Text
            Else
                MsgBox("Data masih kosong", vbInformation, "Isi data dahulu")
            End If
        Else
            If nama.Text = "" Or alamat.Text = "" Or divisi.Text = "" Or notelp_ptgs.Text = "" Or username.Text = "" Or password.Text = "" Then
                MsgBox("Data belum lengkap", vbInformation, "Isi data dahulu")
            Else
                If tambah = True Then
                    sqL = "insert into mspetugas (idptgs, nama, jenkel, alamat, divisi, notelp,  username, password)values(" & Aphostrophe(idptgs.Text) &
                        "," & Aphostrophe(nama.Text) &
                        "," & Aphostrophe(jenkel.Text) &
                        "," & Aphostrophe(alamat.Text) &
                        "," & Aphostrophe(divisi.Text) &
                        "," & Aphostrophe(notelp_ptgs.Text) &
                        "," & Aphostrophe(username.Text) &
                        "," & Aphostrophe(password.Text) & ")"
                    Proses.ExecuteNonQuery(sqL)
                Else
                    sqL = "Update mspetugas set idptgs=" & Aphostrophe(idptgs.Text) &
                        ", nama=" & Aphostrophe(nama.Text) &
                        ", jenkel=" & Aphostrophe(jenkel.Text) &
                        ", alamat=" & Aphostrophe(alamat.Text) &
                        ", divisi=" & Aphostrophe(divisi.Text) &
                        ", notelp=" & Aphostrophe(notelp_ptgs.Text) &
                        ", username=" & Aphostrophe(username.Text) &
                        ", password=" & Aphostrophe(password.Text) &
                        "where idptgs=" & Aphostrophe(nomor)
                    Proses.ExecuteNonQuery(sqL)
                End If
                MsgBox("Data berhasil disimpan", vbInformation, "Notifikasi")
                BtnAwal()
                tampilgrid()
                kosong()
                tutup()
                Cari.Focus()
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub BtnMenu_Click(sender As Object, e As EventArgs) Handles BtnMenu.Click
        Me.Close()
        Main_FromNew.Show()
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        tampilgrid()
    End Sub
End Class