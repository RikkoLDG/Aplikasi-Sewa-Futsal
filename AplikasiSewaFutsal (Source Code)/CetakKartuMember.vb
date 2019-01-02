Imports System.Drawing.Printing

Public Class CetakKartuMember
    Sub tutup()
        kode_member.Enabled = False
        nama.Enabled = False
        nama_team.Enabled = False
        notelp.Enabled = False
    End Sub
    Sub btnAwal()
        BtnCetak.Visible = True
        BtnKembali.Visible = True
    End Sub
    Sub btnhide()
        BtnCetak.Visible = False
        BtnKembali.Visible = False
    End Sub
    Private Sub CetakKartuMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tutup()
    End Sub

    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles BtnKembali.Click
        Me.Close()
        FrPelanggan.Show()
    End Sub
    Private Sub BtnCetak_Click(sender As Object, e As EventArgs) Handles BtnCetak.Click
        btnhide()
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
        btnAwal()
    End Sub
End Class