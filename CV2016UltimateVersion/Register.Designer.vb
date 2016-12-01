<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbxUser = New System.Windows.Forms.TextBox()
        Me.tbxPW = New System.Windows.Forms.TextBox()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.tbxConfirmPW = New System.Windows.Forms.TextBox()
        Me.epUser = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.epPW = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.epConfirmPW = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.tbxEmail = New System.Windows.Forms.TextBox()
        Me.epEmail = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnClose = New System.Windows.Forms.Button()
        CType(Me.epUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.epPW, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.epConfirmPW, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.epEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(180, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Curriculum"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Label2.Location = New System.Drawing.Point(204, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 26)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Registro"
        '
        'tbxUser
        '
        Me.tbxUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.tbxUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.tbxUser.Location = New System.Drawing.Point(30, 136)
        Me.tbxUser.MaxLength = 9
        Me.tbxUser.Name = "tbxUser"
        Me.tbxUser.Size = New System.Drawing.Size(437, 38)
        Me.tbxUser.TabIndex = 1
        Me.tbxUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbxPW
        '
        Me.tbxPW.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.tbxPW.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.tbxPW.Location = New System.Drawing.Point(29, 239)
        Me.tbxPW.MaxLength = 16
        Me.tbxPW.Name = "tbxPW"
        Me.tbxPW.Size = New System.Drawing.Size(437, 38)
        Me.tbxPW.TabIndex = 3
        Me.tbxPW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btnRegister.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.ForeColor = System.Drawing.Color.White
        Me.btnRegister.Location = New System.Drawing.Point(29, 341)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(437, 40)
        Me.btnRegister.TabIndex = 0
        Me.btnRegister.Text = "Registrarse"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(26, 456)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Ya tienes cuenta?"
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.lblLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblLogin.Location = New System.Drawing.Point(372, 456)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(100, 16)
        Me.lblLogin.TabIndex = 6
        Me.lblLogin.Text = "Iniciar sesión"
        '
        'tbxConfirmPW
        '
        Me.tbxConfirmPW.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.tbxConfirmPW.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.tbxConfirmPW.Location = New System.Drawing.Point(29, 283)
        Me.tbxConfirmPW.MaxLength = 16
        Me.tbxConfirmPW.Name = "tbxConfirmPW"
        Me.tbxConfirmPW.Size = New System.Drawing.Size(437, 38)
        Me.tbxConfirmPW.TabIndex = 4
        Me.tbxConfirmPW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'epUser
        '
        Me.epUser.ContainerControl = Me
        '
        'epPW
        '
        Me.epPW.ContainerControl = Me
        '
        'epConfirmPW
        '
        Me.epConfirmPW.ContainerControl = Me
        '
        'tbxEmail
        '
        Me.tbxEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.tbxEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.tbxEmail.Location = New System.Drawing.Point(29, 180)
        Me.tbxEmail.MaxLength = 50
        Me.tbxEmail.Name = "tbxEmail"
        Me.tbxEmail.Size = New System.Drawing.Size(437, 38)
        Me.tbxEmail.TabIndex = 2
        Me.tbxEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'epEmail
        '
        Me.epEmail.ContainerControl = Me
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(470, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(30, 30)
        Me.btnClose.TabIndex = 9
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CV2016UltimateVersion.My.Resources.Resources.registro
        Me.ClientSize = New System.Drawing.Size(500, 500)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.tbxEmail)
        Me.Controls.Add(Me.tbxConfirmPW)
        Me.Controls.Add(Me.lblLogin)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.tbxPW)
        Me.Controls.Add(Me.tbxUser)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Register"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register"
        CType(Me.epUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.epPW, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.epConfirmPW, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.epEmail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbxUser As TextBox
    Friend WithEvents tbxPW As TextBox
    Friend WithEvents btnRegister As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lblLogin As Label
    Friend WithEvents tbxConfirmPW As TextBox
    Friend WithEvents epUser As ErrorProvider
    Friend WithEvents epPW As ErrorProvider
    Friend WithEvents epConfirmPW As ErrorProvider
    Friend WithEvents tbxEmail As TextBox
    Friend WithEvents epEmail As ErrorProvider
    Friend WithEvents btnClose As Button
End Class
