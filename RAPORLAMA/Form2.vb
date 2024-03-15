Imports System.Data.OleDb
Public Class Form2
    Dim baglanti As New OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0; Data Source=bilgiler.mdb")
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rapor As New CrystalReport1()
        Dim dataset As New DataSet()
        Dim adaptor As New OleDbDataAdapter(Form1.sql, baglanti)
        adaptor.Fill(dataset, "Tablo1")
        rapor.SetDataSource(dataset)
        CrystalReportViewer1.ReportSource = rapor

    End Sub
End Class