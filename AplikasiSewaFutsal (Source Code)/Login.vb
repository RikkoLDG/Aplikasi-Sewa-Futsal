Public Class Login
    Sub tampilgrid()
        sqL = "select * from mspetugas"
        Tabel = Proses.ExecuteQuery(sqL)
        dgv2.DataSource = Tabel
    End Sub
    Sub isihak()
        hak.Items.Clear()
        hak.Items.Add("Karyawan")
        hak.Items.Add("Admin")
        hak.SelectedIndex = 0
    End Sub
    Sub bersih()
        user.Clear()
        password.Clear()
        hak.SelectedIndex = 0
    End Sub
    Sub isi()
        With dgv2
            If .RowCount > 0 Then
                idptgs.Text = .Item("idptgs", .CurrentRow.Index).Value
                nama.Text = .Item("nama", .CurrentRow.Index).Value
            End If
        End With
    End Sub
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ServerName = ".\SQLEXPRESS"
        userServer = "rrl"
        PasServer = "1234"
        tampilgrid()
        'notice.Visible = False
        isihak()
        bersih()
        password.PasswordChar = "*"
        SplashScreen.Close()
    End Sub
    Private Sub BtnLogin_Click_1(sender As Object, e As EventArgs) Handles BtnLogin.Click
        sqL = "Select * from mspetugas where username=" & Aphostrophe(user.Text) &
              " and password=" & Aphostrophe(password.Text) &
              " and hak=" & Aphostrophe(hak.Text)
        Tabel = Proses.ExecuteQuery(sqL)
        If Tabel.Rows.Count > 0 And hak.SelectedIndex = 1 Then
            sqL = "Select idptgs, nama  from mspetugas where username like" & Aphostrophe("%" & user.Text & "%") &
            "and password like" & Aphostrophe("%" & password.Text & "%") &
            "and hak like" & Aphostrophe("%" & hak.Text & "%")
            Tabel = Proses.ExecuteQuery(sqL)
            dgv2.DataSource = Tabel
            isi()
            With Main_FromNew
                .Show()
                .MenuAdmin.Visible = True
                .userid.Text = idptgs.Text
                .nama_ptgs.Text = nama.Text
            End With
            Me.Hide()
        ElseIf Tabel.Rows.Count > 0 Then
            sqL = "Select idptgs, nama from mspetugas where username like" & Aphostrophe("%" & user.Text & "%") &
           "and password like" & Aphostrophe("%" & password.Text & "%") &
           "and hak like" & Aphostrophe("%" & hak.Text & "%")
            Tabel = Proses.ExecuteQuery(sqL)
            dgv2.DataSource = Tabel
            isi()
            With Main_FromNew
                .Show()
                .MenuAdmin.Visible = False
                .userid.Text = idptgs.Text
                .nama_ptgs.Text = nama.Text
            End With
            Me.Hide()
        Else
            MsgBox("Username atau Password Salah !!", vbCritical, "Coba Masukan Kembali")
            user.Clear()
            password.Clear()
            user.Focus()
        End If
    End Sub

   
   
    Private Sub bersih_Click(sender As Object, e As EventArgs)
        user.Clear()
        password.Clear()
        user.Focus()
    End Sub

    Private Sub Keluar_Click(sender As Object, e As EventArgs) Handles Keluar.Click
        Dim tny As String = MsgBox("Yakin ingin Keluar Aplikasi ?", vbYesNo + vbInformation, "Konfirmasi")
        If tny = vbYes Then
            Application.Exit()
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            password.PasswordChar = ""
        ElseIf CheckBox1.Checked = False Then
            password.PasswordChar = "*"
        End If
    End Sub

    Private Sub CloseApp_Click(sender As Object, e As EventArgs) Handles CloseApp.Click
        Dim tny As String = MsgBox("Yakin ingin Keluar Aplikasi ?", vbYesNo + vbInformation, "Konfirmasi")
        If tny = vbYes Then
            Application.Exit()
        End If
    End Sub
    Dim tip_klr As New ToolTip()
    Private Sub CloseApp_MouseHover(sender As Object, e As EventArgs) Handles CloseApp.MouseHover
        tip_klr.SetToolTip(Me.CloseApp, "Yakin ?")
    End Sub

    Private Sub Minimize_Click(sender As Object, e As EventArgs) Handles Minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    
End Class