Public Class Class50

    Public Sub Solve()

        Dim max = 1000000

        Dim allPrimes As New List(Of Integer)

        For i = 1 To max

            If SharedMethods.IsPrime(i) Then

                allPrimes.Add(i)

            End If

        Next

        Dim longest = 0
        Dim largest = 0
        Dim largestPrimes As New List(Of Integer)

        For s = 0 To allPrimes.Count - 1

            Dim count = 0
            Dim sum = 0
            Dim primes As New List(Of Integer)

            For e = s To allPrimes.Count - 1

                If SharedMethods.IsPrime(sum) AndAlso count > longest Then
                    longest = count
                    largest = sum
                    largestPrimes = primes
                End If

                If sum + allPrimes(e) < max Then
                    sum += allPrimes(e)
                    count += 1
                    primes.Add(allPrimes(e))
                Else
                    Exit For
                End If

            Next

        Next

        Console.WriteLine(String.Join(" + ", largestPrimes) + " = ")

        Console.WriteLine(longest)
        Console.WriteLine(largest)
        Console.WriteLine("Done")

    End Sub

End Class
