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
        Me.txtvalor = New System.Windows.Forms.TextBox()
        Me.cbxentrada = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblum = New System.Windows.Forms.Label()
        Me.lblr = New System.Windows.Forms.Label()
        Me.cbxsalida = New System.Windows.Forms.ComboBox()
        Me.btnConvertirlong = New System.Windows.Forms.Button()
        Me.btnConvertVolumen = New System.Windows.Forms.Button()
        Me.btnConvMonedas = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtvalor
        '
        Me.txtvalor.Location = New System.Drawing.Point(162, 39)
        Me.txtvalor.Name = "txtvalor"
        Me.txtvalor.Size = New System.Drawing.Size(121, 20)
        Me.txtvalor.TabIndex = 0
        '
        'cbxentrada
        '
        Me.cbxentrada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxentrada.FormattingEnabled = True
        Me.cbxentrada.Items.AddRange(New Object() {"Milimetros", "Centimetros", "Metros", "Kilometros", "Mililitro", "Litro", "MetroCubico", "Dolar", "Euro", "Yen", "Soles"})
        Me.cbxentrada.Location = New System.Drawing.Point(162, 88)
        Me.cbxentrada.Name = "cbxentrada"
        Me.cbxentrada.Size = New System.Drawing.Size(121, 21)
        Me.cbxentrada.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(12, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Ingrese cantidad:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Location = New System.Drawing.Point(108, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "De:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label3.Location = New System.Drawing.Point(118, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "A:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblum)
        Me.GroupBox1.Controls.Add(Me.lblr)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GroupBox1.Location = New System.Drawing.Point(38, 272)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(132, 71)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Resultado"
        '
        'lblum
        '
        Me.lblum.AutoSize = True
        Me.lblum.Location = New System.Drawing.Point(69, 33)
        Me.lblum.Name = "lblum"
        Me.lblum.Size = New System.Drawing.Size(55, 16)
        Me.lblum.TabIndex = 1
        Me.lblum.Text = "Label4"
        '
        'lblr
        '
        Me.lblr.AutoSize = True
        Me.lblr.Location = New System.Drawing.Point(7, 31)
        Me.lblr.Name = "lblr"
        Me.lblr.Size = New System.Drawing.Size(55, 16)
        Me.lblr.TabIndex = 0
        Me.lblr.Text = "Label4"
        '
        'cbxsalida
        '
        Me.cbxsalida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxsalida.FormattingEnabled = True
        Me.cbxsalida.Items.AddRange(New Object() {"Milimetros", "Centimetros", "Metros", "Kilometros", "Mililitro", "Litro", "MetroCubico", "Dolar", "Euro", "Yen", "Soles"})
        Me.cbxsalida.Location = New System.Drawing.Point(162, 133)
        Me.cbxsalida.Name = "cbxsalida"
        Me.cbxsalida.Size = New System.Drawing.Size(121, 21)
        Me.cbxsalida.TabIndex = 6
        '
        'btnConvertirlong
        '
        Me.btnConvertirlong.Location = New System.Drawing.Point(38, 197)
        Me.btnConvertirlong.Name = "btnConvertirlong"
        Me.btnConvertirlong.Size = New System.Drawing.Size(75, 60)
        Me.btnConvertirlong.TabIndex = 7
        Me.btnConvertirlong.Text = "Convertir Longitud"
        Me.btnConvertirlong.UseVisualStyleBackColor = True
        '
        'btnConvertVolumen
        '
        Me.btnConvertVolumen.Location = New System.Drawing.Point(136, 197)
        Me.btnConvertVolumen.Name = "btnConvertVolumen"
        Me.btnConvertVolumen.Size = New System.Drawing.Size(75, 60)
        Me.btnConvertVolumen.TabIndex = 8
        Me.btnConvertVolumen.Text = "Convertir Volumen"
        Me.btnConvertVolumen.UseVisualStyleBackColor = True
        '
        'btnConvMonedas
        '
        Me.btnConvMonedas.Location = New System.Drawing.Point(229, 197)
        Me.btnConvMonedas.Name = "btnConvMonedas"
        Me.btnConvMonedas.Size = New System.Drawing.Size(75, 60)
        Me.btnConvMonedas.TabIndex = 9
        Me.btnConvMonedas.Text = "Convertir Moneda"
        Me.btnConvMonedas.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(364, 368)
        Me.Controls.Add(Me.btnConvMonedas)
        Me.Controls.Add(Me.btnConvertVolumen)
        Me.Controls.Add(Me.btnConvertirlong)
        Me.Controls.Add(Me.cbxsalida)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbxentrada)
        Me.Controls.Add(Me.txtvalor)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtvalor As System.Windows.Forms.TextBox
    Friend WithEvents cbxentrada As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblum As System.Windows.Forms.Label
    Friend WithEvents lblr As System.Windows.Forms.Label
    Friend WithEvents cbxsalida As System.Windows.Forms.ComboBox
    Friend WithEvents btnConvertirlong As System.Windows.Forms.Button
    Friend WithEvents btnConvertVolumen As System.Windows.Forms.Button
    Friend WithEvents btnConvMonedas As System.Windows.Forms.Button

End Class
