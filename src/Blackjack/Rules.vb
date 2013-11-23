'/**********************************************************************************
' * Blackjack                                                                      *
' * Copyright 2013 Adrian Lam                                                      *
' * Last edited 22/11/2013                                                         *
' * Version: beta                                                                  *
' **********************************************************************************
' * This file is part of Blackjack                                                 *
' *                                                                                *
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
' * along with this program; if not, see <http://www.gnu.org/licenses/>            *
' *                                                                                *
' **********************************************************************************/

Public Class Rules
    Private Sub Rules_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TxtRules.Text = "Rule number 1" & Chr(13) & Chr(10) & _
            "Rule number 2" & Chr(13) & Chr(10) & _
            "Lorem ipsum dolor sit amet" & Chr(13) & Chr(10)

        TxtRules.Select(0, 0)
    End Sub
End Class