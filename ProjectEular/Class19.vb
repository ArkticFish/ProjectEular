Public Class Class19

    Public Sub Solve()

        Dim total As Integer

        Dim myDate As New Date(1901, 1, 1)
        Dim maxDate = New Date(2000, 12, 31)

        While myDate < maxDate

            If myDate.DayOfWeek = DayOfWeek.Sunday Then
                total += 1
            End If

            myDate = myDate.AddMonths(1)

        End While

        Console.WriteLine($"{total}")

    End Sub

End Class
