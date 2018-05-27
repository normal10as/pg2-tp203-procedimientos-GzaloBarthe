Module _3_04_triangulo
    Sub main()
        Dim cat_A As Integer
        Dim cat_B As Integer
        Dim hipotenusa As Single
        Console.WriteLine("ingrese el lado A")
        cat_A = Console.ReadLine()
        Validar(cat_A)
        Console.WriteLine("ingrese el lado B")
        cat_B = Console.ReadLine()
        Validar(cat_B)
        hipotenusa = (cat_A ^ 2 + cat_B ^ 2) ^ (1 / 2)
        Console.WriteLine("la hipotenusa es {0}", hipotenusa)
    End Sub
    Sub Validar(ByRef nro)
        While nro < 0
            Console.WriteLine("Error" & vbCrLf & "ingrese un valor POSITIVO")
            nro = Console.ReadLine()
        End While
    End Sub

End Module
