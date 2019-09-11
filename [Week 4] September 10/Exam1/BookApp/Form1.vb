' Victor Velasco
Public Class Form1
    Dim books() As Book = {
        New Book("Crossing the River With Dogs", 19, 54.95),
        New Book("Practical Computing", 54, 51.68),
        New Book("Microsoft Windows MS-DOS Command Line", 12, 36.95),
        New Book("Windows 8, Introductory", 40, 77.95),
        New Book("Microsoft Windows 8: Introductory Concepts and Techniques", 15, 47.95),
        New Book("Windows Command Line", 36, -110.0),
        New Book("A Guide to Helpdesk Concepts", 27, 77.95),
        New Book("Microsoft Windows 8: Intermediate", 28, 73.0)
        }
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bsBooks.DataSource = books
        UpdateForm()
    End Sub
    Private Sub UpdateForm()
        lblBookNumber.Text = bsBooks.Position + 1
        lblTitle.Text = bsBooks.Current.Title
        lblCost.Text = String.Format("{0:C}", bsBooks.Current.Cost)
        lblPrice.Text = String.Format("{0:C}", bsBooks.Current.Price)
        lblQuantity.Text = bsBooks.Current.Quantity
        lblInventoryValue.Text = String.Format("{0:C}", bsBooks.Current.InventoryValue)
    End Sub
    Private Sub BtnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        bsBooks.MoveFirst()
        UpdateForm()
    End Sub
    Private Sub BtnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        bsBooks.MovePrevious()
        UpdateForm()
    End Sub
    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        bsBooks.MoveNext()
        UpdateForm()
    End Sub
    Private Sub BtnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        bsBooks.MoveLast()
        UpdateForm()
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim b As Book = Nothing
        Dim i As Integer

        lstBooks.Items.Clear()

        For i = 0 To books.Count - 1
            If books(i).InventoryValue > txtSearch.Text Then
                b = books(i)
                lstBooks.Items.Add(b.Title)
            End If
        Next

        If b IsNot Nothing Then
        Else
            MessageBox.Show("Not Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub lstBooks_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBooks.SelectedIndexChanged
        For i = 0 To books.Count - 1
            If books(i).Title.ToUpper() = lstBooks.SelectedItem.ToString().ToUpper() Then
                bsBooks.Position = i
                UpdateForm()
                Exit For
            End If
        Next
    End Sub
End Class
