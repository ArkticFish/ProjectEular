Public Class Class23

    Public Sub Solve()

        Dim allNumbers As New List(Of Long)

        For a = 1 To 28123

            If IsAbundant(a) Then

                For b = 1 To 28123 - a

                    If IsAbundant(b) Then

                        allNumbers.Add(a + b)

                    End If

                Next

            End If

        Next

        Dim sumOfAll = 0

        For index = 1 To 28123

            If allNumbers.Contains(index) = False Then
                sumOfAll += index
            End If

        Next


        Console.WriteLine(sumOfAll)

    End Sub

    Private Function IsAbundant(number As Long)

        Return SharedMethods.GetProperFactors(number).Sum() > number

    End Function

End Class
