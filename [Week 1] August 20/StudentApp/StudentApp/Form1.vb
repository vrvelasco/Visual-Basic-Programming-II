' Victor Velasco 8/20/19
Public Class Form1
    Dim stu As New Student("Mary", "Blue")
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblName.Text = stu.StudentFullName
        lblCurrent.Text = stu.CurrentCredits
        lblTotal.Text = stu.TotalCredits
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        stu.AddCredits()
        lblCurrent.Text = stu.CurrentCredits
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        stu.ResetCredits()
        lblTotal.Text = stu.TotalCredits
    End Sub
End Class
