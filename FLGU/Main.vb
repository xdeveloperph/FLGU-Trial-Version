Imports Presenter
Imports Microsoft.Office.Interop.Excel
Imports System.Transactions
Public Class Main
    Public initialize As Boolean
    Public columnstart As Integer
    Public columnend As Integer
    Public row As Integer

    Public pmax As Integer
    Public pmin As Integer
    Public pro As Integer
    Public filepath As String
    Public currentexcelbook As String
    Dim temphousehold As New ImportPresenter.IPHousehold
    Dim tempFamilyMember As New ImportPresenter.IPFamilyMembers
    Dim account As New LoginPresenter
    Dim importcommand As New ImportPresenter
    Private Sub Main_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Login.Show()
        account.Logout()
    End Sub

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dashboard = New Dashboard
        dashboard.MdiParent = Me
        dashboard.StartPosition = FormStartPosition.CenterScreen
        dashboard.Show()
    End Sub

    Private Sub SEARCHToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SEARCHToolStripMenuItem.Click
        Me.ActiveMdiChild.Close()
        Dim childform = New SearchForm
        childform.MdiParent = Me
        childform.StartPosition = FormStartPosition.CenterScreen
        childform.Show()
    End Sub

    Private Sub DASHBOADRDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DASHBOADRDToolStripMenuItem.Click
        Me.ActiveMdiChild.Close()
        Dim childform = New Dashboard
        childform.MdiParent = Me
        childform.StartPosition = FormStartPosition.CenterScreen
        childform.Show()
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub BarangayToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BarangayToolStripMenuItem.Click
        Me.ActiveMdiChild.Close()
        Dim childform = New BarangayForm
        childform.MdiParent = Me
        childform.StartPosition = FormStartPosition.CenterScreen
        childform.Show()
    End Sub

    Private Sub CityToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CityToolStripMenuItem.Click
        Me.ActiveMdiChild.Close()
        Dim householdform = New CityForm
        householdform.MdiParent = Me
        householdform.StartPosition = FormStartPosition.CenterScreen
        householdform.Show()
        householdform.tbcityname.Focus()
    End Sub

    Private Sub DiseaseToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles DiseaseToolStripMenuItem.Click
        Me.ActiveMdiChild.Close()
        Dim childform = New DiseaseForm
        childform.MdiParent = Me
        childform.StartPosition = FormStartPosition.CenterScreen
        childform.Show()
    End Sub

    Private Sub HouseholdToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles HouseholdToolStripMenuItem.Click
        Me.ActiveMdiChild.Close()
        Dim householdform = New HouseholdMainForm
        householdform.MdiParent = Me
        householdform.StartPosition = FormStartPosition.CenterScreen
        householdform.Show()
        householdform.cbcity.Focus()
    End Sub

    Private Sub OccupationToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles OccupationToolStripMenuItem.Click
        Me.ActiveMdiChild.Close()
        Dim childform = New OccupationForm
        childform.MdiParent = Me
        childform.StartPosition = FormStartPosition.CenterScreen
        childform.Show()
    End Sub

    Private Sub SystemLogsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SystemLogsToolStripMenuItem.Click
        Me.ActiveMdiChild.Close()
        Dim childform = New SystemLogs
        childform.MdiParent = Me
        childform.StartPosition = FormStartPosition.CenterScreen
        childform.Show()
    End Sub

    Private Sub ImportToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImportToolStripMenuItem1.Click
        
    End Sub

    Private Sub ImportBW_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles ImportBW.DoWork

    End Sub

 

    Private Sub ImportBW_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles ImportBW.ProgressChanged
        ToolStripProgressBar1.Minimum = 0
        ToolStripProgressBar1.Maximum = pmax
        ToolStripProgressBar1.Value = pro
        ToolStripStatusLabel1.Text = "Importing " + pro.ToString + "/" + pmax.ToString + " of data from " + currentexcelbook
    End Sub

    Private Sub ImportBW_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles ImportBW.RunWorkerCompleted
        ToolStripProgressBar1.Value = 0
        ToolStripStatusLabel1.Text = "Done"
    End Sub

    Private Sub CategoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CategoryToolStripMenuItem.Click
        Me.ActiveMdiChild.Close()
        Dim childform = New CategoryForm
        childform.MdiParent = Me
        childform.StartPosition = FormStartPosition.CenterScreen
        childform.Show()
    End Sub

    Private Sub SocialStatusToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SocialStatusToolStripMenuItem.Click
        Me.ActiveMdiChild.Close()
        Dim childform = New SocialStatusForm
        childform.MdiParent = Me
        childform.StartPosition = FormStartPosition.CenterScreen
        childform.Show()
    End Sub

    Private Sub AccountToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccountToolStripMenuItem1.Click
        Dim Logpress As New LoginPresenter
        Dim credentiaos = Logpress.LoginAccountCredentials()
        If credentiaos.level = 1 Then
            Me.ActiveMdiChild.Close()
            Dim childform = New AccountForm
            childform.MdiParent = Me
            childform.StartPosition = FormStartPosition.CenterScreen
            childform.Show()
        Else
            MsgBox("Access Denied!")
        End If

    End Sub

    Private Sub PuronToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PuronToolStripMenuItem.Click
        Me.ActiveMdiChild.Close()
        Dim childform = New ZoneForm
        childform.MdiParent = Me
        childform.StartPosition = FormStartPosition.CenterScreen
        childform.Show()
    End Sub
End Class