Public Class Form1

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

End Class
