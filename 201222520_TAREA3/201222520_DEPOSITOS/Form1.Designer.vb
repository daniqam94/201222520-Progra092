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
        Me.AHO = New System.Windows.Forms.RadioButton()
        Me.MONP = New System.Windows.Forms.RadioButton()
        Me.MON = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.EFECC = New System.Windows.Forms.TextBox()
        Me.CHEOBC = New System.Windows.Forms.TextBox()
        Me.CHEPC = New System.Windows.Forms.TextBox()
        Me.EFEC = New System.Windows.Forms.CheckBox()
        Me.CHEOB = New System.Windows.Forms.CheckBox()
        Me.CHEP = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CALC = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SALDA = New System.Windows.Forms.TextBox()
        Me.LIMP = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SALDF = New System.Windows.Forms.TextBox()
        Me.SALIR = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "BANCO"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.AHO)
        Me.GroupBox1.Controls.Add(Me.MONP)
        Me.GroupBox1.Controls.Add(Me.MON)
        Me.GroupBox1.Location = New System.Drawing.Point(32, 109)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(183, 154)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo de depósito"
        '
        'AHO
        '
        Me.AHO.AutoSize = True
        Me.AHO.Location = New System.Drawing.Point(21, 115)
        Me.AHO.Name = "AHO"
        Me.AHO.Size = New System.Drawing.Size(79, 21)
        Me.AHO.TabIndex = 4
        Me.AHO.TabStop = True
        Me.AHO.Text = "Ahorros"
        Me.AHO.UseVisualStyleBackColor = True
        '
        'MONP
        '
        Me.MONP.AutoSize = True
        Me.MONP.Location = New System.Drawing.Point(21, 79)
        Me.MONP.Name = "MONP"
        Me.MONP.Size = New System.Drawing.Size(152, 21)
        Me.MONP.TabIndex = 3
        Me.MONP.TabStop = True
        Me.MONP.Text = "Monetarios Premier"
        Me.MONP.UseVisualStyleBackColor = True
        '
        'MON
        '
        Me.MON.AccessibleRole = System.Windows.Forms.AccessibleRole.Separator
        Me.MON.AutoSize = True
        Me.MON.Location = New System.Drawing.Point(21, 43)
        Me.MON.Name = "MON"
        Me.MON.Size = New System.Drawing.Size(99, 21)
        Me.MON.TabIndex = 2
        Me.MON.TabStop = True
        Me.MON.Text = "Monetarios"
        Me.MON.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.EFECC)
        Me.GroupBox2.Controls.Add(Me.CHEOBC)
        Me.GroupBox2.Controls.Add(Me.CHEPC)
        Me.GroupBox2.Controls.Add(Me.EFEC)
        Me.GroupBox2.Controls.Add(Me.CHEOB)
        Me.GroupBox2.Controls.Add(Me.CHEP)
        Me.GroupBox2.Location = New System.Drawing.Point(242, 110)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(369, 153)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Método de depósito"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(215, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Q."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(215, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Q."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(215, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Q."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(215, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Monto:"
        '
        'EFECC
        '
        Me.EFECC.Location = New System.Drawing.Point(242, 113)
        Me.EFECC.Name = "EFECC"
        Me.EFECC.Size = New System.Drawing.Size(107, 22)
        Me.EFECC.TabIndex = 3
        Me.EFECC.Visible = False
        '
        'CHEOBC
        '
        Me.CHEOBC.Location = New System.Drawing.Point(242, 78)
        Me.CHEOBC.Name = "CHEOBC"
        Me.CHEOBC.Size = New System.Drawing.Size(107, 22)
        Me.CHEOBC.TabIndex = 2
        Me.CHEOBC.Visible = False
        '
        'CHEPC
        '
        Me.CHEPC.Location = New System.Drawing.Point(242, 38)
        Me.CHEPC.Name = "CHEPC"
        Me.CHEPC.Size = New System.Drawing.Size(107, 22)
        Me.CHEPC.TabIndex = 1
        Me.CHEPC.Visible = False
        '
        'EFEC
        '
        Me.EFEC.AutoSize = True
        Me.EFEC.Location = New System.Drawing.Point(20, 115)
        Me.EFEC.Name = "EFEC"
        Me.EFEC.Size = New System.Drawing.Size(80, 21)
        Me.EFEC.TabIndex = 3
        Me.EFEC.Text = "Efectivo"
        Me.EFEC.UseVisualStyleBackColor = True
        '
        'CHEOB
        '
        Me.CHEOB.AutoSize = True
        Me.CHEOB.Location = New System.Drawing.Point(20, 78)
        Me.CHEOB.Name = "CHEOB"
        Me.CHEOB.Size = New System.Drawing.Size(171, 21)
        Me.CHEOB.TabIndex = 3
        Me.CHEOB.Text = "Cheque de otro banco"
        Me.CHEOB.UseVisualStyleBackColor = True
        '
        'CHEP
        '
        Me.CHEP.AutoSize = True
        Me.CHEP.Location = New System.Drawing.Point(20, 42)
        Me.CHEP.Name = "CHEP"
        Me.CHEP.Size = New System.Drawing.Size(123, 21)
        Me.CHEP.TabIndex = 3
        Me.CHEP.Text = "Cheque propio"
        Me.CHEP.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CALC)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.SALDA)
        Me.GroupBox3.Location = New System.Drawing.Point(631, 110)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(143, 153)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Saldo anterior"
        '
        'CALC
        '
        Me.CALC.Location = New System.Drawing.Point(20, 81)
        Me.CALC.Name = "CALC"
        Me.CALC.Size = New System.Drawing.Size(106, 54)
        Me.CALC.TabIndex = 4
        Me.CALC.Text = "CALCULAR"
        Me.CALC.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 17)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Q."
        '
        'SALDA
        '
        Me.SALDA.Location = New System.Drawing.Point(37, 38)
        Me.SALDA.Name = "SALDA"
        Me.SALDA.Size = New System.Drawing.Size(89, 22)
        Me.SALDA.TabIndex = 4
        '
        'LIMP
        '
        Me.LIMP.Location = New System.Drawing.Point(242, 364)
        Me.LIMP.Name = "LIMP"
        Me.LIMP.Size = New System.Drawing.Size(127, 60)
        Me.LIMP.TabIndex = 4
        Me.LIMP.Text = "LIMPIAR"
        Me.LIMP.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(50, 285)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(130, 20)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "SALDO FINAL"
        '
        'SALDF
        '
        Me.SALDF.Enabled = False
        Me.SALDF.Location = New System.Drawing.Point(226, 285)
        Me.SALDF.Name = "SALDF"
        Me.SALDF.Size = New System.Drawing.Size(100, 22)
        Me.SALDF.TabIndex = 6
        '
        'SALIR
        '
        Me.SALIR.Location = New System.Drawing.Point(415, 364)
        Me.SALIR.Name = "SALIR"
        Me.SALIR.Size = New System.Drawing.Size(134, 60)
        Me.SALIR.TabIndex = 7
        Me.SALIR.Text = "SALIR"
        Me.SALIR.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(197, 285)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(23, 17)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Q."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.SALIR)
        Me.Controls.Add(Me.SALDF)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LIMP)
        Me.Controls.Add(Me.GroupBox3)
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
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents AHO As RadioButton
    Friend WithEvents MONP As RadioButton
    Friend WithEvents MON As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents EFECC As TextBox
    Friend WithEvents CHEOBC As TextBox
    Friend WithEvents CHEPC As TextBox
    Friend WithEvents EFEC As CheckBox
    Friend WithEvents CHEOB As CheckBox
    Friend WithEvents CHEP As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents CALC As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents SALDA As TextBox
    Friend WithEvents LIMP As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents SALDF As TextBox
    Friend WithEvents SALIR As Button
    Friend WithEvents Label8 As Label
End Class
