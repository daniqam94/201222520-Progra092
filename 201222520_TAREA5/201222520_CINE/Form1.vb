Imports System.Math
Public Class Form1
    Private Sub BSalir_Click(sender As Object, e As EventArgs) Handles BSalir.Click
        If (MsgBox("DESEA SALIR", vbQuestion + vbYesNo, "MENSAJE DE SALIDA") = vbYes) Then
            End
        Else
            LimpiarE()
        End If
    End Sub

    Private Sub BLimpiarV_Click(sender As Object, e As EventArgs) Handles BLimpiarV.Click
        LimpiarV()
    End Sub

    Private Sub BLimpiarE_Click(sender As Object, e As EventArgs) Handles BLimpiarE.Click
        LimpiarE()
    End Sub

    Private Sub BAceptar_Click(sender As Object, e As EventArgs) Handles BAceptar.Click
        If TBCantidadE.Text = "" Then
            MsgBox("Ingrese la Cantidad de Entradas", vbExclamation, "ERROR")
        End If
        If CBXfuncion.Text = "" Then
            MsgBox("Ingrese la Función", vbExclamation, "ERROR")
        End If
        If CBXcine.Text = "" Then
            MsgBox("Ingrese el Cine", vbExclamation, "ERROR")
        End If

        If INDICE < 9 Then
            FUNCION(INDICE) = CBXfuncion.Text
            CINE(INDICE) = CBXcine.Text
            ENTRADAS(INDICE) = Val(TBCantidadE.Text)
            If CBXfuncion.Text = "Funcion 1" Then
                Select Case CBXcine.Text
                    Case "Cine A"
                        SUBTOTAL(INDICE) = Round((ENTRADAS(INDICE) * 30))
                    Case "Cine B"
                        SUBTOTAL(INDICE) = Round((ENTRADAS(INDICE) * 24))
                    Case "Cine C"
                        SUBTOTAL(INDICE) = Round((ENTRADAS(INDICE) * 35))
                End Select
            ElseIf CBXfuncion.Text = "Funcion 2" Then
                Select Case CBXcine.Text
                    Case "Cine A"
                        SUBTOTAL(INDICE) = Round((ENTRADAS(INDICE) * 35), 2)
                    Case "Cine B"
                        SUBTOTAL(INDICE) = Round((ENTRADAS(INDICE) * 34), 2)
                    Case "Cine C"
                        SUBTOTAL(INDICE) = Round((ENTRADAS(INDICE) * 40), 2)
                End Select

            ElseIf CBXfuncion.Text = "Funcion 3" Or CBXfuncion.Text = "Funcion 4" Then
                Select Case CBXcine.Text
                    Case "Cine A"
                        SUBTOTAL(INDICE) = Round((ENTRADAS(INDICE) * 40), 2)
                    Case "Cine B"
                        SUBTOTAL(INDICE) = Round((ENTRADAS(INDICE) * 44), 2)
                    Case "Cine C"
                        SUBTOTAL(INDICE) = Round((ENTRADAS(INDICE) * 50), 2)
                End Select
            End If
        End If

        DESCUENTO1(INDICE) = Round(SUBTOTAL(INDICE) * Descuent1(CBXfuncion.Text, CBXcine.Text), 2)
        DESCUENTO2(INDICE) = Round(SUBTOTAL(INDICE) * Descuent2(SUBTOTAL(INDICE)), 2)
        TOTAL(INDICE) = Round(SUBTOTAL(INDICE) - DESCUENTO1(INDICE) - DESCUENTO2(INDICE), 2)
        Resultados()
        INDICE = INDICE + 1

        If INDICE = 9 Then
            MsgBox("VECTORES LLENOS", vbExclamation, "ERROR")
        End If
    End Sub
End Class
