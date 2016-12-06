﻿Public Class UserPanel
    Dim db As New DataAccess
    Dim path, FinalDate, dateA As String

    Private Sub UserPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Colocamos el dia actual como fecha maxima de nacimiento
        dtpbirth.MaxDate = DateTime.Now.Date

        'Rellenamos con los datos el formulario
        RefillUserInformation()
        RefillEducation()
        RefillExperience()
        RefillExtras()
    End Sub

    'Cambio formato de la fecha para que se pueda insertar correctamente en mysql
    Private Function transformDate(ByVal a As String)
        Dim datee As String
        datee = a.Substring(6, 4) & "-" & a.Substring(3, 2) & "-" & a.Substring(0, 2)
        Return datee
    End Function

    '---------------------------------------------------------------ˇ
    'Nos coloca la marca de agua en el textbox para saber que dato tenemos que poner
    'Marcas de agua en los textbox de la pestaña datos personales
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

    'Marcas de agua en los textbox de la pestaña formacion academica
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
    End Sub

    'Marca de agua en los textbox de la pestaña experiencia
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
    End Sub

    'Marca de agua en los textbox de la pestaña extras
    Private Sub watermarktabext()
        txtbexttittle.Text = txtbexttittle.Tag
        txtbexttype.Text = txtbexttype.Tag

        txtbexttittle.ForeColor = Color.Gray
        txtbexttype.ForeColor = Color.Gray

        AddHandler txtbexttittle.GotFocus, AddressOf GotfocusText
        AddHandler txtbexttittle.LostFocus, AddressOf LostfocusText

        AddHandler txtbexttype.GotFocus, AddressOf GotfocusText
        AddHandler txtbexttype.LostFocus, AddressOf LostfocusText
    End Sub
    '---------------------------------------------------------------^

    '---------------------------------------------------------------ˇ
    'Focus de los Textbox
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
    'Rellenamos los datos de la pestaña Datos Personales
    Private Sub RefillUserInformation()
        Dim query As String
        Dim dsrefill As New DataSet

        query = "Select * from perfil where dni = '12345678Z'"
        dsrefill = db.query(query)

        If dsrefill.Tables(0).Rows.Count > 0 Then
            'Dni
            txtbdpdni.Text = dsrefill.Tables(0).Rows(0).Item(0).ToString

            'Nombre
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

            'Apellidos
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

            'Direccion
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

            'Fecha Nacimiento
            If (dsrefill.Tables(0).Rows(0).Item(4).ToString = ("")) Then
                FinalDate = DateTime.Now.Date
                dateA = dtpbirth.Value.Date

                'Cambio formato de la fecha para que se pueda insertar correctamente en mysql
                FinalDate = transformDate(dateA)

            Else
                dtpbirth.Value = dsrefill.Tables(0).Rows(0).Item(4)
                dateA = dtpbirth.Value.Date
                FinalDate = transformDate(dateA)
            End If

            'Nacionalidad
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

            'Telefono
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
                'Nada
            Else
                path = dsrefill.Tables(0).Rows(0).Item(8)
                pbphoto.Image = Image.FromFile(path)
                UserPhoto.Image = Image.FromFile(path)
            End If

            'Localidad
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
    'Rellenamos los datos de la pestaña Formación academica
    Private Sub RefillEducation()
        Dim query As String
        Dim dsrefill As New DataSet

        query = "Select * from formacion where dni = '12345678Z'"
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
                End With
            End With
        Next
    End Sub
    '---------------------------------------------------------------^

    '---------------------------------------------------------------ˇ
    'Rellenamos los datos de la pestaña Experiencia
    Private Sub RefillExperience()
        Dim query As String
        Dim dsrefill As New DataSet

        query = "Select * from experiencia where dni = '12345678Z'"
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
    'Rellenamos los datos de la pestaña Extras
    Private Sub RefillExtras()
        Dim query As String
        Dim dsrefill As New DataSet

        query = "Select * from formacion2 where dni = '12345678Z'"
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
    'Boton para salir de la aplicación
    Private Sub btnlog_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim res As Integer

        res = MessageBox.Show("¿Está seguro que desea salir?", "Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If res = 6 Then
            Application.Exit()
        End If
    End Sub
    '---------------------------------------------------------------^

    Private Sub txtformname_TextChanged(sender As Object, e As EventArgs) Handles txtfaname.TextChanged

    End Sub

    Private Sub txtbemail_TextChanged(sender As Object, e As EventArgs) Handles txtbdpemail.TextChanged

    End Sub

    '---------------------------------------------------------------ˇ
    'Deja los campos vacios en las distintas pestañas
    Private Sub btndpdelete_Click(sender As Object, e As EventArgs) Handles btndpdelete.Click
        watermarktabdp()
    End Sub

    Private Sub btnfadelete_Click(sender As Object, e As EventArgs) Handles btnfadelete.Click
        watermarktabfa()
    End Sub

    Private Sub btnexpdelete_Click(sender As Object, e As EventArgs) Handles btnexpdelete.Click
        watermarktabexp()
    End Sub

    Private Sub btnextdelete_Click(sender As Object, e As EventArgs) Handles btnextdelete.Click
        watermarktabext()
    End Sub
    '---------------------------------------------------------------^

    Private Sub txtbdpname_TextChanged(sender As Object, e As EventArgs) Handles txtbdpname.TextChanged

    End Sub

    Private Sub btnprdelcv_Click(sender As Object, e As EventArgs) Handles btnprdelcv.Click

    End Sub

    '---------------------------------------------------------------ˇ
    'Comprobramos campos y guardamos a la bd
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
                        nacionalidad='" & txtbdpnacionality.Text & "',telefono=" & CInt(txtbdptlf.Text) & ", email='" & txtbdpemail.Text & "',ruta_foto='" & path & "', localidad='" & txtbdplocality.Text & "' WHERE dni='12345678Z'"

                    MsgBox("Datos añadidos correctamente.")
                Else
                    MsgBox("No se han podido añadir los datos")
                End If

            Catch ex As Exception
                MsgBox("Comprueba que los datos son correctos")
            End Try
        Else
            MsgBox("Debes rellenar todos los campos.")
        End If
    End Sub
    '---------------------------------------------------------------^

    '---------------------------------------------------------------ˇ
    'Abrimos el panel para que el usuario seleccione la foto
    Private Sub btnupphoto_Click(sender As Object, e As EventArgs) Handles btnupphoto.Click
        Dim ofd As New OpenFileDialog()
        ofd.Filter = "Archivos de imagen (*.png, *.jpg)|*.png;*.jpg"
        ofd.Title = "Selecciona una imagen"

        'Show the Dialog. Get the path of the file.
        If ofd.ShowDialog() = DialogResult.OK Then
            path = ofd.FileName.Replace("\", "\\")
        End If

        pbphoto.Image = Image.FromFile(path)
        UserPhoto.Image = Image.FromFile(path)
    End Sub
    '---------------------------------------------------------------^

    '---------------------------------------------------------------ˇ
    'Transformamos la fecha cuando el usuario la selecione
    Private Sub dtpbirth_ValueChanged(sender As Object, e As EventArgs) Handles dtpbirth.ValueChanged
        dateA = dtpbirth.Value.Date
        FinalDate = transformDate(dateA)
    End Sub
    '---------------------------------------------------------------^
End Class