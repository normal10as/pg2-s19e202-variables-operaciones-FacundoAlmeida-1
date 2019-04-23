Imports System

Module Concatenacion
    Sub Main()

        Dim Nombre_empresa As String 
        Dim Nombre_calle As String 
        Dim Altura_calle As Integer
        Dim Fe_inicio_actividad As Date 
        Console.WriteLine("Ingrese nombre de la empresa: ")
        Nombre_empresa= Console.Readline()
        Console.Writeline("Ingrese Nombre de la calle: ")
        Nombre_calle = Console.Readline()
        Console.WriteLine("Ingrese Altura de la calle: ")
        Altura_calle=Console.Readline()
        Console.WriteLine("Ingrese inicio de actividades: ")
        Fe_inicio_actividad= Console.Readline()
        Console.WriteLine("Nombre:" + Convert.ToString(Nombre_empresa) + " Calle:" + Convert.ToString(Nombre_calle) + " Altura Calle:" + Convert.ToString(Altura_calle) + " Fecha Inicio:" + Convert.ToString(Fe_inicio_actividad))
        Console.WriteLine("Nombre:" & Nombre_empresa & " Calle:" & Nombre_calle & " Altura de la calle:" & Altura_calle & " Fecha Inicio: " & Fe_inicio_actividad)
    End Sub

End Module
