<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class extras
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(extras))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.QtyLabel = New System.Windows.Forms.Label()
        Me.incrementQtyButton = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.decrementQtyButton = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.extrasPrice = New System.Windows.Forms.Label()
        Me.extrasName = New System.Windows.Forms.Label()
        Me.selectCheckBox = New Guna.UI2.WinForms.Guna2CustomCheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nextButton = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.incrementQtyButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.decrementQtyButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Raleway", 47.99999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(286, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(571, 67)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "EXTRAS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel1)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(120, 220)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(930, 430)
        Me.FlowLayoutPanel1.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.QtyLabel)
        Me.Panel1.Controls.Add(Me.incrementQtyButton)
        Me.Panel1.Controls.Add(Me.decrementQtyButton)
        Me.Panel1.Controls.Add(Me.extrasPrice)
        Me.Panel1.Controls.Add(Me.extrasName)
        Me.Panel1.Controls.Add(Me.selectCheckBox)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(927, 70)
        Me.Panel1.TabIndex = 0
        '
        'QtyLabel
        '
        Me.QtyLabel.Font = New System.Drawing.Font("Lato", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.QtyLabel.Location = New System.Drawing.Point(773, 12)
        Me.QtyLabel.Name = "QtyLabel"
        Me.QtyLabel.Size = New System.Drawing.Size(56, 34)
        Me.QtyLabel.TabIndex = 70
        Me.QtyLabel.Text = "0"
        Me.QtyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'incrementQtyButton
        '
        Me.incrementQtyButton.BackgroundImage = CType(resources.GetObject("incrementQtyButton.BackgroundImage"), System.Drawing.Image)
        Me.incrementQtyButton.FillColor = System.Drawing.Color.Transparent
        Me.incrementQtyButton.ImageRotate = 0!
        Me.incrementQtyButton.Location = New System.Drawing.Point(835, 16)
        Me.incrementQtyButton.Name = "incrementQtyButton"
        Me.incrementQtyButton.Size = New System.Drawing.Size(30, 30)
        Me.incrementQtyButton.TabIndex = 69
        Me.incrementQtyButton.TabStop = False
        '
        'decrementQtyButton
        '
        Me.decrementQtyButton.BackgroundImage = CType(resources.GetObject("decrementQtyButton.BackgroundImage"), System.Drawing.Image)
        Me.decrementQtyButton.FillColor = System.Drawing.Color.Transparent
        Me.decrementQtyButton.ImageRotate = 0!
        Me.decrementQtyButton.Location = New System.Drawing.Point(737, 16)
        Me.decrementQtyButton.Name = "decrementQtyButton"
        Me.decrementQtyButton.Size = New System.Drawing.Size(30, 30)
        Me.decrementQtyButton.TabIndex = 68
        Me.decrementQtyButton.TabStop = False
        '
        'extrasPrice
        '
        Me.extrasPrice.Font = New System.Drawing.Font("Lato", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.extrasPrice.Location = New System.Drawing.Point(481, 16)
        Me.extrasPrice.Name = "extrasPrice"
        Me.extrasPrice.Size = New System.Drawing.Size(192, 34)
        Me.extrasPrice.TabIndex = 67
        Me.extrasPrice.Text = "$500.00"
        Me.extrasPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'extrasName
        '
        Me.extrasName.Font = New System.Drawing.Font("Lato", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.extrasName.Location = New System.Drawing.Point(229, 16)
        Me.extrasName.Name = "extrasName"
        Me.extrasName.Size = New System.Drawing.Size(195, 34)
        Me.extrasName.TabIndex = 66
        Me.extrasName.Text = "ITEM"
        Me.extrasName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'selectCheckBox
        '
        Me.selectCheckBox.BackColor = System.Drawing.Color.Transparent
        Me.selectCheckBox.CheckedState.BorderColor = System.Drawing.Color.Black
        Me.selectCheckBox.CheckedState.BorderRadius = 2
        Me.selectCheckBox.CheckedState.BorderThickness = 3
        Me.selectCheckBox.CheckedState.FillColor = System.Drawing.Color.Black
        Me.selectCheckBox.Location = New System.Drawing.Point(66, 16)
        Me.selectCheckBox.Name = "selectCheckBox"
        Me.selectCheckBox.Size = New System.Drawing.Size(30, 30)
        Me.selectCheckBox.TabIndex = 0
        Me.selectCheckBox.Text = "Guna2CustomCheckBox1"
        Me.selectCheckBox.UncheckedState.BorderColor = System.Drawing.Color.Black
        Me.selectCheckBox.UncheckedState.BorderRadius = 2
        Me.selectCheckBox.UncheckedState.BorderThickness = 3
        Me.selectCheckBox.UncheckedState.FillColor = System.Drawing.Color.Transparent
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Raleway", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(156, 170)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(103, 34)
        Me.Label10.TabIndex = 62
        Me.Label10.Text = "SELECT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Raleway", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(395, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 34)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "EXTRAS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Raleway", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(656, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 34)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "PRICE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Raleway", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(856, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 34)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "QUANTITY"
        '
        'nextButton
        '
        Me.nextButton.BackColor = System.Drawing.Color.Transparent
        Me.nextButton.BorderRadius = 5
        Me.nextButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.nextButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.nextButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.nextButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.nextButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.nextButton.FillColor = System.Drawing.Color.Black
        Me.nextButton.Font = New System.Drawing.Font("Raleway", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.nextButton.ForeColor = System.Drawing.Color.White
        Me.nextButton.Location = New System.Drawing.Point(970, 705)
        Me.nextButton.Name = "nextButton"
        Me.nextButton.ShadowDecoration.BorderRadius = 5
        Me.nextButton.ShadowDecoration.Enabled = True
        Me.nextButton.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.nextButton.Size = New System.Drawing.Size(130, 50)
        Me.nextButton.TabIndex = 66
        Me.nextButton.Text = "NEXT"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.BorderRadius = 5
        Me.Guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.Font = New System.Drawing.Font("Raleway", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.Black
        Me.Guna2Button1.Location = New System.Drawing.Point(820, 705)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.PressedColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.ShadowDecoration.BorderRadius = 5
        Me.Guna2Button1.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.Guna2Button1.Size = New System.Drawing.Size(130, 50)
        Me.Guna2Button1.TabIndex = 67
        Me.Guna2Button1.Text = "CANCEL"
        '
        'Guna2Button2
        '
        Me.Guna2Button2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button2.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Button2.BorderRadius = 5
        Me.Guna2Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button2.Font = New System.Drawing.Font("Raleway", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Guna2Button2.ForeColor = System.Drawing.Color.Black
        Me.Guna2Button2.Location = New System.Drawing.Point(42, 705)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.PressedColor = System.Drawing.Color.Transparent
        Me.Guna2Button2.ShadowDecoration.BorderRadius = 5
        Me.Guna2Button2.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.Guna2Button2.Size = New System.Drawing.Size(130, 50)
        Me.Guna2Button2.TabIndex = 68
        Me.Guna2Button2.Text = "BACK"
        '
        'extras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1142, 790)
        Me.Controls.Add(Me.Guna2Button2)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.nextButton)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "extras"
        Me.Text = "extras"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.incrementQtyButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decrementQtyButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label10 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents selectCheckBox As Guna.UI2.WinForms.Guna2CustomCheckBox
    Friend WithEvents extrasPrice As Label
    Friend WithEvents extrasName As Label
    Friend WithEvents incrementQtyButton As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents decrementQtyButton As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents QtyLabel As Label
    Friend WithEvents nextButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
End Class
