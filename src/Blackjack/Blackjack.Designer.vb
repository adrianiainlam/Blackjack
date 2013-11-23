<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Blackjack
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CmdHit = New System.Windows.Forms.Button()
        Me.CmdDeal = New System.Windows.Forms.Button()
        Me.CmdSplit = New System.Windows.Forms.Button()
        Me.CmdDoubleDown = New System.Windows.Forms.Button()
        Me.CmdStand = New System.Windows.Forms.Button()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.LblBet = New System.Windows.Forms.Label()
        Me.TxtBet = New System.Windows.Forms.TextBox()
        Me.TxtPlayerCard1 = New System.Windows.Forms.TextBox()
        Me.TxtPlayerCard2 = New System.Windows.Forms.TextBox()
        Me.TxtPlayerCard3 = New System.Windows.Forms.TextBox()
        Me.TxtPlayerCard4 = New System.Windows.Forms.TextBox()
        Me.TxtPlayerCard5 = New System.Windows.Forms.TextBox()
        Me.LblYou = New System.Windows.Forms.Label()
        Me.LblStatus = New System.Windows.Forms.Label()
        Me.LblDesc1 = New System.Windows.Forms.Label()
        Me.LblDesc2 = New System.Windows.Forms.Label()
        Me.LblDesc3 = New System.Windows.Forms.Label()
        Me.LblDealer = New System.Windows.Forms.Label()
        Me.TxtSplit5 = New System.Windows.Forms.TextBox()
        Me.TxtSplit4 = New System.Windows.Forms.TextBox()
        Me.TxtSplit3 = New System.Windows.Forms.TextBox()
        Me.TxtSplit2 = New System.Windows.Forms.TextBox()
        Me.TxtSplit1 = New System.Windows.Forms.TextBox()
        Me.TxtDealerCard5 = New System.Windows.Forms.TextBox()
        Me.TxtDealerCard4 = New System.Windows.Forms.TextBox()
        Me.TxtDealerCard3 = New System.Windows.Forms.TextBox()
        Me.TxtDealerCard2 = New System.Windows.Forms.TextBox()
        Me.TxtDealerCard1 = New System.Windows.Forms.TextBox()
        Me.LblDesc4 = New System.Windows.Forms.Label()
        Me.CmdRules = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CmdHit
        '
        Me.CmdHit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdHit.Location = New System.Drawing.Point(28, 497)
        Me.CmdHit.Name = "CmdHit"
        Me.CmdHit.Size = New System.Drawing.Size(97, 42)
        Me.CmdHit.TabIndex = 0
        Me.CmdHit.Text = "Hit"
        Me.CmdHit.UseVisualStyleBackColor = True
        '
        'CmdDeal
        '
        Me.CmdDeal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdDeal.Location = New System.Drawing.Point(440, 497)
        Me.CmdDeal.Name = "CmdDeal"
        Me.CmdDeal.Size = New System.Drawing.Size(97, 42)
        Me.CmdDeal.TabIndex = 1
        Me.CmdDeal.Text = "Deal"
        Me.CmdDeal.UseVisualStyleBackColor = True
        '
        'CmdSplit
        '
        Me.CmdSplit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdSplit.Location = New System.Drawing.Point(337, 497)
        Me.CmdSplit.Name = "CmdSplit"
        Me.CmdSplit.Size = New System.Drawing.Size(97, 42)
        Me.CmdSplit.TabIndex = 2
        Me.CmdSplit.Text = "Split"
        Me.CmdSplit.UseVisualStyleBackColor = True
        '
        'CmdDoubleDown
        '
        Me.CmdDoubleDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdDoubleDown.Location = New System.Drawing.Point(234, 497)
        Me.CmdDoubleDown.Name = "CmdDoubleDown"
        Me.CmdDoubleDown.Size = New System.Drawing.Size(97, 42)
        Me.CmdDoubleDown.TabIndex = 3
        Me.CmdDoubleDown.Text = "Double Down"
        Me.CmdDoubleDown.UseVisualStyleBackColor = True
        '
        'CmdStand
        '
        Me.CmdStand.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdStand.Location = New System.Drawing.Point(131, 497)
        Me.CmdStand.Name = "CmdStand"
        Me.CmdStand.Size = New System.Drawing.Size(97, 42)
        Me.CmdStand.TabIndex = 4
        Me.CmdStand.Text = "Stand"
        Me.CmdStand.UseVisualStyleBackColor = True
        '
        'TxtTotal
        '
        Me.TxtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotal.Location = New System.Drawing.Point(660, 460)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.ReadOnly = True
        Me.TxtTotal.Size = New System.Drawing.Size(136, 26)
        Me.TxtTotal.TabIndex = 5
        Me.TxtTotal.Text = "100"
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotal.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LblTotal.Location = New System.Drawing.Point(556, 460)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(98, 20)
        Me.LblTotal.TabIndex = 6
        Me.LblTotal.Text = "Your money:"
        '
        'LblBet
        '
        Me.LblBet.AutoSize = True
        Me.LblBet.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBet.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LblBet.Location = New System.Drawing.Point(575, 492)
        Me.LblBet.Name = "LblBet"
        Me.LblBet.Size = New System.Drawing.Size(79, 20)
        Me.LblBet.TabIndex = 7
        Me.LblBet.Text = "Enter bet:"
        '
        'TxtBet
        '
        Me.TxtBet.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBet.Location = New System.Drawing.Point(660, 494)
        Me.TxtBet.Name = "TxtBet"
        Me.TxtBet.Size = New System.Drawing.Size(136, 26)
        Me.TxtBet.TabIndex = 8
        '
        'TxtPlayerCard1
        '
        Me.TxtPlayerCard1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtPlayerCard1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPlayerCard1.Location = New System.Drawing.Point(30, 342)
        Me.TxtPlayerCard1.Multiline = True
        Me.TxtPlayerCard1.Name = "TxtPlayerCard1"
        Me.TxtPlayerCard1.ReadOnly = True
        Me.TxtPlayerCard1.Size = New System.Drawing.Size(94, 125)
        Me.TxtPlayerCard1.TabIndex = 9
        Me.TxtPlayerCard1.Visible = False
        Me.TxtPlayerCard1.WordWrap = False
        '
        'TxtPlayerCard2
        '
        Me.TxtPlayerCard2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtPlayerCard2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPlayerCard2.Location = New System.Drawing.Point(134, 342)
        Me.TxtPlayerCard2.Multiline = True
        Me.TxtPlayerCard2.Name = "TxtPlayerCard2"
        Me.TxtPlayerCard2.ReadOnly = True
        Me.TxtPlayerCard2.Size = New System.Drawing.Size(94, 125)
        Me.TxtPlayerCard2.TabIndex = 10
        Me.TxtPlayerCard2.Visible = False
        Me.TxtPlayerCard2.WordWrap = False
        '
        'TxtPlayerCard3
        '
        Me.TxtPlayerCard3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtPlayerCard3.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPlayerCard3.Location = New System.Drawing.Point(237, 342)
        Me.TxtPlayerCard3.Multiline = True
        Me.TxtPlayerCard3.Name = "TxtPlayerCard3"
        Me.TxtPlayerCard3.ReadOnly = True
        Me.TxtPlayerCard3.Size = New System.Drawing.Size(94, 125)
        Me.TxtPlayerCard3.TabIndex = 11
        Me.TxtPlayerCard3.Visible = False
        Me.TxtPlayerCard3.WordWrap = False
        '
        'TxtPlayerCard4
        '
        Me.TxtPlayerCard4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtPlayerCard4.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPlayerCard4.Location = New System.Drawing.Point(340, 342)
        Me.TxtPlayerCard4.Multiline = True
        Me.TxtPlayerCard4.Name = "TxtPlayerCard4"
        Me.TxtPlayerCard4.ReadOnly = True
        Me.TxtPlayerCard4.Size = New System.Drawing.Size(94, 125)
        Me.TxtPlayerCard4.TabIndex = 12
        Me.TxtPlayerCard4.Visible = False
        Me.TxtPlayerCard4.WordWrap = False
        '
        'TxtPlayerCard5
        '
        Me.TxtPlayerCard5.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtPlayerCard5.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPlayerCard5.Location = New System.Drawing.Point(443, 342)
        Me.TxtPlayerCard5.Multiline = True
        Me.TxtPlayerCard5.Name = "TxtPlayerCard5"
        Me.TxtPlayerCard5.ReadOnly = True
        Me.TxtPlayerCard5.Size = New System.Drawing.Size(94, 125)
        Me.TxtPlayerCard5.TabIndex = 13
        Me.TxtPlayerCard5.Visible = False
        Me.TxtPlayerCard5.WordWrap = False
        '
        'LblYou
        '
        Me.LblYou.AutoSize = True
        Me.LblYou.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblYou.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LblYou.Location = New System.Drawing.Point(592, 384)
        Me.LblYou.Name = "LblYou"
        Me.LblYou.Size = New System.Drawing.Size(87, 37)
        Me.LblYou.TabIndex = 14
        Me.LblYou.Text = "YOU"
        '
        'LblStatus
        '
        Me.LblStatus.AutoSize = True
        Me.LblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStatus.ForeColor = System.Drawing.Color.Cyan
        Me.LblStatus.Location = New System.Drawing.Point(574, 281)
        Me.LblStatus.Name = "LblStatus"
        Me.LblStatus.Size = New System.Drawing.Size(147, 25)
        Me.LblStatus.TabIndex = 15
        Me.LblStatus.Text = "Current status"
        '
        'LblDesc1
        '
        Me.LblDesc1.AutoSize = True
        Me.LblDesc1.Font = New System.Drawing.Font("Old English Text MT", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDesc1.Location = New System.Drawing.Point(50, 204)
        Me.LblDesc1.Name = "LblDesc1"
        Me.LblDesc1.Size = New System.Drawing.Size(469, 77)
        Me.LblDesc1.TabIndex = 16
        Me.LblDesc1.Text = "BLACKJACK"
        '
        'LblDesc2
        '
        Me.LblDesc2.AutoSize = True
        Me.LblDesc2.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDesc2.Location = New System.Drawing.Point(81, 281)
        Me.LblDesc2.Name = "LblDesc2"
        Me.LblDesc2.Size = New System.Drawing.Size(394, 21)
        Me.LblDesc2.TabIndex = 17
        Me.LblDesc2.Text = "H17            Split to 2         No double after split"
        '
        'LblDesc3
        '
        Me.LblDesc3.AutoSize = True
        Me.LblDesc3.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDesc3.Location = New System.Drawing.Point(88, 305)
        Me.LblDesc3.Name = "LblDesc3"
        Me.LblDesc3.Size = New System.Drawing.Size(395, 21)
        Me.LblDesc3.TabIndex = 18
        Me.LblDesc3.Text = "Blackjack pays 3:2               Insurance pays 2:1"
        '
        'LblDealer
        '
        Me.LblDealer.AutoSize = True
        Me.LblDealer.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDealer.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LblDealer.Location = New System.Drawing.Point(592, 68)
        Me.LblDealer.Name = "LblDealer"
        Me.LblDealer.Size = New System.Drawing.Size(144, 37)
        Me.LblDealer.TabIndex = 19
        Me.LblDealer.Text = "DEALER"
        '
        'TxtSplit5
        '
        Me.TxtSplit5.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtSplit5.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSplit5.Location = New System.Drawing.Point(444, 209)
        Me.TxtSplit5.Multiline = True
        Me.TxtSplit5.Name = "TxtSplit5"
        Me.TxtSplit5.ReadOnly = True
        Me.TxtSplit5.Size = New System.Drawing.Size(94, 125)
        Me.TxtSplit5.TabIndex = 24
        Me.TxtSplit5.Visible = False
        Me.TxtSplit5.WordWrap = False
        '
        'TxtSplit4
        '
        Me.TxtSplit4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtSplit4.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSplit4.Location = New System.Drawing.Point(341, 209)
        Me.TxtSplit4.Multiline = True
        Me.TxtSplit4.Name = "TxtSplit4"
        Me.TxtSplit4.ReadOnly = True
        Me.TxtSplit4.Size = New System.Drawing.Size(94, 125)
        Me.TxtSplit4.TabIndex = 23
        Me.TxtSplit4.Visible = False
        Me.TxtSplit4.WordWrap = False
        '
        'TxtSplit3
        '
        Me.TxtSplit3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtSplit3.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSplit3.Location = New System.Drawing.Point(238, 209)
        Me.TxtSplit3.Multiline = True
        Me.TxtSplit3.Name = "TxtSplit3"
        Me.TxtSplit3.ReadOnly = True
        Me.TxtSplit3.Size = New System.Drawing.Size(94, 125)
        Me.TxtSplit3.TabIndex = 22
        Me.TxtSplit3.Visible = False
        Me.TxtSplit3.WordWrap = False
        '
        'TxtSplit2
        '
        Me.TxtSplit2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtSplit2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSplit2.Location = New System.Drawing.Point(135, 209)
        Me.TxtSplit2.Multiline = True
        Me.TxtSplit2.Name = "TxtSplit2"
        Me.TxtSplit2.ReadOnly = True
        Me.TxtSplit2.Size = New System.Drawing.Size(94, 125)
        Me.TxtSplit2.TabIndex = 21
        Me.TxtSplit2.Visible = False
        Me.TxtSplit2.WordWrap = False
        '
        'TxtSplit1
        '
        Me.TxtSplit1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtSplit1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSplit1.Location = New System.Drawing.Point(31, 209)
        Me.TxtSplit1.Multiline = True
        Me.TxtSplit1.Name = "TxtSplit1"
        Me.TxtSplit1.ReadOnly = True
        Me.TxtSplit1.Size = New System.Drawing.Size(94, 125)
        Me.TxtSplit1.TabIndex = 20
        Me.TxtSplit1.Visible = False
        Me.TxtSplit1.WordWrap = False
        '
        'TxtDealerCard5
        '
        Me.TxtDealerCard5.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtDealerCard5.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDealerCard5.Location = New System.Drawing.Point(444, 30)
        Me.TxtDealerCard5.Multiline = True
        Me.TxtDealerCard5.Name = "TxtDealerCard5"
        Me.TxtDealerCard5.ReadOnly = True
        Me.TxtDealerCard5.Size = New System.Drawing.Size(94, 125)
        Me.TxtDealerCard5.TabIndex = 29
        Me.TxtDealerCard5.Visible = False
        Me.TxtDealerCard5.WordWrap = False
        '
        'TxtDealerCard4
        '
        Me.TxtDealerCard4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtDealerCard4.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDealerCard4.Location = New System.Drawing.Point(341, 30)
        Me.TxtDealerCard4.Multiline = True
        Me.TxtDealerCard4.Name = "TxtDealerCard4"
        Me.TxtDealerCard4.ReadOnly = True
        Me.TxtDealerCard4.Size = New System.Drawing.Size(94, 125)
        Me.TxtDealerCard4.TabIndex = 28
        Me.TxtDealerCard4.Visible = False
        Me.TxtDealerCard4.WordWrap = False
        '
        'TxtDealerCard3
        '
        Me.TxtDealerCard3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtDealerCard3.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDealerCard3.Location = New System.Drawing.Point(238, 30)
        Me.TxtDealerCard3.Multiline = True
        Me.TxtDealerCard3.Name = "TxtDealerCard3"
        Me.TxtDealerCard3.ReadOnly = True
        Me.TxtDealerCard3.Size = New System.Drawing.Size(94, 125)
        Me.TxtDealerCard3.TabIndex = 27
        Me.TxtDealerCard3.Visible = False
        Me.TxtDealerCard3.WordWrap = False
        '
        'TxtDealerCard2
        '
        Me.TxtDealerCard2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtDealerCard2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDealerCard2.Location = New System.Drawing.Point(135, 30)
        Me.TxtDealerCard2.Multiline = True
        Me.TxtDealerCard2.Name = "TxtDealerCard2"
        Me.TxtDealerCard2.ReadOnly = True
        Me.TxtDealerCard2.Size = New System.Drawing.Size(94, 125)
        Me.TxtDealerCard2.TabIndex = 26
        Me.TxtDealerCard2.Visible = False
        Me.TxtDealerCard2.WordWrap = False
        '
        'TxtDealerCard1
        '
        Me.TxtDealerCard1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TxtDealerCard1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDealerCard1.Location = New System.Drawing.Point(31, 30)
        Me.TxtDealerCard1.Multiline = True
        Me.TxtDealerCard1.Name = "TxtDealerCard1"
        Me.TxtDealerCard1.ReadOnly = True
        Me.TxtDealerCard1.Size = New System.Drawing.Size(94, 125)
        Me.TxtDealerCard1.TabIndex = 25
        Me.TxtDealerCard1.Visible = False
        Me.TxtDealerCard1.WordWrap = False
        '
        'LblDesc4
        '
        Me.LblDesc4.AutoSize = True
        Me.LblDesc4.Location = New System.Drawing.Point(543, 521)
        Me.LblDesc4.Name = "LblDesc4"
        Me.LblDesc4.Size = New System.Drawing.Size(377, 13)
        Me.LblDesc4.TabIndex = 30
        Me.LblDesc4.Text = "Please enter an even number. Otherwise your winnings may be rounded down."
        '
        'CmdRules
        '
        Me.CmdRules.Location = New System.Drawing.Point(812, 460)
        Me.CmdRules.Name = "CmdRules"
        Me.CmdRules.Size = New System.Drawing.Size(68, 56)
        Me.CmdRules.TabIndex = 31
        Me.CmdRules.Text = "Rules (Help)"
        Me.CmdRules.UseVisualStyleBackColor = True
        '
        'Blackjack
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OliveDrab
        Me.ClientSize = New System.Drawing.Size(918, 545)
        Me.Controls.Add(Me.CmdRules)
        Me.Controls.Add(Me.LblDesc4)
        Me.Controls.Add(Me.TxtDealerCard5)
        Me.Controls.Add(Me.TxtDealerCard4)
        Me.Controls.Add(Me.TxtDealerCard3)
        Me.Controls.Add(Me.TxtDealerCard2)
        Me.Controls.Add(Me.TxtDealerCard1)
        Me.Controls.Add(Me.TxtSplit5)
        Me.Controls.Add(Me.TxtSplit4)
        Me.Controls.Add(Me.TxtSplit3)
        Me.Controls.Add(Me.TxtSplit2)
        Me.Controls.Add(Me.TxtSplit1)
        Me.Controls.Add(Me.LblDealer)
        Me.Controls.Add(Me.LblDesc3)
        Me.Controls.Add(Me.LblDesc2)
        Me.Controls.Add(Me.LblDesc1)
        Me.Controls.Add(Me.LblStatus)
        Me.Controls.Add(Me.LblYou)
        Me.Controls.Add(Me.TxtPlayerCard5)
        Me.Controls.Add(Me.TxtPlayerCard4)
        Me.Controls.Add(Me.TxtPlayerCard3)
        Me.Controls.Add(Me.TxtPlayerCard2)
        Me.Controls.Add(Me.TxtPlayerCard1)
        Me.Controls.Add(Me.TxtBet)
        Me.Controls.Add(Me.LblBet)
        Me.Controls.Add(Me.LblTotal)
        Me.Controls.Add(Me.TxtTotal)
        Me.Controls.Add(Me.CmdStand)
        Me.Controls.Add(Me.CmdDoubleDown)
        Me.Controls.Add(Me.CmdSplit)
        Me.Controls.Add(Me.CmdDeal)
        Me.Controls.Add(Me.CmdHit)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(934, 583)
        Me.MinimumSize = New System.Drawing.Size(934, 583)
        Me.Name = "Blackjack"
        Me.Text = "Blackjack"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CmdHit As System.Windows.Forms.Button
    Friend WithEvents CmdDeal As System.Windows.Forms.Button
    Friend WithEvents CmdSplit As System.Windows.Forms.Button
    Friend WithEvents CmdDoubleDown As System.Windows.Forms.Button
    Friend WithEvents CmdStand As System.Windows.Forms.Button
    Friend WithEvents TxtTotal As System.Windows.Forms.TextBox
    Friend WithEvents LblTotal As System.Windows.Forms.Label
    Friend WithEvents LblBet As System.Windows.Forms.Label
    Friend WithEvents TxtBet As System.Windows.Forms.TextBox
    Friend WithEvents TxtPlayerCard1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtPlayerCard2 As System.Windows.Forms.TextBox
    Friend WithEvents TxtPlayerCard3 As System.Windows.Forms.TextBox
    Friend WithEvents TxtPlayerCard4 As System.Windows.Forms.TextBox
    Friend WithEvents TxtPlayerCard5 As System.Windows.Forms.TextBox
    Friend WithEvents LblYou As System.Windows.Forms.Label
    Friend WithEvents LblStatus As System.Windows.Forms.Label
    Friend WithEvents LblDesc1 As System.Windows.Forms.Label
    Friend WithEvents LblDesc2 As System.Windows.Forms.Label
    Friend WithEvents LblDesc3 As System.Windows.Forms.Label
    Friend WithEvents LblDealer As System.Windows.Forms.Label
    Friend WithEvents TxtSplit5 As System.Windows.Forms.TextBox
    Friend WithEvents TxtSplit4 As System.Windows.Forms.TextBox
    Friend WithEvents TxtSplit3 As System.Windows.Forms.TextBox
    Friend WithEvents TxtSplit2 As System.Windows.Forms.TextBox
    Friend WithEvents TxtSplit1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtDealerCard5 As System.Windows.Forms.TextBox
    Friend WithEvents TxtDealerCard4 As System.Windows.Forms.TextBox
    Friend WithEvents TxtDealerCard3 As System.Windows.Forms.TextBox
    Friend WithEvents TxtDealerCard2 As System.Windows.Forms.TextBox
    Friend WithEvents TxtDealerCard1 As System.Windows.Forms.TextBox
    Friend WithEvents LblDesc4 As System.Windows.Forms.Label
    Friend WithEvents CmdRules As System.Windows.Forms.Button

End Class
