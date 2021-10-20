Public Class Form1

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles BTNLIMPIARINFO.Click
        Call LimpiarInfo()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles BTNLIMPIARTOT.Click
        Call LimpiarTotales()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles BTNLIMPIARMATRIZ.Click
        Call LimpiarMatriz()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BTNSALIR.Click
        Call Salir()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BTNCALCULAR.Click
        If TBXNOMBRE.Text = "" Then
            MsgBox("Ingrese el nombre del alumno", vbExclamation, "ERROR")
        ElseIf TBXCARNE.Text = "" Or IsNumeric(TBXCARNE.Text) = 0 Then
            MsgBox("Ingrese el número de carné", vbExclamation, "ERROR")
        ElseIf RBNBASICOS.Checked = 0 And RBNDIVERSIFICADO.Checked = 0 Then
            MsgBox("Seleccione el nivel de estudios", vbExclamation, "ERROR")
        ElseIf CBXFORMADEPAGO.Text = "" Then
            MsgBox("Seleccione la forma de pago", vbExclamation, "ERROR")
        End If

        If (INDICE < 7) Then
            INSCRIPCIONES(INDICE, 0) = TBXNOMBRE.Text
            INSCRIPCIONES(INDICE, 1) = TBXCARNE.Text

            If RBNBASICOS.Checked Then
                INSCRIPCIONES(INDICE, 2) = RBNBASICOS.Text
                INSCRIPCIONES(INDICE, 3) = ""
                INSCRIPCIONES(INDICE, 4) = Str(InscripcionB)
                INSCRIPCIONES(INDICE, 5) = Str(CuotaB)
                INSCRIPCIONES(INDICE, 6) = Str(InscripcionB + CuotaB)
            End If

            If RBNDIVERSIFICADO.Checked Then
                INSCRIPCIONES(INDICE, 2) = RBNDIVERSIFICADO.Text
                INSCRIPCIONES(INDICE, 3) = CBXCARRERA.SelectedItem
                INSCRIPCIONES(INDICE, 4) = Str(InscripcionD)
                INSCRIPCIONES(INDICE, 5) = Str(CuotaD)
                INSCRIPCIONES(INDICE, 6) = Str(InscripcionD + CuotaD)
            End If

            If CBXFORMADEPAGO.Text = "Efectivo" Then
                INSCRIPCIONES(INDICE, 7) = "Efectivo"
                INSCRIPCIONES(INDICE, 8) = ""
                INSCRIPCIONES(INDICE, 9) = Str(Val(INSCRIPCIONES(INDICE, 6)) + Val(INSCRIPCIONES(INDICE, 8)))
            End If

            If CBXFORMADEPAGO.Text = "Tarjeta de crédito" Then
                INSCRIPCIONES(INDICE, 7) = "Tarjeta de crédito"
                INSCRIPCIONES(INDICE, 8) = Val(INSCRIPCIONES(INDICE, 6) * 0.1)
                INSCRIPCIONES(INDICE, 9) = Str(Val(INSCRIPCIONES(INDICE, 6)) + Val(INSCRIPCIONES(INDICE, 8)))
            End If

            If CBXFORMADEPAGO.Text = "Transferencia por ACH" Then
                INSCRIPCIONES(INDICE, 7) = "Transferencia por ACH"
                INSCRIPCIONES(INDICE, 8) = ""
                INSCRIPCIONES(INDICE, 9) = Str(Val(INSCRIPCIONES(INDICE, 6)) + Val(INSCRIPCIONES(INDICE, 8)))
            End If

            If CBXFORMADEPAGO.Text = "Depósito bancario" Then
                INSCRIPCIONES(INDICE, 7) = "Depósito bancario"
                INSCRIPCIONES(INDICE, 8) = ""
                INSCRIPCIONES(INDICE, 9) = Str(Val(INSCRIPCIONES(INDICE, 6)) + Val(INSCRIPCIONES(INDICE, 8)))
            End If

            INDICE = INDICE + 1
            If (INDICE = 7) Then
                MsgBox("MATRIZ LLENA", vbExclamation, "IMPORTANTE")
            End If
        End If
        LimpiarInfo()

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RBNDIVERSIFICADO.CheckedChanged
        If (RBNDIVERSIFICADO.Checked) Then
            CBXCARRERA.Visible = True
            CBXCARRERA.Focus()
        Else
            CBXCARRERA.Visible = False
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles BTNMOSTRARTOTALES.Click
        Call MostrarTotales()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BTNMOSTRARDATOS.Click
        Call MostrarDatosMatriz()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles BTNELIMINARF.Click
        Dim i As Integer

        i = DataGridView1.SelectedRows(0).Index
        DataGridView1.Rows.RemoveAt(i)

        MsgBox("Se elimino la fila", vbOKOnly)
    End Sub
End Class
