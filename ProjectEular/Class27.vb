Public Class Class27

    Public Sub Solve()

        Dim maxPrime = 0

        Dim maxA = 0
        Dim maxB = 0

        For a = -1000 To 1000

            For b = -1000 To 1000

                Dim primeCount = 0

                For n = 0 To 100

                    Dim ans = (n * n) + (a * n) + b

                    If SharedMethods.IsPrime(ans) Then
                        primeCount += 1
                    Else
                        Exit For
                    End If

                Next

                If primeCount > maxPrime Then

                    maxPrime = primeCount
                    maxA = a
                    maxB = b

                End If

            Next

        Next

        Console.WriteLine($"Max Count:{maxPrime}")
        Console.WriteLine($"a:{maxA} x b:{maxB} = {maxA * maxB}")

        Console.WriteLine()

    End Sub

End Class
