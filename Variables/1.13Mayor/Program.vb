Imports System
Imports System.Math
Module Program
    Sub Main(args As String())
        Dim nro_1, nro_2, nro_3, resultado, mayor_de_2 As Decimal

        Console.WriteLine("Ingrese 3 numeros: ")
        nro_1 = Console.ReadLine()
        nro_2 = Console.ReadLine()
        nro_3 = Console.ReadLine()
        mayor_de_2 = Math.Max(nro_1, nro_2)
        resultado = Math.Max(mayor_de_2, nro_3)
        Console.WriteLine("El mayor numero es: " & resultado)

    End Sub
End Module
