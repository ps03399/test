Imports System.Data.SqlClient

Public Class Cap_Nhat_Va_Xoa_Khach_Hang
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
        Dim lenhsql = "select * from KhachHang"
        Dim adapter1 As New SqlClient.SqlDataAdapter(lenhsql, con)
        Dim dataset1 As New DataSet
        adapter1.Fill(dataset1, "a")
        DataGridView1.DataSource = dataset1
        DataGridView1.DataMember = "a"
    End Sub
    Private Sub Cap_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loaddata()
    End Sub

    Private Sub ButtonCapNhat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCapNhat.Click
        ketnoi()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim ma As String = TextMaKH.Text
        Dim ten As String = TextTenKH.Text
        Dim diachi As String = TextDiaChi.Text
        Dim sdt As String = TextSDT.Text
        Dim email As String = TextEmail.Text
        If ma = "" Then
            MessageBox.Show("Vui Lòng Nhập Mã Khách Hàng muốn Cập Nhật!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim lenhsql = "Update KhachHang SET MaKH= ('" + ma + "'),TenKH =(N'" + ten + "'), DiaChi=(N'" + diachi + "'), SDT=('" + sdt + "'), Email=('" + email + "') Where MaKH=('" + ma + "')"
            Dim cmd As New SqlClient.SqlCommand(lenhsql, con)
            cmd.ExecuteNonQuery()
            con.Close()
        End If
        ketnoi()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        If ma = "" Then
            MessageBox.Show("Vui Lòng Nhập Mã Khách Hàng muốn Cập Nhật!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim lenhsql = "Update KhachHang SET DiaChi= ('" + diachi + "') where SDT =('" + sdt + "')"
            Dim cmd As New SqlClient.SqlCommand(lenhsql, con)
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Cập Nhật Dữ Liệu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        loaddata()

    End Sub
    Private Sub loadtextbox()
        TextMaKH.DataBindings.Clear()
        TextMaKH.DataBindings.Add("Text", DataGridView1.DataSource, "a.MaKH")
        TextTenKH.DataBindings.Clear()
        TextTenKH.DataBindings.Add("Text", DataGridView1.DataSource, "a.TenKH")
        TextDiaChi.DataBindings.Clear()
        TextDiaChi.DataBindings.Add("Text", DataGridView1.DataSource, "a.DiaChi")
        TextSDT.DataBindings.Clear()
        TextSDT.DataBindings.Add("Text", DataGridView1.DataSource, "a.SDT")
        TextEmail.DataBindings.Clear()
        TextEmail.DataBindings.Add("Text", DataGridView1.DataSource, "a.Email")
    End Sub
    Private Sub Cap_Nhat_Va_Xoa_Khach_Hang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loaddata()
        loadtextbox()
    End Sub

    Private Sub ButtonXoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonXoa.Click
        ketnoi()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim ma As String = TextMaKH.Text
        Dim ten As String = TextTenKH.Text
        Dim diachi As String = TextDiaChi.Text
        Dim sdt As String = TextSDT.Text
        Dim email As String = TextEmail.Text
        If ma = "" Then
            MessageBox.Show("Vui Lòng Nhập Mã KH Muốn Xoá!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            Dim lenhsql = "Delete from KhachHang where MaKH =('" + ma + "')"
            Dim cmd As New SqlClient.SqlCommand(lenhsql, con)
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Xoá Dữ Liệu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        loaddata()
    End Sub

    Private Sub ButtonThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonThoat.Click
        Me.Close()

    End Sub
End Class