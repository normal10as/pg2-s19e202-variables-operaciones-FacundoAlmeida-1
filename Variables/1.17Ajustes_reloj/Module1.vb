Imports System
Imports System.DateTime

Module Module1
    Sub Main()
        Dim dia, hora As String
        Dim fecha As Date




        Console.WriteLine("Ingrese un dia: ")
        dia = Console.ReadLine()
        Console.WriteLine("Ingrese una hora: ")
        hora = Console.ReadLine()
        fecha = New DateTime(Now.Year, Now.Month, dia, hora, Now.Minute, Now.Second)
        Console.WriteLine("La fecha es: " & fecha)


    End Sub


End Module