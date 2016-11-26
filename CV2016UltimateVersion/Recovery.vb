Public Class Recovery
    Dim ad As New DataAccess
    Private isMouseDown As Boolean = False
    Private mouseOffset As Point

    Private Sub Recovery_Load(sender As Object, e As EventArgs) Handles Me.Load
        tbxEmail.ForeColor = Color.Gray
        tbxEmail.Text = "Email Usuario"
    End Sub

    ' FUNCTIONS FOR WINDOW MOVEMENT ------------------------------------------------------------------------

    ' Left mouse button pressed
    Private Sub Recovery_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        If e.Button = sender.MouseButtons.Left Then
            ' Get the new position
            mouseOffset = New Point(-e.X, -e.Y)
            ' Set that left button is pressed
            isMouseDown = True
        End If
    End Sub

    ' MouseMove used to check if mouse cursor is moving
    Private Sub Recovery_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If isMouseDown Then
            Dim mousePos As Point = Control.MousePosition
            ' Get the new form position
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Me.Location = mousePos
        End If
    End Sub

    ' Left mouse button released, form should stop moving
    Private Sub Recovery_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        If e.Button = sender.MouseButtons.Left Then
            isMouseDown = False
        End If
    End Sub

    ' ------------------------------------------------------------------------------------------------------
    ' FUNCTIONS FOR DISPLAYING TOOLTIPS --------------------------------------------------------------------

    Private Sub tbxEmail_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles tbxEmail.Enter
        If tbxEmail.Text = "Email Usuario" Then
            tbxEmail.ForeColor = Color.Black
            tbxEmail.Text = ""
        End If
    End Sub

    Private Sub tbxEmail_Leave(sender As Object, e As EventArgs) Handles tbxEmail.Leave
        If tbxEmail.Text = String.Empty Then
            tbxEmail.ForeColor = Color.Gray
            tbxEmail.Text = "Email Usuario"
        End If
    End Sub

    Private Sub btnRecovery_Click(sender As Object, e As EventArgs) Handles btnRecovery.Click
        Dim Query As String
        Dim RecordsDs As DataSet
        Dim correctEmail As Boolean = False

        If tbxEmail.Text = "Email Usuario" Then
            epEmail.SetError(tbxEmail, "El campo Email no puede estar vacío")
        Else
            epEmail.Clear()
        End If

        If isEmail(tbxEmail.Text) Then
            correctEmail = True
            epEmail.Clear()
        Else
            epEmail.SetError(tbxEmail, "Debe insertar un Email correcto")
            correctEmail = False
        End If

        If correctEmail Then
            Query = "SELECT pw FROM usuarios where dni = (SELECT dni FROM perfil WHERE email = '" & tbxEmail.Text & "')"
            RecordsDs = ad.query(Query)
            If RecordsDs.Tables(0).Rows().Count = 1 Then
                GMailSender("gp1visualbasic@gmail.com", "GRUPO1VB", "Recuperación de contraseña", "La contraseña registrada en nuestra Base de datos es: " & Desencriptar(RecordsDs.Tables(0).Rows(0).Item(0)), tbxEmail.Text)
                MessageBox.Show("Se le ha enviado la contraseña a su correo", "Aviso de recuperación", MessageBoxButtons.OK, MessageBoxIcon.Error)
                tbxEmail.ForeColor = Color.Gray
                tbxEmail.Text = "Email Usuario"
            Else
                MessageBox.Show("El email introducido no pertenece a ningún usuario registrado", "Aviso de recuperación", MessageBoxButtons.OK, MessageBoxIcon.Error)
                tbxEmail.ForeColor = Color.Gray
                tbxEmail.Text = "Email Usuario"
            End If
        Else
            MessageBox.Show("No se ha podido restablecer la contraseña", "Aviso de recuperación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub lblLogin_Click(sender As Object, e As EventArgs) Handles lblLogin.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim res As Integer

        res = MsgBox("¿Está seguro que desea salir?", vbYesNo)
        If res = 6 Then
            Application.Exit()
        End If
    End Sub

    Private Sub lblHome_Click(sender As Object, e As EventArgs) Handles lblHome.Click
        Me.Hide()
        Login.Show()
    End Sub


End Class