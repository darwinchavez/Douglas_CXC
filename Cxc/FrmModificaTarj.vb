Public Class FrmModificaTarj
    Dim cod As Integer
    Dim fec As String
    Dim mfac As Double
    Dim nfac As String
    Dim campo As String
    Dim celda As Integer
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If campo = "FechaTransaccion" Then
                Dim fecha As String = TextBox2.Text
                Dim strAct As String = "Update Transacciones set " & campo & "= #" & fecha & "# " & _
                                    "where codigocliente= " & celda & " and NumDocumento='" & TextBox1.Text & "'"
                Dim cmdAct As New OleDb.OleDbCommand(strAct, conectar)
                conectar.Open()
                cmdAct.ExecuteNonQuery()
                conectar.Close()
                MessageBox.Show("OK")
            Else

                If campo = "Monto" Then
                    Dim nvalor As String
                    nvalor = TextBox2.Text
                End If
                Dim strAct As String = "Update Transacciones set " & campo & "= '" & TextBox2.Text & "' " & _
                                    "where codigocliente= " & celda & " and NumDocumento='" & TextBox1.Text & "'"
                Dim cmdAct As New OleDb.OleDbCommand(strAct, conectar)
                conectar.Open()
                cmdAct.ExecuteNonQuery()
                conectar.Close()
                MessageBox.Show("OK")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim f1 As Date = CDate(MaskedTextBox1.Text)
        Dim fechas As Date = MaskedTextBox1.Text
        Dim fecha1 As String
        fecha1 = fechas.ToString("MM/d/yyyy")
        ' Label1.Text = fechas
        Dim ttrans As String = "Tarjeta"
        Dim montoL As String
        'Dim fecha As String = Format(f1, "MMM/dd/yyyy")

        montoL = "Select CodigoCliente,FechaTransaccion,NumDocumento,Monto from Tarjetas where NumDocumento='" & TextBox1.Text & "' and FechaTransaccion=#" & fecha1 & "# and TipoTransaccion='" & ttrans & "'"
        Dim da As New OleDb.OleDbDataAdapter(montoL, conectar)
        Dim ds As New DataSet
        da.Fill(ds, "FechaTransaccion")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "FechaTransaccion"
        ''DataGridView1.Refresh()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        celda = DataGridView1.CurrentRow.Cells(0).Value
        campo = DataGridView1.CurrentCell.OwningColumn.Name
        TextBox3.Text = campo
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class