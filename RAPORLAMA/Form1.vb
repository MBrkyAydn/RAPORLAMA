Imports System.Data.OleDb
Public Class Form1
    Dim baglanti As New OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0; Data Source=bilgiler.mdb")
    Sub guncelle()
        Dim adaptor As New OleDbDataAdapter("SELECT * FROM TABLO1", baglanti)
        Dim tablo As New DataTable()
        adaptor.Fill(tablo)
        DataGridView1.DataSource = tablo


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        guncelle()

    End Sub
    Public sql As String = ""

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sql = "SELECT * FROM TABLO1"
        Form2.ShowDialog()

    End Sub
    Sub temizle()
        TextBox1.Clear()
        TextBox2.Clear()

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (TextBox1.Text <> "") And (TextBox2.Text <> "") Then

            sql = "select * from tablo1 where ADI='" + TextBox1.Text.Trim() + "'AND SOYADI='" + TextBox2.Text.Trim() + "'"
            Dim kaydet As New OleDbCommand(sql, baglanti)
            baglanti.Open()
            Dim varmı As OleDbDataReader = kaydet.ExecuteReader()
            If (varmı.Read()) Then
                Dim sor As Integer

                sor = MessageBox.Show("ARANILAN KAYIT BULUNDU GÖSTERİLSİN Mİ ?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If (sor = DialogResult.Yes) Then
                    Form2.ShowDialog()
                    temizle()
                Else

                    temizle()


                End If

            Else

                MessageBox.Show("KAYIT BULUNAMADI...")



            End If
        guncelle()
        baglanti.Close()

        Else

        MessageBox.Show("müştrei adı veya soyadını gırınız...")

        End If

    End Sub
End Class
