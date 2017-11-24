<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_CadastrarCompras
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
        Me.DirectoryEntry1 = New System.DirectoryServices.DirectoryEntry()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Lbl_Total = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btn_add_produto = New System.Windows.Forms.Button()
        Me.Btn_compra = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_pago = New System.Windows.Forms.TextBox()
        Me.lbl_troco = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cb_metodo = New System.Windows.Forms.ComboBox()
        Me.dgv_compra = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Produto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qtd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv_compra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Lbl_Total)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox3.Location = New System.Drawing.Point(382, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(171, 60)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Valor Total da Compra"
        '
        'Lbl_Total
        '
        Me.Lbl_Total.AutoSize = True
        Me.Lbl_Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Total.Location = New System.Drawing.Point(38, 20)
        Me.Lbl_Total.Name = "Lbl_Total"
        Me.Lbl_Total.Size = New System.Drawing.Size(94, 29)
        Me.Lbl_Total.TabIndex = 0
        Me.Lbl_Total.Text = "R$ 0,00"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.dgv_compra)
        Me.GroupBox4.Controls.Add(Me.btn_add_produto)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(364, 222)
        Me.GroupBox4.TabIndex = 14
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Produtos Comprados"
        '
        'btn_add_produto
        '
        Me.btn_add_produto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add_produto.Location = New System.Drawing.Point(207, 185)
        Me.btn_add_produto.Name = "btn_add_produto"
        Me.btn_add_produto.Size = New System.Drawing.Size(149, 30)
        Me.btn_add_produto.TabIndex = 0
        Me.btn_add_produto.Text = "Adicionar produto"
        Me.btn_add_produto.UseVisualStyleBackColor = True
        '
        'Btn_compra
        '
        Me.Btn_compra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_compra.Location = New System.Drawing.Point(382, 240)
        Me.Btn_compra.Name = "Btn_compra"
        Me.Btn_compra.Size = New System.Drawing.Size(171, 39)
        Me.Btn_compra.TabIndex = 4
        Me.Btn_compra.Text = "Concluir compra"
        Me.Btn_compra.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Valor Pago:"
        '
        'txt_pago
        '
        Me.txt_pago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_pago.Location = New System.Drawing.Point(13, 42)
        Me.txt_pago.Name = "txt_pago"
        Me.txt_pago.Size = New System.Drawing.Size(142, 20)
        Me.txt_pago.TabIndex = 2
        '
        'lbl_troco
        '
        Me.lbl_troco.AutoSize = True
        Me.lbl_troco.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_troco.Location = New System.Drawing.Point(9, 70)
        Me.lbl_troco.Name = "lbl_troco"
        Me.lbl_troco.Size = New System.Drawing.Size(108, 16)
        Me.lbl_troco.TabIndex = 3
        Me.lbl_troco.Text = "Troco: R$ 0,00"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_troco)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_pago)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(382, 134)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(171, 100)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Troco"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cb_metodo)
        Me.GroupBox2.Location = New System.Drawing.Point(382, 78)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(171, 55)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Método pagamento"
        '
        'cb_metodo
        '
        Me.cb_metodo.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cb_metodo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_metodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_metodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb_metodo.FormattingEnabled = True
        Me.cb_metodo.Items.AddRange(New Object() {"Dinheiro", "Cartão Débito", "Cartão Crédito"})
        Me.cb_metodo.Location = New System.Drawing.Point(13, 21)
        Me.cb_metodo.Name = "cb_metodo"
        Me.cb_metodo.Size = New System.Drawing.Size(148, 21)
        Me.cb_metodo.TabIndex = 17
        '
        'dgv_compra
        '
        Me.dgv_compra.AllowUserToDeleteRows = False
        Me.dgv_compra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_compra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_compra.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.Produto, Me.Qtd})
        Me.dgv_compra.Location = New System.Drawing.Point(6, 19)
        Me.dgv_compra.Name = "dgv_compra"
        Me.dgv_compra.Size = New System.Drawing.Size(350, 160)
        Me.dgv_compra.TabIndex = 1
        '
        'id
        '
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        '
        'Produto
        '
        Me.Produto.HeaderText = "Produto"
        Me.Produto.Name = "Produto"
        '
        'Qtd
        '
        Me.Qtd.HeaderText = "Qtd"
        Me.Qtd.Name = "Qtd"
        '
        'Form_CadastrarCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(565, 294)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Btn_compra)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "Form_CadastrarCompras"
        Me.Text = "Comprar"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgv_compra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DirectoryEntry1 As DirectoryServices.DirectoryEntry
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Lbl_Total As Windows.Forms.Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btn_add_produto As Button
    Friend WithEvents Btn_compra As Button
    Friend WithEvents lbl_troco As Windows.Forms.Label
    Friend WithEvents txt_pago As TextBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Private WithEvents cb_metodo As ComboBox
    Friend WithEvents dgv_compra As DataGridView
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents Produto As DataGridViewTextBoxColumn
    Friend WithEvents Qtd As DataGridViewTextBoxColumn
End Class
