Public Class Form1
    Dim numbers() As Integer = {2, 9, 5, 0, 3, 7, 1, 4, 8, 5}

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Multi line Function
        Dim increment = Function(x)
                            Return x + 1
                        End Function

        ' Single line Function
        Dim increment2 = Function(x) x + 2

        lblOutput.Text = increment2(5)

        ' Multi line Sub
        Dim msgVB = Sub(x)
                        lblOutput.Text = "Visual " & x
                    End Sub

        msgVB("Basic")

        ' Single line Sub
        Dim msgHello = Sub(x) MessageBox.Show("Hello " & x)

        'msgHello("World!")

        Dim filtered = numbers.Where(Function(n) n > 4)

        lstOutput.DataSource = filtered.ToList()

        lstOutput.DataSource = numbers.Where(Function(n) n > 4).ToList()


        lstOutput.DataSource = numbers.OrderBy(Function(n) n).ToList() ' Requires Lambda (returns the same number for ordering)

        lstOutput.DataSource = numbers.OrderByDescending(Function(n) n).ToList() ' Requires Lambda (returns the same number for ordering)

        lblOutput.Text = numbers.Where(Function(n) n > 4).Sum()

        lblOutput.Text = numbers.Count(Function(n) n > 4)

        lstOutput.DataSource = numbers.Select(Function(n) n * 2).ToList()

        lstOutput.DataSource = numbers.
            Where(Function(n) n > 4).
            Select(Function(n) n * 2).
            OrderByDescending(Function(n) n).
            ToList()
    End Sub
End Class
