Public Class Form1

    Dim emp1 As New CommissionEmployee("Sue", "Jones", "222-22-2222", 10000.0, 0.06)
    Dim emp2 As New BasePlusCommissionEmployee("Bob", "Lewis", "333-33-3333", 5000.0, 0.04, 300.0)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayEmp()
    End Sub

    Sub DisplayEmp()
        lblCFirstName.Text = emp1.FirstName
        lblCLastName.Text = emp1.LastName
        lblCGrossSales.Text = emp1.GrossSales.ToString("c")
        lblCRate.Text = emp1.CommissionRate.ToString("p")
        lblCEarnings.Text = emp1.CalculateEarnings().ToString("C")
        lblCOutput.Text = emp1.ToString()

        lblBFirstName.Text = emp2.FirstName
        lblBLastName.Text = emp2.LastName
        lblBGrossSales.Text = emp2.GrossSales.ToString("c")
        lblBRate.Text = emp2.CommissionRate.ToString("p")
        lblBase.Text = emp2.BaseSalary.ToString("C")
        lblBEarnings.Text = emp2.CalculateEarnings().ToString("C")
        lblBOutput.Text = emp2.ToString()

    End Sub

    Private Sub btnUpdateEmp1_Click(sender As Object, e As EventArgs) Handles btnUpdateEmp1.Click
        emp1.GrossSales = 5000
        emp1.CommissionRate = 0.1
        DisplayEmp()

    End Sub

    Private Sub btnUpdateEmp2_Click(sender As Object, e As EventArgs) Handles btnUpdateEmp2.Click
        emp2.BaseSalary = 1000
        DisplayEmp()

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        emp1.GrossSales = 10000
        emp1.CommissionRate = 0.06
        emp2.BaseSalary = 300
        DisplayEmp()

    End Sub
End Class
