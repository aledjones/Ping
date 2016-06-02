<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.listPing = New System.Windows.Forms.ListBox()
        Me.cmdPing = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'listPing
        '
        Me.listPing.FormattingEnabled = True
        Me.listPing.Location = New System.Drawing.Point(12, 12)
        Me.listPing.Name = "listPing"
        Me.listPing.Size = New System.Drawing.Size(514, 368)
        Me.listPing.TabIndex = 0
        '
        'cmdPing
        '
        Me.cmdPing.Location = New System.Drawing.Point(12, 395)
        Me.cmdPing.Name = "cmdPing"
        Me.cmdPing.Size = New System.Drawing.Size(75, 23)
        Me.cmdPing.TabIndex = 1
        Me.cmdPing.Text = "Ping!"
        Me.cmdPing.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(538, 460)
        Me.Controls.Add(Me.cmdPing)
        Me.Controls.Add(Me.listPing)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents listPing As System.Windows.Forms.ListBox
    Friend WithEvents cmdPing As System.Windows.Forms.Button

End Class
