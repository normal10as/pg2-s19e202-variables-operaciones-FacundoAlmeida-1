Imports System
Imports datetime

Module Reloj
    Sub Main(args As String())
        Dim dia As Date
        Dim mes As Date
        Dim hora As Date
        Dim minuto As Date

        dia = dia.Now 'agrega la fecha actual a la variable dia
        Console.WriteLine("dia " & dia)
        Console.WriteLine("Dia del a�o: " & dia.DayOfYear) 'de la hora actual asignaada solo imprime dia del a�o
        mes = mes.Now 'x2
        Console.WriteLine("Mes del a�o: " & mes.Month)
        hora = hora.Now
        Console.WriteLine("Hora del dia: " & hora.Hour)
        minuto = minuto.Now
        Console.WriteLine("Minuto: " & minuto.Minute)




    End Sub
End Module
