<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProyek
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
        Dim ProjectIDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProyek))
        Dim ProjectNameLabel As System.Windows.Forms.Label
        Dim PelangganIDLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Me.QuotationDataDataSet = New SalesQuoteManagement.QuotationDataDataSet()
        Me.ProyekBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProyekTableAdapter = New SalesQuoteManagement.QuotationDataDataSetTableAdapters.ProyekTableAdapter()
        Me.TableAdapterManager = New SalesQuoteManagement.QuotationDataDataSetTableAdapters.TableAdapterManager()
        Me.ProyekBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ProjectIDTextBox = New System.Windows.Forms.TextBox()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.ProyekBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ProjectNameTextBox = New System.Windows.Forms.TextBox()
        Me.PelangganIDTextBox = New System.Windows.Forms.TextBox()
        Me.StatusTextBox = New System.Windows.Forms.TextBox()
        Me.ProyekDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        ProjectIDLabel = New System.Windows.Forms.Label()
        ProjectNameLabel = New System.Windows.Forms.Label()
        PelangganIDLabel = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        CType(Me.QuotationDataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProyekBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProyekBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProyekBindingNavigator.SuspendLayout()
        CType(Me.ProyekDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'QuotationDataDataSet
        '
        Me.QuotationDataDataSet.DataSetName = "QuotationDataDataSet"
        Me.QuotationDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProyekBindingSource
        '
        Me.ProyekBindingSource.DataMember = "Proyek"
        Me.ProyekBindingSource.DataSource = Me.QuotationDataDataSet
        '
        'ProyekTableAdapter
        '
        Me.ProyekTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.karyawanTableAdapter = Nothing
        Me.TableAdapterManager.PelangganTableAdapter = Nothing
        Me.TableAdapterManager.ProdukTableAdapter = Nothing
        Me.TableAdapterManager.ProyekTableAdapter = Me.ProyekTableAdapter
        Me.TableAdapterManager.Quotation_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.SupplierTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SalesQuoteManagement.QuotationDataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ProyekBindingNavigator
        '
        Me.ProyekBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ProyekBindingNavigator.BindingSource = Me.ProyekBindingSource
        Me.ProyekBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ProyekBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ProyekBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ProyekBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ProyekBindingNavigatorSaveItem})
        Me.ProyekBindingNavigator.Location = New System.Drawing.Point(0, 389)
        Me.ProyekBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ProyekBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ProyekBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ProyekBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ProyekBindingNavigator.Name = "ProyekBindingNavigator"
        Me.ProyekBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ProyekBindingNavigator.Size = New System.Drawing.Size(516, 25)
        Me.ProyekBindingNavigator.TabIndex = 0
        Me.ProyekBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ProjectIDLabel
        '
        ProjectIDLabel.AutoSize = True
        ProjectIDLabel.Location = New System.Drawing.Point(35, 19)
        ProjectIDLabel.Name = "ProjectIDLabel"
        ProjectIDLabel.Size = New System.Drawing.Size(57, 13)
        ProjectIDLabel.TabIndex = 1
        ProjectIDLabel.Text = "Project ID:"
        '
        'ProjectIDTextBox
        '
        Me.ProjectIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProyekBindingSource, "ProjectID", True))
        Me.ProjectIDTextBox.Location = New System.Drawing.Point(98, 16)
        Me.ProjectIDTextBox.Name = "ProjectIDTextBox"
        Me.ProjectIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ProjectIDTextBox.TabIndex = 2
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
        'ProyekBindingNavigatorSaveItem
        '
        Me.ProyekBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ProyekBindingNavigatorSaveItem.Image = CType(resources.GetObject("ProyekBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ProyekBindingNavigatorSaveItem.Name = "ProyekBindingNavigatorSaveItem"
        Me.ProyekBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ProyekBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ProjectNameLabel
        '
        ProjectNameLabel.AutoSize = True
        ProjectNameLabel.Location = New System.Drawing.Point(18, 45)
        ProjectNameLabel.Name = "ProjectNameLabel"
        ProjectNameLabel.Size = New System.Drawing.Size(74, 13)
        ProjectNameLabel.TabIndex = 3
        ProjectNameLabel.Text = "Project Name:"
        '
        'ProjectNameTextBox
        '
        Me.ProjectNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProyekBindingSource, "ProjectName", True))
        Me.ProjectNameTextBox.Location = New System.Drawing.Point(98, 42)
        Me.ProjectNameTextBox.Name = "ProjectNameTextBox"
        Me.ProjectNameTextBox.Size = New System.Drawing.Size(389, 20)
        Me.ProjectNameTextBox.TabIndex = 4
        '
        'PelangganIDLabel
        '
        PelangganIDLabel.AutoSize = True
        PelangganIDLabel.Location = New System.Drawing.Point(17, 71)
        PelangganIDLabel.Name = "PelangganIDLabel"
        PelangganIDLabel.Size = New System.Drawing.Size(58, 13)
        PelangganIDLabel.TabIndex = 5
        PelangganIDLabel.Text = "Pelanggan"
        '
        'PelangganIDTextBox
        '
        Me.PelangganIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProyekBindingSource, "PelangganID", True))
        Me.PelangganIDTextBox.Location = New System.Drawing.Point(98, 68)
        Me.PelangganIDTextBox.Name = "PelangganIDTextBox"
        Me.PelangganIDTextBox.Size = New System.Drawing.Size(237, 20)
        Me.PelangganIDTextBox.TabIndex = 6
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Location = New System.Drawing.Point(341, 71)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(40, 13)
        StatusLabel.TabIndex = 7
        StatusLabel.Text = "Status:"
        '
        'StatusTextBox
        '
        Me.StatusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProyekBindingSource, "Status", True))
        Me.StatusTextBox.Location = New System.Drawing.Point(387, 68)
        Me.StatusTextBox.Name = "StatusTextBox"
        Me.StatusTextBox.Size = New System.Drawing.Size(100, 20)
        Me.StatusTextBox.TabIndex = 8
        '
        'ProyekDataGridView
        '
        Me.ProyekDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProyekDataGridView.AutoGenerateColumns = False
        Me.ProyekDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProyekDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.ProyekDataGridView.DataSource = Me.ProyekBindingSource
        Me.ProyekDataGridView.Location = New System.Drawing.Point(0, 111)
        Me.ProyekDataGridView.Name = "ProyekDataGridView"
        Me.ProyekDataGridView.Size = New System.Drawing.Size(516, 275)
        Me.ProyekDataGridView.TabIndex = 9
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 22
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ProjectID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ProjectID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ProjectName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ProjectName"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 200
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "PelangganID"
        Me.DataGridViewTextBoxColumn4.HeaderText = "PelangganID"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Status"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'frmProyek
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 414)
        Me.Controls.Add(Me.ProyekDataGridView)
        Me.Controls.Add(StatusLabel)
        Me.Controls.Add(Me.StatusTextBox)
        Me.Controls.Add(PelangganIDLabel)
        Me.Controls.Add(Me.PelangganIDTextBox)
        Me.Controls.Add(ProjectNameLabel)
        Me.Controls.Add(Me.ProjectNameTextBox)
        Me.Controls.Add(ProjectIDLabel)
        Me.Controls.Add(Me.ProjectIDTextBox)
        Me.Controls.Add(Me.ProyekBindingNavigator)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProyek"
        Me.ShowIcon = False
        Me.Text = "Tambah Prospek Baru"
        CType(Me.QuotationDataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProyekBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProyekBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProyekBindingNavigator.ResumeLayout(False)
        Me.ProyekBindingNavigator.PerformLayout()
        CType(Me.ProyekDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents QuotationDataDataSet As SalesQuoteManagement.QuotationDataDataSet
    Friend WithEvents ProyekBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProyekTableAdapter As SalesQuoteManagement.QuotationDataDataSetTableAdapters.ProyekTableAdapter
    Friend WithEvents TableAdapterManager As SalesQuoteManagement.QuotationDataDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProyekBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents ProyekBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ProjectIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProjectNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PelangganIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StatusTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProyekDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
