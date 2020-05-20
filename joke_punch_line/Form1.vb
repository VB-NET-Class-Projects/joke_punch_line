Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub btnSetup_Click(sender As Object, e As EventArgs) Handles btnSetup.Click
        lblJokeDisplay.Text = "What has four wheels and flies?"
        lblJokeDisplay.Visible = True
    End Sub

    Private Sub btnPunchLine_Click(sender As Object, e As EventArgs) Handles btnPunchLine.Click
        lblJokeDisplay.Text = "A garbage truck!"
    End Sub

    Private Sub lblSetup_Click(sender As Object, e As EventArgs) Handles lblJokeDisplay.Click

    End Sub
End Class
