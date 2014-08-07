<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Prac03
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
        Me.lblUBN = New System.Windows.Forms.Label()
        Me.txtUBN = New System.Windows.Forms.TextBox()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lsbPrimeNumbers = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lblUBN
        '
        Me.lblUBN.AutoSize = True
        Me.lblUBN.Location = New System.Drawing.Point(57, 55)
        Me.lblUBN.Name = "lblUBN"
        Me.lblUBN.Size = New System.Drawing.Size(113, 13)
        Me.lblUBN.TabIndex = 0
        Me.lblUBN.Text = "Upper Bound Number:"
        '
        'txtUBN
        '
        Me.txtUBN.Location = New System.Drawing.Point(176, 48)
        Me.txtUBN.Name = "txtUBN"
        Me.txtUBN.Size = New System.Drawing.Size(100, 20)
        Me.txtUBN.TabIndex = 1
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(60, 105)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(216, 22)
        Me.btnDisplay.TabIndex = 2
        Me.btnDisplay.Text = "Display Prime Numbers"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(60, 133)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(216, 22)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lsbPrimeNumbers
        '
        Me.lsbPrimeNumbers.FormattingEnabled = True
        Me.lsbPrimeNumbers.Location = New System.Drawing.Point(376, 41)
        Me.lsbPrimeNumbers.Name = "lsbPrimeNumbers"
        Me.lsbPrimeNumbers.Size = New System.Drawing.Size(366, 264)
        Me.lsbPrimeNumbers.TabIndex = 4
        '
        'Prac03
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 346)
        Me.Controls.Add(Me.lsbPrimeNumbers)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.txtUBN)
        Me.Controls.Add(Me.lblUBN)
        Me.Name = "Prac03"
        Me.Text = "ICT3611-Prac03"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblUBN As System.Windows.Forms.Label
    Friend WithEvents txtUBN As System.Windows.Forms.TextBox
    Friend WithEvents btnDisplay As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lsbPrimeNumbers As System.Windows.Forms.ListBox

End Class
