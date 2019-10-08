Public Class Form2

    Public stu As Student

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        stu = New Student
        stu.StudentFirstName = txtFirst.Text
        stu.StudentLastName = txtLast.Text
        Me.Close()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class