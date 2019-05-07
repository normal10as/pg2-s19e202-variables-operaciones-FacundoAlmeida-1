Imports System
Imports System.Math
Module Program
    Sub Main(args As String())
        Dim valor_1 As Decimal
        Dim valor_2 As Double = Math.Abs(50.5)
        Dim valor_abs As Integer
        Dim valor_potencia As Decimal
        Dim valor_raiz As Integer

        Console.WriteLine("Ingresa un numero: ")
        valor_1 = Console.ReadLine()
        valor_potencia = Math.Pow(valor_1, 10)
        Console.WriteLine("El valor ingresado elevado a la decima potencia es de: " & valor_potencia)
        valor_abs = Math.Abs(valor_1)
        Console.WriteLine("El valor absoluto del numero ingresado es: " & valor_abs)
        valor_raiz = Math.Sqrt(valor_1)
        Console.WriteLine("La raiz cuadrada del valor ingresado es de: " & valor_raiz)

    End Sub
End Module
