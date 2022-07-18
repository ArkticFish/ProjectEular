Imports System.Numerics

Public Class Class43

    Private sum As Long = 0

    Public Sub Solve()

        CheckString("")

        Console.WriteLine()
        Console.WriteLine(sum)

    End Sub

    ' Die is die algoritme. Dit vat 'n woord(string)
    Private Sub CheckString(value As String)

        ' Hier toets ons of ons woord al die letters bevat.
        ' As die woord minder as 10 karakters bevat beteken dit
        ' al die syfers is nog nie in die woord nie en ons moet nog bysit.
        If value.Length < 10 Then
            ' Hier gaan ons van 0 tot 9 en toets of ons woord al klaar 
            ' daardie syfer besit.
            For i = 0 To 9
                If value.Contains(i) = False Then
                    ' As dit nie die syfer bevat nie heg die syfer aan
                    ' die agterkant van die woord en toets weer.
                    CheckString(value & i)
                End If
            Next
        Else
            ' As die woord 'n lengte het van 10 karakters
            ' beteken dit al die karakters is gebruik en ons
            ' moet toets vir die deelbaarheid.
            If HasProperty(value) Then
                sum += Long.Parse(value)
            End If
        End If

    End Sub

    Private Function HasProperty(value As String)
        Return CInt(value.Substring(1, 3)) Mod 2 = 0 AndAlso
                   CInt(value.Substring(2, 3)) Mod 3 = 0 AndAlso
                   CInt(value.Substring(3, 3)) Mod 5 = 0 AndAlso
                   CInt(value.Substring(4, 3)) Mod 7 = 0 AndAlso
                   CInt(value.Substring(5, 3)) Mod 11 = 0 AndAlso
                   CInt(value.Substring(6, 3)) Mod 13 = 0 AndAlso
                   CInt(value.Substring(7, 3)) Mod 17 = 0
    End Function

End Class
