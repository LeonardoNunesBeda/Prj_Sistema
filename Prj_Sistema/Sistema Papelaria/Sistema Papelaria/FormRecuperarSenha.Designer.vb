<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRecuperarSenha
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRecuperarSenha))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_recuperar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_resp = New System.Windows.Forms.TextBox()
        Me.cmb_pergunta = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.txt_user = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_recuperar)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txt_resp)
        Me.GroupBox1.Controls.Add(Me.cmb_pergunta)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.label1)
        Me.GroupBox1.Controls.Add(Me.txt_user)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(224, 241)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cadastro de conta"
        '
        'btn_recuperar
        '
        Me.btn_recuperar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_recuperar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_recuperar.Image = Global.Sistema_Papelaria.My.Resources.Resources.lockOpen2
        Me.btn_recuperar.Location = New System.Drawing.Point(9, 186)
        Me.btn_recuperar.Name = "btn_recuperar"
        Me.btn_recuperar.Size = New System.Drawing.Size(202, 43)
        Me.btn_recuperar.TabIndex = 17
        Me.btn_recuperar.Text = "Recuperar Senha"
        Me.btn_recuperar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_recuperar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 125)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Resposta Secreta:"
        '
        'txt_resp
        '
        Me.txt_resp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_resp.Location = New System.Drawing.Point(9, 141)
        Me.txt_resp.MaxLength = 60
        Me.txt_resp.Name = "txt_resp"
        Me.txt_resp.Size = New System.Drawing.Size(202, 20)
        Me.txt_resp.TabIndex = 14
        '
        'cmb_pergunta
        '
        Me.cmb_pergunta.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_pergunta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmb_pergunta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_pergunta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_pergunta.FormattingEnabled = True
        Me.cmb_pergunta.Items.AddRange(New Object() {"Qual o nome da sua professora do jardim de infância?", "Qual o nome do seu primeiro bicho de estimação?", "Qual foi o primeiro livro que você leu?"})
        Me.cmb_pergunta.Location = New System.Drawing.Point(9, 92)
        Me.cmb_pergunta.Name = "cmb_pergunta"
        Me.cmb_pergunta.Size = New System.Drawing.Size(200, 21)
        Me.cmb_pergunta.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Pergunta Secreta:"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(6, 27)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(90, 13)
        Me.label1.TabIndex = 2
        Me.label1.Text = "Nome do usuário:"
        '
        'txt_user
        '
        Me.txt_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_user.Location = New System.Drawing.Point(9, 43)
        Me.txt_user.MaxLength = 60
        Me.txt_user.Name = "txt_user"
        Me.txt_user.Size = New System.Drawing.Size(202, 20)
        Me.txt_user.TabIndex = 3
        '
        'FormRecuperarSenha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(250, 265)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormRecuperarSenha"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recuperar Senha"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents btn_recuperar As System.Windows.Forms.Button
    Private WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents txt_resp As System.Windows.Forms.TextBox
    Private WithEvents cmb_pergunta As System.Windows.Forms.ComboBox
    Private WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents txt_user As System.Windows.Forms.TextBox
End Class
