Public Class Form1
    Private lbldelta As Object
    Private txt_a As Object
    Private txt_b As Object
    Private txt_c As Object
    Private lbl_pas As Object
    Private lbl_soldo As Object
    Private lbl_X1 As Object
    Private lbl_X2 As Object
    Private Sub RESOUDRE_Click(sender As Object, e As EventArgs)
        Dim A As Single
        Dim B As Single
        Dim C As Single
        A = CSng(txt_a.Text)
        B = CSng(txt_b.Text)
        C = CSng(txt_c.Text)
        Dim delta As Single
        delta = (B * B) - 4 * (A * C)
        lbldelta.Text = delta.ToString
        If (delta < 0) Then
            lbl_pas.Text = "pas de solutions réelles "
        Else
            If delta = 0 Then
                Dim x12 As Single
                x12 = (-B) / (2 * A)
                lbl_soldo.Text = x12.ToString
            Else
                MsgBox("il y a 2 solutions réelles")
                Dim X1 As Single
                Dim X2 As Single
                X1 = ((-B) - Math.Sqrt(delta) / 2 * A)
                X2 = ((-B) + Math.Sqrt(delta) / 2 * A)
                lbl_X1.Text = X1.ToString
                lbl_X2.Text = X2.ToString
            End If
        End If

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs)

    End Sub
End Class
