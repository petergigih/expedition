<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTransaksi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTransaksi))
        Me.LBLTransaksi = New System.Windows.Forms.Label()
        Me.NomorJual = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.NamaBarang = New System.Windows.Forms.Label()
        Me.HargaBarang = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.JumlahBarang = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.LBLHargaBarang = New System.Windows.Forms.Label()
        Me.ButtonInsert = New System.Windows.Forms.Button()
        Me.LBLTotal = New System.Windows.Forms.Label()
        Me.Total = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Supir = New System.Windows.Forms.Label()
        Me.LBLKendaraan = New System.Windows.Forms.Label()
        Me.Nama = New System.Windows.Forms.Label()
        Me.LBLAdmin = New System.Windows.Forms.Label()
        Me.LBLJam = New System.Windows.Forms.Label()
        Me.LBLTanggal = New System.Windows.Forms.Label()
        Me.Admin = New System.Windows.Forms.Label()
        Me.Jam = New System.Windows.Forms.Label()
        Me.Tanggal = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ButtonBatal = New System.Windows.Forms.Button()
        Me.ButtonPrint = New System.Windows.Forms.Button()
        Me.TotalItem = New System.Windows.Forms.Label()
        Me.LBLItem = New System.Windows.Forms.Label()
        Me.AxCrystalReport1 = New AxCrystal.AxCrystalReport()
        Me.LBLkode = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LBLSatuan = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LBLTransaksi
        '
        Me.LBLTransaksi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLTransaksi.Location = New System.Drawing.Point(160, 24)
        Me.LBLTransaksi.Name = "LBLTransaksi"
        Me.LBLTransaksi.Size = New System.Drawing.Size(123, 20)
        Me.LBLTransaksi.TabIndex = 7
        Me.LBLTransaksi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NomorJual
        '
        Me.NomorJual.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.NomorJual.Location = New System.Drawing.Point(12, 24)
        Me.NomorJual.Name = "NomorJual"
        Me.NomorJual.Size = New System.Drawing.Size(138, 20)
        Me.NomorJual.TabIndex = 6
        Me.NomorJual.Text = "Nomor Transaksi"
        Me.NomorJual.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(12, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Nama Pengirim"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(12, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Alamat Pengirim"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(12, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 20)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Telepon Pengirim"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(418, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 20)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Nama Penerima"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Location = New System.Drawing.Point(418, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(138, 20)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Alamat Penerima"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Location = New System.Drawing.Point(418, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(138, 20)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Telepon Penerima"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(160, 87)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(200, 20)
        Me.TextBox3.TabIndex = 3
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(160, 47)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(200, 20)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(160, 67)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(200, 20)
        Me.TextBox2.TabIndex = 2
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(562, 45)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(200, 20)
        Me.TextBox4.TabIndex = 4
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(562, 66)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(200, 20)
        Me.TextBox5.TabIndex = 5
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(562, 87)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(200, 20)
        Me.TextBox6.TabIndex = 6
        '
        'NamaBarang
        '
        Me.NamaBarang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.NamaBarang.Location = New System.Drawing.Point(12, 144)
        Me.NamaBarang.Name = "NamaBarang"
        Me.NamaBarang.Size = New System.Drawing.Size(138, 23)
        Me.NamaBarang.TabIndex = 22
        Me.NamaBarang.Text = "Nama Barang"
        Me.NamaBarang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'HargaBarang
        '
        Me.HargaBarang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.HargaBarang.Location = New System.Drawing.Point(12, 168)
        Me.HargaBarang.Name = "HargaBarang"
        Me.HargaBarang.Size = New System.Drawing.Size(138, 23)
        Me.HargaBarang.TabIndex = 23
        Me.HargaBarang.Text = "Harga Barang"
        Me.HargaBarang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(418, 168)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(95, 20)
        Me.TextBox7.TabIndex = 9
        '
        'JumlahBarang
        '
        Me.JumlahBarang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.JumlahBarang.Location = New System.Drawing.Point(311, 168)
        Me.JumlahBarang.Name = "JumlahBarang"
        Me.JumlahBarang.Size = New System.Drawing.Size(101, 23)
        Me.JumlahBarang.TabIndex = 52
        Me.JumlahBarang.Text = "Jumlah"
        Me.JumlahBarang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(160, 144)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(123, 21)
        Me.ComboBox2.TabIndex = 8
        '
        'LBLHargaBarang
        '
        Me.LBLHargaBarang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLHargaBarang.Location = New System.Drawing.Point(160, 168)
        Me.LBLHargaBarang.Name = "LBLHargaBarang"
        Me.LBLHargaBarang.Size = New System.Drawing.Size(123, 23)
        Me.LBLHargaBarang.TabIndex = 54
        Me.LBLHargaBarang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ButtonInsert
        '
        Me.ButtonInsert.Location = New System.Drawing.Point(581, 171)
        Me.ButtonInsert.Name = "ButtonInsert"
        Me.ButtonInsert.Size = New System.Drawing.Size(72, 23)
        Me.ButtonInsert.TabIndex = 11
        Me.ButtonInsert.Text = "Insert"
        Me.ButtonInsert.UseVisualStyleBackColor = True
        '
        'LBLTotal
        '
        Me.LBLTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTotal.Location = New System.Drawing.Point(562, 386)
        Me.LBLTotal.Name = "LBLTotal"
        Me.LBLTotal.Size = New System.Drawing.Size(143, 32)
        Me.LBLTotal.TabIndex = 59
        Me.LBLTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Total
        '
        Me.Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total.Location = New System.Drawing.Point(436, 386)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(116, 32)
        Me.Total.TabIndex = 58
        Me.Total.Text = "TOTAL : Rp."
        Me.Total.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(160, 121)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(123, 21)
        Me.ComboBox1.TabIndex = 7
        '
        'Supir
        '
        Me.Supir.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Supir.Location = New System.Drawing.Point(12, 122)
        Me.Supir.Name = "Supir"
        Me.Supir.Size = New System.Drawing.Size(138, 20)
        Me.Supir.TabIndex = 60
        Me.Supir.Text = "Supir"
        Me.Supir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LBLKendaraan
        '
        Me.LBLKendaraan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLKendaraan.Location = New System.Drawing.Point(418, 120)
        Me.LBLKendaraan.Name = "LBLKendaraan"
        Me.LBLKendaraan.Size = New System.Drawing.Size(138, 22)
        Me.LBLKendaraan.TabIndex = 63
        Me.LBLKendaraan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Nama
        '
        Me.Nama.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Nama.Location = New System.Drawing.Point(311, 119)
        Me.Nama.Name = "Nama"
        Me.Nama.Size = New System.Drawing.Size(101, 23)
        Me.Nama.TabIndex = 62
        Me.Nama.Text = "Kendaraan"
        Me.Nama.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LBLAdmin
        '
        Me.LBLAdmin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLAdmin.Cursor = System.Windows.Forms.Cursors.Default
        Me.LBLAdmin.Location = New System.Drawing.Point(687, 9)
        Me.LBLAdmin.Name = "LBLAdmin"
        Me.LBLAdmin.Size = New System.Drawing.Size(138, 23)
        Me.LBLAdmin.TabIndex = 69
        Me.LBLAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LBLJam
        '
        Me.LBLJam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLJam.Location = New System.Drawing.Point(687, 145)
        Me.LBLJam.Name = "LBLJam"
        Me.LBLJam.Size = New System.Drawing.Size(138, 23)
        Me.LBLJam.TabIndex = 68
        Me.LBLJam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LBLTanggal
        '
        Me.LBLTanggal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLTanggal.Location = New System.Drawing.Point(687, 119)
        Me.LBLTanggal.Name = "LBLTanggal"
        Me.LBLTanggal.Size = New System.Drawing.Size(138, 23)
        Me.LBLTanggal.TabIndex = 67
        Me.LBLTanggal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Admin
        '
        Me.Admin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Admin.Location = New System.Drawing.Point(619, 9)
        Me.Admin.Name = "Admin"
        Me.Admin.Size = New System.Drawing.Size(58, 23)
        Me.Admin.TabIndex = 66
        Me.Admin.Text = "Admin"
        Me.Admin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Jam
        '
        Me.Jam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Jam.Location = New System.Drawing.Point(581, 145)
        Me.Jam.Name = "Jam"
        Me.Jam.Size = New System.Drawing.Size(100, 23)
        Me.Jam.TabIndex = 65
        Me.Jam.Text = "Jam"
        Me.Jam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Tanggal
        '
        Me.Tanggal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Tanggal.Location = New System.Drawing.Point(581, 119)
        Me.Tanggal.Name = "Tanggal"
        Me.Tanggal.Size = New System.Drawing.Size(100, 23)
        Me.Tanggal.TabIndex = 64
        Me.Tanggal.Text = "Tanggal"
        Me.Tanggal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.Location = New System.Drawing.Point(12, 200)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(813, 158)
        Me.DataGridView1.TabIndex = 70
        '
        'ButtonBatal
        '
        Me.ButtonBatal.Location = New System.Drawing.Point(25, 375)
        Me.ButtonBatal.Name = "ButtonBatal"
        Me.ButtonBatal.Size = New System.Drawing.Size(101, 39)
        Me.ButtonBatal.TabIndex = 76
        Me.ButtonBatal.Text = "BATAL"
        Me.ButtonBatal.UseVisualStyleBackColor = True
        '
        'ButtonPrint
        '
        Me.ButtonPrint.Location = New System.Drawing.Point(713, 387)
        Me.ButtonPrint.Name = "ButtonPrint"
        Me.ButtonPrint.Size = New System.Drawing.Size(91, 30)
        Me.ButtonPrint.TabIndex = 12
        Me.ButtonPrint.Text = "PRINT/SAVE"
        Me.ButtonPrint.UseVisualStyleBackColor = True
        '
        'TotalItem
        '
        Me.TotalItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TotalItem.Location = New System.Drawing.Point(940, 41)
        Me.TotalItem.Name = "TotalItem"
        Me.TotalItem.Size = New System.Drawing.Size(71, 23)
        Me.TotalItem.TabIndex = 56
        Me.TotalItem.Text = "Total Item"
        Me.TotalItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LBLItem
        '
        Me.LBLItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLItem.Location = New System.Drawing.Point(1017, 41)
        Me.LBLItem.Name = "LBLItem"
        Me.LBLItem.Size = New System.Drawing.Size(59, 23)
        Me.LBLItem.TabIndex = 57
        Me.LBLItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AxCrystalReport1
        '
        Me.AxCrystalReport1.Enabled = True
        Me.AxCrystalReport1.Location = New System.Drawing.Point(776, 59)
        Me.AxCrystalReport1.Name = "AxCrystalReport1"
        Me.AxCrystalReport1.OcxState = CType(resources.GetObject("AxCrystalReport1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxCrystalReport1.Size = New System.Drawing.Size(28, 28)
        Me.AxCrystalReport1.TabIndex = 80
        '
        'LBLkode
        '
        Me.LBLkode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLkode.Location = New System.Drawing.Point(1017, 81)
        Me.LBLkode.Name = "LBLkode"
        Me.LBLkode.Size = New System.Drawing.Size(59, 23)
        Me.LBLkode.TabIndex = 81
        Me.LBLkode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'LBLSatuan
        '
        Me.LBLSatuan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLSatuan.Location = New System.Drawing.Point(418, 142)
        Me.LBLSatuan.Name = "LBLSatuan"
        Me.LBLSatuan.Size = New System.Drawing.Size(123, 23)
        Me.LBLSatuan.TabIndex = 82
        Me.LBLSatuan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Location = New System.Drawing.Point(311, 145)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 23)
        Me.Label8.TabIndex = 83
        Me.Label8.Text = "Satuan"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FormTransaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(841, 448)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.LBLSatuan)
        Me.Controls.Add(Me.LBLkode)
        Me.Controls.Add(Me.AxCrystalReport1)
        Me.Controls.Add(Me.ButtonBatal)
        Me.Controls.Add(Me.ButtonPrint)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.LBLAdmin)
        Me.Controls.Add(Me.LBLJam)
        Me.Controls.Add(Me.LBLTanggal)
        Me.Controls.Add(Me.Admin)
        Me.Controls.Add(Me.Jam)
        Me.Controls.Add(Me.Tanggal)
        Me.Controls.Add(Me.LBLKendaraan)
        Me.Controls.Add(Me.Nama)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Supir)
        Me.Controls.Add(Me.LBLTotal)
        Me.Controls.Add(Me.Total)
        Me.Controls.Add(Me.LBLItem)
        Me.Controls.Add(Me.TotalItem)
        Me.Controls.Add(Me.ButtonInsert)
        Me.Controls.Add(Me.LBLHargaBarang)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.JumlahBarang)
        Me.Controls.Add(Me.HargaBarang)
        Me.Controls.Add(Me.NamaBarang)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LBLTransaksi)
        Me.Controls.Add(Me.NomorJual)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FormTransaksi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Penerimaan"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBLTransaksi As System.Windows.Forms.Label
    Friend WithEvents NomorJual As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents NamaBarang As System.Windows.Forms.Label
    Friend WithEvents HargaBarang As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents JumlahBarang As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents LBLHargaBarang As System.Windows.Forms.Label
    Friend WithEvents ButtonInsert As System.Windows.Forms.Button
    Friend WithEvents LBLTotal As System.Windows.Forms.Label
    Friend WithEvents Total As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Supir As System.Windows.Forms.Label
    Friend WithEvents LBLKendaraan As System.Windows.Forms.Label
    Friend WithEvents Nama As System.Windows.Forms.Label
    Friend WithEvents LBLAdmin As System.Windows.Forms.Label
    Friend WithEvents LBLJam As System.Windows.Forms.Label
    Friend WithEvents LBLTanggal As System.Windows.Forms.Label
    Friend WithEvents Admin As System.Windows.Forms.Label
    Friend WithEvents Jam As System.Windows.Forms.Label
    Friend WithEvents Tanggal As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ButtonBatal As System.Windows.Forms.Button
    Friend WithEvents ButtonPrint As System.Windows.Forms.Button
    Friend WithEvents TotalItem As System.Windows.Forms.Label
    Friend WithEvents LBLItem As System.Windows.Forms.Label
    Friend WithEvents AxCrystalReport1 As AxCrystal.AxCrystalReport
    Friend WithEvents LBLkode As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LBLSatuan As System.Windows.Forms.Label
End Class
