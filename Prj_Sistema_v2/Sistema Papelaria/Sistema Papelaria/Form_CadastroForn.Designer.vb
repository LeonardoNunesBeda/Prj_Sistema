﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Txt_tel = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txt_cnpj = New System.Windows.Forms.MaskedTextBox()
        Me.Txt_responsavel = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txt_nome = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_salvar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Txt_tel)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Txt_cnpj)
        Me.GroupBox1.Controls.Add(Me.Txt_responsavel)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Txt_nome)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(230, 220)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Novo Fornecedor"
        '
        'Txt_tel
        '
        Me.Txt_tel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_tel.Location = New System.Drawing.Point(9, 187)
        Me.Txt_tel.Mask = "(99) 0000-0000"
        Me.Txt_tel.Name = "Txt_tel"
        Me.Txt_tel.Size = New System.Drawing.Size(209, 20)
        Me.Txt_tel.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 171)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Telefone:"
        '
        'Txt_cnpj
        '
        Me.Txt_cnpj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_cnpj.Location = New System.Drawing.Point(9, 90)
        Me.Txt_cnpj.Mask = "00\.000\.000/0000\-00"
        Me.Txt_cnpj.Name = "Txt_cnpj"
        Me.Txt_cnpj.Size = New System.Drawing.Size(209, 20)
        Me.Txt_cnpj.TabIndex = 3
        '
        'Txt_responsavel
        '
        Me.Txt_responsavel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_responsavel.Location = New System.Drawing.Point(9, 138)
        Me.Txt_responsavel.Name = "Txt_responsavel"
        Me.Txt_responsavel.Size = New System.Drawing.Size(209, 20)
        Me.Txt_responsavel.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Responsável:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "C.N.P.J:"
        '
        'Txt_nome
        '
        Me.Txt_nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_nome.Location = New System.Drawing.Point(9, 42)
        Me.Txt_nome.Name = "Txt_nome"
        Me.Txt_nome.Size = New System.Drawing.Size(209, 20)
        Me.Txt_nome.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome/Razão Social:"
        '
        'btn_salvar
        '
        Me.btn_salvar.BackColor = System.Drawing.Color.Transparent
        Me.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_salvar.Location = New System.Drawing.Point(12, 238)
        Me.btn_salvar.Name = "btn_salvar"
        Me.btn_salvar.Size = New System.Drawing.Size(230, 35)
        Me.btn_salvar.TabIndex = 3
        Me.btn_salvar.Text = "Salvar Fornecedor"
        Me.btn_salvar.UseVisualStyleBackColor = False
        '
        'Form_CadastroForn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(258, 290)
        Me.Controls.Add(Me.btn_salvar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form_CadastroForn"
        Me.Text = "Cadastro Fornecedor"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Txt_nome As TextBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Txt_responsavel As TextBox
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents btn_salvar As Button
    Friend WithEvents Txt_cnpj As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Txt_tel As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
