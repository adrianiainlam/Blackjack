'/**********************************************************************************
' * Blackjack                                                                      *
' * Copyright 2013 Adrian Lam                                                      *
' * Last edited 22/11/2013                                                         *
' * Version: beta                                                                  *
' **********************************************************************************
' * Blackjack is free software: you can redistribute it and/or modify              *
' * it under the terms of the GNU General Public License as published by           *
' * the Free Software Foundation; either version 3 of the License, or              *
' * (at your option) any later version.                                            *
' *                                                                                *
' * This program is distributed in the hope that it will be useful,                *
' * but WITHOUT ANY WARRANTY; without even the implied warrranty of                *
' * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the                  *
' * GNU General Public License for more details.                                   *
' *                                                                                *
' * You should have received a copy of the GNU General Public License              *
' * along with this program.  If not, see <http://www.gnu.org/licenses/>           *
' *                                                                                *
' **********************************************************************************/

Public Class Blackjack

    Dim AllCards(52) As Boolean ' array to store whether each card has been dealt
    '                             1-13 is Ace to King of spades, 14-26 is Ace to King of Hearts etc

    Dim PlayerCards(5) As Integer, PlayerCardCount As Integer, PlayerCardSum As Integer, PlayerCardSoftSum As Integer

    Dim DealerCards(5) As Integer, DealerCardCount As Integer, DealerCardSum As Integer, DealerCardSoftSum As Integer

    Dim PlayerSplitCards(5) As Integer, PlayerSplitCount As Integer, PlayerSplitSum As Integer, PlayerSplitSoftSum As Integer

    Dim SplitStatus As Integer '0 when no split, 1 when playing 1st hand split, 2 when playing 2nd hand
    Dim Split1Busted As Boolean, Split2Busted As Boolean

    Private Sub Blackjack_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TxtBet.Focus()
        CmdHit.Hide()
        CmdStand.Hide()
        CmdDoubleDown.Hide()
        CmdSplit.Hide()
        LblStatus.Text = "Enter bet amount and" & Chr(13) & Chr(10) & "click Deal to start"
        Randomize() 'Seed pseudo-random number generator
    End Sub

    Sub Initialise()
        Dim i As Integer
        LblStatus.Text = ""
        CmdDeal.Hide()
        CmdHit.Hide()
        CmdStand.Hide()
        CmdDoubleDown.Hide()
        CmdSplit.Hide()
        TxtBet.ReadOnly = True
        For i = 1 To 52 Step 1
            AllCards(i) = False
        Next
        For i = 1 To 5 Step 1
            DealerCards(i) = 0
            PlayerSplitCards(i) = 0
            PlayerCards(i) = 0
        Next
        PlayerCardCount = 0
        DealerCardCount = 0
        PlayerCardSum = 0
        PlayerCardSoftSum = 0
        DealerCardSum = 0
        DealerCardSoftSum = 0
        PlayerSplitCount = 0
        PlayerSplitSum = 0
        PlayerSplitSoftSum = 0
        SplitStatus = 0
        TxtPlayerCard1.Text = ""
        TxtPlayerCard1.Visible = False
        TxtPlayerCard2.Text = ""
        TxtPlayerCard2.Visible = False
        TxtPlayerCard3.Text = ""
        TxtPlayerCard3.Visible = False
        TxtPlayerCard4.Text = ""
        TxtPlayerCard4.Visible = False
        TxtPlayerCard5.Text = ""
        TxtPlayerCard5.Visible = False
        TxtSplit1.Text = ""
        TxtSplit1.Visible = False
        TxtSplit2.Text = ""
        TxtSplit2.Visible = False
        TxtSplit3.Text = ""
        TxtSplit3.Visible = False
        TxtSplit4.Text = ""
        TxtSplit4.Visible = False
        TxtSplit5.Text = ""
        TxtSplit5.Visible = False
        TxtDealerCard1.Text = ""
        TxtDealerCard1.Visible = False
        TxtDealerCard2.Text = ""
        TxtDealerCard2.Visible = False
        TxtDealerCard3.Text = ""
        TxtDealerCard3.Visible = False
        TxtDealerCard4.Text = ""
        TxtDealerCard4.Visible = False
        TxtDealerCard5.Text = ""
        TxtDealerCard5.Visible = False
        Split1Busted = False
        Split2Busted = False
    End Sub

    Private Sub CmdDeal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdDeal.Click

        '''''BEGIN VALIDATION'''''
        If Val(TxtTotal.Text) <= 0 Then
            MsgBox("You have no more money! Click OK to exit program...")
            Me.Close()
        End If
        If TxtBet.Text = "" Or Not IsNumeric(TxtBet.Text) Or Int(Val(TxtBet.Text)) <= 0 Then
            MsgBox("Please enter a valid bet value")
            Return
        End If
        TxtBet.Text = CStr(Int(Val(TxtBet.Text)))
        If Val(TxtBet.Text) > Val(TxtTotal.Text) Then
            MsgBox("You don't have enough money for such a high bet! Please lower your bet value")
            Return
        End If
        '''''END VALIDATION'''''

        Initialise()
        TxtTotal.Text = CStr(Val(TxtTotal.Text) - Val(TxtBet.Text))

        '/**********************************************************************/

        DealToPlayer()
        DealToPlayer()
        'BEGIN Deal hole card to dealer
        DealOneCard(DealerCards, DealerCardCount, DealerCardSum, DealerCardSoftSum)
        TxtDealerCard1.BackColor = Color.Gray
        TxtDealerCard1.Visible = True
        'END Deal hole card to dealer
        DealToDealer()

        '/**************************************************************************/

        '''''BEGIN INSURANCE'''''
        If DealerCards(2) Mod 13 = 1 And Val(TxtTotal.Text) >= Int((Val(TxtBet.Text) + 1) / 2) Then ' If dealer's up card is Ace AND player has enough money Then
            Dim OptionIns As Integer '6=yes, 7=no
            OptionIns = MsgBox("Dealer may have blackjack, do you want insurance?", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Exclamation)
            If OptionIns = 6 And DealerCardSum = 21 Then
                If PlayerCardSum = 21 Then
                    LblStatus.Text = "Dealer and you both have blackjack, push"
                    TxtTotal.Text = CStr(Int(Val(TxtBet.Text) * 5 / 2) + Val(TxtTotal.Text))
                Else
                    LblStatus.Text = "Dealer has blackjack"
                    TxtTotal.Text = CStr(Val(TxtTotal.Text) + Val(TxtBet.Text))
                End If
                DisplayCard(TxtDealerCard1, DealerCards(1))
                EnableDeal()
                Return
            ElseIf OptionIns = 6 And DealerCardSum <> 21 Then
                LblStatus.Text = "Dealer does not have blackjack"
                TxtTotal.Text = CStr(Val(TxtTotal.Text) - Int((Val(TxtBet.Text) + 1) / 2))
            ElseIf OptionIns = 7 And DealerCardSum = 21 Then
                LblStatus.Text = "Dealer has blackjack"
                DisplayCard(TxtDealerCard1, DealerCards(1))
                EnableDeal()
                Return
            End If
        End If
        '''''END INSURANCE'''''

        '''''BEGIN IF DEALER HAS BLACKJACK'''''
        If DealerCardSum = 21 Then
            If PlayerCardSum = 21 Then
                LblStatus.Text = "Dealer and you both have blackjack, push"
                TxtTotal.Text = CStr(Val(TxtTotal.Text) + Val(TxtBet.Text))
            Else
                LblStatus.Text = "Dealer has blackjack"
            End If
            DisplayCard(TxtDealerCard1, DealerCards(1))
            EnableDeal()
            Return
        End If
        '''''END IF DEALER HAS BLACKJACK'''''

        '''''BEGIN IF PLAYER HAS BLACKJACK'''''
        If PlayerCardSum = 21 Then
            LblStatus.Text = "You have blackjack!"
            TxtTotal.Text = CStr(Val(TxtTotal.Text) + Int(Val(TxtBet.Text) * 5 / 2))
            EnableDeal()
            Return
        End If
        '''''END IF PLAYER HAS BLACKJACK'''''

        '/**************************************************************************/

        CmdStand.Show()
        CmdHit.Show()
        CmdDoubleDown.Show()
        If PlayerCards(1) Mod 13 = PlayerCards(2) Mod 13 Then ' If both cards equal Then
            CmdSplit.Show()
        End If
    End Sub

    Function RandBetween(ByVal lower As Integer, ByVal higher As Integer) ' Returns a random integer between lower and higher inclusive
        Return Int((higher - lower + 1) * Rnd() + lower)
    End Function

    Sub DisplayCard(ByRef card As TextBox, ByVal CardValue As Integer)
        Dim face As String, suit As String = "" ' Initialised to stop the complaint of Visual Studio, syntactically and logically not required

        card.BackColor = Color.White ' Set the color of the textbox to white
        If CardValue <> 0 Then
            Select Case (Int((CardValue - 1) / 13))
                Case 0
                    suit = "♠"
                    card.ForeColor = Color.Black ' Set the font color to black
                Case 1
                    suit = "♥"
                    card.ForeColor = Color.Red
                Case 2
                    suit = "♣"
                    card.ForeColor = Color.Black
                Case 3
                    suit = "♦"
                    card.ForeColor = Color.Red
            End Select
            Select Case (CardValue Mod 13)
                Case 0
                    face = "K"
                Case 11
                    face = "J"
                Case 12
                    face = "Q"
                Case 1
                    face = "A"
                Case Else
                    face = CStr(CardValue Mod 13)
            End Select
            card.Text = suit & Chr(13) & Chr(10) & face
            card.Visible = True
        End If
    End Sub

    Sub DealOneCard(ByRef PersonCards() As Integer, ByRef PersonCardCount As Integer, ByRef PersonCardSum As Integer, ByRef PersonCardSoftSum As Integer)
        Dim card As Integer

        Do ' Ensure that no cards are repeated
            card = RandBetween(1, 52)
        Loop Until Not AllCards(card)
        AllCards(card) = True

        PersonCardCount = PersonCardCount + 1
        PersonCards(PersonCardCount) = card
        PersonCardSum = PersonCardSum + (card Mod 13)
        ' Now this does not work if the card is A, J, Q or K, so the exceptions are handled below:

        If PersonCardSoftSum <> 0 Then ' If person has an ace Then
            PersonCardSoftSum = PersonCardSoftSum + (card Mod 13)
        End If

        Select Case (card Mod 13)
            Case 0 ' is King
                PersonCardSum = PersonCardSum + 10
                If PersonCardSoftSum <> 0 Then ' If person has an ace Then
                    PersonCardSoftSum = PersonCardSoftSum + 10
                End If
            Case 11 ' is Jack
                PersonCardSum = PersonCardSum - 1
                If PersonCardSoftSum <> 0 Then
                    PersonCardSoftSum = PersonCardSoftSum - 1
                End If
            Case 12 ' is Queen
                PersonCardSum = PersonCardSum - 2
                If PersonCardSoftSum <> 0 Then
                    PersonCardSoftSum = PersonCardSoftSum - 2
                End If
            Case 1 ' is Ace
                PersonCardSum = PersonCardSum + 10
                If PersonCardSoftSum = 0 Then ' If person does not already have an ace Then
                    PersonCardSoftSum = PersonCardSum - 10
                Else ' Person already has an ace
                    PersonCardSum = PersonCardSum - 10
                End If
        End Select
    End Sub

    Sub DealToPlayer()
        DealOneCard(PlayerCards, PlayerCardCount, PlayerCardSum, PlayerCardSoftSum)
        DisplayCard(TxtPlayerCard1, PlayerCards(1))
        DisplayCard(TxtPlayerCard2, PlayerCards(2))
        DisplayCard(TxtPlayerCard3, PlayerCards(3))
        DisplayCard(TxtPlayerCard4, PlayerCards(4))
        DisplayCard(TxtPlayerCard5, PlayerCards(5))
    End Sub

    Sub DealToDealer()
        DealOneCard(DealerCards, DealerCardCount, DealerCardSum, DealerCardSoftSum)
        ''card 1 skipped because it is hole card
        DisplayCard(TxtDealerCard2, DealerCards(2))
        DisplayCard(TxtDealerCard3, DealerCards(3))
        DisplayCard(TxtDealerCard4, DealerCards(4))
        DisplayCard(TxtDealerCard5, DealerCards(5))
    End Sub

    Private Sub CmdHit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdHit.Click
        CmdDoubleDown.Hide()

        If SplitStatus = 0 Then ' If player did not split Then
            DealToPlayer()
            If PlayerCardSoftSum > 21 Or (PlayerCardSum > 21 And PlayerCardSoftSum = 0) Then
                LblStatus.Text = "You busted"
                EnableDeal()
                Return
            ElseIf PlayerCardCount = 5 Then
                LblStatus.Text = "You win"
                TxtTotal.Text = CStr(Val(TxtTotal.Text) + 2 * Val(TxtBet.Text))
                EnableDeal()
                Return
            ElseIf PlayerCardSum = 21 Or PlayerCardSoftSum = 21 Then ' Automatically stands if player reaches 21
                CmdStand.PerformClick()
            End If

        ElseIf SplitStatus = 1 Then ' ElseIf player splitted and is playing the first hand Then
            DealToPlayer()
            If PlayerCardSoftSum > 21 Or (PlayerCardSum > 21 And PlayerCardSoftSum = 0) Then
                LblStatus.Text = "First hand busted" & Chr(13) & Chr(10) & "Second hand (top)"
                Split1Busted = True
                CmdHit.Show()
                CmdStand.Show()
                SplitStatus = 2 ' Starts player on second hand
            ElseIf PlayerCardCount = 5 Then
                LblStatus.Text = "First hand win" & Chr(13) & Chr(10) & "Second hand (top)"
                SplitStatus = 2 ' Starts player on second hand
            ElseIf PlayerCardSum = 21 Or PlayerCardSoftSum = 21 Then ' Automatically stands if player reaches 21
                CmdStand.PerformClick()
            End If

        Else ' ElseIf player splitted and is playing the second hand Then
            DealToSplit()
            If PlayerSplitSoftSum > 21 Or (PlayerSplitSum > 21 And PlayerSplitSoftSum = 0) Then
                LblStatus.Text = "Second hand busted"
                Split2Busted = True
                EndSplitHands()
            ElseIf PlayerSplitCount = 5 Then
                LblStatus.Text = LblStatus.Text & "Second hand win" & Chr(13) & Chr(10)
                EndSplitHands()
            ElseIf PlayerSplitSoftSum = 21 Or PlayerSplitSum = 21 Then ' Automatically stands if player reaches 21
                CmdStand.PerformClick()
            End If
        End If
    End Sub

    Sub DealToSplit()
        DealOneCard(PlayerSplitCards, PlayerSplitCount, PlayerSplitSum, PlayerSplitSoftSum)
        DisplayCard(TxtSplit1, PlayerSplitCards(1))
        DisplayCard(TxtSplit2, PlayerSplitCards(2))
        DisplayCard(TxtSplit3, PlayerSplitCards(3))
        DisplayCard(TxtSplit4, PlayerSplitCards(4))
        DisplayCard(TxtSplit5, PlayerSplitCards(5))
    End Sub

    Sub ScoreCalc(ByRef score As Integer, ByVal softsum As Integer, ByVal sum As Integer)
        If softsum > 21 Or (sum > 21 And softsum = 0) Then ' If busted Then
            score = 0
        ElseIf sum > 21 And softsum <> 0 Then ' ElseIf sum busted but player has an ace and softsum not busted Then
            score = softsum
        Else
            score = sum
        End If
    End Sub

    Sub EndSplitHands()

        If Split1Busted And Split2Busted Then
            EnableDeal()
            Return
        End If

        DealerAlgo()

        '/***********************************************************/

        Dim score1 As Integer, score2 As Integer, dealerscore As Integer

        ScoreCalc(score1, PlayerCardSoftSum, PlayerCardSum)
        ScoreCalc(score2, PlayerSplitSoftSum, PlayerSplitSum)
        ScoreCalc(dealerscore, DealerCardSoftSum, DealerCardSum)

        If score1 = 0 Then
            LblStatus.Text = "First hand busted" & Chr(13) & Chr(10)
        ElseIf score1 > dealerscore Or (score1 <> 0 And PlayerCardCount = 5) Then
            LblStatus.Text = "First hand win" & Chr(13) & Chr(10)
            TxtTotal.Text = CStr(Val(TxtTotal.Text) + 2 * Val(TxtBet.Text))
        ElseIf score1 = dealerscore Then
            LblStatus.Text = "First hand push" & Chr(13) & Chr(10)
            TxtTotal.Text = CStr(Val(TxtTotal.Text) + Val(TxtBet.Text))
        Else
            LblStatus.Text = "First hand lose" & Chr(13) & Chr(10)
        End If

        If score2 = 0 Then
            LblStatus.Text = LblStatus.Text & "Second hand busted" & Chr(13) & Chr(10)
        ElseIf score2 > dealerscore Or (score2 <> 0 And PlayerSplitCount = 5) Then
            LblStatus.Text = LblStatus.Text & "Second hand win" & Chr(13) & Chr(10)
            TxtTotal.Text = CStr(Val(TxtTotal.Text) + 2 * Val(TxtBet.Text))
        ElseIf score2 = dealerscore Then
            LblStatus.Text = LblStatus.Text & "Second hand push" & Chr(13) & Chr(10)
            TxtTotal.Text = CStr(Val(TxtTotal.Text) + Val(TxtBet.Text))
        Else
            LblStatus.Text = LblStatus.Text & "Second hand lose" & Chr(13) & Chr(10)
        End If

        If dealerscore = 0 Then
            LblStatus.Text = LblStatus.Text & "Dealer Busted" & Chr(13) & Chr(10)
        End If

        '/*********************************************************/

        EnableDeal()
    End Sub

    Sub DealerAlgo()
        DisplayCard(TxtDealerCard1, DealerCards(1)) ' Show the hole card
        While ((DealerCardSum < 17 And DealerCardSoftSum = 0) Or (DealerCardSoftSum < 17 And DealerCardSoftSum <> 0)) And DealerCardCount < 5 'While dealer has not reached 17
            DealToDealer()
        End While
    End Sub

    Sub EnableDeal()
        CmdDeal.Show()
        TxtBet.ReadOnly = False
        CmdHit.Hide()
        CmdStand.Hide()
        CmdDoubleDown.Hide()
        CmdSplit.Hide()
    End Sub

    Private Sub CmdStand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdStand.Click
        If SplitStatus = 1 Then ' If player splitted and is playing first hand Then
            SplitStatus = 2 ' Starts player on second hand
            CmdHit.Show()
            CmdStand.Show()
            CmdDoubleDown.Hide()
            LblStatus.Text = "Second hand (top)"

        ElseIf SplitStatus = 2 Then ' ElseIf player splitted and is playing second hand Then
            EndSplitHands()

        Else ' player did not split
            DealerAlgo()

            '/*************************************************************************/

            Dim PlayerScore As Integer = 0, DealerScore As Integer = 0
            If DealerCardSum > 21 And (DealerCardSoftSum > 21 Or DealerCardSoftSum = 0) Then
                LblStatus.Text = "Dealer busted"
                TxtTotal.Text = CStr(Val(TxtTotal.Text) + 2 * Val(TxtBet.Text))
                EnableDeal()
                Return
            ElseIf DealerCardSum > 21 And DealerCardSoftSum <> 0 Then
                DealerScore = DealerCardSoftSum
            Else
                DealerScore = DealerCardSum
            End If

            If PlayerCardSum > 21 Then PlayerScore = PlayerCardSoftSum Else PlayerScore = PlayerCardSum

            If PlayerScore > DealerScore Then
                LblStatus.Text = "You win"
                TxtTotal.Text = CStr(Val(TxtTotal.Text) + 2 * Val(TxtBet.Text))
                EnableDeal()
            ElseIf PlayerScore = DealerScore Then
                LblStatus.Text = "Push"
                TxtTotal.Text = CStr(Val(TxtTotal.Text) + Val(TxtBet.Text))
                EnableDeal()
            Else
                LblStatus.Text = "You lose"
                EnableDeal()
            End If

            '/*************************************************************************/

        End If
    End Sub

    Private Sub CmdDoubleDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdDoubleDown.Click
        CmdDoubleDown.Hide()


        Dim SecondBet As String
        SecondBet = InputBox("Enter second bet value:")
        While Val(SecondBet) > Val(TxtBet.Text) Or Val(SecondBet) > Val(TxtTotal.Text) Or SecondBet = "" Or Not IsNumeric(SecondBet) Or Int(Val(SecondBet)) <= 0
            If Val(SecondBet) > Val(TxtBet.Text) Or Val(SecondBet) > Val(TxtTotal.Text) Then
                SecondBet = InputBox("Second bet too large, please enter another value:")
            Else
                SecondBet = InputBox("Please enter a correct numerical positive integral value:")
            End If
        End While
        SecondBet = CStr(Int(Val(SecondBet)))
        TxtTotal.Text = CStr(Val(TxtTotal.Text) - Val(SecondBet))


        DealToPlayer()

        If PlayerCardSoftSum > 21 Or (PlayerCardSum > 21 And PlayerCardSoftSum = 0) Then
            LblStatus.Text = "You busted"
            EnableDeal()
            Return
        End If

        DealerAlgo()

        '/*******************************************************************************/

        Dim PlayerScore As Integer = 0, DealerScore As Integer = 0
        If DealerCardSum > 21 And (DealerCardSoftSum > 21 Or DealerCardSoftSum = 0) Then
            LblStatus.Text = "Dealer busted"
            TxtTotal.Text = CStr(Val(TxtTotal.Text) + 2 * Val(TxtBet.Text) + 2 * Val(SecondBet))
            EnableDeal()
            Return
        ElseIf DealerCardSum > 21 And DealerCardSoftSum <> 0 Then
            DealerScore = DealerCardSoftSum
        Else
            DealerScore = DealerCardSum
        End If

        If PlayerCardSum > 21 Then PlayerScore = PlayerCardSoftSum Else PlayerScore = PlayerCardSum

        If PlayerScore > DealerScore Then
            LblStatus.Text = "You win"
            TxtTotal.Text = CStr(Val(TxtTotal.Text) + 2 * Val(TxtBet.Text) + 2 * Val(SecondBet))
            EnableDeal()
        ElseIf PlayerScore = DealerScore Then
            LblStatus.Text = "Push"
            TxtTotal.Text = CStr(Val(TxtTotal.Text) + Val(TxtBet.Text) + Val(SecondBet))
            EnableDeal()
        Else
            LblStatus.Text = "You lose"
            EnableDeal()
        End If

        '/********************************************************************************/

    End Sub

    Private Sub CmdSplit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSplit.Click
        CmdSplit.Hide()
        TxtSplit1.Text = TxtPlayerCard2.Text
        TxtSplit1.Visible = True
        TxtPlayerCard2.Text = ""
        TxtPlayerCard2.Visible = False

        LblStatus.Text = "first hand (bottom)"
        SplitStatus = 1 ' Starts the player on split on first hand

        '''''BEGIN set counters'''''
        PlayerCardSum = PlayerCardSum / 2
        PlayerCardSoftSum = PlayerCardSoftSum / 2
        PlayerSplitSum = PlayerCardSum
        PlayerSplitSoftSum = PlayerCardSoftSum
        PlayerCardCount = 1
        PlayerSplitCount = 1
        PlayerSplitCards(1) = PlayerCards(2)
        PlayerCards(2) = 0
        '''''END set counters'''''

        DealToPlayer()
        DealToSplit()
        CmdStand.Show()
        CmdHit.Show()
        CmdDoubleDown.Hide()
    End Sub

    Private Sub CmdRules_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdRules.Click
        '''''Open a new form with the rules on it'''''
        Dim rules As New Rules ' Declare the new form
        rules.Show() ' Show the new form
    End Sub

End Class
