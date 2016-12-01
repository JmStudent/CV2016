Public Class Register
    Dim ad As New DataAccess
    Private isMouseDown As Boolean = False
    Private mouseOffset As Point
    Private bv As New Behavior
    Private Const userTxtDefault As String = "DNI Usuario"
    Private Const emailTxtDefault As String = "Email Usuario"
    Private Const pwTxtDefault As String = "Password"
    Private Const pwCTxtDefault As String = "Confirma Password"

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles Me.Load
        tbxUser.ForeColor = Color.Gray
        tbxEmail.ForeColor = Color.Gray
        tbxPW.ForeColor = Color.Gray
        tbxConfirmPW.ForeColor = Color.Gray
        tbxUser.Text = userTxtDefault
        tbxEmail.Text = emailTxtDefault
        tbxPW.Text = pwTxtDefault
        tbxConfirmPW.Text = pwCTxtDefault
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

    Private Sub tbxUser_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles tbxUser.Enter
        bv.changeColor(tbxUser, userTxtDefault)
    End Sub

    Private Sub tbxEmail_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles tbxEmail.Enter
        bv.changeColor(tbxEmail, emailTxtDefault)
    End Sub

    Private Sub tbxPW_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles tbxPW.Enter
        bv.changeColor(tbxPW, pwTxtDefault)
    End Sub

    Private Sub tbxConfirmPW_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles tbxConfirmPW.Enter
        bv.changeColor(tbxConfirmPW, pwCTxtDefault)
    End Sub

    Private Sub tbxUser_Leave(sender As Object, e As EventArgs) Handles tbxUser.Leave
        bv.changeColor(tbxUser, userTxtDefault)
    End Sub

    Private Sub tbxEmail_Leave(sender As Object, e As EventArgs) Handles tbxEmail.Leave
        bv.changeColor(tbxEmail, emailTxtDefault)
    End Sub

    Private Sub tbxPW_Leave(sender As Object, e As EventArgs) Handles tbxPW.Leave
        bv.changeColor(tbxPW, pwTxtDefault)
    End Sub

    Private Sub tbxConfirmPW_Leave(sender As Object, e As EventArgs) Handles tbxConfirmPW.Leave
        bv.changeColor(tbxConfirmPW, pwCTxtDefault)
    End Sub

    ' ------------------------------------------------------------------------------------------------------

    Private Sub btRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim Query As String
        Dim RecordsDs As DataSet
        Dim correct As Boolean = False
        Dim correctNIF As Boolean = False
        Dim correctEmail As Boolean = False

        If tbxUser.Text = userTxtDefault Then
            epUser.SetError(tbxUser, "El campo DNI no puede estar vacío")
        Else
            epUser.Clear()
        End If

        If tbxEmail.Text = emailTxtDefault Then
            epEmail.SetError(tbxEmail, "El campo Email no puede estar vacío")
        Else
            epEmail.Clear()
        End If

        If tbxPW.Text = pwTxtDefault Then
            epPW.SetError(tbxPW, "El campo Password no puede estar vacío")
        Else
            epPW.Clear()
        End If

        If tbxConfirmPW.Text = pwCTxtDefault Then
            epConfirmPW.SetError(tbxConfirmPW, "El campo Confirmar Password no puede estar vacío")
        Else
            epConfirmPW.Clear()
        End If

        If checkNIF(tbxUser.Text) Then
            correctNIF = True
            epUser.Clear()
        Else
            epUser.SetError(tbxUser, "Debe insertar un DNI correcto. El formato correcto es 12345678Z")
            correctNIF = False
        End If

        If isEmail(tbxEmail.Text) Then
            correctEmail = True
            epEmail.Clear()
        Else
            epEmail.SetError(tbxEmail, "Debe insertar un Email correcto")
            correctEmail = False
        End If

        If checkPW(tbxPW.Text) Then
            If tbxPW.Text <> tbxConfirmPW.Text Then
                epPW.SetError(tbxPW, "Las contraseñas son diferentes")
                epConfirmPW.SetError(tbxConfirmPW, "Las contraseñas son diferentes")
            Else
                correct = True
                epPW.Clear()
                epConfirmPW.Clear()
            End If
        Else
            epPW.SetError(tbxPW, "Debe introducir una contraseña de 8 a 16 caracteres (minimo 1 digito, 1 mayúscula y 1 minúscula")
            correct = False
        End If

        If correct And correctEmail And correctNIF Then
            Query = "SELECT dni FROM usuarios where dni = '" & tbxUser.Text & "'"
            RecordsDs = ad.query(Query)
            If RecordsDs.Tables(0).Rows().Count = 1 Then
                MessageBox.Show("Este usuario ya ha sido registrado en la BD", "Aviso de registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                tbxPW.UseSystemPasswordChar = False
                tbxConfirmPW.UseSystemPasswordChar = False
                tbxUser.ForeColor = Color.Gray
                tbxEmail.ForeColor = Color.Gray
                tbxPW.ForeColor = Color.Gray
                tbxConfirmPW.ForeColor = Color.Gray
                tbxUser.Text = userTxtDefault
                tbxEmail.Text = emailTxtDefault
                tbxPW.Text = pwTxtDefault
                tbxConfirmPW.Text = pwCTxtDefault
            Else
                Dim pwMD5 = Encriptar(tbxPW.Text)
                Query = "INSERT INTO usuarios VALUES('" & tbxUser.Text.ToUpper & "','" & pwMD5 & "', 0)"
                ad.cud(Query)
                MessageBox.Show("Usuario registrado con éxito. El administrador debe desbloquear su cuenta", "Aviso de registro", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Query = "INSERT INTO perfil (dni, email) VALUES('" & tbxUser.Text & "','" & tbxEmail.Text & "')"
                ad.cud(Query)
                tbxPW.UseSystemPasswordChar = False
                tbxConfirmPW.UseSystemPasswordChar = False
                tbxUser.ForeColor = Color.Gray
                tbxEmail.ForeColor = Color.Gray
                tbxPW.ForeColor = Color.Gray
                tbxConfirmPW.ForeColor = Color.Gray
                tbxUser.Text = userTxtDefault
                tbxEmail.Text = emailTxtDefault
                tbxPW.Text = pwTxtDefault
                tbxConfirmPW.Text = pwCTxtDefault
            End If
        Else
            MessageBox.Show("No se han podido insertar los datos", "Aviso de registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
End Class
