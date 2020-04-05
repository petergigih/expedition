<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTransJual
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTransJual))
        Me.NomorJual = New System.Windows.Forms.Label()
        Me.KodePelanggan = New System.Windows.Forms.Label()
        Me.Nama = New System.Windows.Forms.Label()
        Me.Alamat = New System.Windows.Forms.Label()
        Me.Telepon = New System.Windows.Forms.Label()
        Me.LBLNoJual = New System.Windows.Forms.Label()
        Me.LBLNamaPlg = New System.Windows.Forms.Label()
        Me.LBLAlamat = New System.Windows.Forms.Label()
        Me.LBLTelepon = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Total = New System.Windows.Forms.Label()
        Me.LBLTotal = New System.Windows.Forms.Label()
        Me.Tanggal = New System.Windows.Forms.Label()
        Me.Jam = New System.Windows.Forms.Label()
        Me.Admin = New System.Windows.Forms.Label()
        Me.LBLTanggal = New System.Windows.Forms.Label()
        Me.LBLJam = New System.Windows.Forms.Label()
        Me.LBLAdmin = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Kode = New System.Windows.Forms.Label()
        Me.NamaBarang = New System.Windows.Forms.Label()
        Me.HargaBarang = New System.Windows.Forms.Label()
        Me.JumlahBarang = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.ButtonInsert = New System.Windows.Forms.Button()
        Me.LBLHargaBarang = New System.Windows.Forms.Label()
        Me.ButtonSimpan = New System.Windows.Forms.Button()
        Me.ButtonBatal = New System.Windows.Forms.Button()
        Me.Dibayar = New System.Windows.Forms.Label()
        Me.Kembali = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.LBLKembali = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TotalItem = New System.Windows.Forms.Label()
        Me.LBLItem = New System.Windows.Forms.Label()
        Me.Ongkir = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.LBLKode = New System.Windows.Forms.Label()
        Me.Harga = New System.Windows.Forms.Label()
        Me.ButtonHitungTotal = New System.Windows.Forms.Button()
        Me.ButtonDibayar = New System.Windows.Forms.Button()
        Me.Stok = New System.Windows.Forms.Label()
        Me.LBLStok = New System.Windows.Forms.Label()
        Me.TotalHargaItem = New System.Windows.Forms.Label()
        Me.AxCrystalReport1 = New AxCrystal.AxCrystalReport()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NomorJual
        '
        Me.NomorJual.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.NomorJual.Location = New System.Drawing.Point(21, 24)
        Me.NomorJual.Name = "NomorJual"
        Me.NomorJual.Size = New System.Drawing.Size(138, 20)
        Me.NomorJual.TabIndex = 0
        Me.NomorJual.Text = "Nomor Jual"
        Me.NomorJual.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'KodePelanggan
        '
        Me.KodePelanggan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.KodePelanggan.Location = New System.Drawing.Point(21, 47)
        Me.KodePelanggan.Name = "KodePelanggan"
        Me.KodePelanggan.Size = New System.Drawing.Size(138, 20)
        Me.KodePelanggan.TabIndex = 1
        Me.KodePelanggan.Text = "Kode Pelanggan"
        Me.KodePelanggan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Nama
        '
        Me.Nama.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Nama.Location = New System.Drawing.Point(21, 69)
        Me.Nama.Name = "Nama"
        Me.Nama.Size = New System.Drawing.Size(138, 23)
        Me.Nama.TabIndex = 2
        Me.Nama.Text = "Nama"
        Me.Nama.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Alamat
        '
        Me.Alamat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Alamat.Location = New System.Drawing.Point(21, 94)
        Me.Alamat.Name = "Alamat"
        Me.Alamat.Size = New System.Drawing.Size(138, 24)
        Me.Alamat.TabIndex = 3
        Me.Alamat.Text = "Alamat"
        Me.Alamat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Telepon
        '
        Me.Telepon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Telepon.Location = New System.Drawing.Point(21, 120)
        Me.Telepon.Name = "Telepon"
        Me.Telepon.Size = New System.Drawing.Size(138, 24)
        Me.Telepon.TabIndex = 4
        Me.Telepon.Text = "Telepon"
        Me.Telepon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LBLNoJual
        '
        Me.LBLNoJual.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLNoJual.Location = New System.Drawing.Point(169, 24)
        Me.LBLNoJual.Name = "LBLNoJual"
        Me.LBLNoJual.Size = New System.Drawing.Size(108, 20)
        Me.LBLNoJual.TabIndex = 5
        Me.LBLNoJual.Text = "LBLNoJual"
        Me.LBLNoJual.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LBLNamaPlg
        '
        Me.LBLNamaPlg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLNamaPlg.Location = New System.Drawing.Point(169, 70)
        Me.LBLNamaPlg.Name = "LBLNamaPlg"
        Me.LBLNamaPlg.Size = New System.Drawing.Size(255, 22)
        Me.LBLNamaPlg.TabIndex = 6
        Me.LBLNamaPlg.Text = "LBLNama"
        Me.LBLNamaPlg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LBLAlamat
        '
        Me.LBLAlamat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLAlamat.Location = New System.Drawing.Point(169, 93)
        Me.LBLAlamat.Name = "LBLAlamat"
        Me.LBLAlamat.Size = New System.Drawing.Size(255, 25)
        Me.LBLAlamat.TabIndex = 7
        Me.LBLAlamat.Text = "LBLAlamat"
        Me.LBLAlamat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LBLTelepon
        '
        Me.LBLTelepon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLTelepon.Location = New System.Drawing.Point(169, 120)
        Me.LBLTelepon.Name = "LBLTelepon"
        Me.LBLTelepon.Size = New System.Drawing.Size(255, 23)
        Me.LBLTelepon.TabIndex = 8
        Me.LBLTelepon.Text = "LBLTelepon"
        Me.LBLTelepon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(169, 46)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(108, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'Total
        '
        Me.Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total.Location = New System.Drawing.Point(449, 24)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(116, 32)
        Me.Total.TabIndex = 10
        Me.Total.Text = "TOTAL : Rp."
        Me.Total.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LBLTotal
        '
        Me.LBLTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTotal.Location = New System.Drawing.Point(555, 24)
        Me.LBLTotal.Name = "LBLTotal"
        Me.LBLTotal.Size = New System.Drawing.Size(143, 32)
        Me.LBLTotal.TabIndex = 11
        Me.LBLTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Tanggal
        '
        Me.Tanggal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Tanggal.Location = New System.Drawing.Point(447, 69)
        Me.Tanggal.Name = "Tanggal"
        Me.Tanggal.Size = New System.Drawing.Size(100, 23)
        Me.Tanggal.TabIndex = 12
        Me.Tanggal.Text = "Tanggal"
        Me.Tanggal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Jam
        '
        Me.Jam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Jam.Location = New System.Drawing.Point(447, 95)
        Me.Jam.Name = "Jam"
        Me.Jam.Size = New System.Drawing.Size(100, 23)
        Me.Jam.TabIndex = 13
        Me.Jam.Text = "Jam"
        Me.Jam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Admin
        '
        Me.Admin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Admin.Location = New System.Drawing.Point(447, 121)
        Me.Admin.Name = "Admin"
        Me.Admin.Size = New System.Drawing.Size(100, 23)
        Me.Admin.TabIndex = 14
        Me.Admin.Text = "Admin"
        Me.Admin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LBLTanggal
        '
        Me.LBLTanggal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLTanggal.Location = New System.Drawing.Point(566, 69)
        Me.LBLTanggal.Name = "LBLTanggal"
        Me.LBLTanggal.Size = New System.Drawing.Size(138, 23)
        Me.LBLTanggal.TabIndex = 15
        Me.LBLTanggal.Text = "LBLTanggal"
        Me.LBLTanggal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LBLJam
        '
        Me.LBLJam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLJam.Location = New System.Drawing.Point(566, 95)
        Me.LBLJam.Name = "LBLJam"
        Me.LBLJam.Size = New System.Drawing.Size(138, 23)
        Me.LBLJam.TabIndex = 16
        Me.LBLJam.Text = "LBLJam"
        Me.LBLJam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LBLAdmin
        '
        Me.LBLAdmin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLAdmin.Cursor = System.Windows.Forms.Cursors.Default
        Me.LBLAdmin.Location = New System.Drawing.Point(566, 121)
        Me.LBLAdmin.Name = "LBLAdmin"
        Me.LBLAdmin.Size = New System.Drawing.Size(138, 23)
        Me.LBLAdmin.TabIndex = 17
        Me.LBLAdmin.Text = "LBLAdmin"
        Me.LBLAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.Location = New System.Drawing.Point(21, 250)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(683, 147)
        Me.DataGridView1.TabIndex = 18
        '
        'Kode
        '
        Me.Kode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Kode.Location = New System.Drawing.Point(308, 158)
        Me.Kode.Name = "Kode"
        Me.Kode.Size = New System.Drawing.Size(105, 23)
        Me.Kode.TabIndex = 19
        Me.Kode.Text = "Kode Barang"
        Me.Kode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NamaBarang
        '
        Me.NamaBarang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.NamaBarang.Location = New System.Drawing.Point(21, 158)
        Me.NamaBarang.Name = "NamaBarang"
        Me.NamaBarang.Size = New System.Drawing.Size(138, 23)
        Me.NamaBarang.TabIndex = 21
        Me.NamaBarang.Text = "Nama Barang"
        Me.NamaBarang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'HargaBarang
        '
        Me.HargaBarang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.HargaBarang.Location = New System.Drawing.Point(21, 186)
        Me.HargaBarang.Name = "HargaBarang"
        Me.HargaBarang.Size = New System.Drawing.Size(138, 23)
        Me.HargaBarang.TabIndex = 22
        Me.HargaBarang.Text = "Harga Barang"
        Me.HargaBarang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'JumlahBarang
        '
        Me.JumlahBarang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.JumlahBarang.Location = New System.Drawing.Point(308, 186)
        Me.JumlahBarang.Name = "JumlahBarang"
        Me.JumlahBarang.Size = New System.Drawing.Size(105, 23)
        Me.JumlahBarang.TabIndex = 23
        Me.JumlahBarang.Text = "Jumlah"
        Me.JumlahBarang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(419, 189)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(95, 20)
        Me.TextBox3.TabIndex = 3
        '
        'ButtonInsert
        '
        Me.ButtonInsert.Location = New System.Drawing.Point(559, 186)
        Me.ButtonInsert.Name = "ButtonInsert"
        Me.ButtonInsert.Size = New System.Drawing.Size(72, 23)
        Me.ButtonInsert.TabIndex = 4
        Me.ButtonInsert.Text = "Insert"
        Me.ButtonInsert.UseVisualStyleBackColor = True
        '
        'LBLHargaBarang
        '
        Me.LBLHargaBarang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLHargaBarang.Location = New System.Drawing.Point(169, 186)
        Me.LBLHargaBarang.Name = "LBLHargaBarang"
        Me.LBLHargaBarang.Size = New System.Drawing.Size(123, 23)
        Me.LBLHargaBarang.TabIndex = 27
        Me.LBLHargaBarang.Text = "Harga"
        Me.LBLHargaBarang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ButtonSimpan
        '
        Me.ButtonSimpan.Location = New System.Drawing.Point(594, 466)
        Me.ButtonSimpan.Name = "ButtonSimpan"
        Me.ButtonSimpan.Size = New System.Drawing.Size(91, 30)
        Me.ButtonSimpan.TabIndex = 9
        Me.ButtonSimpan.Text = "SIMPAN"
        Me.ButtonSimpan.UseVisualStyleBackColor = True
        '
        'ButtonBatal
        '
        Me.ButtonBatal.Location = New System.Drawing.Point(235, 415)
        Me.ButtonBatal.Name = "ButtonBatal"
        Me.ButtonBatal.Size = New System.Drawing.Size(101, 39)
        Me.ButtonBatal.TabIndex = 29
        Me.ButtonBatal.Text = "BATAL"
        Me.ButtonBatal.UseVisualStyleBackColor = True
        '
        'Dibayar
        '
        Me.Dibayar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Dibayar.Location = New System.Drawing.Point(361, 438)
        Me.Dibayar.Name = "Dibayar"
        Me.Dibayar.Size = New System.Drawing.Size(100, 23)
        Me.Dibayar.TabIndex = 31
        Me.Dibayar.Text = "Di Bayar"
        Me.Dibayar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Kembali
        '
        Me.Kembali.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Kembali.Location = New System.Drawing.Point(361, 469)
        Me.Kembali.Name = "Kembali"
        Me.Kembali.Size = New System.Drawing.Size(100, 23)
        Me.Kembali.TabIndex = 32
        Me.Kembali.Text = "Kembali"
        Me.Kembali.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(467, 438)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(110, 20)
        Me.TextBox1.TabIndex = 7
        '
        'LBLKembali
        '
        Me.LBLKembali.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLKembali.Location = New System.Drawing.Point(467, 469)
        Me.LBLKembali.Name = "LBLKembali"
        Me.LBLKembali.Size = New System.Drawing.Size(110, 23)
        Me.LBLKembali.TabIndex = 34
        Me.LBLKembali.Text = "LBLKembali"
        Me.LBLKembali.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'TotalItem
        '
        Me.TotalItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TotalItem.Location = New System.Drawing.Point(559, 159)
        Me.TotalItem.Name = "TotalItem"
        Me.TotalItem.Size = New System.Drawing.Size(71, 23)
        Me.TotalItem.TabIndex = 35
        Me.TotalItem.Text = "Total Item"
        Me.TotalItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LBLItem
        '
        Me.LBLItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLItem.Location = New System.Drawing.Point(636, 159)
        Me.LBLItem.Name = "LBLItem"
        Me.LBLItem.Size = New System.Drawing.Size(59, 23)
        Me.LBLItem.TabIndex = 36
        Me.LBLItem.Text = "LBLItem"
        Me.LBLItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Ongkir
        '
        Me.Ongkir.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Ongkir.Location = New System.Drawing.Point(361, 416)
        Me.Ongkir.Name = "Ongkir"
        Me.Ongkir.Size = New System.Drawing.Size(100, 23)
        Me.Ongkir.TabIndex = 37
        Me.Ongkir.Text = "Ongkir"
        Me.Ongkir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox4
        '
        Me.TextBox4.AccessibleDescription = ""
        Me.TextBox4.AccessibleName = ""
        Me.TextBox4.Location = New System.Drawing.Point(467, 416)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(110, 20)
        Me.TextBox4.TabIndex = 5
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(171, 159)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 2
        '
        'LBLKode
        '
        Me.LBLKode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLKode.Location = New System.Drawing.Point(419, 158)
        Me.LBLKode.Name = "LBLKode"
        Me.LBLKode.Size = New System.Drawing.Size(95, 23)
        Me.LBLKode.TabIndex = 40
        Me.LBLKode.Text = "LBLKode"
        Me.LBLKode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Harga
        '
        Me.Harga.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Harga.Location = New System.Drawing.Point(637, 189)
        Me.Harga.Name = "Harga"
        Me.Harga.Size = New System.Drawing.Size(58, 23)
        Me.Harga.TabIndex = 41
        Me.Harga.Text = "Harga"
        Me.Harga.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ButtonHitungTotal
        '
        Me.ButtonHitungTotal.Location = New System.Drawing.Point(594, 415)
        Me.ButtonHitungTotal.Name = "ButtonHitungTotal"
        Me.ButtonHitungTotal.Size = New System.Drawing.Size(91, 21)
        Me.ButtonHitungTotal.TabIndex = 6
        Me.ButtonHitungTotal.Text = "Hitung Total"
        Me.ButtonHitungTotal.UseVisualStyleBackColor = True
        '
        'ButtonDibayar
        '
        Me.ButtonDibayar.Location = New System.Drawing.Point(594, 439)
        Me.ButtonDibayar.Name = "ButtonDibayar"
        Me.ButtonDibayar.Size = New System.Drawing.Size(91, 21)
        Me.ButtonDibayar.TabIndex = 8
        Me.ButtonDibayar.Text = "Dibayar"
        Me.ButtonDibayar.UseVisualStyleBackColor = True
        '
        'Stok
        '
        Me.Stok.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Stok.Location = New System.Drawing.Point(21, 217)
        Me.Stok.Name = "Stok"
        Me.Stok.Size = New System.Drawing.Size(138, 23)
        Me.Stok.TabIndex = 44
        Me.Stok.Text = "Stok Barang"
        Me.Stok.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LBLStok
        '
        Me.LBLStok.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLStok.Location = New System.Drawing.Point(169, 217)
        Me.LBLStok.Name = "LBLStok"
        Me.LBLStok.Size = New System.Drawing.Size(123, 23)
        Me.LBLStok.TabIndex = 45
        Me.LBLStok.Text = "Harga Barang"
        Me.LBLStok.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TotalHargaItem
        '
        Me.TotalHargaItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TotalHargaItem.Location = New System.Drawing.Point(250, 458)
        Me.TotalHargaItem.Name = "TotalHargaItem"
        Me.TotalHargaItem.Size = New System.Drawing.Size(86, 23)
        Me.TotalHargaItem.TabIndex = 46
        Me.TotalHargaItem.Text = "TotalHargaItem"
        Me.TotalHargaItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TotalHargaItem.Visible = False
        '
        'AxCrystalReport1
        '
        Me.AxCrystalReport1.Enabled = True
        Me.AxCrystalReport1.Location = New System.Drawing.Point(467, 216)
        Me.AxCrystalReport1.Name = "AxCrystalReport1"
        Me.AxCrystalReport1.OcxState = CType(resources.GetObject("AxCrystalReport1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxCrystalReport1.Size = New System.Drawing.Size(28, 28)
        Me.AxCrystalReport1.TabIndex = 47
        '
        'FormTransJual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(726, 508)
        Me.Controls.Add(Me.AxCrystalReport1)
        Me.Controls.Add(Me.TotalHargaItem)
        Me.Controls.Add(Me.LBLStok)
        Me.Controls.Add(Me.Stok)
        Me.Controls.Add(Me.ButtonDibayar)
        Me.Controls.Add(Me.ButtonHitungTotal)
        Me.Controls.Add(Me.Harga)
        Me.Controls.Add(Me.LBLKode)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Ongkir)
        Me.Controls.Add(Me.LBLItem)
        Me.Controls.Add(Me.TotalItem)
        Me.Controls.Add(Me.LBLKembali)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Kembali)
        Me.Controls.Add(Me.Dibayar)
        Me.Controls.Add(Me.ButtonBatal)
        Me.Controls.Add(Me.ButtonSimpan)
        Me.Controls.Add(Me.LBLHargaBarang)
        Me.Controls.Add(Me.ButtonInsert)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.JumlahBarang)
        Me.Controls.Add(Me.HargaBarang)
        Me.Controls.Add(Me.NamaBarang)
        Me.Controls.Add(Me.Kode)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.LBLAdmin)
        Me.Controls.Add(Me.LBLJam)
        Me.Controls.Add(Me.LBLTanggal)
        Me.Controls.Add(Me.Admin)
        Me.Controls.Add(Me.Jam)
        Me.Controls.Add(Me.Tanggal)
        Me.Controls.Add(Me.LBLTotal)
        Me.Controls.Add(Me.Total)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.LBLTelepon)
        Me.Controls.Add(Me.LBLAlamat)
        Me.Controls.Add(Me.LBLNamaPlg)
        Me.Controls.Add(Me.LBLNoJual)
        Me.Controls.Add(Me.Telepon)
        Me.Controls.Add(Me.Alamat)
        Me.Controls.Add(Me.Nama)
        Me.Controls.Add(Me.KodePelanggan)
        Me.Controls.Add(Me.NomorJual)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FormTransJual"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaksi Penjualan"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NomorJual As System.Windows.Forms.Label
    Friend WithEvents KodePelanggan As System.Windows.Forms.Label
    Friend WithEvents Nama As System.Windows.Forms.Label
    Friend WithEvents Alamat As System.Windows.Forms.Label
    Friend WithEvents Telepon As System.Windows.Forms.Label
    Friend WithEvents LBLNoJual As System.Windows.Forms.Label
    Friend WithEvents LBLNamaPlg As System.Windows.Forms.Label
    Friend WithEvents LBLAlamat As System.Windows.Forms.Label
    Friend WithEvents LBLTelepon As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Total As System.Windows.Forms.Label
    Friend WithEvents LBLTotal As System.Windows.Forms.Label
    Friend WithEvents Tanggal As System.Windows.Forms.Label
    Friend WithEvents Jam As System.Windows.Forms.Label
    Friend WithEvents Admin As System.Windows.Forms.Label
    Friend WithEvents LBLTanggal As System.Windows.Forms.Label
    Friend WithEvents LBLJam As System.Windows.Forms.Label
    Friend WithEvents LBLAdmin As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Kode As System.Windows.Forms.Label
    Friend WithEvents NamaBarang As System.Windows.Forms.Label
    Friend WithEvents HargaBarang As System.Windows.Forms.Label
    Friend WithEvents JumlahBarang As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents ButtonInsert As System.Windows.Forms.Button
    Friend WithEvents LBLHargaBarang As System.Windows.Forms.Label
    Friend WithEvents ButtonSimpan As System.Windows.Forms.Button
    Friend WithEvents ButtonBatal As System.Windows.Forms.Button
    Friend WithEvents Dibayar As System.Windows.Forms.Label
    Friend WithEvents Kembali As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents LBLKembali As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents TotalItem As System.Windows.Forms.Label
    Friend WithEvents LBLItem As System.Windows.Forms.Label
    Friend WithEvents Ongkir As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents LBLKode As System.Windows.Forms.Label
    Friend WithEvents Harga As System.Windows.Forms.Label
    Friend WithEvents ButtonHitungTotal As System.Windows.Forms.Button
    Friend WithEvents ButtonDibayar As System.Windows.Forms.Button
    Friend WithEvents Stok As System.Windows.Forms.Label
    Friend WithEvents LBLStok As System.Windows.Forms.Label
    Friend WithEvents TotalHargaItem As System.Windows.Forms.Label
    Friend WithEvents AxCrystalReport1 As AxCrystal.AxCrystalReport
End Class
