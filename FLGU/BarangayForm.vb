Imports Presenter
Public Class BarangayForm
    Private presenter As New LocationPresenter
    Public cityid As Integer
    Public barangayid As Integer
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim dashboard = New Dashboard
        dashboard.MdiParent = Main
        dashboard.StartPosition = FormStartPosition.CenterScreen
        dashboard.Show()
    End Sub

    Private Sub BarangayForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        LoadDataGridview()
        cm1()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cm2()
    End Sub

    Private Sub LoadDataGridview()

        Dim bindingsouce1 As New BindingSource
        bindingsouce1.DataSource = presenter.GetListofCity()
        cbcity.DataSource = bindingsouce1
        cbcity.DisplayMember = "name"
        cbcity.ValueMember = "id"

        Dim bindingsouce As New BindingSource
        Dim presenter1 As New LocationPresenter
        bindingsouce.DataSource = presenter1.GetListofBarangay()
        DataGridView1.DataSource = bindingsouce
        DataGridView1.Columns(0).HeaderText = "Record #"
        DataGridView1.Columns(1).HeaderText = "City"
        DataGridView1.Columns(2).HeaderText = "Barangay"
        DataGridView1.Columns(3).HeaderText = "Remove"
        DataGridView1.Columns(3).Visible = False
        DataGridView1.ClearSelection()

    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbarangay.KeyPress

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
            If (tbarangay.Text <> "" And tbarangay.Text <> " " And tbarangay.Text <> Nothing) Then
                presenter.InsertToBarangay(tbarangay.Text, Convert.ToInt32(cbcity.SelectedValue))
                tbarangay.Clear()
                LoadDataGridview()
            Else
                MsgBox("Invalid input format.")
                tbarangay.Focus()
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
            tbarangay.Text = DataGridView1.Item(2, i).Value
            barangayid = DataGridView1.Item(0, i).Value
            cityid = DataGridView1.Item(3, i).Value
            cbcity.SelectedValue = cityid
        Else
            MsgBox("Access Denied!")
        End If
       

    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Dim result = MsgBox("This would overwrite the existing record. Would you like to proceed?", MsgBoxStyle.YesNo)
        If (result = MsgBoxResult.Yes) Then
            presenter.UpdateBarangayByID(barangayid, tbarangay.Text, Convert.ToInt32(cbcity.SelectedValue))
            cm1()
            LoadDataGridview()
            MsgBox("You have successfully updated an old record.")
        End If
       
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        cm1()
        cityid = 0
        barangayid = 0

    End Sub

    Private Sub btnremove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnremove.Click
        Dim Logpress As New LoginPresenter
        Dim credentiaos = Logpress.LoginAccountCredentials()
        If credentiaos.delete = True Then
            Dim result = MsgBox("Are you sure you want to delete this item?", MsgBoxStyle.YesNo)
            Dim i = DataGridView1.CurrentRow.Index
            If (result = MsgBoxResult.Yes) Then
                presenter.RemoveBarangay(DataGridView1.Item(0, i).Value)
                tbarangay.Clear()
                LoadDataGridview()
                cm1()
                MsgBox("You have successfully deleted the record.")
            End If
        Else
            MsgBox("Access Denied!")
        End If
        
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        btnedit.Enabled = True
        btnedit.BackColor = Color.White
        btnremove.Enabled = True
        btnremove.BackColor = Color.White
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
        tbarangay.Clear()
    End Sub

    Public Sub cm2()
        btnadd.Enabled = False
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

End Class