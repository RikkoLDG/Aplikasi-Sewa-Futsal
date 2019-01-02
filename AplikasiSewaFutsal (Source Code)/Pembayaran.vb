Imports CrystalDecisions.CrystalReports.Engine



Public Class Pembayaran
    Dim tambah As Boolean
    Dim nomor As String
    Dim total As Long
    Dim kembali As Long = 0
    Sub barang()
        If loker.Checked = False And kaos.Checked = True And sepatu.Checked = False Then
            barang_sewa.Text = "Jersey Team"
        ElseIf loker.Checked = True And kaos.Checked = False And sepatu.Checked = False Then
            barang_sewa.Text = "Loker"
        ElseIf loker.Checked = False And kaos.Checked = False And sepatu.Checked = True Then
            barang_sewa.Text = "Sepatu"
        ElseIf loker.Checked = True And kaos.Checked = True And sepatu.Checked = False Then
            barang_sewa.Text = "Loker + Jersey Team"
        ElseIf loker.Checked = False And kaos.Checked = True And sepatu.Checked = True Then
            barang_sewa.Text = "Jersey Team + Sepatu"
        ElseIf loker.Checked = True And kaos.Checked = False And sepatu.Checked = True Then
            barang_sewa.Text = "Loker + Sepatu"
        ElseIf loker.Checked = True And kaos.Checked = True And sepatu.Checked = True Then
            barang_sewa.Text = "Loker + Jersey Team + Sepatu"
        Else
            barang_sewa.Text = "Tidak Ada Baran Yang Disewa"
        End If
    End Sub

    Sub pilihan()
        Dim pilihan As Integer = 0
        If loker.Checked = True Then
            pilihan = pilihan + 10000
        End If
        biaya_sewa_barang.Text = pilihan
        If kaos.Checked = True Then
            pilihan = pilihan + 25000
        End If
        biaya_sewa_barang.Text = pilihan
        If sepatu.Checked = True Then
            pilihan = pilihan + 25000
        End If
        biaya_sewa_barang.Text = pilihan
    End Sub
    Sub tampilgrid()
        sqL = "select * from trpembayaran"
        Tabel = Proses.ExecuteQuery(sqL)
        dgv1.DataSource = Tabel
    End Sub

    Sub isicari()
        berdasarkan.Items.Clear()
        berdasarkan.Items.Add("No.Trans")
        berdasarkan.Items.Add("Nama Team")
        berdasarkan.SelectedIndex = 0
    End Sub
    Sub kosong()
        no_trans.Clear()
        kode_book.Clear()
        nama_team.Clear()
        kode_lpgn.Clear()
        nama_lpgn.Clear()
        uang_muka.Clear()
        biaya_sewa_lapangan.Clear()
        status.Clear()
        loker.Checked = False
        kaos.Checked = False
        sepatu.Checked = False
        barang_sewa.Clear()
        biaya_sewa_barang.Clear()
        total_biaya.Clear()
        uang_bayar.Clear()
        kembalian.Clear()
        uang_bayar.Focus()
        tgl_pembayaran.Clear()
        gratis.Visible = False
        total_biaya.Text = "TOTAL BIAYA"
    End Sub
    Sub BtnAwal()
        Btn1.Text = "Lakukan Pembayaran"
        Btn2.Text = "Edit"
        Btn3.Text = "Hapus"
        Btn1.Visible = True
        idptgs.Text = userid.Text
    End Sub
    Sub BtnSimpan()
        Btn1.Visible = False
        Btn2.Text = "Simpan"
        Btn3.Text = "Batal"
        idptgs.Text = userid.Text
    End Sub
    Sub tutup()
        caribooking.Enabled = False
        no_trans.Enabled = False
        kode_book.Enabled = False
        nama_team.Enabled = False
        kode_lpgn.Enabled = False
        nama_lpgn.Enabled = False
        status.Enabled = False
        biaya_sewa_lapangan.Enabled = False
        uang_muka.Enabled = False
        loker.Enabled = False
        kaos.Enabled = False
        sepatu.Enabled = False
        barang_sewa.Enabled = False
        biaya_sewa_barang.Enabled = False
        uang_bayar.Enabled = False
        'kembalian.Enabled = False
        Button3.Enabled = False
        gratis.Visible = False
        tgl_pembayaran.Enabled = False
    End Sub
    Sub buka()
        biaya_sewa_barang.Text = 0
        caribooking.Enabled = True
        no_trans.Enabled = False
        kode_book.Enabled = True
        nama_team.Enabled = True
        kode_lpgn.Enabled = True
        nama_lpgn.Enabled = True
        status.Enabled = False
        biaya_sewa_lapangan.Enabled = False
        uang_muka.Enabled = False
        loker.Enabled = True
        kaos.Enabled = True
        sepatu.Enabled = True
        barang_sewa.Enabled = False
        biaya_sewa_barang.Enabled = False
        uang_bayar.Enabled = True
        'kembalian.Enabled = False
        Button3.Enabled = True
        gratis.Visible = False
        tgl_pembayaran.Enabled = False
    End Sub
    Sub isi()
        loker.Enabled = False
        kaos.Enabled = False
        sepatu.Enabled = False
        With dgv1
            If .RowCount > 0 Then
                no_trans.Text = .Item("no_trans", .CurrentRow.Index).Value
                kode_book.Text = .Item("kode_book", .CurrentRow.Index).Value
                nama_team.Text = .Item("nama_team", .CurrentRow.Index).Value
                kode_lpgn.Text = .Item("kode_lpgn", .CurrentRow.Index).Value
                nama_lpgn.Text = .Item("nama_lpgn", .CurrentRow.Index).Value
                status.Text = .Item("status", .CurrentRow.Index).Value
                biaya_sewa_lapangan.Text = .Item("biaya_sewa_lapangan", .CurrentRow.Index).Value
                barang_sewa.Text = .Item("barang_sewa", .CurrentRow.Index).Value
                biaya_sewa_barang.Text = .Item("biaya_sewa_barang", .CurrentRow.Index).Value
                uang_muka.Text = .Item("uang_muka", .CurrentRow.Index).Value
                total_biaya.Text = .Item("total_biaya", .CurrentRow.Index).Value
                uang_bayar.Text = .Item("uang_bayar", .CurrentRow.Index).Value
                kembalian.Text = .Item("kembalian", .CurrentRow.Index).Value
                idptgs.Text = .Item("idptgs", .CurrentRow.Index).Value
                tgl_pembayaran.Text = .Item("tgl_pembayaran", .CurrentRow.Index).Value
            End If
        End With
    End Sub
    Sub isi_nama_lpgn()
        With dgv2
            If .RowCount > 0 Then
                nama_lpgn.Text = .Item("nama_lpgn", .CurrentRow.Index).Value
            End If
        End With
    End Sub
    Private Sub Pembayaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        BtnAwal()
        tampilgrid()
        isicari()
        tutup()
        kosong()
        Cari.Focus()
        nomor = ""
    End Sub

    Private Sub carimember_Click(sender As Object, e As EventArgs)
        FrmBooking.Show()
        Me.Hide()
    End Sub
    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        kosong()
        no_trans.Text = DateTime.Now.ToString("TR.yyyyddHHmmss")
        tgl_pembayaran.Text = Format(Now, "yyyy-MM-dd")
        BtnAwal()
        BtnSimpan()
        tambah = True
        buka()
        total_biaya.Text = "0"
        uang_bayar.Focus()
    End Sub

    Private Sub status_TextChanged(sender As Object, e As EventArgs) Handles status.TextChanged
        If status.Text = "Non Member" Then
            kaos.Enabled = True
            loker.Enabled = True
            sepatu.Enabled = True
            kaos.Checked = False
            loker.Checked = False
            sepatu.Checked = False
            gratis.Visible = False
        Else
            kaos.Enabled = False
            loker.Enabled = False
            sepatu.Enabled = False
            kaos.Checked = True
            loker.Checked = True
            sepatu.Checked = True
            gratis.Visible = True
            biaya_sewa_barang.Text = 0
        End If
    End Sub

    'Private Sub harga_barang_TextChanged(sender As Object, e As EventArgs) Handles biaya_sewa_barang.TextChanged
    '    total = Val(biaya_sewa_barang.Text) + Val(biaya_sewa_lapangan.Text)
    '    total_biaya.Text = total
    'End Sub

    Private Sub loker_CheckedChanged(sender As Object, e As EventArgs) Handles loker.CheckedChanged
        pilihan()
        barang()
    End Sub

    Private Sub kaos_CheckedChanged(sender As Object, e As EventArgs) Handles kaos.CheckedChanged
        pilihan()
        barang()
    End Sub

    Private Sub sepatu_CheckedChanged(sender As Object, e As EventArgs) Handles sepatu.CheckedChanged
        pilihan()
        barang()
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        If Btn2.Text = "Edit" Then
            If dgv1.RowCount > 0 Then
                BtnSimpan()
                tambah = False
                isi()
                buka()
                uang_bayar.Focus()
                nomor = no_trans.Text
            Else
                MsgBox("Data masih kosong", vbInformation, "Isi data dahulu")
            End If
        Else
            If kode_book.Text = "" Or biaya_sewa_lapangan.Text = "" Or uang_bayar.Text = "" Then
                MsgBox("Data belum lengkap", vbInformation, "Isi data dahulu")
            Else
                If tambah = True Then
                    sqL = "insert into trpembayaran (no_trans, kode_book, nama_team, kode_lpgn, nama_lpgn, status, biaya_sewa_lapangan, barang_sewa, biaya_sewa_barang, uang_muka, total_biaya, uang_bayar, kembalian, idptgs, tgl_pembayaran)values(" & Aphostrophe(no_trans.Text) &
                        "," & Aphostrophe(kode_book.Text) &
                        "," & Aphostrophe(nama_team.Text) &
                        "," & Aphostrophe(kode_lpgn.Text) &
                        "," & Aphostrophe(nama_lpgn.Text) &
                        "," & Aphostrophe(status.Text) &
                        "," & Aphostrophe(biaya_sewa_lapangan.Text) &
                        "," & Aphostrophe(barang_sewa.Text) &
                        "," & Aphostrophe(biaya_sewa_barang.Text) &
                        "," & Aphostrophe(uang_muka.Text) &
                        "," & Aphostrophe(total) &
                        "," & Aphostrophe(uang_bayar.Text) &
                        "," & Aphostrophe(kembali) &
                        "," & Aphostrophe(idptgs.Text) &
                        "," & Aphostrophe(tgl_pembayaran.Text) & ")"
                    Proses.ExecuteNonQuery(sqL)
                Else
                    sqL = "Update trpembayaran set no_trans=" & Aphostrophe(no_trans.Text) &
                        ", kode_book=" & Aphostrophe(kode_book.Text) &
                        ", nama_team=" & Aphostrophe(nama_team.Text) &
                        ", kode_lpgn=" & Aphostrophe(kode_lpgn.Text) &
                        ", nama_lpgn=" & Aphostrophe(nama_lpgn.Text) &
                        ", status=" & Aphostrophe(status.Text) &
                        ", biaya_sewa_lapangan=" & Aphostrophe(biaya_sewa_lapangan.Text) &
                        ", barang_sewa=" & Aphostrophe(barang_sewa.Text) &
                        ", biaya_sewa_barang=" & Aphostrophe(biaya_sewa_barang.Text) &
                        ", uang_muka=" & Aphostrophe(uang_muka.Text) &
                        ", total_biaya=" & Aphostrophe(total) &
                        ", uang_bayar=" & Aphostrophe(uang_bayar.Text) &
                        ", kembalian=" & Aphostrophe(kembali) &
                        ", idptgs=" & Aphostrophe(idptgs.Text) &
                        ", tgl_pembayaran=" & Aphostrophe(tgl_pembayaran.Text) &
                        "where idtrans=" & Aphostrophe(nomor)
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

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        If Btn3.Text = "Batal" Then
            BtnAwal()
            tutup()
            kosong()
            Cari.Focus()
        Else
            If kode_book.Text <> "" Then
                Dim tny As String = MsgBox("Yakin ingin menghapus data ?", vbYesNo + vbInformation, "konfirmasi")
                If tny = vbYes Then
                    sqL = "delete from trpembayaran where no_trans='" & no_trans.Text & "'"
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
    Private Sub uang_bayar_TextChanged(sender As Object, e As EventArgs) Handles uang_bayar.TextChanged
        kembali = Val(uang_bayar.Text) - Val(total)
        kembalian.Text = kembali
        kembalian.Text = Format(kembali, "Rp ##,##0")
    End Sub

    Private Sub dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellContentClick
        isi()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LabelTgl.Text = Format(Now, "dd - MMM - yyyy")
        LabelJam.Text = Format(Now, "HH:mm:ss")
    End Sub
    Private Sub kode_lpgn_TextChanged(sender As Object, e As EventArgs) Handles kode_lpgn.TextChanged
        sqL = "select nama_lpgn from mslapangan where kode_lpgn like" & Aphostrophe("%" & Cari.Text & "%")
        Tabel = Proses.ExecuteQuery(sqL)
        dgv2.DataSource = Tabel
        isi_nama_lpgn()
    End Sub

    Private Sub caribooking_Click(sender As Object, e As EventArgs) Handles caribooking.Click
        CariKodeBook.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        total = Val(biaya_sewa_lapangan.Text) + Val(biaya_sewa_barang.Text) - Val(uang_muka.Text)
        total_biaya.Text = total
        total_biaya.Text = Format(total, "Rp ##,##0")
    End Sub

    Private Sub BtnMenu_Click(sender As Object, e As EventArgs) Handles BtnMenu.Click
        Me.Close()
        Main_FromNew.Show()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        tampilgrid()
    End Sub

    Private Sub BtnCari_Click(sender As Object, e As EventArgs) Handles BtnCari.Click
        Select Case berdasarkan.SelectedIndex
            Case 0
                sqL = "select * from trpembayaran where no_trans like" & Aphostrophe("%" & Cari.Text & "%")
            Case 1
                sqL = "select * from trpembayaran where nama_team like" & Aphostrophe("%" & Cari.Text & "%")
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

    'Private Sub BtnCetakTrans_Click(sender As Object, e As EventArgs) Handles BtnCetakTrans.Click
    ' NotaBayar.CrystalReportViewer1.SelectionFormula = "{trpembayaran.no_trans}='" & (no_trans.Text) &
    ' NotaBayar.CrystalReportViewer1.Refresh()
    ' NotaBayar.Show()
    'End Sub

    Private Sub BtnCetakTrans_Click(sender As Object, e As EventArgs) Handles BtnCetakTrans.Click
        If no_trans.Text = "" Then
            MsgBox("SILAHKAN PILIH NO. TRANSAKSI TERLEBIH DAHULU", vbInformation, "Peringatan")
        End If
        NotaBayar.CrystalReportViewer1.SelectionFormula = "{trpembayaran.no_trans}='" & (no_trans.Text) & "'"
        NotaBayar.CrystalReportViewer1.Refresh()
        Dim rpt As New ReportDocument
        NotaBayar.Show()
    End Sub
End Class