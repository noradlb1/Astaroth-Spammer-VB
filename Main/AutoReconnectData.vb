Public Class AutoReconnectData
	Public guildId As String
	Public channelId As String
	Public userIdGoLive As String
	Public microphoneMuted As Boolean
	Public headphonesMuted As Boolean
	Public videoEnabled As Boolean
	Public goLive As Boolean
	Public joinGoLive As Boolean
	Public speakInStage As Boolean

	Public Sub New(ByVal guildId As String, ByVal channelId As String, ByVal userIdGoLive As String, ByVal microphoneMuted As Boolean, ByVal headphonesMuted As Boolean, ByVal videoEnabled As Boolean, ByVal goLive As Boolean, ByVal joinGoLive As Boolean, ByVal speakInStage As Boolean)
		Me.guildId = guildId
		Me.channelId = channelId
		Me.userIdGoLive = userIdGoLive
		Me.microphoneMuted = microphoneMuted
		Me.headphonesMuted = headphonesMuted
		Me.videoEnabled = videoEnabled
		Me.goLive = goLive
		Me.joinGoLive = joinGoLive
		Me.speakInStage = speakInStage
	End Sub
End Class