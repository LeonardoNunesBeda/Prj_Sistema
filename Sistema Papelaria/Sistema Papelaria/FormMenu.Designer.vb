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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ManutençãoDeContasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastroDeContasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaDeStatusDeContaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastroDeFornecedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EncerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EncerrarSessãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EncerrarSistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_nome = New System.Windows.Forms.Label()
        Me.dgv_forn = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgv_prod = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_forn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv_prod, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManutençãoDeContasToolStripMenuItem, Me.ClienteToolStripMenuItem, Me.EncerrarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(860, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ManutençãoDeContasToolStripMenuItem
        '
        Me.ManutençãoDeContasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastroDeContasToolStripMenuItem, Me.ListaDeStatusDeContaToolStripMenuItem})
        Me.ManutençãoDeContasToolStripMenuItem.Name = "ManutençãoDeContasToolStripMenuItem"
        Me.ManutençãoDeContasToolStripMenuItem.Size = New System.Drawing.Size(140, 20)
        Me.ManutençãoDeContasToolStripMenuItem.Text = "Manutenção de contas"
        '
        'CadastroDeContasToolStripMenuItem
        '
        Me.CadastroDeContasToolStripMenuItem.Name = "CadastroDeContasToolStripMenuItem"
        Me.CadastroDeContasToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.CadastroDeContasToolStripMenuItem.Text = "Cadastro de Contas"
        '
        'ListaDeStatusDeContaToolStripMenuItem
        '
        Me.ListaDeStatusDeContaToolStripMenuItem.Name = "ListaDeStatusDeContaToolStripMenuItem"
        Me.ListaDeStatusDeContaToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.ListaDeStatusDeContaToolStripMenuItem.Text = "Lista de status de conta"
        '
        'ClienteToolStripMenuItem
        '
        Me.ClienteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastroDeFornecedoresToolStripMenuItem})
        Me.ClienteToolStripMenuItem.Name = "ClienteToolStripMenuItem"
        Me.ClienteToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.ClienteToolStripMenuItem.Text = "Fornecedores"
        '
        'CadastroDeFornecedoresToolStripMenuItem
        '
        Me.CadastroDeFornecedoresToolStripMenuItem.Name = "CadastroDeFornecedoresToolStripMenuItem"
        Me.CadastroDeFornecedoresToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.CadastroDeFornecedoresToolStripMenuItem.Text = "Cadastro de Fornecedores"
        '
        'EncerrarToolStripMenuItem
        '
        Me.EncerrarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EncerrarSessãoToolStripMenuItem, Me.EncerrarSistemaToolStripMenuItem})
        Me.EncerrarToolStripMenuItem.Name = "EncerrarToolStripMenuItem"
        Me.EncerrarToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgv_forn)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 148)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(384, 254)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fornecedores"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 39)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Olá,"
        '
        'lbl_nome
        '
        Me.lbl_nome.AutoSize = True
        Me.lbl_nome.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nome.Location = New System.Drawing.Point(123, 62)
        Me.lbl_nome.Name = "lbl_nome"
        Me.lbl_nome.Size = New System.Drawing.Size(66, 24)
        Me.lbl_nome.TabIndex = 3
        Me.lbl_nome.Text = "Label2"
        '
        'dgv_forn
        '
        Me.dgv_forn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_forn.Location = New System.Drawing.Point(6, 19)
        Me.dgv_forn.Name = "dgv_forn"
        Me.dgv_forn.Size = New System.Drawing.Size(372, 229)
        Me.dgv_forn.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgv_prod)
        Me.GroupBox2.Location = New System.Drawing.Point(417, 148)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(419, 254)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Produtos"
        '
        'dgv_prod
        '
        Me.dgv_prod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_prod.Location = New System.Drawing.Point(6, 19)
        Me.dgv_prod.Name = "dgv_prod"
        Me.dgv_prod.Size = New System.Drawing.Size(407, 229)
        Me.dgv_prod.TabIndex = 0
        '
        'FormMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(860, 416)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lbl_nome)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormMenu"
        Me.Text = "Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgv_forn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgv_prod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ManutençãoDeContasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CadastroDeContasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListaDeStatusDeContaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CadastroDeFornecedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EncerrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EncerrarSessãoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EncerrarSistemaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents lbl_nome As Windows.Forms.Label
    Friend WithEvents dgv_forn As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgv_prod As DataGridView
End Class
