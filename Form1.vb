Imports System.Net

Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim filename As String = Application.StartupPath
        If Not filename.EndsWith("\") Then filename &= "\"
        txtLocalFile.Text = filename & "howto_net_download_file.zip"
    End Sub

    Private Sub btnDownload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDownload.Click
        Me.Cursor = Cursors.WaitCursor
        Application.DoEvents()

        Try
            ' Make a WebClient.
            Dim web_client As WebClient = New WebClient

            ' Download the file.
            web_client.DownloadFile(txtRemoteFile.Text, txtLocalFile.Text)

            MessageBox.Show("Done")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Download Error", _
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        Me.Cursor = Cursors.Default
    End Sub
End Class
