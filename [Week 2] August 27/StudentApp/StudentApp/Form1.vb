' Victor Velasco 8/20/19
Public Class Form1
    Dim students() As Student = {
        New Student("Biff", "Arfus"),
        New Student("Becky", "Blue"),
        New Student("Simon", "Smith", 15),
        New Student("Fanny", "Fargo"),
        New Student("Pete", "Smith", 9),
        New Student("Bill", "Bailey"),
        New Student("John", "Long"),
        New Student("Van", "Hill", 36),
        New Student("Cindy", "Jones"),
        New Student("Marcy", "Michaels", 18)
    }
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bsStudents.DataSource = students
        lstStudents.DataSource = bsStudents
        lstStudents.DisplayMember = "StudentLastName"
        dgvStudents.DataSource = bsStudents
        DisplayStudent()
    End Sub
    Private Sub DisplayStudent()
        lblName.Text = bsStudents.Current.StudentFullName
        lblCurrent.Text = bsStudents.Current.CurrentCredits
        lblTotal.Text = bsStudents.Current.TotalCredits

    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        bsStudents.Current.AddCredits(1)
        DisplayStudent()
        dgvStudents.Refresh()
    End Sub
    Private Sub btnAdd3_Click(sender As Object, e As EventArgs) Handles btnAdd3.Click
        bsStudents.Current.AddCredits()
        DisplayStudent()
        dgvStudents.Refresh()
    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        bsStudents.Current.ResetCredits()
        DisplayStudent()
        dgvStudents.Refresh()
    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        bsStudents.MoveFirst()
        DisplayStudent()
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        bsStudents.MovePrevious()
        DisplayStudent()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        bsStudents.MoveNext()
        DisplayStudent()
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        bsStudents.MoveLast()
        DisplayStudent()
    End Sub

    Private Sub btnAdd3All_Click(sender As Object, e As EventArgs) Handles btnAdd3All.Click
        For Each s In students
            s.AddCredits()
        Next
        DisplayStudent()
        dgvStudents.Refresh()
    End Sub

    Private Sub btnResetAll_Click(sender As Object, e As EventArgs) Handles btnResetAll.Click
        For Each s In students
            s.ResetCredits()
        Next
        DisplayStudent()
        dgvStudents.Refresh()
    End Sub
End Class
