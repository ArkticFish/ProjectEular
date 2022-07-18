Public Class Class52

    Public Sub Solve()

        For number = 1 To 99999999

            Dim digits = String.Concat(number.ToString.OrderBy(Function(a) a))

            For mult = 2 To 6

                Dim newDigits = String.Concat((number * mult).ToString.OrderBy(Function(a) a))

                If newDigits <> digits Then
                    GoTo NextNumber
                End If

            Next

            Console.WriteLine(number)
            Return

NextNumber:

        Next

        Console.WriteLine("Done")

    End Sub

End Class
