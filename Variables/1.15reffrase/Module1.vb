Module Module1

    Sub Main()
        Dim frase As String = "aunque la cadena sea de oro, sirve para lo mismo"
        Dim palabra_reemplazar As String
        Dim palabra_nueva As String
        Console.WriteLine("Ingrese palabra a cambiar")
        palabra_reemplazar = Console.ReadLine()
        Console.WriteLine("Ingrese nueva palabra")
        palabra_nueva = Console.ReadLine()
        Console.WriteLine(Replace(frase, palabra_reemplazar, palabra_nueva))

    End Sub

End Module
