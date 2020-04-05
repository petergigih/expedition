Imports System.Data.Odbc
Public Class FormTransaksi
    Dim TglMySQL As String
    Sub KondisiAwal()
        LBLKendaraan.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        LBLKendaraan.Text = ""
        LBLTanggal.Text = Today
        LBLAdmin.Text = FormMenuUtama.STLabel4.Text
        LBLHargaBarang.Text = ""
        LBLSatuan.Text = ""
        LBLItem.Text = ""
        Call MunculSupir()
        Call NomorOtomatis()
        Call BuatKolom()
        Call MunculNamaBarang()
        LBLTotal.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
    End Sub

    Private Sub FormTransaksi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub

    Sub MunculSupir()
        Call Connection()
        ComboBox1.Items.Clear()
        Cmd = New OdbcCommand("Select * from tbl_Sopir", Conn)
        Rd = Cmd.ExecuteReader
        Do While Rd.Read
            ComboBox1.Items.Add(Rd.Item(1))
        Loop
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Call Connection()
        Cmd = New OdbcCommand("Select * from tbl_Sopir where namasopir ='" & ComboBox1.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            LBLKendaraan.Text = Rd!jenisKendaraan
        End If
    End Sub

    Sub MunculNamaBarang()
        Call Connection()
        ComboBox2.Items.Clear()
        Cmd = New OdbcCommand("Select * from tbl_barang", Conn)
        Rd = Cmd.ExecuteReader
        Do While Rd.Read
            ComboBox2.Items.Add(Rd.Item(1))
        Loop
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        Call Connection()
        Cmd = New OdbcCommand("Select * from tbl_barang where namabarang ='" & ComboBox2.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            LBLKode.Text = Rd!kodebarang
            LBLHargaBarang.Text = Rd!harga
            LBLSatuan.Text = Rd!satuan
            'TextBox3.Enabled = True
        End If
        TextBox7.Focus()
    End Sub

    Sub NomorOtomatis()
        Call Connection()
        Cmd = New OdbcCommand("Select * from tbl_jual where nojual in (select max(nojual) from tbl_jual)", Conn)
        Dim UrutanKode As String
        Dim Hitung As Long
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows Then
            UrutanKode = "J" + Format(Now, "yyMMdd") + "001"
        Else
            Hitung = Microsoft.VisualBasic.Right(Rd.GetString(0), 9) + 1
            UrutanKode = "J" + Format(Now, "yyMMdd") + Microsoft.VisualBasic.Right("000" & Hitung, 3)
        End If
        LBLTransaksi.Text = UrutanKode
    End Sub

    Sub BuatKolom()
        DataGridView1.Columns.Clear()
        DataGridView1.Columns.Add("Kode", "Kode")
        DataGridView1.Columns.Add("Nama", "Nama Barang")
        DataGridView1.Columns.Add("Harga", "Harga")
        DataGridView1.Columns.Add("Jumlah", "Jumlah")
        DataGridView1.Columns.Add("Satuan", "satuan")
        DataGridView1.Columns.Add("Subtotal", "Subtotal")
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

    End Sub

    Sub RumusCariItem()
        Dim HitungItem As Integer = 0
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            HitungItem = HitungItem + DataGridView1.Rows(i).Cells(2).Value
            LBLItem.Text = HitungItem
        Next
    End Sub

    Sub RumusSubTotal()
        Dim hitung As Integer = 0
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            hitung = hitung + DataGridView1.Rows(i).Cells(5).Value
            LBLTotal.Text = hitung
        Next
    End Sub

    Private Sub ButtonInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonInsert.Click
        If ComboBox2.Text = "" Or TextBox7.Text = "" Then
            MsgBox("Silahkan masukan nama barang dan jumlah barang!")
        Else
            DataGridView1.Rows.Add(New String() {LBLkode.Text, ComboBox2.Text, LBLHargaBarang.Text, TextBox7.Text, LBLSatuan.Text, Val(LBLHargaBarang.Text) * Val(TextBox7.Text)})
            Call RumusSubTotal()
            ComboBox2.Text = ""
            LBLHargaBarang.Text = ""
            TextBox7.Text = ""
            LBLSatuan.Text = ""
            'TextBox8.Text = ""
            Call RumusCariItem()
            DataGridView1.ReadOnly = True
            'Dim Baris As String = 0
            'If ComboBox2.Text.Equals(DataGridView1.Rows(Baris).Cells(1).Value) Then
            '    ComboBox2.Text = ComboBox2.Text - DataGridView1.Rows(Baris).Cells(1).Value
            'End If
        End If
    End Sub

    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or
    '        TextBox5.Text = "" Or TextBox6.Text = "" Or ComboBox1.Text = "" Then
    '        MsgBox("Silahkan lengkapi data terlebih dahulu")
    '    Else
    '        TglMySQL = Format(Today, "yyyy-MM-dd")
    '        Dim SimpanJual As String = "Insert into tbl_jual values ('" & LBLTransaksi.Text & "','" & FormMenuUtama.STLabel2.Text & "','" & LBLJam.Text & "', '" & TglMySQL & "','" & ComboBox1.Text & "', '" & TextBox1.Text & "','" & TextBox4.Text & "', '" & LBLItem.Text & "','" & LBLTotal.Text & "')" 'LBLAdmin.Text"
    '        Cmd = New OdbcCommand(SimpanJual, Conn)
    '        Cmd.ExecuteNonQuery()

    '        For Baris As Integer = 0 To DataGridView1.Rows.Count - 2
    '            'Dim SimpanDetail As String = "Insert into tbl_detailjual values('" & LBLTransaksi.Text & "', '" & TglMySQL & "','" & DataGridView1.Rows(Baris).Cells(0).Value & "', '" & DataGridView1.Rows(Baris).Cells(1).Value & "', '" & DataGridView1.Rows(Baris).Cells(2).Value & "', '" & DataGridView1.Rows(Baris).Cells(3).Value & "', '" & DataGridView1.Rows(Baris).Cells(4).Value & "')"
    '            Dim SimpanDetail As String = "Insert into tbl_detailjual values ('" & LBLTransaksi.Text & "','" & LBLkode.Text & "','" & DataGridView1.Rows(Baris).Cells(0).Value & "','" & DataGridView1.Rows(Baris).Cells(1).Value & "','" & DataGridView1.Rows(Baris).Cells(2).Value & "','" & DataGridView1.Rows(Baris).Cells(3).Value & "','" & DataGridView1.Rows(Baris).Cells(4).Value & "','" & TglMySQL & "')"
    '            Cmd = New OdbcCommand(SimpanDetail, Conn)
    '            Cmd.ExecuteNonQuery()

    '            'Cmd = New OdbcCommand("Select * from tbl_barang where kodebarang='" & DataGridView1.Rows(Baris).Cells(0).Value & "'", Conn)
    '            'Rd = Cmd.ExecuteReader
    '            'Rd.Read()
    '            'Dim KurangiStok As String = "update tbl_Barang set jumlah = '" & Rd.Item("jumlah") - DataGridView1.Rows(Baris).Cells(3).Value & "' where KodeBarang='" & DataGridView1.Rows(Baris).Cells(0).Value & "'"
    '            'Cmd = New OdbcCommand(KurangiStok, Conn)
    '            'Cmd.ExecuteNonQuery()
    '        Next
    '        Call KondisiAwal()

    '        MsgBox("Transaksi telah berhasil disimpan")
    '    End If

    'End Sub

    Private Sub ButtonPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPrint.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or
             TextBox5.Text = "" Or TextBox6.Text = "" Or ComboBox1.Text = "" Then
            MsgBox("Silahkan lengkapi data terlebih dahulu")
        Else
            TglMySQL = Format(Today, "yyyy-MM-dd")
            Dim SimpanJual As String = "Insert into tbl_jual values ('" & LBLTransaksi.Text & "','" & FormMenuUtama.STLabel2.Text & "','" & LBLJam.Text & "', '" & TglMySQL & "','" & ComboBox1.Text & "', '" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & TextBox3.Text & "','" & TextBox4.Text & "', '" & TextBox5.Text & "', '" & TextBox6.Text & "', '" & LBLItem.Text & "','" & LBLTotal.Text & "')" 'LBLAdmin.Text"
            Cmd = New OdbcCommand(SimpanJual, Conn)
            Cmd.ExecuteNonQuery()

            For Baris As Integer = 0 To DataGridView1.Rows.Count - 2
                'Dim SimpanDetail As String = "Insert into tbl_detailjual values('" & LBLTransaksi.Text & "', '" & TglMySQL & "','" & DataGridView1.Rows(Baris).Cells(0).Value & "', '" & DataGridView1.Rows(Baris).Cells(1).Value & "', '" & DataGridView1.Rows(Baris).Cells(2).Value & "', '" & DataGridView1.Rows(Baris).Cells(3).Value & "', '" & DataGridView1.Rows(Baris).Cells(4).Value & "')"
                Dim SimpanDetail As String = "Insert into tbl_detailjual values ('" & LBLTransaksi.Text & "','" & DataGridView1.Rows(Baris).Cells(0).Value & "','" & DataGridView1.Rows(Baris).Cells(1).Value & "','" & DataGridView1.Rows(Baris).Cells(2).Value & "','" & DataGridView1.Rows(Baris).Cells(3).Value & "','" & DataGridView1.Rows(Baris).Cells(4).Value & "','" & DataGridView1.Rows(Baris).Cells(5).Value & "','" & TglMySQL & "')"
                Cmd = New OdbcCommand(SimpanDetail, Conn)
                Cmd.ExecuteNonQuery()

                'Cmd = New OdbcCommand("Select * from tbl_barang where kodebarang='" & DataGridView1.Rows(Baris).Cells(0).Value & "'", Conn)
                'Rd = Cmd.ExecuteReader
                'Rd.Read()
                'Dim KurangiStok As String = "update tbl_Barang set jumlah = '" & Rd.Item("jumlah") - DataGridView1.Rows(Baris).Cells(3).Value & "' where KodeBarang='" & DataGridView1.Rows(Baris).Cells(0).Value & "'"
                'Cmd = New OdbcCommand(KurangiStok, Conn)
                'Cmd.ExecuteNonQuery()
            Next
            If MessageBox.Show("Cetak Nota?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                MsgBox("berhasil")
                AxCrystalReport1.SelectionFormula = "totext({tbl_jual.NoJual})='" & LBLTransaksi.Text & "'"
                AxCrystalReport1.ReportFileName = "NotaPenerimaan.rpt"
                AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
                AxCrystalReport1.RetrieveDataFiles()
                AxCrystalReport1.Action = 1
                Call KondisiAwal()
            Else
                Call KondisiAwal()

                MsgBox("Transaksi telah berhasil disimpan")
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        LBLJam.Text = TimeOfDay
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub TextBox6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox6.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub TextBox7_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox7.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub TextBox8_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ButtonBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBatal.Click
        If MsgBox("Apakah anda yakin ingin membatalkan transaksi?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            'DataGridView1.Columns.Clear()
            Call KondisiAwal()
        End If
        Call BuatKolom()
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub
End Class