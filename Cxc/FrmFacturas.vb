Public Class FrmFacturas
    Dim cod As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim fechadesde As Date = MaskedTextBox1.Text
        Dim fechahasta As Date = MaskedTextBox2.Text
        Dim fdes As String
        Dim fhas As String
        fdes = fechadesde.ToString("MM/d/yyyy")
        fhas = fechahasta.ToString("MM/d/yyyy")

        Dim strEstCta As String
        Dim borra As String
        borra = "Delete RdeFacturas.* from RdeFacturas"

        strEstCta = "Insert into RdeFacturas SELECT Clientes.CodigoCliente,Clientes.Nombres,Clientes.Apellidos, Transacciones.FechaTransaccion, Transacciones.NumDocumento, Transacciones.Monto " & _
" FROM Clientes INNER JOIN Transacciones ON Clientes.[CodigoCliente] = Transacciones.[CodigoCliente]" & _
" WHERE Clientes.CodigoCliente=" & TextBox1.Text & " AND Transacciones.FechaTransaccion  between #" & fdes & "# And  #" & fhas & "#" & _
 " order BY Transacciones.Fecha"
        Dim cmdborra As New OleDb.OleDbCommand(borra, conectar)
        conectar.Open()
        cmdborra.ExecuteNonQuery()

        Dim cmdsegundo As New OleDb.OleDbCommand(strEstCta, conectar)

        cmdsegundo.ExecuteNonQuery()
        conectar.Close()
        Dim Rverfact As New FrmCrFacturas
        Rverfact.Show()
       
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

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
End Class