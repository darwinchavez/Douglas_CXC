Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        

        Dim tven As String = "Credito"
        Dim salini As String = "SI"
        Dim repventas As String
        repventas = "Select * into SalIni from transacciones where nfactura='" & salini & "'"

        Dim cmdventas As New OleDb.OleDbCommand(RepVentas, conectar)
        conectar.Open()
        cmdventas.ExecuteNonQuery()
        conectar.Close()
        MessageBox.Show("OK")
        
    End Sub
End Class