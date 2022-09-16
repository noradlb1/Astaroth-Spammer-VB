Imports System.Collections.Generic
Imports Leaf.xNet
Imports Microsoft.VisualBasic
Imports System
Imports System.Net.Sockets
Imports System.Net
Imports System.Net.Http
Imports System.IO
Imports System.IO.Compression
Imports System.Text
Imports System.Security.Cryptography
Imports Newtonsoft.Json.Linq
Imports System.Collections.Specialized

Public NotInheritable Class Utils

	Private Sub New()
	End Sub

	Public Shared users As New List(Of String)(), roles As New List(Of String)()
	Public Shared globalAutoReconnect As Boolean = False
	Public Shared lastChannelId As String = ""

	Public Shared Function IsFriendValid(ByVal [friend] As String) As Boolean
		Try
			Return Utils.IsIDValid([friend]) OrElse Utils.IsTagValid([friend])
		Catch
			Return False
		End Try
	End Function

	Public Shared Function GetLagMessage() As String
		Return ":chains: :flag_ac: :chains: :flag_ac: :chains: :flag_ad: :laughing: :brain: :chains: :chains: :flag_ac: :chains: :flag_ac: :chains: :flag_ad: :laughing: :brain: :chains: :chains: :flag_ac: :chains: :flag_ac: :chains: :flag_ad: :laughing: :brain: :chains: :chains: :flag_ac: :chains: :flag_ac: :chains: :flag_ad: :laughing: :brain: :chains: :chains: :flag_ac: :chains: :flag_ac: :chains: :flag_ad: :laughing: :brain: :chains: :chains: :flag_ac: :chains: :flag_ac: :chains: :flag_ad: :laughing: :brain: :chains: :chains: :flag_ac: :chains: :flag_ac: :chains: :flag_ad: :laughing: :brain: :chains: :chains: :flag_ac: :chains: :flag_ac: :chains: :flag_ad: :laughing: :brain: :chains: :chains: :flag_ac: :chains: :flag_ac: :chains: :flag_ad: :laughing: :brain: :chains: :chains: :flag_ac: :chains: :flag_ac: :chains: :flag_ad: :laughing: :brain: :chains: :chains: :flag_ac: :chains: :flag_ac: :chains: :flag_ad: :laughing: :brain: :chains: :chains: :flag_ac: :chains: :flag_ac: :chains: :flag_ad: :laughing: :brain: :chains: :chains: :flag_ac: :chains: :flag_ac: :chains: :flag_ad: :laughing: :brain: :chains: :chains: :flag_ac: :chains: :flag_ac: :chains: :flag_ad: :laughing: :brain: :chains: :chains: :flag_ac: :chains: :flag_ac: :chains: :flag_ad: :laughing: :brain: :chains: :chains: :flag_ac: :chains: :flag_ac: :chains: :flag_ad: :laughing: :brain: :chains: :chains: :flag_ac: :chains: :flag_ac: :chains: :flag_ad: :laughing: :brain: :chains: :chains: :flag_ac: :chains: :flag_ac: :chains: :flag_ad: :laughing: :brain: :chains: :chains: :flag_ac: :chains: :flag_ac: :chains: :flag_ad: :laughing: :brain: :chains: :chains: :flag_ac: :chains: :flag_ac: :chains: :flag_ad: :laughing: :brain: :chains: :chains: :flag_ac: :chains: :flag_ac: :chains: :flag_ad: :laughing: :brain: :chains: :chains: :flag_ac: :chains: :flag_ac: :chains: :flag_ad: :laughing: :brain: :chains: :chains:"
	End Function

	Public Shared Function ReplaceFirst(ByVal text As String, ByVal search As String, ByVal replace As String) As String
		Try
			Dim pos As Integer = text.IndexOf(search)

			If pos < 0 Then
				Return text
			End If

			Return text.Substring(0, pos) & replace & text.Substring(pos + search.Length)
		Catch

		End Try

		Return text
	End Function

	Public Shared Function AreIDsValid(ByVal ids As String) As Boolean
		Try
			ids = ids.Replace(" ", "").Replace(ControlChars.Tab.ToString(), "").Trim()

			If Not ids.Contains(",") Then
				If Not IsIDValid(ids) Then
					Return False
				End If
			Else
				Try
					Dim splitted() As String = Microsoft.VisualBasic.Strings.Split(ids, ",")

					Try
						For Each id As String In splitted
							Try
								If Not IsIDValid(id) Then
									Return False
								End If
							Catch

							End Try
						Next id
					Catch

					End Try

					splitted = Nothing
				Catch

				End Try
			End If

			ids = Nothing

			Return True
		Catch
			Return False
		End Try
	End Function

	Public Shared Function GetIDs(ByVal ids As String) As List(Of String)
		Dim idList As New List(Of String)()

		Try
			ids = ids.Replace(" ", "").Replace(ControlChars.Tab.ToString(), "").Trim()

			If ids.Contains(",") Then
				Dim splitted() As String = Microsoft.VisualBasic.Strings.Split(ids, ",")

				For Each id As String In splitted
					idList.Add(id)
				Next id

				splitted = Nothing
			Else
				idList.Add(ids)
			End If

			ids = Nothing
		Catch

		End Try

		Return idList
	End Function

	Public Shared Function GetXCP(ByVal invite As DiscordInvite) As String
		Try
			Return GetXCP(invite.guildId.ToString(), invite.channelId.ToString(), invite.channelType.ToString())
		Catch
			Return ""
		End Try
	End Function

	Public Shared Function GetXCP(ByVal guildId As String, ByVal channelId As String, ByVal channelType As String) As String
		Try
			Return Base64Encode("{""location"":""Join Guild"",""location_guild_id"":""" & guildId & """,""location_channel_id"":""" & channelId & """,""location_channel_type"":" & channelType & "}")
		Catch
			Return "eyJsb2NhdGlvbiI6IkpvaW4gR3VpbGQiLCJsb2NhdGlvbl9ndWlsZF9pZCI6IjgyMjU4NDA5NTg5MTY1MjYyOSIsImxvY2F0aW9uX2NoYW5uZWxfaWQiOiI4MjI1ODQwOTYzNzA3MjA3NjgiLCJsb2NhdGlvbl9jaGFubmVsX3R5cGUiOjB9"
		End Try
	End Function

	Public Shared Function Base64Encode(ByVal plainText As String) As String
		Try
			Return System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(plainText))
		Catch
			Return ""
		End Try
	End Function

	Public Shared Function GetCurrentRealDateTime() As Date
		Try
			Return (New Date(1970, 1, 1, 0, 0, 0, 0)).AddSeconds((Date.UtcNow - New Date(1970, 1, 1, 0, 0, 0)).TotalSeconds + 7200L)
		Catch
			Return Date.Now
		End Try
	End Function

	Public Shared Function GetInviteInformations(ByVal invite As String, ByVal groupMode As Boolean) As DiscordInvite
		Try
			Dim inviteCode As String = GetInviteCodeByInviteLink(invite), response As String = ""
			Dim request As HttpRequest = CreateCleanRequest()
			request.AddHeader("Accept-Encoding", "gzip, deflate, br")

			If groupMode Then
				response = DecompressResponse(request.Get("https://discord.com/api/v9/invites/" & inviteCode & "?with_counts=true&with_expiration=true"))
			Else
				response = DecompressResponse(request.Get("https://discord.com/api/v9/invites/" & inviteCode & "?inputValue=https://discord.gg/" & inviteCode & "&with_counts=true&with_expiration=true"))
			End If

'INSTANT VB NOTE: In the following line, Instant VB substituted 'Object' for 'dynamic' - this will work in VB with Option Strict Off:
			Dim jss As Object = JObject.Parse(response)
			Dim guildId As String = "0", channelId As String = "0", channelType As String = "0", statusCode As String = CStr(jss.code), membersCount As String = ""
			Dim status As Boolean = True, isGroup As Boolean = groupMode

			If statusCode = "10006" OrElse statusCode = "0" OrElse statusCode <> inviteCode Then
				status = False
			End If

			If status Then
				If Not groupMode Then
					guildId = CStr(jss.guild.id)
				End If

				channelId = CStr(jss.channel.id)
				channelType = CStr(jss.channel.type)
				membersCount = CStr(jss.approximate_member_count)
			End If

			Return New DiscordInvite(inviteCode, status, isGroup, ULong.Parse(guildId), ULong.Parse(channelId), ULong.Parse(membersCount), Integer.Parse(channelType))
		Catch
			Return New DiscordInvite(GetInviteCodeByInviteLink(invite), False, False, 0, 0, 0, 0)
		End Try
	End Function

	Public Shared Function GetTest() As String
		Try
			Dim dayOfWeek As String = "", month As String = "", day As String = "", year As String = "", hour As String = "", minute As String = "", second As String = ""

			Dim nowTime As Date = GetCurrentRealDateTime()
			day = nowTime.Day.ToString()

			If day.Length = 1 Then
				day = "0" & day
			End If

			year = nowTime.Year.ToString()
			hour = nowTime.Hour.ToString()
			minute = nowTime.Minute.ToString()
			second = nowTime.Second.ToString()

			If hour.Length = 1 Then
				hour = "0" & hour
			End If

			If minute.Length = 1 Then
				minute = "0" & minute
			End If

			If second.Length = 1 Then
				second = "0" & second
			End If

			If nowTime.Month = 1 Then
				month = "Jan"
			ElseIf nowTime.Month = 2 Then
				month = "Feb"
			ElseIf nowTime.Month = 3 Then
				month = "Mar"
			ElseIf nowTime.Month = 4 Then
				month = "Apr"
			ElseIf nowTime.Month = 5 Then
				month = "May"
			ElseIf nowTime.Month = 6 Then
				month = "Jun"
			ElseIf nowTime.Month = 7 Then
				month = "Jul"
			ElseIf nowTime.Month = 8 Then
				month = "Aug"
			ElseIf nowTime.Month = 9 Then
				month = "Sep"
			ElseIf nowTime.Month = 10 Then
				month = "Oct"
			ElseIf nowTime.Month = 11 Then
				month = "Nov"
			ElseIf nowTime.Month = 12 Then
				month = "Dec"
			End If

			If nowTime.DayOfWeek = System.DayOfWeek.Monday Then
				dayOfWeek = "Mon"
			ElseIf nowTime.DayOfWeek = System.DayOfWeek.Tuesday Then
				dayOfWeek = "Tue"
			ElseIf nowTime.DayOfWeek = System.DayOfWeek.Wednesday Then
				dayOfWeek = "Wed"
			ElseIf nowTime.DayOfWeek = System.DayOfWeek.Thursday Then
				dayOfWeek = "Thu"
			ElseIf nowTime.DayOfWeek = System.DayOfWeek.Friday Then
				dayOfWeek = "Fri"
			ElseIf nowTime.DayOfWeek = System.DayOfWeek.Saturday Then
				dayOfWeek = "Sat"
			ElseIf nowTime.DayOfWeek = System.DayOfWeek.Sunday Then
				dayOfWeek = "Sun"
			End If

			Return "isIABGlobal=false&datestamp=" & dayOfWeek & "+" & month & "+" & day & "+" & year & "+" & hour & ":" & minute & ":" & second & "+GMT+0200+(Ora+legale+dellâEuropa+centrale)&version=6.17.0&hosts=&landingPath=NotLandingPage&groups=C0001:1,C0002:1,C0003:1&geolocation=IT;62&AwaitingReconsent=false"
		Catch
			Return ""
		End Try
	End Function

	Public Shared Function GetRandomCookie(ByVal language As String) As String
		Try
			Return "__cfduid=" & GetUniqueKey1(43) & "; __dcfduid=" & GetUniqueKey1(32) & "; rebrand_bucket=" & GetUniqueKey1(32) & "; OptanonAlertBoxClosed=2021-05-30T14:59:00.092Z; locale=" & language
		Catch
			Return ""
		End Try
	End Function

	Public Shared Function GetInviteCodeByInviteLink(ByVal inviteLink As String) As String
		Try
			If inviteLink.EndsWith("/") Then
				inviteLink = inviteLink.Substring(0, inviteLink.Length - 1)
			End If

			If inviteLink.Contains("discord") AndAlso inviteLink.Contains("/") AndAlso inviteLink.Contains("http") Then
				Dim splitter() As String = Microsoft.VisualBasic.Strings.Split(inviteLink, "/")

				Return splitter(splitter.Length - 1)
			End If
		Catch

		End Try

		Return inviteLink
	End Function

	Public Shared Iterator Function SplitToLines(ByVal input As String) As IEnumerable(Of String)
		If input Is Nothing Then
			Return
		End If

		Using reader As New System.IO.StringReader(input)
			Dim line As String

'INSTANT VB WARNING: An assignment within expression was extracted from the following statement:
'ORIGINAL LINE: while ((line = reader.ReadLine()) != null)
			line = reader.ReadLine()
			Do While line IsNot Nothing
				Yield line
				line = reader.ReadLine()
			Loop
		End Using
	End Function

	Public Shared Function IsTokenValid(ByVal token As String) As Boolean
		Try
			Dim request As HttpRequest = CreateCleanRequest()

			request.AddHeader("Accept-Encoding", "gzip, deflate, br")
			request.AddHeader("Authorization", token)

			Try
				request.Get("https://discord.com/api/v9/users/@me/library")

				If request.Response.IsOK Then
					Return True
				End If
			Catch

			End Try
		Catch

		End Try

		Return False
	End Function

	Public Shared Function IsProxyValid(ByVal proxy As String) As Boolean
		Try
			Dim chars() As Char = proxy.ToCharArray()
			Dim colons As Integer = 0

			For Each c As Char In chars
				If c = ":"c Then
					colons += 1
				End If
			Next c

			Dim splitted() As String = Strings.Split(proxy, ":")
			Return PingHost(splitted(0), Integer.Parse(splitted(1)))
		Catch
			Return False
		End Try
	End Function

	Public Shared Function PingHost(ByVal strIP As String, ByVal intPort As Integer) As Boolean
		Try
			Dim blProxy As Boolean = False

			Try
				Dim client As New TcpClient(strIP, intPort)
				blProxy = True
			Catch ex As Exception
				Return False
			End Try

			Return blProxy
		Catch
			Return False
		End Try
	End Function

	Public Shared Function GetGroupXCP(ByVal invite As DiscordInvite) As String
		Try
			Return Base64Encode("{""location"":""Invite Button Embed"",""location_guild_id"":null,""location_channel_id"":""" & invite.channelId & """,""location_channel_type"":" & invite.channelType & ",""location_message_id"":null}")
		Catch
			Return "eyJsb2NhdGlvbiI6Ikludml0ZSBCdXR0b24gRW1iZWQiLCJsb2NhdGlvbl9ndWlsZF9pZCI6bnVsbCwibG9jYXRpb25fY2hhbm5lbF9pZCI6IjgzNzM5NzUzMDAzODg5NDY0MiIsImxvY2F0aW9uX2NoYW5uZWxfdHlwZSI6MSwibG9jYXRpb25fbWVzc2FnZV9pZCI6IjgzNzU5MjQyMDAxNDA5NjM4NCJ9"
		End Try
	End Function

	Public Shared Function GetCleanToken(ByVal token As String) As String
		Try
			Return token.Replace(" ", "").Trim().Replace(ControlChars.Tab.ToString(), "")
		Catch
			Return token
		End Try
	End Function

	Public Shared Function IsTokenFormatValid(ByVal token As String) As Boolean
		Try
			Dim tok As String = GetCleanToken(token)

			If tok Is Nothing OrElse tok = "" Then
				Return False
			End If

			If tok.Length <> 88 AndAlso tok.Length <> 59 Then
				Return False
			End If

			If tok.Length = 88 Then
				If Not tok.StartsWith("mfa.") Then
					Return False
				End If
			Else
				Dim chars() As Char = tok.ToCharArray()
				Dim dots As Integer = 0

				For Each c As Char In chars
					If c = "."c Then
						dots += 1
					End If
				Next c

				If dots <> 2 Then
					Return False
				End If

				Dim splitted() As String = Strings.Split(tok, ".")

				If splitted(0).Length <> 24 Then
					Return False
				End If

				If splitted(1).Length <> 6 Then
					Return False
				End If

				If splitted(2).Length <> 27 Then
					Return False
				End If

				Dim decodedFirstPart As String = Base64Decode(splitted(0))

				If Not IsIDValid(decodedFirstPart) Then
					Return False
				End If

				Dim inBinary As String = DecimalToBinary(decodedFirstPart)

				If inBinary.Length <> 60 Then
					Return False
				End If
			End If

			Return True
		Catch
			Return False
		End Try
	End Function

	Public Shared Function IsProxyFormatValid(ByVal proxy As String) As Boolean
		Try
			Dim theProxy As String = GetCleanToken(proxy)

			If theProxy = "" OrElse theProxy Is Nothing Then
				Return False
			End If

			Dim chars() As Char = theProxy.ToCharArray()
			Dim colons As Integer = 0

			For Each c As Char In chars
				If c = ":"c Then
					colons += 1
				End If
			Next c

			If colons <> 1 AndAlso colons <> 3 Then
				Return False
			End If

			Dim splitted() As String = Strings.Split(theProxy, ":")

			Dim ip As String = splitted(0), port As String = splitted(1)

			If ip.Length > 15 Then
				Return False
			End If

			If port.Length > 5 Then
				Return False
			End If

			If Not Microsoft.VisualBasic.Information.IsNumeric(port) Then
				Return False
			End If

			Dim thePort As Integer = Integer.Parse(port)

			If Not(thePort >= 0 AndAlso thePort <= 65535) Then
				Return False
			End If

			Dim theChars() As Char = ip.ToCharArray()
			Dim dots As Integer = 0

			For Each c As Char In theChars
				If c = "."c Then
					dots += 1
				End If
			Next c

			If dots <> 3 Then
				Return False
			End If

			Dim octets() As String = Strings.Split(ip, ".")

			For Each octect As String In octets
				If octect.Length <> 1 AndAlso octect.Length <> 2 AndAlso octect.Length <> 3 Then
					Return False
				End If

				If Not Microsoft.VisualBasic.Information.IsNumeric(octect) Then
					Return False
				End If

				Dim theOctect As Integer = Integer.Parse(octect)

				If Not(theOctect >= 0 AndAlso theOctect <= 255) Then
					Return False
				End If
			Next octect

			If colons = 3 Then
				If GetCleanToken(splitted(2)) = "" OrElse GetCleanToken(splitted(3)) = "" Then
					Return False
				End If
			End If

			Return True
		Catch
			Return False
		End Try
	End Function

	Public Shared Function IsIDValid(ByVal id As String) As Boolean
		Try
			If id.Length <> 18 Then
				Return False
			End If

			If Not Microsoft.VisualBasic.Information.IsNumeric(id) Then
				Return False
			End If

			Return True
		Catch
			Return False
		End Try
	End Function

	Public Shared Function DecimalToBinary(ByVal data As String) As String
		Try
			Return Convert.ToString(Long.Parse(data), 2)
		Catch
			Return ""
		End Try
	End Function

	Public Shared Function Base64Decode(ByVal base64EncodedData As String) As String
		Try
			Return System.Text.Encoding.UTF8.GetString(System.Convert.FromBase64String(base64EncodedData))
		Catch
			Return ""
		End Try
	End Function

	Public Shared Function CreateCleanRequest() As HttpRequest
		Try
			Dim request As New HttpRequest()

			request.KeepTemporaryHeadersOnRedirect = False
			request.EnableMiddleHeaders = False
			request.ClearAllHeaders()
			request.AllowEmptyHeaderValues = False
			request.SslProtocols = System.Security.Authentication.SslProtocols.Tls12
			request.Proxy = Nothing
			request.Username = Nothing
			request.UserAgent = Nothing
			request.UseCookies = False
			request.CookieSingleHeader = True
			request.Authorization = Nothing
			request.BaseAddress = Nothing
			request.Referer = Nothing
			request.Reconnect = False
			request.ReconnectDelay = 0
			request.Password = Nothing
			request.KeepAlive = False
			request.IgnoreInvalidCookie = True
			request.IgnoreProtocolErrors = True
			request.KeepTemporaryHeadersOnRedirect = False
			request.MaximumKeepAliveRequests = 1
			request.Cookies = Nothing
			request.CharacterSet = Nothing
			request.AcceptEncoding = Nothing
			request.Culture = Nothing
			request.AllowAutoRedirect = False
			request.MaximumAutomaticRedirections = 1

			Return request
		Catch
			Return New HttpRequest()
		End Try
	End Function

	Public Shared Function ParseProxy(ByVal proxy As String) As HttpProxyClient
		Try
			Dim chars() As Char = proxy.ToCharArray()
			Dim colons As Integer = 0

			For Each c As Char In chars
				If c = ":"c Then
					colons += 1
				End If
			Next c

			Dim splitted() As String = Strings.Split(proxy, ":")

			If colons = 1 Then
				Return New HttpProxyClient(splitted(0), Integer.Parse(splitted(1)))
			Else
				Return New HttpProxyClient(splitted(0), Integer.Parse(splitted(1)), splitted(2), splitted(3))
			End If
		Catch
			Return Nothing
		End Try
	End Function

	Public Shared Function DecompressGZip(ByVal toDecompress() As Byte) As Byte()
		Try
			Dim stream As New MemoryStream(toDecompress)
			Dim newStream As New MemoryStream()

			Using decompressionStream As New GZipStream(stream, CompressionMode.Decompress)
				decompressionStream.CopyTo(newStream)
			End Using

			Return newStream.ToArray()
		Catch
			Return Encoding.UTF8.GetBytes("")
		End Try
	End Function

	Public Shared Function DecompressDeflate(ByVal toDecompress() As Byte) As Byte()
		Try
			Dim stream As New MemoryStream(toDecompress)
			Dim newStream As New MemoryStream()

			Using decompressionStream As New DeflateStream(stream, CompressionMode.Decompress)
				decompressionStream.CopyTo(newStream)
			End Using

			Return newStream.ToArray()
		Catch
			Return Encoding.UTF8.GetBytes("")
		End Try
	End Function

	Public Shared Function DecompressBr(ByVal toDecompress() As Byte) As Byte()
		Try
			Return BrotliSharpLib.Brotli.DecompressBuffer(toDecompress, 0, toDecompress.Length)
		Catch
			Return Encoding.UTF8.GetBytes("")
		End Try
	End Function

	Public Shared Function DecompressResponse(ByVal response As Leaf.xNet.HttpResponse) As String
		Try
			If response("content-encoding").Equals("br") Then
				Return System.Text.Encoding.UTF8.GetString(DecompressBr(response.ToBytes()))
			ElseIf response("content-encoding").Equals("deflate") Then
				Return System.Text.Encoding.UTF8.GetString(DecompressDeflate(response.ToBytes()))
			ElseIf response("content-encoding").Equals("gzip") Then
				Return System.Text.Encoding.UTF8.GetString(DecompressGZip(response.ToBytes()))
			Else
				Return response.ToString()
			End If
		Catch
			Return response.ToString()
		End Try
	End Function

	Friend Shared ReadOnly chars() As Char = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray()
	Friend Shared ReadOnly numbers() As Char = "123456789".ToCharArray()
	Friend Shared ReadOnly everything() As Char = "abcdefghijklmnopqrstuvwxyz0123456789".ToCharArray()

	Public Shared Function GetUniqueKey(ByVal size As Integer) As String
		Try
			Dim data((4 * size) - 1) As Byte

			Using crypto As New RNGCryptoServiceProvider()
				crypto.GetBytes(data)
			End Using

			Dim result As New StringBuilder(size)

			For i As Integer = 0 To size - 1
				Dim rnd = BitConverter.ToUInt32(data, i * 4)
				Dim idx = rnd Mod chars.Length

				result.Append(chars(idx))
			Next i

			Return result.ToString()
		Catch
			Return ""
		End Try
	End Function

	Public Shared Function GetUniqueKey1(ByVal size As Integer) As String
		Try
			Dim data((4 * size) - 1) As Byte

			Using crypto As New RNGCryptoServiceProvider()
				crypto.GetBytes(data)
			End Using

			Dim result As New StringBuilder(size)

			For i As Integer = 0 To size - 1
				Dim rnd = BitConverter.ToUInt32(data, i * 4)
				Dim idx = rnd Mod everything.Length

				result.Append(everything(idx))
			Next i

			Return result.ToString()
		Catch
			Return ""
		End Try
	End Function

	Public Shared Function GetUniqueInt(ByVal size As Integer) As Integer
		Try
			Dim data((4 * size) - 1) As Byte

			Using crypto As New RNGCryptoServiceProvider()
				crypto.GetBytes(data)
			End Using

			Dim result As New StringBuilder(size)

			For i As Integer = 0 To size - 1
				Dim rnd = BitConverter.ToUInt32(data, i * 4)
				Dim idx = rnd Mod numbers.Length

				result.Append(numbers(idx))
			Next i

			Return Integer.Parse(result.ToString())
		Catch
			Return 0
		End Try
	End Function

	Public Shared Function GetUniqueLong(ByVal size As Integer) As Long
		Try
			Dim data((4 * size) - 1) As Byte

			Using crypto As New RNGCryptoServiceProvider()
				crypto.GetBytes(data)
			End Using

			Dim result As New StringBuilder(size)

			For i As Integer = 0 To size - 1
				Dim rnd = BitConverter.ToUInt32(data, i * 4)
				Dim idx = rnd Mod numbers.Length

				result.Append(numbers(idx))
			Next i

			Return Long.Parse(result.ToString())
		Catch
			Return 0L
		End Try
	End Function

	Public Shared Function IsCaptchaKeyValid(ByVal captchaKey As String) As Boolean
		Try
			Return captchaKey.Length = 32
		Catch
			Return False
		End Try
	End Function

	Public Shared Sub SendMessageToWebhook(ByVal url As String, ByVal username As String, ByVal avatar_url As String, ByVal content As String)
		Try
			Dim request As HttpRequest = CreateCleanRequest()
			Dim data As String = "username=" & username & "&avatar_url=" & avatar_url & "&content=" & content
			request.AddHeader("Accept-Encoding", "gzip, deflate, br")
			request.AddHeader("Content-Length", data.Length.ToString())
			request.AddHeader("Content-Type", "application/x-www-form-urlencoded")
			request.Post(url, data, "application/x-www-form-urlencoded")
		Catch

		End Try
	End Sub

	Public Shared Function Post(ByVal uri As String, ByVal pairs As NameValueCollection) As Byte()
		Try
			Using webClient As New WebClient()
				Return webClient.UploadValues(uri, pairs)
			End Using
		Catch
			Return New Byte() { }
		End Try
	End Function

	Public Shared Function AreFriendsValid(ByVal ids As String) As Boolean
		ids = ids.Replace(" ", "").Replace(ControlChars.Tab.ToString(), "").Trim()

		Try
			If Not ids.Contains(",") Then
				If (Not IsIDValid(ids)) AndAlso (Not IsTagValid(ids)) Then
					Return False
				End If
			Else
				Dim splitted() As String = Microsoft.VisualBasic.Strings.Split(ids, ",")

				For Each id As String In splitted
					If (Not IsIDValid(id)) AndAlso (Not IsTagValid(id)) Then
						Return False
					End If
				Next id

				splitted = Nothing
			End If

			ids = Nothing

			Return True
		Catch
			Return False
		End Try
	End Function

	Public Shared Function GetFriends(ByVal ids As String) As List(Of String)
		Dim idList As New List(Of String)()

		Try
			ids = ids.Replace(" ", "").Replace(ControlChars.Tab.ToString(), "").Trim()

			If ids.Contains(",") Then
				Dim splitted() As String = Microsoft.VisualBasic.Strings.Split(ids, ",")

				For Each id As String In splitted
					idList.Add(id)
				Next id

				splitted = Nothing
			Else
				idList.Add(ids)
			End If

			ids = Nothing
		Catch

		End Try

		Return idList
	End Function

	Public Shared Function IsTagValid(ByVal tag As String) As Boolean
		Try
			If tag.Length > 37 Then
				Return False
			End If

			If Not tag.Contains("#") Then
				Return False
			End If

			Dim splitted() As String = Microsoft.VisualBasic.Strings.Split(tag, "#")

			If splitted(0).Replace(" ", "").Trim().Replace(ControlChars.Tab.ToString(), "") = "" OrElse splitted(1).Replace(" ", "").Trim().Replace(ControlChars.Tab.ToString(), "") = "" Then
				Return False
			End If

			If splitted(1).Replace(" ", "").Trim().Replace(ControlChars.Tab.ToString(), "").Length <> 4 Then
				Return False
			End If

			If Not Microsoft.VisualBasic.Information.IsNumeric(splitted(1).Replace(" ", "").Trim().Replace(ControlChars.Tab.ToString(), "")) Then
				Return False
			End If

			Return True
		Catch
			Return False
		End Try
	End Function

	Public Shared Function IsWebhookValid(ByVal webhook As String) As Boolean
		Try
			If Not webhook.StartsWith("https://discord.com/api/webhooks/") Then
				Return False
			End If

			If webhook.Length <> 120 Then
				Return False
			End If

			Dim toCheck As String = webhook.Replace("https://discord.com/api/webhooks/", "")
			Dim splitted() As String = Strings.Split(toCheck, "/")

			If Not IsIDValid(splitted(0)) Then
				Return False
			End If

			If splitted(1).Length <> 68 Then
				Return False
			End If

			Dim request As HttpRequest = Utils.CreateCleanRequest()
			request.AddHeader("Accept-Encoding", "gzip, deflate, br")
			Return Utils.DecompressResponse(request.Get(webhook)).Contains("id")
		Catch
			Return False
		End Try
	End Function

	Public Shared Function IsEmojiValid(ByVal emoji As String) As Boolean
		If emoji.Length > 3 OrElse emoji.Replace(" ", "").Trim().Replace(ControlChars.Tab.ToString(), "").Length > 3 Then
			Return False
		End If

		Return True
	End Function

	Public Shared Function IsEmoteValid(ByVal emote As String) As Boolean
		If (Not emote.Contains(":")) AndAlso (Not emote.Contains("%3A")) Then
			Return False
		Else
			Dim splitter() As String = Nothing

			If emote.Contains(":") Then
				splitter = Microsoft.VisualBasic.Strings.Split(emote, ":")
			ElseIf emote.Contains("%3A") Then
				splitter = Microsoft.VisualBasic.Strings.Split(emote, "%3A")
			Else
				Return False
			End If

			If Not IsIDValid(splitter(1)) Then
				Return False
			End If

			If splitter(0).Replace(" ", "").Replace(ControlChars.Tab.ToString(), "") = "" Then
				Return False
			End If
		End If

		Return True
	End Function

	Public Shared Function IsReactionValid(ByVal reaction As String) As Boolean
		Return IsEmoteValid(reaction) OrElse IsEmojiValid(reaction)
	End Function
End Class