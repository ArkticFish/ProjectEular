Public Class Class6

    Public Sub Solve()

        Dim num1 As Long
        For index = 1 To 100
            num1 += index * index
        Next

        Dim num2 As Long
        For index = 1 To 100
            num2 += index
        Next
        num2 *= num2

        Console.WriteLine(num2 - num1)

    End Sub

End Class
