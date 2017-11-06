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
        Me.lbl_codigo = New System.Windows.Forms.Label()
        Me.DirectoryEntry1 = New System.DirectoryServices.DirectoryEntry()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Lbl_Total = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lst_produtos = New System.Windows.Forms.ListBox()
        Me.btn_add_produto = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cb_cpf = New System.Windows.Forms.CheckBox()
        Me.Txt_CPF = New System.Windows.Forms.TextBox()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_codigo
        '
        Me.lbl_codigo.AutoSize = True
        Me.lbl_codigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_codigo.Location = New System.Drawing.Point(16, 16)
        Me.lbl_codigo.Name = "lbl_codigo"
        Me.lbl_codigo.Size = New System.Drawing.Size(74, 31)
        Me.lbl_codigo.TabIndex = 0
        Me.lbl_codigo.Text = "0001"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Lbl_Total)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox3.Location = New System.Drawing.Point(128, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(126, 58)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Valor Total da Compra"
        '
        'Lbl_Total
        '
        Me.Lbl_Total.AutoSize = True
        Me.Lbl_Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Total.Location = New System.Drawing.Point(16, 18)
        Me.Lbl_Total.Name = "Lbl_Total"
        Me.Lbl_Total.Size = New System.Drawing.Size(94, 29)
        Me.Lbl_Total.TabIndex = 0
        Me.Lbl_Total.Text = "R$ 0,00"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Txt_CPF)
        Me.GroupBox4.Controls.Add(Me.cb_cpf)
        Me.GroupBox4.Controls.Add(Me.lst_produtos)
        Me.GroupBox4.Controls.Add(Me.btn_add_produto)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 76)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(242, 277)
        Me.GroupBox4.TabIndex = 14
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Compra"
        '
        'lst_produtos
        '
        Me.lst_produtos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lst_produtos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_produtos.FormattingEnabled = True
        Me.lst_produtos.Location = New System.Drawing.Point(6, 58)
        Me.lst_produtos.Name = "lst_produtos"
        Me.lst_produtos.Size = New System.Drawing.Size(230, 171)
        Me.lst_produtos.TabIndex = 1
        '
        'btn_add_produto
        '
        Me.btn_add_produto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add_produto.Location = New System.Drawing.Point(6, 235)
        Me.btn_add_produto.Name = "btn_add_produto"
        Me.btn_add_produto.Size = New System.Drawing.Size(230, 36)
        Me.btn_add_produto.TabIndex = 0
        Me.btn_add_produto.Text = "Adicionar Produto"
        Me.btn_add_produto.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_codigo)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(110, 58)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Código da Compra"
        '
        'cb_cpf
        '
        Me.cb_cpf.AutoSize = True
        Me.cb_cpf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb_cpf.Location = New System.Drawing.Point(6, 20)
        Me.cb_cpf.Name = "cb_cpf"
        Me.cb_cpf.Size = New System.Drawing.Size(95, 17)
        Me.cb_cpf.TabIndex = 2
        Me.cb_cpf.Text = "CPF do cliente:"
        Me.cb_cpf.UseVisualStyleBackColor = True
        '
        'Txt_CPF
        '
        Me.Txt_CPF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_CPF.Enabled = False
        Me.Txt_CPF.Location = New System.Drawing.Point(107, 19)
        Me.Txt_CPF.Name = "Txt_CPF"
        Me.Txt_CPF.Size = New System.Drawing.Size(129, 20)
        Me.Txt_CPF.TabIndex = 3
        '
        'Form_CadastrarCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(269, 373)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form_CadastrarCompras"
        Me.Text = "Comprar"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbl_codigo As Windows.Forms.Label
    Friend WithEvents DirectoryEntry1 As DirectoryServices.DirectoryEntry
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Lbl_Total As Windows.Forms.Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_add_produto As Button
    Friend WithEvents lst_produtos As ListBox
    Friend WithEvents Txt_CPF As TextBox
    Friend WithEvents cb_cpf As CheckBox
End Class
