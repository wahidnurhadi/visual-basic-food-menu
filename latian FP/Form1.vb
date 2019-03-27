Public Class Form1
    Dim tet, tj, ts, tab, tej, ted As Integer
    Dim tr, tng, tp, tba, tl, tsb As Integer

    Private Sub Btnk11_Click(sender As Object, e As EventArgs) Handles Btnk11.Click
        If (Btn11.Text = "Es Teh") Then
            tet = tet - 1
            Jml11.Text = tet
            If tet <= 0 Then
                tet = 0
                Jml11.Text = "0"
            End If
        Else
            tr = tr - 1
            Jml11.Text = tr
            If tr <= 0 Then
                tr = 0
                Jml11.Text = "0"
            End If
        End If
    End Sub

    Private Sub Btnk12_Click(sender As Object, e As EventArgs) Handles Btnk12.Click
        If (Btn12.Text = "Juice") Then
            tj = tj - 1
            Jml12.Text = tj
            If tj <= 0 Then
                tj = 0
                Jml12.Text = "0"
            End If
        Else
            tng = tng - 1
            Jml12.Text = tng
            If tng <= 0 Then
                tng = 0
                Jml12.Text = "0"
            End If
        End If
    End Sub

    Private Sub Btnk21_Click(sender As Object, e As EventArgs) Handles Btnk21.Click
        If (Btn21.Text = "Susu") Then
            ts = ts - 1
            Jml21.Text = ts
            If ts <= 0 Then
                ts = 0
                Jml21.Text = "0"
            End If
        Else
            tp = tp - 1
            Jml21.Text = tp
            If tp <= 0 Then
                tp = 0
                Jml21.Text = "0"
            End If
        End If
    End Sub

    Private Sub Btnk22_Click(sender As Object, e As EventArgs) Handles Btnk22.Click
        If (Btn22.Text = "Air Bening") Then
            tab = tab - 1
            Jml22.Text = tab
            If tab <= 0 Then
                tab = 0
                Jml22.Text = "0"
            End If
        Else
            tba = tba - 1
            Jml22.Text = tba
            If tba <= 0 Then
                tba = 0
                Jml22.Text = "0"
            End If
        End If
    End Sub

    Private Sub Btnk31_Click(sender As Object, e As EventArgs) Handles Btnk31.Click
        If (Btn31.Text = "Es Jeruk") Then
            tej = tej - 1
            Jml31.Text = tej
            If tej <= 0 Then
                tej = 0
                Jml31.Text = "0"
            End If
        Else
            tl = tl - 1
            Jml31.Text = tl
            If tl <= 0 Then
                tl = 0
                Jml31.Text = "0"
            End If
        End If
    End Sub

    Private Sub Btnk32_Click(sender As Object, e As EventArgs) Handles Btnk32.Click
        If (Btn32.Text = "Es Degan") Then
            ted = ted - 1
            Jml32.Text = ted
            If ted <= 0 Then
                ted = 0
                Jml32.Text = "0"
            End If
        Else
            tsb = tsb - 1
            Jml32.Text = tsb
            If tsb <= 0 Then
                tsb = 0
                Jml32.Text = "0"
            End If
        End If
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        tet = 0
        tj = 0
        ts = 0
        tab = 0
        tej = 0
        ted = 0
        tr = 0
        tng = 0
        tp = 0
        tba = 0
        tl = 0
        tsb = 0
        LblTotal.Text = 0
        If (Btn11.Text = "Es Teh") Then
            Jml11.Text = tet
            Jml12.Text = tj
            Jml21.Text = ts
            Jml22.Text = tab
            Jml31.Text = tej
            Jml32.Text = ted
        Else
            Jml11.Text = tr
            Jml12.Text = tng
            Jml21.Text = tp
            Jml22.Text = tba
            Jml31.Text = tl
            Jml32.Text = tsb
        End If
    End Sub

    Dim TotalMakan, TotalMinum, Total As Integer

    Private Sub Btn21_Click(sender As Object, e As EventArgs) Handles Btn21.Click
        If (Btn21.Text = "Susu") Then
            ts = ts + 1
            Jml21.Text = ts
        Else
            tp = tp + 1
            Jml21.Text = tp
        End If
    End Sub

    Private Sub Btn22_Click(sender As Object, e As EventArgs) Handles Btn22.Click
        If (Btn22.Text = "Air Bening") Then
            tab = tab + 1
            Jml22.Text = tab
        Else
            tba = tba + 1
            Jml22.Text = tba
        End If
    End Sub

    Private Sub Btn31_Click(sender As Object, e As EventArgs) Handles Btn31.Click
        If (Btn31.Text = "Es Jeruk") Then
            tej = tej + 1
            Jml31.Text = tej
        Else
            tl = tl + 1
            Jml31.Text = tl
        End If
    End Sub

    Private Sub Btn32_Click(sender As Object, e As EventArgs) Handles Btn32.Click
        If (Btn32.Text = "Es Degan") Then
            ted = ted + 1
            Jml32.Text = ted
        Else
            tsb = tsb + 1
            Jml32.Text = tsb
        End If
    End Sub

    Private Sub BtnTotal_Click(sender As Object, e As EventArgs) Handles BtnTotal.Click
        TotalMakan = (tr * 12000) + (tng * 10000) + (tp * 7000) + (tba * 6000) + (tl * 7000) + (tsb * 8000)
        TotalMinum = (tet * 3000) + (tj * 5000) + (ts * 4000) + (tab * 2000) + (tej * 3000) + (ted * 4000)
        Total = TotalMakan + TotalMinum
        LblTotal.Text = Total
    End Sub

    Private Sub Btn11_Click(sender As Object, e As EventArgs) Handles Btn11.Click
        If (Btn11.Text = "Es Teh") Then
            tet = tet + 1
            Jml11.Text = tet
        Else
            tr = tr + 1
            Jml11.Text = tr
        End If
    End Sub
    Private Sub Btn12_Click(sender As Object, e As EventArgs) Handles Btn12.Click
        If (Btn12.Text = "Juice") Then
            tj = tj + 1
            Jml12.Text = tj
        Else
            tng = tng + 1
            Jml12.Text = tng
        End If
    End Sub


    Private Sub BtnMakanan_Click(sender As Object, e As EventArgs) Handles BtnMakanan.Click
        Btn11.Text = "Rendang"
        Btn12.Text = "Nasi Goreng"
        Btn21.Text = "Pechel"
        Btn22.Text = "Bubur Ayam"
        Btn31.Text = "Lele"
        Btn32.Text = "Seblak"
        Jml11.Text = tr
        Jml12.Text = tng
        Jml21.Text = tp
        Jml22.Text = tba
        Jml31.Text = tl
        Jml32.Text = tsb
    End Sub

    Private Sub BtnMinuman_Click(sender As Object, e As EventArgs) Handles BtnMinuman.Click
        Btn11.Text = "Es Teh"
        Btn12.Text = "Juice"
        Btn21.Text = "Susu"
        Btn22.Text = "Air Bening"
        Btn31.Text = "Es Jeruk"
        Btn32.Text = "Es Degan"
        Jml11.Text = tet
        Jml12.Text = tj
        Jml21.Text = ts
        Jml22.Text = tab
        Jml31.Text = tej
        Jml32.Text = ted

    End Sub

End Class

