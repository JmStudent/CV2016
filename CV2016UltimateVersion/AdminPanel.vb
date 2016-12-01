Imports MySql.Data.MySqlClient

Partial Class AdminPanel
    Dim ad As New DataAccess

    Private Sub AdminPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click 'borradosde usuarios'
        Dim checkedItems As ListView.CheckedListViewItemCollection = lvNoActive.CheckedItems
        Dim checkedItems2 As ListView.CheckedListViewItemCollection = lvActive.CheckedItems
        Dim dni As String

        Dim query As String
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
    End Sub

    'Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click 'salir del usuario'
    '    Dim res As Integer

    '    res = MessageBox.Show("¿Estás seguro de que deseas salir?", "Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Error)
    '    If res = 6 Then
    '        Application.Exit()
    '    End If
    'End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim res As Integer

        res = MessageBox.Show("¿Está seguro que desea salir?", "Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If res = 6 Then
            Application.Exit()
        End If
    End Sub
End Class