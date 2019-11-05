Public Class Form1
    Dim students As New List(Of SWICEnrollee) From {
        New Student("Biff", "Arfus"),
        New Student("Simon", "Smith", 15),
        New Faculty("Fanny", "Fargo"),
        New Student("Pete", "Smith", 9),
        New Student("Bill", "Bailey"),
        New Student("John", "Long"),
        New Student("Van", "Hill", 36),
        New Student("Cindy", "Jones"),
        New CommEdStu("Sean", "Childs"),
        New Faculty("Marcy", "Michaels", 18)
    }

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        bsStudents.DataSource = students

        dgvStudents.DataSource = bsStudents

        lstResults.DisplayMember = "StudentFullName"

        DisplayStudent()
    End Sub

    Private Sub DisplayStudent()

        Dim intTotCur As Integer    'Total current credits
        Dim intFTCnt As Integer     'Count of FullTime students
        Dim dblAvgCurFT As Double   'Average Fulltime Credits

        lblName.Text = bsStudents.Current.StudentFullName
        lblCurrent.Text = bsStudents.Current.CurrentCredits
        lblTotal.Text = bsStudents.Current.TotalCredits

        Dim fulltime = From s In students
                       Where s.CurrentCredits >= 12
                       Select s.StudentFullName

        lstFullTime.Items.Clear()
        For Each s In fulltime
            lstFullTime.Items.Add(s)
        Next

        Dim credits = From s In students
                      Select s.CurrentCredits

        intTotCur = credits.Sum()
        intFTCnt = fulltime.Count

        lblTotCur.Text = intTotCur
        lblFTCnt.Text = intFTCnt

        Dim ftCredits = From s In students
                        Where s.CurrentCredits >= 12
                        Select s.CurrentCredits

        If intFTCnt > 0 Then
            dblAvgCurFT = ftCredits.Sum / intFTCnt
            lblAvgCurFT.Text = dblAvgCurFT
        End If

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

        Dim match = From s In students
                    Where s.StudentLastName.ToLower.Contains(txtName.Text.ToLower)

        If match.Any Then
            Dim stu As SWICEnrollee
            stu = match.First
            bsStudents.Position = students.IndexOf(stu)
            DisplayStudent()
            lstResults.DataSource = match.ToList
        Else
            MessageBox.Show("Not Found")
        End If
    End Sub

    Private Sub lstResults_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstResults.SelectedIndexChanged

        Dim match = From s In students
                    Where s.StudentFullName.ToLower.Contains(lstResults.Text.ToLower)

        bsStudents.Position = students.IndexOf(match.First)

        DisplayStudent()

    End Sub

    Private Sub lstFullTime_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstFullTime.SelectedIndexChanged


        Dim match = From s In students
                    Where s.StudentFullName.ToLower.Contains(lstFullTime.Text.ToLower)

        bsStudents.Position = students.IndexOf(match.First)

        DisplayStudent()


    End Sub

    Private Sub btnRaiseMax_Click(sender As Object, e As EventArgs) Handles btnRaiseMax.Click
        SWICEnrollee.MaxCredits += 3
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim newStu As New Form2
        newStu.ShowDialog()

        If newStu.stu IsNot Nothing Then
            bsStudents.Insert(0, newStu.stu)
            bsStudents.MoveFirst()
        End If


    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

        If bsStudents.Current IsNot Nothing Then
            bsStudents.RemoveCurrent()
        End If
    End Sub

    Private Sub bsStudents_CurrentChanged(sender As Object, e As EventArgs) Handles bsStudents.CurrentChanged
        DisplayStudent()
    End Sub
End Class
