Imports System.Data.OleDb
Public Class Form1
    Dim baglan As New OleDbConnection("provider=microsoft.ace.oledb.12.0; data source=bilgiler.accdb")
    Public Sub ara(veri As String)
        Dim adaptor As New OleDbDataAdapter("select * from tablo1 WHERE ADI+SOYADI+MEMLEKET LIKE '%" + veri + "%' ", baglan)
        Dim tablo As New DataTable
        adaptor.Fill(tablo)
        DataGridView1.DataSource = tablo



    End Sub

    Public Sub hespla1()
        Dim toplam, i As Integer

        For i = 0 To DataGridView1.RowCount - 1

            toplam += DataGridView1.Rows(i).Cells("GELIR").Value()

        Next




        Dim toplam1, j As Integer
        For j = 0 To DataGridView1.RowCount - 1

            toplam1 += DataGridView1.Rows(j).Cells("GIDER").Value()

        Next
        Dim fark As Integer
        fark = toplam - toplam1

        Label1.Text = "GELIRLERIN TOPLAMI : " + toplam.ToString("c2") + "  GIDERLERIN TOPLAMI : " + toplam1.ToString("c2") + "  GELIR VE GIDER FARKI : " + fark.ToString("C2")

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim adap As New OleDbDataAdapter("select * from tablo1", baglan)
        Dim tablo As New DataTable
        adap.Fill(tablo)
        DataGridView1.DataSource = tablo



    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        ara(TextBox1.Text)

        hespla1()

    End Sub
End Class
