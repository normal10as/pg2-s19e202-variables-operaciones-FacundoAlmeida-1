Imports System

Module variables
    Sub Main()
        Console.WriteLine("Ingrese sus datos: ")
        Dim nombre, apellido As String
        Dim fecnac As Date
        Console.WriteLine("Ingrese su nombre: ")
        nombre = Console.ReadLine()
        Console.WriteLine("Ingrese su Apellido: ")
        apellido = Console.ReadLine()
        Console.WriteLine("Ingrese su fecha de nacimiento ")
        fecnac = Console.ReadLine()

        Console.WriteLine("Su apellido es " & apellido & "," & " su nombre es " & nombre & "," & " nació el " & fecnac & ".")



    End Sub
End Module