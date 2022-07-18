Imports System.Numerics

Public Class Class33

    Public Sub Solve()

        Dim top As Long = 1
        Dim bot As Long = 1

        For n = 10 To 99

            For d = 10 To 99

                ' Filter obvious.
                If (n Mod 10 = 0 And n Mod 10 = 0) Or n = d Or n >= d Then
                    Continue For
                End If

                ' Create equavalance value.
                Dim q = n / d

                ' Create string values.
                Dim nS = n.ToString()
                Dim dS = d.ToString()

                ' Loop and replace.
                For i = 0 To 1
                    For j = 0 To 1

                        Dim cI = nS(i)
                        Dim cJ = dS(j)

                        If cI = cJ Then

                            Dim nN = Convert.ToDouble(nS.Remove(i, 1))
                            Dim nD = Convert.ToDouble(dS.Remove(j, 1))

                            If nN / nD = q Then
                                top *= n
                                bot *= d

                                Console.WriteLine($"{n}/{d}")

                                GoTo NextValue
                            End If

                        End If

                    Next
                Next

NextValue:

            Next

        Next

        Dim scd = SharedMethods.GCD(top, bot)

        top /= scd
        bot /= scd

        Console.WriteLine($"Ans = {bot}")

    End Sub

End Class
