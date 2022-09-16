Imports System
Imports System.Windows.Forms
Imports System.Diagnostics

Friend NotInheritable Class Program

	Private Sub New()
	End Sub

	<STAThread> _
	Shared Sub Main()
		Application.EnableVisualStyles()
		Application.SetCompatibleTextRenderingDefault(False)
		Application.Run(New MainForm())
	End Sub
End Class