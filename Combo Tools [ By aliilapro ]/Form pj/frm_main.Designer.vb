<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_main))
        Me.listcombo = New System.Windows.Forms.ListBox()
        Me.btn_load = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.btn_cte = New System.Windows.Forms.Button()
        Me.btn_ctu = New System.Windows.Forms.Button()
        Me.btn_getpas = New System.Windows.Forms.Button()
        Me.btn_getuser = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtlog = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_rd = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_re = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'listcombo
        '
        Me.listcombo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.listcombo.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listcombo.FormattingEnabled = True
        Me.listcombo.ItemHeight = 15
        Me.listcombo.Location = New System.Drawing.Point(7, 15)
        Me.listcombo.Name = "listcombo"
        Me.listcombo.Size = New System.Drawing.Size(314, 375)
        Me.listcombo.TabIndex = 0
        '
        'btn_load
        '
        Me.btn_load.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_load.Location = New System.Drawing.Point(6, 25)
        Me.btn_load.Name = "btn_load"
        Me.btn_load.Size = New System.Drawing.Size(156, 36)
        Me.btn_load.TabIndex = 1
        Me.btn_load.Text = "Load Combo"
        Me.btn_load.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.Location = New System.Drawing.Point(191, 25)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(180, 36)
        Me.btn_save.TabIndex = 2
        Me.btn_save.Text = "Save List"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_re)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btn_load)
        Me.GroupBox1.Controls.Add(Me.btn_save)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.btn_rd)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.btn_cte)
        Me.GroupBox1.Controls.Add(Me.btn_ctu)
        Me.GroupBox1.Controls.Add(Me.btn_getpas)
        Me.GroupBox1.Controls.Add(Me.btn_getuser)
        Me.GroupBox1.Location = New System.Drawing.Point(349, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(377, 394)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Option"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"@gmail.com", "@yahoo.com", "@outlook.com", "@live.com", "@mail.ru"})
        Me.ComboBox1.Location = New System.Drawing.Point(191, 186)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(180, 24)
        Me.ComboBox1.TabIndex = 6
        Me.ComboBox1.Text = "@gmail.com"
        '
        'btn_cte
        '
        Me.btn_cte.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cte.Location = New System.Drawing.Point(191, 144)
        Me.btn_cte.Name = "btn_cte"
        Me.btn_cte.Size = New System.Drawing.Size(180, 36)
        Me.btn_cte.TabIndex = 8
        Me.btn_cte.Text = "Convert To E-mail:Pass"
        Me.btn_cte.UseVisualStyleBackColor = True
        '
        'btn_ctu
        '
        Me.btn_ctu.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ctu.Location = New System.Drawing.Point(5, 144)
        Me.btn_ctu.Name = "btn_ctu"
        Me.btn_ctu.Size = New System.Drawing.Size(157, 36)
        Me.btn_ctu.TabIndex = 7
        Me.btn_ctu.Text = "Convert To User:Pass"
        Me.btn_ctu.UseVisualStyleBackColor = True
        '
        'btn_getpas
        '
        Me.btn_getpas.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_getpas.Location = New System.Drawing.Point(191, 91)
        Me.btn_getpas.Name = "btn_getpas"
        Me.btn_getpas.Size = New System.Drawing.Size(180, 36)
        Me.btn_getpas.TabIndex = 6
        Me.btn_getpas.Text = "Remove User/E-mail"
        Me.btn_getpas.UseVisualStyleBackColor = True
        '
        'btn_getuser
        '
        Me.btn_getuser.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_getuser.Location = New System.Drawing.Point(5, 91)
        Me.btn_getuser.Name = "btn_getuser"
        Me.btn_getuser.Size = New System.Drawing.Size(157, 36)
        Me.btn_getuser.TabIndex = 5
        Me.btn_getuser.Text = "Remove Password"
        Me.btn_getuser.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LinkLabel1)
        Me.GroupBox2.Controls.Add(Me.listcombo)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(331, 394)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Result"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtlog)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 412)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(714, 180)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Log"
        '
        'txtlog
        '
        Me.txtlog.BackColor = System.Drawing.Color.Black
        Me.txtlog.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtlog.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlog.ForeColor = System.Drawing.Color.Lime
        Me.txtlog.Location = New System.Drawing.Point(7, 19)
        Me.txtlog.Multiline = True
        Me.txtlog.Name = "txtlog"
        Me.txtlog.Size = New System.Drawing.Size(702, 155)
        Me.txtlog.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 189)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "You Can Click, Change Domain"
        '
        'btn_rd
        '
        Me.btn_rd.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_rd.Location = New System.Drawing.Point(5, 231)
        Me.btn_rd.Name = "btn_rd"
        Me.btn_rd.Size = New System.Drawing.Size(365, 36)
        Me.btn_rd.TabIndex = 9
        Me.btn_rd.Text = "Remove Duplicates"
        Me.btn_rd.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(209, 306)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(161, 20)
        Me.TextBox2.TabIndex = 18
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(5, 306)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(161, 20)
        Me.TextBox1.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(68, 287)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 16)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Find"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(248, 287)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 16)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Replace Wth"
        '
        'btn_re
        '
        Me.btn_re.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_re.Location = New System.Drawing.Point(6, 343)
        Me.btn_re.Name = "btn_re"
        Me.btn_re.Size = New System.Drawing.Size(365, 36)
        Me.btn_re.TabIndex = 21
        Me.btn_re.Text = "Replace"
        Me.btn_re.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.White
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(243, 15)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(65, 17)
        Me.LinkLabel1.TabIndex = 22
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Clear List"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.BackColor = System.Drawing.SystemColors.Control
        Me.LinkLabel2.Font = New System.Drawing.Font("Microsoft PhagsPa", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.Location = New System.Drawing.Point(565, 590)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(168, 20)
        Me.LinkLabel2.TabIndex = 23
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Join Channel Telegram"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 590)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(733, 25)
        Me.ToolStrip1.TabIndex = 6
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Microsoft PhagsPa", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(326, 22)
        Me.ToolStripLabel1.Text = "CopyLeft ©  By ALIILAPRO - [ t.me/aliilapro ]"
        '
        'frm_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(733, 615)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Combo Tools [ By aliilapro ]"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents listcombo As ListBox
    Friend WithEvents btn_load As Button
    Friend WithEvents btn_save As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btn_getuser As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtlog As TextBox
    Friend WithEvents btn_getpas As Button
    Friend WithEvents btn_cte As Button
    Friend WithEvents btn_ctu As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_rd As Button
    Friend WithEvents btn_re As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
End Class
