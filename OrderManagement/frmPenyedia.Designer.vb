<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPenyedia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPenyedia))
        Dim NamaPerusahaanLabel As System.Windows.Forms.Label
        Dim NamaLengkapLabel As System.Windows.Forms.Label
        Dim JabatanLabel As System.Windows.Forms.Label
        Dim NomorTeleponLabel As System.Windows.Forms.Label
        Dim NomorFaxLabel As System.Windows.Forms.Label
        Dim NomorTeleponRumahLabel As System.Windows.Forms.Label
        Dim HandPhoneLabel As System.Windows.Forms.Label
        Dim AlamatLabel As System.Windows.Forms.Label
        Dim KabupatenKotaLabel As System.Windows.Forms.Label
        Dim ProvinsiLabel As System.Windows.Forms.Label
        Dim KodePosLabel As System.Windows.Forms.Label
        Dim NegaraLabel As System.Windows.Forms.Label
        Dim WebsiteLabel As System.Windows.Forms.Label
        Dim CatatanLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Me.spcPenyedia = New System.Windows.Forms.SplitContainer()
        Me.lblTPenyedia = New System.Windows.Forms.Label()
        Me.tbcPenyedia = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.QuotationDataDataSet = New SalesQuoteManagement.QuotationDataDataSet()
        Me.SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SupplierTableAdapter = New SalesQuoteManagement.QuotationDataDataSetTableAdapters.SupplierTableAdapter()
        Me.TableAdapterManager = New SalesQuoteManagement.QuotationDataDataSetTableAdapters.TableAdapterManager()
        Me.SupplierBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.SupplierBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.NamaPerusahaanTextBox = New System.Windows.Forms.TextBox()
        Me.NamaLengkapTextBox = New System.Windows.Forms.TextBox()
        Me.JabatanTextBox = New System.Windows.Forms.TextBox()
        Me.NomorTeleponTextBox = New System.Windows.Forms.TextBox()
        Me.NomorFaxTextBox = New System.Windows.Forms.TextBox()
        Me.NomorTeleponRumahTextBox = New System.Windows.Forms.TextBox()
        Me.HandPhoneTextBox = New System.Windows.Forms.TextBox()
        Me.AlamatTextBox = New System.Windows.Forms.TextBox()
        Me.KabupatenKotaTextBox = New System.Windows.Forms.TextBox()
        Me.ProvinsiTextBox = New System.Windows.Forms.TextBox()
        Me.KodePosTextBox = New System.Windows.Forms.TextBox()
        Me.NegaraTextBox = New System.Windows.Forms.TextBox()
        Me.WebsiteTextBox = New System.Windows.Forms.TextBox()
        Me.CatatanTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.gBoxAlamat = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SupplierDataGridView = New System.Windows.Forms.DataGridView()
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
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        NamaPerusahaanLabel = New System.Windows.Forms.Label()
        NamaLengkapLabel = New System.Windows.Forms.Label()
        JabatanLabel = New System.Windows.Forms.Label()
        NomorTeleponLabel = New System.Windows.Forms.Label()
        NomorFaxLabel = New System.Windows.Forms.Label()
        NomorTeleponRumahLabel = New System.Windows.Forms.Label()
        HandPhoneLabel = New System.Windows.Forms.Label()
        AlamatLabel = New System.Windows.Forms.Label()
        KabupatenKotaLabel = New System.Windows.Forms.Label()
        ProvinsiLabel = New System.Windows.Forms.Label()
        KodePosLabel = New System.Windows.Forms.Label()
        NegaraLabel = New System.Windows.Forms.Label()
        WebsiteLabel = New System.Windows.Forms.Label()
        CatatanLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        CType(Me.spcPenyedia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spcPenyedia.Panel1.SuspendLayout()
        Me.spcPenyedia.Panel2.SuspendLayout()
        Me.spcPenyedia.SuspendLayout()
        Me.tbcPenyedia.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.QuotationDataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SupplierBindingNavigator.SuspendLayout()
        Me.gBoxAlamat.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SupplierDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'spcPenyedia
        '
        Me.spcPenyedia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spcPenyedia.Location = New System.Drawing.Point(0, 0)
        Me.spcPenyedia.Name = "spcPenyedia"
        Me.spcPenyedia.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'spcPenyedia.Panel1
        '
        Me.spcPenyedia.Panel1.Controls.Add(Me.lblTPenyedia)
        '
        'spcPenyedia.Panel2
        '
        Me.spcPenyedia.Panel2.Controls.Add(Me.tbcPenyedia)
        Me.spcPenyedia.Size = New System.Drawing.Size(619, 516)
        Me.spcPenyedia.SplitterDistance = 42
        Me.spcPenyedia.TabIndex = 0
        '
        'lblTPenyedia
        '
        Me.lblTPenyedia.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTPenyedia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTPenyedia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTPenyedia.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblTPenyedia.Location = New System.Drawing.Point(0, 0)
        Me.lblTPenyedia.Name = "lblTPenyedia"
        Me.lblTPenyedia.Size = New System.Drawing.Size(619, 42)
        Me.lblTPenyedia.TabIndex = 0
        Me.lblTPenyedia.Text = "DATA PENYEDIA BARANG"
        Me.lblTPenyedia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbcPenyedia
        '
        Me.tbcPenyedia.Controls.Add(Me.TabPage2)
        Me.tbcPenyedia.Controls.Add(Me.TabPage1)
        Me.tbcPenyedia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbcPenyedia.Location = New System.Drawing.Point(0, 0)
        Me.tbcPenyedia.Name = "tbcPenyedia"
        Me.tbcPenyedia.SelectedIndex = 0
        Me.tbcPenyedia.Size = New System.Drawing.Size(619, 470)
        Me.tbcPenyedia.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.SupplierDataGridView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(611, 444)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Daftar Penyedia"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(CatatanLabel)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Controls.Add(Me.gBoxAlamat)
        Me.TabPage2.Controls.Add(NamaPerusahaanLabel)
        Me.TabPage2.Controls.Add(Me.NamaPerusahaanTextBox)
        Me.TabPage2.Controls.Add(NomorTeleponLabel)
        Me.TabPage2.Controls.Add(Me.NomorTeleponTextBox)
        Me.TabPage2.Controls.Add(NomorFaxLabel)
        Me.TabPage2.Controls.Add(Me.NomorFaxTextBox)
        Me.TabPage2.Controls.Add(WebsiteLabel)
        Me.TabPage2.Controls.Add(Me.WebsiteTextBox)
        Me.TabPage2.Controls.Add(Me.CatatanTextBox)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(611, 421)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Data Detail"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'QuotationDataDataSet
        '
        Me.QuotationDataDataSet.DataSetName = "QuotationDataDataSet"
        Me.QuotationDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SupplierBindingSource
        '
        Me.SupplierBindingSource.DataMember = "Supplier"
        Me.SupplierBindingSource.DataSource = Me.QuotationDataDataSet
        '
        'SupplierTableAdapter
        '
        Me.SupplierTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.karyawanTableAdapter = Nothing
        Me.TableAdapterManager.PelangganTableAdapter = Nothing
        Me.TableAdapterManager.ProdukTableAdapter = Nothing
        Me.TableAdapterManager.ProyekTableAdapter = Nothing
        Me.TableAdapterManager.Quotation_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.SupplierTableAdapter = Me.SupplierTableAdapter
        Me.TableAdapterManager.UpdateOrder = SalesQuoteManagement.QuotationDataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SupplierBindingNavigator
        '
        Me.SupplierBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.SupplierBindingNavigator.BindingSource = Me.SupplierBindingSource
        Me.SupplierBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SupplierBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.SupplierBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SupplierBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SupplierBindingNavigatorSaveItem})
        Me.SupplierBindingNavigator.Location = New System.Drawing.Point(0, 491)
        Me.SupplierBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.SupplierBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.SupplierBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.SupplierBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.SupplierBindingNavigator.Name = "SupplierBindingNavigator"
        Me.SupplierBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.SupplierBindingNavigator.Size = New System.Drawing.Size(619, 25)
        Me.SupplierBindingNavigator.TabIndex = 1
        Me.SupplierBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'SupplierBindingNavigatorSaveItem
        '
        Me.SupplierBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SupplierBindingNavigatorSaveItem.Image = CType(resources.GetObject("SupplierBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SupplierBindingNavigatorSaveItem.Name = "SupplierBindingNavigatorSaveItem"
        Me.SupplierBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.SupplierBindingNavigatorSaveItem.Text = "Save Data"
        '
        'NamaPerusahaanLabel
        '
        NamaPerusahaanLabel.AutoSize = True
        NamaPerusahaanLabel.Location = New System.Drawing.Point(8, 20)
        NamaPerusahaanLabel.Name = "NamaPerusahaanLabel"
        NamaPerusahaanLabel.Size = New System.Drawing.Size(98, 13)
        NamaPerusahaanLabel.TabIndex = 2
        NamaPerusahaanLabel.Text = "Nama Perusahaan:"
        '
        'NamaPerusahaanTextBox
        '
        Me.NamaPerusahaanTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "NamaPerusahaan", True))
        Me.NamaPerusahaanTextBox.Location = New System.Drawing.Point(107, 20)
        Me.NamaPerusahaanTextBox.Name = "NamaPerusahaanTextBox"
        Me.NamaPerusahaanTextBox.Size = New System.Drawing.Size(246, 20)
        Me.NamaPerusahaanTextBox.TabIndex = 3
        '
        'NamaLengkapLabel
        '
        NamaLengkapLabel.AutoSize = True
        NamaLengkapLabel.Location = New System.Drawing.Point(16, 16)
        NamaLengkapLabel.Name = "NamaLengkapLabel"
        NamaLengkapLabel.Size = New System.Drawing.Size(83, 13)
        NamaLengkapLabel.TabIndex = 4
        NamaLengkapLabel.Text = "Nama Lengkap:"
        '
        'NamaLengkapTextBox
        '
        Me.NamaLengkapTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "NamaLengkap", True))
        Me.NamaLengkapTextBox.Location = New System.Drawing.Point(121, 13)
        Me.NamaLengkapTextBox.Name = "NamaLengkapTextBox"
        Me.NamaLengkapTextBox.Size = New System.Drawing.Size(246, 20)
        Me.NamaLengkapTextBox.TabIndex = 5
        '
        'JabatanLabel
        '
        JabatanLabel.AutoSize = True
        JabatanLabel.Location = New System.Drawing.Point(26, 47)
        JabatanLabel.Name = "JabatanLabel"
        JabatanLabel.Size = New System.Drawing.Size(48, 13)
        JabatanLabel.TabIndex = 6
        JabatanLabel.Text = "Jabatan:"
        '
        'JabatanTextBox
        '
        Me.JabatanTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "Jabatan", True))
        Me.JabatanTextBox.Location = New System.Drawing.Point(121, 43)
        Me.JabatanTextBox.Name = "JabatanTextBox"
        Me.JabatanTextBox.Size = New System.Drawing.Size(172, 20)
        Me.JabatanTextBox.TabIndex = 7
        '
        'NomorTeleponLabel
        '
        NomorTeleponLabel.AutoSize = True
        NomorTeleponLabel.Location = New System.Drawing.Point(393, 20)
        NomorTeleponLabel.Name = "NomorTeleponLabel"
        NomorTeleponLabel.Size = New System.Drawing.Size(83, 13)
        NomorTeleponLabel.TabIndex = 8
        NomorTeleponLabel.Text = "Nomor Telepon:"
        '
        'NomorTeleponTextBox
        '
        Me.NomorTeleponTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "NomorTelepon", True))
        Me.NomorTeleponTextBox.Location = New System.Drawing.Point(485, 17)
        Me.NomorTeleponTextBox.Name = "NomorTeleponTextBox"
        Me.NomorTeleponTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NomorTeleponTextBox.TabIndex = 9
        '
        'NomorFaxLabel
        '
        NomorFaxLabel.AutoSize = True
        NomorFaxLabel.Location = New System.Drawing.Point(406, 43)
        NomorFaxLabel.Name = "NomorFaxLabel"
        NomorFaxLabel.Size = New System.Drawing.Size(61, 13)
        NomorFaxLabel.TabIndex = 10
        NomorFaxLabel.Text = "Nomor Fax:"
        '
        'NomorFaxTextBox
        '
        Me.NomorFaxTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "NomorFax", True))
        Me.NomorFaxTextBox.Location = New System.Drawing.Point(485, 43)
        Me.NomorFaxTextBox.Name = "NomorFaxTextBox"
        Me.NomorFaxTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NomorFaxTextBox.TabIndex = 11
        '
        'NomorTeleponRumahLabel
        '
        NomorTeleponRumahLabel.AutoSize = True
        NomorTeleponRumahLabel.Location = New System.Drawing.Point(13, 106)
        NomorTeleponRumahLabel.Name = "NomorTeleponRumahLabel"
        NomorTeleponRumahLabel.Size = New System.Drawing.Size(86, 13)
        NomorTeleponRumahLabel.TabIndex = 12
        NomorTeleponRumahLabel.Text = "Telepon Rumah:"
        '
        'NomorTeleponRumahTextBox
        '
        Me.NomorTeleponRumahTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "NomorTeleponRumah", True))
        Me.NomorTeleponRumahTextBox.Location = New System.Drawing.Point(121, 73)
        Me.NomorTeleponRumahTextBox.Name = "NomorTeleponRumahTextBox"
        Me.NomorTeleponRumahTextBox.Size = New System.Drawing.Size(118, 20)
        Me.NomorTeleponRumahTextBox.TabIndex = 13
        '
        'HandPhoneLabel
        '
        HandPhoneLabel.AutoSize = True
        HandPhoneLabel.Location = New System.Drawing.Point(20, 76)
        HandPhoneLabel.Name = "HandPhoneLabel"
        HandPhoneLabel.Size = New System.Drawing.Size(70, 13)
        HandPhoneLabel.TabIndex = 14
        HandPhoneLabel.Text = "Hand Phone:"
        '
        'HandPhoneTextBox
        '
        Me.HandPhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "HandPhone", True))
        Me.HandPhoneTextBox.Location = New System.Drawing.Point(121, 103)
        Me.HandPhoneTextBox.Name = "HandPhoneTextBox"
        Me.HandPhoneTextBox.Size = New System.Drawing.Size(118, 20)
        Me.HandPhoneTextBox.TabIndex = 15
        '
        'AlamatLabel
        '
        AlamatLabel.AutoSize = True
        AlamatLabel.Location = New System.Drawing.Point(28, 22)
        AlamatLabel.Name = "AlamatLabel"
        AlamatLabel.Size = New System.Drawing.Size(42, 13)
        AlamatLabel.TabIndex = 16
        AlamatLabel.Text = "Alamat:"
        '
        'AlamatTextBox
        '
        Me.AlamatTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "Alamat", True))
        Me.AlamatTextBox.Location = New System.Drawing.Point(117, 19)
        Me.AlamatTextBox.Name = "AlamatTextBox"
        Me.AlamatTextBox.Size = New System.Drawing.Size(225, 20)
        Me.AlamatTextBox.TabIndex = 17
        '
        'KabupatenKotaLabel
        '
        KabupatenKotaLabel.AutoSize = True
        KabupatenKotaLabel.Location = New System.Drawing.Point(28, 48)
        KabupatenKotaLabel.Name = "KabupatenKotaLabel"
        KabupatenKotaLabel.Size = New System.Drawing.Size(87, 13)
        KabupatenKotaLabel.TabIndex = 18
        KabupatenKotaLabel.Text = "Kabupaten Kota:"
        '
        'KabupatenKotaTextBox
        '
        Me.KabupatenKotaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "KabupatenKota", True))
        Me.KabupatenKotaTextBox.Location = New System.Drawing.Point(117, 45)
        Me.KabupatenKotaTextBox.Name = "KabupatenKotaTextBox"
        Me.KabupatenKotaTextBox.Size = New System.Drawing.Size(225, 20)
        Me.KabupatenKotaTextBox.TabIndex = 19
        '
        'ProvinsiLabel
        '
        ProvinsiLabel.AutoSize = True
        ProvinsiLabel.Location = New System.Drawing.Point(28, 74)
        ProvinsiLabel.Name = "ProvinsiLabel"
        ProvinsiLabel.Size = New System.Drawing.Size(47, 13)
        ProvinsiLabel.TabIndex = 20
        ProvinsiLabel.Text = "Provinsi:"
        '
        'ProvinsiTextBox
        '
        Me.ProvinsiTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "Provinsi", True))
        Me.ProvinsiTextBox.Location = New System.Drawing.Point(117, 71)
        Me.ProvinsiTextBox.Name = "ProvinsiTextBox"
        Me.ProvinsiTextBox.Size = New System.Drawing.Size(225, 20)
        Me.ProvinsiTextBox.TabIndex = 21
        '
        'KodePosLabel
        '
        KodePosLabel.AutoSize = True
        KodePosLabel.Location = New System.Drawing.Point(28, 100)
        KodePosLabel.Name = "KodePosLabel"
        KodePosLabel.Size = New System.Drawing.Size(55, 13)
        KodePosLabel.TabIndex = 22
        KodePosLabel.Text = "kode Pos:"
        '
        'KodePosTextBox
        '
        Me.KodePosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "kodePos", True))
        Me.KodePosTextBox.Location = New System.Drawing.Point(117, 97)
        Me.KodePosTextBox.Name = "KodePosTextBox"
        Me.KodePosTextBox.Size = New System.Drawing.Size(225, 20)
        Me.KodePosTextBox.TabIndex = 23
        '
        'NegaraLabel
        '
        NegaraLabel.AutoSize = True
        NegaraLabel.Location = New System.Drawing.Point(28, 126)
        NegaraLabel.Name = "NegaraLabel"
        NegaraLabel.Size = New System.Drawing.Size(45, 13)
        NegaraLabel.TabIndex = 24
        NegaraLabel.Text = "Negara:"
        '
        'NegaraTextBox
        '
        Me.NegaraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "Negara", True))
        Me.NegaraTextBox.Location = New System.Drawing.Point(117, 123)
        Me.NegaraTextBox.Name = "NegaraTextBox"
        Me.NegaraTextBox.Size = New System.Drawing.Size(225, 20)
        Me.NegaraTextBox.TabIndex = 25
        '
        'WebsiteLabel
        '
        WebsiteLabel.AutoSize = True
        WebsiteLabel.Location = New System.Drawing.Point(418, 72)
        WebsiteLabel.Name = "WebsiteLabel"
        WebsiteLabel.Size = New System.Drawing.Size(46, 13)
        WebsiteLabel.TabIndex = 26
        WebsiteLabel.Text = "website:"
        '
        'WebsiteTextBox
        '
        Me.WebsiteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "website", True))
        Me.WebsiteTextBox.Location = New System.Drawing.Point(485, 69)
        Me.WebsiteTextBox.Name = "WebsiteTextBox"
        Me.WebsiteTextBox.Size = New System.Drawing.Size(100, 20)
        Me.WebsiteTextBox.TabIndex = 27
        '
        'CatatanLabel
        '
        CatatanLabel.AutoSize = True
        CatatanLabel.Location = New System.Drawing.Point(406, 189)
        CatatanLabel.Name = "CatatanLabel"
        CatatanLabel.Size = New System.Drawing.Size(46, 13)
        CatatanLabel.TabIndex = 28
        CatatanLabel.Text = "catatan:"
        '
        'CatatanTextBox
        '
        Me.CatatanTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "catatan", True))
        Me.CatatanTextBox.Location = New System.Drawing.Point(409, 208)
        Me.CatatanTextBox.Multiline = True
        Me.CatatanTextBox.Name = "CatatanTextBox"
        Me.CatatanTextBox.Size = New System.Drawing.Size(176, 156)
        Me.CatatanTextBox.TabIndex = 29
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(53, 133)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(34, 13)
        EmailLabel.TabIndex = 30
        EmailLabel.Text = "email:"
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SupplierBindingSource, "email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(121, 133)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(221, 20)
        Me.EmailTextBox.TabIndex = 31
        '
        'gBoxAlamat
        '
        Me.gBoxAlamat.Controls.Add(Me.AlamatTextBox)
        Me.gBoxAlamat.Controls.Add(Me.NegaraTextBox)
        Me.gBoxAlamat.Controls.Add(NegaraLabel)
        Me.gBoxAlamat.Controls.Add(Me.KodePosTextBox)
        Me.gBoxAlamat.Controls.Add(KodePosLabel)
        Me.gBoxAlamat.Controls.Add(Me.ProvinsiTextBox)
        Me.gBoxAlamat.Controls.Add(ProvinsiLabel)
        Me.gBoxAlamat.Controls.Add(Me.KabupatenKotaTextBox)
        Me.gBoxAlamat.Controls.Add(KabupatenKotaLabel)
        Me.gBoxAlamat.Controls.Add(AlamatLabel)
        Me.gBoxAlamat.Location = New System.Drawing.Point(11, 208)
        Me.gBoxAlamat.Name = "gBoxAlamat"
        Me.gBoxAlamat.Size = New System.Drawing.Size(374, 156)
        Me.gBoxAlamat.TabIndex = 32
        Me.gBoxAlamat.TabStop = False
        Me.gBoxAlamat.Text = "Alamat"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.NamaLengkapTextBox)
        Me.GroupBox1.Controls.Add(Me.EmailTextBox)
        Me.GroupBox1.Controls.Add(EmailLabel)
        Me.GroupBox1.Controls.Add(NamaLengkapLabel)
        Me.GroupBox1.Controls.Add(Me.HandPhoneTextBox)
        Me.GroupBox1.Controls.Add(HandPhoneLabel)
        Me.GroupBox1.Controls.Add(JabatanLabel)
        Me.GroupBox1.Controls.Add(Me.NomorTeleponRumahTextBox)
        Me.GroupBox1.Controls.Add(Me.JabatanTextBox)
        Me.GroupBox1.Controls.Add(NomorTeleponRumahLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(374, 158)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'SupplierDataGridView
        '
        Me.SupplierDataGridView.AutoGenerateColumns = False
        Me.SupplierDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SupplierDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16})
        Me.SupplierDataGridView.DataSource = Me.SupplierBindingSource
        Me.SupplierDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SupplierDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.SupplierDataGridView.Name = "SupplierDataGridView"
        Me.SupplierDataGridView.Size = New System.Drawing.Size(605, 438)
        Me.SupplierDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 25
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NamaPerusahaan"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Perusahaan"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "NamaLengkap"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Nama"
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
        Me.DataGridViewTextBoxColumn5.HeaderText = "Telepon"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "NomorFax"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Fax"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "NomorTeleponRumah"
        Me.DataGridViewTextBoxColumn7.HeaderText = "TeleponRumah"
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
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "email"
        Me.DataGridViewTextBoxColumn16.HeaderText = "email"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'frmPenyedia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 516)
        Me.Controls.Add(Me.SupplierBindingNavigator)
        Me.Controls.Add(Me.spcPenyedia)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPenyedia"
        Me.ShowIcon = False
        Me.Text = "Penyedia"
        Me.spcPenyedia.Panel1.ResumeLayout(False)
        Me.spcPenyedia.Panel2.ResumeLayout(False)
        CType(Me.spcPenyedia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spcPenyedia.ResumeLayout(False)
        Me.tbcPenyedia.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.QuotationDataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SupplierBindingNavigator.ResumeLayout(False)
        Me.SupplierBindingNavigator.PerformLayout()
        Me.gBoxAlamat.ResumeLayout(False)
        Me.gBoxAlamat.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.SupplierDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents spcPenyedia As System.Windows.Forms.SplitContainer
    Friend WithEvents lblTPenyedia As System.Windows.Forms.Label
    Friend WithEvents tbcPenyedia As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents QuotationDataDataSet As SalesQuoteManagement.QuotationDataDataSet
    Friend WithEvents SupplierBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SupplierTableAdapter As SalesQuoteManagement.QuotationDataDataSetTableAdapters.SupplierTableAdapter
    Friend WithEvents TableAdapterManager As SalesQuoteManagement.QuotationDataDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SupplierBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents SupplierBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents NamaLengkapTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HandPhoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NomorTeleponRumahTextBox As System.Windows.Forms.TextBox
    Friend WithEvents JabatanTextBox As System.Windows.Forms.TextBox
    Friend WithEvents gBoxAlamat As System.Windows.Forms.GroupBox
    Friend WithEvents AlamatTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NegaraTextBox As System.Windows.Forms.TextBox
    Friend WithEvents KodePosTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProvinsiTextBox As System.Windows.Forms.TextBox
    Friend WithEvents KabupatenKotaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NamaPerusahaanTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NomorTeleponTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NomorFaxTextBox As System.Windows.Forms.TextBox
    Friend WithEvents WebsiteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CatatanTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SupplierDataGridView As System.Windows.Forms.DataGridView
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
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
