Public Class EstadoCta
    Dim cod As Integer
    Dim num As Integer
    Dim Santerior As Double
    Dim codCli As Integer
    Dim fecha As Date
    Dim nfac As String
    Dim nrec As String
    Dim tven As String
    Dim mfac As Double
    Dim mrec As Double
    Dim saldo As Double
    Dim SaldoAbono As Double
    Dim SaldoCredito As Double

    Private Sub EstadoCta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-ES")
        Me.Top = 50
        Me.Left = 50
    End Sub

    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2100:Revisar consultas SQL para comprobar si tienen vulnerabilidades de seguridad")> Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim fechadesde As Date = MaskedTextBox1.Text
        Dim fechahasta As Date = MaskedTextBox2.Text
        Dim fdes As String
        Dim fhas As String
        fdes = fechadesde.ToString("MM/d/yyyy")
        fhas = fechahasta.ToString("MM/d/yyyy")
        conectar.Open()
        'Todos los registros en el rango de fecha
        Dim borratr As String
        Dim TodosRegistros As String
        borratr = "Delete RegistrosxCliente.* from RegistrosxCliente"
        TodosRegistros = "Insert into RegistrosxCliente SELECT Transacciones.[Numero], Transacciones.[CodigoCliente], Transacciones.[FechaTransaccion], Transacciones.[NumDocumento], Transacciones.[Monto], Transacciones.[TipoTransaccion] " & _
        " FROM Transacciones" & _
        " WHERE Transacciones.CodigoCliente=" & TextBox1.Text & " AND Transacciones.FechaTransaccion >= #" & fdes & "# And  Transacciones.FechaTransaccion <=#" & fhas & "# order by Transacciones.FechaTransaccion,Transacciones.Numero"
        Dim cmdbtr As New OleDb.OleDbCommand(borratr, conectar)
        Dim cmdtr As New OleDb.OleDbCommand(TodosRegistros, conectar)
        cmdbtr.ExecuteNonQuery()
        cmdtr.ExecuteNonQuery()

        'Registros para calcular el saldo anterior
        Dim regsalAnt As String
        Dim bregsalAnt As String
        bregsalAnt = "Delete RegistrosSalAnt.* from RegistrosSalAnt"
        regsalAnt = " Insert into RegistrosSalAnt SELECT DISTINCTROW Transacciones.CodigoCliente, Transacciones.FechaTransaccion, Transacciones.TipoTransaccion, Sum(Transacciones.Monto) AS [Monto] " & _
        " FROM Transacciones" & _
        " GROUP BY Transacciones.CodigoCliente, Transacciones.FechaTransaccion, Transacciones.TipoTransaccion" & _
        " HAVING Transacciones.CodigoCliente=" & TextBox1.Text & " AND Transacciones.FechaTransaccion <#" & fdes & "#"

        Dim cmdbregsalAnt As New OleDb.OleDbCommand(bregsalAnt, conectar)
        Dim cmdrsa As New OleDb.OleDbCommand(regsalAnt, conectar)
        cmdbregsalAnt.ExecuteNonQuery()
        cmdrsa.ExecuteNonQuery()

        Dim bsaldoanterior As String
        bsaldoanterior = "Delete SaldoAnterior.* from SaldoAnterior"
        Dim cmdbsaldoanterior As New OleDb.OleDbCommand(bsaldoanterior, conectar)
        cmdbsaldoanterior.ExecuteNonQuery()

        'Calculo del saldo anterior.
        Dim saldoAnterior As String
        saldoAnterior = " Insert into SaldoAnterior SELECT DISTINCTROW RegistrosSalAnt.CodigoCliente, RegistrosSalAnt.TipoTransaccion, Sum(RegistrosSalAnt.Monto) AS [Monto] " & _
        " FROM RegistrosSalAnt" & _
        " GROUP BY RegistrosSalAnt.CodigoCliente, RegistrosSalAnt.TipoTransaccion"

        Dim cmdsaldoAnterior As New OleDb.OleDbCommand(saldoAnterior, conectar)
        cmdsaldoAnterior.ExecuteNonQuery()

        'Proceso de llenado de estado de cuenta

        'Llenar con saldoAnterior
        Dim AdptSalAnt As New OleDb.OleDbDataAdapter("Select * from SaldoAnterior", conectar)
        Dim tblSaldoAnterior As New DataTable
        AdptSalAnt.Fill(tblSaldoAnterior)
        Dim registrosSA As DataRow()
        registrosSA = tblSaldoAnterior.Select()
        If registrosSA.Length > 0 Then
            For Each dr As DataRow In registrosSA
                If dr("TipoTransaccion").ToString = "Abono" Then
                    SaldoAbono = dr("Monto").ToString
                Else
                    If dr("TipoTransaccion").ToString = "Credito" Then
                        SaldoCredito = dr("Monto")
                    End If
                End If

            Next
        End If
        saldo = SaldoCredito - SaldoAbono
        'Guardar saldo anterior

        

        Dim bSaldo As String
        bSaldo = "Delete EstadoCuenta.* from EstadoCuenta"
        Dim cmdbSaldo As New OleDb.OleDbCommand(bSaldo, conectar)
        cmdbSaldo.ExecuteNonQuery()
        Dim insSaldoAnterior As String

        insSaldoAnterior = "Insert into EstadoCuenta(CodigoCliente,FechaTransaccion,Num_Factura,Credito,Num_Recibo,Abono,Tipo_Transaccion,Saldo) Values(@CodigoCliente,@FechaTransaccion,@Num_Factura,@Credito,@Num_Recibo,@Abono,@Tipo_Transaccion,@Saldo)"
        Dim cmdinsSaldoAnterior As New OleDb.OleDbCommand(insSaldoAnterior, conectar)

        cmdinsSaldoAnterior.Parameters.AddWithValue("CodigoCliente", OleDb.OleDbType.Integer).Value = TextBox1.Text
        cmdinsSaldoAnterior.Parameters.AddWithValue("FechaTransaccion", fechadesde)
        cmdinsSaldoAnterior.Parameters.AddWithValue("Num_Factura", OleDb.OleDbType.VarChar).Value = "-"
        cmdinsSaldoAnterior.Parameters.AddWithValue("Credito", OleDb.OleDbType.Double).Value = 0
        cmdinsSaldoAnterior.Parameters.AddWithValue("Num_Recibo", OleDb.OleDbType.VarChar).Value = "-"
        cmdinsSaldoAnterior.Parameters.AddWithValue("Abono", OleDb.OleDbType.Currency).Value = 0
        cmdinsSaldoAnterior.Parameters.AddWithValue("TipoTransaccion", OleDb.OleDbType.VarChar).Value = "Saldo Anterior"
        cmdinsSaldoAnterior.Parameters.AddWithValue("Saldo", OleDb.OleDbType.Double).Value = saldo

        cmdinsSaldoAnterior.ExecuteNonQuery()

        'RECORRER SALDO POR CLIENTE
        Dim AdptRegxCli As New OleDb.OleDbDataAdapter("Select * from RegistrosxCliente", conectar)
        Dim tblRegxCliente As New DataTable
        AdptRegxCli.Fill(tblRegxCliente)
        Dim registros As DataRow()
        registros = tblRegxCliente.Select()
        If registros.Length > 0 Then
            For Each fila As DataRow In registros
                If fila("TipoTransaccion").ToString = "Abono" Then
                    fecha = fila("FechaTransaccion").ToString
                    nrec = fila("NumDocumento")
                    mrec = fila("Monto").ToString
                    saldo = saldo - mrec

                    insSaldoAnterior = "Insert into EstadoCuenta(CodigoCliente,FechaTransaccion,Num_Factura,Credito,Num_Recibo,Abono,Tipo_Transaccion,Saldo) Values(@CodigoCliente,@FechaTransaccion,@Num_Factura,@Credito,@Num_Recibo,@Abono,@Tipo_Transaccion,@Saldo)"
                    Dim cmdllSaldoAnterior As New OleDb.OleDbCommand(insSaldoAnterior, conectar)

                    cmdllSaldoAnterior.Parameters.AddWithValue("CodigoCliente", OleDb.OleDbType.Integer).Value = TextBox1.Text
                    cmdllSaldoAnterior.Parameters.AddWithValue("FechaTransaccion", OleDb.OleDbType.Date).Value = fecha
                    cmdllSaldoAnterior.Parameters.AddWithValue("Num_Factura", OleDb.OleDbType.VarChar).Value = "-"
                    cmdllSaldoAnterior.Parameters.AddWithValue("Credito", OleDb.OleDbType.Double).Value = 0
                    cmdllSaldoAnterior.Parameters.AddWithValue("Num_Recibo", OleDb.OleDbType.VarChar).Value = nrec
                    cmdllSaldoAnterior.Parameters.AddWithValue("Abono", OleDb.OleDbType.Currency).Value = mrec
                    cmdllSaldoAnterior.Parameters.AddWithValue("TipoTransaccion", OleDb.OleDbType.VarChar).Value = "Abono"
                    cmdllSaldoAnterior.Parameters.AddWithValue("Saldo", OleDb.OleDbType.Double).Value = saldo

                    cmdllSaldoAnterior.ExecuteNonQuery()
                Else
                    If fila("TipoTransaccion").ToString = "Credito" Then
                        fecha = fila("FechaTransaccion").ToString
                        nfac = fila("NumDocumento")
                        mfac = fila("Monto").ToString
                        saldo = saldo + mfac

                        insSaldoAnterior = "Insert into EstadoCuenta(CodigoCliente,FechaTransaccion,Num_Factura,Credito,Num_Recibo,Abono,Tipo_Transaccion,Saldo) Values(@CodigoCliente,@FechaTransaccion,@Num_Factura,@Credito,@Num_Recibo,@Abono,@Tipo_Transaccion,@Saldo)"
                        Dim cmdllSaldoAnterior As New OleDb.OleDbCommand(insSaldoAnterior, conectar)

                        cmdllSaldoAnterior.Parameters.AddWithValue("CodigoCliente", OleDb.OleDbType.Integer).Value = TextBox1.Text
                        cmdllSaldoAnterior.Parameters.AddWithValue("FechaTransaccion", OleDb.OleDbType.Date).Value = fecha
                        cmdllSaldoAnterior.Parameters.AddWithValue("Num_Factura", OleDb.OleDbType.VarChar).Value = nfac
                        cmdllSaldoAnterior.Parameters.AddWithValue("Credito", OleDb.OleDbType.Double).Value = mfac
                        cmdllSaldoAnterior.Parameters.AddWithValue("Num_Recibo", OleDb.OleDbType.VarChar).Value = "-"
                        cmdllSaldoAnterior.Parameters.AddWithValue("Abono", OleDb.OleDbType.Currency).Value = 0
                        cmdllSaldoAnterior.Parameters.AddWithValue("TipoTransaccion", OleDb.OleDbType.VarChar).Value = "Credito"
                        cmdllSaldoAnterior.Parameters.AddWithValue("Saldo", OleDb.OleDbType.Double).Value = saldo

                        cmdllSaldoAnterior.ExecuteNonQuery()
                    End If
                End If

            Next

            

        End If

        Dim bRestCuenta As String
        bRestCuenta = "Delete RepEstadoCuenta.* from RepEstadoCuenta"
        Dim cmdbest As New OleDb.OleDbCommand(bRestCuenta, conectar)
        cmdbest.ExecuteNonQuery()
        Dim EstCta As String
        EstCta = " Insert into RepEstadoCuenta SELECT Clientes.CodigoCliente, Clientes.Nombres, Clientes.Apellidos, EstadoCuenta.FechaTransaccion, EstadoCuenta.Num_Factura, EstadoCuenta.Num_Recibo, EstadoCuenta.Credito, EstadoCuenta.Abono, EstadoCuenta.Saldo" & _
                  " FROM Clientes INNER JOIN EstadoCuenta ON Clientes.[CodigoCliente] = EstadoCuenta.[CodigoCliente]"
        Dim cmdRes As New OleDb.OleDbCommand(EstCta, conectar)
        cmdRes.ExecuteNonQuery()
        conectar.Close()
        Dim reporte As New EstCtaCr2
        reporte.Show()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged
        Dim sbusca As String

        sbusca = "Select CodigoCliente,Nombres,Apellidos from Clientes where Nombres like '" & TextBox6.Text & "%'"
        Dim da As New OleDb.OleDbDataAdapter(sbusca, conectar)
        Dim ds As New DataSet
        da.Fill(ds, "CodigoCliente")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "CodigoCliente"
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        cod = DataGridView1.CurrentRow.Cells(0).Value
        TextBox1.Text = cod
        MaskedTextBox1.Focus()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class