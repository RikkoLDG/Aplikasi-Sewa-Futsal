Imports Microsoft.Win32
Imports System.IO
Public Class Main_FromNew
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Sub maintitlehide()
        Label1.Hide()
        Label2.Hide()
        Label3.Hide()
        PictureBox1.Hide()
        MenuBooking.Hide()
    End Sub
    Sub maintitleshow()
        Label1.Show()
        Label2.Show()
        Label3.Show()
        PictureBox1.Show()
        MenuBooking.Show()
    End Sub
    Sub tampilgrid()
        Tabel.Clear()
        'sqL = "select nama_team, kode_lpgn, tanggal_sewa, lama_Sewa, jam_masuk, jam_keluar from msbooking where tanggal_sewa like" & Aphostrophe("%" & tanggal_sewa.Text & "%")
        sqL = "select msbooking.tanggal_sewa, msbooking.nama_team, mslapangan.nama_lpgn, msbooking.lama_sewa, msbooking.jam_masuk, msbooking.jam_keluar from msbooking INNER JOIN mslapangan ON msbooking.kode_lpgn = mslapangan.kode_lpgn where tanggal_sewa like" & Aphostrophe("%" & tanggal_sewa.Text & "%")
        Tabel = Proses.ExecuteQuery(sqL)
        dgv1.DataSource = Tabel
        dgv1.Columns(0).HeaderText = "TANGGAL SEWA "
        dgv1.Columns(1).HeaderText = "NAMA TEAM"
        dgv1.Columns(2).HeaderText = "NAMA LAPANGAN"
        dgv1.Columns(3).HeaderText = "LAMA SEWA"
        dgv1.Columns(4).HeaderText = "JAM MASUK"
        dgv1.Columns(5).HeaderText = "JAM KELUAR"
    End Sub
    Sub isicari()
        berdasarkan.Items.Clear()
        berdasarkan.Items.Add("Nama Team")
        berdasarkan.Items.Add("Nama Lapangan")
        berdasarkan.SelectedIndex = 0
    End Sub
    '::::::::::::::::::::::::::::::::::::
    '::KUMPULAN DARI BEBERAPA SUB ALARM::
    '::::::::::::::::::::::::::::::::::::
    Sub aktifalarm() 'SUB UNTUK ATUR ALARM PADA MENU UTAMA
        Try
            If TxtLocation.Text = "" Or TxtJudul.Text = "" Then
                MessageBox.Show("Pilih File Sound Terlebih Dahulu", "Notifikasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.TabControl1.SelectedTab = TabPage2
                : Exit Sub
            Else
                Dim xx As String
                xx = "Atur Alarm Pada Waktu " + Jam.Value.ToString + " : " + Menit.Value.ToString + " : " + Detik.Value.ToString + " ?"

                Dim i As Integer
                i = MsgBox(xx, vbInformation + vbYesNo, "")
                If i = vbYes Then
                    Dim a, b, c As String
                    If Microsoft.VisualBasic.Left(Jam.Value, "1") = 0 Then
                        a = Jam.Value
                    Else
                        a = Jam.Value
                        If a.Length = 1 Then
                            a = "0" + Jam.Value.ToString
                        ElseIf a.Length = 2 Then
                            a = Jam.Value
                        End If
                    End If
                    If Microsoft.VisualBasic.Left(Menit.Value, "1") = 0 Then
                        b = Menit.Value
                    Else
                        b = Menit.Value
                        If b.Length = 1 Then
                            b = "0" + Menit.Value.ToString
                        ElseIf b.Length = 2 Then
                            b = Menit.Value
                        End If
                    End If
                    If Microsoft.VisualBasic.Left(Detik.Value, "1") = 0 Then
                        c = Detik.Value
                    Else
                        c = Detik.Value
                        If c.Length = 1 Then
                            c = "0" + Detik.Value.ToString
                        ElseIf c.Length = 2 Then
                            c = Detik.Value
                        End If
                    End If

                    TxtAktif.Text = a + " : " + b + " : " + c
                    Timer2.Enabled = True
                    resetAR.Visible = True
                    MessageBox.Show("Alarm Aktif", "Notifikasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    lblstatus.Text = "ON"
                    lblstatus.ForeColor = Color.Green
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error Set Alarm", "Notifikasi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            : Exit Sub
        End Try
    End Sub 'AKHIR UNTUK SUB PASANG ALARM

    Sub stopalarm() 'SUB UNTUK RESET ALARM 
        Try

            TxtAktif.Text = """"
            Timer2.Enabled = False
            resetAR.Visible = False
            MessageBox.Show("Alarm Telah Di Reset", "Notifikasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            lblstatus.Text = "OFF"
            lblstatus.ForeColor = Color.White


        Catch ex As Exception
            MessageBox.Show("Error Set Alarm", "Notifikasi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            : Exit Sub
        End Try
    End Sub 'AKHIR UNTUK SUB RESET ALARM

    Sub defaultsound() 'SUB UNTUK ATUR SOUND DEFAULT ALARM

        Try
            Dim jumlah As String
            Dim file As String
            Using temp As New IO.StreamReader("configsound.ini")
                file = temp.ReadLine
                If file = "" Then
                    file = Application.StartupPath + "\sound\alarm2.wav"
                    TxtLocation.Text = file
                    jumlah = Split(TxtLocation.Text, "\").Length - 1
                    TxtJudul.Text = Split(file, "\")(jumlah)
                Else
                    TxtLocation.Text = file
                    jumlah = Split(TxtLocation.Text, "\").Length - 1
                    TxtJudul.Text = Split(file, "\")(jumlah)
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Can't Load File Sound", "Notifikasi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub 'AKHIR UNTUK ATUR SOUND DEFAULT ALARM
    Sub simpanfile() 'SUB UNTUK CARI DAN SIMPAN SOUND  ALARM
        Try
            If TxtLocation.Text = "" Or TxtJudul.Text = "" Then
                MessageBox.Show("File Sound Belum DiPilih", "Notifikasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                : Exit Sub
            End If
            Dim url As String
            url = TxtLocation.Text
            My.Computer.FileSystem.WriteAllText("configsound.ini", url, False)
            MessageBox.Show("File Sound Berhasil DiSimpan", "Notifikasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error Save File", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub 'AKHIR UNTUK CARI DAN SIMPAN SOUND  ALARM

    '::::::::::::::::::::::::::::::::::::::::::
    '::BATAS KUMPULAN DARI BEBERAPA SUB ALARM::
    '::::::::::::::::::::::::::::::::::::::::::


    Sub waktusekarang()
        Jam.Value = Format(Now, "HH")
        Menit.Value = Format(Now, "mm")
        Detik.Value = Format(Now, "ss")
    End Sub
    Private Sub Main_FromNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        TabControl1.Visible = False
        lblstatus.Text = "OFF"
        lblstatus.ForeColor = Color.White
        defaultsound()
        isicari()
        tampilgrid()
    End Sub

    Private Sub BtnLihatJadwal_Click(sender As Object, e As EventArgs) Handles BtnLihatJadwal.Click
        GroupJadwal.Hide()
        While (PanelMenu.Height < 592)
            PanelMenu.Height += 1
        End While
        GroupJadwal.Show()
    End Sub

    Private Sub BackArrow_Click(sender As Object, e As EventArgs) Handles BackArrow.Click
        maintitlehide()
        While (PanelMenu.Height > 96)
            PanelMenu.Height -= 1
        End While
        maintitleshow()
    End Sub

    Private Sub CloseApp_Click(sender As Object, e As EventArgs) Handles CloseApp.Click
        Dim tny As String = MsgBox("Yakin ingin tutup aplikasi ?", vbYesNo + vbInformation, "Konfirmasi")
        If tny = vbYes Then
            Application.Exit()
        End If
    End Sub

    Private Sub BtnCari_Click(sender As Object, e As EventArgs) Handles BtnCari.Click
        Tabel.Clear()
        Select Case berdasarkan.SelectedIndex
            Case 0
                sqL = "select msbooking.tanggal_sewa, msbooking.nama_team, mslapangan.nama_lpgn, msbooking.lama_sewa, msbooking.jam_masuk, msbooking.jam_keluar from msbooking INNER JOIN mslapangan ON msbooking.kode_lpgn = mslapangan.kode_lpgn where nama_team like" & Aphostrophe("%" & Cari.Text & "%") & "and tanggal_sewa like" & Aphostrophe("%" & tanggal_sewa.Text & "%")
            Case 1
                sqL = "select msbooking.tanggal_sewa, msbooking.nama_team, mslapangan.nama_lpgn, msbooking.lama_sewa, msbooking.jam_masuk, msbooking.jam_keluar from msbooking INNER JOIN mslapangan ON msbooking.kode_lpgn = mslapangan.kode_lpgn where nama_lpgn like" & Aphostrophe("%" & Cari.Text & "%") & "and tanggal_sewa like" & Aphostrophe("%" & tanggal_sewa.Text & "%")
        End Select
        Tabel = Proses.ExecuteQuery(sqL)
        If Tabel.Rows.Count > 0 Then
            MsgBox("Data yang dicara ada...!!" & Tabel.Rows.Count, vbInformation, "Apakah ini dicari")
            dgv1.DataSource = Tabel
            Cari.Clear()
        Else
            MsgBox("Data yang dicara ada...!!" & Tabel.Rows.Count, vbInformation, "Apakah ini dicari")
            Cari.Clear()
        End If
    End Sub

    Private Sub MenuMember_Click(sender As Object, e As EventArgs) Handles MenuMember.Click
        Me.Hide()
        With FrPelanggan
            .Show()
            .userid.Text = userid.Text
            .nama_ptgs.Text = nama_ptgs.Text
        End With
    End Sub

    Private Sub MenuLapangan_Click(sender As Object, e As EventArgs) Handles MenuLapangan.Click
        Me.Hide()
        With FrLapangan
            .Show()
            .userid.Text = userid.Text
            .nama_ptgs.Text = nama_ptgs.Text
        End With
    End Sub

    Private Sub MenuTransaksi_Click(sender As Object, e As EventArgs) Handles MenuTransaksi.Click
        Me.Hide()
        With Pembayaran
            .Show()
            .userid.Text = userid.Text
            .nama_ptgs.Text = nama_ptgs.Text
        End With
    End Sub

    Private Sub MenuLaporan_Click(sender As Object, e As EventArgs) Handles MenuLaporan.Click
        Me.Hide()
        FrLaporan.Show()
    End Sub


    Private Sub tanggal_sewa_ValueChanged(sender As Object, e As EventArgs) Handles tanggal_sewa.ValueChanged

    End Sub

    Private Sub MenuBooking_Click(sender As Object, e As EventArgs) Handles MenuBooking.Click
        Me.Hide()
        With Booking
            .Show()
            .userid.Text = userid.Text
            .nama_ptgs.Text = nama_ptgs.Text
        End With
    End Sub

    Private Sub MenuAdmin_Click(sender As Object, e As EventArgs)
        Me.Hide()
        With FrPetugas
            .Show()
        End With
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        Tabel.Clear()
    End Sub

    Private Sub BtnTampil_Click(sender As Object, e As EventArgs) Handles BtnTampil.Click
        sqL = "select msbooking.tanggal_sewa, msbooking.nama_team, mslapangan.nama_lpgn, msbooking.lama_sewa, msbooking.jam_masuk, msbooking.jam_keluar from msbooking INNER JOIN mslapangan ON msbooking.kode_lpgn = mslapangan.kode_lpgn"
        Tabel = Proses.ExecuteQuery(sqL)
        MsgBox("Menampilkan Semua Jadwal Sewa", vbInformation, "Notice")
        dgv1.DataSource = Tabel
    End Sub

    Private Sub BtnCetak_Click(sender As Object, e As EventArgs) Handles BtnCetak.Click
        report_jadwal.Show()
    End Sub

    Private Sub Panel2_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel2.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Panel2_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel2.MouseMove
        If drag Then
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
        End If
    End Sub

    Private Sub Panel2_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel2.MouseUp
        drag = False
    End Sub

    Private Sub ASimpan_Click(sender As Object, e As EventArgs) Handles ASimpan.Click
        aktifalarm()
    End Sub

    Private Sub Atutup_Click(sender As Object, e As EventArgs) Handles Atutup.Click
        TabControl1.Visible = False
    End Sub

    Private Sub Jam_ValueChanged(sender As Object, e As EventArgs) Handles Jam.ValueChanged
        If Jam.Value > 24 Then
            Jam.Value = 1
        End If
    End Sub

    Private Sub Menit_ValueChanged(sender As Object, e As EventArgs) Handles Menit.ValueChanged
        If Menit.Value > 60 Then
            Menit.Value = 1
        End If
    End Sub

    Private Sub Detik_ValueChanged(sender As Object, e As EventArgs) Handles Detik.ValueChanged
        If Detik.Value > 60 Then
            Detik.Value = 1
        End If
    End Sub

    Private Sub TxtJudul_TextChanged(sender As Object, e As EventArgs) Handles TxtJudul.TextChanged

    End Sub

    Private Sub TxtLocation_TextChanged(sender As Object, e As EventArgs) Handles TxtLocation.TextChanged

    End Sub

    Private Sub BtnPlay_Click(sender As Object, e As EventArgs) Handles BtnPlay.Click
        Dim a As String
        a = TxtLocation.Text
        If a = "" Or TxtJudul.Text = "" Then
            MessageBox.Show("File Sound Tidak Ada", "Notifikasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            : Exit Sub
        Else
            My.Computer.Audio.Play(a, AudioPlayMode.Background)
        End If
    End Sub

    Private Sub BtnOpen_Click(sender As Object, e As EventArgs) Handles BtnOpen.Click
        OpenFileDialog1.Title = "Selected File"
        OpenFileDialog1.FileName = ""
        With OpenFileDialog1
            .InitialDirectory = Application.StartupPath + "\Sound"
            .Filter = "WAV (*.wav)|*.wav"

        End With

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then

            Dim nStr As String = Me.OpenFileDialog1.FileName.Substring(Me.OpenFileDialog1.FileName.LastIndexOf("\") + 1)
            Me.TxtJudul.Text = nStr
            Me.TxtLocation.Text = Me.OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        simpanfile()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        Try


            If TxtAktif.Text = TxtTime.Text Then
                Dim sound As String
                Dim file As String
                Using temp As New IO.StreamReader("configsound.ini")
                    file = temp.ReadLine
                    If file = "" Then
                        defaultsound()
                        file = Application.StartupPath + "\sound\alarm1.wav"
                        My.Computer.Audio.Play(file, AudioPlayMode.BackgroundLoop)
                    Else
                        sound = file
                        My.Computer.Audio.Play(file, AudioPlayMode.BackgroundLoop)
                    End If
                End Using
                NotifikasiAlarm.Show()
                Timer2.Enabled = False
            End If
        Catch ex As Exception
            NotifikasiAlarm.Show()
            Timer2.Enabled = False
        End Try
    End Sub

    Private Sub BtnAlarm_Click(sender As Object, e As EventArgs) Handles BtnAlarm.Click
        TabControl1.Visible = True
        waktusekarang()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LabelTgl.Text = Format(Now, "dd - MMM - yyyy")
        TxtTime.Text = Format(Now, "HH : mm : ss")
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Dim tny As String = MsgBox("Yakin ingin LogOut ?", vbYesNo + vbInformation, "Konfirmasi")
        If tny = vbYes Then
            Me.Close()
            Login.Show()
            Login.bersih()
        End If
    End Sub

    Private Sub BtnPetugas_Click(sender As Object, e As EventArgs) Handles BtnPetugas.Click
        Me.Hide()
        With FrPetugas
            .Show()
        End With
    End Sub

   
    Private Sub resetAR_Click(sender As Object, e As EventArgs) Handles resetAR.Click
        stopalarm()
    End Sub

End Class