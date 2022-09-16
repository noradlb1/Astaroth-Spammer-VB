Imports System.Windows.Forms
Imports System.Threading
Imports System
Imports System.Diagnostics
Imports System.Runtime
Imports System.Runtime.InteropServices
Imports MetroSuite
Imports System.Collections.Generic
Imports Leaf.xNet
Imports System.Threading.Tasks
Imports System.Linq

Partial Public Class MainForm
	Inherits MetroForm

	<DllImport("psapi.dll")> _
	Shared Function EmptyWorkingSet(ByVal hwProc As IntPtr) As Integer
	End Function

	<DllImport("kernel32.dll")> _
	Private Shared Function SetProcessWorkingSetSize(ByVal process As IntPtr, ByVal minimumWorkingSetSize As UIntPtr, ByVal maximumWorkingSetSize As UIntPtr) As <MarshalAs(UnmanagedType.Bool)> Boolean
	End Function

	Public clients As New List(Of DiscordClient)()
	Public invalidTokens As New List(Of String)()
	Public doneCheckingTokens As Integer = 0

	Public proxies As New List(Of String)()
	Public invalidProxies As New List(Of String)()
	Public doneCheckingProxies As Integer = 0
	Public proxyIndex As Integer = 0

	Public serverSpammer, dmSpammer, typingSpammer, webhookSpammer, massDmAdvertiser As Boolean
	Public multipleMessageIndex As Integer = 0, multipleDmMessageIndex As Integer = 0, multipleWebhookMessageIndex As Integer = 0, multipleDmAdvertiserMessageIndex As Integer = 0, tagAllIndex As Integer = 0, rolesTagAllIndex As Integer = 0
	Public completedUsers As Integer = 0

	Private mediaFormats() As String = { "jpg", "png", "bmp", "jpeg", "jfif", "jpe", "rle", "dib", "svg", "svgz" }
	Public tokensChanged As Boolean

	Public Function GetClients() As List(Of DiscordClient)
		If siticoneCheckBox37.Checked Then
			Dim theClients As New List(Of DiscordClient)()

			Dim limited As Integer = 1
			Dim coso As String = gunaLineTextBox23.Text.Replace(" ", "").Replace(ControlChars.Tab.ToString(), "")

			If coso.Length <= 6 Then
				If Microsoft.VisualBasic.Information.IsNumeric(coso) Then
					Dim temp As Integer = Integer.Parse(coso)

					If Not(temp <= 0) Then
						limited = temp
					End If
				End If
			End If

			Dim i As Integer = 0

			For Each client As DiscordClient In Me.clients
				If i = limited Then
					Exit For
				End If

				theClients.Add(clients(i))
				i += 1
			Next client

			Return theClients
		End If

		Return Me.clients
	End Function

	Public Function GetProxy() As HttpProxyClient
		Try
			If siticoneCheckBox23.Checked Then
				Try
					If proxyIndex >= proxies.Count Then
						proxyIndex = -1
					End If

					proxyIndex += 1

					If proxyIndex >= proxies.Count Then
						proxyIndex = 0
					End If

					Return Utils.ParseProxy(proxies(proxyIndex))
				Catch
					Return Nothing
				End Try
			Else
				Return Nothing
			End If

			Return Nothing
		Catch
			Return Nothing
		End Try
	End Function

	Public Sub New()
		Try
			InitializeComponent()

			tokensChanged = True

			Try
				If Not System.IO.File.Exists("tokens.txt") Then
					System.IO.File.WriteAllText("tokens.txt", "")
				Else
					LoadTokens("tokens.txt")
				End If
			Catch

			End Try

			Try
				If Not System.IO.File.Exists("proxies.txt") Then
					System.IO.File.WriteAllText("proxies.txt", "")
				Else
					LoadProxies("proxies.txt")
				End If
			Catch

			End Try

			CheckForIllegalCrossThreadCalls = False

			siticoneComboBox2.SelectedIndex = 0
			siticoneComboBox1.SelectedIndex = 0

			Dim updateAllThread As New Thread(AddressOf updateAll)
			updateAllThread.Start()

			openFileDialog5.Filter = "All files (*.*)|*.*"

			For Each format As String In mediaFormats
				openFileDialog5.Filter &= "|" & format.ToUpper() & " Image (*." & format & ")|*." & format
			Next format
		Catch

		End Try
	End Sub

	Public Sub save()
		Try
			Dim allProxies As String = "", allTokens As String = ""

			Try
				For Each proxy As String In proxies
					Try
						If allProxies = "" Then
							allProxies = proxy
						Else
							allProxies &= Environment.NewLine & proxy
						End If
					Catch

					End Try
				Next proxy
			Catch

			End Try

			Try
				System.IO.File.WriteAllText("proxies.txt", allProxies)
			Catch

			End Try

			Try
				For Each client As DiscordClient In clients
					Try
						If allTokens = "" Then
							allTokens = client.token
						Else
							allTokens &= Environment.NewLine & client.token
						End If
					Catch

					End Try
				Next client
			Catch

			End Try

			Try
				System.IO.File.WriteAllText("tokens.txt", allTokens)
			Catch

			End Try
		Catch

		End Try
	End Sub

	Public Sub updateAll()
		Do
			Try
				Thread.Sleep(1000)

				Try
					If metroLabel14.Text = "0" Then
						invalidTokens.Clear()
						doneCheckingTokens = 0
						siticoneButton2.Enabled = True
						siticoneButton2.Text = "Remove dead tokens"
						metroLabel14.Text = clients.Count.ToString()
						siticoneButton1.Enabled = True
					End If

					If clients.Count = 0 Then
						metroLabel14.Text = "0"
					End If

					If metroLabel15.Text = "0" Then
						invalidProxies.Clear()
						doneCheckingProxies = 0
						siticoneButton3.Enabled = True
						siticoneButton3.Text = "Remove dead proxies"
						metroLabel15.Text = proxies.Count.ToString()
						siticoneButton4.Enabled = True
					End If

					If proxies.Count = 0 Then
						metroLabel15.Text = "0"
					End If

					If Utils.users.Count = 0 Then
						siticoneCheckBox7.Text = "Mass Mention"
					Else
						siticoneCheckBox7.Text = "Mass Mention (" & Utils.users.Count.ToString() & ")"
					End If

					If gunaLineTextBox4.Text.Contains(",") Then
						siticoneCheckBox8.Text = "Multiple Channels (" & Microsoft.VisualBasic.Strings.Split(gunaLineTextBox4.Text, ",").Length.ToString() & ")"
					Else
						siticoneCheckBox8.Text = "Multiple Channels"
					End If

					If gunaTextBox1.Text.Contains("|") Then
						siticoneCheckBox9.Text = "Multiple Messages (" & Microsoft.VisualBasic.Strings.Split(gunaTextBox1.Text, "|").Length.ToString() & ")"
					Else
						siticoneCheckBox9.Text = "Multiple Messages"
					End If

					If gunaLineTextBox6.Text.Contains(",") Then
						siticoneCheckBox11.Text = "Multiple Users (" & Microsoft.VisualBasic.Strings.Split(gunaLineTextBox6.Text, ",").Length.ToString() & ")"
					Else
						siticoneCheckBox11.Text = "Multiple Users"
					End If

					If gunaTextBox2.Text.Contains("|") Then
						siticoneCheckBox12.Text = "Multiple Messages (" & Microsoft.VisualBasic.Strings.Split(gunaTextBox2.Text, "|").Length.ToString() & ")"
					Else
						siticoneCheckBox12.Text = "Multiple Messages"
					End If

					If gunaLineTextBox11.Text.Contains(",") Then
						siticoneCheckBox5.Text = "Multiple Friends (" & Microsoft.VisualBasic.Strings.Split(gunaLineTextBox11.Text, ",").Length.ToString() & ")"
					Else
						siticoneCheckBox5.Text = "Multiple Friends"
					End If

					If gunaLineTextBox12.Text.Contains(",") Then
						siticoneCheckBox13.Text = "Multiple Channels (" & Microsoft.VisualBasic.Strings.Split(gunaLineTextBox12.Text, ",").Length.ToString() & ")"
					Else
						siticoneCheckBox13.Text = "Multiple Channels"
					End If

					If gunaLineTextBox17.Text.Contains(",") Then
						siticoneCheckBox22.Text = "Multiple Webhooks (" & Microsoft.VisualBasic.Strings.Split(gunaLineTextBox17.Text, ",").Length.ToString() & ")"
					Else
						siticoneCheckBox22.Text = "Multiple Webhooks"
					End If

					If gunaTextBox3.Text.Contains("|") Then
						siticoneCheckBox27.Text = "Multiple Messages (" & Microsoft.VisualBasic.Strings.Split(gunaTextBox3.Text, "|").Length.ToString() & ")"
					Else
						siticoneCheckBox27.Text = "Multiple Messages"
					End If

					metroLabel8.Text = "Parsed users: " & Utils.users.Count.ToString() & ", completed users: " & completedUsers.ToString()

					If gunaTextBox4.Text.Contains("|") Then
						siticoneCheckBox28.Text = "Multiple Messages (" & Microsoft.VisualBasic.Strings.Split(gunaTextBox4.Text, "|").Length.ToString() & ")"
					Else
						siticoneCheckBox28.Text = "Multiple Messages"
					End If

					If completedUsers = Utils.users.Count Then
						gunaButton20.Enabled = False
						CType(New Thread(AddressOf reEnableDMAdvertiser), Thread).Start()
					End If

					If Utils.roles.Count = 0 Then
						siticoneCheckBox29.Text = "Roles Mention"
					Else
						siticoneCheckBox29.Text = "Roles Mention (" & Utils.roles.Count.ToString() & ")"
					End If

					metroLabel32.Text = Utils.users.Count.ToString()
					metroLabel33.Text = Utils.roles.Count.ToString()

					If pictureBox2.BackgroundImage Is Nothing Then
						siticoneButton22.Enabled = False
					Else
						siticoneButton22.Enabled = True
					End If

					If tokensChanged Then
						tokensChanged = False
						save()
					End If
				Catch

				End Try
			Catch

			End Try
		Loop
	End Sub

	Public Function getTagAllUser() As String
		Try
			If tagAllIndex >= Utils.users.Count Then
				tagAllIndex = -1
			End If

			tagAllIndex += 1

			If tagAllIndex >= Utils.users.Count Then
				tagAllIndex = 0
			End If

			Return Utils.users(tagAllIndex)
		Catch

		End Try

		Return ""
	End Function

	Public Function getTagAllRole() As String
		Try
			If rolesTagAllIndex >= Utils.roles.Count Then
				rolesTagAllIndex = -1
			End If

			rolesTagAllIndex += 1

			If rolesTagAllIndex >= Utils.roles.Count Then
				rolesTagAllIndex = 0
			End If

			Return Utils.roles(rolesTagAllIndex)
		Catch

		End Try

		Return ""
	End Function

	Private Sub MainForm_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
		Try
			Process.GetCurrentProcess().Kill()
		Catch

		End Try
	End Sub

	Private Sub bunifuHSlider1_Scroll(ByVal sender As Object, ByVal e As Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs) Handles bunifuHSlider1.Scroll
		Try
			metroLabel17.Text = "Delay: " & bunifuHSlider1.Value.ToString() & "ms"
		Catch

		End Try
	End Sub

	Private Sub bunifuHSlider2_Scroll(ByVal sender As Object, ByVal e As Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs) Handles bunifuHSlider2.Scroll
		Try
			metroLabel18.Text = "Delay: " & bunifuHSlider2.Value.ToString() & "ms"
		Catch

		End Try
	End Sub

	Private Sub bunifuHSlider3_Scroll(ByVal sender As Object, ByVal e As Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs) Handles bunifuHSlider3.Scroll
		Try
			metroLabel19.Text = "Delay: " & bunifuHSlider3.Value.ToString() & "ms"
		Catch

		End Try
	End Sub

	Private Sub bunifuHSlider4_Scroll(ByVal sender As Object, ByVal e As Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs) Handles bunifuHSlider4.Scroll
		Try
			metroLabel20.Text = "Delay: " & bunifuHSlider4.Value.ToString() & "ms"
		Catch

		End Try
	End Sub

	Private Sub bunifuHSlider5_Scroll(ByVal sender As Object, ByVal e As Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs) Handles bunifuHSlider5.Scroll
		Try
			metroLabel21.Text = "Delay: " & bunifuHSlider5.Value.ToString() & "ms"
		Catch

		End Try
	End Sub

	Private Sub bunifuHSlider6_Scroll(ByVal sender As Object, ByVal e As Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs) Handles bunifuHSlider6.Scroll
		Try
			metroLabel22.Text = "Delay: " & bunifuHSlider6.Value.ToString() & "ms"
		Catch

		End Try
	End Sub

	Private Sub bunifuHSlider9_Scroll(ByVal sender As Object, ByVal e As Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs) Handles bunifuHSlider9.Scroll
		Try
			metroLabel25.Text = "Delay: " & bunifuHSlider9.Value.ToString() & "ms"
		Catch

		End Try
	End Sub

	Private Sub bunifuHSlider10_Scroll(ByVal sender As Object, ByVal e As Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs) Handles bunifuHSlider10.Scroll
		Try
			metroLabel26.Text = "Auto end: " & bunifuHSlider10.Value.ToString() & "ms"
		Catch

		End Try
	End Sub

	Private Sub bunifuHSlider11_Scroll(ByVal sender As Object, ByVal e As Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs) Handles bunifuHSlider11.Scroll
		Try
			metroLabel27.Text = "Delay: " & bunifuHSlider11.Value.ToString() & "ms"
		Catch

		End Try
	End Sub

	Private Sub bunifuHSlider12_Scroll(ByVal sender As Object, ByVal e As Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs) Handles bunifuHSlider12.Scroll
		Try
			metroLabel28.Text = "Delay: " & bunifuHSlider12.Value.ToString() & "ms"
		Catch

		End Try
	End Sub

	Private Sub gunaLinkLabel1_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs) Handles gunaLinkLabel1.LinkClicked
		Try
			Process.Start(gunaLinkLabel1.Text)
		Catch

		End Try
	End Sub

	Private Sub siticoneButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles siticoneButton1.Click
		' Homepage - Reset Tokens
		Try
			clients.Clear()
			metroLabel14.Text = "0"

			invalidTokens.Clear()
			doneCheckingTokens = 0
			siticoneButton2.Enabled = True
			siticoneButton2.Text = "Remove dead tokens"
			tokensChanged = True
		Catch

		End Try
	End Sub

	Private Sub siticoneButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles siticoneButton2.Click
		' Homepage - Remove dead tokens
		Try
			invalidTokens.Clear()
			doneCheckingTokens = 0
			siticoneButton2.Enabled = False
			siticoneButton1.Enabled = False
			siticoneButton2.Text = "Removing dead tokens..."
			Dim thread As New Thread(AddressOf CheckTokens)

			thread.Start()
		Catch

		End Try
	End Sub

	Public Sub CheckTokens()
		Try
			Try
				For Each client As DiscordClient In clients
					Try
						If Not siticoneButton2.Enabled Then
							'Thread.Sleep(45)

							Dim thread As New Thread(Sub() CheckToken(client))

							thread.Start()
						End If
					Catch

					End Try
				Next client
			Catch

			End Try

			Try
				Do While doneCheckingTokens <> clients.Count

				Loop
			Catch

			End Try

			metroLabel14.Text = (clients.Count).ToString()

			For Each token As String In invalidTokens
				Try
					For Each client As DiscordClient In clients
						Try
							If client.token = token Then
								clients.Remove(client)
								metroLabel14.Text = (clients.Count).ToString()

								Exit For
							End If
						Catch

						End Try
					Next client
				Catch

				End Try
			Next token

			invalidTokens.Clear()
			doneCheckingTokens = 0
			siticoneButton2.Enabled = True
			siticoneButton2.Text = "Remove dead tokens"
			metroLabel14.Text = clients.Count.ToString()
			siticoneButton1.Enabled = True
			tokensChanged = True
		Catch

		End Try
	End Sub

	Public Sub CheckToken(ByVal client As DiscordClient)
		Try
			If Not siticoneButton2.Enabled Then
				If Not Utils.IsTokenValid(client.token) Then
					invalidTokens.Add(client.token)
					metroLabel14.Text = (clients.Count - invalidTokens.Count).ToString()
				End If

				doneCheckingTokens += 1
			End If
		Catch

		End Try
	End Sub

	Private Sub siticoneButton5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles siticoneButton5.Click
		' Homepage - Load Tokens
		Try
			If openFileDialog1.ShowDialog() = DialogResult.OK Then
				Try
					For Each fileName As String In openFileDialog1.FileNames
						Try
							LoadTokens(fileName)
						Catch

						End Try
					Next fileName
				Catch

				End Try
			End If
		Catch

		End Try
	End Sub

	Public Sub LoadTokens(ByVal fileName As String)
		For Each token As String In Utils.SplitToLines(System.IO.File.ReadAllText(fileName))
			Try
				Dim tok As String = Utils.GetCleanToken(token)
				Dim inserted As Boolean = False

				If Not Utils.IsTokenFormatValid(tok) Then
					Continue For
				End If

				Try
					For Each client As DiscordClient In clients
						Try
							If client.token = tok Then
								inserted = True
								Exit For
							End If
						Catch

						End Try
					Next client
				Catch

				End Try

				If Not inserted Then
					clients.Add(New DiscordClient(tok))
					metroLabel14.Text = clients.Count.ToString()
				End If
			Catch

			End Try
		Next token

		tokensChanged = True
	End Sub

	Private Sub siticoneButton4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles siticoneButton4.Click
		' Homepage - Reset Proxies
		Try
			proxies.Clear()
			metroLabel15.Text = "0"

			invalidProxies.Clear()
			doneCheckingProxies = 0
			siticoneButton3.Enabled = True
			siticoneButton3.Text = "Remove dead proxies"
			tokensChanged = True
		Catch

		End Try
	End Sub

	Private Sub siticoneButton3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles siticoneButton3.Click
		' Homepage - Remove dead proxies
		Try
			invalidProxies.Clear()
			doneCheckingProxies = 0
			siticoneButton3.Enabled = False
			siticoneButton4.Enabled = False
			siticoneButton3.Text = "Removing dead proxies..."
			Dim thread As New Thread(AddressOf CheckProxies)

			thread.Start()
		Catch

		End Try
	End Sub

	Public Sub CheckProxies()
		Try
			For Each proxy As String In proxies
				Try
					If Not siticoneButton3.Enabled Then
						'Thread.Sleep(45)

						Dim thread As New Thread(Sub() CheckProxy(proxy))

						thread.Start()
					End If
				Catch

				End Try
			Next proxy

			Try
				Do While doneCheckingProxies <> proxies.Count

				Loop
			Catch

			End Try

			metroLabel15.Text = (proxies.Count).ToString()

			Try
				For Each proxy As String In invalidProxies
					Try
						For Each anotherProxy As String In proxies
							Try
								If proxy = anotherProxy Then
									proxies.Remove(proxy)
									metroLabel15.Text = (proxies.Count).ToString()

									Exit For
								End If
							Catch

							End Try
						Next anotherProxy
					Catch

					End Try
				Next proxy
			Catch

			End Try

			invalidProxies.Clear()
			doneCheckingProxies = 0
			siticoneButton3.Enabled = True
			siticoneButton3.Text = "Remove dead proxies"
			metroLabel15.Text = proxies.Count.ToString()
			siticoneButton4.Enabled = True
			tokensChanged = True
		Catch

		End Try
	End Sub

	Public Sub CheckProxy(ByVal proxy As String)
		Try
			If Not siticoneButton3.Enabled Then
				If Not Utils.IsProxyValid(proxy) Then
					invalidProxies.Add(proxy)
					metroLabel15.Text = (proxies.Count - invalidProxies.Count).ToString()
				End If

				doneCheckingProxies += 1
			End If
		Catch

		End Try
	End Sub

	Private Sub siticoneButton6_Click(ByVal sender As Object, ByVal e As EventArgs) Handles siticoneButton6.Click
		' Homepage - Load Proxies
		Try
			If openFileDialog2.ShowDialog() = DialogResult.OK Then
				Try
					For Each fileName As String In openFileDialog2.FileNames
						Try
							LoadProxies(fileName)
						Catch

						End Try
					Next fileName
				Catch

				End Try
			End If
		Catch

		End Try

		tokensChanged = True
	End Sub

	Public Sub LoadProxies(ByVal fileName As String)
		Try
			For Each proxy As String In Utils.SplitToLines(System.IO.File.ReadAllText(fileName))
				Try
					Dim prxy As String = Utils.GetCleanToken(proxy)
					Dim inserted As Boolean = False

					If Not Utils.IsProxyFormatValid(prxy) Then
						Continue For
					End If

					Try
						For Each theProxy As String In proxies
							Try
								If theProxy = prxy Then
									inserted = True
									Exit For
								End If
							Catch

							End Try
						Next theProxy
					Catch

					End Try

					If Not inserted Then
						proxies.Add(prxy)
						metroLabel15.Text = proxies.Count.ToString()
					End If
				Catch

				End Try
			Next proxy
		Catch

		End Try
	End Sub

	Private Sub gunaButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles gunaButton1.Click
		' Guild Manager - Join guild
		Try
			If siticoneCheckBox3.Checked Then
				If Not Utils.IsCaptchaKeyValid(gunaLineTextBox20.Text) Then
					MessageBox.Show("The 2Captcha key is not valid! Go to insert a new valid one on the section 'Settings and Utils'.", "AstarothSpammer", MessageBoxButtons.OK, MessageBoxIcon.Error)
					Return
				End If
			End If

			Dim thread As New Thread(Sub() JoinGuild(gunaLineTextBox1.Text, gunaLineTextBox2.Text, gunaLineTextBox3.Text, siticoneCheckBox1.Checked, siticoneCheckBox2.Checked, siticoneCheckBox3.Checked, siticoneCheckBox4.Checked))
			thread.Start()
		Catch

		End Try
	End Sub

	Public Sub JoinGuild(ByVal theInvite As String, ByVal captchaBotID As String, ByVal captchaBotChannelID As String, ByVal communityRules As Boolean, ByVal reactionVerification As Boolean, ByVal captchaBot As Boolean, ByVal groupMode As Boolean)
		Try
			Dim invite As DiscordInvite = Utils.GetInviteInformations(theInvite, groupMode)

			If Not invite.valid Then
				MessageBox.Show("The inserted invite link / code is not valid! Check if the invite is valid and check if you got rate limited from the Discord API.", "AstarothSpammer", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Else
				If siticoneCheckBox33.Checked Then
					gunaButton1.Enabled = False
					gunaButton2.Enabled = True
				End If

				Dim contextProperties As String = ""

				If Not groupMode Then
					contextProperties = Utils.GetXCP(invite)
				Else
					contextProperties = Utils.GetGroupXCP(invite)
				End If

				For Each client As DiscordClient In Me.GetClients()
					Try
						'Thread.Sleep(5)

						If siticoneOSToggleSwith1.Checked Then
							'Thread.Sleep(bunifuHSlider1.Value)
						End If

						Dim thread As New Thread(Sub() ClientJoin(client, invite, contextProperties, captchaBotID, captchaBotChannelID, communityRules, reactionVerification, captchaBot, groupMode, GetProxy(), gunaLineTextBox20.Text))
						thread.Start()
					Catch

					End Try
				Next client
			End If
		Catch

		End Try
	End Sub

	Public Sub ClientJoin(ByVal client As DiscordClient, ByVal invite As DiscordInvite, ByVal contextProperties As String, ByVal captchaBotID As String, ByVal captchaBotChannelID As String, ByVal communityRules As Boolean, ByVal reactionVerification As Boolean, ByVal captchaBot As Boolean, ByVal groupMode As Boolean, ByVal proxyClient As HttpProxyClient, ByVal captchaKey As String)
		If siticoneCheckBox33.Checked Then
			Do While siticoneCheckBox33.Checked AndAlso gunaButton2.Enabled
				Thread.Sleep(5)

				If siticoneOSToggleSwith1.Checked Then
					Thread.Sleep(bunifuHSlider1.Value)
				End If

				client.JoinGuild(invite, contextProperties, captchaBotID, captchaBotChannelID, communityRules, reactionVerification, captchaBot, groupMode, proxyClient, captchaKey)

				Thread.Sleep(5)

				If siticoneOSToggleSwith1.Checked Then
					Thread.Sleep(bunifuHSlider1.Value)
				End If

				client.LeaveGuild(invite, groupMode, proxyClient)
			Loop
		Else
			client.JoinGuild(invite, contextProperties, captchaBotID, captchaBotChannelID, communityRules, reactionVerification, captchaBot, groupMode, proxyClient, captchaKey)
		End If
	End Sub


	Private Sub gunaButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles gunaButton2.Click
		' Guild Manager - Leave guild

		Try
			If siticoneCheckBox33.Checked Then
				gunaButton2.Enabled = False
				gunaButton1.Enabled = True
				Return
			End If

			Dim thread As New Thread(Sub() LeaveGuild(gunaLineTextBox1.Text, siticoneCheckBox4.Checked))
			thread.Start()
		Catch

		End Try
	End Sub

	Public Sub LeaveGuild(ByVal guildInviteID As String, ByVal groupMode As Boolean)
		Try
			If Not Utils.IsIDValid(guildInviteID) Then
				Dim invite As DiscordInvite = Utils.GetInviteInformations(guildInviteID, groupMode)

				If Not invite.valid Then
					MessageBox.Show("The inserted invite link / code / ID is not valid! Check if the invite is valid and check if you got rate limited from the Discord API, try also to use the right guild ID.", "AstarothSpammer", MessageBoxButtons.OK, MessageBoxIcon.Error)
				Else
					For Each client As DiscordClient In Me.GetClients()
						Try
							'Thread.Sleep(5)

							If siticoneOSToggleSwith1.Checked Then
								'Thread.Sleep(bunifuHSlider1.Value)
							End If

							Dim thread As New Thread(Sub() client.LeaveGuild(invite, groupMode, GetProxy()))
							thread.Start()
						Catch

						End Try
					Next client
				End If
			Else
				For Each client As DiscordClient In Me.GetClients()
					Try
						'Thread.Sleep(5)

						If siticoneOSToggleSwith1.Checked Then
							'Thread.Sleep(bunifuHSlider1.Value)
						End If

						Dim thread As New Thread(Sub() client.LeaveGuild(guildInviteID, groupMode, GetProxy()))
						thread.Start()
					Catch

					End Try
				Next client
			End If
		Catch

		End Try
	End Sub

	Public Function GetServerSpam() As Integer
		Try
			If siticoneRadioButton3.Checked Then
				Return 0
			ElseIf siticoneRadioButton4.Checked Then
				Return 1
			Else
				Return 2
			End If
		Catch
			Return 0
		End Try
	End Function

	Public Sub SetServerSpam(ByVal status As Integer)
		Try
			If status = 0 Then
				siticoneRadioButton3.Checked = True
			ElseIf status = 1 Then
				siticoneRadioButton4.Checked = True
			Else
				siticoneRadioButton5.Checked = True
			End If
		Catch

		End Try
	End Sub

	Private Sub gunaButton4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles gunaButton4.Click
		' Server Spammer - Start Spamming
		Try
			rolesTagAllIndex = 0
			tagAllIndex = 0
			Dim actual As Integer = GetServerSpam()
			gunaButton4.Enabled = False
			gunaButton3.Enabled = True
			SetServerSpam(actual)

			If siticoneCheckBox8.Checked Then
				If Not Utils.AreIDsValid(gunaLineTextBox4.Text) Then
					MessageBox.Show("The IDs of the channels are not valid!", "AstarothSpammer", MessageBoxButtons.OK, MessageBoxIcon.Error)

					gunaButton3.Enabled = False
					gunaButton4.Enabled = True

					Return
				End If
			Else
				If Not Utils.IsIDValid(gunaLineTextBox4.Text) Then
					MessageBox.Show("The ID of the channel is not valid!", "AstarothSpammer", MessageBoxButtons.OK, MessageBoxIcon.Error)

					gunaButton3.Enabled = False
					gunaButton4.Enabled = True

					Return
				End If
			End If

			Dim thread As New Thread(AddressOf DoServerSpammer)

			thread.Start()
		Catch

		End Try
	End Sub

	Private Sub gunaButton3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles gunaButton3.Click
		' Server Spammer - Stop Spamming
		Try
			serverSpammer = False
			CType(New Thread(AddressOf reEnableServerSpammer), Thread).Start()
		Catch

		End Try
	End Sub

	Public Sub reEnableServerSpammer()
		Try
			If siticoneOSToggleSwith2.Checked Then
				Thread.Sleep(bunifuHSlider2.Value)
			End If

			rolesTagAllIndex = 0
			tagAllIndex = 0
			gunaButton3.Enabled = False
			gunaButton4.Enabled = True
		Catch

		End Try
	End Sub

	Public Sub DoServerSpammer()
		Try
			serverSpammer = True

			For Each client As DiscordClient In Me.GetClients()
				Thread.Sleep(5)

				Try
					Dim times As Integer = 1

					If siticoneRadioButton4.Checked Then
						times = 2
					ElseIf siticoneRadioButton5.Checked Then
						times = 10
					End If

					Dim proxyClient As HttpProxyClient = GetProxy()

					For i As Integer = 0 To times - 1
						Try
							If siticoneCheckBox8.Checked Then
								For Each id As String In Utils.GetIDs(gunaLineTextBox4.Text)
									Thread.Sleep(5)

									Try
										'Thread.Sleep(5)

										If siticoneOSToggleSwith2.Checked Then
											'Thread.Sleep(bunifuHSlider2.Value)
										End If

										Dim thread As New Thread(Sub() SpamServer(client, id, proxyClient))

										thread.Start()
									Catch

									End Try
								Next id
							Else
								Try
									'Thread.Sleep(5)

									If siticoneOSToggleSwith2.Checked Then
										'Thread.Sleep(bunifuHSlider2.Value)
									End If

									Dim thread As New Thread(Sub() SpamServer(client, gunaLineTextBox4.Text, proxyClient))

									thread.Start()
								Catch

								End Try
							End If
						Catch

						End Try
					Next i
				Catch

				End Try
			Next client
		Catch

		End Try
	End Sub

	Public Function getServerSpamMessage() As String
		Dim msg As String = ""

		Try
			Try
				If Not siticoneCheckBox9.Checked Then
					Dim lines As New List(Of String)()

					For Each line As String In Utils.SplitToLines(gunaTextBox1.Text)
						lines.Add(line)
					Next line

					If lines.Count <> 1 Then
						For Each line As String In lines
							msg = msg & " \u000d" & line
						Next line
					Else
						msg = gunaTextBox1.Text
					End If
				Else
					If multipleMessageIndex < 0 Then
						multipleMessageIndex = 0
					End If

					Dim count As Integer = 0

					For Each c As Char In gunaTextBox1.Text.ToCharArray()
						If c = "|"c Then
							count += 1
						End If
					Next c

					If multipleMessageIndex > count Then
						multipleMessageIndex = 0
					End If

					If count = 0 Then
						Dim lines As New List(Of String)()

						For Each line As String In Utils.SplitToLines(gunaTextBox1.Text)
							lines.Add(line)
						Next line

						If lines.Count <> 1 Then
							For Each line As String In lines
								msg = msg & " \u000d" & line
							Next line
						Else
							msg = gunaTextBox1.Text
						End If

						multipleMessageIndex += 1
					ElseIf count = 1 AndAlso Microsoft.VisualBasic.Strings.Split(gunaTextBox1.Text, "|")(1).Replace(" ", "").Replace(ControlChars.Tab.ToString(), "").Trim() = "" Then
						Dim splitted() As String = Microsoft.VisualBasic.Strings.Split(gunaTextBox1.Text, "|")
						Dim definitive As String = splitted(0)
						Dim lines As New List(Of String)()

						For Each line As String In Utils.SplitToLines(definitive)
							lines.Add(line)
						Next line

						If lines.Count <> 1 Then
							For Each line As String In lines
								msg = msg & " \u000d" & line
							Next line
						Else
							msg = definitive
						End If

						multipleMessageIndex += 1
					Else
						Dim splitted() As String = Microsoft.VisualBasic.Strings.Split(gunaTextBox1.Text, "|")
						Dim definitive As String = splitted(multipleMessageIndex)
						Dim lines As New List(Of String)()

						For Each line As String In Utils.SplitToLines(definitive)
							lines.Add(line)
						Next line

						If lines.Count <> 1 Then
							For Each line As String In lines
								msg = msg & " \u000d" & line
							Next line
						Else
							msg = definitive
						End If

						If multipleMessageIndex = count Then
							multipleMessageIndex = 0
						Else
							multipleMessageIndex += 1
						End If
					End If
				End If
			Catch

			End Try

			If Utils.users.Count = 0 Then
				msg = msg.Replace("[mtag]", "")
				msg = msg.Replace("[all]", "")
			End If

			If Utils.roles.Count = 0 Then
				msg = msg.Replace("[rtag]", "")
				msg = msg.Replace("[rall]", "")
			End If

			If siticoneCheckBox7.Checked Then
				Try
					Do While msg.Contains("[mtag]")
						Try
'INSTANT VB NOTE: The variable tag was renamed since Visual Basic does not handle local variables named the same as class members well:
							Dim tag_Renamed As String = getTagAllUser()

							If tag_Renamed <> "" Then
								msg = Utils.ReplaceFirst(msg, "[mtag]", " <@" & tag_Renamed & "> ")
							End If
						Catch

						End Try
					Loop
				Catch

				End Try

				Try
					Dim allUsers As String = ""

					For Each user As String In Utils.users
						allUsers &= "<@" & user & "> "
					Next user

					allUsers = allUsers.Substring(0, allUsers.Length - 1)
					msg = msg.Replace("[all]", allUsers)
				Catch

				End Try
			Else
				msg = msg.Replace(" [mtag] ", "")
				msg = msg.Replace(" [mtag]", "")
				msg = msg.Replace("[mtag]", "")

				msg = msg.Replace(" [all] ", "")
				msg = msg.Replace(" [all]", "")
				msg = msg.Replace("[all]", "")
			End If

			If siticoneCheckBox29.Checked Then
				Try
					Do While msg.Contains("[rtag]")
						Try
'INSTANT VB NOTE: The variable tag was renamed since Visual Basic does not handle local variables named the same as class members well:
							Dim tag_Renamed As String = getTagAllRole()

							If tag_Renamed <> "" Then
								msg = Utils.ReplaceFirst(msg, "[rtag]", " <@&" & tag_Renamed & "> ")
							End If
						Catch

						End Try
					Loop
				Catch

				End Try

				Try
					Dim allRoles As String = ""

					For Each role As String In Utils.roles
						allRoles &= "<@&" & role & "> "
					Next role

					allRoles = allRoles.Substring(0, allRoles.Length - 1)
					msg = msg.Replace("[rall]", allRoles)
				Catch

				End Try
			Else
				msg = msg.Replace(" [rtag] ", "")
				msg = msg.Replace(" [rtag]", "")
				msg = msg.Replace("[rtag]", "")

				msg = msg.Replace(" [rall] ", "")
				msg = msg.Replace(" [rall]", "")
				msg = msg.Replace("[rall]", "")
			End If

			Try
				Do While msg.Contains("[lag]")
					Try
						msg = Utils.ReplaceFirst(msg, "[lag]", Utils.GetLagMessage())
					Catch

					End Try
				Loop
			Catch

			End Try

			Try
				Do While msg.Contains("[rndnum]")
					Try
						msg = Utils.ReplaceFirst(msg, "[rndnum]", Utils.GetUniqueInt(4).ToString())
					Catch

					End Try
				Loop
			Catch

			End Try

			Try
				Do While msg.Contains("[rndstr]")
					Try
						msg = Utils.ReplaceFirst(msg, "[rndstr]", Utils.GetUniqueKey(16))
					Catch

					End Try
				Loop
			Catch

			End Try
		Catch

		End Try

		Return msg
	End Function

	Public Sub SpamServer(ByVal client As DiscordClient, ByVal channelId As String, ByVal proxyClient As HttpProxyClient)
		Thread.Sleep(5)

		Try
			client.ReadChannel(channelId, proxyClient)
		Catch

		End Try

		Do While serverSpammer
			Thread.Sleep(5)

			Try
				If siticoneOSToggleSwith2.Checked Then
					Thread.Sleep(bunifuHSlider2.Value)
				End If

				client.SendMessage(channelId, getServerSpamMessage(),If(Utils.IsIDValid(gunaLineTextBox5.Text), gunaLineTextBox5.Text, ""), proxyClient, siticoneCheckBox34.Checked)
			Catch

			End Try
		Loop
	End Sub

	Public Function GetDMSpam() As Integer
		Try
			If siticoneRadioButton8.Checked Then
				Return 0
			ElseIf siticoneRadioButton7.Checked Then
				Return 1
			Else
				Return 2
			End If
		Catch
			Return 0
		End Try
	End Function

	Public Sub SetDMSpam(ByVal status As Integer)
		Try
			If status = 0 Then
				siticoneRadioButton8.Checked = True
			ElseIf status = 1 Then
				siticoneRadioButton7.Checked = True
			Else
				siticoneRadioButton6.Checked = True
			End If
		Catch

		End Try
	End Sub

	Private Sub gunaButton5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles gunaButton5.Click
		' DM Spammer - Start Spamming
		Try
			Dim actual As Integer = GetDMSpam()
			gunaButton5.Enabled = False
			gunaButton6.Enabled = True
			SetDMSpam(actual)

			If siticoneCheckBox11.Checked Then
				If Not Utils.AreIDsValid(gunaLineTextBox6.Text) Then
					MessageBox.Show("The IDs of the users are not valid!", "AstarothSpammer", MessageBoxButtons.OK, MessageBoxIcon.Error)

					gunaButton6.Enabled = False
					gunaButton5.Enabled = True

					Return
				End If
			Else
				If Not Utils.IsIDValid(gunaLineTextBox6.Text) Then
					MessageBox.Show("The ID of the user is not valid!", "AstarothSpammer", MessageBoxButtons.OK, MessageBoxIcon.Error)

					gunaButton6.Enabled = False
					gunaButton5.Enabled = True

					Return
				End If
			End If

			Dim thread As New Thread(AddressOf DoDMSpammer)

			thread.Start()
		Catch

		End Try
	End Sub

	Private Sub gunaButton6_Click(ByVal sender As Object, ByVal e As EventArgs) Handles gunaButton6.Click
		' DM Spammer - Stop Spamming
		Try
			dmSpammer = False
			CType(New Thread(AddressOf reEnableDMSpammer), Thread).Start()
		Catch

		End Try
	End Sub

	Public Sub DoDMSpammer()
		Try
			dmSpammer = True

			For Each client As DiscordClient In Me.GetClients()
				Thread.Sleep(5)

				Try
					Dim times As Integer = 1

					If siticoneRadioButton7.Checked Then
						times = 2
					ElseIf siticoneRadioButton6.Checked Then
						times = 10
					End If

					Dim ids As New List(Of String)()
					Dim proxyClient As HttpProxyClient = GetProxy()

					Try
						If siticoneCheckBox12.Checked Then
							Try
								For Each id As String In Utils.GetIDs(gunaLineTextBox6.Text)
									Try
										ids.Add(client.GetDMChannel(id, proxyClient))
									Catch

									End Try
								Next id
							Catch

							End Try
						Else
							ids.Add(client.GetDMChannel(gunaLineTextBox6.Text, proxyClient))
						End If
					Catch

					End Try

					Try
						For Each id As String In ids
							Try
								If Not Utils.IsIDValid(id) Then
									Continue For
								End If
							Catch

							End Try
						Next id
					Catch

					End Try

					For i As Integer = 0 To times - 1
						Try
							For Each id As String In ids
								Thread.Sleep(5)

								Try
									If siticoneOSToggleSwith3.Checked Then
										'Thread.Sleep(bunifuHSlider3.Value)
									End If

									Dim thread As New Thread(Sub() SpamDM(client, id, GetProxy()))

									thread.Start()
								Catch

								End Try
							Next id
						Catch

						End Try
					Next i
				Catch

				End Try
			Next client
		Catch

		End Try
	End Sub

	Public Function getDMSpamMessage() As String
		Dim msg As String = ""

		Try
			Try
				If Not siticoneCheckBox12.Checked Then
					Dim lines As New List(Of String)()

					For Each line As String In Utils.SplitToLines(gunaTextBox2.Text)
						lines.Add(line)
					Next line

					If lines.Count <> 1 Then
						For Each line As String In lines
							msg = msg & " \u000d" & line
						Next line
					Else
						msg = gunaTextBox2.Text
					End If
				Else
					If multipleDmMessageIndex < 0 Then
						multipleDmMessageIndex = 0
					End If

					Dim count As Integer = 0

					For Each c As Char In gunaTextBox2.Text.ToCharArray()
						If c = "|"c Then
							count += 1
						End If
					Next c

					If multipleDmMessageIndex > count Then
						multipleDmMessageIndex = 0
					End If

					If count = 0 Then
						Dim lines As New List(Of String)()

						For Each line As String In Utils.SplitToLines(gunaTextBox2.Text)
							lines.Add(line)
						Next line

						If lines.Count <> 1 Then
							For Each line As String In lines
								msg = msg & " \u000d" & line
							Next line
						Else
							msg = gunaTextBox2.Text
						End If

						multipleDmMessageIndex += 1
					ElseIf count = 1 AndAlso Microsoft.VisualBasic.Strings.Split(gunaTextBox2.Text, "|")(1).Replace(" ", "").Replace(ControlChars.Tab.ToString(), "").Trim() = "" Then
						Dim splitted() As String = Microsoft.VisualBasic.Strings.Split(gunaTextBox2.Text, "|")
						Dim definitive As String = splitted(0)
						Dim lines As New List(Of String)()

						For Each line As String In Utils.SplitToLines(definitive)
							lines.Add(line)
						Next line

						If lines.Count <> 1 Then
							For Each line As String In lines
								msg = msg & " \u000d" & line
							Next line
						Else
							msg = definitive
						End If

						multipleDmMessageIndex += 1
					Else
						Dim splitted() As String = Microsoft.VisualBasic.Strings.Split(gunaTextBox2.Text, "|")
						Dim definitive As String = splitted(multipleDmMessageIndex)
						Dim lines As New List(Of String)()

						For Each line As String In Utils.SplitToLines(definitive)
							lines.Add(line)
						Next line

						If lines.Count <> 1 Then
							For Each line As String In lines
								msg = msg & " \u000d" & line
							Next line
						Else
							msg = definitive
						End If

						If multipleDmMessageIndex = count Then
							multipleDmMessageIndex = 0
						Else
							multipleDmMessageIndex += 1
						End If
					End If
				End If
			Catch

			End Try

			Try
				msg = msg.Replace(" [mtag] ", "")
				msg = msg.Replace(" [mtag]", "")
				msg = msg.Replace("[mtag]", "")

				msg = msg.Replace(" [all] ", "")
				msg = msg.Replace(" [all]", "")
				msg = msg.Replace("[all]", "")

				msg = msg.Replace(" [rtag] ", "")
				msg = msg.Replace(" [rtag]", "")
				msg = msg.Replace("[rtag]", "")

				msg = msg.Replace(" [rall] ", "")
				msg = msg.Replace(" [rall]", "")
				msg = msg.Replace("[rall]", "")
			Catch

			End Try

			Try
				Do While msg.Contains("[lag]")
					Try
						msg = Utils.ReplaceFirst(msg, "[lag]", Utils.GetLagMessage())
					Catch

					End Try
				Loop
			Catch

			End Try

			Try
				Do While msg.Contains("[rndnum]")
					Try
						msg = Utils.ReplaceFirst(msg, "[rndnum]", Utils.GetUniqueInt(4).ToString())
					Catch

					End Try
				Loop
			Catch

			End Try

			Try
				Do While msg.Contains("[rndstr]")
					Try
						msg = Utils.ReplaceFirst(msg, "[rndstr]", Utils.GetUniqueKey(16))
					Catch

					End Try
				Loop
			Catch

			End Try
		Catch

		End Try

		Return msg
	End Function

	Public Sub reEnableDMSpammer()
		Try
			If siticoneOSToggleSwith3.Checked Then
				Thread.Sleep(bunifuHSlider3.Value)
			End If

			gunaButton6.Enabled = False
			gunaButton5.Enabled = True
		Catch

		End Try
	End Sub

	Public Sub SpamDM(ByVal client As DiscordClient, ByVal channelId As String, ByVal proxyClient As HttpProxyClient)
		Thread.Sleep(5)

		Try
			client.ReadChannel(channelId, proxyClient)
		Catch

		End Try

		Try
			Do While dmSpammer
				Try
					Thread.Sleep(5)

					If siticoneOSToggleSwith3.Checked Then
						Thread.Sleep(bunifuHSlider3.Value)
					End If

					client.SendMessage(channelId, getDMSpamMessage(),If(Utils.IsIDValid(gunaLineTextBox7.Text), gunaLineTextBox7.Text, ""), proxyClient)
				Catch

				End Try
			Loop
		Catch

		End Try
	End Sub

	Private Sub gunaButton7_Click(ByVal sender As Object, ByVal e As EventArgs) Handles gunaButton7.Click
		' Reaction Spammer - Add reaction

		Try
			If siticoneRadioButton1.Checked Then
				If Not Utils.IsEmojiValid(gunaLineTextBox8.Text) Then
					MessageBox.Show("The emoji is not valid! Please, insert a new valid one.", "AstarothSpammer", MessageBoxButtons.OK, MessageBoxIcon.Error)
					Return
				End If
			Else
				If Not Utils.IsEmoteValid(gunaLineTextBox8.Text) Then
					MessageBox.Show("The emote is not valid! Please, insert a new valid one.", "AstarothSpammer", MessageBoxButtons.OK, MessageBoxIcon.Error)
					Return
				End If
			End If

			If Not Utils.IsIDValid(gunaLineTextBox9.Text) Then
				MessageBox.Show("The ID of the channel is not valid! Please, insert a new valid one.", "AstarothSpammer", MessageBoxButtons.OK, MessageBoxIcon.Error)
				Return
			End If

			If Not Utils.IsIDValid(gunaLineTextBox10.Text) Then
				MessageBox.Show("The ID of the message is not valid! Please, insert a new valid one.", "AstarothSpammer", MessageBoxButtons.OK, MessageBoxIcon.Error)
				Return
			End If

			Dim thread As New Thread(Sub() DoReactionAdder(gunaLineTextBox8.Text, gunaLineTextBox9.Text, gunaLineTextBox10.Text))

			thread.Start()
		Catch

		End Try
	End Sub

	Private Sub gunaButton8_Click(ByVal sender As Object, ByVal e As EventArgs) Handles gunaButton8.Click
		' Reaction Spammer - Remove reaction

		Try
			If siticoneRadioButton1.Checked Then
				If Not Utils.IsEmojiValid(gunaLineTextBox8.Text) Then
					MessageBox.Show("The emoji is not valid! Please, insert a new valid one.", "AstarothSpammer", MessageBoxButtons.OK, MessageBoxIcon.Error)
					Return
				End If
			Else
				If Not Utils.IsEmoteValid(gunaLineTextBox8.Text) Then
					MessageBox.Show("The emote is not valid! Please, insert a new valid one.", "AstarothSpammer", MessageBoxButtons.OK, MessageBoxIcon.Error)
					Return
				End If
			End If

			If Not Utils.IsIDValid(gunaLineTextBox9.Text) Then
				MessageBox.Show("The ID of the channel is not valid! Please, insert a new valid one.", "AstarothSpammer", MessageBoxButtons.OK, MessageBoxIcon.Error)
				Return
			End If

			If Not Utils.IsIDValid(gunaLineTextBox10.Text) Then
				MessageBox.Show("The ID of the message is not valid! Please, insert a new valid one.", "AstarothSpammer", MessageBoxButtons.OK, MessageBoxIcon.Error)
				Return
			End If

			Dim thread As New Thread(Sub() DoReactionRemover(gunaLineTextBox8.Text, gunaLineTextBox9.Text, gunaLineTextBox10.Text))

			thread.Start()
		Catch

		End Try
	End Sub

	Public Sub DoReactionAdder(ByVal reaction As String, ByVal channelId As String, ByVal messageId As String)
		Try
			For Each client As DiscordClient In Me.GetClients()
				Try
					'Thread.Sleep(5)

					If siticoneOSToggleSwith4.Checked Then
						'Thread.Sleep(bunifuHSlider4.Value)
					End If

					Dim thread As New Thread(Sub() AddReaction(client, reaction, channelId, messageId, GetProxy()))

					thread.Start()
				Catch

				End Try
			Next client
		Catch

		End Try
	End Sub

	Public Sub DoReactionRemover(ByVal reaction As String, ByVal channelId As String, ByVal messageId As String)
		Try
			For Each client As DiscordClient In Me.GetClients()
				Try
					'Thread.Sleep(5)

					If siticoneOSToggleSwith4.Checked Then
						'Thread.Sleep(bunifuHSlider4.Value)
					End If

					Dim thread As New Thread(Sub() RemoveReaction(client, reaction, channelId, messageId, GetProxy()))

					thread.Start()
				Catch

				End Try
			Next client
		Catch

		End Try
	End Sub

	Public Sub AddReaction(ByVal client As DiscordClient, ByVal reaction As String, ByVal channelId As String, ByVal messageId As String, ByVal proxyClient As HttpProxyClient)
		Try
			client.AddReaction(reaction, channelId, messageId, proxyClient)
		Catch

		End Try
	End Sub

	Public Sub RemoveReaction(ByVal client As DiscordClient, ByVal reaction As String, ByVal channelId As String, ByVal messageId As String, ByVal proxyClient As HttpProxyClient)
		Try
			client.RemoveReaction(reaction, channelId, messageId, proxyClient)
		Catch

		End Try
	End Sub

	Private Sub gunaButton10_Click(ByVal sender As Object, ByVal e As EventArgs) Handles gunaButton10.Click
		' Friend Spammer - Add friend

		Try
			If siticoneCheckBox35.Checked Then
				If siticoneCheckBox5.Checked Then
					If Not Utils.AreIDsValid(gunaLineTextBox11.Text) Then
						MessageBox.Show("The IDs of the users are not valid! Please, insert new valids.", "AstarothSpammer", MessageBoxButtons.OK, MessageBoxIcon.Error)
						Return
					End If
				Else
					If Not Utils.IsIDValid(gunaLineTextBox11.Text) Then
						MessageBox.Show("The ID of the user is not valid! Please, insert a new valid one.", "AstarothSpammer", MessageBoxButtons.OK, MessageBoxIcon.Error)
						Return
					End If
				End If

				gunaButton10.Enabled = False
				gunaButton9.Enabled = True
			Else
				If siticoneCheckBox5.Checked Then
					If Not Utils.AreFriendsValid(gunaLineTextBox11.Text) Then
						MessageBox.Show("The IDs and / or tags of the users are not valid! Please, insert new valids.", "AstarothSpammer", MessageBoxButtons.OK, MessageBoxIcon.Error)
						Return
					End If
				Else
					If Not Utils.IsFriendValid(gunaLineTextBox11.Text) Then
						MessageBox.Show("The ID / tag of the user is not valid! Please, insert a new valid one.", "AstarothSpammer", MessageBoxButtons.OK, MessageBoxIcon.Error)
						Return
					End If
				End If
			End If

			Dim thread As New Thread(Sub() DoFriendAdder(gunaLineTextBox11.Text, siticoneCheckBox5.Checked))

			thread.Start()
		Catch

		End Try
	End Sub

	Private Sub gunaButton9_Click(ByVal sender As Object, ByVal e As EventArgs) Handles gunaButton9.Click
		' Friend Spammer - Remove friend

		Try
			If siticoneCheckBox5.Checked Then
				If Not Utils.AreIDsValid(gunaLineTextBox11.Text) Then
					MessageBox.Show("The IDs of the users are not valid! Please, insert new valids.", "AstarothSpammer", MessageBoxButtons.OK, MessageBoxIcon.Error)
					Return
				End If
			Else
				If Not Utils.IsIDValid(gunaLineTextBox11.Text) Then
					MessageBox.Show("The ID of the user is not valid! Please, insert a new valid one.", "AstarothSpammer", MessageBoxButtons.OK, MessageBoxIcon.Error)
					Return
				End If
			End If

			If siticoneCheckBox35.Checked Then
				gunaButton9.Enabled = False
				gunaButton10.Enabled = True
			End If

			Dim thread As New Thread(Sub() DoFriendRemover(gunaLineTextBox11.Text, siticoneCheckBox5.Checked))

			thread.Start()
		Catch

		End Try
	End Sub

	Public Sub DoFriendAdder(ByVal str As String, ByVal multiple As Boolean)
		Try
			For Each client As DiscordClient In Me.GetClients()
				Thread.Sleep(5)

				Try
					If multiple Then
						Dim proxyClient As HttpProxyClient = GetProxy()

						Try
							For Each user As String In Utils.GetFriends(str)
								Try
									'Thread.Sleep(5)

									If siticoneOSToggleSwith5.Checked Then
										'Thread.Sleep(bunifuHSlider5.Value)
									End If

									Dim thread As New Thread(Sub() AddFriend(client, user, proxyClient))

									thread.Start()
								Catch

								End Try
							Next user
						Catch

						End Try
					Else
						Try
							If siticoneOSToggleSwith5.Checked Then
								'Thread.Sleep(bunifuHSlider5.Value)
							End If

							Dim thread As New Thread(Sub() AddFriend(client, str, GetProxy()))

							thread.Start()
						Catch

						End Try
					End If
				Catch

				End Try
			Next client
		Catch

		End Try
	End Sub

	Public Sub DoFriendRemover(ByVal str As String, ByVal multiple As Boolean)
		Try
			For Each client As DiscordClient In Me.GetClients()
				Thread.Sleep(5)

				Try
					If multiple Then
						Dim proxyClient As HttpProxyClient = GetProxy()

						Try
							For Each user As String In Utils.GetIDs(str)
								Thread.Sleep(5)

								If siticoneOSToggleSwith5.Checked Then
									Thread.Sleep(bunifuHSlider5.Value)
								End If

								Try
									Dim thread As New Thread(Sub() RemoveFriend(client, user, proxyClient))

									thread.Start()
								Catch

								End Try
							Next user
						Catch

						End Try
					Else
						Try
							If siticoneOSToggleSwith5.Checked Then
								'Thread.Sleep(bunifuHSlider5.Value)
							End If

							Dim thread As New Thread(Sub() RemoveFriend(client, str, GetProxy()))

							thread.Start()
						Catch

						End Try
					End If
				Catch

				End Try
			Next client
		Catch

		End Try
	End Sub

	Public Sub AddFriend(ByVal client As DiscordClient, ByVal [friend] As String, ByVal proxyClient As HttpProxyClient)
		Try
			client.AddFriend([friend], proxyClient)

			If siticoneCheckBox35.Checked AndAlso gunaButton9.Enabled Then
				If siticoneOSToggleSwith5.Checked Then
					Thread.Sleep(bunifuHSlider5.Value)
				End If

				RemoveFriend(client, [friend], proxyClient)
			End If
		Catch

		End Try
	End Sub

	Public Sub RemoveFriend(ByVal client As DiscordClient, ByVal userId As String, ByVal proxyClient As HttpProxyClient)
		Try
			client.RemoveFriend(userId, proxyClient)

			If siticoneCheckBox35.Checked AndAlso gunaButton9.Enabled Then
				If siticoneOSToggleSwith5.Checked Then
					Thread.Sleep(bunifuHSlider5.Value)
				End If

				AddFriend(client, userId, proxyClient)
			End If
		Catch

		End Try
	End Sub

	Private Sub gunaButton11_Click(ByVal sender As Object, ByVal e As EventArgs) Handles gunaButton11.Click
		' Typing Spammer - Start Spamming
		Try
			gunaButton11.Enabled = False
			gunaButton12.Enabled = True

			If siticoneCheckBox13.Checked Then
				If Not Utils.AreIDsValid(gunaLineTextBox12.Text) Then
					MessageBox.Show("The IDs of the channels are not valid!", "AstarothSpammer", MessageBoxButtons.OK, MessageBoxIcon.Error)

					gunaButton12.Enabled = False
					gunaButton11.Enabled = True

					Return
				End If
			Else
				If Not Utils.IsIDValid(gunaLineTextBox12.Text) Then
					MessageBox.Show("The ID of the channel is not valid!", "AstarothSpammer", MessageBoxButtons.OK, MessageBoxIcon.Error)

					gunaButton12.Enabled = False
					gunaButton11.Enabled = True

					Return
				End If
			End If

			typingSpammer = True
			Dim thread As New Thread(AddressOf DoTypingSpammer)

			thread.Start()
		Catch

		End Try
	End Sub

	Private Sub gunaButton12_Click(ByVal sender As Object, ByVal e As EventArgs) Handles gunaButton12.Click
		' Typing Spammer - Stop Spamming
		Try
			typingSpammer = False
			gunaButton12.Enabled = False
			gunaButton11.Enabled = True
		Catch

		End Try
	End Sub

	Public Sub DoTypingSpammer()
		Try
			For Each client As DiscordClient In Me.GetClients()
				Try
					Thread.Sleep(5)

					If siticoneOSToggleSwith6.Checked Then
						Thread.Sleep(bunifuHSlider6.Value)
					End If

					If siticoneCheckBox13.Checked Then
						Dim proxyClient As HttpProxyClient = GetProxy()

						Try
							For Each id As String In Utils.GetIDs(gunaLineTextBox12.Text)
								Try
									If siticoneOSToggleSwith6.Checked Then
										'Thread.Sleep(bunifuHSlider6.Value)
									End If

									Dim thread As New Thread(Sub() TypingSpam(client, id, proxyClient))

									thread.Start()
								Catch

								End Try
							Next id
						Catch

						End Try
					Else
						Try
							Dim thread As New Thread(Sub() TypingSpam(client, gunaLineTextBox12.Text, GetProxy()))

							thread.Start()
						Catch

						End Try
					End If
				Catch

				End Try
			Next client
		Catch

		End Try
	End Sub

	Public Sub TypingSpam(ByVal client As DiscordClient, ByVal channelId As String, ByVal proxyClient As HttpProxyClient)
		Try
			Do While typingSpammer
				Try
					Thread.Sleep(5)

					client.TypeInChannel(channelId, proxyClient)
					Thread.Sleep(8000)
				Catch

				End Try
			Loop
		Catch

		End Try
	End Sub

	Private Sub gunaButton15_Click(ByVal sender As Object, ByVal e As EventArgs) Handles gunaButton15.Click
		' Voice Spammer - Join voice
		Try
			If Not Utils.IsIDValid(gunaLineTextBox14.Text) Then
				MessageBox.Show("The ID of the guild is not valid! Please, insert a new valid one.", "AstarothSpammer", MessageBoxButtons.OK, MessageBoxIcon.Error)
				Return
			End If

			If Not Utils.IsIDValid(gunaLineTextBox15.Text) Then
				MessageBox.Show("The ID of the channel is not valid! Please, insert a new valid one.", "AstarothSpammer", MessageBoxButtons.OK, MessageBoxIcon.Error)
				Return
			End If

			Dim thread As New Thread(AddressOf DoJoinVoice)

			thread.Start()
		Catch

		End Try
	End Sub

	Private Sub gunaButton16_Click(ByVal sender As Object, ByVal e As EventArgs) Handles gunaButton16.Click
		' Voice Spammer - Leave voice
		Try
			Dim thread As New Thread(AddressOf DoLeaveVoice)

			thread.Start()
		Catch

		End Try
	End Sub

	Public Sub DoJoinVoice()
		Try
			For Each client As DiscordClient In Me.GetClients()
				Try
					'Thread.Sleep(5)

					If siticoneOSToggleSwith9.Checked Then
						'Thread.Sleep(bunifuHSlider9.Value)
					End If

					Dim thread As New Thread(Sub() JoinVoice(client))

					thread.Start()
				Catch

				End Try
			Next client
		Catch

		End Try
	End Sub

	Public Sub DoLeaveVoice()
		Try
			For Each client As DiscordClient In Me.GetClients()
				Try
					'Thread.Sleep(5)

					If siticoneOSToggleSwith9.Checked Then
						'Thread.Sleep(bunifuHSlider9.Value)
					End If

					Dim thread As New Thread(Sub() LeaveVoice(client))

					thread.Start()
				Catch

				End Try
			Next client
		Catch

		End Try
	End Sub

	Public Sub JoinVoice(ByVal client As DiscordClient)
		' Join voice there.

		Try
			client.JoinVoice(gunaLineTextBox14.Text, gunaLineTextBox15.Text, gunaLineTextBox16.Text, siticoneCheckBox14.Checked, siticoneCheckBox15.Checked, siticoneCheckBox16.Checked, siticoneCheckBox17.Checked, siticoneCheckBox18.Checked, siticoneCheckBox20.Checked)

			If siticoneCheckBox21.Checked Then
				If siticoneOSToggleSwith10.Checked Then
					Thread.Sleep(bunifuHSlider10.Value)
				End If

				LeaveVoice(client)
			End If
		Catch

		End Try
	End Sub

	Public Sub LeaveVoice(ByVal client As DiscordClient)
		' Leave voice there.

		Try
			client.LeaveVoice()
		Catch

		End Try
	End Sub

	Private Sub gunaButton17_Click(ByVal sender As Object, ByVal e As EventArgs) Handles gunaButton17.Click
		' Webhook Spammer - Start Spamming
		Try
			gunaButton17.Enabled = False
			webhookSpammer = True
			Dim thread As New Thread(AddressOf DoWebhookSpammer)

			thread.Start()
		Catch

		End Try
	End Sub

	Public Sub DoWebhookSpammer()
		Try
			Dim times As Integer = 1

			If siticoneRadioButton10.Checked Then
				times = 2
			ElseIf siticoneRadioButton9.Checked Then
				times = 10
			End If

			If siticoneCheckBox22.Checked Then
				Try
					For Each webhook As String In Utils.GetIDs(gunaLineTextBox17.Text)
						Thread.Sleep(5)

						Try
							If Not Utils.IsWebhookValid(webhook) Then
								MessageBox.Show("The webhooks are not valid ('" & webhook & "'). Please, remove the invalid webhooks and try again.", "AstarothSpammer", MessageBoxButtons.OK, MessageBoxIcon.Error)
								gunaButton17.Enabled = True
								Return
							End If
						Catch

						End Try
					Next webhook
				Catch

				End Try

				gunaButton18.Enabled = True

				Try
					For i As Integer = 0 To times - 1
						Try
							Thread.Sleep(5)

							For Each webhook As String In Utils.GetIDs(gunaLineTextBox17.Text)
								Thread.Sleep(5)

								Try
									Dim thread As New Thread(Sub() SpamWebhook(webhook))

									thread.Start()
								Catch

								End Try
							Next webhook
						Catch

						End Try
					Next i
				Catch

				End Try
			Else
				Try
					If Not Utils.IsWebhookValid(gunaLineTextBox17.Text) Then
						MessageBox.Show("The webhook is not valid! Please, insert a new valid one.", "AstarothSpammer", MessageBoxButtons.OK, MessageBoxIcon.Error)
						gunaButton17.Enabled = True
						Return
					End If

					gunaButton18.Enabled = True

					Try
						For i As Integer = 0 To times - 1
							Try
								Dim thread As New Thread(Sub() SpamWebhook(gunaLineTextBox17.Text))

								thread.Start()
							Catch

							End Try
						Next i
					Catch

					End Try
				Catch

				End Try
			End If
		Catch

		End Try
	End Sub

	Private Sub gunaButton18_Click(ByVal sender As Object, ByVal e As EventArgs) Handles gunaButton18.Click
		' Webhook Spammer - Stop Spamming
		Try
			webhookSpammer = False
			gunaButton18.Enabled = False
			gunaButton17.Enabled = True
		Catch

		End Try
	End Sub

	Public Function GetWebhookSpammerMessage() As String
		Dim msg As String = ""

		Try
			Try
				If Not siticoneCheckBox27.Checked Then
					Dim lines As New List(Of String)()

					For Each line As String In Utils.SplitToLines(gunaTextBox3.Text)
						lines.Add(line)
					Next line

					If lines.Count <> 1 Then
						For Each line As String In lines
							msg = msg & " \u000d" & line
						Next line
					Else
						msg = gunaTextBox3.Text
					End If
				Else
					If multipleWebhookMessageIndex < 0 Then
						multipleWebhookMessageIndex = 0
					End If

					Dim count As Integer = 0

					For Each c As Char In gunaTextBox3.Text.ToCharArray()
						If c = "|"c Then
							count += 1
						End If
					Next c

					If multipleWebhookMessageIndex > count Then
						multipleWebhookMessageIndex = 0
					End If

					If count = 0 Then
						Dim lines As New List(Of String)()

						For Each line As String In Utils.SplitToLines(gunaTextBox3.Text)
							lines.Add(line)
						Next line

						If lines.Count <> 1 Then
							For Each line As String In lines
								msg = msg & " \u000d" & line
							Next line
						Else
							msg = gunaTextBox3.Text
						End If

						multipleWebhookMessageIndex += 1
					ElseIf count = 1 AndAlso Microsoft.VisualBasic.Strings.Split(gunaTextBox3.Text, "|")(1).Replace(" ", "").Replace(ControlChars.Tab.ToString(), "").Trim() = "" Then
						Dim splitted() As String = Microsoft.VisualBasic.Strings.Split(gunaTextBox3.Text, "|")
						Dim definitive As String = splitted(0)
						Dim lines As New List(Of String)()

						For Each line As String In Utils.SplitToLines(definitive)
							lines.Add(line)
						Next line

						If lines.Count <> 1 Then
							For Each line As String In lines
								msg = msg & " \u000d" & line
							Next line
						Else
							msg = definitive
						End If

						multipleWebhookMessageIndex += 1
					Else
						Dim splitted() As String = Microsoft.VisualBasic.Strings.Split(gunaTextBox3.Text, "|")
						Dim definitive As String = splitted(multipleWebhookMessageIndex)
						Dim lines As New List(Of String)()

						For Each line As String In Utils.SplitToLines(definitive)
							lines.Add(line)
						Next line

						If lines.Count <> 1 Then
							For Each line As String In lines
								msg = msg & " \u000d" & line
							Next line
						Else
							msg = definitive
						End If

						If multipleWebhookMessageIndex = count Then
							multipleWebhookMessageIndex = 0
						Else
							multipleWebhookMessageIndex += 1
						End If
					End If
				End If
			Catch

			End Try

			Try
				msg = msg.Replace(" [mtag] ", "")
				msg = msg.Replace(" [mtag]", "")
				msg = msg.Replace("[mtag]", "")

				msg = msg.Replace(" [all] ", "")
				msg = msg.Replace(" [all]", "")
				msg = msg.Replace("[all]", "")

				msg = msg.Replace(" [rtag] ", "")
				msg = msg.Replace(" [rtag]", "")
				msg = msg.Replace("[rtag]", "")

				msg = msg.Replace(" [rall] ", "")
				msg = msg.Replace(" [rall]", "")
				msg = msg.Replace("[rall]", "")
			Catch

			End Try

			Try
				Do While msg.Contains("[lag]")
					Try
						msg = Utils.ReplaceFirst(msg, "[lag]", Utils.GetLagMessage())
					Catch

					End Try
				Loop
			Catch

			End Try

			Try
				Do While msg.Contains("[rndnum]")
					Try
						msg = Utils.ReplaceFirst(msg, "[rndnum]", Utils.GetUniqueInt(4).ToString())
					Catch

					End Try
				Loop
			Catch

			End Try

			Try
				Do While msg.Contains("[rndstr]")
					Try
						msg = Utils.ReplaceFirst(msg, "[rndstr]", Utils.GetUniqueKey(16))
					Catch

					End Try
				Loop
			Catch

			End Try
		Catch

		End Try

		Return msg
	End Function

	Public Sub SpamWebhook(ByVal url As String)
		Try
			Do While webhookSpammer
				Try
					If siticoneOSToggleSwith11.Checked Then
						Thread.Sleep(bunifuHSlider11.Value)
					End If

					Utils.SendMessageToWebhook(url, gunaLineTextBox18.Text, gunaLineTextBox19.Text, GetWebhookSpammerMessage())
				Catch

				End Try
			Loop
		Catch

		End Try
	End Sub

	Private Sub gunaButton19_Click(ByVal sender As Object, ByVal e As EventArgs) Handles gunaButton19.Click
		' Mass DM Advertiser - Start Advertising
		Try
			If Utils.users.Count = 0 Then
				MessageBox.Show("There are no parsed users! Please, join in a guild and let the Spammer parse the users.", "AstarothSpammer", MessageBoxButtons.OK, MessageBoxIcon.Error)
				Return
			End If

			If Utils.GetCleanToken(gunaTextBox4.Text) = "" Then
				MessageBox.Show("Please, insert a valid message for advertising!", "AstarothSpammer", MessageBoxButtons.OK, MessageBoxIcon.Error)
				Return
			End If

			gunaButton19.Enabled = False
			gunaButton20.Enabled = True
			completedUsers = 0
			massDmAdvertiser = True

			Dim thread As New Thread(AddressOf DoMassDMAdvertiser)

			thread.Start()
		Catch

		End Try
	End Sub

	Private Sub gunaButton20_Click(ByVal sender As Object, ByVal e As EventArgs) Handles gunaButton20.Click
		' Mass DM Advertiser - Stop Advertising
		Try
			massDmAdvertiser = False
			CType(New Thread(AddressOf reEnableDMAdvertiser), Thread).Start()
		Catch

		End Try
	End Sub

	Public Sub reEnableDMAdvertiser()
		Try
			If siticoneOSToggleSwith12.Checked Then
				Thread.Sleep(bunifuHSlider12.Value)
			End If

			gunaButton20.Enabled = False
			gunaButton19.Enabled = True
		Catch

		End Try
	End Sub

	Public Sub DoMassDMAdvertiser()
		Try
			Dim actualIndex As Integer = 0

			For Each client As DiscordClient In Me.GetClients()
				If siticoneOSToggleSwith12.Checked Then
					Thread.Sleep(bunifuHSlider12.Value)
				End If

				Thread.Sleep(5)

				Try
					If massDmAdvertiser Then
						If siticoneOSToggleSwith12.Checked Then
							Thread.Sleep(bunifuHSlider12.Value)
						End If

						Try
							Dim preparedUsers As New List(Of String)()
							Dim dms As Integer = 6

							Try
								If client.IsPhoneVerified() Then
									dms = 22
								End If
							Catch

							End Try

							Try
								For i As Integer = actualIndex To Utils.users.Count - 1
									Try
										If dms > 0 Then
											dms -= 1
											actualIndex += 1
											preparedUsers.Add(Utils.users(i))
										Else
											Exit For
										End If
									Catch
										Exit For
									End Try
								Next i
							Catch

							End Try

							Try
								If siticoneOSToggleSwith12.Checked Then
									'Thread.Sleep(bunifuHSlider12.Value)
								End If

								Dim thread As New Thread(Sub() Advertise(client, preparedUsers, GetProxy()))

								thread.Start()
							Catch

							End Try
						Catch

						End Try
					End If
				Catch

				End Try
			Next client
		Catch

		End Try
	End Sub

	Public Sub Advertise(ByVal client As DiscordClient, ByVal users As List(Of String), ByVal proxyClient As HttpProxyClient)
		Try
			If massDmAdvertiser Then
				Try
					For Each user As String In users
						Thread.Sleep(5)

						Try
							If massDmAdvertiser Then
								Try
									If siticoneOSToggleSwith12.Checked Then
										Thread.Sleep(bunifuHSlider12.Value)
									End If

									If massDmAdvertiser Then
										client.SendMessage(client.GetDMChannel(user, proxyClient), GetMassDMAdvertiserMessage(), "", proxyClient)
										completedUsers += 1
									End If
								Catch

								End Try
							End If
						Catch

						End Try
					Next user
				Catch

				End Try
			End If
		Catch

		End Try
	End Sub

	Public Function GetMassDMAdvertiserMessage() As String
		Dim msg As String = ""

		Try
			Try
				If Not siticoneCheckBox28.Checked Then
					Dim lines As New List(Of String)()

					For Each line As String In Utils.SplitToLines(gunaTextBox4.Text)
						lines.Add(line)
					Next line

					If lines.Count <> 1 Then
						For Each line As String In lines
							msg = msg & " \u000d" & line
						Next line
					Else
						msg = gunaTextBox4.Text
					End If
				Else
					If multipleDmAdvertiserMessageIndex < 0 Then
						multipleDmAdvertiserMessageIndex = 0
					End If

					Dim count As Integer = 0

					For Each c As Char In gunaTextBox4.Text.ToCharArray()
						If c = "|"c Then
							count += 1
						End If
					Next c

					If multipleDmAdvertiserMessageIndex > count Then
						multipleDmAdvertiserMessageIndex = 0
					End If

					If count = 0 Then
						Dim lines As New List(Of String)()

						For Each line As String In Utils.SplitToLines(gunaTextBox4.Text)
							lines.Add(line)
						Next line

						If lines.Count <> 1 Then
							For Each line As String In lines
								msg = msg & " \u000d" & line
							Next line
						Else
							msg = gunaTextBox4.Text
						End If

						multipleDmAdvertiserMessageIndex += 1
					ElseIf count = 1 AndAlso Microsoft.VisualBasic.Strings.Split(gunaTextBox4.Text, "|")(1).Replace(" ", "").Replace(ControlChars.Tab.ToString(), "").Trim() = "" Then
						Dim splitted() As String = Microsoft.VisualBasic.Strings.Split(gunaTextBox4.Text, "|")
						Dim definitive As String = splitted(0)
						Dim lines As New List(Of String)()

						For Each line As String In Utils.SplitToLines(definitive)
							lines.Add(line)
						Next line

						If lines.Count <> 1 Then
							For Each line As String In lines
								msg = msg & " \u000d" & line
							Next line
						Else
							msg = definitive
						End If

						multipleDmAdvertiserMessageIndex += 1
					Else
						Dim splitted() As String = Microsoft.VisualBasic.Strings.Split(gunaTextBox4.Text, "|")
						Dim definitive As String = splitted(multipleDmAdvertiserMessageIndex)
						Dim lines As New List(Of String)()

						For Each line As String In Utils.SplitToLines(definitive)
							lines.Add(line)
						Next line

						If lines.Count <> 1 Then
							For Each line As String In lines
								msg = msg & " \u000d" & line
							Next line
						Else
							msg = definitive
						End If

						If multipleDmAdvertiserMessageIndex = count Then
							multipleDmAdvertiserMessageIndex = 0
						Else
							multipleDmAdvertiserMessageIndex += 1
						End If
					End If
				End If
			Catch

			End Try

			Try
				msg = msg.Replace(" [mtag] ", "")
				msg = msg.Replace(" [mtag]", "")
				msg = msg.Replace("[mtag]", "")

				msg = msg.Replace(" [all] ", "")
				msg = msg.Replace(" [all]", "")
				msg = msg.Replace("[all]", "")

				msg = msg.Replace(" [rtag] ", "")
				msg = msg.Replace(" [rtag]", "")
				msg = msg.Replace("[rtag]", "")

				msg = msg.Replace(" [rall] ", "")
				msg = msg.Replace(" [rall]", "")
				msg = msg.Replace("[rall]", "")
			Catch

			End Try

			Try
				Do While msg.Contains("[lag]")
					Try
						msg = Utils.ReplaceFirst(msg, "[lag]", Utils.GetLagMessage())
					Catch

					End Try
				Loop
			Catch

			End Try

			Try
				Do While msg.Contains("[rndnum]")
					Try
						msg = Utils.ReplaceFirst(msg, "[rndnum]", Utils.GetUniqueInt(4).ToString())
					Catch

					End Try
				Loop
			Catch

			End Try

			Try
				Do While msg.Contains("[rndstr]")
					Try
						msg = Utils.ReplaceFirst(msg, "[rndstr]", Utils.GetUniqueKey(16))
					Catch

					End Try
				Loop
			Catch

			End Try
		Catch

		End Try

		Return msg
	End Function

	Private Sub siticoneButton8_Click(ByVal sender As Object, ByVal e As EventArgs) Handles siticoneButton8.Click
		' Settings and Utils - Set new nickname for all tokens
		Try
			If Not Utils.IsIDValid(gunaLineTextBox21.Text) Then
				MessageBox.Show("The ID of the guild is not valid! Please, insert a new valid one.", "AstarothSpammer", MessageBoxButtons.OK, MessageBoxIcon.Error)
			End If

			Dim thread As New Thread(AddressOf DoSetNickName)

			thread.Start()
		Catch

		End Try
	End Sub

	Public Sub DoSetNickName()
		Try
			For Each client As DiscordClient In Me.GetClients()
				Try
					Dim thread As New Thread(Sub() SetNickname(client, gunaLineTextBox21.Text, gunaLineTextBox22.Text, GetProxy()))

					thread.Start()
				Catch

				End Try
			Next client
		Catch

		End Try
	End Sub

	Public Sub SetNickname(ByVal client As DiscordClient, ByVal guildId As String, ByVal nickname As String, ByVal proxyClient As HttpProxyClient)
		Try
			client.SetNickname(guildId, nickname, proxyClient)
		Catch

		End Try
	End Sub

	Private Sub siticoneButton11_Click(ByVal sender As Object, ByVal e As EventArgs) Handles siticoneButton11.Click
		' Settings and Utils - Set new online status for all tokens
		Try
			Dim thread As New Thread(AddressOf DoSetStatus)

			thread.Start()
		Catch

		End Try
	End Sub

	Public Sub DoSetStatus()
		Try
			Dim status As UserStatus = UserStatus.Online

			If siticoneComboBox2.SelectedIndex = 1 Then
				status = UserStatus.Idle
			ElseIf siticoneComboBox2.SelectedIndex = 2 Then
				status = UserStatus.DoNotDisturb
			ElseIf siticoneComboBox2.SelectedIndex = 3 Then
				status = UserStatus.Invisible
			End If

			For Each client As DiscordClient In Me.GetClients()
				Try
					Dim thread As New Thread(Sub() SetStatus(client, status, GetProxy()))

					thread.Start()
				Catch

				End Try
			Next client
		Catch

		End Try
	End Sub

	Public Sub SetStatus(ByVal client As DiscordClient, ByVal status As UserStatus, ByVal proxyClient As HttpProxyClient)
		Try
			Dim theStatus As String = "online"

			If status.Equals(UserStatus.DoNotDisturb) Then
				theStatus = "dnd"
			ElseIf status.Equals(UserStatus.Idle) Then
				theStatus = "idle"
			ElseIf status.Equals(UserStatus.Invisible) Then
				theStatus = "invisible"
			End If

			Try
				client.ConnectToWebSocket()
			Catch

			End Try

			Try
				client.SetStatus(status, proxyClient)
			Catch

			End Try

			Try
				client.SendToWS("{""op"":3,""d"":{""status"":""" & theStatus & """,""since"":0,""activities"":[],""afk"":false}}")
			Catch

			End Try
		Catch

		End Try
	End Sub

	Private Sub siticoneButton7_Click(ByVal sender As Object, ByVal e As EventArgs) Handles siticoneButton7.Click
		' Reaction Spammer - Fetch from message
		Try
			If Not Utils.IsIDValid(gunaLineTextBox9.Text) Then
				MessageBox.Show("The ID of the channel is not valid! Please, insert a new valid one.", "AstarothSpammer", MessageBoxButtons.OK, MessageBoxIcon.Error)
				Return
			End If

			If Not Utils.IsIDValid(gunaLineTextBox10.Text) Then
				MessageBox.Show("The ID of the message is not valid! Please, insert a new valid one.", "AstarothSpammer", MessageBoxButtons.OK, MessageBoxIcon.Error)
				Return
			End If

			siticoneButton7.Enabled = False
			siticoneButton7.Text = "Fetching"
			Dim thread As New Thread(AddressOf FetchEmote)

			thread.Start()
		Catch

		End Try
	End Sub

	Public Sub FetchEmote()
		Try
			Try
				gunaLineTextBox8.Text = clients(0).FetchEmote(gunaLineTextBox9.Text, gunaLineTextBox10.Text, GetProxy())
			Catch

			End Try

			siticoneButton7.Enabled = True
			siticoneButton7.Text = "Fetch from message"
		Catch

		End Try
	End Sub

	Private Sub siticoneButton12_Click(ByVal sender As Object, ByVal e As EventArgs) Handles siticoneButton12.Click
		' Settings and Utils - Generate Text
		Try
			Dim thread As New Thread(AddressOf GenerateText)
			thread.SetApartmentState(ApartmentState.STA)

			thread.Start()
		Catch

		End Try
	End Sub

	Private Sub siticoneButton10_Click(ByVal sender As Object, ByVal e As EventArgs) Handles siticoneButton10.Click
		Dim thread As New Thread(Sub() ParseUsers(gunaLineTextBox25.Text, gunaLineTextBox24.Text))
		thread.Start()
	End Sub

	Public Sub ParseUsers(ByVal invite As String, ByVal channelId As String)
		Try
			If Not Utils.IsIDValid(channelId) Then
				MessageBox.Show("The ID of the channel that you inserted is not valid! Please, ensure to insert the ID of the channel of this guild that most of the users are visible to you.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
				Return
			End If

			Dim theInvite As DiscordInvite = Utils.GetInviteInformations(invite, False)

			If Not theInvite.valid Then
				MessageBox.Show("The guild invite link / code that you have inserted is not valid! Please, ensure that the invite you inserted is the real invite you want to use and check if you are not rate-limited from the Discord API.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
				Return
			End If

			If Not Utils.IsTokenValid(clients(0).token) Then
				MessageBox.Show("Failed to parse users! Please, ensure that your tokens are all valid or if your tokens list is empty!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
				Return
			End If

			clients(0).ConnectToWebSocket()
			Utils.lastChannelId = channelId
			clients(0).ParseGuild(theInvite, Nothing, channelId)
		Catch
			MessageBox.Show("Failed to parse users! Please, ensure that your tokens are all valid or if your tokens list is empty!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
		End Try
	End Sub

	Private Sub siticoneButton13_Click(ByVal sender As Object, ByVal e As EventArgs) Handles siticoneButton13.Click
		If Not(Utils.users.Count > 0) Then
			Return
		End If

		If saveFileDialog1.ShowDialog().Equals(DialogResult.OK) Then
			Dim preparedList As String = ""

			For Each user As String In Utils.users
				If preparedList = "" Then
					preparedList = user
				Else
					preparedList &= Environment.NewLine & user
				End If
			Next user

			System.IO.File.WriteAllText(saveFileDialog1.FileName, preparedList)
		End If
	End Sub

	Private Sub siticoneButton14_Click(ByVal sender As Object, ByVal e As EventArgs) Handles siticoneButton14.Click
		If openFileDialog3.ShowDialog().Equals(DialogResult.OK) Then
			Try
				Dim realLine As String = ""

				For Each line As String In Utils.SplitToLines(System.IO.File.ReadAllText(openFileDialog3.FileName))
					realLine = line.Replace(" ", "").Trim().Replace(ControlChars.Tab.ToString(), "")

					If Utils.IsIDValid(realLine) Then
						Utils.users.Add(realLine)
					End If
				Next line
			Catch

			End Try
		End If
	End Sub

	Private Sub siticoneButton18_Click(ByVal sender As Object, ByVal e As EventArgs) Handles siticoneButton18.Click
		' Miscellaneous - Phone Lock all loaded tokens
		Dim thread As New Thread(AddressOf PhoneLockAll)
		thread.Start()
	End Sub

	Public Sub PhoneLockAll()
		For Each client As DiscordClient In clients
			'Thread.Sleep(5)
			Dim thread As New Thread(Sub() PhoneLock(client))
			thread.Start()
		Next client
	End Sub

	Public Sub PhoneLock(ByVal client As DiscordClient)
		client.PhoneLock()
	End Sub

	Private Sub siticoneButton19_Click(ByVal sender As Object, ByVal e As EventArgs) Handles siticoneButton19.Click

	End Sub

	Private Sub siticoneButton20_Click(ByVal sender As Object, ByVal e As EventArgs) Handles siticoneButton20.Click

	End Sub

	Private Sub siticoneButton17_Click(ByVal sender As Object, ByVal e As EventArgs) Handles siticoneButton17.Click
		Dim thread As New Thread(Sub() ParseRoles(gunaLineTextBox27.Text))
		thread.Start()
	End Sub

	Public Sub ParseRoles(ByVal guildId As String)
		Try
			If Not Utils.IsIDValid(guildId) Then
				MessageBox.Show("The ID of the guild that you have inserted is not valid!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
				Return
			End If

			If Not Utils.IsTokenValid(clients(0).token) Then
				MessageBox.Show("Failed to parse users! Please, ensure that your tokens are all valid or if your tokens list is empty!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
				Return
			End If

			Utils.roles = clients(0).GetGuildRoles(guildId, Nothing)
		Catch
			MessageBox.Show("Failed to parse roles! Please, ensure that your tokens are all valid or if your tokens list is empty!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
		End Try
	End Sub

	Private Sub siticoneButton16_Click(ByVal sender As Object, ByVal e As EventArgs) Handles siticoneButton16.Click
		If Not(Utils.roles.Count > 0) Then
			Return
		End If

		If saveFileDialog2.ShowDialog().Equals(DialogResult.OK) Then
			Dim preparedList As String = ""

			For Each role As String In Utils.roles
				If preparedList = "" Then
					preparedList = role
				Else
					preparedList &= Environment.NewLine & role
				End If
			Next role

			System.IO.File.WriteAllText(saveFileDialog2.FileName, preparedList)
		End If
	End Sub

	Private Sub siticoneButton15_Click(ByVal sender As Object, ByVal e As EventArgs) Handles siticoneButton15.Click
		If openFileDialog4.ShowDialog().Equals(DialogResult.OK) Then
			Try
				Dim realLine As String = ""

				For Each line As String In Utils.SplitToLines(System.IO.File.ReadAllText(openFileDialog4.FileName))
					realLine = line.Replace(" ", "").Trim().Replace(ControlChars.Tab.ToString(), "")

					If Utils.IsIDValid(realLine) Then
						Utils.roles.Add(realLine)
					End If
				Next line
			Catch

			End Try
		End If
	End Sub

	Private Sub siticoneButton21_Click(ByVal sender As Object, ByVal e As EventArgs) Handles siticoneButton21.Click
		If openFileDialog5.ShowDialog().Equals(DialogResult.OK) Then
			pictureBox2.BackgroundImage = System.Drawing.Image.FromFile(openFileDialog5.FileName)
		End If
	End Sub

	Private Sub siticoneButton22_Click(ByVal sender As Object, ByVal e As EventArgs) Handles siticoneButton22.Click
		Dim thread As New Thread(AddressOf SetAvatarAll)
		thread.Start()
	End Sub

	Public Sub SetAvatarAll()
		For Each client As DiscordClient In clients
			Try
				'Thread.Sleep(5)
				Dim thread As New Thread(Sub() SetAvatar(client, GetProxy()))
				thread.Start()
			Catch

			End Try
		Next client
	End Sub

	Public Sub SetAvatar(ByVal client As DiscordClient, ByVal proxyClient As HttpProxyClient)
		Try
			client.SetAvatar(pictureBox2.BackgroundImage, proxyClient)
		Catch

		End Try
	End Sub

	Private Sub siticoneCheckBox35_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles siticoneCheckBox35.CheckedChanged
		If siticoneCheckBox35.Checked Then
			gunaButton10.Enabled = True
			gunaButton9.Enabled = False
			gunaButton10.Text = "Start Spamming"
			gunaButton9.Text = "Stop Spamming"
		Else
			gunaButton10.Enabled = True
			gunaButton9.Enabled = True
			gunaButton10.Text = "Add friend"
			gunaButton9.Text = "Remove friend"
		End If
	End Sub

	Private Sub siticoneCheckBox33_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles siticoneCheckBox33.CheckedChanged
		If siticoneCheckBox33.Checked Then
			gunaButton1.Text = "Start Spamming"
			gunaButton2.Text = "Stop Spamming"
			gunaButton1.Enabled = True
			gunaButton2.Enabled = False
		Else
			gunaButton1.Text = "Join guild"
			gunaButton2.Text = "Leave guild"
			gunaButton1.Enabled = True
			gunaButton2.Enabled = True
		End If
	End Sub

	Private Sub siticoneButton23_Click(ByVal sender As Object, ByVal e As EventArgs) Handles siticoneButton23.Click
		Dim thread As New Thread(AddressOf ResetAvatarAll)
		thread.Start()
	End Sub

	Public Sub ResetAvatarAll()
		For Each client As DiscordClient In clients
			'Thread.Sleep(5)
			Dim thread As New Thread(Sub() ResetAvatar(client, GetProxy()))
			thread.Start()
		Next client
	End Sub

	Public Sub ResetAvatar(ByVal client As DiscordClient, ByVal proxyClient As HttpProxyClient)
		client.ResetAvatar(proxyClient)
	End Sub

	Public Sub GenerateText()
		Try
			gunaTextBox5.Text = ""
			Dim placeholders As Integer = 0

			If gunaLineTextBox13.Text.Length > 8 OrElse (Not Microsoft.VisualBasic.Information.IsNumeric(gunaLineTextBox13.Text)) Then
				MessageBox.Show("The number of placeholders is not valid! Please, insert a valid number of placeholders to generate.", "AstarothSpammer", MessageBoxButtons.OK, MessageBoxIcon.Error)
				Return
			End If

			placeholders = Integer.Parse(gunaLineTextBox13.Text)

			If placeholders <= 0 Then
				MessageBox.Show("The number of placeholders is not valid! Please, insert a valid number of placeholders to generate.", "AstarothSpammer", MessageBoxButtons.OK, MessageBoxIcon.Error)
				Return
			End If

			Dim result As String = ""

			For i As Integer = 0 To placeholders - 1
				If siticoneCheckBox6.Checked Then
					result &= "[rndnum] "
				End If

				If siticoneCheckBox10.Checked Then
					result &= "[rndstr] "
				End If

				If siticoneCheckBox24.Checked Then
					result &= "[mtag] "
				End If

				If siticoneCheckBox25.Checked Then
					result &= "[lag] "
				End If

				If siticoneCheckBox30.Checked Then
					result &= "[all] "
				End If

				If siticoneCheckBox31.Checked Then
					result &= "[rtag] "
				End If

				If siticoneCheckBox32.Checked Then
					result &= "[rall] "
				End If
			Next i

			gunaTextBox5.Text = result.Substring(0, result.Length - 1)

			Try
				If siticoneCheckBox26.Checked Then
					Clipboard.SetText(gunaTextBox5.Text)
				End If
			Catch

			End Try
		Catch

		End Try
	End Sub

	Private Sub siticoneCheckBox4_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles siticoneCheckBox4.CheckedChanged
		' Guild Manager - Group Mode
'        try
'        {
'            if (siticoneCheckBox4.Checked)
'            {
'                gunaButton1.Text = "Join group";
'                gunaButton2.Text = "Leave group";
'                siticoneCheckBox1.Checked = false;
'                siticoneCheckBox2.Checked = false;
'                siticoneCheckBox3.Checked = false;
'            }
'            else
'            {
'                gunaButton1.Text = "Join guild";
'                gunaButton2.Text = "Leave guild";
'            }
'        }
'        catch
'        {
'
'        }
	End Sub

	Private Sub siticoneCheckBox19_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles siticoneCheckBox19.CheckedChanged
		Try
			Utils.globalAutoReconnect = siticoneCheckBox19.Checked
		Catch

		End Try
	End Sub

	Private Sub siticoneButton9_Click(ByVal sender As Object, ByVal e As EventArgs) Handles siticoneButton9.Click
		' Settings and Utils - Set new HypeSquad for all tokens
		Try
			Dim thread As New Thread(AddressOf DoHypeSquadSetter)

			thread.Start()
		Catch

		End Try
	End Sub

	Public Sub DoHypeSquadSetter()
		Try
			Dim hypeSquad As HypeSquad = HypeSquad.Balance

			If siticoneComboBox1.SelectedIndex = 1 Then
				hypeSquad = HypeSquad.Bravery
			ElseIf siticoneComboBox1.SelectedIndex = 2 Then
				hypeSquad = HypeSquad.Brilliance
			End If

			Try
				For Each client As DiscordClient In Me.GetClients()
					Thread.Sleep(5)

					Try
						Dim thread As New Thread(Sub() SetHypeSquad(client, hypeSquad, GetProxy()))

						thread.Start()
					Catch

					End Try
				Next client
			Catch

			End Try
		Catch

		End Try
	End Sub

	Public Sub SetHypeSquad(ByVal client As DiscordClient, ByVal hypeSquad As HypeSquad, ByVal proxyClient As HttpProxyClient)
		Try
			client.SetHypeSquad(hypeSquad, proxyClient)
		Catch

		End Try
	End Sub

	Private Sub siticoneCheckBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles siticoneCheckBox1.CheckedChanged
		Try
			If siticoneCheckBox4.Checked Then
				siticoneCheckBox1.Checked = False
			End If
		Catch

		End Try
	End Sub

	Private Sub siticoneCheckBox2_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles siticoneCheckBox2.CheckedChanged
		Try
			If siticoneCheckBox4.Checked Then
				siticoneCheckBox2.Checked = False
			End If
		Catch

		End Try
	End Sub

	Private Sub siticoneCheckBox3_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles siticoneCheckBox3.CheckedChanged
		Try
			If siticoneCheckBox4.Checked Then
				siticoneCheckBox3.Checked = False
			End If
		Catch

		End Try
	End Sub
End Class