Public Class Class51

    Public Sub Solve()

        Dim minNumber As Long = 999999999

        For number = 0 To 99999999

            Dim str = number.ToString()

            If str.Contains("9") Then

                Console.Write(str + vbCr)

                Dim primes As New List(Of Long)

                For rep = 0 To 9

                    Dim newNum = Convert.ToInt64(str.Replace("9", rep))

                    If SharedMethods.IsPrime(newNum) Then

                        primes.Add(newNum)

                    End If

                Next

                If primes.Count() = 8 Then

                    Dim minPrime = primes.Min()
                    If minPrime < minNumber Then
                        minNumber = minPrime
                        Exit For
                    End If

                End If

            End If

        Next

        Console.WriteLine(minNumber)
        Console.WriteLine("Done")

    End Sub

End Class
