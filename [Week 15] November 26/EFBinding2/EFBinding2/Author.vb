'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------
'CLASS WILL UPDATE WHEN DATABASE IS UPDATED
Imports System
Imports System.Collections.Generic

Partial Public Class Author
    Public Property AuthorID As Integer
    Public Property FirstName As String
    Public Property LastName As String
    Public ReadOnly Property FullName As String
        Get
            Return FirstName & " " & LastName
        End Get
    End Property

End Class
