<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.Column26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(248, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(410, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "EMPLEADOS GASTOS SEMANAL"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.C, Me.NUM, Me.NOMBRE, Me.PLANTA, Me.PUESTO, Me.INGRESO, Me.SD, Me.CATEGORIA, Me.ESTATUS, Me.BANCO, Me.CUENTA, Me.FALTAS, Me.INCAPACIDAD, Me.RETARDOS, Me.FESTIVOS, Me.TIEMEXTRA, Me.ADEUDODEDIAS, Me.VACACIONESGOSADAS, Me.VACACIONESPAGADAS, Me.DIASTRABAJADOS, Me.PROPORCIONDDIAS, Me.Column22, Me.Column23, Me.Column24, Me.Column25, Me.Column26, Me.Column27, Me.Column28, Me.Column29, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11, Me.Column12, Me.Column13, Me.Column14, Me.Column15, Me.Column16})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 60)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(837, 293)
        Me.DataGridView1.TabIndex = 1
        '
        'C
        '
        Me.C.HeaderText = "C"
        Me.C.Name = "C"
        '
        'NUM
        '
        Me.NUM.HeaderText = "NUM"
        Me.NUM.Name = "NUM"
        '
        'NOMBRE
        '
        Me.NOMBRE.HeaderText = "NOMBRE"
        Me.NOMBRE.Name = "NOMBRE"
        '
        'PLANTA
        '
        Me.PLANTA.HeaderText = "PLANTA"
        Me.PLANTA.Name = "PLANTA"
        '
        'PUESTO
        '
        Me.PUESTO.HeaderText = "PUESTO"
        Me.PUESTO.Name = "PUESTO"
        '
        'INGRESO
        '
        Me.INGRESO.HeaderText = "INGRESO"
        Me.INGRESO.Name = "INGRESO"
        '
        'SD
        '
        Me.SD.HeaderText = "SD"
        Me.SD.Name = "SD"
        '
        'CATEGORIA
        '
        Me.CATEGORIA.HeaderText = "ESTATUS"
        Me.CATEGORIA.Name = "CATEGORIA"
        '
        'ESTATUS
        '
        Me.ESTATUS.HeaderText = "BANCOS"
        Me.ESTATUS.Name = "ESTATUS"
        '
        'BANCO
        '
        Me.BANCO.HeaderText = "CUENTA"
        Me.BANCO.Name = "BANCO"
        '
        'CUENTA
        '
        Me.CUENTA.HeaderText = "FALTAS"
        Me.CUENTA.Name = "CUENTA"
        '
        'FALTAS
        '
        Me.FALTAS.HeaderText = "INCAPACIDAD"
        Me.FALTAS.Name = "FALTAS"
        '
        'INCAPACIDAD
        '
        Me.INCAPACIDAD.HeaderText = "RETARDOS"
        Me.INCAPACIDAD.Name = "INCAPACIDAD"
        '
        'RETARDOS
        '
        Me.RETARDOS.HeaderText = "FESTIVOS"
        Me.RETARDOS.Name = "RETARDOS"
        '
        'FESTIVOS
        '
        Me.FESTIVOS.HeaderText = "DIAS TRAB"
        Me.FESTIVOS.Name = "FESTIVOS"
        '
        'TIEMEXTRA
        '
        Me.TIEMEXTRA.HeaderText = "PROPORCION DIAS TRAB"
        Me.TIEMEXTRA.Name = "TIEMEXTRA"
        '
        'ADEUDODEDIAS
        '
        Me.ADEUDODEDIAS.HeaderText = "SUELDO"
        Me.ADEUDODEDIAS.Name = "ADEUDODEDIAS"
        '
        'VACACIONESGOSADAS
        '
        Me.VACACIONESGOSADAS.HeaderText = "FONDO PATRONAL"
        Me.VACACIONESGOSADAS.Name = "VACACIONESGOSADAS"
        '
        'VACACIONESPAGADAS
        '
        Me.VACACIONESPAGADAS.HeaderText = "AYUDA A PASAJES"
        Me.VACACIONESPAGADAS.Name = "VACACIONESPAGADAS"
        '
        'DIASTRABAJADOS
        '
        Me.DIASTRABAJADOS.HeaderText = "INC.FIJOS"
        Me.DIASTRABAJADOS.Name = "DIASTRABAJADOS"
        '
        'PROPORCIONDDIAS
        '
        Me.PROPORCIONDDIAS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.PROPORCIONDDIAS.HeaderText = "INC VAR"
        Me.PROPORCIONDDIAS.Name = "PROPORCIONDDIAS"
        '
        'Column22
        '
        Me.Column22.HeaderText = "VAC"
        Me.Column22.Name = "Column22"
        '
        'Column23
        '
        Me.Column23.HeaderText = "PV"
        Me.Column23.Name = "Column23"
        '
        'Column24
        '
        Me.Column24.HeaderText = "FEST"
        Me.Column24.Name = "Column24"
        '
        'Column25
        '
        Me.Column25.HeaderText = "VALES DE DESPENSA"
        Me.Column25.Name = "Column25"
        '
        'Column26
        '
        Me.Column26.HeaderText = "PREMIO DE PUNTUALIDAD Y ASISTENCIA "
        Me.Column26.Name = "Column26"
        '
        'Column27
        '
        Me.Column27.HeaderText = "ADEUDO DE DIAS "
        Me.Column27.Name = "Column27"
        '
        'Column28
        '
        Me.Column28.HeaderText = "COMPENSACION"
        Me.Column28.Name = "Column28"
        '
        'Column29
        '
        Me.Column29.HeaderText = "OTROS CONCEPTOS"
        Me.Column29.Name = "Column29"
        '
        'Column1
        '
        Me.Column1.HeaderText = "TOTAL PERCEPCIONES"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "FONDO DE AHORRO"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "RETARDOS"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "PRESTAMO PERSONAL"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "PRESTAMO FONDO DE AHORRO"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "DESCUENTOS VARIOS"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "AUTOMOVIL"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "NOMINA FISCAL"
        Me.Column8.Name = "Column8"
        '
        'Column9
        '
        Me.Column9.HeaderText = "ASIMILADOS"
        Me.Column9.Name = "Column9"
        '
        'Column10
        '
        Me.Column10.HeaderText = "ISR 10%"
        Me.Column10.Name = "Column10"
        '
        'Column11
        '
        Me.Column11.HeaderText = "IVA10.6666667%"
        Me.Column11.Name = "Column11"
        '
        'Column12
        '
        Me.Column12.HeaderText = "TOTAL DEDUCCIONES"
        Me.Column12.Name = "Column12"
        '
        'Column13
        '
        Me.Column13.HeaderText = "TOTAL"
        Me.Column13.Name = "Column13"
        '
        'Column14
        '
        Me.Column14.HeaderText = "TOTAL A PAGAR GASTOS"
        Me.Column14.Name = "Column14"
        '
        'Column15
        '
        Me.Column15.HeaderText = "TOTAL A PAGAR FISCAL"
        Me.Column15.Name = "Column15"
        '
        'Column16
        '
        Me.Column16.HeaderText = "TOTAL A PAGAR"
        Me.Column16.Name = "Column16"
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(688, 401)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 37)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(487, 401)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(141, 37)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Menu Principal"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(340, 401)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(141, 37)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Imprimir"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(850, 450)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(850, 450)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Form4"
        Me.Text = "Form4"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
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
    Friend WithEvents Column26 As DataGridViewTextBoxColumn
    Friend WithEvents Column27 As DataGridViewTextBoxColumn
    Friend WithEvents Column28 As DataGridViewTextBoxColumn
    Friend WithEvents Column29 As DataGridViewTextBoxColumn
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
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
    Friend WithEvents Column15 As DataGridViewTextBoxColumn
    Friend WithEvents Column16 As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As PictureBox
End Class
