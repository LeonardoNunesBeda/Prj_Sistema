<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormListarProdutos
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
        Me.dgv_prod = New System.Windows.Forms.DataGridView()
        Me.Cod_produto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nome_produto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Valor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantidade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fornecedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_prod, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_prod
        '
        Me.dgv_prod.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_prod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_prod.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cod_produto, Me.Nome_produto, Me.Valor, Me.Quantidade, Me.Fornecedor})
        Me.dgv_prod.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_prod.Location = New System.Drawing.Point(0, 0)
        Me.dgv_prod.Name = "dgv_prod"
        Me.dgv_prod.Size = New System.Drawing.Size(617, 451)
        Me.dgv_prod.TabIndex = 0
        '
        'Cod_produto
        '
        Me.Cod_produto.HeaderText = "Código do Produto"
        Me.Cod_produto.Name = "Cod_produto"
        '
        'Nome_produto
        '
        Me.Nome_produto.HeaderText = "Produto"
        Me.Nome_produto.Name = "Nome_produto"
        '
        'Valor
        '
        Me.Valor.HeaderText = "Valor"
        Me.Valor.Name = "Valor"
        '
        'Quantidade
        '
        Me.Quantidade.HeaderText = "Quantidade em Estoque"
        Me.Quantidade.Name = "Quantidade"
        '
        'Fornecedor
        '
        Me.Fornecedor.HeaderText = "Fornecedor"
        Me.Fornecedor.Name = "Fornecedor"
        '
        'FormListarProdutos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(617, 451)
        Me.Controls.Add(Me.dgv_prod)
        Me.Name = "FormListarProdutos"
        Me.Text = "Listar Produtos"
        CType(Me.dgv_prod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgv_prod As DataGridView
    Friend WithEvents Cod_produto As DataGridViewTextBoxColumn
    Friend WithEvents Nome_produto As DataGridViewTextBoxColumn
    Friend WithEvents Valor As DataGridViewTextBoxColumn
    Friend WithEvents Quantidade As DataGridViewTextBoxColumn
    Friend WithEvents Fornecedor As DataGridViewTextBoxColumn
End Class
