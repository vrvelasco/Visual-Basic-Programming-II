Imports Exercise10.Exercise10

Public Class Form1
    Dim db As New BooksEntities()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvTitles.DataSource = db.Titles.ToList() ' Display a list of Titles in the grid.

        GetYears() ' Populates ListBox with years in database that can be used to filter.
    End Sub

    Private Sub BtnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click
        ' Get a filtered list that match the year selected by the user.
        Dim copy = From c In db.Titles
                   Where c.Copyright = lstYears.Text()

        dgvTitles.DataSource = copy.ToList() ' Display filtered list in DataGridView.
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        dgvTitles.DataSource = db.Titles.ToList() ' Reset DataGridView to full list.
    End Sub

    Private Sub GetYears()
        ' Get the distinct years in the database
        Dim years = From y In db.Titles
                    Select y.Copyright Distinct

        ' Display the available years in the ListBox
        ' so the user can find the year they are looking for.
        lstYears.DataSource = years.ToList()
    End Sub
End Class
