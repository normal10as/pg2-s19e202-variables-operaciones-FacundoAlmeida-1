Imports System
Imports System.Math
Module Program
    Sub Main(args As String())
        Dim nro_1, nro_2, nro_3 As Decimal
        Dim mayor_de_2 As Decimal
        Console.WriteLine("Ingrese 3 numeros: ")
        nro_1 = Console.ReadLine()
        nro_2 = Console.ReadLine()
        nro_3 = Console.ReadLine()
        mayor_de_2 = Math.Max(nro_1, nro_2)
        If mayor_de_2 < nro_3 Then
            Console.WriteLine("El numero mayor es el" & nro_3)
        Else
            Console.WriteLine("El numero mayor es el: " & mayor_de_2)
        End If

    End Sub
End Module
