Imports System.Data.Entity

Public Class Form1
    Dim db As New BooksEntities()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'load method takes data from the original and makes a copy to the data context (db) that can be edited and the changes remain
        'RETRIEVING data
        db.Authors.Load
        'local method needs data loaded first and then it connects the data in the data context to the form
        'REFERENCING data
        AuthorBindingSource.DataSource = db.Authors.Local

    End Sub

    'whatever occurs whenever the current property changes
    Private Sub AuthorBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles AuthorBindingSource.CurrentChanged
        'SAVES data changes
        db.SaveChanges()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'CHANGE DGV DATA SOURCE TO NONE IF YOU WANT TO SEE THIS STATEMENT WORK
        AuthorDataGridView.DataSource = db.Authors.Local.
            Select(Function(a) New With {.Author_ID = a.AuthorID, .Author_FullName = a.FullName}). 'object initializer pg 335
            ToList()
    End Sub
End Class
