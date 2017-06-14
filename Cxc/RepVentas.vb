Public Class RepVentas

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
       
        Dim fechadesde As Date = MaskedTextBox1.Text
        Dim fechahasta As Date = MaskedTextBox2.Text
        Dim fdes As String
        Dim fhas As String
        fdes = fechadesde.ToString("MM/d/yyyy")
        fhas = fechahasta.ToString("MM/d/yyyy")
        
        'fecha = dia1 & "/" & mes1 & "/" & ano1

        Dim tven As String = "Credito"
        
        Dim RepVentas As String
        Dim borra As String = "Delete RepVentas.* from RepVentas"
        RepVentas = " Insert into RepVentas SELECT Clientes.CodigoCliente, Clientes.Nombres, Clientes.Apellidos, Transacciones.Numero,Transacciones.FechaTransaccion, Transacciones.NumDocumento, Transacciones.Monto, Transacciones.TipoTransaccion " & _
        " FROM Clientes INNER JOIN Transacciones ON Clientes.CodigoCliente = Transacciones.CodigoCliente" & _
        " WHERE Transacciones.FechaTransaccion >= #" & fdes & "# AND Transacciones.FechaTransaccion<=#" & fhas & "# AND Transacciones.TipoTransaccion='" & tven & "'" & _
        " order by Transacciones.Numero"
        Dim cmdborra As New OleDb.OleDbCommand(borra, conectar)
        Dim cmdventas As New OleDb.OleDbCommand(RepVentas, conectar)
        conectar.Open()
        cmdborra.ExecuteNonQuery()
        cmdventas.ExecuteNonQuery()
        conectar.Close()
        'MessageBox.Show("OK")
        Dim repvtas As New RepVentasCr3
        repvtas.Show()

    End Sub

    Private Sub RepVentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-ES")
        Me.Top = 50
        Me.Left = 50
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class