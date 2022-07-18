Public Class Class7

    Public Sub Solve()

        Dim count = 0
        Dim index = 1

        While count < 10001

            index += 1

            If SharedMethods.IsPrime(index) Then
                count += 1
            End If

        End While

        Console.WriteLine(index)

    End Sub

End Class
