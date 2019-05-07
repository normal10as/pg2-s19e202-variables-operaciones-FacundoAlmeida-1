Imports System

Module variables_tipos
    Sub Main()
        Dim Nombre_de_persona, Lugar_de_nacimiento, Nombre_de_calle, Argentino As String
        Dim Número_de_documento, Altura_calle, Cantidad_habitantes, Monto_de_un_articulo As Integer
        Dim fecha_de_nacimiento As Date
        Dim Altura_corporal, temperatura_ambiente, km_entre_ciudad, Profundidad_del_mar, Peso_de_producto As Decimal

        Nombre_de_persona = "Juan"
        fecha_de_nacimiento = "18/08/1999"
        Número_de_documento = "42085679"
        Lugar_de_nacimiento = "Posadas,Misiones"
        Altura_corporal = "1,96"
        Argentino = "Si"
        temperatura_ambiente = "25.5"
        Nombre_de_calle = "Av. Lavalle"
        Altura_calle = "1020"
        km_entre_ciudad = "35"
        Profundidad_del_mar = "1000"
        Cantidad_habitantes = "40000000"
        Peso_de_producto = "1.95"
        Monto_de_un_articulo = "3.94"

        Console.WriteLine("Nombre de una persona: " & Nombre_de_persona)
        Console.WriteLine("Lugar de nacimiento: " & fecha_de_nacimiento)
        Console.WriteLine("Número de documento: " & Número_de_documento)
        Console.WriteLine("Lugar de Nacimiento:" & Lugar_de_nacimiento)
        Console.WriteLine("Altura corporal: " & Altura_corporal)
        Console.WriteLine("Es Argentino? " & Argentino)
        Console.WriteLine("Temperatura Ambiente: " & temperatura_ambiente)
        Console.WriteLine("Nombre de la calle: " & Nombre_de_calle)
        Console.WriteLine("Distancia en KMs entre garupa y posadas: " & km_entre_ciudad)
        Console.WriteLine("Altura de calle: " & Altura_calle)
        Console.WriteLine("Profundidad del mar en metros: " & Profundidad_del_mar & " Metros")
        Console.WriteLine("Cantidad de habitantes del territorio nacional: " & Cantidad_habitantes)
        Console.WriteLine("Peso de un producto de un supermercado " & Peso_de_producto & " Kilogramos")
        Console.WriteLine("Monto de un articulo: " & "$" & Monto_de_un_articulo)

    End Sub
End Module
