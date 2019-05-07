Imports System

Module Program
    Sub Main(args As String())
        Dim fecha As Date = #12/02/1999#
        Dim dias As Double
        Dim total As Date
        Console.WriteLine("Ingrese fecha: ")
        fecha = Console.ReadLine()
        Console.WriteLine("La fecha ingresada es: " & fecha)

        Console.WriteLine("Ingrese dias a sumar a la fecha: ")
        dias = Console.ReadLine()
        total = fecha.AddDays(dias)
        Console.WriteLine("La fecha sumada es: " & total)
    End Sub
End Module
