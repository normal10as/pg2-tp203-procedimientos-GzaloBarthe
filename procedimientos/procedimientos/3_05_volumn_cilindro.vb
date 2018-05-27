Module _3_05_volumn_cilindro
    Sub main()


        Dim resultado As Single
        resultado = volumen()
        Console.WriteLine("el volumen es {0} cm3", resultado)
    End Sub

    Private Function volumen() As Single
        Const pi As Single = 3.14159265
        Dim r As Single
        Dim h As Single
        Console.WriteLine("ingrese el radio del cilindro en cm")
        r = Console.ReadLine()
        Validar(r)
        Console.WriteLine("ingrese la altura del cilindro en cm")
        h = Console.ReadLine()
        Validar(h)
        Return (pi * r ^ 2 * h)
    End Function

    Sub Validar(ByRef nro)
        While nro < 0
            Console.WriteLine("Error" & vbCrLf & "ingrese un valor POSITIVO")
            nro = Console.ReadLine()
        End While
    End Sub

End Module
