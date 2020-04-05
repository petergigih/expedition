Imports System.Data.Odbc
Public Class FormTransJual
    Dim TglMySQL As String
    Sub KondisiAwal()
        LBLNamaPlg.Text = ""
        LBLAlamat.Text = ""
        LBLTelepon.Text = ""
        LBLTanggal.Text = Today
        LBLAdmin.Text = FormMenuUtama.STLabel4.Text
        LBLKembali.Text = ""
        TextBox1.Text = ""
        LBLKode.Text = ""
        LBLStok.Text = ""
        LBLHargaBarang.Text = ""
        TextBox3.Text = ""
        TextBox3.Enabled = False
        LBLItem.Text = ""
        Call MunculKodePelanggan()
        Call NomorOtomatis()
        Call BuatKolom()
        Call MunculNamaBarang()
        LBLTotal.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Enabled = False
        Harga.Text = 0
        TextBox4.Text = 0
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        LBLJam.Text = TimeOfDay

    End Sub

    Private Sub FormTransJual_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call KondisiAwal()

        
    End Sub
    Sub MunculKodePelanggan()
        Call Connection()
        ComboBox1.Items.Clear()
        Cmd = New OdbcCommand("Select * from tbl_Pelanggan", Conn)
        Rd = Cmd.ExecuteReader
        Do While Rd.Read
            ComboBox1.Items.Add(Rd.Item(0))
        Loop
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Call Connection()
        Cmd = New OdbcCommand("Select * from tbl_Pelanggan where nomorpelanggan ='" & ComboBox1.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            LBLNamaPlg.Text = Rd!Nama
            LBLAlamat.Text = Rd!Alamat
            LBLTelepon.Text = Rd!Telepon
            ComboBox2.Enabled = True
        End If
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
        LBLNoJual.Text = UrutanKode
    End Sub
    Sub BuatKolom()
        DataGridView1.Columns.Clear()
        DataGridView1.Columns.Add("Kode", "Kode")
        DataGridView1.Columns.Add("Nama", "Nama Barang")
        DataGridView1.Columns.Add("Harga", "Harga")
        DataGridView1.Columns.Add("Jumlah", "Jumlah")
        DataGridView1.Columns.Add("Subtotal", "Subtotal")
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

    End Sub

    Private Sub ButtonInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonInsert.Click
        If ComboBox2.Text = "" Or TextBox3.Text = "" Then
            MsgBox("Silahkan masukan nama barang atau jumlah barang!")
        Else
            If Val(LBLStok.Text) < Val(TextBox3.Text) Then
                MsgBox("Jumlah Pembelian Melebihi Stok Barang!")
            Else
                DataGridView1.Rows.Add(New String() {LBLKode.Text, ComboBox2.Text, LBLHargaBarang.Text, TextBox3.Text, Val(LBLHargaBarang.Text) * Val(TextBox3.Text)})
                Call RumusSubTotal()
                LBLHargaBarang.Text = ""
                TextBox3.Text = ""
                TextBox3.Enabled = False
                TextBox1.Text = ""
                ComboBox2.Text = ""
                LBLTotal.Text = ""
                LBLKembali.Text = ""
                LBLStok.Text = ""
                Call RumusCariItem()
                DataGridView1.ReadOnly = True
                'Dim Baris As String = 0
                'If ComboBox2.Text.Equals(DataGridView1.Rows(Baris).Cells(1).Value) Then
                '    ComboBox2.Text = ComboBox2.Text - DataGridView1.Rows(Baris).Cells(1).Value
                'End If
            End If
        End If
    End Sub
    
    Sub RumusSubTotal()
        Dim hitung As Integer = 0
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            hitung = hitung + DataGridView1.Rows(i).Cells(4).Value
            Harga.Text = hitung
        Next
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
        If e.KeyChar = Chr(13) Then
            Dim HitungTotal As Integer = 0
            If TextBox4.Text = "" Then
                MsgBox("Masukan ongkir!")
            Else
                HitungTotal = HitungTotal + Harga.Text
                LBLTotal.Text = HitungTotal + TextBox4.Text
                If TextBox4.Text = "" Then
                    MsgBox("Masukan Pembayaran")
                ElseIf Val(TextBox1.Text) < Val(LBLTotal.Text) Then
                    MsgBox("Pembayaran Kurang!")
                ElseIf Val(TextBox1.Text) = Val(LBLTotal.Text) Then
                    LBLKembali.Text = 0
                ElseIf Val(TextBox1.Text) > Val(LBLTotal.Text) Then
                    LBLKembali.Text = Val(TextBox1.Text) - Val(LBLTotal.Text)
                    ButtonSimpan.Focus()
                End If
            End If
        End If
    End Sub
    Sub RumusCariItem()
        Dim HitungItem As Integer = 0
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            HitungItem = HitungItem + DataGridView1.Rows(i).Cells(3).Value
            LBLItem.Text = HitungItem
        Next
    End Sub
    Private Sub ButtonSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSimpan.Click
        If LBLKembali.Text = "" Or LBLNamaPlg.Text = "" Or LBLTotal.Text = "" Or DataGridView1.RowCount = 1 Then
            MsgBox("Transaksi tidak ada, silahkan lakukan transaksi terlebih dahulu")
        Else
            TglMySQL = Format(Today, "yyyy-MM-dd")
            Dim SimpanJual As String = "Insert into tbl_jual values ('" & LBLNoJual.Text & "', '" & TglMySQL & "','" & LBLJam.Text & "','" & LBLItem.Text & "','" & Harga.Text & "','" & TextBox1.Text & "','" & LBLKembali.Text & "','" & ComboBox1.Text & "','" & FormMenuUtama.STLabel2.Text & "', '" & TextBox4.Text & "', '" & LBLTotal.Text & "')" 'LBLAdmin.Text"
            Cmd = New OdbcCommand(SimpanJual, Conn)
            Cmd.ExecuteNonQuery()

            For Baris As Integer = 0 To DataGridView1.Rows.Count - 2
                'Dim SimpanDetail As String = "Insert into tbl_detailjual values('" & LBLNoJual.Text & "', '" & TglMySQL & "','" & DataGridView1.Rows(Baris).Cells(0).Value & "', '" & DataGridView1.Rows(Baris).Cells(1).Value & "', '" & DataGridView1.Rows(Baris).Cells(2).Value & "', '" & DataGridView1.Rows(Baris).Cells(3).Value & "', '" & DataGridView1.Rows(Baris).Cells(4).Value & "')"
                Dim SimpanDetail As String = "Insert into tbl_detailjual values ('" & LBLNoJual.Text & "','" & DataGridView1.Rows(Baris).Cells(0).Value & "','" & DataGridView1.Rows(Baris).Cells(1).Value & "','" & DataGridView1.Rows(Baris).Cells(2).Value & "','" & DataGridView1.Rows(Baris).Cells(3).Value & "','" & DataGridView1.Rows(Baris).Cells(4).Value & "','" & TglMySQL & "')"
                Cmd = New OdbcCommand(SimpanDetail, Conn)
                Cmd.ExecuteNonQuery()

                Cmd = New OdbcCommand("Select * from tbl_barang where kodebarang='" & DataGridView1.Rows(Baris).Cells(0).Value & "'", Conn)
                Rd = Cmd.ExecuteReader
                Rd.Read()
                Dim KurangiStok As String = "update tbl_Barang set jumlah = '" & Rd.Item("jumlah") - DataGridView1.Rows(Baris).Cells(3).Value & "' where KodeBarang='" & DataGridView1.Rows(Baris).Cells(0).Value & "'"
                Cmd = New OdbcCommand(KurangiStok, Conn)
                Cmd.ExecuteNonQuery()
            Next
            If MessageBox.Show("Cetak Nota?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                MsgBox("berhasil")
                AxCrystalReport1.SelectionFormula = "totext({tbl_jual.NoJual})='" & LBLNoJual.Text & "'"
                AxCrystalReport1.ReportFileName = "NotaPenjualanNewDBS.rpt"
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

    'Private Sub ButtonHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonHapus.Click
    '    DataGridView1.


    'End Sub

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
            LBLStok.Text = Rd!jumlah
            TextBox3.Enabled = True
        End If
        TextBox3.Focus()

    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
        If e.KeyChar = Chr(13) Then
            If TextBox4.Text = "" Then
                MsgBox("Masukan ongkir!")
            Else
                Dim HitungTotal As Integer = 0
                HitungTotal = HitungTotal + Harga.Text
                LBLTotal.Text = HitungTotal + TextBox4.Text
                ButtonHitungTotal.Focus()
            End If
        End If
    End Sub

    Private Sub ButtonHitungTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonHitungTotal.Click
        Dim HitungTotal As Integer = 0
        If TextBox4.Text = "" Then
            MsgBox("Masukan ongkir!")
        Else
            HitungTotal = HitungTotal + Harga.Text
            LBLTotal.Text = HitungTotal + TextBox4.Text
        End If
    End Sub

    Private Sub ButtonDibayar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDibayar.Click
        Dim HitungTotal As Integer = 0
        If TextBox4.Text = "" Then
            MsgBox("Masukan ongkir!")
        Else
            HitungTotal = HitungTotal + Harga.Text
            LBLTotal.Text = HitungTotal + TextBox4.Text
            If TextBox1.Text = "" Then
                MsgBox("Masukan Pembayaran")
            ElseIf Val(TextBox1.Text) < Val(LBLTotal.Text) Then
                MsgBox("Pembayaran Kurang!")
            ElseIf Val(TextBox1.Text) = Val(LBLTotal.Text) Then
                LBLKembali.Text = 0
            ElseIf Val(TextBox1.Text) > Val(LBLTotal.Text) Then
                LBLKembali.Text = Val(TextBox1.Text) - Val(LBLTotal.Text)
                ButtonSimpan.Focus()
            End If
        End If
    End Sub

    Private Sub ButtonBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBatal.Click
        If MsgBox("Apakah anda yakin ingin membatalkan transaksi?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            DataGridView1.Columns.Clear()
        End If
        Call BuatKolom()
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
        'ButtonInsert.Focus()
    End Sub

    Private Sub AxCrystalReport1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AxCrystalReport1.Enter

    End Sub

 
  
    Private Sub LBLNoJual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LBLNoJual.Click

    End Sub

    Private Sub NamaBarang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NamaBarang.Click

    End Sub

    Private Sub LBLKode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LBLKode.Click

    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub LBLStok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LBLStok.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub LBLJam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LBLJam.Click

    End Sub
End Class