<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBase
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart3 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TableMenuKanan = New System.Windows.Forms.TableLayoutPanel()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.TableChartAtas = New System.Windows.Forms.TableLayoutPanel()
        Me.lblTDash1 = New System.Windows.Forms.Label()
        Me.lblTDash2 = New System.Windows.Forms.Label()
        Me.lblTDash3 = New System.Windows.Forms.Label()
        Me.TableMenuBawah = New System.Windows.Forms.TableLayoutPanel()
        Me.btnMenuOverview = New System.Windows.Forms.Button()
        Me.btnAkunkontak = New System.Windows.Forms.Button()
        Me.btnOpportunity = New System.Windows.Forms.Button()
        Me.btnPriceList = New System.Windows.Forms.Button()
        Me.btnProduk = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.btnReporting = New System.Windows.Forms.Button()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TableMenuKanan.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.TableChartAtas.SuspendLayout()
        Me.SuspendLayout()
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(695, 60)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(341, 224)
        Me.Chart1.TabIndex = 1
        Me.Chart1.Text = "Sales Procces"
        '
        'Chart2
        '
        ChartArea2.Name = "ChartArea1"
        Me.Chart2.ChartAreas.Add(ChartArea2)
        Me.Chart2.Dock = System.Windows.Forms.DockStyle.Fill
        Legend2.Name = "Legend1"
        Me.Chart2.Legends.Add(Legend2)
        Me.Chart2.Location = New System.Drawing.Point(3, 60)
        Me.Chart2.Name = "Chart2"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.Chart2.Series.Add(Series2)
        Me.Chart2.Size = New System.Drawing.Size(340, 224)
        Me.Chart2.TabIndex = 2
        Me.Chart2.Text = "Chart2"
        Title1.Name = "Title1"
        Title1.Text = "JUDUL CHART siji"
        Me.Chart2.Titles.Add(Title1)
        '
        'Chart3
        '
        ChartArea3.Name = "ChartArea1"
        Me.Chart3.ChartAreas.Add(ChartArea3)
        Me.Chart3.Dock = System.Windows.Forms.DockStyle.Fill
        Legend3.Name = "Legend1"
        Me.Chart3.Legends.Add(Legend3)
        Me.Chart3.Location = New System.Drawing.Point(349, 60)
        Me.Chart3.Name = "Chart3"
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        Me.Chart3.Series.Add(Series3)
        Me.Chart3.Size = New System.Drawing.Size(340, 224)
        Me.Chart3.TabIndex = 3
        Me.Chart3.Text = "Chart3"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TableMenuKanan)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1354, 713)
        Me.SplitContainer1.SplitterDistance = 311
        Me.SplitContainer1.TabIndex = 5
        '
        'TableMenuKanan
        '
        Me.TableMenuKanan.ColumnCount = 1
        Me.TableMenuKanan.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableMenuKanan.Controls.Add(Me.btnMenuOverview, 0, 0)
        Me.TableMenuKanan.Controls.Add(Me.btnAkunkontak, 0, 1)
        Me.TableMenuKanan.Controls.Add(Me.btnOpportunity, 0, 2)
        Me.TableMenuKanan.Controls.Add(Me.btnPriceList, 0, 5)
        Me.TableMenuKanan.Controls.Add(Me.btnProduk, 0, 4)
        Me.TableMenuKanan.Controls.Add(Me.Button7, 0, 3)
        Me.TableMenuKanan.Controls.Add(Me.btnReporting, 0, 6)
        Me.TableMenuKanan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableMenuKanan.Location = New System.Drawing.Point(0, 0)
        Me.TableMenuKanan.Name = "TableMenuKanan"
        Me.TableMenuKanan.RowCount = 8
        Me.TableMenuKanan.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableMenuKanan.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableMenuKanan.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableMenuKanan.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableMenuKanan.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableMenuKanan.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableMenuKanan.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableMenuKanan.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableMenuKanan.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableMenuKanan.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableMenuKanan.Size = New System.Drawing.Size(311, 713)
        Me.TableMenuKanan.TabIndex = 0
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.TableChartAtas)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.TableMenuBawah)
        Me.SplitContainer2.Size = New System.Drawing.Size(1039, 713)
        Me.SplitContainer2.SplitterDistance = 287
        Me.SplitContainer2.TabIndex = 0
        '
        'TableChartAtas
        '
        Me.TableChartAtas.CausesValidation = False
        Me.TableChartAtas.ColumnCount = 3
        Me.TableChartAtas.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableChartAtas.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableChartAtas.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableChartAtas.Controls.Add(Me.Chart1, 2, 1)
        Me.TableChartAtas.Controls.Add(Me.Chart3, 1, 1)
        Me.TableChartAtas.Controls.Add(Me.Chart2, 0, 1)
        Me.TableChartAtas.Controls.Add(Me.lblTDash1, 0, 0)
        Me.TableChartAtas.Controls.Add(Me.lblTDash2, 1, 0)
        Me.TableChartAtas.Controls.Add(Me.lblTDash3, 2, 0)
        Me.TableChartAtas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableChartAtas.Location = New System.Drawing.Point(0, 0)
        Me.TableChartAtas.Name = "TableChartAtas"
        Me.TableChartAtas.RowCount = 2
        Me.TableChartAtas.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableChartAtas.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableChartAtas.Size = New System.Drawing.Size(1039, 287)
        Me.TableChartAtas.TabIndex = 0
        '
        'lblTDash1
        '
        Me.lblTDash1.AutoSize = True
        Me.lblTDash1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTDash1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTDash1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTDash1.Location = New System.Drawing.Point(3, 0)
        Me.lblTDash1.Name = "lblTDash1"
        Me.lblTDash1.Size = New System.Drawing.Size(340, 57)
        Me.lblTDash1.TabIndex = 4
        Me.lblTDash1.Text = "OPPORTUNITY"
        Me.lblTDash1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTDash2
        '
        Me.lblTDash2.AutoSize = True
        Me.lblTDash2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTDash2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTDash2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTDash2.Location = New System.Drawing.Point(349, 0)
        Me.lblTDash2.Name = "lblTDash2"
        Me.lblTDash2.Size = New System.Drawing.Size(340, 57)
        Me.lblTDash2.TabIndex = 5
        Me.lblTDash2.Text = "PROGRESS"
        Me.lblTDash2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTDash3
        '
        Me.lblTDash3.AutoSize = True
        Me.lblTDash3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTDash3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTDash3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTDash3.Location = New System.Drawing.Point(695, 0)
        Me.lblTDash3.Name = "lblTDash3"
        Me.lblTDash3.Size = New System.Drawing.Size(341, 57)
        Me.lblTDash3.TabIndex = 6
        Me.lblTDash3.Text = "PIPELINE"
        Me.lblTDash3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableMenuBawah
        '
        Me.TableMenuBawah.AutoSize = True
        Me.TableMenuBawah.BackColor = System.Drawing.SystemColors.Control
        Me.TableMenuBawah.ColumnCount = 5
        Me.TableMenuBawah.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableMenuBawah.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableMenuBawah.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableMenuBawah.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableMenuBawah.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableMenuBawah.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableMenuBawah.Location = New System.Drawing.Point(0, 0)
        Me.TableMenuBawah.Name = "TableMenuBawah"
        Me.TableMenuBawah.RowCount = 2
        Me.TableMenuBawah.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableMenuBawah.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableMenuBawah.Size = New System.Drawing.Size(1039, 422)
        Me.TableMenuBawah.TabIndex = 0
        '
        'btnMenuOverview
        '
        Me.btnMenuOverview.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnMenuOverview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnMenuOverview.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenuOverview.Image = Global.SalesQuoteManagement.My.Resources.Resources.books
        Me.btnMenuOverview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMenuOverview.Location = New System.Drawing.Point(3, 3)
        Me.btnMenuOverview.Name = "btnMenuOverview"
        Me.btnMenuOverview.Size = New System.Drawing.Size(305, 95)
        Me.btnMenuOverview.TabIndex = 0
        Me.btnMenuOverview.Text = "OVERVIEW"
        Me.btnMenuOverview.UseVisualStyleBackColor = False
        '
        'btnAkunkontak
        '
        Me.btnAkunkontak.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAkunkontak.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAkunkontak.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAkunkontak.Image = Global.SalesQuoteManagement.My.Resources.Resources.book
        Me.btnAkunkontak.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAkunkontak.Location = New System.Drawing.Point(3, 104)
        Me.btnAkunkontak.Name = "btnAkunkontak"
        Me.btnAkunkontak.Size = New System.Drawing.Size(305, 95)
        Me.btnAkunkontak.TabIndex = 1
        Me.btnAkunkontak.Text = "CONTACT"
        Me.btnAkunkontak.UseVisualStyleBackColor = False
        '
        'btnOpportunity
        '
        Me.btnOpportunity.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnOpportunity.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnOpportunity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpportunity.Image = Global.SalesQuoteManagement.My.Resources.Resources.Shopping_Full
        Me.btnOpportunity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOpportunity.Location = New System.Drawing.Point(3, 205)
        Me.btnOpportunity.Name = "btnOpportunity"
        Me.btnOpportunity.Size = New System.Drawing.Size(305, 95)
        Me.btnOpportunity.TabIndex = 2
        Me.btnOpportunity.Text = "OPPORTUNITY"
        Me.btnOpportunity.UseVisualStyleBackColor = False
        '
        'btnPriceList
        '
        Me.btnPriceList.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPriceList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnPriceList.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPriceList.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnPriceList.Image = Global.SalesQuoteManagement.My.Resources.Resources.order
        Me.btnPriceList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPriceList.Location = New System.Drawing.Point(3, 508)
        Me.btnPriceList.Name = "btnPriceList"
        Me.btnPriceList.Size = New System.Drawing.Size(305, 95)
        Me.btnPriceList.TabIndex = 5
        Me.btnPriceList.Text = "PRICE LIST"
        Me.btnPriceList.UseVisualStyleBackColor = False
        '
        'btnProduk
        '
        Me.btnProduk.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnProduk.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnProduk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProduk.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnProduk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProduk.Location = New System.Drawing.Point(3, 407)
        Me.btnProduk.Name = "btnProduk"
        Me.btnProduk.Size = New System.Drawing.Size(305, 95)
        Me.btnProduk.TabIndex = 4
        Me.btnProduk.Text = "PRODUCTS"
        Me.btnProduk.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Button7.Image = Global.SalesQuoteManagement.My.Resources.Resources.new_file
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.Location = New System.Drawing.Point(3, 306)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(305, 95)
        Me.Button7.TabIndex = 7
        Me.Button7.Text = "QUOTATIONS"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'btnReporting
        '
        Me.btnReporting.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnReporting.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnReporting.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReporting.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnReporting.Image = Global.SalesQuoteManagement.My.Resources.Resources.pen
        Me.btnReporting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReporting.Location = New System.Drawing.Point(3, 609)
        Me.btnReporting.Name = "btnReporting"
        Me.btnReporting.Size = New System.Drawing.Size(305, 95)
        Me.btnReporting.TabIndex = 9
        Me.btnReporting.Text = "REPORTING"
        Me.btnReporting.UseVisualStyleBackColor = False
        '
        'frmBase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1354, 713)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmBase"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Overview"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TableMenuKanan.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.TableChartAtas.ResumeLayout(False)
        Me.TableChartAtas.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Chart2 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Chart3 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents TableChartAtas As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblTDash1 As System.Windows.Forms.Label
    Friend WithEvents lblTDash2 As System.Windows.Forms.Label
    Friend WithEvents lblTDash3 As System.Windows.Forms.Label
    Friend WithEvents TableMenuBawah As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableMenuKanan As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnMenuOverview As System.Windows.Forms.Button
    Friend WithEvents btnAkunkontak As System.Windows.Forms.Button
    Friend WithEvents btnOpportunity As System.Windows.Forms.Button
    Friend WithEvents btnProduk As System.Windows.Forms.Button
    Friend WithEvents btnPriceList As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents btnReporting As System.Windows.Forms.Button
End Class
