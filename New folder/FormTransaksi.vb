Imports System.Data.Odbc
Public Class FormTransaksi
    Sub kondisiawal()
        LBLNama.Text = ""
        LBLAlamat.Text = ""
        LBLTelp.Text = ""
        LBLTanggal.Text = Today
        LBLAdmin.Text = FormMenuUtama.STLabel4.Text
        LBLKembali.Text = ""
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        LBLWaktu.Text = TimeOfDay
    End Sub

    Private Sub FormTransaksi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call kondisiawal()
        Call MunculKodePelanggan()
    End Sub
    Sub MunculKodePelanggan()
        Call Connection()
        Cmd = New OdbcCommand("Select * From tbl_pelanggan", Conn)
        Rd = Cmd.ExecuteReader
        Do While Rd.Read
            ComboBox1.Items.Add(Rd.Item(0))
        Loop
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Call Connection()
        Cmd = New OdbcCommand("Select * From tbl_pelanggan where NomorPelanggan= '" & ComboBox1.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            LBLNama.Text = Rd!Nama
            LBLAlamat.Text = Rd!Alamat
            LBLTelp.Text = Rd!Telepon
        End If
    End Sub
End Class