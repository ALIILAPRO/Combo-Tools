Imports System.IO
Imports Microsoft.VisualBasic.CompilerServices

Public Class frm_main
    Private Sub btn_load_Click(sender As Object, e As EventArgs) Handles btn_load.Click
        Dim o As New OpenFileDialog
        o.Filter = "Text File|*.txt"
        If o.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Dim items As String() = File.ReadAllLines(o.FileName)
            Me.listcombo.Items.AddRange(items)
            txtlog.AppendText(Environment.NewLine + "[+] Successfully Loaded Combo : " & (o.SafeFileName))
        End If
    End Sub

    Private Sub btn_getuser_Click(sender As Object, e As EventArgs) Handles btn_getuser.Click
        Dim num As Integer = (Me.listcombo.Items.Count - 1)
        Dim i As Integer = 0
        Do While (i <= num)
            Try
                Dim separator As Char() = New Char() {":"c}
                Dim strArray As String() = Conversions.ToString(Me.listcombo.Items.Item(i)).Split(separator)
                Me.listcombo.Items.Item(i) = strArray(0)
            Catch exception1 As Exception
            End Try
            i += 1
        Loop
        txtlog.AppendText(Environment.NewLine + "[+] Password Successfully Removed Converted To User / E-mail")
    End Sub

    Private Sub frm_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtlog.AppendText("################################################")
        txtlog.AppendText(Environment.NewLine + "[.] - Combo Tools Running")
        txtlog.AppendText(Environment.NewLine + "[.] - App Version 1.0")
        txtlog.AppendText(Environment.NewLine + "[.] - Create By aLiiLaPrO")
        txtlog.AppendText(Environment.NewLine + "################################################")
    End Sub

    Private Sub btn_getpas_Click(sender As Object, e As EventArgs) Handles btn_getpas.Click
        Dim num As Integer = (Me.listcombo.Items.Count - 1)
        Dim i As Integer = 0
        Do While (i <= num)
            Try
                Dim separator As Char() = New Char() {":"c}
                Dim strArray As String() = Conversions.ToString(Me.listcombo.Items.Item(i)).Split(separator)
                Me.listcombo.Items.Item(i) = strArray(1)
            Catch exception1 As Exception
            End Try
            i += 1
        Loop
        txtlog.AppendText(Environment.NewLine + "[+] User/E-mail Successfully Removed Converted To Password")
    End Sub

    Private Sub btn_ctu_Click(sender As Object, e As EventArgs) Handles btn_ctu.Click
        Dim num As Integer = (Me.listcombo.Items.Count - 1)
        Dim i As Integer = 0
        Do While (i <= num)
            Try
                Dim separator As Char() = New Char() {":"c}
                Dim strArray As String() = Conversions.ToString(Me.listcombo.Items.Item(i)).Split(separator)
                Dim str3 As String = strArray(1)
                Dim str2 As String = strArray(0)
                Dim chArray2 As Char() = New Char() {"@"c}
                Dim strArray2 As String() = str2.Split(chArray2)
                Me.listcombo.Items.Item(i) = (strArray2(0) & ":" & str3)
            Catch exception1 As Exception
            End Try
            i += 1
        Loop
        txtlog.AppendText(Environment.NewLine + "[+] Combo Successfully Convert To User:Pass")
    End Sub

    Private Sub btn_cte_Click(sender As Object, e As EventArgs) Handles btn_cte.Click
        Dim num As Integer = (Me.listcombo.Items.Count - 1)
        Dim i As Integer = 0
        Do While (i <= num)
            Try
                Dim separator As Char() = New Char() {":"c}
                Dim strArray As String() = Conversions.ToString(Me.listcombo.Items.Item(i)).Split(separator)
                Me.listcombo.Items.Item(i) = (strArray(0) & ComboBox1.Text & strArray(1))
            Catch exception1 As Exception
            End Try
            i += 1
        Loop
        txtlog.AppendText(Environment.NewLine + "[+] Combo Successfully Convert To E-mail:Pass =>" & ComboBox1.Text & "")
    End Sub

    Private Sub btn_rd_Click(sender As Object, e As EventArgs) Handles btn_rd.Click
        Dim enumerator As IEnumerator
        Dim enumerator2 As IEnumerator
        Dim list As New ArrayList
        Try
            enumerator = Me.listcombo.Items.GetEnumerator
            Do While enumerator.MoveNext
                Dim item As String = Conversions.ToString(enumerator.Current)
                If Not list.Contains(item) Then
                    list.Add(item)
                End If
            Loop
        Finally
            If TypeOf enumerator Is IDisposable Then
                TryCast(enumerator, IDisposable).Dispose()
            End If
        End Try
        Me.listcombo.Items.Clear()

        Try
            enumerator2 = list.GetEnumerator
            Do While enumerator2.MoveNext
                Dim str2 As String = Conversions.ToString(enumerator2.Current)
                Me.listcombo.Items.Add(str2)
            Loop
        Finally
            If TypeOf enumerator2 Is IDisposable Then
                TryCast(enumerator2, IDisposable).Dispose()
            End If
        End Try
        txtlog.AppendText(Environment.NewLine + "[+] Successfully Duplicates Removed")
    End Sub

    Private Sub btn_re_Click(sender As Object, e As EventArgs) Handles btn_re.Click
        Dim num As Integer = (Me.listcombo.Items.Count - 1)
        Dim i As Integer = 0
        Do While (i <= num)
            Try
                Dim str As String = Conversions.ToString(Me.listcombo.Items.Item(i)).Replace(Me.TextBox1.Text, Me.TextBox2.Text)
                Me.listcombo.Items.Item(i) = str
            Catch exception1 As Exception
            End Try
            i += 1
        Loop
        txtlog.AppendText(Environment.NewLine + "[+] Successfully Replaced")
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.listcombo.Items.Clear()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start("https://t.me/source_pro")
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Using saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "txt File (*.txt)|*.txt"
            Dim flag As Boolean = saveFileDialog.ShowDialog() = DialogResult.OK
            If flag Then
                Using streamWriter As New StreamWriter(saveFileDialog.FileName)
                    Dim i As Integer = 0
                    While i < Me.listcombo.Items.Count
                        streamWriter.WriteLine(Me.listcombo.Items(i))
                        System.Math.Max(System.Threading.Interlocked.Increment(i), i - 1)
                    End While
                End Using
            End If
        End Using
    End Sub
End Class