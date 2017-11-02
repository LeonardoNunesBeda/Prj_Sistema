<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLogin))
        Me.gb_login = New System.Windows.Forms.GroupBox()
        Me.Lbl_acesso = New System.Windows.Forms.Label()
        Me.lbl_senha = New System.Windows.Forms.Label()
        Me.btn_entrar = New System.Windows.Forms.Button()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_tentativas = New System.Windows.Forms.Label()
        Me.cmb_acesso = New System.Windows.Forms.ComboBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.txt_user = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.gb_login.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gb_login
        '
        Me.gb_login.Controls.Add(Me.Lbl_acesso)
        Me.gb_login.Controls.Add(Me.lbl_senha)
        Me.gb_login.Controls.Add(Me.btn_entrar)
        Me.gb_login.Controls.Add(Me.groupBox1)
        Me.gb_login.Controls.Add(Me.cmb_acesso)
        Me.gb_login.Controls.Add(Me.label3)
        Me.gb_login.Controls.Add(Me.label1)
        Me.gb_login.Controls.Add(Me.txt_senha)
        Me.gb_login.Controls.Add(Me.txt_user)
        Me.gb_login.Controls.Add(Me.label2)
        Me.gb_login.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_login.Location = New System.Drawing.Point(12, 12)
        Me.gb_login.Name = "gb_login"
        Me.gb_login.Size = New System.Drawing.Size(307, 199)
        Me.gb_login.TabIndex = 5
        Me.gb_login.TabStop = False
        Me.gb_login.Text = "Autenticação"
        '
        'Lbl_acesso
        '
        Me.Lbl_acesso.AutoSize = True
        Me.Lbl_acesso.Location = New System.Drawing.Point(126, 147)
        Me.Lbl_acesso.Name = "Lbl_acesso"
        Me.Lbl_acesso.Size = New System.Drawing.Size(33, 13)
        Me.Lbl_acesso.TabIndex = 9
        Me.Lbl_acesso.Text = "None"
        '
        'lbl_senha
        '
        Me.lbl_senha.AutoSize = True
        Me.lbl_senha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_senha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_senha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbl_senha.Location = New System.Drawing.Point(6, 113)
        Me.lbl_senha.Name = "lbl_senha"
        Me.lbl_senha.Size = New System.Drawing.Size(113, 13)
        Me.lbl_senha.TabIndex = 8
        Me.lbl_senha.Text = "Esqueceu sua senha?"
        '
        'btn_entrar
        '
        Me.btn_entrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_entrar.Image = Global.Sistema_Papelaria.My.Resources.Resources.key1
        Me.btn_entrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_entrar.Location = New System.Drawing.Point(212, 147)
        Me.btn_entrar.Name = "btn_entrar"
        Me.btn_entrar.Size = New System.Drawing.Size(78, 38)
        Me.btn_entrar.TabIndex = 7
        Me.btn_entrar.Text = "Entrar"
        Me.btn_entrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_entrar.UseVisualStyleBackColor = True
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.lbl_tentativas)
        Me.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.groupBox1.Location = New System.Drawing.Point(211, 25)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.groupBox1.Size = New System.Drawing.Size(80, 85)
        Me.groupBox1.TabIndex = 6
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Tentativas"
        '
        'lbl_tentativas
        '
        Me.lbl_tentativas.AutoSize = True
        Me.lbl_tentativas.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tentativas.Location = New System.Drawing.Point(16, 16)
        Me.lbl_tentativas.Name = "lbl_tentativas"
        Me.lbl_tentativas.Size = New System.Drawing.Size(51, 55)
        Me.lbl_tentativas.TabIndex = 0
        Me.lbl_tentativas.Text = "3"
        '
        'cmb_acesso
        '
        Me.cmb_acesso.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmb_acesso.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmb_acesso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_acesso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_acesso.FormattingEnabled = True
        Me.cmb_acesso.Items.AddRange(New Object() {"Funcionário", "Administrador"})
        Me.cmb_acesso.Location = New System.Drawing.Point(9, 164)
        Me.cmb_acesso.Name = "cmb_acesso"
        Me.cmb_acesso.Size = New System.Drawing.Size(177, 21)
        Me.cmb_acesso.TabIndex = 5
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(6, 147)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(88, 13)
        Me.label3.TabIndex = 4
        Me.label3.Text = "Nível de acesso:"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(6, 25)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(92, 13)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Usuário ou E-mail:"
        '
        'txt_senha
        '
        Me.txt_senha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_senha.Location = New System.Drawing.Point(9, 90)
        Me.txt_senha.MaxLength = 10
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_senha.Size = New System.Drawing.Size(177, 20)
        Me.txt_senha.TabIndex = 3
        '
        'txt_user
        '
        Me.txt_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_user.Location = New System.Drawing.Point(9, 41)
        Me.txt_user.MaxLength = 60
        Me.txt_user.Name = "txt_user"
        Me.txt_user.Size = New System.Drawing.Size(177, 20)
        Me.txt_user.TabIndex = 1
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(6, 74)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(41, 13)
        Me.label2.TabIndex = 2
        Me.label2.Text = "Senha:"
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(329, 222)
        Me.Controls.Add(Me.gb_login)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormLogin"
        Me.Text = "Login"
        Me.gb_login.ResumeLayout(False)
        Me.gb_login.PerformLayout()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents gb_login As System.Windows.Forms.GroupBox
    Private WithEvents lbl_senha As System.Windows.Forms.Label
    Private WithEvents btn_entrar As System.Windows.Forms.Button
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents lbl_tentativas As System.Windows.Forms.Label
    Private WithEvents cmb_acesso As System.Windows.Forms.ComboBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents txt_senha As System.Windows.Forms.TextBox
    Private WithEvents txt_user As System.Windows.Forms.TextBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents Lbl_acesso As Windows.Forms.Label
End Class
