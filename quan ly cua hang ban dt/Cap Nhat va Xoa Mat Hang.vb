Imports System.Data.SqlClient

Public Class Cap_Nhat_va_Xoa_Mat_Hang
    Private con As SqlConnection
    Private Sub ketnoi()
        Dim cn As String = "workstation id=Assignmentfinal.mssql.somee.com;packet size=4096;user id=lethuan_SQLLogin_1;pwd=2skoycycnf;data source=Assignmentfinal.mssql.somee.com;persist security info=False;initial catalog=Assignmentfinal"
        Try
            con = New SqlConnection(cn)
        Catch ex As Exception
            MessageBox.Show("Kết Nối Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Private Sub loadTable()
        ketnoi()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim lenhsql = "select * from MatHang"
        Dim adapter1 As New SqlClient.SqlDataAdapter(lenhsql, con)
        Dim dataset1 As New DataSet
        adapter1.Fill(dataset1, "a")
        DataGridView1.DataSource = dataset1
        DataGridView1.DataMember = "a"
    End Sub
    Private Sub Loadtable_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadTable()
    End Sub
    Private Sub loadtextbox()
        TextBoxTenMH.DataBindings.Clear()
        TextBoxTenMH.DataBindings.Add("Text", DataGridView1.DataSource, "a.TenMH")
        TextBoxSoLuong.DataBindings.Clear()
        TextBoxSoLuong.DataBindings.Add("Text", DataGridView1.DataSource, "a.SoLuong")
        TextBoxGiaNhap.DataBindings.Clear()
        TextBoxGiaNhap.DataBindings.Add("Text", DataGridView1.DataSource, "a.GiaNhap")
        TextBoxGiaXuat.DataBindings.Clear()
        TextBoxGiaXuat.DataBindings.Add("Text", DataGridView1.DataSource, "a.GiaXuat")
        TextBoxMaNSX.DataBindings.Clear()
        TextBoxMaNSX.DataBindings.Add("Text", DataGridView1.DataSource, "a.MaNSX")
        TextBoxMaMH.DataBindings.Clear()
        TextBoxMaMH.DataBindings.Add("Text", DataGridView1.DataSource, "a.MaMH")
        DateTimePicker1.DataBindings.Clear()
        DateTimePicker1.DataBindings.Add("Text", DataGridView1.DataSource, "a.NgayThang")
        ComboBox1.DataBindings.Clear()
        ComboBox1.DataBindings.Add("Text", DataGridView1.DataSource, "a.DacDiem")
    End Sub
    Private Sub Cap_Nhat_load_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadTable()
        loadtextbox()
    End Sub

    Private Sub ButtonThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonThoat.Click
        Me.Close()

    End Sub

    Private Sub ButtonCapNhat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ketnoi()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim maMH As String = TextBoxMaMH.Text
        Dim TenMH As String = TextBoxTenMH.Text
        Dim MaNSX As String = TextBoxMaNSX.Text
        Dim SoLuong As String = TextBoxSoLuong.Text
        Dim GiaNhap As String = TextBoxGiaNhap.Text
        Dim GiaXuat As String = TextBoxGiaXuat.Text
        Dim DacDiem As String = ComboBox1.Text
        If maMH = "" Then
            MessageBox.Show("Vui Lòng Nhập Mã MH Muốn Cập Nhật!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim lenhsql = "update MatHang set MaMH= ('" + maMH + "'), TenMH= (N'" + TenMH + "'), MaNSX= (N'" + MaNSX + "'), SoLuong = (N'" + SoLuong + "'), GiaNhap = ('" + GiaNhap + "'), GiaXuat = ('" + GiaXuat + "'), DacDiem= ('" + DacDiem + "') where MaMH =('" + maMH + "')"
            Dim cmd As New SqlClient.SqlCommand(lenhsql, con)
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Thêm Dữ Liệu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        loadTable()
    End Sub

    Private Sub ButtonXoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonXoa.Click
        ketnoi()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim maMH As String = TextBoxMaMH.Text
        Dim TenMH As String = TextBoxTenMH.Text
        Dim MaNSX As String = TextBoxMaNSX.Text
        Dim SoLuong As String = TextBoxSoLuong.Text
        Dim GiaNhap As String = TextBoxGiaNhap.Text
        Dim GiaXuat As String = TextBoxGiaXuat.Text
        If maMH = "" Then
            MessageBox.Show("Vui Lòng Nhập Mã MH Muốn Xoá!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim lenhsql = "Delete from MatHang Where MaMH= ('" + maMH + "')"
            Dim cmd As New SqlClient.SqlCommand(lenhsql, con)
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Xoá Dữ Liệu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        loadTable()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class