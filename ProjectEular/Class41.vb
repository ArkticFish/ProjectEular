Public Class Class41

    Public Sub Solve()

        Dim count = 1

        For index = 7654321 To 1234567 Step -1

            If PanDigital(index, "1234567") Then

                Console.WriteLine(index)
                If SharedMethods.IsPrime(index) Then

                    Console.WriteLine(index)
                    Return

                End If

            End If

        Next

        Console.WriteLine()

    End Sub

    Public Function PanDigital(number As String, numbers As Char())

        Return number.Distinct().Where(Function(chr) numbers.Contains(chr)).Count() = number.Length

    End Function

End Class
