Public Class Class12

    Public Sub Solve()

        Dim devisors = 0

        Dim newNumber = 0
        Dim curNumber = 0

        While devisors <= 500

            curNumber += 1
            newNumber += curNumber

            devisors = SharedMethods.GetFactors(newNumber).Count()

        End While

        Console.WriteLine($"{newNumber} - {devisors}")

    End Sub

End Class
