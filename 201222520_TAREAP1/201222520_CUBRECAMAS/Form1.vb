Imports System.Math
Public Class Form1
    Private Sub CBlino_CheckedChanged(sender As Object, e As EventArgs) Handles CBlino.CheckedChanged
        If (CBlino.Checked) Then
            TBlino.Visible = True
            TBlino.Focus()
        Else
            TBlino.Clear()
            TBlino.Visible = False
        End If
    End Sub

    Private Sub CBalgodon_CheckedChanged(sender As Object, e As EventArgs) Handles CBalgodon.CheckedChanged
        If (CBalgodon.Checked) Then
            TBalgodon.Visible = True
            TBalgodon.Focus()
        Else
            TBalgodon.Clear()
            TBalgodon.Visible = False
        End If
    End Sub

    Private Sub CBseda_CheckedChanged(sender As Object, e As EventArgs) Handles CBseda.CheckedChanged
        If (CBseda.Checked) Then
            TBseda.Visible = True
            TBseda.Focus()
        Else
            TBseda.Clear()
            TBseda.Visible = False
        End If
    End Sub

    Private Sub CBhilocrudo_CheckedChanged(sender As Object, e As EventArgs) Handles CBhilocrudo.CheckedChanged
        If (CBhilocrudo.Checked) Then
            TBhilocrudo.Visible = True
            TBhilocrudo.Focus()
        Else
            TBhilocrudo.Clear()
            TBhilocrudo.Visible = False
        End If
    End Sub

    Private Sub RBimperial_CheckedChanged(sender As Object, e As EventArgs) Handles RBimperial.CheckedChanged
        If (RBimperial.Checked) Then
            MsgBox("NECESITA 3 YARDAS DE MATERIAL", vbOKOnly, "IMPORTANTE")
        End If
    End Sub

    Private Sub RBmatrimonial_CheckedChanged(sender As Object, e As EventArgs) Handles RBmatrimonial.CheckedChanged
        If (RBmatrimonial.Checked) Then
            MsgBox("NECESITA 5 YARDAS DE MATERIAL", vbOKOnly, "IMPORTANTE")
        End If
    End Sub

    Private Sub RBqueen_CheckedChanged(sender As Object, e As EventArgs) Handles RBqueen.CheckedChanged
        If (RBqueen.Checked) Then
            MsgBox("NECESITA 6 YARDAS DE MATERIAL", vbOKOnly, "IMPORTANTE")
        End If
    End Sub

    Private Sub RBking_CheckedChanged(sender As Object, e As EventArgs) Handles RBking.CheckedChanged
        If (RBking.Checked) Then
            MsgBox("NECESITA 7 YARDAS DE MATERIAL", vbOKOnly, "IMPORTANTE")
        End If
    End Sub

    Private Sub LimpiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarToolStripMenuItem.Click
        limpiar()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If (MsgBox("DESEA SALIR", vbQuestion + vbYesNo, "MENSAJE DE SALIDA") = vbYes) Then
            Me.Close()
        Else limpiar()
        End If
    End Sub

    Private Sub CalcularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularToolStripMenuItem.Click

        Tlino = Val(Resultados.TBPlino.Text)
        Talgodon = Val(Resultados.TBPalgodon.Text)
        Tseda = Val(Resultados.TBPseda.Text)
        Thilocrudo = Val(Resultados.TBPhilocrudo.Text)

        TMateriales = Val(TBlino.Text) + Val(TBalgodon.Text) + Val(TBseda.Text) + Val(TBhilocrudo.Text)
        TPcosto = Val(Resultados.TBPcosto.Text)
        TPventa = Val(Resultados.TBPventa.Text)

        If RBimperial.Checked = True Or RBmatrimonial.Checked = True Or RBqueen.Checked = True Or RBking.Checked = True Then
        Else
            MsgBox("NECESITA INGRESAR EL TAMAÑO DE LA CAMA", vbOKOnly, "ERROR")
        End If


        If RBimperial.Checked Then
            If (TMateriales = 3) Then
                Tlino = Val(TBlino.Text) * Plino
                Resultados.TBPlino.Text = Str(Round(Tlino, 2))

                Talgodon = Val(TBalgodon.Text) * Palgodon
                Resultados.TBPalgodon.Text = Str(Round(Talgodon, 2))

                Tseda = Val(TBseda.Text) * Pseda
                Resultados.TBPseda.Text = Str(Round(Tseda, 2))

                Thilocrudo = Val(TBhilocrudo.Text) * Philocrudo
                Resultados.TBPhilocrudo.Text = Str(Round(Thilocrudo, 2))

                TPcosto = PMOimperial + Tlino + Talgodon + Tseda + Thilocrudo
                Resultados.TBPcosto.Text = Str(Round(TPcosto, 2))

                TPventa = (TPcosto * 0.65) + TPcosto
                Resultados.TBPventa.Text = Str(Round(TPventa, 2))

                Me.Hide()
                Resultados.Show()
            Else
                MsgBox("NECESITA 3 YARDAS DE MATERIAL", vbOKOnly, "ERROR")
            End If
        End If


        If RBmatrimonial.Checked Then
            If (TMateriales = 5) Then
                Tlino = Val(TBlino.Text) * Plino
                Resultados.TBPlino.Text = Str(Round(Tlino, 2))

                Talgodon = Val(TBalgodon.Text) * Palgodon
                Resultados.TBPalgodon.Text = Str(Round(Talgodon, 2))

                Tseda = Val(TBseda.Text) * Pseda
                Resultados.TBPseda.Text = Str(Round(Tseda, 2))

                Thilocrudo = Val(TBhilocrudo.Text) * Philocrudo
                Resultados.TBPhilocrudo.Text = Str(Round(Thilocrudo, 2))

                TPcosto = PMOimperial + Tlino + Talgodon + Tseda + Thilocrudo
                Resultados.TBPcosto.Text = Str(Round(TPcosto, 2))

                TPventa = (TPcosto * 0.65) + TPcosto
                Resultados.TBPventa.Text = Str(Round(TPventa, 2))

                Me.Hide()
                Resultados.Show()
            Else
                MsgBox("NECESITA 5 YARDAS DE MATERIAL", vbOKOnly, "ERROR")
            End If
        End If


        If RBqueen.Checked Then
            If (TMateriales = 6) Then
                Tlino = Val(TBlino.Text) * Plino
                Resultados.TBPlino.Text = Str(Round(Tlino, 2))

                Talgodon = Val(TBalgodon.Text) * Palgodon
                Resultados.TBPalgodon.Text = Str(Round(Talgodon, 2))

                Tseda = Val(TBseda.Text) * Pseda
                Resultados.TBPseda.Text = Str(Round(Tseda, 2))

                Thilocrudo = Val(TBhilocrudo.Text) * Philocrudo
                Resultados.TBPhilocrudo.Text = Str(Round(Thilocrudo, 2))

                TPcosto = PMOimperial + Tlino + Talgodon + Tseda + Thilocrudo
                Resultados.TBPcosto.Text = Str(Round(TPcosto, 2))

                TPventa = (TPcosto * 0.65) + TPcosto
                Resultados.TBPventa.Text = Str(Round(TPventa, 2))

                Me.Hide()
                Resultados.Show()
            Else
                MsgBox("NECESITA 6 YARDAS DE MATERIAL", vbOKOnly, "ERROR")
            End If
        End If


        If RBking.Checked Then
            If (TMateriales = 7) Then
                Tlino = Val(TBlino.Text) * Plino
                Resultados.TBPlino.Text = Str(Round(Tlino, 2))

                Talgodon = Val(TBalgodon.Text) * Palgodon
                Resultados.TBPalgodon.Text = Str(Round(Talgodon, 2))

                Tseda = Val(TBseda.Text) * Pseda
                Resultados.TBPseda.Text = Str(Round(Tseda, 2))

                Thilocrudo = Val(TBhilocrudo.Text) * Philocrudo
                Resultados.TBPhilocrudo.Text = Str(Round(Thilocrudo, 2))

                TPcosto = PMOimperial + Tlino + Talgodon + Tseda + Thilocrudo
                Resultados.TBPcosto.Text = Str(Round(TPcosto, 2))

                TPventa = (TPcosto * 0.65) + TPcosto
                Resultados.TBPventa.Text = Str(Round(TPventa, 2))

                Me.Hide()
                Resultados.Show()
            Else
                MsgBox("NECESITA 7 YARDAS DE MATERIAL", vbOKOnly, "ERROR")
            End If
        End If

        If RBimperial.Checked Then
            Resultados.Label8.Text = "RESULTADOS PARA CAMA IMPERIAL"
        ElseIf RBmatrimonial.Checked Then
            Resultados.Label8.Text = "RESULTADOS PARA CAMA MATRIMONIAL"
        ElseIf RBqueen.Checked Then
            Resultados.Label8.Text = "RESULTADOS PARA CAMA QUEEN"
        ElseIf RBking.Checked Then
            Resultados.Label8.Text = "RESULTADOS PARA CAMA KING"
        End If

    End Sub
End Class
