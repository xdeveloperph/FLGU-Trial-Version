Imports Presenter
Imports [Interface]
Public Class HouseholdMainForm
    Dim LPres As New LocationPresenter
    Dim SIPres As New SubInformationpresenter
    Dim UIPres As New UserInformationPresenter
    Dim searchresult As New List(Of HouseholdLibrary)
    Dim skip As Integer
    Dim request As New SearchLibrary
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PopulateHousehold()
    End Sub

    Private Sub HouseholdMainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadDefault()
        PopulateBarangay()
        PopulatePurok()
        AddHandler cbcity.SelectedIndexChanged, AddressOf Me.cbcity_SelectedIndexChanged
        AddHandler cbbarangay.SelectedIndexChanged, AddressOf Me.cbbarangay_SelectedIndexChanged
    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        Main.ActiveMdiChild.Close()
        Dim childform = New Household
        childform.MdiParent = Main
        childform.StartPosition = FormStartPosition.CenterScreen
        childform.Show()
        Me.Close()
    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        Dim Logpress As New LoginPresenter
        Dim credentiaos = Logpress.LoginAccountCredentials()
        If credentiaos.edit = True Then
            If DataGridView1.SelectedRows.Count > 0 Then
                Dim i = DataGridView1.CurrentRow.Index
                Dim recordid = DataGridView1.Item(0, i).Value
                Main.ActiveMdiChild.Close()
                Dim childform = New Household
                childform.editentry = recordid
                childform.getfrom = 0
                childform.MdiParent = Main
                childform.StartPosition = FormStartPosition.CenterScreen
                childform.Show()
                Me.Close()
            Else
                MsgBox("Please select an item.")
            End If
        Else
            MsgBox("Access Denied!")
        End If
       

    End Sub

    Private Sub btnremove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnremove.Click
        Dim Logpress As New LoginPresenter
        Dim credentiaos = Logpress.LoginAccountCredentials()
        If credentiaos.delete = True Then
            If DataGridView1.SelectedRows.Count > 0 Then
                Dim i = DataGridView1.CurrentRow.Index
                Dim recordid = DataGridView1.Item(0, i).Value
                Dim result = MsgBox("Are you sure you want to delete this item? this will also delete the family members in this household.", MsgBoxStyle.YesNo)
                If (result = MsgBoxResult.Yes) Then
                    UIPres.RemoveHousehold(recordid)
                    PopulateHousehold()
                    MsgBox("You have successfully deleted the record.")
                End If
            Else
                MsgBox("Please select an item.")
            End If
        Else
            MsgBox("Access Denied!")
        End If
        

    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Main.ActiveMdiChild.Close()
        Dim childform = New Dashboard
        childform.MdiParent = Main
        childform.StartPosition = FormStartPosition.CenterScreen
        childform.Show()
        Me.Close()
    End Sub
    Private Sub LoadDefault()

        Dim bindingsouce As New BindingSource
        Dim addcity As New Dataaccess.city
        addcity.id = 0
        addcity.name = "All"
        Dim listofcity = LPres.GetListofCity()
        listofcity.Insert(0, addcity)
        bindingsouce.DataSource = listofcity
        cbcity.DataSource = bindingsouce
        cbcity.DisplayMember = "name"
        cbcity.ValueMember = "id"

        bindingsouce = New BindingSource
        Dim addcategory As New Dataaccess.citizencategory
        addcategory.id = 0
        addcategory.name = "All"
        Dim listofcategory = UIPres.GetListofCCategory()
        listofcategory.Insert(0, addcategory)
        bindingsouce.DataSource = listofcategory
        cbcategory.DataSource = bindingsouce
        cbcategory.DisplayMember = "name"
        cbcategory.ValueMember = "id"
        cbcategory.Text = "None"

        bindingsouce = New BindingSource
        Dim addsc As New Dataaccess.socialstatu
        addsc.id = 0
        addsc.name = "All"
        Dim listofsocialstat = SIPres.GetListofSocialStatus()
        listofsocialstat.Insert(0, addsc)
        bindingsouce.DataSource = listofsocialstat
        cbsocialstat.DataSource = bindingsouce
        cbsocialstat.DisplayMember = "name"
        cbsocialstat.ValueMember = "id"
        cbsocialstat.Text = "None"
        PopulateHousehold()
    End Sub
    Public Sub PopulateHousehold()
        disableallcontrol()
        DataGridView1.SendToBack()
        request = New SearchLibrary
        request.BarangayID = cbbarangay.SelectedValue
        request.CityID = cbcity.SelectedValue
        request.PurokID = cbpurok.SelectedValue
        request.SocailComunityID = cbsocialstat.SelectedValue
        request.CategoryID = cbcategory.SelectedValue
        request.FamilyName = tbfamilyname.Text

        BackgroundWorker1.RunWorkerAsync()
    End Sub
    Private Sub cbcity_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        PopulateBarangay()
        PopulatePurok()
    End Sub
    Private Sub cbbarangay_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        PopulatePurok()
    End Sub
    Public Sub PopulateBarangay()
        Dim bindingsouce As New BindingSource
        If cbcity.SelectedValue IsNot Nothing Then
            Dim addbarangay As New Dataaccess.barangay
            addbarangay.id = 0
            addbarangay.name = "All"
            Dim listbarangay = LPres.GetBarangayListbyCityID(Integer.Parse(cbcity.SelectedValue))
            listbarangay.Insert(0, addbarangay)
            bindingsouce.DataSource = listbarangay
        End If
        cbbarangay.DataSource = bindingsouce
        cbbarangay.DisplayMember = "name"
        cbbarangay.ValueMember = "id"

    End Sub
    Public Sub PopulatePurok()
        Dim bindingsouce As New BindingSource
        If cbbarangay.SelectedValue IsNot Nothing Then
            Dim addpurok As New Dataaccess.purok
            addpurok.id = 0
            addpurok.name = "All"
            Dim listofpurok = LPres.GetListofPurokByBarangayID(Integer.Parse(cbbarangay.SelectedValue))
            listofpurok.Insert(0, addpurok)
            bindingsouce.DataSource = listofpurok
            cbpurok.DataSource = bindingsouce
            cbpurok.DisplayMember = "name"
            cbpurok.ValueMember = "id"
        Else
            cbpurok.DataSource = Nothing
        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        searchresult = UIPres.SearchHousehold(request, Integer.Parse(tbnor.Text), skip)
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        If (searchresult IsNot Nothing) Then

            Dim bindingsouce As New BindingSource
            bindingsouce.DataSource = searchresult
            DataGridView1.DataSource = bindingsouce
            DataGridView1.Columns(0).HeaderText = "Record #"
            DataGridView1.Columns(1).HeaderText = "Family Name"
            DataGridView1.Columns(2).HeaderText = "Population"
            DataGridView1.Columns(3).HeaderText = "Household #"
            DataGridView1.Columns(4).HeaderText = "Contact #"
            DataGridView1.Columns(5).HeaderText = "Socail Status"
            DataGridView1.Columns(6).HeaderText = "Category"
            DataGridView1.Columns(7).HeaderText = "City"
            DataGridView1.Columns(8).HeaderText = "Barangay"
            DataGridView1.Columns(9).HeaderText = "Purok"
            DataGridView1.Columns(10).HeaderText = "Date Created"
            DataGridView1.ClearSelection()

        End If
        Enableallcontrol()
        paneloading.SendToBack()
        'If (searchresult.Count > 0 And searchresult.Count = Integer.Parse(tbnor.Text)) Then
        '    Button6.Enabled = True
        'Else
        '    Button6.Enabled = False
        'End If
    End Sub
    Private Sub Enableallcontrol()
        For Each ctrl As Control In GroupBox1.Controls
            If TypeOf ctrl Is ComboBox Or TypeOf ctrl Is TextBox Then
                ctrl.Enabled = True
            End If
        Next ctrl
        For Each ctrl As Control In GroupBox2.Controls
            If TypeOf ctrl Is Button Then
                ctrl.Enabled = True
            End If
        Next ctrl
        DataGridView1.Enabled = True
    End Sub
    Private Sub disableallcontrol()
        For Each ctrl As Control In GroupBox1.Controls
            If TypeOf ctrl Is ComboBox Or TypeOf ctrl Is TextBox Then
                ctrl.Enabled = False
            End If
        Next ctrl
        For Each ctrl As Control In GroupBox2.Controls
            If TypeOf ctrl Is Button Then
                ctrl.Enabled = False
            End If
        Next ctrl
        DataGridView1.Enabled = False
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'skip -= Integer.Parse(tbnor.Text)
        'If (skip <= 0) Then
        '    Button4.Enabled = False
        '    skip = 0
        'Else
        '    Button4.Enabled = True
        'End If
        PopulateHousehold()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        'skip += Integer.Parse(tbnor.Text)
        'Button4.Enabled = True
        'PopulateHousehold()
    End Sub
    Private Sub keypresstxtbox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbnor.KeyPress
        If (Char.IsDigit(e.KeyChar)) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class