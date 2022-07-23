Public Class Form1
    Dim XorO As Boolean
    Dim pX As Integer
    Dim pO As Integer
    Dim move1 As Integer
    Private Sub dis_abled()
        btn1.Enabled = False
        btn2.Enabled = False
        btn3.Enabled = False
        btn4.Enabled = False
        btn5.Enabled = False
        btn6.Enabled = False
        btn7.Enabled = False
        btn8.Enabled = False
        btn9.Enabled = False

    End Sub
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        move1 += 1
        If move1 Mod 2 = 0 Then
            btn1.Text = "O"
            btn1.Enabled = False
            XorO = False
            If (btn1.Text = "O" And btn2.Text = "O" And btn3.Text = "O") Then
                btn1.BackColor = Color.DarkRed
                btn2.BackColor = Color.DarkRed
                btn3.BackColor = Color.DarkRed
                MessageBox.Show("The winner is player O")
                dis_abled()
                pO += 1
                Label5.Text = pO
            ElseIf (btn1.Text = "O" And btn4.Text = "O" And btn7.Text = "O") Then
                btn1.BackColor = Color.DarkRed
                btn4.BackColor = Color.DarkRed
                btn7.BackColor = Color.DarkRed
                MessageBox.Show("The winner is player O")
                dis_abled()
                pO += 1
                Label5.Text = pO
            ElseIf (btn1.Text = "O" And btn5.Text = "X" And btn9.Text = "O") Then
                btn1.BackColor = Color.DarkRed
                btn5.BackColor = Color.DarkRed
                btn9.BackColor = Color.DarkRed
                MessageBox.Show("The winner is player O")
                dis_abled()
                pO += 1
                Label5.Text = pO
            End If
        Else
            btn1.Text = "X"
            btn1.Enabled = False
            XorO = True
            If (btn1.Text = "X" And btn2.Text = "X" And btn3.Text = "X") Then
                btn1.BackColor = Color.DarkRed
                btn2.BackColor = Color.DarkRed
                btn3.BackColor = Color.DarkRed
                MessageBox.Show("The winner is player X")
                dis_abled()
                pX += 1
                Label4.Text = pX
            ElseIf (btn1.Text = "X" And btn4.Text = "X" And btn7.Text = "X") Then
                btn1.BackColor = Color.DarkRed
                btn4.BackColor = Color.DarkRed
                btn7.BackColor = Color.DarkRed
                MessageBox.Show("The winner is player X")
                dis_abled()
                pX += 1
                Label4.Text = pX
            ElseIf (btn1.Text = "X" And btn5.Text = "X" And btn9.Text = "X") Then
                btn1.BackColor = Color.DarkRed
                btn5.BackColor = Color.DarkRed
                btn9.BackColor = Color.DarkRed
                MessageBox.Show("The winner is player X")
                dis_abled()
                pX += 1
                Label4.Text = pX
            End If
        End If

    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        move1 += 1
        If move1 Mod 2 = 0 Then
            btn2.Text = "O"
            btn2.Enabled = False
            XorO = False
            If (btn1.Text = "O" And btn2.Text = "O" And btn3.Text = "O") Then
                btn1.BackColor = Color.DarkRed
                btn2.BackColor = Color.DarkRed
                btn3.BackColor = Color.DarkRed
                MessageBox.Show("The winner is player O")
                dis_abled()
                pO += 1
                Label5.Text = pO
            ElseIf (btn2.Text = "O" And btn5.Text = "O" And btn8.Text = "O") Then
                btn2.BackColor = Color.DarkRed
                btn5.BackColor = Color.DarkRed
                btn8.BackColor = Color.DarkRed
                MessageBox.Show("The winner is player O")
                dis_abled()
                pO += 1
                Label5.Text = pO

            End If
        Else
            btn2.Text = "X"
            btn2.Enabled = False
            XorO = True
            If (btn1.Text = "X" And btn2.Text = "X" And btn3.Text = "X") Then
                btn1.BackColor = Color.DarkRed
                btn2.BackColor = Color.DarkRed
                btn3.BackColor = Color.DarkRed
                MessageBox.Show("The winner is player X")
                dis_abled()
                pX += 1
                Label4.Text = pX
            ElseIf (btn2.Text = "X" And btn5.Text = "X" And btn8.Text = "X") Then
                btn2.BackColor = Color.DarkRed
                btn5.BackColor = Color.DarkRed
                btn8.BackColor = Color.DarkRed
                pX += 1
                Label4.Text = pX
            End If
        End If
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        move1 += 1
        If move1 Mod 2 = 0 Then
            btn3.Text = "O"
            btn3.Enabled = False
            XorO = False
            If (btn1.Text = "O" And btn2.Text = "O" And btn3.Text = "O") Then
                btn1.BackColor = Color.DarkRed
                btn2.BackColor = Color.DarkRed
                btn3.BackColor = Color.DarkRed
                MessageBox.Show("The winner is player O")
                dis_abled()
                pO += 1
                Label5.Text = pO
            ElseIf (btn3.Text = "O" And btn5.Text = "O" And btn9.Text = "O") Then
                btn3.BackColor = Color.DarkRed
                btn5.BackColor = Color.DarkRed
                btn9.BackColor = Color.DarkRed
                MessageBox.Show("The winner is player O")
                dis_abled()
                pO += 1
                Label5.Text = pO
            ElseIf (btn3.Text = "O" And btn5.Text = "O" And btn7.Text = "O") Then
                btn3.BackColor = Color.DarkRed
                btn5.BackColor = Color.DarkRed
                btn7.BackColor = Color.DarkRed
                MessageBox.Show("The winner is player O")
                dis_abled()
                pO += 1
                Label5.Text = pO
            End If
        Else
            btn3.Text = "X"
            btn3.Enabled = False
            XorO = True
            If (btn1.Text = "X" And btn2.Text = "X" And btn3.Text = "X") Then
                btn1.BackColor = Color.DarkRed
                btn2.BackColor = Color.DarkRed
                btn3.BackColor = Color.DarkRed
                MessageBox.Show("The winner is player X")
                dis_abled()
                pX += 1
                Label4.Text = pX
            ElseIf (btn3.Text = "X" And btn5.Text = "X" And btn7.Text = "X") Then
                btn3.BackColor = Color.DarkRed
                btn5.BackColor = Color.DarkRed
                btn7.BackColor = Color.DarkRed
                MessageBox.Show("The winner is player X")
                dis_abled()
                pX += 1
                Label4.Text = pX
            ElseIf (btn3.Text = "X" And btn6.Text = "X" And btn9.Text = "X") Then
                btn3.BackColor = Color.DarkRed
                btn6.BackColor = Color.DarkRed
                btn9.BackColor = Color.DarkRed
                pX += 1
                Label4.Text = pX
            End If
        End If
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        move1 += 1
        If move1 Mod 2 = 0 Then
            btn4.Text = "O"
            btn4.Enabled = False
            XorO = False
            If (btn4.Text = "O" And btn5.Text = "O" And btn6.Text = "O") Then
                btn4.BackColor = Color.DarkRed
                btn5.BackColor = Color.DarkRed
                btn6.BackColor = Color.DarkRed
                MessageBox.Show("The winner is player O")
                dis_abled()
                pO += 1
                Label5.Text = pO
            ElseIf (btn1.Text = "O" And btn4.Text = "O" And btn7.Text = "O") Then
                btn1.BackColor = Color.DarkRed
                btn4.BackColor = Color.DarkRed
                btn7.BackColor = Color.DarkRed
                MessageBox.Show("The winner is player O")
                dis_abled()
                pO += 1
                Label5.Text = pO

            End If
        Else
            btn4.Text = "X"
            btn4.Enabled = False
            XorO = True
            If (btn4.Text = "X" And btn5.Text = "X" And btn6.Text = "X") Then
                btn4.BackColor = Color.DarkRed
                btn5.BackColor = Color.DarkRed
                btn6.BackColor = Color.DarkRed
                MessageBox.Show("The winner is playerX")
                dis_abled()
                pX += 1
                Label4.Text = pX
            ElseIf (btn1.Text = "X" And btn4.Text = "X" And btn7.Text = "X") Then
                btn1.BackColor = Color.DarkRed
                btn4.BackColor = Color.DarkRed
                btn7.BackColor = Color.DarkRed
                MessageBox.Show("The winner is player X")
                dis_abled()
                pX += 1
                Label4.Text = pX

            End If
        End If
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        move1 += 1
        If move1 Mod 2 = 0 Then
            btn5.Text = "O"
            btn5.Enabled = False
            XorO = False
            If (btn4.Text = "O" And btn5.Text = "O" And btn6.Text = "O") Then
                btn4.BackColor = Color.DarkRed
                btn5.BackColor = Color.DarkRed
                btn6.BackColor = Color.DarkRed
                MessageBox.Show("The winner is player O")
                dis_abled()
                pO += 1
                Label5.Text = pO
            ElseIf (btn1.Text = "O" And btn5.Text = "O" And btn9.Text = "O") Then
                btn1.BackColor = Color.DarkRed
                btn5.BackColor = Color.DarkRed
                btn9.BackColor = Color.DarkRed
                MessageBox.Show("The winner is player O")
                dis_abled()
                pO += 1
                Label5.Text = pO
            ElseIf (btn2.Text = "O" And btn5.Text = "O" And btn8.Text = "O") Then
                btn2.BackColor = Color.DarkRed
                btn5.BackColor = Color.DarkRed
                btn8.BackColor = Color.DarkRed
                MessageBox.Show("The winner is player O")
                dis_abled()
                pO += 1
                Label5.Text = pO
            ElseIf (btn3.Text = "O" And btn5.Text = "O" And btn7.Text = "O") Then
                btn3.BackColor = Color.DarkRed
                btn5.BackColor = Color.DarkRed
                btn7.BackColor = Color.DarkRed
                MessageBox.Show("The winner is player O")
                dis_abled()
                pO += 1
                Label5.Text = pO
            End If
        Else
            btn5.Text = "X"
            btn5.Enabled = False
            XorO = True
            If (btn4.Text = "X" And btn5.Text = "X" And btn6.Text = "X") Then
                btn4.BackColor = Color.DarkRed
                btn5.BackColor = Color.DarkRed
                btn6.BackColor = Color.DarkRed
                MessageBox.Show("The winner is player X")
                dis_abled()
                pX += 1
                Label4.Text = pX
            ElseIf (btn1.Text = "X" And btn5.Text = "X" And btn9.Text = "X") Then
                btn1.BackColor = Color.DarkRed
                btn5.BackColor = Color.DarkRed
                btn9.BackColor = Color.DarkRed
                MessageBox.Show("The winner is player X")
                dis_abled()
                pX += 1
                Label4.Text = pX
            ElseIf (btn2.Text = "X" And btn5.Text = "X" And btn8.Text = "X") Then
                btn2.BackColor = Color.DarkRed
                btn5.BackColor = Color.DarkRed
                btn8.BackColor = Color.DarkRed
                MessageBox.Show("The winner is player X")
                dis_abled()
                pX += 1
                Label4.Text = pX
            ElseIf (btn3.Text = "X" And btn5.Text = "X" And btn7.Text = "X") Then
                btn3.BackColor = Color.DarkRed
                btn5.BackColor = Color.DarkRed
                btn7.BackColor = Color.DarkRed
                MessageBox.Show("The winner is player X")
                dis_abled()
                pX += 1
                Label4.Text = pX
            End If
        End If
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        move1 += 1
        If move1 Mod 2 = 0 Then
            btn6.Text = "O"
            btn6.Enabled = False
            XorO = False
            If (btn4.Text = "O" And btn5.Text = "O" And btn6.Text = "O") Then
                btn4.BackColor = Color.DarkRed
                btn5.BackColor = Color.DarkRed
                btn6.BackColor = Color.DarkRed
                MessageBox.Show("The winner is player O")
                dis_abled()
                pO += 1
                Label5.Text = pO

            ElseIf (btn3.Text = "O" And btn9.Text = "O" And btn6.Text = "O") Then
                btn2.BackColor = Color.DarkRed
                btn9.BackColor = Color.DarkRed
                btn6.BackColor = Color.DarkRed
                MessageBox.Show("The winner is player O")
                dis_abled()
                pO += 1
                Label5.Text = pO
            End If
        Else
            btn6.Text = "X"
            btn6.Enabled = False
            XorO = True
            If (btn4.Text = "X" And btn5.Text = "X" And btn6.Text = "X") Then
                btn4.BackColor = Color.DarkRed
                btn5.BackColor = Color.DarkRed
                btn6.BackColor = Color.DarkRed
                MessageBox.Show("The winner is player X")
                dis_abled()
                pX += 1
                Label4.Text = pX
            ElseIf (btn3.Text = "X" And btn9.Text = "X" And btn6.Text = "X") Then
                btn3.BackColor = Color.DarkRed
                btn9.BackColor = Color.DarkRed
                btn6.BackColor = Color.DarkRed
                MessageBox.Show("The winner is player X")
                dis_abled()
                pX += 1
                Label4.Text = pX
            End If
        End If

    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        move1 += 1
        If move1 Mod 2 = 0 Then
            btn7.Text = "O"
            btn7.Enabled = False
            XorO = False
            If (btn1.Text = "O" And btn4.Text = "O" And btn7.Text = "O") Then
                btn1.BackColor = Color.DarkRed
                btn4.BackColor = Color.DarkRed
                btn7.BackColor = Color.DarkRed
                MessageBox.Show("The winner is player O")
                dis_abled()
                pO += 1
                Label5.Text = pO

            ElseIf (btn7.Text = "O" And btn8.Text = "O" And btn9.Text = "O") Then
                btn7.BackColor = Color.DarkRed
                btn8.BackColor = Color.DarkRed
                btn9.BackColor = Color.DarkRed
                MessageBox.Show("The winner is player O")
                dis_abled()
                pO += 1
                Label5.Text = pO
            ElseIf (btn3.Text = "O" And btn5.Text = "O" And btn7.Text = "O") Then
                btn3.BackColor = Color.DarkRed
                btn5.BackColor = Color.DarkRed
                btn7.BackColor = Color.DarkRed
                MessageBox.Show("The winner is player O")
                dis_abled()
                pO += 1
                Label5.Text = pO
            End If
        Else
            btn7.Text = "X"
            btn7.Enabled = False
            XorO = True
            If (btn1.Text = "X" And btn4.Text = "X" And btn7.Text = "X") Then
                btn1.BackColor = Color.DarkRed
                btn4.BackColor = Color.DarkRed
                btn7.BackColor = Color.DarkRed
                MessageBox.Show("The winner is player X")
                dis_abled()
                pX += 1
                Label4.Text = pX

            ElseIf (btn7.Text = "X" And btn8.Text = "X" And btn9.Text = "X") Then
                btn7.BackColor = Color.DarkRed
                btn8.BackColor = Color.DarkRed
                btn9.BackColor = Color.DarkRed
                MessageBox.Show("The winner is player X")
                dis_abled()
                pX += 1
                Label4.Text = pX
            ElseIf (btn3.Text = "X" And btn5.Text = "X" And btn7.Text = "X") Then
                btn3.BackColor = Color.DarkRed
                btn5.BackColor = Color.DarkRed
                btn7.BackColor = Color.DarkRed
                MessageBox.Show("The winner is player X")
                dis_abled()
                pX += 1
                Label4.Text = pX
            End If
        End If
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        move1 += 1
        If move1 Mod 2 = 0 Then
            btn8.Text = "O"
            btn8.Enabled = False
            XorO = False
            If (btn2.Text = "O" And btn5.Text = "O" And btn8.Text = "O") Then
                btn2.BackColor = Color.DarkRed
                btn5.BackColor = Color.DarkRed
                btn8.BackColor = Color.DarkRed
                MessageBox.Show("The winner is player O")
                dis_abled()
                pO += 1
                Label5.Text = pO

            ElseIf (btn7.Text = "O" And btn8.Text = "O" And btn9.Text = "O") Then
                btn7.BackColor = Color.DarkRed
                btn8.BackColor = Color.DarkRed
                btn9.BackColor = Color.DarkRed
                MessageBox.Show("The winner is player O")
                dis_abled()
                pO += 1
                Label5.Text = pO
            End If
        Else
            btn8.Text = "X"
            btn8.Enabled = False
            XorO = True
            If (btn2.Text = "X" And btn5.Text = "X" And btn8.Text = "X") Then
                btn2.BackColor = Color.DarkRed
                btn5.BackColor = Color.DarkRed
                btn8.BackColor = Color.DarkRed
                MessageBox.Show("The winner is player X")
                dis_abled()
                pX += 1
                Label4.Text = pX

            ElseIf (btn7.Text = "X" And btn8.Text = "X" And btn9.Text = "X") Then
                btn7.BackColor = Color.DarkRed
                btn8.BackColor = Color.DarkRed
                btn9.BackColor = Color.DarkRed
                MessageBox.Show("The winner is player X")
                dis_abled()
                pX += 1
                Label4.Text = pX
            End If
        End If
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        move1 += 1
        If move1 Mod 2 = 0 Then
            btn9.Text = "O"
            btn9.Enabled = False
            XorO = False
            If (btn3.Text = "O" And btn6.Text = "O" And btn9.Text = "O") Then
                btn3.BackColor = Color.DarkRed
                btn6.BackColor = Color.DarkRed
                btn9.BackColor = Color.DarkRed
                MessageBox.Show("The winner is player O")
                dis_abled()
                pO += 1
                Label5.Text = pO

            ElseIf (btn7.Text = "O" And btn8.Text = "O" And btn9.Text = "O") Then
                btn7.BackColor = Color.DarkRed
                btn8.BackColor = Color.DarkRed
                btn9.BackColor = Color.DarkRed
                MessageBox.Show("The winner is playerO")
                dis_abled()
                pO += 1
                Label5.Text = pO
            ElseIf (btn1.Text = "O" And btn5.Text = "O" And btn9.Text = "O") Then
                btn1.BackColor = Color.DarkRed
                btn5.BackColor = Color.DarkRed
                btn9.BackColor = Color.DarkRed
                MessageBox.Show("The winner is player O")
                dis_abled()
                pO += 1
                Label5.Text = pO
            End If
        Else
            btn9.Text = "X"
            btn9.Enabled = False
            XorO = True
            MessageBox.Show(move1)
            If (btn3.Text = "X" And btn6.Text = "X" And btn9.Text = "X") Then
                btn3.BackColor = Color.DarkRed
                btn6.BackColor = Color.DarkRed
                btn9.BackColor = Color.DarkRed
                pX += 1
                Label4.Text = pX

            ElseIf (btn7.Text = "X" And btn8.Text = "X" And btn9.Text = "X") Then
                btn7.BackColor = Color.DarkRed
                btn8.BackColor = Color.DarkRed
                btn9.BackColor = Color.DarkRed
                MessageBox.Show("The winner is player X")
                dis_abled()
                pX += 1
                Label4.Text = pX
            ElseIf (btn1.Text = "X" And btn5.Text = "O" And btn9.Text = "X") Then
                btn1.BackColor = Color.DarkRed
                btn5.BackColor = Color.DarkRed
                btn9.BackColor = Color.DarkRed
                MessageBox.Show("The winner is player X")
                dis_abled()
                pX += 1
                Label4.Text = pX
            End If
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim move1 As Integer = 0

        btn1.Text = " "
        btn2.Text = " "
        btn3.Text = " "
        btn4.Text = " "
        btn5.Text = " "
        btn6.Text = " "
        btn7.Text = " "
        btn8.Text = " "
        btn9.Text = " "

        btn1.Enabled = True
        btn2.Enabled = True
        btn3.Enabled = True
        btn4.Enabled = True
        btn5.Enabled = True
        btn6.Enabled = True
        btn7.Enabled = True
        btn8.Enabled = True
        btn9.Enabled = True

        btn1.BackColor = Color.Blue
        btn2.BackColor = Color.Blue
        btn3.BackColor = Color.Blue
        btn4.BackColor = Color.Blue
        btn5.BackColor = Color.Blue
        btn6.BackColor = Color.Blue
        btn7.BackColor = Color.Blue
        btn8.BackColor = Color.Blue
        btn9.BackColor = Color.Blue

    End Sub
End Class
