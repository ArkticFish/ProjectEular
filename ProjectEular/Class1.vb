Imports System.Numerics

Public Class Class1

    Public Sub Solve()

        Dim total As BigInteger

        Dim ind3 = 3
        While ind3 < 1000
            total += ind3
            ind3 += 3
        End While

        Dim ind5 = 5
        While ind5 < 1000
            total += ind5
            ind5 += 5
        End While

        Dim ind15 = 15
        While ind15 < 1000
            total -= ind15
            ind15 += 15
        End While

        Console.WriteLine(total)

    End Sub

End Class
