Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PictureBox1.Image = Project_001.My.Resources.Resources.th__1_
        TextBox1.Text = "Red Light says STOP"


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PictureBox1.Image = Project_001.My.Resources.Resources.th__2_1
        TextBox1.Text = "Yellow Light says GO"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PictureBox1.Image = Project_001.My.Resources.Resources.th
        TextBox1.Text = "Green Light says GO"
    End Sub


End Class
