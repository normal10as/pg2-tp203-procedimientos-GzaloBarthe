Module _3_02_suma_dias
    Sub main()
        Dim fecha As Date
        Dim dias As Integer
        Console.WriteLine("ingrese una fecha")
        fecha = Console.ReadLine()
        Console.WriteLine("ingrese una cantidad de dias a sumar")
        dias = Console.ReadLine()
        fecha = Sumar(fecha, dias)
        Console.WriteLine("nueva fecha: " & fecha)
    End Sub
    Private Function Sumar(fe As Date, d As Integer) As Date

        Return (fe.AddDays(d))
    End Function

End Module
