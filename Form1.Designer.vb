<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.txtLoan = New System.Windows.Forms.TextBox()
        Me.cbErate = New System.Windows.Forms.ComboBox()
        Me.cbYear = New System.Windows.Forms.ComboBox()
        Me.cbSrate = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbOutput = New System.Windows.Forms.ListBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(392, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Car Loan Payment Calculator"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Turquoise
        Me.GroupBox1.Controls.Add(Me.btnClear)
        Me.GroupBox1.Controls.Add(Me.btnCalculate)
        Me.GroupBox1.Controls.Add(Me.txtRate)
        Me.GroupBox1.Controls.Add(Me.txtLoan)
        Me.GroupBox1.Controls.Add(Me.cbErate)
        Me.GroupBox1.Controls.Add(Me.cbYear)
        Me.GroupBox1.Controls.Add(Me.cbSrate)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(35, 65)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(535, 230)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Loan Calculator"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(178, 177)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(120, 30)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(33, 177)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(120, 30)
        Me.btnCalculate.TabIndex = 2
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'txtRate
        '
        Me.txtRate.Location = New System.Drawing.Point(128, 125)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(125, 27)
        Me.txtRate.TabIndex = 3
        '
        'txtLoan
        '
        Me.txtLoan.Location = New System.Drawing.Point(128, 36)
        Me.txtLoan.Name = "txtLoan"
        Me.txtLoan.Size = New System.Drawing.Size(125, 27)
        Me.txtLoan.TabIndex = 2
        '
        'cbErate
        '
        Me.cbErate.FormattingEnabled = True
        Me.cbErate.Items.AddRange(New Object() {"2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.cbErate.Location = New System.Drawing.Point(415, 81)
        Me.cbErate.Name = "cbErate"
        Me.cbErate.Size = New System.Drawing.Size(68, 28)
        Me.cbErate.TabIndex = 9
        '
        'cbYear
        '
        Me.cbYear.FormattingEnabled = True
        Me.cbYear.Items.AddRange(New Object() {"2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cbYear.Location = New System.Drawing.Point(415, 44)
        Me.cbYear.Name = "cbYear"
        Me.cbYear.Size = New System.Drawing.Size(68, 28)
        Me.cbYear.TabIndex = 8
        '
        'cbSrate
        '
        Me.cbSrate.FormattingEnabled = True
        Me.cbSrate.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cbSrate.Location = New System.Drawing.Point(128, 80)
        Me.cbSrate.Name = "cbSrate"
        Me.cbSrate.Size = New System.Drawing.Size(68, 28)
        Me.cbSrate.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 128)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 20)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Rate Step Size "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(315, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "End Rate (%)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(340, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Years"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Start Rate (%)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Loan Amount"
        '
        'lbOutput
        '
        Me.lbOutput.FormattingEnabled = True
        Me.lbOutput.ItemHeight = 20
        Me.lbOutput.Items.AddRange(New Object() {"Interest Rate     Monthly Payment"})
        Me.lbOutput.Location = New System.Drawing.Point(35, 315)
        Me.lbOutput.Name = "lbOutput"
        Me.lbOutput.Size = New System.Drawing.Size(535, 164)
        Me.lbOutput.TabIndex = 2
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(21, 523)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(60, 20)
        Me.lblName.TabIndex = 3
        Me.lblName.Text = "Name : "
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(450, 510)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 30)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Car List"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 590)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lbOutput)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Car Loan Payment Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtRate As TextBox
    Friend WithEvents txtLoan As TextBox
    Friend WithEvents cbErate As ComboBox
    Friend WithEvents cbYear As ComboBox
    Friend WithEvents cbSrate As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbOutput As ListBox
    Friend WithEvents lblName As Label
    Friend WithEvents Button1 As Button

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim strAmount As Double = CDbl(txtLoan.Text)
        Dim strYears As Integer = (cbYear.SelectedItem)
        Dim strsRate As Integer = (cbSrate.SelectedItem)
        Dim strErate As Integer = (cbErate.SelectedItem)
        Dim strStepR As Double = CDbl(txtRate.Text)
        Dim result As Decimal
        Dim rate As Double
        Dim arrange As String = "{0}                  {1}"
        Dim month As Integer = strYears * 12

        strAmount = Double.Parse(txtLoan.Text.ToString())
        strYears = Double.Parse(cbYear.GetItemText(cbYear.SelectedItem))
        strsRate = Double.Parse(cbSrate.GetItemText(cbSrate.SelectedItem))
        strErate = Double.Parse(cbErate.GetItemText(cbErate.SelectedItem))
        strStepR = Double.Parse(txtRate.Text.ToString())

        For rate = strsRate To strErate Step strStepR
            'Interest rate = (rate / 12) / 100
            result = -Pmt((rate / 12) / 100, month, strAmount)
            lbOutput.Items.Add(String.Format(arrange, FormatPercent(rate.ToString / 100), FormatCurrency(result.ToString, 2)))

        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strName As String
        lblName.Text = "Name: MOHAMMAD ISMAIL BIN MOHAMMAD IZZUDDIN" + vbCrLf + "(10DDT20F1044)"
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtLoan.Text = ""
        txtRate.Text = ""
        cbErate.ResetText()
        cbSrate.ResetText()
        cbYear.ResetText()
        lbOutput.Items.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("
         Perodua Ativa
         5-Seater SUV
         From RM61,500

         Proton X50
         SUV
         From RM79,200

         Honda HR-V 
         Compact crossover SUV
         From RM104,000

         Nissan X-Trail
         Compact crossover SUV
         From RM128,630", MsgBoxStyle.OkCancel, "Car List")
    End Sub
End Class
