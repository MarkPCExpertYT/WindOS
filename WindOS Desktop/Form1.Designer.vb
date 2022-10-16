<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.BatteryLbl = New System.Windows.Forms.Label()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.VolumeLbl = New System.Windows.Forms.Label()
        Me.VolumeIcon = New System.Windows.Forms.PictureBox()
        Me.Clock = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ChangeWallpaperToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetWallpaperToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WallpaperLayoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZoomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StretchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CenterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WallpaperDialog = New System.Windows.Forms.OpenFileDialog()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.UserLabel = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VolumeIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel1.Controls.Add(Me.Clock)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 600)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1016, 33)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(33, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(437, 33)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Label1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.ProgressBar1)
        Me.FlowLayoutPanel1.Controls.Add(Me.BatteryLbl)
        Me.FlowLayoutPanel1.Controls.Add(Me.TrackBar1)
        Me.FlowLayoutPanel1.Controls.Add(Me.VolumeLbl)
        Me.FlowLayoutPanel1.Controls.Add(Me.VolumeIcon)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(470, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(483, 33)
        Me.FlowLayoutPanel1.TabIndex = 4
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(409, 3)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(71, 27)
        Me.ProgressBar1.TabIndex = 2
        '
        'BatteryLbl
        '
        Me.BatteryLbl.ForeColor = System.Drawing.Color.White
        Me.BatteryLbl.Location = New System.Drawing.Point(336, 0)
        Me.BatteryLbl.Name = "BatteryLbl"
        Me.BatteryLbl.Size = New System.Drawing.Size(67, 33)
        Me.BatteryLbl.TabIndex = 3
        Me.BatteryLbl.Text = "null%" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Unknown"
        Me.BatteryLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(259, 3)
        Me.TrackBar1.Maximum = 100
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(71, 45)
        Me.TrackBar1.TabIndex = 5
        Me.TrackBar1.TickFrequency = 10
        Me.TrackBar1.Value = 100
        '
        'VolumeLbl
        '
        Me.VolumeLbl.ForeColor = System.Drawing.Color.White
        Me.VolumeLbl.Location = New System.Drawing.Point(219, 0)
        Me.VolumeLbl.Name = "VolumeLbl"
        Me.VolumeLbl.Size = New System.Drawing.Size(34, 33)
        Me.VolumeLbl.TabIndex = 6
        Me.VolumeLbl.Text = "100%"
        Me.VolumeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'VolumeIcon
        '
        Me.VolumeIcon.BackgroundImage = Global.WindOS_Desktop.My.Resources.Resources.volume_high
        Me.VolumeIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.VolumeIcon.Location = New System.Drawing.Point(184, 3)
        Me.VolumeIcon.Name = "VolumeIcon"
        Me.VolumeIcon.Size = New System.Drawing.Size(29, 30)
        Me.VolumeIcon.TabIndex = 4
        Me.VolumeIcon.TabStop = False
        '
        'Clock
        '
        Me.Clock.Dock = System.Windows.Forms.DockStyle.Right
        Me.Clock.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clock.ForeColor = System.Drawing.Color.White
        Me.Clock.Location = New System.Drawing.Point(953, 0)
        Me.Clock.Name = "Clock"
        Me.Clock.Size = New System.Drawing.Size(63, 33)
        Me.Clock.TabIndex = 1
        Me.Clock.Text = "00:00:00"
        Me.Clock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.WindOS_Desktop.My.Resources.Resources.leafoslogo
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(33, 33)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 250
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangeWallpaperToolStripMenuItem, Me.ResetWallpaperToolStripMenuItem, Me.WallpaperLayoutToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(172, 70)
        '
        'ChangeWallpaperToolStripMenuItem
        '
        Me.ChangeWallpaperToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ChangeWallpaperToolStripMenuItem.Name = "ChangeWallpaperToolStripMenuItem"
        Me.ChangeWallpaperToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ChangeWallpaperToolStripMenuItem.Text = "Change Wallpaper"
        '
        'ResetWallpaperToolStripMenuItem
        '
        Me.ResetWallpaperToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ResetWallpaperToolStripMenuItem.Name = "ResetWallpaperToolStripMenuItem"
        Me.ResetWallpaperToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ResetWallpaperToolStripMenuItem.Text = "Reset Wallpaper"
        '
        'WallpaperLayoutToolStripMenuItem
        '
        Me.WallpaperLayoutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ZoomToolStripMenuItem, Me.StretchToolStripMenuItem, Me.TileToolStripMenuItem, Me.CenterToolStripMenuItem})
        Me.WallpaperLayoutToolStripMenuItem.Name = "WallpaperLayoutToolStripMenuItem"
        Me.WallpaperLayoutToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.WallpaperLayoutToolStripMenuItem.Text = "Wallpaper layout"
        '
        'ZoomToolStripMenuItem
        '
        Me.ZoomToolStripMenuItem.Name = "ZoomToolStripMenuItem"
        Me.ZoomToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.ZoomToolStripMenuItem.Text = "Zoom"
        '
        'StretchToolStripMenuItem
        '
        Me.StretchToolStripMenuItem.Name = "StretchToolStripMenuItem"
        Me.StretchToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.StretchToolStripMenuItem.Text = "Stretch"
        '
        'TileToolStripMenuItem
        '
        Me.TileToolStripMenuItem.Name = "TileToolStripMenuItem"
        Me.TileToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.TileToolStripMenuItem.Text = "Tile"
        '
        'CenterToolStripMenuItem
        '
        Me.CenterToolStripMenuItem.Checked = True
        Me.CenterToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CenterToolStripMenuItem.Name = "CenterToolStripMenuItem"
        Me.CenterToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.CenterToolStripMenuItem.Text = "Center"
        '
        'WallpaperDialog
        '
        Me.WallpaperDialog.Filter = "PNG Images|*.png|JPEG Images|*.jpg;*.jpeg|Bitmaps|*.bmp|All Files|*.*"
        Me.WallpaperDialog.Title = "Please select an image"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.UserLabel)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.ListBox1)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(0, 359)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(242, 242)
        Me.Panel2.TabIndex = 2
        Me.Panel2.Tag = "false"
        Me.Panel2.Visible = False
        '
        'UserLabel
        '
        Me.UserLabel.ForeColor = System.Drawing.Color.White
        Me.UserLabel.Location = New System.Drawing.Point(111, 202)
        Me.UserLabel.Name = "UserLabel"
        Me.UserLabel.Size = New System.Drawing.Size(100, 36)
        Me.UserLabel.TabIndex = 4
        Me.UserLabel.Text = "Running on user: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "null"
        Me.UserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.WindOS_Desktop.My.Resources.Resources.power
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Location = New System.Drawing.Point(64, 202)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(41, 37)
        Me.Button2.TabIndex = 3
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Baloo", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(65, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 27)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Applications"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.ForeColor = System.Drawing.Color.White
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 19
        Me.ListBox1.Items.AddRange(New Object() {"File Manager", "WindSurfer", "BreezePad", "WindMedia"})
        Me.ListBox1.Location = New System.Drawing.Point(64, 28)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(178, 171)
        Me.ListBox1.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindOS_Desktop.My.Resources.Resources.windbanner
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(65, 239)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.BackgroundImage = Global.WindOS_Desktop.My.Resources.Resources.leaf_better
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1016, 633)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "WindOS Denali Desktop"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VolumeIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Clock As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ChangeWallpaperToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WallpaperDialog As OpenFileDialog
    Friend WithEvents ResetWallpaperToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WallpaperLayoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ZoomToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StretchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CenterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents BatteryLbl As Label
    Friend WithEvents VolumeIcon As PictureBox
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents VolumeLbl As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents UserLabel As Label
    Friend WithEvents Label1 As Label
End Class
