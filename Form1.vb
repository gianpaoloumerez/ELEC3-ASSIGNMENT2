Public Class Form1
    Dim time As Byte = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (time = 0) Then
            Panel1.BackColor = Color.Red
            Panel2.BackColor = Color.Red
            Panel3.BackColor = Color.Red
            Panel4.BackColor = Color.Red
            Panel5.BackColor = Color.Red
            Panel6.BackColor = Color.Red
            Panel7.BackColor = Color.Silver
            Panel8.BackColor = Color.Silver
            Panel9.BackColor = Color.Silver
            Panel10.BackColor = Color.Red
            Panel11.BackColor = Color.Red
            Panel12.BackColor = Color.Silver
            Panel13.BackColor = Color.Silver
            Panel14.BackColor = Color.Silver
            Panel15.BackColor = Color.Red
            Panel16.BackColor = Color.Red
            Panel17.BackColor = Color.Silver
            Panel18.BackColor = Color.Silver
            Panel19.BackColor = Color.Silver
            Panel20.BackColor = Color.Red
            Panel21.BackColor = Color.Red
            Panel22.BackColor = Color.Red
            Panel23.BackColor = Color.Red
            Panel24.BackColor = Color.Red
            Panel25.BackColor = Color.Red
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class
