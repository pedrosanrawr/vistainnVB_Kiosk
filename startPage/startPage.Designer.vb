<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class startPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(startPage))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.sidePanel = New System.Windows.Forms.Panel()
        Me.bookNowButton = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sidePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(100, 55)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(500, 130)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lato", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(96, 705)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(509, 25)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = """YOUR GETAWAY TO RELAXATION AND COMFORT"""
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'sidePanel
        '
        Me.sidePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.sidePanel.Controls.Add(Me.bookNowButton)
        Me.sidePanel.Controls.Add(Me.Label4)
        Me.sidePanel.Controls.Add(Me.PictureBox1)
        Me.sidePanel.Location = New System.Drawing.Point(442, 0)
        Me.sidePanel.Name = "sidePanel"
        Me.sidePanel.Size = New System.Drawing.Size(700, 790)
        Me.sidePanel.TabIndex = 2
        '
        'bookNowButton
        '
        Me.bookNowButton.BackColor = System.Drawing.Color.Transparent
        Me.bookNowButton.BorderRadius = 5
        Me.bookNowButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bookNowButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.bookNowButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.bookNowButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bookNowButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.bookNowButton.FillColor = System.Drawing.Color.Black
        Me.bookNowButton.Font = New System.Drawing.Font("Raleway", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.bookNowButton.ForeColor = System.Drawing.Color.White
        Me.bookNowButton.Location = New System.Drawing.Point(233, 405)
        Me.bookNowButton.Name = "bookNowButton"
        Me.bookNowButton.ShadowDecoration.BorderRadius = 5
        Me.bookNowButton.ShadowDecoration.Enabled = True
        Me.bookNowButton.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.bookNowButton.Size = New System.Drawing.Size(234, 80)
        Me.bookNowButton.TabIndex = 10
        Me.bookNowButton.Text = "BOOK NOW"
        '
        'startPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1142, 790)
        Me.Controls.Add(Me.sidePanel)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "startPage"
        Me.Text = "startPage"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sidePanel.ResumeLayout(False)
        Me.sidePanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents sidePanel As Panel
    Friend WithEvents bookNowButton As Guna.UI2.WinForms.Guna2Button
End Class
