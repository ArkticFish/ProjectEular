Public Class Class49

    Public Sub Solve()

        For n1 = 1000 To 9999

            For i = 1 To 9999

                Dim n2 = n1 + i
                Dim n3 = n1 + i + i

                If SharedMethods.IsPrime(n1) AndAlso SharedMethods.IsPrime(n2) AndAlso SharedMethods.IsPrime(n3) Then

                    Dim n1Col = String.Concat(n1.ToString.OrderBy(Function(a) a))
                    Dim n2Col = String.Concat(n2.ToString.OrderBy(Function(a) a))
                    Dim n3Col = String.Concat(n3.ToString.OrderBy(Function(a) a))

                    If n1Col.Length = 4 AndAlso n1Col = n2Col AndAlso n2Col = n3Col Then

                        Console.WriteLine($"{n1} + {i} = {n2} + {i} = {n3}")
                        Console.WriteLine(n1 & n2 & n3)

                    End If

                End If

            Next


        Next

        Console.WriteLine("Done")

    End Sub

End Class
