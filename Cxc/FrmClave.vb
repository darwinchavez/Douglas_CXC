Public Class FrmClave

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "JustoJimenez" And TextBox2.Text = "032017" And modifica = "Credito" Then
            ModificaVenta.Show()
            Me.Close()
        Else
            If TextBox1.Text = "JustoJimenez" And TextBox2.Text = "032017" And modifica = "Abono" Then
                ModificaAbonos.Show()
                Me.Close()
            End If
        End If
    End Sub
End Class