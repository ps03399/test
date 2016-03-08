Imports System.Data.SqlClient

Public Class Them_Moi_Mat_Hang
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
        Dim lenhsql = "select * from MatHang"
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
        TextGiaNhap.DataBindings.Clear()
        TextGiaNhap.DataBindings.Add("Text", DataGridView1.DataSource, "a.GiaNhap")
        TextGiaXuat.DataBindings.Clear()
        TextGiaXuat.DataBindings.Add("Text", DataGridView1.DataSource, "a.GiaXuat")
        TextMaMH.DataBindings.Clear()
        TextMaMH.DataBindings.Add("Text", DataGridView1.DataSource, "a.MaMH")
        TextMaNSX.DataBindings.Clear()
        TextMaNSX.DataBindings.Add("Text", DataGridView1.DataSource, "a.MaNSX")
        TextMoTaDacDiem.DataBindings.Clear()
        TextMoTaDacDiem.DataBindings.Add("Text", DataGridView1.DataSource, "a.DacDiem")
        TextSoLuong.DataBindings.Clear()
        TextSoLuong.DataBindings.Add("Text", DataGridView1.DataSource, "a.SoLuong")
        TextTenMH.DataBindings.Clear()
        TextTenMH.DataBindings.Add("Text", DataGridView1.DataSource, "a.TenMH")
        DateTimePicker1.DataBindings.Clear()
        DateTimePicker1.DataBindings.Add("Text", DataGridView1.DataSource, "a.NgayThang")
    End Sub
    Private Sub Cap_Nhat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loaddata()
        loadtextbox()
    End Sub
    Private Sub ButtonThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonThoat.Click
        Me.Close()

    End Sub

    Private Sub ButtonThemMoi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonThemMoi.Click
        ketnoi()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim MaMH As String = TextMaMH.Text
        Dim TenMH As String = TextTenMH.Text
        Dim MaNSX As String = TextMaNSX.Text
        Dim DacDiem As String = TextMoTaDacDiem.Text
        Dim SoLuong As String = TextSoLuong.Text
        Dim GiaNhap As String = TextGiaNhap.Text
        Dim GiaXuat As String = TextGiaXuat.Text
        Dim NgayThang As String = ""
        If MaMH = "" Or TenMH = "" Or DacDiem = "" Or SoLuong = "" Or GiaNhap = "" Or GiaXuat = "" Then
            MessageBox.Show("Vui Lòng Nhập đầy đủ thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim lenhsql = "insert into MatHang values ('" + MaMH + "',N'" + TenMH + "',N'" + MaNSX + "',N'" + DacDiem + "',N'" + SoLuong + "',N'" + GiaNhap + "',N'" + GiaXuat + "','" + NgayThang + "')"
            Dim cmd As New SqlClient.SqlCommand(lenhsql, con)
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Thêm Dữ Liệu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        loaddata()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub
End Class