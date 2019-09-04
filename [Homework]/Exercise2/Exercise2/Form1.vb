Public Class Form1
    Dim employees() As Employee = {
        New Employee("Tom Thompson", "(618) 555-4444", 1100.0),
        New Employee("Georgia Kenedy", "(618) 555-5836", 1320.0),
        New Employee("Pete Peterson", "(618) 555-4327", 1188.0),
        New Employee("Meredith Jones", "(618) 555-1180", 1795.0),
        New Employee("Jean Cummings", "(618) 555-2195", 1716.0),
        New Employee("Michael Robbins", "(618) 555-5443", 1200.0),
        New Employee("Polly Marks", "(618) 555-1075", 1520.0)
        }
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Try
        '    employees = {
        'New Employee("Tom Thompson", "(618) 555-4444", 1100.0),
        'New Employee("Georgia Kenedy", "(618) 555-5836", 1320.0),
        'New Employee("Pete Peterson", "(618) 555-4327", 1188.0),
        'New Employee("Meredith Jones", "(618) 555-1180", 1795.0),
        'New Employee("Jean Cummings", "(618) 555-2195", 1716.0),
        'New Employee("Michael Robbins", "(618) 555-5443", 1200.0),
        'New Employee("Polly Marks", "(618) 555-1075", 1520.0)
        '}
        'Catch ex As Exception
        '    MessageBox.Show("Caught it!")
        'End Try

        bsEmployees.DataSource = employees
        dgvEmployees.DataSource = bsEmployees
        UpdateForm()
    End Sub
    Private Sub UpdateForm()
        lblName.Text = bsEmployees.Current.Name
        lblPhone.Text = bsEmployees.Current.Phone
        lblMonthly.Text = String.Format("{0:C}", bsEmployees.Current.MonthlySalary)
        dgvEmployees.Columns(2).DefaultCellStyle.Format = "c"
        lblAnnual.Text = String.Format("{0:C}", bsEmployees.Current.AnnualSalary)
        dgvEmployees.Columns(3).DefaultCellStyle.Format = "c"
        dgvEmployees.Refresh()
    End Sub

    Private Sub BtnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        bsEmployees.MoveFirst()
        UpdateForm()
    End Sub

    Private Sub BtnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        bsEmployees.MovePrevious()
        UpdateForm()
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        bsEmployees.MoveNext()
        UpdateForm()
    End Sub

    Private Sub BtnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        bsEmployees.MoveLast()
        UpdateForm()
    End Sub

    Private Sub BtnRaise_Click(sender As Object, e As EventArgs) Handles btnRaise.Click
        For Each emp In employees
            emp.Raise()
        Next
        UpdateForm()
    End Sub
End Class


