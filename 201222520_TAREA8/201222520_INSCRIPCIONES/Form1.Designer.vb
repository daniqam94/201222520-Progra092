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
        Me.CBXFORMADEPAGO = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CBXCARRERA = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RBNDIVERSIFICADO = New System.Windows.Forms.RadioButton()
        Me.RBNBASICOS = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBXCARNE = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBXNOMBRE = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TBXTOTALDISE = New System.Windows.Forms.TextBox()
        Me.TBXTOTALELEC = New System.Windows.Forms.TextBox()
        Me.TBXTOTALBACH = New System.Windows.Forms.TextBox()
        Me.TBXTOTALPER = New System.Windows.Forms.TextBox()
        Me.TBXTOTALDIV = New System.Windows.Forms.TextBox()
        Me.TBXTOTALBAS = New System.Windows.Forms.TextBox()
        Me.TBXTOTALDEP = New System.Windows.Forms.TextBox()
        Me.TBXTOTALTRANS = New System.Windows.Forms.TextBox()
        Me.TBXTOTALTARJ = New System.Windows.Forms.TextBox()
        Me.TBXTOTALEFEC = New System.Windows.Forms.TextBox()
        Me.TBXTOTALGEN = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
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
        Me.BTNCALCULAR = New System.Windows.Forms.Button()
        Me.BTNMOSTRARDATOS = New System.Windows.Forms.Button()
        Me.BTNSALIR = New System.Windows.Forms.Button()
        Me.BTNLIMPIARINFO = New System.Windows.Forms.Button()
        Me.BTNLIMPIARTOT = New System.Windows.Forms.Button()
        Me.BTNLIMPIARMATRIZ = New System.Windows.Forms.Button()
        Me.BTNMOSTRARTOTALES = New System.Windows.Forms.Button()
        Me.BTNELIMINARF = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(534, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(419, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "COLEGIO CAMINO DEL SABER"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.CBXFORMADEPAGO)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.CBXCARRERA)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.RBNDIVERSIFICADO)
        Me.GroupBox1.Controls.Add(Me.RBNBASICOS)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TBXCARNE)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TBXNOMBRE)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(119, 82)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(360, 318)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INFORMACION DEL ALUMNO A INSCRIBIR"
        '
        'CBXFORMADEPAGO
        '
        Me.CBXFORMADEPAGO.FormattingEnabled = True
        Me.CBXFORMADEPAGO.Items.AddRange(New Object() {"Efectivo", "Tarjeta de crédito", "Transferencia por ACH", "Depósito bancario"})
        Me.CBXFORMADEPAGO.Location = New System.Drawing.Point(163, 249)
        Me.CBXFORMADEPAGO.Name = "CBXFORMADEPAGO"
        Me.CBXFORMADEPAGO.Size = New System.Drawing.Size(136, 28)
        Me.CBXFORMADEPAGO.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 252)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(130, 20)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Forma de pago :"
        '
        'CBXCARRERA
        '
        Me.CBXCARRERA.FormattingEnabled = True
        Me.CBXCARRERA.Items.AddRange(New Object() {"Perito contador", "Bachillerato", "Electrónica", "Diseño gráfico"})
        Me.CBXCARRERA.Location = New System.Drawing.Point(34, 203)
        Me.CBXCARRERA.Name = "CBXCARRERA"
        Me.CBXCARRERA.Size = New System.Drawing.Size(255, 28)
        Me.CBXCARRERA.TabIndex = 8
        Me.CBXCARRERA.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 171)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(293, 18)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "* Si eligio diversificado, elija la carrera"
        '
        'RBNDIVERSIFICADO
        '
        Me.RBNDIVERSIFICADO.AutoSize = True
        Me.RBNDIVERSIFICADO.Location = New System.Drawing.Point(163, 136)
        Me.RBNDIVERSIFICADO.Name = "RBNDIVERSIFICADO"
        Me.RBNDIVERSIFICADO.Size = New System.Drawing.Size(126, 24)
        Me.RBNDIVERSIFICADO.TabIndex = 2
        Me.RBNDIVERSIFICADO.Text = "Diversificado"
        Me.RBNDIVERSIFICADO.UseVisualStyleBackColor = True
        '
        'RBNBASICOS
        '
        Me.RBNBASICOS.AutoSize = True
        Me.RBNBASICOS.Location = New System.Drawing.Point(163, 106)
        Me.RBNBASICOS.Name = "RBNBASICOS"
        Me.RBNBASICOS.Size = New System.Drawing.Size(84, 24)
        Me.RBNBASICOS.TabIndex = 6
        Me.RBNBASICOS.Text = "Básicos"
        Me.RBNBASICOS.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Nivel de estudios :"
        '
        'TBXCARNE
        '
        Me.TBXCARNE.Location = New System.Drawing.Point(102, 61)
        Me.TBXCARNE.Name = "TBXCARNE"
        Me.TBXCARNE.Size = New System.Drawing.Size(197, 26)
        Me.TBXCARNE.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Carné :"
        '
        'TBXNOMBRE
        '
        Me.TBXNOMBRE.Location = New System.Drawing.Point(102, 29)
        Me.TBXNOMBRE.Name = "TBXNOMBRE"
        Me.TBXNOMBRE.Size = New System.Drawing.Size(197, 26)
        Me.TBXNOMBRE.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre :"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox4.Controls.Add(Me.TBXTOTALDISE)
        Me.GroupBox4.Controls.Add(Me.TBXTOTALELEC)
        Me.GroupBox4.Controls.Add(Me.TBXTOTALBACH)
        Me.GroupBox4.Controls.Add(Me.TBXTOTALPER)
        Me.GroupBox4.Controls.Add(Me.TBXTOTALDIV)
        Me.GroupBox4.Controls.Add(Me.TBXTOTALBAS)
        Me.GroupBox4.Controls.Add(Me.TBXTOTALDEP)
        Me.GroupBox4.Controls.Add(Me.TBXTOTALTRANS)
        Me.GroupBox4.Controls.Add(Me.TBXTOTALTARJ)
        Me.GroupBox4.Controls.Add(Me.TBXTOTALEFEC)
        Me.GroupBox4.Controls.Add(Me.TBXTOTALGEN)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(1040, 82)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(405, 460)
        Me.GroupBox4.TabIndex = 9
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "TOTALES"
        '
        'TBXTOTALDISE
        '
        Me.TBXTOTALDISE.Enabled = False
        Me.TBXTOTALDISE.Location = New System.Drawing.Point(279, 427)
        Me.TBXTOTALDISE.Name = "TBXTOTALDISE"
        Me.TBXTOTALDISE.Size = New System.Drawing.Size(100, 26)
        Me.TBXTOTALDISE.TabIndex = 25
        '
        'TBXTOTALELEC
        '
        Me.TBXTOTALELEC.Enabled = False
        Me.TBXTOTALELEC.Location = New System.Drawing.Point(279, 395)
        Me.TBXTOTALELEC.Name = "TBXTOTALELEC"
        Me.TBXTOTALELEC.Size = New System.Drawing.Size(100, 26)
        Me.TBXTOTALELEC.TabIndex = 24
        '
        'TBXTOTALBACH
        '
        Me.TBXTOTALBACH.Enabled = False
        Me.TBXTOTALBACH.Location = New System.Drawing.Point(279, 363)
        Me.TBXTOTALBACH.Name = "TBXTOTALBACH"
        Me.TBXTOTALBACH.Size = New System.Drawing.Size(100, 26)
        Me.TBXTOTALBACH.TabIndex = 23
        '
        'TBXTOTALPER
        '
        Me.TBXTOTALPER.Enabled = False
        Me.TBXTOTALPER.Location = New System.Drawing.Point(279, 331)
        Me.TBXTOTALPER.Name = "TBXTOTALPER"
        Me.TBXTOTALPER.Size = New System.Drawing.Size(100, 26)
        Me.TBXTOTALPER.TabIndex = 22
        '
        'TBXTOTALDIV
        '
        Me.TBXTOTALDIV.Enabled = False
        Me.TBXTOTALDIV.Location = New System.Drawing.Point(279, 282)
        Me.TBXTOTALDIV.Name = "TBXTOTALDIV"
        Me.TBXTOTALDIV.Size = New System.Drawing.Size(100, 26)
        Me.TBXTOTALDIV.TabIndex = 21
        '
        'TBXTOTALBAS
        '
        Me.TBXTOTALBAS.Enabled = False
        Me.TBXTOTALBAS.Location = New System.Drawing.Point(279, 250)
        Me.TBXTOTALBAS.Name = "TBXTOTALBAS"
        Me.TBXTOTALBAS.Size = New System.Drawing.Size(100, 26)
        Me.TBXTOTALBAS.TabIndex = 20
        '
        'TBXTOTALDEP
        '
        Me.TBXTOTALDEP.Enabled = False
        Me.TBXTOTALDEP.Location = New System.Drawing.Point(279, 193)
        Me.TBXTOTALDEP.Name = "TBXTOTALDEP"
        Me.TBXTOTALDEP.Size = New System.Drawing.Size(100, 26)
        Me.TBXTOTALDEP.TabIndex = 19
        '
        'TBXTOTALTRANS
        '
        Me.TBXTOTALTRANS.Enabled = False
        Me.TBXTOTALTRANS.Location = New System.Drawing.Point(279, 161)
        Me.TBXTOTALTRANS.Name = "TBXTOTALTRANS"
        Me.TBXTOTALTRANS.Size = New System.Drawing.Size(100, 26)
        Me.TBXTOTALTRANS.TabIndex = 18
        '
        'TBXTOTALTARJ
        '
        Me.TBXTOTALTARJ.Enabled = False
        Me.TBXTOTALTARJ.Location = New System.Drawing.Point(279, 129)
        Me.TBXTOTALTARJ.Name = "TBXTOTALTARJ"
        Me.TBXTOTALTARJ.Size = New System.Drawing.Size(100, 26)
        Me.TBXTOTALTARJ.TabIndex = 17
        '
        'TBXTOTALEFEC
        '
        Me.TBXTOTALEFEC.Enabled = False
        Me.TBXTOTALEFEC.Location = New System.Drawing.Point(279, 98)
        Me.TBXTOTALEFEC.Name = "TBXTOTALEFEC"
        Me.TBXTOTALEFEC.Size = New System.Drawing.Size(100, 26)
        Me.TBXTOTALEFEC.TabIndex = 16
        '
        'TBXTOTALGEN
        '
        Me.TBXTOTALGEN.Enabled = False
        Me.TBXTOTALGEN.Location = New System.Drawing.Point(279, 47)
        Me.TBXTOTALGEN.Name = "TBXTOTALGEN"
        Me.TBXTOTALGEN.Size = New System.Drawing.Size(100, 26)
        Me.TBXTOTALGEN.TabIndex = 15
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(60, 429)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(99, 17)
        Me.Label17.TabIndex = 14
        Me.Label17.Text = "Diseño gráfico"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(60, 397)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(78, 17)
        Me.Label16.TabIndex = 13
        Me.Label16.Text = "Electrónica"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(60, 365)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(82, 17)
        Me.Label15.TabIndex = 12
        Me.Label15.Text = "Bachillerato"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(60, 337)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(105, 17)
        Me.Label14.TabIndex = 11
        Me.Label14.Text = "Perito contador"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(27, 309)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(198, 17)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "Total inscritos por carrera"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(60, 284)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(89, 17)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Diversificado"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(60, 256)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 17)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Básicos"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(27, 231)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(147, 17)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Total por nivel (Q.)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(60, 193)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(124, 17)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Depósito Bancario"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(60, 163)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(153, 17)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Transferencia por ACH"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(60, 134)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 17)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Tarjeta de crédito"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(60, 107)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(58, 17)
        Me.Label18.TabIndex = 3
        Me.Label18.Text = "Efectivo"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(27, 80)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(218, 17)
        Me.Label19.TabIndex = 2
        Me.Label19.Text = "Total por forma de pago (Q.)"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(27, 47)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(142, 17)
        Me.Label20.TabIndex = 1
        Me.Label20.Text = "Total General (Q.)"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10})
        Me.DataGridView1.Location = New System.Drawing.Point(13, 565)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(1518, 252)
        Me.DataGridView1.TabIndex = 6
        '
        'Column1
        '
        Me.Column1.HeaderText = "Nombre"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Carné"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Nivel de estudios"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Carrera"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Inscripción"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Mensualidad"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Pago inicial"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "Forma de pago"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        '
        'Column9
        '
        Me.Column9.HeaderText = "Recargo"
        Me.Column9.MinimumWidth = 6
        Me.Column9.Name = "Column9"
        '
        'Column10
        '
        Me.Column10.HeaderText = "Total"
        Me.Column10.MinimumWidth = 6
        Me.Column10.Name = "Column10"
        '
        'BTNCALCULAR
        '
        Me.BTNCALCULAR.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BTNCALCULAR.Location = New System.Drawing.Point(584, 94)
        Me.BTNCALCULAR.Name = "BTNCALCULAR"
        Me.BTNCALCULAR.Size = New System.Drawing.Size(154, 85)
        Me.BTNCALCULAR.TabIndex = 27
        Me.BTNCALCULAR.Text = "CALCULAR"
        Me.BTNCALCULAR.UseVisualStyleBackColor = False
        '
        'BTNMOSTRARDATOS
        '
        Me.BTNMOSTRARDATOS.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BTNMOSTRARDATOS.Location = New System.Drawing.Point(584, 199)
        Me.BTNMOSTRARDATOS.Name = "BTNMOSTRARDATOS"
        Me.BTNMOSTRARDATOS.Size = New System.Drawing.Size(154, 85)
        Me.BTNMOSTRARDATOS.TabIndex = 28
        Me.BTNMOSTRARDATOS.Text = "MOSTRAR DATOS EN MATRIZ"
        Me.BTNMOSTRARDATOS.UseVisualStyleBackColor = False
        '
        'BTNSALIR
        '
        Me.BTNSALIR.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNSALIR.Location = New System.Drawing.Point(584, 411)
        Me.BTNSALIR.Name = "BTNSALIR"
        Me.BTNSALIR.Size = New System.Drawing.Size(154, 85)
        Me.BTNSALIR.TabIndex = 29
        Me.BTNSALIR.Text = "SALIR"
        Me.BTNSALIR.UseVisualStyleBackColor = False
        '
        'BTNLIMPIARINFO
        '
        Me.BTNLIMPIARINFO.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BTNLIMPIARINFO.Location = New System.Drawing.Point(779, 93)
        Me.BTNLIMPIARINFO.Name = "BTNLIMPIARINFO"
        Me.BTNLIMPIARINFO.Size = New System.Drawing.Size(154, 85)
        Me.BTNLIMPIARINFO.TabIndex = 30
        Me.BTNLIMPIARINFO.Text = "LIMPIAR INFORMACIÓN ALUMNO"
        Me.BTNLIMPIARINFO.UseVisualStyleBackColor = False
        '
        'BTNLIMPIARTOT
        '
        Me.BTNLIMPIARTOT.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BTNLIMPIARTOT.Location = New System.Drawing.Point(779, 298)
        Me.BTNLIMPIARTOT.Name = "BTNLIMPIARTOT"
        Me.BTNLIMPIARTOT.Size = New System.Drawing.Size(154, 85)
        Me.BTNLIMPIARTOT.TabIndex = 31
        Me.BTNLIMPIARTOT.Text = "LIMPIAR TOTALES"
        Me.BTNLIMPIARTOT.UseVisualStyleBackColor = False
        '
        'BTNLIMPIARMATRIZ
        '
        Me.BTNLIMPIARMATRIZ.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BTNLIMPIARMATRIZ.Location = New System.Drawing.Point(779, 199)
        Me.BTNLIMPIARMATRIZ.Name = "BTNLIMPIARMATRIZ"
        Me.BTNLIMPIARMATRIZ.Size = New System.Drawing.Size(154, 85)
        Me.BTNLIMPIARMATRIZ.TabIndex = 32
        Me.BTNLIMPIARMATRIZ.Text = "LIMPIAR MATRIZ"
        Me.BTNLIMPIARMATRIZ.UseVisualStyleBackColor = False
        '
        'BTNMOSTRARTOTALES
        '
        Me.BTNMOSTRARTOTALES.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BTNMOSTRARTOTALES.Location = New System.Drawing.Point(584, 297)
        Me.BTNMOSTRARTOTALES.Name = "BTNMOSTRARTOTALES"
        Me.BTNMOSTRARTOTALES.Size = New System.Drawing.Size(154, 85)
        Me.BTNMOSTRARTOTALES.TabIndex = 33
        Me.BTNMOSTRARTOTALES.Text = "MOSTRAR TOTALES"
        Me.BTNMOSTRARTOTALES.UseVisualStyleBackColor = False
        '
        'BTNELIMINARF
        '
        Me.BTNELIMINARF.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNELIMINARF.Location = New System.Drawing.Point(779, 411)
        Me.BTNELIMINARF.Name = "BTNELIMINARF"
        Me.BTNELIMINARF.Size = New System.Drawing.Size(154, 85)
        Me.BTNELIMINARF.TabIndex = 34
        Me.BTNELIMINARF.Text = "ELIMINAR FILA SELECCIONADA"
        Me.BTNELIMINARF.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1557, 825)
        Me.Controls.Add(Me.BTNELIMINARF)
        Me.Controls.Add(Me.BTNMOSTRARTOTALES)
        Me.Controls.Add(Me.BTNLIMPIARMATRIZ)
        Me.Controls.Add(Me.BTNLIMPIARTOT)
        Me.Controls.Add(Me.BTNLIMPIARINFO)
        Me.Controls.Add(Me.BTNSALIR)
        Me.Controls.Add(Me.BTNMOSTRARDATOS)
        Me.Controls.Add(Me.BTNCALCULAR)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RBNBASICOS As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents TBXCARNE As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TBXNOMBRE As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CBXCARRERA As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents RBNDIVERSIFICADO As RadioButton
    Friend WithEvents CBXFORMADEPAGO As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents DataGridView1 As DataGridView
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
    Friend WithEvents BTNCALCULAR As Button
    Friend WithEvents BTNMOSTRARDATOS As Button
    Friend WithEvents BTNSALIR As Button
    Friend WithEvents BTNLIMPIARINFO As Button
    Friend WithEvents BTNLIMPIARTOT As Button
    Friend WithEvents BTNLIMPIARMATRIZ As Button
    Friend WithEvents BTNMOSTRARTOTALES As Button
    Friend WithEvents TBXTOTALGEN As TextBox
    Friend WithEvents TBXTOTALDISE As TextBox
    Friend WithEvents TBXTOTALELEC As TextBox
    Friend WithEvents TBXTOTALBACH As TextBox
    Friend WithEvents TBXTOTALPER As TextBox
    Friend WithEvents TBXTOTALDIV As TextBox
    Friend WithEvents TBXTOTALBAS As TextBox
    Friend WithEvents TBXTOTALDEP As TextBox
    Friend WithEvents TBXTOTALTRANS As TextBox
    Friend WithEvents TBXTOTALTARJ As TextBox
    Friend WithEvents TBXTOTALEFEC As TextBox
    Friend WithEvents BTNELIMINARF As Button
End Class
