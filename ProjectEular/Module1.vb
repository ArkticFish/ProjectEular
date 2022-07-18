Module Module1

    Private program As New Class53()

    Sub Main()

        Dim t1 = Date.Now()

        program.Solve()

        Dim t2 = Date.Now()

        Console.WriteLine($"Time : {t2 - t1}")

        Console.ReadLine()

    End Sub

End Module
