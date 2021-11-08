Imports System.Math
Public Class Form1
    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        If (MsgBox("DESEA SALIR", vbQuestion + vbYesNo, "MENSAJE DE SALIDA") = vbYes) Then
            End
        Else
            LimpiarInfo()
            LimpiarVectores()
        End If
    End Sub

    Private Sub LIMPIARVECTORESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARVECTORESToolStripMenuItem.Click
        LimpiarVectores()
    End Sub

    Private Sub LIMPIARENTRADASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARENTRADASToolStripMenuItem.Click
        LimpiarInfo()
    End Sub

    Private Sub OPERARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OPERARToolStripMenuItem.Click
        If (INDICE < 7) Then
            If TextBox1.Text <> "" Then
                NumeroDPI(INDICE) = TextBox1.Text
            Else
                MsgBox("Debe ingresar el número de DPI")
            End If

            If TextBox2.Text <> "" Then
                NombreCliente(INDICE) = TextBox2.Text
            Else
                MsgBox("Debe ingresar el nombre del cliente")
            End If

            If TextBox3.Text <> "" Then
                ValorArticulo(INDICE) = Round(Val(TextBox3.Text), 2)
            Else
                MsgBox("Debe ingresar el valor del artículo vendido")
            End If

            If TextBox4.Text <> "" Then
                CantidadMeses(INDICE) = TextBox4.Text
            Else
                MsgBox("Debe ingresar la cantidad de meses a pagar")
            End If
        End If


        If TextBox4.Text = 12 And TextBox3.Text > 8000 Then
            TasaIntereses(INDICE) = 0.02
        ElseIf TextBox4.Text > 12 And TextBox4.Text <= 24 Then
            TasaIntereses(INDICE) = 0.045
        ElseIf TextBox4.Text > 24 And TextBox4.Text <= 36 Then
            TasaIntereses(INDICE) = 0.055
        ElseIf TextBox4.Text >= 36 Then
            TasaIntereses(INDICE) = 0.062
        ElseIf TextBox4.Text <= 12 Then
            TasaIntereses(INDICE) = 0.03
        End If

        MontoFinal(INDICE) = Round(Val(ValorArticulo(INDICE) + (TasaIntereses(INDICE) * CantidadMeses(INDICE))), 2)

        INDICE = INDICE + 1
        LimpiarInfo()
        If (INDICE = 7) Then
            MsgBox("MATRIZ LLENA", vbExclamation, "IMPORTANTE")
        End If
    End Sub

    Private Sub MOSTRARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MOSTRARToolStripMenuItem.Click
        MostrarDatosVectores()
    End Sub

    Private Sub ORDENARDESCENDENTEMENTEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ORDENARDESCENDENTEMENTEToolStripMenuItem.Click
        DataGridView1.Sort(Column1, System.ComponentModel.ListSortDirection.Descending)
    End Sub
End Class
