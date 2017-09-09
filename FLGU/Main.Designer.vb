<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FILEToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VIEWToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccountToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarangayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DiseaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HouseholdToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OccupationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SocialStatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SystemLogsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PuronToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SEARCHToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DASHBOADRDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportBW = New System.ComponentModel.BackgroundWorker()
        Me.PurokToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurokToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripProgressBar1, Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 724)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1024, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(100, 16)
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        Me.ToolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FILEToolStripMenuItem1, Me.VIEWToolStripMenuItem, Me.SEARCHToolStripMenuItem, Me.DASHBOADRDToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1024, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FILEToolStripMenuItem1
        '
        Me.FILEToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImportToolStripMenuItem1, Me.ExitToolStripMenuItem1})
        Me.FILEToolStripMenuItem1.Name = "FILEToolStripMenuItem1"
        Me.FILEToolStripMenuItem1.Size = New System.Drawing.Size(40, 20)
        Me.FILEToolStripMenuItem1.Text = "FILE"
        '
        'ImportToolStripMenuItem1
        '
        Me.ImportToolStripMenuItem1.Name = "ImportToolStripMenuItem1"
        Me.ImportToolStripMenuItem1.Size = New System.Drawing.Size(139, 22)
        Me.ImportToolStripMenuItem1.Text = "Import Excel"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(139, 22)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'VIEWToolStripMenuItem
        '
        Me.VIEWToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AccountToolStripMenuItem1, Me.BarangayToolStripMenuItem, Me.CategoryToolStripMenuItem, Me.CityToolStripMenuItem, Me.DiseaseToolStripMenuItem, Me.HouseholdToolStripMenuItem, Me.OccupationToolStripMenuItem, Me.SocialStatusToolStripMenuItem, Me.SystemLogsToolStripMenuItem, Me.PuronToolStripMenuItem})
        Me.VIEWToolStripMenuItem.Name = "VIEWToolStripMenuItem"
        Me.VIEWToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.VIEWToolStripMenuItem.Text = "DATA"
        '
        'AccountToolStripMenuItem1
        '
        Me.AccountToolStripMenuItem1.Name = "AccountToolStripMenuItem1"
        Me.AccountToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.AccountToolStripMenuItem1.Text = "Account"
        '
        'BarangayToolStripMenuItem
        '
        Me.BarangayToolStripMenuItem.Name = "BarangayToolStripMenuItem"
        Me.BarangayToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BarangayToolStripMenuItem.Text = "Barangay"
        '
        'CategoryToolStripMenuItem
        '
        Me.CategoryToolStripMenuItem.Name = "CategoryToolStripMenuItem"
        Me.CategoryToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CategoryToolStripMenuItem.Text = "Category"
        '
        'CityToolStripMenuItem
        '
        Me.CityToolStripMenuItem.Name = "CityToolStripMenuItem"
        Me.CityToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CityToolStripMenuItem.Text = "City"
        '
        'DiseaseToolStripMenuItem
        '
        Me.DiseaseToolStripMenuItem.Name = "DiseaseToolStripMenuItem"
        Me.DiseaseToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DiseaseToolStripMenuItem.Text = "Disease"
        '
        'HouseholdToolStripMenuItem
        '
        Me.HouseholdToolStripMenuItem.Name = "HouseholdToolStripMenuItem"
        Me.HouseholdToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.HouseholdToolStripMenuItem.Text = "Household"
        '
        'OccupationToolStripMenuItem
        '
        Me.OccupationToolStripMenuItem.Name = "OccupationToolStripMenuItem"
        Me.OccupationToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OccupationToolStripMenuItem.Text = "Occupation"
        '
        'SocialStatusToolStripMenuItem
        '
        Me.SocialStatusToolStripMenuItem.Name = "SocialStatusToolStripMenuItem"
        Me.SocialStatusToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SocialStatusToolStripMenuItem.Text = "Social Status"
        '
        'SystemLogsToolStripMenuItem
        '
        Me.SystemLogsToolStripMenuItem.Name = "SystemLogsToolStripMenuItem"
        Me.SystemLogsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SystemLogsToolStripMenuItem.Text = "System Logs"
        '
        'PuronToolStripMenuItem
        '
        Me.PuronToolStripMenuItem.Name = "PuronToolStripMenuItem"
        Me.PuronToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PuronToolStripMenuItem.Text = "Purok"
        '
        'SEARCHToolStripMenuItem
        '
        Me.SEARCHToolStripMenuItem.Name = "SEARCHToolStripMenuItem"
        Me.SEARCHToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.SEARCHToolStripMenuItem.Text = "SEARCH"
        '
        'DASHBOADRDToolStripMenuItem
        '
        Me.DASHBOADRDToolStripMenuItem.Name = "DASHBOADRDToolStripMenuItem"
        Me.DASHBOADRDToolStripMenuItem.Size = New System.Drawing.Size(89, 20)
        Me.DASHBOADRDToolStripMenuItem.Text = "DASHBOARD"
        '
        'ImportBW
        '
        '
        'PurokToolStripMenuItem
        '
        Me.PurokToolStripMenuItem.Name = "PurokToolStripMenuItem"
        Me.PurokToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PurokToolStripMenuItem.Text = "Purok"
        '
        'PurokToolStripMenuItem1
        '
        Me.PurokToolStripMenuItem1.Name = "PurokToolStripMenuItem1"
        Me.PurokToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.PurokToolStripMenuItem1.Text = "Purok"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FLGU.My.Resources.Resources.back_3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1024, 746)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FLGU System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripProgressBar1 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FILEToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImportToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VIEWToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BarangayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CityToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DiseaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HouseholdToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OccupationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SEARCHToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DASHBOADRDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AccountToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SystemLogsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImportBW As System.ComponentModel.BackgroundWorker
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents CategoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SocialStatusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PurokToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PurokToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PuronToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
