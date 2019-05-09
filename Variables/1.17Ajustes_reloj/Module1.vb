Imports System
Imports System.DateTime

Module Module1
    Sub Main()
        Dim mes, año, segundo As Date
        Dim diaa, hora, fecha As String
        Dim minutoo As DateTime
        mes = mes.Now



        Console.WriteLine("Ingrese un dia: ")
        diaa = Console.ReadLine()
        mes = mes.Now
        año = año.Now
        segundo = segundo.Now
        minutoo = minutoo.Now
        segundo = segundo.Now

        Console.WriteLine("Ingrese una hora: ")
        hora = Console.ReadLine()
        fecha = New DateTime(año.Year, mes.Month, diaa, hora, minutoo.Minute, segundo.Second)
        Console.WriteLine("La fecha es: " & fecha)


    End Sub


End Module