<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AgregarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReciboToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TarjetasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReciboToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReciboToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TarjetaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaldosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasDiariasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbonosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstadoCuentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaldosDeClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PruebaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarToolStripMenuItem, Me.ModificarToolStripMenuItem, Me.SalirToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.SalirToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(420, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AgregarToolStripMenuItem
        '
        Me.AgregarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClienteToolStripMenuItem, Me.FacturaToolStripMenuItem, Me.ReciboToolStripMenuItem, Me.TarjetasToolStripMenuItem})
        Me.AgregarToolStripMenuItem.Name = "AgregarToolStripMenuItem"
        Me.AgregarToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.AgregarToolStripMenuItem.Text = "Agregar"
        '
        'ClienteToolStripMenuItem
        '
        Me.ClienteToolStripMenuItem.Name = "ClienteToolStripMenuItem"
        Me.ClienteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ClienteToolStripMenuItem.Text = "Cliente"
        '
        'FacturaToolStripMenuItem
        '
        Me.FacturaToolStripMenuItem.Name = "FacturaToolStripMenuItem"
        Me.FacturaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FacturaToolStripMenuItem.Text = "Crédito"
        '
        'ReciboToolStripMenuItem
        '
        Me.ReciboToolStripMenuItem.Name = "ReciboToolStripMenuItem"
        Me.ReciboToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ReciboToolStripMenuItem.Text = "Abonos"
        '
        'TarjetasToolStripMenuItem
        '
        Me.TarjetasToolStripMenuItem.Name = "TarjetasToolStripMenuItem"
        Me.TarjetasToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.TarjetasToolStripMenuItem.Text = "Tarjetas"
        '
        'ModificarToolStripMenuItem
        '
        Me.ModificarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FacturaToolStripMenuItem1, Me.ReciboToolStripMenuItem1, Me.ReciboToolStripMenuItem2, Me.TarjetaToolStripMenuItem})
        Me.ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem"
        Me.ModificarToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.ModificarToolStripMenuItem.Text = "Modificar"
        '
        'FacturaToolStripMenuItem1
        '
        Me.FacturaToolStripMenuItem1.Name = "FacturaToolStripMenuItem1"
        Me.FacturaToolStripMenuItem1.Size = New System.Drawing.Size(113, 22)
        Me.FacturaToolStripMenuItem1.Text = "Cliente"
        '
        'ReciboToolStripMenuItem1
        '
        Me.ReciboToolStripMenuItem1.Name = "ReciboToolStripMenuItem1"
        Me.ReciboToolStripMenuItem1.Size = New System.Drawing.Size(113, 22)
        Me.ReciboToolStripMenuItem1.Text = "Factura"
        '
        'ReciboToolStripMenuItem2
        '
        Me.ReciboToolStripMenuItem2.Name = "ReciboToolStripMenuItem2"
        Me.ReciboToolStripMenuItem2.Size = New System.Drawing.Size(113, 22)
        Me.ReciboToolStripMenuItem2.Text = "Recibo"
        '
        'TarjetaToolStripMenuItem
        '
        Me.TarjetaToolStripMenuItem.Name = "TarjetaToolStripMenuItem"
        Me.TarjetaToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.TarjetaToolStripMenuItem.Text = "Tarjeta"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaldosToolStripMenuItem})
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.SalirToolStripMenuItem.Text = "Consultar"
        '
        'SaldosToolStripMenuItem
        '
        Me.SaldosToolStripMenuItem.Name = "SaldosToolStripMenuItem"
        Me.SaldosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SaldosToolStripMenuItem.Text = "Saldos"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VentasDiariasToolStripMenuItem, Me.AbonosToolStripMenuItem, Me.ToolStripMenuItem1, Me.EstadoCuentaToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.SaldosDeClientesToolStripMenuItem, Me.FacturasToolStripMenuItem, Me.PruebaToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'VentasDiariasToolStripMenuItem
        '
        Me.VentasDiariasToolStripMenuItem.Name = "VentasDiariasToolStripMenuItem"
        Me.VentasDiariasToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.VentasDiariasToolStripMenuItem.Text = "Créditos"
        '
        'AbonosToolStripMenuItem
        '
        Me.AbonosToolStripMenuItem.Name = "AbonosToolStripMenuItem"
        Me.AbonosToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.AbonosToolStripMenuItem.Text = "Abonos"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(171, 22)
        Me.ToolStripMenuItem1.Text = "Tarjetas"
        '
        'EstadoCuentaToolStripMenuItem
        '
        Me.EstadoCuentaToolStripMenuItem.Name = "EstadoCuentaToolStripMenuItem"
        Me.EstadoCuentaToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.EstadoCuentaToolStripMenuItem.Text = "Estado cuenta"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'SaldosDeClientesToolStripMenuItem
        '
        Me.SaldosDeClientesToolStripMenuItem.Name = "SaldosDeClientesToolStripMenuItem"
        Me.SaldosDeClientesToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.SaldosDeClientesToolStripMenuItem.Text = "Saldos de Clientes"
        '
        'FacturasToolStripMenuItem
        '
        Me.FacturasToolStripMenuItem.Name = "FacturasToolStripMenuItem"
        Me.FacturasToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.FacturasToolStripMenuItem.Text = "Facturas"
        '
        'SalirToolStripMenuItem1
        '
        Me.SalirToolStripMenuItem1.Name = "SalirToolStripMenuItem1"
        Me.SalirToolStripMenuItem1.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem1.Text = "Salir"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(286, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Versión 260317:10:04"
        '
        'PruebaToolStripMenuItem
        '
        Me.PruebaToolStripMenuItem.Name = "PruebaToolStripMenuItem"
        Me.PruebaToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.PruebaToolStripMenuItem.Text = "Estado de Cuentas"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 199)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Principal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AgregarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FacturaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReciboToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FacturaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReciboToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReciboToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaldosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VentasDiariasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbonosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EstadoCuentaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaldosDeClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FacturasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TarjetasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TarjetaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PruebaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
