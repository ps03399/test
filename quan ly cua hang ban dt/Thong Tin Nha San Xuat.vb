Imports System.Data.SqlClient

Public Class Thong_Tin_Nha_San_Xuat
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
        Dim lenhsql = "select * from NhaSanXuat"
        Dim adapter1 As New SqlClient.SqlDataAdapter(lenhsql, con)
        Dim dataset1 As New DataSet
        adapter1.Fill(dataset1, "a")
        DataGridView1.DataSource = dataset1
        DataGridView1.DataMember = "a"
    End Sub
    Private Sub Cap_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loaddata()
    End Sub
    Private Sub loadtextbox()
        TextTenNSX.DataBindings.Clear()
        TextTenNSX.DataBindings.Add("Text", DataGridView1.DataSource, "a.TenNSX")
        TextMaNSX.DataBindings.Clear()
        TextMaNSX.DataBindings.Add("Text", DataGridView1.DataSource, "a.MaNSX")
        TextQuocGia.DataBindings.Clear()
        TextQuocGia.DataBindings.Add("Text", DataGridView1.DataSource, "a.QuocGia")
        TextSDT.DataBindings.Clear()
        TextSDT.DataBindings.Add("Text", DataGridView1.DataSource, "a.SDT")
        TextEmail.DataBindings.Clear()
        TextEmail.DataBindings.Add("Text", DataGridView1.DataSource, "a.Email")
    End Sub
    Private Sub Cap_Nhat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loaddata()
        loadtextbox()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        ketnoi()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim MaNSX As String = TextMaNSX.Text
        Dim TenNSX As String = TextTenNSX.Text
        Dim QuocGia As String = TextQuocGia.Text
        Dim SDT As String = TextSDT.Text
        Dim Email As String = TextEmail.Text
        If MaNSX = "" Or TenNSX = "" Or QuocGia = "" Or SDT = "" Or Email = "" Then
            MessageBox.Show("Vui Lòng Nhập đầy đủ thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim lenhsql = "insert into NhaSanXuat values ('" + MaNSX + "',N'" + TenNSX + "',N'" + QuocGia + "',N'" + SDT + "',N'" + Email + "')"
            Dim cmd As New SqlClient.SqlCommand(lenhsql, con)
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Thêm Dữ Liệu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        loaddata()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        ketnoi()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim MaNSX As String = TextMaNSX.Text
        Dim TenNSX As String = TextTenNSX.Text
        Dim QuocGia As String = TextQuocGia.Text
        Dim SDT As String = TextSDT.Text
        Dim Email As String = TextEmail.Text
        If MaNSX = "" Then
            MessageBox.Show("Vui Lòng Nhập Mã NSX muốn Cập Nhật!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            Dim lenhsql = "Update NhaSanXuat SET MaNSX= ('" + MaNSX + "') where TenNSX =('" + TenNSX + "')"
            Dim cmd As New SqlClient.SqlCommand(lenhsql, con)
            cmd.ExecuteNonQuery()
            con.Close()
        End If
        ketnoi()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        If MaNSX = "" Then
            MessageBox.Show("Vui Lòng Nhập Mã NSX muốn Cập Nhật!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim lenhsql1 = "Update NhaSanXuat SET QuocGia= ('" + QuocGia + "') where SDT =('" + SDT + "')"
            Dim cmd As New SqlClient.SqlCommand(lenhsql1, con)
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Cập Nhật Dữ Liệu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        loaddata()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        ketnoi()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim MaNSX As String = TextMaNSX.Text
        Dim TenNSX As String = TextTenNSX.Text
        Dim QuocGia As String = TextQuocGia.Text
        Dim SDT As String = TextSDT.Text
        Dim Email As String = TextEmail.Text
        If MaNSX = "" Then
            MessageBox.Show("Vui Lòng Nhập Mã NSX muốn Xoá!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            Dim lenhsql = "delete from NhaSanXuat where MaNSX= ('" + MaNSX + "')"
            Dim cmd As New SqlClient.SqlCommand(lenhsql, con)
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Xoá Dữ Liệu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        loaddata()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Me.Close()

    End Sub
End Class