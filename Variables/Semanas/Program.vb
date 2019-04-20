Imports System

Module Program
    Sub Main()
        Const dias As Integer = 365
        Const Dias_Laborables As Integer = 177
        Const Dias_semana As Integer = 7

        Console.WriteLine("El año tiene " & dias / Dias_semana & " Semanas. Y las semanas labolares son: " & Dias_Laborables / Dias_semana)
    End Sub
End Module