<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Receipt
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
        Me.txBxName = New System.Windows.Forms.TextBox()
        Me.txBxHouseNo = New System.Windows.Forms.TextBox()
        Me.txBxStreetName = New System.Windows.Forms.TextBox()
        Me.txBxTown = New System.Windows.Forms.TextBox()
        Me.txBxPostCode = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblHouseNo = New System.Windows.Forms.Label()
        Me.lblStreetName = New System.Windows.Forms.Label()
        Me.lblTown = New System.Windows.Forms.Label()
        Me.lblPostCode = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txBxBike = New System.Windows.Forms.TextBox()
        Me.txBxHelmet = New System.Windows.Forms.TextBox()
        Me.txBxPedals = New System.Windows.Forms.TextBox()
        Me.txBxLock = New System.Windows.Forms.TextBox()
        Me.txBxTotal = New System.Windows.Forms.TextBox()
        Me.lblCardNo = New System.Windows.Forms.Label()
        Me.txBxCardNumber = New System.Windows.Forms.TextBox()
        Me.grBxAddress = New System.Windows.Forms.GroupBox()
        Me.lblCardNumberError = New System.Windows.Forms.Label()
        Me.lblPostCodeError = New System.Windows.Forms.Label()
        Me.lblTownError = New System.Windows.Forms.Label()
        Me.lblStreetNameError = New System.Windows.Forms.Label()
        Me.lblHouseNoError = New System.Windows.Forms.Label()
        Me.lblNameError = New System.Windows.Forms.Label()
        Me.lblTitle3 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grBxAddress.SuspendLayout()
        Me.SuspendLayout()
        '
        'txBxName
        '
        Me.txBxName.Location = New System.Drawing.Point(107, 36)
        Me.txBxName.Name = "txBxName"
        Me.txBxName.Size = New System.Drawing.Size(192, 20)
        Me.txBxName.TabIndex = 0
        '
        'txBxHouseNo
        '
        Me.txBxHouseNo.Location = New System.Drawing.Point(107, 80)
        Me.txBxHouseNo.Name = "txBxHouseNo"
        Me.txBxHouseNo.Size = New System.Drawing.Size(192, 20)
        Me.txBxHouseNo.TabIndex = 1
        '
        'txBxStreetName
        '
        Me.txBxStreetName.Location = New System.Drawing.Point(107, 129)
        Me.txBxStreetName.Name = "txBxStreetName"
        Me.txBxStreetName.Size = New System.Drawing.Size(192, 20)
        Me.txBxStreetName.TabIndex = 2
        '
        'txBxTown
        '
        Me.txBxTown.Location = New System.Drawing.Point(107, 181)
        Me.txBxTown.Name = "txBxTown"
        Me.txBxTown.Size = New System.Drawing.Size(192, 20)
        Me.txBxTown.TabIndex = 3
        '
        'txBxPostCode
        '
        Me.txBxPostCode.Location = New System.Drawing.Point(107, 229)
        Me.txBxPostCode.Name = "txBxPostCode"
        Me.txBxPostCode.Size = New System.Drawing.Size(192, 20)
        Me.txBxPostCode.TabIndex = 4
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(50, 36)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(38, 13)
        Me.lblName.TabIndex = 5
        Me.lblName.Text = "Name:"
        '
        'lblHouseNo
        '
        Me.lblHouseNo.AutoSize = True
        Me.lblHouseNo.Location = New System.Drawing.Point(7, 83)
        Me.lblHouseNo.Name = "lblHouseNo"
        Me.lblHouseNo.Size = New System.Drawing.Size(81, 13)
        Me.lblHouseNo.TabIndex = 6
        Me.lblHouseNo.Text = "House Number:"
        '
        'lblStreetName
        '
        Me.lblStreetName.AutoSize = True
        Me.lblStreetName.Location = New System.Drawing.Point(22, 132)
        Me.lblStreetName.Name = "lblStreetName"
        Me.lblStreetName.Size = New System.Drawing.Size(69, 13)
        Me.lblStreetName.TabIndex = 7
        Me.lblStreetName.Text = "Street Name:"
        '
        'lblTown
        '
        Me.lblTown.AutoSize = True
        Me.lblTown.Location = New System.Drawing.Point(29, 185)
        Me.lblTown.Name = "lblTown"
        Me.lblTown.Size = New System.Drawing.Size(62, 13)
        Me.lblTown.TabIndex = 8
        Me.lblTown.Text = "Town/ City:"
        '
        'lblPostCode
        '
        Me.lblPostCode.AutoSize = True
        Me.lblPostCode.Location = New System.Drawing.Point(32, 232)
        Me.lblPostCode.Name = "lblPostCode"
        Me.lblPostCode.Size = New System.Drawing.Size(59, 13)
        Me.lblPostCode.TabIndex = 9
        Me.lblPostCode.Text = "Post Code:"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.DarkRed
        Me.Button1.Location = New System.Drawing.Point(592, 315)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 31)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Print Receipt"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(557, 139)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Bicycle:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(492, 166)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "MIPS Bicycle Helmet:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(521, 201)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Clipless Pedals:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(556, 234)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "D Lock:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(561, 264)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Total:"
        '
        'txBxBike
        '
        Me.txBxBike.Location = New System.Drawing.Point(607, 135)
        Me.txBxBike.Name = "txBxBike"
        Me.txBxBike.ReadOnly = True
        Me.txBxBike.Size = New System.Drawing.Size(81, 20)
        Me.txBxBike.TabIndex = 17
        Me.txBxBike.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txBxHelmet
        '
        Me.txBxHelmet.Location = New System.Drawing.Point(607, 166)
        Me.txBxHelmet.Name = "txBxHelmet"
        Me.txBxHelmet.ReadOnly = True
        Me.txBxHelmet.Size = New System.Drawing.Size(81, 20)
        Me.txBxHelmet.TabIndex = 18
        Me.txBxHelmet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txBxPedals
        '
        Me.txBxPedals.Location = New System.Drawing.Point(607, 198)
        Me.txBxPedals.Name = "txBxPedals"
        Me.txBxPedals.ReadOnly = True
        Me.txBxPedals.Size = New System.Drawing.Size(81, 20)
        Me.txBxPedals.TabIndex = 19
        Me.txBxPedals.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txBxLock
        '
        Me.txBxLock.Location = New System.Drawing.Point(607, 231)
        Me.txBxLock.Name = "txBxLock"
        Me.txBxLock.ReadOnly = True
        Me.txBxLock.Size = New System.Drawing.Size(81, 20)
        Me.txBxLock.TabIndex = 20
        Me.txBxLock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txBxTotal
        '
        Me.txBxTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txBxTotal.Location = New System.Drawing.Point(607, 261)
        Me.txBxTotal.Name = "txBxTotal"
        Me.txBxTotal.ReadOnly = True
        Me.txBxTotal.Size = New System.Drawing.Size(81, 20)
        Me.txBxTotal.TabIndex = 21
        Me.txBxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCardNo
        '
        Me.lblCardNo.AutoSize = True
        Me.lblCardNo.Location = New System.Drawing.Point(19, 279)
        Me.lblCardNo.Name = "lblCardNo"
        Me.lblCardNo.Size = New System.Drawing.Size(72, 13)
        Me.lblCardNo.TabIndex = 22
        Me.lblCardNo.Text = "Card Number:"
        '
        'txBxCardNumber
        '
        Me.txBxCardNumber.Location = New System.Drawing.Point(107, 276)
        Me.txBxCardNumber.MaxLength = 16
        Me.txBxCardNumber.Name = "txBxCardNumber"
        Me.txBxCardNumber.Size = New System.Drawing.Size(192, 20)
        Me.txBxCardNumber.TabIndex = 23
        '
        'grBxAddress
        '
        Me.grBxAddress.Controls.Add(Me.lblCardNumberError)
        Me.grBxAddress.Controls.Add(Me.lblPostCodeError)
        Me.grBxAddress.Controls.Add(Me.lblTownError)
        Me.grBxAddress.Controls.Add(Me.lblStreetNameError)
        Me.grBxAddress.Controls.Add(Me.lblHouseNoError)
        Me.grBxAddress.Controls.Add(Me.lblNameError)
        Me.grBxAddress.Controls.Add(Me.txBxHouseNo)
        Me.grBxAddress.Controls.Add(Me.lblCardNo)
        Me.grBxAddress.Controls.Add(Me.txBxCardNumber)
        Me.grBxAddress.Controls.Add(Me.lblHouseNo)
        Me.grBxAddress.Controls.Add(Me.txBxStreetName)
        Me.grBxAddress.Controls.Add(Me.lblStreetName)
        Me.grBxAddress.Controls.Add(Me.txBxTown)
        Me.grBxAddress.Controls.Add(Me.lblTown)
        Me.grBxAddress.Controls.Add(Me.txBxPostCode)
        Me.grBxAddress.Controls.Add(Me.lblPostCode)
        Me.grBxAddress.Controls.Add(Me.txBxName)
        Me.grBxAddress.Controls.Add(Me.lblName)
        Me.grBxAddress.Location = New System.Drawing.Point(65, 76)
        Me.grBxAddress.Name = "grBxAddress"
        Me.grBxAddress.Size = New System.Drawing.Size(316, 348)
        Me.grBxAddress.TabIndex = 24
        Me.grBxAddress.TabStop = False
        Me.grBxAddress.Text = "Please input your name and address below"
        '
        'lblCardNumberError
        '
        Me.lblCardNumberError.AutoSize = True
        Me.lblCardNumberError.ForeColor = System.Drawing.Color.Red
        Me.lblCardNumberError.Location = New System.Drawing.Point(107, 299)
        Me.lblCardNumberError.Name = "lblCardNumberError"
        Me.lblCardNumberError.Size = New System.Drawing.Size(39, 13)
        Me.lblCardNumberError.TabIndex = 29
        Me.lblCardNumberError.Text = "Label6"
        '
        'lblPostCodeError
        '
        Me.lblPostCodeError.AutoSize = True
        Me.lblPostCodeError.ForeColor = System.Drawing.Color.Red
        Me.lblPostCodeError.Location = New System.Drawing.Point(107, 252)
        Me.lblPostCodeError.Name = "lblPostCodeError"
        Me.lblPostCodeError.Size = New System.Drawing.Size(39, 13)
        Me.lblPostCodeError.TabIndex = 28
        Me.lblPostCodeError.Text = "Label5"
        '
        'lblTownError
        '
        Me.lblTownError.AutoSize = True
        Me.lblTownError.ForeColor = System.Drawing.Color.Red
        Me.lblTownError.Location = New System.Drawing.Point(107, 204)
        Me.lblTownError.Name = "lblTownError"
        Me.lblTownError.Size = New System.Drawing.Size(39, 13)
        Me.lblTownError.TabIndex = 27
        Me.lblTownError.Text = "Label4"
        '
        'lblStreetNameError
        '
        Me.lblStreetNameError.AutoSize = True
        Me.lblStreetNameError.ForeColor = System.Drawing.Color.Red
        Me.lblStreetNameError.Location = New System.Drawing.Point(107, 152)
        Me.lblStreetNameError.Name = "lblStreetNameError"
        Me.lblStreetNameError.Size = New System.Drawing.Size(39, 13)
        Me.lblStreetNameError.TabIndex = 26
        Me.lblStreetNameError.Text = "Label3"
        '
        'lblHouseNoError
        '
        Me.lblHouseNoError.AutoSize = True
        Me.lblHouseNoError.ForeColor = System.Drawing.Color.Red
        Me.lblHouseNoError.Location = New System.Drawing.Point(107, 103)
        Me.lblHouseNoError.Name = "lblHouseNoError"
        Me.lblHouseNoError.Size = New System.Drawing.Size(39, 13)
        Me.lblHouseNoError.TabIndex = 25
        Me.lblHouseNoError.Text = "Label2"
        '
        'lblNameError
        '
        Me.lblNameError.AutoSize = True
        Me.lblNameError.ForeColor = System.Drawing.Color.Red
        Me.lblNameError.Location = New System.Drawing.Point(107, 59)
        Me.lblNameError.Name = "lblNameError"
        Me.lblNameError.Size = New System.Drawing.Size(39, 13)
        Me.lblNameError.TabIndex = 24
        Me.lblNameError.Text = "Label1"
        '
        'lblTitle3
        '
        Me.lblTitle3.AutoSize = True
        Me.lblTitle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle3.ForeColor = System.Drawing.Color.Black
        Me.lblTitle3.Location = New System.Drawing.Point(397, 104)
        Me.lblTitle3.Name = "lblTitle3"
        Me.lblTitle3.Size = New System.Drawing.Size(382, 13)
        Me.lblTitle3.TabIndex = 25
        Me.lblTitle3.Text = "The total price of your Bicycle and Accessories is displayed below"
        '
        'btnExit
        '
        Me.btnExit.ForeColor = System.Drawing.Color.DarkRed
        Me.btnExit.Location = New System.Drawing.Point(495, 323)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(63, 23)
        Me.btnExit.TabIndex = 26
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Receipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(824, 529)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblTitle3)
        Me.Controls.Add(Me.grBxAddress)
        Me.Controls.Add(Me.txBxTotal)
        Me.Controls.Add(Me.txBxLock)
        Me.Controls.Add(Me.txBxPedals)
        Me.Controls.Add(Me.txBxHelmet)
        Me.Controls.Add(Me.txBxBike)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button1)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "Receipt"
        Me.Text = "Receipt"
        Me.grBxAddress.ResumeLayout(False)
        Me.grBxAddress.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txBxName As TextBox
    Friend WithEvents txBxHouseNo As TextBox
    Friend WithEvents txBxStreetName As TextBox
    Friend WithEvents txBxTown As TextBox
    Friend WithEvents txBxPostCode As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblHouseNo As Label
    Friend WithEvents lblStreetName As Label
    Friend WithEvents lblTown As Label
    Friend WithEvents lblPostCode As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txBxBike As TextBox
    Friend WithEvents txBxHelmet As TextBox
    Friend WithEvents txBxPedals As TextBox
    Friend WithEvents txBxLock As TextBox
    Friend WithEvents txBxTotal As TextBox
    Friend WithEvents lblCardNo As Label
    Friend WithEvents txBxCardNumber As TextBox
    Friend WithEvents grBxAddress As GroupBox
    Friend WithEvents lblTitle3 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents lblNameError As Label
    Friend WithEvents lblCardNumberError As Label
    Friend WithEvents lblPostCodeError As Label
    Friend WithEvents lblTownError As Label
    Friend WithEvents lblStreetNameError As Label
    Friend WithEvents lblHouseNoError As Label
End Class
