Public Class RetryPass
    Dim ad As New DataAccess
    Private isMouseDown As Boolean = False
    Private mouseOffset As Point
    Private bv As New Behavior
    Private Const newPW As String = "Contraseña Nueva"
    Private Const confirmNewPW As String = "Confirma Contraseña Nueva"
    Private Sub RetryPass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbxNewPass.ForeColor = Color.Gray
        tbxNewPass2.ForeColor = Color.Gray
        tbxNewPass.Text = newPW
        tbxNewPass2.Text = confirmNewPW
        Dim dni = RecoveryData.dni
    End Sub

    ' FUNCTIONS FOR WINDOW MOVEMENT ------------------------------------------------------------------------

    ' Left mouse button pressed
    Private Sub Register_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        If e.Button = sender.MouseButtons.Left Then
            ' Get the new position
            mouseOffset = New Point(-e.X, -e.Y)
            ' Set that left button is pressed
            isMouseDown = True
        End If
    End Sub

    ' MouseMove used to check if mouse cursor is moving
    Private Sub Register_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If isMouseDown Then
            Dim mousePos As Point = Control.MousePosition
            ' Get the new form position
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Me.Location = mousePos
        End If
    End Sub

    ' Left mouse button released, form should stop moving
    Private Sub Register_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        If e.Button = sender.MouseButtons.Left Then
            isMouseDown = False
        End If
    End Sub

    ' ------------------------------------------------------------------------------------------------------
    ' FUNCTIONS FOR DISPLAYING TOOLTIPS --------------------------------------------------------------------

    Private Sub tbxNewPass_Leave(sender As Object, e As EventArgs) Handles tbxNewPass.Leave
        bv.changeColor(tbxNewPass, newPW)
    End Sub

    Private Sub tbxNewPass2_Leave(sender As Object, e As EventArgs) Handles tbxNewPass2.Leave
        bv.changeColor(tbxNewPass2, confirmNewPW)
    End Sub

    Private Sub btnRetry_Click(sender As Object, e As EventArgs) Handles btnRetry.Click
        Dim Query As String
        Dim correct As Boolean = False

        If tbxNewPass.Text = newPW Then
            epPW.SetError(tbxNewPass, "El campo Contraseña no puede estar vacío")
        Else
            epPW.Clear()
        End If

        If tbxNewPass2.Text = confirmNewPW Then
            epConfirmPW.SetError(tbxNewPass2, "El campo Confirmar Contraseña Nueva no puede estar vacío")
        Else
            epConfirmPW.Clear()
        End If

        If tbxNewPass.Text <> tbxNewPass2.Text Then
            epPW.SetError(tbxNewPass, "Las contraseñas son diferentes")
            epConfirmPW.SetError(tbxNewPass2, "Las contraseñas son diferentes")
        Else
            epPW.Clear()
            epConfirmPW.Clear()
        End If

        If checkPW(tbxNewPass.Text) Then
            correct = True
            epPW.Clear()
        Else
            epPW.SetError(tbxNewPass, "Debe introducir una contraseña de 8 a 16 caracteres (minimo 1 digito, 1 mayúscula y 1 minúscula")
            correct = False
        End If

        If correct Then
            Dim pwMD5 = Encriptar(tbxNewPass.Text)
            Query = "UPDATE usuarios SET pw = '" & pwMD5 & "' WHERE dni = '" & dni & "')"
            ad.cud(Query)
            MessageBox.Show("Contraseña modificada con éxito", "Cambio de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            tbxNewPass.ForeColor = Color.Gray
            tbxNewPass2.ForeColor = Color.Gray
            tbxNewPass.Text = newPW
            tbxNewPass2.Text = confirmNewPW
            MessageBox.Show("No se ha modificado la contraseña", "Cambio de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If
    End Sub

    Private Sub btnClose_Click_1(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim res As Integer

        res = MessageBox.Show("¿Está seguro que desea salir?", "Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If res = 6 Then
            Application.Exit()
        End If
    End Sub

    Private Sub lblLogin_Click(sender As Object, e As EventArgs) Handles lblLogin.Click
        Login.Show()
        Me.Close()
    End Sub
End Class