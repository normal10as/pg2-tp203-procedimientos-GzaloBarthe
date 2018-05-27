Module _3_07_sobrecargada
    Enum operaciones As Byte
        suma = 1
        resta = 2
        multiplicacion = 3
        division = 4
    End Enum

    Sub main()
        calcular(operaciones.suma)
        calcular(operaciones.resta)
        calcular(operaciones.multiplicacion)
        calcular(operaciones.division)
        Console.WriteLine("leeeestooooo!!!!")

    End Sub
    Private Function calcular(ByVal op) As Single
        Dim resul As Single
        Select Case op
            Case 1
                resul = sumar(2, 3)
                resul = sumar(2, 3, 4)
                resul = sumar(2, 3, 4, 5)
            Case 2
                resul = restar(2, 3)
                resul = restar(2, 3, 4)
                resul = restar(2, 3, 4, 5)
            Case 3
                resul = multiplicar(2, 3)
                resul = multiplicar(2, 3, 4)
                resul = multiplicar(2, 3, 4, 5)
            Case 4
                resul = dividir(2, 3)
                resul = dividir(2, 3, 4)
                resul = dividir(2, 3, 4, 5)
        End Select
    End Function
    Private Function sumar(ByVal a, ByVal b) As Integer
        Return (a + b)
    End Function
    Private Function sumar(ByVal a, ByVal b, ByVal c) As Integer
        Return (sumar(a, b) + c)
    End Function
    Private Function sumar(ByVal a, ByVal b, ByVal c, ByVal d) As Integer
        Return (sumar(a, b) + sumar(c, d))
    End Function

    Private Function restar(ByVal a, ByVal b) As Integer
        Return (a - b)
    End Function
    Private Function restar(ByVal a, ByVal b, ByVal c) As Integer
        Return (restar(a, b) - c)
    End Function
    Private Function restar(ByVal a, ByVal b, ByVal c, ByVal d) As Integer
        Return (restar(a, b) - restar(c, d))
    End Function
    Private Function multiplicar(ByVal a, ByVal b) As Integer
        Return (a * b)
    End Function
    Private Function multiplicar(ByVal a, ByVal b, ByVal c) As Integer
        Return (multiplicar(a, b) * c)
    End Function
    Private Function multiplicar(ByVal a, ByVal b, ByVal c, ByVal d) As Integer
        Return (multiplicar(a, b) * multiplicar(c, d))
    End Function

    Private Function dividir(ByVal a, ByVal b) As Single
        Return (a / b)
    End Function
    Private Function dividir(ByVal a, ByVal b, ByVal c) As Single
        Return (dividir(a, b) / c)
    End Function
    Private Function dividir(ByVal a, ByVal b, ByVal c, ByVal d) As Single
        Return (dividir(a, b) / dividir(c, d))
    End Function

End Module
