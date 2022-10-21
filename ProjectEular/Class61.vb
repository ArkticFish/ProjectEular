Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing.Reader

Public Class Class61
    
    Private numberList As List(Of (Indx as Int16, Prt1 as Int16, Prt2 as Int16)) = New List(Of (Indx as Int16, Prt1 as Int16, Prt2 as Int16))

    Public Sub Solve()

#Region "Populating"

        For i = 45 To 10000
            Dim num = Triangle(i).ToString()
            If num < 10000
                numberList.Add((0, Cint(num.Substring(0, 2)), Cint(num.Substring(2, 2))))
            Else
                Exit For
            End If
        Next

        For i = 32 To 10000
            Dim num = Square(i).ToString()
            If num < 10000
                numberList.Add((1, Cint(num.Substring(0, 2)), Cint(num.Substring(2, 2))))
            Else
                Exit For
            End If
        Next

        For i = 26 To 10000
            Dim num = Pentagonal(i).ToString()
            If num < 10000
                numberList.Add((2, Cint(num.Substring(0, 2)), Cint(num.Substring(2, 2))))
            Else
                Exit For
            End If
        Next

        For i = 23 To 10000
            Dim num = Hexagonal(i).ToString()
            If num < 10000
                numberList.Add((3, Cint(num.Substring(0, 2)), Cint(num.Substring(2, 2))))
            Else
                Exit For
            End If
        Next

        For i = 21 To 10000
            Dim num = Heptagonal(i).ToString()
            If num < 10000
                numberList.Add((4, Cint(num.Substring(0, 2)), Cint(num.Substring(2, 2))))
            Else
                Exit For
            End If
        Next

        For i = 19 To 10000
            Dim num = Octagonal(i).ToString()
            If num < 10000
                numberList.Add((5, Cint(num.Substring(0, 2)), Cint(num.Substring(2, 2))))
            Else
                Exit For
            End If
        Next

#End Region

#region "Pruning"

        For i = numberList.Count() - 1 To 0 Step -1
            Dim tester = numberList(i)
            If not numberList.Any(Function(val) val.Prt1 = tester.Prt2)
                numberList.Remove(tester)
            End If
        Next

#End Region

#region "Testing"
        TestNumbers()
#End Region

        Console.WriteLine("Done")

    End Sub

    Private Sub TestNumbers(optional starting As int16 = -1, optional ending As int16 = -1, optional sequence as String = "", optional total as integer = 0, Optional theString As string = "")

        If sequence.Length = 6 And ending = starting
            Console.WriteLine($"{theString} = {total}")
        End If

        For Each number In numberList.Where(Function(val) (val.Prt1 = ending Or ending = -1) AndAlso sequence.Contains(val.Indx) = false)

            TestNumbers(IIf(starting = -1, number.Prt1, starting), number.Prt2, $"{sequence}{number.Indx}", total + CInt($"{number.Prt1}{number.Prt2}"), $"{theString} - {number.Prt1}{number.Prt2}")

        Next

    End Sub

    Private Function Triangle(n As Long) As Long
        Return n * (n + 1) / 2
    End Function

    Private Function Square(n As Long) As Long
        Return n * n
    End Function

    Private Function Pentagonal(n As Long) As Long
        Return n * (3 * n - 1) / 2
    End Function

    Private Function Hexagonal(n As Long) As Long
        Return n * (2 * n - 1)
    End Function

    Private Function Heptagonal(n As Long) As Long
        Return n * (5 * n - 3) / 2
    End Function

    Private Function Octagonal(n As Long) As Long
        Return n * (3 * n - 2)
    End Function

End Class
