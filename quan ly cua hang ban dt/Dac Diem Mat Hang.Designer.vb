<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dac_Diem_Mat_Hang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dac_Diem_Mat_Hang))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBoxMaDD = New System.Windows.Forms.TextBox()
        Me.ButtonThoat = New System.Windows.Forms.Button()
        Me.ButtonXoa = New System.Windows.Forms.Button()
        Me.ButtonCapNhat = New System.Windows.Forms.Button()
        Me.ButtonThem = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxTenDD = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBoxMaDD)
        Me.GroupBox1.Controls.Add(Me.ButtonThoat)
        Me.GroupBox1.Controls.Add(Me.ButtonXoa)
        Me.GroupBox1.Controls.Add(Me.ButtonCapNhat)
        Me.GroupBox1.Controls.Add(Me.ButtonThem)
        Me.GroupBox1.Controls.Add(Me.RichTextBox1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBoxTenDD)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(684, 140)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông Tin Đặc Điểm Mặt Hàng"
        '
        'TextBoxMaDD
        '
        Me.TextBoxMaDD.Location = New System.Drawing.Point(127, 29)
        Me.TextBoxMaDD.Name = "TextBoxMaDD"
        Me.TextBoxMaDD.Size = New System.Drawing.Size(117, 20)
        Me.TextBoxMaDD.TabIndex = 15
        '
        'ButtonThoat
        '
        Me.ButtonThoat.Location = New System.Drawing.Point(524, 101)
        Me.ButtonThoat.Name = "ButtonThoat"
        Me.ButtonThoat.Size = New System.Drawing.Size(75, 23)
        Me.ButtonThoat.TabIndex = 14
        Me.ButtonThoat.Text = "Thoát"
        Me.ButtonThoat.UseVisualStyleBackColor = True
        '
        'ButtonXoa
        '
        Me.ButtonXoa.Location = New System.Drawing.Point(385, 101)
        Me.ButtonXoa.Name = "ButtonXoa"
        Me.ButtonXoa.Size = New System.Drawing.Size(75, 23)
        Me.ButtonXoa.TabIndex = 13
        Me.ButtonXoa.Text = "Xoá"
        Me.ButtonXoa.UseVisualStyleBackColor = True
        '
        'ButtonCapNhat
        '
        Me.ButtonCapNhat.Location = New System.Drawing.Point(253, 101)
        Me.ButtonCapNhat.Name = "ButtonCapNhat"
        Me.ButtonCapNhat.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCapNhat.TabIndex = 12
        Me.ButtonCapNhat.Text = "Cập Nhật"
        Me.ButtonCapNhat.UseVisualStyleBackColor = True
        '
        'ButtonThem
        '
        Me.ButtonThem.Location = New System.Drawing.Point(127, 101)
        Me.ButtonThem.Name = "ButtonThem"
        Me.ButtonThem.Size = New System.Drawing.Size(75, 23)
        Me.ButtonThem.TabIndex = 11
        Me.ButtonThem.Text = "Thêm Mới"
        Me.ButtonThem.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(353, 26)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(311, 57)
        Me.RichTextBox1.TabIndex = 5
        Me.RichTextBox1.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(302, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Mô Tả:"
        '
        'TextBoxTenDD
        '
        Me.TextBoxTenDD.Location = New System.Drawing.Point(127, 63)
        Me.TextBoxTenDD.Name = "TextBoxTenDD"
        Me.TextBoxTenDD.Size = New System.Drawing.Size(117, 20)
        Me.TextBoxTenDD.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tên Đặc Điểm"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Mã Đặc Điểm"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 172)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(684, 176)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Danh Sách Các Đặc Điểm"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(25, 30)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(630, 137)
        Me.DataGridView1.TabIndex = 0
        '
        'Dac_Diem_Mat_Hang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 353)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Dac_Diem_Mat_Hang"
        Me.Text = "Đặc Điểm Mặt Hàng"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBoxTenDD As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ButtonThoat As System.Windows.Forms.Button
    Friend WithEvents ButtonXoa As System.Windows.Forms.Button
    Friend WithEvents ButtonCapNhat As System.Windows.Forms.Button
    Friend WithEvents ButtonThem As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TextBoxMaDD As System.Windows.Forms.TextBox
End Class
