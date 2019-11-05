Public Class Form2

    Public stu As SWICEnrollee

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        stu = New Student(txtFirst.Text, txtLast.Text)
        Me.Close()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class