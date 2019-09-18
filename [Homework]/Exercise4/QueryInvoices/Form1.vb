Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim invoices() As Invoice = {
            New Invoice(83, "Electric sander", 7, 57.98),
            New Invoice(24, "Power saw", 18, 99.99),
            New Invoice(7, "Sledge hammer", 11, 21.5),
            New Invoice(77, "Hammer", 76, 11.99),
            New Invoice(39, "Lawn mower", 3, 79.5),
            New Invoice(68, "Screwdriver", 106, 6.99),
            New Invoice(56, "Jig saw", 21, 11.0),
            New Invoice(3, "Wrench", 34, 7.5)
        }
        bsInvoices.DataSource = invoices
        dgvResults.DataSource = bsInvoices
    End Sub

    Private Sub BtnA_Click(sender As Object, e As EventArgs) Handles btnA.Click

    End Sub

    Private Sub BtnB_Click(sender As Object, e As EventArgs) Handles btnB.Click

    End Sub

    Private Sub BtnC_Click(sender As Object, e As EventArgs) Handles btnC.Click

    End Sub

    Private Sub BtnD_Click(sender As Object, e As EventArgs) Handles btnD.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub
End Class
