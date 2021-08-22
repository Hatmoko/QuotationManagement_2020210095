Public Class frmBarang

    Private Sub ProdukBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles ProdukBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProdukBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.QuotationDataDataSet)

    End Sub

    Private Sub frmBarang_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'QuotationDataDataSet.Produk' table. You can move, or remove it, as needed.
        Me.ProdukTableAdapter.Fill(Me.QuotationDataDataSet.Produk)

    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class