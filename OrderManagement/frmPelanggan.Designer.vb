<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPelanggan
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
        Dim NamaPerusahaanLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPelanggan))
        Dim NamaLengkapLabel As System.Windows.Forms.Label
        Dim JabatanLabel As System.Windows.Forms.Label
        Dim NomorTeleponLabel As System.Windows.Forms.Label
        Dim NomorFaxLabel As System.Windows.Forms.Label
        Dim HandPhoneLabel As System.Windows.Forms.Label
        Dim NomorTeleponRumahLabel As System.Windows.Forms.Label
        Dim AlamatLabel As System.Windows.Forms.Label
        Dim KabupatenKotaLabel As System.Windows.Forms.Label
        Dim ProvinsiLabel As System.Windows.Forms.Label
        Dim KodePosLabel As System.Windows.Forms.Label
        Dim NegaraLabel As System.Windows.Forms.Label
        Dim WebsiteLabel As System.Windows.Forms.Label
        Me.spcPelanggan = New System.Windows.Forms.SplitContainer()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.tbcKaryawan = New System.Windows.Forms.TabControl()
        Me.TabPageData = New System.Windows.Forms.TabPage()
        Me.NamaPerusahaanTextBox = New System.Windows.Forms.TextBox()
        Me.PelangganBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QuotationDataDataSet = New SalesQuoteManagement.QuotationDataDataSet()
        Me.TabPageDaftar = New System.Windows.Forms.TabPage()
        Me.PelangganDataGridView = New System.Windows.Forms.DataGridView()
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
        Me.PelangganTableAdapter = New SalesQuoteManagement.QuotationDataDataSetTableAdapters.PelangganTableAdapter()
        Me.TableAdapterManager = New SalesQuoteManagement.QuotationDataDataSetTableAdapters.TableAdapterManager()
        Me.PelangganBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
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
        Me.PelangganBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.NamaLengkapTextBox = New System.Windows.Forms.TextBox()
        Me.JabatanTextBox = New System.Windows.Forms.TextBox()
        Me.NomorTeleponTextBox = New System.Windows.Forms.TextBox()
        Me.NomorFaxTextBox = New System.Windows.Forms.TextBox()
        Me.HandPhoneTextBox = New System.Windows.Forms.TextBox()
        Me.NomorTeleponRumahTextBox = New System.Windows.Forms.TextBox()
        Me.gboxAlamat = New System.Windows.Forms.GroupBox()
        Me.AlamatTextBox = New System.Windows.Forms.TextBox()
        Me.KabupatenKotaTextBox = New System.Windows.Forms.TextBox()
        Me.ProvinsiTextBox = New System.Windows.Forms.TextBox()
        Me.KodePosTextBox = New System.Windows.Forms.TextBox()
        Me.NegaraTextBox = New System.Windows.Forms.TextBox()
        Me.WebsiteTextBox = New System.Windows.Forms.TextBox()
        Me.gBoxctatan = New System.Windows.Forms.GroupBox()
        Me.lblTemail = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.CatatanTextBox = New System.Windows.Forms.TextBox()
        NamaPerusahaanLabel = New System.Windows.Forms.Label()
        NamaLengkapLabel = New System.Windows.Forms.Label()
        JabatanLabel = New System.Windows.Forms.Label()
        NomorTeleponLabel = New System.Windows.Forms.Label()
        NomorFaxLabel = New System.Windows.Forms.Label()
        HandPhoneLabel = New System.Windows.Forms.Label()
        NomorTeleponRumahLabel = New System.Windows.Forms.Label()
        AlamatLabel = New System.Windows.Forms.Label()
        KabupatenKotaLabel = New System.Windows.Forms.Label()
        ProvinsiLabel = New System.Windows.Forms.Label()
        KodePosLabel = New System.Windows.Forms.Label()
        NegaraLabel = New System.Windows.Forms.Label()
        WebsiteLabel = New System.Windows.Forms.Label()
        CType(Me.spcPelanggan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spcPelanggan.Panel1.SuspendLayout()
        Me.spcPelanggan.Panel2.SuspendLayout()
        Me.spcPelanggan.SuspendLayout()
        Me.tbcKaryawan.SuspendLayout()
        Me.TabPageData.SuspendLayout()
        CType(Me.PelangganBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuotationDataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageDaftar.SuspendLayout()
        CType(Me.PelangganDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PelangganBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PelangganBindingNavigator.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gboxAlamat.SuspendLayout()
        Me.gBoxctatan.SuspendLayout()
        Me.SuspendLayout()
        '
        'NamaPerusahaanLabel
        '
        NamaPerusahaanLabel.AutoSize = True
        NamaPerusahaanLabel.Location = New System.Drawing.Point(18, 18)
        NamaPerusahaanLabel.Name = "NamaPerusahaanLabel"
        NamaPerusahaanLabel.Size = New System.Drawing.Size(98, 13)
        NamaPerusahaanLabel.TabIndex = 0
        NamaPerusahaanLabel.Text = "Nama Perusahaan:"
        '
        'spcPelanggan
        '
        Me.spcPelanggan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spcPelanggan.Location = New System.Drawing.Point(0, 0)
        Me.spcPelanggan.Name = "spcPelanggan"
        Me.spcPelanggan.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'spcPelanggan.Panel1
        '
        Me.spcPelanggan.Panel1.Controls.Add(Me.lblTitle)
        '
        'spcPelanggan.Panel2
        '
        Me.spcPelanggan.Panel2.Controls.Add(Me.tbcKaryawan)
        Me.spcPelanggan.Size = New System.Drawing.Size(619, 491)
        Me.spcPelanggan.SplitterDistance = 40
        Me.spcPelanggan.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(619, 40)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "DATA PELANGGAN"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbcKaryawan
        '
        Me.tbcKaryawan.Controls.Add(Me.TabPageData)
        Me.tbcKaryawan.Controls.Add(Me.TabPageDaftar)
        Me.tbcKaryawan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbcKaryawan.Location = New System.Drawing.Point(0, 0)
        Me.tbcKaryawan.Name = "tbcKaryawan"
        Me.tbcKaryawan.SelectedIndex = 0
        Me.tbcKaryawan.Size = New System.Drawing.Size(619, 447)
        Me.tbcKaryawan.TabIndex = 0
        '
        'TabPageData
        '
        Me.TabPageData.AutoScroll = True
        Me.TabPageData.Controls.Add(Me.TextBox1)
        Me.TabPageData.Controls.Add(Me.lblTemail)
        Me.TabPageData.Controls.Add(Me.gBoxctatan)
        Me.TabPageData.Controls.Add(WebsiteLabel)
        Me.TabPageData.Controls.Add(Me.WebsiteTextBox)
        Me.TabPageData.Controls.Add(Me.gboxAlamat)
        Me.TabPageData.Controls.Add(NomorFaxLabel)
        Me.TabPageData.Controls.Add(Me.NomorFaxTextBox)
        Me.TabPageData.Controls.Add(NomorTeleponLabel)
        Me.TabPageData.Controls.Add(Me.NomorTeleponTextBox)
        Me.TabPageData.Controls.Add(NamaPerusahaanLabel)
        Me.TabPageData.Controls.Add(Me.NamaPerusahaanTextBox)
        Me.TabPageData.Controls.Add(Me.GroupBox1)
        Me.TabPageData.Location = New System.Drawing.Point(4, 22)
        Me.TabPageData.Name = "TabPageData"
        Me.TabPageData.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageData.Size = New System.Drawing.Size(611, 421)
        Me.TabPageData.TabIndex = 0
        Me.TabPageData.Text = "Data Detail"
        Me.TabPageData.UseVisualStyleBackColor = True
        '
        'NamaPerusahaanTextBox
        '
        Me.NamaPerusahaanTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PelangganBindingSource, "NamaPerusahaan", True))
        Me.NamaPerusahaanTextBox.Location = New System.Drawing.Point(122, 15)
        Me.NamaPerusahaanTextBox.Name = "NamaPerusahaanTextBox"
        Me.NamaPerusahaanTextBox.Size = New System.Drawing.Size(244, 20)
        Me.NamaPerusahaanTextBox.TabIndex = 1
        '
        'PelangganBindingSource
        '
        Me.PelangganBindingSource.DataMember = "Pelanggan"
        Me.PelangganBindingSource.DataSource = Me.QuotationDataDataSet
        '
        'QuotationDataDataSet
        '
        Me.QuotationDataDataSet.DataSetName = "QuotationDataDataSet"
        Me.QuotationDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabPageDaftar
        '
        Me.TabPageDaftar.Controls.Add(Me.PelangganDataGridView)
        Me.TabPageDaftar.Location = New System.Drawing.Point(4, 22)
        Me.TabPageDaftar.Name = "TabPageDaftar"
        Me.TabPageDaftar.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageDaftar.Size = New System.Drawing.Size(611, 421)
        Me.TabPageDaftar.TabIndex = 1
        Me.TabPageDaftar.Text = "Daftar Pelanggan"
        Me.TabPageDaftar.UseVisualStyleBackColor = True
        '
        'PelangganDataGridView
        '
        Me.PelangganDataGridView.AutoGenerateColumns = False
        Me.PelangganDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PelangganDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15})
        Me.PelangganDataGridView.DataSource = Me.PelangganBindingSource
        Me.PelangganDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PelangganDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.PelangganDataGridView.Name = "PelangganDataGridView"
        Me.PelangganDataGridView.Size = New System.Drawing.Size(605, 415)
        Me.PelangganDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 20
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NamaPerusahaan"
        Me.DataGridViewTextBoxColumn2.HeaderText = "NamaPerusahaan"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "NamaLengkap"
        Me.DataGridViewTextBoxColumn3.HeaderText = "NamaLengkap"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Jabatan"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Jabatan"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "NomorTelepon"
        Me.DataGridViewTextBoxColumn5.HeaderText = "NomorTelepon"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "NomorFax"
        Me.DataGridViewTextBoxColumn6.HeaderText = "NomorFax"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "NomorTeleponRumah"
        Me.DataGridViewTextBoxColumn7.HeaderText = "NomorTeleponRumah"
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
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "website"
        Me.DataGridViewTextBoxColumn14.HeaderText = "website"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "catatan"
        Me.DataGridViewTextBoxColumn15.HeaderText = "catatan"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
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
        Me.TableAdapterManager.Quotation_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.SupplierTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SalesQuoteManagement.QuotationDataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PelangganBindingNavigator
        '
        Me.PelangganBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PelangganBindingNavigator.BindingSource = Me.PelangganBindingSource
        Me.PelangganBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PelangganBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PelangganBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PelangganBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PelangganBindingNavigatorSaveItem})
        Me.PelangganBindingNavigator.Location = New System.Drawing.Point(0, 466)
        Me.PelangganBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PelangganBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PelangganBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PelangganBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PelangganBindingNavigator.Name = "PelangganBindingNavigator"
        Me.PelangganBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PelangganBindingNavigator.Size = New System.Drawing.Size(619, 25)
        Me.PelangganBindingNavigator.TabIndex = 1
        Me.PelangganBindingNavigator.Text = "BindingNavigator1"
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
        'PelangganBindingNavigatorSaveItem
        '
        Me.PelangganBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PelangganBindingNavigatorSaveItem.Image = CType(resources.GetObject("PelangganBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PelangganBindingNavigatorSaveItem.Name = "PelangganBindingNavigatorSaveItem"
        Me.PelangganBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PelangganBindingNavigatorSaveItem.Text = "Save Data"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(NomorTeleponRumahLabel)
        Me.GroupBox1.Controls.Add(Me.NomorTeleponRumahTextBox)
        Me.GroupBox1.Controls.Add(HandPhoneLabel)
        Me.GroupBox1.Controls.Add(Me.HandPhoneTextBox)
        Me.GroupBox1.Controls.Add(JabatanLabel)
        Me.GroupBox1.Controls.Add(Me.JabatanTextBox)
        Me.GroupBox1.Controls.Add(NamaLengkapLabel)
        Me.GroupBox1.Controls.Add(Me.NamaLengkapTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(313, 119)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Contact Person"
        '
        'NamaLengkapLabel
        '
        NamaLengkapLabel.AutoSize = True
        NamaLengkapLabel.Location = New System.Drawing.Point(12, 16)
        NamaLengkapLabel.Name = "NamaLengkapLabel"
        NamaLengkapLabel.Size = New System.Drawing.Size(83, 13)
        NamaLengkapLabel.TabIndex = 0
        NamaLengkapLabel.Text = "Nama Lengkap:"
        '
        'NamaLengkapTextBox
        '
        Me.NamaLengkapTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PelangganBindingSource, "NamaLengkap", True))
        Me.NamaLengkapTextBox.Location = New System.Drawing.Point(101, 13)
        Me.NamaLengkapTextBox.Name = "NamaLengkapTextBox"
        Me.NamaLengkapTextBox.Size = New System.Drawing.Size(205, 20)
        Me.NamaLengkapTextBox.TabIndex = 1
        '
        'JabatanLabel
        '
        JabatanLabel.AutoSize = True
        JabatanLabel.Location = New System.Drawing.Point(47, 42)
        JabatanLabel.Name = "JabatanLabel"
        JabatanLabel.Size = New System.Drawing.Size(48, 13)
        JabatanLabel.TabIndex = 2
        JabatanLabel.Text = "Jabatan:"
        '
        'JabatanTextBox
        '
        Me.JabatanTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PelangganBindingSource, "Jabatan", True))
        Me.JabatanTextBox.Location = New System.Drawing.Point(101, 39)
        Me.JabatanTextBox.Name = "JabatanTextBox"
        Me.JabatanTextBox.Size = New System.Drawing.Size(205, 20)
        Me.JabatanTextBox.TabIndex = 3
        '
        'NomorTeleponLabel
        '
        NomorTeleponLabel.AutoSize = True
        NomorTeleponLabel.Location = New System.Drawing.Point(367, 55)
        NomorTeleponLabel.Name = "NomorTeleponLabel"
        NomorTeleponLabel.Size = New System.Drawing.Size(83, 13)
        NomorTeleponLabel.TabIndex = 4
        NomorTeleponLabel.Text = "Nomor Telepon:"
        '
        'NomorTeleponTextBox
        '
        Me.NomorTeleponTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PelangganBindingSource, "NomorTelepon", True))
        Me.NomorTeleponTextBox.Location = New System.Drawing.Point(455, 52)
        Me.NomorTeleponTextBox.Name = "NomorTeleponTextBox"
        Me.NomorTeleponTextBox.Size = New System.Drawing.Size(133, 20)
        Me.NomorTeleponTextBox.TabIndex = 5
        '
        'NomorFaxLabel
        '
        NomorFaxLabel.AutoSize = True
        NomorFaxLabel.Location = New System.Drawing.Point(387, 84)
        NomorFaxLabel.Name = "NomorFaxLabel"
        NomorFaxLabel.Size = New System.Drawing.Size(61, 13)
        NomorFaxLabel.TabIndex = 5
        NomorFaxLabel.Text = "Nomor Fax:"
        '
        'NomorFaxTextBox
        '
        Me.NomorFaxTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PelangganBindingSource, "NomorFax", True))
        Me.NomorFaxTextBox.Location = New System.Drawing.Point(454, 81)
        Me.NomorFaxTextBox.Name = "NomorFaxTextBox"
        Me.NomorFaxTextBox.Size = New System.Drawing.Size(134, 20)
        Me.NomorFaxTextBox.TabIndex = 6
        '
        'HandPhoneLabel
        '
        HandPhoneLabel.AutoSize = True
        HandPhoneLabel.Location = New System.Drawing.Point(25, 68)
        HandPhoneLabel.Name = "HandPhoneLabel"
        HandPhoneLabel.Size = New System.Drawing.Size(70, 13)
        HandPhoneLabel.TabIndex = 4
        HandPhoneLabel.Text = "Hand Phone:"
        '
        'HandPhoneTextBox
        '
        Me.HandPhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PelangganBindingSource, "HandPhone", True))
        Me.HandPhoneTextBox.Location = New System.Drawing.Point(101, 65)
        Me.HandPhoneTextBox.Name = "HandPhoneTextBox"
        Me.HandPhoneTextBox.Size = New System.Drawing.Size(151, 20)
        Me.HandPhoneTextBox.TabIndex = 5
        '
        'NomorTeleponRumahLabel
        '
        NomorTeleponRumahLabel.AutoSize = True
        NomorTeleponRumahLabel.Location = New System.Drawing.Point(9, 94)
        NomorTeleponRumahLabel.Name = "NomorTeleponRumahLabel"
        NomorTeleponRumahLabel.Size = New System.Drawing.Size(86, 13)
        NomorTeleponRumahLabel.TabIndex = 6
        NomorTeleponRumahLabel.Text = "Telepon Rumah:"
        '
        'NomorTeleponRumahTextBox
        '
        Me.NomorTeleponRumahTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PelangganBindingSource, "NomorTeleponRumah", True))
        Me.NomorTeleponRumahTextBox.Location = New System.Drawing.Point(101, 91)
        Me.NomorTeleponRumahTextBox.Name = "NomorTeleponRumahTextBox"
        Me.NomorTeleponRumahTextBox.Size = New System.Drawing.Size(151, 20)
        Me.NomorTeleponRumahTextBox.TabIndex = 7
        '
        'gboxAlamat
        '
        Me.gboxAlamat.Controls.Add(NegaraLabel)
        Me.gboxAlamat.Controls.Add(Me.NegaraTextBox)
        Me.gboxAlamat.Controls.Add(KodePosLabel)
        Me.gboxAlamat.Controls.Add(Me.KodePosTextBox)
        Me.gboxAlamat.Controls.Add(ProvinsiLabel)
        Me.gboxAlamat.Controls.Add(Me.ProvinsiTextBox)
        Me.gboxAlamat.Controls.Add(KabupatenKotaLabel)
        Me.gboxAlamat.Controls.Add(Me.KabupatenKotaTextBox)
        Me.gboxAlamat.Controls.Add(AlamatLabel)
        Me.gboxAlamat.Controls.Add(Me.AlamatTextBox)
        Me.gboxAlamat.Location = New System.Drawing.Point(24, 168)
        Me.gboxAlamat.Name = "gboxAlamat"
        Me.gboxAlamat.Size = New System.Drawing.Size(584, 104)
        Me.gboxAlamat.TabIndex = 7
        Me.gboxAlamat.TabStop = False
        Me.gboxAlamat.Text = "Alamat"
        '
        'AlamatLabel
        '
        AlamatLabel.AutoSize = True
        AlamatLabel.Location = New System.Drawing.Point(53, 22)
        AlamatLabel.Name = "AlamatLabel"
        AlamatLabel.Size = New System.Drawing.Size(42, 13)
        AlamatLabel.TabIndex = 0
        AlamatLabel.Text = "Alamat:"
        '
        'AlamatTextBox
        '
        Me.AlamatTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PelangganBindingSource, "Alamat", True))
        Me.AlamatTextBox.Location = New System.Drawing.Point(101, 19)
        Me.AlamatTextBox.Name = "AlamatTextBox"
        Me.AlamatTextBox.Size = New System.Drawing.Size(463, 20)
        Me.AlamatTextBox.TabIndex = 1
        '
        'KabupatenKotaLabel
        '
        KabupatenKotaLabel.AutoSize = True
        KabupatenKotaLabel.Location = New System.Drawing.Point(8, 48)
        KabupatenKotaLabel.Name = "KabupatenKotaLabel"
        KabupatenKotaLabel.Size = New System.Drawing.Size(87, 13)
        KabupatenKotaLabel.TabIndex = 2
        KabupatenKotaLabel.Text = "Kabupaten Kota:"
        '
        'KabupatenKotaTextBox
        '
        Me.KabupatenKotaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PelangganBindingSource, "KabupatenKota", True))
        Me.KabupatenKotaTextBox.Location = New System.Drawing.Point(101, 45)
        Me.KabupatenKotaTextBox.Name = "KabupatenKotaTextBox"
        Me.KabupatenKotaTextBox.Size = New System.Drawing.Size(244, 20)
        Me.KabupatenKotaTextBox.TabIndex = 3
        '
        'ProvinsiLabel
        '
        ProvinsiLabel.AutoSize = True
        ProvinsiLabel.Location = New System.Drawing.Point(48, 74)
        ProvinsiLabel.Name = "ProvinsiLabel"
        ProvinsiLabel.Size = New System.Drawing.Size(47, 13)
        ProvinsiLabel.TabIndex = 4
        ProvinsiLabel.Text = "Provinsi:"
        '
        'ProvinsiTextBox
        '
        Me.ProvinsiTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PelangganBindingSource, "Provinsi", True))
        Me.ProvinsiTextBox.Location = New System.Drawing.Point(101, 71)
        Me.ProvinsiTextBox.Name = "ProvinsiTextBox"
        Me.ProvinsiTextBox.Size = New System.Drawing.Size(244, 20)
        Me.ProvinsiTextBox.TabIndex = 5
        '
        'KodePosLabel
        '
        KodePosLabel.AutoSize = True
        KodePosLabel.Location = New System.Drawing.Point(403, 48)
        KodePosLabel.Name = "KodePosLabel"
        KodePosLabel.Size = New System.Drawing.Size(55, 13)
        KodePosLabel.TabIndex = 6
        KodePosLabel.Text = "kode Pos:"
        '
        'KodePosTextBox
        '
        Me.KodePosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PelangganBindingSource, "kodePos", True))
        Me.KodePosTextBox.Location = New System.Drawing.Point(464, 45)
        Me.KodePosTextBox.Name = "KodePosTextBox"
        Me.KodePosTextBox.Size = New System.Drawing.Size(100, 20)
        Me.KodePosTextBox.TabIndex = 7
        '
        'NegaraLabel
        '
        NegaraLabel.AutoSize = True
        NegaraLabel.Location = New System.Drawing.Point(355, 77)
        NegaraLabel.Name = "NegaraLabel"
        NegaraLabel.Size = New System.Drawing.Size(45, 13)
        NegaraLabel.TabIndex = 8
        NegaraLabel.Text = "Negara:"
        '
        'NegaraTextBox
        '
        Me.NegaraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PelangganBindingSource, "Negara", True))
        Me.NegaraTextBox.Location = New System.Drawing.Point(406, 74)
        Me.NegaraTextBox.Name = "NegaraTextBox"
        Me.NegaraTextBox.Size = New System.Drawing.Size(158, 20)
        Me.NegaraTextBox.TabIndex = 9
        '
        'WebsiteLabel
        '
        WebsiteLabel.AutoSize = True
        WebsiteLabel.Location = New System.Drawing.Point(402, 110)
        WebsiteLabel.Name = "WebsiteLabel"
        WebsiteLabel.Size = New System.Drawing.Size(46, 13)
        WebsiteLabel.TabIndex = 8
        WebsiteLabel.Text = "website:"
        '
        'WebsiteTextBox
        '
        Me.WebsiteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PelangganBindingSource, "website", True))
        Me.WebsiteTextBox.Location = New System.Drawing.Point(454, 107)
        Me.WebsiteTextBox.Name = "WebsiteTextBox"
        Me.WebsiteTextBox.Size = New System.Drawing.Size(134, 20)
        Me.WebsiteTextBox.TabIndex = 9
        '
        'gBoxctatan
        '
        Me.gBoxctatan.Controls.Add(Me.CatatanTextBox)
        Me.gBoxctatan.Location = New System.Drawing.Point(21, 278)
        Me.gBoxctatan.Name = "gBoxctatan"
        Me.gBoxctatan.Size = New System.Drawing.Size(564, 111)
        Me.gBoxctatan.TabIndex = 10
        Me.gBoxctatan.TabStop = False
        Me.gBoxctatan.Text = "Catatan"
        '
        'lblTemail
        '
        Me.lblTemail.AutoSize = True
        Me.lblTemail.Location = New System.Drawing.Point(411, 140)
        Me.lblTemail.Name = "lblTemail"
        Me.lblTemail.Size = New System.Drawing.Size(31, 13)
        Me.lblTemail.TabIndex = 11
        Me.lblTemail.Text = "email"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(454, 137)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(134, 20)
        Me.TextBox1.TabIndex = 14
        '
        'CatatanTextBox
        '
        Me.CatatanTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PelangganBindingSource, "catatan", True))
        Me.CatatanTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CatatanTextBox.Location = New System.Drawing.Point(3, 16)
        Me.CatatanTextBox.Multiline = True
        Me.CatatanTextBox.Name = "CatatanTextBox"
        Me.CatatanTextBox.Size = New System.Drawing.Size(558, 92)
        Me.CatatanTextBox.TabIndex = 1
        '
        'frmPelanggan
        '
        Me.ClientSize = New System.Drawing.Size(619, 491)
        Me.Controls.Add(Me.PelangganBindingNavigator)
        Me.Controls.Add(Me.spcPelanggan)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPelanggan"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Data Pelanggan"
        Me.spcPelanggan.Panel1.ResumeLayout(False)
        Me.spcPelanggan.Panel2.ResumeLayout(False)
        CType(Me.spcPelanggan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spcPelanggan.ResumeLayout(False)
        Me.tbcKaryawan.ResumeLayout(False)
        Me.TabPageData.ResumeLayout(False)
        Me.TabPageData.PerformLayout()
        CType(Me.PelangganBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuotationDataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageDaftar.ResumeLayout(False)
        CType(Me.PelangganDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PelangganBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PelangganBindingNavigator.ResumeLayout(False)
        Me.PelangganBindingNavigator.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gboxAlamat.ResumeLayout(False)
        Me.gboxAlamat.PerformLayout()
        Me.gBoxctatan.ResumeLayout(False)
        Me.gBoxctatan.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents spcKaryawan As System.Windows.Forms.SplitContainer
    Friend WithEvents spcPelanggan As System.Windows.Forms.SplitContainer
    Friend WithEvents tbcKaryawan As System.Windows.Forms.TabControl
    Friend WithEvents TabPageData As System.Windows.Forms.TabPage
    Friend WithEvents TabPageDaftar As System.Windows.Forms.TabPage
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents QuotationDataDataSet As SalesQuoteManagement.QuotationDataDataSet
    Friend WithEvents PelangganBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PelangganTableAdapter As SalesQuoteManagement.QuotationDataDataSetTableAdapters.PelangganTableAdapter
    Friend WithEvents TableAdapterManager As SalesQuoteManagement.QuotationDataDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PelangganBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents PelangganBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents PelangganDataGridView As System.Windows.Forms.DataGridView
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
    Friend WithEvents NamaPerusahaanTextBox As System.Windows.Forms.TextBox
    Friend WithEvents gBoxctatan As System.Windows.Forms.GroupBox
    Friend WithEvents WebsiteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents gboxAlamat As System.Windows.Forms.GroupBox
    Friend WithEvents NegaraTextBox As System.Windows.Forms.TextBox
    Friend WithEvents KodePosTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProvinsiTextBox As System.Windows.Forms.TextBox
    Friend WithEvents KabupatenKotaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AlamatTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NomorFaxTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents NomorTeleponRumahTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HandPhoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents JabatanTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NamaLengkapTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NomorTeleponTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents lblTemail As System.Windows.Forms.Label
    Friend WithEvents CatatanTextBox As System.Windows.Forms.TextBox
End Class
