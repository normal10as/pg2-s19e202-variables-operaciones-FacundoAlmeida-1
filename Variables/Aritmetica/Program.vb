Imports System

Module aritmética
    Sub Main()
        Dim valor1 As Integer = 10
        Dim valor2 As Integer = 12
        Dim valor3 As Decimal = 8.23
        Dim valor4 As Decimal = 1.23
        Dim result1 As Integer
        result1 = valor1 + valor2

        Console.WriteLine("Suma de entero con entero: " & valor1 + valor2)
        Console.WriteLine("suma de entero con punto flotante " & valor1 + valor3)
        Console.WriteLine("multiplicacion de entero con punto flotante: " & valor2 * valor4)
        Console.WriteLine("Divion de entero con entero ")
        Console.WriteLine("Division de entero con entero: " & valor2 / valor1)
        Console.WriteLine("Divison de entero con punto flotante: " & valor1 / valor4)



    End Sub
End Module