<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserPanel
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabdp = New System.Windows.Forms.TabPage()
        Me.btndpdeleteimg = New System.Windows.Forms.Button()
        Me.dtpbirth = New System.Windows.Forms.DateTimePicker()
        Me.btndpdelete = New System.Windows.Forms.Button()
        Me.btndpsave = New System.Windows.Forms.Button()
        Me.txtbdpdni = New System.Windows.Forms.TextBox()
        Me.pbphoto = New System.Windows.Forms.PictureBox()
        Me.btnupphoto = New System.Windows.Forms.Button()
        Me.txtbdpemail = New System.Windows.Forms.TextBox()
        Me.txtbdptlf = New System.Windows.Forms.TextBox()
        Me.txtbdpnacionality = New System.Windows.Forms.TextBox()
        Me.txtbdplocality = New System.Windows.Forms.TextBox()
        Me.txtdpbdir = New System.Windows.Forms.TextBox()
        Me.txtbdpsurname = New System.Windows.Forms.TextBox()
        Me.txtbdpname = New System.Windows.Forms.TextBox()
        Me.tabfa = New System.Windows.Forms.TabPage()
        Me.lvfa = New System.Windows.Forms.ListView()
        Me.idfa = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.year_ini = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.year_fin = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.nombrefa = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lugarfa = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.descfa = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnfadelete = New System.Windows.Forms.Button()
        Me.btnfasave = New System.Windows.Forms.Button()
        Me.txtfadesc = New System.Windows.Forms.TextBox()
        Me.txtfayearend = New System.Windows.Forms.TextBox()
        Me.txtfayearstart = New System.Windows.Forms.TextBox()
        Me.txtfaplace = New System.Windows.Forms.TextBox()
        Me.txtfaname = New System.Windows.Forms.TextBox()
        Me.tabexp = New System.Windows.Forms.TabPage()
        Me.lvexp = New System.Windows.Forms.ListView()
        Me.idexp = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Años = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Empresa = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Descripcion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnexpdelete = New System.Windows.Forms.Button()
        Me.btnexpsave = New System.Windows.Forms.Button()
        Me.txtexpdesc = New System.Windows.Forms.TextBox()
        Me.txtexpyears = New System.Windows.Forms.TextBox()
        Me.txtexpcompany = New System.Windows.Forms.TextBox()
        Me.tabext = New System.Windows.Forms.TabPage()
        Me.lvextras = New System.Windows.Forms.ListView()
        Me.id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tipo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.titulo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnextdelete = New System.Windows.Forms.Button()
        Me.btnextsave = New System.Windows.Forms.Button()
        Me.txtbexttype = New System.Windows.Forms.TextBox()
        Me.txtbexttittle = New System.Windows.Forms.TextBox()
        Me.tabprofile = New System.Windows.Forms.TabPage()
        Me.btnprdeluser = New System.Windows.Forms.Button()
        Me.btnprgencv = New System.Windows.Forms.Button()
        Me.UserPhoto = New System.Windows.Forms.PictureBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.eptlf = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.epemail = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.tabdp.SuspendLayout()
        CType(Me.pbphoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabfa.SuspendLayout()
        Me.tabexp.SuspendLayout()
        Me.tabext.SuspendLayout()
        Me.tabprofile.SuspendLayout()
        CType(Me.UserPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eptlf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.epemail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabdp)
        Me.TabControl1.Controls.Add(Me.tabfa)
        Me.TabControl1.Controls.Add(Me.tabexp)
        Me.TabControl1.Controls.Add(Me.tabext)
        Me.TabControl1.Controls.Add(Me.tabprofile)
        Me.TabControl1.Location = New System.Drawing.Point(9, 21)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Padding = New System.Drawing.Point(0, 0)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(561, 339)
        Me.TabControl1.TabIndex = 0
        '
        'tabdp
        '
        Me.tabdp.BackColor = System.Drawing.Color.White
        Me.tabdp.Controls.Add(Me.btndpdeleteimg)
        Me.tabdp.Controls.Add(Me.dtpbirth)
        Me.tabdp.Controls.Add(Me.btndpdelete)
        Me.tabdp.Controls.Add(Me.btndpsave)
        Me.tabdp.Controls.Add(Me.txtbdpdni)
        Me.tabdp.Controls.Add(Me.pbphoto)
        Me.tabdp.Controls.Add(Me.btnupphoto)
        Me.tabdp.Controls.Add(Me.txtbdpemail)
        Me.tabdp.Controls.Add(Me.txtbdptlf)
        Me.tabdp.Controls.Add(Me.txtbdpnacionality)
        Me.tabdp.Controls.Add(Me.txtbdplocality)
        Me.tabdp.Controls.Add(Me.txtdpbdir)
        Me.tabdp.Controls.Add(Me.txtbdpsurname)
        Me.tabdp.Controls.Add(Me.txtbdpname)
        Me.tabdp.Location = New System.Drawing.Point(4, 22)
        Me.tabdp.Margin = New System.Windows.Forms.Padding(0)
        Me.tabdp.Name = "tabdp"
        Me.tabdp.Size = New System.Drawing.Size(553, 313)
        Me.tabdp.TabIndex = 0
        Me.tabdp.Text = "Datos personales"
        '
        'btndpdeleteimg
        '
        Me.btndpdeleteimg.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btndpdeleteimg.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btndpdeleteimg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndpdeleteimg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btndpdeleteimg.ForeColor = System.Drawing.Color.White
        Me.btndpdeleteimg.Location = New System.Drawing.Point(424, 159)
        Me.btndpdeleteimg.Name = "btndpdeleteimg"
        Me.btndpdeleteimg.Size = New System.Drawing.Size(102, 23)
        Me.btndpdeleteimg.TabIndex = 31
        Me.btndpdeleteimg.Text = "Borrar Imagen"
        Me.btndpdeleteimg.UseVisualStyleBackColor = False
        '
        'dtpbirth
        '
        Me.dtpbirth.Location = New System.Drawing.Point(33, 123)
        Me.dtpbirth.MaxDate = New Date(2016, 12, 6, 0, 0, 0, 0)
        Me.dtpbirth.Name = "dtpbirth"
        Me.dtpbirth.Size = New System.Drawing.Size(225, 20)
        Me.dtpbirth.TabIndex = 13
        Me.dtpbirth.Value = New Date(2016, 12, 6, 0, 0, 0, 0)
        '
        'btndpdelete
        '
        Me.btndpdelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btndpdelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btndpdelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndpdelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btndpdelete.ForeColor = System.Drawing.Color.White
        Me.btndpdelete.Location = New System.Drawing.Point(374, 271)
        Me.btndpdelete.Name = "btndpdelete"
        Me.btndpdelete.Size = New System.Drawing.Size(102, 23)
        Me.btndpdelete.TabIndex = 12
        Me.btndpdelete.Text = "Borrar datos"
        Me.btndpdelete.UseVisualStyleBackColor = False
        '
        'btndpsave
        '
        Me.btndpsave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btndpsave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btndpsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndpsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btndpsave.ForeColor = System.Drawing.Color.White
        Me.btndpsave.Location = New System.Drawing.Point(86, 271)
        Me.btndpsave.Name = "btndpsave"
        Me.btndpsave.Size = New System.Drawing.Size(102, 23)
        Me.btndpsave.TabIndex = 11
        Me.btndpsave.Text = "Guardar"
        Me.btndpsave.UseVisualStyleBackColor = False
        '
        'txtbdpdni
        '
        Me.txtbdpdni.Enabled = False
        Me.txtbdpdni.Location = New System.Drawing.Point(33, 15)
        Me.txtbdpdni.Name = "txtbdpdni"
        Me.txtbdpdni.Size = New System.Drawing.Size(225, 20)
        Me.txtbdpdni.TabIndex = 10
        '
        'pbphoto
        '
        Me.pbphoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbphoto.Location = New System.Drawing.Point(363, 15)
        Me.pbphoto.Name = "pbphoto"
        Me.pbphoto.Size = New System.Drawing.Size(126, 132)
        Me.pbphoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbphoto.TabIndex = 9
        Me.pbphoto.TabStop = False
        '
        'btnupphoto
        '
        Me.btnupphoto.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btnupphoto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btnupphoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnupphoto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnupphoto.ForeColor = System.Drawing.Color.White
        Me.btnupphoto.Location = New System.Drawing.Point(316, 159)
        Me.btnupphoto.Name = "btnupphoto"
        Me.btnupphoto.Size = New System.Drawing.Size(102, 23)
        Me.btnupphoto.TabIndex = 8
        Me.btnupphoto.Text = "Subir"
        Me.btnupphoto.UseVisualStyleBackColor = False
        '
        'txtbdpemail
        '
        Me.txtbdpemail.ForeColor = System.Drawing.Color.Gray
        Me.txtbdpemail.Location = New System.Drawing.Point(33, 231)
        Me.txtbdpemail.Name = "txtbdpemail"
        Me.txtbdpemail.Size = New System.Drawing.Size(225, 20)
        Me.txtbdpemail.TabIndex = 7
        Me.txtbdpemail.Tag = "Email"
        '
        'txtbdptlf
        '
        Me.txtbdptlf.ForeColor = System.Drawing.Color.Gray
        Me.txtbdptlf.Location = New System.Drawing.Point(316, 231)
        Me.txtbdptlf.Name = "txtbdptlf"
        Me.txtbdptlf.Size = New System.Drawing.Size(208, 20)
        Me.txtbdptlf.TabIndex = 6
        Me.txtbdptlf.Tag = "Teléfono"
        '
        'txtbdpnacionality
        '
        Me.txtbdpnacionality.ForeColor = System.Drawing.Color.Gray
        Me.txtbdpnacionality.Location = New System.Drawing.Point(33, 195)
        Me.txtbdpnacionality.Name = "txtbdpnacionality"
        Me.txtbdpnacionality.Size = New System.Drawing.Size(225, 20)
        Me.txtbdpnacionality.TabIndex = 5
        Me.txtbdpnacionality.Tag = "Nacionalidad"
        '
        'txtbdplocality
        '
        Me.txtbdplocality.ForeColor = System.Drawing.Color.Gray
        Me.txtbdplocality.Location = New System.Drawing.Point(316, 195)
        Me.txtbdplocality.Name = "txtbdplocality"
        Me.txtbdplocality.Size = New System.Drawing.Size(208, 20)
        Me.txtbdplocality.TabIndex = 4
        Me.txtbdplocality.Tag = "Localidad"
        '
        'txtdpbdir
        '
        Me.txtdpbdir.ForeColor = System.Drawing.Color.Gray
        Me.txtdpbdir.Location = New System.Drawing.Point(33, 159)
        Me.txtdpbdir.Name = "txtdpbdir"
        Me.txtdpbdir.Size = New System.Drawing.Size(225, 20)
        Me.txtdpbdir.TabIndex = 3
        Me.txtdpbdir.Tag = "Dirección"
        '
        'txtbdpsurname
        '
        Me.txtbdpsurname.ForeColor = System.Drawing.Color.Gray
        Me.txtbdpsurname.Location = New System.Drawing.Point(33, 87)
        Me.txtbdpsurname.Name = "txtbdpsurname"
        Me.txtbdpsurname.Size = New System.Drawing.Size(225, 20)
        Me.txtbdpsurname.TabIndex = 1
        Me.txtbdpsurname.Tag = "Apellidos"
        '
        'txtbdpname
        '
        Me.txtbdpname.ForeColor = System.Drawing.Color.Gray
        Me.txtbdpname.Location = New System.Drawing.Point(33, 51)
        Me.txtbdpname.Name = "txtbdpname"
        Me.txtbdpname.Size = New System.Drawing.Size(225, 20)
        Me.txtbdpname.TabIndex = 0
        Me.txtbdpname.Tag = "Nombre"
        '
        'tabfa
        '
        Me.tabfa.BackColor = System.Drawing.Color.White
        Me.tabfa.Controls.Add(Me.lvfa)
        Me.tabfa.Controls.Add(Me.btnfadelete)
        Me.tabfa.Controls.Add(Me.btnfasave)
        Me.tabfa.Controls.Add(Me.txtfadesc)
        Me.tabfa.Controls.Add(Me.txtfayearend)
        Me.tabfa.Controls.Add(Me.txtfayearstart)
        Me.tabfa.Controls.Add(Me.txtfaplace)
        Me.tabfa.Controls.Add(Me.txtfaname)
        Me.tabfa.Location = New System.Drawing.Point(4, 22)
        Me.tabfa.Name = "tabfa"
        Me.tabfa.Padding = New System.Windows.Forms.Padding(3)
        Me.tabfa.Size = New System.Drawing.Size(553, 313)
        Me.tabfa.TabIndex = 1
        Me.tabfa.Text = "Formación académica"
        '
        'lvfa
        '
        Me.lvfa.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.idfa, Me.year_ini, Me.year_fin, Me.nombrefa, Me.lugarfa, Me.descfa})
        Me.lvfa.FullRowSelect = True
        Me.lvfa.GridLines = True
        Me.lvfa.Location = New System.Drawing.Point(22, 123)
        Me.lvfa.Name = "lvfa"
        Me.lvfa.Size = New System.Drawing.Size(503, 146)
        Me.lvfa.TabIndex = 27
        Me.lvfa.UseCompatibleStateImageBehavior = False
        Me.lvfa.View = System.Windows.Forms.View.Details
        '
        'idfa
        '
        Me.idfa.Text = "ID"
        Me.idfa.Width = 39
        '
        'year_ini
        '
        Me.year_ini.Text = "Año Inicio"
        Me.year_ini.Width = 74
        '
        'year_fin
        '
        Me.year_fin.Text = "Año Fin"
        Me.year_fin.Width = 68
        '
        'nombrefa
        '
        Me.nombrefa.Text = "Nombre"
        Me.nombrefa.Width = 65
        '
        'lugarfa
        '
        Me.lugarfa.Text = "Lugar"
        Me.lugarfa.Width = 69
        '
        'descfa
        '
        Me.descfa.Text = "Descripción"
        Me.descfa.Width = 183
        '
        'btnfadelete
        '
        Me.btnfadelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btnfadelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btnfadelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnfadelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnfadelete.ForeColor = System.Drawing.Color.White
        Me.btnfadelete.Location = New System.Drawing.Point(364, 275)
        Me.btnfadelete.Name = "btnfadelete"
        Me.btnfadelete.Size = New System.Drawing.Size(102, 23)
        Me.btnfadelete.TabIndex = 26
        Me.btnfadelete.Text = "Borrar Registro"
        Me.btnfadelete.UseVisualStyleBackColor = False
        '
        'btnfasave
        '
        Me.btnfasave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btnfasave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btnfasave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnfasave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnfasave.ForeColor = System.Drawing.Color.White
        Me.btnfasave.Location = New System.Drawing.Point(76, 275)
        Me.btnfasave.Name = "btnfasave"
        Me.btnfasave.Size = New System.Drawing.Size(102, 23)
        Me.btnfasave.TabIndex = 25
        Me.btnfasave.Text = "Guardar"
        Me.btnfasave.UseVisualStyleBackColor = False
        '
        'txtfadesc
        '
        Me.txtfadesc.ForeColor = System.Drawing.Color.Gray
        Me.txtfadesc.Location = New System.Drawing.Point(22, 83)
        Me.txtfadesc.Name = "txtfadesc"
        Me.txtfadesc.Size = New System.Drawing.Size(507, 20)
        Me.txtfadesc.TabIndex = 24
        Me.txtfadesc.Tag = "Descripción"
        '
        'txtfayearend
        '
        Me.txtfayearend.ForeColor = System.Drawing.Color.Gray
        Me.txtfayearend.Location = New System.Drawing.Point(305, 50)
        Me.txtfayearend.Name = "txtfayearend"
        Me.txtfayearend.Size = New System.Drawing.Size(225, 20)
        Me.txtfayearend.TabIndex = 22
        Me.txtfayearend.Tag = "Año Fin"
        '
        'txtfayearstart
        '
        Me.txtfayearstart.ForeColor = System.Drawing.Color.Gray
        Me.txtfayearstart.Location = New System.Drawing.Point(22, 50)
        Me.txtfayearstart.Name = "txtfayearstart"
        Me.txtfayearstart.Size = New System.Drawing.Size(225, 20)
        Me.txtfayearstart.TabIndex = 21
        Me.txtfayearstart.Tag = "Año Inicio"
        '
        'txtfaplace
        '
        Me.txtfaplace.ForeColor = System.Drawing.Color.Gray
        Me.txtfaplace.Location = New System.Drawing.Point(305, 15)
        Me.txtfaplace.Name = "txtfaplace"
        Me.txtfaplace.Size = New System.Drawing.Size(225, 20)
        Me.txtfaplace.TabIndex = 20
        Me.txtfaplace.Tag = "Lugar"
        '
        'txtfaname
        '
        Me.txtfaname.ForeColor = System.Drawing.Color.Gray
        Me.txtfaname.Location = New System.Drawing.Point(22, 15)
        Me.txtfaname.Name = "txtfaname"
        Me.txtfaname.Size = New System.Drawing.Size(225, 20)
        Me.txtfaname.TabIndex = 19
        Me.txtfaname.Tag = "Nombre"
        '
        'tabexp
        '
        Me.tabexp.BackColor = System.Drawing.Color.White
        Me.tabexp.Controls.Add(Me.lvexp)
        Me.tabexp.Controls.Add(Me.btnexpdelete)
        Me.tabexp.Controls.Add(Me.btnexpsave)
        Me.tabexp.Controls.Add(Me.txtexpdesc)
        Me.tabexp.Controls.Add(Me.txtexpyears)
        Me.tabexp.Controls.Add(Me.txtexpcompany)
        Me.tabexp.Location = New System.Drawing.Point(4, 22)
        Me.tabexp.Name = "tabexp"
        Me.tabexp.Padding = New System.Windows.Forms.Padding(3)
        Me.tabexp.Size = New System.Drawing.Size(553, 313)
        Me.tabexp.TabIndex = 2
        Me.tabexp.Text = "Experiencia"
        '
        'lvexp
        '
        Me.lvexp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvexp.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.idexp, Me.Años, Me.Empresa, Me.Descripcion})
        Me.lvexp.FullRowSelect = True
        Me.lvexp.GridLines = True
        Me.lvexp.Location = New System.Drawing.Point(22, 127)
        Me.lvexp.Name = "lvexp"
        Me.lvexp.Size = New System.Drawing.Size(506, 130)
        Me.lvexp.TabIndex = 27
        Me.lvexp.UseCompatibleStateImageBehavior = False
        Me.lvexp.View = System.Windows.Forms.View.Details
        '
        'idexp
        '
        Me.idexp.Text = "ID"
        Me.idexp.Width = 38
        '
        'Años
        '
        Me.Años.Text = "Años"
        '
        'Empresa
        '
        Me.Empresa.Text = "Empresa"
        Me.Empresa.Width = 59
        '
        'Descripcion
        '
        Me.Descripcion.Text = "Descripción"
        Me.Descripcion.Width = 341
        '
        'btnexpdelete
        '
        Me.btnexpdelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btnexpdelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btnexpdelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnexpdelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnexpdelete.ForeColor = System.Drawing.Color.White
        Me.btnexpdelete.Location = New System.Drawing.Point(364, 275)
        Me.btnexpdelete.Name = "btnexpdelete"
        Me.btnexpdelete.Size = New System.Drawing.Size(102, 23)
        Me.btnexpdelete.TabIndex = 26
        Me.btnexpdelete.Text = "Borrar Registro"
        Me.btnexpdelete.UseVisualStyleBackColor = False
        '
        'btnexpsave
        '
        Me.btnexpsave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btnexpsave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btnexpsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnexpsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnexpsave.ForeColor = System.Drawing.Color.White
        Me.btnexpsave.Location = New System.Drawing.Point(76, 275)
        Me.btnexpsave.Name = "btnexpsave"
        Me.btnexpsave.Size = New System.Drawing.Size(102, 23)
        Me.btnexpsave.TabIndex = 25
        Me.btnexpsave.Text = "Guardar"
        Me.btnexpsave.UseVisualStyleBackColor = False
        '
        'txtexpdesc
        '
        Me.txtexpdesc.ForeColor = System.Drawing.Color.Gray
        Me.txtexpdesc.Location = New System.Drawing.Point(22, 83)
        Me.txtexpdesc.Name = "txtexpdesc"
        Me.txtexpdesc.Size = New System.Drawing.Size(507, 20)
        Me.txtexpdesc.TabIndex = 24
        Me.txtexpdesc.Tag = "Descripción"
        '
        'txtexpyears
        '
        Me.txtexpyears.ForeColor = System.Drawing.Color.Gray
        Me.txtexpyears.Location = New System.Drawing.Point(22, 50)
        Me.txtexpyears.Name = "txtexpyears"
        Me.txtexpyears.Size = New System.Drawing.Size(508, 20)
        Me.txtexpyears.TabIndex = 21
        Me.txtexpyears.Tag = "Años"
        '
        'txtexpcompany
        '
        Me.txtexpcompany.ForeColor = System.Drawing.Color.Gray
        Me.txtexpcompany.Location = New System.Drawing.Point(22, 15)
        Me.txtexpcompany.Name = "txtexpcompany"
        Me.txtexpcompany.Size = New System.Drawing.Size(508, 20)
        Me.txtexpcompany.TabIndex = 19
        Me.txtexpcompany.Tag = "Empresa"
        '
        'tabext
        '
        Me.tabext.BackColor = System.Drawing.Color.White
        Me.tabext.Controls.Add(Me.lvextras)
        Me.tabext.Controls.Add(Me.btnextdelete)
        Me.tabext.Controls.Add(Me.btnextsave)
        Me.tabext.Controls.Add(Me.txtbexttype)
        Me.tabext.Controls.Add(Me.txtbexttittle)
        Me.tabext.Location = New System.Drawing.Point(4, 22)
        Me.tabext.Name = "tabext"
        Me.tabext.Padding = New System.Windows.Forms.Padding(3)
        Me.tabext.Size = New System.Drawing.Size(553, 313)
        Me.tabext.TabIndex = 3
        Me.tabext.Text = "Extras"
        '
        'lvextras
        '
        Me.lvextras.BackColor = System.Drawing.Color.White
        Me.lvextras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvextras.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.id, Me.tipo, Me.titulo})
        Me.lvextras.FullRowSelect = True
        Me.lvextras.GridLines = True
        Me.lvextras.Location = New System.Drawing.Point(21, 110)
        Me.lvextras.Name = "lvextras"
        Me.lvextras.Size = New System.Drawing.Size(509, 131)
        Me.lvextras.TabIndex = 29
        Me.lvextras.UseCompatibleStateImageBehavior = False
        Me.lvextras.View = System.Windows.Forms.View.Details
        '
        'id
        '
        Me.id.Text = "ID"
        Me.id.Width = 50
        '
        'tipo
        '
        Me.tipo.Text = "Tipo"
        Me.tipo.Width = 130
        '
        'titulo
        '
        Me.titulo.Text = "Titulo"
        Me.titulo.Width = 170
        '
        'btnextdelete
        '
        Me.btnextdelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btnextdelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btnextdelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnextdelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnextdelete.ForeColor = System.Drawing.Color.White
        Me.btnextdelete.Location = New System.Drawing.Point(363, 261)
        Me.btnextdelete.Name = "btnextdelete"
        Me.btnextdelete.Size = New System.Drawing.Size(102, 23)
        Me.btnextdelete.TabIndex = 26
        Me.btnextdelete.Text = "Borrar Registro"
        Me.btnextdelete.UseVisualStyleBackColor = False
        '
        'btnextsave
        '
        Me.btnextsave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btnextsave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btnextsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnextsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnextsave.ForeColor = System.Drawing.Color.White
        Me.btnextsave.Location = New System.Drawing.Point(75, 261)
        Me.btnextsave.Name = "btnextsave"
        Me.btnextsave.Size = New System.Drawing.Size(102, 23)
        Me.btnextsave.TabIndex = 25
        Me.btnextsave.Text = "Guardar"
        Me.btnextsave.UseVisualStyleBackColor = False
        '
        'txtbexttype
        '
        Me.txtbexttype.ForeColor = System.Drawing.Color.Gray
        Me.txtbexttype.Location = New System.Drawing.Point(305, 37)
        Me.txtbexttype.Name = "txtbexttype"
        Me.txtbexttype.Size = New System.Drawing.Size(225, 20)
        Me.txtbexttype.TabIndex = 20
        Me.txtbexttype.Tag = "Tipo"
        '
        'txtbexttittle
        '
        Me.txtbexttittle.ForeColor = System.Drawing.Color.Gray
        Me.txtbexttittle.Location = New System.Drawing.Point(22, 37)
        Me.txtbexttittle.Name = "txtbexttittle"
        Me.txtbexttittle.Size = New System.Drawing.Size(225, 20)
        Me.txtbexttittle.TabIndex = 19
        Me.txtbexttittle.Tag = "Título"
        '
        'tabprofile
        '
        Me.tabprofile.BackColor = System.Drawing.Color.White
        Me.tabprofile.Controls.Add(Me.btnprdeluser)
        Me.tabprofile.Controls.Add(Me.btnprgencv)
        Me.tabprofile.Controls.Add(Me.UserPhoto)
        Me.tabprofile.Location = New System.Drawing.Point(4, 22)
        Me.tabprofile.Name = "tabprofile"
        Me.tabprofile.Padding = New System.Windows.Forms.Padding(3)
        Me.tabprofile.Size = New System.Drawing.Size(553, 313)
        Me.tabprofile.TabIndex = 4
        Me.tabprofile.Text = "Perfil"
        '
        'btnprdeluser
        '
        Me.btnprdeluser.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btnprdeluser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btnprdeluser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnprdeluser.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnprdeluser.ForeColor = System.Drawing.Color.White
        Me.btnprdeluser.Location = New System.Drawing.Point(216, 242)
        Me.btnprdeluser.Name = "btnprdeluser"
        Me.btnprdeluser.Size = New System.Drawing.Size(126, 23)
        Me.btnprdeluser.TabIndex = 31
        Me.btnprdeluser.Text = "Borrar Usuario"
        Me.btnprdeluser.UseVisualStyleBackColor = False
        '
        'btnprgencv
        '
        Me.btnprgencv.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btnprgencv.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btnprgencv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnprgencv.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnprgencv.ForeColor = System.Drawing.Color.White
        Me.btnprgencv.Location = New System.Drawing.Point(216, 203)
        Me.btnprgencv.Name = "btnprgencv"
        Me.btnprgencv.Size = New System.Drawing.Size(126, 23)
        Me.btnprgencv.TabIndex = 29
        Me.btnprgencv.Text = "Generar Curriculum"
        Me.btnprgencv.UseVisualStyleBackColor = False
        '
        'UserPhoto
        '
        Me.UserPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UserPhoto.Location = New System.Drawing.Point(216, 35)
        Me.UserPhoto.Name = "UserPhoto"
        Me.UserPhoto.Size = New System.Drawing.Size(126, 132)
        Me.UserPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.UserPhoto.TabIndex = 10
        Me.UserPhoto.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(550, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(30, 30)
        Me.btnClose.TabIndex = 8
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'eptlf
        '
        Me.eptlf.ContainerControl = Me
        '
        'epemail
        '
        Me.epemail.ContainerControl = Me
        '
        'UserPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(580, 370)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "UserPanel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.TabControl1.ResumeLayout(False)
        Me.tabdp.ResumeLayout(False)
        Me.tabdp.PerformLayout()
        CType(Me.pbphoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabfa.ResumeLayout(False)
        Me.tabfa.PerformLayout()
        Me.tabexp.ResumeLayout(False)
        Me.tabexp.PerformLayout()
        Me.tabext.ResumeLayout(False)
        Me.tabext.PerformLayout()
        Me.tabprofile.ResumeLayout(False)
        CType(Me.UserPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eptlf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.epemail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabdp As TabPage
    Friend WithEvents tabfa As TabPage
    Friend WithEvents tabexp As TabPage
    Friend WithEvents tabext As TabPage
    Friend WithEvents tabprofile As TabPage
    Friend WithEvents txtbdpemail As TextBox
    Friend WithEvents txtbdptlf As TextBox
    Friend WithEvents txtbdpnacionality As TextBox
    Friend WithEvents txtbdplocality As TextBox
    Friend WithEvents txtdpbdir As TextBox
    Friend WithEvents txtbdpsurname As TextBox
    Friend WithEvents txtbdpname As TextBox
    Friend WithEvents btnClose As Button
    Friend WithEvents txtbdpdni As TextBox
    Friend WithEvents pbphoto As PictureBox
    Friend WithEvents btnupphoto As Button
    Friend WithEvents btndpdelete As Button
    Friend WithEvents btndpsave As Button
    Friend WithEvents btnfadelete As Button
    Friend WithEvents btnfasave As Button
    Friend WithEvents txtfadesc As TextBox
    Friend WithEvents txtfayearend As TextBox
    Friend WithEvents txtfayearstart As TextBox
    Friend WithEvents txtfaplace As TextBox
    Friend WithEvents txtfaname As TextBox
    Friend WithEvents btnexpdelete As Button
    Friend WithEvents btnexpsave As Button
    Friend WithEvents txtexpcompany As TextBox
    Friend WithEvents btnextdelete As Button
    Friend WithEvents btnextsave As Button
    Friend WithEvents txtbexttype As TextBox
    Friend WithEvents txtbexttittle As TextBox
    Friend WithEvents txtexpdesc As TextBox
    Friend WithEvents txtexpyears As TextBox
    Friend WithEvents UserPhoto As PictureBox
    Friend WithEvents btnprgencv As Button
    Friend WithEvents btnprdeluser As Button
    Friend WithEvents lvextras As ListView
    Friend WithEvents id As ColumnHeader
    Friend WithEvents tipo As ColumnHeader
    Friend WithEvents titulo As ColumnHeader
    Friend WithEvents lvfa As ListView
    Friend WithEvents idfa As ColumnHeader
    Friend WithEvents year_ini As ColumnHeader
    Friend WithEvents year_fin As ColumnHeader
    Friend WithEvents nombrefa As ColumnHeader
    Friend WithEvents lugarfa As ColumnHeader
    Friend WithEvents lvexp As ListView
    Friend WithEvents idexp As ColumnHeader
    Friend WithEvents Años As ColumnHeader
    Friend WithEvents Empresa As ColumnHeader
    Friend WithEvents Descripcion As ColumnHeader
    Friend WithEvents dtpbirth As DateTimePicker
    Friend WithEvents eptlf As ErrorProvider
    Friend WithEvents epemail As ErrorProvider
    Friend WithEvents descfa As ColumnHeader
    Friend WithEvents btndpdeleteimg As Button
End Class
