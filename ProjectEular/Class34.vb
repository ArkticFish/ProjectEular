Imports System.Numerics

Public Class Class34

    Public Sub Solve()

        Dim total As Long = 0

        Dim facts As Integer() = {1, 1, 2, 6, 24, 120, 720, 5040, 40320, 362880}

        For number As Long = 10 To 1000000

            Dim sum As Long = 0

            For Each ch In number.ToString()
                sum += facts(CInt(ch.ToString()))
            Next

            If sum = number Then
                total += number
                Console.WriteLine(sum)
            End If

            If number Mod 1000000 = 0 Then
                Console.WriteLine(number)
            End If

        Next

        Console.WriteLine(total)

    End Sub

End Class
