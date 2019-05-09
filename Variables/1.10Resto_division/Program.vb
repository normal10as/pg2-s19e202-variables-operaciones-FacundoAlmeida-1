Imports System

Module Program
    Sub Main(args As String())

        Dim a As Integer
        Console.WriteLine("Ingrese un valor entero para mostrar el resultado dividido por 2: ")
        a = Console.ReadLine()
        Console.WriteLine("El resultado es: " & a Mod 2)

    End Sub
End Module
