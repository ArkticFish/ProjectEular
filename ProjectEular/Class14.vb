Public Class Class14

    Public Sub Solve()

        Dim curNumber = 0

        Dim maxChain = 0
        Dim maxChainNumber = 0

        While curNumber <= 1000000

            curNumber += 1
            Dim chain = Collatz(curNumber, 1)

            If chain > maxChain Then
                maxChain = chain
                maxChainNumber = curNumber
            End If

        End While

        Console.WriteLine($"{maxChainNumber} - {maxChain}")

    End Sub

    Private Function Collatz(number As Long, count As Long) As Long

        If number = 1 Then
            Return count
        Else
            If number Mod 2 = 0 Then
                Return Collatz(number / 2, count + 1)
            Else
                Return Collatz(3 * number + 1, count + 1)
            End If
        End If

    End Function

End Class
