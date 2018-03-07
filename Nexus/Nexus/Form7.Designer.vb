<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form7))
        Me.BunifuCircleProgressbar1 = New Bunifu.Framework.UI.BunifuCircleProgressbar()
        Me.BunifuCircleProgressbar2 = New Bunifu.Framework.UI.BunifuCircleProgressbar()
        Me.BunifuCircleProgressbar3 = New Bunifu.Framework.UI.BunifuCircleProgressbar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuCircleProgressbar1
        '
        Me.BunifuCircleProgressbar1.BackColor = System.Drawing.SystemColors.Control
        Me.BunifuCircleProgressbar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!)
        Me.BunifuCircleProgressbar1.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuCircleProgressbar1.LabelVisible = True
        Me.BunifuCircleProgressbar1.LineThickness = 10
        Me.BunifuCircleProgressbar1.Location = New System.Drawing.Point(1, 281)
        Me.BunifuCircleProgressbar1.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.BunifuCircleProgressbar1.MaxValue = 100
        Me.BunifuCircleProgressbar1.Name = "BunifuCircleProgressbar1"
        Me.BunifuCircleProgressbar1.ProgressBackColor = System.Drawing.Color.Gainsboro
        Me.BunifuCircleProgressbar1.ProgressColor = System.Drawing.Color.SeaGreen
        Me.BunifuCircleProgressbar1.Size = New System.Drawing.Size(201, 201)
        Me.BunifuCircleProgressbar1.TabIndex = 0
        Me.BunifuCircleProgressbar1.Value = 0
        '
        'BunifuCircleProgressbar2
        '
        Me.BunifuCircleProgressbar2.BackColor = System.Drawing.SystemColors.Control
        Me.BunifuCircleProgressbar2.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!)
        Me.BunifuCircleProgressbar2.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuCircleProgressbar2.LabelVisible = True
        Me.BunifuCircleProgressbar2.LineThickness = 10
        Me.BunifuCircleProgressbar2.Location = New System.Drawing.Point(262, 281)
        Me.BunifuCircleProgressbar2.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.BunifuCircleProgressbar2.MaxValue = 100
        Me.BunifuCircleProgressbar2.Name = "BunifuCircleProgressbar2"
        Me.BunifuCircleProgressbar2.ProgressBackColor = System.Drawing.Color.Gainsboro
        Me.BunifuCircleProgressbar2.ProgressColor = System.Drawing.Color.SeaGreen
        Me.BunifuCircleProgressbar2.Size = New System.Drawing.Size(201, 201)
        Me.BunifuCircleProgressbar2.TabIndex = 1
        Me.BunifuCircleProgressbar2.Value = 0
        '
        'BunifuCircleProgressbar3
        '
        Me.BunifuCircleProgressbar3.BackColor = System.Drawing.SystemColors.Control
        Me.BunifuCircleProgressbar3.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!)
        Me.BunifuCircleProgressbar3.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuCircleProgressbar3.LabelVisible = True
        Me.BunifuCircleProgressbar3.LineThickness = 10
        Me.BunifuCircleProgressbar3.Location = New System.Drawing.Point(536, 281)
        Me.BunifuCircleProgressbar3.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.BunifuCircleProgressbar3.MaxValue = 100
        Me.BunifuCircleProgressbar3.Name = "BunifuCircleProgressbar3"
        Me.BunifuCircleProgressbar3.ProgressBackColor = System.Drawing.Color.Gainsboro
        Me.BunifuCircleProgressbar3.ProgressColor = System.Drawing.Color.SeaGreen
        Me.BunifuCircleProgressbar3.Size = New System.Drawing.Size(201, 201)
        Me.BunifuCircleProgressbar3.TabIndex = 2
        Me.BunifuCircleProgressbar3.Value = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label1.Location = New System.Drawing.Point(84, 259)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "CPU"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label2.Location = New System.Drawing.Point(338, 259)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "GPU"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label3.Location = New System.Drawing.Point(586, 255)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "HD/SSD speed "
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 4000
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.Label4.Location = New System.Drawing.Point(377, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "SpeedTest"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(800, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(45, 42)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(734, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(45, 42)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(857, 482)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BunifuCircleProgressbar3)
        Me.Controls.Add(Me.BunifuCircleProgressbar2)
        Me.Controls.Add(Me.BunifuCircleProgressbar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form7"
        Me.Text = "Form7"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuCircleProgressbar1 As Bunifu.Framework.UI.BunifuCircleProgressbar
    Friend WithEvents BunifuCircleProgressbar2 As Bunifu.Framework.UI.BunifuCircleProgressbar
    Friend WithEvents BunifuCircleProgressbar3 As Bunifu.Framework.UI.BunifuCircleProgressbar
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
