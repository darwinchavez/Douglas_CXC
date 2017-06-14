Public Class ReporteAbonos

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim fechadesde As Date = MaskedTextBox1.Text
        Dim fechahasta As Date = MaskedTextBox2.Text
        Dim fdes As String
        Dim fhas As String
        fdes = fechadesde.ToString("MM/dd/yyyy")
        fhas = fechahasta.ToString("MM/dd/yyyy")

        'fecha = dia1 & "/" & mes1 & "/" & ano1

        Dim tven As String = "Abono"

        Dim RepAbonos As String
        Dim borra As String = "Delete RepAbonos.* from RepAbonos"
        RepAbonos = " Insert into RepAbonos SELECT Clientes.CodigoCliente, Clientes.Nombres, Clientes.Apellidos, Transacciones.Numero,Transacciones.FechaTransaccion, Transacciones.NumDocumento, Transacciones.Monto, Transacciones.TipoTransaccion " & _
        " FROM Clientes INNER JOIN Transacciones ON Clientes.CodigoCliente = Transacciones.CodigoCliente" & _
        " WHERE Transacciones.FechaTransaccion >= #" & fdes & "# AND Transacciones.FechaTransaccion<=#" & fhas & "# AND Transacciones.TipoTransaccion='" & tven & "'" & _
        " order by Transacciones.Numero "
        Dim cmdborra As New OleDb.OleDbCommand(borra, conectar)
        Dim cmdventas As New OleDb.OleDbCommand(RepAbonos, conectar)
        conectar.Open()
        cmdborra.ExecuteNonQuery()
        cmdventas.ExecuteNonQuery()
        conectar.Close()

        Dim repabo As New RepAbonoscr4
        repabo.Show()
    End Sub

    Private Sub ReporteAbonos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = 50
        Me.Left = 50
    End Sub

    Private Sub MaskedTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MaskedTextBox1.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedTextBox1.MaskInputRejected

    End Sub

    Private Sub MaskedTextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MaskedTextBox2.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub MaskedTextBox2_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedTextBox2.MaskInputRejected

    End Sub
End Class