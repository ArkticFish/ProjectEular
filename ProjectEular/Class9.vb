Public Class Class9

    Public Sub Solve()

        For a = 1 To 1000
            For b = 1 To 1000
                For c = 1 To 1000
                    If a + b + c = 1000 AndAlso a * a + b * b = c * c Then
                        Console.WriteLine(a * b * c)
                        Return
                    End If
                Next
            Next
        Next

    End Sub

End Class
