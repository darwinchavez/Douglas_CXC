Public Class Form1

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click

    End Sub

    Private Sub ClienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClienteToolStripMenuItem.Click
        Dim clientes As New Clientes
        clientes.Show()
    End Sub

    Private Sub FacturaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacturaToolStripMenuItem.Click
        Dim ventas As New Ventas
        ventas.Show()
    End Sub

    Private Sub ReciboToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReciboToolStripMenuItem.Click
        Dim abono As New Abonos
        abono.Show()
    End Sub

    Private Sub SalirToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub SaldosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaldosToolStripMenuItem.Click
        Dim salxcli As New SaldoxCliente
        salxcli.Show()
    End Sub

    Private Sub EstadoCuentaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EstadoCuentaToolStripMenuItem.Click
        Dim estado As New EstadoCta
        estado.Show()
    End Sub

    Private Sub ReciboToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReciboToolStripMenuItem1.Click
        modifica = "Credito"
        Dim cla As New FrmClave
        cla.Show()
    End Sub

    Private Sub ReciboToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReciboToolStripMenuItem2.Click
        modifica = "Abono"
        Dim cla As New FrmClave
        cla.Show()
    End Sub

    Private Sub FacturaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacturaToolStripMenuItem1.Click
        Dim mcli As New ModificarClientes
        mcli.Show()
    End Sub

    Private Sub VentasDiariasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VentasDiariasToolStripMenuItem.Click
        Dim rventas As New RepVentas
        rventas.Show()
    End Sub

    Private Sub AbonosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbonosToolStripMenuItem.Click
        Dim repabo As New ReporteAbonos
        repabo.Show()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = 50
        Me.Left = 50

    End Sub

    Private Sub ClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem.Click
        Dim repcli As New ReporteClienteCr1
        repcli.Show()
    End Sub

    Private Sub SaldosDeClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaldosDeClientesToolStripMenuItem.Click
        Dim SaldoCreditos As String
        Dim borraCreditos As String
        Dim borraAbonos As String
        Dim tcred As String = "Credito"
        Dim tabo As String = "Abono"
        borraCreditos = "Delete TotalCreditos.* from TotalCreditos"
        borraAbonos = "Delete TotalAbonos.* from TotalAbonos"

        SaldoCreditos = " Insert into TotalCreditos SELECT DISTINCTROW Transacciones.CodigoCliente, Sum(Transacciones.Monto) AS [Total_Creditos] " & _
        " FROM Transacciones " & _
        " GROUP BY Transacciones.CodigoCliente,Transacciones.TipoTransaccion " & _
        " Having  Transacciones.TipoTransaccion='" & tcred & "'"

        Dim SaldoAbonos As String
        SaldoAbonos = "Insert into TotalAbonos SELECT DISTINCTROW Transacciones.CodigoCliente, Sum(Transacciones.Monto) AS [Total_Abonos]  " & _
        " FROM Transacciones " & _
        " GROUP BY Transacciones.CodigoCliente,Transacciones.TipoTransaccion " & _
        " Having  Transacciones.TipoTransaccion='" & tabo & "'"

        Dim cmdborraCreditos As New OleDb.OleDbCommand(borraCreditos, conectar)
        Dim cmdborraAbonos As New OleDb.OleDbCommand(borraAbonos, conectar)

        Dim cmdCreditos As New OleDb.OleDbCommand(SaldoCreditos, conectar)
        Dim cmdAbonos As New OleDb.OleDbCommand(SaldoAbonos, conectar)


        conectar.Open()
        cmdborraCreditos.ExecuteNonQuery()
        cmdborraAbonos.ExecuteNonQuery()
        cmdCreditos.ExecuteNonQuery()
        cmdAbonos.ExecuteNonQuery()

        Dim bRestCtaClientes As String
        bRestCtaClientes = "Delete RestCtaClientes.* from RestCtaClientes"
        Dim cmdbrec As New OleDb.OleDbCommand(bRestCtaClientes, conectar)
        cmdbrec.ExecuteNonQuery()

        Dim EstCtaClientes As String
        EstCtaClientes = " Insert into RestCtaClientes SELECT Clientes.CodigoCliente, Clientes.Nombres, Clientes.Apellidos,Clientes.Limite_Credito,TotalCreditos.Total_Creditos,TotalAbonos.Total_Abonos,TotalCreditos.Total_Creditos-TotalAbonos.Total_Abonos as Saldo " & _
                         " FROM (Clientes INNER JOIN TotalCreditos ON Clientes.[CodigoCliente] = TotalCreditos.[CodigoCliente]) INNER JOIN TotalAbonos ON Clientes.[CodigoCliente] = TotalAbonos.[CodigoCliente]"

        Dim cmdestad As New OleDb.OleDbCommand(EstCtaClientes, conectar)
        cmdestad.ExecuteNonQuery()
        conectar.Close()
        


    End Sub

    Private Sub FacturasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacturasToolStripMenuItem.Click
        Dim rfact As New FrmFacturas
        rfact.Show()

    End Sub

    Private Sub TarjetasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TarjetasToolStripMenuItem.Click
        Dim tarj As New FrmTarjetas
        tarj.Show()
    End Sub

    Private Sub TarjetaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TarjetaToolStripMenuItem.Click
        Dim mTar As New FrmModificaTarj
        mTar.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Dim Rtarj As New FrmReporteTarjeta
        Rtarj.Show()
    End Sub

    Private Sub PruebaToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim RDetAb As New Form4
        RDetAb.Show()
    End Sub

    Private Sub PruebaToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles PruebaToolStripMenuItem.Click
        Dim Codigo As String
        Dim Nombres As String
        Dim apellidos As String
        Dim lcredito As Double
        Dim txt5 As Double
        Dim txt6 As Double
        Dim SaldoCreditos As String
        Dim borraCreditos As String
        Dim borraAbonos As String
        Dim tcred As String = "Credito"
        Dim tabo As String = "Abono"

        Dim bestcuenta As String
        bestcuenta = "Delete RestCtaClientes.* from RestCtaClientes "
        borraCreditos = "Delete TotalCreditos.* from TotalCreditos"
        borraAbonos = "Delete TotalAbonos.* from TotalAbonos"

        SaldoCreditos = " Insert into TotalCreditos SELECT DISTINCTROW Transacciones.CodigoCliente, Sum(Transacciones.Monto) AS [Total_Creditos] " & _
        " FROM Transacciones " & _
        " GROUP BY Transacciones.CodigoCliente,Transacciones.TipoTransaccion " & _
        " Having  Transacciones.TipoTransaccion='" & tcred & "'"

        Dim SaldoAbonos As String
        SaldoAbonos = "Insert into TotalAbonos SELECT DISTINCTROW Transacciones.CodigoCliente, Sum(Transacciones.Monto) AS [Total_Abonos]  " & _
        " FROM Transacciones " & _
        " GROUP BY Transacciones.CodigoCliente,Transacciones.TipoTransaccion " & _
        " Having Transacciones.TipoTransaccion='" & tabo & "'"

        Dim cmdbestcta As New OleDb.OleDbCommand(bestcuenta, conectar)
        Dim cmdborraCreditos As New OleDb.OleDbCommand(borraCreditos, conectar)
        Dim cmdborraAbonos As New OleDb.OleDbCommand(borraAbonos, conectar)

        Dim cmdCreditos As New OleDb.OleDbCommand(SaldoCreditos, conectar)
        Dim cmdAbonos As New OleDb.OleDbCommand(SaldoAbonos, conectar)


        conectar.Open()
        cmdbestcta.ExecuteNonQuery()
        cmdborraCreditos.ExecuteNonQuery()
        cmdborraAbonos.ExecuteNonQuery()
        cmdCreditos.ExecuteNonQuery()
        cmdAbonos.ExecuteNonQuery()
        Dim daClientes As New OleDb.OleDbDataAdapter("select * from Clientes ", conectar)
        Dim daCreditos As New OleDb.OleDbDataAdapter("select * from TotalCreditos", conectar)
        Dim daAbonos As New OleDb.OleDbDataAdapter("select * from TotalAbonos", conectar)

        Dim tablaClientes As New DataTable
        Dim tablaCreditos As New DataTable
        Dim tablaAbonos As New DataTable

        daClientes.Fill(tablaClientes)
        daCreditos.Fill(tablaCreditos)
        daAbonos.Fill(tablaAbonos)

        Dim filasClientes As DataRow()
        Dim filasCreditos As DataRow()
        Dim filasAbonos As DataRow()

        filasClientes = tablaClientes.Select()
        If filasClientes.Length > 0 Then
            For Each Clientes As DataRow In filasClientes
                txt5 = 0
                txt6 = 0
                Codigo = Clientes("CodigoCliente").ToString
                Nombres = Clientes("Nombres").ToString
                apellidos = Clientes("Apellidos").ToString
                lcredito = Clientes("Limite_Credito")

                'Recorrer creditos
                filasCreditos = tablaCreditos.Select("CodigoCliente= " & Codigo & "")
                If filasCreditos.Length > 0 Then
                    For Each dr As DataRow In filasCreditos
                        txt5 = dr("Total_Creditos").ToString
                    Next
                End If

                'recorrer abonos
                filasAbonos = tablaAbonos.Select("CodigoCliente=" & Codigo & " ")
                If filasAbonos.Length > 0 Then
                    For Each Abonos As DataRow In filasAbonos
                        txt6 = Abonos("Total_Abonos").ToString
                    Next
                End If

                'Guardar
                Dim insSaldoAnterior As String
                insSaldoAnterior = "Insert into RestCtaClientes(CodigoCliente,Nombres,Apellidos,Limite_Credito,Total_Creditos,Total_Abonos,Saldo) Values(@CodigoCliente,@Nombres,@Apellidos,@Limite_Credito,@Total_Creditos,@Total_Abonos,@Saldo)"
                Dim cmdllSaldoAnterior As New OleDb.OleDbCommand(insSaldoAnterior, conectar)

                cmdllSaldoAnterior.Parameters.AddWithValue("CodigoCliente", OleDb.OleDbType.Integer).Value = Codigo
                cmdllSaldoAnterior.Parameters.AddWithValue("Nombres", OleDb.OleDbType.VarChar).Value = Nombres
                cmdllSaldoAnterior.Parameters.AddWithValue("Apellidos", OleDb.OleDbType.Double).Value = apellidos
                cmdllSaldoAnterior.Parameters.AddWithValue("Limite_Credito", OleDb.OleDbType.VarChar).Value = lcredito
                cmdllSaldoAnterior.Parameters.AddWithValue("Total_Creditos", OleDb.OleDbType.Currency).Value = txt5
                cmdllSaldoAnterior.Parameters.AddWithValue("Total_Abonos", OleDb.OleDbType.VarChar).Value = txt6
                cmdllSaldoAnterior.Parameters.AddWithValue("Saldo", OleDb.OleDbType.Double).Value = txt5 - txt6

                cmdllSaldoAnterior.ExecuteNonQuery()


            Next
            

        End If

        conectar.Close()
        
        Dim rep As New SaldosCr5
        rep.Show()

    End Sub
End Class
