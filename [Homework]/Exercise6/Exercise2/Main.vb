Public Class Main
    Dim employees As New List(Of Employee) From {
        New Employee("Tom Thompson", "(618) 555-4444", 1100.0),
        New Employee("Georgia Kenedy", "(618) 555-5836", 1320.0),
        New Employee("Pete Peterson", "(618) 555-4327", 1188.0),
        New Employee("Meredith Jones", "(618) 555-1180", 1795.0),
        New Employee("Jean Cummings", "(618) 555-2195", 1716.0),
        New Employee("Michael Robbins", "(618) 555-5443", 1200.0),
        New Employee("Polly Marks", "(618) 555-1075", 1520.0)
        }
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        bsEmployees.DataSource = employees
        lstResults.DisplayMember = "Name"
        dgvEmployees.DataSource = bsEmployees
        dgvEmployees.Columns(2).DefaultCellStyle.Format = "c"
        dgvEmployees.Columns(3).DefaultCellStyle.Format = "c"
        UpdateForm()
    End Sub
    Private Sub UpdateForm()
        If bsEmployees.Current IsNot Nothing Then
            lblName.Text = bsEmployees.Current.Name
            lblPhone.Text = bsEmployees.Current.Phone
            lblMonthly.Text = String.Format("{0:C}", bsEmployees.Current.MonthlySalary)
            lblAnnual.Text = String.Format("{0:C}", bsEmployees.Current.AnnualSalary)
            lblTotalMonthly.Text = CalcMonthly()
            lblTotalAnnual.Text = CalcAnnual()
        End If
    End Sub

    Private Sub BtnRaise_Click(sender As Object, e As EventArgs) Handles btnRaise.Click
        For Each emp In employees
            emp.Raise()
        Next
        UpdateForm()
        dgvEmployees.Refresh()
    End Sub
    Private Function CalcMonthly()
        Dim monthly = From m In employees
                      Select m.MonthlySalary

        Return monthly.Sum().ToString("c")
    End Function
    Private Function CalcAnnual()
        Dim annual = From a In employees
                     Select a.AnnualSalary

        Return annual.Sum().ToString("c")
    End Function

    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim match = From emp In employees
                    Where emp.Name.ToLower().StartsWith(txtSearch.Text.ToLower())

        If match.Any() Then
            Dim emp As Employee
            emp = match.First() ' Get the first element
            bsEmployees.Position = employees.IndexOf(emp) ' Move to that element
            UpdateForm()
            lstResults.DataSource = match.ToList()
        End If
    End Sub

    Private Sub LstResults_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstResults.SelectedIndexChanged
        Dim match = From emp In employees
                    Where emp.Name.ToLower().Contains(lstResults.Text.ToLower())

        bsEmployees.Position = employees.IndexOf(match.First())
        UpdateForm()
    End Sub

    Private Sub btnIncrease_Click(sender As Object, e As EventArgs) Handles btnIncrease.Click
        Employee.RaisePercentage += 1
        btnRaise.Text = String.Format("Give all employees a {0}% raise", Employee.RaisePercentage)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim myAdd As New Add
        myAdd.ShowDialog()

        If myAdd.emp IsNot Nothing Then
            bsEmployees.Insert(0, myAdd.emp)
            bsEmployees.MoveFirst()
        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If bsEmployees.Current IsNot Nothing Then
            bsEmployees.RemoveCurrent()
        End If
    End Sub

    Private Sub bsEmployees_CurrentChanged(sender As Object, e As EventArgs) Handles bsEmployees.CurrentChanged
        UpdateForm()
    End Sub
End Class