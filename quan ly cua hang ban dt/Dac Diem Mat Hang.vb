Imports System.Data.SqlClient

Public Class Dac_Diem_Mat_Hang
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
        Dim lenhsql = "select * from DacDiem"
        Dim adapter1 As New SqlClient.SqlDataAdapter(lenhsql, con)
        Dim dataset1 As New DataSet
        adapter1.Fill(dataset1, "a")
        DataGridView1.DataSource = dataset1
        DataGridView1.DataMember = "a"
    End Sub
    Private Sub Dac_Diem_Mat_Hang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loaddata()

    End Sub
    Private Sub loadtextbox()
        TextBoxMaDD.DataBindings.Clear()
        TextBoxMaDD.DataBindings.Add("Text", DataGridView1.DataSource, "a.MaDacDiem")
        TextBoxTenDD.DataBindings.Clear()
        TextBoxTenDD.DataBindings.Add("Text", DataGridView1.DataSource, "a.TenDacDiem")
        RichTextBox1.DataBindings.Clear()
        RichTextBox1.DataBindings.Add("Text", DataGridView1.DataSource, "a.MoTa")
    End Sub
    Private Sub loadtext123_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loaddata()
        loadtextbox()

    End Sub

    Private Sub ButtonThem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonThem.Click
        ketnoi()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim MaDacDiem As String = TextBoxMaDD.Text
        Dim TenDacDiem As String = TextBoxTenDD.Text
        Dim MoTa As String = RichTextBox1.Text
        If MaDacDiem = "" Or TenDacDiem = "" Or MoTa = "" Then
            MessageBox.Show("Vui Lòng Nhập đầy đủ thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim lenhsql = "insert into DacDiem values ('" + MaDacDiem + "',N'" + TenDacDiem + "',N'" + MoTa + "')"
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
        Dim MaDacDiem As String = TextBoxMaDD.Text
        Dim TenDacDiem As String = TextBoxTenDD.Text
        Dim MoTa As String = RichTextBox1.Text
        If MaDacDiem = "" Or TenDacDiem = "" Or MoTa = "" Then
            MessageBox.Show("Vui Lòng Nhập đầy đủ thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim lenhsql = "Update DacDiem Set MaDacDiem= ('" + MaDacDiem + "'), TenDacDiem= (N'" + TenDacDiem + "'), MoTa= (N'" + MoTa + "') where MaDacDiem =('" + MaDacDiem + "')"
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
        Dim MaDacDiem As String = TextBoxMaDD.Text
        Dim TenDacDiem As String = TextBoxTenDD.Text
        Dim MoTa As String = RichTextBox1.Text
        If MaDacDiem = "" Then
            MessageBox.Show("Vui Lòng Nhập Mã Đặc Điểm Muốn Xoá!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim lenhsql = "Delete from DacDiem Where MaDacDiem= ('" + MaDacDiem + "')"
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