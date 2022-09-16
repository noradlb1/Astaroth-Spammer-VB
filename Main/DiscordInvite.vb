Public Class DiscordInvite
	Public inviteCode As String
	Public valid, isGroup As Boolean
	Public guildId, channelId, membersCount As ULong
	Public channelType As Integer

	Public Sub New(ByVal inviteCode As String, ByVal valid As Boolean, ByVal isGroup As Boolean, ByVal guildId As ULong, ByVal channelId As ULong, ByVal membersCount As ULong, ByVal channelType As Integer)
		Me.inviteCode = inviteCode
		Me.valid = valid
		Me.isGroup = isGroup
		Me.guildId = guildId
		Me.channelId = channelId
		Me.membersCount = membersCount
		Me.channelType = channelType
	End Sub
End Class