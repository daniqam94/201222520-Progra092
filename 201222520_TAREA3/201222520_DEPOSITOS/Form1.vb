
Imports System.Math
Public Class Form1
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles SALIR.Click
        If (MsgBox("DESEA SALIR", vbQuestion + vbYesNo, "MENSAJE DE SALIDA") = vbYes) Then
            Me.Close()
        Else limpiar()
        End If
    End Sub

    Private Sub LIMP_Click(sender As Object, e As EventArgs) Handles LIMP.Click
        limpiar()
    End Sub

    Private Sub CALC_Click(sender As Object, e As EventArgs) Handles CALC.Click

        Dim Res1, Res2, ResF As Double
        Res1 = Val(CHEPC.Text) + Val(CHEOBC.Text) + Val(EFECC.Text) + Val(SALDA.Text)
        Res2 = Val(SALDA.Text)

        If AHO.Checked = True Then
            Select Case Res1
                Case 1 To 1000.99
                    ResF = (Val(Res1) * 0.015) + Val(Res1)
                Case 1001 To 5000.99
                    ResF = (Val(Res1) * 0.025) + Val(Res1)
                Case 5001 To 15000.99
                    ResF = (Val(Res1) * 0.075) + Val(Res1)
                Case >= 15001
                    ResF = (Val(Res1) * 0.1) + Val(Res1)
            End Select
        ElseIf MONP.Checked = True Then
            Select Case Res2
                Case 1 To 1000.99
                    ResF = (Val(Res2) * 0.025) + Val(Res2) + Val(CHEPC.Text) + Val(CHEOBC.Text) + Val(EFECC.Text)
                Case 1001 To 15000.99
                    ResF = (Val(Res2) * 0.03) + Val(Res2) + Val(CHEPC.Text) + Val(CHEOBC.Text) + Val(EFECC.Text)
                Case >= 15001
                    ResF = (Val(Res2) * 0.045) + Val(Res2) + Val(CHEPC.Text) + Val(CHEOBC.Text) + Val(EFECC.Text)
            End Select
        ElseIf MON.Checked = True Then
            ResF = Val(Res2) + Val(CHEPC.Text) + Val(CHEOBC.Text) + Val(EFECC.Text)
        End If

        SALDF.Text = Str(Round(ResF, 2))
    End Sub

    Private Sub CHEP_CheckedChanged(sender As Object, e As EventArgs) Handles CHEP.CheckedChanged

        If (CHEP.Checked) Then
            CHEPC.Visible = True
            CHEPC.Focus()
        Else
            CHEPC.Clear()
            CHEPC.Visible = False
        End If
    End Sub

    Private Sub CHEOB_CheckedChanged(sender As Object, e As EventArgs) Handles CHEOB.CheckedChanged

        If (CHEOB.Checked) Then
            CHEOBC.Visible = True
            CHEOBC.Focus()
        Else
            CHEOBC.Clear()
            CHEOBC.Visible = False
        End If
    End Sub

    Private Sub EFEC_CheckedChanged(sender As Object, e As EventArgs) Handles EFEC.CheckedChanged

        If (EFEC.Checked) Then
            EFECC.Visible = True
            EFECC.Focus()
        Else
            EFECC.Clear()
            EFECC.Visible = False
        End If
    End Sub
End Class
