<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBarang
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
        Dim IDProdukLabel As System.Windows.Forms.Label
        Dim SupplierIDLabel As System.Windows.Forms.Label
        Dim KodeProdukLabel As System.Windows.Forms.Label
        Dim ManufacturerBrandLabel As System.Windows.Forms.Label
        Dim CategoryLabel As System.Windows.Forms.Label
        Dim NamaProdukLabel As System.Windows.Forms.Label
        Dim HargaLabel As System.Windows.Forms.Label
        Dim KuantitasPerUnitLabel As System.Windows.Forms.Label
        Dim KeteranganLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBarang))
        Me.ProdukBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.ProdukBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.ProdukBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.spcBarang = New System.Windows.Forms.SplitContainer()
        Me.lblTProduk = New System.Windows.Forms.Label()
        Me.tbcProduk = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.IDProdukTextBox = New System.Windows.Forms.TextBox()
        Me.SupplierIDTextBox = New System.Windows.Forms.TextBox()
        Me.KodeProdukTextBox = New System.Windows.Forms.TextBox()
        Me.ManufacturerBrandTextBox = New System.Windows.Forms.TextBox()
        Me.CategoryTextBox = New System.Windows.Forms.TextBox()
        Me.NamaProdukTextBox = New System.Windows.Forms.TextBox()
        Me.HargaTextBox = New System.Windows.Forms.TextBox()
        Me.KuantitasPerUnitTextBox = New System.Windows.Forms.TextBox()
        Me.KeteranganTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ProdukDataGridView = New System.Windows.Forms.DataGridView()
        Me.ProdukTableAdapter = New SalesQuoteManagement.QuotationDataDataSetTableAdapters.ProdukTableAdapter()
        Me.TableAdapterManager = New SalesQuoteManagement.QuotationDataDataSetTableAdapters.TableAdapterManager()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        IDProdukLabel = New System.Windows.Forms.Label()
        SupplierIDLabel = New System.Windows.Forms.Label()
        KodeProdukLabel = New System.Windows.Forms.Label()
        ManufacturerBrandLabel = New System.Windows.Forms.Label()
        CategoryLabel = New System.Windows.Forms.Label()
        NamaProdukLabel = New System.Windows.Forms.Label()
        HargaLabel = New System.Windows.Forms.Label()
        KuantitasPerUnitLabel = New System.Windows.Forms.Label()
        KeteranganLabel = New System.Windows.Forms.Label()
        CType(Me.ProdukBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProdukBindingNavigator.SuspendLayout()
        CType(Me.ProdukBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuotationDataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spcBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spcBarang.Panel1.SuspendLayout()
        Me.spcBarang.Panel2.SuspendLayout()
        Me.spcBarang.SuspendLayout()
        Me.tbcProduk.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.ProdukDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDProdukLabel
        '
        IDProdukLabel.AutoSize = True
        IDProdukLabel.Location = New System.Drawing.Point(64, 29)
        IDProdukLabel.Name = "IDProdukLabel"
        IDProdukLabel.Size = New System.Drawing.Size(55, 13)
        IDProdukLabel.TabIndex = 0
        IDProdukLabel.Text = "IDProduk:"
        '
        'SupplierIDLabel
        '
        SupplierIDLabel.AutoSize = True
        SupplierIDLabel.Location = New System.Drawing.Point(64, 55)
        SupplierIDLabel.Name = "SupplierIDLabel"
        SupplierIDLabel.Size = New System.Drawing.Size(62, 13)
        SupplierIDLabel.TabIndex = 2
        SupplierIDLabel.Text = "Supplier ID:"
        '
        'KodeProdukLabel
        '
        KodeProdukLabel.AutoSize = True
        KodeProdukLabel.Location = New System.Drawing.Point(64, 81)
        KodeProdukLabel.Name = "KodeProdukLabel"
        KodeProdukLabel.Size = New System.Drawing.Size(72, 13)
        KodeProdukLabel.TabIndex = 4
        KodeProdukLabel.Text = "Kode Produk:"
        '
        'ManufacturerBrandLabel
        '
        ManufacturerBrandLabel.AutoSize = True
        ManufacturerBrandLabel.Location = New System.Drawing.Point(64, 107)
        ManufacturerBrandLabel.Name = "ManufacturerBrandLabel"
        ManufacturerBrandLabel.Size = New System.Drawing.Size(104, 13)
        ManufacturerBrandLabel.TabIndex = 6
        ManufacturerBrandLabel.Text = "Manufacturer Brand:"
        '
        'CategoryLabel
        '
        CategoryLabel.AutoSize = True
        CategoryLabel.Location = New System.Drawing.Point(64, 133)
        CategoryLabel.Name = "CategoryLabel"
        CategoryLabel.Size = New System.Drawing.Size(52, 13)
        CategoryLabel.TabIndex = 8
        CategoryLabel.Text = "Category:"
        '
        'NamaProdukLabel
        '
        NamaProdukLabel.AutoSize = True
        NamaProdukLabel.Location = New System.Drawing.Point(64, 159)
        NamaProdukLabel.Name = "NamaProdukLabel"
        NamaProdukLabel.Size = New System.Drawing.Size(75, 13)
        NamaProdukLabel.TabIndex = 10
        NamaProdukLabel.Text = "Nama Produk:"
        '
        'HargaLabel
        '
        HargaLabel.AutoSize = True
        HargaLabel.Location = New System.Drawing.Point(64, 185)
        HargaLabel.Name = "HargaLabel"
        HargaLabel.Size = New System.Drawing.Size(39, 13)
        HargaLabel.TabIndex = 12
        HargaLabel.Text = "Harga:"
        '
        'KuantitasPerUnitLabel
        '
        KuantitasPerUnitLabel.AutoSize = True
        KuantitasPerUnitLabel.Location = New System.Drawing.Point(64, 211)
        KuantitasPerUnitLabel.Name = "KuantitasPerUnitLabel"
        KuantitasPerUnitLabel.Size = New System.Drawing.Size(95, 13)
        KuantitasPerUnitLabel.TabIndex = 14
        KuantitasPerUnitLabel.Text = "Kuantitas Per Unit:"
        '
        'KeteranganLabel
        '
        KeteranganLabel.AutoSize = True
        KeteranganLabel.Location = New System.Drawing.Point(64, 237)
        KeteranganLabel.Name = "KeteranganLabel"
        KeteranganLabel.Size = New System.Drawing.Size(65, 13)
        KeteranganLabel.TabIndex = 16
        KeteranganLabel.Text = "Keterangan:"
        '
        'ProdukBindingNavigator
        '
        Me.ProdukBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ProdukBindingNavigator.BindingSource = Me.ProdukBindingSource
        Me.ProdukBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ProdukBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ProdukBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ProdukBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ProdukBindingNavigatorSaveItem})
        Me.ProdukBindingNavigator.Location = New System.Drawing.Point(0, 466)
        Me.ProdukBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ProdukBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ProdukBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ProdukBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ProdukBindingNavigator.Name = "ProdukBindingNavigator"
        Me.ProdukBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ProdukBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ProdukBindingNavigator.Size = New System.Drawing.Size(619, 25)
        Me.ProdukBindingNavigator.TabIndex = 0
        Me.ProdukBindingNavigator.Text = "BindingNavigator1"
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
        'ProdukBindingSource
        '
        Me.ProdukBindingSource.DataMember = "Produk"
        Me.ProdukBindingSource.DataSource = Me.QuotationDataDataSet
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
        'ProdukBindingNavigatorSaveItem
        '
        Me.ProdukBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ProdukBindingNavigatorSaveItem.Image = CType(resources.GetObject("ProdukBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ProdukBindingNavigatorSaveItem.Name = "ProdukBindingNavigatorSaveItem"
        Me.ProdukBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ProdukBindingNavigatorSaveItem.Text = "Save Data"
        '
        'spcBarang
        '
        Me.spcBarang.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spcBarang.Location = New System.Drawing.Point(0, 0)
        Me.spcBarang.Name = "spcBarang"
        Me.spcBarang.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'spcBarang.Panel1
        '
        Me.spcBarang.Panel1.Controls.Add(Me.btnClose)
        Me.spcBarang.Panel1.Controls.Add(Me.lblTProduk)
        '
        'spcBarang.Panel2
        '
        Me.spcBarang.Panel2.Controls.Add(Me.tbcProduk)
        Me.spcBarang.Size = New System.Drawing.Size(619, 466)
        Me.spcBarang.SplitterDistance = 40
        Me.spcBarang.TabIndex = 2
        '
        'lblTProduk
        '
        Me.lblTProduk.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblTProduk.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTProduk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTProduk.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTProduk.Location = New System.Drawing.Point(0, 0)
        Me.lblTProduk.Name = "lblTProduk"
        Me.lblTProduk.Size = New System.Drawing.Size(619, 40)
        Me.lblTProduk.TabIndex = 0
        Me.lblTProduk.Text = "DATA PRODUK"
        Me.lblTProduk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbcProduk
        '
        Me.tbcProduk.Controls.Add(Me.TabPage1)
        Me.tbcProduk.Controls.Add(Me.TabPage2)
        Me.tbcProduk.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbcProduk.Location = New System.Drawing.Point(0, 0)
        Me.tbcProduk.Name = "tbcProduk"
        Me.tbcProduk.SelectedIndex = 0
        Me.tbcProduk.Size = New System.Drawing.Size(619, 422)
        Me.tbcProduk.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(IDProdukLabel)
        Me.TabPage1.Controls.Add(Me.IDProdukTextBox)
        Me.TabPage1.Controls.Add(SupplierIDLabel)
        Me.TabPage1.Controls.Add(Me.SupplierIDTextBox)
        Me.TabPage1.Controls.Add(KodeProdukLabel)
        Me.TabPage1.Controls.Add(Me.KodeProdukTextBox)
        Me.TabPage1.Controls.Add(ManufacturerBrandLabel)
        Me.TabPage1.Controls.Add(Me.ManufacturerBrandTextBox)
        Me.TabPage1.Controls.Add(CategoryLabel)
        Me.TabPage1.Controls.Add(Me.CategoryTextBox)
        Me.TabPage1.Controls.Add(NamaProdukLabel)
        Me.TabPage1.Controls.Add(Me.NamaProdukTextBox)
        Me.TabPage1.Controls.Add(HargaLabel)
        Me.TabPage1.Controls.Add(Me.HargaTextBox)
        Me.TabPage1.Controls.Add(KuantitasPerUnitLabel)
        Me.TabPage1.Controls.Add(Me.KuantitasPerUnitTextBox)
        Me.TabPage1.Controls.Add(KeteranganLabel)
        Me.TabPage1.Controls.Add(Me.KeteranganTextBox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(611, 396)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Data Detail"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'IDProdukTextBox
        '
        Me.IDProdukTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProdukBindingSource, "IDProduk", True))
        Me.IDProdukTextBox.Location = New System.Drawing.Point(174, 26)
        Me.IDProdukTextBox.Name = "IDProdukTextBox"
        Me.IDProdukTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDProdukTextBox.TabIndex = 1
        '
        'SupplierIDTextBox
        '
        Me.SupplierIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProdukBindingSource, "SupplierID", True))
        Me.SupplierIDTextBox.Location = New System.Drawing.Point(174, 52)
        Me.SupplierIDTextBox.Name = "SupplierIDTextBox"
        Me.SupplierIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SupplierIDTextBox.TabIndex = 3
        '
        'KodeProdukTextBox
        '
        Me.KodeProdukTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProdukBindingSource, "KodeProduk", True))
        Me.KodeProdukTextBox.Location = New System.Drawing.Point(174, 78)
        Me.KodeProdukTextBox.Name = "KodeProdukTextBox"
        Me.KodeProdukTextBox.Size = New System.Drawing.Size(100, 20)
        Me.KodeProdukTextBox.TabIndex = 5
        '
        'ManufacturerBrandTextBox
        '
        Me.ManufacturerBrandTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProdukBindingSource, "ManufacturerBrand", True))
        Me.ManufacturerBrandTextBox.Location = New System.Drawing.Point(174, 104)
        Me.ManufacturerBrandTextBox.Name = "ManufacturerBrandTextBox"
        Me.ManufacturerBrandTextBox.Size = New System.Drawing.Size(207, 20)
        Me.ManufacturerBrandTextBox.TabIndex = 7
        '
        'CategoryTextBox
        '
        Me.CategoryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProdukBindingSource, "Category", True))
        Me.CategoryTextBox.Location = New System.Drawing.Point(174, 130)
        Me.CategoryTextBox.Name = "CategoryTextBox"
        Me.CategoryTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CategoryTextBox.TabIndex = 9
        '
        'NamaProdukTextBox
        '
        Me.NamaProdukTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProdukBindingSource, "NamaProduk", True))
        Me.NamaProdukTextBox.Location = New System.Drawing.Point(174, 156)
        Me.NamaProdukTextBox.Name = "NamaProdukTextBox"
        Me.NamaProdukTextBox.Size = New System.Drawing.Size(207, 20)
        Me.NamaProdukTextBox.TabIndex = 11
        '
        'HargaTextBox
        '
        Me.HargaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProdukBindingSource, "Harga", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "Rp #,##0"))
        Me.HargaTextBox.Location = New System.Drawing.Point(174, 182)
        Me.HargaTextBox.Name = "HargaTextBox"
        Me.HargaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.HargaTextBox.TabIndex = 13
        '
        'KuantitasPerUnitTextBox
        '
        Me.KuantitasPerUnitTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProdukBindingSource, "KuantitasPerUnit", True))
        Me.KuantitasPerUnitTextBox.Location = New System.Drawing.Point(174, 208)
        Me.KuantitasPerUnitTextBox.Name = "KuantitasPerUnitTextBox"
        Me.KuantitasPerUnitTextBox.Size = New System.Drawing.Size(207, 20)
        Me.KuantitasPerUnitTextBox.TabIndex = 15
        '
        'KeteranganTextBox
        '
        Me.KeteranganTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProdukBindingSource, "Keterangan", True))
        Me.KeteranganTextBox.Location = New System.Drawing.Point(174, 234)
        Me.KeteranganTextBox.Multiline = True
        Me.KeteranganTextBox.Name = "KeteranganTextBox"
        Me.KeteranganTextBox.Size = New System.Drawing.Size(207, 135)
        Me.KeteranganTextBox.TabIndex = 17
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ProdukDataGridView)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(611, 396)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Daftar Produk"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ProdukDataGridView
        '
        Me.ProdukDataGridView.AutoGenerateColumns = False
        Me.ProdukDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ProdukDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProdukDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.ProdukDataGridView.DataSource = Me.ProdukBindingSource
        Me.ProdukDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProdukDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.ProdukDataGridView.Name = "ProdukDataGridView"
        Me.ProdukDataGridView.Size = New System.Drawing.Size(605, 390)
        Me.ProdukDataGridView.TabIndex = 0
        '
        'ProdukTableAdapter
        '
        Me.ProdukTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.karyawanTableAdapter = Nothing
        Me.TableAdapterManager.PelangganTableAdapter = Nothing
        Me.TableAdapterManager.ProdukTableAdapter = Me.ProdukTableAdapter
        Me.TableAdapterManager.ProyekTableAdapter = Nothing
        Me.TableAdapterManager.Quotation_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.SupplierTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SalesQuoteManagement.QuotationDataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(521, 5)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(94, 32)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "[ X TUTUP ]"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IDProduk"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "SupplierID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Penyedia"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "KodeProduk"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Kode "
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ManufacturerBrand"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Brand"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Category"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Kategori"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "NamaProduk"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Produk"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Harga"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Harga"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "KuantitasPerUnit"
        Me.DataGridViewTextBoxColumn10.HeaderText = "PerUnit"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Keterangan"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Keterangan"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'frmBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 491)
        Me.ControlBox = False
        Me.Controls.Add(Me.spcBarang)
        Me.Controls.Add(Me.ProdukBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBarang"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Produk"
        CType(Me.ProdukBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProdukBindingNavigator.ResumeLayout(False)
        Me.ProdukBindingNavigator.PerformLayout()
        CType(Me.ProdukBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuotationDataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spcBarang.Panel1.ResumeLayout(False)
        Me.spcBarang.Panel2.ResumeLayout(False)
        CType(Me.spcBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spcBarang.ResumeLayout(False)
        Me.tbcProduk.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.ProdukDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents QuotationDataDataSet As SalesQuoteManagement.QuotationDataDataSet
    Friend WithEvents ProdukBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProdukTableAdapter As SalesQuoteManagement.QuotationDataDataSetTableAdapters.ProdukTableAdapter
    Friend WithEvents TableAdapterManager As SalesQuoteManagement.QuotationDataDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProdukBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents ProdukBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents spcBarang As System.Windows.Forms.SplitContainer
    Friend WithEvents lblTProduk As System.Windows.Forms.Label
    Friend WithEvents tbcProduk As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents IDProdukTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SupplierIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents KodeProdukTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ManufacturerBrandTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CategoryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NamaProdukTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HargaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents KuantitasPerUnitTextBox As System.Windows.Forms.TextBox
    Friend WithEvents KeteranganTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProdukDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
