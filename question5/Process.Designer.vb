<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Process
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.ResultLabel = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(92, 66)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(595, 23)
        Me.ProgressBar1.TabIndex = 0
        '
        'ResultLabel
        '
        Me.ResultLabel.AutoSize = True
        Me.ResultLabel.Location = New System.Drawing.Point(12, 74)
        Me.ResultLabel.Name = "ResultLabel"
        Me.ResultLabel.Size = New System.Drawing.Size(39, 15)
        Me.ResultLabel.TabIndex = 1
        Me.ResultLabel.Text = "Result"
        '
        'Process
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ResultLabel)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Name = "Process"
        Me.Text = "Process"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents ResultLabel As Label
    Friend WithEvents Timer1 As Timer
End Class
