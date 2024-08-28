Imports System.Numerics

Public Class Class64

    Private OddCount As Integer = 0

    Public Sub Solve()


        For index = 2 To 10000

            GetFractions(index)

        Next

        Console.WriteLine()
        Console.WriteLine($"OddCount: {OddCount}")

    End Sub

    Private Sub GetFractions(n As Integer)

        Dim M As Double = 0
        Dim D As Double = 1
        Dim A As Double = Math.Floor(Math.Sqrt(n))
        Dim A0 = A

        Dim repeatWatch As New List(Of String)

        Console.Write($"{n} : {A0};")

        Dim repeatCount = 0

        While True

            M = D * A - M
            D = (n - Math.Pow(M, 2)) / D
            A = Math.Floor((A0 + M) / D)

            If repeatWatch.Contains($"{M},{D},{A}") Then
                Console.WriteLine()
                Console.WriteLine($"Repeat : {repeatCount}")
                Exit While
            End If

            Console.Write($"{A},")

            repeatCount += 1
            repeatWatch.Add($"{M},{D},{A}")

        End While

        If repeatCount Mod 2 = 1 Then
            OddCount += 1
        End If

    End Sub

End Class
