Module Module1

    Public INDICE As Byte = 0
    Public INSCRIPCIONES(7, 10) As String

    Public Const InscripcionB As Integer = 350
    Public Const InscripcionD As Integer = 450
    Public Const CuotaB As Integer = 250
    Public Const CuotaD As Integer = 350
    Sub LimpiarInfo()
        Form1.TBXNOMBRE.Clear()
        Form1.TBXCARNE.Clear()
        Form1.RBNBASICOS.Checked = 0
        Form1.RBNDIVERSIFICADO.Checked = 0
        Form1.CBXCARRERA.Text = ""
        Form1.CBXFORMADEPAGO.Text = ""
        Form1.TBXNOMBRE.Focus()
    End Sub

    Sub LimpiarTotales()
        Form1.TBXTOTALGEN.Clear()
        Form1.TBXTOTALEFEC.Clear()
        Form1.TBXTOTALTARJ.Clear()
        Form1.TBXTOTALTRANS.Clear()
        Form1.TBXTOTALDEP.Clear()
        Form1.TBXTOTALBAS.Clear()
        Form1.TBXTOTALDIV.Clear()
        Form1.TBXTOTALPER.Clear()
        Form1.TBXTOTALBACH.Clear()
        Form1.TBXTOTALELEC.Clear()
        Form1.TBXTOTALDISE.Clear()
    End Sub

    Sub LimpiarMatriz()
        Dim i As Byte, j As Byte

        Form1.DataGridView1.Rows.Clear()

        For i = 0 To 6
            For j = 0 To 9
                INSCRIPCIONES(i, j) = Nothing
            Next j
        Next i
        INDICE = 0
        MsgBox("LA MATRIZ SE HA LIMPIADO")
    End Sub

    Sub MostrarDatosMatriz()
        Dim i As Byte
        Form1.DataGridView1.Rows.Clear()

        For i = 0 To 6
            If (INSCRIPCIONES(i, 0) <> Nothing) Then
                Form1.DataGridView1.Rows.Add(INSCRIPCIONES(i, 0), INSCRIPCIONES(i, 1), INSCRIPCIONES(i, 2), INSCRIPCIONES(i, 3), INSCRIPCIONES(i, 4), INSCRIPCIONES(i, 5), INSCRIPCIONES(i, 6), INSCRIPCIONES(i, 7), INSCRIPCIONES(i, 8), INSCRIPCIONES(i, 9))
            Else
                Exit For
            End If
        Next i
    End Sub

    Sub Salir()
        If (MsgBox("DESEA SALIR", vbQuestion + vbYesNo, "MENSAJE DE SALIDA") = vbYes) Then
            Form1.Close()
        Else
            LimpiarInfo()
            LimpiarTotales()
            LimpiarMatriz()
        End If
    End Sub

    Sub MostrarTotales()
        Dim i As Byte
        Dim TotalGeneral As Double = 0
        Dim TotalEfectivo As Double = 0
        Dim TotalTarjeta As Double = 0
        Dim TotalTransferencia As Double = 0
        Dim TotalDeposito As Double = 0
        Dim TotalBasicos As Double = 0
        Dim TotalDiversificado As Double = 0
        Dim TotalPerito As Byte = 0
        Dim TotalBachillerato As Byte = 0
        Dim TotalElectronica As Byte = 0
        Dim TotalDiseño As Byte = 0

        For i = 0 To 6
            TotalGeneral = TotalGeneral + Val(INSCRIPCIONES(i, 9))

            If (Str(INSCRIPCIONES(i, 7) = "Efectivo")) Then
                TotalEfectivo = TotalEfectivo + Val(INSCRIPCIONES(i, 9))
            End If

            If (Str(INSCRIPCIONES(i, 7) = "Tarjeta de crédito")) Then
                TotalTarjeta = TotalTarjeta + Val(INSCRIPCIONES(i, 9))
            End If

            If (Str(INSCRIPCIONES(i, 7) = "Transferencia por ACH")) Then
                TotalTransferencia = TotalTransferencia + Val(INSCRIPCIONES(i, 9))
            End If

            If (Str(INSCRIPCIONES(i, 7) = "Depósito bancario")) Then
                TotalDeposito = TotalDeposito + Val(INSCRIPCIONES(i, 9))
            End If

            If (Str(INSCRIPCIONES(i, 2) = "Básicos")) Then
                TotalBasicos = TotalBasicos + Val(INSCRIPCIONES(i, 9))
            End If

            If (Str(INSCRIPCIONES(i, 2) = "Diversificado")) Then
                TotalDiversificado = TotalDiversificado + Val(INSCRIPCIONES(i, 9))
            End If

            If (Str(INSCRIPCIONES(i, 3) = "Perito contador")) Then
                TotalPerito = TotalPerito + 1
            End If

            If (Str(INSCRIPCIONES(i, 3) = "Bachillerato")) Then
                TotalBachillerato = TotalBachillerato + 1
            End If

            If (Str(INSCRIPCIONES(i, 3) = "Electrónica")) Then
                TotalElectronica = TotalElectronica + 1
            End If

            If (Str(INSCRIPCIONES(i, 3) = "Diseño gráfico")) Then
                TotalDiseño = TotalDiseño + 1
            End If

        Next i

        Form1.TBXTOTALGEN.Text = Math.Round(TotalGeneral, 2).ToString
        Form1.TBXTOTALEFEC.Text = Math.Round(TotalEfectivo, 2).ToString
        Form1.TBXTOTALTARJ.Text = Math.Round(TotalTarjeta, 2).ToString
        Form1.TBXTOTALTRANS.Text = Math.Round(TotalTransferencia, 2).ToString
        Form1.TBXTOTALDEP.Text = Math.Round(TotalDeposito, 2).ToString
        Form1.TBXTOTALBAS.Text = Math.Round(TotalBasicos, 2).ToString
        Form1.TBXTOTALDIV.Text = Math.Round(TotalDiversificado, 2).ToString
        Form1.TBXTOTALPER.Text = Str(TotalPerito)
        Form1.TBXTOTALBACH.Text = Str(TotalBachillerato)
        Form1.TBXTOTALELEC.Text = Str(TotalElectronica)
        Form1.TBXTOTALDISE.Text = Str(TotalDiseño)
    End Sub
End Module
