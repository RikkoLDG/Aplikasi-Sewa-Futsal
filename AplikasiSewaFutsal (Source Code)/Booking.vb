Public Class Booking
    Public tgl As Date
    Public tgl2 As Date
    Dim tambah As Boolean
    Dim nomor As String
    Dim keluar As String
    Dim harga_awal1 As String
    Dim hrg_lpgn_total As String
    Sub tampilgrid()
        sqL = "select * from msbooking"
        Tabel = Proses.ExecuteQuery(sqL)
        dgv1.DataSource = Tabel
        dgv1.Columns(0).HeaderText = "KODE BOOKING "
        dgv1.Columns(1).HeaderText = "TANNGAL BOOKING"
        dgv1.Columns(2).HeaderText = "ATAS NAMA"
        dgv1.Columns(3).HeaderText = "NAMA TEAM"
        dgv1.Columns(4).HeaderText = "STATUS"
        dgv1.Columns(5).HeaderText = "KODE MEMBER"
        dgv1.Columns(6).HeaderText = "No. Telphone"
        dgv1.Columns(7).HeaderText = "KODE LAPANGAN"
        dgv1.Columns(8).HeaderText = "LAMA SEWA"
        dgv1.Columns(9).HeaderText = "HARSA SEWA TOTAL"
        dgv1.Columns(10).HeaderText = "TANGGAL SEWA"
        dgv1.Columns(11).HeaderText = "JAM MASUK"
        dgv1.Columns(12).HeaderText = "JAM KELUAR"
        dgv1.Columns(13).HeaderText = "UANG MUKA"
        dgv1.Columns(14).HeaderText = "ID PETUGAS"
        'kode_book, tanggal_book, nama, nama_team, status, kode_member, notelp, 
        ' kode_lpgn, lama_sewa, harga_sewa_total, tanggal_sewa, jam_masuk, jam_keluar, uang_muka, idptgs
    End Sub
    Sub lama()
        If lama_sewa.SelectedIndex = 0 Then
            harga_awal1 = Val(harga_awal.Text)
            harga_sewa_total.Text = Val(harga_awal.Text) * 1
        Else
            harga_awal1 = Val(harga_awal.Text)
            harga_sewa_total.Text = Val(harga_awal.Text) * 2
        End If
    End Sub
    'Sub harga()
    '    If rumput.Checked = True Then
    '        hrg_lpgn = 150000
    '        harga_lpgn.Text = hrg_lpgn
    '    Else
    '        hrg_lpgn = 225000
    '        harga_lpgn.Text = hrg_lpgn
    '    End If
    'End Sub

    Sub keluaran()
        If lama_sewa.SelectedIndex = 0 Then
            keluar = jam_masuk.Value.AddHours(1)
            jam_keluar.Text = keluar
        Else
            keluar = jam_masuk.Value.AddHours(2)
            jam_keluar.Text = keluar
        End If
    End Sub

    'Sub lapanganrumput()
    '    lapangan1.Items.Clear()
    '    lapangan1.Items.Add("Lapangan1")
    '    lapangan1.Items.Add("Lapangan2")
    '    lapangan1.SelectedIndex = 0
    '    tipe.Text = "Rumput Sintetis"
    'End Sub
    'Sub lapanganmatras()
    '    lapangan1.Items.Clear()
    '    lapangan1.Items.Add("Lapangan3")
    '    lapangan1.Items.Add("Lapangan4")
    '    lapangan1.SelectedIndex = 0
    '    tipe.Text = "Matras"
    'End Sub
    Sub isilama()
        lama_sewa.Items.Clear()
        lama_sewa.Items.Add("1 Jam")
        lama_sewa.Items.Add("2 Jam")
        lama_sewa.SelectedIndex = 0
    End Sub
    Sub isicari()
        berdasarkan.Items.Clear()
        berdasarkan.Items.Add("Kode Booking")
        berdasarkan.Items.Add("Nama")
        berdasarkan.SelectedIndex = 0
    End Sub
    Sub kosong()
        kode_book.Clear()
        tanggal_book.Clear()
        nama.Clear()
        nama_team.Clear()
        status.Clear()
        member.Checked = False
        nonmember.Checked = False
        kode_member.Clear()
        notelp.Clear()
        kode_lpgn.Clear()
        lama_sewa.Items.Clear()
        harga_awal.Text = ""
        harga_awal1 = ""
        harga_sewa_total.Clear()
        tanggal_sewa.Text = DateTime.Now.ToString("yyyy-MM-dd")
        jam_masuk.Text = "00:00"
        uang_muka.Clear()
        idptgs.Clear()
        nama.Focus()
    End Sub
    Sub BtnAwal()
        Btn1.Text = "Tambah"
        Btn2.Text = "Edit"
        Btn3.Text = "Hapus"
        Btn4.Text = "Batal"
        Btn1.Visible = True
        Btn3.Visible = True
        status.Text = "Non Member"
        kode_member.Text = "Non Member"
        idptgs.Text = userid.Text
    End Sub
    Sub BtnSimpan()
        Btn1.Visible = False
        Btn3.Visible = False
        Btn2.Text = "Simpan"
        Btn3.Text = "Batal"
        Btn4.Text = "Batal"
        idptgs.Text = userid.Text
    End Sub
    Sub tutup()
        kode_book.Enabled = False
        tanggal_book.Enabled = False
        nama.Enabled = False
        nama_team.Enabled = False
        status.Enabled = False
        member.Enabled = False
        nonmember.Enabled = False
        kode_member.Enabled = False
        notelp.Enabled = False
        kode_lpgn.Enabled = False
        lama_sewa.Enabled = False
        harga_sewa_total.Enabled = False
        tanggal_sewa.Enabled = False
        jam_masuk.Enabled = False
        uang_muka.Enabled = False
        idptgs.Enabled = False
        carilapangan.Enabled = False
        carimember.Enabled = False
    End Sub
    Sub buka()
        kode_book.Enabled = False
        tanggal_book.Enabled = True
        nama.Enabled = True
        nama_team.Enabled = True
        status.Enabled = False
        member.Enabled = False
        nonmember.Enabled = False
        kode_member.Enabled = False
        notelp.Enabled = True
        kode_lpgn.Enabled = True
        lama_sewa.Enabled = True
        harga_sewa_total.Enabled = True
        tanggal_sewa.Enabled = True
        jam_masuk.Enabled = True
        uang_muka.Enabled = True
        idptgs.Enabled = False
        carilapangan.Enabled = True
        carimember.Enabled = True
    End Sub
    Sub isi()
        With dgv1
            isilama()
            If .RowCount > 0 Then
                kode_book.Text = .Item("kode_book", .CurrentRow.Index).Value
                tanggal_book.Text = .Item("tanggal_book", .CurrentRow.Index).Value
                nama.Text = .Item("nama", .CurrentRow.Index).Value
                nama_team.Text = .Item("nama_team", .CurrentRow.Index).Value
                status.Text = .Item("status", .CurrentRow.Index).Value
                kode_member.Text = .Item("kode_member", .CurrentRow.Index).Value
                notelp.Text = .Item("notelp", .CurrentRow.Index).Value
                kode_lpgn.Text = .Item("kode_lpgn", .CurrentRow.Index).Value
                Dim lama_sewa1 As String = .Item(8, .CurrentRow.Index).Value
                For i = 0 To lama_sewa.Items.Count - 1
                    Dim lama_sewa2 As String = lama_sewa.Items(i).ToString
                    If UCase(Trim(lama_sewa2)) = UCase(Trim(lama_sewa1)) Then
                        lama_sewa.SelectedIndex = i
                    End If
                Next
                harga_sewa_total.Text = .Item("harga_sewa_total", .CurrentRow.Index).Value
                tanggal_sewa.Text = .Item("tanggal_sewa", .CurrentRow.Index).Value
                jam_masuk.Text = .Item("jam_masuk", .CurrentRow.Index).Value
                jam_keluar.Text = .Item("jam_keluar", .CurrentRow.Index).Value
                uang_muka.Text = .Item("uang_muka", .CurrentRow.Index).Value
                idptgs.Text = .Item("idptgs", .CurrentRow.Index).Value
            End If
        End With
    End Sub
    Sub AutoNo()
        sqL = "select kode_book from msbooking order by kode_book desc"
        Tabel = Proses.ExecuteQuery(sqL)
        If Tabel.Rows.Count = 0 Then
            nomor = "B0001"
        Else
            Dim nom As String = Microsoft.VisualBasic.Right(Trim(Tabel.Rows(0).Item(0).ToString), 3)
            Dim urut As String = Val(nom) + 1
            nom = urut
            Dim panjang As Byte = Len(nom)
            nomor = "B" & Microsoft.VisualBasic.Right("0000" & urut, 4)
        End If
        kode_book.Text = nomor
    End Sub
    Private Sub Booking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        BtnAwal()
        tampilgrid()
        isilama()
        isicari()
        tutup()
        kosong()
        Cari.Focus()
        nomor = ""
    End Sub

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        kosong()
        AutoNo()
        tanggal_book.Text = DateTime.Now.ToString("yyyy-MM-dd")
        BtnAwal()
        BtnSimpan()
        tambah = True
        buka()
        isilama()
        nama.Focus()
    End Sub
    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        If Btn2.Text = "Edit" Then
            If dgv1.RowCount > 0 Then
                BtnSimpan()
                tambah = False
                isilama()
                isi()
                buka()
                kode_lpgn.Clear()
                lama_sewa.SelectedIndex = 0
                harga_sewa_total.Text = 0
                nama.Focus()
                nomor = kode_book.Text
            Else
                MsgBox("Data masih kosong", vbInformation, "Isi data dahulu")
            End If
        Else
            If nama.Text = "" Or nama_team.Text = "" Or status.Text = "" Or notelp.Text = "" Or kode_lpgn.Text = "" Or harga_sewa_total.Text = "" Or tanggal_sewa.Text = "" Or jam_masuk.Text = "" Or jam_keluar.Text = "" Or uang_muka.Text = "" Then
                MsgBox("Data belum lengkap", vbInformation, "Isi data dahulu")
            Else
                If tambah = True Then
                    keluaran()
                    sqL = "insert into msbooking (kode_book, tanggal_book, nama, nama_team, status, kode_member, notelp, kode_lpgn, lama_sewa, harga_sewa_total, tanggal_sewa, jam_masuk, jam_keluar, uang_muka, idptgs)values(" & Aphostrophe(kode_book.Text) &
                        "," & Aphostrophe(tanggal_book.Text) &
                        "," & Aphostrophe(nama.Text) &
                        "," & Aphostrophe(nama_team.Text) &
                        "," & Aphostrophe(status.Text) &
                        "," & Aphostrophe(kode_member.Text) &
                        "," & Aphostrophe(notelp.Text) &
                        "," & Aphostrophe(kode_lpgn.Text) &
                        "," & Aphostrophe(lama_sewa.Text) &
                        "," & Aphostrophe(harga_sewa_total.Text) &
                        "," & Aphostrophe(tanggal_sewa.Text) &
                        "," & Aphostrophe(jam_masuk.Text) &
                        "," & Aphostrophe(jam_keluar.Text) &
                        "," & Aphostrophe(uang_muka.Text) &
                        "," & Aphostrophe(idptgs.Text) & ")"
                    Proses.ExecuteNonQuery(sqL)
                Else
                    keluaran()
                    sqL = "Update msbooking set kode_book=" & Aphostrophe(kode_book.Text) &
                        ", tanggal_book=" & Aphostrophe(tanggal_book.Text) &
                        ", nama=" & Aphostrophe(nama.Text) &
                        ", nama_team=" & Aphostrophe(nama_team.Text) &
                        ", status=" & Aphostrophe(status.Text) &
                        ", kode_member=" & Aphostrophe(kode_member.Text) &
                        ", notelp=" & Aphostrophe(notelp.Text) &
                        ", kode_lpgn=" & Aphostrophe(kode_lpgn.Text) &
                        ", lama_sewa=" & Aphostrophe(lama_sewa.Text) &
                        ", tanggal_sewa=" & Aphostrophe(tanggal_sewa.Text) &
                        ", jam_masuk=" & Aphostrophe(jam_masuk.Text) &
                        ", jam_keluar=" & Aphostrophe(jam_keluar.Text) &
                        ", harga_sewa_total=" & Aphostrophe(harga_sewa_total.Text) &
                        ", uang_muka=" & Aphostrophe(uang_muka.Text) &
                        ", idptgs=" & Aphostrophe(idptgs.Text) &
                        "where kode_book=" & Aphostrophe(nomor)
                    Proses.ExecuteNonQuery(sqL)
                End If
                MsgBox("Data berhasil disimpan", vbInformation, "Notifikasi")
                BtnAwal()
                isilama()
                tampilgrid()
                kosong()
                tutup()
                Cari.Focus()
            End If
        End If
    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        If kode_book.Text <> "" Then
            Dim tny As String = MsgBox("Yakin ingin menghapus data ?", vbYesNo + vbInformation, "konfirmasi")
            If tny = vbYes Then
                sqL = "delete from msbooking where kode_book='" & kode_book.Text & "'"
                Proses.ExecuteNonQuery(sqL)
                MsgBox("Data berhasil hapus", vbInformation, "Data sukses")
                BtnAwal()
                tampilgrid()
                isilama()
                isicari()
                tutup()
                kosong()
                Cari.Focus()
                nomor = ""
            End If
        End If
    End Sub

    Private Sub carimember_Click(sender As Object, e As EventArgs) Handles carimember.Click
        FrmPelanggan.Show()
        Me.Hide()
    End Sub

    Private Sub status_TextChanged(sender As Object, e As EventArgs) Handles status.TextChanged
        If status.Text = "Non Member" Then
            nonmember.Checked = True
            member.Checked = False
        Else
            nonmember.Checked = False
            member.Checked = True
        End If
    End Sub
    Private Sub dgv1_Click(sender As Object, e As EventArgs) Handles dgv1.Click
        BtnAwal()
        tutup()
        kosong()
        isi()
    End Sub

    Private Sub cek_Click(sender As Object, e As EventArgs) Handles cek.Click
        'sqL = "select nama_lpgn, tanggal_sewa, jam_masuk, jam_keluar  from trbooking where nama_lpgn like" & Aphostrophe("%" & lapangan1.Text & "%") &
        '    "and tanggal_sewa like" & Aphostrophe("%" & tanggal_sewa.Text & "%") &
        '    "and jam_masuk like" & Aphostrophe("%" & jam_masuk.Text & "%") &
        '    "and jam_keluar like" & Aphostrophe("%" & jam_keluar.Text & "%")
        'Tabel = Proses.ExecuteQuery(sqL)
        'If Tabel.Rows.Count > 0 Then
        '    MsgBox("Pilih Lapangan Atau Waktu Yang Lain" & Tabel.Rows.Count, vbInformation, "Lapangan Sudah di Booking")
        'Else
        '    MsgBox("Lapangan Tersedia" & Tabel.Rows.Count, vbInformation, "Booking Sukses")
        'End If
    End Sub

    Private Sub lama_sewa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lama_sewa.SelectedIndexChanged
        lama()
    End Sub

    Private Sub BtnCari_Click(sender As Object, e As EventArgs)
        Select Case berdasarkan.SelectedIndex
            Case 0
                sqL = "select * from trbooking where kode_book like" & Aphostrophe("%" & Cari.Text & "%")
            Case 1
                sqL = "select * from trbooking where nama like" & Aphostrophe("%" & Cari.Text & "%")
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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LabelTgl.Text = Format(Now, "dd - MMM - yyyy")
        LabelJam.Text = Format(Now, "HH:mm:ss")
    End Sub

    Private Sub BtnMenu_Click(sender As Object, e As EventArgs) Handles BtnMenu.Click
        Me.Close()
        Main_FromNew.Show()
    End Sub

    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles Btn4.Click
        If Btn3.Text = "Batal" Then
            BtnAwal()
            tutup()
            kosong()
            Cari.Focus()
        Else
            If kode_book.Text <> "" Then
                Dim tny As String = MsgBox("Yakin ingin menghapus data ?", vbYesNo + vbInformation, "konfirmasi")
                If tny = vbYes Then
                    sqL = "delete from msbooking where kode_book='" & kode_book.Text & "'"
                    Proses.ExecuteNonQuery(sqL)
                    MsgBox("Data berhasil hapus", vbInformation, "Data sukses")
                    BtnAwal()
                    tampilgrid()
                    isilama()
                    isicari()
                    tutup()
                    kosong()
                    Cari.Focus()
                    nomor = ""
                End If
            End If
        End If
    End Sub

    Private Sub carilapangan_Click(sender As Object, e As EventArgs) Handles carilapangan.Click
        PilihLapangan.Show()
        Me.Hide()
    End Sub

    Private Sub BtnCari_Click_1(sender As Object, e As EventArgs) Handles BtnCari.Click
        Select Case berdasarkan.SelectedIndex
            Case 0
                sqL = "select * from msbooking where kode_book like" & Aphostrophe("%" & Cari.Text & "%")
            Case 1
                sqL = "select * from msbooking where nama like" & Aphostrophe("%" & Cari.Text & "%")
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        tampilgrid()
    End Sub

 
End Class