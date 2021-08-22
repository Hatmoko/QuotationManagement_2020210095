Public Class frmPenyedia

    Private Sub SupplierBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles SupplierBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SupplierBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.QuotationDataDataSet)

    End Sub

    Private Sub frmPenyedia_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'QuotationDataDataSet.Supplier' table. You can move, or remove it, as needed.
        Me.SupplierTableAdapter.Fill(Me.QuotationDataDataSet.Supplier)

    End Sub
End Class