Imports System

Module Program
    Sub Main(args As String())
        Dim Monto, Interes As Decimal
        Dim Dias As Decimal
        Dim total As UInteger


        Console.WriteLine("Ingrese Monto: ")
        Monto = Console.ReadLine()
        Console.WriteLine("Ingrese interes: ")
        Interes = Console.ReadLine()
        Console.WriteLine("Ingrese durante cuantos dias: ")
        Dias = Console.ReadLine()
        total = (Monto * Interes * Dias) / (360 * 100)
        Console.WriteLine("El interes producido es de: " & total)

    End Sub
End Module
