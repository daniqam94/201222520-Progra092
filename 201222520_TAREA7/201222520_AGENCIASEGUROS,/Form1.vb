Public Class Form1
    Public INDICE As Byte = 0

    Public Edad(7) As Integer
    Public Genero(7) As String
    Public Registro(7) As String
    Public MontoDeDaños(7) As Integer
    Public Taller(7) As String
    Public Deducible(7) As Integer

    Sub LimpiarInformacion()
        TBX1EDAD.Clear()
        TBX2MONTO.Clear()
        CBX1GENERO.Text = ""
        CBX2REGISTRO.Text = ""
        CBX3TALLER.Text = ""
        TBX1EDAD.Focus()
    End Sub

    Sub LimpiarEstadisticas()
        TBX3MONTOT.Clear()
        TBX4.Clear()
        TBX5.Clear()
        TBX6.Clear()
        TBX7.Clear()
        TBX8.Clear()
    End Sub

    Sub LimpiarListas()
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        ListBox4.Items.Clear()
        ListBox5.Items.Clear()
        ListBox6.Items.Clear()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        LimpiarInformacion()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        LimpiarEstadisticas()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        LimpiarListas()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If (MsgBox("DESEA SALIR", vbQuestion + vbYesNo, "MENSAJE DE SALIDA") = vbYes) Then
            End
        Else
            LimpiarInformacion()
            LimpiarEstadisticas()
            LimpiarListas()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TBX1EDAD.Text = "" Or IsNumeric(TBX1EDAD.Text) = 0 Then
            MsgBox("Ingrese la Edad del Cliente en Números", vbExclamation, "ERROR")
        ElseIf CBX1GENERO.Text = "" Then
            MsgBox("Seleccione el Género del Cliente", vbExclamation, "ERROR")
        ElseIf CBX2REGISTRO.Text = "" Then
            MsgBox("Seleccione el Tipo de Registro del Cliente", vbExclamation, "ERROR")
        ElseIf CBX3TALLER.Text = "" Then
            MsgBox("Seleccione el Tipo de Taller", vbExclamation, "ERROR")
        ElseIf TBX2MONTO.Text = "" Or IsNumeric(TBX2MONTO.Text) = False Then
            MsgBox("Ingrese el Monto de los Daños en Quetzales", vbExclamation, "ERROR")
        End If

        If (INDICE < 7) Then
            Edad(INDICE) = Val(TBX1EDAD.Text)
            Genero(INDICE) = CBX1GENERO.SelectedItem.ToString()
            Registro(INDICE) = CBX2REGISTRO.SelectedItem.ToString()
            Taller(INDICE) = CBX3TALLER.SelectedItem.ToString()
            MontoDeDaños(INDICE) = Val(TBX2MONTO.Text)
            Deducible(INDICE) = Val(TBX2MONTO.Text) * 0.06
            LimpiarInformacion()
        End If

        INDICE = INDICE + 1

        If (INDICE >= 7) Then
            LimpiarEstadisticas()
            LimpiarListas()
            MsgBox("LISTAS LLENAS", vbExclamation, "ERROR")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim MostrarD As Byte
        LimpiarListas()

        For MostrarD = 0 To 7
            If Edad(MostrarD) <> Nothing Then
                ListBox1.Items.Add(Edad(MostrarD))
                ListBox2.Items.Add(Genero(MostrarD))
                ListBox3.Items.Add(Registro(MostrarD))
                ListBox4.Items.Add(MontoDeDaños(MostrarD))
                ListBox5.Items.Add(Taller(MostrarD))
                ListBox6.Items.Add(Deducible(MostrarD))
            Else
                Exit For
            End If
        Next MostrarD
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim SumaDeMontos As Integer = 0
        Dim MostrarSDM As Integer

        For MostrarSDM = 0 To ListBox4.Items.Count - 1
            SumaDeMontos = SumaDeMontos + Val(ListBox4.Items.Item(MostrarSDM))

        Next MostrarSDM

        TBX3MONTOT.Text = Str(SumaDeMontos)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim Estadisticas As Byte
        Dim E1 As Byte = 0
        Dim E2 As Byte = 0
        Dim E3 As Byte = 0
        Dim E4 As Byte = 0
        Dim E5 As Byte = 0


        For Estadisticas = 0 To 7

            If (Edad(Estadisticas) > 0) And (Edad(Estadisticas) < 25) Then
                E1 = E1 + 1
            End If

            If (Genero(Estadisticas) = "Femenino") Then
                E2 = E2 + 1
            End If

            Select Case Edad(Estadisticas)
                Case 18 To 25 And Genero(Estadisticas) = "Masculino" : E3 = E3 + 1
            End Select

            If (Registro(Estadisticas) = "0") Then
                E4 = E4 + 1
            Else
                E4 = E4 + 0
            End If

            E5 = ListBox1.Items.Count()

        Next Estadisticas

        TBX4.Text = Math.Round((Str(E1) / INDICE) * 100, 2) & " %"
        TBX5.Text = Math.Round((Str(E2) / INDICE) * 100, 2) & " %"
        TBX6.Text = Math.Round((Str(E3) / INDICE) * 100, 2) & " %"
        TBX7.Text = Math.Round((Str(E4) / INDICE) * 100, 2) & " %"
        TBX8.Text = Str(E5)
    End Sub
End Class
