'/**********************************************************************************
' * Blackjack                                                                      *
' * Copyright 2013 Adrian Lam                                                      *
' * Last edited 22/11/2013                                                         *
' * Version: beta                                                                  *
' **********************************************************************************
' * This file is a documentation of Blackjack                                      *
' *                                                                                *
' * Permission is granted to copy, distribute and/or modify this document          *
' * under the terms of the GNU Free Documentation License, Version 1.3             *
' * or any later version published by the Free Software Foundation;                *
' * with no Invariant Sections, no Front-Cover Texts, and no Back-Cover Texts.     *
' * A copy of the license is included in the file entitled "GNU Free               *
' * Documentation License".                                                        *
' *                                                                                *
' **********************************************************************************/

Public Class Rules
    Private Sub Rules_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TxtRules.Text = _
    "Blackjack" & Chr(13) & Chr(10) & _
    "In this game, you start with 100 non-divisible monetary units, and you must place a valid bet before the game starts" & Chr(13) & Chr(10) & _
    "This game follows all typical single-deck Blackjack rules with the following variations:" & Chr(13) & Chr(10) & _
    "    1. Your hand is automatically won if it has 5 cards and is not busted. The dealer stands if his hand has 5 cards and is not busted" & Chr(13) & Chr(10) & _
    "    2. H17 - The dealer must hit on soft 17 (when the hand can either be 7 or 17). Variation 1 overrides this variation." & Chr(13) & Chr(10) & _
    "    3. Split to 2 - You can only split once." & Chr(13) & Chr(10) & _
    "    4. Blackjack pays 3:2" & Chr(13) & Chr(10) & _
    "    5. Insurance pays 1:2" & Chr(13) & Chr(10) & _
    Chr(13) & Chr(10) & "---------------------------------------------------------------" & Chr(13) & Chr(10) & _
    "The detailed rules of Blackjack are as follows: [1]" & Chr(13) & Chr(10) & _
    Chr(13) & Chr(10) & "You are dealt an initial hand of two cards. The dealer's hand receives its first card face up, and immediately receives its second card face down (the hole card), which the dealer peeks at but does not reveal unless it makes the dealer's hand a blackjack." & Chr(13) & Chr(10) & _
    Chr(13) & Chr(10) & "Your object is to win money by creating card totals that turn out to be higher than the dealer's hand but do not exceed 21 (''busting''/''breaking''), or alternatively by allowing the dealer to take additional cards until she busts. On your turn, you must choose whether to ''hit'' (take a card), ''stand'' (end your turn), ''double'' (double wager, take a single card and finish) or ''split'' (if the two cards have the same value, separate them to make two hands). Number cards count as their natural value; the jack, queen, and king (also known as ''face cards'' or ''pictures'') count as 10; aces are valued as either 1 or 11 according to the player's choice. If the hand value exceeds 21 points, it busts, and all bets on it are immediately forfeit." & Chr(13) & Chr(10) & _
    Chr(13) & Chr(10) & "After you have finished playing, the dealer's hand is resolved by drawing cards until the hand busts or achieves a value of 17 or higher (a dealer total of 17 including an ace, or ''soft 17'', must be drawn to). The dealer never doubles or splits. If the dealer busts, you win. If the dealer does not bust, each remaining bet wins if its hand is higher than the dealer's, and loses if it is lower. In the case of a tied score, known as ''push'' or ''standoff'', bets are normally returned without adjustment; however, a blackjack beats any hand that is not a blackjack, even one with a value of 21. An outcome of blackjack vs. blackjack results in a push. Wins are paid out at 1:1, or equal to the wager, except for winning blackjacks, which are paid at 3:2 (meaning you receive three dollars for every two bet), or one-and-a-half times the wager." & Chr(13) & Chr(10) & _
    Chr(13) & Chr(10) & "***Player decisions***" & Chr(13) & Chr(10) & _
    "After receiving an initial two cards, the player has up to four standard options: ''hit'', ''stand'', ''double down'', or ''split''. " & Chr(13) & Chr(10) & _
    "- Hit: Take another card from the dealer." & Chr(13) & Chr(10) & _
    "- Stand: Take no more cards, also known as ''stand pat'', ''stick'', or ''stay''." & Chr(13) & Chr(10) & _
    "- Double down (only available as the first decision of a hand): You are allowed to increase the initial bet by up to 100% in exchange for committing to stand after receiving exactly one more card." & Chr(13) & Chr(10) & _
    "- Split (only available as the first decision of a hand): If the first two cards have the same value, you can split them into two hands. The dealer separates the two cards and draws an additional card on each, placing one bet with each hand. You then play out the two separate hands in turn, with some restrictions. In the case of ten-valued cards, splitting is allowed only when the cards have the identical ranks; for instance, a hand of 10-10 may be split, but not one of 10-king. Doubling and further splitting of post-split hands is not allowed, and blackjacks after a split are counted as non-blackjack 21 when comparing against the dealer's hand." & Chr(13) & Chr(10) & _
    Chr(13) & Chr(10) & "On reaching 21 (including soft 21), the hand is required to stand. When the last hand has finished being played, the dealer reveals the hole card, and stands or draws further cards according to the rules of the game for dealer drawing. When the outcome of the dealer's hand is established, any hands with bets remaining on the table are resolved: bets on losing hands are forfeited, the bet on a push is left on the table, and winners are paid out." & Chr(13) & Chr(10) & _
    Chr(13) & Chr(10) & "***Insurance***" & Chr(13) & Chr(10) & _
    "If the dealer's upcard is an ace, you are offered the option of taking ''insurance'' before the dealer checks the hole card." & Chr(13) & Chr(10) & _
    "Insurance is a side bet that the dealer has blackjack and is treated independently of the main wager. It pays 2:1 (meaning that the player receives two dollars for every dollar bet) and is available when the dealer's exposed card is an ace. The idea is that the dealer's second card has a fairly high probability (nearly one-third) to be ten-valued, giving the dealer blackjack and disappointment for the player. It is attractive (although not necessarily wise) for the player to insure against the possibility of a dealer blackjack by making a maximum ''insurance'' bet, in which case the ''insurance proceeds'' will make up for the concomitant loss on the original bet. The player may add up to half the value of their original bet to the insurance and these extra chips are placed on a portion of the table usually marked ''Insurance pays 2 to 1''." & Chr(13) & Chr(10) & _
    "Players with a blackjack may also take insurance." & Chr(13) & Chr(10) & _
    Chr(13) & Chr(10) & _
    "[1]: Copied with modification from Blackjack, article from Wikipedia, the Free Encyclopedia. The article can be found here: http://en.wikipedia.org/wiki/Blackjack . This text is used under the GNU Free Documentation License." & Chr(13) & Chr(10) & Chr(13) & Chr(10) & _
    "This documentation is released under the GNU Free Documentation License." & Chr(13) & Chr(10) & _
    "Permission is granted to copy, distribute and/or modify this document under the terms of the GNU Free Documentation License, Version 1.3 or any later version published by the Free Software Foundation; with no Invariant Sections, no Front-Cover Texts, and no Back-Cover Texts. A copy of the license is included in the file entitled ''GNU Free Documentation License''."

        TxtRules.Select(0, 0)
    End Sub
End Class