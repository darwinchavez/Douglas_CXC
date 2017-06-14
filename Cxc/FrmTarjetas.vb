Public Class FrmTarjetas
    Dim cod As Integer
    Dim nom As String
    Dim ape As String
    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        Dim sbusca As String

        sbusca = "Select CodigoCliente,Nombres,Apellidos from Clientes where Nombres like '" & TextBox6.Text & "%'"
        Dim da As New OleDb.OleDbDataAdapter(sbusca, conectar)
        Dim ds As New DataSet
        da.Fill(ds, "CodigoCliente")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "CodigoCliente"
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        cod = DataGridView1.CurrentRow.Cells(0).Value
        nom = DataGridView1.CurrentRow.Cells(1).Value
        ape = DataGridView1.CurrentRow.Cells(2).Value
        TextBox1.Text = cod
        TextBox2.Text = nom
        TextBox3.Text = ape
        MaskedTextBox1.Focus()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fechadesde As Date = MaskedTextBox1.Text
        Dim tv As String = "Tarjeta"
        Dim fdes As String

        fdes = fechadesde.ToString("dd/MMM/yyyy")



        Dim cadGuarda As String

        Dim mrec As String = TextBox5.Text
        conectar.Open()
        Try
            cadGuarda = "Insert into Tarjetas(CodigoCliente,FechaIngreso,Num_Lote,Monto,Tipo) Values(@CodigoCliente,@FechaIngreso,@Num_Lote,@Monto,@Tipo)"


            Dim cmdGuarda As New OleDb.OleDbCommand(cadGuarda, conectar)
            If Not IsDate(MaskedTextBox1.Text) Then
                MessageBox.Show("Digite una fecha válida", "Error", MessageBoxButtons.OK)
                MaskedTextBox1.Focus()
            End If
            If Not IsNumeric(TextBox5.Text) Then
                MessageBox.Show("El Monto debe ser un valor numérico", "Aviso ", MessageBoxButtons.OK)
                TextBox5.Focus()
            End If



            cmdGuarda.Parameters.AddWithValue("CodigoCliente", Int(TextBox1.Text))
            cmdGuarda.Parameters.AddWithValue("FechaIngreso", fechadesde)
            cmdGuarda.Parameters.AddWithValue("Num_Lote", TextBox4.Text)
            cmdGuarda.Parameters.AddWithValue("Monto", OleDb.OleDbType.VarChar).Value = mrec
            cmdGuarda.Parameters.AddWithValue("Tipo", tv)



            Dim t As Integer = CInt(cmdGuarda.ExecuteNonQuery)

            conectar.Close()
            MessageBox.Show("Registro Almacenado con éxito", "Empresa...", MessageBoxButtons.OK)
            Button1.Enabled = False
        Catch ex As Exception

            If ex.Message = "Los cambios solicitados en la tabla no se realizaron correctamente porque crearían valores duplicados en el índice, clave principal o relación. Cambie los datos en el campo o los campos que contienen datos duplicados, quite el índice o vuelva a definir el índice para permitir entradas duplicadas e inténtelo de nuevo." Then
                MessageBox.Show("Ese Recibo ya existe,verifique", "Aviso", MessageBoxButtons.OK)
                conectar.Close()
            End If

        End Try
    End Sub

    Private Sub FrmTarjetas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = 50
        Me.Left = 50
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        Button1.Enabled = True
        TextBox6.Focus()
    End Sub
End Class