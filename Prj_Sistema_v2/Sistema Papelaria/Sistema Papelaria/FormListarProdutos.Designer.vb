<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormListarProdutos
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_add_prod = New System.Windows.Forms.Button()
        Me.lst_produtos = New System.Windows.Forms.ListBox()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lst_produtos)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(251, 252)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Produtos fornecidos:"
        '
        'btn_add_prod
        '
        Me.btn_add_prod.BackColor = System.Drawing.Color.Transparent
        Me.btn_add_prod.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add_prod.Location = New System.Drawing.Point(12, 270)
        Me.btn_add_prod.Name = "btn_add_prod"
        Me.btn_add_prod.Size = New System.Drawing.Size(251, 36)
        Me.btn_add_prod.TabIndex = 2
        Me.btn_add_prod.Text = "Selecionar Produto"
        Me.btn_add_prod.UseVisualStyleBackColor = False
        '
        'lst_produtos
        '
        Me.lst_produtos.FormattingEnabled = True
        Me.lst_produtos.Location = New System.Drawing.Point(6, 20)
        Me.lst_produtos.Name = "lst_produtos"
        Me.lst_produtos.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lst_produtos.Size = New System.Drawing.Size(239, 225)
        Me.lst_produtos.TabIndex = 0
        '
        'FormListarProdutos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(275, 321)
        Me.Controls.Add(Me.btn_add_prod)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "FormListarProdutos"
        Me.Text = "Listar Produtos"
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lst_produtos As ListBox
    Friend WithEvents btn_add_prod As Button
End Class
