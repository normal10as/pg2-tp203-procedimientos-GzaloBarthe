Module _3_06_sumatoria_de_cuadrados
    Sub main()
        Dim nro As Integer
        Console.WriteLine("ingrese un nro")
        nro = Console.ReadLine()
        Validar(nro)
        sumatoriaCuadrada(nro)

    End Sub
    Sub sumatoriaCuadrada(ByRef n)
        Dim sumatra As Integer
        For i As Integer = 1 To n
            Console.WriteLine("{0} al cuadrado es {1}", i, i ^ 2)
            sumatra = sumatra + i ^ 2
        Next
        Console.WriteLine("la sumatoria de los nros es {0}", sumatra)
    End Sub

    Sub Validar(ByRef nro)
        While nro < 0
            Console.WriteLine("Error" & vbCrLf & "ingrese un valor POSITIVO")
            nro = Console.ReadLine()
        End While
    End Sub

End Module
