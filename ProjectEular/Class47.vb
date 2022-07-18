Public Class Class47

    Dim qCount = 4

    Public Sub Solve()

        Dim count = 0

        Dim index As Long

        For index = 1 To 10000000

            If CheckNumber(index) Then
                count += 1
            Else
                count = 0
            End If

            If count = qCount Then
                Exit For
            End If

        Next


        Console.WriteLine(index - qCount + 1)
        Console.WriteLine()

    End Sub

    Private Function CheckNumber(num As Long) As Boolean

        Return SharedMethods.GetFactors(num).Where(Function(val) SharedMethods.IsPrime(val)).Count >= qCount

    End Function

End Class
