Imports System

Module Program
    Sub Main(args As String())
        Dim a, i As Decimal
        Dim m As Decimal
        Dim r As UInteger
        Dim t As UShort

        Console.WriteLine("Ingrese Monto: ")
        m = Console.ReadLine()
        Console.WriteLine("Ingrese interes: ")
        r = Console.ReadLine()
        Console.WriteLine("Ingrese durante cuantos dias: ")
        t = Console.ReadLine()
        a = (m * r * t) / (360 * 100)
        Console.WriteLine("El interes producido es de: " & a)
        Console.WriteLine("monto acumulado: " & m + r)
    End Sub
End Module
