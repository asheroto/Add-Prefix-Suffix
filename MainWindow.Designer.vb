<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
        Me.Textbox_Text = New System.Windows.Forms.TextBox()
        Me.TextBox_Prefix = New System.Windows.Forms.TextBox()
        Me.Label_Prefix = New System.Windows.Forms.Label()
        Me.Label_Suffix = New System.Windows.Forms.Label()
        Me.TextBox_Suffix = New System.Windows.Forms.TextBox()
        Me.Button_Go = New System.Windows.Forms.Button()
        Me.Label_Text = New System.Windows.Forms.Label()
        Me.Timer_RemoveDone = New System.Windows.Forms.Timer(Me.components)
        Me.Button_ClearText = New System.Windows.Forms.Button()
        Me.Label_Done = New System.Windows.Forms.Label()
        Me.Button_ClearPrefix = New System.Windows.Forms.Button()
        Me.Button_ClearSuffix = New System.Windows.Forms.Button()
        Me.Timer_BringToFront = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_AppUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker_AppUpdate = New System.ComponentModel.BackgroundWorker()
        Me.SuspendLayout()
        '
        'Textbox_Text
        '
        Me.Textbox_Text.Location = New System.Drawing.Point(21, 115)
        Me.Textbox_Text.Multiline = True
        Me.Textbox_Text.Name = "Textbox_Text"
        Me.Textbox_Text.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.Textbox_Text.Size = New System.Drawing.Size(865, 515)
        Me.Textbox_Text.TabIndex = 3
        '
        'TextBox_Prefix
        '
        Me.TextBox_Prefix.Location = New System.Drawing.Point(143, 12)
        Me.TextBox_Prefix.Name = "TextBox_Prefix"
        Me.TextBox_Prefix.Size = New System.Drawing.Size(458, 29)
        Me.TextBox_Prefix.TabIndex = 1
        '
        'Label_Prefix
        '
        Me.Label_Prefix.AutoSize = True
        Me.Label_Prefix.Location = New System.Drawing.Point(17, 15)
        Me.Label_Prefix.Name = "Label_Prefix"
        Me.Label_Prefix.Size = New System.Drawing.Size(81, 21)
        Me.Label_Prefix.TabIndex = 2
        Me.Label_Prefix.Text = "Add Prefix"
        '
        'Label_Suffix
        '
        Me.Label_Suffix.AutoSize = True
        Me.Label_Suffix.Location = New System.Drawing.Point(17, 52)
        Me.Label_Suffix.Name = "Label_Suffix"
        Me.Label_Suffix.Size = New System.Drawing.Size(81, 21)
        Me.Label_Suffix.TabIndex = 4
        Me.Label_Suffix.Text = "Add Suffix"
        '
        'TextBox_Suffix
        '
        Me.TextBox_Suffix.Location = New System.Drawing.Point(143, 47)
        Me.TextBox_Suffix.Name = "TextBox_Suffix"
        Me.TextBox_Suffix.Size = New System.Drawing.Size(458, 29)
        Me.TextBox_Suffix.TabIndex = 2
        '
        'Button_Go
        '
        Me.Button_Go.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button_Go.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Go.Location = New System.Drawing.Point(711, 12)
        Me.Button_Go.Name = "Button_Go"
        Me.Button_Go.Size = New System.Drawing.Size(175, 64)
        Me.Button_Go.TabIndex = 4
        Me.Button_Go.Text = "Generate && " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Copy to Clipboard"
        Me.Button_Go.UseVisualStyleBackColor = True
        '
        'Label_Text
        '
        Me.Label_Text.AutoSize = True
        Me.Label_Text.Location = New System.Drawing.Point(17, 88)
        Me.Label_Text.Name = "Label_Text"
        Me.Label_Text.Size = New System.Drawing.Size(36, 21)
        Me.Label_Text.TabIndex = 6
        Me.Label_Text.Text = "Text"
        '
        'Timer_RemoveDone
        '
        Me.Timer_RemoveDone.Interval = 1000
        '
        'Button_ClearText
        '
        Me.Button_ClearText.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button_ClearText.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_ClearText.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_ClearText.Location = New System.Drawing.Point(797, 87)
        Me.Button_ClearText.Name = "Button_ClearText"
        Me.Button_ClearText.Size = New System.Drawing.Size(89, 23)
        Me.Button_ClearText.TabIndex = 5
        Me.Button_ClearText.Text = "Clear"
        Me.Button_ClearText.UseVisualStyleBackColor = True
        '
        'Label_Done
        '
        Me.Label_Done.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Done.ForeColor = System.Drawing.Color.Green
        Me.Label_Done.Location = New System.Drawing.Point(720, 15)
        Me.Label_Done.Name = "Label_Done"
        Me.Label_Done.Size = New System.Drawing.Size(62, 26)
        Me.Label_Done.TabIndex = 8
        Me.Label_Done.Text = "DONE"
        Me.Label_Done.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label_Done.Visible = False
        '
        'Button_ClearPrefix
        '
        Me.Button_ClearPrefix.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button_ClearPrefix.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_ClearPrefix.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_ClearPrefix.Location = New System.Drawing.Point(607, 16)
        Me.Button_ClearPrefix.Name = "Button_ClearPrefix"
        Me.Button_ClearPrefix.Size = New System.Drawing.Size(98, 23)
        Me.Button_ClearPrefix.TabIndex = 6
        Me.Button_ClearPrefix.Text = "Clear"
        Me.Button_ClearPrefix.UseVisualStyleBackColor = True
        '
        'Button_ClearSuffix
        '
        Me.Button_ClearSuffix.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button_ClearSuffix.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_ClearSuffix.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_ClearSuffix.Location = New System.Drawing.Point(607, 50)
        Me.Button_ClearSuffix.Name = "Button_ClearSuffix"
        Me.Button_ClearSuffix.Size = New System.Drawing.Size(98, 23)
        Me.Button_ClearSuffix.TabIndex = 7
        Me.Button_ClearSuffix.Text = "Clear"
        Me.Button_ClearSuffix.UseVisualStyleBackColor = True
        '
        'Timer_BringToFront
        '
        Me.Timer_BringToFront.Enabled = True
        Me.Timer_BringToFront.Interval = 250
        '
        'Timer_AppUpdate
        '
        Me.Timer_AppUpdate.Enabled = True
        Me.Timer_AppUpdate.Interval = 1000
        '
        'BackgroundWorker_AppUpdate
        '
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(898, 642)
        Me.Controls.Add(Me.Button_ClearSuffix)
        Me.Controls.Add(Me.Button_ClearPrefix)
        Me.Controls.Add(Me.Label_Done)
        Me.Controls.Add(Me.Button_ClearText)
        Me.Controls.Add(Me.Label_Text)
        Me.Controls.Add(Me.Button_Go)
        Me.Controls.Add(Me.Label_Suffix)
        Me.Controls.Add(Me.TextBox_Suffix)
        Me.Controls.Add(Me.Label_Prefix)
        Me.Controls.Add(Me.TextBox_Prefix)
        Me.Controls.Add(Me.Textbox_Text)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "MainWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Prefix/Suffix to Text"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Textbox_Text As TextBox
    Friend WithEvents TextBox_Prefix As TextBox
    Friend WithEvents Label_Prefix As Label
    Friend WithEvents Label_Suffix As Label
    Friend WithEvents TextBox_Suffix As TextBox
    Friend WithEvents Button_Go As Button
    Friend WithEvents Label_Text As Label
    Friend WithEvents Timer_RemoveDone As Timer
    Friend WithEvents Button_ClearText As Button
    Friend WithEvents Label_Done As Label
    Friend WithEvents Button_ClearPrefix As Button
    Friend WithEvents Button_ClearSuffix As Button
    Friend WithEvents Timer_BringToFront As Timer
    Friend WithEvents Timer_AppUpdate As Timer
    Friend WithEvents BackgroundWorker_AppUpdate As System.ComponentModel.BackgroundWorker
End Class
