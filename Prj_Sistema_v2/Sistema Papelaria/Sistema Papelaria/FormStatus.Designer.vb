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
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_parametro = New System.Windows.Forms.TextBox()
        Me.btn_filtrar = New System.Windows.Forms.Button()
        Me.cb_selecione = New System.Windows.Forms.ComboBox()
        Me.id_usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status_conta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo_conta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.num_tentativas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlternarStatus = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Excluir = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Editar = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_dados
        '
        Me.dgv_dados.AllowUserToAddRows = False
        Me.dgv_dados.AllowUserToDeleteRows = False
        Me.dgv_dados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_dados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_usuario, Me.usuario, Me.status_conta, Me.tipo_conta, Me.num_tentativas, Me.AlternarStatus, Me.Excluir, Me.Editar})
        Me.dgv_dados.Location = New System.Drawing.Point(13, 62)
        Me.dgv_dados.MultiSelect = False
        Me.dgv_dados.Name = "dgv_dados"
        Me.dgv_dados.ReadOnly = True
        Me.dgv_dados.Size = New System.Drawing.Size(697, 346)
        Me.dgv_dados.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(326, 9)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(98, 13)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "PESQUISAR POR:"
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
        Me.txt_parametro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_parametro.Location = New System.Drawing.Point(12, 31)
        Me.txt_parametro.Name = "txt_parametro"
        Me.txt_parametro.Size = New System.Drawing.Size(283, 20)
        Me.txt_parametro.TabIndex = 5
        '
        'btn_filtrar
        '
        Me.btn_filtrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_filtrar.Location = New System.Drawing.Point(589, 23)
        Me.btn_filtrar.Name = "btn_filtrar"
        Me.btn_filtrar.Size = New System.Drawing.Size(121, 32)
        Me.btn_filtrar.TabIndex = 9
        Me.btn_filtrar.Text = "Filtrar"
        Me.btn_filtrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btn_filtrar.UseVisualStyleBackColor = True
        '
        'cb_selecione
        '
        Me.cb_selecione.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cb_selecione.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_selecione.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_selecione.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb_selecione.FormattingEnabled = True
        Me.cb_selecione.Items.AddRange(New Object() {"ID_USUARIO", "USUARIO", "STATUS_CONTA"})
        Me.cb_selecione.Location = New System.Drawing.Point(329, 30)
        Me.cb_selecione.Name = "cb_selecione"
        Me.cb_selecione.Size = New System.Drawing.Size(223, 21)
        Me.cb_selecione.TabIndex = 16
        '
        'id_usuario
        '
        Me.id_usuario.HeaderText = "ID Usuário"
        Me.id_usuario.MaxInputLength = 10
        Me.id_usuario.Name = "id_usuario"
        Me.id_usuario.ReadOnly = True
        '
        'usuario
        '
        Me.usuario.HeaderText = "Usuário"
        Me.usuario.MaxInputLength = 40
        Me.usuario.Name = "usuario"
        Me.usuario.ReadOnly = True
        '
        'status_conta
        '
        Me.status_conta.HeaderText = "Status da Conta"
        Me.status_conta.MaxInputLength = 10
        Me.status_conta.Name = "status_conta"
        Me.status_conta.ReadOnly = True
        '
        'tipo_conta
        '
        Me.tipo_conta.HeaderText = "Tipo de Conta"
        Me.tipo_conta.MaxInputLength = 15
        Me.tipo_conta.Name = "tipo_conta"
        Me.tipo_conta.ReadOnly = True
        '
        'num_tentativas
        '
        Me.num_tentativas.HeaderText = "N de Tentativas"
        Me.num_tentativas.MaxInputLength = 3
        Me.num_tentativas.Name = "num_tentativas"
        Me.num_tentativas.ReadOnly = True
        '
        'AlternarStatus
        '
        Me.AlternarStatus.HeaderText = "Ativar/Bloquear"
        Me.AlternarStatus.Image = Global.Sistema_Papelaria.My.Resources.Resources.ic_block_black_24dp_2x
        Me.AlternarStatus.Name = "AlternarStatus"
        Me.AlternarStatus.ReadOnly = True
        Me.AlternarStatus.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AlternarStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Excluir
        '
        Me.Excluir.HeaderText = "Excluir"
        Me.Excluir.Image = Global.Sistema_Papelaria.My.Resources.Resources.ic_delete_forever_black_24dp_2x
        Me.Excluir.Name = "Excluir"
        Me.Excluir.ReadOnly = True
        '
        'Editar
        '
        Me.Editar.HeaderText = "Editar"
        Me.Editar.Image = Global.Sistema_Papelaria.My.Resources.Resources.ic_create_black_24dp_2x
        Me.Editar.Name = "Editar"
        Me.Editar.ReadOnly = True
        '
        'FormStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(722, 420)
        Me.Controls.Add(Me.cb_selecione)
        Me.Controls.Add(Me.btn_filtrar)
        Me.Controls.Add(Me.dgv_dados)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txt_parametro)
        Me.Name = "FormStatus"
        Me.Text = "Status das Contas"
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_dados As DataGridView
    Friend WithEvents Label12 As Windows.Forms.Label
    Friend WithEvents Label11 As Windows.Forms.Label
    Friend WithEvents txt_parametro As TextBox
    Friend WithEvents btn_filtrar As Button
    Private WithEvents cb_selecione As ComboBox
    Friend WithEvents id_usuario As DataGridViewTextBoxColumn
    Friend WithEvents usuario As DataGridViewTextBoxColumn
    Friend WithEvents status_conta As DataGridViewTextBoxColumn
    Friend WithEvents tipo_conta As DataGridViewTextBoxColumn
    Friend WithEvents num_tentativas As DataGridViewTextBoxColumn
    Friend WithEvents AlternarStatus As DataGridViewImageColumn
    Friend WithEvents Excluir As DataGridViewImageColumn
    Friend WithEvents Editar As DataGridViewImageColumn
End Class
