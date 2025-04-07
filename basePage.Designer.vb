<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class basePage
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pagePanel = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'pagePanel
        '
        Me.pagePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pagePanel.Location = New System.Drawing.Point(0, 0)
        Me.pagePanel.Name = "pagePanel"
        Me.pagePanel.Size = New System.Drawing.Size(1142, 790)
        Me.pagePanel.TabIndex = 1
        '
        'basePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1142, 790)
        Me.Controls.Add(Me.pagePanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "basePage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Me.Opacity < 1 Then
            Me.Opacity += 0.05
        Else
            Timer1.Stop()
        End If
    End Sub

    Private Sub roundCorners(obj As Form)
        Dim DGP As New Drawing2D.GraphicsPath
        Dim radius = 25
        DGP.StartFigure()
        DGP.AddArc(New Rectangle(0, 0, radius, radius), 180, 90)
        DGP.AddLine(radius, 0, obj.Width - radius, 0)
        DGP.AddArc(New Rectangle(obj.Width - radius, 0, radius, radius), -90, 90)
        DGP.AddLine(obj.Width, radius, obj.Width, obj.Height - radius)
        DGP.AddArc(New Rectangle(obj.Width - radius, obj.Height - radius, radius, radius), 0, 90)
        DGP.AddLine(obj.Width - radius, obj.Height, radius, obj.Height)
        DGP.AddArc(New Rectangle(0, obj.Height - radius, radius, radius), 90, 90)
        DGP.CloseFigure()
        obj.Region = New Region(DGP)
    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents pagePanel As Panel
End Class
