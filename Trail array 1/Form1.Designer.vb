<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Options
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.cmBxBikeType = New System.Windows.Forms.ComboBox()
        Me.pcBxBikeTypes = New System.Windows.Forms.PictureBox()
        Me.lblBicycleType = New System.Windows.Forms.Label()
        Me.btnQuote = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblTitle1 = New System.Windows.Forms.Label()
        Me.cmBxFrameType = New System.Windows.Forms.ComboBox()
        Me.lblFrameType = New System.Windows.Forms.Label()
        Me.cmBxBrakeType = New System.Windows.Forms.ComboBox()
        Me.pcBxFrameType = New System.Windows.Forms.PictureBox()
        Me.pcBxBrakeType = New System.Windows.Forms.PictureBox()
        Me.lblBrakeType = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTitle2 = New System.Windows.Forms.Label()
        Me.chBxHelmet = New System.Windows.Forms.CheckBox()
        Me.pcBxHelmet = New System.Windows.Forms.PictureBox()
        Me.chBxPedals = New System.Windows.Forms.CheckBox()
        Me.pcBxPedals = New System.Windows.Forms.PictureBox()
        Me.pcBxLock = New System.Windows.Forms.PictureBox()
        Me.chBxLock = New System.Windows.Forms.CheckBox()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.btnPurchase = New System.Windows.Forms.Button()
        Me.lblEnsure = New System.Windows.Forms.Label()
        CType(Me.pcBxBikeTypes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcBxFrameType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcBxBrakeType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcBxHelmet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcBxPedals, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcBxLock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmBxBikeType
        '
        Me.cmBxBikeType.FormattingEnabled = True
        Me.cmBxBikeType.Location = New System.Drawing.Point(55, 80)
        Me.cmBxBikeType.Name = "cmBxBikeType"
        Me.cmBxBikeType.Size = New System.Drawing.Size(153, 21)
        Me.cmBxBikeType.TabIndex = 0
        Me.cmBxBikeType.Text = "Choose Bicycle Type here"
        '
        'pcBxBikeTypes
        '
        Me.pcBxBikeTypes.Location = New System.Drawing.Point(275, 80)
        Me.pcBxBikeTypes.Name = "pcBxBikeTypes"
        Me.pcBxBikeTypes.Size = New System.Drawing.Size(174, 115)
        Me.pcBxBikeTypes.TabIndex = 1
        Me.pcBxBikeTypes.TabStop = False
        '
        'lblBicycleType
        '
        Me.lblBicycleType.AutoSize = True
        Me.lblBicycleType.Location = New System.Drawing.Point(272, 198)
        Me.lblBicycleType.Name = "lblBicycleType"
        Me.lblBicycleType.Size = New System.Drawing.Size(171, 13)
        Me.lblBicycleType.TabIndex = 2
        Me.lblBicycleType.Text = "Bicycle Type will be displayed here"
        '
        'btnQuote
        '
        Me.btnQuote.ForeColor = System.Drawing.Color.DarkRed
        Me.btnQuote.Location = New System.Drawing.Point(526, 419)
        Me.btnQuote.Name = "btnQuote"
        Me.btnQuote.Size = New System.Drawing.Size(75, 23)
        Me.btnQuote.TabIndex = 3
        Me.btnQuote.Text = "Quote"
        Me.btnQuote.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(76, 13)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(230, 25)
        Me.lblTitle.TabIndex = 4
        Me.lblTitle.Text = "BRILLIANT BICYCLES"
        '
        'lblTitle1
        '
        Me.lblTitle1.AutoSize = True
        Me.lblTitle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle1.Location = New System.Drawing.Point(52, 49)
        Me.lblTitle1.Name = "lblTitle1"
        Me.lblTitle1.Size = New System.Drawing.Size(378, 16)
        Me.lblTitle1.TabIndex = 5
        Me.lblTitle1.Text = "Please select the specifications of your bicycle below"
        '
        'cmBxFrameType
        '
        Me.cmBxFrameType.FormattingEnabled = True
        Me.cmBxFrameType.Location = New System.Drawing.Point(55, 230)
        Me.cmBxFrameType.Name = "cmBxFrameType"
        Me.cmBxFrameType.Size = New System.Drawing.Size(153, 21)
        Me.cmBxFrameType.TabIndex = 6
        Me.cmBxFrameType.Text = "Choose Frame Type here"
        '
        'lblFrameType
        '
        Me.lblFrameType.AutoSize = True
        Me.lblFrameType.Location = New System.Drawing.Point(272, 348)
        Me.lblFrameType.Name = "lblFrameType"
        Me.lblFrameType.Size = New System.Drawing.Size(166, 13)
        Me.lblFrameType.TabIndex = 8
        Me.lblFrameType.Text = "Frame Type will be displayed here"
        '
        'cmBxBrakeType
        '
        Me.cmBxBrakeType.FormattingEnabled = True
        Me.cmBxBrakeType.Location = New System.Drawing.Point(55, 384)
        Me.cmBxBrakeType.Name = "cmBxBrakeType"
        Me.cmBxBrakeType.Size = New System.Drawing.Size(153, 21)
        Me.cmBxBrakeType.TabIndex = 9
        Me.cmBxBrakeType.Text = "Choose Brake Type here"
        '
        'pcBxFrameType
        '
        Me.pcBxFrameType.Location = New System.Drawing.Point(275, 230)
        Me.pcBxFrameType.Name = "pcBxFrameType"
        Me.pcBxFrameType.Size = New System.Drawing.Size(174, 115)
        Me.pcBxFrameType.TabIndex = 10
        Me.pcBxFrameType.TabStop = False
        '
        'pcBxBrakeType
        '
        Me.pcBxBrakeType.Location = New System.Drawing.Point(275, 384)
        Me.pcBxBrakeType.Name = "pcBxBrakeType"
        Me.pcBxBrakeType.Size = New System.Drawing.Size(174, 115)
        Me.pcBxBrakeType.TabIndex = 11
        Me.pcBxBrakeType.TabStop = False
        '
        'lblBrakeType
        '
        Me.lblBrakeType.AutoSize = True
        Me.lblBrakeType.Location = New System.Drawing.Point(272, 502)
        Me.lblBrakeType.Name = "lblBrakeType"
        Me.lblBrakeType.Size = New System.Drawing.Size(165, 13)
        Me.lblBrakeType.TabIndex = 12
        Me.lblBrakeType.Text = "Brake Type will be displayed here"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(601, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 13
        '
        'lblTitle2
        '
        Me.lblTitle2.AutoSize = True
        Me.lblTitle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle2.Location = New System.Drawing.Point(556, 59)
        Me.lblTitle2.Name = "lblTitle2"
        Me.lblTitle2.Size = New System.Drawing.Size(196, 16)
        Me.lblTitle2.TabIndex = 14
        Me.lblTitle2.Text = "Choose Accessories below"
        '
        'chBxHelmet
        '
        Me.chBxHelmet.AutoSize = True
        Me.chBxHelmet.Location = New System.Drawing.Point(541, 118)
        Me.chBxHelmet.Name = "chBxHelmet"
        Me.chBxHelmet.Size = New System.Drawing.Size(122, 17)
        Me.chBxHelmet.TabIndex = 15
        Me.chBxHelmet.Text = "MIPS bicycle helmet"
        Me.chBxHelmet.UseVisualStyleBackColor = True
        '
        'pcBxHelmet
        '
        Me.pcBxHelmet.Location = New System.Drawing.Point(669, 90)
        Me.pcBxHelmet.Name = "pcBxHelmet"
        Me.pcBxHelmet.Size = New System.Drawing.Size(130, 80)
        Me.pcBxHelmet.TabIndex = 16
        Me.pcBxHelmet.TabStop = False
        '
        'chBxPedals
        '
        Me.chBxPedals.AutoSize = True
        Me.chBxPedals.Location = New System.Drawing.Point(541, 230)
        Me.chBxPedals.Name = "chBxPedals"
        Me.chBxPedals.Size = New System.Drawing.Size(96, 17)
        Me.chBxPedals.TabIndex = 17
        Me.chBxPedals.Text = "Clipless Pedals"
        Me.chBxPedals.UseVisualStyleBackColor = True
        '
        'pcBxPedals
        '
        Me.pcBxPedals.Location = New System.Drawing.Point(669, 198)
        Me.pcBxPedals.Name = "pcBxPedals"
        Me.pcBxPedals.Size = New System.Drawing.Size(130, 80)
        Me.pcBxPedals.TabIndex = 18
        Me.pcBxPedals.TabStop = False
        '
        'pcBxLock
        '
        Me.pcBxLock.Location = New System.Drawing.Point(670, 311)
        Me.pcBxLock.Name = "pcBxLock"
        Me.pcBxLock.Size = New System.Drawing.Size(130, 80)
        Me.pcBxLock.TabIndex = 19
        Me.pcBxLock.TabStop = False
        '
        'chBxLock
        '
        Me.chBxLock.AutoSize = True
        Me.chBxLock.Location = New System.Drawing.Point(541, 345)
        Me.chBxLock.Name = "chBxLock"
        Me.chBxLock.Size = New System.Drawing.Size(61, 17)
        Me.chBxLock.TabIndex = 20
        Me.chBxLock.Text = "D Lock"
        Me.chBxLock.UseVisualStyleBackColor = True
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Location = New System.Drawing.Point(455, 445)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(246, 13)
        Me.lblOutput.TabIndex = 21
        Me.lblOutput.Text = "The total cost of your bicycle will be displayed here"
        '
        'btnPurchase
        '
        Me.btnPurchase.Enabled = False
        Me.btnPurchase.ForeColor = System.Drawing.Color.DarkRed
        Me.btnPurchase.Location = New System.Drawing.Point(527, 476)
        Me.btnPurchase.Name = "btnPurchase"
        Me.btnPurchase.Size = New System.Drawing.Size(75, 23)
        Me.btnPurchase.TabIndex = 22
        Me.btnPurchase.Text = "Purchase"
        Me.btnPurchase.UseVisualStyleBackColor = True
        '
        'lblEnsure
        '
        Me.lblEnsure.AutoSize = True
        Me.lblEnsure.ForeColor = System.Drawing.Color.White
        Me.lblEnsure.Location = New System.Drawing.Point(455, 403)
        Me.lblEnsure.Name = "lblEnsure"
        Me.lblEnsure.Size = New System.Drawing.Size(359, 13)
        Me.lblEnsure.TabIndex = 23
        Me.lblEnsure.Text = "Ensure to click Quote button after making any changes to selected options"
        '
        'Options
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(824, 529)
        Me.Controls.Add(Me.lblEnsure)
        Me.Controls.Add(Me.btnPurchase)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.chBxLock)
        Me.Controls.Add(Me.pcBxLock)
        Me.Controls.Add(Me.pcBxPedals)
        Me.Controls.Add(Me.chBxPedals)
        Me.Controls.Add(Me.pcBxHelmet)
        Me.Controls.Add(Me.chBxHelmet)
        Me.Controls.Add(Me.lblTitle2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblBrakeType)
        Me.Controls.Add(Me.pcBxBrakeType)
        Me.Controls.Add(Me.pcBxFrameType)
        Me.Controls.Add(Me.cmBxBrakeType)
        Me.Controls.Add(Me.lblFrameType)
        Me.Controls.Add(Me.cmBxFrameType)
        Me.Controls.Add(Me.lblTitle1)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnQuote)
        Me.Controls.Add(Me.lblBicycleType)
        Me.Controls.Add(Me.pcBxBikeTypes)
        Me.Controls.Add(Me.cmBxBikeType)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "Options"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Options"
        CType(Me.pcBxBikeTypes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcBxFrameType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcBxBrakeType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcBxHelmet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcBxPedals, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcBxLock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmBxBikeType As ComboBox
    Friend WithEvents pcBxBikeTypes As PictureBox
    Friend WithEvents lblBicycleType As Label
    Friend WithEvents btnQuote As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblTitle1 As Label
    Friend WithEvents cmBxFrameType As ComboBox
    Friend WithEvents lblFrameType As Label
    Friend WithEvents cmBxBrakeType As ComboBox
    Friend WithEvents pcBxFrameType As PictureBox
    Friend WithEvents pcBxBrakeType As PictureBox
    Friend WithEvents lblBrakeType As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTitle2 As Label
    Friend WithEvents chBxHelmet As CheckBox
    Friend WithEvents pcBxHelmet As PictureBox
    Friend WithEvents chBxPedals As CheckBox
    Friend WithEvents pcBxPedals As PictureBox
    Friend WithEvents pcBxLock As PictureBox
    Friend WithEvents chBxLock As CheckBox
    Friend WithEvents lblOutput As Label
    Friend WithEvents btnPurchase As Button
    Friend WithEvents lblEnsure As Label
End Class
