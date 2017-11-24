<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormListarFornecedores
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgv_forn = New System.Windows.Forms.DataGridView()
        Me.btn_filtrar = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_parametro = New System.Windows.Forms.TextBox()
        Me.cb_selecione = New System.Windows.Forms.ComboBox()
        Me.CNPJ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nome_Forn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Contato = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Responsavel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VerProdutos = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Editar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Excluir = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.dgv_forn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_forn
        '
        Me.dgv_forn.AllowUserToAddRows = False
        Me.dgv_forn.AllowUserToDeleteRows = False
        Me.dgv_forn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_forn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_forn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_forn.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CNPJ, Me.Nome_Forn, Me.Contato, Me.Responsavel, Me.VerProdutos, Me.Editar, Me.Excluir})
        Me.dgv_forn.Location = New System.Drawing.Point(12, 73)
        Me.dgv_forn.Name = "dgv_forn"
        Me.dgv_forn.ReadOnly = True
        Me.dgv_forn.Size = New System.Drawing.Size(607, 348)
        Me.dgv_forn.TabIndex = 0
        '
        'btn_filtrar
        '
        Me.btn_filtrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_filtrar.Location = New System.Drawing.Point(498, 25)
        Me.btn_filtrar.Name = "btn_filtrar"
        Me.btn_filtrar.Size = New System.Drawing.Size(121, 32)
        Me.btn_filtrar.TabIndex = 14
        Me.btn_filtrar.Text = "Filtrar"
        Me.btn_filtrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btn_filtrar.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(335, 10)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(98, 13)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "PESQUISAR POR:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 10)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(185, 13)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "DIGITE O PARÂMETRO DE BUSCA:"
        '
        'txt_parametro
        '
        Me.txt_parametro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_parametro.Location = New System.Drawing.Point(12, 32)
        Me.txt_parametro.Name = "txt_parametro"
        Me.txt_parametro.Size = New System.Drawing.Size(320, 20)
        Me.txt_parametro.TabIndex = 10
        '
        'cb_selecione
        '
        Me.cb_selecione.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cb_selecione.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_selecione.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_selecione.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb_selecione.FormattingEnabled = True
        Me.cb_selecione.Items.AddRange(New Object() {"CNPJ", "Nome do Fornecedor", "Responsável"})
        Me.cb_selecione.Location = New System.Drawing.Point(338, 31)
        Me.cb_selecione.Name = "cb_selecione"
        Me.cb_selecione.Size = New System.Drawing.Size(154, 21)
        Me.cb_selecione.TabIndex = 15
        '
        'CNPJ
        '
        Me.CNPJ.HeaderText = "CNPJ"
        Me.CNPJ.Name = "CNPJ"
        Me.CNPJ.ReadOnly = True
        '
        'Nome_Forn
        '
        Me.Nome_Forn.HeaderText = "Nome do Fornecedor"
        Me.Nome_Forn.Name = "Nome_Forn"
        Me.Nome_Forn.ReadOnly = True
        '
        'Contato
        '
        Me.Contato.HeaderText = "Telefone"
        Me.Contato.Name = "Contato"
        Me.Contato.ReadOnly = True
        '
        'Responsavel
        '
        Me.Responsavel.HeaderText = "Responsável"
        Me.Responsavel.Name = "Responsavel"
        Me.Responsavel.ReadOnly = True
        '
        'VerProdutos
        '
        Me.VerProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.VerProdutos.HeaderText = "Ver Produtos"
        Me.VerProdutos.Name = "VerProdutos"
        Me.VerProdutos.ReadOnly = True
        Me.VerProdutos.Text = "Ver Produtos"
        '
        'Editar
        '
        Me.Editar.HeaderText = "Editar"
        Me.Editar.Image = Global.Sistema_Papelaria.My.Resources.Resources.ic_create_black_24dp_2x
        Me.Editar.Name = "Editar"
        Me.Editar.ReadOnly = True
        '
        'Excluir
        '
        Me.Excluir.HeaderText = "Excluir"
        Me.Excluir.Image = Global.Sistema_Papelaria.My.Resources.Resources.ic_delete_forever_black_24dp_2x
        Me.Excluir.Name = "Excluir"
        Me.Excluir.ReadOnly = True
        '
        'FormListarFornecedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(631, 433)
        Me.Controls.Add(Me.cb_selecione)
        Me.Controls.Add(Me.btn_filtrar)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txt_parametro)
        Me.Controls.Add(Me.dgv_forn)
        Me.Name = "FormListarFornecedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listar Fornecedores"
        CType(Me.dgv_forn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv_forn As DataGridView
    Friend WithEvents btn_filtrar As Button
    Friend WithEvents Label12 As Windows.Forms.Label
    Friend WithEvents Label11 As Windows.Forms.Label
    Friend WithEvents txt_parametro As TextBox
    Private WithEvents cb_selecione As ComboBox
    Friend WithEvents CNPJ As DataGridViewTextBoxColumn
    Friend WithEvents Nome_Forn As DataGridViewTextBoxColumn
    Friend WithEvents Contato As DataGridViewTextBoxColumn
    Friend WithEvents Responsavel As DataGridViewTextBoxColumn
    Friend WithEvents VerProdutos As DataGridViewButtonColumn
    Friend WithEvents Editar As DataGridViewImageColumn
    Friend WithEvents Excluir As DataGridViewImageColumn
End Class
