Imports System.Math
Module Module1

    Public Const PMOimperial = 65.5
    Public Const PMOmatrimonial = 85.99
    Public Const PMOqueen = 99.99
    Public Const PMOking = 105.99

    Public Const Plino = 15.0
    Public Const Palgodon = 23.99
    Public Const Pseda = 30.99
    Public Const Philocrudo = 39.99

    Public Tlino As Double, Talgodon As Double, Tseda As Double, Thilocrudo As Double
    Public TPcosto As Double, TPventa As Double, TMateriales As Double

    Sub limpiar()
        Form1.RBimperial.Checked = False
        Form1.RBmatrimonial.Checked = False
        Form1.RBqueen.Checked = False
        Form1.RBking.Checked = False
        Form1.CBlino.Checked = False
        Form1.CBalgodon.Checked = False
        Form1.CBseda.Checked = False
        Form1.CBhilocrudo.Checked = False
        Form1.TBlino.Clear()
        Form1.TBalgodon.Clear()
        Form1.TBseda.Clear()
        Form1.TBhilocrudo.Clear()
        Resultados.TBPcosto.Clear()
        Resultados.TBPventa.Clear()
        Resultados.TBPlino.Clear()
        Resultados.TBPalgodon.Clear()
        Resultados.TBPseda.Clear()
        Resultados.TBPhilocrudo.Clear()

    End Sub
End Module
