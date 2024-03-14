Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub vscroll_Scroll(sender As Object, e As ScrollEventArgs) Handles vscroll.Scroll
        txtOut.Text = vscroll.Value
        txtHours.Text = vscroll.Value \ 60
        txtMinutes.Text = vscroll.Value Mod 60
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
