Imports Presenter
Imports [Interface]
Public Class Dashboard
    Dim DDpres As New DashboardPresenter
    Dim LPres As New LocationPresenter
    Dim SIPres As New SubInformationpresenter
    Dim UIPres As New UserInformationPresenter
    Private Sub Dashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim popcount = DDpres.GetPopulation
        With popcount
            tbpfemale.Text = .female
            tbpmale.Text = .male
            tbptotal.Text = .total
        End With

        Dim bindingsouce = New BindingSource
        Dim cbphilhealthtype As New List(Of BindingItems)
        cbphilhealthtype.Add(New BindingItems With {.id = 0, .name = "Undefine"})
        cbphilhealthtype.Add(New BindingItems With {.id = 1, .name = "Private"})
        cbphilhealthtype.Add(New BindingItems With {.id = 2, .name = "Shared"})
        cbphilhealthtype.Add(New BindingItems With {.id = 3, .name = "Government"})
        bindingsouce.DataSource = cbphilhealthtype
        cbphtype.DataSource = bindingsouce
        cbphtype.DisplayMember = "name"
        cbphtype.ValueMember = "id"
        loadphilhealth()

        Dim bir = DDpres.GetBirmember
        With bir
            tbbr.Text = .registered
            tbbu.Text = .unregisted
        End With
        PopulateBarangay()
        PopulatePurok()
        Dim result = DDpres.GetHousehold(cbbarangay.SelectedValue, cbpurok.SelectedValue)
        tbhh.Text = result
        SocialStatus()
        Dim listofSocialStatus = SIPres.GetListofSocialStatus()
        listofSocialStatus.Insert(0, New Dataaccess.socialstatu With {.id = 0, .name = "All"})
        bindingsouce = New BindingSource
        bindingsouce.DataSource = listofSocialStatus
        cbsc.DataSource = bindingsouce
        cbsc.DisplayMember = "name"
        cbsc.ValueMember = "id"

        GroupPopulate()
        Dim listofCategory = UIPres.GetListofCCategory()
        listofCategory.Insert(0, New Dataaccess.citizencategory With {.id = 0, .name = "All"})
        bindingsouce = New BindingSource
        bindingsouce.DataSource = listofCategory
        cbgroup.DataSource = bindingsouce
        cbgroup.DisplayMember = "name"
        cbgroup.ValueMember = "id"

        AddHandler cbphtype.SelectedIndexChanged, AddressOf Me.cbphtype_SelectedIndexChanged
        AddHandler cbbarangay.SelectedIndexChanged, AddressOf Me.cbbarangay_SelectedIndexChanged
        AddHandler cbpurok.SelectedIndexChanged, AddressOf Me.cbpurok_SelectedIndexChanged
        AddHandler cbsc.SelectedIndexChanged, AddressOf Me.cbsc_SelectedIndexChanged
        AddHandler cbgroup.SelectedIndexChanged, AddressOf cbgroup_SelectedIndexChanged
    End Sub

    Private Sub loadphilhealth()
        Dim result = DDpres.GetPhilmember(cbphtype.SelectedValue)
        With result
            tbphr.Text = .registered
            tbphu.Text = .unregisted
        End With
    End Sub

    Public Sub PopulateBarangay()
        Dim bindingsouce As New BindingSource

        Dim addbarangay As New Dataaccess.barangay
        addbarangay.id = 0
        addbarangay.name = "All"
        Dim listbarangay = LPres.GetListofBarangayOrig()
        listbarangay.Insert(0, addbarangay)
        bindingsouce.DataSource = listbarangay
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
    Public Sub SocialStatus()

        Dim scresult = DDpres.GetSocialStat(cbsc.SelectedValue)
        With scresult
            tbsf.Text = .Famlilycount
            tbsp.Text = Math.Round(.percentage, 2)
        End With
    End Sub
    Public Sub GroupPopulate()


        Dim cgroup = DDpres.GetGroups(cbgroup.SelectedValue)
        With cgroup
            tbgf.Text = .Famlilycount
            tbgp.Text = Math.Round(.percentage, 2)
        End With
    End Sub
    Private Sub cbphtype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        loadphilhealth()
    End Sub

    Private Sub cbbarangay_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        PopulatePurok()
        Dim result = DDpres.GetHousehold(cbbarangay.SelectedValue, cbpurok.SelectedValue)
        tbhh.Text = result
    End Sub

    Private Sub cbpurok_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim result = DDpres.GetHousehold(cbbarangay.SelectedValue, cbpurok.SelectedValue)
        tbhh.Text = result
    End Sub

    Private Sub cbsc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SocialStatus()
    End Sub

    Private Sub cbgroup_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GroupPopulate()
    End Sub
End Class