Public Class Options

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'array of bike type options    
        Dim bikeTypes() As String = {"Road", "Cyclocross", "Gravel", "Mountain"}
        cmBxBikeType.Items.AddRange(bikeTypes)

        'array of frame type options
        Dim frameTypes() As String = {"Steel", "Aluminium", "Carbon Fibre"}
        cmBxFrameType.Items.AddRange(frameTypes)

        'array of brake type options
        Dim brakeTypes() As String = {"Disc Brakes", "Rim Brakes"}
        cmBxBrakeType.Items.AddRange(brakeTypes)

        'code to make helmet,pedals and lock images to be loaded on form
        pcBxHelmet.Image = Image.FromFile(renderImage("Helmet"))

        pcBxPedals.Image = Image.FromFile(renderImage("Pedals"))

        pcBxLock.Image = Image.FromFile(renderImage("Lock"))

    End Sub
    Public Function renderImage(imageName As String) As String
        'code that defines location of images and variables involved
        Dim assetsFolder As String = "C:\Project\Programmng\Trail array 1\Images"
        Dim fileName As String = System.IO.Path.Combine(assetsFolder, imageName & ".jpg")
        If System.IO.File.Exists(fileName) Then
            Return fileName
        Else
            fileName = System.IO.Path.Combine(assetsFolder, "Default.jpg")
            Return fileName
        End If
    End Function

    Private Sub cmBxBikeType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmBxBikeType.SelectedIndexChanged
        'code to load choosen bike type image onto picture box and its name onto a label
        Dim assetsFolder As String = "C:\Project\Programmng\Trail array 1\Images"
        Dim bikeType As String = cmBxBikeType.Text
        Dim fileName As String = System.IO.Path.Combine(assetsFolder, bikeType & ".jpg")

        If cmBxBikeType.SelectedItem = bikeType Then
            fileName = System.IO.Path.Combine(assetsFolder, bikeType & ".jpg")
            pcBxBikeTypes.Image = Image.FromFile(fileName)
            lblBicycleType.Text = bikeType
        End If
    End Sub

    Private Sub cmBxFrameType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmBxFrameType.SelectedIndexChanged
        'code to load choosen frame type image onto picture box and its name onto a label
        Dim assetsFolder As String = "C:\Project\Programmng\Trail array 1\Images"
        Dim frameType As String = cmBxFrameType.Text
        Dim fileName As String = System.IO.Path.Combine(assetsFolder, frameType & ".jpg")

        If cmBxFrameType.SelectedItem = frameType Then
            fileName = System.IO.Path.Combine(assetsFolder, frameType & ".jpg")
            pcBxFrameType.Image = Image.FromFile(fileName)
            lblFrameType.Text = frameType
        End If
    End Sub

    Private Sub cmBxBrakeType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmBxBrakeType.SelectedIndexChanged
        'code to load choosen brake type image onto picture box and its name onto a label
        Dim assetsFolder As String = "C:\Project\Programmng\Trail array 1\Images"
        Dim brakeType As String = cmBxBrakeType.Text
        Dim fileName As String = System.IO.Path.Combine(assetsFolder, brakeType & ".jpg")

        If cmBxBrakeType.SelectedItem = brakeType Then
            fileName = System.IO.Path.Combine(assetsFolder, brakeType & ".jpg")
            pcBxBrakeType.Image = Image.FromFile(fileName)
            lblBrakeType.Text = brakeType
        End If
    End Sub

    Private Sub btnQuote_Click(sender As Object, e As EventArgs) Handles btnQuote.Click
        'code to enable purchase button
        btnPurchase.Enabled = True

        'declaration of data dictionary
        Dim priceList As New Dictionary(Of String, Decimal)

        'population of data dictionary with all possible bike, frame and brake combinations with their prices
        priceList.Add("RoadSteelRim Brakes", 160)
        priceList.Add("RoadSteelDisc Brakes", 200)
        priceList.Add("RoadAluminiumRim Brakes", 390)
        priceList.Add("RoadAluminiumDisc Brakes", 450)
        priceList.Add("RoadCarbon FibreRim Brakes", 1700)
        priceList.Add("RoadCarbon FibreDisc Brakes", 1800)

        priceList.Add("CyclocrossSteelRim Brakes", 240)
        priceList.Add("CyclocrossSteelDisc Brakes", 280)
        priceList.Add("CyclocrossAluminiumRim Brakes", 840)
        priceList.Add("CyclocrossAluminiumDisc Brakes", 900)
        priceList.Add("CyclocrossCarbon FibreRim Brakes", 2200)
        priceList.Add("CyclocrossCarbon FibreDisc Brakes", 2300)

        priceList.Add("GravelSteelRim Brakes", 190)
        priceList.Add("GravelSteelDisc Brakes", 230)
        priceList.Add("GravelAluminiumRim Brakes", 500)
        priceList.Add("GravelAluminiumDisc Brakes", 560)
        priceList.Add("GravelCarbon FibreRim Brakes", 1900)
        priceList.Add("GravelCarbon FibreDisc Brakes", 2000)

        priceList.Add("MountainSteelRim Brakes", 190)
        priceList.Add("MountainSteelDisc Brakes", 230)
        priceList.Add("MountainAluminiumRim Brakes", 500)
        priceList.Add("MountainAluminiumDisc Brakes", 560)
        priceList.Add("MountainCarbon FibreRim Brakes", 1900)
        priceList.Add("MountainCarbon FibreDisc Brakes", 2000)

        'data dictionary of optional accessories and their prices
        Dim priceListAccessories As New Dictionary(Of String, Decimal)
        priceListAccessories.Add("Helmet", 65)
        priceListAccessories.Add("Pedals", 79)
        priceListAccessories.Add("Lock", 45)

        'code to combine all selected bicycle options
        Dim pair As String
        pair = cmBxBikeType.Text & cmBxFrameType.Text & cmBxBrakeType.Text

        'code to compare selected options with options in data dictionary in order to obtain the price of the bicycle and accessories
        If chBxHelmet.Checked Then
            helmetCost = priceListAccessories.Item("Helmet")
        Else
            helmetCost = 0
        End If

        If chBxPedals.Checked Then
            pedalsCost = priceListAccessories.Item("Pedals")
        Else
            pedalsCost = 0
        End If

        If chBxLock.Checked Then
            lockCost = priceListAccessories.Item("Lock")
        Else
            lockCost = 0
        End If

        'code to calculate total of selected bicycle and accessories
        Try
            cost = priceList.Item(pair)
            total = cost + helmetCost + pedalsCost + lockCost

            lblOutput.Text = "£" & total

            'code to check for errors in the selection of options and display error messages
        Catch ex As Exception
            lblOutput.Text = "Error, please ensure to select a bicycle type, frame type and brake type"
        End Try

        If lblOutput.Text = "Error, please ensure to select a bike type, frame type and brake type" Then
            cost = 0
            total = cost + helmetCost + pedalsCost + lockCost
        End If

    End Sub

    Private Sub btnPurchase_Click(sender As Object, e As EventArgs) Handles btnPurchase.Click
        'code to equate public variables to specific variables from options form
        strBikeType = cmBxBikeType.Text
        strFrameType = cmBxFrameType.Text
        strBrakeType = cmBxBrakeType.Text
        strHelmet = chBxHelmet.Text
        strPedals = chBxPedals.Text
        strLock = chBxLock.Text

        'code to load receipt for from purchase button click
        Dim receiptForm = New Receipt()
        receiptForm.StartPosition = FormStartPosition.Manual
        receiptForm.DesktopLocation = Me.DesktopLocation
        receiptForm.Show()

    End Sub
End Class
