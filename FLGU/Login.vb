Imports Presenter


Public Class Login
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Private Sub loginUser()
        Dim a As Date = Date.Parse("06/21/2014")
        Dim b As Date = Date.Parse("12/31/2014")
        If a <= Now.Date And b >= Now.Date Then
            Try
                Dim loginpress = New LoginPresenter
                Dim resul = loginpress.LoginVerification(txtusername.Text, txtpassword.Text)
                If resul = 1 Then
                    txtusername.Focus()
                    Main.Show()
                    Me.Hide()
                ElseIf resul = 0 Then
                    MessageBox.Show("Invalid username/password.")
                    txtusername.Focus()
                End If
            Catch ex As Exception
                MsgBox("Fail to connect to server.")
            End Try
        Else
            MsgBox("System has expired.")
        End If
    End Sub

    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
       
            loginUser()
            ClearTextBox(Me)
       

    End Sub

    Private Sub txtpassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            loginUser()
            ClearTextBox(Me)
        End If
    End Sub

    Public Sub ClearTextBox(ByVal root As Control)
        For Each ctrl As Control In root.Controls
            ClearTextBox(ctrl)
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Text = String.Empty
            End If
        Next ctrl
    End Sub

    Private Sub Login_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If Asc(e.KeyChar) = Keys.F10 Then
            Me.Hide()
            DataCon.Show()
        End If
    End Sub
    Protected Overrides Function ProcessKeyPreview(ByRef m As System.Windows.Forms.Message) As Boolean
        If m.Msg = 260 Then  'WM_KEYDOWN
            Dim key As Keys = m.WParam
            If key = Keys.F10 Then
                Me.Hide()
                DataCon.Show()
                Return True
            End If
        End If

        Return MyBase.ProcessKeyPreview(m)
    End Function

End Class