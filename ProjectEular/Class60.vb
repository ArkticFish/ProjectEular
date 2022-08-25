Imports SM = ProjectEular.SharedMethods

Public Class Class60

    Public Sub Solve()

        Dim primeLimit = 1100

        ' List first 1100 primes.
        Dim primes = New List(Of Integer)

        Dim i = 1
        While primes.Count() < primeLimit

            If SM.IsPrime(i) Then
                primes.Add(i)
            End If

            i += 1

        End While

        Dim smallest = 0

        ' Loop through permutations.
        For a = 0 To primeLimit - 5

            Dim num1 = primes(a)

            For b = a + 1 To primeLimit - 4

                Dim num2 = primes(b)

                If SM.IsPrime(CInt(num1 & num2)) AndAlso
                    SM.IsPrime(CInt(num2 & num1)) Then

                    For c = b + 1 To primeLimit - 3

                        Dim num3 = primes(c)

                        If SM.IsPrime(CInt(num1 & num3)) AndAlso
                                    SM.IsPrime(CInt(num3 & num1)) AndAlso
                                    SM.IsPrime(CInt(num2 & num3)) AndAlso
                                    SM.IsPrime(CInt(num3 & num2)) Then

                            For d = c + 1 To primeLimit - 2

                                Dim num4 = primes(d)

                                If SM.IsPrime(CInt(num1 & num4)) AndAlso
                                    SM.IsPrime(CInt(num4 & num1)) AndAlso
                                    SM.IsPrime(CInt(num2 & num4)) AndAlso
                                    SM.IsPrime(CInt(num4 & num2)) AndAlso
                                    SM.IsPrime(CInt(num3 & num4)) AndAlso
                                    SM.IsPrime(CInt(num4 & num3)) Then

                                    For e = d + 1 To primeLimit - 1

                                        Dim num5 = primes(e)

                                        If SM.IsPrime(CInt(num1 & num5)) AndAlso
                                            SM.IsPrime(CInt(num5 & num1)) AndAlso
                                            SM.IsPrime(CInt(num2 & num5)) AndAlso
                                            SM.IsPrime(CInt(num5 & num2)) AndAlso
                                            SM.IsPrime(CInt(num3 & num5)) AndAlso
                                            SM.IsPrime(CInt(num5 & num3)) AndAlso
                                            SM.IsPrime(CInt(num4 & num5)) AndAlso
                                            SM.IsPrime(CInt(num5 & num4)) Then

                                            Dim sum = num1 + num2 + num3 + num4 + num5

                                            If sum < smallest Or smallest = 0 Then

                                                smallest = sum
                                                GoTo Done

                                            End If

                                        End If
                                    Next

                                End If

                            Next

                        End If

                    Next

                End If

            Next
        Next

Done:

        Console.WriteLine($"Smallest = {smallest}")

    End Sub

End Class
