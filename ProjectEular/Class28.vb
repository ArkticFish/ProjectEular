Public Class Class28

    Public Sub Solve()

        Dim width As Integer = 1001
        Dim height As Integer = 1001


        Dim grid(width, height) As Integer

        For y = 0 To height - 1
            For x = 0 To width - 1
                grid(x, y) = 0
            Next
        Next

        Dim curX = Math.Floor(width / 2.0)
        Dim curY = Math.Floor(height / 2.0)
        Dim curDir = Dir.Up

        For index = 1 To width * height

            grid(curX, curY) = index

            If curDir = Dir.Up Then
                If curX + 1 < width AndAlso grid(curX + 1, curY) = 0 Then
                    curDir = Dir.Right
                    curX = curX + 1
                Else
                    curY = curY - 1
                End If
            ElseIf curDir = Dir.Right Then
                If curY + 1 < height AndAlso grid(curX, curY + 1) = 0 Then
                    curDir = Dir.Down
                    curY = curY + 1
                Else
                    curX = curX + 1
                End If
            ElseIf curDir = Dir.Down Then
                If curX - 1 >= 0 AndAlso grid(curX - 1, curY) = 0 Then
                    curDir = Dir.Left
                    curX = curX - 1
                Else
                    curY = curY + 1
                End If
            ElseIf curDir = Dir.Left Then
                If curY - 1 >= 0 AndAlso grid(curX, curY - 1) = 0 Then
                    curDir = Dir.Up
                    curY = curY - 1
                Else
                    curX = curX - 1
                End If
            End If

        Next

        'For y = 0 To height - 1
        '    For x = 0 To width - 1
        '        Console.Write($"{grid(x, y):00} ")
        '    Next
        '    Console.WriteLine()
        'Next

        Dim sum = 0

        For index = 0 To width - 1
            sum += grid(index, index)
        Next

        For index = 0 To width - 1
            sum += grid(index, (width - 1) - index)
        Next

        Console.WriteLine()
        Console.WriteLine($"Sum: {sum - 1}")


    End Sub

    Public Enum Dir
        Up
        Right
        Down
        Left
    End Enum

End Class
