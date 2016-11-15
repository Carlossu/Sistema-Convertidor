Public Class Form1

    Private Sub btnConvertirlong_Click(sender As Object, e As EventArgs) Handles btnConvertirlong.Click
        If cbxentrada.Text = "Milimetros" And cbxsalida.Text = "Milimetros" Then
            lblr.Text = Val(txtvalor.Text)
            lblum.Text = "mm"
        ElseIf cbxentrada.Text = "Milimetros" And cbxsalida.Text = "Centimetros" Then
            lblr.Text = Val(txtvalor.Text) / 10
            lblum.Text = "cm"
        ElseIf cbxentrada.Text = "Milimetros" And cbxsalida.Text = "Metros" Then
            lblr.Text = Val(txtvalor.Text) / 1000
            lblum.Text = "m"
        ElseIf cbxentrada.Text = "Milimetros" And cbxsalida.Text = "Kilometros" Then
            lblr.Text = Val(txtvalor.Text) / 1000000
            lblum.Text = "km"
        ElseIf cbxentrada.Text = "Centimetros" And cbxsalida.Text = "Milimetros" Then
            lblr.Text = Val(txtvalor.Text) * 10
            lblum.Text = "mm"
        ElseIf cbxentrada.Text = "Centimetros" And cbxsalida.Text = "Centimetros" Then
            lblr.Text = Val(txtvalor.Text)
            lblum.Text = "cm"
        ElseIf cbxentrada.Text = "Centimetros" And cbxsalida.Text = "Metros" Then
            lblr.Text = Val(txtvalor.Text) / 100
            lblum.Text = "m"
        ElseIf cbxentrada.Text = "Centimetros" And cbxsalida.Text = "Kilometros" Then
            lblr.Text = Val(txtvalor.Text) / 100000
            lblum.Text = "km"
        ElseIf cbxentrada.Text = "Metros" And cbxsalida.Text = "Milimetros" Then
            lblr.Text = Val(txtvalor.Text) * 1000
            lblum.Text = "mm"
        ElseIf cbxentrada.Text = "Metros" And cbxsalida.Text = "Centimetros" Then
            lblr.Text = Val(txtvalor.Text) * 100
            lblum.Text = "cm"
        ElseIf cbxentrada.Text = "Metros" And cbxsalida.Text = "Metros" Then
            lblr.Text = Val(txtvalor.Text)
            lblum.Text = "m"
        ElseIf cbxentrada.Text = "Metros" And cbxsalida.Text = "Kilometros" Then
            lblr.Text = Val(txtvalor.Text) / 1000
            lblum.Text = "km"
        ElseIf cbxentrada.Text = "Kilometros" And cbxsalida.Text = "Milimetros" Then
            lblr.Text = Val(txtvalor.Text) * 1000000
            lblum.Text = "mm"
        ElseIf cbxentrada.Text = "Kilometros" And cbxsalida.Text = "Centimetros" Then
            lblr.Text = Val(txtvalor.Text) * 100000
            lblum.Text = "cm"
        ElseIf cbxentrada.Text = "Kilometros" And cbxsalida.Text = "Metros" Then
            lblr.Text = Val(txtvalor.Text) * 1000
            lblum.Text = "m"
        ElseIf cbxentrada.Text = "Kilometros" And cbxsalida.Text = "Kilometros" Then
            lblr.Text = Val(txtvalor.Text)
            lblum.Text = "km"
        End If
    End Sub

    Private Sub btnConvertVolumen_Click(sender As Object, e As EventArgs) Handles btnConvertVolumen.Click
        If cbxentrada.Text = "Mililitro" And cbxsalida.Text = "Litro" Then
            lblr.Text = Val(txtvalor.Text) * 0.001
            lblum.Text = "Litros"
        ElseIf cbxentrada.Text = "Mililitro" And cbxsalida.Text = "MetroCubico" Then
            lblr.Text = Val(txtvalor.Text) * 0.000001
            lblum.Text = "Metros Cúbicos"
        ElseIf cbxentrada.Text = "Mililitro" And cbxsalida.Text = "Mililitro" Then
            lblr.Text = Val(txtvalor.Text)
            lblum.Text = "Mililitro"

        ElseIf cbxentrada.Text = "Litro" And cbxsalida.Text = "Mililitro" Then
            lblr.Text = Val(txtvalor.Text) * 1000
            lblum.Text = "Mililitros"
        ElseIf cbxentrada.Text = "Litro" And cbxsalida.Text = "MetroCubico" Then
            lblr.Text = Val(txtvalor.Text) * 0.001
            lblum.Text = "Metros Cúbicos"
        ElseIf cbxentrada.Text = "Litro" And cbxsalida.Text = "Litro" Then
            lblr.Text = Val(txtvalor.Text)
            lblum.Text = "Litros"
        ElseIf cbxentrada.Text = "MetroCubico" And cbxsalida.Text = "Mililitro" Then
            lblr.Text = Val(txtvalor.Text) * 1000000.0
            lblum.Text = "Mililitros"
        ElseIf cbxentrada.Text = "MetroCubico" And cbxsalida.Text = "Litro" Then
            lblr.Text = Val(txtvalor.Text) * 1000
            lblum.Text = "Euro"
        ElseIf cbxentrada.Text = "MetroCubico" And cbxsalida.Text = "MetroCubico" Then
            lblr.Text = Val(txtvalor.Text)
            lblum.Text = "Metros Cúbicos"

        End If
    End Sub

    Private Sub btnConvMonedas_Click(sender As Object, e As EventArgs) Handles btnConvMonedas.Click
        If cbxentrada.Text = "Dolar" And cbxsalida.Text = "Euro" Then
            lblr.Text = Val(txtvalor.Text) * 0.89
            lblum.Text = "Euros"
        ElseIf cbxentrada.Text = "Dolar" And cbxsalida.Text = "Yen" Then
            lblr.Text = Val(txtvalor.Text) * 103.1
            lblum.Text = "Yenes"
        ElseIf cbxentrada.Text = "Dolar" And cbxsalida.Text = "Soles" Then
            lblr.Text = Val(txtvalor.Text) * 3.38
            lblum.Text = "Soles"
        ElseIf cbxentrada.Text = "Dolar" And cbxsalida.Text = "Dolar" Then
            lblr.Text = Val(txtvalor.Text)
            lblum.Text = "Dolar"
        ElseIf cbxentrada.Text = "Euro" And cbxsalida.Text = "Dolar" Then
            lblr.Text = Val(txtvalor.Text) * 1.11
            lblum.Text = "Euros"
        ElseIf cbxentrada.Text = "Euro" And cbxsalida.Text = "Yen" Then
            lblr.Text = Val(txtvalor.Text) * 114.82
            lblum.Text = "Yenes"
        ElseIf cbxentrada.Text = "Euro" And cbxsalida.Text = "Soles" Then
            lblr.Text = Val(txtvalor.Text) * 3.77
            lblum.Text = "Soles"
        ElseIf cbxentrada.Text = "Euro" And cbxsalida.Text = "Euro" Then
            lblr.Text = Val(txtvalor.Text)
            lblum.Text = "Euro"
        ElseIf cbxentrada.Text = "Yen" And cbxsalida.Text = "Dolar" Then
            lblr.Text = Val(txtvalor.Text) * 0.0096
            lblum.Text = "Dolar"
        ElseIf cbxentrada.Text = "Yen" And cbxsalida.Text = "Euro" Then
            lblr.Text = Val(txtvalor.Text) * 0.0087
            lblum.Text = "Euro"
        ElseIf cbxentrada.Text = "Yen" And cbxsalida.Text = "Soles" Then
            lblr.Text = Val(txtvalor.Text) * 0.0328
            lblum.Text = "Soles"
        ElseIf cbxentrada.Text = "Yen" And cbxsalida.Text = "Yen" Then
            lblr.Text = Val(txtvalor.Text)
            lblum.Text = "Yen"
        ElseIf cbxentrada.Text = "Soles" And cbxsalida.Text = "Dolar" Then
            lblr.Text = Val(txtvalor.Text) * 0.295
            lblum.Text = "Dolar"
        ElseIf cbxentrada.Text = "Soles" And cbxsalida.Text = "Yen" Then
            lblr.Text = Val(txtvalor.Text) * 30.42
            lblum.Text = "Yenes"
        ElseIf cbxentrada.Text = "Soles" And cbxsalida.Text = "Euro" Then
            lblr.Text = Val(txtvalor.Text) * 0.264
            lblum.Text = "Euro"
        ElseIf cbxentrada.Text = "Soles" And cbxsalida.Text = "Soles" Then
            lblr.Text = Val(txtvalor.Text)
            lblum.Text = "Soles"
        End If
    End Sub
End Class
