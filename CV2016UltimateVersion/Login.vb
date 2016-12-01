Public Class Login
    Private isMouseDown As Boolean = False
    Private mouseOffset As Point
    Private bv As New Behavior
    Private Const userTxtDefault As String = "DNI Usuario"
    Private Const pwTxtDefault As String = "Password"
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbxUser.ForeColor = Color.Gray
        tbxPW.ForeColor = Color.Gray
        tbxUser.Text = userTxtDefault
        tbxPW.Text = pwTxtDefault
    End Sub
    ' FUNCTIONS FOR WINDOW MOVEMENT ------------------------------------------------------------------------

    ' Left mouse button pressed
    Private Sub Login_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        If e.Button = sender.MouseButtons.Left Then
            ' Get the new position
            mouseOffset = New Point(-e.X, -e.Y)
            ' Set that left button is pressed
            isMouseDown = True
        End If
    End Sub

    ' MouseMove used to check if mouse cursor is moving
    Private Sub Login_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If isMouseDown Then
            Dim mousePos As Point = Control.MousePosition
            ' Get the new form position
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Me.Location = mousePos
        End If
    End Sub

    ' Left mouse button released, form should stop moving
    Private Sub Login_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        If e.Button = sender.MouseButtons.Left Then
            isMouseDown = False
        End If
    End Sub
    ' ------------------------------------------------------------------------------------------------------
    ' FUNCTIONS FOR DISPLAYING TOOLTIPS --------------------------------------------------------------------

    Private Sub tbxUser_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles tbxUser.Enter
        bv.changeColor(tbxUser, userTxtDefault)
    End Sub

    Private Sub TextBox2_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles tbxPW.Enter
        bv.changeColor(tbxPW, pwTxtDefault)
    End Sub
    Private Sub tbxUser_Leave(sender As Object, e As EventArgs) Handles tbxUser.Leave
        bv.changeColor(tbxUser, userTxtDefault)
    End Sub
    Private Sub TextBox2_Leave(sender As Object, e As EventArgs) Handles tbxPW.Leave
        bv.changeColor(tbxPW, pwTxtDefault)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        enterLogin()
    End Sub
    Private Sub tbxUser_KeyUp(sender As Object, e As KeyEventArgs) Handles tbxUser.KeyUp
        If e.KeyCode = Keys.Enter Then
            enterLogin()
        End If
    End Sub
    Private Sub TextBox2_KeyUp(sender As Object, e As KeyEventArgs) Handles tbxPW.KeyUp
        If e.KeyCode = Keys.Enter Then
            enterLogin()
        End If
    End Sub
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Register.Show()
        Me.Close()
    End Sub

    Private Sub lblRecovery_Click(sender As Object, e As EventArgs) Handles lblRecoverPass.Click
        Recovery.Show()
        Me.Close()
    End Sub
    Private Sub enterLogin()
        Dim db As New DataAccess
        Dim ds As New DataSet
        Dim query As String
        Dim type As Integer
        Dim pattern As String = tbxPW.Text.Substring(0, 3)

        db.connect()

        If pattern = "gp1" Then
            query = "SELECT * FROM usuarios where dni = '" & tbxUser.Text & "' and pw = '" & tbxPW.Text & "'"
        Else
            query = "SELECT * FROM usuarios where dni = '" & tbxUser.Text & "' and pw = '" & Encriptar(tbxPW.Text) & "'"
        End If

        ds = db.query(query)
        If ds.Tables(0).Rows.Count >= 1 Then
            type = ds.Tables(0).Rows(0).Item(2)
            If type = 1 Then
                AdminPanel.Show()
                Me.Close()
            ElseIf type = 0 Then
                MessageBox.Show("Debe esperar a que un administrador active su usuario", "Espera de activación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf type = 2 Then
                UserPanel.Show()
                Me.Close()
            End If
        Else
            MessageBox.Show("Login incorrecto!!", "Login incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim res As Integer
        res = MessageBox.Show("¿Está seguro que desea salir?", "Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        ' res = MsgBox("¿Está seguro que desea salir?", vbYesNo)
        If res = 6 Then
            Application.Exit()
        End If
    End Sub
End Class
