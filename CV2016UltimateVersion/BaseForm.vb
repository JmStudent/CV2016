Public Class BaseForm
    Inherits System.Windows.Forms.Form
    Private isMouseDown As Boolean = False
    Private mouseOffset As Point
    ' FUNCTIONS FOR WINDOW MOVEMENT    ------------------------------------------------------------------------

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
End Class