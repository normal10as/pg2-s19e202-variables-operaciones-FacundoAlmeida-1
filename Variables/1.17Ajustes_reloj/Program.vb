Imports System
Imports System.DateTime

Module Program
    Sub Main(args As String())
        Dim mes, año, minuto, segundo As Date
        Dim dia, hora, fecha As String
        Dim mes_actual As DateTime
        Dim anio_actual As DateTime
        Dim fecha_ing As DateTime
        Dim minuto As DateTime
        mes = mes.Now
        dia = dia.now


        Console.WriteLine("Ingrese un dia: ")
        dia = Console.ReadLine()

        Console.WriteLine("Ingrese una hora: ")
        hora = Console.ReadLine()
        fecha = New DateTime(año.Year, mes.Month, dia, hora, minuto.Minute, segundo.Second)
        Console.WriteLine("La fecha es: " & fecha)


    End Sub


End Module
