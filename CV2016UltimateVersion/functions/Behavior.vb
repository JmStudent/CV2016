Public Class Behavior
    Sub changeColor(ByRef tb As TextBox, ByVal textDefault As String)
        Select Case tb.Text
            Case textDefault
                tb.ForeColor = Color.Black
                If (textDefault = "Password") Or (textDefault = "Confirma Password") Then
                    tb.Clear()
                    tb.UseSystemPasswordChar = True
                End If
                tb.Text = ""
            Case String.Empty
                tb.ForeColor = Color.Gray
                If (textDefault = "Password") Or (textDefault = "Confirma Password") Then
                    tb.UseSystemPasswordChar = False
                End If
                tb.Text = textDefault
        End Select
    End Sub
End Class
