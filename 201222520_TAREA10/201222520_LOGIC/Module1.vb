Module Module1

    Public INDICE As Byte = 0

    Public NumeroDPI(7) As String
    Public NombreCliente(7) As String
    Public ValorArticulo(7) As Double
    Public CantidadMeses(7) As Integer
    Public TasaIntereses(7) As String
    Public MontoFinal(7) As Double

    Sub LimpiarInfo()
        Form1.TextBox1.Clear()
        Form1.TextBox2.Clear()
        Form1.TextBox3.Clear()
        Form1.textbox4.clear()
        Form1.TextBox1.Focus()
    End Sub

    Sub LimpiarVectores()
        Form1.DataGridView1.Rows.Clear()

        For INDICE = 0 To 6
            NumeroDPI(INDICE) = Nothing
            NombreCliente(INDICE) = Nothing
            ValorArticulo(INDICE) = Nothing
            CantidadMeses(INDICE) = Nothing
            TasaIntereses(INDICE) = Nothing
            MontoFinal(INDICE) = Nothing
        Next INDICE
    End Sub

    Sub MostrarDatosVectores()

        Form1.DataGridView1.Rows.Clear()
        For INDICE = 0 To 6

            If (NumeroDPI(INDICE) <> Nothing) Then
                Form1.DataGridView1.Rows.Add(NumeroDPI(INDICE), NombreCliente(INDICE), ValorArticulo(INDICE), CantidadMeses(INDICE), TasaIntereses(INDICE), MontoFinal(INDICE))
            Else
                Exit For
            End If
        Next INDICE
    End Sub
End Module
