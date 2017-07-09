<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBMICalculator
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
        Me.picPicture = New System.Windows.Forms.PictureBox()
        Me.lstListBox = New System.Windows.Forms.ListBox()
        Me.lblHowToCalculate = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtEnterMeters = New System.Windows.Forms.TextBox()
        Me.lblEnterHeight = New System.Windows.Forms.Label()
        Me.lblInches = New System.Windows.Forms.Label()
        Me.lblMeters = New System.Windows.Forms.Label()
        Me.txtEnterInches = New System.Windows.Forms.TextBox()
        Me.lblCalculation = New System.Windows.Forms.Label()
        Me.txtEnterWeight = New System.Windows.Forms.TextBox()
        Me.lblWeight = New System.Windows.Forms.Label()
        CType(Me.picPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picPicture
        '
        Me.picPicture.Image = Global.BMICalculator.My.Resources.Resources.bmi
        Me.picPicture.Location = New System.Drawing.Point(17, 12)
        Me.picPicture.Name = "picPicture"
        Me.picPicture.Size = New System.Drawing.Size(299, 114)
        Me.picPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPicture.TabIndex = 0
        Me.picPicture.TabStop = False
        '
        'lstListBox
        '
        Me.lstListBox.BackColor = System.Drawing.Color.White
        Me.lstListBox.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstListBox.FormattingEnabled = True
        Me.lstListBox.ItemHeight = 16
        Me.lstListBox.Items.AddRange(New Object() {"Imperial", "Metric"})
        Me.lstListBox.Location = New System.Drawing.Point(26, 169)
        Me.lstListBox.Name = "lstListBox"
        Me.lstListBox.Size = New System.Drawing.Size(64, 36)
        Me.lstListBox.TabIndex = 1
        '
        'lblHowToCalculate
        '
        Me.lblHowToCalculate.AutoSize = True
        Me.lblHowToCalculate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHowToCalculate.Location = New System.Drawing.Point(23, 142)
        Me.lblHowToCalculate.Name = "lblHowToCalculate"
        Me.lblHowToCalculate.Size = New System.Drawing.Size(80, 16)
        Me.lblHowToCalculate.TabIndex = 2
        Me.lblHowToCalculate.Text = "Select one:"
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.DarkRed
        Me.btnCalculate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.Color.White
        Me.btnCalculate.Location = New System.Drawing.Point(94, 266)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(137, 32)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "Calculate BMI"
        Me.btnCalculate.UseVisualStyleBackColor = False
        Me.btnCalculate.Visible = False
        '
        'txtEnterMeters
        '
        Me.txtEnterMeters.Location = New System.Drawing.Point(261, 169)
        Me.txtEnterMeters.Name = "txtEnterMeters"
        Me.txtEnterMeters.Size = New System.Drawing.Size(48, 20)
        Me.txtEnterMeters.TabIndex = 4
        Me.txtEnterMeters.Visible = False
        '
        'lblEnterHeight
        '
        Me.lblEnterHeight.AutoSize = True
        Me.lblEnterHeight.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnterHeight.Location = New System.Drawing.Point(156, 143)
        Me.lblEnterHeight.Name = "lblEnterHeight"
        Me.lblEnterHeight.Size = New System.Drawing.Size(136, 16)
        Me.lblEnterHeight.TabIndex = 5
        Me.lblEnterHeight.Text = "Enter height/weight:"
        Me.lblEnterHeight.Visible = False
        '
        'lblInches
        '
        Me.lblInches.AutoSize = True
        Me.lblInches.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInches.Location = New System.Drawing.Point(156, 197)
        Me.lblInches.Name = "lblInches"
        Me.lblInches.Size = New System.Drawing.Size(97, 16)
        Me.lblInches.TabIndex = 7
        Me.lblInches.Text = "Heigh in Inches"
        Me.lblInches.Visible = False
        '
        'lblMeters
        '
        Me.lblMeters.AutoSize = True
        Me.lblMeters.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMeters.Location = New System.Drawing.Point(156, 170)
        Me.lblMeters.Name = "lblMeters"
        Me.lblMeters.Size = New System.Drawing.Size(103, 16)
        Me.lblMeters.TabIndex = 8
        Me.lblMeters.Text = "Height in Meters"
        Me.lblMeters.Visible = False
        '
        'txtEnterInches
        '
        Me.txtEnterInches.Location = New System.Drawing.Point(261, 196)
        Me.txtEnterInches.Name = "txtEnterInches"
        Me.txtEnterInches.Size = New System.Drawing.Size(48, 20)
        Me.txtEnterInches.TabIndex = 9
        Me.txtEnterInches.Visible = False
        '
        'lblCalculation
        '
        Me.lblCalculation.AutoSize = True
        Me.lblCalculation.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalculation.ForeColor = System.Drawing.Color.DarkRed
        Me.lblCalculation.Location = New System.Drawing.Point(98, 314)
        Me.lblCalculation.Name = "lblCalculation"
        Me.lblCalculation.Size = New System.Drawing.Size(0, 16)
        Me.lblCalculation.TabIndex = 11
        Me.lblCalculation.Visible = False
        '
        'txtEnterWeight
        '
        Me.txtEnterWeight.Location = New System.Drawing.Point(261, 223)
        Me.txtEnterWeight.Name = "txtEnterWeight"
        Me.txtEnterWeight.Size = New System.Drawing.Size(48, 20)
        Me.txtEnterWeight.TabIndex = 13
        Me.txtEnterWeight.Visible = False
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeight.Location = New System.Drawing.Point(156, 224)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(49, 16)
        Me.lblWeight.TabIndex = 12
        Me.lblWeight.Text = "Weight"
        Me.lblWeight.Visible = False
        '
        'frmBMICalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(332, 363)
        Me.Controls.Add(Me.txtEnterWeight)
        Me.Controls.Add(Me.lblWeight)
        Me.Controls.Add(Me.lblCalculation)
        Me.Controls.Add(Me.txtEnterInches)
        Me.Controls.Add(Me.lblMeters)
        Me.Controls.Add(Me.lblInches)
        Me.Controls.Add(Me.lblEnterHeight)
        Me.Controls.Add(Me.txtEnterMeters)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblHowToCalculate)
        Me.Controls.Add(Me.lstListBox)
        Me.Controls.Add(Me.picPicture)
        Me.Name = "frmBMICalculator"
        Me.Text = "Body Mass Index (BMI) Calculator"
        CType(Me.picPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picPicture As System.Windows.Forms.PictureBox
    Friend WithEvents lstListBox As System.Windows.Forms.ListBox
    Friend WithEvents lblHowToCalculate As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents txtEnterMeters As System.Windows.Forms.TextBox
    Friend WithEvents lblEnterHeight As System.Windows.Forms.Label
    Friend WithEvents lblInches As System.Windows.Forms.Label
    Friend WithEvents lblMeters As System.Windows.Forms.Label
    Friend WithEvents txtEnterInches As System.Windows.Forms.TextBox
    Friend WithEvents lblCalculation As System.Windows.Forms.Label
    Friend WithEvents txtEnterWeight As System.Windows.Forms.TextBox
    Friend WithEvents lblWeight As System.Windows.Forms.Label

End Class
