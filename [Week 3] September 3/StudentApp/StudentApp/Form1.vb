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

        dgvStudents.DataSource = bsStudents

        DisplayStudent()
    End Sub

    Private Sub DisplayStudent()
        Dim intCntFT, intSumCurFT, intSumCurrent As Integer

        lblName.Text = bsStudents.Current.StudentFullName
        lblCurrent.Text = bsStudents.Current.CurrentCredits
        lblTotal.Text = bsStudents.Current.TotalCredits

        lstFullTime.Items.Clear()

        For Each s As Student In students
            If s.CurrentCredits >= 12 Then
                intCntFT += 1
                intSumCurFT += s.CurrentCredits
                lstFullTime.Items.Add(s.StudentFullName)
            End If
            intSumCurrent += s.CurrentCredits
        Next

        lblFTCnt.Text = intCntFT

        If intCntFT > 0 Then
            lblAvgCurFT.Text = intSumCurFT / intCntFT
        End If

        lblTotCur.Text = intSumCurrent
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

    Private Sub btnAdd1_Click(sender As Object, e As EventArgs) Handles btnAdd1.Click
        bsStudents.Current.AddCredits(1)
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
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim stu As Student = Nothing
        Dim i As Integer

        lstResults.Items.Clear()

        For i = 0 To students.Count - 1
            If students(i).StudentLastName.ToUpper().Contains(txtName.Text.ToUpper()) Then
                stu = students(i)
                lstResults.Items.Add(stu.StudentFullName)
            End If
        Next

        If stu IsNot Nothing Then
        Else
            MessageBox.Show("Not Found!")
        End If
    End Sub
    Private Sub lstResults_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstResults.SelectedIndexChanged
        For i = 0 To students.Count - 1
            If students(i).StudentFullName = lstResults.SelectedItem.ToString() Then
                bsStudents.Position = i
                DisplayStudent()
                Exit For
            End If
        Next
    End Sub
    Private Sub lstFullTime_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstFullTime.SelectedIndexChanged
        For i = 0 To students.Count - 1
            If students(i).StudentFullName = lstFullTime.SelectedItem.ToString() Then
                bsStudents.Position = i
                DisplayStudent()
                Exit For
            End If
        Next

    End Sub
End Class
