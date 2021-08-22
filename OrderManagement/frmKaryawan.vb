Public Class frmKaryawan

    Private Sub PelangganBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
 

    End Sub

    Private Sub frmKaryawan_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'QuotationDataDataSet.karyawan' table. You can move, or remove it, as needed.
        Me.KaryawanTableAdapter.Fill(Me.QuotationDataDataSet.karyawan)

    End Sub
End Class