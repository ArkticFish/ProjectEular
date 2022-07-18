Imports System.Numerics

Public Class Class2

    Public Sub Solve()

        Dim total As BigInteger

        Dim num1 = 1
        Dim num2 = 2

        While num2 < 4000000

            If num2 Mod 2 = 0 Then total += num2

            Dim num3 = num1 + num2
            num1 = num2
            num2 = num3

        End While

        Console.WriteLine(total)

    End Sub

End Class
