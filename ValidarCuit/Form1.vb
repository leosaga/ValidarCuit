Public Class Form1

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress


        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "-" Then


            e.Handled = True
            Exit Sub
        End If


        Dim pos As Integer = TextBox1.SelectionStart
        If pos < 3 Then e.Handled = True


        If e.KeyChar = "-" And pos <> 2 And pos <> 11 Then
            e.Handled = True
            Exit Sub
        End If
        If Char.IsNumber(e.KeyChar) And (pos = 2 Or pos = 11) Then
            e.Handled = True
            Exit Sub
        End If

        If TextBox1.Text.IndexOf("") > -1 Then Exit Sub

        TextBox1.Focus()

    End Sub
   

    Private Sub personafisica_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fisica.CheckedChanged
        hombre.Enabled = True
        mujer.Enabled = True




    End Sub

    Private Sub personajuridica_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles juridica.CheckedChanged
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

        End If
        TextBox1.Focus()
        TextBox1.SelectionStart = TextBox1.Text.Length

    End Sub

    Private Sub mujer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mujer.CheckedChanged
        If mujer.Checked Then
            TextBox1.Text = "27-"

        End If
        TextBox1.Focus()
        TextBox1.SelectionStart = TextBox1.Text.Length
    End Sub

    
    Private Sub aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles aceptar.Click
        If TextBox1.Text.Length = 13 Then Exit Sub


        Dim Ponderador As Integer
        Dim Acumulado As Integer
        Dim Digito As Integer
        Dim Posicion As Integer
        Dim cuit As String = TextBox1.Text.Substring(0, 2) + TextBox1.Text.Substring(3)
        Ponderador = 2
        Acumulado = 0

        'Recorro la cadena de atrás para adelante
        For Posicion = 10 To 1 Step -1
            'Sumo las multiplicaciones de cada dígito x su ponderador
            Acumulado = Acumulado + CInt(cuit.Substring(Posicion - 1, 1)) * Ponderador
            Ponderador = Ponderador + 1

            If Ponderador > 7 Then Ponderador = 2
        Next

        Digito = 11 - (Acumulado Mod 11)
        If Digito = 11 Then Digito = 0

        If Digito = 10 Then
            If fisica.Checked Then
                TextBox1.Text = "23" + TextBox1.Text.Substring(2)
            Else
                TextBox1.Text = "33" + TextBox1.Text.Substring(2)
            End If
            Call aceptar_Click(sender, e)
            Exit Sub
        End If

        TextBox1.Text = TextBox1.Text + "-" + CStr(Digito)
        'Dim x, s(9), m, c(9), d, i, acu As Integer
        ''serie del texbox

        's = {2,3,4,5,6,7,2,3,4,5}
        'For x = 0 To 10
        '    'salta la pocicion 2 q es el guion
        '    If x <> 2 Then
        '        d = CInt(TextBox1.Text.Substring(x, 1))
        '        c(i) = d
        '        i += 1

        '    End If

        'Next
        'For x = 0 To 9
        '    acu = acu + c(x) * s(x)
        'Next
        'm = 11- Mod (acu,11)
        'If m = 11 Then
        '    m = 0
        'End If
        'TextBox1.Text(+"-" + CStr(m))
    End Sub
End Class
