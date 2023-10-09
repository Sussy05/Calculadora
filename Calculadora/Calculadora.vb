Public Class Form1
    'Utilizamos la variables fuera de cualquier metodo y así trabajar con ellas en la mayoría de partes
    Dim numero1 As Double
    Dim numero2 As Double
    Dim operacion As String
    Dim resultado As String

    Private Sub btnminimizar_Click(sender As Object, e As EventArgs) Handles btnminimizar.Click
        'Minimizamos el formulario
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Cancelamos el formulario
        Me.Close()
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        'Hacemos un llamo al número en el textbox y se trabaja con un & lo que signica que siempre va a concatenar
        txtpantalla.Text &= 0
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        txtpantalla.Text &= 1
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        txtpantalla.Text &= 2
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        txtpantalla.Text &= 3
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        txtpantalla.Text &= 4
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        txtpantalla.Text &= 5
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        txtpantalla.Text &= 6
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        txtpantalla.Text &= 7
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        txtpantalla.Text &= 8
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        txtpantalla.Text &= 9
    End Sub

    Private Sub RealizarOperacion(operador As String)
        'Se realiza la operción solicitada por medio del operador y se hace un llamado al metdo selec case
        Select Case operador
            Case "+"
                resultado = (numero1 + numero2).ToString
            Case "-"
                resultado = (numero1 - numero2).ToString
            Case "*"
                resultado = (numero1 * numero2).ToString
            Case "/"
                'Hacemos una condición por si la división es en 0
                If (numero2 = 0) Then
                    AvisosError1.ShowDialog()
                    Return
                End If
                resultado = (numero1 / numero2).ToString
            Case "^"
                resultado = (numero1 ^ numero2).ToString
        End Select
    End Sub

    Private Sub btncalcular_Click(sender As Object, e As EventArgs) Handles btncalcular.Click
        'Se crea una varible
        Dim cadena = txtpantalla.Text.Trim()
        Dim ElementosEnCadena() As String = cadena.Split(operacion)
        'Se crea una condiconal por si el segundo número no es completado
        If (ElementosEnCadena.Length > 1 And ElementosEnCadena(1) <> "") Then
            Dim valordespuesdelmasn As String = ElementosEnCadena(1).Trim()
            numero2 = valordespuesdelmasn
            RealizarOperacion(operacion)
            MsgBox("El resultado de la operación: " + txtpantalla.Text + " es de: " + CStr(resultado))
        Else
            'Llamamos al segundo formulario para mostrar mensaje en pantalla
            AvisoError.ShowDialog()
        End If
    End Sub

    Private Sub btnsumar_Click(sender As Object, e As EventArgs) Handles btnsumar.Click
        'Se hace un llamado a la variable, se iguala a la texbox y se hace lo mismo en el resto de las operaciones.
        numero1 = txtpantalla.Text
        txtpantalla.Text &= " + "
        operacion = "+"
    End Sub

    Private Sub btnrestar_Click(sender As Object, e As EventArgs) Handles btnrestar.Click
        numero1 = txtpantalla.Text
        txtpantalla.Text &= " - "
        operacion = "-"
    End Sub

    Private Sub btnmulti_Click(sender As Object, e As EventArgs) Handles btnmulti.Click
        numero1 = txtpantalla.Text
        txtpantalla.Text &= " * "
        operacion = "*"
    End Sub

    Private Sub Buttobtndivision_Click(sender As Object, e As EventArgs) Handles Buttobtndivision.Click
        numero1 = txtpantalla.Text
        txtpantalla.Text &= " / "
        operacion = "/"
    End Sub

    Private Sub btnelevado_Click(sender As Object, e As EventArgs) Handles btnelevado.Click
        numero1 = txtpantalla.Text
        txtpantalla.Text &= " ^ "
        operacion = "^"
    End Sub

    Private Sub btnpunto_Click(sender As Object, e As EventArgs) Handles btnpunto.Click
        'Hacemos un llamado al texbox en el punto
        txtpantalla.Text &= ","
    End Sub

    Private Sub btneliminar1_Click(sender As Object, e As EventArgs) Handles btneliminar1.Click
        'Declaramos variable, igualamos al textbox y usamos el metodo SubString para eliminar digito por digito
        Dim cadena As String = txtpantalla.Text
        txtpantalla.Text = cadena.Substring(0, txtpantalla.Text.Length - 1)
    End Sub

    Private Sub btnborrar_Click(sender As Object, e As EventArgs) Handles btnborrar.Click
        'Limpiamos todo el campo de texto
        txtpantalla.Clear()
    End Sub
End Class
