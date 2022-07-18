Imports System.Numerics

Public Class Class25

    Public Sub Solve()

        Dim t1 As BigInteger = 1
        Dim t2 As BigInteger = 1

        Dim index = 2

        While BigInteger.Log10(t2) < 999

            Dim t3 = t1 + t2

            t1 = t2
            t2 = t3

            index += 1

        End While

        Console.WriteLine(index)

    End Sub

End Class
