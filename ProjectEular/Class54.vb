Imports System.IO

Public Class Class54

    Public Sub Solve()

        Dim count = 0

        Dim gameLines = File.ReadAllLines("p054_poker.txt")

        For Each gameLine In gameLines

            Dim game = New PokerGame(gameLine)
            If game.WinningPlayer = "Player 1" Then
                count += 1
            End If

            Console.WriteLine($"{gameLine} : {game.WinningPlayer}")

        Next

        Console.WriteLine(count)
        Console.WriteLine("Done")

    End Sub

    Private Class PokerGame

        Private P1Hand As Hand
        Private P2Hand As Hand

        Public WinningPlayer As String = String.Empty

        Public Sub New(gameString As String)

            Dim cardStrings = gameString.Split(" "c)

            Dim P1Cards As New List(Of Card)
            For i = 0 To 4
                P1Cards.Add(New Card(cardStrings(i)))
            Next
            P1Hand = New Hand(P1Cards.OrderBy(Function(card) card.CardFace).ToList())

            Dim P2Cards As New List(Of Card)
            For i = 5 To 9
                P2Cards.Add(New Card(cardStrings(i)))
            Next
            P2Hand = New Hand(P2Cards.OrderBy(Function(card) card.CardFace).ToList())

            Dim result = Hand.Compare(P1Hand, P2Hand)
            If result = 0 Then
                WinningPlayer = "Draw"
            ElseIf result = 1 Then
                WinningPlayer = "Player 1"
            Else
                WinningPlayer = "Player 2"
            End If

        End Sub

    End Class

    Private Class Hand

        Private cards As New List(Of Card)

        ' Winning properties.
        Public RoyalFlush As Boolean

        Public StraightFlush As Boolean
        Public StraightFlushValue As Integer

        Public FourOfAKind As Boolean
        Public FourOfAKindValue As Integer

        Public FullHouse As Boolean
        Public FullHouseThreeValue As Integer
        Public FullHouseTwoValue As Integer

        Public Flush As Boolean

        Public Straight As Boolean
        Public StraightValue As Integer

        Public ThreeOfAKind As Boolean
        Public ThreeOfAKindValue As Integer

        Public TwoPairs As Boolean
        Public TwoPairsFirstValue As Integer
        Public TwoPairsSecondValue As Integer

        Public OnePair As Boolean
        Public OnePairValue As Integer

        Public HighCard As Integer

        Public Sub New(cards As List(Of Card))
            Me.cards = cards

            AnalyzeHand()
        End Sub

        Public Sub AnalyzeHand()

            ' Check Flush.
            If cards(0).CardSuit = cards(1).CardSuit AndAlso
               cards(1).CardSuit = cards(2).CardSuit AndAlso
               cards(2).CardSuit = cards(3).CardSuit AndAlso
               cards(3).CardSuit = cards(4).CardSuit Then

                Flush = True

            End If

            ' Check Straight.
            If cards(0).CardFace + 1 = cards(1).CardFace AndAlso
               cards(1).CardFace + 1 = cards(2).CardFace AndAlso
               cards(2).CardFace + 1 = cards(3).CardFace AndAlso
               cards(3).CardFace + 1 = cards(4).CardFace Then

                Straight = True
                StraightValue = cards(4).CardFace

            End If

            ' Check Straight Flush
            If Flush AndAlso Straight Then
                StraightFlush = True
                StraightFlushValue = StraightValue
                ' Check Royal Flush.
                If StraightFlushValue = 12 Then
                    RoyalFlush = True
                End If
            End If

            ' Group The Cards.
            Dim groups = cards.GroupBy(Function(card) card.CardFace).
                Select(Function(group) New Tuple(Of Integer, Integer)(group.Key, group.Count())).
                OrderBy(Function(group) group.Item2)

            ' Check Four Of A Kind.
            Dim fours = groups.Where(Function(group) group.Item2 = 4)
            If fours.Any() Then
                FourOfAKind = True
                FourOfAKindValue = fours.Last.Item1
            End If

            ' Check Three Of A Kind.
            Dim threes = groups.Where(Function(group) group.Item2 = 3)
            If threes.Any() Then
                ThreeOfAKind = True
                ThreeOfAKindValue = threes(threes.Count() - 1).Item1
            End If

            ' Check Two Pairs.
            Dim pairs = groups.Where(Function(group) group.Item2 = 2)
            If pairs.Any() Then
                OnePair = True
                OnePairValue = pairs(pairs.Count() - 1).Item1
                If pairs.Count() = 2 Then
                    TwoPairs = True
                    TwoPairsFirstValue = OnePairValue
                    TwoPairsSecondValue = pairs(pairs.Count() - 2).Item1
                End If
            End If

            ' Check for full house.
            If ThreeOfAKind AndAlso OnePair Then
                FullHouse = True
                FullHouseTwoValue = OnePairValue
                FullHouseThreeValue = ThreeOfAKindValue
            End If

            ' Set high card.
            If groups.Any(Function(group) group.Item2 = 1) Then
                HighCard = groups.Where(Function(group) group.Item2 = 1).Last.Item1
            End If

        End Sub

        Public Shared Function Compare(hand1 As Hand, hand2 As Hand) As Integer

            If hand1.RoyalFlush Then
                If hand2.RoyalFlush Then
                    Return 0
                Else
                    Return 1
                End If
            ElseIf hand1.StraightFlush Then
                If hand2.RoyalFlush Then
                    Return -1
                ElseIf hand2.StraightFlush Then
                    Return hand1.StraightFlushValue.CompareTo(hand2.StraightFlushValue)
                Else
                    Return 1
                End If
            ElseIf hand1.FourOfAKindValue Then
                If hand2.RoyalFlush Or hand2.StraightFlush Then
                    Return -1
                ElseIf hand2.FourOfAKind Then
                    Return hand1.FourOfAKindValue.CompareTo(hand2.FourOfAKindValue)
                Else
                    Return 1
                End If
            ElseIf hand1.FullHouse Then
                If hand2.RoyalFlush Or hand2.StraightFlush Or hand2.FourOfAKind Then
                    Return -1
                ElseIf hand2.FourOfAKind Then
                    Return hand1.FourOfAKindValue.CompareTo(hand2.FourOfAKindValue)
                Else
                    Return 1
                End If
            ElseIf hand1.Flush Then
                If hand2.RoyalFlush Or hand2.StraightFlush Or hand2.FourOfAKind Or hand2.FullHouse Then
                    Return -1
                ElseIf hand2.Flush Then
                    Return hand1.HighCard.CompareTo(hand2.HighCard)
                Else
                    Return 1
                End If
            ElseIf hand1.Straight Then
                If hand2.RoyalFlush Or hand2.StraightFlush Or hand2.FourOfAKind Or hand2.FullHouse Or hand2.Flush Then
                    Return -1
                ElseIf hand2.Straight Then
                    Return hand1.StraightValue.CompareTo(hand2.StraightValue)
                Else
                    Return 1
                End If
            ElseIf hand1.ThreeOfAKind Then
                If hand2.RoyalFlush Or hand2.StraightFlush Or hand2.FourOfAKind Or hand2.FullHouse Or hand2.Flush Or hand2.Straight Then
                    Return -1
                ElseIf hand2.ThreeOfAKind Then
                    Return hand1.ThreeOfAKindValue.CompareTo(hand2.ThreeOfAKindValue)
                Else
                    Return 1
                End If
            ElseIf hand1.TwoPairs Then
                If hand2.RoyalFlush Or hand2.StraightFlush Or hand2.FourOfAKind Or hand2.FullHouse Or hand2.Flush Or hand2.Straight Or hand2.ThreeOfAKind Then
                    Return -1
                ElseIf hand2.TwoPairs Then
                    If hand1.TwoPairsFirstValue = hand2.TwoPairsFirstValue Then
                        Return hand1.HighCard.CompareTo(hand2.HighCard)
                    Else
                        Return hand1.TwoPairsFirstValue.CompareTo(hand2.TwoPairsFirstValue)
                    End If
                Else
                    Return 1
                End If
            ElseIf hand1.OnePair Then
                If hand2.RoyalFlush Or hand2.StraightFlush Or hand2.FourOfAKind Or hand2.FullHouse Or hand2.Flush Or hand2.Straight Or hand2.ThreeOfAKind Or hand2.TwoPairs Then
                    Return -1
                ElseIf hand2.OnePair Then
                    If hand1.OnePairValue = hand2.OnePairValue Then
                        Return hand1.HighCard.CompareTo(hand2.HighCard)
                    Else
                        Return hand1.OnePairValue.CompareTo(hand2.OnePairValue)
                    End If
                Else
                    Return 1
                End If
            Else
                If hand2.RoyalFlush Or hand2.StraightFlush Or hand2.FourOfAKind Or hand2.FullHouse Or hand2.Flush Or hand2.Straight Or hand2.ThreeOfAKind Or hand2.TwoPairs Or hand2.OnePair Then
                    Return -1
                Else
                    Return hand1.HighCard.CompareTo(hand2.HighCard)
                End If
            End If

        End Function

    End Class

    Private Class Card

        Public CardSuit As Suit
        Public CardFace As Face

        Public Sub New(cardString)

            Dim face = cardString(0).ToString()

            Select Case face
                Case "2"
                    CardFace = Class54.Face.Two
                Case "3"
                    CardFace = Class54.Face.Three
                Case "4"
                    CardFace = Class54.Face.Four
                Case "5"
                    CardFace = Class54.Face.Five
                Case "6"
                    CardFace = Class54.Face.Six
                Case "7"
                    CardFace = Class54.Face.Seven
                Case "8"
                    CardFace = Class54.Face.Eight
                Case "9"
                    CardFace = Class54.Face.Nine
                Case "T"
                    CardFace = Class54.Face.Ten
                Case "J"
                    CardFace = Class54.Face.Jack
                Case "Q"
                    CardFace = Class54.Face.Queen
                Case "K"
                    CardFace = Class54.Face.King
                Case "A"
                    CardFace = Class54.Face.Ace
            End Select

            Dim suit = cardString(1).ToString()

            Select Case suit
                Case "H"
                    CardSuit = Class54.Suit.Heart
                Case "D"
                    CardSuit = Class54.Suit.Diamond
                Case "S"
                    CardSuit = Class54.Suit.Spade
                Case "C"
                    CardSuit = Class54.Suit.Club
            End Select

        End Sub

    End Class

    Private Enum Suit
        Heart
        Diamond
        Spade
        Club
    End Enum

    Private Enum Face
        Two
        Three
        Four
        Five
        Six
        Seven
        Eight
        Nine
        Ten
        Jack
        Queen
        King
        Ace
    End Enum

End Class
