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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_CarregarCompras))
        Me.Dgv_Compras = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_CodigoCompra = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmb_produto = New System.Windows.Forms.ComboBox()
        Me.btn_entrar = New System.Windows.Forms.Button()
        Me.DataSet1 = New Sistema_Papelaria.DataSet1()
        Me.DataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.id_compra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_vendedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.data = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Dgv_Compras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dgv_Compras
        '
        resources.ApplyResources(Me.Dgv_Compras, "Dgv_Compras")
        Me.Dgv_Compras.AutoGenerateColumns = False
        Me.Dgv_Compras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dgv_Compras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Compras.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_compra, Me.id_vendedor, Me.data, Me.total})
        Me.Dgv_Compras.DataSource = Me.DataSet1BindingSource
        Me.Dgv_Compras.Name = "Dgv_Compras"
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
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataSet1BindingSource
        '
        Me.DataSet1BindingSource.DataSource = Me.DataSet1
        Me.DataSet1BindingSource.Position = 0
        '
        'id_compra
        '
        resources.ApplyResources(Me.id_compra, "id_compra")
        Me.id_compra.Name = "id_compra"
        '
        'id_vendedor
        '
        resources.ApplyResources(Me.id_vendedor, "id_vendedor")
        Me.id_vendedor.Name = "id_vendedor"
        '
        'data
        '
        resources.ApplyResources(Me.data, "data")
        Me.data.Name = "data"
        '
        'total
        '
        resources.ApplyResources(Me.total, "total")
        Me.total.Name = "total"
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
        Me.Controls.Add(Me.Dgv_Compras)
        Me.Name = "Form_CarregarCompras"
        CType(Me.Dgv_Compras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Dgv_Compras As DataGridView
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Txt_CodigoCompra As TextBox
    Friend WithEvents Label3 As Windows.Forms.Label
    Private WithEvents cmb_produto As ComboBox
    Private WithEvents btn_entrar As Button
    Friend WithEvents id_compra As DataGridViewTextBoxColumn
    Friend WithEvents id_vendedor As DataGridViewTextBoxColumn
    Friend WithEvents data As DataGridViewTextBoxColumn
    Friend WithEvents total As DataGridViewTextBoxColumn
    Friend WithEvents DataSet1BindingSource As BindingSource
    Friend WithEvents DataSet1 As DataSet1
End Class
