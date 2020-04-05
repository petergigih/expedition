Imports System.Data.Odbc
Public Class FormLogin

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()

    End Sub

    Sub Terbuka()
        FormMenuUtama.LoginToolStripMenuItem.Enabled = False
        FormMenuUtama.LogoutToolStripMenuItem.Enabled = True
        FormMenuUtama.UtilityToolStripMenuItem.Enabled = False

        FormMenuUtama.GroupBox1.Visible = True
        FormMenuUtama.GroupBox2.Visible = True
        FormMenuUtama.GroupBox3.Visible = True
        FormMenuUtama.Button1.Visible = True
        FormMenuUtama.Button2.Visible = True
        FormMenuUtama.Button3.Visible = True
        FormMenuUtama.Button4.Visible = True
        FormMenuUtama.Button5.Visible = True
        FormMenuUtama.Button6.Visible = True
        FormMenuUtama.Button7.Visible = True
        FormMenuUtama.Button8.Visible = True
        FormMenuUtama.Supir.Visible = True
    End Sub

    Sub KondisiAwal()
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Masukan Username dan Password!")
        Else
            Call Connection()
            Cmd = New OdbcCommand("Select * From tbl_admin where kode_admin='" & TextBox1.Text & "' and password_admin = '" & TextBox2.Text & "'", Conn)

            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                Me.Close()
                Call Terbuka()
                FormMenuUtama.STLabel2.Text = Rd!Kode_Admin
                FormMenuUtama.STLabel4.Text = Rd!Nama_Admin
                FormMenuUtama.STLabel6.Text = Rd!Level_Admin
                'FormMenuUtama.ShowDialog()
                If FormMenuUtama.STLabel6.Text = "ADMIN" Then
                    FormMenuUtama.Button1.Enabled = True
                ElseIf FormMenuUtama.STLabel6.Text = "USER" Then
                    'FormMenuUtama.ShowDialog()
                    FormMenuUtama.Button1.Enabled = False
                End If
            Else
                MsgBox("Username atau Password Anda Salah!")
            End If

        End If
    End Sub

    Private Sub FormLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Button1_Click(e, AcceptButton)
        End If
    End Sub

End Class