Public Class frmMain

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitTSMenuItem.Click
        Try
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Me.IsMdiContainer = True
        'frmBase.MdiParent = Me
        'frmBase.Show()
    End Sub

    Private Sub tspBtnCustomer_Click(sender As System.Object, e As System.EventArgs) Handles tspBtnCustomer.Click
        frmPelanggan.MdiParent = Me
        frmPelanggan.Show()
    End Sub
    Private Sub tspBtnSupplier_Click(sender As System.Object, e As System.EventArgs) Handles tspBtnSupplier.Click
        frmPenyedia.MdiParent = Me
        frmPenyedia.Show()
    End Sub
    Private Sub tspBtnEmployees_Click(sender As System.Object, e As System.EventArgs) Handles tspBtnEmployees.Click
        frmKaryawan.MdiParent = Me
        frmKaryawan.Show()

    End Sub

    Private Sub tspBtnProduct_Click(sender As System.Object, e As System.EventArgs) Handles tspBtnProduct.Click
        frmBarang.MdiParent = Me
        frmBarang.Show()
    End Sub

    Private Sub tspBtnQuotation_Click(sender As System.Object, e As System.EventArgs) Handles tspBtnQuotation.Click
        frmPenawaran1.MdiParent = Me
        frmPenawaran1.Show()
    End Sub

    Private Sub CustomeDataTSMitem_Click(sender As System.Object, e As System.EventArgs) Handles CustomeDataTSMitem.Click
        frmPelanggan.MdiParent = Me
        frmPelanggan.Show()
    End Sub

    Private Sub SuplierDataTSMitem_Click(sender As System.Object, e As System.EventArgs) Handles SuplierDataTSMitem.Click
        frmPenyedia.MdiParent = Me
        frmPenyedia.Show()
    End Sub

    Private Sub PersonalDataTSMitem_Click(sender As System.Object, e As System.EventArgs) Handles PersonalDataTSMitem.Click
        frmKaryawan.MdiParent = Me
        frmKaryawan.Show()
    End Sub

    Private Sub ProductDataTSMitem_Click(sender As System.Object, e As System.EventArgs) Handles ProductDataTSMitem.Click
        frmBarang.MdiParent = Me
        frmBarang.Show()
    End Sub

    Private Sub QuotationRptTSMitem_Click(sender As System.Object, e As System.EventArgs) Handles QuotationRptTSMitem.Click
        Me.IsMdiContainer = True
        rptQSn.MdiParent = Me
        rptQSn.Show()
    End Sub

    Private Sub QuotationToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles QuotationToolStripMenuItem.Click
        'frmPenawaran.MdiParent = Me
        'frmPenawaran.Show()
    End Sub

    Private Sub CustomerDataToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CustomerDataToolStripMenuItem.Click
        frmPelanggan.MdiParent = Me
        frmPelanggan.Show()
    End Sub

    Private Sub SuplierDataToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SuplierDataToolStripMenuItem.Click
        frmPenyedia.MdiParent = Me
        frmPenyedia.Show()
    End Sub

    Private Sub ProductToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ProductToolStripMenuItem.Click
        frmBarang.MdiParent = Me
        frmBarang.Show()
    End Sub

    Private Sub TsBtnProspek_Click(sender As System.Object, e As System.EventArgs) Handles TsBtnProspek.Click
        frmProyek.MdiParent = Me
        frmProyek.Show()
    End Sub

    Private Sub AboutHelpTSMitem_Click(sender As System.Object, e As System.EventArgs) Handles AboutHelpTSMitem.Click

        AboutBoxApp.Show()
    End Sub
End Class
