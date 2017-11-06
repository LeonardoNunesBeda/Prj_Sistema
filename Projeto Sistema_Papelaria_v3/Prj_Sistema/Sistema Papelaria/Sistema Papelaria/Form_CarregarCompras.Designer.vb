<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_CarregarCompras
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_CarregarCompras))
        Me.Dgv_Compras = New System.Windows.Forms.DataGridView()
        Me.Txt_cliente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_CodigoCompra = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmb_produto = New System.Windows.Forms.ComboBox()
        Me.btn_entrar = New System.Windows.Forms.Button()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Produto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qtd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CPF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Dgv_Compras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dgv_Compras
        '
        resources.ApplyResources(Me.Dgv_Compras, "Dgv_Compras")
        Me.Dgv_Compras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Compras.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Produto, Me.Qtd, Me.CPF})
        Me.Dgv_Compras.Name = "Dgv_Compras"
        '
        'Txt_cliente
        '
        resources.ApplyResources(Me.Txt_cliente, "Txt_cliente")
        Me.Txt_cliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_cliente.Name = "Txt_cliente"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Txt_CodigoCompra
        '
        resources.ApplyResources(Me.Txt_CodigoCompra, "Txt_CodigoCompra")
        Me.Txt_CodigoCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_CodigoCompra.Name = "Txt_CodigoCompra"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'cmb_produto
        '
        resources.ApplyResources(Me.cmb_produto, "cmb_produto")
        Me.cmb_produto.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_produto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmb_produto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_produto.FormattingEnabled = True
        Me.cmb_produto.Items.AddRange(New Object() {resources.GetString("cmb_produto.Items"), resources.GetString("cmb_produto.Items1")})
        Me.cmb_produto.Name = "cmb_produto"
        '
        'btn_entrar
        '
        resources.ApplyResources(Me.btn_entrar, "btn_entrar")
        Me.btn_entrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_entrar.Name = "btn_entrar"
        Me.btn_entrar.UseVisualStyleBackColor = True
        '
        'ID
        '
        resources.ApplyResources(Me.ID, "ID")
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        '
        'Produto
        '
        resources.ApplyResources(Me.Produto, "Produto")
        Me.Produto.Name = "Produto"
        Me.Produto.ReadOnly = True
        '
        'Qtd
        '
        resources.ApplyResources(Me.Qtd, "Qtd")
        Me.Qtd.Name = "Qtd"
        Me.Qtd.ReadOnly = True
        '
        'CPF
        '
        resources.ApplyResources(Me.CPF, "CPF")
        Me.CPF.Name = "CPF"
        Me.CPF.ReadOnly = True
        '
        'Form_CarregarCompras
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.btn_entrar)
        Me.Controls.Add(Me.cmb_produto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Txt_CodigoCompra)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txt_cliente)
        Me.Controls.Add(Me.Dgv_Compras)
        Me.Name = "Form_CarregarCompras"
        CType(Me.Dgv_Compras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Dgv_Compras As DataGridView
    Friend WithEvents Txt_cliente As TextBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Txt_CodigoCompra As TextBox
    Friend WithEvents Label3 As Windows.Forms.Label
    Private WithEvents cmb_produto As ComboBox
    Private WithEvents btn_entrar As Button
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Produto As DataGridViewTextBoxColumn
    Friend WithEvents Qtd As DataGridViewTextBoxColumn
    Friend WithEvents CPF As DataGridViewTextBoxColumn
End Class
