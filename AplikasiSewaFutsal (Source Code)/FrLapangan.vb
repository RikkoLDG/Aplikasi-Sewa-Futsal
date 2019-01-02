Public Class FrLapangan
    Dim tambah As Boolean
    Dim nomor As String
    Dim jenis_lpgn As String = ""
    Sub tampilgrid()
        sqL = "select * from mslapangan"
        Tabel = Proses.ExecuteQuery(sqL)
        dgv1.DataSource = Tabel
    End Sub
    Sub isikelas()
        kelas.Items.Clear()
        kelas.Items.Add("International")
        kelas.Items.Add("Standard")
        kelas.SelectedIndex = 0
    End Sub
    Sub isicari()
        berdasarkan.Items.Clear()
        berdasarkan.Items.Add("Kode Lapangan")
        berdasarkan.Items.Add("Nama Lapangan")
        berdasarkan.SelectedIndex = 0
    End Sub
    Sub jenis()
        If rumput.Checked = True Then
            jenis_lpgn = "Rumput Sintetis"
        ElseIf Vinyl.Checked = True Then
            jenis_lpgn = "Lantai Vinyl"
        End If
    End Sub
    Sub kosong()
        kode_lpgn.Clear()
        nama_lpgn.Clear()
        jenis_lpgn = ""
        rumput.Checked = False
        Vinyl.Checked = False
        ukuran_lpgn.Clear()
        kelas.Items.Clear()
        harga_sewa.Clear()
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
        dgv1.Enabled = False
    End Sub
    Sub tutup()
        kode_lpgn.Enabled = False
        nama_lpgn.Enabled = False
        rumput.Enabled = False
        Vinyl.Enabled = False
        ukuran_lpgn.Enabled = False
        kelas.Enabled = False
        harga_sewa.Enabled = False
        dgv1.Enabled = True
    End Sub
    Sub buka()
        kode_lpgn.Enabled = False
        nama_lpgn.Enabled = True
        rumput.Enabled = True
        Vinyl.Enabled = True
        ukuran_lpgn.Enabled = True
        kelas.Enabled = True
        harga_sewa.Enabled = True
    End Sub
    Sub isi()
        With dgv1
            isikelas()
            If .RowCount > 0 Then
                kode_lpgn.Text = .Item("kode_lpgn", .CurrentRow.Index).Value
                nama_lpgn.Text = .Item("nama_lpgn", .CurrentRow.Index).Value
                jenis_lpgn = .Item("jenis_lpgn", .CurrentRow.Index).Value
                ukuran_lpgn.Text = .Item("ukuran_lpgn", .CurrentRow.Index).Value
                Dim kelas1 As String = .Item(4, .CurrentRow.Index).Value
                For i = 0 To kelas.Items.Count - 1
                    Dim kelas2 As String = kelas.Items(i).ToString
                    If UCase(Trim(kelas2)) = UCase(Trim(kelas1)) Then
                        kelas.SelectedIndex = i
                    End If
                Next
                harga_sewa.Text = .Item("harga_sewa", .CurrentRow.Index).Value
            End If
        End With
    End Sub
    Sub AutoNo()
        sqL = "select kode_lpgn from mslapangan order by kode_lpgn desc"
        Tabel = Proses.ExecuteQuery(sqL)
        If Tabel.Rows.Count = 0 Then
            nomor = "LP0001"
        Else
            Dim nom As String = Microsoft.VisualBasic.Right(Trim(Tabel.Rows(0).Item(0).ToString), 3)
            Dim urut As String = Val(nom) + 1
            nom = urut
            Dim panjang As Byte = Len(nom)
            nomor = "LP" & Microsoft.VisualBasic.Right("0000" & urut, 4)
        End If
        kode_lpgn.Text = nomor
    End Sub
    Private Sub FrLapangan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        BtnAwal()
        tampilgrid()
        isikelas()
        isicari()
        tutup()
        kosong()
        Cari.Focus()
        nomor = ""
    End Sub

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        kosong()
        AutoNo()
        BtnAwal()
        BtnSimpan()
        tambah = True
        buka()
        isikelas()
        nama_lpgn.Focus()
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        If Btn2.Text = "Edit" Then
            If dgv1.RowCount > 0 Then
                BtnSimpan()
                tambah = False
                isikelas()
                isi()
                buka()
                nama_lpgn.Focus()
                nomor = kode_lpgn.Text
            Else
                MsgBox("Data masih kosong", vbInformation, "Isi data dahulu")
            End If
        Else
            If nama_lpgn.Text = "" Or jenis_lpgn = "" Or ukuran_lpgn.Text = "" Or harga_sewa.Text = "" Then
                MsgBox("Data belum lengkap", vbInformation, "Isi data dahulu")
            Else
                If tambah = True Then
                    sqL = "insert into mslapangan (kode_lpgn, nama_lpgn, jenis_lpgn, ukuran_lpgn, kelas, harga_sewa)values(" & Aphostrophe(kode_lpgn.Text) &
                        "," & Aphostrophe(nama_lpgn.Text) &
                        "," & Aphostrophe(jenis_lpgn) &
                        "," & Aphostrophe(ukuran_lpgn.Text) &
                        "," & Aphostrophe(kelas.Text) &
                        "," & Aphostrophe(harga_sewa.Text) & ")"
                    Proses.ExecuteNonQuery(sqL)
                Else
                    sqL = "Update mslapangan set kode_lpgn=" & Aphostrophe(kode_lpgn.Text) &
                        ", nama_lpgn=" & Aphostrophe(nama_lpgn.Text) &
                        ", jenis_lpgn=" & Aphostrophe(jenis_lpgn) &
                        ", ukuran_lpgn=" & Aphostrophe(ukuran_lpgn.Text) &
                        ", kelas=" & Aphostrophe(kelas.Text) &
                        ", harga_sewa=" & Aphostrophe(harga_sewa.Text) &
                        "where kode_lpgn=" & Aphostrophe(nomor)
                    Proses.ExecuteNonQuery(sqL)
                End If
                MsgBox("Data berhasil disimpan", vbInformation, "Notifikasi")
                BtnAwal()
                isikelas()
                tampilgrid()
                kosong()
                tutup()
                Cari.Focus()
            End If
        End If
    End Sub


    Private Sub rumput_CheckedChanged(sender As Object, e As EventArgs) Handles rumput.CheckedChanged
        jenis()
    End Sub

    Private Sub Vinyl_CheckedChanged(sender As Object, e As EventArgs) Handles Vinyl.CheckedChanged
        jenis()
    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        If kode_lpgn.Text <> "" Then
            Dim tny As String = MsgBox("Yakin ingin menghapus data ?", vbYesNo + vbInformation, "konfirmasi")
            If tny = vbYes Then
                sqL = "delete from mslapangan where kode_lpgn='" & kode_lpgn.Text & "'"
                Proses.ExecuteNonQuery(sqL)
                MsgBox("Data berhasil hapus", vbInformation, "Data sukses")
                BtnAwal()
                tampilgrid()
                isikelas()
                isicari()
                tutup()
                kosong()
                Cari.Focus()
                nomor = ""
            End If
        End If
    End Sub
    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles Btn4.Click
        If Btn3.Text = "Batal" Then
            BtnAwal()
            tutup()
            kosong()
            Cari.Focus()
        Else
            If kode_lpgn.Text <> "" Then
                Dim tny As String = MsgBox("Yakin ingin menghapus data ?", vbYesNo + vbInformation, "konfirmasi")
                If tny = vbYes Then
                    sqL = "delete from mslapangan where kode_lpgn='" & kode_lpgn.Text & "'"
                    Proses.ExecuteNonQuery(sqL)
                    MsgBox("Data berhasil hapus", vbInformation, "Data sukses")
                    BtnAwal()
                    tampilgrid()
                    isikelas()
                    isicari()
                    tutup()
                    kosong()
                    Cari.Focus()
                    nomor = ""
                End If
            End If
        End If
    End Sub
    Private Sub dgv1_Click(sender As Object, e As EventArgs) Handles dgv1.Click
        isi()
    End Sub

    Private Sub BtnCari_Click(sender As Object, e As EventArgs) Handles BtnCari.Click
        Select Case berdasarkan.SelectedIndex
            Case 0
                sqL = "select * from mslapangan where kode_lpgn like" & Aphostrophe("%" & Cari.Text & "%")
            Case 1
                sqL = "select * from mslapangan where nama_lpgn like" & Aphostrophe("%" & Cari.Text & "%")
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        tampilgrid()
    End Sub

    Private Sub BtnMenu_Click(sender As Object, e As EventArgs) Handles BtnMenu.Click
        Me.Close()
        Main_FromNew.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LabelTgl.Text = Format(Now, "dd - MMM - yyyy")
        LabelJam.Text = Format(Now, "HH:mm:ss")
    End Sub

End Class