<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserPanel
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabdp = New System.Windows.Forms.TabPage()
        Me.btndpdelete = New System.Windows.Forms.Button()
        Me.btndpsave = New System.Windows.Forms.Button()
        Me.txtbdpdni = New System.Windows.Forms.TextBox()
        Me.btnupphoto = New System.Windows.Forms.Button()
        Me.txtbdpemail = New System.Windows.Forms.TextBox()
        Me.txtbdptlf = New System.Windows.Forms.TextBox()
        Me.txtbdpnacionality = New System.Windows.Forms.TextBox()
        Me.txtbdplocality = New System.Windows.Forms.TextBox()
        Me.txtdpbdir = New System.Windows.Forms.TextBox()
        Me.txtbdpbirthd = New System.Windows.Forms.TextBox()
        Me.txtbdpsurname = New System.Windows.Forms.TextBox()
        Me.txtbdpname = New System.Windows.Forms.TextBox()
        Me.tabfa = New System.Windows.Forms.TabPage()
        Me.btnfadelete = New System.Windows.Forms.Button()
        Me.btnfasave = New System.Windows.Forms.Button()
        Me.txtfadesc = New System.Windows.Forms.TextBox()
        Me.dgvfa = New System.Windows.Forms.DataGridView()
        Me.txtfayearend = New System.Windows.Forms.TextBox()
        Me.txtfayearstart = New System.Windows.Forms.TextBox()
        Me.txtfaplace = New System.Windows.Forms.TextBox()
        Me.txtfaname = New System.Windows.Forms.TextBox()
        Me.tabexp = New System.Windows.Forms.TabPage()
        Me.btnexpdelete = New System.Windows.Forms.Button()
        Me.btnexpsave = New System.Windows.Forms.Button()
        Me.txtexpdesc = New System.Windows.Forms.TextBox()
        Me.dgvexp = New System.Windows.Forms.DataGridView()
        Me.txtexpyeare = New System.Windows.Forms.TextBox()
        Me.txtexpyeari = New System.Windows.Forms.TextBox()
        Me.txtexpcompany = New System.Windows.Forms.TextBox()
        Me.tabext = New System.Windows.Forms.TabPage()
        Me.btnextdelete = New System.Windows.Forms.Button()
        Me.btnextsave = New System.Windows.Forms.Button()
        Me.dgvextra = New System.Windows.Forms.DataGridView()
        Me.txtbexttype = New System.Windows.Forms.TextBox()
        Me.txtbexttittle = New System.Windows.Forms.TextBox()
        Me.tabprofile = New System.Windows.Forms.TabPage()
        Me.btnprdeluser = New System.Windows.Forms.Button()
        Me.btnprdelcv = New System.Windows.Forms.Button()
        Me.btnprgencv = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.pbphoto = New System.Windows.Forms.PictureBox()
        Me.UserPhoto = New System.Windows.Forms.PictureBox()
        Me.TabControl1.SuspendLayout()
        Me.tabdp.SuspendLayout()
        Me.tabfa.SuspendLayout()
        CType(Me.dgvfa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabexp.SuspendLayout()
        CType(Me.dgvexp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabext.SuspendLayout()
        CType(Me.dgvextra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabprofile.SuspendLayout()
        CType(Me.pbphoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tabdp.Controls.Add(Me.txtbdpbirthd)
        Me.tabdp.Controls.Add(Me.txtbdpsurname)
        Me.tabdp.Controls.Add(Me.txtbdpname)
        Me.tabdp.Location = New System.Drawing.Point(4, 22)
        Me.tabdp.Margin = New System.Windows.Forms.Padding(0)
        Me.tabdp.Name = "tabdp"
        Me.tabdp.Size = New System.Drawing.Size(553, 313)
        Me.tabdp.TabIndex = 0
        Me.tabdp.Text = "Datos personales"
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
        Me.txtbdpdni.Text = "Dni"
        '
        'btnupphoto
        '
        Me.btnupphoto.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btnupphoto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btnupphoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnupphoto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnupphoto.ForeColor = System.Drawing.Color.White
        Me.btnupphoto.Location = New System.Drawing.Point(374, 159)
        Me.btnupphoto.Name = "btnupphoto"
        Me.btnupphoto.Size = New System.Drawing.Size(102, 23)
        Me.btnupphoto.TabIndex = 8
        Me.btnupphoto.Text = "Subir"
        Me.btnupphoto.UseVisualStyleBackColor = False
        '
        'txtbdpemail
        '
        Me.txtbdpemail.Location = New System.Drawing.Point(33, 231)
        Me.txtbdpemail.Name = "txtbdpemail"
        Me.txtbdpemail.Size = New System.Drawing.Size(225, 20)
        Me.txtbdpemail.TabIndex = 7
        '
        'txtbdptlf
        '
        Me.txtbdptlf.Location = New System.Drawing.Point(316, 231)
        Me.txtbdptlf.Name = "txtbdptlf"
        Me.txtbdptlf.Size = New System.Drawing.Size(208, 20)
        Me.txtbdptlf.TabIndex = 6
        '
        'txtbdpnacionality
        '
        Me.txtbdpnacionality.Location = New System.Drawing.Point(33, 195)
        Me.txtbdpnacionality.Name = "txtbdpnacionality"
        Me.txtbdpnacionality.Size = New System.Drawing.Size(225, 20)
        Me.txtbdpnacionality.TabIndex = 5
        '
        'txtbdplocality
        '
        Me.txtbdplocality.Location = New System.Drawing.Point(316, 195)
        Me.txtbdplocality.Name = "txtbdplocality"
        Me.txtbdplocality.Size = New System.Drawing.Size(208, 20)
        Me.txtbdplocality.TabIndex = 4
        '
        'txtdpbdir
        '
        Me.txtdpbdir.Location = New System.Drawing.Point(33, 159)
        Me.txtdpbdir.Name = "txtdpbdir"
        Me.txtdpbdir.Size = New System.Drawing.Size(225, 20)
        Me.txtdpbdir.TabIndex = 3
        '
        'txtbdpbirthd
        '
        Me.txtbdpbirthd.Location = New System.Drawing.Point(33, 123)
        Me.txtbdpbirthd.Name = "txtbdpbirthd"
        Me.txtbdpbirthd.Size = New System.Drawing.Size(225, 20)
        Me.txtbdpbirthd.TabIndex = 2
        '
        'txtbdpsurname
        '
        Me.txtbdpsurname.Location = New System.Drawing.Point(33, 87)
        Me.txtbdpsurname.Name = "txtbdpsurname"
        Me.txtbdpsurname.Size = New System.Drawing.Size(225, 20)
        Me.txtbdpsurname.TabIndex = 1
        '
        'txtbdpname
        '
        Me.txtbdpname.Location = New System.Drawing.Point(33, 51)
        Me.txtbdpname.Name = "txtbdpname"
        Me.txtbdpname.Size = New System.Drawing.Size(225, 20)
        Me.txtbdpname.TabIndex = 0
        '
        'tabfa
        '
        Me.tabfa.BackColor = System.Drawing.Color.White
        Me.tabfa.Controls.Add(Me.btnfadelete)
        Me.tabfa.Controls.Add(Me.btnfasave)
        Me.tabfa.Controls.Add(Me.txtfadesc)
        Me.tabfa.Controls.Add(Me.dgvfa)
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
        Me.btnfadelete.Text = "Borrar"
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
        Me.txtfadesc.Location = New System.Drawing.Point(22, 83)
        Me.txtfadesc.Name = "txtfadesc"
        Me.txtfadesc.Size = New System.Drawing.Size(507, 20)
        Me.txtfadesc.TabIndex = 24
        '
        'dgvfa
        '
        Me.dgvfa.BackgroundColor = System.Drawing.Color.White
        Me.dgvfa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvfa.Location = New System.Drawing.Point(22, 119)
        Me.dgvfa.Name = "dgvfa"
        Me.dgvfa.Size = New System.Drawing.Size(508, 150)
        Me.dgvfa.TabIndex = 23
        '
        'txtfayearend
        '
        Me.txtfayearend.Location = New System.Drawing.Point(305, 50)
        Me.txtfayearend.Name = "txtfayearend"
        Me.txtfayearend.Size = New System.Drawing.Size(225, 20)
        Me.txtfayearend.TabIndex = 22
        '
        'txtfayearstart
        '
        Me.txtfayearstart.Location = New System.Drawing.Point(22, 50)
        Me.txtfayearstart.Name = "txtfayearstart"
        Me.txtfayearstart.Size = New System.Drawing.Size(225, 20)
        Me.txtfayearstart.TabIndex = 21
        '
        'txtfaplace
        '
        Me.txtfaplace.Location = New System.Drawing.Point(305, 15)
        Me.txtfaplace.Name = "txtfaplace"
        Me.txtfaplace.Size = New System.Drawing.Size(225, 20)
        Me.txtfaplace.TabIndex = 20
        '
        'txtfaname
        '
        Me.txtfaname.Location = New System.Drawing.Point(22, 15)
        Me.txtfaname.Name = "txtfaname"
        Me.txtfaname.Size = New System.Drawing.Size(225, 20)
        Me.txtfaname.TabIndex = 19
        '
        'tabexp
        '
        Me.tabexp.BackColor = System.Drawing.Color.White
        Me.tabexp.Controls.Add(Me.btnexpdelete)
        Me.tabexp.Controls.Add(Me.btnexpsave)
        Me.tabexp.Controls.Add(Me.txtexpdesc)
        Me.tabexp.Controls.Add(Me.dgvexp)
        Me.tabexp.Controls.Add(Me.txtexpyeare)
        Me.tabexp.Controls.Add(Me.txtexpyeari)
        Me.tabexp.Controls.Add(Me.txtexpcompany)
        Me.tabexp.Location = New System.Drawing.Point(4, 22)
        Me.tabexp.Name = "tabexp"
        Me.tabexp.Padding = New System.Windows.Forms.Padding(3)
        Me.tabexp.Size = New System.Drawing.Size(553, 313)
        Me.tabexp.TabIndex = 2
        Me.tabexp.Text = "Experiencia"
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
        Me.btnexpdelete.Text = "Borrar"
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
        Me.txtexpdesc.Location = New System.Drawing.Point(22, 83)
        Me.txtexpdesc.Name = "txtexpdesc"
        Me.txtexpdesc.Size = New System.Drawing.Size(507, 20)
        Me.txtexpdesc.TabIndex = 24
        '
        'dgvexp
        '
        Me.dgvexp.BackgroundColor = System.Drawing.Color.White
        Me.dgvexp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvexp.Location = New System.Drawing.Point(22, 119)
        Me.dgvexp.Name = "dgvexp"
        Me.dgvexp.Size = New System.Drawing.Size(508, 150)
        Me.dgvexp.TabIndex = 23
        '
        'txtexpyeare
        '
        Me.txtexpyeare.Location = New System.Drawing.Point(305, 50)
        Me.txtexpyeare.Name = "txtexpyeare"
        Me.txtexpyeare.Size = New System.Drawing.Size(225, 20)
        Me.txtexpyeare.TabIndex = 22
        '
        'txtexpyeari
        '
        Me.txtexpyeari.Location = New System.Drawing.Point(22, 50)
        Me.txtexpyeari.Name = "txtexpyeari"
        Me.txtexpyeari.Size = New System.Drawing.Size(225, 20)
        Me.txtexpyeari.TabIndex = 21
        '
        'txtexpcompany
        '
        Me.txtexpcompany.Location = New System.Drawing.Point(22, 15)
        Me.txtexpcompany.Name = "txtexpcompany"
        Me.txtexpcompany.Size = New System.Drawing.Size(225, 20)
        Me.txtexpcompany.TabIndex = 19
        '
        'tabext
        '
        Me.tabext.BackColor = System.Drawing.Color.White
        Me.tabext.Controls.Add(Me.btnextdelete)
        Me.tabext.Controls.Add(Me.btnextsave)
        Me.tabext.Controls.Add(Me.dgvextra)
        Me.tabext.Controls.Add(Me.txtbexttype)
        Me.tabext.Controls.Add(Me.txtbexttittle)
        Me.tabext.Location = New System.Drawing.Point(4, 22)
        Me.tabext.Name = "tabext"
        Me.tabext.Padding = New System.Windows.Forms.Padding(3)
        Me.tabext.Size = New System.Drawing.Size(553, 313)
        Me.tabext.TabIndex = 3
        Me.tabext.Text = "Extras"
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
        Me.btnextdelete.Text = "Borrar"
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
        'dgvextra
        '
        Me.dgvextra.BackgroundColor = System.Drawing.Color.White
        Me.dgvextra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvextra.Location = New System.Drawing.Point(22, 90)
        Me.dgvextra.Name = "dgvextra"
        Me.dgvextra.Size = New System.Drawing.Size(508, 150)
        Me.dgvextra.TabIndex = 23
        '
        'txtbexttype
        '
        Me.txtbexttype.Location = New System.Drawing.Point(305, 37)
        Me.txtbexttype.Name = "txtbexttype"
        Me.txtbexttype.Size = New System.Drawing.Size(225, 20)
        Me.txtbexttype.TabIndex = 20
        '
        'txtbexttittle
        '
        Me.txtbexttittle.Location = New System.Drawing.Point(22, 37)
        Me.txtbexttittle.Name = "txtbexttittle"
        Me.txtbexttittle.Size = New System.Drawing.Size(225, 20)
        Me.txtbexttittle.TabIndex = 19
        '
        'tabprofile
        '
        Me.tabprofile.BackColor = System.Drawing.Color.White
        Me.tabprofile.Controls.Add(Me.btnprdeluser)
        Me.tabprofile.Controls.Add(Me.btnprdelcv)
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
        Me.btnprdeluser.Location = New System.Drawing.Point(216, 264)
        Me.btnprdeluser.Name = "btnprdeluser"
        Me.btnprdeluser.Size = New System.Drawing.Size(126, 23)
        Me.btnprdeluser.TabIndex = 31
        Me.btnprdeluser.Text = "Borrar Usuario"
        Me.btnprdeluser.UseVisualStyleBackColor = False
        '
        'btnprdelcv
        '
        Me.btnprdelcv.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btnprdelcv.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btnprdelcv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnprdelcv.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnprdelcv.ForeColor = System.Drawing.Color.White
        Me.btnprdelcv.Location = New System.Drawing.Point(216, 224)
        Me.btnprdelcv.Name = "btnprdelcv"
        Me.btnprdelcv.Size = New System.Drawing.Size(126, 23)
        Me.btnprdelcv.TabIndex = 30
        Me.btnprdelcv.Text = "Borrar"
        Me.btnprdelcv.UseVisualStyleBackColor = False
        '
        'btnprgencv
        '
        Me.btnprgencv.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btnprgencv.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btnprgencv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnprgencv.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnprgencv.ForeColor = System.Drawing.Color.White
        Me.btnprgencv.Location = New System.Drawing.Point(216, 179)
        Me.btnprgencv.Name = "btnprgencv"
        Me.btnprgencv.Size = New System.Drawing.Size(126, 23)
        Me.btnprgencv.TabIndex = 29
        Me.btnprgencv.Text = "Generar Curriculum"
        Me.btnprgencv.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(564, -2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(20, 20)
        Me.btnClose.TabIndex = 8
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'pbphoto
        '
        Me.pbphoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbphoto.Location = New System.Drawing.Point(363, 15)
        Me.pbphoto.Name = "pbphoto"
        Me.pbphoto.Size = New System.Drawing.Size(126, 132)
        Me.pbphoto.TabIndex = 9
        Me.pbphoto.TabStop = False
        '
        'UserPhoto
        '
        Me.UserPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UserPhoto.Location = New System.Drawing.Point(216, 20)
        Me.UserPhoto.Name = "UserPhoto"
        Me.UserPhoto.Size = New System.Drawing.Size(126, 132)
        Me.UserPhoto.TabIndex = 10
        Me.UserPhoto.TabStop = False
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
        Me.tabfa.ResumeLayout(False)
        Me.tabfa.PerformLayout()
        CType(Me.dgvfa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabexp.ResumeLayout(False)
        Me.tabexp.PerformLayout()
        CType(Me.dgvexp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabext.ResumeLayout(False)
        Me.tabext.PerformLayout()
        CType(Me.dgvextra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabprofile.ResumeLayout(False)
        CType(Me.pbphoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserPhoto, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtbdpbirthd As TextBox
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
    Friend WithEvents dgvfa As DataGridView
    Friend WithEvents txtfayearend As TextBox
    Friend WithEvents txtfayearstart As TextBox
    Friend WithEvents txtfaplace As TextBox
    Friend WithEvents txtfaname As TextBox
    Friend WithEvents btnexpdelete As Button
    Friend WithEvents btnexpsave As Button
    Friend WithEvents dgvexp As DataGridView
    Friend WithEvents txtexpcompany As TextBox
    Friend WithEvents btnextdelete As Button
    Friend WithEvents btnextsave As Button
    Friend WithEvents dgvextra As DataGridView
    Friend WithEvents txtbexttype As TextBox
    Friend WithEvents txtbexttittle As TextBox
    Friend WithEvents txtexpdesc As TextBox
    Friend WithEvents txtexpyeare As TextBox
    Friend WithEvents txtexpyeari As TextBox
    Friend WithEvents UserPhoto As PictureBox
    Friend WithEvents btnprgencv As Button
    Friend WithEvents btnprdeluser As Button
    Friend WithEvents btnprdelcv As Button
End Class
