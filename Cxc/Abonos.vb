Public Class Abonos
    Dim cod As Integer
    Dim nom As String
    Dim ape As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim fechadesde As Date = MaskedTextBox1.Text
        Dim tv As String = "Abono"
        Dim fdes As String

        fdes = fechadesde.ToString("dd/MMM/yyyy")



        Dim cadGuarda As String
        
        Dim mrec As String = TextBox5.Text
        conectar.Open()
        'Try
        cadGuarda = "Insert into Transacciones(CodigoCliente,FechaTransaccion,NumDocumento,Monto,TipoTransaccion) Values(@CodigoCliente,@FechaTransaccion,@NumDocumento,@Monto,@TipoTransaccion)"


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
        cmdGuarda.Parameters.AddWithValue("FechaTransaccion", fechadesde)
        cmdGuarda.Parameters.AddWithValue("NumDocumento", TextBox4.Text)
        cmdGuarda.Parameters.AddWithValue("Monto", OleDb.OleDbType.VarChar).Value = mrec
        cmdGuarda.Parameters.AddWithValue("TipoTransaccion", tv)



        Dim t As Integer = CInt(cmdGuarda.ExecuteNonQuery)

        conectar.Close()
        MessageBox.Show("Registro Almacenado con éxito", "Empresa...", MessageBoxButtons.OK)
        Button1.Enabled = False
        'Catch ex As Exception

        '    If ex.Message = "Los cambios solicitados en la tabla no se realizaron correctamente porque crearían valores duplicados en el índice, clave principal o relación. Cambie los datos en el campo o los campos que contienen datos duplicados, quite el índice o vuelva a definir el índice para permitir entradas duplicadas e inténtelo de nuevo." Then
        '        MessageBox.Show("Ese Recibo ya existe,verifique", "Aviso", MessageBoxButtons.OK)
        '        conectar.Close()
        '    End If

        'End Try

    End Sub

    Private Sub TextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.LostFocus
        'If TextBox1.Text = "" Then
        '    Exit Sub
        'Else
        '    conectar.Open()
        '    Dim da1 As New OleDb.OleDbDataAdapter("select * from Clientes", conectar)
        '    Dim tabla1 As New DataTable
        '    da1.Fill(tabla1)
        '    Dim filas1 As DataRow()
        '    filas1 = tabla1.Select("CodigoCliente= " & TextBox1.Text & "")
        '    If filas1.Length > 0 Then
        '        For Each dr As DataRow In filas1
        '            TextBox2.Text = dr("Nombres").ToString
        '            TextBox3.Text = dr("Apellidos").ToString


        '            conectar.Close()


        '            'BasicoCtxt.Text = Math.Round(basicoC, 2)


        '        Next

        '    Else
        '        MessageBox.Show("Ese Empleado no existe")

        '        conectar.Close()

        '    End If



        'End If

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
      
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        Button1.Enabled = True
        TextBox6.Focus()
    End Sub

    Private Sub Abonos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = 50
        Me.Left = 50
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
        nom = DataGridView1.CurrentRow.Cells(1).Value
        ape = DataGridView1.CurrentRow.Cells(2).Value
        TextBox1.Text = cod
        TextBox2.Text = nom
        TextBox3.Text = ape
        MaskedTextBox1.Focus()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub MaskedTextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MaskedTextBox1.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles MaskedTextBox1.MaskInputRejected

    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox5.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub
End Class