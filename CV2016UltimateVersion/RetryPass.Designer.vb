<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RetryPass
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnRetry = New System.Windows.Forms.Button()
        Me.tbxNewPass2 = New System.Windows.Forms.TextBox()
        Me.tbxNewPass = New System.Windows.Forms.TextBox()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(264, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 46)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Curriculum"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Label2.Location = New System.Drawing.Point(286, 149)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 37)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Recuperar"
        '
        'btnRetry
        '
        Me.btnRetry.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btnRetry.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btnRetry.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRetry.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRetry.ForeColor = System.Drawing.Color.White
        Me.btnRetry.Location = New System.Drawing.Point(51, 520)
        Me.btnRetry.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnRetry.Name = "btnRetry"
        Me.btnRetry.Size = New System.Drawing.Size(651, 62)
        Me.btnRetry.TabIndex = 4
        Me.btnRetry.Text = "Recuperar"
        Me.btnRetry.UseVisualStyleBackColor = False
        '
        'tbxNewPass2
        '
        Me.tbxNewPass2.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.tbxNewPass2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.tbxNewPass2.Location = New System.Drawing.Point(48, 377)
        Me.tbxNewPass2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbxNewPass2.MaxLength = 16
        Me.tbxNewPass2.Name = "tbxNewPass2"
        Me.tbxNewPass2.Size = New System.Drawing.Size(654, 53)
        Me.tbxNewPass2.TabIndex = 6
        Me.tbxNewPass2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbxNewPass
        '
        Me.tbxNewPass.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.tbxNewPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.tbxNewPass.Location = New System.Drawing.Point(48, 243)
        Me.tbxNewPass.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbxNewPass.MaxLength = 9
        Me.tbxNewPass.Name = "tbxNewPass"
        Me.tbxNewPass.Size = New System.Drawing.Size(654, 53)
        Me.tbxNewPass.TabIndex = 5
        Me.tbxNewPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.lblLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblLogin.Location = New System.Drawing.Point(520, 708)
        Me.lblLogin.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(139, 25)
        Me.lblLogin.TabIndex = 8
        Me.lblLogin.Text = "Iniciar sesión"
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.lblInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblInfo.Location = New System.Drawing.Point(44, 706)
        Me.lblInfo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(185, 25)
        Me.lblInfo.TabIndex = 7
        Me.lblInfo.Text = "Ya tienes cuenta?"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(705, 0)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(45, 46)
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'RetryPass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CV2016UltimateVersion.My.Resources.Resources.login
        Me.ClientSize = New System.Drawing.Size(750, 769)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblLogin)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.btnRetry)
        Me.Controls.Add(Me.tbxNewPass2)
        Me.Controls.Add(Me.tbxNewPass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "RetryPass"
        Me.Text = "RetryPass"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnRetry As Button
    Friend WithEvents tbxNewPass2 As TextBox
    Friend WithEvents tbxNewPass As TextBox
    Friend WithEvents lblLogin As Label
    Friend WithEvents lblInfo As Label
    Friend WithEvents btnClose As Button
End Class
