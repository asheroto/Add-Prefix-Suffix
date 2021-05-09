Imports System.Net
Imports Newtonsoft.Json

Public Class MainWindow

    Private Sub Button_Go_Click(sender As Object, e As EventArgs) Handles Button_Go.Click
        If Textbox_Text.Text = "" Then Exit Sub

        Dim result_count As Integer
        Dim result As String = Nothing
        For Each line In Textbox_Text.Lines
            result += TextBox_Prefix.Text & line & TextBox_Suffix.Text & vbCrLf
            result_count += 1
        Next

        Clipboard.SetText(result)

        Label_Done.Visible = True
        Label_Done.Left = Button_Go.Left
        Label_Done.Top = Button_Go.Top
        Label_Done.Size = Button_Go.Size
        Timer_RemoveDone.Enabled = True
    End Sub

    Private Sub Timer_RemoveDone_Tick(sender As Object, e As EventArgs) Handles Timer_RemoveDone.Tick
        Timer_RemoveDone.Enabled = False
        Label_Done.Visible = False
    End Sub

    Private Sub Button_ClearText_Click(sender As Object, e As EventArgs) Handles Button_ClearText.Click
        Textbox_Text.Text = Nothing
        Textbox_Text.Focus()
    End Sub

    Private Sub TextBox_Prefix_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox_Prefix.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button_Go.PerformClick()
        End If
    End Sub

    Private Sub TextBox_Suffix_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox_Suffix.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button_Go.PerformClick()
        End If
    End Sub

    Private Sub Button_ClearPrefix_Click(sender As Object, e As EventArgs) Handles Button_ClearPrefix.Click
        TextBox_Prefix.Clear()
        TextBox_Prefix.Focus()
    End Sub

    Private Sub Button_ClearSuffix_Click(sender As Object, e As EventArgs) Handles Button_ClearSuffix.Click
        TextBox_Suffix.Clear()
        TextBox_Suffix.Focus()
    End Sub

    Private Sub Timer_AppUpdate_Tick(sender As Object, e As EventArgs) Handles Timer_AppUpdate.Tick
        Timer_AppUpdate.Enabled = False

        If BackgroundWorker_AppUpdate.IsBusy = False Then BackgroundWorker_AppUpdate.RunWorkerAsync()
    End Sub

    Private Sub BackgroundWorker_AppUpdate_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker_AppUpdate.DoWork
        Try
            Dim hasConnection As Boolean = My.Computer.Network.Ping("api.asher.tools")
            If hasConnection = False Then Throw New Exception("Cannot ping asher.tools")

            Dim api_data = New WebClient().DownloadString("https://api.asher.tools/software/add-prefix-suffix")
            Dim api_ashertools As API = JsonConvert.DeserializeObject(Of API)(api_data)

            Dim latest_version = New Version(api_ashertools.version_number)
            Dim my_version = New Version(Mid(My.Application.Info.Version.ToString, 1, Len(My.Application.Info.Version.ToString) - 2))
            Dim result = latest_version.CompareTo(my_version)

            If result > 0 Then
                'Newer version available
                Me.Invoke(Sub()
                              Dim ask =
                                            MsgBox("Newer version available, click OK to Download.", vbInformation + vbOKCancel)

                              If ask = vbOK Then
                                  Dim x As New Process
                                  x.StartInfo.UseShellExecute = True
                                  x.StartInfo.FileName = api_ashertools.download_url
                                  x.StartInfo.WindowStyle = ProcessWindowStyle.Normal
                                  x.Start()
                              End If
                          End Sub)
            Else
                'No newer version available
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class

Public Class API
    Private m_version_number As String

    Public Property version_number As String
        Get
            Return m_version_number
        End Get
        Set(value As String)
            m_version_number = value
        End Set
    End Property

    Private m_download_url As String

    Public Property download_url As String
        Get
            Return m_download_url
        End Get
        Set(value As String)
            m_download_url = value
        End Set
    End Property
End Class
