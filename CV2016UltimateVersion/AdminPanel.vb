Imports MySql.Data.MySqlClient

Public Class AdminPanel
    Dim ad As New DataAccess

    Private isMouseDown As Boolean = False
    Private mouseOffset As Point


    Private Sub AdminPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbsearch.Text = "Buscar por DNI"
        loadpeople(0, lvNoActive)
        loadpeople(2, lvActive)


    End Sub

    Public Sub loadpeople(tipo As Integer, lv As ListView) 'carga en los listview los usuarios, primer parametro tipo de user, segundo parametro; el listview donde se quiere cargar

        Dim query As String
        Dim slqadpter As New MySqlDataAdapter
        Dim sqlcommand As New MySqlCommand
        Dim TABLE As New DataTable
        Dim i As Integer

        lv.Items.Clear()


        query = "SELECT dni, email FROM perfil where dni IN (select dni from usuarios where tipo=" & tipo & ")"

        With sqlcommand
            .CommandText = query
            .Connection = ad.connect()
        End With

        With slqadpter
            .SelectCommand = sqlcommand
            .Fill(TABLE)
        End With

        For i = 0 To TABLE.Rows.Count - 1
            With lv
                .Items.Add(TABLE.Rows(i)("dni"))
                With .Items(.Items.Count - 1).SubItems
                    .Add(TABLE.Rows(i)("email"))
                End With
            End With
        Next

        For i = 0 To lv.Items.Count - 2 Step 2
            lv.Items(i + 1).BackColor = Color.LightGray
            lv.Items(i).BackColor = Color.LightCyan
        Next
    End Sub

    Private Sub btnActivate_Click(sender As Object, e As EventArgs) Handles btnActivate.Click 'Activación de usuarios'
        Dim checkedItems As ListView.CheckedListViewItemCollection =
        lvNoActive.CheckedItems
        Dim dni As String

        Dim query As String

        For Each item In checkedItems
            dni = item.SubItems(0).text
            query = " UPDATE usuarios set tipo=2 WHERE dni= '" & dni & "'"
            ad.cud(query)
        Next


        loadpeople(2, lvActive)
        loadpeople(0, lvNoActive)

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click 'borrados de usuarios'
        Dim checkedItems As ListView.CheckedListViewItemCollection = lvNoActive.CheckedItems
        Dim checkedItems2 As ListView.CheckedListViewItemCollection = lvActive.CheckedItems
        Dim dni As String
        Dim num1, num2 As Integer
        Dim query As String

        num1 = checkedItems.Count
        num2 = checkedItems2.Count

        If (num1 > 0 Or num2 > 0) Then
            Dim res = MsgBox("Estas seguro de borrar a al/los usuario/s?", MsgBoxStyle.YesNo)
            If res = 6 Then
                For Each item In checkedItems
                    dni = item.SubItems(0).text
                    query = " DELETE FROM  usuarios WHERE dni= '" & dni & "'"
                    ad.cud(query)
                Next

                For Each item In checkedItems2
                    dni = item.SubItems(0).text
                    query = " DELETE FROM  usuarios WHERE dni= '" & dni & "'"
                    ad.cud(query)
                Next

                loadpeople(2, lvActive)
                loadpeople(0, lvNoActive)
            End If


        End If
    End Sub



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


    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click 'buscar usuarios por dni'

        Dim query, query2 As String
        Dim slqadpter As New MySqlDataAdapter
        Dim sqlcommand, sqlcommand2 As New MySqlCommand
        Dim TABLE As New DataTable
        Dim i As Integer
        Dim lv As ListView


        Dim dni = tbsearch.Text
        If (Len(dni) = 9) Then
            query = "SELECT dni, email FROM perfil where dni = '" & dni & "'"
            query2 = "SELECT tipo FROM usuarios where dni = '" & dni & "'"


            With sqlcommand2
                .CommandText = query2
                .Connection = ad.connect()

            End With
            With slqadpter
                .SelectCommand = sqlcommand2
            End With
            Dim value As Object = sqlcommand2.ExecuteScalar()

            If (value = 2) Then
                lv = lvActive
            Else
                lv = lvNoActive
            End If


            With sqlcommand
                .CommandText = query
                .Connection = ad.connect()

            End With
            With slqadpter
                .SelectCommand = sqlcommand
                .Fill(TABLE)
            End With

            lvActive.Items.Clear()
            lvNoActive.Items.Clear()

            For i = 0 To TABLE.Rows.Count - 1
                With lv
                    .Items.Add(TABLE.Rows(i)("dni"))
                    With .Items(.Items.Count - 1).SubItems
                        .Add(TABLE.Rows(i)("email"))
                    End With
                End With
            Next

            For i = 0 To lv.Items.Count - 2 Step 2
                lv.Items(i + 1).BackColor = Color.LightGray
                lv.Items(i).BackColor = Color.LightCyan
            Next
        Else
            MessageBox.Show("DNI no correcto", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            loadpeople(2, lvActive)
            loadpeople(0, lvNoActive)
        End If

    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click 'cerrar ventana'
        Dim res As Integer
        res = MessageBox.Show("¿Está seguro que desea salir?", "Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If res = 6 Then
            Application.Exit()
        End If
    End Sub



    Private Sub tbsearch_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbsearch.GotFocus
        If tbsearch.Text = "Buscar por DNI" Then
            tbsearch.Text = ""
        End If
    End Sub
    Private Sub Ttbsearch_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbsearch.LostFocus
        If tbsearch.TextLength = Nothing Then
            tbsearch.Text = "Buscar por DNI"
        End If
    End Sub

    Private Sub btnGenerateCV_Click(sender As Object, e As EventArgs) Handles btnGenerateCV.Click 'generar pdf'
        Dim checkedItems As ListView.CheckedListViewItemCollection = lvNoActive.CheckedItems
        Dim checkedItems2 As ListView.CheckedListViewItemCollection = lvActive.CheckedItems
        Dim dni As String
        Dim num1, num2, num3 As Integer
        num1 = checkedItems.Count
        num2 = checkedItems2.Count
        num3 = num1 + num2


        If (num3 = 1) Then
            For Each item In checkedItems
                dni = item.SubItems(0).text
                Dim g As New PDFGenerator(dni)
                g.generate()

            Next
            For Each item In checkedItems2
                dni = item.SubItems(0).text
                Dim g As New PDFGenerator(dni)
                g.generate()
            Next
        Else
            MessageBox.Show("Solo se puede generar un CV a la vez", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If




    End Sub
End Class

