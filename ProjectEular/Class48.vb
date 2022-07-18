Imports System.Numerics

Public Class Class48

    Public Sub Solve()

        Dim sum As BigInteger = 0

        For n = 1 To 1000

            sum += BigInteger.Pow(n, n)

        Next

        Console.WriteLine(sum)

    End Sub

End Class
