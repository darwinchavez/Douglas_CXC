Public Class ModificarClientes
    Dim cod As Integer
    Dim campo As String
    Dim celda As Integer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        ''Dim f1 As Date = CDate(MaskedTextBox1.Text)

        'Dim mabono As String
        ''Dim fecha As String = Format(f1, "MMM/dd/yyyy")

        'mabono = "Select CodigoCliente,Nombres,Apellidos from Clientes where Nombres like '" & TextBox1.Text & "%'"
        'Dim da As New OleDb.OleDbDataAdapter(mabono, conectar)
        'Dim ds As New DataSet
        'da.Fill(ds, "Nombres")
        'DataGridView1.DataSource = ds
        'DataGridView1.DataMember = "Nombres"
        ' ''DataGridView1.Refresh()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        celda = DataGridView1.CurrentRow.Cells(0).Value
        campo = DataGridView1.CurrentCell.OwningColumn.Name
        TextBox3.Text = campo
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim strAct As String = "Update Clientes set " & campo & "= '" & TextBox2.Text & "' " & _
                               "where codigocliente= " & celda
        Dim cmdAct As New OleDb.OleDbCommand(strAct, conectar)
        conectar.Open()
        cmdAct.ExecuteNonQuery()
        conectar.Close()
        MessageBox.Show("OK")

       
    End Sub

    Private Sub ModificarClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = 50
        Me.Left = 50
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Dim f1 As Date = CDate(MaskedTextBox1.Text)
        ' Label1.Text = fechas

        Dim mcliente As String
        'Dim fecha As String = Format(f1, "MMM/dd/yyyy")

        mcliente = "Select CodigoCliente,Nombres,Apellidos from Clientes where CodigoCliente=" & TextBox1.Text & ""
        Dim da As New OleDb.OleDbDataAdapter(mcliente, conectar)
        Dim ds As New DataSet
        da.Fill(ds, "codigocliente")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "codigocliente"
        ''DataGridView1.Refresh()
    End Sub
End Class