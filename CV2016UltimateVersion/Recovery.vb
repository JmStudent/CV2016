Partial Class Recovery
    Dim ad As New DataAccess
    Private bv As New Behavior
    Private Const emailTxtDefault As String = "Email Usuario"

    Private Sub Recovery_Load(sender As Object, e As EventArgs) Handles Me.Load
        tbxEmail.ForeColor = Color.Gray
        tbxEmail.Text = emailTxtDefault
    End Sub

    ' FUNCTIONS FOR DISPLAYING TOOLTIPS --------------------------------------------------------------------

    Private Sub tbxEmail_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles tbxEmail.Enter
        bv.changeColor(tbxEmail, emailTxtDefault)
    End Sub

    Private Sub tbxEmail_Leave(sender As Object, e As EventArgs) Handles tbxEmail.Leave
        bv.changeColor(tbxEmail, emailTxtDefault)
    End Sub

    Private Sub btnRecovery_Click(sender As Object, e As EventArgs) Handles btnRecovery.Click
        Dim Query As String
        Dim RecordsDs As DataSet
        Dim correctEmail As Boolean = False

        If tbxEmail.Text = emailTxtDefault Then
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
                Dim newPW = CreateNewPW(12, False)
                GMailSender("gp1visualbasic@gmail.com", "GRUPO1VB", "Recuperación de contraseña", "La contraseña registrada en nuestra Base de datos es: " & ("gp1" & newPW), tbxEmail.Text)
                MessageBox.Show("Se le ha enviado la contraseña a su correo", "Aviso de recuperación", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Query = "UPDATE usuarios SET pw = 'gp1" & newPW & "' WHERE dni = (SELECT dni FROM perfil WHERE email = '" & tbxEmail.Text & "')"
                ad.cud(Query)
                tbxEmail.ForeColor = Color.Gray
                tbxEmail.Text = emailTxtDefault
            Else
                MessageBox.Show("El email introducido no pertenece a ningún usuario registrado", "Aviso de recuperación", MessageBoxButtons.OK, MessageBoxIcon.Error)
                tbxEmail.ForeColor = Color.Gray
                tbxEmail.Text = emailTxtDefault
            End If
        Else
            MessageBox.Show("No se ha podido restablecer la contraseña", "Aviso de recuperación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub lblLogin_Click(sender As Object, e As EventArgs) Handles lblLogin.Click
        Login.Show()
        Me.Close()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim res As Integer

        res = MessageBox.Show("¿Está seguro que desea salir?", "Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If res = 6 Then
            Application.Exit()
        End If
    End Sub

    Private Sub lblHome_Click(sender As Object, e As EventArgs) Handles lblHome.Click
        Login.Show()
        Me.Close()
    End Sub

End Class