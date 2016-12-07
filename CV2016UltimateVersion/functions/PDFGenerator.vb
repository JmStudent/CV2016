Imports iTextSharp
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
' Sólo es necesario instanciar esto donde querais hacer uso de la función:
' Dim g As New PDFGenerator("dni correspondiente")
' g.generate()
Public Class PDFGenerator
    Private dni As String
    Private da As New DataAccess
    Sub New(ByVal dniPassed As String)
        dni = dniPassed
    End Sub
    Public Sub generate()
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.DefaultExt = "pdf"
        If saveFileDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Try
                Dim doc As New Document
                Dim ESCRITOR As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(saveFileDialog1.FileName, FileMode.Create))
                Dim fontSizeBase As Integer = 10
                Dim fontSizeTitle As Integer = 20
                doc.Open()
                ' CURRÍCULUM VITAE
                doc.Add(newP("Currículum Vitae", 40, BaseColor.BLACK, True, False, True))
                ' DATOS DE PERFIL
                Dim perfil As ArrayList = extractData("perfil")
                If perfil.Count > 0 Then
                    For Each item In perfil
                        doc.Add(newP(item(1) + " " + item(2), 30, BaseColor.DARK_GRAY, True, True, False))
                        doc.Add(newP(" ", 5, BaseColor.WHITE, False, False, False))
                        doc.Add(newP("· Teléfono: " + item(6), fontSizeBase, BaseColor.BLACK, True, False, False))
                        doc.Add(newP("· Email: " + item(7), fontSizeBase, BaseColor.BLACK, True, False, False))
                        doc.Add(newP("· Nacionalidad: " + item(5), fontSizeBase, BaseColor.BLACK, True, False, False))
                        doc.Add(newP("· Fecha de Nacimiento: " + item(4), fontSizeBase, BaseColor.BLACK, True, False, False))
                        doc.Add(newP("· Dirección: " + item(3) + ", " + item(9), fontSizeBase, BaseColor.BLACK, True, False, False))
                    Next
                End If
                ' DATOS DE FORMACIÓN
                Dim formacion As ArrayList = extractData("formacion")
                If formacion.Count > 0 Then
                    doc.Add(newP("FORMACIÓN", fontSizeTitle, BaseColor.GRAY, True, True, False))
                    For Each item In formacion
                        Dim i As Integer = 0
                        doc.Add(newP(item(i + 2) + " - " + item(i + 3) + " " + item(i + 4) + ", " + item(i + 5), fontSizeBase, BaseColor.BLACK, True, False, False))
                        doc.Add(newP("            " + item(i + 6), fontSizeBase, BaseColor.BLACK, True, False, False))
                    Next
                End If
                ' DATOS DE FORMACIÓN 2
                Dim formacion2 As ArrayList = extractData("formacion2")
                If formacion2.Count > 0 Then
                    doc.Add(newP("FORMACIÓN COMPLEMENTARIA", fontSizeTitle, BaseColor.GRAY, True, True, False))
                    For Each item In formacion2
                        Dim i As Integer = 0
                        doc.Add(newP(item(i + 2) + " - " + item(i + 3), fontSizeBase, BaseColor.BLACK, True, False, False))
                    Next
                End If
                ' EXPERIENCIA LABORAL
                Dim experiencia As ArrayList = extractData("experiencia")
                If experiencia.Count > 0 Then
                    doc.Add(newP("EXPERIENCIA LABORAL", fontSizeTitle, BaseColor.GRAY, True, True, False))
                    For Each item In experiencia
                        Dim i As Integer = 0
                        Dim year As String = If(item(i + 2) > 1, "años", "año")
                        doc.Add(newP("Durante " + item(i + 2) + " " + year + " en " + item(i + 3), fontSizeBase, BaseColor.BLACK, True, False, False))
                        doc.Add(newP("            " + item(i + 4), fontSizeBase, BaseColor.BLACK, True, False, False))
                    Next
                End If
                ' IMAGEN
                Try
                    Dim img As itextsharp.text.Image = itextsharp.text.Image.GetInstance(perfil.Item(0)(8))
                    img.ScalePercent(50)
                    img.SetAbsolutePosition(365, 630)
                    doc.Add(img)
                Catch imgE As Exception
                    MessageBox.Show("No se pudo insertar la foto, ruta incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
                doc.Close()
                MessageBox.Show("CV generado en PDF con éxito", "CV Generado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
    Private Function newP(text As String, sizeF As Integer, colour As BaseColor, bold As Boolean, italic As Boolean, under As Boolean)
        Dim p As New Paragraph(text)
        If bold And italic Then
            p.Font.SetStyle(Font.BOLDITALIC)
        Else
            If bold Then
                p.Font.SetStyle(Font.BOLD)
            ElseIf italic Then
                p.Font.SetStyle(Font.ITALIC)
            End If
        End If
        If under Then
            p.Font.SetStyle(Font.UNDERLINE)
        End If
        p.Font.Size = sizeF
        p.Font.Color = colour
        Return p
    End Function
    Private Function extractData(table As String)
        Dim ds As New DataSet
        Dim list As New ArrayList
        ds = da.query("SELECT * FROM " & table & " WHERE dni='" & dni & "'")
        If ds.Tables(0).Rows.Count >= 1 Then
            For i = 0 To ds.Tables(0).Rows.Count - 1
                Dim results(ds.Tables(0).Columns.Count - 1) As String
                For j = 0 To results.Count - 1
                    Try
                        results(j) = CStr(ds.Tables(0).Rows(i).Item(j))
                    Catch ex As Exception
                        results(j) = ds.Tables(0).Rows(i).Item(j)
                    End Try
                Next
                list.Add(results)
            Next
            Return list
        End If
        Return list
    End Function
End Class
