Imports System.Data.SqlClient

Public Class Thanh_Toan
    Private con As SqlConnection
    Private Sub ketnoi()
        Dim cn As String = "workstation id=Assignmentfinal.mssql.somee.com;packet size=4096;user id=lethuan_SQLLogin_1;pwd=2skoycycnf;data source=Assignmentfinal.mssql.somee.com;persist security info=False;initial catalog=Assignmentfinal"
        Try
            con = New SqlConnection(cn)
        Catch ex As Exception
            MessageBox.Show("Kết Nối Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Private Sub HoaDonBan()
        TextBoxMaDH.DataBindings.Clear()
        TextBoxMaDH.DataBindings.Add("Text", DataGridView1.DataSource, "a.MaDH")
        TextBoxTenMH.DataBindings.Clear()
        TextBoxTenMH.DataBindings.Add("Text", DataGridView1.DataSource, "a.TenMH")
        TextBoxTenKH.DataBindings.Clear()
        TextBoxTenKH.DataBindings.Add("Text", DataGridView1.DataSource, "a.TenKH")
        TextBoxSoLuong.DataBindings.Clear()
        TextBoxSoLuong.DataBindings.Add("Text", DataGridView1.DataSource, "a.SoLuong")
        TextBoxGia.DataBindings.Clear()
        TextBoxGia.DataBindings.Add("Text", DataGridView1.DataSource, "a.GiaBan")
        TextBoxTongTien.DataBindings.Clear()
        TextBoxTongTien.DataBindings.Add("Text", DataGridView1.DataSource, "a.TongTien")
        TextBoxDaThanhToan.DataBindings.Clear()
        TextBoxDaThanhToan.DataBindings.Add("Text", DataGridView1.DataSource, "a.TienDaTT")
        TextBoxChuaThanhToan.DataBindings.Clear()
        TextBoxChuaThanhToan.DataBindings.Add("Text", DataGridView1.DataSource, "a.TienNo")
        DateTimePicker1.DataBindings.Clear()
        DateTimePicker1.DataBindings.Add("Text", DataGridView1.DataSource, "a.HanTT")
    End Sub
    Private Sub HoaDonNhap()
        TextBoxMaDH.DataBindings.Clear()
        TextBoxMaDH.DataBindings.Add("Text", DataGridView1.DataSource, "a.MaDH")
        TextBoxTenMH.DataBindings.Clear()
        TextBoxTenMH.DataBindings.Add("Text", DataGridView1.DataSource, "a.TenMH")
        TextBoxSoLuong.DataBindings.Clear()
        TextBoxSoLuong.DataBindings.Add("Text", DataGridView1.DataSource, "a.SoLuong")
        TextBoxGia.DataBindings.Clear()
        TextBoxGia.DataBindings.Add("Text", DataGridView1.DataSource, "a.GiaNhap")
        TextBoxTongTien.DataBindings.Clear()
        TextBoxTongTien.DataBindings.Add("Text", DataGridView1.DataSource, "a.TongTien")
        TextBoxDaThanhToan.DataBindings.Clear()
        TextBoxDaThanhToan.DataBindings.Add("Text", DataGridView1.DataSource, "a.TienDaTT")
        TextBoxChuaThanhToan.DataBindings.Clear()
        TextBoxChuaThanhToan.DataBindings.Add("Text", DataGridView1.DataSource, "a.TienNo")
        DateTimePicker1.DataBindings.Clear()
        DateTimePicker1.DataBindings.Add("Text", DataGridView1.DataSource, "a.HanTT")
        TextBoxTenKH.Text = ""

    End Sub
    Private Sub RadioButtonNhap_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonNhap.CheckedChanged
        ketnoi()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim lenhsql = "select * from HoaDonNhap"
        Dim adapter1 As New SqlClient.SqlDataAdapter(lenhsql, con)
        Dim dataset1 As New DataSet
        adapter1.Fill(dataset1, "a")
        DataGridView1.DataSource = dataset1
        DataGridView1.DataMember = "a"
        HoaDonNhap()

    End Sub

    Private Sub RadioButtonXuất_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonXuất.CheckedChanged
        ketnoi()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim lenhsql = "select * from HoaDonBan"
        Dim adapter1 As New SqlClient.SqlDataAdapter(lenhsql, con)
        Dim dataset1 As New DataSet
        adapter1.Fill(dataset1, "a")
        DataGridView1.DataSource = dataset1
        DataGridView1.DataMember = "a"
        HoaDonBan()

    End Sub

    Private Sub ButtonThanhToan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonThanhToan.Click
        ketnoi()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim MaDH As String = TextBoxMaDH.Text
        Dim DaThanhToan As String = TextBoxTongTien.Text
        TextBoxChuaThanhToan.Text = "0"
        Dim ChuaThanhToan As String = TextBoxChuaThanhToan.Text
        If RadioButtonNhap.Checked Then
            Dim lenhsql1 = "Update HoaDonNhap SET TienDaTT= ('" + DaThanhToan + "'), TienNo=('" + ChuaThanhToan + "') where MaDH = ('" + MaDH + "')"
            Dim cmd1 As New SqlClient.SqlCommand(lenhsql1, con)
            cmd1.ExecuteNonQuery()
            con.Close()
            HoaDonNhap()

        Else
            Dim lenhsql = "Update HoaDonBan SET TienDaTT= ('" + DaThanhToan + "'), TienNo=('" + ChuaThanhToan + "') where MaDH = ('" + MaDH + "')"
            Dim cmd As New SqlClient.SqlCommand(lenhsql, con)
            cmd.ExecuteNonQuery()
            con.Close()
            HoaDonBan()
        End If
    End Sub

    Private Sub ButtonThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonThoat.Click
        Me.Close()

    End Sub
End Class