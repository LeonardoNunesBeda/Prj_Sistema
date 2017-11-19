<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_CadastroForn
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_salvar = New System.Windows.Forms.Button()
        Me.lbl_id_fornecedor = New System.Windows.Forms.Label()
        Me.Txt_responsavel = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_nome = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_del_prod = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_add_prod = New System.Windows.Forms.Button()
        Me.lst_produtos = New System.Windows.Forms.ListBox()
        Me.Txt_cnpj = New System.Windows.Forms.MaskedTextBox()
        Me.Txt_tel = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Txt_tel)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Txt_cnpj)
        Me.GroupBox1.Controls.Add(Me.lbl_id_fornecedor)
        Me.GroupBox1.Controls.Add(Me.Txt_responsavel)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Txt_nome)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(230, 250)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Novo Fornecedor"
        '
        'btn_salvar
        '
        Me.btn_salvar.BackColor = System.Drawing.Color.Transparent
        Me.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_salvar.Location = New System.Drawing.Point(360, 268)
        Me.btn_salvar.Name = "btn_salvar"
        Me.btn_salvar.Size = New System.Drawing.Size(191, 35)
        Me.btn_salvar.TabIndex = 3
        Me.btn_salvar.Text = "Salvar Fornecedor"
        Me.btn_salvar.UseVisualStyleBackColor = False
        '
        'lbl_id_fornecedor
        '
        Me.lbl_id_fornecedor.AutoSize = True
        Me.lbl_id_fornecedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id_fornecedor.Location = New System.Drawing.Point(127, 20)
        Me.lbl_id_fornecedor.Name = "lbl_id_fornecedor"
        Me.lbl_id_fornecedor.Size = New System.Drawing.Size(48, 25)
        Me.lbl_id_fornecedor.TabIndex = 8
        Me.lbl_id_fornecedor.Text = "001"
        '
        'Txt_responsavel
        '
        Me.Txt_responsavel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_responsavel.Location = New System.Drawing.Point(9, 166)
        Me.Txt_responsavel.Name = "Txt_responsavel"
        Me.Txt_responsavel.Size = New System.Drawing.Size(209, 20)
        Me.Txt_responsavel.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Responsável:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "C.N.P.J:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Código do Fornecedor:"
        '
        'Txt_nome
        '
        Me.Txt_nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_nome.Location = New System.Drawing.Point(9, 70)
        Me.Txt_nome.Name = "Txt_nome"
        Me.Txt_nome.Size = New System.Drawing.Size(209, 20)
        Me.Txt_nome.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome/Razão Social:"
        '
        'btn_del_prod
        '
        Me.btn_del_prod.BackColor = System.Drawing.Color.Transparent
        Me.btn_del_prod.Enabled = False
        Me.btn_del_prod.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_del_prod.Location = New System.Drawing.Point(152, 199)
        Me.btn_del_prod.Name = "btn_del_prod"
        Me.btn_del_prod.Size = New System.Drawing.Size(140, 36)
        Me.btn_del_prod.TabIndex = 1
        Me.btn_del_prod.Text = "Remover Produto"
        Me.btn_del_prod.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_add_prod)
        Me.GroupBox2.Controls.Add(Me.lst_produtos)
        Me.GroupBox2.Controls.Add(Me.btn_del_prod)
        Me.GroupBox2.Location = New System.Drawing.Point(248, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(303, 250)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Produtos fornecidos:"
        '
        'btn_add_prod
        '
        Me.btn_add_prod.BackColor = System.Drawing.Color.Transparent
        Me.btn_add_prod.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add_prod.Location = New System.Drawing.Point(6, 199)
        Me.btn_add_prod.Name = "btn_add_prod"
        Me.btn_add_prod.Size = New System.Drawing.Size(140, 36)
        Me.btn_add_prod.TabIndex = 2
        Me.btn_add_prod.Text = "Add Produto"
        Me.btn_add_prod.UseVisualStyleBackColor = False
        '
        'lst_produtos
        '
        Me.lst_produtos.FormattingEnabled = True
        Me.lst_produtos.Location = New System.Drawing.Point(6, 20)
        Me.lst_produtos.Name = "lst_produtos"
        Me.lst_produtos.Size = New System.Drawing.Size(286, 173)
        Me.lst_produtos.TabIndex = 0
        '
        'Txt_cnpj
        '
        Me.Txt_cnpj.Location = New System.Drawing.Point(9, 118)
        Me.Txt_cnpj.Mask = "00\.000\.000/0000\-00"
        Me.Txt_cnpj.Name = "Txt_cnpj"
        Me.Txt_cnpj.Size = New System.Drawing.Size(209, 20)
        Me.Txt_cnpj.TabIndex = 3
        '
        'Txt_tel
        '
        Me.Txt_tel.Location = New System.Drawing.Point(9, 215)
        Me.Txt_tel.Mask = "(99) 0000-0000"
        Me.Txt_tel.Name = "Txt_tel"
        Me.Txt_tel.Size = New System.Drawing.Size(209, 20)
        Me.Txt_tel.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 199)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Telefone:"
        '
        'Form_CadastroForn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(562, 315)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btn_salvar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form_CadastroForn"
        Me.Text = "Cadastro Fornecedor"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Txt_nome As TextBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Txt_responsavel As TextBox
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents btn_del_prod As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lst_produtos As ListBox
    Friend WithEvents btn_add_prod As Button
    Friend WithEvents lbl_id_fornecedor As Windows.Forms.Label
    Friend WithEvents btn_salvar As Button
    Friend WithEvents Txt_cnpj As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Txt_tel As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
