<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_CadastrarProdutos
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_new_forn = New System.Windows.Forms.Label()
        Me.cmb_categoria = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cb_fornecedor = New System.Windows.Forms.ComboBox()
        Me.NUD_qtdProd = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txt_valor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txt_Prod = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Btn_salvar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NUD_qtdProd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_new_forn)
        Me.GroupBox1.Controls.Add(Me.cmb_categoria)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cb_fornecedor)
        Me.GroupBox1.Controls.Add(Me.NUD_qtdProd)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Txt_valor)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Txt_Prod)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(234, 246)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Novo Produto"
        '
        'lbl_new_forn
        '
        Me.lbl_new_forn.AutoSize = True
        Me.lbl_new_forn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_new_forn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_new_forn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbl_new_forn.Location = New System.Drawing.Point(6, 219)
        Me.lbl_new_forn.Name = "lbl_new_forn"
        Me.lbl_new_forn.Size = New System.Drawing.Size(138, 13)
        Me.lbl_new_forn.TabIndex = 15
        Me.lbl_new_forn.Text = "Cadastrar Novo Fornecedor"
        '
        'cmb_categoria
        '
        Me.cmb_categoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_categoria.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmb_categoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_categoria.FormattingEnabled = True
        Me.cmb_categoria.Location = New System.Drawing.Point(6, 145)
        Me.cmb_categoria.Name = "cmb_categoria"
        Me.cmb_categoria.Size = New System.Drawing.Size(220, 21)
        Me.cmb_categoria.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 129)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Categoria (escolha na lista ou digite agora): *"
        '
        'cb_fornecedor
        '
        Me.cb_fornecedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cb_fornecedor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_fornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_fornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb_fornecedor.FormattingEnabled = True
        Me.cb_fornecedor.Items.AddRange(New Object() {"(Cadastrar novo)"})
        Me.cb_fornecedor.Location = New System.Drawing.Point(6, 195)
        Me.cb_fornecedor.Name = "cb_fornecedor"
        Me.cb_fornecedor.Size = New System.Drawing.Size(220, 21)
        Me.cb_fornecedor.TabIndex = 12
        '
        'NUD_qtdProd
        '
        Me.NUD_qtdProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NUD_qtdProd.Location = New System.Drawing.Point(107, 90)
        Me.NUD_qtdProd.Maximum = New Decimal(New Integer() {1410065407, 2, 0, 0})
        Me.NUD_qtdProd.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NUD_qtdProd.Name = "NUD_qtdProd"
        Me.NUD_qtdProd.Size = New System.Drawing.Size(120, 20)
        Me.NUD_qtdProd.TabIndex = 11
        Me.NUD_qtdProd.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 179)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Fornecedor:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(104, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Quantidade no estoque: *"
        '
        'Txt_valor
        '
        Me.Txt_valor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_valor.Location = New System.Drawing.Point(6, 90)
        Me.Txt_valor.Name = "Txt_valor"
        Me.Txt_valor.Size = New System.Drawing.Size(95, 20)
        Me.Txt_valor.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Valor (R$):  *"
        '
        'Txt_Prod
        '
        Me.Txt_Prod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Prod.Location = New System.Drawing.Point(6, 42)
        Me.Txt_Prod.Name = "Txt_Prod"
        Me.Txt_Prod.Size = New System.Drawing.Size(220, 20)
        Me.Txt_Prod.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nome do Produto: *"
        '
        'Btn_salvar
        '
        Me.Btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_salvar.Location = New System.Drawing.Point(12, 264)
        Me.Btn_salvar.Name = "Btn_salvar"
        Me.Btn_salvar.Size = New System.Drawing.Size(234, 35)
        Me.Btn_salvar.TabIndex = 2
        Me.Btn_salvar.Text = "Salvar"
        Me.Btn_salvar.UseVisualStyleBackColor = True
        '
        'Form_CadastrarProdutos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(261, 311)
        Me.Controls.Add(Me.Btn_salvar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form_CadastrarProdutos"
        Me.Text = " Cadastrar Produto"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NUD_qtdProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents Txt_valor As TextBox
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Txt_Prod As TextBox
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Btn_salvar As Button
    Friend WithEvents NUD_qtdProd As NumericUpDown
    Friend WithEvents Label1 As Windows.Forms.Label
    Private WithEvents cb_fornecedor As ComboBox
    Friend WithEvents Label5 As Windows.Forms.Label
    Private WithEvents cmb_categoria As ComboBox
    Private WithEvents lbl_new_forn As Windows.Forms.Label
End Class
