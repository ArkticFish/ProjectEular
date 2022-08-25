Imports System.Numerics

Public Class Class56

    Public Sub Solve()

        Dim max As Long = 0

        For a = 1 To 99

            For b = 1 To 99

                Dim sum As Long = 0
                Dim number = BigInteger.Pow(a, b).ToString()

                For Each num In number

                    sum += CInt(num.ToString())

                Next

                If sum > max Then
                    max = sum
                End If

            Next

        Next

        Console.WriteLine(max)
        Console.WriteLine("Done")

    End Sub

End Class
