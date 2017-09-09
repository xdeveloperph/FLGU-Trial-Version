Imports Presenter
Public Class DiseaseForm
    Private presenter As New SubInformationpresenter
    Public dieseaseid As Integer

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        Dim Logpress As New LoginPresenter
        Dim credentiaos = Logpress.LoginAccountCredentials()
        If credentiaos.create = True Then
            If (tbdiseasname.Text <> "" And tbdiseasname.Text <> " " And tbdiseasname.Text <> Nothing) Then
                presenter.InsertToDisease(tbdiseasname.Text)
                tbdiseasname.Clear()
                LoadDataGridview()
                MsgBox("You have successfully created a new record.")
            Else
                MsgBox("Invalid input format.")
                tbdiseasname.Clear()
                tbdiseasname.Focus()
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
            tbdiseasname.Text = DataGridView1.Item(1, i).Value
            dieseaseid = DataGridView1.Item(0, i).Value
        Else
            MsgBox("Access Denied!")
        End If
        
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Dim result = MsgBox("This would overwrite the existing record. Would you like to proceed?", MsgBoxStyle.YesNo)
        If (result = MsgBoxResult.Yes) Then
            presenter.UpdateDiseaseByID(dieseaseid, tbdiseasname.Text)
            LoadDataGridview()
            cm1()
            MsgBox("You have successfully updated an old record.")
        End If
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click

        dieseaseid = 0
        tbdiseasname.Clear()
        cm1()
    End Sub

    Private Sub btnremove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnremove.Click
        Dim Logpress As New LoginPresenter
        Dim credentiaos = Logpress.LoginAccountCredentials()
        If credentiaos.delete = True Then
            Dim result = MsgBox("Are you sure you want to delete this item?", MsgBoxStyle.YesNo)
            Dim i = DataGridView1.CurrentRow.Index
            If (result = MsgBoxResult.Yes) Then
                presenter.RemoveDisease(DataGridView1.Item(0, i).Value)
                LoadDataGridview()
                cm1()
                MsgBox("You have successfully deleted the record.")
            End If
        Else
            MsgBox("Access Denied!")
        End If
       


    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
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
        tbdiseasname.Clear()
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

    Private Sub diseasname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbdiseasname.KeyPress
        If (Char.IsLetterOrDigit(e.KeyChar)) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = Keys.Space Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub LoadDataGridview()
        Dim bindingsouce As New BindingSource
        bindingsouce.DataSource = presenter.GetListofDiseases()
        DataGridView1.DataSource = bindingsouce
        DataGridView1.Columns(0).HeaderText = "Record #"
        DataGridView1.Columns(1).HeaderText = "Disease"
        DataGridView1.Columns(2).HeaderText = "Date Created"
        DataGridView1.Columns(3).HeaderText = "Remove"
        DataGridView1.Columns(3).Visible = False
        DataGridView1.ClearSelection()
    End Sub
    Private Sub DiseaseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataGridview()
        cm1()
    End Sub
End Class