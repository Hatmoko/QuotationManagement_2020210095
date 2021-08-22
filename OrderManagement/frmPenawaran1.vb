Public Class frmPenawaran1

    Private Sub Quotation_DetailsBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles Quotation_DetailsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Quotation_DetailsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.QuotationDataDataSet)

    End Sub

    Private Sub frmPenawaran1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'QuotationDataDataSet.Proyek' table. You can move, or remove it, as needed.
        Try
            Me.ProyekTableAdapter.Fill(Me.QuotationDataDataSet.Proyek)
            'TODO: This line of code loads data into the 'QuotationDataDataSet.Quotation_Details' table. You can move, or remove it, as needed.
            Me.Quotation_DetailsTableAdapter.Fill(Me.QuotationDataDataSet.Quotation_Details)

        Catch ex As Exception

        End Try

    End Sub

End Class