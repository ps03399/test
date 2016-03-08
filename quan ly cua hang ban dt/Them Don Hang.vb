Imports System.Data.SqlClient

Public Class Them_Don_Hang
    Private con As SqlConnection
    Private Sub ketnoi()
        Dim cn As String = "workstation id=Assignmentfinal.mssql.somee.com;packet size=4096;user id=lethuan_SQLLogin_1;pwd=2skoycycnf;data source=Assignmentfinal.mssql.somee.com;persist security info=False;initial catalog=Assignmentfinal"
        Try
            con = New SqlConnection(cn)
        Catch ex As Exception
            MessageBox.Show("Kết Nối Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Private Sub loaddata()
        ketnoi()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim lenhsql = "select * from DonHang"
        Dim adapter1 As New SqlClient.SqlDataAdapter(lenhsql, con)
        Dim dataset1 As New DataSet
        adapter1.Fill(dataset1, "a")
        DataGridView1.DataSource = dataset1
        DataGridView1.DataMember = "a"
    End Sub
    Private Sub Cap_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loaddata()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
    Private Sub loadtextbox()
        TextBoxMaKH.DataBindings.Clear()
        TextBoxMaKH.DataBindings.Add("Text", DataGridView1.DataSource, "a.MaKH")
        TextBoxGia.DataBindings.Clear()
        TextBoxGia.DataBindings.Add("Text", DataGridView1.DataSource, "a.Gia")
        TextBoxMaDH.DataBindings.Clear()
        TextBoxMaDH.DataBindings.Add("Text", DataGridView1.DataSource, "a.MaDH")
        TextBoxMaLoaiDH.DataBindings.Clear()
        TextBoxMaLoaiDH.DataBindings.Add("Text", DataGridView1.DataSource, "a.MaLoaiDH")
        TextBoxMaMH.DataBindings.Clear()
        TextBoxMaMH.DataBindings.Add("Text", DataGridView1.DataSource, "a.MaMH")
        TextBoxNguoiLap.DataBindings.Clear()
        TextBoxNguoiLap.DataBindings.Add("Text", DataGridView1.DataSource, "a.NguoiLap")
        TextBoxSoLuong.DataBindings.Clear()
        TextBoxSoLuong.DataBindings.Add("Text", DataGridView1.DataSource, "a.SoLuong")
        ComboBoxMaNSX.DataBindings.Clear()
        ComboBoxMaNSX.DataBindings.Add("Text", DataGridView1.DataSource, "a.MaNSX")
    End Sub
    Private Sub load_hien_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loaddata()
        loadtextbox()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ketnoi()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim MaMH As String = TextBoxMaMH.Text
        Dim MaKH As String = TextBoxMaKH.Text
        Dim MaNSX As String = ComboBoxMaNSX.Text
        Dim SoLuong As String = TextBoxSoLuong.Text
        Dim Gia As String = TextBoxGia.Text
        Dim MaDH As String = TextBoxMaDH.Text
        Dim NguoiLap As String = TextBoxNguoiLap.Text
        Dim MaLoaiDH As String = TextBoxMaLoaiDH.Text
        Dim NgayLap As String = ""
        If MaMH = "" Or MaKH = "" Or MaNSX = "" Or Gia = "" Or MaDH = "" Then
            MessageBox.Show("Vui Lòng Nhập Đầy Đủ Thông Tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim lenhsql = "insert into DonHang values ('" + MaDH + "',N'" + MaLoaiDH + "',N'" + MaNSX + "',N'" + MaKH + "',N'" + MaMH + "',N'" + NguoiLap + "',N'" + SoLuong + "',N'" + Gia + "',N'" + NgayLap + "')"
            Dim cmd As New SqlClient.SqlCommand(lenhsql, con)
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Thêm Dữ Liệu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        loaddata()
    End Sub

    Private Sub ButtonCapNhat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCapNhat.Click
        ketnoi()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim MaMH As String = TextBoxMaMH.Text
        Dim MaKH As String = TextBoxMaKH.Text
        Dim MaNSX As String = ComboBoxMaNSX.Text
        Dim SoLuong As String = TextBoxSoLuong.Text
        Dim Gia As String = TextBoxGia.Text
        Dim MaDH As String = TextBoxMaDH.Text
        Dim NguoiLap As String = TextBoxNguoiLap.Text
        Dim MaLoaiDH As String = TextBoxMaLoaiDH.Text
        Dim NgayLap As String = ""
        If MaDH = "" Then
            MessageBox.Show("Vui Lòng Nhập Mã Đơn Hàng Cần Cập Nhật!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim lenhsql = "Update DonHang Set MaDH = ('" + MaDH + "'), MaLoaiDH= (N'" + MaLoaiDH + "'),MaNSX= (N'" + MaNSX + "'), MaKH= (N'" + MaKH + "'), MaMH= (N'" + MaMH + "'), NguoiLap= (N'" + NguoiLap + "'), SoLuong= (N'" + SoLuong + "'), Gia= (N'" + Gia + "'), NgayLap= (N'" + NgayLap + "') Where MaDH =('" + MaDH + "')"
            Dim cmd As New SqlClient.SqlCommand(lenhsql, con)
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Cập Nhật Dữ Liệu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        loaddata()
    End Sub

    Private Sub ButtonXoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonXoa.Click
        ketnoi()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim MaDH As String = TextBoxMaMH.Text
        If MaDH = "" Then
            MessageBox.Show("Vui Lòng Nhập Mã Mặt Hàng Muốn Xoá!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim lenhsql = "Delete from DonHang where MaMH= ('" + MaDH + "') "
            Dim cmd As New SqlClient.SqlCommand(lenhsql, con)
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Xoá Dữ Liệu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        loaddata()
    End Sub
End Class