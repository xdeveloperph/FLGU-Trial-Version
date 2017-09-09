Imports Presenter
Public Class SystemLogs
    Dim systemlog As New SystemPresenter
    Private Sub btnremove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnremove.Click
        Dim newgrid As New DataGridView
        newgrid = DataGridView1
        Dim bindingsouce As New BindingSource
        bindingsouce.DataSource = systemlog.SearchLogst(DateTimePicker1.Value, DateTimePicker2.Value)
        newgrid.DataSource = bindingsouce
        Datacolumns()
    End Sub

    Private Sub SystemLogs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim bindingsouce As New BindingSource
        bindingsouce.DataSource = systemlog.GetSystemLogs()
        DataGridView1.DataSource = bindingsouce
        Datacolumns()
    End Sub
    Public Sub Datacolumns()
        DataGridView1.Columns(0).HeaderText = "User"
        DataGridView1.Columns(1).HeaderText = "Action"
        DataGridView1.Columns(2).HeaderText = "Table Name"
        DataGridView1.Columns(3).HeaderText = "Date and Time"
        DataGridView1.Columns(4).HeaderText = "RID"
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
        Dim dashboard = New Dashboard
        dashboard.MdiParent = Main
        dashboard.StartPosition = FormStartPosition.CenterScreen
        dashboard.Show()
    End Sub
End Class