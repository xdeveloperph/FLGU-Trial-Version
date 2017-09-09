Imports Presenter
Public Class AccountForm
    Dim Accpres As New LoginPresenter
    Dim accountid As Integer
    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        Dim Logpress As New LoginPresenter
        Dim credentiaos = Logpress.LoginAccountCredentials()
        If credentiaos.create = True Then
            If (tbfname.Text.Trim <> "" And tbfname.Text.Trim <> "" And tbusername.Text.Trim <> "" And tbpassword.Text.Trim <> "" And tbvpassword.Text.Trim <> "") Then
                If (tbpassword.Text = tbvpassword.Text) Then
                    Dim account As New Dataaccess.account
                    account.fname = tbfname.Text
                    account.mname = tbmi.Text
                    account.lname = tblname.Text
                    account.username = tbusername.Text
                    account.password = tbpassword.Text
                    account.level = If(cbadministrator.Checked = True, 1, 0)
                    account.create = cbcreate.Checked
                    account.edit = cbedit.Checked
                    account.delete = cbdelete.Checked
                    account.import = cbimport.Checked
                    account.export = cbexport.Checked
                    Accpres.InsertToAccount(account)
                    LoadDataGridview()
                    MsgBox("You have successfully created a new record.")
                Else
                    MsgBox("Password does not match.")
                End If
            Else
                MsgBox("Invalid input format.")
                clearalltextbox()
            End If
        Else
            MsgBox("Access Denied!")
        End If
        
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
        Dim dashboard = New Dashboard
        dashboard.MdiParent = Main
        dashboard.StartPosition = FormStartPosition.CenterScreen
        dashboard.Show()
    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        Dim Logpress As New LoginPresenter
        Dim credentiaos = Logpress.LoginAccountCredentials()
        If credentiaos.edit = True Then
            cm2()
            btnadd.Enabled = False
            Dim i = DataGridView1.CurrentRow.Index
            accountid = DataGridView1.Item(0, i).Value
            Dim account As Dataaccess.account = Accpres.GetAccountbyID(accountid)
            tbfname.Text = account.fname
            tbmi.Text = account.mname
            tblname.Text = account.lname
            tbusername.Text = account.username
            tbpassword.Text = account.password
            cbadministrator.Checked = account.level
            cbcreate.Checked = account.create
            cbedit.Checked = account.edit
            cbdelete.Checked = account.delete
            cbimport.Checked = account.import
            cbexport.Checked = account.export
        Else
            MsgBox("Access Denied!")
        End If
        

    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Dim result = MsgBox("This would overwrite the existing record. Would you like to proceed?", MsgBoxStyle.YesNo)
        If (result = MsgBoxResult.Yes) Then

            Dim account As New Dataaccess.account
            account.id = accountid
            account.fname = tbfname.Text
            account.mname = tbmi.Text
            account.lname = tblname.Text
            account.username = tbusername.Text
            account.password = tbpassword.Text
            account.level = If(cbadministrator.Checked = True, 1, 0)
            account.create = cbcreate.Checked
            account.edit = cbedit.Checked
            account.delete = cbdelete.Checked
            account.import = cbimport.Checked
            account.export = cbexport.Checked
            Accpres.UpdateAccountByID(account)
            LoadDataGridview()
            cm1()
            clearalltextbox()
            MsgBox("You have successfully updated an old record.")
        End If
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        clearalltextbox()
        accountid = 0
        tbfname.Clear()
        cm1()
    End Sub

    Private Sub btnremove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnremove.Click
        Dim Logpress As New LoginPresenter
        Dim credentiaos = Logpress.LoginAccountCredentials()
        If credentiaos.delete = True Then
            Dim result = MsgBox("Are you sure you want to delete this item?", MsgBoxStyle.YesNo)
            Dim i = DataGridView1.CurrentRow.Index
            If (result = MsgBoxResult.Yes) Then
                Accpres.RemoveAccount(DataGridView1.Item(0, i).Value)
                LoadDataGridview()
                cm1()
                MsgBox("You have successfully deleted the record.")
            End If
        Else
            MsgBox("Access Denied!")
        End If
       


    End Sub
    Private Sub validtxt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Char.IsLetterOrDigit(e.KeyChar)) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = Keys.Space Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        btnedit.Enabled = True
        btnedit.BackColor = Color.White
        btnremove.Enabled = True
        btnremove.BackColor = Color.White
    End Sub

    Private Sub clearalltextbox()
        For Each ctrl As Control In GroupBox1.Controls
            If TypeOf ctrl Is TextBox Then
                ctrl.ResetText()
            End If
        Next ctrl
        cbadministrator.Checked = False
        cbcreate.Checked = False
        cbedit.Checked = False
        cbdelete.Checked = False
        cbimport.Checked = False
        cbexport.Checked = False
    End Sub
    Public Sub cm1()
        btnadd.Enabled = True
        btnedit.Enabled = False
        btncancel.Enabled = False
        btnsave.Enabled = False
        btnremove.Enabled = False
        btnedit.BackColor = Color.Lavender
        btncancel.BackColor = Color.Lavender
        btnsave.BackColor = Color.Lavender
        btnremove.BackColor = Color.Lavender
        btnadd.BackColor = Color.White
        DataGridView1.ClearSelection()
    End Sub
    Public Sub cm2()
        btnedit.Enabled = True
        btncancel.Enabled = True
        btnsave.Enabled = True
        btnremove.Enabled = True
        btnadd.BackColor = Color.Lavender
        btnedit.BackColor = Color.White
        btncancel.BackColor = Color.White
        btnsave.BackColor = Color.White
        btnremove.BackColor = Color.White
    End Sub
    Private Sub LoadDataGridview()
        Dim bindingsouce As New BindingSource
        bindingsouce.DataSource = Accpres.GetListofAccount()
        DataGridView1.DataSource = bindingsouce
        DataGridView1.Columns(0).HeaderText = "Record #"
        DataGridView1.Columns(1).HeaderText = "First Name"
        DataGridView1.Columns(2).HeaderText = "MI"
        DataGridView1.Columns(3).HeaderText = "Last Name"
        DataGridView1.Columns(4).Visible = False
        DataGridView1.Columns(5).Visible = False
        DataGridView1.Columns(6).HeaderText = "Administrator"
        DataGridView1.Columns(7).HeaderText = "Create"
        DataGridView1.Columns(8).HeaderText = "Edit"
        DataGridView1.Columns(9).HeaderText = "Delete"
        DataGridView1.Columns(10).HeaderText = "Export"
        DataGridView1.Columns(11).HeaderText = "Import"
        DataGridView1.ClearSelection()
    End Sub

    Private Sub AccountForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cm1()
        LoadDataGridview()
        For Each ctrl As Control In GroupBox1.Controls
            If TypeOf ctrl Is TextBox Then
                AddHandler ctrl.KeyPress, AddressOf Me.validtxt_KeyPress
            End If
        Next ctrl
        DataGridView1.ClearSelection()
    End Sub
End Class