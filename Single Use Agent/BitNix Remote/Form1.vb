Public Class BitRemote
    Protected Overrides Sub OnFormClosing(e As FormClosingEventArgs)
        If e.CloseReason = CloseReason.UserClosing Then
            Try
                For Each prog As Process In Process.GetProcesses
                    If prog.ProcessName = "BREMOTE" Then
                        prog.Kill()
                    End If
                Next
            Catch ex As Exception

            End Try

            End
            e.Cancel = True
        End If
        MyBase.OnFormClosing(e)
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button3.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            For Each prog As Process In Process.GetProcesses
                If prog.ProcessName = "BREMOTE" Then
                    prog.Kill()
                End If
            Next
        Catch ex As Exception

        End Try

        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            For Each prog As Process In Process.GetProcesses
                If prog.ProcessName = "BREMOTE" Then
                    prog.Kill()
                End If
            Next
        Catch ex As Exception
        End Try
        Dim TempFolder As String = My.Computer.FileSystem.CombinePath(My.Computer.FileSystem.SpecialDirectories.Temp, "BREMOTE")
        Dim URL_R As String
        If System.Environment.Is64BitOperatingSystem = True Then
            URL_R = "https://bitnix.co/remote/meshagent64-BitNix.exe"
        Else
            URL_R = "https://bitnix.co/remote/meshagent32-BitNix.exe"
        End If
        Try

            My.Computer.Network.DownloadFile(URL_R, My.Computer.FileSystem.CombinePath(My.Computer.FileSystem.SpecialDirectories.Temp, "BREMOTE.exe"), "", "", True, 500, True)
            Dim startInfo As New ProcessStartInfo
            startInfo.FileName = My.Computer.FileSystem.CombinePath(My.Computer.FileSystem.SpecialDirectories.Temp, "BREMOTE.exe")
            startInfo.Arguments = "connect"
            startInfo.WindowStyle = ProcessWindowStyle.Hidden
            Process.Start(startInfo)
            ShowInTaskbar = True
            Button2.Visible = False
            Button1.Visible = False
            Label1.Text = "Waiting for Agent please wait" & Environment.NewLine & "Your workstation name: " + System.Windows.Forms.SystemInformation.ComputerName & Environment.NewLine & Environment.NewLine & "Close this window to close the remote session."
            Label1.AutoSize = False
            Label1.TextAlign = ContentAlignment.TopLeft
            Button3.Visible = True
        Catch ex As Exception
            MessageBox.Show("Please check your internet connection.")
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Elevate.Show()
    End Sub
End Class
