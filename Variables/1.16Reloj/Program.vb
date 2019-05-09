Imports System
Imports datetime

Module Reloj
    Sub Main(args As String())
        Dim dia As Date
        Dim mes As Date
        Dim hora As Date
        Dim minuto As Date

        dia = dia.Now
        Console.WriteLine("dia " & dia)
        Console.WriteLine("Dia del año: " & dia.DayOfYear)
        mes = mes.Now
        Console.WriteLine("Mes del año: " & mes.Month)
        hora = hora.Now
        Console.WriteLine("Hora del dia: " & hora.Hour)
        minuto = minuto.Now
        Console.WriteLine("Minuto: " & minuto.Minute)




    End Sub
End Module
