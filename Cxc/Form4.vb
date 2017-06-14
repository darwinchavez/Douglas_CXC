Public Class Form4

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Seleccionar los registro en un rango de fechas para sacar saldo anterior.
        '(DETALLE)
        Dim fechadesde As Date = MaskedTextBox1.Text
        Dim fechahasta As Date = MaskedTextBox2.Text
        Dim fdes As String
        Dim fhas As String
        fdes = fechadesde.ToString("MM/dd/yyyy")
        fhas = fechahasta.ToString("MM/dd/yyyy")
        Dim strDetAbonos As String
        Dim BorraDetAbonos As String
        BorraDetAbonos = "Delete RepDetAbonos.* from RepDetAbonos"
        strDetAbonos = " Insert into RepDetAbonos SELECT Abonos.Numero, Abonos.CodigoCliente, Abonos.FechaAbono, Abonos.Num_Recibo, Abonos.Monto, Abonos.Tipo " & _
        " FROM Abonos" & _
        " WHERE Abonos.CodigoCliente=" & TextBox1.Text & " And Abonos.FechaAbono >= #" & fdes & "# AND Abonos.FechaAbono<=#" & fhas & "# "

        Dim cmdBorraDetAbonos As New OleDb.OleDbCommand(BorraDetAbonos, conectar)
        Dim cmdDetAbonos As New OleDb.OleDbCommand(strDetAbonos, conectar)
        conectar.Open()
        cmdBorraDetAbonos.ExecuteNonQuery()
        cmdDetAbonos.ExecuteNonQuery()

        

        '            'SALDO ANTERIOR
        Dim borraSalant As String
        borraSalant = "Delete SalAntAbonos.* from SalAntAbonos"
        Dim RsalAntAbonos As String
        RsalAntAbonos = "Insert into SalAntAbonos SELECT Abonos.[Numero], Abonos.[CodigoCliente], Abonos.[FechaAbono], Abonos.[Num_Recibo], Abonos.[Monto], Abonos.[Tipo] " & _
        " FROM Abonos" & _
        " WHERE Abonos.CodigoCliente=" & TextBox1.Text & " AND Abonos.FechaAbono < #" & fdes & "#"
        Dim cmdRsalAntAbonos As New OleDb.OleDbCommand(RsalAntAbonos, conectar)
        Dim cmdborraSalAnt As New OleDb.OleDbCommand(borraSalant, conectar)
        cmdborraSalAnt.ExecuteNonQuery()
        cmdRsalAntAbonos.ExecuteNonQuery()
        
        Dim borraSal As String
        Dim SalAnterior As String
        borraSal = "Delete SaldoAnterior.* from SaldoAnterior"
        SalAnterior = "Insert into SaldoAnterior SELECT DISTINCTROW SalAntAbonos.CodigoCliente, Sum(SalAntAbonos.Monto) AS [SalAnt] " & _
        " FROM SalAntAbonos" & _
        " GROUP BY SalAntAbonos.CodigoCliente" & _
        " HAVING (((SalAntAbonos.CodigoCliente)=" & TextBox1.Text & "))"
        Dim cmdborrasal As New OleDb.OleDbCommand(borraSal, conectar)
        Dim cmdsaldo As New OleDb.OleDbCommand(SalAnterior, conectar)
        cmdborrasal.ExecuteNonQuery()
        cmdsaldo.ExecuteNonQuery()

        '-------------------------------------------------------CREDITOS----------------------------------------------
        Dim strDetCreditos As String
        Dim BorraDetCreditos As String
        BorraDetCreditos = "Delete RepDetCreditos.* from RepDetCreditos"
        strDetCreditos = "Insert into RepDetCreditos SELECT Creditos.Numero, Creditos.CodigoCliente, Creditos.FechaCredito, Creditos.Num_Factura, Creditos.Monto, Creditos.Tipo " & _
        " FROM Creditos" & _
        " WHERE Creditos.CodigoCliente=" & TextBox1.Text & " And Creditos.FechaCredito >= #" & fdes & "# AND Creditos.FechaCredito<=#" & fhas & "# "

        Dim cmdBorraDetCreditos As New OleDb.OleDbCommand(BorraDetCreditos, conectar)
        Dim cmdDetCreditos As New OleDb.OleDbCommand(strDetCreditos, conectar)
        ' conectar.Open()
        cmdBorraDetCreditos.ExecuteNonQuery()
        cmdDetCreditos.ExecuteNonQuery()



        '            'SALDO ANTERIOR
        Dim borraSalantCre As String
        borraSalantCre = "Delete SalAntCreditos.* from SalAntCreditos"
        Dim RsalAntCreditos As String
        RsalAntCreditos = " Insert into SalAntCreditos SELECT Creditos.[Numero], Creditos.[CodigoCliente], Creditos.[FechaCredito], Creditos.[Num_Factura], Creditos.[Monto], Creditos.[Tipo] " & _
        " FROM Creditos" & _
        " WHERE Creditos.CodigoCliente=" & TextBox1.Text & " AND Creditos.FechaCredito < #" & fdes & "#"
        Dim cmdRsalAntCreditos As New OleDb.OleDbCommand(RsalAntCreditos, conectar)
        Dim cmdborraSalAntCre As New OleDb.OleDbCommand(borraSalantCre, conectar)
        cmdborraSalAnt.ExecuteNonQuery()
        cmdRsalAntCreditos.ExecuteNonQuery()

        Dim borraSalCre As String
        Dim SalAnteriorCre As String
        borraSalCre = "Delete SaldoAnteriorCre.* from SaldoAnteriorCre"
        SalAnteriorCre = " Insert into SaldoAnteriorCre  Select DISTINCTROW SalAntCreditos.CodigoCliente, Sum(SalAntCreditos.Monto) AS [SalAntCre] " & _
        " FROM SalAntCreditos" & _
        " GROUP BY SalAntCreditos.CodigoCliente" & _
        " HAVING (((SalAntCreditos.CodigoCliente)=" & TextBox1.Text & "))"
        Dim cmdborrasalCre As New OleDb.OleDbCommand(borraSalCre, conectar)
        Dim cmdsaldoCre As New OleDb.OleDbCommand(SalAnteriorCre, conectar)
        cmdborrasalCre.ExecuteNonQuery()
        cmdsaldoCre.ExecuteNonQuery()

        Dim borratotSaldoAnt As String
        borratotSaldoAnt = "Delete totSaldoAnt.* from totSaldoAnt"

        Dim totSaldoAnt As String
        totSaldoAnt = "Insert into TSaldoAnterior SELECT SaldoAnteriorCre.CodigoCliente, SaldoAnteriorCre.SalAntCre, SaldoAnterior.SalAnt,SaldoAnteriorCre.SalAntCre-SaldoAnterior.SalAnt as SaldoAnterior " & _
                       " FROM SaldoAnteriorCre INNER JOIN SaldoAnterior ON SaldoAnteriorCre.[CodigoCliente] = SaldoAnterior.[CodigoCliente]"
        Dim cmdborratotSaldoAnt As New OleDb.OleDbCommand(totSaldoAnt, conectar)
        Dim cmdtotSaldoAnt As New OleDb.OleDbCommand(totSaldoAnt, conectar)
        cmdborratotSaldoAnt.ExecuteNonQuery()
        cmdtotSaldoAnt.ExecuteNonQuery()
        conectar.Close()
        MessageBox.Show("Ok")
       

    End Sub
End Class