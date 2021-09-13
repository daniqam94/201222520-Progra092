<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TBCantidadE = New System.Windows.Forms.TextBox()
        Me.CBXcine = New System.Windows.Forms.ComboBox()
        Me.CBXfuncion = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LBTotal = New System.Windows.Forms.ListBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LBDescuento2 = New System.Windows.Forms.ListBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LBDescuento1 = New System.Windows.Forms.ListBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LBSubtotal = New System.Windows.Forms.ListBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LBEntradas = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LBCine = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LBFuncion = New System.Windows.Forms.ListBox()
        Me.BAceptar = New System.Windows.Forms.Button()
        Me.BLimpiarE = New System.Windows.Forms.Button()
        Me.BLimpiarV = New System.Windows.Forms.Button()
        Me.BSalir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 56)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CINE"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GroupBox1.Controls.Add(Me.TBCantidadE)
        Me.GroupBox1.Controls.Add(Me.CBXcine)
        Me.GroupBox1.Controls.Add(Me.CBXfuncion)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(163, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(381, 152)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INGRESE LA SIGUIENTE INFORMACIÓN"
        '
        'TBCantidadE
        '
        Me.TBCantidadE.Location = New System.Drawing.Point(221, 112)
        Me.TBCantidadE.Name = "TBCantidadE"
        Me.TBCantidadE.Size = New System.Drawing.Size(119, 26)
        Me.TBCantidadE.TabIndex = 7
        '
        'CBXcine
        '
        Me.CBXcine.FormattingEnabled = True
        Me.CBXcine.Items.AddRange(New Object() {"Cine A", "Cine B", "Cine C"})
        Me.CBXcine.Location = New System.Drawing.Point(188, 70)
        Me.CBXcine.Name = "CBXcine"
        Me.CBXcine.Size = New System.Drawing.Size(153, 28)
        Me.CBXcine.TabIndex = 6
        '
        'CBXfuncion
        '
        Me.CBXfuncion.FormattingEnabled = True
        Me.CBXfuncion.Items.AddRange(New Object() {"Funcion 1", "Funcion 2", "Funcion 3", "Funcion 4"})
        Me.CBXfuncion.Location = New System.Drawing.Point(187, 35)
        Me.CBXfuncion.Name = "CBXfuncion"
        Me.CBXfuncion.Size = New System.Drawing.Size(153, 28)
        Me.CBXfuncion.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(177, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Cantidad de Entradas :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Elija el Cine :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Elija la Función :"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.LBTotal)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.LBDescuento2)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.LBDescuento1)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.LBSubtotal)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.LBEntradas)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.LBCine)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.LBFuncion)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(0, 200)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(900, 238)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "RESULTADOS"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(762, 35)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 19)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "TOTAL (Q)"
        '
        'LBTotal
        '
        Me.LBTotal.FormattingEnabled = True
        Me.LBTotal.ItemHeight = 17
        Me.LBTotal.Location = New System.Drawing.Point(762, 57)
        Me.LBTotal.Name = "LBTotal"
        Me.LBTotal.Size = New System.Drawing.Size(120, 174)
        Me.LBTotal.TabIndex = 13
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(632, 35)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(117, 19)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Descuento 2(Q)"
        '
        'LBDescuento2
        '
        Me.LBDescuento2.FormattingEnabled = True
        Me.LBDescuento2.ItemHeight = 17
        Me.LBDescuento2.Location = New System.Drawing.Point(636, 57)
        Me.LBDescuento2.Name = "LBDescuento2"
        Me.LBDescuento2.Size = New System.Drawing.Size(120, 174)
        Me.LBDescuento2.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(506, 35)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(117, 19)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Descuento 1(Q)"
        '
        'LBDescuento1
        '
        Me.LBDescuento1.FormattingEnabled = True
        Me.LBDescuento1.ItemHeight = 17
        Me.LBDescuento1.Location = New System.Drawing.Point(510, 57)
        Me.LBDescuento1.Name = "LBDescuento1"
        Me.LBDescuento1.Size = New System.Drawing.Size(120, 174)
        Me.LBDescuento1.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(389, 35)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 19)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "SubTotal (Q)"
        '
        'LBSubtotal
        '
        Me.LBSubtotal.FormattingEnabled = True
        Me.LBSubtotal.ItemHeight = 17
        Me.LBSubtotal.Location = New System.Drawing.Point(384, 57)
        Me.LBSubtotal.Name = "LBSubtotal"
        Me.LBSubtotal.Size = New System.Drawing.Size(120, 174)
        Me.LBSubtotal.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(260, 35)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 19)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Entradas"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(260, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 19)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Cantidad de"
        '
        'LBEntradas
        '
        Me.LBEntradas.FormattingEnabled = True
        Me.LBEntradas.ItemHeight = 17
        Me.LBEntradas.Location = New System.Drawing.Point(258, 57)
        Me.LBEntradas.Name = "LBEntradas"
        Me.LBEntradas.Size = New System.Drawing.Size(120, 174)
        Me.LBEntradas.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(128, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 19)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Cine"
        '
        'LBCine
        '
        Me.LBCine.FormattingEnabled = True
        Me.LBCine.ItemHeight = 17
        Me.LBCine.Location = New System.Drawing.Point(132, 57)
        Me.LBCine.Name = "LBCine"
        Me.LBCine.Size = New System.Drawing.Size(120, 174)
        Me.LBCine.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 19)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Función"
        '
        'LBFuncion
        '
        Me.LBFuncion.FormattingEnabled = True
        Me.LBFuncion.ItemHeight = 17
        Me.LBFuncion.Location = New System.Drawing.Point(6, 57)
        Me.LBFuncion.Name = "LBFuncion"
        Me.LBFuncion.Size = New System.Drawing.Size(120, 174)
        Me.LBFuncion.TabIndex = 0
        '
        'BAceptar
        '
        Me.BAceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BAceptar.Location = New System.Drawing.Point(563, 25)
        Me.BAceptar.Name = "BAceptar"
        Me.BAceptar.Size = New System.Drawing.Size(128, 58)
        Me.BAceptar.TabIndex = 4
        Me.BAceptar.Text = "ACEPTAR"
        Me.BAceptar.UseVisualStyleBackColor = False
        '
        'BLimpiarE
        '
        Me.BLimpiarE.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BLimpiarE.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BLimpiarE.Location = New System.Drawing.Point(563, 95)
        Me.BLimpiarE.Name = "BLimpiarE"
        Me.BLimpiarE.Size = New System.Drawing.Size(128, 68)
        Me.BLimpiarE.TabIndex = 5
        Me.BLimpiarE.Text = "LIMPIAR ENTRADAS"
        Me.BLimpiarE.UseVisualStyleBackColor = False
        '
        'BLimpiarV
        '
        Me.BLimpiarV.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BLimpiarV.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BLimpiarV.Location = New System.Drawing.Point(697, 95)
        Me.BLimpiarV.Name = "BLimpiarV"
        Me.BLimpiarV.Size = New System.Drawing.Size(128, 68)
        Me.BLimpiarV.TabIndex = 6
        Me.BLimpiarV.Text = "LIMPIAR VECTORES"
        Me.BLimpiarV.UseVisualStyleBackColor = False
        '
        'BSalir
        '
        Me.BSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BSalir.Location = New System.Drawing.Point(697, 25)
        Me.BSalir.Name = "BSalir"
        Me.BSalir.Size = New System.Drawing.Size(128, 58)
        Me.BSalir.TabIndex = 7
        Me.BSalir.Text = "SALIR"
        Me.BSalir.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(900, 450)
        Me.Controls.Add(Me.BSalir)
        Me.Controls.Add(Me.BLimpiarV)
        Me.Controls.Add(Me.BLimpiarE)
        Me.Controls.Add(Me.BAceptar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TBCantidadE As TextBox
    Friend WithEvents CBXcine As ComboBox
    Friend WithEvents CBXfuncion As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents LBDescuento1 As ListBox
    Friend WithEvents Label9 As Label
    Friend WithEvents LBSubtotal As ListBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents LBEntradas As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents LBCine As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents LBFuncion As ListBox
    Friend WithEvents Label12 As Label
    Friend WithEvents LBTotal As ListBox
    Friend WithEvents Label11 As Label
    Friend WithEvents LBDescuento2 As ListBox
    Friend WithEvents BAceptar As Button
    Friend WithEvents BLimpiarE As Button
    Friend WithEvents BLimpiarV As Button
    Friend WithEvents BSalir As Button
End Class
