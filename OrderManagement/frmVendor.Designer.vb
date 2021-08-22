<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSuplier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSuplier))
        Dim CompanyLabel As System.Windows.Forms.Label
        Me.spcSuplier = New System.Windows.Forms.SplitContainer()
        Me.lblTSuplier = New System.Windows.Forms.Label()
        Me.TbcSuplier = New System.Windows.Forms.TabControl()
        Me.tabSuplier1 = New System.Windows.Forms.TabPage()
        Me.TabSuplier2 = New System.Windows.Forms.TabPage()
        Me.QuotationDBDataSet = New SalesQuoteManagement.QuotationDBDataSet()
        Me.SuppliersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SuppliersTableAdapter = New SalesQuoteManagement.QuotationDBDataSetTableAdapters.SuppliersTableAdapter()
        Me.TableAdapterManager = New SalesQuoteManagement.QuotationDBDataSetTableAdapters.TableAdapterManager()
        Me.SuppliersBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.SuppliersBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.SuppliersDataGridView = New System.Windows.Forms.DataGridView()
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
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CompanyTextBox = New System.Windows.Forms.TextBox()
        CompanyLabel = New System.Windows.Forms.Label()
        CType(Me.spcSuplier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spcSuplier.Panel1.SuspendLayout()
        Me.spcSuplier.Panel2.SuspendLayout()
        Me.spcSuplier.SuspendLayout()
        Me.TbcSuplier.SuspendLayout()
        Me.tabSuplier1.SuspendLayout()
        Me.TabSuplier2.SuspendLayout()
        CType(Me.QuotationDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SuppliersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SuppliersBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuppliersBindingNavigator.SuspendLayout()
        CType(Me.SuppliersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'spcSuplier
        '
        Me.spcSuplier.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spcSuplier.Location = New System.Drawing.Point(0, 0)
        Me.spcSuplier.Name = "spcSuplier"
        Me.spcSuplier.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'spcSuplier.Panel1
        '
        Me.spcSuplier.Panel1.Controls.Add(Me.lblTSuplier)
        '
        'spcSuplier.Panel2
        '
        Me.spcSuplier.Panel2.Controls.Add(Me.TbcSuplier)
        Me.spcSuplier.Size = New System.Drawing.Size(720, 641)
        Me.spcSuplier.SplitterDistance = 70
        Me.spcSuplier.TabIndex = 0
        '
        'lblTSuplier
        '
        Me.lblTSuplier.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTSuplier.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTSuplier.Image = Global.SalesQuoteManagement.My.Resources.Resources.book
        Me.lblTSuplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblTSuplier.Location = New System.Drawing.Point(0, 0)
        Me.lblTSuplier.Name = "lblTSuplier"
        Me.lblTSuplier.Size = New System.Drawing.Size(720, 70)
        Me.lblTSuplier.TabIndex = 0
        Me.lblTSuplier.Text = "SUPLIER"
        Me.lblTSuplier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TbcSuplier
        '
        Me.TbcSuplier.Controls.Add(Me.tabSuplier1)
        Me.TbcSuplier.Controls.Add(Me.TabSuplier2)
        Me.TbcSuplier.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TbcSuplier.Location = New System.Drawing.Point(0, 0)
        Me.TbcSuplier.Name = "TbcSuplier"
        Me.TbcSuplier.SelectedIndex = 0
        Me.TbcSuplier.Size = New System.Drawing.Size(720, 567)
        Me.TbcSuplier.TabIndex = 0
        '
        'tabSuplier1
        '
        Me.tabSuplier1.Controls.Add(CompanyLabel)
        Me.tabSuplier1.Controls.Add(Me.CompanyTextBox)
        Me.tabSuplier1.Location = New System.Drawing.Point(4, 22)
        Me.tabSuplier1.Name = "tabSuplier1"
        Me.tabSuplier1.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSuplier1.Size = New System.Drawing.Size(712, 541)
        Me.tabSuplier1.TabIndex = 0
        Me.tabSuplier1.Text = "Suplier Data"
        Me.tabSuplier1.UseVisualStyleBackColor = True
        '
        'TabSuplier2
        '
        Me.TabSuplier2.Controls.Add(Me.SuppliersDataGridView)
        Me.TabSuplier2.Location = New System.Drawing.Point(4, 22)
        Me.TabSuplier2.Name = "TabSuplier2"
        Me.TabSuplier2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabSuplier2.Size = New System.Drawing.Size(712, 518)
        Me.TabSuplier2.TabIndex = 1
        Me.TabSuplier2.Text = "Supplier List"
        Me.TabSuplier2.UseVisualStyleBackColor = True
        '
        'QuotationDBDataSet
        '
        Me.QuotationDBDataSet.DataSetName = "QuotationDBDataSet"
        Me.QuotationDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SuppliersBindingSource
        '
        Me.SuppliersBindingSource.DataMember = "Suppliers"
        Me.SuppliersBindingSource.DataSource = Me.QuotationDBDataSet
        '
        'SuppliersTableAdapter
        '
        Me.SuppliersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CustomersTableAdapter = Nothing
        Me.TableAdapterManager.Employee_PrivilegesTableAdapter = Nothing
        Me.TableAdapterManager.EmployeesTableAdapter = Nothing
        Me.TableAdapterManager.Inventory_Transaction_TypesTableAdapter = Nothing
        Me.TableAdapterManager.Inventory_TransactionsTableAdapter = Nothing
        Me.TableAdapterManager.InvoicesTableAdapter = Nothing
        Me.TableAdapterManager.Order_Details_StatusTableAdapter = Nothing
        Me.TableAdapterManager.Order_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.Orders_StatusTableAdapter = Nothing
        Me.TableAdapterManager.Orders_Tax_StatusTableAdapter = Nothing
        Me.TableAdapterManager.OrdersTableAdapter = Nothing
        Me.TableAdapterManager.PrivilegesTableAdapter = Nothing
        Me.TableAdapterManager.ProductsTableAdapter = Nothing
        Me.TableAdapterManager.Quotation_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.Quotation_StatusTableAdapter = Nothing
        Me.TableAdapterManager.QuotationTableAdapter = Nothing
        Me.TableAdapterManager.Sales_ReportsTableAdapter = Nothing
        Me.TableAdapterManager.ShippersTableAdapter = Nothing
        Me.TableAdapterManager.StringsTableAdapter = Nothing
        Me.TableAdapterManager.SuppliersTableAdapter = Me.SuppliersTableAdapter
        Me.TableAdapterManager.UpdateOrder = SalesQuoteManagement.QuotationDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SuppliersBindingNavigator
        '
        Me.SuppliersBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.SuppliersBindingNavigator.BindingSource = Me.SuppliersBindingSource
        Me.SuppliersBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SuppliersBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.SuppliersBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SuppliersBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SuppliersBindingNavigatorSaveItem})
        Me.SuppliersBindingNavigator.Location = New System.Drawing.Point(0, 616)
        Me.SuppliersBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.SuppliersBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.SuppliersBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.SuppliersBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.SuppliersBindingNavigator.Name = "SuppliersBindingNavigator"
        Me.SuppliersBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.SuppliersBindingNavigator.Size = New System.Drawing.Size(720, 25)
        Me.SuppliersBindingNavigator.TabIndex = 1
        Me.SuppliersBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
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
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'SuppliersBindingNavigatorSaveItem
        '
        Me.SuppliersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SuppliersBindingNavigatorSaveItem.Image = CType(resources.GetObject("SuppliersBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SuppliersBindingNavigatorSaveItem.Name = "SuppliersBindingNavigatorSaveItem"
        Me.SuppliersBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.SuppliersBindingNavigatorSaveItem.Text = "Save Data"
        '
        'SuppliersDataGridView
        '
        Me.SuppliersDataGridView.AutoGenerateColumns = False
        Me.SuppliersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SuppliersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18})
        Me.SuppliersDataGridView.DataSource = Me.SuppliersBindingSource
        Me.SuppliersDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuppliersDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.SuppliersDataGridView.Name = "SuppliersDataGridView"
        Me.SuppliersDataGridView.Size = New System.Drawing.Size(706, 512)
        Me.SuppliersDataGridView.TabIndex = 0
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
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Company"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Company"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Last Name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Last Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "First Name"
        Me.DataGridViewTextBoxColumn4.HeaderText = "First Name"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "E-mail Address"
        Me.DataGridViewTextBoxColumn5.HeaderText = "E-mail Address"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Job Title"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Job Title"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Business Phone"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Business Phone"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Home Phone"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Home Phone"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Mobile Phone"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Mobile Phone"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Fax Number"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Fax Number"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Address"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "City"
        Me.DataGridViewTextBoxColumn12.HeaderText = "City"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "State/Province"
        Me.DataGridViewTextBoxColumn13.HeaderText = "State/Province"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "ZIP/Postal Code"
        Me.DataGridViewTextBoxColumn14.HeaderText = "ZIP/Postal Code"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Country/Region"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Country/Region"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Web Page"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Web Page"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Notes"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Notes"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "Attachments"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Attachments"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'CompanyLabel
        '
        CompanyLabel.AutoSize = True
        CompanyLabel.Location = New System.Drawing.Point(15, 24)
        CompanyLabel.Name = "CompanyLabel"
        CompanyLabel.Size = New System.Drawing.Size(54, 13)
        CompanyLabel.TabIndex = 0
        CompanyLabel.Text = "Company:"
        '
        'CompanyTextBox
        '
        Me.CompanyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SuppliersBindingSource, "Company", True))
        Me.CompanyTextBox.Location = New System.Drawing.Point(75, 21)
        Me.CompanyTextBox.Name = "CompanyTextBox"
        Me.CompanyTextBox.Size = New System.Drawing.Size(260, 20)
        Me.CompanyTextBox.TabIndex = 1
        '
        'frmSuplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 641)
        Me.Controls.Add(Me.SuppliersBindingNavigator)
        Me.Controls.Add(Me.spcSuplier)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSuplier"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Suplier"
        Me.spcSuplier.Panel1.ResumeLayout(False)
        Me.spcSuplier.Panel2.ResumeLayout(False)
        CType(Me.spcSuplier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spcSuplier.ResumeLayout(False)
        Me.TbcSuplier.ResumeLayout(False)
        Me.tabSuplier1.ResumeLayout(False)
        Me.tabSuplier1.PerformLayout()
        Me.TabSuplier2.ResumeLayout(False)
        CType(Me.QuotationDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SuppliersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SuppliersBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuppliersBindingNavigator.ResumeLayout(False)
        Me.SuppliersBindingNavigator.PerformLayout()
        CType(Me.SuppliersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents spcSuplier As System.Windows.Forms.SplitContainer
    Friend WithEvents lblTSuplier As System.Windows.Forms.Label
    Friend WithEvents TbcSuplier As System.Windows.Forms.TabControl
    Friend WithEvents tabSuplier1 As System.Windows.Forms.TabPage
    Friend WithEvents TabSuplier2 As System.Windows.Forms.TabPage
    Friend WithEvents QuotationDBDataSet As SalesQuoteManagement.QuotationDBDataSet
    Friend WithEvents SuppliersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SuppliersTableAdapter As SalesQuoteManagement.QuotationDBDataSetTableAdapters.SuppliersTableAdapter
    Friend WithEvents TableAdapterManager As SalesQuoteManagement.QuotationDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SuppliersBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents SuppliersBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents SuppliersDataGridView As System.Windows.Forms.DataGridView
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
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CompanyTextBox As System.Windows.Forms.TextBox
End Class
