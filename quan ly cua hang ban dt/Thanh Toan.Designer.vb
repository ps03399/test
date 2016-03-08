<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Thanh_Toan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Thanh_Toan))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonXuất = New System.Windows.Forms.RadioButton()
        Me.RadioButtonNhap = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBoxTongTien = New System.Windows.Forms.TextBox()
        Me.TextBoxGia = New System.Windows.Forms.TextBox()
        Me.TextBoxSoLuong = New System.Windows.Forms.TextBox()
        Me.TextBoxMaDH = New System.Windows.Forms.TextBox()
        Me.TextBoxTenMH = New System.Windows.Forms.TextBox()
        Me.TextBoxTenNSX = New System.Windows.Forms.TextBox()
        Me.TextBoxTenKH = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ButtonThoat = New System.Windows.Forms.Button()
        Me.ButtonThanhToan = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBoxChuaThanhToan = New System.Windows.Forms.TextBox()
        Me.TextBoxDaThanhToan = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButtonXuất)
        Me.GroupBox1.Controls.Add(Me.RadioButtonNhap)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(603, 50)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Đơn Hàng Cần Thanh Toán"
        '
        'RadioButtonXuất
        '
        Me.RadioButtonXuất.AutoSize = True
        Me.RadioButtonXuất.Location = New System.Drawing.Point(389, 29)
        Me.RadioButtonXuất.Name = "RadioButtonXuất"
        Me.RadioButtonXuất.Size = New System.Drawing.Size(99, 17)
        Me.RadioButtonXuất.TabIndex = 1
        Me.RadioButtonXuất.TabStop = True
        Me.RadioButtonXuất.Text = "Đơn Hàng Xuất"
        Me.RadioButtonXuất.UseVisualStyleBackColor = True
        '
        'RadioButtonNhap
        '
        Me.RadioButtonNhap.AutoSize = True
        Me.RadioButtonNhap.Location = New System.Drawing.Point(168, 29)
        Me.RadioButtonNhap.Name = "RadioButtonNhap"
        Me.RadioButtonNhap.Size = New System.Drawing.Size(103, 17)
        Me.RadioButtonNhap.TabIndex = 0
        Me.RadioButtonNhap.TabStop = True
        Me.RadioButtonNhap.Text = "Đơn Hàng Nhập"
        Me.RadioButtonNhap.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBoxTongTien)
        Me.GroupBox2.Controls.Add(Me.TextBoxGia)
        Me.GroupBox2.Controls.Add(Me.TextBoxSoLuong)
        Me.GroupBox2.Controls.Add(Me.TextBoxMaDH)
        Me.GroupBox2.Controls.Add(Me.TextBoxTenMH)
        Me.GroupBox2.Controls.Add(Me.TextBoxTenNSX)
        Me.GroupBox2.Controls.Add(Me.TextBoxTenKH)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 68)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(603, 184)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Chi Tiết Đơn Hàng"
        '
        'TextBoxTongTien
        '
        Me.TextBoxTongTien.Location = New System.Drawing.Point(443, 102)
        Me.TextBoxTongTien.Name = "TextBoxTongTien"
        Me.TextBoxTongTien.Size = New System.Drawing.Size(154, 20)
        Me.TextBoxTongTien.TabIndex = 15
        '
        'TextBoxGia
        '
        Me.TextBoxGia.Location = New System.Drawing.Point(443, 65)
        Me.TextBoxGia.Name = "TextBoxGia"
        Me.TextBoxGia.Size = New System.Drawing.Size(154, 20)
        Me.TextBoxGia.TabIndex = 14
        '
        'TextBoxSoLuong
        '
        Me.TextBoxSoLuong.Location = New System.Drawing.Point(443, 33)
        Me.TextBoxSoLuong.Name = "TextBoxSoLuong"
        Me.TextBoxSoLuong.Size = New System.Drawing.Size(154, 20)
        Me.TextBoxSoLuong.TabIndex = 13
        '
        'TextBoxMaDH
        '
        Me.TextBoxMaDH.Location = New System.Drawing.Point(123, 33)
        Me.TextBoxMaDH.Name = "TextBoxMaDH"
        Me.TextBoxMaDH.Size = New System.Drawing.Size(175, 20)
        Me.TextBoxMaDH.TabIndex = 11
        '
        'TextBoxTenMH
        '
        Me.TextBoxTenMH.Location = New System.Drawing.Point(123, 65)
        Me.TextBoxTenMH.Name = "TextBoxTenMH"
        Me.TextBoxTenMH.Size = New System.Drawing.Size(175, 20)
        Me.TextBoxTenMH.TabIndex = 10
        '
        'TextBoxTenNSX
        '
        Me.TextBoxTenNSX.Location = New System.Drawing.Point(123, 102)
        Me.TextBoxTenNSX.Name = "TextBoxTenNSX"
        Me.TextBoxTenNSX.Size = New System.Drawing.Size(175, 20)
        Me.TextBoxTenNSX.TabIndex = 9
        '
        'TextBoxTenKH
        '
        Me.TextBoxTenKH.Location = New System.Drawing.Point(332, 148)
        Me.TextBoxTenKH.Name = "TextBoxTenKH"
        Me.TextBoxTenKH.Size = New System.Drawing.Size(175, 20)
        Me.TextBoxTenKH.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(340, 105)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Tổng Tiền:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(218, 151)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Tên Khách Hàng:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(340, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Giá ( Nhập-Xuất ):"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Tên NSX:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(340, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Số Lượng:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tên Mặt Hàng:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Đơn Hàng:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ButtonThoat)
        Me.GroupBox3.Controls.Add(Me.ButtonThanhToan)
        Me.GroupBox3.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.TextBoxChuaThanhToan)
        Me.GroupBox3.Controls.Add(Me.TextBoxDaThanhToan)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 258)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(603, 100)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Chi Tiết Thanh Toán"
        '
        'ButtonThoat
        '
        Me.ButtonThoat.Location = New System.Drawing.Point(467, 68)
        Me.ButtonThoat.Name = "ButtonThoat"
        Me.ButtonThoat.Size = New System.Drawing.Size(75, 23)
        Me.ButtonThoat.TabIndex = 8
        Me.ButtonThoat.Text = "Thoát"
        Me.ButtonThoat.UseVisualStyleBackColor = True
        '
        'ButtonThanhToan
        '
        Me.ButtonThanhToan.Location = New System.Drawing.Point(357, 68)
        Me.ButtonThanhToan.Name = "ButtonThanhToan"
        Me.ButtonThanhToan.Size = New System.Drawing.Size(75, 23)
        Me.ButtonThanhToan.TabIndex = 6
        Me.ButtonThanhToan.Text = "Thanh Toán"
        Me.ButtonThanhToan.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(123, 67)
        Me.DateTimePicker1.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(175, 20)
        Me.DateTimePicker1.TabIndex = 5
        Me.DateTimePicker1.Value = New Date(1991, 1, 1, 0, 0, 0, 0)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(25, 73)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(92, 13)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Hạn Thanh Toán;"
        '
        'TextBoxChuaThanhToan
        '
        Me.TextBoxChuaThanhToan.Location = New System.Drawing.Point(467, 32)
        Me.TextBoxChuaThanhToan.Name = "TextBoxChuaThanhToan"
        Me.TextBoxChuaThanhToan.Size = New System.Drawing.Size(130, 20)
        Me.TextBoxChuaThanhToan.TabIndex = 3
        '
        'TextBoxDaThanhToan
        '
        Me.TextBoxDaThanhToan.Location = New System.Drawing.Point(123, 32)
        Me.TextBoxDaThanhToan.Name = "TextBoxDaThanhToan"
        Me.TextBoxDaThanhToan.Size = New System.Drawing.Size(175, 20)
        Me.TextBoxDaThanhToan.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(340, 35)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(121, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Tiền Chưa Thanh Toán:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(25, 35)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Đã Thanh Toán:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DataGridView1)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 364)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(603, 139)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Danh Sách Đơn Hàng Thanh Toán"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(591, 114)
        Me.DataGridView1.TabIndex = 0
        '
        'Thanh_Toan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(629, 515)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Thanh_Toan"
        Me.Text = "Thanh Toán"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButtonXuất As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonNhap As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxTongTien As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxGia As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxSoLuong As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxMaDH As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxTenMH As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxTenNSX As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxTenKH As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxChuaThanhToan As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxDaThanhToan As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ButtonThoat As System.Windows.Forms.Button
    Friend WithEvents ButtonThanhToan As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
