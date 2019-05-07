Imports System

Module Program
    Sub Main()
        Dim A As Integer
        Dim B As Integer
        Dim C As Integer
        Dim D As Integer
        Dim suma As Integer
        Dim media As Integer

        Console.WriteLine("Ingrese valor 1")
        A = Console.ReadLine()
        Console.WriteLine("Ingrese valor 2")
        B = Console.ReadLine()
        Console.WriteLine("Ingrese valor 3")
        C = Console.ReadLine()
        Console.WriteLine("Ingrese valor 4")
        D = Console.ReadLine()
        suma = A + B + C + D
        media = suma / 4

        Console.WriteLine("La sumatoria de todos los numeros es de: " & suma & " Y la media es de: " & media)




    End Sub
End Module