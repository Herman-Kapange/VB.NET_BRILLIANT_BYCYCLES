Public Class Receipt
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'code to enable exit button
        Me.Close()
    End Sub

    Private Sub Receipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'code to clear error label text
        lblNameError.Text = ""
        lblCardNumberError.Text = ""
        lblHouseNoError.Text = ""
        lblPostCodeError.Text = ""
        lblStreetNameError.Text = ""
        lblTownError.Text = ""

        'code to display prices in read only text boxes
        txBxBike.Text = Format(cost, "£0.00")
        txBxHelmet.Text = Format(helmetCost, "£0.00")
        txBxPedals.Text = Format(pedalsCost, "£0.00")
        txBxLock.Text = Format(lockCost, "£0.00")
        txBxTotal.Text = Format(total, "£0.00")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ''variables to be used in getting customer information
        Dim name As String = txBxName.Text
        Dim houseNo As String = txBxHouseNo.Text
        Dim streetName As String = txBxStreetName.Text
        Dim town As String = txBxTown.Text
        Dim postCode As String = txBxPostCode.Text
        Dim cardNumber As String = txBxCardNumber.Text
        Dim isValid As Boolean = True

        'code to validate data entered in all customer information text boxes
        If name.Length < 1 Then
            isValid = False
            lblNameError.Text = "Error, Please Input Name"
        End If
        If houseNo.Length < 1 Then
            isValid = False
            lblHouseNoError.Text = "Error, Please Input House Number"
        End If
        If streetName.Length < 1 Then
            isValid = False
            lblStreetNameError.Text = "Error, Please Input Street Name"
        End If
        If town.Length < 2 Or town.Length > 25 Then
            isValid = False
            lblTownError.Text = "Error, Please Input Correct Town"
        End If
        If postCode.Length < 6 Or postCode.Length > 7 Then
            isValid = False
            lblPostCodeError.Text = "Error, Postcode must be 6 or 7 characters"
        End If

        If txBxCardNumber.TextLength < 16 Then
            isValid = False
            lblCardNumberError.Text = "Error, Please Input 16 digit card number"
        End If

        If isValid = True Then
            'code to define receipt text file location
            Dim receiptFileName As String = "C:\Project\Programmng\Trail array 1\Receipt\BikeReceipt.txt"
            If System.IO.File.Exists(receiptFileName) = True Then

                'code to print customer name, bike details , optional extras and total price onto receipt text file
                Dim objWriter As New System.IO.StreamWriter(receiptFileName)
                objWriter.WriteLine("RECEIPT")
                objWriter.WriteLine("--------------------------------------------")
                objWriter.WriteLine(name)
                objWriter.WriteLine(strBikeType)
                objWriter.WriteLine(strFrameType & " frame" & " and " & strBrakeType)
                Select Case Options.chBxHelmet.Checked
                    Case True
                        objWriter.WriteLine(strHelmet)
                End Select
                Select Case Options.chBxPedals.Checked
                    Case True
                        objWriter.WriteLine(strPedals)
                End Select
                Select Case Options.chBxLock.Checked
                    Case True
                        objWriter.WriteLine(strLock)
                End Select
                objWriter.WriteLine("Total:" & Format(total, "£0.00"))
                objWriter.Close()
                MsgBox("Receipt Printed")

            End If
        End If

    End Sub

    Private Sub txBxCardNumber_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txBxCardNumber.KeyPress
        'code to only allow numbers to be input in card number text box
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub
End Class