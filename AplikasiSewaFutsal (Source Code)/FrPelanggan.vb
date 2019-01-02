Public Class FrPelanggan
    Dim tambah As Boolean
    Dim nomor As String
    Sub tampilgrid()
        sqL = "select * from msmember"
        Tabel = Proses.ExecuteQuery(sqL)
        dgv1.DataSource = Tabel
    End Sub
    Sub isiStatus()
        status.Clear()
        status.Text = "Member"
    End Sub
    Sub isicari()
        berdasarkan.Items.Clear()
        berdasarkan.Items.Add("No ID")
        berdasarkan.Items.Add("Nama")
        berdasarkan.SelectedIndex = 0
    End Sub
    Sub kosong()
        kode_member.Clear()
        nama.Clear()
        nama_team.Clear()
        alamat.Clear()
        status.Clear()
        notelp.Clear()
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
        kode_member.Enabled = False
        nama.Enabled = False
        nama_team.Enabled = False
        alamat.Enabled = False
        status.Enabled = False
        notelp.Enabled = False
        dgv1.Enabled = True
    End Sub
    Sub buka()
        kode_member.Enabled = False
        nama.Enabled = True
        nama_team.Enabled = True
        alamat.Enabled = True
        status.Enabled = False
        notelp.Enabled = True
    End Sub
    Sub isi()
        With dgv1
            If .RowCount > 0 Then
                kode_member.Text = .Item("kode_member", .CurrentRow.Index).Value
                nama.Text = .Item("nama", .CurrentRow.Index).Value
                nama_team.Text = .Item("nama_team", .CurrentRow.Index).Value
                alamat.Text = .Item("alamat", .CurrentRow.Index).Value
                status.Text = .Item("status", .CurrentRow.Index).Value
                notelp.Text = .Item("notelp", .CurrentRow.Index).Value
            End If
        End With
    End Sub
    Sub AutoNo()
        sqL = "select kode_member from msmember order by kode_member desc"
        Tabel = Proses.ExecuteQuery(sqL)
        If Tabel.Rows.Count = 0 Then
            nomor = "MF0001"
        Else
            Dim nom As String = Microsoft.VisualBasic.Right(Trim(Tabel.Rows(0).Item(0).ToString), 3)
            Dim urut As String = Val(nom) + 1
            nom = urut
            Dim panjang As Byte = Len(nom)
            nomor = "MF" & Microsoft.VisualBasic.Right("0000" & urut, 4)
        End If
        kode_member.Text = nomor
    End Sub

    Private Sub FrPelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        BtnAwal()
        tampilgrid()
        isiStatus()
        isicari()
        tutup()
        kosong()
        Cari.Focus()
        nomor = ""
    End Sub
    Private Sub Btn1_Click_1(sender As Object, e As EventArgs) Handles Btn1.Click
        kosong()
        AutoNo()
        BtnAwal()
        BtnSimpan()
        tambah = True
        buka()
        isiStatus()
        nama.Focus()
    End Sub
    Private Sub Btn2_Click_1(sender As Object, e As EventArgs) Handles Btn2.Click
        If Btn2.Text = "Edit" Then
            If dgv1.RowCount > 0 Then
                BtnSimpan()
                tambah = False
                isiStatus()
                isi()
                buka()
                nama.Focus()
                nomor = kode_member.Text
            Else
                MsgBox("Data masih kosong", vbInformation, "Isi data dahulu")
            End If
        Else
            If nama.Text = "" Or nama_team.Text = "" Or alamat.Text = "" Or status.Text = "" Then
                MsgBox("Data belum lengkap", vbInformation, "Isi data dahulu")
            Else
                If tambah = True Then
                    sqL = "insert into msmember (kode_member, nama, nama_team, alamat, status, notelp)values(" & Aphostrophe(kode_member.Text) &
                        "," & Aphostrophe(nama.Text) &
                        "," & Aphostrophe(nama_team.Text) &
                        "," & Aphostrophe(alamat.Text) &
                        "," & Aphostrophe(status.Text) &
                        "," & Aphostrophe(notelp.Text) & ")"
                    Proses.ExecuteNonQuery(sqL)
                Else
                    sqL = "Update msmember set kode_member=" & Aphostrophe(kode_member.Text) &
                        ", nama=" & Aphostrophe(nama.Text) &
                        ", nama_team=" & Aphostrophe(nama_team.Text) &
                        ", alamat=" & Aphostrophe(alamat.Text) &
                        ", status=" & Aphostrophe(status.Text) &
                        ", notelp=" & Aphostrophe(notelp.Text) &
                        "where kode_member=" & Aphostrophe(nomor)
                    Proses.ExecuteNonQuery(sqL)
                End If
                MsgBox("Data berhasil disimpan", vbInformation, "Notifikasi")
                BtnAwal()
                isiStatus()
                tampilgrid()
                kosong()
                tutup()
                Cari.Focus()
            End If
        End If
    End Sub

    Private Sub Btn3_Click_1(sender As Object, e As EventArgs) Handles Btn3.Click
        If kode_member.Text <> "" Then
            Dim tny As String = MsgBox("Yakin ingin menghapus data ?", vbYesNo + vbInformation, "konfirmasi")
            If tny = vbYes Then
                sqL = "delete from msmember where kode_member='" & kode_member.Text & "'"
                Proses.ExecuteNonQuery(sqL)
                MsgBox("Data berhasil hapus", vbInformation, "Data sukses")
                BtnAwal()
                tampilgrid()
                isiStatus()
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
            If kode_member.Text <> "" Then
                Dim tny As String = MsgBox("Yakin ingin menghapus data ?", vbYesNo + vbInformation, "konfirmasi")
                If tny = vbYes Then
                    sqL = "delete from msmember where kode_member='" & kode_member.Text & "'"
                    Proses.ExecuteNonQuery(sqL)
                    MsgBox("Data berhasil hapus", vbInformation, "Data sukses")
                    BtnAwal()
                    tampilgrid()
                    isiStatus()
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
                sqL = "select * from msmember where kode_member like" & Aphostrophe("%" & Cari.Text & "%")
            Case 1
                sqL = "select * from msmember where nama like" & Aphostrophe("%" & Cari.Text & "%")
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

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Booking.Show()
        Me.Close()
    End Sub

    Private Sub Cetak_Click(sender As Object, e As EventArgs) Handles Cetak.Click
        Me.Hide()
        With CetakKartuMember
            .kode_member.Text = kode_member.Text
            .nama.Text = nama.Text
            .nama_team.Text = nama_team.Text
            .notelp.Text = notelp.Text
        End With
        CetakKartuMember.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LabelTgl.Text = Format(Now, "dd - MMM - yyyy")
        LabelJam.Text = Format(Now, "HH:mm:ss")
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Main_FromNew.Show()
    End Sub


End Class