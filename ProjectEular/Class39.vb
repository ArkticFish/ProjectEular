Public Class Class39

    Public Sub Solve()

        Dim maxP As Integer = 0
        Dim maxPVal As Integer = 0

        For p = 1 To 1000

            Dim val = 0

            For a = 1 To p

                For b = 1 To p - a

                    Dim c = p - a - b

                    If IsRightTriangle({a, b, c}) Then

                        val += 1

                    End If

                Next

            Next

            If val > maxPVal Then
                maxPVal = val
                maxP = p
            End If

            Console.WriteLine(p)

        Next

        Console.WriteLine()
        Console.WriteLine(maxP)

    End Sub

    Private Function IsRightTriangle(sides As Integer())

        Array.Sort(sides)

        Return Math.Pow(sides(0), 2) + Math.Pow(sides(1), 2) = Math.Pow(sides(2), 2)

    End Function

End Class
