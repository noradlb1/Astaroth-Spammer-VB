'INSTANT VB NOTE: This code snippet uses implicit typing. You will need to set 'Option Infer On' in the VB file or set 'Option Infer' at the project level.
'INSTANT VB NOTE: This code snippet uses dynamic typing. You will need to set 'Option Strict Off' in the VB file or set 'Option Strict' off at the project level.

Imports Leaf.xNet
Imports Newtonsoft.Json.Linq
Imports System.Threading
Imports Newtonsoft.Json
Imports System.Net
Imports System
Imports System.Collections.Generic
Imports WebSocketSharp
Imports Microsoft.VisualBasic

Public Class DiscordClient
	Public token As String, language As String = "", cookie As String = "", superProperties As String = "", userAgent As String = "", userId As String = ""
	Public ws As WebSocket
	Public connected, phoneVerified As Boolean
	Public client_build_number As String
	Public queue As New List(Of String)(), idQueue As New List(Of String)()
	Private phoneNumber As String = ""
	Private data As AutoReconnectData = Nothing
	Public connectedToVoice As Boolean
	Public payloads As Integer = 0

	Public Sub New(ByVal token As String)
		Try
			Me.token = token
			Me.userAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:89.0) Gecko/20100101 Firefox/89.0"
		Catch

		End Try
	End Sub

	Public Function GetUserId() As String
		Try
			If userId <> "" Then
				Return userId
			End If

			Try
				Dim request As HttpRequest = Utils.CreateCleanRequest()
				request.AddHeader("Accept", "*/*")
				request.AddHeader("Accept-Encoding", "gzip, deflate, br")
				request.AddHeader("Accept-Language", GetLanguage())
				request.AddHeader("Alt-Used", "discord.com")
				request.AddHeader("Authorization", token)
				request.AddHeader("Connection", "keep-alive")
				request.AddHeader("Cookie", GetCookie())
				request.AddHeader("DNT", "1")
				request.AddHeader("Host", "discord.com")
				request.AddHeader("Origin", "https://discord.com")
				request.AddHeader("Referer", "https://discord.com/channels/@me")
				request.AddHeader("TE", "Trailers")
				request.AddHeader("User-Agent", Me.userAgent)
				request.AddHeader("X-Super-Properties", GetSuperProperties())
				'INSTANT VB NOTE: In the following line, Instant VB substituted 'Object' for 'dynamic' - this will work in VB with Option Strict Off:
				Dim jss As Object = JObject.Parse(Utils.DecompressResponse(request.Get("https://discord.com/api/v9/users/@me")))
				Dim locale As String = CStr(jss.id)
				userId = locale
				Return locale
			Catch
				Return ""
			End Try
		Catch
			Return ""
		End Try
	End Function

	Public Function IsPhoneVerified() As Boolean
		Try
			If phoneNumber <> "" Then
				Return phoneVerified
			End If

			Try
				Dim request As HttpRequest = Utils.CreateCleanRequest()
				request.AddHeader("Accept", "*/*")
				request.AddHeader("Accept-Encoding", "gzip, deflate, br")
				request.AddHeader("Accept-Language", GetLanguage())
				request.AddHeader("Alt-Used", "discord.com")
				request.AddHeader("Authorization", token)
				request.AddHeader("Connection", "keep-alive")
				request.AddHeader("Cookie", GetCookie())
				request.AddHeader("DNT", "1")
				request.AddHeader("Host", "discord.com")
				request.AddHeader("Origin", "https://discord.com")
				request.AddHeader("Referer", "https://discord.com/channels/@me")
				request.AddHeader("TE", "Trailers")
				request.AddHeader("User-Agent", Me.userAgent)
				request.AddHeader("X-Super-Properties", GetSuperProperties())
				Dim lol As String = Utils.DecompressResponse(request.Get("https://discord.com/api/v9/users/@me"))
				'INSTANT VB NOTE: In the following line, Instant VB substituted 'Object' for 'dynamic' - this will work in VB with Option Strict Off:
				Dim jss As Object = JObject.Parse(Utils.DecompressResponse(request.Get("https://discord.com/api/v9/users/@me")))
				Dim locale As String = CStr(jss.phone)

				Try
					If locale Is Nothing OrElse locale = "null" Then
						phoneNumber = "n"
						phoneVerified = False
					End If
				Catch
					phoneNumber = CStr(jss.phone)
					phoneVerified = True
				End Try

				Return phoneVerified
			Catch
				Return False
			End Try
		Catch
			Return False
		End Try
	End Function

	Public Function GetGuildChannels(ByVal guildId As String, ByVal proxyClient As HttpProxyClient) As List(Of String)
		Try
			Dim request As HttpRequest = Utils.CreateCleanRequest()
			request.Proxy = proxyClient
			Dim channels As New List(Of String)()

			request.AddHeader("Accept", "*/*")
			request.AddHeader("Accept-Encoding", "gzip, deflate, br")
			request.AddHeader("Accept-Language", GetLanguage())
			request.AddHeader("Alt-Used", "discord.com")
			request.AddHeader("Authorization", token)
			request.AddHeader("Connection", "keep-alive")
			request.AddHeader("Cookie", GetCookie())
			request.AddHeader("DNT", "1")
			request.AddHeader("Host", "discord.com")
			request.AddHeader("Origin", "https://discord.com")
			request.AddHeader("Referer", "https://discord.com/channels/@me")
			request.AddHeader("TE", "Trailers")
			request.AddHeader("User-Agent", Me.userAgent)
			request.AddHeader("X-Super-Properties", GetSuperProperties())

			Dim response As String = Utils.DecompressResponse(request.Get("https://discord.com/api/v9/guilds/" & guildId & "/channels"))
			'INSTANT VB NOTE: In the following line, Instant VB substituted 'Object' for 'dynamic' - this will work in VB with Option Strict Off:
			Dim dynJson As Object = JsonConvert.DeserializeObject(response)

			For Each item In dynJson
				Try
					If CStr(item.type) = "0" Then
						channels.Add(CStr(item.id))
					End If
				Catch

				End Try
			Next item

			Return channels
		Catch

		End Try

		Return New List(Of String)()
	End Function

	Public Function GetGuildRoles(ByVal guildId As String, ByVal proxyClient As HttpProxyClient) As List(Of String)
		Try
			Dim request As HttpRequest = Utils.CreateCleanRequest()
			request.Proxy = proxyClient
			Dim roles As New List(Of String)()

			request.AddHeader("Accept", "*/*")
			request.AddHeader("Accept-Encoding", "gzip, deflate, br")
			request.AddHeader("Accept-Language", GetLanguage())
			request.AddHeader("Alt-Used", "discord.com")
			request.AddHeader("Authorization", token)
			request.AddHeader("Connection", "keep-alive")
			request.AddHeader("Cookie", GetCookie())
			request.AddHeader("DNT", "1")
			request.AddHeader("Host", "discord.com")
			request.AddHeader("Origin", "https://discord.com")
			request.AddHeader("Referer", "https://discord.com/channels/@me")
			request.AddHeader("TE", "Trailers")
			request.AddHeader("User-Agent", Me.userAgent)
			request.AddHeader("X-Super-Properties", GetSuperProperties())

			Dim response As String = Utils.DecompressResponse(request.Get("https://discord.com/api/v9/guilds/" & guildId & "/roles"))
			'INSTANT VB NOTE: In the following line, Instant VB substituted 'Object' for 'dynamic' - this will work in VB with Option Strict Off:
			Dim dynJson As Object = JsonConvert.DeserializeObject(response)

			For Each item In dynJson
				Try
					If CStr(item.name) <> "@everyone" Then
						roles.Add(CStr(item.id))
					End If
				Catch

				End Try
			Next item

			Return roles
		Catch

		End Try

		Return New List(Of String)()
	End Function

	Public Function GetGroupRecipients(ByVal channelId As String, ByVal proxyClient As HttpProxyClient) As List(Of String)
		Try
			Dim request As HttpRequest = Utils.CreateCleanRequest()
			request.Proxy = proxyClient
			Dim recipients As New List(Of String)()

			request.AddHeader("Accept", "*/*")
			request.AddHeader("Accept-Encoding", "gzip, deflate, br")
			request.AddHeader("Accept-Language", GetLanguage())
			request.AddHeader("Alt-Used", "discord.com")
			request.AddHeader("Authorization", token)
			request.AddHeader("Connection", "keep-alive")
			request.AddHeader("Cookie", GetCookie())
			request.AddHeader("DNT", "1")
			request.AddHeader("Host", "discord.com")
			request.AddHeader("Origin", "https://discord.com")
			request.AddHeader("Referer", "https://discord.com/channels/@me")
			request.AddHeader("TE", "Trailers")
			request.AddHeader("User-Agent", Me.userAgent)
			request.AddHeader("X-Super-Properties", GetSuperProperties())

			Dim response As String = Utils.DecompressResponse(request.Get("https://discord.com/api/v9/channels/" & channelId))
			'INSTANT VB NOTE: In the following line, Instant VB substituted 'Object' for 'dynamic' - this will work in VB with Option Strict Off:
			Dim dynJson As Object = JsonConvert.DeserializeObject(response)

			For Each item In dynJson
				Try
					For Each another In item
						Try
							For Each anotherino In another
								Try
									recipients.Add(CStr(anotherino.id))
								Catch

								End Try
							Next anotherino
						Catch

						End Try
					Next another
				Catch

				End Try
			Next item

			Return recipients
		Catch

		End Try

		Return New List(Of String)()
	End Function

	Public Function GetLanguage() As String
		Try
			If language <> "" Then
				Return language
			End If

			Dim request As New HttpRequest()

			request.AddHeader("Accept", "*/*")
			request.AddHeader("Accept-Encoding", "gzip, deflate, br")
			request.AddHeader("Accept-Language", "it")
			request.AddHeader("Alt-Used", "discord.com")
			request.AddHeader("Authorization", token)
			request.AddHeader("Connection", "keep-alive")
			request.AddHeader("Cookie", GetCookie("it"))
			request.AddHeader("DNT", "1")
			request.AddHeader("Host", "discord.com")
			request.AddHeader("Origin", "https://discord.com")
			request.AddHeader("Referer", "https://discord.com/channels/@me")
			request.AddHeader("TE", "Trailers")
			request.AddHeader("User-Agent", Me.userAgent)
			request.AddHeader("X-Super-Properties", GetSuperProperties())

			Dim response As String = Utils.DecompressResponse(request.Get("https://discord.com/api/v9/users/@me"))
			'INSTANT VB NOTE: In the following line, Instant VB substituted 'Object' for 'dynamic' - this will work in VB with Option Strict Off:
			Dim jss As Object = JObject.Parse(response)

			language = CStr(jss.locale)
			userId = CStr(jss.id)

			Try
				If CStr(jss.phone) IsNot Nothing AndAlso CStr(jss.phone) <> "null" Then
					phoneVerified = True
					phoneNumber = CStr(jss.phone)
				Else
					phoneVerified = False
					phoneNumber = "n"
				End If
			Catch
				phoneVerified = False
				phoneNumber = "n"
			End Try

			Return language
		Catch
			Return ""
		End Try
	End Function

	Public Function GetCookie(Optional ByVal language As String = "") As String
		Try
			If cookie <> "" Then
				Return cookie & "; OptanonConsent=" & Utils.GetTest() & "; __cfruid=" & Utils.GetUniqueKey1(40) & "-1625931828"
			End If

			If language = "" Then
				cookie = Utils.GetRandomCookie(GetLanguage())
			Else
				cookie = Utils.GetRandomCookie(language)
			End If

			Return cookie & "; OptanonConsent=" & Utils.GetTest()
		Catch
			Return ""
		End Try
	End Function

	Public Function GetSuperProperties() As String
		Try
			If superProperties <> "" Then
				Return superProperties
			End If

			client_build_number = Utils.GetUniqueInt(5).ToString()
			superProperties = Utils.Base64Encode("{""os"":""Windows"",""browser"":""Firefox"",""device"":"""",""system_locale"":""it-IT"",""browser_user_agent"":""" & userAgent & """,""browser_version"":""89.0"",""os_version"":""10"",""referrer"":"""",""referring_domain"":"""",""referrer_current"":"""",""referring_domain_current"":"""",""release_channel"":""stable"",""client_build_number"":" & client_build_number & ",""client_event_source"":null}")
			Return superProperties
		Catch
			Return ""
		End Try
	End Function

	Public Function FirstlyFetchInvite(ByVal invite As DiscordInvite, ByVal proxyClient As HttpProxyClient) As Boolean
		Try
			Dim request As HttpRequest = Utils.CreateCleanRequest()
			request.Proxy = proxyClient

			request.AddHeader("Accept", "*/*")
			request.AddHeader("Accept-Encoding", "gzip, deflate, br")
			request.AddHeader("Accept-Language", GetLanguage())
			request.AddHeader("Alt-Used", "discord.com")
			request.AddHeader("Authorization", token)
			request.AddHeader("Connection", "keep-alive")
			request.AddHeader("Cookie", GetCookie())
			request.AddHeader("DNT", "1")
			request.AddHeader("Host", "discord.com")
			request.AddHeader("Origin", "https://discord.com")
			request.AddHeader("Referer", "https://discord.com/channels/@me")
			request.AddHeader("TE", "Trailers")
			request.AddHeader("User-Agent", Me.userAgent)
			request.AddHeader("X-Super-Properties", GetSuperProperties())

			Try
				Return request.Get("https://discord.com/api/v9/invites/" & invite.inviteCode & "?inputValue=" & invite.inviteCode & "&with_counts=true&with_expiration=true").IsOK
			Catch
				Return False
			End Try
		Catch
			Return False
		End Try
	End Function

	Public Function FirstlyFetchGroupInvite(ByVal invite As DiscordInvite, ByVal proxyClient As HttpProxyClient) As Boolean
		Try
			Dim request As HttpRequest = Utils.CreateCleanRequest()
			request.Proxy = proxyClient

			request.AddHeader("Accept", "*/*")
			request.AddHeader("Accept-Encoding", "gzip, deflate, br")
			request.AddHeader("Accept-Language", GetLanguage())
			request.AddHeader("Alt-Used", "discord.com")
			request.AddHeader("Authorization", token)
			request.AddHeader("Connection", "keep-alive")
			request.AddHeader("Cookie", GetCookie())
			request.AddHeader("DNT", "1")
			request.AddHeader("Host", "discord.com")
			request.AddHeader("Referer", "https://discord.com/channels/@me")
			request.AddHeader("TE", "Trailers")
			request.AddHeader("User-Agent", Me.userAgent)
			request.AddHeader("X-Super-Properties", GetSuperProperties())

			Try
				Return request.Get("https://discord.com/api/v9/invites/" & invite.inviteCode & "?with_counts=true&with_expiration=true").IsOK
			Catch
				Return False
			End Try
		Catch
			Return False
		End Try
	End Function

	Public Sub JoinGuild(ByVal invite As DiscordInvite, ByVal contextProperties As String, ByVal captchaBotID As String, ByVal captchaBotChannelID As String, ByVal communityRules As Boolean, ByVal reactionVerification As Boolean, ByVal captchaBot As Boolean, ByVal groupMode As Boolean, ByVal proxyClient As HttpProxyClient, ByVal captchaKey As String)
		Try
			If Not groupMode Then
				If Not FirstlyFetchInvite(invite, proxyClient) Then
					Return
				End If

				Dim request As HttpRequest = Utils.CreateCleanRequest()
				request.Proxy = proxyClient

				request.AddHeader("Accept", "*/*")
				request.AddHeader("Accept-Encoding", "gzip, deflate, br")
				request.AddHeader("Accept-Language", GetLanguage())
				request.AddHeader("Alt-Used", "discord.com")
				request.AddHeader("Authorization", token)
				request.AddHeader("Connection", "keep-alive")
				request.AddHeader("Content-Length", "0")
				request.AddHeader("Cookie", GetCookie())
				request.AddHeader("DNT", "1")
				request.AddHeader("Host", "discord.com")
				request.AddHeader("Origin", "https://discord.com")
				request.AddHeader("Referer", "https://discord.com/channels/@me")
				request.AddHeader("TE", "Trailers")
				request.AddHeader("User-Agent", Me.userAgent)
				request.AddHeader("X-Context-Properties", contextProperties)
				request.AddHeader("X-Super-Properties", GetSuperProperties())

				Try
					request.Post("https://discord.com/api/v9/invites/" & invite.inviteCode)
				Catch

				End Try

				Try
					If request.Response.IsOK AndAlso request.Response.StatusCode = Leaf.xNet.HttpStatusCode.OK Then
						Try
							If communityRules Then
								Dim response As String = Utils.DecompressResponse(request.Response)
								'INSTANT VB NOTE: In the following line, Instant VB substituted 'Object' for 'dynamic' - this will work in VB with Option Strict Off:
								Dim jss As Object = JObject.Parse(response)

								If CBool(jss.show_verification_form) Then
									Thread.Sleep(350)

									Dim rules As String = GetRules(invite, proxyClient)
									BypassRules(invite, rules, proxyClient)
								End If
							End If
						Catch

						End Try

						Try
							Thread.Sleep(1000)

							If reactionVerification Then
								BypassReactionVerification(invite, True, proxyClient)
							Else
								BypassReactionVerification(invite, False, proxyClient)
							End If

							Thread.Sleep(1250)
						Catch

						End Try

						Try
							If captchaBot Then
								Thread.Sleep(1500)
								BypassCaptchaBot(captchaBotID, captchaBotChannelID, proxyClient, captchaKey)
							End If
						Catch

						End Try
					End If
				Catch

				End Try
			Else
				If Not FirstlyFetchGroupInvite(invite, proxyClient) Then
					Return
				End If

				Dim request As HttpRequest = Utils.CreateCleanRequest()
				request.Proxy = proxyClient

				request.AddHeader("Accept", "*/*")
				request.AddHeader("Accept-Encoding", "gzip, deflate, br")
				request.AddHeader("Accept-Language", GetLanguage())
				request.AddHeader("Alt-Used", "discord.com")
				request.AddHeader("Authorization", token)
				request.AddHeader("Connection", "keep-alive")
				request.AddHeader("Content-Length", "0")
				request.AddHeader("Cookie", GetCookie())
				request.AddHeader("DNT", "1")
				request.AddHeader("Host", "discord.com")
				request.AddHeader("Origin", "https://discord.com")
				request.AddHeader("Referer", "https://discord.com/channels/@me")
				request.AddHeader("TE", "Trailers")
				request.AddHeader("User-Agent", Me.userAgent)
				request.AddHeader("X-Context-Properties", contextProperties)
				request.AddHeader("X-Super-Properties", GetSuperProperties())

				Try
					request.Post("https://discord.com/api/v9/invites/" & invite.inviteCode)
				Catch

				End Try
			End If
		Catch

		End Try
	End Sub

	Public Async Sub BypassCaptchaBot(ByVal captchaBotID As String, ByVal captchaBotChannelID As String, ByVal proxyClient As HttpProxyClient, ByVal captchaKey As String)
		Try
			If Utils.IsIDValid(captchaBotID) Then
				Dim embedUrl As String = "", channelId As String = ""

				If Utils.IsIDValid(captchaBotChannelID) Then
					channelId = captchaBotChannelID
				Else
					channelId = GetDMChannel(captchaBotID, proxyClient)
				End If

				embedUrl = GetEmbedURL(channelId, proxyClient)
				Dim request As HttpRequest = Utils.CreateCleanRequest()
				request.Proxy = proxyClient
				Dim captchaBase64 As String = Convert.ToBase64String(request.Get(embedUrl).ToBytes())
				Dim solver As New TwoCaptcha.TwoCaptcha(captchaKey)
				Dim captcha As New TwoCaptcha.Captcha.Normal()
				captcha.SetBase64(captchaBase64)
				captcha.SetCaseSensitive(True)
				Await solver.Solve(captcha)
				Dim solved As String = captcha.Code

				AnswerToCaptcha(channelId, solved, proxyClient)
			End If
		Catch

		End Try
	End Sub

	Public Sub AnswerToCaptcha(ByVal channelId As String, ByVal solved As String, ByVal proxyClient As HttpProxyClient)
		Try
			Dim request As HttpRequest = Utils.CreateCleanRequest()
			request.Proxy = proxyClient
			Dim data As String = "{""content"":""" & solved & """,""nonce"":""" & Utils.GetUniqueLong(18).ToString() & """,""tts"":false}"

			request.AddHeader("Accept", "*/*")
			request.AddHeader("Accept-Encoding", "gzip, deflate, br")
			request.AddHeader("Accept-Language", GetLanguage())
			request.AddHeader("Alt-Used", "discord.com")
			request.AddHeader("Authorization", token)
			request.AddHeader("Connection", "keep-alive")
			request.AddHeader("Content-Length", data.Length.ToString())
			request.AddHeader("Content-Type", "application/json")
			request.AddHeader("Cookie", GetCookie())
			request.AddHeader("DNT", "1")
			request.AddHeader("Host", "discord.com")
			request.AddHeader("Origin", "https://discord.com")
			request.AddHeader("Referer", "https://discord.com/channels/@me/" & channelId)
			request.AddHeader("TE", "Trailers")
			request.AddHeader("User-Agent", Me.userAgent)
			request.AddHeader("X-Super-Properties", GetSuperProperties())

			request.Post("https://discord.com/api/v9/channels/" & channelId & "/messages", data, "application/json")
		Catch

		End Try
	End Sub

	Public Sub BypassReactionVerification(ByVal invite As DiscordInvite, ByVal doThat As Boolean, ByVal proxyClient As HttpProxyClient)
		Try
			Dim request As HttpRequest = Utils.CreateCleanRequest()
			request.Proxy = proxyClient

			request.AddHeader("Accept", "*/*")
			request.AddHeader("Accept-Encoding", "gzip, deflate, br")
			request.AddHeader("Accept-Language", GetLanguage())
			request.AddHeader("Alt-Used", "discord.com")
			request.AddHeader("Authorization", token)
			request.AddHeader("Connection", "keep-alive")
			request.AddHeader("Cookie", GetCookie())
			request.AddHeader("Host", "discord.com")
			request.AddHeader("Referer", "https://discord.com/channels/@me")
			request.AddHeader("TE", "Trailers")
			request.AddHeader("User-Agent", Me.userAgent)
			request.AddHeader("X-Super-Properties", GetSuperProperties())

			Dim messages As String = Utils.DecompressResponse(request.Get("https://discord.com/api/v9/channels/" & invite.channelId & "/messages?limit=50"))

			If doThat Then
				'INSTANT VB NOTE: In the following line, Instant VB substituted 'Object' for 'dynamic' - this will work in VB with Option Strict Off:
				Dim dynJson As Object = JsonConvert.DeserializeObject(messages)

				For Each item In dynJson
					Try
						For Each item1 In item.reactions
							Try
								Dim reaction As String = "", id As String = ""
								id = item1.emoji.id
								reaction = item1.emoji.name

								If id IsNot Nothing AndAlso id <> "" Then
									reaction &= ":" & id
								End If

								Thread.Sleep(1500)
								AddReaction(reaction, invite.channelId.ToString(), CStr(item.id), proxyClient)
							Catch

							End Try
						Next item1
					Catch

					End Try
				Next item

				Try
					Dim channelDone As String = invite.channelId.ToString()

					For Each channelId As String In GetGuildChannels(invite.guildId.ToString(), proxyClient)
						If channelId = channelDone Then
							Continue For
						End If

						Try
							Dim request1 As HttpRequest = Utils.CreateCleanRequest()
							request1.Proxy = proxyClient

							request1.AddHeader("Accept", "*/*")
							request1.AddHeader("Accept-Encoding", "gzip, deflate, br")
							request1.AddHeader("Accept-Language", GetLanguage())
							request1.AddHeader("Alt-Used", "discord.com")
							request1.AddHeader("Authorization", token)
							request1.AddHeader("Connection", "keep-alive")
							request1.AddHeader("Cookie", GetCookie())
							request1.AddHeader("Host", "discord.com")
							request1.AddHeader("Referer", "https://discord.com/channels/@me")
							request1.AddHeader("TE", "Trailers")
							request1.AddHeader("User-Agent", Me.userAgent)
							request1.AddHeader("X-Super-Properties", GetSuperProperties())

							Dim messages1 As String = Utils.DecompressResponse(request1.Get("https://discord.com/api/v9/channels/" & channelId & "/messages?limit=50"))
							'INSTANT VB NOTE: In the following line, Instant VB substituted 'Object' for 'dynamic' - this will work in VB with Option Strict Off:
							Dim dynJson1 As Object = JsonConvert.DeserializeObject(messages1)

							For Each item In dynJson1
								Try
									For Each item1 In item.reactions
										Try
											Dim reaction As String = "", id As String = ""
											id = item1.emoji.id
											reaction = item1.emoji.name

											If id IsNot Nothing AndAlso id <> "" Then
												reaction &= ":" & id
											End If

											Thread.Sleep(1500)
											AddReaction(reaction, channelId, CStr(item.id), proxyClient)
										Catch

										End Try
									Next item1
								Catch

								End Try
							Next item
						Catch

						End Try
					Next channelId
				Catch

				End Try
			End If
		Catch

		End Try
	End Sub

	Public Sub AddReaction(ByVal reaction As String, ByVal channelId As String, ByVal messageId As String, ByVal proxyClient As HttpProxyClient)
		Try
			Dim request As HttpRequest = Utils.CreateCleanRequest()
			request.Proxy = proxyClient

			request.AddHeader("Accept", "*/*")
			request.AddHeader("Accept-Encoding", "gzip, deflate, br")
			request.AddHeader("Accept-Language", GetLanguage())
			request.AddHeader("Alt-Used", "discord.com")
			request.AddHeader("Authorization", token)
			request.AddHeader("Connection", "keep-alive")
			request.AddHeader("Content-Length", "0")
			request.AddHeader("Cookie", GetCookie())
			request.AddHeader("DNT", "1")
			request.AddHeader("Host", "discord.com")
			request.AddHeader("Origin", "https://discord.com")
			request.AddHeader("Referer", "https://discord.com/channels/" & channelId & "/" & messageId)
			request.AddHeader("TE", "Trailers")
			request.AddHeader("User-Agent", Me.userAgent)
			request.AddHeader("X-Super-Properties", GetSuperProperties())

			request.Put("https://discord.com/api/v9/channels/" & channelId & "/messages/" & messageId & "/reactions/" & reaction & "/@me")
		Catch

		End Try
	End Sub

	Public Function GetRules(ByVal invite As DiscordInvite, ByVal proxyClient As HttpProxyClient) As String
		Try
			Dim request As HttpRequest = Utils.CreateCleanRequest()
			request.Proxy = proxyClient

			request.AddHeader("Accept", "*/*")
			request.AddHeader("Accept-Encoding", "gzip, deflate, br")
			request.AddHeader("Accept-Language", GetLanguage())
			request.AddHeader("Alt-Used", "discord.com")
			request.AddHeader("Authorization", token)
			request.AddHeader("Connection", "keep-alive")
			request.AddHeader("Cookie", GetCookie())
			request.AddHeader("DNT", "1")
			request.AddHeader("Host", "discord.com")
			request.AddHeader("Referer", "https://discord.com/channels/" & invite.guildId & "/" & invite.channelId)
			request.AddHeader("TE", "Trailers")
			request.AddHeader("User-Agent", Me.userAgent)
			request.AddHeader("X-Super-Properties", GetSuperProperties())

			Dim data As String = Utils.DecompressResponse(request.Get("https://discord.com/api/v9/guilds/" & invite.guildId & "/member-verification?with_guild=false&invite_code=" & invite.inviteCode)), toSend As String = ""

			If data.Contains("""form_fields"": []") OrElse data.Contains("""form_fields"":[]") Then
				Dim lol1 As String = Microsoft.VisualBasic.Strings.Split(data, "{""version"": """)(1)
				Dim lol2 As String = Microsoft.VisualBasic.Strings.Split(lol1, """")(0)

				toSend = "{""version"": """ & lol2 & """,""form_fields"": []}"
			Else
				Dim lol1 As String = Microsoft.VisualBasic.Strings.Split(data, "}], ""description"":")(0)

				toSend = lol1 & ",""response"":true}]}"
			End If

			Return toSend
		Catch
			Return ""
		End Try
	End Function

	Public Sub BypassRules(ByVal invite As DiscordInvite, ByVal data As String, ByVal proxyClient As HttpProxyClient)
		Try
			Dim request As HttpRequest = Utils.CreateCleanRequest()
			request.Proxy = proxyClient

			request.AddHeader("Accept", "*/*")
			request.AddHeader("Accept-Encoding", "gzip, deflate, br")
			request.AddHeader("Accept-Language", GetLanguage())
			request.AddHeader("Alt-Used", "discord.com")
			request.AddHeader("Authorization", token)
			request.AddHeader("Connection", "keep-alive")
			request.AddHeader("Content-Length", data.Length.ToString())
			request.AddHeader("Content-Type", "application/json")
			request.AddHeader("Cookie", GetCookie())
			request.AddHeader("DNT", "1")
			request.AddHeader("Host", "discord.com")
			request.AddHeader("Origin", "https://discord.com")
			request.AddHeader("Referer", "https://discord.com/channels/" & invite.guildId & "/" & invite.channelId)
			request.AddHeader("TE", "Trailers")
			request.AddHeader("User-Agent", Me.userAgent)
			request.AddHeader("X-Super-Properties", GetSuperProperties())

			request.Put("https://discord.com/api/v9/guilds/" & invite.guildId & "/requests/@me", data, "application/json")
		Catch

		End Try
	End Sub

	Public Sub LeaveGuild(ByVal invite As DiscordInvite, ByVal groupMode As Boolean, ByVal proxyClient As HttpProxyClient)
		Try
			If groupMode Then
				LeaveGuild(invite.channelId.ToString(), groupMode, proxyClient)
			Else
				LeaveGuild(invite.guildId.ToString(), groupMode, proxyClient)
			End If
		Catch

		End Try
	End Sub

	Public Sub LeaveGuild(ByVal guildId As String, ByVal groupMode As Boolean, ByVal proxyClient As HttpProxyClient)
		Try
			If Not groupMode Then
				Dim request As HttpRequest = Utils.CreateCleanRequest()
				request.Proxy = proxyClient

				request.AddHeader("Accept", "*/*")
				request.AddHeader("Accept-Encoding", "gzip, deflate, br")
				request.AddHeader("Accept-Language", GetLanguage())
				request.AddHeader("Alt-Used", "discord.com")
				request.AddHeader("Authorization", token)
				request.AddHeader("Connection", "keep-alive")
				request.AddHeader("Content-Length", "17")
				request.AddHeader("Content-Type", "application/json")
				request.AddHeader("Cookie", GetCookie())
				request.AddHeader("DNT", "1")
				request.AddHeader("Host", "discord.com")
				request.AddHeader("Origin", "https://discord.com")
				request.AddHeader("Referer", "https://discord.com/channels/@me")
				request.AddHeader("TE", "Trailers")
				request.AddHeader("User-Agent", Me.userAgent)
				request.AddHeader("X-Super-Properties", GetSuperProperties())

				request.Delete("https://discord.com/api/v9/users/@me/guilds/" & guildId, "{""lurking"":false}", "application/json")
			Else
				Dim request As HttpRequest = Utils.CreateCleanRequest()
				request.Proxy = proxyClient

				request.AddHeader("Accept", "*/*")
				request.AddHeader("Accept-Encoding", "gzip, deflate, br")
				request.AddHeader("Accept-Language", GetLanguage())
				request.AddHeader("Alt-Used", "discord.com")
				request.AddHeader("Authorization", token)
				request.AddHeader("Connection", "keep-alive")
				request.AddHeader("Content-Length", "17")
				request.AddHeader("Content-Type", "application/json")
				request.AddHeader("Cookie", GetCookie())
				request.AddHeader("DNT", "1")
				request.AddHeader("Host", "discord.com")
				request.AddHeader("Origin", "https://discord.com")
				request.AddHeader("Referer", "https://discord.com/channels/@me")
				request.AddHeader("TE", "Trailers")
				request.AddHeader("User-Agent", Me.userAgent)
				request.AddHeader("X-Super-Properties", GetSuperProperties())

				request.Delete("https://discord.com/api/v9/channels/" & guildId, "{""lurking"":false}", "application/json")
			End If
		Catch

		End Try
	End Sub

	Public Sub ReadChannel(ByVal channelId As String, ByVal proxyClient As HttpProxyClient)
		Try
			Dim request As HttpRequest = Utils.CreateCleanRequest()
			request.Proxy = proxyClient

			request.AddHeader("Accept", "*/*")
			request.AddHeader("Accept-Encoding", "gzip, deflate, br")
			request.AddHeader("Accept-Language", GetLanguage())
			request.AddHeader("Alt-Used", "discord.com")
			request.AddHeader("Authorization", token)
			request.AddHeader("Connection", "keep-alive")
			request.AddHeader("Cookie", GetCookie())
			request.AddHeader("Host", "discord.com")
			request.AddHeader("Referer", "https://discord.com/channels/@me/" & channelId)
			request.AddHeader("TE", "Trailers")
			request.AddHeader("User-Agent", Me.userAgent)
			request.AddHeader("X-Super-Properties", GetSuperProperties())

			request.Get("https://discord.com/api/v9/channels/" & channelId & "/messages?limit=50")
		Catch

		End Try
	End Sub

	Public Function GetEmbedURL(ByVal channelId As String, ByVal proxyClient As HttpProxyClient) As String
		Try
			Dim request As HttpRequest = Utils.CreateCleanRequest()
			request.Proxy = proxyClient

			request.AddHeader("Accept", "*/*")
			request.AddHeader("Accept-Encoding", "gzip, deflate, br")
			request.AddHeader("Accept-Language", GetLanguage())
			request.AddHeader("Alt-Used", "discord.com")
			request.AddHeader("Authorization", token)
			request.AddHeader("Connection", "keep-alive")
			request.AddHeader("Cookie", GetCookie())
			request.AddHeader("Host", "discord.com")
			request.AddHeader("Referer", "https://discord.com/channels/@me/" & channelId)
			request.AddHeader("TE", "Trailers")
			request.AddHeader("User-Agent", Me.userAgent)
			request.AddHeader("X-Super-Properties", GetSuperProperties())

			Dim messages As String = Utils.DecompressResponse(request.Get("https://discord.com/api/v9/channels/" & channelId & "/messages?limit=50"))
			'INSTANT VB NOTE: In the following line, Instant VB substituted 'Object' for 'dynamic' - this will work in VB with Option Strict Off:
			Dim dynJson As Object = JsonConvert.DeserializeObject(messages)

			For Each item In dynJson
				Try
					For Each item1 In item.embeds
						Try
							Return CStr(item1.image.url)
						Catch

						End Try
					Next item1

					Exit For
				Catch

				End Try
			Next item
		Catch

		End Try

		Return ""
	End Function

	Public Function GetDMChannel(ByVal userId As String, ByVal proxyClient As HttpProxyClient) As String
		Try
			Dim request As HttpRequest = Utils.CreateCleanRequest()
			request.Proxy = proxyClient

			request.AddHeader("Accept", "*/*")
			request.AddHeader("Accept-Encoding", "gzip, deflate, br")
			request.AddHeader("Accept-Language", GetLanguage())
			request.AddHeader("Alt-Used", "discord.com")
			request.AddHeader("Authorization", token)
			request.AddHeader("Connection", "keep-alive")
			request.AddHeader("Cookie", GetCookie())
			request.AddHeader("DNT", "1")
			request.AddHeader("Host", "discord.com")
			request.AddHeader("Origin", "https://discord.com")
			request.AddHeader("Referer", "https://discord.com/channels/@me")
			request.AddHeader("TE", "Trailers")
			request.AddHeader("User-Agent", Me.userAgent)
			request.AddHeader("X-Super-Properties", GetSuperProperties())

			Dim dms As String = Utils.DecompressResponse(request.Get("https://discord.com/api/v9/users/@me/channels"))
			'INSTANT VB NOTE: In the following line, Instant VB substituted 'Object' for 'dynamic' - this will work in VB with Option Strict Off:
			Dim jss As Object = JsonConvert.DeserializeObject(dms)

			For Each item In jss
				Try
					For Each another In item.recipients
						Try
							If CStr(another.id) = userId Then
								Return CStr(item.id)
							End If
						Catch

						End Try
					Next another
				Catch

				End Try
			Next item

			Return CreateDM(userId, proxyClient)
		Catch

		End Try

		Return ""
	End Function

	Public Function CreateDM(ByVal userId As String, ByVal proxyClient As HttpProxyClient) As String
		Try
			Dim request As HttpRequest = Utils.CreateCleanRequest()
			request.Proxy = proxyClient
			Dim data As String = "{""recipients"":[""" & userId & """]}"

			request.AddHeader("Accept", "*/*")
			request.AddHeader("Accept-Encoding", "gzip, deflate, br")
			request.AddHeader("Accept-Language", GetLanguage())
			request.AddHeader("Alt-Used", "discord.com")
			request.AddHeader("Authorization", token)
			request.AddHeader("Connection", "keep-alive")
			request.AddHeader("Content-Length", data.Length.ToString())
			request.AddHeader("Content-Type", "application/json")
			request.AddHeader("Cookie", GetCookie())
			request.AddHeader("DNT", "1")
			request.AddHeader("Host", "discord.com")
			request.AddHeader("Origin", "https://discord.com")
			request.AddHeader("Referer", "https://discord.com/channels/@me")
			request.AddHeader("TE", "Trailers")
			request.AddHeader("User-Agent", Me.userAgent)
			request.AddHeader("X-Context-Properties", "e30=")
			request.AddHeader("X-Super-Properties", GetSuperProperties())

			Dim result As String = Utils.DecompressResponse(request.Post("https://discord.com/api/v9/users/@me/channels", data, "application/json"))
			'INSTANT VB NOTE: In the following line, Instant VB substituted 'Object' for 'dynamic' - this will work in VB with Option Strict Off:
			Dim jss As Object = JObject.Parse(result)
			Dim theId As String = CStr(jss.id)

			Return theId
		Catch

		End Try

		Return ""
	End Function

	Public Sub ConnectToWebSocket()
		Try
			If Not connected Then
				ws = New WebSocket("wss://gateway.discord.gg/?encoding=json&v=9")
				ws.SslConfiguration.EnabledSslProtocols = System.Security.Authentication.SslProtocols.Tls12
				ws.Origin = "https://discord.com"
				ws.EnableRedirection = False
				ws.EmitOnPing = False
				ws.CustomHeaders = New Dictionary(Of String, String) From {{"Accept", "*/*"}, {"Accept-Encoding", "gzip, deflate, br"}, {"Accept-Language", "it-IT,it;q=0.8,en-US;q=0.5,en;q=0.3"}, {"Cache-Control", "no-cache"}, {"Connection", "keep-alive, Upgrade"}, {"DNT", "1"}, {"Host", "gateway.discord.gg"}, {"Origin", "https://discord.com"}, {"Pragma", "no-cache"}, {"Sec-WebSocket-Extensions", "permessage-deflate"}, {"Sec-WebSocket-Version", "13"}, {"Upgrade", "WebSocket"}, {"User-Agent", Me.userAgent}}
				GetSuperProperties()
				CType(New Thread(AddressOf fetchQueue), Thread).Start()
				AddHandler ws.OnMessage, AddressOf Ws_OnMessage
				ws.Connect()
				ws.Send("{""op"":2,""d"":{""token"":""" & token & """,""capabilities"":125,""properties"":{""os"":""Windows"",""browser"":""Firefox"",""device"":"""",""system_locale"":""it-IT"",""browser_user_agent"":""Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:89.0) Gecko/20100101 Firefox/89.0"",""browser_version"":""89.0"",""os_version"":""10"",""referrer"":"""",""referring_domain"":"""",""referrer_current"":"""",""referring_domain_current"":"""",""release_channel"":""stable"",""client_build_number"":" & client_build_number.ToString() & ",""client_event_source"":null},""presence"":{""status"":""online"",""since"":0,""activities"":[],""afk"":false},""compress"":false,""client_state"":{""guild_hashes"":{},""highest_last_message_id"":""0"",""read_state_version"":0,""user_guild_settings_version"":-1}}}")
				connected = True
			End If
		Catch

		End Try
	End Sub

	Private Sub Ws_OnMessage(ByVal sender As Object, ByVal e As MessageEventArgs)
		Try
			Dim data As String = System.Text.Encoding.UTF8.GetString(e.RawData)
			queue.Add(data)
			'INSTANT VB NOTE: In the following line, Instant VB substituted 'Object' for 'dynamic' - this will work in VB with Option Strict Off:
			Dim jss As Object = JObject.Parse(data)

			If jss.op = 10 Then
				Dim heartbeat_interval As Integer = jss.d.heartbeat_interval
				CType(New Thread(Sub() doHeartbeat(heartbeat_interval)), Thread).Start()
			End If

			If jss.t = "GUILD_MEMBER_LIST_UPDATE" Then
				idQueue.Add(data)
				payloads += 1
			ElseIf CStr(jss.t) = "VOICE_STATE_UPDATE" Then
				Try
					If CStr(jss.d.member.user.id) = GetUserId() Then
						If CStr(jss.d.channel_id) Is Nothing OrElse CStr(jss.d.channel_id) = "null" Then
							connectedToVoice = False

							If Me.data IsNot Nothing Then
								If Utils.globalAutoReconnect Then
									JoinVoice(Me.data.guildId, Me.data.channelId, Me.data.userIdGoLive, Me.data.microphoneMuted, Me.data.headphonesMuted, Me.data.videoEnabled, Me.data.goLive, Me.data.joinGoLive, Me.data.speakInStage)
								End If
							End If
						Else
							connectedToVoice = True
						End If
					End If
				Catch
					connectedToVoice = False
				End Try
			End If
		Catch

		End Try
	End Sub

	Public Sub doHeartbeat(ByVal heartbeat_interval As Integer)
		Try
			Do
				Try
					Thread.Sleep(heartbeat_interval)
					ws.Send("{""op"":1,""d"":null}")
				Catch

				End Try
			Loop
		Catch

		End Try
	End Sub

	Public Sub fetchQueue()
		Do
			Thread.Sleep(250)

			Try
				If Not (queue.Count <= 0) Then
					Dim data As String = queue(0)
					queue.RemoveAt(0)
				End If
			Catch

			End Try

			Try
				If Not (idQueue.Count <= 0) Then
					Dim data As String = idQueue(0)
					idQueue.RemoveAt(0)

					Dim splitted() As String = Strings.Split(data, """id"":""")

					For i1 As Integer = 1 To splitted.Length - 1
						Try
							Dim another As String = splitted(i1)

							Dim anotherSplit() As String = Strings.Split(another, """")
							Dim finalId As String = anotherSplit(0)

							If Information.IsNumeric(finalId) AndAlso finalId.Length = 18 AndAlso data.Contains(finalId & """"c & "," & """"c & "discriminator") AndAlso (Not Utils.users.Contains(finalId)) Then
								Utils.users.Add(finalId)
							End If
						Catch

						End Try
					Next i1

					Dim i As Integer = 0
					Do While i < Utils.users.Count
						Try
							Dim j As Integer = 0
							Do While j < Utils.users.Count
								Try
									If i <> j Then
										If Utils.users(i) = Utils.users(j) Then
											Utils.users.RemoveAt(i)
										End If
									End If
								Catch

								End Try
								j += 1
							Loop
						Catch

						End Try
						i += 1
					Loop
				End If
			Catch

			End Try
		Loop
	End Sub

	Public Sub ParseGroup(ByVal invite As DiscordInvite, ByVal proxyClient As HttpProxyClient)
		Try
			Utils.users.Clear()
			Utils.users.AddRange(GetGroupRecipients(invite.channelId.ToString(), proxyClient))
		Catch

		End Try
	End Sub

	Public Sub ParseGuild(ByVal invite As DiscordInvite, ByVal proxyClient As HttpProxyClient, ByVal channelId As String)
		Try
			If Utils.lastChannelId = channelId Then
				payloads = 0
				Utils.users.Clear()

				Try
					'Thread.Sleep(1000);
					Dim first As Integer = 0, second As Integer = 99

					If Utils.lastChannelId = channelId Then
						Try
							ws.Send("{""op"":14,""d"":{""guild_id"":""" & invite.guildId.ToString() & """,""typing"":true,""activities"":true,""threads"":true,""channels"":{""" & channelId.ToString() & """:[[" & first.ToString() & "," & second.ToString() & "]]}}}")
						Catch

						End Try
					Else
						Return
					End If

					Dim members As ULong = invite.membersCount
					'Thread.Sleep(1000);

					Do While members > 100 AndAlso Utils.lastChannelId = channelId
						Try
							'Thread.Sleep(1000);

							If payloads >= 2 Then
								payloads = 0
								first += 100
								second += 100
								members -= 100

								If Utils.lastChannelId <> channelId Then
									Return
								End If

								Try
									ws.Send("{""op"":14,""d"":{""guild_id"":""" & invite.guildId.ToString() & """,""typing"":true,""activities"":true,""threads"":true,""channels"":{""" & channelId.ToString() & """:[[" & first.ToString() & "," & second.ToString() & "]]}}}")
								Catch

								End Try

								If Utils.lastChannelId <> channelId Then
									Return
								End If
							End If
						Catch

						End Try
					Loop
				Catch

				End Try
			End If
		Catch

		End Try
	End Sub

	Public Sub SendMessage(ByVal channelId As String, ByVal message As String, ByVal reference As String, ByVal proxyClient As HttpProxyClient, Optional ByVal delete As Boolean = False)
		Try
			Dim request As HttpRequest = Utils.CreateCleanRequest()
			request.Proxy = proxyClient

			Dim data As String = ""

			If reference = "" Then
				data = "{""content"":""" & message & """,""nonce"":""" & Utils.GetUniqueLong(18).ToString() & """,""tts"":false}"
			Else
				data = "{""content"":""" & message & """,""nonce"":""" & Utils.GetUniqueLong(18).ToString() & """,""tts"":false,""message_reference"":{""channel_id"":""" & channelId & """,""message_id"":""" & reference & """}}"
			End If

			request.AddHeader("Accept", "*/*")
			request.AddHeader("Accept-Encoding", "gzip, deflate, br")
			request.AddHeader("Accept-Language", GetLanguage())
			request.AddHeader("Alt-Used", "discord.com")
			request.AddHeader("Authorization", token)
			request.AddHeader("Connection", "keep-alive")
			request.AddHeader("Content-Length", data.Length.ToString())
			request.AddHeader("Content-Type", "application/json")
			request.AddHeader("Cookie", GetCookie())
			request.AddHeader("DNT", "1")
			request.AddHeader("Host", "discord.com")
			request.AddHeader("Origin", "https://discord.com")
			request.AddHeader("Referer", "https://discord.com/channels/@me/" & channelId)
			request.AddHeader("TE", "Trailers")
			request.AddHeader("User-Agent", Me.userAgent)
			request.AddHeader("X-Super-Properties", GetSuperProperties())

			'INSTANT VB NOTE: In the following line, Instant VB substituted 'Object' for 'dynamic' - this will work in VB with Option Strict Off:
			Dim jss As Object = JObject.Parse(Utils.DecompressResponse(request.Post("https://discord.com/api/v9/channels/" & channelId & "/messages", data, "application/json")))
			Dim theId As String = CStr(jss.id)

			If delete Then
				DeleteMessage(channelId, theId, proxyClient)
			End If
		Catch

		End Try
	End Sub

	Public Sub SendToWS(ByVal data As String)
		Try
			If Not connected Then
				ConnectToWebSocket()
			End If

			ws.Send(data)
		Catch

		End Try
	End Sub

	Public Sub SetStatus(ByVal status As UserStatus, ByVal proxyClient As HttpProxyClient)
		Try
			Dim request As HttpRequest = Utils.CreateCleanRequest()
			request.Proxy = proxyClient

			Dim theStatus As String = "online"

			If status.Equals(UserStatus.DoNotDisturb) Then
				theStatus = "dnd"
			ElseIf status.Equals(UserStatus.Idle) Then
				theStatus = "idle"
			ElseIf status.Equals(UserStatus.Invisible) Then
				theStatus = "invisible"
			End If

			Dim data As String = "{""status"":""" & theStatus & """}"

			request.AddHeader("Accept", "*/*")
			request.AddHeader("Accept-Encoding", "gzip, deflate, br")
			request.AddHeader("Accept-Language", GetLanguage())
			request.AddHeader("Alt-Used", "discord.com")
			request.AddHeader("Authorization", token)
			request.AddHeader("Connection", "keep-alive")
			request.AddHeader("Content-Length", data.Length.ToString())
			request.AddHeader("Content-Type", "application/json")
			request.AddHeader("Cookie", GetCookie())
			request.AddHeader("DNT", "1")
			request.AddHeader("Host", "discord.com")
			request.AddHeader("Origin", "https://discord.com")
			request.AddHeader("Referer", "https://discord.com/channels/@me")
			request.AddHeader("TE", "Trailers")
			request.AddHeader("User-Agent", Me.userAgent)
			request.AddHeader("X-Super-Properties", GetSuperProperties())

			request.Patch("https://discord.com/api/v9/users/@me/settings", data, "application/json")
		Catch

		End Try
	End Sub

	Public Sub SetNickname(ByVal guildId As String, ByVal nickname As String, ByVal proxyClient As HttpProxyClient)
		Try
			Dim request As HttpRequest = Utils.CreateCleanRequest()
			request.Proxy = proxyClient

			Dim data As String = "{""nick"":""" & nickname & """}"

			request.AddHeader("Accept", "*/*")
			request.AddHeader("Accept-Encoding", "gzip, deflate, br")
			request.AddHeader("Accept-Language", GetLanguage())
			request.AddHeader("Alt-Used", "discord.com")
			request.AddHeader("Authorization", token)
			request.AddHeader("Connection", "keep-alive")
			request.AddHeader("Content-Length", data.Length.ToString())
			request.AddHeader("Content-Type", "application/json")
			request.AddHeader("Cookie", GetCookie())
			request.AddHeader("DNT", "1")
			request.AddHeader("Host", "discord.com")
			request.AddHeader("Origin", "https://discord.com")
			request.AddHeader("Referer", "https://discord.com/channels/@me")
			request.AddHeader("TE", "Trailers")
			request.AddHeader("User-Agent", Me.userAgent)
			request.AddHeader("X-Super-Properties", GetSuperProperties())

			request.Patch("https://discord.com/api/v9/guilds/" & guildId & "/members/@me", data, "application/json")
		Catch

		End Try
	End Sub

	Public Sub SetHypeSquad(ByVal house As HypeSquad, ByVal proxyClient As HttpProxyClient)
		Try
			Dim request As HttpRequest = Utils.CreateCleanRequest()
			request.Proxy = proxyClient

			Dim hypesquad As Integer = 1

			'If house.Equals(hypesquad.Balance) Then
			'	hypesquad = 3
			'ElseIf house.Equals(hypesquad.Brilliance) Then
			'	hypesquad = 2
			'End If

			Dim data As String = "{""house_id"":" & hypesquad.ToString() & "}"

			request.AddHeader("Accept", "*/*")
			request.AddHeader("Accept-Encoding", "gzip, deflate, br")
			request.AddHeader("Accept-Language", GetLanguage())
			request.AddHeader("Alt-Used", "discord.com")
			request.AddHeader("Authorization", token)
			request.AddHeader("Connection", "keep-alive")
			request.AddHeader("Content-Length", data.Length.ToString())
			request.AddHeader("Content-Type", "application/json")
			request.AddHeader("Cookie", GetCookie())
			request.AddHeader("DNT", "1")
			request.AddHeader("Host", "discord.com")
			request.AddHeader("Origin", "https://discord.com")
			request.AddHeader("Referer", "https://discord.com/channels/@me")
			request.AddHeader("TE", "Trailers")
			request.AddHeader("User-Agent", Me.userAgent)
			request.AddHeader("X-Super-Properties", GetSuperProperties())

			request.Post("https://discord.com/api/v9/hypesquad/online", data, "application/json")
		Catch

		End Try
	End Sub

	Public Sub TypeInChannel(ByVal channelId As String, ByVal proxyClient As HttpProxyClient)
		Try
			Dim request As HttpRequest = Utils.CreateCleanRequest()
			request.Proxy = proxyClient

			request.AddHeader("Accept", "*/*")
			request.AddHeader("Accept-Encoding", "gzip, deflate, br")
			request.AddHeader("Accept-Language", GetLanguage())
			request.AddHeader("Alt-Used", "discord.com")
			request.AddHeader("Authorization", token)
			request.AddHeader("Connection", "keep-alive")
			request.AddHeader("Connection", "keep-alive")
			request.AddHeader("Content-Length", "0")
			request.AddHeader("Cookie", GetCookie())
			request.AddHeader("DNT", "1")
			request.AddHeader("Host", "discord.com")
			request.AddHeader("Origin", "https://discord.com")
			request.AddHeader("Referer", "https://discord.com/channels/@me/" & channelId)
			request.AddHeader("TE", "Trailers")
			request.AddHeader("User-Agent", Me.userAgent)
			request.AddHeader("X-Super-Properties", GetSuperProperties())

			request.Post("https://discord.com/api/v9/channels/" & channelId & "/typing")
		Catch

		End Try
	End Sub

	Public Sub AddFriend(ByVal [friend] As String, ByVal proxyClient As HttpProxyClient)
		Try
			If Utils.IsIDValid([friend]) Then
				AddFriendByID([friend], proxyClient)
			ElseIf Utils.IsTagValid([friend]) Then
				AddFriendByTag([friend], proxyClient)
			End If
		Catch

		End Try
	End Sub

	Public Sub AddFriendByID(ByVal userId As String, ByVal proxyClient As HttpProxyClient)
		Try
			Dim request As HttpRequest = Utils.CreateCleanRequest()
			request.Proxy = proxyClient

			request.AddHeader("Accept", "*/*")
			request.AddHeader("Accept-Encoding", "gzip, deflate, br")
			request.AddHeader("Accept-Language", GetLanguage())
			request.AddHeader("Alt-Used", "discord.com")
			request.AddHeader("Authorization", token)
			request.AddHeader("Connection", "keep-alive")
			request.AddHeader("Content-Length", "2")
			request.AddHeader("Content-Type", "application/json")
			request.AddHeader("Cookie", GetCookie())
			request.AddHeader("DNT", "1")
			request.AddHeader("Host", "discord.com")
			request.AddHeader("Origin", "https://discord.com")
			request.AddHeader("Referer", "https://discord.com/channels/@me")
			request.AddHeader("TE", "Trailers")
			request.AddHeader("User-Agent", Me.userAgent)
			request.AddHeader("X-Context-Properties", "eyJsb2NhdGlvbiI6IkNvbnRleHRNZW51In0=")
			request.AddHeader("X-Super-Properties", GetSuperProperties())

			request.Put("https://discord.com/api/v9/users/@me/relationships/" & userId, "{}", "application/json")
		Catch

		End Try
	End Sub

	Public Sub AddFriendByTag(ByVal tag As String, ByVal proxyClient As HttpProxyClient)
		Try
			Dim request As HttpRequest = Utils.CreateCleanRequest()
			request.Proxy = proxyClient

			Dim splitted() As String = Strings.Split(tag, "#")
			Dim data As String = "{""username"":""" & splitted(0) & """,""discriminator"":" & splitted(1) & "}"

			request.AddHeader("Accept", "*/*")
			request.AddHeader("Accept-Encoding", "gzip, deflate, br")
			request.AddHeader("Accept-Language", GetLanguage())
			request.AddHeader("Alt-Used", "discord.com")
			request.AddHeader("Authorization", token)
			request.AddHeader("Connection", "keep-alive")
			request.AddHeader("Content-Length", data.Length.ToString())
			request.AddHeader("Content-Type", "application/json")
			request.AddHeader("Cookie", GetCookie())
			request.AddHeader("DNT", "1")
			request.AddHeader("Host", "discord.com")
			request.AddHeader("Origin", "https://discord.com")
			request.AddHeader("Referer", "https://discord.com/channels/@me")
			request.AddHeader("TE", "Trailers")
			request.AddHeader("User-Agent", Me.userAgent)
			request.AddHeader("X-Context-Properties", "eyJsb2NhdGlvbiI6IkFkZCBGcmllbmQifQ==")
			request.AddHeader("X-Super-Properties", GetSuperProperties())

			request.Post("https://discord.com/api/v9/users/@me/relationships", data, "application/json")
		Catch

		End Try
	End Sub

	Public Sub AddFriendByTag(ByVal username As String, ByVal discriminator As String, ByVal proxyClient As HttpProxyClient)
		Try
			Dim request As HttpRequest = Utils.CreateCleanRequest()
			request.Proxy = proxyClient

			Dim data As String = "{""username"":""" & username & """,""discriminator"":" & discriminator & "}"

			request.AddHeader("Accept", "*/*")
			request.AddHeader("Accept-Encoding", "gzip, deflate, br")
			request.AddHeader("Accept-Language", GetLanguage())
			request.AddHeader("Alt-Used", "discord.com")
			request.AddHeader("Authorization", token)
			request.AddHeader("Connection", "keep-alive")
			request.AddHeader("Content-Length", data.Length.ToString())
			request.AddHeader("Content-Type", "application/json")
			request.AddHeader("Cookie", GetCookie())
			request.AddHeader("DNT", "1")
			request.AddHeader("Host", "discord.com")
			request.AddHeader("Origin", "https://discord.com")
			request.AddHeader("Referer", "https://discord.com/channels/@me")
			request.AddHeader("TE", "Trailers")
			request.AddHeader("User-Agent", Me.userAgent)
			request.AddHeader("X-Context-Properties", "eyJsb2NhdGlvbiI6IkFkZCBGcmllbmQifQ==")
			request.AddHeader("X-Super-Properties", GetSuperProperties())

			request.Post("https://discord.com/api/v9/users/@me/relationships", data, "application/json")
		Catch

		End Try
	End Sub

	Public Sub RemoveFriend(ByVal userId As String, ByVal proxyClient As HttpProxyClient)
		Try
			Dim request As HttpRequest = Utils.CreateCleanRequest()
			request.Proxy = proxyClient

			request.AddHeader("Accept", "*/*")
			request.AddHeader("Accept-Encoding", "gzip, deflate, br")
			request.AddHeader("Accept-Language", GetLanguage())
			request.AddHeader("Alt-Used", "discord.com")
			request.AddHeader("Authorization", token)
			request.AddHeader("Connection", "keep-alive")
			request.AddHeader("Cookie", GetCookie())
			request.AddHeader("DNT", "1")
			request.AddHeader("Host", "discord.com")
			request.AddHeader("Origin", "https://discord.com")
			request.AddHeader("Referer", "https://discord.com/channels/@me")
			request.AddHeader("TE", "Trailers")
			request.AddHeader("User-Agent", Me.userAgent)
			request.AddHeader("X-Context-Properties", "eyJsb2NhdGlvbiI6IkZyaWVuZHMifQ==")
			request.AddHeader("X-Super-Properties", GetSuperProperties())

			request.Delete("https://discord.com/api/v9/users/@me/relationships/" & userId)
		Catch

		End Try
	End Sub

	Public Function FetchEmote(ByVal channelId As String, ByVal messageId As String, ByVal proxyClient As HttpProxyClient) As String
		Try
			Dim request As HttpRequest = Utils.CreateCleanRequest()
			request.Proxy = proxyClient

			request.AddHeader("Accept", "*/*")
			request.AddHeader("Accept-Encoding", "gzip, deflate, br")
			request.AddHeader("Accept-Language", GetLanguage())
			request.AddHeader("Alt-Used", "discord.com")
			request.AddHeader("Authorization", token)
			request.AddHeader("Connection", "keep-alive")
			request.AddHeader("Cookie", GetCookie())
			request.AddHeader("Host", "discord.com")
			request.AddHeader("Origin", "https://discord.com")
			request.AddHeader("Referer", "https://discord.com/channels/@me/" & channelId)
			request.AddHeader("TE", "Trailers")
			request.AddHeader("User-Agent", Me.userAgent)
			request.AddHeader("X-Super-Properties", GetSuperProperties())

			'INSTANT VB NOTE: In the following line, Instant VB substituted 'Object' for 'dynamic' - this will work in VB with Option Strict Off:
			Dim dynJson As Object = JsonConvert.DeserializeObject(Utils.DecompressResponse(request.Get("https://discord.com/api/v9/channels/" & channelId & "/messages?limit=50")))

			For Each item In dynJson
				Try
					If CStr(item.id) = messageId Then
						Try
							For Each item1 In item.reactions
								Try
									Dim reaction As String = "", id As String = ""
									id = item1.emoji.id
									reaction = item1.emoji.name

									If id IsNot Nothing AndAlso id <> "" Then
										reaction &= ":" & id
									End If

									Return reaction
								Catch

								End Try
							Next item1
						Catch

						End Try
					End If
				Catch

				End Try
			Next item

			Return ""
		Catch
			Return ""
		End Try
	End Function

	Public Sub RemoveReaction(ByVal reaction As String, ByVal channelId As String, ByVal messageId As String, ByVal proxyClient As HttpProxyClient)
		Try
			Dim request As HttpRequest = Utils.CreateCleanRequest()
			request.Proxy = proxyClient

			request.AddHeader("Accept", "*/*")
			request.AddHeader("Accept-Encoding", "gzip, deflate, br")
			request.AddHeader("Accept-Language", GetLanguage())
			request.AddHeader("Alt-Used", "discord.com")
			request.AddHeader("Authorization", token)
			request.AddHeader("Connection", "keep-alive")
			request.AddHeader("Cookie", GetCookie())
			request.AddHeader("DNT", "1")
			request.AddHeader("Host", "discord.com")
			request.AddHeader("Origin", "https://discord.com")
			request.AddHeader("Referer", "https://discord.com/channels/" & channelId & "/" & messageId)
			request.AddHeader("TE", "Trailers")
			request.AddHeader("User-Agent", Me.userAgent)
			request.AddHeader("X-Super-Properties", GetSuperProperties())

			request.Delete("https://discord.com/api/v9/channels/" & channelId & "/messages/" & messageId & "/reactions/" & reaction & "/@me")
		Catch

		End Try
	End Sub

	Public Sub JoinVoice(ByVal guildId As String, ByVal channelId As String, ByVal userIdGoLive As String, ByVal microphoneMuted As Boolean, ByVal headphonesMuted As Boolean, ByVal videoEnabled As Boolean, ByVal goLive As Boolean, ByVal joinGoLive As Boolean, ByVal speakInStage As Boolean)
		Try
			If Not connectedToVoice Then
				connectedToVoice = True
				Me.data = New AutoReconnectData(guildId, channelId, userIdGoLive, microphoneMuted, headphonesMuted, videoEnabled, goLive, joinGoLive, speakInStage)

				SendToWS("{""op"":4,""d"":{""guild_id"":""" & guildId & """,""channel_id"":""" & channelId & """,""self_mute"":" & microphoneMuted.ToString().ToLower() & ",""self_deaf"":" & headphonesMuted.ToString().ToLower() & ",""self_video"":" & videoEnabled.ToString().ToLower() & ",""preferred_region"":null}}")

				If speakInStage Then
					SendSpeakRequestToStageChannel(guildId, channelId)
				Else
					If goLive Then
						Me.GoLive(guildId, channelId)
					End If

					If joinGoLive AndAlso Utils.IsIDValid(userIdGoLive) Then
						Me.JoinGoLive(guildId, channelId, userIdGoLive)
					End If
				End If
			End If
		Catch
			connectedToVoice = False
		End Try
	End Sub

	Public Sub LeaveVoice()
		Try
			If connectedToVoice Then
				connectedToVoice = False
				SendToWS("{""op"":4,""d"":{""guild_id"":null,""channel_id"":null,""self_mute"":false,""self_deaf"":false,""self_video"":false}}")
			End If
		Catch
			connectedToVoice = True
		End Try
	End Sub

	Public Sub SendSpeakRequestToStageChannel(ByVal guildId As String, ByVal channelId As String)
		Try
			Dim timestamp As String = ""

			Dim year As String = "", month As String = "", day As String = "", hour As String = "", minute As String = "", second As String = ""

			year = Date.Now.Year.ToString()
			month = Date.Now.Month.ToString()

			If month.Length = 1 Then
				month = "0" & month
			End If

			day = Date.Now.Day.ToString()

			If day.Length = 1 Then
				day = "0" & day
			End If

			hour = Date.Now.Hour.ToString()

			If hour.Length = 1 Then
				hour = "0" & hour
			End If

			minute = Date.Now.Minute.ToString()

			If minute.Length = 1 Then
				minute = "0" & minute
			End If

			second = Date.Now.Minute.ToString()

			If second.Length = 1 Then
				second = "0" & second
			End If

			timestamp = year & "-" & month & "-" & day & "T" & hour & ":" & minute & ":" & second & "." & Date.Now.Millisecond.ToString() & "Z"

			Dim messageJson As String = "{""request_to_speak_timestamp"":""" & timestamp & """,""channel_id"":""" & channelId & """}"

			Dim request As HttpRequest = Utils.CreateCleanRequest()

			request.AddHeader("Accept", "*/*")
			request.AddHeader("Accept-Encoding", "gzip, deflate, br")
			request.AddHeader("Accept-Language", GetLanguage())
			request.AddHeader("Alt-Used", "discord.com")
			request.AddHeader("Authorization", token)
			request.AddHeader("Connection", "keep-alive")
			request.AddHeader("Content-Length", messageJson.Length.ToString())
			request.AddHeader("Content-Type", "application/json")
			request.AddHeader("Cookie", GetCookie())
			request.AddHeader("DNT", "1")
			request.AddHeader("Host", "discord.com")
			request.AddHeader("Origin", "https://discord.com")
			request.AddHeader("Referer", "https://discord.com/channels/" & guildId & "/" & channelId)
			request.AddHeader("TE", "Trailers")
			request.AddHeader("User-Agent", Me.userAgent)
			request.AddHeader("X-Super-Properties", GetSuperProperties())

			request.Patch("https://discord.com/api/v9/guilds/" & guildId & "/voice-states/@me", messageJson, "application/json")
		Catch

		End Try
	End Sub

	Public Sub GoLive(ByVal guildId As String, ByVal channelId As String)
		Try
			SendToWS("{""op"":18,""d"":{""type"":""guild"",""guild_id"":""" & guildId & """,""channel_id"":""" & channelId & """,""preferred_region"":null}}")
			SendToWS("{""op"":22,""d"":{""stream_key"":""guild:" & guildId & ":" & channelId & ":" & GetUserId() & """,""paused"":false}}")
		Catch

		End Try
	End Sub

	Public Sub StopGoLive(ByVal guildId As String, ByVal channelId As String)
		Try
			SendToWS("{""op"":19,""d"":{""stream_key"":""guild:" & guildId & ":" & channelId & ":" & GetUserId() & """}}")
		Catch

		End Try
	End Sub

	Public Sub JoinGoLive(ByVal guildId As String, ByVal channelId As String, ByVal theUser As String)
		Try
			SendToWS("{""op"":20,""d"":{""stream_key"":""guild:" & guildId & ":" & channelId & ":" & theUser & """}}")
		Catch

		End Try
	End Sub

	Public Sub LeaveGoLive(ByVal guildId As String, ByVal channelId As String, ByVal userId As String)
		Try
			SendToWS("{""op"":19,""d"":{""stream_key"":""guild:" & guildId & ":" & channelId & ":" & userId & """}}")
		Catch

		End Try
	End Sub

	Public Sub PhoneLock()
		Try
			Dim request As HttpRequest = Utils.CreateCleanRequest()

			request.AddHeader("Authorization", token)

			Try
				request.Post("https://discord.com/api/v9/invites/NXk4rE5jFA")
			Catch

			End Try
		Catch

		End Try
	End Sub

	Public Sub DeleteMessage(ByVal channelId As String, ByVal messageId As String, ByVal proxyClient As HttpProxyClient)
		Try
			Dim request As HttpRequest = Utils.CreateCleanRequest()
			request.Proxy = proxyClient

			request.AddHeader("Accept", "*/*")
			request.AddHeader("Accept-Encoding", "gzip, deflate, br")
			request.AddHeader("Accept-Language", GetLanguage())
			request.AddHeader("Alt-Used", "discord.com")
			request.AddHeader("Authorization", token)
			request.AddHeader("Connection", "keep-alive")
			request.AddHeader("Cookie", GetCookie())
			request.AddHeader("DNT", "1")
			request.AddHeader("Host", "discord.com")
			request.AddHeader("Origin", "https://discord.com")
			request.AddHeader("Referer", "https://discord.com/channels/@me/" & channelId)
			request.AddHeader("TE", "Trailers")
			request.AddHeader("User-Agent", Me.userAgent)
			request.AddHeader("X-Super-Properties", GetSuperProperties())

			request.Delete("https://discord.com/api/v9/channels/" & channelId & "/messages/" & messageId)
		Catch

		End Try
	End Sub

	Public Sub SetAvatar(ByVal image As System.Drawing.Image, ByVal proxyClient As HttpProxyClient)
		Try
			Dim ms = New System.IO.MemoryStream()
			image.Save(ms, image.RawFormat)
			SetAvatar(Convert.ToBase64String(ms.ToArray()), proxyClient)
		Catch

		End Try
	End Sub

	Public Sub SetAvatar(ByVal base64 As String, ByVal proxyClient As HttpProxyClient)
		Try
			Dim content As String = "{""avatar"":""data:image/png;base64," & base64 & """}"

			Dim request As HttpRequest = Utils.CreateCleanRequest()
			request.Proxy = proxyClient

			request.AddHeader("Accept", "*/*")
			request.AddHeader("Accept-Encoding", "gzip, deflate, br")
			request.AddHeader("Accept-Language", GetLanguage())
			request.AddHeader("Alt-Used", "discord.com")
			request.AddHeader("Authorization", token)
			request.AddHeader("Connection", "keep-alive")
			request.AddHeader("Content-Length", content.Length.ToString())
			request.AddHeader("Content-Type", "application/json")
			request.AddHeader("Cookie", GetCookie())
			request.AddHeader("Host", "discord.com")
			request.AddHeader("Origin", "https://discord.com")
			request.AddHeader("Referer", "https://discord.com/channels/@me")
			request.AddHeader("TE", "Trailers")
			request.AddHeader("User-Agent", Me.userAgent)
			request.AddHeader("X-Super-Properties", GetSuperProperties())

			request.Patch("https://discord.com/api/v9/users/@me", content, "application/json")
		Catch

		End Try
	End Sub

	Public Sub ResetAvatar(ByVal proxyClient As HttpProxyClient)
		Try
			Dim content As String = "{""avatar"":null}"

			Dim request As HttpRequest = Utils.CreateCleanRequest()
			request.Proxy = proxyClient

			request.AddHeader("Accept", "*/*")
			request.AddHeader("Accept-Encoding", "gzip, deflate, br")
			request.AddHeader("Accept-Language", GetLanguage())
			request.AddHeader("Alt-Used", "discord.com")
			request.AddHeader("Authorization", token)
			request.AddHeader("Connection", "keep-alive")
			request.AddHeader("Content-Length", content.Length.ToString())
			request.AddHeader("Content-Type", "application/json")
			request.AddHeader("Cookie", GetCookie())
			request.AddHeader("Host", "discord.com")
			request.AddHeader("Origin", "https://discord.com")
			request.AddHeader("Referer", "https://discord.com/channels/@me")
			request.AddHeader("TE", "Trailers")
			request.AddHeader("User-Agent", Me.userAgent)
			request.AddHeader("X-Super-Properties", GetSuperProperties())

			request.Patch("https://discord.com/api/v9/users/@me", content, "application/json")
		Catch

		End Try
	End Sub
End Class