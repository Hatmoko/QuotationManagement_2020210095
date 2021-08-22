<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPenawaran1
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
        Dim ID1Label As System.Windows.Forms.Label
        Dim QuotationIDLabel As System.Windows.Forms.Label
        Dim PelangganLabel As System.Windows.Forms.Label
        Dim ProyekLabel As System.Windows.Forms.Label
        Dim ProdukLabel As System.Windows.Forms.Label
        Dim DateReceivedLabel As System.Windows.Forms.Label
        Dim UnitPriceLabel As System.Windows.Forms.Label
        Dim QuantityLabel As System.Windows.Forms.Label
        Dim DiscountLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPenawaran1))
        Dim lblProsesimbol As System.Windows.Forms.Label
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.lblT = New System.Windows.Forms.Label()
        Me.TabControlTawar = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ID1TextBox = New System.Windows.Forms.TextBox()
        Me.Quotation_DetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QuotationDataDataSet = New SalesQuoteManagement.QuotationDataDataSet()
        Me.QuotationIDTextBox = New System.Windows.Forms.TextBox()
        Me.PelangganTextBox = New System.Windows.Forms.TextBox()
        Me.ProyekTextBox = New System.Windows.Forms.TextBox()
        Me.ProyekBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProdukTextBox = New System.Windows.Forms.TextBox()
        Me.DateReceivedDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.UnitPriceTextBox = New System.Windows.Forms.TextBox()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.DiscountTextBox = New System.Windows.Forms.TextBox()
        Me.StatusTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Quotation_DetailsDataGridView = New System.Windows.Forms.DataGridView()
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
        Me.Quotation_DetailsTableAdapter = New SalesQuoteManagement.QuotationDataDataSetTableAdapters.Quotation_DetailsTableAdapter()
        Me.TableAdapterManager = New SalesQuoteManagement.QuotationDataDataSetTableAdapters.TableAdapterManager()
        Me.Quotation_DetailsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Quotation_DetailsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ProyekTableAdapter = New SalesQuoteManagement.QuotationDataDataSetTableAdapters.ProyekTableAdapter()
        ID1Label = New System.Windows.Forms.Label()
        QuotationIDLabel = New System.Windows.Forms.Label()
        PelangganLabel = New System.Windows.Forms.Label()
        ProyekLabel = New System.Windows.Forms.Label()
        ProdukLabel = New System.Windows.Forms.Label()
        DateReceivedLabel = New System.Windows.Forms.Label()
        UnitPriceLabel = New System.Windows.Forms.Label()
        QuantityLabel = New System.Windows.Forms.Label()
        DiscountLabel = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        lblProsesimbol = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TabControlTawar.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.Quotation_DetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuotationDataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProyekBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.Quotation_DetailsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Quotation_DetailsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Quotation_DetailsBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'ID1Label
        '
        ID1Label.AutoSize = True
        ID1Label.Location = New System.Drawing.Point(68, 50)
        ID1Label.Name = "ID1Label"
        ID1Label.Size = New System.Drawing.Size(27, 13)
        ID1Label.TabIndex = 0
        ID1Label.Text = "ID1:"
        ID1Label.Visible = False
        '
        'QuotationIDLabel
        '
        QuotationIDLabel.AutoSize = True
        QuotationIDLabel.Location = New System.Drawing.Point(68, 76)
        QuotationIDLabel.Name = "QuotationIDLabel"
        QuotationIDLabel.Size = New System.Drawing.Size(70, 13)
        QuotationIDLabel.TabIndex = 2
        QuotationIDLabel.Text = "Quotation ID:"
        '
        'PelangganLabel
        '
        PelangganLabel.AutoSize = True
        PelangganLabel.Location = New System.Drawing.Point(68, 102)
        PelangganLabel.Name = "PelangganLabel"
        PelangganLabel.Size = New System.Drawing.Size(61, 13)
        PelangganLabel.TabIndex = 4
        PelangganLabel.Text = "Pelanggan:"
        '
        'ProyekLabel
        '
        ProyekLabel.AutoSize = True
        ProyekLabel.Location = New System.Drawing.Point(68, 128)
        ProyekLabel.Name = "ProyekLabel"
        ProyekLabel.Size = New System.Drawing.Size(43, 13)
        ProyekLabel.TabIndex = 6
        ProyekLabel.Text = "Proyek:"
        '
        'ProdukLabel
        '
        ProdukLabel.AutoSize = True
        ProdukLabel.Location = New System.Drawing.Point(68, 154)
        ProdukLabel.Name = "ProdukLabel"
        ProdukLabel.Size = New System.Drawing.Size(44, 13)
        ProdukLabel.TabIndex = 8
        ProdukLabel.Text = "Produk:"
        '
        'DateReceivedLabel
        '
        DateReceivedLabel.AutoSize = True
        DateReceivedLabel.Location = New System.Drawing.Point(68, 181)
        DateReceivedLabel.Name = "DateReceivedLabel"
        DateReceivedLabel.Size = New System.Drawing.Size(82, 13)
        DateReceivedLabel.TabIndex = 10
        DateReceivedLabel.Text = "Date Received:"
        '
        'UnitPriceLabel
        '
        UnitPriceLabel.AutoSize = True
        UnitPriceLabel.Location = New System.Drawing.Point(68, 206)
        UnitPriceLabel.Name = "UnitPriceLabel"
        UnitPriceLabel.Size = New System.Drawing.Size(56, 13)
        UnitPriceLabel.TabIndex = 12
        UnitPriceLabel.Text = "Unit Price:"
        '
        'QuantityLabel
        '
        QuantityLabel.AutoSize = True
        QuantityLabel.Location = New System.Drawing.Point(68, 232)
        QuantityLabel.Name = "QuantityLabel"
        QuantityLabel.Size = New System.Drawing.Size(49, 13)
        QuantityLabel.TabIndex = 14
        QuantityLabel.Text = "Quantity:"
        '
        'DiscountLabel
        '
        DiscountLabel.AutoSize = True
        DiscountLabel.Location = New System.Drawing.Point(68, 258)
        DiscountLabel.Name = "DiscountLabel"
        DiscountLabel.Size = New System.Drawing.Size(52, 13)
        DiscountLabel.TabIndex = 16
        DiscountLabel.Text = "Discount:"
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Location = New System.Drawing.Point(68, 284)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(38, 13)
        StatusLabel.TabIndex = 18
        StatusLabel.Text = "status:"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblT)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControlTawar)
        Me.SplitContainer1.Size = New System.Drawing.Size(634, 493)
        Me.SplitContainer1.SplitterDistance = 42
        Me.SplitContainer1.TabIndex = 0
        '
        'lblT
        '
        Me.lblT.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblT.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblT.Location = New System.Drawing.Point(0, 0)
        Me.lblT.Name = "lblT"
        Me.lblT.Size = New System.Drawing.Size(634, 42)
        Me.lblT.TabIndex = 0
        Me.lblT.Text = "DATA PENAWARAN"
        Me.lblT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabControlTawar
        '
        Me.TabControlTawar.Controls.Add(Me.TabPage1)
        Me.TabControlTawar.Controls.Add(Me.TabPage2)
        Me.TabControlTawar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlTawar.Location = New System.Drawing.Point(0, 0)
        Me.TabControlTawar.Name = "TabControlTawar"
        Me.TabControlTawar.SelectedIndex = 0
        Me.TabControlTawar.Size = New System.Drawing.Size(634, 447)
        Me.TabControlTawar.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(lblProsesimbol)
        Me.TabPage1.Controls.Add(ID1Label)
        Me.TabPage1.Controls.Add(Me.ID1TextBox)
        Me.TabPage1.Controls.Add(QuotationIDLabel)
        Me.TabPage1.Controls.Add(Me.QuotationIDTextBox)
        Me.TabPage1.Controls.Add(PelangganLabel)
        Me.TabPage1.Controls.Add(Me.PelangganTextBox)
        Me.TabPage1.Controls.Add(ProyekLabel)
        Me.TabPage1.Controls.Add(Me.ProyekTextBox)
        Me.TabPage1.Controls.Add(ProdukLabel)
        Me.TabPage1.Controls.Add(Me.ProdukTextBox)
        Me.TabPage1.Controls.Add(DateReceivedLabel)
        Me.TabPage1.Controls.Add(Me.DateReceivedDateTimePicker)
        Me.TabPage1.Controls.Add(UnitPriceLabel)
        Me.TabPage1.Controls.Add(Me.UnitPriceTextBox)
        Me.TabPage1.Controls.Add(QuantityLabel)
        Me.TabPage1.Controls.Add(Me.QuantityTextBox)
        Me.TabPage1.Controls.Add(DiscountLabel)
        Me.TabPage1.Controls.Add(Me.DiscountTextBox)
        Me.TabPage1.Controls.Add(StatusLabel)
        Me.TabPage1.Controls.Add(Me.StatusTextBox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(626, 421)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Data Detail"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ID1TextBox
        '
        Me.ID1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Quotation_DetailsBindingSource, "ID1", True))
        Me.ID1TextBox.Location = New System.Drawing.Point(156, 47)
        Me.ID1TextBox.Name = "ID1TextBox"
        Me.ID1TextBox.Size = New System.Drawing.Size(200, 20)
        Me.ID1TextBox.TabIndex = 1
        Me.ID1TextBox.Visible = False
        Me.ID1TextBox.WordWrap = False
        '
        'Quotation_DetailsBindingSource
        '
        Me.Quotation_DetailsBindingSource.DataMember = "Quotation_Details"
        Me.Quotation_DetailsBindingSource.DataSource = Me.QuotationDataDataSet
        '
        'QuotationDataDataSet
        '
        Me.QuotationDataDataSet.DataSetName = "QuotationDataDataSet"
        Me.QuotationDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'QuotationIDTextBox
        '
        Me.QuotationIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Quotation_DetailsBindingSource, "QuotationID", True))
        Me.QuotationIDTextBox.Location = New System.Drawing.Point(156, 73)
        Me.QuotationIDTextBox.Name = "QuotationIDTextBox"
        Me.QuotationIDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.QuotationIDTextBox.TabIndex = 3
        '
        'PelangganTextBox
        '
        Me.PelangganTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Quotation_DetailsBindingSource, "Pelanggan", True))
        Me.PelangganTextBox.Location = New System.Drawing.Point(156, 99)
        Me.PelangganTextBox.Name = "PelangganTextBox"
        Me.PelangganTextBox.Size = New System.Drawing.Size(406, 20)
        Me.PelangganTextBox.TabIndex = 5
        '
        'ProyekTextBox
        '
        Me.ProyekTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.ProyekTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Quotation_DetailsBindingSource, "Proyek", True))
        Me.ProyekTextBox.Location = New System.Drawing.Point(156, 125)
        Me.ProyekTextBox.Name = "ProyekTextBox"
        Me.ProyekTextBox.Size = New System.Drawing.Size(406, 20)
        Me.ProyekTextBox.TabIndex = 7
        '
        'ProyekBindingSource
        '
        Me.ProyekBindingSource.DataMember = "Proyek"
        Me.ProyekBindingSource.DataSource = Me.QuotationDataDataSet
        '
        'ProdukTextBox
        '
        Me.ProdukTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Quotation_DetailsBindingSource, "Produk", True))
        Me.ProdukTextBox.Location = New System.Drawing.Point(156, 151)
        Me.ProdukTextBox.Name = "ProdukTextBox"
        Me.ProdukTextBox.Size = New System.Drawing.Size(406, 20)
        Me.ProdukTextBox.TabIndex = 9
        '
        'DateReceivedDateTimePicker
        '
        Me.DateReceivedDateTimePicker.CustomFormat = "dd MMM yyyy"
        Me.DateReceivedDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Quotation_DetailsBindingSource, "DateReceived", True))
        Me.DateReceivedDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateReceivedDateTimePicker.Location = New System.Drawing.Point(156, 177)
        Me.DateReceivedDateTimePicker.Name = "DateReceivedDateTimePicker"
        Me.DateReceivedDateTimePicker.Size = New System.Drawing.Size(119, 20)
        Me.DateReceivedDateTimePicker.TabIndex = 11
        '
        'UnitPriceTextBox
        '
        Me.UnitPriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Quotation_DetailsBindingSource, "UnitPrice", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "Rp #,##0"))
        Me.UnitPriceTextBox.Location = New System.Drawing.Point(156, 203)
        Me.UnitPriceTextBox.Name = "UnitPriceTextBox"
        Me.UnitPriceTextBox.Size = New System.Drawing.Size(200, 20)
        Me.UnitPriceTextBox.TabIndex = 13
        Me.UnitPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Quotation_DetailsBindingSource, "Quantity", True))
        Me.QuantityTextBox.Location = New System.Drawing.Point(261, 229)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(95, 20)
        Me.QuantityTextBox.TabIndex = 15
        Me.QuantityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DiscountTextBox
        '
        Me.DiscountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Quotation_DetailsBindingSource, "Discount", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.DiscountTextBox.Location = New System.Drawing.Point(261, 251)
        Me.DiscountTextBox.Name = "DiscountTextBox"
        Me.DiscountTextBox.Size = New System.Drawing.Size(76, 20)
        Me.DiscountTextBox.TabIndex = 17
        Me.DiscountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'StatusTextBox
        '
        Me.StatusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Quotation_DetailsBindingSource, "status", True))
        Me.StatusTextBox.Location = New System.Drawing.Point(156, 281)
        Me.StatusTextBox.Name = "StatusTextBox"
        Me.StatusTextBox.Size = New System.Drawing.Size(87, 20)
        Me.StatusTextBox.TabIndex = 19
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Quotation_DetailsDataGridView)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(626, 421)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Daftar Barang"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Quotation_DetailsDataGridView
        '
        Me.Quotation_DetailsDataGridView.AutoGenerateColumns = False
        Me.Quotation_DetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Quotation_DetailsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.Quotation_DetailsDataGridView.DataSource = Me.Quotation_DetailsBindingSource
        Me.Quotation_DetailsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Quotation_DetailsDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.Quotation_DetailsDataGridView.Name = "Quotation_DetailsDataGridView"
        Me.Quotation_DetailsDataGridView.Size = New System.Drawing.Size(620, 415)
        Me.Quotation_DetailsDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID1"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID1"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 50
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "QuotationID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nomor"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 80
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Pelanggan"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Pelanggan"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Proyek"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Proyek"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Produk"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Produk"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "DateReceived"
        Me.DataGridViewTextBoxColumn6.HeaderText = "DateReceived"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "UnitPrice"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "Rp #,##0"
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn7.HeaderText = "UnitPrice"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Quantity"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn8.HeaderText = "Quantity"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Discount"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn9.HeaderText = "Discount"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "status"
        Me.DataGridViewTextBoxColumn10.HeaderText = "status"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Visible = False
        '
        'Quotation_DetailsTableAdapter
        '
        Me.Quotation_DetailsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.karyawanTableAdapter = Nothing
        Me.TableAdapterManager.PelangganTableAdapter = Nothing
        Me.TableAdapterManager.ProdukTableAdapter = Nothing
        Me.TableAdapterManager.ProyekTableAdapter = Nothing
        Me.TableAdapterManager.Quotation_DetailsTableAdapter = Me.Quotation_DetailsTableAdapter
        Me.TableAdapterManager.SupplierTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SalesQuoteManagement.QuotationDataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Quotation_DetailsBindingNavigator
        '
        Me.Quotation_DetailsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Quotation_DetailsBindingNavigator.BindingSource = Me.Quotation_DetailsBindingSource
        Me.Quotation_DetailsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Quotation_DetailsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Quotation_DetailsBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Quotation_DetailsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Quotation_DetailsBindingNavigatorSaveItem})
        Me.Quotation_DetailsBindingNavigator.Location = New System.Drawing.Point(0, 468)
        Me.Quotation_DetailsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Quotation_DetailsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Quotation_DetailsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Quotation_DetailsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Quotation_DetailsBindingNavigator.Name = "Quotation_DetailsBindingNavigator"
        Me.Quotation_DetailsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Quotation_DetailsBindingNavigator.Size = New System.Drawing.Size(634, 25)
        Me.Quotation_DetailsBindingNavigator.TabIndex = 1
        Me.Quotation_DetailsBindingNavigator.Text = "BindingNavigatorQuote"
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
        'Quotation_DetailsBindingNavigatorSaveItem
        '
        Me.Quotation_DetailsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Quotation_DetailsBindingNavigatorSaveItem.Image = CType(resources.GetObject("Quotation_DetailsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Quotation_DetailsBindingNavigatorSaveItem.Name = "Quotation_DetailsBindingNavigatorSaveItem"
        Me.Quotation_DetailsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Quotation_DetailsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ProyekTableAdapter
        '
        Me.ProyekTableAdapter.ClearBeforeFill = True
        '
        'lblProsesimbol
        '
        lblProsesimbol.AutoSize = True
        lblProsesimbol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblProsesimbol.Location = New System.Drawing.Point(343, 254)
        lblProsesimbol.Name = "lblProsesimbol"
        lblProsesimbol.Size = New System.Drawing.Size(19, 15)
        lblProsesimbol.TabIndex = 20
        lblProsesimbol.Text = "%"
        ' AddHandler lblProsesimbol.Click, AddressOf Me.Label1_Click
        '
        'frmPenawaran1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 493)
        Me.Controls.Add(Me.Quotation_DetailsBindingNavigator)
        Me.Controls.Add(Me.SplitContainer1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPenawaran1"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TabControlTawar.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.Quotation_DetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuotationDataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProyekBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.Quotation_DetailsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Quotation_DetailsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Quotation_DetailsBindingNavigator.ResumeLayout(False)
        Me.Quotation_DetailsBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents lblT As System.Windows.Forms.Label
    Friend WithEvents TabControlTawar As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents QuotationDataDataSet As SalesQuoteManagement.QuotationDataDataSet
    Friend WithEvents Quotation_DetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Quotation_DetailsTableAdapter As SalesQuoteManagement.QuotationDataDataSetTableAdapters.Quotation_DetailsTableAdapter
    Friend WithEvents TableAdapterManager As SalesQuoteManagement.QuotationDataDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Quotation_DetailsBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Quotation_DetailsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Quotation_DetailsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ID1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents QuotationIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PelangganTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProyekTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProdukTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateReceivedDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents UnitPriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents QuantityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DiscountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StatusTextBox As System.Windows.Forms.TextBox
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
    Friend WithEvents ProyekBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProyekTableAdapter As SalesQuoteManagement.QuotationDataDataSetTableAdapters.ProyekTableAdapter
End Class
