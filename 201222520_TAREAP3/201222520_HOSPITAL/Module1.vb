Imports System.Math
Module Module1

    Public MATRIZ(6, 11) As String
    Public INDICE As Byte = 0

    Public Const HabitacionPrivada As Integer = 350
    Public Const HabitacionSemiprivada As Integer = 250
    Public Const HabitacionNoPrivada As Integer = 150

    Sub LimpiarInfo()
        Form1.TBXnombre.Clear()
        Form1.TBXnit.Clear()
        Form1.TBXdias.Clear()
        Form1.TBXhonorarios.Clear()
        Form1.CBXhabitacion.Text = ""
        Form1.CBXformapago.Text = ""
        Form1.TBXnombre.Focus()
    End Sub

    Sub LimpiarEstadisticas()
        Form1.TBXestadistica1.Clear()
        Form1.TBXestadistica2.Clear()
        Form1.TBXestadistica3.Clear()
    End Sub

    Sub Salir()
        If (MsgBox("DESEA SALIR", vbQuestion + vbYesNo, "MENSAJE DE SALIDA") = vbYes) Then
            Form1.Close()
        Else
            LimpiarInfo()
            LimpiarEstadisticas()
            LimpiarMatriz()
        End If
    End Sub

    Sub LimpiarMatriz()
        Form1.DataGridView1.Rows.Clear()

        INDICE = 0

        While (INDICE <= 5)
            MATRIZ(INDICE, 0) = Nothing
            MATRIZ(INDICE, 1) = Nothing
            MATRIZ(INDICE, 2) = Nothing
            MATRIZ(INDICE, 3) = Nothing
            MATRIZ(INDICE, 4) = Nothing
            MATRIZ(INDICE, 5) = Nothing
            MATRIZ(INDICE, 6) = Nothing
            MATRIZ(INDICE, 7) = Nothing
            MATRIZ(INDICE, 8) = Nothing
            MATRIZ(INDICE, 9) = Nothing
            MATRIZ(INDICE, 10) = Nothing
            INDICE = INDICE + 1
        End While
    End Sub

    Public Function VerificarRepetido() As Boolean
        Dim encontrado As Boolean = True
        INDICE = 0
        VerificarRepetido = True

        While (INDICE <= 5) And (encontrado)

            If (MATRIZ(INDICE, 0) <> Nothing) Then

                If (MATRIZ(INDICE, 1) = Val(Form1.TBXnit.Text)) Then
                    VerificarRepetido = encontrado = False
                    Return VerificarRepetido
                Else
                    INDICE = INDICE + 1
                End If
            Else
                Exit While
            End If
        End While
        If (encontrado) Then
            Return VerificarRepetido
        End If
    End Function

    Sub MostrarDatosMatriz()
        Dim i As Byte
        Form1.DataGridView1.Rows.Clear()

        For i = 0 To 5
            If (MATRIZ(i, 0) <> Nothing) Then
                Form1.DataGridView1.Rows.Add(MATRIZ(i, 0), MATRIZ(i, 1), MATRIZ(i, 2), MATRIZ(i, 3), MATRIZ(i, 4), MATRIZ(i, 5), MATRIZ(i, 6), MATRIZ(i, 7), MATRIZ(i, 8), MATRIZ(i, 9), MATRIZ(i, 10))
            Else
                Exit For
            End If
        Next i
    End Sub

    Sub MostrarEstadisticas()
        Dim i As Byte
        Dim TotalPacientesHP As Byte = 0
        Dim TotalTransACH As Double = 0
        Dim TotalDiasHNP As Double = 0

        While (i <= 5)
            If (MATRIZ(i, 0) <> Nothing) Then
                If MATRIZ(i, 4) = "1. Habitación privada" Then
                    TotalPacientesHP = TotalPacientesHP + 1
                End If
                If MATRIZ(i, 6) = "Transferencia ACH" Then
                    TotalTransACH = TotalTransACH + Val(MATRIZ(i, 10))
                End If
                If MATRIZ(i, 4) = "3. No privada" Then
                    TotalDiasHNP = TotalDiasHNP + Val(MATRIZ(i, 2))
                End If
                i = i + 1
            Else
                Exit While
            End If
        End While

        Form1.TBXestadistica1.Text = Str(TotalPacientesHP)
        Form1.TBXestadistica2.Text = Str(Round(TotalTransACH, 2))
        Form1.TBXestadistica3.Text = Str(TotalDiasHNP)
    End Sub

End Module
