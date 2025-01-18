<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        lblLoanAmount = New Label()
        lblInterestRate = New Label()
        lblMonthlyPayment = New Label()
        lblLoanTerm = New Label()
        txtLoanAmount = New TextBox()
        txtInterestRate = New TextBox()
        cmbLoanTerm = New ComboBox()
        btnCalculate = New Button()
        btnClear = New Button()
        btnExit = New Button()
        SuspendLayout()
        ' 
        ' lblLoanAmount
        ' 
        lblLoanAmount.AutoSize = True
        lblLoanAmount.Location = New Point(12, 67)
        lblLoanAmount.Name = "lblLoanAmount"
        lblLoanAmount.Size = New Size(80, 15)
        lblLoanAmount.TabIndex = 0
        lblLoanAmount.Text = "Loan Amount" & vbCrLf
        ' 
        ' lblInterestRate
        ' 
        lblInterestRate.AutoSize = True
        lblInterestRate.Location = New Point(12, 92)
        lblInterestRate.Name = "lblInterestRate"
        lblInterestRate.Size = New Size(134, 15)
        lblInterestRate.TabIndex = 1
        lblInterestRate.Text = "Annual Interest Rate (%)"
        ' 
        ' lblMonthlyPayment
        ' 
        lblMonthlyPayment.AutoSize = True
        lblMonthlyPayment.Location = New Point(12, 119)
        lblMonthlyPayment.Name = "lblMonthlyPayment"
        lblMonthlyPayment.Size = New Size(102, 15)
        lblMonthlyPayment.TabIndex = 2
        lblMonthlyPayment.Text = "Monthly Payment"
        ' 
        ' lblLoanTerm
        ' 
        lblLoanTerm.AutoSize = True
        lblLoanTerm.Location = New Point(12, 40)
        lblLoanTerm.Name = "lblLoanTerm"
        lblLoanTerm.Size = New Size(101, 15)
        lblLoanTerm.TabIndex = 3
        lblLoanTerm.Text = "Loan Term (Years)"
        ' 
        ' txtLoanAmount
        ' 
        txtLoanAmount.Location = New Point(394, 64)
        txtLoanAmount.Name = "txtLoanAmount"
        txtLoanAmount.Size = New Size(100, 23)
        txtLoanAmount.TabIndex = 4
        ' 
        ' txtInterestRate
        ' 
        txtInterestRate.Location = New Point(394, 89)
        txtInterestRate.Name = "txtInterestRate"
        txtInterestRate.Size = New Size(100, 23)
        txtInterestRate.TabIndex = 5
        ' 
        ' cmbLoanTerm
        ' 
        cmbLoanTerm.FormattingEnabled = True
        cmbLoanTerm.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30"})
        cmbLoanTerm.Location = New Point(394, 37)
        cmbLoanTerm.Name = "cmbLoanTerm"
        cmbLoanTerm.Size = New Size(100, 23)
        cmbLoanTerm.TabIndex = 6
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Location = New Point(407, 376)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(75, 23)
        btnCalculate.TabIndex = 7
        btnCalculate.Text = "Calculate"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(366, 415)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(75, 23)
        btnClear.TabIndex = 8
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(463, 415)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(75, 23)
        btnExit.TabIndex = 9
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnExit)
        Controls.Add(btnClear)
        Controls.Add(btnCalculate)
        Controls.Add(cmbLoanTerm)
        Controls.Add(txtInterestRate)
        Controls.Add(txtLoanAmount)
        Controls.Add(lblLoanTerm)
        Controls.Add(lblMonthlyPayment)
        Controls.Add(lblInterestRate)
        Controls.Add(lblLoanAmount)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblLoanAmount As Label
    Friend WithEvents lblInterestRate As Label
    Friend WithEvents lblMonthlyPayment As Label
    Friend WithEvents lblLoanTerm As Label
    Friend WithEvents txtLoanAmount As TextBox
    Friend WithEvents txtInterestRate As TextBox
    Friend WithEvents cmbLoanTerm As ComboBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button

End Class
