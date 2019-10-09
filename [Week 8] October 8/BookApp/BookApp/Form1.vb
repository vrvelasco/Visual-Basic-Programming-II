Public Class Form1
    Dim books As New List(Of Book) From {
            New Book("Nineteen Eighty-Four", "Science Fiction", 19, 24.26),
            New Book("Pride & Prejudice", "Romance", 54, 9.95),
            New Book("Animal Farm", "Satire", 12, 15.15),
            New Book("The Shining", "Horror", 40, 28.99),
            New Book("The War of the Worlds", "Science Fiction", 15, 8.73),
            New Book("Fahrenheit 451", "Science Fiction", 36, 16.99),
            New Book("The Notebook", "Romance", 27, 11.34),
            New Book("Fifty Shades of Grey", "Romance", 10, 24.26),
            New Book("Dracula", "Horror", 34, 13.86),
            New Book("Frankenstein", "Science Fiction", 28, 9.54)
    }

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bsBooks.DataSource = books
        lblMargin.Text = String.Format("{0:N2}%", Book.ProfitMargin)
        UpdateGenre()
        DisplayBook()
    End Sub

    Private Sub DisplayBook()
        If bsBooks.Current IsNot Nothing Then
            Dim b As Book = bsBooks.Current
            lblGenre.Text = b.Genre
            lblCost.Text = b.Cost.ToString("C")
            lblPrice.Text = b.Price.ToString("C")
            lblQuantity.Text = b.Quantity.ToString()
            lblTitle.Text = b.Title
            lblInventoryValue.Text = b.InventoryValue.ToString("C")

            ' Count 
            Dim count As Integer = (From g In books
                                    Where g.Genre = cboGenres.Text()
                                    Select g.Quantity).Count()

            lblGenreCount.Text = count

            'Value
            Dim value As Double = (From g In books
                                   Where g.Genre = cboGenres.Text()
                                   Select g.InventoryValue).Sum()

            lblGenreInvValue.Text = value.ToString("c")
        End If
    End Sub

    Private Sub bsBooks_CurrentChanged(sender As Object, e As EventArgs) Handles bsBooks.CurrentChanged
        DisplayBook()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim match = From b In books
                    Where b.Title.ToLower().StartsWith(txtSearch.Text.ToLower())

        If match.Any() Then
            Dim b As Book
            b = match.First() ' Get the first element
            bsBooks.Position = books.IndexOf(b) ' Move to that element
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim t, g As String
        Dim c As Double
        Dim q As Integer

        Try
            t = txtTitle.Text
            c = CDbl(txtCost.Text)
            q = CInt(txtQuantity.Text)
            g = txtGenre.Text

            Dim newBook = New Book(t, g, q, c)
            bsBooks.Insert(0, newBook)
            UpdateGenre()
        Catch
            MessageBox.Show("Fields are empty or invalid. Please try again.", "New Book Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnLowerMargin_Click(sender As Object, e As EventArgs) Handles btnLowerMargin.Click
        Book.ProfitMargin -= 2
        DisplayBook()
        lblMargin.Text = String.Format("{0:N2}%", Book.ProfitMargin)
    End Sub

    Private Sub btnRaiseMargin_Click(sender As Object, e As EventArgs) Handles btnRaiseMargin.Click
        Book.ProfitMargin += 2
        DisplayBook()
        lblMargin.Text = String.Format("{0:N2}%", Book.ProfitMargin)
    End Sub

    Private Sub UpdateGenre()
        Dim genres = (From g In books
                      Select g.Genre).Distinct().ToList()
        cboGenres.DataSource = genres
    End Sub

    Private Sub cboGenres_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGenres.SelectedIndexChanged
        Dim populate = From g In books
                       Where g.Genre = cboGenres.Text()
                       Select g.Title

        lstBooks.DataSource = populate.ToList()
    End Sub

    Private Sub lstBooks_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBooks.SelectedIndexChanged
        Dim match = From b In books
                    Where b.Title.ToLower().Equals(lstBooks.Text.ToLower())

        If match.Any() Then
            Dim b As Book
            b = match.First() ' Get the first element
            bsBooks.Position = books.IndexOf(b) ' Move to that element
        End If
    End Sub
End Class
