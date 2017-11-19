<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMenu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ManutençãoDeContasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastroDeContasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaDeStatusDeContaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FornToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastroDeFornecedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarFornecedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastrarCompraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerComprasRealizadasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem13 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastrarProdutosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem15 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EncerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EncerrarSessãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EncerrarSistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbl_user_name = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Btn_Encerrar = New System.Windows.Forms.Button()
        Me.Btn_Sair = New System.Windows.Forms.Button()
        Me.Btn_Contas = New System.Windows.Forms.Button()
        Me.Btn_Cadastrar = New System.Windows.Forms.Button()
        Me.Btn_Comprar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RelatórioDeComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManutençãoDeContasToolStripMenuItem, Me.FornToolStripMenuItem, Me.ComprasToolStripMenuItem, Me.ToolStripMenuItem13, Me.EncerrarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(523, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ManutençãoDeContasToolStripMenuItem
        '
        Me.ManutençãoDeContasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastroDeContasToolStripMenuItem, Me.ListaDeStatusDeContaToolStripMenuItem})
        Me.ManutençãoDeContasToolStripMenuItem.Image = Global.Sistema_Papelaria.My.Resources.Resources.accounts
        Me.ManutençãoDeContasToolStripMenuItem.Name = "ManutençãoDeContasToolStripMenuItem"
        Me.ManutençãoDeContasToolStripMenuItem.Size = New System.Drawing.Size(156, 20)
        Me.ManutençãoDeContasToolStripMenuItem.Text = "Manutenção de contas"
        '
        'CadastroDeContasToolStripMenuItem
        '
        Me.CadastroDeContasToolStripMenuItem.Name = "CadastroDeContasToolStripMenuItem"
        Me.CadastroDeContasToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.CadastroDeContasToolStripMenuItem.Text = "Cadastro de Contas"
        '
        'ListaDeStatusDeContaToolStripMenuItem
        '
        Me.ListaDeStatusDeContaToolStripMenuItem.Name = "ListaDeStatusDeContaToolStripMenuItem"
        Me.ListaDeStatusDeContaToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.ListaDeStatusDeContaToolStripMenuItem.Text = "Lista/Status das contas"
        '
        'FornToolStripMenuItem
        '
        Me.FornToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastroDeFornecedoresToolStripMenuItem, Me.ListarFornecedoresToolStripMenuItem})
        Me.FornToolStripMenuItem.Image = Global.Sistema_Papelaria.My.Resources.Resources.ship1
        Me.FornToolStripMenuItem.Name = "FornToolStripMenuItem"
        Me.FornToolStripMenuItem.Size = New System.Drawing.Size(106, 20)
        Me.FornToolStripMenuItem.Text = "Fornecedores"
        '
        'CadastroDeFornecedoresToolStripMenuItem
        '
        Me.CadastroDeFornecedoresToolStripMenuItem.Name = "CadastroDeFornecedoresToolStripMenuItem"
        Me.CadastroDeFornecedoresToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.CadastroDeFornecedoresToolStripMenuItem.Text = "Cadastro de Fornecedores"
        '
        'ListarFornecedoresToolStripMenuItem
        '
        Me.ListarFornecedoresToolStripMenuItem.Name = "ListarFornecedoresToolStripMenuItem"
        Me.ListarFornecedoresToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.ListarFornecedoresToolStripMenuItem.Text = "Listar Fornecedores"
        '
        'ComprasToolStripMenuItem
        '
        Me.ComprasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastrarCompraToolStripMenuItem, Me.VerComprasRealizadasToolStripMenuItem, Me.RelatórioDeComprasToolStripMenuItem})
        Me.ComprasToolStripMenuItem.Image = Global.Sistema_Papelaria.My.Resources.Resources.money
        Me.ComprasToolStripMenuItem.Name = "ComprasToolStripMenuItem"
        Me.ComprasToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.ComprasToolStripMenuItem.Text = "Compras"
        '
        'CadastrarCompraToolStripMenuItem
        '
        Me.CadastrarCompraToolStripMenuItem.Name = "CadastrarCompraToolStripMenuItem"
        Me.CadastrarCompraToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.CadastrarCompraToolStripMenuItem.Text = "Cadastrar compra"
        '
        'VerComprasRealizadasToolStripMenuItem
        '
        Me.VerComprasRealizadasToolStripMenuItem.Name = "VerComprasRealizadasToolStripMenuItem"
        Me.VerComprasRealizadasToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.VerComprasRealizadasToolStripMenuItem.Text = "Gerar relatório"
        '
        'ToolStripMenuItem13
        '
        Me.ToolStripMenuItem13.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastrarProdutosToolStripMenuItem, Me.ToolStripMenuItem15})
        Me.ToolStripMenuItem13.Image = Global.Sistema_Papelaria.My.Resources.Resources.shop_basq
        Me.ToolStripMenuItem13.Name = "ToolStripMenuItem13"
        Me.ToolStripMenuItem13.Size = New System.Drawing.Size(77, 20)
        Me.ToolStripMenuItem13.Text = "Estoque"
        '
        'CadastrarProdutosToolStripMenuItem
        '
        Me.CadastrarProdutosToolStripMenuItem.Name = "CadastrarProdutosToolStripMenuItem"
        Me.CadastrarProdutosToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.CadastrarProdutosToolStripMenuItem.Text = "Cadastrar Produto"
        '
        'ToolStripMenuItem15
        '
        Me.ToolStripMenuItem15.Name = "ToolStripMenuItem15"
        Me.ToolStripMenuItem15.Size = New System.Drawing.Size(170, 22)
        Me.ToolStripMenuItem15.Text = "Listar Produtos"
        '
        'EncerrarToolStripMenuItem
        '
        Me.EncerrarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EncerrarSessãoToolStripMenuItem, Me.EncerrarSistemaToolStripMenuItem})
        Me.EncerrarToolStripMenuItem.Image = Global.Sistema_Papelaria.My.Resources.Resources.power2
        Me.EncerrarToolStripMenuItem.Name = "EncerrarToolStripMenuItem"
        Me.EncerrarToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.EncerrarToolStripMenuItem.Text = "Encerrar"
        '
        'EncerrarSessãoToolStripMenuItem
        '
        Me.EncerrarSessãoToolStripMenuItem.Name = "EncerrarSessãoToolStripMenuItem"
        Me.EncerrarSessãoToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.EncerrarSessãoToolStripMenuItem.Text = "Encerrar Sessão"
        '
        'EncerrarSistemaToolStripMenuItem
        '
        Me.EncerrarSistemaToolStripMenuItem.Name = "EncerrarSistemaToolStripMenuItem"
        Me.EncerrarSistemaToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.EncerrarSistemaToolStripMenuItem.Text = "Encerrar Sistema"
        '
        'lbl_user_name
        '
        Me.lbl_user_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_user_name.Location = New System.Drawing.Point(12, 51)
        Me.lbl_user_name.Name = "lbl_user_name"
        Me.lbl_user_name.Size = New System.Drawing.Size(499, 25)
        Me.lbl_user_name.TabIndex = 2
        Me.lbl_user_name.Text = "Olá, Usuário."
        Me.lbl_user_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = Global.Sistema_Papelaria.My.Resources.Resources.papelaria
        Me.PictureBox1.Location = New System.Drawing.Point(207, 173)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(304, 180)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Btn_Encerrar
        '
        Me.Btn_Encerrar.FlatAppearance.BorderSize = 5
        Me.Btn_Encerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Encerrar.Image = Global.Sistema_Papelaria.My.Resources.Resources.power2
        Me.Btn_Encerrar.Location = New System.Drawing.Point(12, 311)
        Me.Btn_Encerrar.Name = "Btn_Encerrar"
        Me.Btn_Encerrar.Size = New System.Drawing.Size(143, 42)
        Me.Btn_Encerrar.TabIndex = 9
        Me.Btn_Encerrar.Text = "Encerrar Programa"
        Me.Btn_Encerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Encerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Encerrar.UseVisualStyleBackColor = True
        '
        'Btn_Sair
        '
        Me.Btn_Sair.FlatAppearance.BorderSize = 5
        Me.Btn_Sair.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Sair.Image = Global.Sistema_Papelaria.My.Resources.Resources.lock
        Me.Btn_Sair.Location = New System.Drawing.Point(12, 263)
        Me.Btn_Sair.Name = "Btn_Sair"
        Me.Btn_Sair.Size = New System.Drawing.Size(143, 42)
        Me.Btn_Sair.TabIndex = 8
        Me.Btn_Sair.Text = "Encerrar Sessão"
        Me.Btn_Sair.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Sair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Sair.UseVisualStyleBackColor = True
        '
        'Btn_Contas
        '
        Me.Btn_Contas.FlatAppearance.BorderSize = 5
        Me.Btn_Contas.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Contas.Image = Global.Sistema_Papelaria.My.Resources.Resources.accounts
        Me.Btn_Contas.Location = New System.Drawing.Point(350, 105)
        Me.Btn_Contas.Name = "Btn_Contas"
        Me.Btn_Contas.Size = New System.Drawing.Size(161, 53)
        Me.Btn_Contas.TabIndex = 7
        Me.Btn_Contas.Text = "Contas"
        Me.Btn_Contas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Contas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Contas.UseVisualStyleBackColor = True
        '
        'Btn_Cadastrar
        '
        Me.Btn_Cadastrar.FlatAppearance.BorderSize = 5
        Me.Btn_Cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Cadastrar.Image = Global.Sistema_Papelaria.My.Resources.Resources.add_box
        Me.Btn_Cadastrar.Location = New System.Drawing.Point(188, 105)
        Me.Btn_Cadastrar.Name = "Btn_Cadastrar"
        Me.Btn_Cadastrar.Size = New System.Drawing.Size(156, 53)
        Me.Btn_Cadastrar.TabIndex = 6
        Me.Btn_Cadastrar.Text = "Cadastrar Produto"
        Me.Btn_Cadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Cadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Cadastrar.UseVisualStyleBackColor = True
        '
        'Btn_Comprar
        '
        Me.Btn_Comprar.FlatAppearance.BorderSize = 5
        Me.Btn_Comprar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Comprar.Image = Global.Sistema_Papelaria.My.Resources.Resources.money
        Me.Btn_Comprar.Location = New System.Drawing.Point(12, 105)
        Me.Btn_Comprar.Name = "Btn_Comprar"
        Me.Btn_Comprar.Size = New System.Drawing.Size(170, 53)
        Me.Btn_Comprar.TabIndex = 5
        Me.Btn_Comprar.Text = "Comprar"
        Me.Btn_Comprar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Comprar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Comprar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(388, 356)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 20)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Papelaria v1.0 ©"
        '
        'RelatórioDeComprasToolStripMenuItem
        '
        Me.RelatórioDeComprasToolStripMenuItem.Name = "RelatórioDeComprasToolStripMenuItem"
        Me.RelatórioDeComprasToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.RelatórioDeComprasToolStripMenuItem.Text = "Relatório de Compras"
        '
        'FormMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(523, 387)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Btn_Encerrar)
        Me.Controls.Add(Me.Btn_Sair)
        Me.Controls.Add(Me.Btn_Contas)
        Me.Controls.Add(Me.Btn_Cadastrar)
        Me.Controls.Add(Me.Btn_Comprar)
        Me.Controls.Add(Me.lbl_user_name)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Papelaria v1.0"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ManutençãoDeContasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CadastroDeContasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListaDeStatusDeContaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FornToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CadastroDeFornecedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EncerrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EncerrarSessãoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EncerrarSistemaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lbl_user_name As Windows.Forms.Label
    Friend WithEvents Btn_Comprar As Button
    Friend WithEvents ComprasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CadastrarCompraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerComprasRealizadasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarFornecedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Btn_Cadastrar As Button
    Friend WithEvents Btn_Contas As Button
    Friend WithEvents Btn_Sair As Button
    Friend WithEvents Btn_Encerrar As Button
    Friend WithEvents ToolStripMenuItem13 As ToolStripMenuItem
    Friend WithEvents CadastrarProdutosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem15 As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents RelatórioDeComprasToolStripMenuItem As ToolStripMenuItem
End Class
