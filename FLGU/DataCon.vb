Imports Presenter


Public Class DataCon
    Dim connpress As New LoginPresenter
    Dim Test As New LocationPresenter
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        Login.Show()

    End Sub

    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        connpress.MySQLSettings(tbhost.Text, tbpassword.Text, tbusername.Text)

    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Test.GetListofBarangay()
            MsgBox("Connection Successful!")
        Catch ex As Exception
            MsgBox("Fail to connect to server.")
        End Try
    End Sub

    Private Sub DataCon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim data = connpress.MySQLSettingsData()
        tbhost.Text = data.host
        tbpassword.Text = data.password
        tbusername.Text = data.username

    End Sub
End Class