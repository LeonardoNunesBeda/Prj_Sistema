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
        Me.Cod_Forn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nome_Forn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Contato = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CNPJ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Responsavel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Produtos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_forn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_forn
        '
        Me.dgv_forn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_forn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_forn.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cod_Forn, Me.Nome_Forn, Me.Contato, Me.CNPJ, Me.Responsavel, Me.Produtos})
        Me.dgv_forn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_forn.Location = New System.Drawing.Point(0, 0)
        Me.dgv_forn.Name = "dgv_forn"
        Me.dgv_forn.Size = New System.Drawing.Size(677, 375)
        Me.dgv_forn.TabIndex = 0
        '
        'Cod_Forn
        '
        Me.Cod_Forn.HeaderText = "Código Fornecedor"
        Me.Cod_Forn.Name = "Cod_Forn"
        '
        'Nome_Forn
        '
        Me.Nome_Forn.HeaderText = "Nome do Fornecedor"
        Me.Nome_Forn.Name = "Nome_Forn"
        '
        'Contato
        '
        Me.Contato.HeaderText = "Telefone"
        Me.Contato.Name = "Contato"
        '
        'CNPJ
        '
        Me.CNPJ.HeaderText = "CNPJ"
        Me.CNPJ.Name = "CNPJ"
        '
        'Responsavel
        '
        Me.Responsavel.HeaderText = "Responsável"
        Me.Responsavel.Name = "Responsavel"
        '
        'Produtos
        '
        Me.Produtos.HeaderText = "Produtos"
        Me.Produtos.Name = "Produtos"
        Me.Produtos.ReadOnly = True
        '
        'FormListarFornecedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(677, 375)
        Me.Controls.Add(Me.dgv_forn)
        Me.Name = "FormListarFornecedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listar Fornecedores"
        CType(Me.dgv_forn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgv_forn As DataGridView
    Friend WithEvents Cod_Forn As DataGridViewTextBoxColumn
    Friend WithEvents Nome_Forn As DataGridViewTextBoxColumn
    Friend WithEvents Contato As DataGridViewTextBoxColumn
    Friend WithEvents CNPJ As DataGridViewTextBoxColumn
    Friend WithEvents Responsavel As DataGridViewTextBoxColumn
    Friend WithEvents Produtos As DataGridViewTextBoxColumn
End Class
