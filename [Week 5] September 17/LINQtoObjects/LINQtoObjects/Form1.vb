Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim values() As Integer = {2, 9, 5, 0, 3, 7, 1, 4, 8, 5}

        'For Each v In values
        '    If v > 4 Then
        '        lstOutput.Items.Add(v)
        '    End If
        'Next

        Dim filtered = From v In values
                       Where v > 4

        'For Each i In filtered
        '    lstOutput.Items.Add(i)
        'Next

        Dim sorted = From v In values
                     Order By v

        Dim filtersort = From v In filtered
                         Order By v

        Dim filtersort2 = From v In values
                          Where v > 4
                          Order By v

        Dim doubled = From v In filtered
                      Select v * 2

        Dim students() As Student = {
            New Student("Simon", "Smith", 15),
            New Student("Fanny", "Fargo"),
            New Student("Pete", "Smith", 9),
            New Student("Bill", "Bailey"),
            New Student("John", "Long"),
            New Student("Van", "Hill", 36),
            New Student("Cindy", "Jones"),
            New Student("Sean", "Childs"),
            New Student("Marcy", "Michaels", 18)
        }

        Dim stus = From s In students
                   Let classes = s.TotalCredits / 3
                   Where s.TotalCredits > 10
                   Order By s.StudentFirstName Descending, s.StudentLastName
                   Select s.StudentFullName, s.TotalCredits, NumberOfClasses = classes

        'Select s.TotalCredits / 3
        'Select Case s.StudentLastName & ", " & s.StudentFirstName

        lstOutput.DataSource = stus.ToArray()
        lstOutput.DisplayMember = "StudentFullName"

        dgvStudents.DataSource = stus.ToArray()

        Dim c1 As Integer = stus.Count()
        MessageBox.Show("Number of items in ""stus"": " & c1)

        Dim c2 As Integer = (From ss In stus
                             Where ss.NumberOfClasses > 0).Count()

        MessageBox.Show("Number of students with more than one class: " & c2)

        Dim c3 As Integer = (From sss In students
                             Select sss.StudentLastName).Distinct().Count()
        MessageBox.Show("Number of student last names: " & c3)

        'lstOutput.DataSource = filtered.ToArray()
        'lstOutput.DataSource = sorted.ToArray()
        'lstOutput.DataSource = filtersort.ToArray()
        'lstOutput.DataSource = filtersort2.ToArray()
        'lstOutput.DataSource = doubled.ToArray()


    End Sub
End Class
