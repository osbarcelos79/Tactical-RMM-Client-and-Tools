Public Class BREMOTE
    Private Sub BREMOTE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = System.Windows.Forms.SystemInformation.ComputerName
    End Sub
End Class