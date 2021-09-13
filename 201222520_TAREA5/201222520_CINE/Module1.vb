Imports System.Math
Module Module1
    Sub LimpiarE()
        Form1.TBCantidadE.Clear()
        Form1.CBXfuncion.Text = ""
        Form1.CBXcine.Text = ""
        Form1.CBXfuncion.Focus()
    End Sub

    Sub LimpiarV()
        Form1.LBFuncion.Items.Clear()
        Form1.LBCine.Items.Clear()
        Form1.LBEntradas.Items.Clear()
        Form1.LBSubtotal.Items.Clear()
        Form1.LBDescuento1.Items.Clear()
        Form1.LBDescuento2.Items.Clear()
        Form1.LBTotal.Items.Clear()
    End Sub

    Public INDICE As Byte = 0
    Public FUNCION(9) As String
    Public CINE(9) As String
    Public ENTRADAS(9) As Integer
    Public SUBTOTAL(9) As Double
    Public DESCUENTO1(9) As Double
    Public DESCUENTO2(9) As Double
    Public TOTAL(9) As Double

    Sub Resultados()
        Form1.LBFuncion.Items.Add(FUNCION(INDICE))
        Form1.LBCine.Items.Add(CINE(INDICE))
        Form1.LBEntradas.Items.Add(ENTRADAS(INDICE))
        Form1.LBSubtotal.Items.Add(SUBTOTAL(INDICE))
        Form1.LBDescuento1.Items.Add(DESCUENTO1(INDICE))
        Form1.LBDescuento2.Items.Add(DESCUENTO2(INDICE))
        Form1.LBTotal.Items.Add(TOTAL(INDICE))
    End Sub

    Public Desc1 As Double
    Public Function Descuent1(D1funcion As String, D1cine As String) As Double
        If (D1funcion = "Funcion 3" Or D1funcion = "Funcion 4") And (D1cine = "Cine B" Or D1cine = "Cine C") Then
            Desc1 = 0.055
        ElseIf (D1funcion = "Funcion 1") And (D1cine = "Cine B" Or D1cine = "Cine C") Then
            Desc1 = 0.03
        ElseIf (D1funcion = "Funcion 2") And (D1cine = "Cine A") Then
            Desc1 = 0.015
        Else Desc1 = 0
        End If
        Return Desc1
    End Function

    Public Desc2 As Double
    Public Function Descuent2(D2subtotal As Double) As Double
        If (D2subtotal >= 100) And (D2subtotal <= 300) Then
            Desc2 = 0.02
        ElseIf (D2subtotal >= 300) And (D2subtotal <= 500) Then
            Desc2 = 0.04
        ElseIf (D2subtotal >= 500) And (D2subtotal <= 1000) Then
            Desc2 = 0.06
        Else Desc2 = 0
        End If
        Return Desc2
    End Function
End Module
