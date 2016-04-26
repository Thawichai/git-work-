Public Class Form

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim money, vat, num As String
        money = NumericUpDown1.Text

        If money <= 10000 Then
            vat = 0
        ElseIf money <= 15000 Then
            vat = 7
        ElseIf money < 30000 Then
            vat = 15
        Else
            vat = 17
        End If

        num = money * vat / 100

        Label7.Text = num
        Label5.Text = vat

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
