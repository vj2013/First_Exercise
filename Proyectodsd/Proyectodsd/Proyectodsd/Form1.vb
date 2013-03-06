Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblfecha.Text = DateAndTime.Today
        lblhora.Text = DateAndTime.Hour(Date.Now)
    End Sub
End Class
