<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormListarProdutos
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btn_filtrar = New System.Windows.Forms.Button()
        Me.dgv_dados = New System.Windows.Forms.DataGridView()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_parametro = New System.Windows.Forms.TextBox()
        Me.cb_selecione = New System.Windows.Forms.ComboBox()
        Me.cb_preço = New System.Windows.Forms.CheckBox()
        Me.cod_prod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeProd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Valor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QtdEstoque = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fornecedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlternarStatus = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Excluir = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_filtrar
        '
        Me.btn_filtrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_filtrar.Location = New System.Drawing.Point(497, 24)
        Me.btn_filtrar.Name = "btn_filtrar"
        Me.btn_filtrar.Size = New System.Drawing.Size(121, 32)
        Me.btn_filtrar.TabIndex = 15
        Me.btn_filtrar.Text = "Filtrar"
        Me.btn_filtrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btn_filtrar.UseVisualStyleBackColor = True
        '
        'dgv_dados
        '
        Me.dgv_dados.AllowUserToAddRows = False
        Me.dgv_dados.AllowUserToDeleteRows = False
        Me.dgv_dados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_dados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cod_prod, Me.NomeProd, Me.Valor, Me.QtdEstoque, Me.Fornecedor, Me.AlternarStatus, Me.Excluir})
        Me.dgv_dados.Location = New System.Drawing.Point(12, 62)
        Me.dgv_dados.MultiSelect = False
        Me.dgv_dados.Name = "dgv_dados"
        Me.dgv_dados.ReadOnly = True
        Me.dgv_dados.Size = New System.Drawing.Size(606, 346)
        Me.dgv_dados.TabIndex = 10
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(199, 9)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(98, 13)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "PESQUISAR POR:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(8, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(185, 13)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "DIGITE O PARÂMETRO DE BUSCA:"
        '
        'txt_parametro
        '
        Me.txt_parametro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_parametro.Location = New System.Drawing.Point(11, 31)
        Me.txt_parametro.Name = "txt_parametro"
        Me.txt_parametro.Size = New System.Drawing.Size(182, 20)
        Me.txt_parametro.TabIndex = 11
        '
        'cb_selecione
        '
        Me.cb_selecione.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cb_selecione.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_selecione.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_selecione.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb_selecione.FormattingEnabled = True
        Me.cb_selecione.Items.AddRange(New Object() {"Código do Produto", "Nome", "Categoria", "Fornecedor"})
        Me.cb_selecione.Location = New System.Drawing.Point(199, 30)
        Me.cb_selecione.Name = "cb_selecione"
        Me.cb_selecione.Size = New System.Drawing.Size(154, 21)
        Me.cb_selecione.TabIndex = 16
        '
        'cb_preço
        '
        Me.cb_preço.AutoSize = True
        Me.cb_preço.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb_preço.Location = New System.Drawing.Point(361, 33)
        Me.cb_preço.Name = "cb_preço"
        Me.cb_preço.Size = New System.Drawing.Size(109, 17)
        Me.cb_preço.TabIndex = 17
        Me.cb_preço.Text = "Ordenar por preço"
        Me.cb_preço.UseVisualStyleBackColor = True
        '
        'cod_prod
        '
        Me.cod_prod.HeaderText = "Código"
        Me.cod_prod.Name = "cod_prod"
        Me.cod_prod.ReadOnly = True
        '
        'NomeProd
        '
        Me.NomeProd.HeaderText = "Nome"
        Me.NomeProd.Name = "NomeProd"
        Me.NomeProd.ReadOnly = True
        '
        'Valor
        '
        Me.Valor.HeaderText = "Valor"
        Me.Valor.Name = "Valor"
        Me.Valor.ReadOnly = True
        '
        'QtdEstoque
        '
        Me.QtdEstoque.HeaderText = "Qtd Estoque"
        Me.QtdEstoque.Name = "QtdEstoque"
        Me.QtdEstoque.ReadOnly = True
        '
        'Fornecedor
        '
        Me.Fornecedor.HeaderText = "Fornecedor"
        Me.Fornecedor.Name = "Fornecedor"
        Me.Fornecedor.ReadOnly = True
        '
        'AlternarStatus
        '
        Me.AlternarStatus.HeaderText = "Editar"
        Me.AlternarStatus.Image = Global.Sistema_Papelaria.My.Resources.Resources.ic_create_black_24dp_2x
        Me.AlternarStatus.Name = "AlternarStatus"
        Me.AlternarStatus.ReadOnly = True
        Me.AlternarStatus.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AlternarStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Excluir
        '
        Me.Excluir.HeaderText = "Excluir"
        Me.Excluir.Image = Global.Sistema_Papelaria.My.Resources.Resources.ic_delete_forever_black_24dp_2x
        Me.Excluir.Name = "Excluir"
        Me.Excluir.ReadOnly = True
        '
        'FormListarProdutos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(632, 422)
        Me.Controls.Add(Me.cb_preço)
        Me.Controls.Add(Me.cb_selecione)
        Me.Controls.Add(Me.btn_filtrar)
        Me.Controls.Add(Me.dgv_dados)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txt_parametro)
        Me.Name = "FormListarProdutos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listar Produtos"
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_filtrar As Button
    Friend WithEvents dgv_dados As DataGridView
    Friend WithEvents Label12 As Windows.Forms.Label
    Friend WithEvents Label11 As Windows.Forms.Label
    Friend WithEvents txt_parametro As TextBox
    Private WithEvents cb_selecione As ComboBox
    Friend WithEvents cb_preço As CheckBox
    Friend WithEvents cod_prod As DataGridViewTextBoxColumn
    Friend WithEvents NomeProd As DataGridViewTextBoxColumn
    Friend WithEvents Valor As DataGridViewTextBoxColumn
    Friend WithEvents QtdEstoque As DataGridViewTextBoxColumn
    Friend WithEvents Fornecedor As DataGridViewTextBoxColumn
    Friend WithEvents AlternarStatus As DataGridViewImageColumn
    Friend WithEvents Excluir As DataGridViewImageColumn
End Class
