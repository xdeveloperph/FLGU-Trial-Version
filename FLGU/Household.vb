Imports Presenter
Imports System.Transactions
Public Class Household
    Dim LPres As New LocationPresenter
    Dim SIPres As New SubInformationpresenter
    Dim UIPres As New UserInformationPresenter
    Dim housholdentry As New UserInformationPresenter.HouseholdDataset
    Dim DDpres As New DashboardPresenter
    Dim memberid As Integer
    Public editentry As Integer
    Public getfrom As Integer
    Private Class ComboboxItems
        Property name As String
        Property id As String
    End Class
    Private Sub Household_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cm1()
        LoadDefault()
       
        If editentry <> 0 Then
            Dim Gethousholdentry As UserInformationPresenter.HouseholdDataset = UIPres.GetHouseholdDataset(getfrom, editentry)
            housholdentry = Gethousholdentry
            With housholdentry
                Dim item As String = .cityid
                cbcity.Text = LPres.GetCityDatabyID(.cityid).name
                PopulateBarangay()
                cbbarangay.Text = LPres.GetBarangayDatabyID(.barangayid).name
                PopulatePurok()
                cbpurok.Text = LPres.GetPurokDatabyID(.purokid).name
                tbfamilyname.Text = .familyname
                tbfamilyno.Text = .familynum
                tbhousenum.Text = .householdnum
                cbsocialcom.SelectedValue = .soccomid
                cbcategory.SelectedValue = .categoryid
            End With
            PopulateHousehold()
            AddHandler btncreate.Click, AddressOf Me.btnUpdate_Click
            btncreate.Text = "Update Household"
        Else
            PopulateBarangay()
            PopulatePurok()
            AddHandler btncreate.Click, AddressOf Me.btncreate_Click
        End If
       

        AddHandler cbcity.SelectedIndexChanged, AddressOf Me.cbcity_SelectedIndexChanged
        AddHandler cbbarangay.SelectedIndexChanged, AddressOf Me.cbbarangay_SelectedIndexChanged

        For Each ctrl As Control In GroupBox1.Controls
            If TypeOf ctrl Is TextBox Then
                If ctrl.Name = "tbcontact" Or ctrl.Name = "tbincome" Or ctrl.Name = "tbtin" Or ctrl.Name = "tbphilhealth" Then
                    AddHandler ctrl.KeyPress, AddressOf Me.OnlyNumberPress
                Else
                    AddHandler ctrl.KeyPress, AddressOf Me.keypresstxtbox
                End If

            End If
        Next ctrl
        For Each ctrl As Control In GroupBox2.Controls
            If TypeOf ctrl Is TextBox Then
                If ctrl.Name = "tbhousenum" Or ctrl.Name = "tbfamilyno" Then
                    AddHandler ctrl.KeyPress, AddressOf Me.OnlyNumberPress
                Else
                    AddHandler ctrl.KeyPress, AddressOf Me.keypresstxtbox
                End If
            End If
        Next ctrl

    End Sub



    Private Sub LoadDefault()
        Dim defaultitem As Integer = -1
        Dim bindingsouce As New BindingSource
        bindingsouce.DataSource = LPres.GetListofCity()
        cbcity.DataSource = bindingsouce
        cbcity.DisplayMember = "name"
        cbcity.ValueMember = "id"

        Dim listofOccupation = SIPres.GetListofOccupation()
        listofOccupation.Insert(0, New Dataaccess.occupation With {.id = 0, .name = "None"})
        bindingsouce = New BindingSource
        bindingsouce.DataSource = listofOccupation
        cboccupation.DataSource = bindingsouce
        cboccupation.DisplayMember = "name"
        cboccupation.ValueMember = "id"

        Dim listofDiseas = SIPres.GetListofDiseases()
        listofDiseas.Insert(0, New Dataaccess.disease With {.id = 0, .name = "None"})
        bindingsouce = New BindingSource
        bindingsouce.DataSource = listofDiseas
        cbdisease.DataSource = bindingsouce
        cbdisease.DisplayMember = "name"
        cbdisease.ValueMember = "id"

        bindingsouce = New BindingSource
        bindingsouce.DataSource = UIPres.GetListofCCategory()
        cbcategory.DataSource = bindingsouce
        cbcategory.DisplayMember = "name"
        cbcategory.ValueMember = "id"
        cbcategory.Text = "None"

        bindingsouce = New BindingSource
        bindingsouce.DataSource = SIPres.GetListofSocialStatus()
        cbsocialcom.DataSource = bindingsouce
        cbsocialcom.DisplayMember = "name"
        cbsocialcom.ValueMember = "id"
        cbsocialcom.Text = "None"

        bindingsouce = New BindingSource
        Dim cbdictionary As New List(Of ComboboxItems)
        cbdictionary.Add(New ComboboxItems With {.id = "M", .name = "Male"})
        cbdictionary.Add(New ComboboxItems With {.id = "F", .name = "Female"})
        bindingsouce.DataSource = cbdictionary
        tbgender.DataSource = bindingsouce
        tbgender.DisplayMember = "name"
        tbgender.ValueMember = "id"

        bindingsouce = New BindingSource
        Dim tbbloodtypedataset As New List(Of ComboboxItems)
        tbbloodtypedataset.Add(New ComboboxItems With {.id = "A", .name = "A"})
        tbbloodtypedataset.Add(New ComboboxItems With {.id = "AB", .name = "AB"})
        tbbloodtypedataset.Add(New ComboboxItems With {.id = "B", .name = "B"})
        tbbloodtypedataset.Add(New ComboboxItems With {.id = "O", .name = "O"})
        bindingsouce.DataSource = tbbloodtypedataset
        tbbloodtype.DataSource = bindingsouce
        tbbloodtype.DisplayMember = "name"
        tbbloodtype.ValueMember = "id"

        bindingsouce = New BindingSource
        Dim tbosydatase As New List(Of ComboboxItems)
        tbosydatase.Add(New ComboboxItems With {.id = "OSY", .name = "Out School Youth"})
        tbosydatase.Add(New ComboboxItems With {.id = "ISY", .name = "In School Youth"})
        bindingsouce.DataSource = tbosydatase
        tbosy.DataSource = bindingsouce
        tbosy.DisplayMember = "name"
        tbosy.ValueMember = "id"

        bindingsouce = New BindingSource
        Dim cbphilhealthtype As New List(Of ComboboxItems)
        cbphilhealthtype.Add(New ComboboxItems With {.id = 0, .name = "Undefine"})
        cbphilhealthtype.Add(New ComboboxItems With {.id = 1, .name = "Private"})
        cbphilhealthtype.Add(New ComboboxItems With {.id = 2, .name = "Shared"})
        cbphilhealthtype.Add(New ComboboxItems With {.id = 3, .name = "Government"})
        bindingsouce.DataSource = cbphilhealthtype
        tbphiltype.DataSource = bindingsouce
        tbphiltype.DisplayMember = "name"
        tbphiltype.ValueMember = "id"

        PopulateHousehold()


    End Sub

    Private Sub cbcity_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        PopulateBarangay()
        PopulatePurok()
    End Sub

    Private Sub cbbarangay_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        PopulatePurok()
    End Sub

#Region "Binding Functions"
    Public Sub PopulateBarangay()
        Dim bindingsouce As New BindingSource
        If cbcity.SelectedValue IsNot Nothing Then
            bindingsouce.DataSource = LPres.GetBarangayListbyCityID(Integer.Parse(cbcity.SelectedValue))
        End If
        cbbarangay.DataSource = bindingsouce
        cbbarangay.DisplayMember = "name"
        cbbarangay.ValueMember = "id"

    End Sub
    Public Sub PopulatePurok()
        Dim bindingsouce As New BindingSource
        If cbbarangay.SelectedValue IsNot Nothing Then
            bindingsouce.DataSource = LPres.GetListofPurokByBarangayID(Integer.Parse(cbbarangay.SelectedValue))
            cbpurok.DataSource = bindingsouce
            cbpurok.DisplayMember = "name"
            cbpurok.ValueMember = "id"
        Else
            cbpurok.DataSource = Nothing
        End If
    End Sub
    Public Sub PopulateHousehold()
        Dim bindingsouce As New BindingSource
        bindingsouce.DataSource = housholdentry.Member
        DataGridView1.DataSource = bindingsouce
        DataGridView1.Columns(0).HeaderText = "First Name"
        DataGridView1.Columns(1).HeaderText = "MI"
        DataGridView1.Columns(2).HeaderText = "Last Name"
        DataGridView1.Columns(3).HeaderText = "Birth"
        DataGridView1.Columns(4).HeaderText = "Contact #"
        DataGridView1.Columns(5).HeaderText = "Blood Type"
        DataGridView1.Columns(6).HeaderText = "Gender"
        DataGridView1.Columns(7).HeaderText = "ISY/OSY"
        DataGridView1.Columns(8).HeaderText = "PWD"
        DataGridView1.Columns(9).HeaderText = "Occupation"
        DataGridView1.Columns(10).HeaderText = "Disease"
        DataGridView1.Columns(11).HeaderText = "Tin No."
        DataGridView1.Columns(12).HeaderText = "Philhealth"
        DataGridView1.Columns(13).HeaderText = "Philhealth Type"
        DataGridView1.Columns(14).HeaderText = "Philhealth Exp"
        DataGridView1.Columns(15).HeaderText = "Income"
        DataGridView1.Columns(16).Visible = False
        DataGridView1.Columns(17).Visible = False
        DataGridView1.Columns(18).Visible = False
        DataGridView1.Columns(19).Visible = False
        DataGridView1.Columns(20).Visible = False
        DataGridView1.ClearSelection()

        Dim popcount = DDpres.GetPopulation
        With popcount
            lbtoh.Text = .total
        End With
        lbtop.Text = DDpres.GetHousehold(0, 0)
    End Sub
#End Region

    Private Sub tblname_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tblname.LostFocus
        If tbfamilyname.Text.Trim = "" Then
            tbfamilyname.Text = tblname.Text
        End If
    End Sub
    Private Sub keypresstxtbox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Char.IsLetterOrDigit(e.KeyChar)) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = Keys.Space Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        Dim Logpress As New LoginPresenter
        Dim credentiaos = Logpress.LoginAccountCredentials()
        If credentiaos.create = True Then
            If (tbname.Text <> "" And tblname.Text <> " ") Then
                Dim fmember As New UserInformationPresenter.FamilyMembersDataset
                With fmember
                    .birth = dtpbirth.Value.Date
                    .bloodtype = tbbloodtype.Text
                    .contactnum = tbcontact.Text
                    .disease = cbdisease.Text
                    .diseaseid = cbdisease.SelectedValue
                    .fname = tbname.Text
                    .gender = tbgender.SelectedValue
                    .lanme = tblname.Text
                    .mname = tbsurname.Text
                    .occupation = cboccupation.Text
                    .occupationid = cboccupation.SelectedValue
                    .osy = tbosy.Text
                    .osyid = tbosy.SelectedValue
                    .philhealthexp = dtphilexp.Value.Date
                    .philhealthnum = tbphilhealth.Text
                    .philhealthtype = tbphiltype.Text
                    .philtypeid = tbphiltype.SelectedIndex
                    .pwd = tbpwd.Text
                    .tin = tbtin.Text
                    .income = tbincome.Text
                    .tempid = (housholdentry.Member.Count + 1)
                End With
                With housholdentry
                    .barangayid = cbbarangay.SelectedValue
                    .categoryid = cbcategory.SelectedValue
                    .cityid = cbcity.SelectedValue
                    .familyname = tbfamilyname.Text
                    .familynum = tbfamilyno.Text
                    .householdnum = tbhousenum.Text
                    .purokid = cbpurok.SelectedValue
                    .soccomid = cbsocialcom.SelectedValue
                    .Member.Add(fmember)
                End With
                PopulateHousehold()
                For Each ctrl As Control In GroupBox1.Controls
                    If TypeOf ctrl Is TextBox Then
                        ctrl.Text = ""
                    End If
                Next ctrl
            Else
                MsgBox("Please provide basic information such as Name and Last Name to save record.")
            End If
        Else
            MsgBox("Access Denied!")
        End If
        
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        If getfrom = 0 Then
            Me.Close()
            Dim dashboard = New HouseholdMainForm
            dashboard.MdiParent = Main
            dashboard.StartPosition = FormStartPosition.CenterScreen
            dashboard.Show()
        Else
            Me.Close()
            Dim dashboard = New SearchForm
            dashboard.MdiParent = Main
            dashboard.StartPosition = FormStartPosition.CenterScreen
            dashboard.Show()
        End If
       
    End Sub
    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        btnedit.Enabled = True
        btnedit.BackColor = Color.White
        btnremove.Enabled = True
        btnremove.BackColor = Color.White
    End Sub
    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        Dim Logpress As New LoginPresenter
        Dim credentiaos = Logpress.LoginAccountCredentials()
        If credentiaos.edit = True Then
            cm2()
            btnadd.Enabled = False
            Dim i = DataGridView1.CurrentRow.Index
            memberid = Integer.Parse(DataGridView1.Item(20, i).Value)

            Dim result = (From data In housholdentry.Member
                         Where data.tempid = memberid
                         Select data).FirstOrDefault()
            If result IsNot Nothing Then
                With result
                    dtpbirth.Value = If(.birth.ToString() = "01/01/01 12:00:00 AM", Now, .birth)
                    tbbloodtype.Text = .bloodtype
                    tbcontact.Text = .contactnum
                    cbdisease.Text = .disease
                    cbdisease.SelectedValue = If(Char.IsDigit(.diseaseid.ToString), .diseaseid, 0)
                    tbname.Text = .fname
                    tbgender.Text = .gender
                    tblname.Text = .lanme
                    tbsurname.Text = .mname
                    cboccupation.Text = .occupation
                    cboccupation.SelectedValue = .occupationid
                    tbosy.Text = .osy
                    tbosy.SelectedIndex = If(Char.IsDigit(.osyid), .osyid, 0)
                    dtphilexp.Value = If(.philhealthexp.ToString() = "01/01/01 12:00:00 AM", Now, .philhealthexp)
                    tbphilhealth.Text = .philhealthnum
                    tbphiltype.Text = .philhealthtype
                    tbphiltype.SelectedIndex = If(Char.IsDigit(.philtypeid.ToString()), .philtypeid, 0)
                    tbincome.Text = .income
                    tbpwd.Text = .pwd
                    tbtin.Text = .tin
                End With
            End If
        Else
            MsgBox("Access Denied!")
        End If
       
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Dim result = MsgBox("This would overwrite the existing record. Would you like to proceed?", MsgBoxStyle.YesNo)
        If (result = MsgBoxResult.Yes) Then
            If (tbname.Text.Trim <> "" And tblname.Text.Trim <> "") Then

                Dim results = (From data In housholdentry.Member
                    Where data.tempid = memberid
                    Select data).FirstOrDefault()
                If results IsNot Nothing Then
                    With results
                        .birth = dtpbirth.Value.Date
                        .bloodtype = tbbloodtype.Text
                        .contactnum = tbcontact.Text
                        .disease = cbdisease.Text
                        .diseaseid = cbdisease.SelectedValue
                        .fname = tbname.Text
                        .gender = tbgender.Text
                        .lanme = tblname.Text
                        .mname = tbsurname.Text
                        .occupation = cboccupation.Text
                        .occupationid = cboccupation.SelectedValue
                        .osy = tbosy.Text
                        .osyid = tbosy.SelectedIndex
                        .philhealthexp = dtphilexp.Value.Date
                        .philhealthnum = tbphilhealth.Text
                        .philhealthtype = tbphiltype.Text
                        .philtypeid = tbphiltype.SelectedIndex
                        .pwd = tbpwd.Text
                        .tin = tbtin.Text
                        .income = tbincome.Text
                    End With
                End If
                With housholdentry
                    .barangayid = cbbarangay.SelectedValue
                    .categoryid = cbcategory.SelectedValue
                    .cityid = cbcity.SelectedValue
                    .familyname = tbfamilyname.Text
                    .familynum = tbfamilyno.Text
                    .householdnum = tbhousenum.Text
                    .purokid = cbpurok.SelectedValue
                    .soccomid = cbsocialcom.SelectedValue
                End With
                PopulateHousehold()
                For Each ctrl As Control In GroupBox1.Controls
                    If TypeOf ctrl Is TextBox Then
                        ctrl.Text = ""
                    End If
                Next ctrl
            End If
            cm1()
            MsgBox("You have successfully updated an old record.")
        End If
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        memberid = 0
        ResetAll()
        cm1()
    End Sub

    Private Sub btnremove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnremove.Click
        Dim Logpress As New LoginPresenter
        Dim credentiaos = Logpress.LoginAccountCredentials()
        If credentiaos.delete = True Then
            Dim result = MsgBox("Are you sure you want to delete this item?", MsgBoxStyle.YesNo)
            Dim i As Integer = DataGridView1.CurrentRow.Index
            If (result = MsgBoxResult.Yes) Then
                Dim recordid = Integer.Parse(DataGridView1.Item(20, i).Value)
                Dim item = housholdentry.Member.Where(Function(x) x.tempid = recordid).FirstOrDefault()
                housholdentry.Member.Remove(item)
                For Each ctrl As Control In GroupBox1.Controls
                    If TypeOf ctrl Is TextBox Then
                        ctrl.Text = ""
                    End If
                Next ctrl
                PopulateHousehold()
                cm1()
                MsgBox("You have successfully deleted the record.")
            End If
        Else
            MsgBox("Access Denied!")
        End If
        
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
        DataGridView1.ClearSelection()
    End Sub

    Private Sub btncreate_Click(ByVal sender As Object, ByVal e As EventArgs)
        Using scope As New TransactionScope()
            UIPres.InsertHouseholdandMembers(housholdentry)
            scope.Complete()
            MsgBox("A new household was successfully added.")
            ResetAll()
        End Using
    End Sub
    Private Sub btnUpdate_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim result = MsgBox("This would overwrite the existing record. Would you like to proceed?", MsgBoxStyle.YesNo)
        If (result = MsgBoxResult.Yes) Then
            Using scope As New TransactionScope()
                UIPres.UpdateHouseholdandMembers(getfrom, editentry, housholdentry)
                scope.Complete()
                MsgBox("You have successfully updated the record.")
            End Using
        End If
    End Sub

    Private Sub ResetAll()
        For Each ctrl As Control In GroupBox1.Controls
            If TypeOf ctrl Is TextBox Or TypeOf ctrl Is ComboBox Then
                ctrl.ResetText()
            End If
        Next ctrl
        For Each ctrl As Control In GroupBox2.Controls
            If TypeOf ctrl Is TextBox Or TypeOf ctrl Is ComboBox Then
                ctrl.ResetText()
            End If
        Next ctrl
        DataGridView1.DataSource = Nothing
        housholdentry = New UserInformationPresenter.HouseholdDataset
    End Sub

    Private Sub OnlyNumberPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then
            Else
                e.Handled = True
            End If
        End If
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        
    End Sub
End Class