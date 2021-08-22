Public Class frmPelanggan



    Private Sub PelangganBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles PelangganBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PelangganBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.QuotationDataDataSet)

    End Sub

    Private Sub frmPelanggan_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'QuotationDataDataSet.Pelanggan' table. You can move, or remove it, as needed.
        Me.PelangganTableAdapter.Fill(Me.QuotationDataDataSet.Pelanggan)

    End Sub

End Class