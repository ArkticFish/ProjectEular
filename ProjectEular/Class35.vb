Public Class Class35

    Public Sub Solve()

        Dim count = 0

        For i = 1 To 1000000

            Dim match = False

            If SharedMethods.IsPrime(i) Then

                match = True

                ' Check rotations.
                Dim ww = i & i
                Dim l = ww.Length / 2
                For j = 1 To l

                    Dim w = ww.Substring(j, l)
                    If SharedMethods.IsPrime(w) = False Then
                        match = False
                        GoTo SkipNumber
                    End If

                Next


            End If

SkipNumber:
            If match Then
                count += 1
                Console.WriteLine(i)
            End If

        Next

        Console.WriteLine()
        Console.WriteLine(count)

    End Sub

End Class
