<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmkartu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.TeamViewerTheme1 = New DDCounter.TeamViewerTheme()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbljumlah = New System.Windows.Forms.Label()
        Me.lblmbuh = New System.Windows.Forms.Label()
        Me.btnbatal = New DDCounter.SkypeButton()
        Me.btnlihat = New DDCounter.SkypeButton()
        Me.lblwaktu = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnkembali = New DDCounter.SkypeButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnindosat = New System.Windows.Forms.Button()
        Me.btnxl = New System.Windows.Forms.Button()
        Me.btntelkomsel = New System.Windows.Forms.Button()
        Me.btnaxis = New System.Windows.Forms.Button()
        Me.btnesia = New System.Windows.Forms.Button()
        Me.btntri = New System.Windows.Forms.Button()
        Me.btnsmart = New System.Windows.Forms.Button()
        Me.btnflexi = New System.Windows.Forms.Button()
        Me.btnstarone = New System.Windows.Forms.Button()
        Me.btnceria = New System.Windows.Forms.Button()
        Me.btnhepi = New System.Windows.Forms.Button()
        Me.btnpln = New System.Windows.Forms.Button()
        Me.TeamViewerTheme1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 1000
        '
        'TeamViewerTheme1
        '
        Me.TeamViewerTheme1.Controls.Add(Me.TableLayoutPanel1)
        Me.TeamViewerTheme1.Controls.Add(Me.Label3)
        Me.TeamViewerTheme1.Controls.Add(Me.lbljumlah)
        Me.TeamViewerTheme1.Controls.Add(Me.lblmbuh)
        Me.TeamViewerTheme1.Controls.Add(Me.btnbatal)
        Me.TeamViewerTheme1.Controls.Add(Me.btnlihat)
        Me.TeamViewerTheme1.Controls.Add(Me.lblwaktu)
        Me.TeamViewerTheme1.Controls.Add(Me.Label2)
        Me.TeamViewerTheme1.Controls.Add(Me.Label1)
        Me.TeamViewerTheme1.Controls.Add(Me.btnkembali)
        Me.TeamViewerTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TeamViewerTheme1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.TeamViewerTheme1.Image = Nothing
        Me.TeamViewerTheme1.Location = New System.Drawing.Point(0, 0)
        Me.TeamViewerTheme1.MoveHeight = 19
        Me.TeamViewerTheme1.Name = "TeamViewerTheme1"
        Me.TeamViewerTheme1.Resizable = True
        Me.TeamViewerTheme1.Size = New System.Drawing.Size(982, 748)
        Me.TeamViewerTheme1.TabIndex = 0
        Me.TeamViewerTheme1.Text = "TeamViewerTheme1"
        Me.TeamViewerTheme1.TransparencyKey = System.Drawing.Color.Empty
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Location = New System.Drawing.Point(23, 647)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(305, 20)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Pilih salah satu jenis kartu yang ingin dibeli"
        '
        'lbljumlah
        '
        Me.lbljumlah.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbljumlah.AutoSize = True
        Me.lbljumlah.BackColor = System.Drawing.Color.Transparent
        Me.lbljumlah.Font = New System.Drawing.Font("Cambria", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbljumlah.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbljumlah.Location = New System.Drawing.Point(880, 675)
        Me.lbljumlah.Name = "lbljumlah"
        Me.lbljumlah.Size = New System.Drawing.Size(16, 16)
        Me.lbljumlah.TabIndex = 31
        Me.lbljumlah.Text = "0"
        '
        'lblmbuh
        '
        Me.lblmbuh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblmbuh.AutoSize = True
        Me.lblmbuh.BackColor = System.Drawing.Color.Transparent
        Me.lblmbuh.Font = New System.Drawing.Font("Cambria", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmbuh.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblmbuh.Location = New System.Drawing.Point(714, 675)
        Me.lblmbuh.Name = "lblmbuh"
        Me.lblmbuh.Size = New System.Drawing.Size(166, 16)
        Me.lblmbuh.TabIndex = 30
        Me.lblmbuh.Text = "Jumlah Pulsa yang dibeli :"
        '
        'btnbatal
        '
        Me.btnbatal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnbatal.Colors = New DDCounter.Bloom(-1) {}
        Me.btnbatal.Customization = ""
        Me.btnbatal.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnbatal.Image = Nothing
        Me.btnbatal.ImageAllignmentMode = DDCounter.SkypeButton.AllignMode.Left
        Me.btnbatal.Location = New System.Drawing.Point(870, 704)
        Me.btnbatal.Name = "btnbatal"
        Me.btnbatal.NoRounding = False
        Me.btnbatal.Size = New System.Drawing.Size(100, 32)
        Me.btnbatal.TabIndex = 29
        Me.btnbatal.Text = "Batal"
        Me.btnbatal.Text_Margin_Left = 27
        Me.btnbatal.Transparent = False
        '
        'btnlihat
        '
        Me.btnlihat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnlihat.Colors = New DDCounter.Bloom(-1) {}
        Me.btnlihat.Customization = ""
        Me.btnlihat.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnlihat.Image = Nothing
        Me.btnlihat.ImageAllignmentMode = DDCounter.SkypeButton.AllignMode.Left
        Me.btnlihat.Location = New System.Drawing.Point(717, 704)
        Me.btnlihat.Name = "btnlihat"
        Me.btnlihat.NoRounding = False
        Me.btnlihat.Size = New System.Drawing.Size(147, 32)
        Me.btnlihat.TabIndex = 28
        Me.btnlihat.Text = "Lihat Pembelian"
        Me.btnlihat.Text_Margin_Left = 16
        Me.btnlihat.Transparent = False
        '
        'lblwaktu
        '
        Me.lblwaktu.AutoSize = True
        Me.lblwaktu.BackColor = System.Drawing.Color.Transparent
        Me.lblwaktu.Font = New System.Drawing.Font("Cambria", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblwaktu.ForeColor = System.Drawing.Color.White
        Me.lblwaktu.Location = New System.Drawing.Point(16, 7)
        Me.lblwaktu.Name = "lblwaktu"
        Me.lblwaktu.Size = New System.Drawing.Size(31, 16)
        Me.lblwaktu.TabIndex = 27
        Me.lblwaktu.Text = "jam"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Cambria", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(855, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 16)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "DD-Tronik © 2014"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Cambria", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(234, 41)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Pilihan Kartu"
        '
        'btnkembali
        '
        Me.btnkembali.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnkembali.Colors = New DDCounter.Bloom(-1) {}
        Me.btnkembali.Customization = ""
        Me.btnkembali.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnkembali.Image = Nothing
        Me.btnkembali.ImageAllignmentMode = DDCounter.SkypeButton.AllignMode.Left
        Me.btnkembali.Location = New System.Drawing.Point(12, 704)
        Me.btnkembali.Name = "btnkembali"
        Me.btnkembali.NoRounding = False
        Me.btnkembali.Size = New System.Drawing.Size(100, 32)
        Me.btnkembali.TabIndex = 24
        Me.btnkembali.Text = "Kembali"
        Me.btnkembali.Text_Margin_Left = 16
        Me.btnkembali.Transparent = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnindosat, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnxl, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btntelkomsel, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnaxis, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btnesia, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btntri, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnsmart, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnflexi, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnstarone, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnceria, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btnhepi, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btnpln, 3, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 111)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(958, 526)
        Me.TableLayoutPanel1.TabIndex = 36
        '
        'btnindosat
        '
        Me.btnindosat.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnindosat.BackgroundImage = Global.DDCounter.My.Resources.Resources.indosat
        Me.btnindosat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnindosat.Location = New System.Drawing.Point(3, 3)
        Me.btnindosat.Name = "btnindosat"
        Me.btnindosat.Size = New System.Drawing.Size(233, 169)
        Me.btnindosat.TabIndex = 1
        Me.btnindosat.UseVisualStyleBackColor = True
        '
        'btnxl
        '
        Me.btnxl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnxl.BackgroundImage = Global.DDCounter.My.Resources.Resources._1719a761587fd6ad865831e489ae21d38f46dfa7
        Me.btnxl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnxl.Location = New System.Drawing.Point(242, 3)
        Me.btnxl.Name = "btnxl"
        Me.btnxl.Size = New System.Drawing.Size(233, 169)
        Me.btnxl.TabIndex = 2
        Me.btnxl.UseVisualStyleBackColor = True
        '
        'btntelkomsel
        '
        Me.btntelkomsel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btntelkomsel.BackgroundImage = Global.DDCounter.My.Resources.Resources.Telkomsel
        Me.btntelkomsel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btntelkomsel.Location = New System.Drawing.Point(481, 3)
        Me.btntelkomsel.Name = "btntelkomsel"
        Me.btntelkomsel.Size = New System.Drawing.Size(233, 169)
        Me.btntelkomsel.TabIndex = 3
        Me.btntelkomsel.UseVisualStyleBackColor = True
        '
        'btnaxis
        '
        Me.btnaxis.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnaxis.BackgroundImage = Global.DDCounter.My.Resources.Resources.aXIS
        Me.btnaxis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnaxis.Location = New System.Drawing.Point(481, 353)
        Me.btnaxis.Name = "btnaxis"
        Me.btnaxis.Size = New System.Drawing.Size(233, 170)
        Me.btnaxis.TabIndex = 11
        Me.btnaxis.UseVisualStyleBackColor = True
        '
        'btnesia
        '
        Me.btnesia.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnesia.BackgroundImage = Global.DDCounter.My.Resources.Resources.logo_esia
        Me.btnesia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnesia.Location = New System.Drawing.Point(720, 3)
        Me.btnesia.Name = "btnesia"
        Me.btnesia.Size = New System.Drawing.Size(235, 169)
        Me.btnesia.TabIndex = 4
        Me.btnesia.UseVisualStyleBackColor = True
        '
        'btntri
        '
        Me.btntri.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btntri.BackgroundImage = Global.DDCounter.My.Resources.Resources.kartu_GSM_three
        Me.btntri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btntri.Location = New System.Drawing.Point(3, 178)
        Me.btntri.Name = "btntri"
        Me.btntri.Size = New System.Drawing.Size(233, 169)
        Me.btntri.TabIndex = 5
        Me.btntri.UseVisualStyleBackColor = True
        '
        'btnsmart
        '
        Me.btnsmart.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnsmart.BackgroundImage = Global.DDCounter.My.Resources.Resources.Logo_smartfren
        Me.btnsmart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnsmart.Location = New System.Drawing.Point(242, 178)
        Me.btnsmart.Name = "btnsmart"
        Me.btnsmart.Size = New System.Drawing.Size(233, 169)
        Me.btnsmart.TabIndex = 6
        Me.btnsmart.UseVisualStyleBackColor = True
        '
        'btnflexi
        '
        Me.btnflexi.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnflexi.BackgroundImage = Global.DDCounter.My.Resources.Resources.lowongan_kerja_telkom_flexi1
        Me.btnflexi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnflexi.Location = New System.Drawing.Point(481, 178)
        Me.btnflexi.Name = "btnflexi"
        Me.btnflexi.Size = New System.Drawing.Size(233, 169)
        Me.btnflexi.TabIndex = 7
        Me.btnflexi.UseVisualStyleBackColor = True
        '
        'btnstarone
        '
        Me.btnstarone.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnstarone.BackgroundImage = Global.DDCounter.My.Resources.Resources.starone_big
        Me.btnstarone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnstarone.Location = New System.Drawing.Point(720, 178)
        Me.btnstarone.Name = "btnstarone"
        Me.btnstarone.Size = New System.Drawing.Size(235, 169)
        Me.btnstarone.TabIndex = 8
        Me.btnstarone.UseVisualStyleBackColor = True
        '
        'btnceria
        '
        Me.btnceria.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnceria.BackgroundImage = Global.DDCounter.My.Resources.Resources.ceria
        Me.btnceria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnceria.Location = New System.Drawing.Point(3, 353)
        Me.btnceria.Name = "btnceria"
        Me.btnceria.Size = New System.Drawing.Size(233, 170)
        Me.btnceria.TabIndex = 9
        Me.btnceria.UseVisualStyleBackColor = True
        '
        'btnhepi
        '
        Me.btnhepi.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnhepi.BackgroundImage = Global.DDCounter.My.Resources.Resources.logo_hepi_magenta1
        Me.btnhepi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnhepi.Location = New System.Drawing.Point(242, 353)
        Me.btnhepi.Name = "btnhepi"
        Me.btnhepi.Size = New System.Drawing.Size(233, 170)
        Me.btnhepi.TabIndex = 10
        Me.btnhepi.UseVisualStyleBackColor = True
        '
        'btnpln
        '
        Me.btnpln.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnpln.BackgroundImage = Global.DDCounter.My.Resources.Resources.LOGO_PLN
        Me.btnpln.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnpln.Location = New System.Drawing.Point(720, 353)
        Me.btnpln.Name = "btnpln"
        Me.btnpln.Size = New System.Drawing.Size(235, 170)
        Me.btnpln.TabIndex = 12
        Me.btnpln.UseVisualStyleBackColor = True
        '
        'frmkartu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(982, 748)
        Me.ControlBox = False
        Me.Controls.Add(Me.TeamViewerTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmkartu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TeamViewerTheme1.ResumeLayout(False)
        Me.TeamViewerTheme1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnkembali As DDCounter.SkypeButton
    Friend WithEvents TeamViewerTheme1 As DDCounter.TeamViewerTheme
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblwaktu As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblmbuh As System.Windows.Forms.Label
    Friend WithEvents btnbatal As DDCounter.SkypeButton
    Friend WithEvents btnlihat As DDCounter.SkypeButton
    Friend WithEvents lbljumlah As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnindosat As System.Windows.Forms.Button
    Friend WithEvents btnxl As System.Windows.Forms.Button
    Friend WithEvents btntelkomsel As System.Windows.Forms.Button
    Friend WithEvents btnaxis As System.Windows.Forms.Button
    Friend WithEvents btnesia As System.Windows.Forms.Button
    Friend WithEvents btntri As System.Windows.Forms.Button
    Friend WithEvents btnsmart As System.Windows.Forms.Button
    Friend WithEvents btnflexi As System.Windows.Forms.Button
    Friend WithEvents btnstarone As System.Windows.Forms.Button
    Friend WithEvents btnceria As System.Windows.Forms.Button
    Friend WithEvents btnhepi As System.Windows.Forms.Button
    Friend WithEvents btnpln As System.Windows.Forms.Button
End Class
