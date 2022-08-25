Imports System.Numerics

Public Class Class55

    Public Sub Solve()

        Dim count = 0

        For n As BigInteger = 1 To 9999

            Dim number = n

            For i = 1 To 50

                Dim reverse = BigInteger.Parse(String.Concat(number.ToString().Reverse()))

                number = number + reverse

                If SharedMethods.IsPalindrome(number.ToString()) Then

                    GoTo NextNumber

                End If

            Next

            count += 1
NextNumber:

        Next

        Console.WriteLine(count)
        Console.WriteLine("Done")

    End Sub

End Class
