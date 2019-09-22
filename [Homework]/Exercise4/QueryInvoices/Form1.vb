Public Class Form1
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
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvResults.DataSource = invoices
    End Sub

    Private Sub BtnA_Click(sender As Object, e As EventArgs) Handles btnA.Click
        Dim PartA = From a In invoices
                    Order By a.PartDescription

        dgvResults.DataSource = PartA.ToArray()
        UpdateDisplay()
    End Sub

    Private Sub BtnB_Click(sender As Object, e As EventArgs) Handles btnB.Click
        Dim PartB = From b In invoices
                    Order By b.Price
        dgvResults.DataSource = PartB.ToArray()
        UpdateDisplay()
    End Sub

    Private Sub BtnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        Dim PartC = From c In invoices
                    Order By c.Quantity
                    Select c.PartDescription, c.Quantity
        dgvResults.DataSource = PartC.ToArray()
        UpdateDisplay()
    End Sub

    Private Sub BtnD_Click(sender As Object, e As EventArgs) Handles btnD.Click
        Dim PartD = From d In invoices
                    Let _invoice = d.Quantity * d.Price
                    Order By _invoice
                    Select d.PartDescription, InvoiceTotal = _invoice
        dgvResults.DataSource = PartD.ToArray()
        UpdateDisplay()
    End Sub

    Private Sub BtnE_Click(sender As Object, e As EventArgs) Handles btnE.Click
        Dim PartD = From d In invoices
                    Let _invoice = d.Quantity * d.Price
                    Order By _invoice
                    Select d.PartDescription, InvoiceTotal = _invoice

        Dim PartE = From de In PartD
                    Where de.InvoiceTotal >= 200 And de.InvoiceTotal <= 500
        dgvResults.DataSource = PartE.ToArray()
        UpdateDisplay()
    End Sub

    ' Method    
    Private Sub UpdateDisplay()
        dgvResults.Refresh()
    End Sub
End Class
