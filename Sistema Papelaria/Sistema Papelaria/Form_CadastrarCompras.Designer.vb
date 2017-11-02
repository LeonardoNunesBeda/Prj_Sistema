<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_CadastrarCompras
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
        Me.lbl_codigo = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Txt_vendendor = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Txt_Cliente = New System.Windows.Forms.TextBox()
        Me.Txt_CodProd = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_NomeProd = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DirectoryEntry1 = New System.DirectoryServices.DirectoryEntry()
        Me.Btn_salvar = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Lbl_valorProd = New System.Windows.Forms.Label()
        Me.Lbl_Total = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Txt_QuantidadeProd = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_codigo
        '
        Me.lbl_codigo.AutoSize = True
        Me.lbl_codigo.Font = New System.Drawing.Font("Modern No. 20", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_codigo.Location = New System.Drawing.Point(10, 41)
        Me.lbl_codigo.Name = "lbl_codigo"
        Me.lbl_codigo.Size = New System.Drawing.Size(89, 38)
        Me.lbl_codigo.TabIndex = 0
        Me.lbl_codigo.Text = "0001"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_codigo)
        Me.GroupBox1.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(105, 100)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Código da Compra"
        '
        'Txt_vendendor
        '
        Me.Txt_vendendor.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_vendendor.Location = New System.Drawing.Point(10, 37)
        Me.Txt_vendendor.Multiline = True
        Me.Txt_vendendor.Name = "Txt_vendendor"
        Me.Txt_vendendor.Size = New System.Drawing.Size(460, 38)
        Me.Txt_vendendor.TabIndex = 4
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Txt_vendendor)
        Me.GroupBox2.Font = New System.Drawing.Font("Modern No. 20", 15.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(138, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(476, 100)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Vendedor"
        '
        'Txt_Cliente
        '
        Me.Txt_Cliente.Font = New System.Drawing.Font("Modern No. 20", 9.75!)
        Me.Txt_Cliente.Location = New System.Drawing.Point(17, 35)
        Me.Txt_Cliente.Multiline = True
        Me.Txt_Cliente.Name = "Txt_Cliente"
        Me.Txt_Cliente.Size = New System.Drawing.Size(568, 38)
        Me.Txt_Cliente.TabIndex = 7
        '
        'Txt_CodProd
        '
        Me.Txt_CodProd.Font = New System.Drawing.Font("Modern No. 20", 9.75!)
        Me.Txt_CodProd.Location = New System.Drawing.Point(6, 53)
        Me.Txt_CodProd.Multiline = True
        Me.Txt_CodProd.Name = "Txt_CodProd"
        Me.Txt_CodProd.Size = New System.Drawing.Size(54, 38)
        Me.Txt_CodProd.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Código"
        '
        'Txt_NomeProd
        '
        Me.Txt_NomeProd.Font = New System.Drawing.Font("Modern No. 20", 9.75!)
        Me.Txt_NomeProd.Location = New System.Drawing.Point(67, 53)
        Me.Txt_NomeProd.Multiline = True
        Me.Txt_NomeProd.Name = "Txt_NomeProd"
        Me.Txt_NomeProd.Size = New System.Drawing.Size(198, 38)
        Me.Txt_NomeProd.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(457, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Valor do produto"
        '
        'Btn_salvar
        '
        Me.Btn_salvar.Font = New System.Drawing.Font("Modern No. 20", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_salvar.Location = New System.Drawing.Point(12, 365)
        Me.Btn_salvar.Name = "Btn_salvar"
        Me.Btn_salvar.Size = New System.Drawing.Size(200, 61)
        Me.Btn_salvar.TabIndex = 12
        Me.Btn_salvar.Text = "Salvar"
        Me.Btn_salvar.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Lbl_Total)
        Me.GroupBox3.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(454, 339)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(160, 87)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Valor Total da Compra"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Txt_QuantidadeProd)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Lbl_valorProd)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Txt_CodProd)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Txt_NomeProd)
        Me.GroupBox4.Font = New System.Drawing.Font("Modern No. 20", 15.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 236)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(602, 100)
        Me.GroupBox4.TabIndex = 14
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Compra"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Txt_Cliente)
        Me.GroupBox5.Font = New System.Drawing.Font("Modern No. 20", 15.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 130)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(602, 100)
        Me.GroupBox5.TabIndex = 15
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Cliente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(64, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 17)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Nome do Produto"
        '
        'Lbl_valorProd
        '
        Me.Lbl_valorProd.AutoSize = True
        Me.Lbl_valorProd.Location = New System.Drawing.Point(482, 56)
        Me.Lbl_valorProd.Name = "Lbl_valorProd"
        Me.Lbl_valorProd.Size = New System.Drawing.Size(80, 22)
        Me.Lbl_valorProd.TabIndex = 13
        Me.Lbl_valorProd.Text = "R$ 0,00"
        '
        'Lbl_Total
        '
        Me.Lbl_Total.AutoSize = True
        Me.Lbl_Total.Font = New System.Drawing.Font("Modern No. 20", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Lbl_Total.Location = New System.Drawing.Point(43, 56)
        Me.Lbl_Total.Name = "Lbl_Total"
        Me.Lbl_Total.Size = New System.Drawing.Size(80, 22)
        Me.Lbl_Total.TabIndex = 0
        Me.Lbl_Total.Text = "R$ 0,00"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(278, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(173, 17)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Quantidade de produtos"
        '
        'Txt_QuantidadeProd
        '
        Me.Txt_QuantidadeProd.Font = New System.Drawing.Font("Modern No. 20", 9.75!)
        Me.Txt_QuantidadeProd.Location = New System.Drawing.Point(313, 53)
        Me.Txt_QuantidadeProd.Multiline = True
        Me.Txt_QuantidadeProd.Name = "Txt_QuantidadeProd"
        Me.Txt_QuantidadeProd.Size = New System.Drawing.Size(101, 38)
        Me.Txt_QuantidadeProd.TabIndex = 15
        '
        'Form_CadastrarCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(638, 438)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Btn_salvar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form_CadastrarCompras"
        Me.Text = "Comprar"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbl_codigo As Windows.Forms.Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Txt_vendendor As TextBox
    Friend WithEvents Txt_Cliente As TextBox
    Friend WithEvents Txt_CodProd As TextBox
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Txt_NomeProd As TextBox
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents DirectoryEntry1 As DirectoryServices.DirectoryEntry
    Friend WithEvents Btn_salvar As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Lbl_Total As Windows.Forms.Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Txt_QuantidadeProd As TextBox
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents Lbl_valorProd As Windows.Forms.Label
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents GroupBox5 As GroupBox
    Public WithEvents GroupBox2 As GroupBox
End Class
