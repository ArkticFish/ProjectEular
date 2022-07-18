Public Class Class31

    Private count As Long
    Private coins As Integer() = {200, 100, 50, 20, 10, 5, 2, 1}

    Public Sub Solve()

        Search(0, 0)
        Console.WriteLine(count)

    End Sub

    Private Sub Search(val As String, index As Integer)

        While val < 200

            If index < coins.Length - 1 Then

                Search(val, index + 1)

            End If

            val += coins(index)

            If val = 200 Then
                count += 1
            End If

        End While


    End Sub

    'Public Sub Solve()

    '    Dim answer As Long = 0

    '    Dim p200 = 0

    '    While p200 < 200

    '        Dim p100 = p200

    '        While p100 < 200

    '            Dim p50 = p100

    '            While p50 < 200

    '                Dim p20 = p50

    '                While p20 < 200

    '                    Dim p10 = p20

    '                    While p10 < 200

    '                        Dim p5 = p10

    '                        While p5 < 200

    '                            Dim p2 = p5

    '                            While p2 < 200

    '                                Dim p1 = p2

    '                                While p1 < 200

    '                                    p1 += 1

    '                                    If p1 = 200 Then
    '                                        answer += 1
    '                                    End If

    '                                End While

    '                                p2 += 2

    '                                If p2 = 200 Then
    '                                    answer += 1
    '                                End If

    '                            End While

    '                            p5 += 5

    '                            If p5 = 200 Then
    '                                answer += 1
    '                            End If

    '                        End While

    '                        p10 += 10

    '                        If p10 = 200 Then
    '                            answer += 1
    '                        End If

    '                    End While

    '                    p20 += 20

    '                    If p20 = 200 Then
    '                        answer += 1
    '                    End If

    '                End While

    '                p50 += 50

    '                If p50 = 200 Then
    '                    answer += 1
    '                End If

    '            End While

    '            p100 += 100

    '            If p100 = 200 Then
    '                answer += 1
    '            End If

    '        End While

    '        p200 += 200

    '        If p200 = 200 Then
    '            answer += 1
    '        End If

    '    End While

    '    Console.WriteLine(answer)

    'End Sub

End Class
