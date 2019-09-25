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
        lblTotalMonthly.Text = CalcMonthly()
        lblTotalAnnual.Text = CalcAnnual()
    End Sub

    Private Sub BtnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If Not SearchFunction(txtSearch.Text, bsEmployees.Position - 1, 0, -1) Then
            lblError.Visible = True
        Else
            lblError.Visible = False
        End If
        UpdateForm()
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If Not SearchFunction(txtSearch.Text, bsEmployees.Position + 1, employees.Count - 1, 1) Then
            lblError.Visible = True
        Else
            lblError.Visible = False
        End If
        UpdateForm()
    End Sub

    Private Sub BtnRaise_Click(sender As Object, e As EventArgs) Handles btnRaise.Click
        For Each emp In employees
            emp.Raise()
        Next
        UpdateForm()
    End Sub

    Private Sub BindingNavigatorMoveFirstItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveFirstItem.Click
        UpdateForm()
    End Sub

    Private Sub BindingNavigatorMovePreviousItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMovePreviousItem.Click
        UpdateForm()
    End Sub

    Private Sub BindingNavigatorMoveNextItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveNextItem.Click
        UpdateForm()
    End Sub

    Private Sub BindingNavigatorMoveLastItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveLastItem.Click
        UpdateForm()
    End Sub
    Private Function CalcMonthly()
        Dim m As Integer

        For Each emp In employees
            m += emp.MonthlySalary
        Next

        Return m.ToString("c")
    End Function
    Private Function CalcAnnual()
        Dim a As Integer

        For Each emp In employees
            a += emp.AnnualSalary
        Next

        Return a.ToString("c")
    End Function

    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        lblError.Visible = False
    End Sub

    Private Function SearchFunction(name As String, p As Integer, l As Integer, s As Integer)
        For i = p To l Step s
            If employees(i).Name.ToUpper().Contains(name.ToUpper()) Then
                bsEmployees.Position = i
                Return True
                Exit For
            End If
        Next
        Return False
    End Function
End Class