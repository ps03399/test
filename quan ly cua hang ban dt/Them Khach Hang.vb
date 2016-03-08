Imports System.Data.SqlClient

Public Class Them_Khach_Hang
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
    Private Sub loadtextbox()
        TextBoxMaKH.DataBindings.Clear()
        TextBoxMaKH.DataBindings.Add("Text", DataGridView1.DataSource, "a.MaKH")
        TextBoxTenKH.DataBindings.Clear()
        TextBoxTenKH.DataBindings.Add("Text", DataGridView1.DataSource, "a.TenKH")
        TextBoxSDT.DataBindings.Clear()
        TextBoxSDT.DataBindings.Add("Text", DataGridView1.DataSource, "a.SDT")
        TextBoxDiaChi.DataBindings.Clear()
        TextBoxDiaChi.DataBindings.Add("Text", DataGridView1.DataSource, "a.DiaChi")
        TextBoxEmail.DataBindings.Clear()
        TextBoxEmail.DataBindings.Add("Text", DataGridView1.DataSource, "a.Email")
    End Sub
    Private Sub text_123_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loaddata()
        loadtextbox()
    End Sub
    Private Sub ButtonThem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonThem.Click
        ketnoi()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim MaKH As String = TextBoxMaKH.Text
        Dim SDT As String = TextBoxSDT.Text
        Dim Ten As String = TextBoxTenKH.Text
        Dim DiaChi As String = TextBoxDiaChi.Text
        Dim Email As String = TextBoxEmail.Text
        If MaKH = "" Or SDT = "" Or Ten = "" Or DiaChi = "" Or Email = "" Then
            MessageBox.Show("Vui Lòng Nhập Đầy Đủ Thông Tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim lenhsql = "insert into KhachHang values ('" + MaKH + "',N'" + Ten + "',N'" + DiaChi + "',N'" + SDT + "',N'" + Email + "')"
            Dim cmd As New SqlClient.SqlCommand(lenhsql, con)
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Thêm Dữ Liệu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        loaddata()
    End Sub

    Private Sub ButtonThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonThoat.Click
        Me.Close()

    End Sub
End Class