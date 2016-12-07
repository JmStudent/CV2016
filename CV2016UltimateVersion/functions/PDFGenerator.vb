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
        ' hacer la consulta a la base de datos aquí mismo y recuperar todos los datos que posteriormente
        ' usaré para crear el currículum
    End Sub
    Public Sub generate()
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.DefaultExt = "pdf"
        If saveFileDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Try
                Dim doc As New Document
                Dim ESCRITOR As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(saveFileDialog1.FileName, FileMode.Create))
                doc.Open()
                'Dim lab2 As New Paragraph("Hola Mundo")
                'lab2.Font.Size = 40
                'lab2.Font.Color = BaseColor.ORANGE
                ' CURRÍCULUM VITAE
                doc.Add(newP("Currículum Vitae", 40, BaseColor.BLACK, True, False))
                ' DATOS DE PERFIL
                Dim perfil As ArrayList = extractData("perfil", 10)
                If perfil.Count > 0 Then
                    'For Each item In perfil
                    '    doc.Add(newP())
                    'Next
                    'doc.Add(lab2)
                End If
                doc.Close()
                MsgBox("CREADO ARCHIVO PDF")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Private Function newP(text As String, sizeF As Integer, colour As BaseColor, bold As Boolean, italic As Boolean)
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
        p.Font.Size = sizeF
        p.Font.Color = colour
        Return p
    End Function
    Private Function extractData(table As String, col As Integer)
        Dim ds As New DataSet
        Dim list As New ArrayList
        ds = da.query("SELECT * FROM " & table & " WHERE dni='" & dni & "'")
        If ds.Tables(0).Rows.Count >= 1 Then
            For i = 0 To ds.Tables(0).Rows.Count - 1
                For j = 0 To col - 1
                    Try
                        list.Add(CStr(ds.Tables(0).Rows(0).Item(j)))
                    Catch ex As Exception
                        list.Add(ds.Tables(0).Rows(0).Item(j))
                    End Try
                Next
            Next
            Return list
        End If
        Return list
    End Function
End Class
