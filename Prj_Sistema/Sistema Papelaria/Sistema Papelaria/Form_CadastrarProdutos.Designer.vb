<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_CadastrarProdutos
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
        Me.lbl = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cb_fornecedor = New System.Windows.Forms.ComboBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.btn_add_fornecedor = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txt_valor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txt_Prod = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Btn_salvar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Location = New System.Drawing.Point(3, 33)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(98, 13)
        Me.lbl.TabIndex = 0
        Me.lbl.Text = "Código do Produto:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cb_fornecedor)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox1.Controls.Add(Me.btn_add_fornecedor)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Txt_valor)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Txt_Prod)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lbl)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(234, 252)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Produtos"
        '
        'cb_fornecedor
        '
        Me.cb_fornecedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cb_fornecedor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_fornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_fornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb_fornecedor.FormattingEnabled = True
        Me.cb_fornecedor.Items.AddRange(New Object() {"Funcionário", "Administrador"})
        Me.cb_fornecedor.Location = New System.Drawing.Point(6, 175)
        Me.cb_fornecedor.Name = "cb_fornecedor"
        Me.cb_fornecedor.Size = New System.Drawing.Size(220, 21)
        Me.cb_fornecedor.TabIndex = 12
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumericUpDown1.Location = New System.Drawing.Point(107, 126)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDown1.TabIndex = 11
        '
        'btn_add_fornecedor
        '
        Me.btn_add_fornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add_fornecedor.Location = New System.Drawing.Point(104, 202)
        Me.btn_add_fornecedor.Name = "btn_add_fornecedor"
        Me.btn_add_fornecedor.Size = New System.Drawing.Size(123, 31)
        Me.btn_add_fornecedor.TabIndex = 3
        Me.btn_add_fornecedor.Text = "Add Novo Fornecedor"
        Me.btn_add_fornecedor.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(98, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 25)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "001"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Fornecedor:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(104, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Quantidade no estoque:"
        '
        'Txt_valor
        '
        Me.Txt_valor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_valor.Location = New System.Drawing.Point(6, 126)
        Me.Txt_valor.Name = "Txt_valor"
        Me.Txt_valor.Size = New System.Drawing.Size(95, 20)
        Me.Txt_valor.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Valor (R$): "
        '
        'Txt_Prod
        '
        Me.Txt_Prod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Prod.Location = New System.Drawing.Point(6, 78)
        Me.Txt_Prod.Name = "Txt_Prod"
        Me.Txt_Prod.Size = New System.Drawing.Size(220, 20)
        Me.Txt_Prod.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nome do Produto:"
        '
        'Btn_salvar
        '
        Me.Btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_salvar.Location = New System.Drawing.Point(12, 270)
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
        Me.ClientSize = New System.Drawing.Size(258, 318)
        Me.Controls.Add(Me.Btn_salvar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form_CadastrarProdutos"
        Me.Text = " "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbl As Windows.Forms.Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents Txt_valor As TextBox
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Txt_Prod As TextBox
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Btn_salvar As Button
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents btn_add_fornecedor As Button
    Friend WithEvents Label1 As Windows.Forms.Label
    Private WithEvents cb_fornecedor As ComboBox
End Class
