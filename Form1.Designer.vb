<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class txtNome
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.textId = New System.Windows.Forms.TextBox()
        Me.textNome = New System.Windows.Forms.TextBox()
        Me.textEndereco = New System.Windows.Forms.TextBox()
        Me.textNumero = New System.Windows.Forms.TextBox()
        Me.btnIncluir = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnDeletar = New System.Windows.Forms.Button()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.btnListar = New System.Windows.Forms.Button()
        Me.dgvDados = New System.Windows.Forms.DataGridView()
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'textId
        '
        Me.textId.AutoSize = True
        Me.textId.Location = New System.Drawing.Point(55, 46)
        Me.textId.Name = "textId"
        Me.textId.Size = New System.Drawing.Size(17, 15)
        Me.textId.TabIndex = 6
        Me.textId.Text = "Id"
        '
        'textNome
        '
        Me.textNome.AutoSize = True
        Me.textNome.Location = New System.Drawing.Point(55, 75)
        Me.textNome.Name = "textNome"
        Me.textNome.Size = New System.Drawing.Size(40, 15)
        Me.textNome.TabIndex = 7
        Me.textNome.Text = "Nome"
        '
        'textEndereco
        '
        Me.textEndereco.AutoSize = True
        Me.textEndereco.Location = New System.Drawing.Point(55, 101)
        Me.textEndereco.Name = "textEndereco"
        Me.textEndereco.Size = New System.Drawing.Size(56, 15)
        Me.textEndereco.TabIndex = 8
        Me.textEndereco.Text = "Endereco"
        '
        'textNumero
        '
        Me.textNumero.AutoSize = True
        Me.textNumero.Location = New System.Drawing.Point(55, 133)
        Me.textNumero.Name = "textNumero"
        Me.textNumero.Size = New System.Drawing.Size(51, 15)
        Me.textNumero.TabIndex = 9
        Me.textNumero.Text = "Numero"
        '
        'btnIncluir
        '
        Me.btnIncluir.Location = New System.Drawing.Point(147, 170)
        Me.btnIncluir.Name = "btnIncluir"
        Me.btnIncluir.Size = New System.Drawing.Size(76, 23)
        Me.btnIncluir.TabIndex = 16
        Me.btnIncluir.Text = "Incluir"
        Me.btnIncluir.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(239, 170)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(75, 23)
        Me.btnEditar.TabIndex = 17
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnDeletar
        '
        Me.btnDeletar.Location = New System.Drawing.Point(330, 170)
        Me.btnDeletar.Name = "btnDeletar"
        Me.btnDeletar.Size = New System.Drawing.Size(75, 23)
        Me.btnDeletar.TabIndex = 18
        Me.btnDeletar.Text = "Deletar"
        Me.btnDeletar.UseVisualStyleBackColor = True
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(420, 170)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(75, 23)
        Me.btnConsultar.TabIndex = 19
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'btnListar
        '
        Me.btnListar.Location = New System.Drawing.Point(510, 170)
        Me.btnListar.Name = "btnListar"
        Me.btnListar.Size = New System.Drawing.Size(75, 23)
        Me.btnListar.TabIndex = 20
        Me.btnListar.Text = "Listar"
        Me.btnListar.UseVisualStyleBackColor = True
        '
        'dgvDados
        '
        Me.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDados.Location = New System.Drawing.Point(147, 217)
        Me.dgvDados.Name = "dgvDados"
        Me.dgvDados.RowTemplate.Height = 25
        Me.dgvDados.Size = New System.Drawing.Size(616, 253)
        Me.dgvDados.TabIndex = 25
        '
        'txtNome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(1029, 584)
        Me.Controls.Add(Me.dgvDados)
        Me.Controls.Add(Me.btnListar)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.btnDeletar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnIncluir)
        Me.Controls.Add(Me.textNumero)
        Me.Controls.Add(Me.textEndereco)
        Me.Controls.Add(Me.textNome)
        Me.Controls.Add(Me.textId)

        Me.Name = "txtNome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Clientes"
        CType(Me.dgvDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents textId As TextBox
    Friend WithEvents textNome As TextBox
    Friend WithEvents textEndereco As TextBox
    Friend WithEvents textNumero As TextBox
    Friend WithEvents btnIncluir As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnDeletar As Button
    Friend WithEvents btnConsultar As Button
    Friend WithEvents btnListar As Button
    Friend WithEvents dgvDados As DataGridView
End Class
