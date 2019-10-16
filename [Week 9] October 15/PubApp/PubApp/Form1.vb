Public Class Form1

    Dim aBook As Publication = New Book("Starting out with C#", 2017, "Gaddis", "Computer Science")
    Dim aMag As Publication = New Magazine("Wired", 2011, "June", 1)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayBook()
    End Sub

    Private Sub DisplayBook()
        lblTitle.Text = aBook.Title
        lblYear.Text = aBook.Year
        lblRead.Text = aBook.Read
        lblOutput.Text = aBook.GetInfo()
    End Sub

    Private Sub DisplayMag()
        lblTitle.Text = aMag.Title
        If TypeOf aMag Is Magazine Then ' Test to make sure it's a magazine and not something else (like a book)
            lblYear.Text = CType(aMag, Magazine).PubDate ' Cast to Magazine type
        Else
            lblYear.Text = String.Empty
        End If
        lblRead.Text = aMag.Read
        lblOutput.Text = aMag.GetInfo()
    End Sub

    Private Sub chkBookRead_CheckedChanged(sender As Object, e As EventArgs) Handles chkBookRead.CheckedChanged
        aBook.Read = chkBookRead.Checked
        DisplayBook()
    End Sub

    Private Sub chkMagRead_CheckedChanged(sender As Object, e As EventArgs) Handles chkMagRead.CheckedChanged
        aMag.Read = chkMagRead.Checked
        DisplayMag()
    End Sub

    Private Sub btnBook_Click(sender As Object, e As EventArgs) Handles btnBook.Click
        DisplayBook()
    End Sub

    Private Sub btnMagazine_Click(sender As Object, e As EventArgs) Handles btnMagazine.Click
        DisplayMag()
    End Sub
End Class
