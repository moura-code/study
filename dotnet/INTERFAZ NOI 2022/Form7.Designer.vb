<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form7))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.C = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PLANTA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PUESTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.INGRESO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CATEGORIA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESTATUS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BANCO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUENTA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FALTAS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.INCAPACIDAD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RETARDOS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FESTIVOS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIEMEXTRA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ADEUDODEDIAS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VACACIONESGOSADAS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VACACIONESPAGADAS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DIASTRABAJADOS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PROPORCIONDDIAS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(825, 450)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.C, Me.NUM, Me.NOMBRE, Me.PLANTA, Me.PUESTO, Me.INGRESO, Me.SD, Me.CATEGORIA, Me.ESTATUS, Me.BANCO, Me.CUENTA, Me.FALTAS, Me.INCAPACIDAD, Me.RETARDOS, Me.FESTIVOS, Me.TIEMEXTRA, Me.ADEUDODEDIAS, Me.VACACIONESGOSADAS, Me.VACACIONESPAGADAS, Me.DIASTRABAJADOS, Me.PROPORCIONDDIAS, Me.Column22, Me.Column23, Me.Column24, Me.Column25})
        Me.DataGridView1.Location = New System.Drawing.Point(0, 134)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(825, 245)
        Me.DataGridView1.TabIndex = 10
        '
        'C
        '
        Me.C.HeaderText = "C"
        Me.C.Name = "C"
        '
        'NUM
        '
        Me.NUM.HeaderText = "NUMGASTO"
        Me.NUM.Name = "NUM"
        '
        'NOMBRE
        '
        Me.NOMBRE.HeaderText = "NUM"
        Me.NOMBRE.Name = "NOMBRE"
        '
        'PLANTA
        '
        Me.PLANTA.HeaderText = "NOMBRE"
        Me.PLANTA.Name = "PLANTA"
        '
        'PUESTO
        '
        Me.PUESTO.HeaderText = "AREA/UNIDAD"
        Me.PUESTO.Name = "PUESTO"
        '
        'INGRESO
        '
        Me.INGRESO.HeaderText = "PUESTO"
        Me.INGRESO.Name = "INGRESO"
        '
        'SD
        '
        Me.SD.HeaderText = "ALTA"
        Me.SD.Name = "SD"
        '
        'CATEGORIA
        '
        Me.CATEGORIA.HeaderText = "ANTIGUEDAD"
        Me.CATEGORIA.Name = "CATEGORIA"
        '
        'ESTATUS
        '
        Me.ESTATUS.HeaderText = "SDEX"
        Me.ESTATUS.Name = "ESTATUS"
        '
        'BANCO
        '
        Me.BANCO.HeaderText = "NSS"
        Me.BANCO.Name = "BANCO"
        '
        'CUENTA
        '
        Me.CUENTA.HeaderText = "EMPRESA"
        Me.CUENTA.Name = "CUENTA"
        '
        'FALTAS
        '
        Me.FALTAS.HeaderText = "BANCO"
        Me.FALTAS.Name = "FALTAS"
        '
        'INCAPACIDAD
        '
        Me.INCAPACIDAD.HeaderText = "CUENTA"
        Me.INCAPACIDAD.Name = "INCAPACIDAD"
        '
        'RETARDOS
        '
        Me.RETARDOS.HeaderText = "FALTAS"
        Me.RETARDOS.Name = "RETARDOS"
        '
        'FESTIVOS
        '
        Me.FESTIVOS.HeaderText = "INC"
        Me.FESTIVOS.Name = "FESTIVOS"
        '
        'TIEMEXTRA
        '
        Me.TIEMEXTRA.HeaderText = "DIAS TRAB"
        Me.TIEMEXTRA.Name = "TIEMEXTRA"
        '
        'ADEUDODEDIAS
        '
        Me.ADEUDODEDIAS.HeaderText = "PROPORCION N DIAS TRAB"
        Me.ADEUDODEDIAS.Name = "ADEUDODEDIAS"
        '
        'VACACIONESGOSADAS
        '
        Me.VACACIONESGOSADAS.HeaderText = "SUELDO"
        Me.VACACIONESGOSADAS.Name = "VACACIONESGOSADAS"
        '
        'VACACIONESPAGADAS
        '
        Me.VACACIONESPAGADAS.HeaderText = "SUBSIDIO"
        Me.VACACIONESPAGADAS.Name = "VACACIONESPAGADAS"
        '
        'DIASTRABAJADOS
        '
        Me.DIASTRABAJADOS.HeaderText = "IMSS"
        Me.DIASTRABAJADOS.Name = "DIASTRABAJADOS"
        '
        'PROPORCIONDDIAS
        '
        Me.PROPORCIONDDIAS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.PROPORCIONDDIAS.HeaderText = "INFONAVIT"
        Me.PROPORCIONDDIAS.Name = "PROPORCIONDDIAS"
        '
        'Column22
        '
        Me.Column22.HeaderText = "PENSION ALIMENTICIA"
        Me.Column22.Name = "Column22"
        '
        'Column23
        '
        Me.Column23.HeaderText = "TOTAL DEDUCCIONES"
        Me.Column23.Name = "Column23"
        '
        'Column24
        '
        Me.Column24.HeaderText = "TOTAL A PAGAR"
        Me.Column24.Name = "Column24"
        '
        'Column25
        '
        Me.Column25.HeaderText = "TOTAL DESCUENTO"
        Me.Column25.Name = "Column25"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(221, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(392, 29)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "EMPLEADOS FISCAL SEMANAL"
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(825, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form7"
        Me.Text = "Form7"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents C As DataGridViewTextBoxColumn
    Friend WithEvents NUM As DataGridViewTextBoxColumn
    Friend WithEvents NOMBRE As DataGridViewTextBoxColumn
    Friend WithEvents PLANTA As DataGridViewTextBoxColumn
    Friend WithEvents PUESTO As DataGridViewTextBoxColumn
    Friend WithEvents INGRESO As DataGridViewTextBoxColumn
    Friend WithEvents SD As DataGridViewTextBoxColumn
    Friend WithEvents CATEGORIA As DataGridViewTextBoxColumn
    Friend WithEvents ESTATUS As DataGridViewTextBoxColumn
    Friend WithEvents BANCO As DataGridViewTextBoxColumn
    Friend WithEvents CUENTA As DataGridViewTextBoxColumn
    Friend WithEvents FALTAS As DataGridViewTextBoxColumn
    Friend WithEvents INCAPACIDAD As DataGridViewTextBoxColumn
    Friend WithEvents RETARDOS As DataGridViewTextBoxColumn
    Friend WithEvents FESTIVOS As DataGridViewTextBoxColumn
    Friend WithEvents TIEMEXTRA As DataGridViewTextBoxColumn
    Friend WithEvents ADEUDODEDIAS As DataGridViewTextBoxColumn
    Friend WithEvents VACACIONESGOSADAS As DataGridViewTextBoxColumn
    Friend WithEvents VACACIONESPAGADAS As DataGridViewTextBoxColumn
    Friend WithEvents DIASTRABAJADOS As DataGridViewTextBoxColumn
    Friend WithEvents PROPORCIONDDIAS As DataGridViewTextBoxColumn
    Friend WithEvents Column22 As DataGridViewTextBoxColumn
    Friend WithEvents Column23 As DataGridViewTextBoxColumn
    Friend WithEvents Column24 As DataGridViewTextBoxColumn
    Friend WithEvents Column25 As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
End Class
