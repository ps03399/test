Imports System.Data.SqlClient

Public Class TimKiemKhachHang
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
        Dim lenhsql = "select MaKH from KhachHang"
        Dim ad As New SqlClient.SqlDataAdapter(lenhsql, con)
        Dim da As New DataSet
        ad.Fill(da, "MaKH")
        ComboBox1.DataSource = da.Tables("MaKH")
        ComboBox1.DisplayMember = "MaKH"
    End Sub
    Private Sub from_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loaddata()
    End Sub

    Private Sub ButtonTenKH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonTenKH.Click
        ketnoi()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        DataGridView1.ClearSelection()
        Dim TenKH As String = TextBoxTenKH.Text
        If TenKH = "" Then
            MessageBox.Show("Vui Lòng Nhập Tên Khách Hàng!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim lenhsql = "select * from KhachHang where TenKH=(N'" + TenKH + "')"
            Dim adapter1 As New SqlClient.SqlDataAdapter(lenhsql, con)
            Dim dataset1 As New DataSet
            adapter1.Fill(dataset1, "VKL")
            DataGridView1.DataSource = dataset1
            DataGridView1.DataMember = "VKL"
        End If
    End Sub

    Private Sub ButtonMaKH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMaKH.Click
        ketnoi()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        DataGridView1.ClearSelection()
        Dim MaKH As String = ComboBox1.Text
        If MaKH = "" Then
            MessageBox.Show("Vui Lòng Nhập Mã Khách Hàng!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim lenhsql = "select * from KhachHang where MaKH=('" + MaKH + "')"
            Dim adapter1 As New SqlClient.SqlDataAdapter(lenhsql, con)
            Dim dataset1 As New DataSet
            adapter1.Fill(dataset1, "VKL")
            DataGridView1.DataSource = dataset1
            DataGridView1.DataMember = "VKL"
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub
End Class