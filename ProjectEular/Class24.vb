Public Class Class24

    Private count As Integer = 0

    Private allChars As Char()

    Public Sub Solve()

        allChars = {"0"c, "1"c, "2"c, "3"c, "4"c, "5"c, "6"c, "7"c, "8"c, "9"c}

        Permutations(String.Empty)

    End Sub

    'Public Sub SolveOld()

    '    Dim count As Integer = 0

    '    allChars = {"0"c, "1"c, "2"c, "3"c, "4"c, "5"c, "6"c, "7"c, "8"c, "9"c}

    '    For c1 = 0 To allChars.Length - 1

    '        Dim p1 As String = c1

    '        For c2 = 0 To allChars.Length - 1

    '            If Not p1.Contains(allChars(c2)) Then

    '                Dim p2 = p1 + allChars(c2)

    '                For c3 = 0 To allChars.Length - 1

    '                    If Not p2.Contains(allChars(c3)) Then

    '                        Dim p3 = p2 + allChars(c3)

    '                        For c4 = 0 To allChars.Length - 1

    '                            If Not p3.Contains(allChars(c4)) Then

    '                                Dim p4 = p3 + allChars(c4)

    '                                For c5 = 0 To allChars.Length - 1

    '                                    If Not p4.Contains(allChars(c5)) Then

    '                                        Dim p5 = p4 + allChars(c5)

    '                                        For c6 = 0 To allChars.Length - 1

    '                                            If Not p5.Contains(allChars(c6)) Then

    '                                                Dim p6 = p5 + allChars(c6)

    '                                                For c7 = 0 To allChars.Length - 1

    '                                                    If Not p6.Contains(allChars(c7)) Then

    '                                                        Dim p7 = p6 + allChars(c7)

    '                                                        For c8 = 0 To allChars.Length - 1

    '                                                            If Not p7.Contains(allChars(c8)) Then

    '                                                                Dim p8 = p7 + allChars(c8)

    '                                                                For c9 = 0 To allChars.Length - 1

    '                                                                    If Not p8.Contains(allChars(c9)) Then

    '                                                                        Dim p9 = p8 + allChars(c9)

    '                                                                        For c10 = 0 To allChars.Length - 1

    '                                                                            If Not p9.Contains(allChars(c10)) Then

    '                                                                                Dim p10 = p9 + allChars(c10)
    '                                                                                count += 1

    '                                                                                If count = 1000000 Then
    '                                                                                    Console.WriteLine(p10)
    '                                                                                End If

    '                                                                            End If

    '                                                                        Next

    '                                                                    End If

    '                                                                Next

    '                                                            End If

    '                                                        Next

    '                                                    End If

    '                                                Next

    '                                            End If

    '                                        Next

    '                                    End If

    '                                Next

    '                            End If

    '                        Next

    '                    End If

    '                Next

    '            End If

    '        Next

    '    Next

    'End Sub

    Private Sub Permutations(val As String)

        If val.Length = allChars.Length Then

            count += 1
            If count = 1000000 Then
                Console.WriteLine(val)
                Return
            End If

        Else

            For index = 0 To allChars.Length - 1
                If Not val.Contains(allChars(index)) Then
                    Permutations(val + allChars(index))
                End If
            Next

        End If

    End Sub

End Class
