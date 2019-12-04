Imports System.Data.Entity

Public Class Form1
    Dim db As New PracticeEntities()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        db.Employees.Load

        EmployeeBindingSource.DataSource = db.Employees.Local

        GetDepartments()
        GetEmployee()
    End Sub

    Private Sub EmployeeBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles EmployeeBindingSource.CurrentChanged
        db.SaveChanges()
    End Sub

    Private Sub GetDepartments()
        Dim depart = db.Employees.
            Select(Function(d) d.deptcode).Distinct()

        For Each d In depart
            cboDepart.Items.Add(d)
        Next
    End Sub

    Public Sub GetEmployee()
        lstResults.Items.Clear()

        Dim names = db.Employees.
            Where(Function(n) n.deptcode.StartsWith(cboDepart.Text)).
            OrderBy(Function(o) o.lastname)

        For Each n In names
            lstResults.Items.Add(n.FullName)
        Next

        lblResults.Text = String.Format("{0} employees", names.Count())
    End Sub

    Private Sub cboDepart_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDepart.SelectedIndexChanged
        GetEmployee()
    End Sub

    Private Sub lstResults_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstResults.SelectedIndexChanged
        Dim match = db.Employees.
            Where(Function(m) m.FullName.Equals(lstResults.Text))
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        dgvResults.DataSource = db.Employees.Local.
            Where(Function(t) t.hiredate >= DateTime.Parse(txtStart.Text) Or t.hiredate <= DateTime.Parse(txtEnd.Text)).
            OrderByDescending(Function(o) o.hiredate).
            Select(Function(s) New With {s.FullName, s.hiredate}).ToList()
    End Sub
End Class
