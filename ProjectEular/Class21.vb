Public Class Class21

    Public Sub Solve()

        Dim amicables As New List(Of Long)
        Dim nonAmicables As New List(Of Long)

        For index = 1 To 9999

            If amicables.Contains(index) = False AndAlso nonAmicables.Contains(index) = False Then

                Dim a = SumOf(index)
                Dim b = SumOf(a)

                If b = index AndAlso a <> b Then
                    amicables.Add(index)
                    amicables.Add(a)
                Else
                    nonAmicables.Add(index)
                    nonAmicables.Add(a)
                End If

            End If

        Next

        Console.WriteLine(amicables.Sum())

    End Sub

    Private Function SumOf(number As Long) As Long

        Dim factors = SharedMethods.GetProperFactors(number)
        Return factors.Sum()

    End Function

End Class
