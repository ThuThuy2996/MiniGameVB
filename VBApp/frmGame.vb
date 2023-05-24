Public Class frmGame
    Dim Rs, a, b, c, d As Integer
    Dim Goal As Integer
    Dim count As Integer

    Private Sub btn_Reset_Click(sender As Object, e As EventArgs) Handles btn_Reset.Click
        Dim result As DialogResult = MessageBox.Show("リセットしてもよろしいですか", "確認", MessageBoxButtons.YesNo)

        If result = DialogResult.No Then
            MessageBox.Show("いいえ")
        ElseIf result = DialogResult.Yes Then
            MessageBox.Show("はい")
            btn_Spin.Enabled = True
            Goal = 0
            lbl_Sum.Text = String.Format("¥{0}", Goal.ToString())
            lbl_Notic.Visible = False
            btn_Reset.Visible = False
        End If

    End Sub

    Private Sub btn_Spin_Click(sender As Object, e As EventArgs) Handles btn_Spin.Click
        If Timer1.Enabled = False Then
            Timer1.Enabled = True
            count += 1
        End If
    End Sub

    Private Function RndImage(val As Integer) As Image
        Select Case val
            Case 1
                Return My.Resources.Jisoo
            Case 2
                Return My.Resources.Roses
            Case 3
                Return My.Resources.Jennie
            Case 4
                Return My.Resources.Lisa
        End Select
    End Function

    Private Function CalcGoal(a As Integer, b As Integer, c As Integer, d As Integer) As Integer
        Dim result = 0
        If a = b And b = c And c = d Then
            result = 100
        ElseIf (a = b AndAlso b = c) OrElse (a = c AndAlso c = d) OrElse (b = c AndAlso c = d) Then
            result = 50
        ElseIf a = b Or a = c Or a = d Or b = c Or b = d Or c = d Then
            result = 10
        Else
            result = -10
        End If
        Return result
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Rs += 10
        If Rs < 100 Then
            a = Int(1 + Rnd() * 4)
            b = Int(1 + Rnd() * 4)
            c = Int(1 + Rnd() * 4)
            d = Int(1 + Rnd() * 4)

            ptbA.BackgroundImage = RndImage(a)
            ptbB.BackgroundImage = RndImage(b)
            ptbC.BackgroundImage = RndImage(c)
            ptbD.BackgroundImage = RndImage(d)
        Else
            Timer1.Enabled = False
            Rs = 0
            Dim result = CalcGoal(a, b, c, d)
            Goal += result
            If result > 0 Then
                MessageBox.Show(String.Format("素晴らしい ！ {0}円勝ちました", result.ToString()))
            Else
                MessageBox.Show("10円引かれます！ 次回の幸運を祈ります")
            End If
            lbl_Sum.Text = String.Format("¥{0}", Goal.ToString())
            If count > 9 Then
                btn_Spin.Enabled = False
                lbl_Notic.Visible = True
                btn_Reset.Visible = True
            End If
        End If
    End Sub
End Class
