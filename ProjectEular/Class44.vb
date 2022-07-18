Public Class Class44

    Public Sub Solve()

        Dim min = 999999999

        Dim numbers As New List(Of Long)

        For n = 1 To 10000

            numbers.Add(n * (3 * n - 1) / 2)

        Next

        For j = 0 To 9998

            For k = j + 1 To 9999

                Dim sum = numbers(k) + numbers(j)
                Dim dif = numbers(k) - numbers(j)

                If numbers.Contains(sum) AndAlso numbers.Contains(dif) Then

                    Dim thisMin = Math.Abs(numbers(k) - numbers(j))
                    If thisMin < min Then
                        min = thisMin
                    End If

                End If

            Next

            Console.Write($"{j} ")

        Next

        Console.Clear()
        Console.WriteLine($"Ans = {min}")

    End Sub

End Class
