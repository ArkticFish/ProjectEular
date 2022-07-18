Imports System.Numerics

Public Class Class20

    Public Sub Solve()

        Dim total As BigInteger = 1

        For index = 1 To 100
            total *= index
        Next

        Console.WriteLine($"{total.ToString().Select(Function(val) CInt(val.ToString())).Sum()}")

    End Sub

End Class
