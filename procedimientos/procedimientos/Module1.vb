Module Module1

    Sub Main()
        Dim fe As Date = Now
        fecha(fe)
        hora(fe)
    End Sub
    Private Sub fecha(hoy)

        Console.WriteLine("{0}/{1}/{2}", hoy.Day, hoy.Month, hoy.Year)
    End Sub
    Private Function hora(hoy)
        Console.WriteLine("hora: {0}:{1}", hoy.Hour, hoy.Minute)
        Return (0)
    End Function
End Module
