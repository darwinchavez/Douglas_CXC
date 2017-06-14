Public Class Clientes

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cadGuarda As String

        If Not IsNumeric(TextBox4.Text) Then
            MessageBox.Show("El limte de crédito es numérico")
            Exit Sub
        End If
        Try
            cadGuarda = "Insert into Clientes(CodigoCliente,Nombres,Apellidos,Limite_Credito) Values(@CodigoCliente,@Nombres,@Apellidos,@Limite_Credito)"


            Dim cmdGuarda As New OleDb.OleDbCommand(cadGuarda, conectar)


            cmdGuarda.Parameters.AddWithValue("CodigoCliente", Int(TextBox1.Text))
            cmdGuarda.Parameters.AddWithValue("Nombres", TextBox2.Text)
            cmdGuarda.Parameters.AddWithValue("Apellidos", TextBox3.Text)
            cmdGuarda.Parameters.AddWithValue("Limite_Credito", TextBox4.Text)


            conectar.Open()
            Dim t As Integer = CInt(cmdGuarda.ExecuteNonQuery)

            conectar.Close()
            MessageBox.Show("Registro Almacenado con éxito", "Empresa...", MessageBoxButtons.OK)
            Button1.Enabled = False
        Catch err As OleDb.OleDbException

            If err.ErrorCode = "-2147467259" Then ' "Los cambios solicitados en la tabla no se realizaron correctamente porque crearían valores duplicados en el índice, clave principal o relación. Cambie los datos en el campo o los campos que contienen datos duplicados, quite el índice o vuelva a definirlo para permitir entradas duplicadas e inténtelo de nuevo." Then
                MessageBox.Show("Ese Codigo ya existe,verifique", "Un aviso de Ugarte", MessageBoxButtons.OK)
                conectar.Close()
            End If

        End Try

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Button1.Enabled = True
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Clientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = 50
        Me.Left = 50
    End Sub
End Class