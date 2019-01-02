Public Class Main_Form


    Private Sub DataPetugasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataPetugasToolStripMenuItem.Click
        With FrPetugas
            .MdiParent = Me
            .Show()
            .Top = 0
            .Left = 0
        End With
    End Sub

    Private Sub DataPelangganToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataPelangganToolStripMenuItem.Click
        With FrPelanggan
            .MdiParent = Me
            .Show()
            .Top = 0
            .Left = 0
        End With
    End Sub
    Private Sub DataLapanganToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BookingLapanganToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TransaksiPembayaranToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransaksiPembayaranToolStripMenuItem.Click
        With Pembayaran
            .MdiParent = Me
            .Show()
            .Top = 0
            .Left = 0
        End With
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Dim tny As String = MsgBox("Yakin ingin Log out ?", vbYesNo + vbInformation, "konfirmasi")
        If tny = vbYes Then
            With Login
                .user.Clear()
                .password.Clear()
                .tampilgrid()
                .Show()
                .user.Focus()
                .isihak()
            End With
            Me.Close()
        End If
    End Sub

    Private Sub DataBookingToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BookingLapanganToolStripMenuItem_Click_1(sender As Object, e As EventArgs)

    End Sub
    Private Sub TambahUserToolStripMenuItem_Click(sender As Object, e As EventArgs)
        With TambahUser
            .MdiParent = Me
            .Show()
            .Top = 0
            .Left = 0
        End With
    End Sub

    Private Sub DataBookingToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles DataBookingToolStripMenuItem.Click
        With Booking
            .MdiParent = Me
            .Show()
            .Top = 0
            .Left = 0
        End With
    End Sub
End Class