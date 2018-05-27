Module _3_03_Potencias
    Sub main()
        Dim nro As Integer
        Dim resultado As Long

        Console.WriteLine("ingrese un nro:")
        nro = Console.ReadLine()
        For i As Byte = 2 To 6
            resultado = potencia(nro, i)
            Console.WriteLine("{0} elevavo a la {1} es igual a {2}", nro, i, resultado)
        Next
    End Sub

    Private Function potencia(ByVal x, ByVal n) As Integer
        Return (x ^ n)
    End Function

End Module
