' Firefox Theme.
' Made by AeroRev9.
' 25/07/2015.
' Updated : 29/07/2015 [2].
' Credits : Mavaamarten, Xertz.
' Converted by LaPanthere

Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Text
Imports System.Windows.Forms

Friend NotInheritable Class Theme

	Private Sub New()
	End Sub


	Public Shared Function GlobalFont(ByVal B As FontStyle, ByVal S As Integer) As Font
		Return New Font("Segoe UI", S, B)
	End Function

	Public Shared Function GetCheckMark() As String
		Return "iVBORw0KGgoAAAANSUhEUgAAABMAAAAQCAYAAAD0xERiAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsMAAA7DAcdvqGQAAAEySURBVDhPY/hPRUBdw/79+/efVHz77bf/X37+wRAn2bDff/7+91l+83/YmtsYBpJs2ITjz/8rTbrwP2Dlrf9XXn5FkSPJsD13P/y3nHsVbNjyy28w5Ik27NWXX//TNt8DG1S19zFWNRiGvfzy8//ccy9RxEB4wvFnYIMMZl7+//brLwx5EEYx7MP33/9dF18Ha1py8RVcHBR7mlMvgsVXX8X0Hgwz/P379z8yLtz5AKxJdcpFcBj9+v3nf/CqW2Cx5E13UdSiYwzDvv36/d9/BUSzzvRL/0t2PQSzQd57+vEHilp0jGEYCJ9+8hnuGhiee+4Vhjp0jNUwEN566/1/m/mQZJC/48H/zz9+YVWHjHEaBsKgwAZ59eH771jl0TFew0D48osvWMWxYYKGEY///gcAqiuA6kEmfEMAAAAASUVORK5CYII="
	End Function

End Class

Friend NotInheritable Class Helpers

	Private Sub New()
	End Sub


	Public Enum MouseState As Byte
		None = 0
		Over = 1
		Down = 2
	End Enum

	Public Shared Function FullRectangle(ByVal S As Size, ByVal Subtract As Boolean) As Rectangle
		If Subtract Then
			Return New Rectangle(0, 0, S.Width - 1, S.Height - 1)
		Else
			Return New Rectangle(0, 0, S.Width, S.Height)
		End If
	End Function

	Public Shared Function GreyColor(ByVal G As Integer) As Color
		Return Color.FromArgb(G, G, G)
	End Function

	Public Shared Sub CenterString(ByVal G As Graphics, ByVal T As String, ByVal F As Font, ByVal C As Color, ByVal R As Rectangle)
		Dim TS As SizeF = G.MeasureString(T, F)

		Using B As New SolidBrush(C)
			G.DrawString(T, F, B, New Point(CInt(R.Width \ 2 - (TS.Width \ 2)), CInt(R.Height \ 2 - (TS.Height \ 2))))
		End Using
	End Sub


	Public Shared Sub FillRoundRect(ByVal G As Graphics, ByVal R As Rectangle, ByVal Curve As Integer, ByVal C As Color)
		Using B As New SolidBrush(C)
			G.FillPie(B, R.X, R.Y, Curve, Curve, 180, 90)
			G.FillPie(B, R.X + R.Width - Curve, R.Y, Curve, Curve, 270, 90)
			G.FillPie(B, R.X, R.Y + R.Height - Curve, Curve, Curve, 90, 90)
			G.FillPie(B, R.X + R.Width - Curve, R.Y + R.Height - Curve, Curve, Curve, 0, 90)
			G.FillRectangle(B, Convert.ToInt32(R.X + Curve \ 2), R.Y, R.Width - Curve, Convert.ToInt32(Curve \ 2))
			G.FillRectangle(B, R.X, Convert.ToInt32(R.Y + Curve \ 2), R.Width, R.Height - Curve)
			G.FillRectangle(B, Convert.ToInt32(R.X + Curve \ 2), Convert.ToInt32(R.Y + R.Height - Curve \ 2), R.Width - Curve, Convert.ToInt32(Curve \ 2))
		End Using

	End Sub


	Public Shared Sub DrawRoundRect(ByVal G As Graphics, ByVal R As Rectangle, ByVal Curve As Integer, ByVal C As Color)
		Using P As New Pen(C)
			G.DrawArc(P, R.X, R.Y, Curve, Curve, 180, 90)
			G.DrawLine(P, Convert.ToInt32(R.X + Curve \ 2), R.Y, Convert.ToInt32(R.X + R.Width - Curve \ 2), R.Y)
			G.DrawArc(P, R.X + R.Width - Curve, R.Y, Curve, Curve, 270, 90)
			G.DrawLine(P, R.X, Convert.ToInt32(R.Y + Curve \ 2), R.X, Convert.ToInt32(R.Y + R.Height - Curve \ 2))
			G.DrawLine(P, Convert.ToInt32(R.X + R.Width), Convert.ToInt32(R.Y + Curve \ 2), Convert.ToInt32(R.X + R.Width), Convert.ToInt32(R.Y + R.Height - Curve \ 2))
			G.DrawLine(P, Convert.ToInt32(R.X + Curve \ 2), Convert.ToInt32(R.Y + R.Height), Convert.ToInt32(R.X + R.Width - Curve \ 2), Convert.ToInt32(R.Y + R.Height))
			G.DrawArc(P, R.X, R.Y + R.Height - Curve, Curve, Curve, 90, 90)
			G.DrawArc(P, R.X + R.Width - Curve, R.Y + R.Height - Curve, Curve, Curve, 0, 90)
		End Using

	End Sub


	Public Shared Sub CenterStringTab(ByVal G As Graphics, ByVal text As String, ByVal font As Font, ByVal brush As Brush, ByVal rect As Rectangle, Optional ByVal shadow As Boolean = False, Optional ByVal yOffset As Integer = 0)
		Dim textSize As SizeF = G.MeasureString(text, font)
		Dim textX As Integer = CInt(rect.X + (rect.Width \ 2) - (textSize.Width \ 2))
		Dim textY As Integer = CInt(rect.Y + (rect.Height \ 2) - (textSize.Height \ 2) + yOffset)

		If shadow Then
			G.DrawString(text, font, Brushes.Black, textX + 1, textY + 1)
		End If
		G.DrawString(text, font, brush, textX, textY + 1)

	End Sub

End Class


<DefaultEvent("CheckedChanged")> _
Friend Class FirefoxRadioButton
	Inherits Control

	#region " Public "
	Public Event CheckedChanged As CheckedChangedEventHandler
	Public Delegate Sub CheckedChangedEventHandler(ByVal sender As Object, ByVal e As EventArgs)
	#End Region

	#region " Private "
	Private State As Helpers.MouseState
	Private ETC As Color = Color.Blue

	Private G As Graphics
	Private _EnabledCalc As Boolean
	Private _Checked As Boolean
	#End Region
	Private _Bold As Boolean

	#region " Properties "

	Public Property Checked() As Boolean
		Get
			Return _Checked
		End Get
		Set(ByVal value As Boolean)
			_Checked = value
			Invalidate()
		End Set
	End Property

	Public Shadows Property Enabled() As Boolean
		Get
			Return EnabledCalc
		End Get
		Set(ByVal value As Boolean)
			_EnabledCalc = value
			Invalidate()
		End Set
	End Property

	<DisplayName("Enabled")> _
	Public Property EnabledCalc() As Boolean
		Get
			Return _EnabledCalc
		End Get
		Set(ByVal value As Boolean)
			Enabled = value
			Invalidate()
		End Set
	End Property

	Public Property Bold() As Boolean
		Get
			Return _Bold
		End Get
		Set(ByVal value As Boolean)
			_Bold = value
			Invalidate()
		End Set
	End Property

	#End Region

	#region " Control "

	Public Sub New()
		DoubleBuffered = True
		ForeColor = Color.White
		Font = Theme.GlobalFont(FontStyle.Regular, 10)
		Size = New Size(160, 27)
		Enabled = True
	End Sub


	Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
		G = e.Graphics
		G.SmoothingMode = SmoothingMode.HighQuality
		G.TextRenderingHint = TextRenderingHint.ClearTypeGridFit

		MyBase.OnPaint(e)

		G.Clear(Parent.BackColor)

		If Enabled Then
			ETC = Color.FromArgb(66, 78, 90)

			Select Case State

				Case Helpers.MouseState.Over, Helpers.MouseState.Down

					Using P As New Pen(Color.FromArgb(34, 146, 208))
						G.DrawEllipse(P, New Rectangle(2, 2, 22, 22))
					End Using


				Case Else

					Using P As New Pen(Helpers.GreyColor(190))
						G.DrawEllipse(P, New Rectangle(2, 2, 22, 22))
					End Using


			End Select


			If Checked Then
				Using B As New SolidBrush(Color.FromArgb(34, 146, 208))
					G.FillEllipse(B, New Rectangle(7, 7, 12, 12))
				End Using

			End If

		Else
			ETC = Helpers.GreyColor(170)

			Using P As New Pen(Helpers.GreyColor(210))
				G.DrawEllipse(P, New Rectangle(2, 2, 22, 22))
			End Using


			If Checked Then
				Using B As New SolidBrush(Color.FromArgb(34, 146, 208))
					G.FillEllipse(B, New Rectangle(7, 7, 12, 12))
				End Using

			End If

		End If

		Using B As New SolidBrush(ETC)

			If Bold Then
				G.DrawString(Text, Theme.GlobalFont(FontStyle.Bold, 10), B, New Point(32, 4))
			Else
				G.DrawString(Text, Theme.GlobalFont(FontStyle.Regular, 10), B, New Point(32, 4))
			End If

		End Using


	End Sub

	Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
		MyBase.OnMouseDown(e)
		State = Helpers.MouseState.Down
		Invalidate()
	End Sub

	Protected Overrides Sub OnMouseUp(ByVal e As MouseEventArgs)
		MyBase.OnMouseUp(e)


		If Enabled Then

			If Not Checked Then
				For Each C As Control In Parent.Controls
					If TypeOf C Is FirefoxRadioButton Then
						DirectCast(C, FirefoxRadioButton).Checked = False
					End If
				Next C

			End If

			Checked = True
			RaiseEvent CheckedChanged(Me, e)
		End If

		State = Helpers.MouseState.Over
		Invalidate()
	End Sub

	Protected Overrides Sub OnMouseEnter(ByVal e As EventArgs)
		MyBase.OnMouseEnter(e)
		State = Helpers.MouseState.Over
		Invalidate()
	End Sub

	Protected Overrides Sub OnMouseLeave(ByVal e As EventArgs)
		MyBase.OnMouseLeave(e)
		State = Helpers.MouseState.None
		Invalidate()
	End Sub

	#End Region

End Class

<DefaultEvent("CheckedChanged")> _
Friend Class FirefoxCheckBox
	Inherits Control

	#region " Public "
	Public Event CheckedChanged As CheckedChangedEventHandler
	Public Delegate Sub CheckedChangedEventHandler(ByVal sender As Object, ByVal e As EventArgs)
	#End Region

	#region " Private "
	Private State As Helpers.MouseState
	Private ETC As Color = Color.Blue

	Private G As Graphics
	Private _EnabledCalc As Boolean
	Private _Checked As Boolean
	#End Region
	Private _Bold As Boolean

	#region " Properties "

	Public Property Checked() As Boolean
		Get
			Return _Checked
		End Get
		Set(ByVal value As Boolean)
			_Checked = value
			Invalidate()
		End Set
	End Property

	Public Shadows Property Enabled() As Boolean
		Get
			Return EnabledCalc
		End Get
		Set(ByVal value As Boolean)
			_EnabledCalc = value
			Invalidate()
		End Set
	End Property

	<DisplayName("Enabled")> _
	Public Property EnabledCalc() As Boolean
		Get
			Return _EnabledCalc
		End Get
		Set(ByVal value As Boolean)
			Enabled = value
			Invalidate()
		End Set
	End Property

	Public Property Bold() As Boolean
		Get
			Return _Bold
		End Get
		Set(ByVal value As Boolean)
			_Bold = value
			Invalidate()
		End Set
	End Property

	#End Region

	#region " Control "

	Public Sub New()
		DoubleBuffered = True
		ForeColor = Color.White
		Font = Theme.GlobalFont(FontStyle.Regular, 10)
		Size = New Size(160, 27)
		Enabled = True
	End Sub


	Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
		G = e.Graphics
		G.SmoothingMode = SmoothingMode.HighQuality
		G.TextRenderingHint = TextRenderingHint.ClearTypeGridFit

		MyBase.OnPaint(e)

		G.Clear(Parent.BackColor)

		If Enabled Then
			ETC = Color.White

			Select Case State

				Case Helpers.MouseState.Over, Helpers.MouseState.Down
					Helpers.DrawRoundRect(G, New Rectangle(3, 3, 20, 20), 3, Color.FromArgb(44, 156, 218))

				Case Else
					Helpers.DrawRoundRect(G, New Rectangle(3, 3, 20, 20), 3, Helpers.GreyColor(200))

			End Select


			If Checked Then
				Using I As Image = Image.FromStream(New System.IO.MemoryStream(Convert.FromBase64String(Theme.GetCheckMark())))
					G.DrawImage(I, New Point(4, 5))
				End Using

			End If


		Else
			ETC = Helpers.GreyColor(170)
			Helpers.DrawRoundRect(G, New Rectangle(3, 3, 20, 20), 3, Helpers.GreyColor(220))


			If Checked Then
				Using I As Image = Image.FromStream(New System.IO.MemoryStream(Convert.FromBase64String(Theme.GetCheckMark())))
					G.DrawImage(I, New Point(4, 5))
				End Using

			End If

		End If


		Using B As New SolidBrush(ETC)

			If Bold Then
				G.DrawString(Text, Theme.GlobalFont(FontStyle.Bold, 10), B, New Point(32, 4))
			Else
				G.DrawString(Text, Theme.GlobalFont(FontStyle.Regular, 10), B, New Point(32, 4))
			End If

		End Using


	End Sub

	Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
		MyBase.OnMouseDown(e)
		State = Helpers.MouseState.Down
		Invalidate()
	End Sub

	Protected Overrides Sub OnMouseUp(ByVal e As MouseEventArgs)
		MyBase.OnMouseUp(e)

		If Enabled Then
			Checked = Not Checked
			RaiseEvent CheckedChanged(Me, e)
		End If

		State = Helpers.MouseState.Over
		Invalidate()
	End Sub

	Protected Overrides Sub OnMouseEnter(ByVal e As EventArgs)
		MyBase.OnMouseEnter(e)
		State = Helpers.MouseState.Over
		Invalidate()
	End Sub

	Protected Overrides Sub OnMouseLeave(ByVal e As EventArgs)
		MyBase.OnMouseLeave(e)
		State = Helpers.MouseState.None
		Invalidate()
	End Sub

	#End Region

End Class

Friend Class FirefoxH1
	Inherits Label

	#region " Private "
	#End Region
	Private G As Graphics

	#region " Control "

	Public Sub New()
		DoubleBuffered = True
		AutoSize = False
		Font = New Font("Segoe UI Semibold", 20)
		ForeColor = Color.FromArgb(76, 88, 100)
	End Sub


	Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
		G = e.Graphics
		G.SmoothingMode = SmoothingMode.HighQuality
		G.TextRenderingHint = TextRenderingHint.ClearTypeGridFit

		MyBase.OnPaint(e)

		Using P As New Pen(Helpers.GreyColor(200))
			G.DrawLine(P, New Point(0, 50), New Point(Width, 50))
		End Using

	End Sub

	#End Region

End Class

Friend Class FirefoxH2
	Inherits Label

	#region " Control "

	Public Sub New()
		Font = Theme.GlobalFont(FontStyle.Bold, 10)
		ForeColor = Color.FromArgb(76, 88, 100)
		BackColor = Color.White
	End Sub

	#End Region

End Class

Friend Class FirefoxButton
	Inherits Control

	#region " Private "
	Private State As Helpers.MouseState
	Private ETC As Color = Color.Blue

	Private G As Graphics
	#End Region
	Private _EnabledCalc As Boolean

	#region " Properties "

	Public Shadows Property Enabled() As Boolean
		Get
			Return EnabledCalc
		End Get
		Set(ByVal value As Boolean)
			_EnabledCalc = value
			Invalidate()
		End Set
	End Property

	<DisplayName("Enabled")> _
	Public Property EnabledCalc() As Boolean
		Get
			Return _EnabledCalc
		End Get
		Set(ByVal value As Boolean)
			Enabled = value
			Invalidate()
		End Set
	End Property

	#End Region

	#region " Control "

	Public Sub New()
		DoubleBuffered = True
		Enabled = True
		ForeColor = Color.FromArgb(56, 68, 80)
		Font = Theme.GlobalFont(FontStyle.Regular, 10)
	End Sub


	Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
		G = e.Graphics
		G.SmoothingMode = SmoothingMode.HighQuality
		G.TextRenderingHint = TextRenderingHint.ClearTypeGridFit

		MyBase.OnPaint(e)

		G.Clear(Parent.BackColor)

		If Enabled Then
			ETC = Color.FromArgb(56, 68, 80)

			Select Case State

				Case Helpers.MouseState.None

					Using B As New SolidBrush(Helpers.GreyColor(245))
						G.FillRectangle(B, New Rectangle(1, 1, Width - 2, Height - 2))
					End Using


					Helpers.DrawRoundRect(G, Helpers.FullRectangle(Size, True), 2, Helpers.GreyColor(193))

				Case Helpers.MouseState.Over

					Using B As New SolidBrush(Helpers.GreyColor(232))
						G.FillRectangle(B, New Rectangle(1, 1, Width - 2, Height - 2))
					End Using


					Helpers.DrawRoundRect(G, Helpers.FullRectangle(Size, True), 2, Helpers.GreyColor(193))

				Case Else

					Using B As New SolidBrush(Helpers.GreyColor(212))
						G.FillRectangle(B, New Rectangle(1, 1, Width - 2, Height - 2))
					End Using


					Helpers.DrawRoundRect(G, Helpers.FullRectangle(Size, True), 2, Helpers.GreyColor(193))

			End Select

		Else
			ETC = Helpers.GreyColor(170)

			Using B As New SolidBrush(Helpers.GreyColor(245))
				G.FillRectangle(B, New Rectangle(1, 1, Width - 2, Height - 2))
			End Using

			Helpers.DrawRoundRect(G, Helpers.FullRectangle(Size, True), 2, Helpers.GreyColor(223))

		End If

		Helpers.CenterString(G, Text, Theme.GlobalFont(FontStyle.Regular, 10), ETC, Helpers.FullRectangle(Size, False))

	End Sub

	Protected Overrides Sub OnMouseUp(ByVal e As MouseEventArgs)
		MyBase.OnMouseUp(e)
		State = Helpers.MouseState.Over
		Invalidate()
	End Sub

	Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
		MyBase.OnMouseUp(e)
		State = Helpers.MouseState.Down
		Invalidate()
	End Sub

	Protected Overrides Sub OnMouseEnter(ByVal e As EventArgs)
		MyBase.OnMouseEnter(e)
		State = Helpers.MouseState.Over
		Invalidate()
	End Sub

	Protected Overrides Sub OnMouseLeave(ByVal e As EventArgs)
		MyBase.OnMouseEnter(e)
		State = Helpers.MouseState.None
		Invalidate()
	End Sub

	#End Region

End Class

Friend Class FirefoxRedirect
	Inherits Control

	#region " Private "
	Private State As Helpers.MouseState

	Private G As Graphics
	Private FC As Color = Color.Blue
	#End Region
	Private FF As Font = Nothing

	#region " Control "

	Public Sub New()
		DoubleBuffered = True
		Cursor = Cursors.Hand
		BackColor = Color.White
	End Sub


	Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
		G = e.Graphics
		G.SmoothingMode = SmoothingMode.HighQuality
		G.TextRenderingHint = TextRenderingHint.ClearTypeGridFit

		MyBase.OnPaint(e)

		Select Case State

			Case Helpers.MouseState.Over
				FC = Color.FromArgb(23, 140, 229)
				FF = Theme.GlobalFont(FontStyle.Underline, 10)

			Case Helpers.MouseState.Down
				FC = Color.FromArgb(255, 149, 0)
				FF = Theme.GlobalFont(FontStyle.Regular, 10)

			Case Else
				FC = Color.FromArgb(0, 149, 221)
				FF = Theme.GlobalFont(FontStyle.Regular, 10)

		End Select

		Using B As New SolidBrush(FC)
			G.DrawString(Text, FF, B, New Point(0, 0))
		End Using

	End Sub

	Protected Overrides Sub OnMouseUp(ByVal e As MouseEventArgs)
		MyBase.OnMouseUp(e)
		State = Helpers.MouseState.Over
		Invalidate()
	End Sub

	Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
		MyBase.OnMouseUp(e)
		State = Helpers.MouseState.Down
		Invalidate()
	End Sub

	Protected Overrides Sub OnMouseEnter(ByVal e As EventArgs)
		MyBase.OnMouseEnter(e)
		State = Helpers.MouseState.Over
		Invalidate()
	End Sub

	Protected Overrides Sub OnMouseLeave(ByVal e As EventArgs)
		MyBase.OnMouseEnter(e)
		State = Helpers.MouseState.None
		Invalidate()
	End Sub

	#End Region

End Class

Friend Class FirefoxSubTabControl
	Inherits TabControl

	#region " Private "
	Private G As Graphics
	#End Region
	Private TabRect As Rectangle

	#region " Control "

	Public Sub New()
		DoubleBuffered = True
		Alignment = TabAlignment.Top
	End Sub

	Protected Overrides Sub OnCreateControl()
		MyBase.OnCreateControl()
		SetStyle(ControlStyles.UserPaint, True)
		ItemSize = New Size(100, 40)
		SizeMode = TabSizeMode.Fixed
	End Sub

	Protected Overrides Sub OnControlAdded(ByVal e As ControlEventArgs)
		MyBase.OnControlAdded(e)
		Try
			For i As Integer = 0 To TabPages.Count - 1
				TabPages(i).BackColor = Color.FromArgb(40, 40, 40)
				TabPages(i).ForeColor = Color.FromArgb(153, 153, 153)
				TabPages(i).Font = Theme.GlobalFont(FontStyle.Regular, 10)
			Next i
		Catch
		End Try
	End Sub


	Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
		G = e.Graphics
		G.SmoothingMode = SmoothingMode.HighQuality
		G.TextRenderingHint = TextRenderingHint.ClearTypeGridFit

		MyBase.OnPaint(e)

		G.Clear(Parent.BackColor)


		For i As Integer = 0 To TabPages.Count - 1
			TabRect = GetTabRect(i)


			If GetTabRect(i).Contains(Me.PointToClient(Cursor.Position)) And Not(SelectedIndex = i) Then
				Using B As New SolidBrush(Helpers.GreyColor(240))
					G.FillRectangle(B, New Rectangle(GetTabRect(i).Location.X - 2, GetTabRect(i).Location.Y - 2, GetTabRect(i).Width, GetTabRect(i).Height + 1))
				End Using


			ElseIf SelectedIndex = i Then
				Using B As New SolidBrush(Helpers.GreyColor(240))
					G.FillRectangle(B, New Rectangle(GetTabRect(i).Location.X - 2, GetTabRect(i).Location.Y - 2, GetTabRect(i).Width, GetTabRect(i).Height + 1))
				End Using

				Using P As New Pen(Color.FromArgb(255, 149, 0), 4)
					G.DrawLine(P, New Point(TabRect.X - 2, TabRect.Y + ItemSize.Height - 2), New Point(TabRect.X + TabRect.Width - 2, TabRect.Y + ItemSize.Height - 2))
				End Using

			ElseIf Not(SelectedIndex = i) Then
				G.FillRectangle(Brushes.White, GetTabRect(i))
			End If

			Using B As New SolidBrush(Color.FromArgb(56, 69, 80))
				Helpers.CenterStringTab(G, TabPages(i).Text, Theme.GlobalFont(FontStyle.Regular, 10), B, GetTabRect(i))
			End Using

		Next i

		Using P As New Pen(Helpers.GreyColor(200))
			G.DrawLine(P, New Point(0, ItemSize.Height + 2), New Point(Width, ItemSize.Height + 2))
		End Using

	End Sub

	#End Region

End Class

Friend Class FirefoxMainTabControl
	Inherits TabControl

	#region " Private "
	Private G As Graphics
	Private TabRect As Rectangle
	#End Region
	Private FC As Color = Color.Blue

	#region " Control "

	Public Sub New()
		DoubleBuffered = True
		ItemSize = New Size(43, 152)
		Alignment = TabAlignment.Left
		SizeMode = TabSizeMode.Fixed
	End Sub

	Protected Overrides Sub OnCreateControl()
		MyBase.OnCreateControl()
		SetStyle(ControlStyles.UserPaint, True)
	End Sub

	Protected Overrides Sub OnControlAdded(ByVal e As ControlEventArgs)
		MyBase.OnControlAdded(e)
		Try
			For i As Integer = 0 To TabPages.Count - 1
				TabPages(i).BackColor = Color.FromArgb(40, 40, 40)
				TabPages(i).ForeColor = Color.FromArgb(153, 153, 153)
				TabPages(i).Font = Theme.GlobalFont(FontStyle.Regular, 10)
			Next i
		Catch
		End Try
	End Sub


	Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
		G = e.Graphics
		G.SmoothingMode = SmoothingMode.HighQuality
		G.TextRenderingHint = TextRenderingHint.ClearTypeGridFit

		MyBase.OnPaint(e)

		G.Clear(Color.FromArgb(40, 40, 40))


		For i As Integer = 0 To TabPages.Count - 1
			TabRect = GetTabRect(i)


			If SelectedIndex = i Then
				Using B As New SolidBrush(Color.FromArgb(52, 63, 72))
					G.FillRectangle(B, TabRect)
				End Using

				FC = Helpers.GreyColor(245)

				''' COLOR OR VERTICAL BAR

				Using B As New SolidBrush(Color.FromArgb(209, 43, 43))
					G.FillRectangle(B, New Rectangle(TabRect.Location.X - 3, TabRect.Location.Y + 1, 5, TabRect.Height - 2))
				End Using

			Else
				FC = Helpers.GreyColor(192)

				Using B As New SolidBrush(Color.FromArgb(40, 40, 40))
					G.FillRectangle(B, TabRect)
				End Using

			End If

			Using B As New SolidBrush(FC)
				G.DrawString(TabPages(i).Text, Theme.GlobalFont(FontStyle.Regular, 10), B, New Point(TabRect.X + 50, TabRect.Y + 12))
			End Using

			If i = 0 Then
				G.DrawImage(My.Resources._3, New Rectangle(TabRect.X + 19, TabRect.Y + ((TabRect.Height \ 2) - 10), 22, 22))
			ElseIf i = 1 Then
				G.DrawImage(My.Resources._4, New Rectangle(TabRect.X + 19, TabRect.Y + ((TabRect.Height \ 2) - 10), 22, 22))
			ElseIf i = 2 Then
				G.DrawImage(My.Resources._1, New Rectangle(TabRect.X + 19, TabRect.Y + ((TabRect.Height \ 2) - 10), 22, 22))
			ElseIf i = 3 Then
				G.DrawImage(My.Resources._6, New Rectangle(TabRect.X + 19, TabRect.Y + ((TabRect.Height \ 2) - 10), 22, 22))
			ElseIf i = 4 Then
				G.DrawImage(My.Resources._5, New Rectangle(TabRect.X + 19, TabRect.Y + ((TabRect.Height \ 2) - 10), 22, 22))
			ElseIf i = 5 Then
				G.DrawImage(My.Resources._2, New Rectangle(TabRect.X + 19, TabRect.Y + ((TabRect.Height \ 2) - 10), 22, 22))
			ElseIf i = 6 Then
				G.DrawImage(My.Resources._8, New Rectangle(TabRect.X + 19, TabRect.Y + ((TabRect.Height \ 2) - 10), 22, 22))
			ElseIf i = 7 Then
				G.DrawImage(My.Resources._7, New Rectangle(TabRect.X + 19, TabRect.Y + ((TabRect.Height \ 2) - 10), 22, 22))
			ElseIf i = 8 Then
				G.DrawImage(My.Resources._11, New Rectangle(TabRect.X + 19, TabRect.Y + ((TabRect.Height \ 2) - 10), 22, 22))
			ElseIf i = 9 Then
				G.DrawImage(My.Resources._12, New Rectangle(TabRect.X + 19, TabRect.Y + ((TabRect.Height \ 2) - 10), 22, 22))
			ElseIf i = 10 Then
				G.DrawImage(My.Resources._10, New Rectangle(TabRect.X + 19, TabRect.Y + ((TabRect.Height \ 2) - 10), 22, 22))
			ElseIf i = 11 Then
				G.DrawImage(My.Resources._13, New Rectangle(TabRect.X + 19, TabRect.Y + ((TabRect.Height \ 2) - 10), 22, 22))
			ElseIf i = 12 Then
				G.DrawImage(My.Resources._14, New Rectangle(TabRect.X + 19, TabRect.Y + ((TabRect.Height \ 2) - 10), 22, 22))
			End If
		Next i

	End Sub

	#End Region

End Class

<DefaultEvent("TextChanged")> _
Friend Class FirefoxTextbox
	Inherits Control

	#region " Private "
	Private withEventsField_TB As New TextBox()
	Private Property TB() As TextBox
		Get
			Return withEventsField_TB
		End Get
		Set(ByVal value As TextBox)
			If withEventsField_TB IsNot Nothing Then
				RemoveHandler withEventsField_TB.TextChanged, AddressOf TextChangeTb
			End If
			withEventsField_TB = value
			If withEventsField_TB IsNot Nothing Then
				AddHandler withEventsField_TB.TextChanged, AddressOf TextChangeTb
			End If
		End Set
	End Property
	Private G As Graphics
	Private State As Helpers.MouseState

	Private IsDown As Boolean
	Private _EnabledCalc As Boolean
	Private _allowpassword As Boolean = False
	Private _maxChars As Integer = 32767
	Private _textAlignment As HorizontalAlignment
	Private _multiLine As Boolean = False
	#End Region
	Private _readOnly As Boolean = False

	#region " Properties "

	Public Shadows Property Enabled() As Boolean
		Get
			Return EnabledCalc
		End Get
		Set(ByVal value As Boolean)
			TB.Enabled = value
			_EnabledCalc = value
			Invalidate()
		End Set
	End Property

	<DisplayName("Enabled")> _
	Public Property EnabledCalc() As Boolean
		Get
			Return _EnabledCalc
		End Get
		Set(ByVal value As Boolean)
			Enabled = value
			Invalidate()
		End Set
	End Property

	Public Shadows Property UseSystemPasswordChar() As Boolean
		Get
			Return _allowpassword
		End Get
		Set(ByVal value As Boolean)
			TB.UseSystemPasswordChar = UseSystemPasswordChar
			_allowpassword = value
			Invalidate()
		End Set
	End Property

	Public Shadows Property MaxLength() As Integer
		Get
			Return _maxChars
		End Get
		Set(ByVal value As Integer)
			_maxChars = value
			TB.MaxLength = MaxLength
			Invalidate()
		End Set
	End Property

	Public Shadows Property TextAlign() As HorizontalAlignment
		Get
			Return _textAlignment
		End Get
		Set(ByVal value As HorizontalAlignment)
			_textAlignment = value
			Invalidate()
		End Set
	End Property

	Public Shadows Property MultiLine() As Boolean
		Get
			Return _multiLine
		End Get
		Set(ByVal value As Boolean)
			_multiLine = value
			TB.Multiline = value
			OnResize(EventArgs.Empty)
			Invalidate()
		End Set
	End Property

	Public Shadows Property [ReadOnly]() As Boolean
		Get
			Return _readOnly
		End Get
		Set(ByVal value As Boolean)
			_readOnly = value
			If TB IsNot Nothing Then
				TB.ReadOnly = value
			End If
		End Set
	End Property

	#End Region

	#region " Control "

	Protected Overrides Sub OnTextChanged(ByVal e As EventArgs)
		MyBase.OnTextChanged(e)
		Invalidate()
	End Sub

	Protected Overrides Sub OnBackColorChanged(ByVal e As EventArgs)
		MyBase.OnBackColorChanged(e)
		Invalidate()
	End Sub

	Protected Overrides Sub OnForeColorChanged(ByVal e As EventArgs)
		MyBase.OnForeColorChanged(e)
		TB.ForeColor = ForeColor
		Invalidate()
	End Sub

	Protected Overrides Sub OnFontChanged(ByVal e As EventArgs)
		MyBase.OnFontChanged(e)
		TB.Font = Font
	End Sub

	Protected Overrides Sub OnGotFocus(ByVal e As EventArgs)
		MyBase.OnGotFocus(e)
		TB.Focus()
	End Sub

	Private Sub TextChangeTb(ByVal sender As Object, ByVal e As EventArgs)
		Text = TB.Text
	End Sub

	Private Sub TextChng(ByVal sender As Object, ByVal e As EventArgs)
		TB.Text = Text
	End Sub

	Public Sub NewTextBox()
		Dim _with1 = TB
		_with1.Text = String.Empty
		_with1.BackColor = Color.White
		_with1.ForeColor = Color.FromArgb(66, 78, 90)
		_with1.TextAlign = HorizontalAlignment.Left
		_with1.BorderStyle = BorderStyle.None
		_with1.Location = New Point(3, 3)
		_with1.Font = Theme.GlobalFont(FontStyle.Regular, 10)
		_with1.Size = New Size(Width - 3, Height - 3)
		_with1.UseSystemPasswordChar = UseSystemPasswordChar
	End Sub

	Public Sub New()
		MyBase.New()
		AddHandler TextChanged, AddressOf TextChng
		NewTextBox()
		Controls.Add(TB)
		SetStyle(ControlStyles.UserPaint Or ControlStyles.SupportsTransparentBackColor, True)
		DoubleBuffered = True
		TextAlign = HorizontalAlignment.Left
		ForeColor = Color.FromArgb(66, 78, 90)
		Font = Theme.GlobalFont(FontStyle.Regular, 10)
		Size = New Size(130, 29)
		Enabled = True
	End Sub


	Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
		G = e.Graphics
		G.SmoothingMode = SmoothingMode.HighQuality
		G.TextRenderingHint = TextRenderingHint.ClearTypeGridFit

		MyBase.OnPaint(e)

		G.Clear(Parent.BackColor)


		If Enabled Then
			TB.ForeColor = Color.FromArgb(66, 78, 90)

			If State = Helpers.MouseState.Down Then
				Helpers.DrawRoundRect(G, Helpers.FullRectangle(Size, True), 3, Color.FromArgb(44, 156, 218))
			Else
				Helpers.DrawRoundRect(G, Helpers.FullRectangle(Size, True), 3, Helpers.GreyColor(200))
			End If

		Else
			TB.ForeColor = Helpers.GreyColor(170)
			Helpers.DrawRoundRect(G, Helpers.FullRectangle(Size, True), 3, Helpers.GreyColor(230))
		End If

		TB.TextAlign = TextAlign
		TB.UseSystemPasswordChar = UseSystemPasswordChar

	End Sub

	Protected Overrides Sub OnResize(ByVal e As EventArgs)
		MyBase.OnResize(e)
		If Not MultiLine Then
			Dim tbheight As Integer = TB.Height
			TB.Location = New Point(10, Convert.ToInt32(((Height \ 2) - (tbheight \ 2) - 0)))
			TB.Size = New Size(Width - 20, tbheight)
		Else
			TB.Location = New Point(10, 10)
			TB.Size = New Size(Width - 20, Height - 20)
		End If
	End Sub

	Protected Overrides Sub OnEnter(ByVal e As EventArgs)
		MyBase.OnEnter(e)
		State = Helpers.MouseState.Down
		Invalidate()
	End Sub

	Protected Overrides Sub OnLeave(ByVal e As EventArgs)
		MyBase.OnLeave(e)
		State = Helpers.MouseState.None
		Invalidate()
	End Sub

	#End Region

End Class

Friend Class FirefoxNumericUpDown
	Inherits Control

	#region " Private "
	Private G As Graphics
	Private _Value As Integer
	Private _Min As Integer
	Private _Max As Integer
	Private Loc As Point
	Private Down As Boolean
	Private _EnabledCalc As Boolean
	#End Region
	Private ETC As Color = Color.Blue

	#region " Properties "

	Public Shadows Property Enabled() As Boolean
		Get
			Return EnabledCalc
		End Get
		Set(ByVal value As Boolean)
			_EnabledCalc = value
			Invalidate()
		End Set
	End Property

	<DisplayName("Enabled")> _
	Public Property EnabledCalc() As Boolean
		Get
			Return _EnabledCalc
		End Get
		Set(ByVal value As Boolean)
			Enabled = value
			Invalidate()
		End Set
	End Property

	Public Property Value() As Integer
		Get
			Return _Value
		End Get

		Set(ByVal value As Integer)
			If value <= _Max And value >= Minimum Then
				_Value = value
			End If

			Invalidate()

		End Set
	End Property

	Public Property Minimum() As Integer
		Get
			Return _Min
		End Get

		Set(ByVal value As Integer)
			If value < Maximum Then
				_Min = value
			End If

			If value < Minimum Then
				value = Minimum
			End If

			Invalidate()
		End Set
	End Property

	Public Property Maximum() As Integer
		Get
			Return _Max
		End Get

		Set(ByVal value As Integer)
			If value > Minimum Then
				_Max = value
			End If

			If value > Maximum Then
				value = Maximum
			End If

			Invalidate()
		End Set
	End Property

	#End Region

	#region " Control "

	Public Sub New()
		Try
			DoubleBuffered = True
			Value = 0
			Minimum = 0
			Maximum = 100
			Cursor = Cursors.IBeam
			BackColor = Color.White
			ForeColor = Color.White
			Font = Theme.GlobalFont(FontStyle.Regular, 10)
			Enabled = True
		Catch

		End Try
	End Sub

	Protected Overrides Sub OnMouseMove(ByVal e As MouseEventArgs)
		Try
			MyBase.OnMouseMove(e)
			Loc.X = e.X
			Loc.Y = e.Y
			Invalidate()

			If Loc.X < Width - 23 Then
				Cursor = Cursors.IBeam
			Else
				Cursor = Cursors.Default
			End If

		Catch

		End Try
	End Sub

	Protected Overrides Sub OnResize(ByVal e As EventArgs)
		Try
			MyBase.OnResize(e)
			Height = 30
		Catch

		End Try
	End Sub

	Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
		Try
			MyBase.OnMouseClick(e)


			If Enabled Then
				If Loc.X > Width - 21 AndAlso Loc.X < Width - 3 Then
					If Loc.Y < 15 Then
						If (Value + 1) <= Maximum Then
							Value += 1
						End If
					Else
						If (Value - 1) >= Minimum Then
							Value -= 1
						End If
					End If
				Else
					Down = Not Down
					Focus()
				End If

			End If

			Invalidate()
		Catch

		End Try
	End Sub

	Protected Overrides Sub OnKeyPress(ByVal e As System.Windows.Forms.KeyPressEventArgs)
		Try
			MyBase.OnKeyPress(e)
			Try
				If Down Then
					Value = Convert.ToInt32(Value.ToString() & e.KeyChar.ToString())
				End If

				If Value > Maximum Then
					Value = Maximum
				End If

			Catch
			End Try
		Catch

		End Try
	End Sub

	Protected Overrides Sub OnKeyUp(ByVal e As System.Windows.Forms.KeyEventArgs)
		Try
			MyBase.OnKeyUp(e)


			If e.KeyCode = Keys.Up Then
				If (Value + 1) <= Maximum Then
					Value += 1
				End If

				Invalidate()


			ElseIf e.KeyCode = Keys.Down Then
				If (Value - 1) >= Minimum Then
					Value -= 1
				End If

			ElseIf e.KeyCode = Keys.Back Then
				Dim BC As String = Value.ToString()
				BC = BC.Remove(Convert.ToInt32(BC.Length - 1))

				If (BC.Length = 0) Then
					BC = "0"
				End If

				Value = Convert.ToInt32(BC)

			End If

			Invalidate()

		Catch

		End Try
	End Sub

	Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
		Try
			G = e.Graphics
			G.SmoothingMode = SmoothingMode.HighQuality
			G.TextRenderingHint = TextRenderingHint.ClearTypeGridFit

			MyBase.OnPaint(e)

			G.Clear(Parent.BackColor)


			If Enabled Then
				ETC = Color.FromArgb(66, 78, 90)

				Using P As New Pen(Helpers.GreyColor(190))
					Helpers.DrawRoundRect(G, Helpers.FullRectangle(Size, True), 2, Helpers.GreyColor(190))
					G.DrawLine(P, New Point(Width - 24, CInt(Math.Truncate(13.5F))), New Point(Width - 5, CInt(Math.Truncate(13.5F))))
				End Using

				Helpers.DrawRoundRect(G, New Rectangle(Width - 24, 4, 19, 21), 3, Helpers.GreyColor(200))

			Else
				ETC = Helpers.GreyColor(170)

				Using P As New Pen(Helpers.GreyColor(230))
					Helpers.DrawRoundRect(G, Helpers.FullRectangle(Size, True), 2, Helpers.GreyColor(190))
					G.DrawLine(P, New Point(Width - 24, CInt(Math.Truncate(13.5F))), New Point(Width - 5, CInt(Math.Truncate(13.5F))))
				End Using

				Helpers.DrawRoundRect(G, New Rectangle(Width - 24, 4, 19, 21), 3, Helpers.GreyColor(220))

			End If

			Using B As New SolidBrush(ETC)
				G.DrawString("t", New Font("Marlett", 8, FontStyle.Bold), B, New Point(Width - 22, 5))
				G.DrawString("u", New Font("Marlett", 8, FontStyle.Bold), B, New Point(Width - 22, 13))
				Helpers.CenterString(G, Value.ToString(), New Font("Segoe UI", 10), ETC, New Rectangle(Width \ 2 - 10, 0, Width - 5, Height))
			End Using

		Catch

		End Try
	End Sub

	#End Region

End Class