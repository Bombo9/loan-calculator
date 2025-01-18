Public Class Form1
    ' Declare variables at the class level
    Dim loanAmount As Decimal
    Dim interestRate As Decimal
    Dim loanTerm As Integer
    Dim monthlyPayment As Decimal
    Dim interestRates() As Decimal = {3.5D, 4D, 5D} ' Example interest rates for predefined loan types

    ' Event handler for the Calculate button click
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Clear previous results
        lblMonthlyPayment.Text = ""

        ' Try to parse the user inputs
        If Decimal.TryParse(txtLoanAmount.Text, loanAmount) AndAlso
           Decimal.TryParse(txtInterestRate.Text, interestRate) AndAlso
           Integer.TryParse(cmbLoanTerm.SelectedItem.ToString(), loanTerm) Then

            ' Calculate the monthly payment for the user-specified interest rate
            Dim monthlyInterestRate As Decimal = interestRate / 100 / 12
            Dim numberOfPayments As Integer = loanTerm * 12
            Dim userSpecifiedPayment = loanAmount * monthlyInterestRate / (1 - (1 + monthlyInterestRate) ^ -numberOfPayments)

            ' Display the result for the user-specified interest rate
            lblMonthlyPayment.Text &= "Monthly Payment at " & interestRate.ToString() & "% (User Input): " & userSpecifiedPayment.ToString("C2") & vbCrLf

            ' Loop through the array of predefined interest rates
            For Each rate As Decimal In interestRates
                ' Calculate the monthly interest rate
                Dim predefinedMonthlyRate As Decimal = rate / 100 / 12

                ' Calculate the monthly payment for the predefined interest rate
                Dim predefinedPayment = loanAmount * predefinedMonthlyRate / (1 - (1 + predefinedMonthlyRate) ^ -numberOfPayments)

                ' Display the result for each predefined rate
                lblMonthlyPayment.Text &= "Monthly Payment at " & rate.ToString() & "%: " & predefinedPayment.ToString("C2") & vbCrLf
            Next
        Else
            ' Show error message if the input is invalid
            MessageBox.Show("Please enter valid values.")
        End If
    End Sub

    ' Event handler for the Clear button click
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear all inputs and output
        txtLoanAmount.Clear()
        txtInterestRate.Clear()
        cmbLoanTerm.SelectedIndex = -1
        lblMonthlyPayment.Text = "Monthly Payment: $0.00"
    End Sub

    ' Event handler for the Exit button click
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the application
        Me.Close()
    End Sub
End Class
