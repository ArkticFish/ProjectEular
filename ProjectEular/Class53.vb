Imports System.Numerics

Public Class Class53

    Public Sub Solve()

        Dim count = 0

        For n As BigInteger = 1 To 100

            For r As BigInteger = 1 To n

                If Notations(n, r) > 1000000 Then
                    count += 1
                End If

            Next

        Next

        Console.WriteLine(count)
        Console.WriteLine("Done")

    End Sub

    Private Function Notations(n As BigInteger, r As BigInteger) As BigInteger

        Return Fact(n) / (Fact(r) * Fact(n - r))

    End Function

    Private Function Fact(num As BigInteger) As BigInteger

        Dim prod As BigInteger = 1

        For index = num To 1 Step -1

            prod *= index

        Next

        Return prod

    End Function

End Class
