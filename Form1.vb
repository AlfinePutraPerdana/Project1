Public Class Form1

    
    
    

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDaftar.Click
        If CBTurnamen.Text = "Dota 2" Then
            TBBiaya.Text = "Rp.200.000"
            BoxTotalHadiah.Text = "Rp.14.000.000"
        ElseIf CBTurnamen.Text = "CounterStrike : Global Offensive" Then
            TBBiaya.Text = "Rp.225.000"
            BoxTotalHadiah.Text = "Rp.14.500.000"
        ElseIf CBTurnamen.Text = "Player Unknown's Battleground" Then
            TBBiaya.Text = "Rp.275.000"
            BoxTotalHadiah.Text = "Rp.15.000.000"
        Else
            MsgBox("Data Yang Dimasukan Tidak Lengkap! ", MsgBoxStyle.Exclamation, "Data Tidak Lengkap!")

        End If
        MsgBox("Selamat! " & TextBoxTeam.Text & " Telah Terdaftar" & vbNewLine & "Informasi akan dikirimkan melalui E-mail anda", MsgBoxStyle.Information, "Terdaftar")
    End Sub

    Private Sub ButtonKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonKeluar.Click
        Close()
    End Sub
End Class
