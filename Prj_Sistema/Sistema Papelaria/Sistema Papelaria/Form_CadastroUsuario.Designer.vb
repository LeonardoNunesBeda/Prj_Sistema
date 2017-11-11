<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_CadastroUsuario
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
        Me.Txt_user = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cb_Pergunta = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Txt_resposta = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Cb_TipoConta = New System.Windows.Forms.ComboBox()
        Me.Checkbox_visualizar = New System.Windows.Forms.CheckBox()
        Me.Txt_email = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_RepetirSenha = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txt_senha = New System.Windows.Forms.TextBox()
        Me.Btn_Salvar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Txt_user
        '
        Me.Txt_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_user.Location = New System.Drawing.Point(9, 41)
        Me.Txt_user.Name = "Txt_user"
        Me.Txt_user.Size = New System.Drawing.Size(253, 20)
        Me.Txt_user.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nome do Usuário:"
        '
        'Cb_Pergunta
        '
        Me.Cb_Pergunta.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Cb_Pergunta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cb_Pergunta.FormattingEnabled = True
        Me.Cb_Pergunta.Items.AddRange(New Object() {"Qual o primeiro livro que você leu?", "Qual o seu filme favorito?", "Qual o nome do seu primeiro animal de estimação?"})
        Me.Cb_Pergunta.Location = New System.Drawing.Point(10, 250)
        Me.Cb_Pergunta.Name = "Cb_Pergunta"
        Me.Cb_Pergunta.Size = New System.Drawing.Size(252, 21)
        Me.Cb_Pergunta.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Txt_resposta)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Cb_TipoConta)
        Me.GroupBox1.Controls.Add(Me.Checkbox_visualizar)
        Me.GroupBox1.Controls.Add(Me.Txt_email)
        Me.GroupBox1.Controls.Add(Me.Cb_Pergunta)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Txt_RepetirSenha)
        Me.GroupBox1.Controls.Add(Me.Txt_user)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Txt_senha)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(272, 336)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cadastro"
        '
        'Txt_resposta
        '
        Me.Txt_resposta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_resposta.Location = New System.Drawing.Point(10, 302)
        Me.Txt_resposta.Name = "Txt_resposta"
        Me.Txt_resposta.Size = New System.Drawing.Size(252, 20)
        Me.Txt_resposta.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 115)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Tipo de Conta:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 285)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Resposta Secreta:"
        '
        'Cb_TipoConta
        '
        Me.Cb_TipoConta.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Cb_TipoConta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_TipoConta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cb_TipoConta.FormattingEnabled = True
        Me.Cb_TipoConta.Items.AddRange(New Object() {"Adminstrador", "Funcionário"})
        Me.Cb_TipoConta.Location = New System.Drawing.Point(10, 131)
        Me.Cb_TipoConta.Name = "Cb_TipoConta"
        Me.Cb_TipoConta.Size = New System.Drawing.Size(252, 21)
        Me.Cb_TipoConta.TabIndex = 9
        '
        'Checkbox_visualizar
        '
        Me.Checkbox_visualizar.AutoSize = True
        Me.Checkbox_visualizar.Location = New System.Drawing.Point(162, 205)
        Me.Checkbox_visualizar.Name = "Checkbox_visualizar"
        Me.Checkbox_visualizar.Size = New System.Drawing.Size(104, 17)
        Me.Checkbox_visualizar.TabIndex = 8
        Me.Checkbox_visualizar.Text = "Visualizar Senha"
        Me.Checkbox_visualizar.UseVisualStyleBackColor = True
        '
        'Txt_email
        '
        Me.Txt_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_email.Location = New System.Drawing.Point(10, 84)
        Me.Txt_email.Name = "Txt_email"
        Me.Txt_email.Size = New System.Drawing.Size(252, 20)
        Me.Txt_email.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Email:"
        '
        'Txt_RepetirSenha
        '
        Me.Txt_RepetirSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_RepetirSenha.Location = New System.Drawing.Point(139, 179)
        Me.Txt_RepetirSenha.Name = "Txt_RepetirSenha"
        Me.Txt_RepetirSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txt_RepetirSenha.Size = New System.Drawing.Size(123, 20)
        Me.Txt_RepetirSenha.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 234)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(183, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Pergunta Secreta: (Escolha ou digite)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(136, 163)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Repetir Senha:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Senha:"
        '
        'Txt_senha
        '
        Me.Txt_senha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_senha.Location = New System.Drawing.Point(10, 179)
        Me.Txt_senha.Name = "Txt_senha"
        Me.Txt_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txt_senha.Size = New System.Drawing.Size(123, 20)
        Me.Txt_senha.TabIndex = 4
        '
        'Btn_Salvar
        '
        Me.Btn_Salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Salvar.Location = New System.Drawing.Point(12, 354)
        Me.Btn_Salvar.Name = "Btn_Salvar"
        Me.Btn_Salvar.Size = New System.Drawing.Size(272, 35)
        Me.Btn_Salvar.TabIndex = 5
        Me.Btn_Salvar.Text = "Salvar"
        Me.Btn_Salvar.UseVisualStyleBackColor = True
        '
        'Form_CadastroUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(296, 407)
        Me.Controls.Add(Me.Btn_Salvar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form_CadastroUsuario"
        Me.Text = "Cadastro de Usuário"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Txt_user As TextBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Cb_Pergunta As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label8 As Windows.Forms.Label
    Friend WithEvents Cb_TipoConta As ComboBox
    Friend WithEvents Checkbox_visualizar As CheckBox
    Friend WithEvents Txt_RepetirSenha As TextBox
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents Txt_senha As TextBox
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents Txt_email As TextBox
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Txt_resposta As TextBox
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents Btn_Salvar As Button
End Class
