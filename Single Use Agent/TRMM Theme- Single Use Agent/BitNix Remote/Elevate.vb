
Imports System.Diagnostics
Imports System.Security
Imports System.IO
Public Class Elevate


    Private Sub Elevate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim securePassword As New Security.SecureString()

        For Each c As Char In TextBox3.Text

            securePassword.AppendChar(c)
        Next c
        Dim proc As ProcessStartInfo = New ProcessStartInfo()
        proc.FileName = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName
        proc.UseShellExecute = False
        proc.Domain = TextBox1.Text
        proc.UserName = TextBox2.Text
        proc.Password = securePassword
        Try
            Process.Start(proc)
        Catch ex As Exception
            MessageBox.Show("Invalid username or password.")
        End Try
    End Sub
End Class