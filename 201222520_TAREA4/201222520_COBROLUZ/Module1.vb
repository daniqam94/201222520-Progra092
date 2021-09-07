Imports System.Math
Module Module1
    Sub LimpiarE()
        Form1.TextBox1.Clear()
        Form1.TextBox2.Clear()
        Form1.TextBox3.Clear()
        Form1.TextBox4.Clear()
        Form1.ComboBox1.Text = ""
        Form1.ComboBox2.Text = ""
        Form1.TextBox1.Focus()
    End Sub

    Public INDICE As Byte = 0

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

        INDICE = 0
    End Sub

    Public Cliente(11) As String
    Public Servicio(11) As String
    Public Tarifa(11) As String
    Public SaldoAnterior(11) As Double
    Public PagoInicial(11) As Double
    Public Mora(11) As Double
    Public PagoConMora(11) As Double
    Public PagoParcial(11) As Double
    Public Descuento(11) As Double
    Public PagoTotal(11) As Double

    Sub Resultados()
        Form1.ListBox1.Items.Add(Cliente(INDICE))
        Form1.ListBox2.Items.Add(Servicio(INDICE))
        Form1.ListBox3.Items.Add(Tarifa(INDICE))
        Form1.ListBox4.Items.Add(SaldoAnterior(INDICE))
        Form1.ListBox5.Items.Add(PagoInicial(INDICE))
        Form1.ListBox6.Items.Add(Mora(INDICE))
        Form1.ListBox7.Items.Add(PagoConMora(INDICE))
        Form1.ListBox8.Items.Add(PagoParcial(INDICE))
        Form1.ListBox9.Items.Add(Descuento(INDICE))
        Form1.ListBox10.Items.Add(PagoTotal(INDICE))
    End Sub
End Module
