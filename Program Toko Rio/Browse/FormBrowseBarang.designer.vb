<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBrowseBarang
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBrowseBarang))
        Me.main_tool_strip = New System.Windows.Forms.ToolStrip
        Me.btnAdd = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.btnExit = New System.Windows.Forms.ToolStripButton
        Me.GroupGrdBrowseSuppType = New System.Windows.Forms.GroupBox
        Me.gridBarang = New System.Windows.Forms.DataGridView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.txtCari = New System.Windows.Forms.TextBox
        Me.cmbCari = New System.Windows.Forms.ComboBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtCari2 = New System.Windows.Forms.TextBox
        Me.cmbCari2 = New System.Windows.Forms.ComboBox
        Me.main_tool_strip.SuspendLayout()
        Me.GroupGrdBrowseSuppType.SuspendLayout()
        CType(Me.gridBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'main_tool_strip
        '
        Me.main_tool_strip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.main_tool_strip.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.main_tool_strip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAdd, Me.ToolStripSeparator5, Me.btnExit})
        Me.main_tool_strip.Location = New System.Drawing.Point(0, 0)
        Me.main_tool_strip.Name = "main_tool_strip"
        Me.main_tool_strip.Size = New System.Drawing.Size(844, 54)
        Me.main_tool_strip.TabIndex = 481
        Me.main_tool_strip.Text = "Tool Strip"
        '
        'btnAdd
        '
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(55, 51)
        Me.btnAdd.Text = "Tambah"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 54)
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(44, 51)
        Me.btnExit.Text = "Keluar"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'GroupGrdBrowseSuppType
        '
        Me.GroupGrdBrowseSuppType.Controls.Add(Me.gridBarang)
        Me.GroupGrdBrowseSuppType.Location = New System.Drawing.Point(18, 142)
        Me.GroupGrdBrowseSuppType.Name = "GroupGrdBrowseSuppType"
        Me.GroupGrdBrowseSuppType.Size = New System.Drawing.Size(814, 280)
        Me.GroupGrdBrowseSuppType.TabIndex = 482
        Me.GroupGrdBrowseSuppType.TabStop = False
        Me.GroupGrdBrowseSuppType.Text = "Daftar Barang"
        '
        'gridBarang
        '
        Me.gridBarang.AllowUserToAddRows = False
        Me.gridBarang.AllowUserToDeleteRows = False
        Me.gridBarang.AllowUserToOrderColumns = True
        Me.gridBarang.Location = New System.Drawing.Point(6, 19)
        Me.gridBarang.Name = "gridBarang"
        Me.gridBarang.ReadOnly = True
        Me.gridBarang.RowHeadersWidth = 40
        Me.gridBarang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridBarang.Size = New System.Drawing.Size(802, 243)
        Me.gridBarang.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCari2)
        Me.GroupBox1.Controls.Add(Me.cmbCari2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txtCari)
        Me.GroupBox1.Controls.Add(Me.cmbCari)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(826, 79)
        Me.GroupBox1.TabIndex = 486
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pencarian"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(536, 46)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(64, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "RESET"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtCari
        '
        Me.txtCari.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCari.Location = New System.Drawing.Point(294, 20)
        Me.txtCari.MaxLength = 100
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(236, 22)
        Me.txtCari.TabIndex = 2
        '
        'cmbCari
        '
        Me.cmbCari.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCari.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCari.FormattingEnabled = True
        Me.cmbCari.Location = New System.Drawing.Point(136, 18)
        Me.cmbCari.Name = "cmbCari"
        Me.cmbCari.Size = New System.Drawing.Size(137, 24)
        Me.cmbCari.TabIndex = 1
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(12, 21)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(86, 16)
        Me.Label17.TabIndex = 351
        Me.Label17.Text = "Berdasarkan"
        '
        'txtCari2
        '
        Me.txtCari2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCari2.Location = New System.Drawing.Point(294, 48)
        Me.txtCari2.MaxLength = 100
        Me.txtCari2.Name = "txtCari2"
        Me.txtCari2.Size = New System.Drawing.Size(236, 22)
        Me.txtCari2.TabIndex = 355
        '
        'cmbCari2
        '
        Me.cmbCari2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCari2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCari2.FormattingEnabled = True
        Me.cmbCari2.Location = New System.Drawing.Point(134, 46)
        Me.cmbCari2.Name = "cmbCari2"
        Me.cmbCari2.Size = New System.Drawing.Size(137, 24)
        Me.cmbCari2.TabIndex = 354
        '
        'FormBrowseBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(844, 437)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupGrdBrowseSuppType)
        Me.Controls.Add(Me.main_tool_strip)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormBrowseBarang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ambil Barang"
        Me.main_tool_strip.ResumeLayout(False)
        Me.main_tool_strip.PerformLayout()
        Me.GroupGrdBrowseSuppType.ResumeLayout(False)
        CType(Me.gridBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents main_tool_strip As System.Windows.Forms.ToolStrip
    Friend WithEvents btnAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupGrdBrowseSuppType As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtCari As System.Windows.Forms.TextBox
    Friend WithEvents cmbCari As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents gridBarang As System.Windows.Forms.DataGridView
    Friend WithEvents txtCari2 As System.Windows.Forms.TextBox
    Friend WithEvents cmbCari2 As System.Windows.Forms.ComboBox

End Class
