Public Class Form1
    Private Sub btnSluiten_Click(sender As Object, e As EventArgs) Handles btnSluiten.Click
        End
    End Sub

    Private Sub btnDebug_Click(sender As Object, e As EventArgs) Handles btnDebug.Click

        For a As Single = 1 To 3 Step 0.5
            Debug.WriteLine(a)
        Next

    End Sub

    Private Sub btnTekstvak_Click(sender As Object, e As EventArgs) Handles btnTekstvak.Click
        For b As Double = 1 To 5 Step 0.2
            txtTekst.Text = txtTekst.Text & b.ToString & vbCrLf

        Next
    End Sub

    Private Sub btnNegatief_Click(sender As Object, e As EventArgs) Handles btnNegatief.Click
        For c As Integer = 100 To 1 Step -1
            txtTekst.Text = txtTekst.Text & c.ToString & vbCrLf
        Next
    End Sub

    Private Sub btnLussen_Click(sender As Object, e As EventArgs) Handles btnLussen.Click
        Dim a, b As Integer
        For a = 1 To 5
            For b = 1 To 10
                txtTekst.Text = txtTekst.Text & a.ToString & " - " & b.ToString & vbCrLf
            Next
        Next
    End Sub

    Private Sub btnOneindige_Click(sender As Object, e As EventArgs) Handles btnOneindige.Click
        Dim a, b As Integer
        For a = 1 To 5
            For b = 1 To 10
                txtTekst.Text = txtTekst.Text & a.ToString & " - " & b.ToString & vbCrLf
                b = 1
            Next
        Next
    End Sub
End Class
