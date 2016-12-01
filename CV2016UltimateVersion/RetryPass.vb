Public Class RetryPass
    Private Sub RetryPass_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnClose_Click_1(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim res As Integer

        res = MessageBox.Show("¿Está seguro que desea salir?", "Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If res = 6 Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnRetry_Click(sender As Object, e As EventArgs) Handles btnRetry.Click

    End Sub

    Private Sub lblLogin_Click(sender As Object, e As EventArgs) Handles lblLogin.Click
        Login.Show()
        Me.Close()
    End Sub
End Class