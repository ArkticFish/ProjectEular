Imports System.Text

Public Class Class40

    Public Sub Solve()

        Dim builder As New StringBuilder()
        Dim count = 1

        While builder.Length < 1000000

            builder.Append(count)
            count += 1

        End While

        Dim strVal = builder.ToString()

        Dim indexes = {1, 10, 100, 1000, 10000, 100000, 1000000}

        Dim val = 1

        For Each index In indexes
            val *= CInt(strVal(index - 1).ToString())
        Next

        Console.WriteLine()
        Console.WriteLine(val)

    End Sub

End Class
