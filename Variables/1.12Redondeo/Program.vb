Imports System
Imports System.Math

Module Program
    Sub Main(args As String())

        Dim numero As Double
        Dim resul As Decimal
        Console.WriteLine("Ingrese un numero: ")
        numero = Console.ReadLine()
        resul = Math.Round(numero)
        Console.WriteLine("El redondeo del numero " & numero & " es de " & resul)
        Console.WriteLine("El valor por defecto del numero es: " & Floor(numero))
        Console.WriteLine("El valor por exceso del numero es: " & Ceiling(numero))

    End Sub
End Module
