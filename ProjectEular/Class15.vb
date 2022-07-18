Public Class Class15

    Public Sub Solve()

        Dim number = CheckSpace(0, 0, 20)

        Console.WriteLine($"{number}")

    End Sub

    Private Function CheckSpace(x As Integer, y As Integer, size As Integer) As Long

        If x = size And y = size Then
            Return 1
        Else
            If x = size Then
                Return CheckSpace(x, y + 1, size)
            ElseIf y = size Then
                Return CheckSpace(x + 1, y, size)
            Else
                Return CheckSpace(x + 1, y, size) + CheckSpace(x, y + 1, size)
            End If
        End If

    End Function

End Class
