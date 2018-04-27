Public Class Form1

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress


        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "-" Then


            e.Handled = True
            Exit Sub
        End If
        Dim pos As Integer = TextBox1.SelectionStart
        If e.KeyChar = "-" And pos <> 2 And pos <> 11 Then
            e.Handled = True
            Exit Sub
        End If
        If Char.IsNumber(e.KeyChar) And (pos = 2 Or pos = 11) Then
            e.Handled = True
            Exit Sub
        End If

    End Sub
   

End Class
