Imports Microsoft.Win32
Imports System.IO
Public Class Main_formOP
    Sub waktusekarang()
        Jam.Value = Format(Now, "HH")
        Menit.Value = Format(Now, "mm")
        Detik.Value = Format(Now, "ss")
    End Sub
    Sub tampilgrid()
        'sqL = "select nama_team, kode_lpgn, tanggal_sewa, lama_Sewa, jam_masuk, jam_keluar from msbooking where tanggal_sewa like" & Aphostrophe("%" & tanggal_sewa.Text & "%")
        sqL = "select msbooking.tanggal_sewa, msbooking.nama_team, mslapangan.nama_lpgn, msbooking.lama_sewa, msbooking.jam_masuk, msbooking.jam_keluar from msbooking INNER JOIN mslapangan ON msbooking.kode_lpgn = mslapangan.kode_lpgn where tanggal_sewa like" & Aphostrophe("%" & tanggal_sewa.Text & "%")
        Tabel = Proses.ExecuteQuery(sqL)
        dgv1.DataSource = Tabel
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
                MessageBox.Show("Pilih File Sound Terlebih Dahulu", "CoretanCode", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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
                    MessageBox.Show("Alarm Aktif", "CoretanCode", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    lblstatus.Text = "ON"
                    lblstatus.ForeColor = Color.Green
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error Set Alarm", "CoretanCode", MessageBoxButtons.OK, MessageBoxIcon.Error)
            : Exit Sub
        End Try
    End Sub 'AKHIR UNTUK SUB PASANG ALARM
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
            MessageBox.Show("Can't Load File Sound", "CoretanCode", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub 'AKHIR UNTUK ATUR SOUND DEFAULT ALARM
    Sub simpanfile() 'SUB UNTUK CARI DAN SIMPAN SOUND  ALARM
        Try
            If TxtLocation.Text = "" Or TxtJudul.Text = "" Then
                MessageBox.Show("File Sound Belum DiPilih", "CoretanCode", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                : Exit Sub
            End If
            Dim url As String
            url = TxtLocation.Text
            My.Computer.FileSystem.WriteAllText("configsound.ini", url, False)
            MessageBox.Show("File Sound Berhasil DiSimpan", "CoretanCode", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error Save File", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub 'AKHIR UNTUK CARI DAN SIMPAN SOUND  ALARM

    '::::::::::::::::::::::::::::::::::::::::::
    '::BATAS KUMPULAN DARI BEBERAPA SUB ALARM::
    '::::::::::::::::::::::::::::::::::::::::::

    Private Sub Main_formOP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        tampilgrid()
        GroupAlarm.Visible = False
        lblstatus.Text = "OFF"
        lblstatus.ForeColor = Color.Black
        defaultsound()
        isicari()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LabelTgl.Text = Format(Now, "dd - MMM - yyyy")
        TxtTime.Text = Format(Now, "HH : mm : ss")
    End Sub

    Private Sub MenuMember_Click(sender As Object, e As EventArgs) Handles MenuMember.Click
        Me.Hide()
        With FrPelanggan
            .Show()
            .userid.Text = userid.Text
            .nama_ptgs.Text = nama_ptgs.Text
        End With
    End Sub

    Private Sub MenuBooking_Click(sender As Object, e As EventArgs) Handles MenuBooking.Click
        Me.Hide()
        With Booking
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

    Private Sub tanggal_sewa_ValueChanged(sender As Object, e As EventArgs) Handles tanggal_sewa.ValueChanged
        tampilgrid()
    End Sub

    Private Sub MenuTransaksi_Click(sender As Object, e As EventArgs) Handles MenuTransaksi.Click
        Me.Hide()
        With Pembayaran
            .Show()
            .userid.Text = userid.Text
            .nama_ptgs.Text = nama_ptgs.Text
        End With
    End Sub


    Private Sub Menit_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Jam_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Detik_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnSet_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MenuAlarm_Click(sender As Object, e As EventArgs) Handles MenuAlarm.Click
        GroupAlarm.Visible = True
        waktusekarang()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        GroupAlarm.Visible = False
        defaultsound()
    End Sub

    Private Sub Jam_ValueChanged_1(sender As Object, e As EventArgs) Handles Jam.ValueChanged
        If Jam.Value > 24 Then
            Jam.Value = 1
        End If
    End Sub

    Private Sub Menit_ValueChanged_1(sender As Object, e As EventArgs) Handles Menit.ValueChanged
        If Menit.Value > 60 Then
            Menit.Value = 1
        End If
    End Sub

    Private Sub Detik_ValueChanged_1(sender As Object, e As EventArgs) Handles Detik.ValueChanged
        If Detik.Value > 60 Then
            Detik.Value = 1
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        aktifalarm()
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

    Private Sub BtnPlay_Click(sender As Object, e As EventArgs) Handles BtnPlay.Click
        Dim a As String
        a = TxtLocation.Text
        If a = "" Or TxtJudul.Text = "" Then
            MessageBox.Show("File Sound Tidak Ada", "CoretanCode", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            : Exit Sub
        Else
            My.Computer.Audio.Play(a, AudioPlayMode.Background)
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

    Private Sub LogOut_Click(sender As Object, e As EventArgs) Handles LogOut.Click
        Me.Close()
        Login.Show()
        Login.bersih()
    End Sub

    Private Sub MenuAdmin_Click(sender As Object, e As EventArgs) Handles MenuAdmin.Click
        Me.Hide()
        With FrPetugas
            .Show()
        End With
    End Sub

    Private Sub BtnCari_Click(sender As Object, e As EventArgs) Handles BtnCari.Click
        Select Case berdasarkan.SelectedIndex
            Case 0
                sqL = "select msbooking.tanggal_sewa, msbooking.nama_team, mslapangan.nama_lpgn, msbooking.lama_sewa, msbooking.jam_masuk, msbooking.jam_keluar from msbooking INNER JOIN mslapangan ON msbooking.kode_lpgn = mslapangan.kode_lpgn where nama_team like" & Aphostrophe("%" & Cari.Text & "%")
            Case 1
                sqL = "select msbooking.tanggal_sewa, msbooking.nama_team, mslapangan.nama_lpgn, msbooking.lama_sewa, msbooking.jam_masuk, msbooking.jam_keluar from msbooking INNER JOIN mslapangan ON msbooking.kode_lpgn = mslapangan.kode_lpgn where nama_lpgn like" & Aphostrophe("%" & Cari.Text & "%")
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

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        tampilgrid()
    End Sub

    Private Sub MenuLaporan_Click(sender As Object, e As EventArgs) Handles MenuLaporan.Click
        Me.Hide()
        FrLaporan.Show()
    End Sub

    Private Sub dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub TxtJudul_TextChanged(sender As Object, e As EventArgs) Handles TxtJudul.TextChanged

    End Sub

    Private Sub TxtLocation_TextChanged(sender As Object, e As EventArgs) Handles TxtLocation.TextChanged

    End Sub

    Private Sub lblstatus_Click(sender As Object, e As EventArgs) Handles lblstatus.Click

    End Sub

    Private Sub TxtAktif_Click(sender As Object, e As EventArgs) Handles TxtAktif.Click

    End Sub

    Private Sub TxtTime_Click(sender As Object, e As EventArgs) Handles TxtTime.Click

    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub
End Class