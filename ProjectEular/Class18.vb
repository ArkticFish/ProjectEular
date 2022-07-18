Imports System.Text

Public Class Class18

    Private pyramid As String = "75
95 64
17 47 82
18 35 87 10
20 04 82 47 65
19 01 23 75 03 34
88 02 77 73 07 63 67
99 65 04 28 06 16 70 92
41 41 26 56 83 40 80 70 33
41 48 72 33 47 32 37 16 94 29
53 71 44 65 25 43 91 52 97 51 14
70 11 33 28 77 73 17 78 39 68 17 57
91 71 52 38 17 14 91 43 58 50 27 29 48
63 66 04 68 89 53 67 30 73 16 69 87 40 31
04 62 98 27 23 09 70 98 73 93 38 53 60 04 23"

    Private myTree As New Tree

    Private maxNumber As Integer = 0

    Public Sub Solve()

        BuildNodes()

        SearchBreadth(myTree.Head, 0)

        Console.WriteLine($"{maxNumber}")

    End Sub

    Private Sub BuildNodes()

        Dim lines = pyramid.Split(vbCrLf).Select(Function(line) line.Split(" "))

        myTree.AddNode((0, 0), Dir.Left, 75)

        For indexLines = 0 To lines.Count() - 2

            For indexNumbers = 0 To lines(indexLines).Count() - 1

                myTree.AddNode((indexLines, indexNumbers), Dir.Left, lines(indexLines + 1)(indexNumbers))
                myTree.AddNode((indexLines, indexNumbers), Dir.Right, lines(indexLines + 1)(indexNumbers + 1))

            Next

        Next

    End Sub

    Private Sub SearchBreadth(n As Node, total As Integer)

        total += n.Value

        If (n.LeftNode Is Nothing) = False Then
            SearchBreadth(n.LeftNode, total)
        End If
        If (n.RightNode Is Nothing) = False Then
            SearchBreadth(n.RightNode, total)
        End If

        If n.Location.y = 14 Then
            If total > maxNumber Then
                maxNumber = total
            End If
        End If

    End Sub

End Class

Public Class Tree

    Public Head As Node

    Public Sub AddNode(location As (y As Integer, x As Integer), direction As dir, value As Integer)

        If Head Is Nothing Then
            Head = New Node((0, 0), value)
            Return
        End If

        Dim curNode = Head

        While True

            If curNode.Location.y = location.y Then
                If direction = Dir.Left Then
                    Dim leftNode = GetLeftNode((location.y, location.x - 1))
                    If leftNode IsNot Nothing Then
                        curNode.LeftNode = leftNode
                    Else
                        curNode.LeftNode = New Node((location.y + 1, location.x), value)
                    End If
                    Return
                Else
                    Dim rightNode = GetRightNode((location.y, location.x + 1))
                    If rightNode IsNot Nothing Then
                        curNode.RightNode = rightNode
                    Else
                        curNode.RightNode = New Node((location.y + 1, location.x + 1), value)
                    End If
                    Return
                End If
            Else
                If location.x > curNode.Location.x Then
                    curNode = curNode.RightNode
                Else
                    curNode = curNode.LeftNode
                End If
            End If

        End While

    End Sub

    Public Function GetLeftNode(location As (y As Integer, x As Integer)) As Node

        Dim curNode = Head

        While True

            If curNode Is Nothing Then
                Return Nothing
            Else

                If curNode.Location.y = location.y Then
                    If curNode.Location.x <> location.x Then
                        Return Nothing
                    Else
                        Return curNode.RightNode
                    End If
                Else
                    If location.x > curNode.Location.x Then
                        curNode = curNode.RightNode
                    Else
                        curNode = curNode.LeftNode
                    End If
                End If

            End If

        End While

    End Function

    Public Function GetRightNode(location As (y As Integer, x As Integer))

        Dim curNode = Head

        While True

            If curNode Is Nothing Then
                Return Nothing
            Else

                If curNode.Location.y = location.y Then
                    If curNode.Location.x <> location.x Then
                        Return Nothing
                    Else
                        Return curNode.LeftNode
                    End If
                Else
                    If location.x > curNode.Location.x Then
                        curNode = curNode.RightNode
                    Else
                        curNode = curNode.LeftNode
                    End If
                End If

            End If

        End While

    End Function

End Class

Public Class Node

    Public Value As Integer

    Public LeftNode As Node
    Public RightNode As Node

    Public Location As (y As Integer, x As Integer)

    Public Sub New(location As (y As Integer, x As Integer), value As Integer)

        Me.Value = value
        Me.Location = location

    End Sub

End Class

Public Enum Dir
    Left
    Right
End Enum
