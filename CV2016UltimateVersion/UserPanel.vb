Public Class UserPanel
    Dim lasttext As String

    'Nos coloca la marca de agua en el textbox para saber que dato tenemos que poner
    'Marcas de agua en los textbox de la pestaña datos personales
    Private Sub watermarktabdp()
        txtbdpname.Text = "Nombre"
        txtbdpsurname.Text = "Apellidos"
        txtbdpbirthd.Text = "Fecha Nacimiento"
        txtdpbdir.Text = "Dirección"
        txtbdpnacionality.Text = "Nacionalidad"
        txtbdplocality.Text = "Localidad"
        txtbdpemail.Text = "Email"
        txtbdptlf.Text = "Teléfono"

        txtbdpname.ForeColor = Color.Gray
        txtbdpsurname.ForeColor = Color.Gray
        txtbdpbirthd.ForeColor = Color.Gray
        txtdpbdir.ForeColor = Color.Gray
        txtbdpnacionality.ForeColor = Color.Gray
        txtbdplocality.ForeColor = Color.Gray
        txtbdpemail.ForeColor = Color.Gray
        txtbdptlf.ForeColor = Color.Gray

        AddHandler txtbdpname.GotFocus, AddressOf GotfocusTexto
        AddHandler txtbdpsurname.GotFocus, AddressOf GotfocusTexto
        AddHandler txtbdpbirthd.GotFocus, AddressOf GotfocusTexto
        AddHandler txtdpbdir.GotFocus, AddressOf GotfocusTexto
        AddHandler txtbdpnacionality.GotFocus, AddressOf GotfocusTexto
        AddHandler txtbdplocality.GotFocus, AddressOf GotfocusTexto
        AddHandler txtbdpemail.GotFocus, AddressOf GotfocusTexto
        AddHandler txtbdptlf.GotFocus, AddressOf GotfocusTexto

        AddHandler txtbdpname.LostFocus, AddressOf LostfocusTexto
        AddHandler txtbdpsurname.LostFocus, AddressOf LostfocusTexto
        AddHandler txtbdpbirthd.LostFocus, AddressOf LostfocusTexto
        AddHandler txtdpbdir.LostFocus, AddressOf LostfocusTexto
        AddHandler txtbdpnacionality.LostFocus, AddressOf LostfocusTexto
        AddHandler txtbdplocality.LostFocus, AddressOf LostfocusTexto
        AddHandler txtbdpemail.LostFocus, AddressOf LostfocusTexto
        AddHandler txtbdptlf.LostFocus, AddressOf LostfocusTexto

    End Sub

    'Marcas de agua en los textbox de la pestaña formacion academica
    Private Sub watermarktabfa()
        txtfaname.Text = "Nombre"
        txtfaplace.Text = "Lugar"
        txtfayearstart.Text = "Año Inicio"
        txtfayearend.Text = "Año Fin"
        txtfadesc.Text = "Descripción"

        txtfaname.ForeColor = Color.Gray
        txtfaplace.ForeColor = Color.Gray
        txtfayearstart.ForeColor = Color.Gray
        txtfayearend.ForeColor = Color.Gray
        txtfadesc.ForeColor = Color.Gray

        AddHandler txtfaname.GotFocus, AddressOf GotfocusTexto
        AddHandler txtfaplace.GotFocus, AddressOf GotfocusTexto
        AddHandler txtfayearstart.GotFocus, AddressOf GotfocusTexto
        AddHandler txtfayearend.GotFocus, AddressOf GotfocusTexto
        AddHandler txtfadesc.GotFocus, AddressOf GotfocusTexto

        AddHandler txtfaname.LostFocus, AddressOf LostfocusTexto
        AddHandler txtfaplace.LostFocus, AddressOf LostfocusTexto
        AddHandler txtfayearstart.LostFocus, AddressOf LostfocusTexto
        AddHandler txtfayearend.LostFocus, AddressOf LostfocusTexto
        AddHandler txtfadesc.LostFocus, AddressOf LostfocusTexto
    End Sub

    'Marca de agua en los textbox de la pestaña experiencia
    Private Sub watermarktabexp()
        txtexpcompany.Text = "Empresa"
        txtexpyeari.Text = "Año Inicio"
        txtexpyeare.Text = "Año Fin"
        txtexpdesc.Text = "Descripción"

        txtexpcompany.ForeColor = Color.Gray
        txtexpyeari.ForeColor = Color.Gray
        txtexpyeare.ForeColor = Color.Gray
        txtexpdesc.ForeColor = Color.Gray

        AddHandler txtexpcompany.GotFocus, AddressOf GotfocusTexto
        AddHandler txtexpyeari.GotFocus, AddressOf GotfocusTexto
        AddHandler txtexpyeare.GotFocus, AddressOf GotfocusTexto
        AddHandler txtexpdesc.GotFocus, AddressOf GotfocusTexto

        AddHandler txtexpcompany.LostFocus, AddressOf LostfocusTexto
        AddHandler txtexpyeari.LostFocus, AddressOf LostfocusTexto
        AddHandler txtexpyeare.LostFocus, AddressOf LostfocusTexto
        AddHandler txtexpdesc.LostFocus, AddressOf LostfocusTexto
    End Sub

    'Marca de agua en los textbox de la pestaña extras
    Private Sub watermarktabext()
        txtbexttittle.Text = "Título"
        txtbexttype.Text = "Tipo"

        txtbexttittle.ForeColor = Color.Gray
        txtbexttype.ForeColor = Color.Gray

        AddHandler txtbexttittle.GotFocus, AddressOf GotfocusTexto
        AddHandler txtbexttype.GotFocus, AddressOf GotfocusTexto

        AddHandler txtbexttittle.LostFocus, AddressOf LostfocusTexto
        AddHandler txtbexttype.LostFocus, AddressOf LostfocusTexto
    End Sub

    Private Sub GotfocusTexto(ByVal sender As Object, ByVal e As EventArgs)
        lasttext = sender.Text
        sender.Text = ""
        sender.ForeColor = Color.Black
    End Sub

    Private Sub LostfocusTexto(ByVal sender As Object, ByVal e As EventArgs)
        If sender.Text = "" Then
            sender.text = lasttext
            sender.Forecolor = Color.Gray
        End If
    End Sub

    Private Sub UserPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Cargamos marcas de aguas en las distintas pestañas
        watermarktabdp()
        watermarktabfa()
        watermarktabexp()
        watermarktabext()

    End Sub

    'Boton para salir de la aplicación
    Private Sub btnlog_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim res As Integer

        res = MsgBox("¿Está seguro que desea salir?", vbYesNo)
        If res = 6 Then
            Application.Exit()
        End If
    End Sub

    Private Sub txtformname_TextChanged(sender As Object, e As EventArgs) Handles txtfaname.TextChanged

    End Sub

    Private Sub txtbemail_TextChanged(sender As Object, e As EventArgs) Handles txtbdpemail.TextChanged

    End Sub


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
End Class