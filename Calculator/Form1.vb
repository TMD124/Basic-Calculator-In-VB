Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim dbl1stNum As Double
        Dim dbl2stNum As Double
        Dim dblSumNum As Double
        Dim strCombo As String

        dbl1stNum = Val(txtNum1.Text)
        dbl2stNum = Val(txtNum2.Text)
        strCombo = cmbOperation.Text

        If strCombo = "Multiply" Then
            dblSumNum = dbl1stNum * dbl2stNum
        ElseIf strCombo = "Divide" Then
            dblSumNum = dbl1stNum / dbl2stNum
        ElseIf strCombo = "Plus" Then
            dblSumNum = dbl1stNum + dbl2stNum
        ElseIf strCombo = "Minus" Then
            dblSumNum = dbl1stNum - dbl2stNum
        End If
        lblAnswer.Text = dblSumNum
    End Sub
End Class
