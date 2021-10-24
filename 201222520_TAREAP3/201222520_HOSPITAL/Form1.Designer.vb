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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CBXformapago = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CBXhabitacion = New System.Windows.Forms.ComboBox()
        Me.TBXhonorarios = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TBXdias = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBXnit = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBXnombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TBXestadistica3 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TBXestadistica2 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TBXestadistica1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TBXconsultanit = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MOSTRARENMATRIZToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CALCULARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARMATRIZToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARESTADISTICASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CALCULARESTADISTICASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARMATRIZToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARINFORMACIÓNToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARESTADISTICASToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(558, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "HOSPITAL"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.CBXformapago)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.CBXhabitacion)
        Me.GroupBox1.Controls.Add(Me.TBXhonorarios)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TBXdias)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TBXnit)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TBXnombre)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(83, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(368, 310)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INFORMACIÓN PACIENTE"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 245)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(130, 20)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Forma de pago :"
        '
        'CBXformapago
        '
        Me.CBXformapago.FormattingEnabled = True
        Me.CBXformapago.Items.AddRange(New Object() {"Efectivo", "Transferencia ACH", "Depósito bancario", "Tarjeta de crédito", "Seguro Médico"})
        Me.CBXformapago.Location = New System.Drawing.Point(167, 245)
        Me.CBXformapago.Name = "CBXformapago"
        Me.CBXformapago.Size = New System.Drawing.Size(183, 28)
        Me.CBXformapago.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 209)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(156, 20)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Tipo de habitación : "
        '
        'CBXhabitacion
        '
        Me.CBXhabitacion.FormattingEnabled = True
        Me.CBXhabitacion.Items.AddRange(New Object() {"1. Habitación privada", "2. Semiprivada", "3. No privada"})
        Me.CBXhabitacion.Location = New System.Drawing.Point(181, 201)
        Me.CBXhabitacion.Name = "CBXhabitacion"
        Me.CBXhabitacion.Size = New System.Drawing.Size(169, 28)
        Me.CBXhabitacion.TabIndex = 5
        '
        'TBXhonorarios
        '
        Me.TBXhonorarios.Location = New System.Drawing.Point(244, 159)
        Me.TBXhonorarios.Name = "TBXhonorarios"
        Me.TBXhonorarios.Size = New System.Drawing.Size(106, 26)
        Me.TBXhonorarios.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(213, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Honorarios del médico (Q.) :"
        '
        'TBXdias
        '
        Me.TBXdias.Location = New System.Drawing.Point(276, 120)
        Me.TBXdias.Name = "TBXdias"
        Me.TBXdias.Size = New System.Drawing.Size(74, 26)
        Me.TBXdias.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(242, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Cantidad de días hospitalizado :"
        '
        'TBXnit
        '
        Me.TBXnit.Location = New System.Drawing.Point(153, 76)
        Me.TBXnit.Name = "TBXnit"
        Me.TBXnit.Size = New System.Drawing.Size(197, 26)
        Me.TBXnit.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Número de NIT :"
        '
        'TBXnombre
        '
        Me.TBXnombre.Location = New System.Drawing.Point(119, 36)
        Me.TBXnombre.Name = "TBXnombre"
        Me.TBXnombre.Size = New System.Drawing.Size(231, 26)
        Me.TBXnombre.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nombre :"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.TBXestadistica3)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.TBXestadistica2)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.TBXestadistica1)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(847, 63)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(347, 310)
        Me.GroupBox2.TabIndex = 43
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ESTADISTICAS"
        '
        'TBXestadistica3
        '
        Me.TBXestadistica3.Enabled = False
        Me.TBXestadistica3.Location = New System.Drawing.Point(221, 152)
        Me.TBXestadistica3.Name = "TBXestadistica3"
        Me.TBXestadistica3.Size = New System.Drawing.Size(100, 26)
        Me.TBXestadistica3.TabIndex = 50
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(19, 175)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(181, 20)
        Me.Label13.TabIndex = 49
        Me.Label13.Text = "habitación no privada :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(19, 155)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(152, 20)
        Me.Label12.TabIndex = 48
        Me.Label12.Text = "Días que se utilizó la"
        '
        'TBXestadistica2
        '
        Me.TBXestadistica2.Enabled = False
        Me.TBXestadistica2.Location = New System.Drawing.Point(221, 89)
        Me.TBXestadistica2.Name = "TBXestadistica2"
        Me.TBXestadistica2.Size = New System.Drawing.Size(100, 26)
        Me.TBXestadistica2.TabIndex = 47
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(19, 114)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(182, 20)
        Me.Label11.TabIndex = 46
        Me.Label11.Text = "transferencia ACH (Q.) :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(19, 92)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(153, 20)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = "Total recaudado en"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(19, 56)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(158, 20)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "habitación privada :"
        '
        'TBXestadistica1
        '
        Me.TBXestadistica1.Enabled = False
        Me.TBXestadistica1.Location = New System.Drawing.Point(221, 36)
        Me.TBXestadistica1.Name = "TBXestadistica1"
        Me.TBXestadistica1.Size = New System.Drawing.Size(100, 26)
        Me.TBXestadistica1.TabIndex = 44
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(167, 20)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Pacientes que usaron"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.TBXconsultanit)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(475, 160)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(346, 98)
        Me.GroupBox3.TabIndex = 44
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "CONSULTA"
        '
        'TBXconsultanit
        '
        Me.TBXconsultanit.Location = New System.Drawing.Point(97, 59)
        Me.TBXconsultanit.Name = "TBXconsultanit"
        Me.TBXconsultanit.Size = New System.Drawing.Size(129, 26)
        Me.TBXconsultanit.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(18, 22)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(288, 20)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Ingrese el número de NIT del paciente"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11})
        Me.DataGridView1.Location = New System.Drawing.Point(13, 380)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(1308, 252)
        Me.DataGridView1.TabIndex = 45
        '
        'Column1
        '
        Me.Column1.HeaderText = "Nombre"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "NIT"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Días hospitalizado"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Honorarios del médico (Q.)"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Tipo de habitación"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Precio habitacion (Q.)"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Forma de pago"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "Pago parcial (Q.)"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        '
        'Column9
        '
        Me.Column9.HeaderText = "Descuento (Q.)"
        Me.Column9.MinimumWidth = 6
        Me.Column9.Name = "Column9"
        '
        'Column10
        '
        Me.Column10.HeaderText = "Recargo (Q.)"
        Me.Column10.MinimumWidth = 6
        Me.Column10.Name = "Column10"
        '
        'Column11
        '
        Me.Column11.HeaderText = "Total (Q.)"
        Me.Column11.MinimumWidth = 6
        Me.Column11.Name = "Column11"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MenuStrip1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MOSTRARENMATRIZToolStripMenuItem, Me.CALCULARToolStripMenuItem, Me.LIMPIARMATRIZToolStripMenuItem, Me.LIMPIARESTADISTICASToolStripMenuItem, Me.CALCULARESTADISTICASToolStripMenuItem, Me.LIMPIARMATRIZToolStripMenuItem2, Me.LIMPIARINFORMACIÓNToolStripMenuItem1, Me.LIMPIARESTADISTICASToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1355, 28)
        Me.MenuStrip1.TabIndex = 46
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MOSTRARENMATRIZToolStripMenuItem
        '
        Me.MOSTRARENMATRIZToolStripMenuItem.Name = "MOSTRARENMATRIZToolStripMenuItem"
        Me.MOSTRARENMATRIZToolStripMenuItem.Size = New System.Drawing.Size(171, 24)
        Me.MOSTRARENMATRIZToolStripMenuItem.Text = "MOSTRAR EN MATRIZ"
        '
        'CALCULARToolStripMenuItem
        '
        Me.CALCULARToolStripMenuItem.Name = "CALCULARToolStripMenuItem"
        Me.CALCULARToolStripMenuItem.Size = New System.Drawing.Size(103, 24)
        Me.CALCULARToolStripMenuItem.Text = "CALCULAR"
        '
        'LIMPIARMATRIZToolStripMenuItem
        '
        Me.LIMPIARMATRIZToolStripMenuItem.Name = "LIMPIARMATRIZToolStripMenuItem"
        Me.LIMPIARMATRIZToolStripMenuItem.Size = New System.Drawing.Size(201, 24)
        Me.LIMPIARMATRIZToolStripMenuItem.Text = "CALCULAR ESTADISTICAS"
        '
        'LIMPIARESTADISTICASToolStripMenuItem
        '
        Me.LIMPIARESTADISTICASToolStripMenuItem.Name = "LIMPIARESTADISTICASToolStripMenuItem"
        Me.LIMPIARESTADISTICASToolStripMenuItem.Size = New System.Drawing.Size(62, 24)
        Me.LIMPIARESTADISTICASToolStripMenuItem.Text = "SALIR"
        '
        'CALCULARESTADISTICASToolStripMenuItem
        '
        Me.CALCULARESTADISTICASToolStripMenuItem.Name = "CALCULARESTADISTICASToolStripMenuItem"
        Me.CALCULARESTADISTICASToolStripMenuItem.Size = New System.Drawing.Size(109, 24)
        Me.CALCULARESTADISTICASToolStripMenuItem.Text = "CONSULTAR"
        '
        'LIMPIARMATRIZToolStripMenuItem2
        '
        Me.LIMPIARMATRIZToolStripMenuItem2.Name = "LIMPIARMATRIZToolStripMenuItem2"
        Me.LIMPIARMATRIZToolStripMenuItem2.Size = New System.Drawing.Size(140, 24)
        Me.LIMPIARMATRIZToolStripMenuItem2.Text = "LIMPIAR MATRIZ"
        '
        'LIMPIARINFORMACIÓNToolStripMenuItem1
        '
        Me.LIMPIARINFORMACIÓNToolStripMenuItem1.Name = "LIMPIARINFORMACIÓNToolStripMenuItem1"
        Me.LIMPIARINFORMACIÓNToolStripMenuItem1.Size = New System.Drawing.Size(200, 24)
        Me.LIMPIARINFORMACIÓNToolStripMenuItem1.Text = "LIMPIAR INFORMACIÓN"
        '
        'LIMPIARESTADISTICASToolStripMenuItem1
        '
        Me.LIMPIARESTADISTICASToolStripMenuItem1.Name = "LIMPIARESTADISTICASToolStripMenuItem1"
        Me.LIMPIARESTADISTICASToolStripMenuItem1.Size = New System.Drawing.Size(182, 24)
        Me.LIMPIARESTADISTICASToolStripMenuItem1.Text = "LIMPIAR ESTADISTICAS"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1355, 645)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TBXnit As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TBXnombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TBXdias As TextBox
    Friend WithEvents TBXhonorarios As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents CBXformapago As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CBXhabitacion As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TBXestadistica1 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TBXestadistica2 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TBXestadistica3 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TBXconsultanit As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CALCULARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MOSTRARENMATRIZToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LIMPIARMATRIZToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CALCULARESTADISTICASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LIMPIARESTADISTICASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents LIMPIARINFORMACIÓNToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LIMPIARMATRIZToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents LIMPIARESTADISTICASToolStripMenuItem1 As ToolStripMenuItem
End Class
