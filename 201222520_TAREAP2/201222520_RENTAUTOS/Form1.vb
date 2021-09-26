Imports System.Math
Public Class Form1
    Private Sub LIMPIARENTRADASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARENTRADASToolStripMenuItem.Click
        LimpiarE()
    End Sub

    Private Sub LIMPIARVECTORESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARVECTORESToolStripMenuItem.Click
        LimpiarV()
    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        If (MsgBox("DESEA SALIR", vbQuestion + vbYesNo, "MENSAJE DE SALIDA") = vbYes) Then
            End
        Else
            LimpiarE()
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If (CheckBox1.Checked) Then
            TextBox4.Visible = True
            TextBox4.Focus()
        Else
            TextBox4.Clear()
            TextBox4.Visible = False
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If (CheckBox2.Checked) Then
            TextBox5.Visible = True
            TextBox5.Focus()
        Else
            TextBox5.Clear()
            TextBox5.Visible = False
        End If
    End Sub

    Private Sub CALCULARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CALCULARToolStripMenuItem.Click
        If TextBox1.Text = "" Then
            MsgBox("Ingrese el numero de NIT", vbExclamation, "ERROR")
        ElseIf TextBox2.Text = "" Then
            MsgBox("Ingrese la placa del auto", vbExclamation, "ERROR")
        ElseIf ComboBox1.Text = "" Then
            MsgBox("Seleccione la Marca del Vehiculo", vbExclamation, "ERROR")
        ElseIf TextBox3.Text = "" Then
            MsgBox("Ingrese la cantidad de dias a alquilar", vbExclamation, "ERROR")
        ElseIf CheckBox1.Checked = False And CheckBox2.Checked = False Then
            MsgBox("Seleccione el metodo de pago", vbExclamation, "ERROR")
        ElseIf Val(TextBox4.Text) + Val(TextBox5.Text) < 100 Or Val(TextBox4.Text) + Val(TextBox5.Text) > 100 Then
            MsgBox("El porcentaje de pago debe de ser del 100%", vbExclamation, "ERROR")
        End If

        If INDICE < 6 Then
            NIT(INDICE) = TextBox1.Text
            PLACA(INDICE) = TextBox2.Text
            MARCA(INDICE) = ComboBox1.Text
            CANTDIAS(INDICE) = Val(TextBox3.Text)
        End If

        Select Case ComboBox1.Text
            Case "Honda"
                SUBTOTAL(INDICE) = CANTDIAS(INDICE) * PrecioH
                CANTEFECTIVO(INDICE) = (Val(TextBox4.Text) / 100) * SUBTOTAL(INDICE)
                CANTTARJETA(INDICE) = (Val(TextBox5.Text) / 100) * SUBTOTAL(INDICE)
            Case "Mercedes Benz"
                SUBTOTAL(INDICE) = CANTDIAS(INDICE) * PrecioMB
                CANTEFECTIVO(INDICE) = (Val(TextBox4.Text) / 100) * SUBTOTAL(INDICE)
                CANTTARJETA(INDICE) = (Val(TextBox5.Text) / 100) * SUBTOTAL(INDICE)
            Case "Toyota"
                SUBTOTAL(INDICE) = CANTDIAS(INDICE) * PrecioT
                CANTEFECTIVO(INDICE) = (Val(TextBox4.Text) / 100) * SUBTOTAL(INDICE)
                CANTTARJETA(INDICE) = (Val(TextBox5.Text) / 100) * SUBTOTAL(INDICE)
            Case "Mazda"
                SUBTOTAL(INDICE) = CANTDIAS(INDICE) * PrecioM
                CANTEFECTIVO(INDICE) = (Val(TextBox4.Text) / 100) * SUBTOTAL(INDICE)
                CANTTARJETA(INDICE) = (Val(TextBox5.Text) / 100) * SUBTOTAL(INDICE)
        End Select


        DESCUENTO(INDICE) = FuncionDescuento()
        RECARGO(INDICE) = FuncionRecargo()
        PAGOFINAL(INDICE) = FuncionPagoFinal()
        Resultados()
        INDICE = INDICE + 1

        If INDICE = 9 Then
            MsgBox("VECTORES LLENOS", vbExclamation, "ERROR")
            LimpiarE()
        End If
    End Sub
End Class
