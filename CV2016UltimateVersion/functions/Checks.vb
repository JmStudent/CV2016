Imports System.Text.RegularExpressions

Module Checks
    ' ------------------------------------------------------------------------------------------------------
    ' FUNCTIONS TO CHECK NIF -------------------------------------------------------------------------------
    Public Function checkNIF(ByVal nif As String)
        Dim letra = nif.Substring(nif.Length - 1).ToUpper
        Dim numeros = nif.Substring(0, (nif.Length - 1))
        Try
            If IsNumeric(numeros) Then
                Return If(("TRWAGMYFPDXBNJZSQVHLCKE".Substring(numeros Mod 23, 1) = letra And letra.Length = 1 And numeros.Length = 8), True, False)
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

    ' ------------------------------------------------------------------------------------------------------
    ' FUNCTION TO CHECK PW ---------------------------------------------------------------------------------
    Public Function checkPW(ByVal value As String)
        Dim regex As Regex = New Regex("^(?=\w*\d)(?=\w*[A-Z])(?=\w*[a-z])\S{8,16}$")
        Dim match As Match = regex.Match(value)
        Return match.Success
    End Function

    ' ------------------------------------------------------------------------------------------------------
    ' FUNCTION TO CHECK EMAIL ------------------------------------------------------------------------------
    Public Function isEmail(ByVal email As String) As Boolean
        Static emailExpression As New Regex("^(?(')('.+?(?<!\\)'@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$")
        Return emailExpression.IsMatch(email)
    End Function

    ' ------------------------------------------------------------------------------------------------------
    ' FUNCTIONS TO RECOVERY EMAIL --------------------------------------------------------------------------

    Public Function GMailSender(ByVal Username As String, ByVal Password As String, ByVal Subject As String, ByVal Body As String, ByVal DestinyAddress As String) As Boolean
        Try
            Dim MailSetup As New Net.Mail.MailMessage
            MailSetup.Subject = Subject
            MailSetup.To.Add(DestinyAddress)
            MailSetup.From = New Net.Mail.MailAddress(Username)
            MailSetup.Body = Body
            Dim SMTP As New Net.Mail.SmtpClient("smtp.gmail.com")
            SMTP.Port = 587
            SMTP.EnableSsl = True
            SMTP.Credentials = New Net.NetworkCredential(Username, Password)
            SMTP.Send(MailSetup)
            Return True
        Catch ex As Exception
            MessageBox.Show("No se ha podido enviar el email", "Aviso de envío", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    ' ------------------------------------------------------------------------------------------------------

End Module
