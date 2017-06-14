Public Class FrmReporteTarjeta

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fechadesde As Date = MaskedTextBox1.Text
        Dim fechahasta As Date = MaskedTextBox2.Text
        Dim fdes As String
        Dim fhas As String
        fdes = fechadesde.ToString("MM/d/yyyy")
        fhas = fechahasta.ToString("MM/d/yyyy")

        'fecha = dia1 & "/" & mes1 & "/" & ano1

        Dim tven As String = "Tarjeta"

        Dim RepTarjetas As String
        Dim borra As String = "Delete RepTarjetas.* from RepTarjetas"
        RepTarjetas = "Insert into RepTarjetas SELECT Clientes.CodigoCliente, Clientes.Nombres, Clientes.Apellidos,Transacciones.Numero,Transacciones.FechaTransaccion, Transacciones.NumDocumento, Transacciones.Monto, Transacciones.TipoTransaccion " & _
       " FROM Clientes INNER JOIN Transacciones ON Clientes.[CodigoCliente] = Transacciones.[CodigoCliente]" & _
       " WHERE Transacciones.[FechaTransaccion] >= #" & fdes & "# AND Transacciones.[FechaTransaccion]<=#" & fhas & "# AND Transacciones.[Tipo]='" & tven & "'" & _
       "order by Transacciones.Numero"
        Dim cmdborra As New OleDb.OleDbCommand(borra, conectar)
        Dim cmdTarjeta As New OleDb.OleDbCommand(RepTarjetas, conectar)
        conectar.Open()
        cmdborra.ExecuteNonQuery()
        cmdTarjeta.ExecuteNonQuery()
        conectar.Close()

       
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class