<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_CarregarCompras
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_CarregarCompras))
        Me.Dgv_Compras = New System.Windows.Forms.DataGridView()
        Me.Txt_cliente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_CodigoCompra = New System.Windows.Forms.TextBox()
        CType(Me.Dgv_Compras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dgv_Compras
        '
        resources.ApplyResources(Me.Dgv_Compras, "Dgv_Compras")
        Me.Dgv_Compras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_Compras.Name = "Dgv_Compras"
        '
        'Txt_cliente
        '
        resources.ApplyResources(Me.Txt_cliente, "Txt_cliente")
        Me.Txt_cliente.Name = "Txt_cliente"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Txt_CodigoCompra
        '
        resources.ApplyResources(Me.Txt_CodigoCompra, "Txt_CodigoCompra")
        Me.Txt_CodigoCompra.Name = "Txt_CodigoCompra"
        '
        'Form_CarregarCompras
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Txt_CodigoCompra)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txt_cliente)
        Me.Controls.Add(Me.Dgv_Compras)
        Me.Name = "Form_CarregarCompras"
        CType(Me.Dgv_Compras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Dgv_Compras As DataGridView
    Friend WithEvents Txt_cliente As TextBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Txt_CodigoCompra As TextBox
End Class
