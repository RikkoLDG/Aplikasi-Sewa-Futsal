Public Class SplashScreen
    Sub FadeIn()
        Do Until Me.Opacity = 1
            Me.Opacity += 0.00002
            Application.DoEvents()
        Loop
    End Sub

    Sub FadeOut()
        Do Until Me.Opacity = 0
            Me.Opacity -= 0.0002
            Application.DoEvents()
        Loop
        If Me.Opacity = 0 Then
            With Login
                .Show()
            End With
            Me.Close()
        End If
    End Sub

    Sub Tunggu()
        Dim Hitung = 3000000
        Do Until Hitung = 0
            Hitung -= 1
            Application.DoEvents()
        Loop
    End Sub

    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Opacity = 0
        FadeIn()
        Tunggu()
        FadeOut()
    End Sub
End Class