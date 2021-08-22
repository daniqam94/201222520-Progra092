Imports System.Math
Public Class Resultados
    Private Sub REGRESAR_Click(sender As Object, e As EventArgs) Handles REGRESAR.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub SALIR_Click(sender As Object, e As EventArgs) Handles SALIR.Click
        If (MsgBox("DESEA SALIR", vbQuestion + vbYesNo, "MENSAJE DE SALIDA") = vbYes) Then
            Me.Close()
        Else limpiar()
            Me.Hide()
            Form1.Show()
        End If
    End Sub
End Class