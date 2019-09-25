Public Class Form1
    Dim students As New List(Of Student) From {
        New Student("Biff", "Arfus"),
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

    'Dim students() As Student = {
    '    New Student("Biff", "Arfus"),
    '    New Student("Becky", "Blue"),
    '    New Student("Simon", "Smith", 15),
    '    New Student("Fanny", "Fargo"),
    '    New Student("Pete", "Smith", 9),
    '    New Student("Bill", "Bailey"),
    '    New Student("John", "Long"),
    '    New Student("Van", "Hill", 36),
    '    New Student("Cindy", "Jones"),
    '    New Student("Marcy", "Michaels", 18)
    '}

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'students.Add(New Student("Biff", "Arfus"))
        'students.Add(New Student("Simon", "Smith", 15))
        'students.Add(New Student("Fanny", "Fargo"))
        'students.Add(New Student("Pete", "Smith", 9))
        'students.Add(New Student("Bill", "Bailey"))
        'students.Add(New Student("John", "Long"))
        'students.Add(New Student("Van", "Hill", 36))
        'students.Add(New Student("Cindy", "Jones"))
        'students.Add(New Student("Sean", "Childs"))
        'students.Add(New Student("Marcy", "Michaels", 18))
        bsStudents.DataSource = students
        lstResults.DisplayMember = "StudentFullName"
        dgvStudents.DataSource = bsStudents

        DisplayStudent()
    End Sub

    Private Sub DisplayStudent()
        'Dim intCntFT, intSumCurFT, intSumCurrent As Integer
        Dim intTotCur, intFTCnt As Integer ' Total current credit and count of full time students
        Dim dblAvgCurFT As Double ' Average full time credits.

        lblName.Text = bsStudents.Current.StudentFullName
        lblCurrent.Text = bsStudents.Current.CurrentCredits
        lblTotal.Text = bsStudents.Current.TotalCredits

        Dim fullTime = From s In students
                       Where s.CurrentCredits >= 12
                       Select s.StudentFullName

        'lstFullTime.DataSource = fullTime.ToArray()

        lstFullTime.Items.Clear()

        For Each s In fullTime
            lstFullTime.Items.Add(s)
        Next

        Dim credits = From s In students
                      Select s.CurrentCredits

        intTotCur = credits.Sum()
        intFTCnt = fullTime.Count()

        lblTotCur.Text = intTotCur
        lblFTCnt.Text = intFTCnt

        Dim ftCredits = From s In students
                        Where s.CurrentCredits >= 12
                        Select s.CurrentCredits

        If intFTCnt > 0 Then
            dblAvgCurFT = ftCredits.Sum() / intFTCnt
            lblAvgCurFT.Text = dblAvgCurFT
        End If
        'For Each s As Student In students
        '    If s.CurrentCredits >= 12 Then
        '        intCntFT += 1
        '        intSumCurFT += s.CurrentCredits
        '        lstFullTime.Items.Add(s.StudentFullName)
        '    End If
        '    intSumCurrent += s.CurrentCredits
        'Next

        'lblFTCnt.Text = intCntFT

        'If intCntFT > 0 Then
        '    lblAvgCurFT.Text = intSumCurFT / intCntFT
        'End If

        'lblTotCur.Text = intSumCurrent
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
        'Dim i As Integer

        'lstResults.Items.Clear()

        'For i = 0 To students.Count - 1
        '    If students(i).StudentLastName.ToUpper().Contains(txtName.Text.ToUpper()) Then
        '        stu = students(i)
        '        lstResults.Items.Add(stu.StudentFullName)
        '    End If
        'Next

        'If stu IsNot Nothing Then
        'Else
        '    MessageBox.Show("Not Found!")
        'End If

        Dim match = From s In students
                    Where s.StudentLastName.ToLower().Contains(txtName.Text.ToLower())

        If match.Any() Then
            Dim stu As Student
            stu = match.First() ' Get the first element
            bsStudents.Position = students.IndexOf(stu) ' Move to that element
            DisplayStudent()
            lstResults.DataSource = match.ToList()
        Else
            MessageBox.Show("Not found!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub lstResults_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstResults.SelectedIndexChanged
        Dim match = From s In students
                    Where s.StudentFullName.ToLower().Contains(lstResults.Text.ToLower())

        bsStudents.Position = students.IndexOf(match.First())
        DisplayStudent()
        'For i = 0 To students.Count - 1
        '    If students(i).StudentFullName = lstResults.SelectedItem.ToString() Then
        '        bsStudents.Position = i
        '        DisplayStudent()
        '        Exit For
        '    End If
        'Next
    End Sub
    Private Sub lstFullTime_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstFullTime.SelectedIndexChanged
        Dim match = From s In students
                    Where s.StudentFullName.ToLower().Contains(lstFullTime.Text.ToLower())

        bsStudents.Position = students.IndexOf(match.First())
        DisplayStudent()

        'For i = 0 To students.Count - 1
        '    If students(i).StudentFullName = lstFullTime.SelectedItem.ToString() Then
        '        bsStudents.Position = i
        '        DisplayStudent()
        '        Exit For
        '    End If
        'Next
    End Sub
End Class
