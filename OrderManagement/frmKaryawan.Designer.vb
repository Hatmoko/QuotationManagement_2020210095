<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKaryawan
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
        Dim IDKaryawanLabel As System.Windows.Forms.Label
        Dim NamaLengkapLabel As System.Windows.Forms.Label
        Dim TempatLahirLabel As System.Windows.Forms.Label
        Dim TanggalLahirLabel As System.Windows.Forms.Label
        Dim JabatanLabel As System.Windows.Forms.Label
        Dim TanggalMasukLabel As System.Windows.Forms.Label
        Dim NomorTeleponRumahLabel As System.Windows.Forms.Label
        Dim HandPhoneLabel As System.Windows.Forms.Label
        Dim AlamatLabel As System.Windows.Forms.Label
        Dim KabupatenKotaLabel As System.Windows.Forms.Label
        Dim ProvinsiLabel As System.Windows.Forms.Label
        Dim KodePosLabel As System.Windows.Forms.Label
        Dim NegaraLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim CatatanLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKaryawan))
        Me.spcKaryawan = New System.Windows.Forms.SplitContainer()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.KaryawanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QuotationDataDataSet = New SalesQuoteManagement.QuotationDataDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.IDKaryawanTextBox = New System.Windows.Forms.TextBox()
        Me.NamaLengkapTextBox = New System.Windows.Forms.TextBox()
        Me.TempatLahirTextBox = New System.Windows.Forms.TextBox()
        Me.TanggalLahirDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.JabatanTextBox = New System.Windows.Forms.TextBox()
        Me.TanggalMasukDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.NomorTeleponRumahTextBox = New System.Windows.Forms.TextBox()
        Me.HandPhoneTextBox = New System.Windows.Forms.TextBox()
        Me.AlamatTextBox = New System.Windows.Forms.TextBox()
        Me.KabupatenKotaTextBox = New System.Windows.Forms.TextBox()
        Me.ProvinsiTextBox = New System.Windows.Forms.TextBox()
        Me.KodePosTextBox = New System.Windows.Forms.TextBox()
        Me.NegaraTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.CatatanTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.KaryawanDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PelangganBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PelangganTableAdapter = New SalesQuoteManagement.QuotationDataDataSetTableAdapters.PelangganTableAdapter()
        Me.TableAdapterManager = New SalesQuoteManagement.QuotationDataDataSetTableAdapters.TableAdapterManager()
        Me.KaryawanTableAdapter = New SalesQuoteManagement.QuotationDataDataSetTableAdapters.karyawanTableAdapter()
        IDKaryawanLabel = New System.Windows.Forms.Label()
        NamaLengkapLabel = New System.Windows.Forms.Label()
        TempatLahirLabel = New System.Windows.Forms.Label()
        TanggalLahirLabel = New System.Windows.Forms.Label()
        JabatanLabel = New System.Windows.Forms.Label()
        TanggalMasukLabel = New System.Windows.Forms.Label()
        NomorTeleponRumahLabel = New System.Windows.Forms.Label()
        HandPhoneLabel = New System.Windows.Forms.Label()
        AlamatLabel = New System.Windows.Forms.Label()
        KabupatenKotaLabel = New System.Windows.Forms.Label()
        ProvinsiLabel = New System.Windows.Forms.Label()
        KodePosLabel = New System.Windows.Forms.Label()
        NegaraLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        CatatanLabel = New System.Windows.Forms.Label()
        CType(Me.spcKaryawan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spcKaryawan.Panel1.SuspendLayout()
        Me.spcKaryawan.Panel2.SuspendLayout()
        Me.spcKaryawan.SuspendLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.KaryawanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuotationDataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.KaryawanDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PelangganBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDKaryawanLabel
        '
        IDKaryawanLabel.AutoSize = True
        IDKaryawanLabel.Location = New System.Drawing.Point(60, 36)
        IDKaryawanLabel.Name = "IDKaryawanLabel"
        IDKaryawanLabel.Size = New System.Drawing.Size(68, 13)
        IDKaryawanLabel.TabIndex = 0
        IDKaryawanLabel.Text = "IDKaryawan:"
        '
        'NamaLengkapLabel
        '
        NamaLengkapLabel.AutoSize = True
        NamaLengkapLabel.Location = New System.Drawing.Point(45, 62)
        NamaLengkapLabel.Name = "NamaLengkapLabel"
        NamaLengkapLabel.Size = New System.Drawing.Size(83, 13)
        NamaLengkapLabel.TabIndex = 2
        NamaLengkapLabel.Text = "Nama Lengkap:"
        '
        'TempatLahirLabel
        '
        TempatLahirLabel.AutoSize = True
        TempatLahirLabel.Location = New System.Drawing.Point(56, 88)
        TempatLahirLabel.Name = "TempatLahirLabel"
        TempatLahirLabel.Size = New System.Drawing.Size(72, 13)
        TempatLahirLabel.TabIndex = 4
        TempatLahirLabel.Text = "Tempat Lahir:"
        '
        'TanggalLahirLabel
        '
        TanggalLahirLabel.AutoSize = True
        TanggalLahirLabel.Location = New System.Drawing.Point(53, 115)
        TanggalLahirLabel.Name = "TanggalLahirLabel"
        TanggalLahirLabel.Size = New System.Drawing.Size(75, 13)
        TanggalLahirLabel.TabIndex = 6
        TanggalLahirLabel.Text = "Tanggal Lahir:"
        '
        'JabatanLabel
        '
        JabatanLabel.AutoSize = True
        JabatanLabel.Location = New System.Drawing.Point(80, 140)
        JabatanLabel.Name = "JabatanLabel"
        JabatanLabel.Size = New System.Drawing.Size(48, 13)
        JabatanLabel.TabIndex = 8
        JabatanLabel.Text = "Jabatan:"
        '
        'TanggalMasukLabel
        '
        TanggalMasukLabel.AutoSize = True
        TanggalMasukLabel.Location = New System.Drawing.Point(44, 167)
        TanggalMasukLabel.Name = "TanggalMasukLabel"
        TanggalMasukLabel.Size = New System.Drawing.Size(84, 13)
        TanggalMasukLabel.TabIndex = 10
        TanggalMasukLabel.Text = "Tanggal Masuk:"
        '
        'NomorTeleponRumahLabel
        '
        NomorTeleponRumahLabel.AutoSize = True
        NomorTeleponRumahLabel.Location = New System.Drawing.Point(42, 192)
        NomorTeleponRumahLabel.Name = "NomorTeleponRumahLabel"
        NomorTeleponRumahLabel.Size = New System.Drawing.Size(86, 13)
        NomorTeleponRumahLabel.TabIndex = 12
        NomorTeleponRumahLabel.Text = "Telepon Rumah:"
        '
        'HandPhoneLabel
        '
        HandPhoneLabel.AutoSize = True
        HandPhoneLabel.Location = New System.Drawing.Point(58, 218)
        HandPhoneLabel.Name = "HandPhoneLabel"
        HandPhoneLabel.Size = New System.Drawing.Size(70, 13)
        HandPhoneLabel.TabIndex = 14
        HandPhoneLabel.Text = "Hand Phone:"
        '
        'AlamatLabel
        '
        AlamatLabel.AutoSize = True
        AlamatLabel.Location = New System.Drawing.Point(80, 275)
        AlamatLabel.Name = "AlamatLabel"
        AlamatLabel.Size = New System.Drawing.Size(42, 13)
        AlamatLabel.TabIndex = 16
        AlamatLabel.Text = "Alamat:"
        '
        'KabupatenKotaLabel
        '
        KabupatenKotaLabel.AutoSize = True
        KabupatenKotaLabel.Location = New System.Drawing.Point(35, 301)
        KabupatenKotaLabel.Name = "KabupatenKotaLabel"
        KabupatenKotaLabel.Size = New System.Drawing.Size(87, 13)
        KabupatenKotaLabel.TabIndex = 18
        KabupatenKotaLabel.Text = "Kabupaten Kota:"
        '
        'ProvinsiLabel
        '
        ProvinsiLabel.AutoSize = True
        ProvinsiLabel.Location = New System.Drawing.Point(339, 301)
        ProvinsiLabel.Name = "ProvinsiLabel"
        ProvinsiLabel.Size = New System.Drawing.Size(47, 13)
        ProvinsiLabel.TabIndex = 20
        ProvinsiLabel.Text = "Provinsi:"
        '
        'KodePosLabel
        '
        KodePosLabel.AutoSize = True
        KodePosLabel.Location = New System.Drawing.Point(67, 330)
        KodePosLabel.Name = "KodePosLabel"
        KodePosLabel.Size = New System.Drawing.Size(55, 13)
        KodePosLabel.TabIndex = 22
        KodePosLabel.Text = "kode Pos:"
        '
        'NegaraLabel
        '
        NegaraLabel.AutoSize = True
        NegaraLabel.Location = New System.Drawing.Point(340, 327)
        NegaraLabel.Name = "NegaraLabel"
        NegaraLabel.Size = New System.Drawing.Size(45, 13)
        NegaraLabel.TabIndex = 24
        NegaraLabel.Text = "Negara:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(94, 244)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(34, 13)
        EmailLabel.TabIndex = 26
        EmailLabel.Text = "email:"
        '
        'CatatanLabel
        '
        CatatanLabel.AutoSize = True
        CatatanLabel.Location = New System.Drawing.Point(383, 40)
        CatatanLabel.Name = "CatatanLabel"
        CatatanLabel.Size = New System.Drawing.Size(46, 13)
        CatatanLabel.TabIndex = 28
        CatatanLabel.Text = "catatan:"
        '
        'spcKaryawan
        '
        Me.spcKaryawan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spcKaryawan.Location = New System.Drawing.Point(0, 0)
        Me.spcKaryawan.Name = "spcKaryawan"
        Me.spcKaryawan.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'spcKaryawan.Panel1
        '
        Me.spcKaryawan.Panel1.Controls.Add(Me.lblTitle)
        '
        'spcKaryawan.Panel2
        '
        Me.spcKaryawan.Panel2.AutoScroll = True
        Me.spcKaryawan.Panel2.Controls.Add(Me.BindingNavigator1)
        Me.spcKaryawan.Panel2.Controls.Add(Me.TabControl1)
        Me.spcKaryawan.Size = New System.Drawing.Size(619, 500)
        Me.spcKaryawan.SplitterDistance = 40
        Me.spcKaryawan.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(619, 40)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "DATA KARYAWAN"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator1.BindingSource = Me.KaryawanBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 431)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(619, 25)
        Me.BindingNavigator1.TabIndex = 2
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'KaryawanBindingSource
        '
        Me.KaryawanBindingSource.DataMember = "karyawan"
        Me.KaryawanBindingSource.DataSource = Me.QuotationDataDataSet
        '
        'QuotationDataDataSet
        '
        Me.QuotationDataDataSet.DataSetName = "QuotationDataDataSet"
        Me.QuotationDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(619, 456)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(IDKaryawanLabel)
        Me.TabPage1.Controls.Add(Me.IDKaryawanTextBox)
        Me.TabPage1.Controls.Add(NamaLengkapLabel)
        Me.TabPage1.Controls.Add(Me.NamaLengkapTextBox)
        Me.TabPage1.Controls.Add(TempatLahirLabel)
        Me.TabPage1.Controls.Add(Me.TempatLahirTextBox)
        Me.TabPage1.Controls.Add(TanggalLahirLabel)
        Me.TabPage1.Controls.Add(Me.TanggalLahirDateTimePicker)
        Me.TabPage1.Controls.Add(JabatanLabel)
        Me.TabPage1.Controls.Add(Me.JabatanTextBox)
        Me.TabPage1.Controls.Add(TanggalMasukLabel)
        Me.TabPage1.Controls.Add(Me.TanggalMasukDateTimePicker)
        Me.TabPage1.Controls.Add(NomorTeleponRumahLabel)
        Me.TabPage1.Controls.Add(Me.NomorTeleponRumahTextBox)
        Me.TabPage1.Controls.Add(HandPhoneLabel)
        Me.TabPage1.Controls.Add(Me.HandPhoneTextBox)
        Me.TabPage1.Controls.Add(AlamatLabel)
        Me.TabPage1.Controls.Add(Me.AlamatTextBox)
        Me.TabPage1.Controls.Add(KabupatenKotaLabel)
        Me.TabPage1.Controls.Add(Me.KabupatenKotaTextBox)
        Me.TabPage1.Controls.Add(ProvinsiLabel)
        Me.TabPage1.Controls.Add(Me.ProvinsiTextBox)
        Me.TabPage1.Controls.Add(KodePosLabel)
        Me.TabPage1.Controls.Add(Me.KodePosTextBox)
        Me.TabPage1.Controls.Add(NegaraLabel)
        Me.TabPage1.Controls.Add(Me.NegaraTextBox)
        Me.TabPage1.Controls.Add(EmailLabel)
        Me.TabPage1.Controls.Add(Me.EmailTextBox)
        Me.TabPage1.Controls.Add(CatatanLabel)
        Me.TabPage1.Controls.Add(Me.CatatanTextBox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(611, 430)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Data Detail"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'IDKaryawanTextBox
        '
        Me.IDKaryawanTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KaryawanBindingSource, "IDKaryawan", True))
        Me.IDKaryawanTextBox.Location = New System.Drawing.Point(134, 33)
        Me.IDKaryawanTextBox.Name = "IDKaryawanTextBox"
        Me.IDKaryawanTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IDKaryawanTextBox.TabIndex = 1
        '
        'NamaLengkapTextBox
        '
        Me.NamaLengkapTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KaryawanBindingSource, "NamaLengkap", True))
        Me.NamaLengkapTextBox.Location = New System.Drawing.Point(134, 59)
        Me.NamaLengkapTextBox.Name = "NamaLengkapTextBox"
        Me.NamaLengkapTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NamaLengkapTextBox.TabIndex = 3
        '
        'TempatLahirTextBox
        '
        Me.TempatLahirTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KaryawanBindingSource, "TempatLahir", True))
        Me.TempatLahirTextBox.Location = New System.Drawing.Point(134, 85)
        Me.TempatLahirTextBox.Name = "TempatLahirTextBox"
        Me.TempatLahirTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TempatLahirTextBox.TabIndex = 5
        '
        'TanggalLahirDateTimePicker
        '
        Me.TanggalLahirDateTimePicker.CustomFormat = "dd MMM yyyy"
        Me.TanggalLahirDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.KaryawanBindingSource, "TanggalLahir", True))
        Me.TanggalLahirDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TanggalLahirDateTimePicker.Location = New System.Drawing.Point(134, 111)
        Me.TanggalLahirDateTimePicker.Name = "TanggalLahirDateTimePicker"
        Me.TanggalLahirDateTimePicker.Size = New System.Drawing.Size(123, 20)
        Me.TanggalLahirDateTimePicker.TabIndex = 7
        '
        'JabatanTextBox
        '
        Me.JabatanTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KaryawanBindingSource, "Jabatan", True))
        Me.JabatanTextBox.Location = New System.Drawing.Point(134, 137)
        Me.JabatanTextBox.Name = "JabatanTextBox"
        Me.JabatanTextBox.Size = New System.Drawing.Size(200, 20)
        Me.JabatanTextBox.TabIndex = 9
        '
        'TanggalMasukDateTimePicker
        '
        Me.TanggalMasukDateTimePicker.CustomFormat = "dd MMM yyyy"
        Me.TanggalMasukDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.KaryawanBindingSource, "TanggalMasuk", True))
        Me.TanggalMasukDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TanggalMasukDateTimePicker.Location = New System.Drawing.Point(134, 163)
        Me.TanggalMasukDateTimePicker.Name = "TanggalMasukDateTimePicker"
        Me.TanggalMasukDateTimePicker.Size = New System.Drawing.Size(123, 20)
        Me.TanggalMasukDateTimePicker.TabIndex = 11
        '
        'NomorTeleponRumahTextBox
        '
        Me.NomorTeleponRumahTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KaryawanBindingSource, "NomorTeleponRumah", True))
        Me.NomorTeleponRumahTextBox.Location = New System.Drawing.Point(134, 189)
        Me.NomorTeleponRumahTextBox.Name = "NomorTeleponRumahTextBox"
        Me.NomorTeleponRumahTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NomorTeleponRumahTextBox.TabIndex = 13
        '
        'HandPhoneTextBox
        '
        Me.HandPhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KaryawanBindingSource, "HandPhone", True))
        Me.HandPhoneTextBox.Location = New System.Drawing.Point(134, 215)
        Me.HandPhoneTextBox.Name = "HandPhoneTextBox"
        Me.HandPhoneTextBox.Size = New System.Drawing.Size(200, 20)
        Me.HandPhoneTextBox.TabIndex = 15
        '
        'AlamatTextBox
        '
        Me.AlamatTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KaryawanBindingSource, "Alamat", True))
        Me.AlamatTextBox.Location = New System.Drawing.Point(134, 272)
        Me.AlamatTextBox.Name = "AlamatTextBox"
        Me.AlamatTextBox.Size = New System.Drawing.Size(452, 20)
        Me.AlamatTextBox.TabIndex = 17
        '
        'KabupatenKotaTextBox
        '
        Me.KabupatenKotaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KaryawanBindingSource, "KabupatenKota", True))
        Me.KabupatenKotaTextBox.Location = New System.Drawing.Point(134, 298)
        Me.KabupatenKotaTextBox.Name = "KabupatenKotaTextBox"
        Me.KabupatenKotaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.KabupatenKotaTextBox.TabIndex = 19
        '
        'ProvinsiTextBox
        '
        Me.ProvinsiTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KaryawanBindingSource, "Provinsi", True))
        Me.ProvinsiTextBox.Location = New System.Drawing.Point(386, 298)
        Me.ProvinsiTextBox.Name = "ProvinsiTextBox"
        Me.ProvinsiTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ProvinsiTextBox.TabIndex = 21
        '
        'KodePosTextBox
        '
        Me.KodePosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KaryawanBindingSource, "kodePos", True))
        Me.KodePosTextBox.Location = New System.Drawing.Point(134, 327)
        Me.KodePosTextBox.Name = "KodePosTextBox"
        Me.KodePosTextBox.Size = New System.Drawing.Size(123, 20)
        Me.KodePosTextBox.TabIndex = 23
        '
        'NegaraTextBox
        '
        Me.NegaraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KaryawanBindingSource, "Negara", True))
        Me.NegaraTextBox.Location = New System.Drawing.Point(386, 324)
        Me.NegaraTextBox.Name = "NegaraTextBox"
        Me.NegaraTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NegaraTextBox.TabIndex = 25
        Me.NegaraTextBox.Text = "Indonesia"
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KaryawanBindingSource, "email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(134, 241)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(200, 20)
        Me.EmailTextBox.TabIndex = 27
        '
        'CatatanTextBox
        '
        Me.CatatanTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KaryawanBindingSource, "catatan", True))
        Me.CatatanTextBox.Location = New System.Drawing.Point(386, 62)
        Me.CatatanTextBox.Multiline = True
        Me.CatatanTextBox.Name = "CatatanTextBox"
        Me.CatatanTextBox.Size = New System.Drawing.Size(200, 124)
        Me.CatatanTextBox.TabIndex = 29
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.KaryawanDataGridView)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(611, 430)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Daftar Karyawan"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'KaryawanDataGridView
        '
        Me.KaryawanDataGridView.AutoGenerateColumns = False
        Me.KaryawanDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.KaryawanDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15})
        Me.KaryawanDataGridView.DataSource = Me.KaryawanBindingSource
        Me.KaryawanDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KaryawanDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.KaryawanDataGridView.Name = "KaryawanDataGridView"
        Me.KaryawanDataGridView.Size = New System.Drawing.Size(605, 424)
        Me.KaryawanDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IDKaryawan"
        Me.DataGridViewTextBoxColumn1.HeaderText = "NIP"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 35
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NamaLengkap"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nama"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "TempatLahir"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Tempat Lahir"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "TanggalLahir"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Tanggal Lahir"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Jabatan"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Jabatan"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "TanggalMasuk"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Tanggal Masuk"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "NomorTeleponRumah"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Telepon Rumah"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "HandPhone"
        Me.DataGridViewTextBoxColumn8.HeaderText = "HandPhone"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Alamat"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Alamat"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "KabupatenKota"
        Me.DataGridViewTextBoxColumn10.HeaderText = "KabupatenKota"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Provinsi"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Provinsi"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "kodePos"
        Me.DataGridViewTextBoxColumn12.HeaderText = "kodePos"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Negara"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Negara"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "email"
        Me.DataGridViewTextBoxColumn14.HeaderText = "email"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "catatan"
        Me.DataGridViewTextBoxColumn15.HeaderText = "catatan"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'PelangganBindingSource
        '
        Me.PelangganBindingSource.DataMember = "Pelanggan"
        Me.PelangganBindingSource.DataSource = Me.QuotationDataDataSet
        '
        'PelangganTableAdapter
        '
        Me.PelangganTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.karyawanTableAdapter = Nothing
        Me.TableAdapterManager.PelangganTableAdapter = Me.PelangganTableAdapter
        Me.TableAdapterManager.ProdukTableAdapter = Nothing
        Me.TableAdapterManager.ProyekTableAdapter = Nothing
        Me.TableAdapterManager.Quotation_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.SupplierTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SalesQuoteManagement.QuotationDataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'KaryawanTableAdapter
        '
        Me.KaryawanTableAdapter.ClearBeforeFill = True
        '
        'frmKaryawan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 500)
        Me.Controls.Add(Me.spcKaryawan)
        Me.Name = "frmKaryawan"
        Me.ShowIcon = False
        Me.Text = "Karyawan"
        Me.spcKaryawan.Panel1.ResumeLayout(False)
        Me.spcKaryawan.Panel2.ResumeLayout(False)
        Me.spcKaryawan.Panel2.PerformLayout()
        CType(Me.spcKaryawan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spcKaryawan.ResumeLayout(False)
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.KaryawanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuotationDataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.KaryawanDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PelangganBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents spcKaryawan As System.Windows.Forms.SplitContainer
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents QuotationDataDataSet As SalesQuoteManagement.QuotationDataDataSet
    Friend WithEvents PelangganBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PelangganTableAdapter As SalesQuoteManagement.QuotationDataDataSetTableAdapters.PelangganTableAdapter
    Friend WithEvents TableAdapterManager As SalesQuoteManagement.QuotationDataDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents KaryawanBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents KaryawanTableAdapter As SalesQuoteManagement.QuotationDataDataSetTableAdapters.karyawanTableAdapter
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents KaryawanDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDKaryawanTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NamaLengkapTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TempatLahirTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TanggalLahirDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents JabatanTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TanggalMasukDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents NomorTeleponRumahTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HandPhoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AlamatTextBox As System.Windows.Forms.TextBox
    Friend WithEvents KabupatenKotaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProvinsiTextBox As System.Windows.Forms.TextBox
    Friend WithEvents KodePosTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NegaraTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CatatanTextBox As System.Windows.Forms.TextBox
End Class
