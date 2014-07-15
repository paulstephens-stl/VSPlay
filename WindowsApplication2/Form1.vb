Public Class Form1

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Enabled Then ProgressBar1.Value += 1
        If ProgressBar1.Value >= ProgressBar1.Maximum Then Timer1.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Enabled = Not (Timer1.Enabled)
        ProgressBar1.Value = 0
    End Sub
End Class
