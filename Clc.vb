Public Class Clc
    Dim A As String
    Dim B As String
    Dim op = ""
    Dim res As Integer

    Private Sub In1_TextChanged(sender As Object, e As EventArgs) Handles In1.TextChanged
        A = In1.Text
    End Sub

    Private Sub Plus_Click(sender As Object, e As EventArgs) Handles Plus.Click
        op = "+"
    End Sub

    Private Sub Minus_Click(sender As Object, e As EventArgs) Handles Minus.Click
        op = "-"
    End Sub

    Private Sub Mult_Click(sender As Object, e As EventArgs) Handles Mult.Click
        op = "*"
    End Sub

    Private Sub Div_Click(sender As Object, e As EventArgs) Handles Div.Click
        op = "/"
    End Sub

    Private Sub Eq_Click(sender As Object, e As EventArgs) Handles Eq.Click
        If IsNumeric(A) And IsNumeric(B) Then
            If op = "+" Then
                res = Integer.Parse(A) + Integer.Parse(B)
            ElseIf op = "-" Then
                res = Integer.Parse(A) - Integer.Parse(B)
            ElseIf op = "*" Then
                res = Integer.Parse(A) * Integer.Parse(B)
            ElseIf op = "/" Then
                res = Integer.Parse(A) / Integer.Parse(B)
            Else
                MessageBox.Show("veiller donner un operateur")

            End If

            Lb.Text = res.ToString()
        End If
    End Sub

    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click
        In1.Text = ""
        In2.Text = ""
        Lb.Text = ""
    End Sub

    Private Sub In2_TextChanged(sender As Object, e As EventArgs) Handles In2.TextChanged
        B = In2.Text

    End Sub

    Private Sub Lb_Click(sender As Object, e As EventArgs) Handles Lb.Click

    End Sub
End Class
