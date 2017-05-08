Imports MySql.Data.MySqlClient
Public Class frmbayar
    Dim second As Integer = 1
    Dim detik As Integer = 1
    Dim objConnection2 As New MySqlConnection("Server='" & ip & "';port=3306;user id='root';password='';database='harga'")

    Sub gantitulisan()
        lblpesan.ForeColor = Color.Blue
        lblpesan.Text = "Terima kasih telah bertransaksi dengan kami !!"
        lblproses.Visible = False
        Timer3.Start()
        Timer2.Stop()
        lblpesan.Visible = True
        PictureBox1.BackgroundImage = DDCounter.My.Resources.Resources.notification_done
    End Sub

    Sub cek()
        Call atur()
        objConnection2.Close()
        objConnection2.Open()
        Dim strsql As String = "select ket from akses"
        Dim cmd As New MySqlCommand(strsql, objConnection2)
        objDataReader = cmd.ExecuteReader
        objDataReader.Read()
        If objDataReader("ket").ToString = "beres" Then
            objConnection2.Close()
            objConnection2.Open()
            objCommand = New MySqlCommand
            objCommand.Connection = objConnection2
            objCommand.CommandType = CommandType.Text
            objCommand.CommandText = "update akses set ket='siap'"
            objCommand.CommandTimeout = 0
            objCommand.ExecuteNonQuery()
            Call gantitulisan()
        ElseIf objDataReader("ket").ToString = "benar" Then
            objConnection2.Close()
            objConnection2.Open()
            objCommand = New MySqlCommand
            objCommand.Connection = objConnection2
            objCommand.CommandType = CommandType.Text
            objCommand.CommandText = "update akses set ket='siap'"
            objCommand.CommandTimeout = 0
            objCommand.ExecuteNonQuery()
            Call gantitulisan()
            frmdepo.Close()
        ElseIf objDataReader("ket").ToString = "batal" Then
            'frmgagal.lblpesan.Text = "Transaksi telah dibatalkan !"
            'frmgagal.ShowDialog()
            lblpesan.Text = "Transaksi telah dibatalkan !!"
            lblproses.Visible = False
            Timer3.Start()
            Timer2.Stop()
            lblpesan.Visible = True
            PictureBox1.BackgroundImage = DDCounter.My.Resources.Resources.notification_error
        End If
    End Sub

    Private Sub frmbayar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim total As Integer
        PictureBox1.BackgroundImage = DDCounter.My.Resources.Resources.notification_warning
        Timer1.Start()
        Timer2.Start()
        'untuk transaksi beli pulsa
        If transaksi = "pulsa" Then
            objConnection2.Close()
            objConnection2.Open()
            Dim strsql2 As String = "select tampung.id_trx as ID, operator.nama as Operator, harga.denom as Nominal, tampung.no_tujuan as Nomor" _
                                    & ", tampung.harga as Harga from tampung, harga, operator where tampung.kode_produk = harga.kode_produk " _
                                    & "and harga.id_operator=operator.id_operator"
            Dim cmd As New MySqlCommand(strsql2, objConnection2)
            Dim da2 As MySqlDataAdapter = New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da2.Fill(dt)
            DataGridView1.DataSource = dt
            objConnection2.Close()

            For Each dgvRow As DataGridViewRow In DataGridView1.Rows
                If Not dgvRow.IsNewRow Then
                    total += CInt(dgvRow.Cells(4).Value)
                End If
            Next
            lbltotal.Text = total
            lblpesan.ForeColor = Color.Red
            lblpesan.Text = "Silahkan bayar Rp " & lbltotal.Text & ",- ke kasir !"
            lblproses.Visible = True

            GroupBox1.Text = "Informasi Pembelian Pulsa"
            lblinformasi.Text = "Daftar pulsa yang dibeli"
            lblproses.Text = "Proses pengisian pulsa akan dilakukan setelah anda membayar sejumlah uang ........"

        Else
            'untuk deposit
            objConnection2.Close()
            objConnection2.Open()
            Dim strsql2 As String = "select idres 'ID Reseller',nama Nama,depo 'Jumlah Deposit' from tampung2"
            Dim cmd As New MySqlCommand(strsql2, objConnection2)
            Dim da2 As MySqlDataAdapter = New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da2.Fill(dt)
            DataGridView1.DataSource = dt
            objConnection2.Close()

            For Each dgvRow As DataGridViewRow In DataGridView1.Rows
                If Not dgvRow.IsNewRow Then
                    total += CInt(dgvRow.Cells(2).Value)
                End If
            Next
            lbltotal.Text = total
            lblpesan.ForeColor = Color.Red
            lblpesan.Text = "Silahkan bayar Rp " & lbltotal.Text & ",- ke kasir !"
            lblproses.Visible = True

            GroupBox1.Text = "Informasi Deposit"
            lblinformasi.Text = "Informasi uang deposit"
            lblproses.Text = "Proses penambahan deposit akan dilakukan setelah anda menyerahkan sejumlah uang."
        End If
        
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        second = second - 1
        If second = 0 Then
            cek()
            second = 1
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If lblpesan.Visible = True Then
            lblpesan.Visible = False
        ElseIf lblpesan.Visible = False Then
            lblpesan.Visible = True
        End If
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        detik = detik + 1
        If detik = 8 Then
            detik = 1
            Timer3.Stop()
            Me.Close()
            Timer2.Start()
        End If
    End Sub
End Class