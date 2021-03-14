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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnVer = New System.Windows.Forms.Button()
        Me.dgvEscuela = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCancelar1 = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.txtNombreAct = New System.Windows.Forms.TextBox()
        Me.txtCodAct = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.dgvBuscado = New System.Windows.Forms.DataGridView()
        Me.cboCriterio = New System.Windows.Forms.ComboBox()
        Me.txtNombreBuscado = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvEscuela, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.dgvBuscado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(765, 291)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnVer)
        Me.TabPage1.Controls.Add(Me.dgvEscuela)
        Me.TabPage1.Location = New System.Drawing.Point(4, 28)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(757, 259)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Lista de Escuelas"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnVer
        '
        Me.btnVer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVer.Location = New System.Drawing.Point(602, 197)
        Me.btnVer.Margin = New System.Windows.Forms.Padding(4)
        Me.btnVer.Name = "btnVer"
        Me.btnVer.Size = New System.Drawing.Size(146, 53)
        Me.btnVer.TabIndex = 1
        Me.btnVer.Text = "VER"
        Me.btnVer.UseVisualStyleBackColor = True
        '
        'dgvEscuela
        '
        Me.dgvEscuela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEscuela.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvEscuela.Location = New System.Drawing.Point(4, 4)
        Me.dgvEscuela.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvEscuela.Name = "dgvEscuela"
        Me.dgvEscuela.Size = New System.Drawing.Size(749, 251)
        Me.dgvEscuela.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtNombre)
        Me.TabPage2.Controls.Add(Me.txtCodigo)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.btnCancelar1)
        Me.TabPage2.Controls.Add(Me.btnAgregar)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 28)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Size = New System.Drawing.Size(757, 259)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Agregar"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(134, 60)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(340, 26)
        Me.txtNombre.TabIndex = 1
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(134, 22)
        Me.txtCodigo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(340, 26)
        Me.txtCodigo.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 64)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nombre:"
        '
        'btnCancelar1
        '
        Me.btnCancelar1.Location = New System.Drawing.Point(255, 114)
        Me.btnCancelar1.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancelar1.Name = "btnCancelar1"
        Me.btnCancelar1.Size = New System.Drawing.Size(112, 60)
        Me.btnCancelar1.TabIndex = 3
        Me.btnCancelar1.Text = "Cancelar"
        Me.btnCancelar1.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(134, 114)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(112, 60)
        Me.btnAgregar.TabIndex = 2
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo:"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.txtNombreAct)
        Me.TabPage3.Controls.Add(Me.txtCodAct)
        Me.TabPage3.Controls.Add(Me.Label3)
        Me.TabPage3.Controls.Add(Me.btnEliminar)
        Me.TabPage3.Controls.Add(Me.btnActualizar)
        Me.TabPage3.Controls.Add(Me.Label4)
        Me.TabPage3.Location = New System.Drawing.Point(4, 28)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(757, 259)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Actualizar"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'txtNombreAct
        '
        Me.txtNombreAct.Location = New System.Drawing.Point(132, 57)
        Me.txtNombreAct.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombreAct.Name = "txtNombreAct"
        Me.txtNombreAct.Size = New System.Drawing.Size(340, 26)
        Me.txtNombreAct.TabIndex = 1
        '
        'txtCodAct
        '
        Me.txtCodAct.Location = New System.Drawing.Point(132, 19)
        Me.txtCodAct.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCodAct.Name = "txtCodAct"
        Me.txtCodAct.Size = New System.Drawing.Size(340, 26)
        Me.txtCodAct.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 61)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 19)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nombre:"
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(254, 111)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(112, 60)
        Me.btnEliminar.TabIndex = 3
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(132, 111)
        Me.btnActualizar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(112, 60)
        Me.btnActualizar.TabIndex = 2
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 23)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 19)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Codigo:"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.dgvBuscado)
        Me.TabPage4.Controls.Add(Me.cboCriterio)
        Me.TabPage4.Controls.Add(Me.txtNombreBuscado)
        Me.TabPage4.Controls.Add(Me.Label5)
        Me.TabPage4.Controls.Add(Me.btnBuscar)
        Me.TabPage4.Controls.Add(Me.Label6)
        Me.TabPage4.Location = New System.Drawing.Point(4, 28)
        Me.TabPage4.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(757, 259)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Buscar"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'dgvBuscado
        '
        Me.dgvBuscado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvBuscado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBuscado.Location = New System.Drawing.Point(16, 53)
        Me.dgvBuscado.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvBuscado.Name = "dgvBuscado"
        Me.dgvBuscado.Size = New System.Drawing.Size(725, 183)
        Me.dgvBuscado.TabIndex = 16
        '
        'cboCriterio
        '
        Me.cboCriterio.FormattingEnabled = True
        Me.cboCriterio.Items.AddRange(New Object() {"CodEscuela", "Escuela"})
        Me.cboCriterio.Location = New System.Drawing.Point(441, 15)
        Me.cboCriterio.Margin = New System.Windows.Forms.Padding(4)
        Me.cboCriterio.Name = "cboCriterio"
        Me.cboCriterio.Size = New System.Drawing.Size(121, 27)
        Me.cboCriterio.TabIndex = 1
        Me.cboCriterio.Text = "Escuela"
        '
        'txtNombreBuscado
        '
        Me.txtNombreBuscado.Location = New System.Drawing.Point(92, 15)
        Me.txtNombreBuscado.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombreBuscado.Name = "txtNombreBuscado"
        Me.txtNombreBuscado.Size = New System.Drawing.Size(240, 26)
        Me.txtNombreBuscado.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 19)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 19)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Nombre:"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(609, 13)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(112, 31)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(343, 18)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 19)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Criterio:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(765, 291)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Crud Escuela"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgvEscuela, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.dgvBuscado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btnVer As Button
    Friend WithEvents dgvEscuela As DataGridView
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCancelar1 As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents txtNombreAct As TextBox
    Friend WithEvents txtCodAct As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents txtNombreBuscado As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents cboCriterio As ComboBox
    Friend WithEvents dgvBuscado As DataGridView
End Class
