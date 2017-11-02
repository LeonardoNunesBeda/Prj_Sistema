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
        Me.Btn_salvar = New System.Windows.Forms.Button()
        Me.Txt_codprod = New System.Windows.Forms.TextBox()
        Me.Txt_Prod = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_valor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txt_qtd = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CB_Fornecedores = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Location = New System.Drawing.Point(19, 29)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(95, 13)
        Me.lbl.TabIndex = 0
        Me.lbl.Text = "Código do Produto"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CB_Fornecedores)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Txt_qtd)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Txt_valor)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Txt_Prod)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Txt_codprod)
        Me.GroupBox1.Controls.Add(Me.lbl)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(331, 455)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Produtos"
        '
        'Btn_salvar
        '
        Me.Btn_salvar.Location = New System.Drawing.Point(53, 487)
        Me.Btn_salvar.Name = "Btn_salvar"
        Me.Btn_salvar.Size = New System.Drawing.Size(246, 78)
        Me.Btn_salvar.TabIndex = 2
        Me.Btn_salvar.Text = "Salvar"
        Me.Btn_salvar.UseVisualStyleBackColor = True
        '
        'Txt_codprod
        '
        Me.Txt_codprod.Location = New System.Drawing.Point(22, 60)
        Me.Txt_codprod.Name = "Txt_codprod"
        Me.Txt_codprod.Size = New System.Drawing.Size(281, 20)
        Me.Txt_codprod.TabIndex = 1
        '
        'Txt_Prod
        '
        Me.Txt_Prod.Location = New System.Drawing.Point(22, 135)
        Me.Txt_Prod.Name = "Txt_Prod"
        Me.Txt_Prod.Size = New System.Drawing.Size(281, 20)
        Me.Txt_Prod.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nome do Produto"
        '
        'Txt_valor
        '
        Me.Txt_valor.Location = New System.Drawing.Point(22, 215)
        Me.Txt_valor.Name = "Txt_valor"
        Me.Txt_valor.Size = New System.Drawing.Size(281, 20)
        Me.Txt_valor.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Valor"
        '
        'Txt_qtd
        '
        Me.Txt_qtd.Location = New System.Drawing.Point(22, 302)
        Me.Txt_qtd.Name = "Txt_qtd"
        Me.Txt_qtd.Size = New System.Drawing.Size(281, 20)
        Me.Txt_qtd.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 271)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Quantidade"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 351)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Fornecedor"
        '
        'CB_Fornecedores
        '
        Me.CB_Fornecedores.FormattingEnabled = True
        Me.CB_Fornecedores.Location = New System.Drawing.Point(22, 380)
        Me.CB_Fornecedores.Name = "CB_Fornecedores"
        Me.CB_Fornecedores.Size = New System.Drawing.Size(281, 21)
        Me.CB_Fornecedores.TabIndex = 9
        '
        'Form_CadastrarProdutos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(355, 590)
        Me.Controls.Add(Me.Btn_salvar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form_CadastrarProdutos"
        Me.Text = "Cadastro de produtos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbl As Windows.Forms.Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CB_Fornecedores As ComboBox
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents Txt_qtd As TextBox
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents Txt_valor As TextBox
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Txt_Prod As TextBox
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Txt_codprod As TextBox
    Friend WithEvents Btn_salvar As Button
End Class
