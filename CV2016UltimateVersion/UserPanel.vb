Public Class UserPanel
    Dim db As New DataAccess
    Private isMouseDown As Boolean = False
    Private mouseOffset As Point
    Dim path, FinalDate, dateA As String
    Dim idfromfa, idfromexp, idfromext, total As Integer
    Dim dni = RecoveryData.dni

    Private Sub UserPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'We place the actual day as the maximum date of birth
        dtpbirth.MaxDate = DateTime.Now.Date

        'Fill in the fields with the data
        RefillUserInformation()
        RefillEducation()
        RefillExperience()
        RefillExtras()
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

    '---------------------------------------------------------------ˇ
    'Change date format so that it can be inserted correctly in mysql
    Private Function transformDate(ByVal a As String)
        Dim datee As String
        datee = a.Substring(6, 4) & "-" & a.Substring(3, 2) & "-" & a.Substring(0, 2)
        Return datee
    End Function

    '---------------------------------------------------------------ˇ
    'Transform the date when the user selects it
    Private Sub dtpbirth_ValueChanged(sender As Object, e As EventArgs) Handles dtpbirth.ValueChanged
        dateA = dtpbirth.Value.Date
        FinalDate = transformDate(dateA)
    End Sub
    '---------------------------------------------------------------^

    '---------------------------------------------------------------ˇ
    'We place the watermark in the textbox to know what data we have to put
    'Watermarks in the personal data tab
    Private Sub watermarktabdp()
        txtbdpname.Text = txtbdpname.Tag
        txtbdpsurname.Text = txtbdpsurname.Tag
        txtdpbdir.Text = txtdpbdir.Tag
        txtbdpnacionality.Text = txtbdpnacionality.Tag
        txtbdplocality.Text = txtbdplocality.Tag
        txtbdpemail.Text = txtbdpemail.Tag
        txtbdptlf.Text = txtbdptlf.Tag

        FinalDate = transformDate(DateTime.Now.Date)
        dtpbirth.Value = FinalDate

        txtbdpname.ForeColor = Color.Gray
        txtbdpsurname.ForeColor = Color.Gray

        txtdpbdir.ForeColor = Color.Gray
        txtbdpnacionality.ForeColor = Color.Gray
        txtbdplocality.ForeColor = Color.Gray
        txtbdpemail.ForeColor = Color.Gray
        txtbdptlf.ForeColor = Color.Gray

        AddHandler txtbdpname.GotFocus, AddressOf GotfocusText
        AddHandler txtbdpname.LostFocus, AddressOf LostfocusText

        AddHandler txtbdpsurname.GotFocus, AddressOf GotfocusText
        AddHandler txtbdpsurname.LostFocus, AddressOf LostfocusText

        AddHandler txtdpbdir.GotFocus, AddressOf GotfocusText
        AddHandler txtdpbdir.LostFocus, AddressOf LostfocusText

        AddHandler txtbdpnacionality.GotFocus, AddressOf GotfocusText
        AddHandler txtbdpnacionality.LostFocus, AddressOf LostfocusText

        AddHandler txtbdplocality.GotFocus, AddressOf GotfocusText
        AddHandler txtbdplocality.LostFocus, AddressOf LostfocusText

        AddHandler txtbdpemail.GotFocus, AddressOf GotfocusText
        AddHandler txtbdpemail.LostFocus, AddressOf LostfocusText

        AddHandler txtbdptlf.GotFocus, AddressOf GotfocusText
        AddHandler txtbdptlf.LostFocus, AddressOf LostfocusText
    End Sub

    'Watermarks in academic formation tab 
    Private Sub watermarktabfa()
        txtfaname.Text = txtfaname.Tag
        txtfaplace.Text = txtfaplace.Tag
        txtfayearstart.Text = txtfayearstart.Tag
        txtfayearend.Text = txtfayearend.Tag
        txtfadesc.Text = txtfadesc.Tag

        txtfaname.ForeColor = Color.Gray
        txtfaplace.ForeColor = Color.Gray
        txtfayearstart.ForeColor = Color.Gray
        txtfayearend.ForeColor = Color.Gray
        txtfadesc.ForeColor = Color.Gray

        AddHandler txtfaname.GotFocus, AddressOf GotfocusText
        AddHandler txtfaname.LostFocus, AddressOf LostfocusText

        AddHandler txtfaplace.GotFocus, AddressOf GotfocusText
        AddHandler txtfaplace.LostFocus, AddressOf LostfocusText

        AddHandler txtfayearstart.GotFocus, AddressOf GotfocusText
        AddHandler txtfayearstart.LostFocus, AddressOf LostfocusText

        AddHandler txtfayearend.GotFocus, AddressOf GotfocusText
        AddHandler txtfayearend.LostFocus, AddressOf LostfocusText

        AddHandler txtfadesc.GotFocus, AddressOf GotfocusText
        AddHandler txtfadesc.LostFocus, AddressOf LostfocusText

        'We prevent you from editing a record without clicking
        idfromfa = 0
    End Sub

    'Watermark on the experience tab
    Private Sub watermarktabexp()
        txtexpcompany.Text = txtexpcompany.Tag
        txtexpyears.Text = txtexpyears.Tag
        txtexpdesc.Text = txtexpdesc.Tag

        txtexpcompany.ForeColor = Color.Gray
        txtexpyears.ForeColor = Color.Gray
        txtexpdesc.ForeColor = Color.Gray

        AddHandler txtexpcompany.GotFocus, AddressOf GotfocusText
        AddHandler txtexpcompany.LostFocus, AddressOf LostfocusText

        AddHandler txtexpyears.GotFocus, AddressOf GotfocusText
        AddHandler txtexpyears.LostFocus, AddressOf LostfocusText

        AddHandler txtexpdesc.GotFocus, AddressOf GotfocusText
        AddHandler txtexpdesc.LostFocus, AddressOf LostfocusText

        'We prevent you from editing a record without clicking
        idfromexp = 0
    End Sub

    'Watermark on the extra tab
    Private Sub watermarktabext()
        txtbexttittle.Text = txtbexttittle.Tag
        txtbexttype.Text = txtbexttype.Tag

        txtbexttittle.ForeColor = Color.Gray
        txtbexttype.ForeColor = Color.Gray

        AddHandler txtbexttittle.GotFocus, AddressOf GotfocusText
        AddHandler txtbexttittle.LostFocus, AddressOf LostfocusText

        AddHandler txtbexttype.GotFocus, AddressOf GotfocusText
        AddHandler txtbexttype.LostFocus, AddressOf LostfocusText

        'We prevent you from editing a record without clicking
        idfromext = 0
    End Sub
    '---------------------------------------------------------------^

    '---------------------------------------------------------------ˇ
    'Texbox Focus
    Private Sub GotfocusText(ByVal sender As Object, ByVal e As EventArgs)
        If (sender.Text = sender.Tag) Then
            sender.Text = ""
            sender.ForeColor = Color.Black
        End If
    End Sub

    Private Sub LostfocusText(ByVal sender As Object, ByVal e As EventArgs)
        If sender.Text = "" Then
            sender.text = sender.Tag
            sender.Forecolor = Color.Gray
        End If
    End Sub
    '---------------------------------------------------------------^

    '---------------------------------------------------------------ˇ
    'Fill in the Personal Data tab
    Private Sub RefillUserInformation()
        Dim query As String
        Dim dsrefill As New DataSet

        query = "Select * from perfil where dni = '" & dni & "'"
        dsrefill = db.query(query)

        If dsrefill.Tables(0).Rows.Count > 0 Then
            'Dni
            txtbdpdni.Text = dsrefill.Tables(0).Rows(0).Item(0).ToString

            'Name
            If (dsrefill.Tables(0).Rows(0).Item(1).ToString.Equals("")) Then
                txtbdpname.Text = "Nombre"
                txtbdpname.ForeColor = Color.Gray
                AddHandler txtbdpname.GotFocus, AddressOf GotfocusText
                AddHandler txtbdpname.LostFocus, AddressOf LostfocusText
            Else
                txtbdpname.ForeColor = Color.Black
                txtbdpname.Text = dsrefill.Tables(0).Rows(0).Item(1).ToString
                AddHandler txtbdpname.GotFocus, AddressOf GotfocusText
                AddHandler txtbdpname.LostFocus, AddressOf LostfocusText
            End If

            'Surname
            If (dsrefill.Tables(0).Rows(0).Item(2).ToString = ("")) Then
                txtbdpsurname.Text = "Apellidos"
                txtbdpsurname.ForeColor = Color.Gray
                AddHandler txtbdpsurname.GotFocus, AddressOf GotfocusText
                AddHandler txtbdpsurname.LostFocus, AddressOf LostfocusText
            Else
                txtbdpsurname.ForeColor = Color.Black
                txtbdpsurname.Text = dsrefill.Tables(0).Rows(0).Item(2).ToString
                AddHandler txtbdpsurname.GotFocus, AddressOf GotfocusText
                AddHandler txtbdpsurname.LostFocus, AddressOf LostfocusText
            End If

            'address
            If (dsrefill.Tables(0).Rows(0).Item(3).ToString = ("")) Then
                txtdpbdir.Text = "Dirección"
                txtdpbdir.ForeColor = Color.Gray
                AddHandler txtdpbdir.GotFocus, AddressOf GotfocusText
                AddHandler txtdpbdir.LostFocus, AddressOf LostfocusText
            Else
                txtdpbdir.ForeColor = Color.Black
                txtdpbdir.Text = dsrefill.Tables(0).Rows(0).Item(3).ToString
                AddHandler txtdpbdir.GotFocus, AddressOf GotfocusText
                AddHandler txtdpbdir.LostFocus, AddressOf LostfocusText
            End If

            'Birth date
            If (dsrefill.Tables(0).Rows(0).Item(4).ToString = ("")) Then
                FinalDate = DateTime.Now.Date
                dateA = dtpbirth.Value.Date

                'Change date format so that it can be inserted correctly in mysql
                FinalDate = transformDate(dateA)

            Else
                dtpbirth.Value = dsrefill.Tables(0).Rows(0).Item(4)
                dateA = dtpbirth.Value.Date
                FinalDate = transformDate(dateA)
            End If

            'nationality
            If (dsrefill.Tables(0).Rows(0).Item(5).ToString = ("")) Then
                txtbdpnacionality.Text = "Nacionalidad"
                txtbdpnacionality.ForeColor = Color.Gray
                AddHandler txtbdpnacionality.GotFocus, AddressOf GotfocusText
                AddHandler txtbdpnacionality.LostFocus, AddressOf LostfocusText
            Else
                txtbdpnacionality.ForeColor = Color.Black
                txtbdpnacionality.Text = dsrefill.Tables(0).Rows(0).Item(5).ToString
                AddHandler txtbdpnacionality.GotFocus, AddressOf GotfocusText
                AddHandler txtbdpnacionality.LostFocus, AddressOf LostfocusText
            End If

            'telephone number
            If (dsrefill.Tables(0).Rows(0).Item(6).ToString = ("")) Then
                txtbdptlf.Text = "Teléfono"
                txtbdptlf.ForeColor = Color.Gray
                AddHandler txtbdptlf.GotFocus, AddressOf GotfocusText
                AddHandler txtbdptlf.LostFocus, AddressOf LostfocusText
            Else
                txtbdptlf.ForeColor = Color.Black
                txtbdptlf.Text = dsrefill.Tables(0).Rows(0).Item(6).ToString
                AddHandler txtbdptlf.GotFocus, AddressOf GotfocusText
                AddHandler txtbdptlf.LostFocus, AddressOf LostfocusText
            End If

            'Email
            If (dsrefill.Tables(0).Rows(0).Item(7).ToString = ("")) Then
                txtbdpemail.Text = "Email"
                txtbdpemail.ForeColor = Color.Gray
                AddHandler txtbdpemail.GotFocus, AddressOf GotfocusText
                AddHandler txtbdpemail.LostFocus, AddressOf LostfocusText
            Else
                txtbdpemail.ForeColor = Color.Black
                txtbdpemail.Text = dsrefill.Tables(0).Rows(0).Item(7).ToString
                AddHandler txtbdpemail.GotFocus, AddressOf GotfocusText
                AddHandler txtbdpemail.LostFocus, AddressOf LostfocusText
            End If
            'Ruta
            If (dsrefill.Tables(0).Rows(0).Item(8).ToString = ("")) Then
                pbphoto.Image = Nothing
                UserPhoto.Image = Nothing
            Else
                path = dsrefill.Tables(0).Rows(0).Item(8)
                pbphoto.Image = Image.FromFile(path)
                UserPhoto.Image = Image.FromFile(path)
            End If

            'locality
            If (dsrefill.Tables(0).Rows(0).Item(9).ToString = ("")) Then
                txtbdplocality.Text = "Localidad"
                txtbdplocality.ForeColor = Color.Gray
                AddHandler txtbdplocality.GotFocus, AddressOf GotfocusText
                AddHandler txtbdplocality.LostFocus, AddressOf LostfocusText
            Else
                txtbdplocality.ForeColor = Color.Black
                txtbdplocality.Text = dsrefill.Tables(0).Rows(0).Item(9).ToString
                AddHandler txtbdplocality.GotFocus, AddressOf GotfocusText
                AddHandler txtbdplocality.LostFocus, AddressOf LostfocusText
            End If
        Else
            watermarktabdp()
        End If


    End Sub
    '---------------------------------------------------------------^

    '---------------------------------------------------------------ˇ
    'Fill in the Education tab
    Private Sub RefillEducation()
        Dim query As String
        Dim dsrefill As New DataSet

        query = "Select * from formacion where dni = '" & dni & "'"
        dsrefill = db.query(query)

        watermarktabfa()

        For i = 0 To dsrefill.Tables(0).Rows.Count - 1
            With lvfa
                .Items.Add(dsrefill.Tables(0).Rows(i).Item(1))
                With .Items(.Items.Count - 1).SubItems
                    .Add(dsrefill.Tables(0).Rows(i).Item(2))
                    .Add(dsrefill.Tables(0).Rows(i).Item(3))
                    .Add(dsrefill.Tables(0).Rows(i).Item(4))
                    .Add(dsrefill.Tables(0).Rows(i).Item(5))
                    .Add(dsrefill.Tables(0).Rows(i).Item(6))
                End With
            End With
        Next
    End Sub
    '---------------------------------------------------------------^

    '---------------------------------------------------------------ˇ
    'Fill in the Experience tab
    Private Sub RefillExperience()
        Dim query As String
        Dim dsrefill As New DataSet

        query = "Select * from experiencia where dni = '" & dni & "'"
        dsrefill = db.query(query)

        watermarktabexp()

        For i = 0 To dsrefill.Tables(0).Rows.Count - 1
            With lvexp
                .Items.Add(dsrefill.Tables(0).Rows(i).Item(1))
                With .Items(.Items.Count - 1).SubItems
                    .Add(dsrefill.Tables(0).Rows(i).Item(2))
                    .Add(dsrefill.Tables(0).Rows(i).Item(3))
                    .Add(dsrefill.Tables(0).Rows(i).Item(4))
                End With
            End With
        Next
    End Sub
    '---------------------------------------------------------------^

    '---------------------------------------------------------------ˇ
    'Fill in the Extras tab
    Private Sub RefillExtras()
        Dim query As String
        Dim dsrefill As New DataSet

        query = "Select * from formacion2 where dni = '" & dni & "'"
        dsrefill = db.query(query)

        watermarktabext()

        For i = 0 To dsrefill.Tables(0).Rows.Count - 1
            With lvextras
                .Items.Add(dsrefill.Tables(0).Rows(i).Item(1))
                With .Items(.Items.Count - 1).SubItems
                    .Add(dsrefill.Tables(0).Rows(i).Item(2))
                    .Add(dsrefill.Tables(0).Rows(i).Item(3))
                End With
            End With
        Next
    End Sub
    '---------------------------------------------------------------^

    '---------------------------------------------------------------ˇ
    'Button to quit the application
    Private Sub btnlog_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim res As Integer

        res = MessageBox.Show("¿Está seguro que desea salir?", "Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If res = 6 Then
            Application.Exit()
        End If
    End Sub
    '---------------------------------------------------------------^

    '---------------------------------------------------------------ˇ
    'Button for deleting the fields of personal data
    Private Sub btndpdelete_Click(sender As Object, e As EventArgs) Handles btndpdelete.Click
        Dim res As Integer

        res = MessageBox.Show("¿Está seguro que desea borrar los campos?", "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If res = 6 Then
            watermarktabdp()
        End If
    End Sub
    '---------------------------------------------------------------^

    '---------------------------------------------------------------ˇ
    'Button to erase training logs academy
    Private Sub btnfadelete_Click(sender As Object, e As EventArgs) Handles btnfadelete.Click
        Dim consdelete As String
        Dim res As Integer

        res = MessageBox.Show("¿Está seguro que desea borrar el registro?", "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If res = 6 Then
            consdelete = "DELETE FROM formacion WHERE id = " & idfromfa & " and dni = '" & dni & "'"
            Try
                db.cud(consdelete)

                watermarktabfa()
                lvfa.Items.Clear()
                RefillEducation()
            Catch ex As Exception
                MessageBox.Show("No se ha podido borrar el registro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
    '---------------------------------------------------------------^

    '---------------------------------------------------------------ˇ
    'Button to delete the fields of academic formation
    Private Sub btnfaclear_Click(sender As Object, e As EventArgs) Handles btnfaclear.Click
        watermarktabfa()
    End Sub

    '---------------------------------------------------------------ˇ
    'Button to erase the experience log
    Private Sub btnexpdelete_Click(sender As Object, e As EventArgs) Handles btnexpdelete.Click
        Dim consdelete As String
        Dim res As Integer

        res = MessageBox.Show("¿Está seguro que desea borrar los campos?", "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If res = 6 Then
            consdelete = "DELETE FROM experiencia WHERE id = " & idfromexp & " and dni = '" & dni & "'"
            Try
                db.cud(consdelete)

                watermarktabexp()
                lvexp.Items.Clear()
                RefillExperience()
            Catch ex As Exception
                MessageBox.Show("No se ha podido borrar el registro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
    '---------------------------------------------------------------^

    '---------------------------------------------------------------ˇ
    'Button to erase the fields of experience
    Private Sub btnexpclear_Click(sender As Object, e As EventArgs) Handles btnexpclear.Click
        watermarktabexp()
    End Sub
    '---------------------------------------------------------------^

    '---------------------------------------------------------------ˇ
    'Button to delete the extras registry
    Private Sub btnextdelete_Click(sender As Object, e As EventArgs) Handles btnextdelete.Click
        Dim consdelete As String
        Dim res As Integer

        res = MessageBox.Show("¿Está seguro que desea borrar los campos?", "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If res = 6 Then
            consdelete = "DELETE FROM formacion2 WHERE id = " & idfromext & " and dni = '" & dni & "'"

            Try
                db.cud(consdelete)

                watermarktabext()
                lvextras.Items.Clear()
                RefillExtras()
            Catch ex As Exception
                MessageBox.Show("No se ha podido borrar el registro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
    '---------------------------------------------------------------^

    '---------------------------------------------------------------ˇ
    'Button to delete extra fields
    Private Sub btnextclear_Click(sender As Object, e As EventArgs) Handles btnextclear.Click
        watermarktabext()
    End Sub
    '---------------------------------------------------------------^

    '---------------------------------------------------------------ˇ
    'Button to delete the user's photo
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btndpdeleteimg.Click
        Dim consupdate As String
        Dim res As Integer

        res = MessageBox.Show("¿Está seguro que desea borrar los campos?", "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If res = 6 Then
            path = ""
            pbphoto.Image = Nothing
            UserPhoto.Image = Nothing

            consupdate = "UPDATE perfil SET ruta_foto='" & path & "' WHERE dni='" & dni & "'"
            db.cud(consupdate)
        End If
    End Sub
    '---------------------------------------------------------------^

    '---------------------------------------------------------------ˇ
    'When we click on an item in the list, we show the data in the corresponding textbox
    'Academic formation
    Private Sub lvfa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvfa.SelectedIndexChanged

        If lvfa.SelectedItems.Count > 0 Then

            txtfaname.ForeColor = Color.Black
            txtfaplace.ForeColor = Color.Black
            txtfayearstart.ForeColor = Color.Black
            txtfayearend.ForeColor = Color.Black
            txtfadesc.ForeColor = Color.Black

            'We show the data
            txtfaname.Text = lvfa.SelectedItems(0).SubItems(3).Text
            txtfaplace.Text = lvfa.SelectedItems(0).SubItems(4).Text
            txtfayearstart.Text = lvfa.SelectedItems(0).SubItems(1).Text
            txtfayearend.Text = lvfa.SelectedItems(0).SubItems(2).Text
            txtfadesc.Text = lvfa.SelectedItems(0).SubItems(5).Text

            'We collect the id
            idfromfa = CInt(lvfa.SelectedItems(0).SubItems(0).Text)
        End If

    End Sub

    'Experience
    Private Sub lvexp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvexp.SelectedIndexChanged

        If lvexp.SelectedItems.Count > 0 Then

            txtexpcompany.ForeColor = Color.Black
            txtexpyears.ForeColor = Color.Black
            txtexpdesc.ForeColor = Color.Black

            'We put the data
            txtexpyears.Text = lvexp.SelectedItems(0).SubItems(1).Text
            txtexpcompany.Text = lvexp.SelectedItems(0).SubItems(2).Text
            txtexpdesc.Text = lvexp.SelectedItems(0).SubItems(3).Text

            'We collect the id
            idfromexp = CInt(lvexp.SelectedItems(0).SubItems(0).Text)
        End If

    End Sub

    'Extras
    Private Sub lvextras_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvextras.SelectedIndexChanged

        If lvextras.SelectedItems.Count > 0 Then

            txtbexttittle.ForeColor = Color.Black
            txtbexttype.ForeColor = Color.Black

            'We put the data
            txtbexttype.Text = lvextras.SelectedItems(0).SubItems(1).Text
            txtbexttittle.Text = lvextras.SelectedItems(0).SubItems(2).Text

            'We collect the id
            idfromext = CInt(lvextras.SelectedItems(0).SubItems(0).Text)
        End If

    End Sub
    '---------------------------------------------------------------^

    '---------------------------------------------------------------ˇ
    'We verified that the year of beginning is not going to be greater than the year of end
    Private Function checkyears(ByVal iniy As String, ByVal endy As String)
        If IsNumeric(iniy) And IsNumeric(endy) Then
            If (CInt(iniy) <= CInt(endy)) Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function
    '---------------------------------------------------------------^

    '---------------------------------------------------------------ˇ
    'Check the existing id for insertion
    Private Function setId(ByVal tabla As String)
        Dim finalid As Integer
        Dim consid As String
        Dim dsrefill As New DataSet
        Dim numeros = {1, 2, 3}.ToList

        consid = "Select id from " & tabla & " where dni = '" & dni & "'"
        dsrefill = db.query(consid)

        'We count the number of rows
        total = dsrefill.Tables(0).Rows.Count

        If (total >= 3) Then

        Else
            'We insert it in the array
            Dim ids(0 To total - 1)
            For i = 0 To total - 1
                ids(i) = dsrefill.Tables(0).Rows(i).Item(0)
            Next

            If ids.Contains(1) Then
                numeros.Remove(1)
            End If

            If ids.Contains(2) Then
                numeros.Remove(2)
            End If

            If ids.Contains(3) Then
                numeros.Remove(3)
            End If

            finalid = CInt(numeros(0))
        End If

        Return finalid

    End Function
    '---------------------------------------------------------------^

    '---------------------------------------------------------------ˇ
    'Button to generate the pdf
    Private Sub btnprgencv_Click(sender As Object, e As EventArgs) Handles btnprgencv.Click
        'Generar curriculum by Jose applelover
    End Sub
    '---------------------------------------------------------------^

    '---------------------------------------------------------------ˇ
    'We check fields and store personal data in the database.
    Private Sub btndpsave_Click(sender As Object, e As EventArgs) Handles btndpsave.Click
        Dim consupdate As String
        Dim bltlf, blemail As Boolean

        If (txtbdpname.Text <> txtbdpname.Tag And txtbdpsurname.Text <> txtbdpsurname.Tag And txtdpbdir.Text <> txtdpbdir.Tag And
            txtbdpnacionality.Text <> txtbdpnacionality.Tag And txtbdplocality.Text <> txtbdplocality.Tag And txtbdpemail.Text <> txtbdpemail.Tag And txtbdptlf.Text <> txtbdptlf.Tag) Then

            If (IsNumeric(txtbdptlf.Text) = False Or txtbdptlf.Text.Length < 9) Then
                eptlf.SetError(txtbdptlf, "Introduzca un número correcto")
                bltlf = False
            Else
                eptlf.Clear()
                bltlf = True
            End If

            If (isEmail(txtbdpemail.Text) = False) Then
                epemail.SetError(txtbdpemail, "Introduzca un email válido")
                blemail = False
            Else
                epemail.Clear()
                blemail = True
            End If

            Try
                If (bltlf = True And blemail = True) Then

                    consupdate = "UPDATE perfil SET nombre='" & txtbdpname.Text & "', apellidos='" & txtbdpsurname.Text & "', direccion='" & txtdpbdir.Text & "',fecha_nac='" & FinalDate & "',
                        nacionalidad='" & txtbdpnacionality.Text & "',telefono=" & CInt(txtbdptlf.Text) & ", email='" & txtbdpemail.Text & "',ruta_foto='" & path & "', localidad='" & txtbdplocality.Text & "' WHERE dni='" & dni & "'"

                    db.cud(consupdate)

                    MessageBox.Show("Datos añadidos correctamente.", "Información.", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else
                    MessageBox.Show("Compruebe que todos los campos son correctos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As Exception
                MessageBox.Show("No se han podido actualizar los datos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Debes rellenar todos los campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    '---------------------------------------------------------------^

    '---------------------------------------------------------------ˇ
    'We check fields and store academic formation in the database.
    Private Sub btnfasave_Click(sender As Object, e As EventArgs) Handles btnfasave.Click
        Dim consupdate, consinsert As String

        If (txtfaname.Text <> txtfaname.Tag And txtfaplace.Text <> txtfaplace.Tag And txtfayearstart.Text <> txtfayearstart.Tag And txtfayearend.Text <> txtfayearend.Tag And txtfadesc.Text <> txtfadesc.Tag) Then
            If (checkyears(txtfayearstart.Text, txtfayearend.Text)) Then

                consupdate = "UPDATE formacion SET year_inicio ='" & txtfayearstart.Text & "', year_fin ='" & txtfayearend.Text & "', nombre='" & txtfaname.Text & "', lugar = '" & txtfaplace.Text & "', descripcion = '" & txtfadesc.Text & "' WHERE id = " & idfromfa & " and dni = '" & dni & "'"

                If (db.cud(consupdate) = 0) Then
                    consinsert = "INSERT INTO formacion (`dni`, `id`, `year_inicio`, `year_fin`, `nombre`, `lugar`, `descripcion`) VALUES ('" & dni & "', " & setId("formacion") & " ,'" & txtfayearstart.Text & "','" & txtfayearend.Text & "','" & txtfaname.Text & "','" & txtfaplace.Text & "','" & txtfadesc.Text & "')"

                    If (total < 3) Then
                        Try
                            db.cud(consinsert)

                            MessageBox.Show("Datos insertados correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            watermarktabfa()
                            lvfa.Items.Clear()
                            RefillEducation()
                        Catch ex As Exception
                            MessageBox.Show("Se ha producido un error al insertar los datos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Try
                    Else
                        MessageBox.Show("Debes eliminar un campo, solo puedes tener 3 como máximo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    Try
                        db.cud(consupdate)

                        MessageBox.Show("Datos actualizados correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        watermarktabfa()
                        lvfa.Items.Clear()
                        RefillEducation()

                    Catch ex As Exception
                        MessageBox.Show("No se han podido actualizar los datos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If

            Else
                MessageBox.Show("Debes introducir los años correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Debes rellenar todos los campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    '---------------------------------------------------------------^

    '---------------------------------------------------------------ˇ
    'We check fields and store experience in the database.
    Private Sub btnexpsave_Click(sender As Object, e As EventArgs) Handles btnexpsave.Click
        Dim consupdate, consinsert As String

        If (txtexpcompany.Text <> txtexpcompany.Tag And txtexpyears.Text <> txtexpyears.Tag And txtexpdesc.Text <> txtexpdesc.Tag) Then
            If (CInt(txtexpyears.Text) > 0 And IsNumeric(txtexpyears.Text)) Then
                consupdate = "UPDATE experiencia SET years ='" & txtexpyears.Text & "', empresa ='" & txtexpcompany.Text & "', descripcion = '" & txtexpdesc.Text & "' WHERE id = " & idfromexp & " and dni = '" & dni & "'"

                If (db.cud(consupdate) = 0) Then

                    consinsert = "INSERT INTO experiencia (`dni`, `id`, `years`, `empresa`, `descripcion`) VALUES ('" & dni & "', " & setId("experiencia") & " ,'" & txtexpyears.Text & "','" & txtexpcompany.Text & "','" & txtexpdesc.Text & "')"

                    If (total < 3) Then
                        Try

                            db.cud(consinsert)

                            MessageBox.Show("Datos insertados correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            lvexp.Items.Clear()
                            watermarktabexp()
                            RefillExperience()
                        Catch ex As Exception
                            MessageBox.Show("Se ha producido un error al insertar los datos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Try
                    Else
                        MessageBox.Show("Debes eliminar un campo, solo puedes tener 3 como máximo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    Try
                        db.cud(consupdate)

                        MessageBox.Show("Datos actualizados correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        lvexp.Items.Clear()
                        watermarktabexp()
                        RefillExperience()

                    Catch ex As Exception
                        MessageBox.Show("No se han podido actualizar los datos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try

                End If
            Else
                MessageBox.Show("Debes introducir los años correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Debes rellenar todos los campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub
    '---------------------------------------------------------------^

    '---------------------------------------------------------------ˇ
    'We check fields and store extras in the database.
    Private Sub btnextsave_Click(sender As Object, e As EventArgs) Handles btnextsave.Click
        Dim consupdate, consinsert As String

        If (txtbexttittle.Text <> txtbexttittle.Tag And txtbexttype.Text <> txtbexttype.Tag) Then
            consupdate = "UPDATE formacion2 SET tipo ='" & txtbexttype.Text & "', titulo='" & txtbexttittle.Text & "' WHERE id = " & idfromext & " and dni = '" & dni & "'"

            If (db.cud(consupdate) = 0) Then

                consinsert = "INSERT INTO formacion2 (`dni`, `id`, `tipo`, `titulo`) VALUES ('" & dni & "'," & setId("formacion2") & ", '" & txtbexttype.Text & "','" & txtbexttittle.Text & "')"

                If (total < 3) Then
                    Try
                        db.cud(consinsert)

                        MessageBox.Show("Datos insertados correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        lvextras.Items.Clear()
                        watermarktabext()
                        RefillExtras()
                    Catch ex As Exception
                        MessageBox.Show("Se ha producido un error al insertar los datos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                Else
                    MessageBox.Show("Debes eliminar un campo, solo puedes tener 3 como máximo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                Try
                    db.cud(consupdate)
                Catch ex As Exception
                    MessageBox.Show("No se han podido actualizar los datos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

                MessageBox.Show("Datos actualizados correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)

                lvextras.Items.Clear()
                watermarktabext()
                RefillExtras()
            End If
        Else
            MessageBox.Show("Debes rellenar todos los campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    '---------------------------------------------------------------^

    '---------------------------------------------------------------ˇ
    'We open the panel for the user to select the photo
    Private Sub btnupphoto_Click(sender As Object, e As EventArgs) Handles btnupphoto.Click
        Dim ofd As New OpenFileDialog()
        ofd.Filter = "Archivos de imagen (*.png, *.jpg)|*.png;*.jpg"
        ofd.Title = "Selecciona una imagen"

        If ofd.ShowDialog() = DialogResult.OK Then
            path = ofd.FileName.Replace("\", "\\")
            pbphoto.Image = Image.FromFile(path)
            UserPhoto.Image = Image.FromFile(path)
        End If
    End Sub
    '---------------------------------------------------------------^
End Class