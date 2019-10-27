Public MustInherit Class Employee ' Abstract class; cannot instanciate
    Public Property FirstName() As String ' auto-implemented
    Public Property LastName() As String ' auto-implemented
    Public Property SocialSecurityNumber() As String ' auto-implemented

    ' five-argument constructor
    Public Sub New(first As String, last As String, ssn As String)

        ' implicit call to class Object's constructor occurs here
        FirstName = first
        LastName = last
        SocialSecurityNumber = ssn
    End Sub ' New


    ' return String representation of CommissionEmployee object
    Public Overrides Function ToString() As String
        Return " EMPLOYEE" & String.Format("{0}Name: {1} {2}{3}Social Security Number: {4}", vbNewLine, FirstName, LastName, vbNewLine, SocialSecurityNumber)
    End Function ' ToString
    ' calculate earnings
    Public MustOverride Function CalculateEarnings() As Decimal ' Abstract method

End Class