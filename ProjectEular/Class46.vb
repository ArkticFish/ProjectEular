Public Class Class46

    Public Sub Solve()

        Dim numbers As New List(Of Long)

        For n = 9 To 100001 Step 2

            If SharedMethods.IsPrime(n) = False Then

                If TestNumber(n) = False Then
                    Console.WriteLine(n)
                End If

            End If

        Next

    End Sub

    Private Function TestNumber(num As Long)

        Dim prime = 1

        While prime < num

            prime += 2

            If SharedMethods.IsPrime(prime) Then

                Dim square = 1

                While prime + 2 * square * square <= num

                    If prime + 2 * square * square = num Then
                        Return True
                    Else
                        square += 1
                    End If

                End While

            End If

        End While

        Return False

    End Function

End Class
