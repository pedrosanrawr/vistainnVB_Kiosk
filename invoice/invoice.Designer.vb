<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class invoice
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(invoice))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Guna2Shapes1 = New Guna.UI2.WinForms.Guna2Shapes()
        Me.infoLabel = New System.Windows.Forms.Label()
        Me.totalPriceLabel = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.vatLabel = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dateLabel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.referenceNoLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.informationLabel = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.okayButton = New Guna.UI2.WinForms.Guna2Button()
        Me.redirectLabel = New System.Windows.Forms.Label()
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Guna2Shapes1)
        Me.Panel1.Controls.Add(Me.infoLabel)
        Me.Panel1.Controls.Add(Me.totalPriceLabel)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.vatLabel)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.dateLabel)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.referenceNoLabel)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.informationLabel)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(571, 790)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(431, 54)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(80, 80)
        Me.PictureBox1.TabIndex = 76
        Me.PictureBox1.TabStop = False
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Lato", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(31, 704)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(480, 50)
        Me.Label15.TabIndex = 75
        Me.Label15.Text = "Address: Metro Manila, Philippines"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Lato", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(31, 654)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(480, 50)
        Me.Label14.TabIndex = 74
        Me.Label14.Text = "Phone No.: 09506654718"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Lato", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(31, 604)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(480, 50)
        Me.Label13.TabIndex = 73
        Me.Label13.Text = "Email: Vistainn@gmail.com"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Lato", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(45, 554)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(480, 50)
        Me.Label12.TabIndex = 72
        Me.Label12.Text = "Thanks for choosing Vistainn!"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2Shapes1
        '
        Me.Guna2Shapes1.BorderColor = System.Drawing.Color.Black
        Me.Guna2Shapes1.BorderThickness = 0
        Me.Guna2Shapes1.FillColor = System.Drawing.Color.Black
        Me.Guna2Shapes1.LineThickness = 1
        Me.Guna2Shapes1.Location = New System.Drawing.Point(0, 534)
        Me.Guna2Shapes1.Name = "Guna2Shapes1"
        Me.Guna2Shapes1.PolygonSkip = 1
        Me.Guna2Shapes1.Rotate = 0!
        Me.Guna2Shapes1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Line
        Me.Guna2Shapes1.Size = New System.Drawing.Size(571, 24)
        Me.Guna2Shapes1.TabIndex = 71
        Me.Guna2Shapes1.Text = "Guna2Shapes1"
        Me.Guna2Shapes1.Zoom = 80
        '
        'infoLabel
        '
        Me.infoLabel.Font = New System.Drawing.Font("Lato", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.infoLabel.Location = New System.Drawing.Point(45, 444)
        Me.infoLabel.Name = "infoLabel"
        Me.infoLabel.Size = New System.Drawing.Size(480, 77)
        Me.infoLabel.TabIndex = 70
        Me.infoLabel.Text = "Please complete your payment to confirm your booking."
        Me.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'totalPriceLabel
        '
        Me.totalPriceLabel.Font = New System.Drawing.Font("Lato", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.totalPriceLabel.Location = New System.Drawing.Point(440, 357)
        Me.totalPriceLabel.Name = "totalPriceLabel"
        Me.totalPriceLabel.Size = New System.Drawing.Size(122, 26)
        Me.totalPriceLabel.TabIndex = 69
        Me.totalPriceLabel.Text = "$5000.00"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Raleway", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(281, 354)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(156, 26)
        Me.Label9.TabIndex = 68
        Me.Label9.Text = "AMOUNT DUE:"
        '
        'vatLabel
        '
        Me.vatLabel.Font = New System.Drawing.Font("Lato", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.vatLabel.Location = New System.Drawing.Point(121, 306)
        Me.vatLabel.Name = "vatLabel"
        Me.vatLabel.Size = New System.Drawing.Size(122, 26)
        Me.vatLabel.TabIndex = 67
        Me.vatLabel.Text = "$4.00"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Raleway", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(31, 304)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 26)
        Me.Label8.TabIndex = 66
        Me.Label8.Text = "VAT (8%):"
        '
        'dateLabel
        '
        Me.dateLabel.Font = New System.Drawing.Font("Lato", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.dateLabel.Location = New System.Drawing.Point(158, 256)
        Me.dateLabel.Name = "dateLabel"
        Me.dateLabel.Size = New System.Drawing.Size(122, 26)
        Me.dateLabel.TabIndex = 65
        Me.dateLabel.Text = "04/04/25"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Raleway", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(31, 254)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 26)
        Me.Label5.TabIndex = 64
        Me.Label5.Text = "DATE ISSUED:"
        '
        'referenceNoLabel
        '
        Me.referenceNoLabel.Font = New System.Drawing.Font("Lato", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.referenceNoLabel.Location = New System.Drawing.Point(179, 206)
        Me.referenceNoLabel.Name = "referenceNoLabel"
        Me.referenceNoLabel.Size = New System.Drawing.Size(122, 26)
        Me.referenceNoLabel.TabIndex = 63
        Me.referenceNoLabel.Text = "A0545415664"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Raleway", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 204)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 26)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "REFERENCE NO.:"
        '
        'informationLabel
        '
        Me.informationLabel.Font = New System.Drawing.Font("Lato", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.informationLabel.Location = New System.Drawing.Point(31, 84)
        Me.informationLabel.Name = "informationLabel"
        Me.informationLabel.Size = New System.Drawing.Size(296, 70)
        Me.informationLabel.TabIndex = 61
        Me.informationLabel.Text = "Peter Jhon Dones" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "09506654718" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "peterjohndones112@gmail"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Raleway", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(31, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(167, 26)
        Me.Label7.TabIndex = 60
        Me.Label7.Text = "BILLED TO:"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(611, 55)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(500, 130)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Raleway", 32.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(670, 305)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(383, 45)
        Me.Label16.TabIndex = 77
        Me.Label16.Text = "BOOKING CONFIRMED!"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Raleway", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(670, 355)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(383, 45)
        Me.Label17.TabIndex = 78
        Me.Label17.Text = "ENJOY THE STAY!"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'okayButton
        '
        Me.okayButton.BackColor = System.Drawing.Color.Transparent
        Me.okayButton.BorderRadius = 5
        Me.okayButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.okayButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.okayButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.okayButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.okayButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.okayButton.FillColor = System.Drawing.Color.Black
        Me.okayButton.Font = New System.Drawing.Font("Raleway", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.okayButton.ForeColor = System.Drawing.Color.White
        Me.okayButton.Location = New System.Drawing.Point(796, 486)
        Me.okayButton.Name = "okayButton"
        Me.okayButton.ShadowDecoration.BorderRadius = 5
        Me.okayButton.ShadowDecoration.Enabled = True
        Me.okayButton.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.okayButton.Size = New System.Drawing.Size(130, 50)
        Me.okayButton.TabIndex = 79
        Me.okayButton.Text = "OKAY"
        '
        'redirectLabel
        '
        Me.redirectLabel.Font = New System.Drawing.Font("Lato", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.redirectLabel.Location = New System.Drawing.Point(698, 656)
        Me.redirectLabel.Name = "redirectLabel"
        Me.redirectLabel.Size = New System.Drawing.Size(315, 30)
        Me.redirectLabel.TabIndex = 77
        Me.redirectLabel.Text = "Redirecting to the start page in 15 seconds..."
        Me.redirectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'timer
        '
        '
        'invoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1142, 790)
        Me.Controls.Add(Me.redirectLabel)
        Me.Controls.Add(Me.okayButton)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "invoice"
        Me.Text = "  "
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents informationLabel As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents referenceNoLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents vatLabel As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents dateLabel As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents totalPriceLabel As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Guna2Shapes1 As Guna.UI2.WinForms.Guna2Shapes
    Friend WithEvents infoLabel As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents okayButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents redirectLabel As Label
    Friend WithEvents timer As Timer
End Class
