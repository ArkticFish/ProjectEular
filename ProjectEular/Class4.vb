Public Class Class4

    Public Sub Solve()

        Dim thelist As New List(Of Long)

        For x = 100 To 999

            For y = 100 To 999

                Dim number = x * y
                Dim _to = number.ToString()
                Dim _fro = SharedMethods.Reverse(_to)

                If _to = _fro Then
                    thelist.Add(number)
                End If

            Next

        Next

        thelist.Sort()
        Console.WriteLine(thelist.LastOrDefault())

    End Sub

End Class
