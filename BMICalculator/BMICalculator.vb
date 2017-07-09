Public Class frmBMICalculator

    Private Sub frmBMICalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Threading.Thread.Sleep(3000)
    End Sub

    Private Sub lstListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstListBox.SelectedIndexChanged
        btnCalculate.Visible = True
        lblEnterHeight.Visible = True
        lblMeters.Visible = True
        lblInches.Visible = True
        txtEnterMeters.Visible = True
        txtEnterInches.Visible = True
        lblWeight.Visible = True
        txtEnterWeight.Visible = True

    End Sub

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnCalculate.Click
        Dim intSystemSelect As Integer

        intSystemSelect = Me.lstListBox.SelectedIndex()

        Select Case intSystemSelect
            Case 0
                FindImperialBMI()
            Case 1
                FindMetricBMI()

        End Select
    End Sub
    Private Sub FindImperialBMI()
        Dim intInches As Integer
        Dim intWeightInPounds As Integer
        Dim intFinalImperialBMI As Integer
        Dim blnValidityImperialCheck As Boolean = False

        Try
            intInches = Convert.ToDecimal(txtEnterInches.Text)
            intWeightInPounds = Convert.ToDecimal(txtEnterWeight.Text)
            If intInches >= 0.1 Then
                blnValidityImperialCheck = True
            Else
                MsgBox("Please enter valid number!", , "Entry Error")
            End If
        Catch Exception As FormatException
            MsgBox("Please enter valid number!", , "Entry Error")
        End Try

        Try
            intWeightInPounds = Convert.ToInt32(txtEnterWeight.Text)
            If intWeightInPounds >= 1 Then
                blnValidityImperialCheck = True
            Else
                MsgBox("Please enter valid number!", , "Entry Error")
            End If
        Catch Exception As FormatException
            MsgBox("Please enter valid number!", , "Entry Error")
        End Try
        txtEnterWeight.Focus()
        lblCalculation.Visible = True
        intFinalImperialBMI = (intWeightInPounds / (intInches * intInches)) * 703
        lblCalculation.Text = "Your BMI is: " & intFinalImperialBMI.ToString("F2")
    End Sub
    Private Sub FindMetricBMI()
        Dim intMeters As Integer
        Dim intWeightInKilos As Integer
        Dim intFinalMetricBMI As Integer
        Dim blnValidityMetricCheck As Boolean = False

        Try
            intMeters = Convert.ToDecimal(txtEnterMeters.Text)
            intWeightInKilos = Convert.ToDecimal(txtEnterWeight.Text)
            If intMeters >= 1 Then
                blnValidityMetricCheck = True
            Else
                MsgBox("Please enter valid number!", , "Entry Error")
            End If
        Catch Exception As FormatException
            MsgBox("Please enter valid number!", , "Entry Error")
        End Try

        Try
            intWeightInKilos = Convert.ToInt32(txtEnterWeight.Text)
            If intWeightInKilos >= 1 Then
                blnValidityMetricCheck = True
            Else
                MsgBox("Please enter valid number!", , "Entry Error")
            End If
        Catch Exception As FormatException
            MsgBox("Please enter valid number!", , "Entry Error")
        End Try
        txtEnterWeight.Focus()
        lblCalculation.Visible = True
        intFinalMetricBMI = intWeightInKilos / (intMeters * intMeters)
        lblCalculation.Text = "Your BMI is: " & intFinalMetricBMI.ToString("F2")
    End Sub
End Class
