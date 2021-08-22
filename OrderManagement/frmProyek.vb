Public Class frmProyek

    Private Sub ProyekBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles ProyekBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProyekBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.QuotationDataDataSet)

    End Sub

    Private Sub frmProyek_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'QuotationDataDataSet.Proyek' table. You can move, or remove it, as needed.
        Me.ProyekTableAdapter.Fill(Me.QuotationDataDataSet.Proyek)

    End Sub
End Class