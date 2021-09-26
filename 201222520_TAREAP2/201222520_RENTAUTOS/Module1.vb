Imports System.Math
Module Module1
    Sub LimpiarE()
        Form1.TextBox1.Clear()
        Form1.TextBox2.Clear()
        Form1.TextBox3.Clear()
        Form1.TextBox4.Clear()
        Form1.TextBox5.Clear()
        Form1.ComboBox1.Text = ""
        Form1.CheckBox1.Checked = 0
        Form1.CheckBox2.Checked = False
        Form1.TextBox1.Focus()
    End Sub

    Sub LimpiarV()
        Form1.ListBox1.Items.Clear()
        Form1.ListBox2.Items.Clear()
        Form1.ListBox3.Items.Clear()
        Form1.ListBox4.Items.Clear()
        Form1.ListBox5.Items.Clear()
        Form1.ListBox6.Items.Clear()
        Form1.ListBox7.Items.Clear()
        Form1.ListBox8.Items.Clear()
        Form1.ListBox9.Items.Clear()
        Form1.ListBox10.Items.Clear()
    End Sub

    Public INDICE As Byte = 0
    Public NIT(6) As String
    Public PLACA(6) As String
    Public MARCA(6) As String
    Public CANTDIAS(6) As Integer
    Public SUBTOTAL(6) As Double
    Public CANTEFECTIVO(6) As Double
    Public CANTTARJETA(6) As Double
    Public DESCUENTO(6) As Double
    Public RECARGO(6) As Double
    Public PAGOFINAL(6) As Double

    Public Const PrecioH = 250
    Public Const PrecioMB = 450
    Public Const PrecioT = 325
    Public Const PrecioM = 300

    Sub Resultados()
        Form1.ListBox1.Items.Add(NIT(INDICE))
        Form1.ListBox2.Items.Add(PLACA(INDICE))
        Form1.ListBox3.Items.Add(MARCA(INDICE))
        Form1.ListBox4.Items.Add(CANTDIAS(INDICE))
        Form1.ListBox5.Items.Add(SUBTOTAL(INDICE))
        Form1.ListBox6.Items.Add(CANTEFECTIVO(INDICE))
        Form1.ListBox7.Items.Add(CANTTARJETA(INDICE))
        Form1.ListBox8.Items.Add(DESCUENTO(INDICE))
        Form1.ListBox9.Items.Add(RECARGO(INDICE))
        Form1.ListBox10.Items.Add(PAGOFINAL(INDICE))
    End Sub

    Public Function FuncionDescuento() As Double
        Dim FDescuento As Double

        If Form1.CheckBox1.Checked = True And Val(Form1.TextBox4.Text) = 100 Then
            FDescuento = DESCUENTO(INDICE)
            FDescuento = SUBTOTAL(INDICE) * 0.05
            Return FDescuento
        Else
            FDescuento = 0
            Return FDescuento
        End If
    End Function

    Public Function FuncionRecargo() As Double
        Dim FRecargo As Double

        If Form1.CheckBox2.Checked = True And Val(Form1.TextBox5.Text) = 100 Then
            FRecargo = RECARGO(INDICE)
            FRecargo = SUBTOTAL(INDICE) * 0.025
            Return FRecargo
        Else
            FRecargo = 0
            Return FRecargo
        End If
    End Function

    Public Function FuncionPagoFinal() As Double
        Dim Total As Double
        Total = PAGOFINAL(INDICE)
        Total = SUBTOTAL(INDICE) - DESCUENTO(INDICE) + RECARGO(INDICE)
        Return Total
    End Function

End Module
