Public Class ModificaVenta
    Dim cod As Integer
    Dim fec As String
    Dim mfac As Double
    Dim nfac As String
    Dim campo As String
    Dim celda As Integer



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim fechadesde As Date = MaskedTextBox1.Text

        Dim fdes As String

        fdes = fechadesde.ToString("MM/d/yyyy")


        Dim mventa As String
        'Dim fecha As String = Format(f1, "MMM/dd/yyyy")

        mventa = "Select CodigoCliente,fechaTransaccion,NumDocumento,Monto from Transacciones where NumDocumento='" & TextBox1.Text & "' and FechaTransaccion=#" & fdes & "#"
        Dim da As New OleDb.OleDbDataAdapter(mventa, conectar)
        Dim ds As New DataSet
        da.Fill(ds, "FechaTransaccion")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "FechaTransaccion"
        da.Dispose()
        ''DataGridView1.Refresh()
    End Sub

    Private Sub ModificaVenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-ES")
        Me.Top = 50
        Me.Left = 50
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        celda = DataGridView1.CurrentRow.Cells(0).Value
        campo = DataGridView1.CurrentCell.OwningColumn.Name
        TextBox2.Text = campo
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
       
    End Sub

    Private Sub DataGridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.Click
        'Dim fecha1 As Date = CDate(DataGridView1.CurrentRow.Cells(1).Value)


        'fec = Format(fecha1, "dd/MMM/yyyy")

        'cod = DataGridView1.CurrentRow.Cells(0).Value

        'nfac = DataGridView1.CurrentRow.Cells(2).Value
        'mfac = DataGridView1.CurrentRow.Cells(3).Value
        'Dim mynumber As Integer = mfac
        '' MaskedTextBox2.Text = fec
        'TextBox2.Text = FormatNumber(mynumber, 2, , , TriState.True)
        'TextBox3.Text = nfac
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim nvalor As String
        If campo = "FechaTransaccion" Then
            Dim fecha As String = TextBox3.Text
            Dim strAct As String = "Update Transacciones set " & campo & "= #" & fecha & "# " & _
                                "where codigocliente= " & celda & " and NumDocumento='" & TextBox1.Text & "'"
            Dim cmdAct As New OleDb.OleDbCommand(strAct, conectar)
            conectar.Open()
            cmdAct.ExecuteNonQuery()
            conectar.Close()
            MessageBox.Show("OK")
        Else
            If campo = "Monto" Then

                nvalor = TextBox3.Text



                Dim strAct As String = "Update Transacciones set " & campo & "= '" & nvalor & "' " & _
                                    "where codigocliente= " & celda & " and NumDocumento='" & TextBox1.Text & "'"
                Dim cmdAct As New OleDb.OleDbCommand(strAct, conectar)
                conectar.Open()
                cmdAct.ExecuteNonQuery()
                conectar.Close()
                MessageBox.Show("OK")
            End If
        End If
    End Sub
End Class