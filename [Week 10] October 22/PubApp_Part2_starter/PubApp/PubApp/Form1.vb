Public Class Form1

    Dim pubs As New List(Of Publication) From {
            New Book("Starting out with C#", 2017, "Gaddis", "Computer Science"),
            New Magazine("Wired", 2011, "June", 1),
            New Book("Visual C#: How to Program", 2017, "Deitel", "Computer Science"),
            New Magazine("PC Magazine", 2015, "September", 9)
    }

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each p In pubs
            lstPubs.Items.Add(p.GetInfo)
        Next
    End Sub
End Class
