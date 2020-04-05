Imports System.Data.Odbc
Public Class FormLapJual

    Sub kondisiawal()
        Label7.Text = Format(DateTimePicker2.Value, "yyyy, MM, dd")
        Label8.Text = Format(DateTimePicker2.Value, "yyyy, MM, dd")
        DateTimePicker1.Text = Today
        DateTimePicker2.Text = Today
        DateTimePicker3.Text = Today

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Masukkan Nomor Nota Terlebih Dahulu!")
        Else
            Call Connection()
            Cmd = New OdbcCommand("Select * From tbl_jual where NoJual='" & TextBox1.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                AxCrystalReport1.SelectionFormula = "totext({tbl_jual.Nojual})='" & TextBox1.Text & "'"
                AxCrystalReport1.ReportFileName = "NotaPenerimaan.rpt"
                AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
                AxCrystalReport1.RetrieveDataFiles()
                AxCrystalReport1.Action = 1
                TextBox1.Text = ""
            Else
                MsgBox("Data tidak ditemukan!")
                TextBox1.Text = ""
            End If
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        AxCrystalReport1.SelectionFormula = "totext({tbl_jual.TanggalJual})='" & DateTimePicker1.Value & "'"
        AxCrystalReport1.ReportFileName = "LaporanHarian.rpt"
        AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
        AxCrystalReport1.RetrieveDataFiles()
        AxCrystalReport1.Action = 1
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        AxCrystalReport1.SelectionFormula = "{tbl_jual.tanggaljual}in date (" & Label7.Text & ") to date(" & Label8.Text & ")"
        AxCrystalReport1.ReportFileName = "LaporanMingguan.rpt"
        AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
        AxCrystalReport1.RetrieveDataFiles()
        AxCrystalReport1.Action = 1
    End Sub

    Private Sub FormLapJual_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("01 - JANUARI")
        ComboBox1.Items.Add("02 - FEBRUARI")
        ComboBox1.Items.Add("03 - MARET")
        ComboBox1.Items.Add("04 - APRIL")
        ComboBox1.Items.Add("05 - MEI")
        ComboBox1.Items.Add("06 - JUNI")
        ComboBox1.Items.Add("07 - JULI")
        ComboBox1.Items.Add("08 - AGUSTUS")
        ComboBox1.Items.Add("09 - SEPTEMBER")
        ComboBox1.Items.Add("10 - OKTOBER")
        ComboBox1.Items.Add("11 - NOVEMBER")
        ComboBox1.Items.Add("12 - DESEMBER")
        Call kondisiawal()
        ComboBox2.Items.Clear()
        ComboBox2.Text = Date.Now.Year
        For i As Integer = 0 To 1
            ComboBox2.Items.Add(Date.Now.Year - i)
        Next

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If ComboBox1.Text = "" Or ComboBox2.Text = "" Then
            MsgBox("Silahkan isi Bulan dan Tahunnya terlebih dahulu!")
        Else
            'Call Connection()
            'Cmd = New OdbcCommand("Select * From tbl_jual where tanggalJual='" & Val(ComboBox1.Text) & "'", Conn)
            'Rd = Cmd.ExecuteReader
            'Rd.Read()
            'If Rd.HasRows Then
            AxCrystalReport1.SelectionFormula = "Month({tbl_jual.tanggaljual})=" & Val(ComboBox1.Text) & " and year({tbl_jual.tanggaljual})=" & Val(ComboBox2.Text)
            AxCrystalReport1.ReportFileName = "LaporanBulanan.rpt"
            AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
            AxCrystalReport1.RetrieveDataFiles()
            AxCrystalReport1.Action = 1
            '    Else
            '    MsgBox("Data tidak ditemukan!")
            '    TextBox1.Text = ""
            'End If
        End If
    End Sub

    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged
        Label7.Text = Format(DateTimePicker2.Value, "yyyy, MM, dd")
    End Sub

    Private Sub DateTimePicker3_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker3.ValueChanged
        Label8.Text = Format(DateTimePicker3.Value, "yyyy, MM, dd")
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Button1_Click(e, AcceptButton)
        End If
    End Sub

End Class