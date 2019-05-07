Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
        Dim dias_x_semanas As String
        Dim horas_x_dia As String

        Dim semana As String = 0
        Console.WriteLine("Ingrese dia: ")
        dias_x_semanas = Console.ReadLine()
        If dias_x_semanas > 1 And dias_x_semanas < 8 Then
            semana = 1


        ElseIf dias_x_semanas > 7 And dias_x_semanas < 16 Then
            semana = 2

        ElseIf dias_x_semanas > 15 And dias_x_semanas < 22 Then
            semana = 3

        ElseIf dias_x_semanas > 21 And dias_x_semanas < 31 Then
            semana = 4

        End If
        Console.WriteLine("El dia corresponde a la semana nro: " & semana)



        'ingresar hora y ahi decir a que dia corresponde
        Console.WriteLine("Ingrese hora del dia: ")
        horas_x_dia = Console.ReadLine()
        If horas_x_dia Then
            'terminar dsps

        End If

    End Sub
End Module
