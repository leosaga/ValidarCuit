<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.aceptar = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.hombre = New System.Windows.Forms.RadioButton
        Me.mujer = New System.Windows.Forms.RadioButton
        Me.fisica = New System.Windows.Forms.RadioButton
        Me.juridica = New System.Windows.Forms.RadioButton
        Me.cuil = New System.Windows.Forms.Label
        Me.persona = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.persona.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'aceptar
        '
        Me.aceptar.Location = New System.Drawing.Point(264, 229)
        Me.aceptar.Name = "aceptar"
        Me.aceptar.Size = New System.Drawing.Size(75, 23)
        Me.aceptar.TabIndex = 0
        Me.aceptar.Text = "aceptar"
        Me.aceptar.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(82, 227)
        Me.TextBox1.MaxLength = 13
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
        '
        'hombre
        '
        Me.hombre.AutoSize = True
        Me.hombre.Enabled = False
        Me.hombre.Location = New System.Drawing.Point(6, 19)
        Me.hombre.Name = "hombre"
        Me.hombre.Size = New System.Drawing.Size(60, 17)
        Me.hombre.TabIndex = 2
        Me.hombre.TabStop = True
        Me.hombre.Text = "hombre"
        Me.hombre.UseVisualStyleBackColor = True
        '
        'mujer
        '
        Me.mujer.AutoSize = True
        Me.mujer.Enabled = False
        Me.mujer.Location = New System.Drawing.Point(6, 47)
        Me.mujer.Name = "mujer"
        Me.mujer.Size = New System.Drawing.Size(50, 17)
        Me.mujer.TabIndex = 3
        Me.mujer.TabStop = True
        Me.mujer.Text = "mujer"
        Me.mujer.UseVisualStyleBackColor = True
        '
        'fisica
        '
        Me.fisica.AutoSize = True
        Me.fisica.Location = New System.Drawing.Point(0, 15)
        Me.fisica.Name = "fisica"
        Me.fisica.Size = New System.Drawing.Size(90, 17)
        Me.fisica.TabIndex = 4
        Me.fisica.TabStop = True
        Me.fisica.Text = "persona fisica"
        Me.fisica.UseVisualStyleBackColor = True
        '
        'juridica
        '
        Me.juridica.AutoSize = True
        Me.juridica.Location = New System.Drawing.Point(0, 47)
        Me.juridica.Name = "juridica"
        Me.juridica.Size = New System.Drawing.Size(99, 17)
        Me.juridica.TabIndex = 5
        Me.juridica.TabStop = True
        Me.juridica.Text = "persona juridica"
        Me.juridica.UseVisualStyleBackColor = True
        '
        'cuil
        '
        Me.cuil.AutoSize = True
        Me.cuil.Location = New System.Drawing.Point(12, 234)
        Me.cuil.Name = "cuil"
        Me.cuil.Size = New System.Drawing.Size(51, 13)
        Me.cuil.TabIndex = 6
        Me.cuil.Text = "cuit / cuil"
        '
        'persona
        '
        Me.persona.Controls.Add(Me.fisica)
        Me.persona.Controls.Add(Me.juridica)
        Me.persona.Location = New System.Drawing.Point(26, 44)
        Me.persona.Name = "persona"
        Me.persona.Size = New System.Drawing.Size(109, 69)
        Me.persona.TabIndex = 7
        Me.persona.TabStop = False
        Me.persona.Text = "personas"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.hombre)
        Me.GroupBox2.Controls.Add(Me.mujer)
        Me.GroupBox2.Location = New System.Drawing.Point(206, 44)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(98, 69)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "genero"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 312)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.persona)
        Me.Controls.Add(Me.cuil)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.aceptar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.persona.ResumeLayout(False)
        Me.persona.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents aceptar As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents hombre As System.Windows.Forms.RadioButton
    Friend WithEvents mujer As System.Windows.Forms.RadioButton
    Friend WithEvents fisica As System.Windows.Forms.RadioButton
    Friend WithEvents juridica As System.Windows.Forms.RadioButton
    Friend WithEvents cuil As System.Windows.Forms.Label
    Friend WithEvents persona As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox

End Class
