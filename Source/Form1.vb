Imports System.IO
Imports System.Net
Imports DiscordRPC
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports MaterialSkin

' To whoever is reading this, im sorry for what you're about to see
' Welcome to spaghetti code land - enjoy your stay <3
' ~Jayy


Public Class Form1
    Dim CSRF As String = "" '""
    Dim CookieStr As String = "" '""
    Dim client As New DiscordRpcClient("821131144783331358")


    Public Sub updateRPC(ByVal usr As String, ByVal completed As Integer, ByVal qualified As Boolean)
        If qualified Then
            client.SetPresence(New RichPresence() With {
.Details = "⚑ 🏆 [" & completed & "\10] Flags found",
.State = "[" & completed & "\6] to qualify | Logged in as: " + usr,
.Assets = New Assets() With {
.LargeImageKey = "cyber",
.LargeImageText = "Cybermesterskaberne 2021",
.SmallImageKey = "trophy",
.SmallImageText = "Qualified for the Regional Cyberchampionships"
}
})
        Else
            client.SetPresence(New RichPresence() With {
.Details = "⚑ [" & completed & "\10] Flags found",
.State = "[" & completed & "\6] to qualify | Logged in as: " + usr,
.Assets = New Assets() With {
.LargeImageKey = "cyber",
.LargeImageText = "Cybermesterskaberne 2021",
.SmallImageKey = "no",
.SmallImageText = "Not yet qualified for the Regional Cyberchampionships"
}
})
        End If

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Read opt.txt if not found create it
        If System.IO.File.Exists(Application.StartupPath & "\opt.txt") Then
            If Not System.IO.File.ReadAllText(Application.StartupPath & "\opt.txt").Contains("HERE") Then
                CSRF = System.IO.File.ReadAllLines(Application.StartupPath & "\opt.txt")(0)
                CookieStr = System.IO.File.ReadAllLines(Application.StartupPath & "\opt.txt")(1)
            Else
                MsgBox("Please change the values in opt.txt and open the pogram again")
                System.IO.File.WriteAllText(Application.StartupPath & "\opt.txt", "CSRF TOKEN HERE" & Environment.NewLine & "COOKIE HERE")
                Me.Close()
            End If

        Else
            MsgBox("Please change the values in opt.txt and open the pogram again")
            System.IO.File.WriteAllText(Application.StartupPath & "\opt.txt", "CSRF TOKEN HERE" & Environment.NewLine & "COOKIE HERE")
            Me.Close()
        End If

        client.Initialize()
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.DARK
        SkinManager.ColorScheme = New ColorScheme(Primary.DeepOrange600, Primary.DeepOrange800, Primary.DeepOrange800, Accent.Orange700, TextShade.WHITE)
        getSolves()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        getSolves()

    End Sub
    Public Sub handleData(result)

        Dim jsonObj = JObject.Parse(result)
        Dim dataObj = JObject.Parse(JsonConvert.SerializeObject(jsonObj.GetValue("data")))
        username.Text = dataObj.GetValue("name")
        solvesTxt.Text = dataObj.GetValue("score")
        Dim score As Integer = dataObj.GetValue("score")
        If score > 5 Then
            updateRPC(dataObj.GetValue("name"), score, True)
        Else
            updateRPC(dataObj.GetValue("name"), score, False)
        End If
    End Sub
    Public Sub getSolves()
        'https://junior.cybermesterskaberne.dk/api/v1/users/me/solves
        Dim url = "https://junior.cybermesterskaberne.dk/api/v1/users/me"
        Dim httpRequest = CType(WebRequest.Create(url), HttpWebRequest)
        httpRequest.Accept = "application/json"
        httpRequest.Headers("Accept-Encoding") = "gzip, deflate, br"
        httpRequest.Headers("Accept-Language") = "en-US,en;q=0.9"
        httpRequest.Headers("Connection") = "keep-alive"
        httpRequest.ContentType = "application/json"
        httpRequest.Headers("Cookie") = CookieStr
        httpRequest.Headers("CSRF-Token") = CSRF
        httpRequest.Headers("Host") = "junior.cybermesterskaberne.dk"
        httpRequest.Headers("Referer") = "https://junior.cybermesterskaberne.dk/challenges"
        httpRequest.Headers("Sec-Fetch-Dest") = "empty"
        httpRequest.Headers("Sec-Fetch-Mode") = "cors"
        httpRequest.Headers("Sec-Fetch-Site") = "same-origin"
        httpRequest.Headers("User-Agent") = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/87.0.4280.141 Safari/537.36 OPR/73.0.3856.400"
        Dim httpResponse = CType(httpRequest.GetResponse(), HttpWebResponse)

        Using streamReader = New StreamReader(httpResponse.GetResponseStream())
            Dim result = streamReader.ReadToEnd()
            handleData(result)
        End Using

        Console.WriteLine(httpResponse.StatusCode)
    End Sub

End Class
