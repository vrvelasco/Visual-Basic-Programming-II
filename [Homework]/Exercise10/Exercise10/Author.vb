'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Namespace Exercise10

    Partial Public Class Author
        Public Property AuthorID As Integer
        Public Property FirstName As String
        Public Property LastName As String
    
        Public Overridable Property Titles As ICollection(Of Title) = New HashSet(Of Title)
    
    End Class

End Namespace
