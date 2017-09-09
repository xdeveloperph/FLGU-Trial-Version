<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccountForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AccountForm))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnremove = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tbvpassword = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbpassword = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbusername = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tblname = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbmi = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbfname = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cbadministrator = New System.Windows.Forms.CheckBox()
        Me.cbdelete = New System.Windows.Forms.CheckBox()
        Me.cbimport = New System.Windows.Forms.CheckBox()
        Me.cbedit = New System.Windows.Forms.CheckBox()
        Me.cbexport = New System.Windows.Forms.CheckBox()
        Me.cbcreate = New System.Windows.Forms.CheckBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeight = 30
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(20, 362)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(449, 146)
        Me.DataGridView1.TabIndex = 48
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.btnclose)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.btnadd)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.btnedit)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.btncancel)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.btnsave)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.btnremove)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(475, 16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(72, 492)
        Me.GroupBox2.TabIndex = 47
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Menu"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(20, 389)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 13)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Close"
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnclose.BackgroundImage = Global.FLGU.My.Resources.Resources.application_delete_icon
        Me.btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnclose.Location = New System.Drawing.Point(13, 342)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(45, 45)
        Me.btnclose.TabIndex = 35
        Me.btnclose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 326)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Remove"
        '
        'btnadd
        '
        Me.btnadd.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnadd.BackgroundImage = Global.FLGU.My.Resources.Resources.Button_Add_icon
        Me.btnadd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnadd.Location = New System.Drawing.Point(13, 19)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(45, 45)
        Me.btnadd.TabIndex = 24
        Me.btnadd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 262)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Cancel"
        '
        'btnedit
        '
        Me.btnedit.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnedit.BackgroundImage = Global.FLGU.My.Resources.Resources.edit_validated_icon
        Me.btnedit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnedit.Location = New System.Drawing.Point(13, 86)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(45, 45)
        Me.btnedit.TabIndex = 25
        Me.btnedit.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 198)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Save"
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btncancel.BackgroundImage = Global.FLGU.My.Resources.Resources.delete_file_icon
        Me.btncancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btncancel.Location = New System.Drawing.Point(13, 214)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(45, 45)
        Me.btncancel.TabIndex = 26
        Me.btncancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Edit"
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnsave.BackgroundImage = Global.FLGU.My.Resources.Resources.Actions_document_save_icon
        Me.btnsave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnsave.Location = New System.Drawing.Point(13, 150)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(45, 45)
        Me.btnsave.TabIndex = 28
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Add"
        '
        'btnremove
        '
        Me.btnremove.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnremove.BackgroundImage = Global.FLGU.My.Resources.Resources.Actions_trash_empty_icon
        Me.btnremove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnremove.Location = New System.Drawing.Point(13, 278)
        Me.btnremove.Name = "btnremove"
        Me.btnremove.Size = New System.Drawing.Size(45, 45)
        Me.btnremove.TabIndex = 27
        Me.btnremove.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.tbvpassword)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.tbpassword)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.tbusername)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.tblname)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.tbmi)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tbfname)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(19, 16)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(449, 234)
        Me.GroupBox1.TabIndex = 46
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Account"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(22, 188)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(115, 18)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Verify Password"
        '
        'tbvpassword
        '
        Me.tbvpassword.Location = New System.Drawing.Point(144, 185)
        Me.tbvpassword.Name = "tbvpassword"
        Me.tbvpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbvpassword.Size = New System.Drawing.Size(288, 24)
        Me.tbvpassword.TabIndex = 10
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(22, 158)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 18)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Password"
        '
        'tbpassword
        '
        Me.tbpassword.Location = New System.Drawing.Point(144, 155)
        Me.tbpassword.Name = "tbpassword"
        Me.tbpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbpassword.Size = New System.Drawing.Size(288, 24)
        Me.tbpassword.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(22, 128)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 18)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Username"
        '
        'tbusername
        '
        Me.tbusername.Location = New System.Drawing.Point(144, 125)
        Me.tbusername.Name = "tbusername"
        Me.tbusername.Size = New System.Drawing.Size(288, 24)
        Me.tbusername.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(22, 68)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(24, 18)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "MI"
        '
        'tblname
        '
        Me.tblname.Location = New System.Drawing.Point(144, 95)
        Me.tblname.Name = "tblname"
        Me.tblname.Size = New System.Drawing.Size(288, 24)
        Me.tblname.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(22, 98)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 18)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Last Name"
        '
        'tbmi
        '
        Me.tbmi.Location = New System.Drawing.Point(144, 65)
        Me.tbmi.Name = "tbmi"
        Me.tbmi.Size = New System.Drawing.Size(288, 24)
        Me.tbmi.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "First Name"
        '
        'tbfname
        '
        Me.tbfname.Location = New System.Drawing.Point(144, 35)
        Me.tbfname.Name = "tbfname"
        Me.tbfname.Size = New System.Drawing.Size(288, 24)
        Me.tbfname.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.cbadministrator)
        Me.GroupBox3.Controls.Add(Me.cbdelete)
        Me.GroupBox3.Controls.Add(Me.cbimport)
        Me.GroupBox3.Controls.Add(Me.cbedit)
        Me.GroupBox3.Controls.Add(Me.cbexport)
        Me.GroupBox3.Controls.Add(Me.cbcreate)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(20, 258)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(449, 97)
        Me.GroupBox3.TabIndex = 47
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Credentials"
        '
        'cbadministrator
        '
        Me.cbadministrator.AutoSize = True
        Me.cbadministrator.Location = New System.Drawing.Point(84, 31)
        Me.cbadministrator.Name = "cbadministrator"
        Me.cbadministrator.Size = New System.Drawing.Size(114, 22)
        Me.cbadministrator.TabIndex = 5
        Me.cbadministrator.Text = "Administrator"
        Me.cbadministrator.UseVisualStyleBackColor = True
        '
        'cbdelete
        '
        Me.cbdelete.AutoSize = True
        Me.cbdelete.Location = New System.Drawing.Point(84, 59)
        Me.cbdelete.Name = "cbdelete"
        Me.cbdelete.Size = New System.Drawing.Size(69, 22)
        Me.cbdelete.TabIndex = 4
        Me.cbdelete.Text = "Delete"
        Me.cbdelete.UseVisualStyleBackColor = True
        '
        'cbimport
        '
        Me.cbimport.AutoSize = True
        Me.cbimport.Location = New System.Drawing.Point(204, 59)
        Me.cbimport.Name = "cbimport"
        Me.cbimport.Size = New System.Drawing.Size(69, 22)
        Me.cbimport.TabIndex = 3
        Me.cbimport.Text = "Import"
        Me.cbimport.UseVisualStyleBackColor = True
        '
        'cbedit
        '
        Me.cbedit.AutoSize = True
        Me.cbedit.Location = New System.Drawing.Point(295, 31)
        Me.cbedit.Name = "cbedit"
        Me.cbedit.Size = New System.Drawing.Size(52, 22)
        Me.cbedit.TabIndex = 2
        Me.cbedit.Text = "Edit"
        Me.cbedit.UseVisualStyleBackColor = True
        '
        'cbexport
        '
        Me.cbexport.AutoSize = True
        Me.cbexport.Location = New System.Drawing.Point(295, 59)
        Me.cbexport.Name = "cbexport"
        Me.cbexport.Size = New System.Drawing.Size(70, 22)
        Me.cbexport.TabIndex = 1
        Me.cbexport.Text = "Export"
        Me.cbexport.UseVisualStyleBackColor = True
        '
        'cbcreate
        '
        Me.cbcreate.AutoSize = True
        Me.cbcreate.Location = New System.Drawing.Point(204, 31)
        Me.cbcreate.Name = "cbcreate"
        Me.cbcreate.Size = New System.Drawing.Size(71, 22)
        Me.cbcreate.TabIndex = 0
        Me.cbcreate.Text = "Create"
        Me.cbcreate.UseVisualStyleBackColor = True
        '
        'AccountForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FLGU.My.Resources.Resources.formbackground3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(567, 524)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AccountForm"
        Me.Text = "AccountForm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnremove As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents tbvpassword As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tbpassword As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tbusername As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tblname As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tbmi As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbfname As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cbadministrator As System.Windows.Forms.CheckBox
    Friend WithEvents cbdelete As System.Windows.Forms.CheckBox
    Friend WithEvents cbimport As System.Windows.Forms.CheckBox
    Friend WithEvents cbedit As System.Windows.Forms.CheckBox
    Friend WithEvents cbexport As System.Windows.Forms.CheckBox
    Friend WithEvents cbcreate As System.Windows.Forms.CheckBox
End Class
