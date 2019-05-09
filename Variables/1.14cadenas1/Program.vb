Imports System



Module Program
    Sub Main(args As String())
        Dim cadena, let_o, let_a As String
        Console.WriteLine("Ingrese una palabra: ")
        cadena = Console.ReadLine()
        let_a = cadena.IndexOf("a", 0) + 1
        let_o = cadena.IndexOf("o", 0) + 1
        Console.WriteLine("la letra A empieza en la ubicacion " & let_a & " y la letra o en la posicion: " & let_o)




    End Sub
End Module
