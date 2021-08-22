Public Class frmSuplier

    Private Sub SuppliersBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles SuppliersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SuppliersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.QuotationDBDataSet)

    End Sub

    Private Sub frmSuplier_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'QuotationDBDataSet.Suppliers' table. You can move, or remove it, as needed.
        Me.SuppliersTableAdapter.Fill(Me.QuotationDBDataSet.Suppliers)

    End Sub
End Class