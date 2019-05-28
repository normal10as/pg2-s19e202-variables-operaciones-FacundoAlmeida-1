Module Module1

    Sub Main()
        Dim frase As String = "aunque la cadena sea de oro, sirve para lo mismo"
        Dim palabra_actual, palabra_nueva, resultado As String
        Console.WriteLine("Ingrese palabra a cambiar")
        palabra_actual = Console.ReadLine()
        Console.WriteLine("Ingrese nueva palabra")
        palabra_nueva = Console.ReadLine()
        Dim palabra_actual_1 = " " + palabra_actual + " "
        Dim palabra_nueva_1 = " " + palabra_nueva + " "
        resultado = Replace(frase, palabra_actual_1, palabra_nueva_1)
        palabra_actual_1 = " " + palabra_actual_1 + ","
        palabra_nueva_1 = " " + palabra_nueva + ","
        resultado = Replace(resultado, palabra_actual_1, palabra_nueva_1)
        palabra_actual_1 = " " + palabra_actual + "."
        palabra_nueva_1 = " " + palabra_nueva + "."
        resultado = Replace(resultado, palabra_actual_1, palabra_nueva_1)
        palabra_actual_1 = palabra_actual + " "
        palabra_nueva_1 = Replace(resultado, palabra_actual_1, palabra_nueva_1, 1, -1, CompareMethod.Text)
        Console.WriteLine("Nueva frase: " & resultado)

    End Sub

End Module
