Public Class Class10

    Public Sub Solve()

        Dim index = 1
        Dim total As Long = 0

        While index < 2000000

            If SharedMethods.IsPrime(index) Then
                total += index
            End If

            index += 1
        End While

        Console.WriteLine(total)

    End Sub

End Class
