Public Class Form1

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress


        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "-" Then


            e.Handled = True
            Exit Sub
        End If



        Dim pos As Integer = TextBox1.SelectionStart
        If pos < 4 Then e.Handled = True

        If e.KeyChar = "-" And pos <> 2 And pos <> 11 Then
            e.Handled = True
            Exit Sub
        End If
        If Char.IsNumber(e.KeyChar) And (pos = 2 Or pos = 11) Then
            e.Handled = True
            Exit Sub
        End If

        If TextBox1.Text.IndexOf("") > -1 Then Exit Sub



    End Sub
   

    Private Sub personafisica_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles personafisica.CheckedChanged
        hombre.Enabled = True
        mujer.Enabled = True

       

      
    End Sub

    Private Sub personajuridica_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles personajuridica.CheckedChanged
        hombre.Checked = False
        mujer.Checked = False
        hombre.Enabled = False
        mujer.Enabled = False
        TextBox1.Text = "30-"
        TextBox1.Focus()
        TextBox1.SelectionStart = TextBox1.Text.Length
    End Sub

    Private Sub hombre_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hombre.CheckedChanged
        If hombre.Checked Then
            TextBox1.Text = "20-"
            TextBox1.Focus()
            TextBox1.SelectionStart = TextBox1.Text.Length
        End If
    End Sub

    Private Sub mujer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mujer.CheckedChanged
        If mujer.Checked Then
            TextBox1.Text = "27-"
            TextBox1.Focus()
            TextBox1.SelectionStart = TextBox1.Text.Length
        End If
    End Sub
End Class
