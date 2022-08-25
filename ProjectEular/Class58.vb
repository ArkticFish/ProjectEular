Public Class Class58

    Public Sub Solve()

        CalcTable(27000)

        Console.WriteLine("Done")

    End Sub

    Private Sub CalcTable(side As Integer)

        Dim size = side + 1

        Dim grid()() = New Integer(size)() {}

        For y = 0 To size - 1
            grid(y) = New Integer(size) {}
            For x = 0 To size - 1
                grid(y)(x) = 0
            Next
        Next

        Dim sum = 0
        Dim total = 0

        Dim curX = Math.Floor(size / 2.0)
        Dim curY = Math.Floor(size / 2.0)
        Dim midPoint = Math.Floor(size / 2.0)
        Dim curDir = Dir.Up

        For index = 1 To size * size

            grid(curX)(curY) = index

            If Math.Abs(midPoint - curX) = Math.Abs(midPoint - curY) Then
                total += 1
                If SharedMethods.IsPrime(index) Then
                    sum += 1
                End If
            End If

            If curX = curY And curX > midPoint Then
                Console.WriteLine($"{curX}:{curY}={sum / total:P0}")
                If sum / total < 0.1 Then
                    Console.WriteLine(Math.Abs(midPoint - curX) * 2 + 1)
                    Return
                End If
            End If

            If curX = Math.Floor(size / 2.0) And curY = Math.Floor(size / 2.0) Then
                curDir = Dir.Right
                curX += 1
            ElseIf curDir = Dir.Up Then
                If curX - 1 >= 0 AndAlso grid(curX - 1)(curY) = 0 Then
                    curDir = Dir.Left
                    curX -= 1
                Else
                    curY = curY - 1
                End If
            ElseIf curDir = Dir.Right Then
                If curY - 1 >= 0 AndAlso grid(curX)(curY - 1) = 0 Then
                    curDir = Dir.Up
                    curY = curY - 1
                Else
                    curX = curX + 1
                End If
            ElseIf curDir = Dir.Down Then
                If curX + 1 < size AndAlso grid(curX + 1)(curY) = 0 Then
                    curDir = Dir.Right
                    curX = curX + 1
                Else
                    curY = curY + 1
                End If
            ElseIf curDir = Dir.Left Then
                If curY + 1 < size AndAlso grid(curX)(curY + 1) = 0 Then
                    curDir = Dir.Down
                    curY = curY + 1
                Else
                    curX = curX - 1
                End If
            End If

        Next

    End Sub

    Public Enum Dir
        Up
        Right
        Down
        Left
    End Enum

End Class
