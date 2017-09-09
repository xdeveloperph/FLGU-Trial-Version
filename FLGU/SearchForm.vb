Imports Presenter
Imports [Interface]
Imports System.Data.SqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Public Class SearchForm
    Dim LPres As New LocationPresenter
    Dim SIPres As New SubInformationpresenter
    Dim UIPres As New UserInformationPresenter
    Dim housholdentry As New UserInformationPresenter.HouseholdDataset
    Dim searchlist As New List(Of CitizenInformation)
    Dim searchoption As New SearchLibrary

    Dim skip As Integer
    Private Sub SearchForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loaddefault()
        PopulateBarangay()
        PopulatePurok()
        AddHandler cbcity.SelectedIndexChanged, AddressOf Me.cbcity_SelectedIndexChanged
        AddHandler cbbarangay.SelectedIndexChanged, AddressOf Me.cbbarangay_SelectedIndexChanged
        ExecuteSearch()
    End Sub
    Private Sub keypresstxtbox(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbnor.KeyPress
        If (Char.IsDigit(e.KeyChar)) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ExecuteSearch()
    End Sub

    Private Sub ExecuteSearch()
        disableallcontrol()
        DataGridView1.SendToBack()
        searchoption = New SearchLibrary
        With searchoption
            .BarangayID = cbbarangay.SelectedValue
            .CityID = cbcity.SelectedValue
            .PurokID = cbpurok.SelectedValue
            .SocailComunityID = cbst.SelectedValue
            .OSYISY = cbosy.SelectedValue
            .Philhealth = cbphil.SelectedValue
            .PhilhealthTypeID = cbphiltype.SelectedValue
            .BIR = cbbir.SelectedValue
            .BloodType = cbbloodtype.SelectedValue
            .Gender = cbgender.SelectedValue
            .CategoryID = cbcategory.SelectedValue
            .OccupationID = cboccupation.SelectedValue
            .DiseasedID = cbdisease.SelectedValue
            .pwd = tbpwd.Text
            .KeyString = tbkeystring.Text
        End With
        BackgroundWorker1.RunWorkerAsync()
    End Sub
    Private Sub loaddefault()

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

        Dim listofOccupation = SIPres.GetListofOccupation()
        listofOccupation.Insert(0, New Dataaccess.occupation With {.id = 0, .name = "None"})
        listofOccupation.Insert(0, New Dataaccess.occupation With {.id = -1, .name = "All"})
        bindingsouce = New BindingSource
        bindingsouce.DataSource = listofOccupation
        cboccupation.DataSource = bindingsouce
        cboccupation.DisplayMember = "name"
        cboccupation.ValueMember = "id"

        Dim listofDiseas = SIPres.GetListofDiseases()
        listofDiseas.Insert(0, New Dataaccess.disease With {.id = 0, .name = "None"})
        listofDiseas.Insert(0, New Dataaccess.disease With {.id = -1, .name = "All"})
        bindingsouce = New BindingSource
        bindingsouce.DataSource = listofDiseas
        cbdisease.DataSource = bindingsouce
        cbdisease.DisplayMember = "name"
        cbdisease.ValueMember = "id"

        Dim listofCategory = UIPres.GetListofCCategory()
        listofCategory.Insert(0, New Dataaccess.citizencategory With {.id = 0, .name = "All"})
        bindingsouce = New BindingSource
        bindingsouce.DataSource = listofCategory
        cbcategory.DataSource = bindingsouce
        cbcategory.DisplayMember = "name"
        cbcategory.ValueMember = "id"
        cbcategory.Text = "None"

        Dim listofSocialStatus = SIPres.GetListofSocialStatus()
        listofSocialStatus.Insert(0, New Dataaccess.socialstatu With {.id = 0, .name = "All"})
        bindingsouce = New BindingSource
        bindingsouce.DataSource = listofSocialStatus
        cbst.DataSource = bindingsouce
        cbst.DisplayMember = "name"
        cbst.ValueMember = "id"
        cbst.Text = "None"

        bindingsouce = New BindingSource
        Dim cbdictionary As New List(Of BindingItems)
        cbdictionary.Add(New BindingItems With {.id = "", .name = "All"})
        cbdictionary.Add(New BindingItems With {.id = "M", .name = "Male"})
        cbdictionary.Add(New BindingItems With {.id = "F", .name = "Female"})
        bindingsouce.DataSource = cbdictionary
        cbgender.DataSource = bindingsouce
        cbgender.DisplayMember = "name"
        cbgender.ValueMember = "id"

        bindingsouce = New BindingSource
        Dim tbbloodtypedataset As New List(Of BindingItems)
        tbbloodtypedataset.Add(New BindingItems With {.id = "", .name = "All"})
        tbbloodtypedataset.Add(New BindingItems With {.id = "A", .name = "A"})
        tbbloodtypedataset.Add(New BindingItems With {.id = "AB", .name = "AB"})
        tbbloodtypedataset.Add(New BindingItems With {.id = "B", .name = "B"})
        tbbloodtypedataset.Add(New BindingItems With {.id = "O", .name = "O"})
        bindingsouce.DataSource = tbbloodtypedataset
        cbbloodtype.DataSource = bindingsouce
        cbbloodtype.DisplayMember = "name"
        cbbloodtype.ValueMember = "id"

        bindingsouce = New BindingSource
        Dim tbosydatase As New List(Of BindingItems)
        tbosydatase.Add(New BindingItems With {.id = "", .name = "All"})
        tbosydatase.Add(New BindingItems With {.id = "OSY", .name = "Out School Youth"})
        tbosydatase.Add(New BindingItems With {.id = "ISY", .name = "In School Youth"})
        bindingsouce.DataSource = tbosydatase
        cbosy.DataSource = bindingsouce
        cbosy.DisplayMember = "name"
        cbosy.ValueMember = "id"

        bindingsouce = New BindingSource
        Dim cbphilhealth As New List(Of BindingItems)
        cbphilhealth.Add(New BindingItems With {.id = 0, .name = "All"})
        cbphilhealth.Add(New BindingItems With {.id = "R", .name = "Registered"})
        cbphilhealth.Add(New BindingItems With {.id = "U", .name = "Unregistered"})
        bindingsouce.DataSource = cbphilhealth
        cbphil.DataSource = bindingsouce
        cbphil.DisplayMember = "name"
        cbphil.ValueMember = "id"

        bindingsouce = New BindingSource
        Dim cbbiritems As New List(Of BindingItems)
        cbbiritems.Add(New BindingItems With {.id = "", .name = "All"})
        cbbiritems.Add(New BindingItems With {.id = "R", .name = "Registered"})
        cbbiritems.Add(New BindingItems With {.id = "U", .name = "Unregistered"})
        bindingsouce.DataSource = cbbiritems
        cbbir.DataSource = bindingsouce
        cbbir.DisplayMember = "name"
        cbbir.ValueMember = "id"

        bindingsouce = New BindingSource
        Dim cbphilhealthtype As New List(Of BindingItems)
        cbphilhealthtype.Add(New BindingItems With {.id = -1, .name = "All"})
        cbphilhealthtype.Add(New BindingItems With {.id = 0, .name = "Undefine"})
        cbphilhealthtype.Add(New BindingItems With {.id = 1, .name = "Private"})
        cbphilhealthtype.Add(New BindingItems With {.id = 2, .name = "Shared"})
        cbphilhealthtype.Add(New BindingItems With {.id = 3, .name = "Government"})
        bindingsouce.DataSource = cbphilhealthtype
        cbphiltype.DataSource = bindingsouce
        cbphiltype.DisplayMember = "name"
        cbphiltype.ValueMember = "id"

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

    Private Sub cbcity_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        PopulateBarangay()
    End Sub

    Private Sub cbbarangay_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        PopulatePurok()
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Main.ActiveMdiChild.Close()
        Dim childform = New Dashboard
        childform.MdiParent = Main
        childform.StartPosition = FormStartPosition.CenterScreen
        childform.Show()
        Me.Close()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        
       
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
                childform.getfrom = 1
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

 

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
      
        If DataGridView1.Rows(e.RowIndex).Cells(9).Value IsNot Nothing Then
            Dim phil As String = DataGridView1.Rows(e.RowIndex).Cells(7).Value
            Dim time As DateTime = DateTime.Parse(DataGridView1.Rows(e.RowIndex).Cells(9).Value)
            If (phil = "0" Or phil.Trim = "") Then
                e.CellStyle.BackColor = Color.Yellow
            Else
                If Now.Date.AddDays(-30) <= time.Date Or time.Date <= Now.Date Then
                    e.CellStyle.BackColor = Color.Orange
                Else
                    e.CellStyle.BackColor = Color.Red
                End If
            End If
        End If

      
    End Sub

  
    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        searchlist = UIPres.SearchCitizen(searchoption, Integer.Parse(tbnor.Text), skip)
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        Main.ToolStripProgressBar1.Value = e.ProgressPercentage
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        If (searchlist IsNot Nothing) Then
            Dim bindingsouce As New BindingSource
            bindingsouce.DataSource = searchlist
            DataGridView1.DataSource = bindingsouce
            DataGridView1.Columns(0).HeaderText = "Record #"
            DataGridView1.Columns(1).HeaderText = "First Name"
            DataGridView1.Columns(2).HeaderText = "MI"
            DataGridView1.Columns(3).HeaderText = "Last Name"
            DataGridView1.Columns(4).HeaderText = "Birth"
            DataGridView1.Columns(5).HeaderText = "Age"
            DataGridView1.Columns(6).HeaderText = "Contact #"
            DataGridView1.Columns(7).HeaderText = "Philhealth"
            DataGridView1.Columns(8).HeaderText = "Philhealth Type"
            DataGridView1.Columns(9).HeaderText = "Philhealth Exp"
            DataGridView1.Columns(10).HeaderText = "Income"
            DataGridView1.Columns(11).HeaderText = "Blood Type"
            DataGridView1.Columns(12).HeaderText = "Occupation"
            DataGridView1.Columns(13).HeaderText = "OSY/ISY"
            DataGridView1.Columns(14).HeaderText = "PWE"
            DataGridView1.Columns(15).HeaderText = "Gender"
            DataGridView1.Columns(16).HeaderText = "Social Status"
            DataGridView1.Columns(17).HeaderText = "Household #"
            DataGridView1.Columns(18).HeaderText = "Family #"
            DataGridView1.Columns(19).HeaderText = "City"
            DataGridView1.Columns(20).HeaderText = "Barangay"
            DataGridView1.Columns(21).HeaderText = "Purok"
            DataGridView1.Columns(22).HeaderText = "Political Party"
            DataGridView1.ClearSelection()
        End If
        paneloading.SendToBack()
        Enableallcontrol()

        'If (searchlist.Count > 0 And searchlist.Count = Integer.Parse(tbnor.Text)) Then
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
        'ExecuteSearch()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        'skip += Integer.Parse(tbnor.Text)
        'Button4.Enabled = True
        'ExecuteSearch()
    End Sub


End Class