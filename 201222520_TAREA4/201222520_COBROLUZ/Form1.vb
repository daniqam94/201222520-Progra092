Imports System.Math
Public Class Form1
    Private Sub LIMPIARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARToolStripMenuItem.Click
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

    Private Sub CALCULARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CALCULARToolStripMenuItem.Click
        If TextBox1.Text = "" Then
            MsgBox("Ingrese el nombre del cliente", vbExclamation, "ERROR")
        End If
        If TextBox2.Text = "" Then
            MsgBox("Ingrese el número de NIT", vbExclamation, "ERROR")
        End If
        If TextBox3.Text = "" Then
            MsgBox("Ingrese el saldo anterior", vbExclamation, "ERROR")
        End If
        If TextBox4.Text = "" Then
            MsgBox("Ingrese Consumo de KW-mes", vbExclamation, "ERROR")
        End If

        If (INDICE <= 10) Then
            Cliente(INDICE) = TextBox1.Text
            Servicio(INDICE) = ComboBox1.Text
            Tarifa(INDICE) = ComboBox2.Text
            SaldoAnterior(INDICE) = TextBox3.Text
        End If

        If (ComboBox1.Text = "Residencial") Then
            Select Case Val(TextBox4.Text)
                Case 1 To 100
                    PagoInicial(INDICE) = Round(Val(TextBox4.Text) * 0.99, 2)
                Case 101 To 300
                    PagoInicial(INDICE) = Round(Val(TextBox4.Text) * 1.2, 2)
                Case >= 301
                    PagoInicial(INDICE) = Round(Val(TextBox4.Text) * 3.0, 2)
            End Select
        End If

        If (ComboBox1.Text = "Industrial") Then
            Select Case Val(TextBox4.Text)
                Case 1 To 100
                    PagoInicial(INDICE) = Round(Val(TextBox4.Text) * 1.99, 2)
                Case 101 To 300
                    PagoInicial(INDICE) = Round(Val(TextBox4.Text) * 2.2, 2)
                Case >= 301
                    PagoInicial(INDICE) = Round(Val(TextBox4.Text) * 4.0, 2)
            End Select
        End If

        If Val(TextBox3.Text) > 0 Then
            Mora(INDICE) = Round(Val((TextBox3.Text) * 0.02), 2)
            PagoConMora(INDICE) = Round(Val(TextBox3.Text) + Mora(INDICE), 2)
        ElseIf Val(TextBox3.Text) <= 0 Then
            Mora(INDICE) = "No hay recargo por mora"
        End If

        Select Case ComboBox2.Text
            Case "Social"
                PagoParcial(INDICE) = Round(PagoInicial(INDICE) + PagoConMora(INDICE), 2)
                Descuento(INDICE) = Round(PagoInicial(INDICE) * 0.2, 2)
                PagoTotal(INDICE) = Round(PagoParcial(INDICE) - Descuento(INDICE), 2)

            Case "No Social"
                PagoParcial(INDICE) = Round(PagoInicial(INDICE) + PagoConMora(INDICE), 2)
                Descuento(INDICE) = Round(PagoInicial(INDICE) * 0.1, 2)
                PagoTotal(INDICE) = Round(PagoParcial(INDICE) - Descuento(INDICE), 2)
        End Select

        Resultados()
        INDICE = INDICE + 1

        If (INDICE = 11) Then
            MsgBox("VECTORES LLENOS")
        End If
        LimpiarE()
    End Sub

End Class
