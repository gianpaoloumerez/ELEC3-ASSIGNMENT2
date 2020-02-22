Public Class Form1
    Dim time As Byte = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (time = 0) Then
            Panel1.BackColor = Color.Red
            Panel2.BackColor = Color.Red
            Panel3.BackColor = Color.Red
            Panel4.BackColor = Color.Red
            Panel5.BackColor = Color.Red
        End If
    End Sub
End Class
