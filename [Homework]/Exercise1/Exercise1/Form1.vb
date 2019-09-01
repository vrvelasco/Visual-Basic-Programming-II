Public Class Form1
    Dim s As New Sphere(1)
    Dim t As New Tetrahedron()
    Dim c As New Cube(1)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshForm()
    End Sub

    Private Sub RefreshForm()
        ' Cube
        lblCSize.Text = c.Size.ToString("n2")
        lblCVolume.Text = c.Volume.ToString("n2")
        lblCArea.Text = c.SurfaceArea.ToString("n2")

        ' Sphere
        lblSSize.Text = s.Size.ToString("n2")
        lblSVolume.Text = s.Volume.ToString("n2")
        lblSArea.Text = s.SurfaceArea.ToString("n2")

        ' Tetra
        lblTSize.Text = t.Size.ToString("n2")
        lblTVolume.Text = t.Volume.ToString("n2")
        lblTArea.Text = t.SurfaceArea.ToString("n2")
    End Sub

    Private Sub BtnEnlarge_Click(sender As Object, e As EventArgs) Handles btnEnlarge.Click
        c.Enlarge(10)
        s.Enlarge(10)
        t.Enlarge(10)
        RefreshForm()
    End Sub

    Private Sub BtnNegative_Click(sender As Object, e As EventArgs) Handles btnNegative.Click
        Try
            c.Enlarge(-1)
            s.Enlarge(-1)
            t.Enlarge(-1)
            RefreshForm()
        Catch ex As Exception
            MessageBox.Show("The size has to be greater than zero.", "Invalid Size", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
