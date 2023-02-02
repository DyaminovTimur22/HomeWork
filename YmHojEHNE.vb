Imports System

Module Program
    Const UNLONGMAX As ULong = 6710886467108864
    Sub Main(args As String())
        Console.WriteLine("¬видите любое число дл€ умножени€:")
        Dim N As Long
        Dim R As Long
        R = 1
        N = 0
        While N <> 1
            N = CInt(Console.ReadLine)
            R = R * N
        End While
        Console.WriteLine("Ёто будет равно:")
        Console.WriteLine(R)
    End Sub
End Module