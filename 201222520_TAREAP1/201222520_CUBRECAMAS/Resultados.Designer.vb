<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Resultados
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBPcosto = New System.Windows.Forms.TextBox()
        Me.TBPventa = New System.Windows.Forms.TextBox()
        Me.REGRESAR = New System.Windows.Forms.Button()
        Me.SALIR = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TBPhilocrudo = New System.Windows.Forms.TextBox()
        Me.TBPseda = New System.Windows.Forms.TextBox()
        Me.TBPalgodon = New System.Windows.Forms.TextBox()
        Me.TBPlino = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(89, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "RESULTADOS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Precio Costo (Q) :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(180, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Precio de venta (Q) :"
        '
        'TBPcosto
        '
        Me.TBPcosto.Enabled = False
        Me.TBPcosto.Location = New System.Drawing.Point(226, 99)
        Me.TBPcosto.Name = "TBPcosto"
        Me.TBPcosto.Size = New System.Drawing.Size(100, 22)
        Me.TBPcosto.TabIndex = 3
        '
        'TBPventa
        '
        Me.TBPventa.Enabled = False
        Me.TBPventa.Location = New System.Drawing.Point(226, 143)
        Me.TBPventa.Name = "TBPventa"
        Me.TBPventa.Size = New System.Drawing.Size(100, 22)
        Me.TBPventa.TabIndex = 4
        '
        'REGRESAR
        '
        Me.REGRESAR.Location = New System.Drawing.Point(57, 202)
        Me.REGRESAR.Name = "REGRESAR"
        Me.REGRESAR.Size = New System.Drawing.Size(101, 47)
        Me.REGRESAR.TabIndex = 5
        Me.REGRESAR.Text = "REGRESAR"
        Me.REGRESAR.UseVisualStyleBackColor = True
        '
        'SALIR
        '
        Me.SALIR.Location = New System.Drawing.Point(202, 202)
        Me.SALIR.Name = "SALIR"
        Me.SALIR.Size = New System.Drawing.Size(98, 47)
        Me.SALIR.TabIndex = 6
        Me.SALIR.Text = "SALIR"
        Me.SALIR.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TBPhilocrudo)
        Me.GroupBox1.Controls.Add(Me.TBPseda)
        Me.GroupBox1.Controls.Add(Me.TBPalgodon)
        Me.GroupBox1.Controls.Add(Me.TBPlino)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(375, 77)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(314, 172)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "TOTAL POR MATERIAL"
        '
        'TBPhilocrudo
        '
        Me.TBPhilocrudo.Enabled = False
        Me.TBPhilocrudo.Location = New System.Drawing.Point(129, 137)
        Me.TBPhilocrudo.Name = "TBPhilocrudo"
        Me.TBPhilocrudo.Size = New System.Drawing.Size(100, 22)
        Me.TBPhilocrudo.TabIndex = 12
        '
        'TBPseda
        '
        Me.TBPseda.Enabled = False
        Me.TBPseda.Location = New System.Drawing.Point(129, 104)
        Me.TBPseda.Name = "TBPseda"
        Me.TBPseda.Size = New System.Drawing.Size(100, 22)
        Me.TBPseda.TabIndex = 11
        '
        'TBPalgodon
        '
        Me.TBPalgodon.Enabled = False
        Me.TBPalgodon.Location = New System.Drawing.Point(129, 69)
        Me.TBPalgodon.Name = "TBPalgodon"
        Me.TBPalgodon.Size = New System.Drawing.Size(100, 22)
        Me.TBPalgodon.TabIndex = 10
        '
        'TBPlino
        '
        Me.TBPlino.Enabled = False
        Me.TBPlino.Location = New System.Drawing.Point(129, 33)
        Me.TBPlino.Name = "TBPlino"
        Me.TBPlino.Size = New System.Drawing.Size(100, 22)
        Me.TBPlino.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 140)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 17)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Hilo crudo (Q) : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 107)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 17)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Seda (Q) :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 17)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Algodon (Q) :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Lino (Q) :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(35, 62)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 17)
        Me.Label8.TabIndex = 9
        '
        'Resultados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(732, 287)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.SALIR)
        Me.Controls.Add(Me.REGRESAR)
        Me.Controls.Add(Me.TBPventa)
        Me.Controls.Add(Me.TBPcosto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Resultados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Resultados"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TBPcosto As TextBox
    Friend WithEvents TBPventa As TextBox
    Friend WithEvents REGRESAR As Button
    Friend WithEvents SALIR As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TBPhilocrudo As TextBox
    Friend WithEvents TBPseda As TextBox
    Friend WithEvents TBPalgodon As TextBox
    Friend WithEvents TBPlino As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
End Class
