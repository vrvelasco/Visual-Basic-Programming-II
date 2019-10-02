Public Class Form2
    Public stu As New Student()
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        stu.StudentFirstName = txtFirst.Text
        stu.StudentLastName = txtLast.Text
        Close()
    End Sub
End Class