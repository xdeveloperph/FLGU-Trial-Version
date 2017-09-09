<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SearchForm))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbnor = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cbdisease = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cboccupation = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.tbpwd = New System.Windows.Forms.TextBox()
        Me.cbst = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cbphiltype = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cbosy = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbgender = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbbloodtype = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbkeystring = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbcategory = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbpurok = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbbir = New System.Windows.Forms.ComboBox()
        Me.cbbarangay = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbphil = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbcity = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.paneloading = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.paneloading.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.tbnor)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.cbdisease)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.cboccupation)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.tbpwd)
        Me.GroupBox1.Controls.Add(Me.cbst)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.cbphiltype)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.cbosy)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.cbgender)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.cbbloodtype)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.tbkeystring)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.cbcategory)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cbpurok)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cbbir)
        Me.GroupBox1.Controls.Add(Me.cbbarangay)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cbphil)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cbcity)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(20, 13)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(985, 242)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Option"
        '
        'tbnor
        '
        Me.tbnor.Location = New System.Drawing.Point(858, 158)
        Me.tbnor.Name = "tbnor"
        Me.tbnor.ReadOnly = True
        Me.tbnor.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.tbnor.Size = New System.Drawing.Size(110, 24)
        Me.tbnor.TabIndex = 36
        Me.tbnor.Text = "10"
        Me.tbnor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(701, 161)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(121, 18)
        Me.Label18.TabIndex = 35
        Me.Label18.Text = "Number of Rows"
        '
        'cbdisease
        '
        Me.cbdisease.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbdisease.FormattingEnabled = True
        Me.cbdisease.Location = New System.Drawing.Point(791, 94)
        Me.cbdisease.Name = "cbdisease"
        Me.cbdisease.Size = New System.Drawing.Size(177, 26)
        Me.cbdisease.TabIndex = 34
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(701, 97)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(62, 18)
        Me.Label15.TabIndex = 33
        Me.Label15.Text = "Disease"
        '
        'cboccupation
        '
        Me.cboccupation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboccupation.FormattingEnabled = True
        Me.cboccupation.Location = New System.Drawing.Point(791, 62)
        Me.cboccupation.Name = "cboccupation"
        Me.cboccupation.Size = New System.Drawing.Size(177, 26)
        Me.cboccupation.TabIndex = 32
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(701, 65)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(84, 18)
        Me.Label16.TabIndex = 31
        Me.Label16.Text = "Occupation"
        '
        'tbpwd
        '
        Me.tbpwd.Location = New System.Drawing.Point(791, 126)
        Me.tbpwd.Name = "tbpwd"
        Me.tbpwd.Size = New System.Drawing.Size(177, 24)
        Me.tbpwd.TabIndex = 30
        '
        'cbst
        '
        Me.cbst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbst.FormattingEnabled = True
        Me.cbst.Location = New System.Drawing.Point(126, 126)
        Me.cbst.Name = "cbst"
        Me.cbst.Size = New System.Drawing.Size(225, 26)
        Me.cbst.TabIndex = 29
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(17, 129)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(95, 18)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "Social Status"
        '
        'cbphiltype
        '
        Me.cbphiltype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbphiltype.FormattingEnabled = True
        Me.cbphiltype.Location = New System.Drawing.Point(488, 62)
        Me.cbphiltype.Name = "cbphiltype"
        Me.cbphiltype.Size = New System.Drawing.Size(183, 26)
        Me.cbphiltype.TabIndex = 27
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(368, 65)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(107, 18)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Philhealth Type"
        '
        'cbosy
        '
        Me.cbosy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbosy.FormattingEnabled = True
        Me.cbosy.Location = New System.Drawing.Point(126, 158)
        Me.cbosy.Name = "cbosy"
        Me.cbosy.Size = New System.Drawing.Size(225, 26)
        Me.cbosy.TabIndex = 25
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(17, 161)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(39, 18)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "OSY"
        '
        'cbgender
        '
        Me.cbgender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbgender.FormattingEnabled = True
        Me.cbgender.Location = New System.Drawing.Point(488, 158)
        Me.cbgender.Name = "cbgender"
        Me.cbgender.Size = New System.Drawing.Size(183, 26)
        Me.cbgender.TabIndex = 21
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(368, 161)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 18)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Gender"
        '
        'cbbloodtype
        '
        Me.cbbloodtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbloodtype.FormattingEnabled = True
        Me.cbbloodtype.Location = New System.Drawing.Point(488, 126)
        Me.cbbloodtype.Name = "cbbloodtype"
        Me.cbbloodtype.Size = New System.Drawing.Size(183, 26)
        Me.cbbloodtype.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(368, 129)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 18)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Blood Type"
        '
        'tbkeystring
        '
        Me.tbkeystring.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbkeystring.Location = New System.Drawing.Point(126, 190)
        Me.tbkeystring.Name = "tbkeystring"
        Me.tbkeystring.Size = New System.Drawing.Size(842, 29)
        Me.tbkeystring.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 197)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 18)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Keyword"
        '
        'cbcategory
        '
        Me.cbcategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbcategory.FormattingEnabled = True
        Me.cbcategory.Location = New System.Drawing.Point(791, 30)
        Me.cbcategory.Name = "cbcategory"
        Me.cbcategory.Size = New System.Drawing.Size(177, 26)
        Me.cbcategory.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(701, 33)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 18)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Category"
        '
        'cbpurok
        '
        Me.cbpurok.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbpurok.FormattingEnabled = True
        Me.cbpurok.Location = New System.Drawing.Point(126, 94)
        Me.cbpurok.Name = "cbpurok"
        Me.cbpurok.Size = New System.Drawing.Size(225, 26)
        Me.cbpurok.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(701, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 18)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "PWD"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Purok"
        '
        'cbbir
        '
        Me.cbbir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbir.FormattingEnabled = True
        Me.cbbir.Location = New System.Drawing.Point(488, 94)
        Me.cbbir.Name = "cbbir"
        Me.cbbir.Size = New System.Drawing.Size(183, 26)
        Me.cbbir.TabIndex = 9
        '
        'cbbarangay
        '
        Me.cbbarangay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbarangay.FormattingEnabled = True
        Me.cbbarangay.Location = New System.Drawing.Point(126, 62)
        Me.cbbarangay.Name = "cbbarangay"
        Me.cbbarangay.Size = New System.Drawing.Size(225, 26)
        Me.cbbarangay.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(368, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 18)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "BIR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Barangay"
        '
        'cbphil
        '
        Me.cbphil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbphil.FormattingEnabled = True
        Me.cbphil.Location = New System.Drawing.Point(488, 30)
        Me.cbphil.Name = "cbphil"
        Me.cbphil.Size = New System.Drawing.Size(183, 26)
        Me.cbphil.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(368, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 18)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Philhealth"
        '
        'cbcity
        '
        Me.cbcity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbcity.FormattingEnabled = True
        Me.cbcity.Location = New System.Drawing.Point(126, 30)
        Me.cbcity.Name = "cbcity"
        Me.cbcity.Size = New System.Drawing.Size(225, 26)
        Me.cbcity.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "City"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.btnclose)
        Me.GroupBox2.Controls.Add(Me.btnedit)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(1011, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(77, 433)
        Me.GroupBox2.TabIndex = 52
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Menu"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.BackgroundImage = Global.FLGU.My.Resources.Resources.Excel_icon
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Location = New System.Drawing.Point(16, 158)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(45, 45)
        Me.Button2.TabIndex = 58
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(20, 206)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 13)
        Me.Label11.TabIndex = 59
        Me.Label11.Text = "Export"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.BackgroundImage = Global.FLGU.My.Resources.Resources.search_icon
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(16, 30)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(45, 45)
        Me.Button1.TabIndex = 56
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(18, 78)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(41, 13)
        Me.Label17.TabIndex = 57
        Me.Label17.Text = "Search"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(22, 269)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(33, 13)
        Me.Label19.TabIndex = 53
        Me.Label19.Text = "Close"
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnclose.BackgroundImage = Global.FLGU.My.Resources.Resources.application_delete_icon
        Me.btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnclose.Location = New System.Drawing.Point(16, 222)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(45, 45)
        Me.btnclose.TabIndex = 52
        Me.btnclose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'btnedit
        '
        Me.btnedit.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnedit.BackgroundImage = Global.FLGU.My.Resources.Resources.Actions_view_list_details_icon
        Me.btnedit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnedit.Location = New System.Drawing.Point(16, 94)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(45, 45)
        Me.btnedit.TabIndex = 47
        Me.btnedit.UseVisualStyleBackColor = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(23, 142)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(30, 13)
        Me.Label21.TabIndex = 49
        Me.Label21.Text = "View"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.DataGridView1.ColumnHeadersHeight = 30
        Me.DataGridView1.Location = New System.Drawing.Point(20, 262)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(984, 359)
        Me.DataGridView1.TabIndex = 53
        '
        'BackgroundWorker1
        '
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = Global.FLGU.My.Resources.Resources.gif_load
        Me.PictureBox1.Location = New System.Drawing.Point(7, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(120, 120)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 54
        Me.PictureBox1.TabStop = False
        '
        'paneloading
        '
        Me.paneloading.BackColor = System.Drawing.Color.CadetBlue
        Me.paneloading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.paneloading.Controls.Add(Me.PictureBox1)
        Me.paneloading.Location = New System.Drawing.Point(450, 364)
        Me.paneloading.Name = "paneloading"
        Me.paneloading.Size = New System.Drawing.Size(135, 135)
        Me.paneloading.TabIndex = 55
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Button4)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.Button6)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(1011, 452)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(77, 169)
        Me.GroupBox3.TabIndex = 60
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Page"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button4.BackgroundImage = Global.FLGU.My.Resources.Resources.Actions_go_previous_view_icon
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Enabled = False
        Me.Button4.Location = New System.Drawing.Point(16, 30)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(45, 45)
        Me.Button4.TabIndex = 56
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(14, 78)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(48, 13)
        Me.Label20.TabIndex = 57
        Me.Label20.Text = "Previous"
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button6.BackgroundImage = Global.FLGU.My.Resources.Resources.Actions_go_next_view_icon
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button6.Enabled = False
        Me.Button6.Location = New System.Drawing.Point(16, 94)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(45, 45)
        Me.Button6.TabIndex = 47
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(24, 142)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(29, 13)
        Me.Label23.TabIndex = 49
        Me.Label23.Text = "Next"
        '
        'SearchForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FLGU.My.Resources.Resources.formbackground3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1103, 633)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.paneloading)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "SearchForm"
        Me.Text = "SearchForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.paneloading.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbbloodtype As System.Windows.Forms.ComboBox
    Private WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbkeystring As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cbcategory As System.Windows.Forms.ComboBox
    Private WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbpurok As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbbir As System.Windows.Forms.ComboBox
    Friend WithEvents cbbarangay As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbphil As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbcity As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbphiltype As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cbosy As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cbgender As System.Windows.Forms.ComboBox
    Private WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cbst As System.Windows.Forms.ComboBox
    Private WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cbdisease As System.Windows.Forms.ComboBox
    Private WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cboccupation As System.Windows.Forms.ComboBox
    Private WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents tbpwd As System.Windows.Forms.TextBox
    Private WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents paneloading As System.Windows.Forms.Panel
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents tbnor As System.Windows.Forms.TextBox
    Private WithEvents Label18 As System.Windows.Forms.Label
End Class
