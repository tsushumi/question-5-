Public Class Process
    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click
        ProgressBar1.Location = New System.Drawing.Point(56, 72)
        ProgressBar1.Size = New Size(168, 23)
        ProgressBar1.TabIndex = 2
        ProgressBar1.Value = 0
    End Sub

    Private Sub Process_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        ResultLabel.Visible = True
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value <= ProgressBar1.Maximum - 1 Then
            ProgressBar1.Value += 1
            ResultLabel.Text = Int(ProgressBar1.Value * 100 / ProgressBar1.Maximum)
            ResultLabel.Refresh()
        Else Timer1.Enabled = False
        End If
    End Sub
End Class
