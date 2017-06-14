Public Class SaldoxCliente

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim txt4 As String
        Dim txt5 As String
        Dim txt6 As String
        Dim SaldoCreditos As String
        Dim borraCreditos As String
        Dim borraAbonos As String
        Dim tcred As String = "Credito"
        Dim tabo As String = "Abono"

        borraCreditos = "Delete TotalCreditos.* from TotalCreditos"
        borraAbonos = "Delete TotalAbonos.* from TotalAbonos"

        SaldoCreditos = " Insert into TotalCreditos SELECT DISTINCTROW Transacciones.CodigoCliente, Sum(Transacciones.Monto) AS [Total_Creditos] " & _
        " FROM Transacciones " & _
        " GROUP BY Transacciones.CodigoCliente,Transacciones.TipoTransaccion " & _
        " Having Transacciones.CodigoCliente=" & TextBox1.Text & " and Transacciones.TipoTransaccion='" & tcred & "'"

        Dim SaldoAbonos As String
        SaldoAbonos = "Insert into TotalAbonos SELECT DISTINCTROW Transacciones.CodigoCliente, Sum(Transacciones.Monto) AS [Total_Abonos]  " & _
        " FROM Transacciones " & _
        " GROUP BY Transacciones.CodigoCliente,Transacciones.TipoTransaccion " & _
        " Having Transacciones.CodigoCliente=" & TextBox1.Text & " and Transacciones.TipoTransaccion='" & tabo & "'"

        Dim cmdborraCreditos As New OleDb.OleDbCommand(borraCreditos, conectar)
        Dim cmdborraAbonos As New OleDb.OleDbCommand(borraAbonos, conectar)

        Dim cmdCreditos As New OleDb.OleDbCommand(SaldoCreditos, conectar)
        Dim cmdAbonos As New OleDb.OleDbCommand(SaldoAbonos, conectar)


        conectar.Open()
        cmdborraCreditos.ExecuteNonQuery()
        cmdborraAbonos.ExecuteNonQuery()
        cmdCreditos.ExecuteNonQuery()
        cmdAbonos.ExecuteNonQuery()
        Dim daClientes As New OleDb.OleDbDataAdapter("select * from Clientes where codigoCliente=" & TextBox1.Text & "", conectar)
        Dim daCreditos As New OleDb.OleDbDataAdapter("select * from TotalCreditos", conectar)
        Dim daAbonos As New OleDb.OleDbDataAdapter("select * from TotalAbonos", conectar)

        Dim tablaClientes As New DataTable
        Dim tablaCreditos As New DataTable
        Dim tablaAbonos As New DataTable

        daClientes.Fill(tablaClientes)
        daCreditos.Fill(tablaCreditos)
        daAbonos.Fill(tablaAbonos)

        Dim filasClientes As DataRow()
        Dim filasCreditos As DataRow()
        Dim filasAbonos As DataRow()

        filasClientes = tablaClientes.Select("CodigoCliente=" & TextBox1.Text & "")
        If filasClientes.Length > 0 Then
            For Each Clientes As DataRow In filasClientes
                TextBox2.Text = Clientes("Nombres").ToString
                TextBox3.Text = Clientes("Apellidos").ToString

            Next
        End If


        filasCreditos = tablaCreditos.Select("CodigoCliente= " & TextBox1.Text & "")
        If filasCreditos.Length > 0 Then
            For Each dr As DataRow In filasCreditos
                TextBox5.Text = dr("Total_Creditos").ToString
            Next
        End If


        filasAbonos = tablaAbonos.Select("CodigoCliente=" & TextBox1.Text & "")
        If filasAbonos.Length > 0 Then
            For Each Abonos As DataRow In filasAbonos
                TextBox6.Text = Abonos("Total_Abonos").ToString
            Next
        End If

        conectar.Close()
        txt5 = TextBox5.Text
        txt6 = TextBox6.Text
        If txt5 = "" Then txt5 = 0
        If txt6 = "" Then txt6 = 0
        If TextBox5.Text = "" Then TextBox5.Text = 0
        If TextBox6.Text = "" Then TextBox6.Text = 0
        Dim abo As Double = txt6
        Dim cred As Double = txt5

        'Dim da1 As New OleDb.OleDbDataAdapter("select * from Salxcli", conectar)
        'Dim tabla1 As New DataTable
        'da1.Fill(tabla1)
        'Dim filas1 As DataRow()
        'filas1 = tabla1.Select("CodigoCliente= " & TextBox1.Text & "")
        'If filas1.Length > 0 Then
        '    For Each dr As DataRow In filas1
        '        TextBox2.Text = dr("Nombres").ToString
        '        TextBox3.Text = dr("Apellidos").ToString
        txt4 = TextBox5.Text - TextBox6.Text
        Dim mynumber As Double = txt4
        TextBox5.Text = FormatNumber(cred, 2, , , TriState.True)
        TextBox6.Text = FormatNumber(abo, 2, , , TriState.True)
        TextBox4.Text = FormatNumber(mynumber, 2, , , TriState.True)
        '        conectar.Close()




    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub SaldoxCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = 50
        Me.Left = 50
    End Sub
End Class