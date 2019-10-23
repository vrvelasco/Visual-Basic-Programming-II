Public Class Form1

    Dim emps As New List(Of Employee) From {
        New CommissionEmployee("Sue", "Jones", "222-22-2222", 10000.0, 0.06),
        New BasePlusCommissionEmployee("Bob", "Lewis", "333-33-3333", 5000.0, 0.04, 300.0),
        New SalariedEmployee("John", "Smith", "111-11-1111", 800.0)
    }

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each ee In emps
            lstEmps.Items.Add(ee.ToString())
        Next
    End Sub
End Class
