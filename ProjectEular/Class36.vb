Public Class Class36

    Public Sub Solve()

        Dim sum = 0

        For i = 1 To 1000000

            If SharedMethods.IsPalindrome(i) Then

                Dim base2 = Convert.ToString(i, 2)

                If SharedMethods.IsPalindrome(base2) Then

                    Console.WriteLine(i)
                    sum += i

                End If

            End If

        Next

        Console.WriteLine()
        Console.WriteLine(sum)

    End Sub

End Class
