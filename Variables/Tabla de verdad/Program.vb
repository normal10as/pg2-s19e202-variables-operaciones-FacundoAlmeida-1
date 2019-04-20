Imports System

Module Program
    Sub Main()
        Dim v As Boolean
        Dim f As Boolean

        v = True
        f = False
        Console.WriteLine("Operadores logicos: AND ")
        Console.WriteLine("EXP1-EXP2 - EXP1 y EXP2 ")
        Console.WriteLine("V   - V   -" & (v And v))
        Console.WriteLine("V   - F   -" & (v And f))
        Console.WriteLine("F   - V   -" & (f And v))
        Console.WriteLine("F   - F   -" & (f And f) & vbCrLf)
        Console.WriteLine("Operadores logicos: NOT")
        Console.WriteLine("EXP1 -   NoExp1")
        Console.WriteLine("V    - " & (Not v))
        Console.WriteLine("F    - " & (Not f))
        Console.WriteLine("" & vbCrLf)
        Console.WriteLine("Operadores logicos: OR")
        Console.WriteLine("EXP1 - EXP2  - EXP1 o EXP2")
        Console.WriteLine("V    -   V   -" & (v Or v))
        Console.WriteLine("V    -   F   -" & (v Or f))
        Console.WriteLine("F    -   V   -" & (f Or v))
        Console.WriteLine("F    -   F   -" & (f Or f) & vbCrLf)
        Console.WriteLine("Operadores logicos:XOR")
        Console.WriteLine("EXP1 - EXP2 - EXP1 y EXP2")
        Console.WriteLine("V    - V - " & (v Xor v))
        Console.WriteLine("V    - F - " & (v Xor f))
        Console.WriteLine("F    - V - " & (f Xor v))
        Console.WriteLine("F    - F - " & (f Xor f))




    End Sub
End Module