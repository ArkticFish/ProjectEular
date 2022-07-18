Imports System.Numerics

Public Class Class16

    Public Sub Solve()

        Dim number = 0

        Dim pow = BigInteger.Pow(2, 1000).ToString()

        For Each letter In pow

            number += CInt(letter.ToString())

        Next

        Console.WriteLine($"{number}")

    End Sub

End Class
