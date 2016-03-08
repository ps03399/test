Imports System.Data.SqlClient

Public Class TimKiemMatHang
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
        Dim lenhsql = "select TenNSX from NhaSanXuat"
        Dim ad As New SqlClient.SqlDataAdapter(lenhsql, con)
        Dim da As New DataSet
        ad.Fill(da, "TenNSX")
        ComboBox1.DataSource = da.Tables("TenNSX")
        ComboBox1.DisplayMember = "TenNSX"
    End Sub
    Private Sub loaddata1()
        ketnoi()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim lenhsql = "select TenMH from MatHang"
        Dim ad As New SqlClient.SqlDataAdapter(lenhsql, con)
        Dim da As New DataSet
        ad.Fill(da, "TenMH")
        ComboBox2.DataSource = da.Tables("TenMH")
        ComboBox2.DisplayMember = "TenMH"
    End Sub
    Private Sub from_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loaddata()
        loaddata1()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ketnoi()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        DataGridView1.ClearSelection()
        Dim TenMH As String = ComboBox2.Text
        If TenMH = "" Then
            MessageBox.Show("Vui Lòng Nhập Tên Mặt Hàng!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim lenhsql = "select * from MatHang where TenMH=('" + TenMH + "')"
            Dim adapter1 As New SqlClient.SqlDataAdapter(lenhsql, con)
            Dim dataset1 As New DataSet
            adapter1.Fill(dataset1, "VKL")
            DataGridView1.DataSource = dataset1
            DataGridView1.DataMember = "VKL"
        End If
    End Sub

    Private Sub ButtonNSX_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonNSX.Click
        ketnoi()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        DataGridView1.ClearSelection()
        Dim TenNSX As String = ComboBox1.Text
        If TenNSX = "" Then
            MessageBox.Show("Vui Lòng Nhập Tên Nhà Sản Xuất!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim lenhsql = "select * from NhaSanXuat where TenNSX=('" + TenNSX + "')"
            Dim adapter1 As New SqlClient.SqlDataAdapter(lenhsql, con)
            Dim dataset1 As New DataSet
            adapter1.Fill(dataset1, "VKL")
            DataGridView1.DataSource = dataset1
            DataGridView1.DataMember = "VKL"
        End If
    End Sub

    Private Sub ButtonGia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonGia.Click
        ketnoi()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        DataGridView1.ClearSelection()

        Dim GiaXuat As String = ComboBox3.Text
        If GiaXuat = "" Then
            MessageBox.Show("Vui Lòng Chọn Giá Tiền!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If ComboBox3.Text = "0 - 5 triệu" Then
                Dim lenhsql = "select * from MatHang where GiaXuat>=0 AND GiaXuat <5000000"
                Dim adapter1 As New SqlClient.SqlDataAdapter(lenhsql, con)
                Dim dataset1 As New DataSet
                adapter1.Fill(dataset1, "VKL")
                DataGridView1.DataSource = dataset1
                DataGridView1.DataMember = "VKL"
            ElseIf ComboBox3.Text = "5 triệu - 10 triệu" Then
                Dim lenhsql = "select * from MatHang where GiaXuat>=5000000 AND GiaXuat <10000000"
                Dim adapter1 As New SqlClient.SqlDataAdapter(lenhsql, con)
                Dim dataset1 As New DataSet
                adapter1.Fill(dataset1, "VKL")
                DataGridView1.DataSource = dataset1
                DataGridView1.DataMember = "VKL"
            ElseIf ComboBox3.Text = "10 triệu trở lên" Then
                Dim lenhsql = "select * from MatHang where GiaXuat>=10000000"
                Dim adapter1 As New SqlClient.SqlDataAdapter(lenhsql, con)
                Dim dataset1 As New DataSet
                adapter1.Fill(dataset1, "VKL")
                DataGridView1.DataSource = dataset1
                DataGridView1.DataMember = "VKL"
            End If
        End If
    End Sub

    Private Sub ButtonThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonThoat.Click
        Me.Close()

    End Sub
End Class