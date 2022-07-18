
Public Class Class30

    Public Sub Solve()

        Dim answer As Long = 0

        For index As Long = 2 To 1000000

            Dim sum = index.
                ToString().
                Select(Function(val)
                           Return Math.Pow(Convert.ToInt64(val.ToString()), 5)
                       End Function).Sum()

            If sum = index Then
                answer += index
            End If

        Next

        Console.WriteLine(answer)

    End Sub

End Class
