Public Class NotifikasiAlarm

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        My.Computer.Audio.Stop()
        Me.Close()
        Main_formOP.Timer2.Stop()
        Main_formOP.lblstatus.Text = "OFF"
        Main_formOP.lblstatus.ForeColor = Color.Black
    End Sub
End Class