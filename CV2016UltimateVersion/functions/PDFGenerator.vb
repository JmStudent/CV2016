Imports iTextSharp
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
' Sólo es necesario instanciar esto donde querais hacer uso de la función:
' Dim g As New PDFGenerator("dni correspondiente")
' g.generate()
Public Class PDFGenerator
    Private dni As String
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
                Dim DOCUMENTO As New Document
                Dim ESCRITOR As PdfWriter = PdfWriter.GetInstance(DOCUMENTO, New FileStream(saveFileDialog1.FileName, FileMode.Create))
                DOCUMENTO.Open()
                Dim lab As New Label
                Dim lab2 As New Paragraph("Hola Mundo")
                lab2.Font.Size = 40
                lab2.Font.Color = BaseColor.ORANGE
                DOCUMENTO.Add(lab2)
                DOCUMENTO.Close()
                MsgBox("CREADO ARCHIVO PDF")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Private Function newP(text As String, sizeF As Integer, colour As BaseColor)
        Dim p As New Paragraph(text)
        p.Font.Size = sizeF
        p.Font.Color = colour
        Return p
    End Function
End Class
