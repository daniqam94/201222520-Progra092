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
        Me.RBking = New System.Windows.Forms.RadioButton()
        Me.RBqueen = New System.Windows.Forms.RadioButton()
        Me.RBmatrimonial = New System.Windows.Forms.RadioButton()
        Me.RBimperial = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBhilocrudo = New System.Windows.Forms.TextBox()
        Me.TBseda = New System.Windows.Forms.TextBox()
        Me.TBalgodon = New System.Windows.Forms.TextBox()
        Me.TBlino = New System.Windows.Forms.TextBox()
        Me.CBhilocrudo = New System.Windows.Forms.CheckBox()
        Me.CBseda = New System.Windows.Forms.CheckBox()
        Me.CBalgodon = New System.Windows.Forms.CheckBox()
        Me.CBlino = New System.Windows.Forms.CheckBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CalcularToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(148, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(374, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FÁBRICA DE CUBRECAMAS"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RBking)
        Me.GroupBox1.Controls.Add(Me.RBqueen)
        Me.GroupBox1.Controls.Add(Me.RBmatrimonial)
        Me.GroupBox1.Controls.Add(Me.RBimperial)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(45, 99)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(229, 160)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tamaño de Cama"
        '
        'RBking
        '
        Me.RBking.AllowDrop = True
        Me.RBking.AutoSize = True
        Me.RBking.Location = New System.Drawing.Point(18, 112)
        Me.RBking.Name = "RBking"
        Me.RBking.Size = New System.Drawing.Size(65, 25)
        Me.RBking.TabIndex = 3
        Me.RBking.Text = "King"
        Me.RBking.UseVisualStyleBackColor = True
        '
        'RBqueen
        '
        Me.RBqueen.AllowDrop = True
        Me.RBqueen.AutoSize = True
        Me.RBqueen.Location = New System.Drawing.Point(18, 85)
        Me.RBqueen.Name = "RBqueen"
        Me.RBqueen.Size = New System.Drawing.Size(88, 25)
        Me.RBqueen.TabIndex = 2
        Me.RBqueen.Text = "Queen"
        Me.RBqueen.UseVisualStyleBackColor = True
        '
        'RBmatrimonial
        '
        Me.RBmatrimonial.AllowDrop = True
        Me.RBmatrimonial.AutoSize = True
        Me.RBmatrimonial.Location = New System.Drawing.Point(18, 58)
        Me.RBmatrimonial.Name = "RBmatrimonial"
        Me.RBmatrimonial.Size = New System.Drawing.Size(129, 25)
        Me.RBmatrimonial.TabIndex = 1
        Me.RBmatrimonial.Text = "Matrimonial"
        Me.RBmatrimonial.UseVisualStyleBackColor = True
        '
        'RBimperial
        '
        Me.RBimperial.AllowDrop = True
        Me.RBimperial.AutoSize = True
        Me.RBimperial.Location = New System.Drawing.Point(18, 31)
        Me.RBimperial.Name = "RBimperial"
        Me.RBimperial.Size = New System.Drawing.Size(97, 25)
        Me.RBimperial.TabIndex = 0
        Me.RBimperial.Text = "Imperial"
        Me.RBimperial.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TBhilocrudo)
        Me.GroupBox2.Controls.Add(Me.TBseda)
        Me.GroupBox2.Controls.Add(Me.TBalgodon)
        Me.GroupBox2.Controls.Add(Me.TBlino)
        Me.GroupBox2.Controls.Add(Me.CBhilocrudo)
        Me.GroupBox2.Controls.Add(Me.CBseda)
        Me.GroupBox2.Controls.Add(Me.CBalgodon)
        Me.GroupBox2.Controls.Add(Me.CBlino)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(306, 99)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(323, 223)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tipo de Material"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(120, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Cantidad (yardas)"
        '
        'TBhilocrudo
        '
        Me.TBhilocrudo.Location = New System.Drawing.Point(152, 162)
        Me.TBhilocrudo.Name = "TBhilocrudo"
        Me.TBhilocrudo.Size = New System.Drawing.Size(100, 28)
        Me.TBhilocrudo.TabIndex = 6
        Me.TBhilocrudo.Visible = False
        '
        'TBseda
        '
        Me.TBseda.Location = New System.Drawing.Point(152, 128)
        Me.TBseda.Name = "TBseda"
        Me.TBseda.Size = New System.Drawing.Size(100, 28)
        Me.TBseda.TabIndex = 5
        Me.TBseda.Visible = False
        '
        'TBalgodon
        '
        Me.TBalgodon.Location = New System.Drawing.Point(152, 94)
        Me.TBalgodon.Name = "TBalgodon"
        Me.TBalgodon.Size = New System.Drawing.Size(100, 28)
        Me.TBalgodon.TabIndex = 4
        Me.TBalgodon.Visible = False
        '
        'TBlino
        '
        Me.TBlino.Location = New System.Drawing.Point(152, 60)
        Me.TBlino.Name = "TBlino"
        Me.TBlino.Size = New System.Drawing.Size(100, 28)
        Me.TBlino.TabIndex = 3
        Me.TBlino.Visible = False
        '
        'CBhilocrudo
        '
        Me.CBhilocrudo.AutoSize = True
        Me.CBhilocrudo.Location = New System.Drawing.Point(17, 164)
        Me.CBhilocrudo.Name = "CBhilocrudo"
        Me.CBhilocrudo.Size = New System.Drawing.Size(115, 25)
        Me.CBhilocrudo.TabIndex = 3
        Me.CBhilocrudo.Text = "Hilo crudo"
        Me.CBhilocrudo.UseVisualStyleBackColor = True
        '
        'CBseda
        '
        Me.CBseda.AutoSize = True
        Me.CBseda.Location = New System.Drawing.Point(17, 128)
        Me.CBseda.Name = "CBseda"
        Me.CBseda.Size = New System.Drawing.Size(75, 25)
        Me.CBseda.TabIndex = 2
        Me.CBseda.Text = "Seda"
        Me.CBseda.UseVisualStyleBackColor = True
        '
        'CBalgodon
        '
        Me.CBalgodon.AutoSize = True
        Me.CBalgodon.Location = New System.Drawing.Point(17, 94)
        Me.CBalgodon.Name = "CBalgodon"
        Me.CBalgodon.Size = New System.Drawing.Size(103, 25)
        Me.CBalgodon.TabIndex = 1
        Me.CBalgodon.Text = "Algodon"
        Me.CBalgodon.UseVisualStyleBackColor = True
        '
        'CBlino
        '
        Me.CBlino.AutoSize = True
        Me.CBlino.Location = New System.Drawing.Point(17, 60)
        Me.CBlino.Name = "CBlino"
        Me.CBlino.Size = New System.Drawing.Size(64, 25)
        Me.CBlino.TabIndex = 0
        Me.CBlino.Text = "Lino"
        Me.CBlino.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalcularToolStripMenuItem, Me.LimpiarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(667, 28)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CalcularToolStripMenuItem
        '
        Me.CalcularToolStripMenuItem.Name = "CalcularToolStripMenuItem"
        Me.CalcularToolStripMenuItem.Size = New System.Drawing.Size(76, 24)
        Me.CalcularToolStripMenuItem.Text = "Calcular"
        '
        'LimpiarToolStripMenuItem
        '
        Me.LimpiarToolStripMenuItem.Name = "LimpiarToolStripMenuItem"
        Me.LimpiarToolStripMenuItem.Size = New System.Drawing.Size(73, 24)
        Me.LimpiarToolStripMenuItem.Text = "Limpiar"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(52, 24)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(667, 354)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Informacion"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RBking As RadioButton
    Friend WithEvents RBqueen As RadioButton
    Friend WithEvents RBmatrimonial As RadioButton
    Friend WithEvents RBimperial As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TBhilocrudo As TextBox
    Friend WithEvents TBseda As TextBox
    Friend WithEvents TBalgodon As TextBox
    Friend WithEvents TBlino As TextBox
    Friend WithEvents CBhilocrudo As CheckBox
    Friend WithEvents CBseda As CheckBox
    Friend WithEvents CBalgodon As CheckBox
    Friend WithEvents CBlino As CheckBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CalcularToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
End Class
