<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminPanel
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
        Me.lvNoActive = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnActivate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lbNoactive = New System.Windows.Forms.Label()
        Me.btnGenerateCV = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lvActive = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tbsearch = New System.Windows.Forms.TextBox()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lvNoActive
        '
        Me.lvNoActive.BackColor = System.Drawing.Color.White
        Me.lvNoActive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvNoActive.CheckBoxes = True
        Me.lvNoActive.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lvNoActive.GridLines = True
        Me.lvNoActive.Location = New System.Drawing.Point(30, 125)
        Me.lvNoActive.Name = "lvNoActive"
        Me.lvNoActive.Scrollable = False
        Me.lvNoActive.Size = New System.Drawing.Size(280, 127)
        Me.lvNoActive.TabIndex = 0
        Me.lvNoActive.UseCompatibleStateImageBehavior = False
        Me.lvNoActive.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "DNI"
        Me.ColumnHeader1.Width = 90
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Email"
        Me.ColumnHeader2.Width = 190
        '
        'btnActivate
        '
        Me.btnActivate.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btnActivate.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnActivate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActivate.ForeColor = System.Drawing.Color.Snow
        Me.btnActivate.Location = New System.Drawing.Point(118, 298)
        Me.btnActivate.Name = "btnActivate"
        Me.btnActivate.Size = New System.Drawing.Size(97, 25)
        Me.btnActivate.TabIndex = 2
        Me.btnActivate.Text = "Activar"
        Me.btnActivate.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btnDelete.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDelete.Location = New System.Drawing.Point(320, 298)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(97, 25)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "Borrar"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'lbNoactive
        '
        Me.lbNoactive.AutoSize = True
        Me.lbNoactive.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNoactive.Location = New System.Drawing.Point(78, 92)
        Me.lbNoactive.Name = "lbNoactive"
        Me.lbNoactive.Size = New System.Drawing.Size(149, 20)
        Me.lbNoactive.TabIndex = 4
        Me.lbNoactive.Text = "Usuarios no Activos"
        '
        'btnGenerateCV
        '
        Me.btnGenerateCV.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btnGenerateCV.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnGenerateCV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerateCV.ForeColor = System.Drawing.Color.Snow
        Me.btnGenerateCV.Location = New System.Drawing.Point(522, 298)
        Me.btnGenerateCV.Name = "btnGenerateCV"
        Me.btnGenerateCV.Size = New System.Drawing.Size(97, 25)
        Me.btnGenerateCV.TabIndex = 7
        Me.btnGenerateCV.Text = "Generar CV"
        Me.btnGenerateCV.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(481, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Usuarios  Activos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(256, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(214, 24)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Panel de Administración"
        '
        'lvActive
        '
        Me.lvActive.BackColor = System.Drawing.Color.White
        Me.lvActive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvActive.CheckBoxes = True
        Me.lvActive.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader7})
        Me.lvActive.GridLines = True
        Me.lvActive.Location = New System.Drawing.Point(425, 125)
        Me.lvActive.Name = "lvActive"
        Me.lvActive.Scrollable = False
        Me.lvActive.Size = New System.Drawing.Size(280, 127)
        Me.lvActive.TabIndex = 12
        Me.lvActive.UseCompatibleStateImageBehavior = False
        Me.lvActive.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "DNI"
        Me.ColumnHeader3.Width = 90
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Email"
        Me.ColumnHeader7.Width = 190
        '
        'tbsearch
        '
        Me.tbsearch.Location = New System.Drawing.Point(294, 349)
        Me.tbsearch.Multiline = True
        Me.tbsearch.Name = "tbsearch"
        Me.tbsearch.Size = New System.Drawing.Size(109, 31)
        Me.tbsearch.TabIndex = 13
        '
        'btnsearch
        '
        Me.btnsearch.BackgroundImage = Global.CV2016UltimateVersion.My.Resources.Resources.search1
        Me.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btnsearch.Location = New System.Drawing.Point(409, 349)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(41, 31)
        Me.btnsearch.TabIndex = 14
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(717, -1)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(20, 30)
        Me.btnClose.TabIndex = 15
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'AdminPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImage = Global.CV2016UltimateVersion.My.Resources.Resources.admin2
        Me.ClientSize = New System.Drawing.Size(737, 412)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.tbsearch)
        Me.Controls.Add(Me.lvActive)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnGenerateCV)
        Me.Controls.Add(Me.lbNoactive)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnActivate)
        Me.Controls.Add(Me.lvNoActive)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdminPanel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Panel de Administración"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lvNoActive As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents btnActivate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents lbNoactive As Label
    Friend WithEvents btnGenerateCV As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lvActive As ListView
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents tbsearch As TextBox
    Friend WithEvents btnsearch As Button
    Friend WithEvents btnClose As Button
End Class
