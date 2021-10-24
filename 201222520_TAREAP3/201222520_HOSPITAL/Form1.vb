Imports System.Math
Public Class Form1
    Private Sub LIMPIARESTADISTICASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARESTADISTICASToolStripMenuItem.Click
        Salir()
    End Sub

    Private Sub CALCULARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CALCULARToolStripMenuItem.Click
        If TBXnombre.Text = "" Then
            MsgBox("Ingrese el nombre", vbExclamation, "ERROR")
        ElseIf TBXnit.Text = "" Or IsNumeric(TBXnit.Text) = 0 Then
            MsgBox("Ingrese el número de NIT", vbExclamation, "ERROR")
        ElseIf TBXdias.Text = "" Or IsNumeric(TBXdias.Text) = 0 Then
            MsgBox("Ingrese la cantidad de días hospitalizado", vbExclamation, "ERROR")
        ElseIf TBXhonorarios.Text = "" Then
            MsgBox("Ingrese los honorarios del medico", vbExclamation, "ERROR")
        ElseIf CBXhabitacion.Text = "" Then
            MsgBox("Seleccione el tipo de habitación", vbExclamation, "ERROR")
        ElseIf CBXformapago.Text = "" Then
            MsgBox("Seleccione la forma de pago", vbExclamation, "ERROR")
        End If

        If VerificarRepetido() Then
        Else
            MsgBox("Número de NIT repetido, debe ingresar uno diferente")
            TBXnit.Clear()
            TBXnit.Focus()
        End If

        If (INDICE <= 5) Then
            MATRIZ(INDICE, 0) = TBXnombre.Text
            MATRIZ(INDICE, 1) = Str(Val(TBXnit.Text))
            MATRIZ(INDICE, 2) = Str(Val(TBXdias.Text))
            MATRIZ(INDICE, 3) = Str(Round(Val(TBXhonorarios.Text), 2))
            MATRIZ(INDICE, 4) = CBXhabitacion.SelectedItem
            MATRIZ(INDICE, 6) = CBXformapago.SelectedItem

            Select Case CBXhabitacion.SelectedItem
                Case "1. Habitación privada"
                    MATRIZ(INDICE, 5) = HabitacionPrivada
                    MATRIZ(INDICE, 7) = Str(Round((MATRIZ(INDICE, 2) * HabitacionPrivada) + MATRIZ(INDICE, 3), 2))
                Case "2. Semiprivada"
                    MATRIZ(INDICE, 5) = HabitacionSemiprivada
                    MATRIZ(INDICE, 7) = Str(Round((MATRIZ(INDICE, 2) * HabitacionSemiprivada) + MATRIZ(INDICE, 3), 2))
                Case "3. No privada"
                    MATRIZ(INDICE, 5) = HabitacionNoPrivada
                    MATRIZ(INDICE, 7) = Str(Round((MATRIZ(INDICE, 2) * HabitacionNoPrivada) + MATRIZ(INDICE, 3), 2))
            End Select

            Select Case CBXformapago.SelectedItem
                Case "Efectivo"
                    MATRIZ(INDICE, 8) = Str(Round(MATRIZ(INDICE, 7) * 0.1, 2))
                    MATRIZ(INDICE, 9) = 0
                    MATRIZ(INDICE, 10) = Str(Round(MATRIZ(INDICE, 7) - MATRIZ(INDICE, 8) + MATRIZ(INDICE, 9), 2))
                Case "Transferencia ACH"
                    MATRIZ(INDICE, 8) = Str(Round(MATRIZ(INDICE, 7) * 0.08, 2))
                    MATRIZ(INDICE, 9) = 0
                    MATRIZ(INDICE, 10) = Str(Round(MATRIZ(INDICE, 7) - MATRIZ(INDICE, 8) + MATRIZ(INDICE, 9), 2))
                Case "Depósito bancario"
                    MATRIZ(INDICE, 8) = Str(Round(MATRIZ(INDICE, 7) * 0.1, 2))
                    MATRIZ(INDICE, 9) = 0
                    MATRIZ(INDICE, 10) = Str(Round(MATRIZ(INDICE, 7) - MATRIZ(INDICE, 8) + MATRIZ(INDICE, 9), 2))
                Case "Tarjeta de crédito"
                    MATRIZ(INDICE, 8) = 0
                    MATRIZ(INDICE, 9) = Str(Round(MATRIZ(INDICE, 7) * 0.015, 2))
                    MATRIZ(INDICE, 10) = Str(Round(MATRIZ(INDICE, 7) - MATRIZ(INDICE, 8) + MATRIZ(INDICE, 9), 2))
                Case "Seguro Médico"
                    MATRIZ(INDICE, 8) = 0
                    MATRIZ(INDICE, 9) = 0
                    MATRIZ(INDICE, 10) = Str(Round(MATRIZ(INDICE, 7) - MATRIZ(INDICE, 8) + MATRIZ(INDICE, 9), 2))
            End Select
        End If

        INDICE = INDICE + 1
        LimpiarInfo()
        If (INDICE = 6) Then
            MsgBox("MATRIZ LLENA", vbExclamation, "IMPORTANTE")
        End If

    End Sub

    Private Sub MOSTRARENMATRIZToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MOSTRARENMATRIZToolStripMenuItem.Click
        MostrarDatosMatriz()
    End Sub

    Private Sub LIMPIARINFORMACIÓNToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LIMPIARINFORMACIÓNToolStripMenuItem1.Click
        LimpiarInfo()
    End Sub

    Private Sub LIMPIARESTADISTICASToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LIMPIARESTADISTICASToolStripMenuItem1.Click
        LimpiarEstadisticas()
    End Sub

    Private Sub LIMPIARMATRIZToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles LIMPIARMATRIZToolStripMenuItem2.Click
        LimpiarMatriz()
    End Sub

    Private Sub LIMPIARMATRIZToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARMATRIZToolStripMenuItem.Click
        MostrarEstadisticas()
    End Sub

    Private Sub CALCULARESTADISTICASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CALCULARESTADISTICASToolStripMenuItem.Click
        Dim existe As Boolean = True
        INDICE = 0
        While (INDICE <= 5) And (existe)
            If (MATRIZ(INDICE, 0) <> Nothing) Then
                If Str(MATRIZ(INDICE, 1) = Str(TBXconsultanit.Text)) Then
                    existe = False
                Else
                    INDICE = INDICE + 1
                End If
            Else
                Exit While
            End If
        End While

        If (existe) Then
            MsgBox("NIT no encontrado")
            TBXconsultanit.Focus()
        Else
            MsgBox("NIT Encontrado exitosamente")

            TBXnombre.Text = MATRIZ(INDICE, 0)
            TBXnit.Text = MATRIZ(INDICE, 1)
            TBXdias.Text = MATRIZ(INDICE, 2)
            TBXhonorarios.Text = MATRIZ(INDICE, 3)
            CBXhabitacion.Text = MATRIZ(INDICE, 4)
            CBXformapago.Text = MATRIZ(INDICE, 6)

            TBXconsultanit.Clear()
            DataGridView1.Rows.Clear()
            DataGridView1.Rows.Add(MATRIZ(INDICE, 0), MATRIZ(INDICE, 1), MATRIZ(INDICE, 2), MATRIZ(INDICE, 3), MATRIZ(INDICE, 4), MATRIZ(INDICE, 5), MATRIZ(INDICE, 6), MATRIZ(INDICE, 7), MATRIZ(INDICE, 8), MATRIZ(INDICE, 9), MATRIZ(INDICE, 10))
        End If
    End Sub
End Class
