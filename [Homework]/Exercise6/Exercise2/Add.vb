Public Class Add
    Public emp As Employee
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        emp = New Employee()

        If txtName.Text = "" And txtPhone.Text = "" And txtSalary.Text = "" Then
            MessageBox.Show("Please complete form to add employee.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            emp.Name = txtName.Text
            emp.MonthlySalary = txtSalary.Text
            emp.Phone = txtPhone.Text
        End If

        Close()
    End Sub
End Class