<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormStatus
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
        Me.dgv_dados = New System.Windows.Forms.DataGridView()
        Me.id_usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status_conta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo_conta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.num_tentativas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ativar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Excluir = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cb_selecione = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_parametro = New System.Windows.Forms.TextBox()
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_dados
        '
        Me.dgv_dados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_dados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_usuario, Me.usuario, Me.status_conta, Me.tipo_conta, Me.num_tentativas, Me.Ativar, Me.Excluir})
        Me.dgv_dados.Location = New System.Drawing.Point(13, 58)
        Me.dgv_dados.Name = "dgv_dados"
        Me.dgv_dados.Size = New System.Drawing.Size(697, 350)
        Me.dgv_dados.TabIndex = 0
        '
        'id_usuario
        '
        Me.id_usuario.HeaderText = "id_usuario"
        Me.id_usuario.MaxInputLength = 10
        Me.id_usuario.Name = "id_usuario"
        '
        'usuario
        '
        Me.usuario.HeaderText = "usuario"
        Me.usuario.MaxInputLength = 40
        Me.usuario.Name = "usuario"
        '
        'status_conta
        '
        Me.status_conta.HeaderText = "status_conta"
        Me.status_conta.MaxInputLength = 10
        Me.status_conta.Name = "status_conta"
        '
        'tipo_conta
        '
        Me.tipo_conta.HeaderText = "tipo_conta"
        Me.tipo_conta.MaxInputLength = 15
        Me.tipo_conta.Name = "tipo_conta"
        '
        'num_tentativas
        '
        Me.num_tentativas.HeaderText = "num_tentativas"
        Me.num_tentativas.MaxInputLength = 3
        Me.num_tentativas.Name = "num_tentativas"
        '
        'Ativar
        '
        Me.Ativar.HeaderText = "Ativar"
        Me.Ativar.Name = "Ativar"
        Me.Ativar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Ativar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Excluir
        '
        Me.Excluir.HeaderText = "Excluir"
        Me.Excluir.Name = "Excluir"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(593, 9)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 13)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "SELECIONE:"
        '
        'cb_selecione
        '
        Me.cb_selecione.FormattingEnabled = True
        Me.cb_selecione.Items.AddRange(New Object() {"ID_USUARIO", "USUARIO", "STATUS_CONTA"})
        Me.cb_selecione.Location = New System.Drawing.Point(596, 31)
        Me.cb_selecione.Name = "cb_selecione"
        Me.cb_selecione.Size = New System.Drawing.Size(114, 21)
        Me.cb_selecione.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(185, 13)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "DIGITE O PARÂMETRO DE BUSCA:"
        '
        'txt_parametro
        '
        Me.txt_parametro.Location = New System.Drawing.Point(12, 31)
        Me.txt_parametro.Name = "txt_parametro"
        Me.txt_parametro.Size = New System.Drawing.Size(446, 20)
        Me.txt_parametro.TabIndex = 5
        '
        'FormStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(722, 420)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cb_selecione)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txt_parametro)
        Me.Controls.Add(Me.dgv_dados)
        Me.Name = "FormStatus"
        Me.Text = "FormStatus"
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_dados As DataGridView
    Friend WithEvents Label12 As Windows.Forms.Label
    Friend WithEvents cb_selecione As ComboBox
    Friend WithEvents Label11 As Windows.Forms.Label
    Friend WithEvents txt_parametro As TextBox
    Friend WithEvents id_usuario As DataGridViewTextBoxColumn
    Friend WithEvents usuario As DataGridViewTextBoxColumn
    Friend WithEvents status_conta As DataGridViewTextBoxColumn
    Friend WithEvents tipo_conta As DataGridViewTextBoxColumn
    Friend WithEvents num_tentativas As DataGridViewTextBoxColumn
    Friend WithEvents Ativar As DataGridViewImageColumn
    Friend WithEvents Excluir As DataGridViewImageColumn
End Class
