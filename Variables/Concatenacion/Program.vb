Imports System

Module Concatenacion
    Sub Main()

        Dim Nombre_empresa As String = "Empresa1"
        Dim Nombre_calle As String = "Lavalle"
        Dim Altura_calle As Integer = "1050"
        Dim Fe_inicio_actividad As Date = "18/08/1990"
        Console.WriteLine("Nombre:" + Convert.ToString(Nombre_empresa) + " Calle:" + Convert.ToString(Nombre_calle) + " Altura Calle:" + Convert.ToString(Altura_calle) + " Fecha Inicio:" + Convert.ToString(Fe_inicio_actividad))
        Console.WriteLine("Nombre:" & Nombre_empresa & " Calle:" & Nombre_calle & " Altura de la calle:" & Altura_calle & " Fecha Inicio: " & Fe_inicio_actividad)
    End Sub

End Module