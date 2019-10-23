Public Class Form1


    Dim emp1 As New CommissionEmployee("Sue", "Jones", "222-22-2222", 10000.0, 0.06)
    Dim emp2 As New BasePlusCommissionEmployee("Bob", "Lewis", "333-33-3333", 5000.0, 0.04, 300.0)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayEmp(emp1)
    End Sub


    Private Sub radBasePlusEmployee_CheckedChanged(sender As Object, e As EventArgs) Handles radBasePlusEmployee.CheckedChanged
        DisplayEmp(emp2)

    End Sub

    Private Sub radCommission_CheckedChanged(sender As Object, e As EventArgs) Handles radCommission.CheckedChanged
        DisplayEmp(emp1)

    End Sub

    Private Sub DisplayEmp(emp As CommissionEmployee)
        lblFirstName.Text = emp.FirstName
        lblLastName.Text = emp.LastName
        lblEmpAttrib1.Text = emp.GrossSales.ToString("c")
        lblEmpAttrib2.Text = emp.CommissionRate.ToString("p")

        ' Check to see if you can cast
        If TypeOf emp Is BasePlusCommissionEmployee Then
            lblBaseSalary.Text = CType(emp, BasePlusCommissionEmployee).BaseSalary.ToString("C")
        Else
            lblBaseSalary.Text = String.Empty
        End If

        lblEarnings.Text = emp.CalculateEarnings().ToString("C")
        lblOutput.Text = emp.ToString()
        grpEmp.Text = "Base Plus Commission Employee"

    End Sub

    'Private Sub DisplayEmp1()
    '    lblFirstName.Text = emp1.FirstName
    '    lblLastName.Text = emp1.LastName
    '    lblEmpAttrib1.Text = emp1.GrossSales.ToString("c")
    '    lblEmpAttrib2.Text = emp1.CommissionRate.ToString("p")
    '    lblBaseSalary.Text = String.Empty
    '    lblEarnings.Text = emp1.CalculateEarnings().ToString("C")
    '    lblOutput.Text = emp1.ToString()
    '    grpEmp.Text = "Commission Employee"

    'End Sub

    'Private Sub DisplayEmp2()
    '    lblFirstName.Text = emp2.FirstName
    '    lblLastName.Text = emp2.LastName
    '    lblEmpAttrib1.Text = emp2.GrossSales.ToString("c")
    '    lblEmpAttrib2.Text = emp2.CommissionRate.ToString("p")
    '    lblBaseSalary.Text = emp2.BaseSalary.ToString("C")
    '    lblEarnings.Text = emp2.CalculateEarnings().ToString("C")
    '    lblOutput.Text = emp2.ToString()
    '    grpEmp.Text = "Base Plus Commission Employee"

    'End Sub

End Class
