Public Class Class32


    Private refString = "123456789"

    Public Sub Solve()

        Dim products As New List(Of Long)

        Dim max = Math.Sqrt(9876543)

        For a = 1 To max

            If a Mod 10000 = 0 Then
                Console.Write(a & vbCr)
            End If

            For b = 1 To 9876543 / a

                Dim str = $"{a}{b}{a * b}"
                If str.Length = 9 Then
                    If str.Intersect(refString).Count() = 9 Then
                        products.Add(a * b)
                        Console.WriteLine(str)
                    End If
                End If

            Next

        Next

        Console.WriteLine()
        Console.WriteLine(products.Distinct().Sum())

    End Sub

End Class
