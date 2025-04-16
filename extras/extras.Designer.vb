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
        Me.itemFlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.itemPanel = New System.Windows.Forms.Panel()
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
        Me.cancelButton = New Guna.UI2.WinForms.Guna2Button()
        Me.backButton = New Guna.UI2.WinForms.Guna2Button()
        Me.itemFlowLayoutPanel.SuspendLayout()
        Me.itemPanel.SuspendLayout()
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
        'itemFlowLayoutPanel
        '
        Me.itemFlowLayoutPanel.AutoScroll = True
        Me.itemFlowLayoutPanel.Controls.Add(Me.itemPanel)
        Me.itemFlowLayoutPanel.Location = New System.Drawing.Point(120, 220)
        Me.itemFlowLayoutPanel.Name = "itemFlowLayoutPanel"
        Me.itemFlowLayoutPanel.Size = New System.Drawing.Size(930, 430)
        Me.itemFlowLayoutPanel.TabIndex = 2
        '
        'itemPanel
        '
        Me.itemPanel.Controls.Add(Me.QtyLabel)
        Me.itemPanel.Controls.Add(Me.incrementQtyButton)
        Me.itemPanel.Controls.Add(Me.decrementQtyButton)
        Me.itemPanel.Controls.Add(Me.extrasPrice)
        Me.itemPanel.Controls.Add(Me.extrasName)
        Me.itemPanel.Controls.Add(Me.selectCheckBox)
        Me.itemPanel.Location = New System.Drawing.Point(3, 3)
        Me.itemPanel.Name = "itemPanel"
        Me.itemPanel.Size = New System.Drawing.Size(924, 70)
        Me.itemPanel.TabIndex = 0
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
        'cancelButton
        '
        Me.cancelButton.BackColor = System.Drawing.Color.Transparent
        Me.cancelButton.BorderColor = System.Drawing.Color.Transparent
        Me.cancelButton.BorderRadius = 5
        Me.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cancelButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.cancelButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.cancelButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.cancelButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.cancelButton.FillColor = System.Drawing.Color.Transparent
        Me.cancelButton.Font = New System.Drawing.Font("Raleway", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.cancelButton.ForeColor = System.Drawing.Color.Black
        Me.cancelButton.Location = New System.Drawing.Point(820, 705)
        Me.cancelButton.Name = "cancelButton"
        Me.cancelButton.PressedColor = System.Drawing.Color.Transparent
        Me.cancelButton.ShadowDecoration.BorderRadius = 5
        Me.cancelButton.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.cancelButton.Size = New System.Drawing.Size(130, 50)
        Me.cancelButton.TabIndex = 67
        Me.cancelButton.Text = "CANCEL"
        '
        'backButton
        '
        Me.backButton.BackColor = System.Drawing.Color.Transparent
        Me.backButton.BorderColor = System.Drawing.Color.Transparent
        Me.backButton.BorderRadius = 5
        Me.backButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.backButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.backButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.backButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.backButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.backButton.FillColor = System.Drawing.Color.Transparent
        Me.backButton.Font = New System.Drawing.Font("Raleway", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.backButton.ForeColor = System.Drawing.Color.Black
        Me.backButton.Location = New System.Drawing.Point(42, 705)
        Me.backButton.Name = "backButton"
        Me.backButton.PressedColor = System.Drawing.Color.Transparent
        Me.backButton.ShadowDecoration.BorderRadius = 5
        Me.backButton.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.backButton.Size = New System.Drawing.Size(130, 50)
        Me.backButton.TabIndex = 68
        Me.backButton.Text = "BACK"
        '
        'extras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1142, 790)
        Me.Controls.Add(Me.backButton)
        Me.Controls.Add(Me.cancelButton)
        Me.Controls.Add(Me.nextButton)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.itemFlowLayoutPanel)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "extras"
        Me.Text = "extras"
        Me.itemFlowLayoutPanel.ResumeLayout(False)
        Me.itemPanel.ResumeLayout(False)
        CType(Me.incrementQtyButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.decrementQtyButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents itemFlowLayoutPanel As FlowLayoutPanel
    Friend WithEvents Label10 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents itemPanel As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents selectCheckBox As Guna.UI2.WinForms.Guna2CustomCheckBox
    Friend WithEvents extrasPrice As Label
    Friend WithEvents extrasName As Label
    Friend WithEvents incrementQtyButton As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents decrementQtyButton As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents QtyLabel As Label
    Friend WithEvents nextButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cancelButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents backButton As Guna.UI2.WinForms.Guna2Button
End Class
