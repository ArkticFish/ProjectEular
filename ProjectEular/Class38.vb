Public Class Class38

    Public Sub Solve()

        Dim max As Long = 0

        For n = 2 To 10

            For num = 1 To 10000

                Dim str = ""

                For i = 1 To n

                    str += (i * num).ToString()

                Next

                If str.Length = 9 AndAlso str.Distinct().Where(Function(chr) chr <> "0"c).Count() = 9 Then

                    Dim val = Convert.ToInt64(str)
                    If val > max Then
                        max = val
                    End If

                End If

            Next

        Next

        Console.WriteLine()
        Console.WriteLine(max)

    End Sub

End Class
