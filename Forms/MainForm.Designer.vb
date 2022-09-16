Partial Public Class MainForm
	Private components As System.ComponentModel.IContainer = Nothing

	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing AndAlso (components IsNot Nothing) Then
			components.Dispose()
		End If

		MyBase.Dispose(disposing)
	End Sub

	Private Sub InitializeComponent()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
			Me.gunaControlBox1 = New Guna.UI.WinForms.GunaControlBox()
			Me.gunaControlBox2 = New Guna.UI.WinForms.GunaControlBox()
			Me.gunaControlBox3 = New Guna.UI.WinForms.GunaControlBox()
			Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog()
			Me.openFileDialog2 = New System.Windows.Forms.OpenFileDialog()
			Me.firefoxMainTabControl1 = New FirefoxMainTabControl()
			Me.tabPage1 = New System.Windows.Forms.TabPage()
			Me.siticoneCheckBox37 = New ns1.SiticoneCheckBox()
			Me.gunaLineTextBox23 = New Guna.UI.WinForms.GunaLineTextBox()
			Me.siticoneCheckBox23 = New ns1.SiticoneCheckBox()
			Me.siticoneButton6 = New ns1.SiticoneButton()
			Me.siticoneButton5 = New ns1.SiticoneButton()
			Me.pictureBox1 = New System.Windows.Forms.PictureBox()
			Me.siticoneButton3 = New ns1.SiticoneButton()
			Me.metroLabel15 = New MetroSuite.MetroLabel()
			Me.metroLabel16 = New MetroSuite.MetroLabel()
			Me.siticoneButton4 = New ns1.SiticoneButton()
			Me.siticoneButton2 = New ns1.SiticoneButton()
			Me.metroLabel14 = New MetroSuite.MetroLabel()
			Me.metroLabel13 = New MetroSuite.MetroLabel()
			Me.siticoneButton1 = New ns1.SiticoneButton()
			Me.metroLabel1 = New MetroSuite.MetroLabel()
			Me.tabPage2 = New System.Windows.Forms.TabPage()
			Me.siticoneCheckBox36 = New ns1.SiticoneCheckBox()
			Me.siticoneCheckBox33 = New ns1.SiticoneCheckBox()
			Me.gunaButton2 = New Guna.UI.WinForms.GunaButton()
			Me.gunaButton1 = New Guna.UI.WinForms.GunaButton()
			Me.metroLabel17 = New MetroSuite.MetroLabel()
			Me.siticoneOSToggleSwith1 = New ns1.SiticoneOSToggleSwith()
			Me.siticoneCheckBox4 = New ns1.SiticoneCheckBox()
			Me.siticoneCheckBox3 = New ns1.SiticoneCheckBox()
			Me.siticoneCheckBox2 = New ns1.SiticoneCheckBox()
			Me.siticoneCheckBox1 = New ns1.SiticoneCheckBox()
			Me.gunaLineTextBox3 = New Guna.UI.WinForms.GunaLineTextBox()
			Me.gunaLineTextBox2 = New Guna.UI.WinForms.GunaLineTextBox()
			Me.gunaLineTextBox1 = New Guna.UI.WinForms.GunaLineTextBox()
			Me.metroLabel2 = New MetroSuite.MetroLabel()
			Me.bunifuHSlider1 = New Bunifu.UI.WinForms.BunifuHSlider()
			Me.tabPage3 = New System.Windows.Forms.TabPage()
			Me.siticoneCheckBox34 = New ns1.SiticoneCheckBox()
			Me.siticoneCheckBox29 = New ns1.SiticoneCheckBox()
			Me.siticoneRadioButton5 = New ns1.SiticoneRadioButton()
			Me.siticoneRadioButton4 = New ns1.SiticoneRadioButton()
			Me.siticoneRadioButton3 = New ns1.SiticoneRadioButton()
			Me.gunaButton3 = New Guna.UI.WinForms.GunaButton()
			Me.gunaButton4 = New Guna.UI.WinForms.GunaButton()
			Me.metroLabel18 = New MetroSuite.MetroLabel()
			Me.siticoneOSToggleSwith2 = New ns1.SiticoneOSToggleSwith()
			Me.siticoneCheckBox9 = New ns1.SiticoneCheckBox()
			Me.siticoneCheckBox8 = New ns1.SiticoneCheckBox()
			Me.siticoneCheckBox7 = New ns1.SiticoneCheckBox()
			Me.gunaTextBox1 = New Guna.UI.WinForms.GunaTextBox()
			Me.gunaLineTextBox5 = New Guna.UI.WinForms.GunaLineTextBox()
			Me.gunaLineTextBox4 = New Guna.UI.WinForms.GunaLineTextBox()
			Me.metroLabel3 = New MetroSuite.MetroLabel()
			Me.bunifuHSlider2 = New Bunifu.UI.WinForms.BunifuHSlider()
			Me.tabPage4 = New System.Windows.Forms.TabPage()
			Me.siticoneRadioButton6 = New ns1.SiticoneRadioButton()
			Me.siticoneRadioButton7 = New ns1.SiticoneRadioButton()
			Me.siticoneRadioButton8 = New ns1.SiticoneRadioButton()
			Me.metroLabel19 = New MetroSuite.MetroLabel()
			Me.siticoneOSToggleSwith3 = New ns1.SiticoneOSToggleSwith()
			Me.gunaButton6 = New Guna.UI.WinForms.GunaButton()
			Me.gunaButton5 = New Guna.UI.WinForms.GunaButton()
			Me.siticoneCheckBox12 = New ns1.SiticoneCheckBox()
			Me.siticoneCheckBox11 = New ns1.SiticoneCheckBox()
			Me.gunaTextBox2 = New Guna.UI.WinForms.GunaTextBox()
			Me.gunaLineTextBox7 = New Guna.UI.WinForms.GunaLineTextBox()
			Me.gunaLineTextBox6 = New Guna.UI.WinForms.GunaLineTextBox()
			Me.metroLabel4 = New MetroSuite.MetroLabel()
			Me.bunifuHSlider3 = New Bunifu.UI.WinForms.BunifuHSlider()
			Me.tabPage5 = New System.Windows.Forms.TabPage()
			Me.siticoneButton7 = New ns1.SiticoneButton()
			Me.gunaButton8 = New Guna.UI.WinForms.GunaButton()
			Me.gunaButton7 = New Guna.UI.WinForms.GunaButton()
			Me.metroLabel20 = New MetroSuite.MetroLabel()
			Me.siticoneOSToggleSwith4 = New ns1.SiticoneOSToggleSwith()
			Me.siticoneRadioButton2 = New ns1.SiticoneRadioButton()
			Me.siticoneRadioButton1 = New ns1.SiticoneRadioButton()
			Me.gunaLineTextBox10 = New Guna.UI.WinForms.GunaLineTextBox()
			Me.gunaLineTextBox9 = New Guna.UI.WinForms.GunaLineTextBox()
			Me.gunaLineTextBox8 = New Guna.UI.WinForms.GunaLineTextBox()
			Me.metroLabel5 = New MetroSuite.MetroLabel()
			Me.bunifuHSlider4 = New Bunifu.UI.WinForms.BunifuHSlider()
			Me.tabPage6 = New System.Windows.Forms.TabPage()
			Me.siticoneCheckBox35 = New ns1.SiticoneCheckBox()
			Me.bunifuHSlider5 = New Bunifu.UI.WinForms.BunifuHSlider()
			Me.gunaButton9 = New Guna.UI.WinForms.GunaButton()
			Me.gunaButton10 = New Guna.UI.WinForms.GunaButton()
			Me.metroLabel21 = New MetroSuite.MetroLabel()
			Me.siticoneOSToggleSwith5 = New ns1.SiticoneOSToggleSwith()
			Me.siticoneCheckBox5 = New ns1.SiticoneCheckBox()
			Me.gunaLineTextBox11 = New Guna.UI.WinForms.GunaLineTextBox()
			Me.metroLabel6 = New MetroSuite.MetroLabel()
			Me.tabPage7 = New System.Windows.Forms.TabPage()
			Me.bunifuHSlider6 = New Bunifu.UI.WinForms.BunifuHSlider()
			Me.gunaButton12 = New Guna.UI.WinForms.GunaButton()
			Me.gunaButton11 = New Guna.UI.WinForms.GunaButton()
			Me.metroLabel22 = New MetroSuite.MetroLabel()
			Me.siticoneOSToggleSwith6 = New ns1.SiticoneOSToggleSwith()
			Me.siticoneCheckBox13 = New ns1.SiticoneCheckBox()
			Me.gunaLineTextBox12 = New Guna.UI.WinForms.GunaLineTextBox()
			Me.metroLabel7 = New MetroSuite.MetroLabel()
			Me.tabPage9 = New System.Windows.Forms.TabPage()
			Me.gunaLineTextBox16 = New Guna.UI.WinForms.GunaLineTextBox()
			Me.gunaButton16 = New Guna.UI.WinForms.GunaButton()
			Me.gunaButton15 = New Guna.UI.WinForms.GunaButton()
			Me.siticoneCheckBox21 = New ns1.SiticoneCheckBox()
			Me.siticoneCheckBox20 = New ns1.SiticoneCheckBox()
			Me.siticoneCheckBox19 = New ns1.SiticoneCheckBox()
			Me.siticoneCheckBox18 = New ns1.SiticoneCheckBox()
			Me.siticoneCheckBox17 = New ns1.SiticoneCheckBox()
			Me.siticoneCheckBox16 = New ns1.SiticoneCheckBox()
			Me.siticoneCheckBox15 = New ns1.SiticoneCheckBox()
			Me.siticoneCheckBox14 = New ns1.SiticoneCheckBox()
			Me.metroLabel26 = New MetroSuite.MetroLabel()
			Me.siticoneOSToggleSwith10 = New ns1.SiticoneOSToggleSwith()
			Me.metroLabel25 = New MetroSuite.MetroLabel()
			Me.siticoneOSToggleSwith9 = New ns1.SiticoneOSToggleSwith()
			Me.gunaLineTextBox15 = New Guna.UI.WinForms.GunaLineTextBox()
			Me.gunaLineTextBox14 = New Guna.UI.WinForms.GunaLineTextBox()
			Me.metroLabel9 = New MetroSuite.MetroLabel()
			Me.bunifuHSlider10 = New Bunifu.UI.WinForms.BunifuHSlider()
			Me.bunifuHSlider9 = New Bunifu.UI.WinForms.BunifuHSlider()
			Me.tabPage10 = New System.Windows.Forms.TabPage()
			Me.siticoneRadioButton9 = New ns1.SiticoneRadioButton()
			Me.siticoneRadioButton10 = New ns1.SiticoneRadioButton()
			Me.siticoneRadioButton11 = New ns1.SiticoneRadioButton()
			Me.siticoneCheckBox27 = New ns1.SiticoneCheckBox()
			Me.siticoneCheckBox22 = New ns1.SiticoneCheckBox()
			Me.gunaButton18 = New Guna.UI.WinForms.GunaButton()
			Me.gunaButton17 = New Guna.UI.WinForms.GunaButton()
			Me.metroLabel27 = New MetroSuite.MetroLabel()
			Me.siticoneOSToggleSwith11 = New ns1.SiticoneOSToggleSwith()
			Me.gunaTextBox3 = New Guna.UI.WinForms.GunaTextBox()
			Me.gunaLineTextBox19 = New Guna.UI.WinForms.GunaLineTextBox()
			Me.gunaLineTextBox18 = New Guna.UI.WinForms.GunaLineTextBox()
			Me.gunaLineTextBox17 = New Guna.UI.WinForms.GunaLineTextBox()
			Me.metroLabel10 = New MetroSuite.MetroLabel()
			Me.bunifuHSlider11 = New Bunifu.UI.WinForms.BunifuHSlider()
			Me.tabPage11 = New System.Windows.Forms.TabPage()
			Me.siticoneCheckBox28 = New ns1.SiticoneCheckBox()
			Me.metroLabel8 = New MetroSuite.MetroLabel()
			Me.gunaButton20 = New Guna.UI.WinForms.GunaButton()
			Me.gunaButton19 = New Guna.UI.WinForms.GunaButton()
			Me.metroLabel28 = New MetroSuite.MetroLabel()
			Me.siticoneOSToggleSwith12 = New ns1.SiticoneOSToggleSwith()
			Me.gunaTextBox4 = New Guna.UI.WinForms.GunaTextBox()
			Me.metroLabel11 = New MetroSuite.MetroLabel()
			Me.bunifuHSlider12 = New Bunifu.UI.WinForms.BunifuHSlider()
			Me.tabPage12 = New System.Windows.Forms.TabPage()
			Me.siticoneCheckBox32 = New ns1.SiticoneCheckBox()
			Me.siticoneCheckBox31 = New ns1.SiticoneCheckBox()
			Me.siticoneCheckBox30 = New ns1.SiticoneCheckBox()
			Me.siticoneComboBox1 = New ns1.SiticoneComboBox()
			Me.siticoneButton9 = New ns1.SiticoneButton()
			Me.siticoneCheckBox26 = New ns1.SiticoneCheckBox()
			Me.siticoneCheckBox25 = New ns1.SiticoneCheckBox()
			Me.siticoneCheckBox24 = New ns1.SiticoneCheckBox()
			Me.siticoneCheckBox10 = New ns1.SiticoneCheckBox()
			Me.siticoneCheckBox6 = New ns1.SiticoneCheckBox()
			Me.gunaLineTextBox13 = New Guna.UI.WinForms.GunaLineTextBox()
			Me.gunaTextBox5 = New Guna.UI.WinForms.GunaTextBox()
			Me.siticoneButton12 = New ns1.SiticoneButton()
			Me.siticoneComboBox2 = New ns1.SiticoneComboBox()
			Me.siticoneButton11 = New ns1.SiticoneButton()
			Me.siticoneButton8 = New ns1.SiticoneButton()
			Me.gunaLineTextBox22 = New Guna.UI.WinForms.GunaLineTextBox()
			Me.gunaLineTextBox21 = New Guna.UI.WinForms.GunaLineTextBox()
			Me.gunaLinkLabel1 = New Guna.UI.WinForms.GunaLinkLabel()
			Me.gunaLineTextBox20 = New Guna.UI.WinForms.GunaLineTextBox()
			Me.metroLabel12 = New MetroSuite.MetroLabel()
			Me.tabPage8 = New System.Windows.Forms.TabPage()
			Me.siticoneButton23 = New ns1.SiticoneButton()
			Me.siticoneButton22 = New ns1.SiticoneButton()
			Me.siticoneButton21 = New ns1.SiticoneButton()
			Me.pictureBox2 = New System.Windows.Forms.PictureBox()
			Me.siticoneButton20 = New ns1.SiticoneButton()
			Me.gunaLineTextBox29 = New Guna.UI.WinForms.GunaLineTextBox()
			Me.siticoneButton19 = New ns1.SiticoneButton()
			Me.gunaLineTextBox28 = New Guna.UI.WinForms.GunaLineTextBox()
			Me.siticoneButton18 = New ns1.SiticoneButton()
			Me.siticoneButton15 = New ns1.SiticoneButton()
			Me.siticoneButton16 = New ns1.SiticoneButton()
			Me.metroLabel33 = New MetroSuite.MetroLabel()
			Me.metroLabel34 = New MetroSuite.MetroLabel()
			Me.siticoneButton17 = New ns1.SiticoneButton()
			Me.gunaLineTextBox27 = New Guna.UI.WinForms.GunaLineTextBox()
			Me.siticoneButton14 = New ns1.SiticoneButton()
			Me.siticoneButton13 = New ns1.SiticoneButton()
			Me.metroLabel32 = New MetroSuite.MetroLabel()
			Me.metroLabel31 = New MetroSuite.MetroLabel()
			Me.siticoneButton10 = New ns1.SiticoneButton()
			Me.gunaLineTextBox24 = New Guna.UI.WinForms.GunaLineTextBox()
			Me.gunaLineTextBox25 = New Guna.UI.WinForms.GunaLineTextBox()
			Me.metroLabel29 = New MetroSuite.MetroLabel()
			Me.tabPage13 = New System.Windows.Forms.TabPage()
			Me.metroLabel24 = New MetroSuite.MetroLabel()
			Me.openFileDialog3 = New System.Windows.Forms.OpenFileDialog()
			Me.openFileDialog4 = New System.Windows.Forms.OpenFileDialog()
			Me.saveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
			Me.saveFileDialog2 = New System.Windows.Forms.SaveFileDialog()
			Me.openFileDialog5 = New System.Windows.Forms.OpenFileDialog()
			Me.firefoxMainTabControl1.SuspendLayout()
			Me.tabPage1.SuspendLayout()
			DirectCast(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.tabPage2.SuspendLayout()
			Me.tabPage3.SuspendLayout()
			Me.tabPage4.SuspendLayout()
			Me.tabPage5.SuspendLayout()
			Me.tabPage6.SuspendLayout()
			Me.tabPage7.SuspendLayout()
			Me.tabPage9.SuspendLayout()
			Me.tabPage10.SuspendLayout()
			Me.tabPage11.SuspendLayout()
			Me.tabPage12.SuspendLayout()
			Me.tabPage8.SuspendLayout()
			DirectCast(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.tabPage13.SuspendLayout()
			Me.SuspendLayout()
			' 
			' gunaControlBox1
			' 
			Me.gunaControlBox1.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.gunaControlBox1.Animated = True
			Me.gunaControlBox1.AnimationHoverSpeed = 0.07F
			Me.gunaControlBox1.AnimationSpeed = 0.03F
			Me.gunaControlBox1.IconColor = System.Drawing.Color.White
			Me.gunaControlBox1.IconSize = 15F
			Me.gunaControlBox1.Location = New System.Drawing.Point(1072, 7)
			Me.gunaControlBox1.Name = "gunaControlBox1"
			Me.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.Red
			Me.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White
			Me.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black
			Me.gunaControlBox1.Size = New System.Drawing.Size(45, 29)
			Me.gunaControlBox1.TabIndex = 0
			' 
			' gunaControlBox2
			' 
			Me.gunaControlBox2.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.gunaControlBox2.Animated = True
			Me.gunaControlBox2.AnimationHoverSpeed = 0.07F
			Me.gunaControlBox2.AnimationSpeed = 0.03F
			Me.gunaControlBox2.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MaximizeBox
			Me.gunaControlBox2.IconColor = System.Drawing.Color.White
			Me.gunaControlBox2.IconSize = 15F
			Me.gunaControlBox2.Location = New System.Drawing.Point(1021, 7)
			Me.gunaControlBox2.Name = "gunaControlBox2"
			Me.gunaControlBox2.OnHoverBackColor = System.Drawing.Color.Red
			Me.gunaControlBox2.OnHoverIconColor = System.Drawing.Color.White
			Me.gunaControlBox2.OnPressedColor = System.Drawing.Color.Black
			Me.gunaControlBox2.Size = New System.Drawing.Size(45, 29)
			Me.gunaControlBox2.TabIndex = 1
			' 
			' gunaControlBox3
			' 
			Me.gunaControlBox3.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.gunaControlBox3.Animated = True
			Me.gunaControlBox3.AnimationHoverSpeed = 0.07F
			Me.gunaControlBox3.AnimationSpeed = 0.03F
			Me.gunaControlBox3.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox
			Me.gunaControlBox3.IconColor = System.Drawing.Color.White
			Me.gunaControlBox3.IconSize = 15F
			Me.gunaControlBox3.Location = New System.Drawing.Point(970, 7)
			Me.gunaControlBox3.Name = "gunaControlBox3"
			Me.gunaControlBox3.OnHoverBackColor = System.Drawing.Color.Red
			Me.gunaControlBox3.OnHoverIconColor = System.Drawing.Color.White
			Me.gunaControlBox3.OnPressedColor = System.Drawing.Color.Black
			Me.gunaControlBox3.Size = New System.Drawing.Size(45, 29)
			Me.gunaControlBox3.TabIndex = 2
			' 
			' openFileDialog1
			' 
			Me.openFileDialog1.Filter = "Text file (*.txt)|*.txt"
			Me.openFileDialog1.Multiselect = True
			Me.openFileDialog1.Title = "Load tokens from file"
			' 
			' openFileDialog2
			' 
			Me.openFileDialog2.Filter = "Text file (*.txt)|*.txt"
			Me.openFileDialog2.Multiselect = True
			Me.openFileDialog2.Title = "Load proxies from file"
			' 
			' firefoxMainTabControl1
			' 
			Me.firefoxMainTabControl1.Alignment = System.Windows.Forms.TabAlignment.Left
			Me.firefoxMainTabControl1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.firefoxMainTabControl1.Controls.Add(Me.tabPage1)
			Me.firefoxMainTabControl1.Controls.Add(Me.tabPage2)
			Me.firefoxMainTabControl1.Controls.Add(Me.tabPage3)
			Me.firefoxMainTabControl1.Controls.Add(Me.tabPage4)
			Me.firefoxMainTabControl1.Controls.Add(Me.tabPage5)
			Me.firefoxMainTabControl1.Controls.Add(Me.tabPage6)
			Me.firefoxMainTabControl1.Controls.Add(Me.tabPage7)
			Me.firefoxMainTabControl1.Controls.Add(Me.tabPage9)
			Me.firefoxMainTabControl1.Controls.Add(Me.tabPage10)
			Me.firefoxMainTabControl1.Controls.Add(Me.tabPage11)
			Me.firefoxMainTabControl1.Controls.Add(Me.tabPage12)
			Me.firefoxMainTabControl1.Controls.Add(Me.tabPage8)
			Me.firefoxMainTabControl1.Controls.Add(Me.tabPage13)
			Me.firefoxMainTabControl1.ItemSize = New System.Drawing.Size(43, 180)
			Me.firefoxMainTabControl1.Location = New System.Drawing.Point(1, 42)
			Me.firefoxMainTabControl1.Multiline = True
			Me.firefoxMainTabControl1.Name = "firefoxMainTabControl1"
			Me.firefoxMainTabControl1.SelectedIndex = 0
			Me.firefoxMainTabControl1.Size = New System.Drawing.Size(1119, 589)
			Me.firefoxMainTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
			Me.firefoxMainTabControl1.TabIndex = 3
			' 
			' tabPage1
			' 
			Me.tabPage1.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(40)))), (CInt((CByte(40)))), (CInt((CByte(40)))))
			Me.tabPage1.Controls.Add(Me.siticoneCheckBox37)
			Me.tabPage1.Controls.Add(Me.gunaLineTextBox23)
			Me.tabPage1.Controls.Add(Me.siticoneCheckBox23)
			Me.tabPage1.Controls.Add(Me.siticoneButton6)
			Me.tabPage1.Controls.Add(Me.siticoneButton5)
			Me.tabPage1.Controls.Add(Me.pictureBox1)
			Me.tabPage1.Controls.Add(Me.siticoneButton3)
			Me.tabPage1.Controls.Add(Me.metroLabel15)
			Me.tabPage1.Controls.Add(Me.metroLabel16)
			Me.tabPage1.Controls.Add(Me.siticoneButton4)
			Me.tabPage1.Controls.Add(Me.siticoneButton2)
			Me.tabPage1.Controls.Add(Me.metroLabel14)
			Me.tabPage1.Controls.Add(Me.metroLabel13)
			Me.tabPage1.Controls.Add(Me.siticoneButton1)
			Me.tabPage1.Controls.Add(Me.metroLabel1)
			Me.tabPage1.Font = New System.Drawing.Font("Segoe UI", 10F)
			Me.tabPage1.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(153)))), (CInt((CByte(153)))), (CInt((CByte(153)))))
			Me.tabPage1.Location = New System.Drawing.Point(184, 4)
			Me.tabPage1.Name = "tabPage1"
			Me.tabPage1.Padding = New System.Windows.Forms.Padding(3)
			Me.tabPage1.Size = New System.Drawing.Size(931, 581)
			Me.tabPage1.TabIndex = 0
			Me.tabPage1.Text = "Homepage"
			' 
			' siticoneCheckBox37
			' 
			Me.siticoneCheckBox37.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.siticoneCheckBox37.AutoSize = True
			Me.siticoneCheckBox37.CheckedState.BorderColor = System.Drawing.Color.Red
			Me.siticoneCheckBox37.CheckedState.BorderRadius = 2
			Me.siticoneCheckBox37.CheckedState.BorderThickness = 0
			Me.siticoneCheckBox37.CheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.siticoneCheckBox37.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.siticoneCheckBox37.Location = New System.Drawing.Point(396, 317)
			Me.siticoneCheckBox37.Name = "siticoneCheckBox37"
			Me.siticoneCheckBox37.Size = New System.Drawing.Size(145, 17)
			Me.siticoneCheckBox37.TabIndex = 53
			Me.siticoneCheckBox37.Text = "Limit number of tokens"
			Me.siticoneCheckBox37.UncheckedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneCheckBox37.UncheckedState.BorderRadius = 2
			Me.siticoneCheckBox37.UncheckedState.BorderThickness = 0
			Me.siticoneCheckBox37.UncheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneCheckBox37.UseVisualStyleBackColor = True
			' 
			' gunaLineTextBox23
			' 
			Me.gunaLineTextBox23.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.gunaLineTextBox23.Animated = True
			Me.gunaLineTextBox23.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(40)))), (CInt((CByte(40)))), (CInt((CByte(40)))))
			Me.gunaLineTextBox23.Cursor = System.Windows.Forms.Cursors.IBeam
			Me.gunaLineTextBox23.FocusedLineColor = System.Drawing.Color.Red
			Me.gunaLineTextBox23.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.gunaLineTextBox23.LineColor = System.Drawing.Color.Gainsboro
			Me.gunaLineTextBox23.LineSize = 1
			Me.gunaLineTextBox23.Location = New System.Drawing.Point(383, 281)
			Me.gunaLineTextBox23.MaxLength = 2147483647
			Me.gunaLineTextBox23.Name = "gunaLineTextBox23"
			Me.gunaLineTextBox23.PasswordChar = ControlChars.NullChar
			Me.gunaLineTextBox23.Size = New System.Drawing.Size(167, 26)
			Me.gunaLineTextBox23.TabIndex = 52
			Me.gunaLineTextBox23.Text = "0"
			Me.gunaLineTextBox23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
			Me.gunaLineTextBox23.TextOffsetX = 0
			' 
			' siticoneCheckBox23
			' 
			Me.siticoneCheckBox23.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.siticoneCheckBox23.AutoSize = True
			Me.siticoneCheckBox23.CheckedState.BorderColor = System.Drawing.Color.Red
			Me.siticoneCheckBox23.CheckedState.BorderRadius = 2
			Me.siticoneCheckBox23.CheckedState.BorderThickness = 0
			Me.siticoneCheckBox23.CheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.siticoneCheckBox23.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.siticoneCheckBox23.Location = New System.Drawing.Point(425, 182)
			Me.siticoneCheckBox23.Name = "siticoneCheckBox23"
			Me.siticoneCheckBox23.Size = New System.Drawing.Size(85, 17)
			Me.siticoneCheckBox23.TabIndex = 14
			Me.siticoneCheckBox23.Text = "Use proxies"
			Me.siticoneCheckBox23.UncheckedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneCheckBox23.UncheckedState.BorderRadius = 2
			Me.siticoneCheckBox23.UncheckedState.BorderThickness = 0
			Me.siticoneCheckBox23.UncheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneCheckBox23.UseVisualStyleBackColor = True
			' 
			' siticoneButton6
			' 
			Me.siticoneButton6.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.siticoneButton6.BorderRadius = 15
			Me.siticoneButton6.CheckedState.Parent = Me.siticoneButton6
			Me.siticoneButton6.CustomImages.Parent = Me.siticoneButton6
			Me.siticoneButton6.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.siticoneButton6.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.siticoneButton6.ForeColor = System.Drawing.Color.White
			Me.siticoneButton6.HoveredState.Parent = Me.siticoneButton6
			Me.siticoneButton6.Location = New System.Drawing.Point(730, 281)
			Me.siticoneButton6.Name = "siticoneButton6"
			Me.siticoneButton6.ShadowDecoration.Parent = Me.siticoneButton6
			Me.siticoneButton6.Size = New System.Drawing.Size(180, 45)
			Me.siticoneButton6.TabIndex = 13
			Me.siticoneButton6.Text = "Load Proxies"
'			Me.siticoneButton6.Click += New System.EventHandler(Me.siticoneButton6_Click)
			' 
			' siticoneButton5
			' 
			Me.siticoneButton5.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.siticoneButton5.BorderRadius = 15
			Me.siticoneButton5.CheckedState.Parent = Me.siticoneButton5
			Me.siticoneButton5.CustomImages.Parent = Me.siticoneButton5
			Me.siticoneButton5.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.siticoneButton5.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.siticoneButton5.ForeColor = System.Drawing.Color.White
			Me.siticoneButton5.HoveredState.Parent = Me.siticoneButton5
			Me.siticoneButton5.Location = New System.Drawing.Point(19, 281)
			Me.siticoneButton5.Name = "siticoneButton5"
			Me.siticoneButton5.ShadowDecoration.Parent = Me.siticoneButton5
			Me.siticoneButton5.Size = New System.Drawing.Size(180, 45)
			Me.siticoneButton5.TabIndex = 12
			Me.siticoneButton5.Text = "Load Tokens"
'			Me.siticoneButton5.Click += New System.EventHandler(Me.siticoneButton5_Click)
			' 
			' pictureBox1
			' 
			Me.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.pictureBox1.BackgroundImage = (DirectCast(resources.GetObject("pictureBox1.BackgroundImage"), System.Drawing.Image))
			Me.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
			Me.pictureBox1.Location = New System.Drawing.Point(401, 46)
			Me.pictureBox1.Name = "pictureBox1"
			Me.pictureBox1.Size = New System.Drawing.Size(128, 128)
			Me.pictureBox1.TabIndex = 11
			Me.pictureBox1.TabStop = False
			' 
			' siticoneButton3
			' 
			Me.siticoneButton3.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.siticoneButton3.BorderRadius = 5
			Me.siticoneButton3.CheckedState.Parent = Me.siticoneButton3
			Me.siticoneButton3.CustomImages.Parent = Me.siticoneButton3
			Me.siticoneButton3.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.siticoneButton3.ForeColor = System.Drawing.Color.White
			Me.siticoneButton3.HoveredState.Parent = Me.siticoneButton3
			Me.siticoneButton3.Location = New System.Drawing.Point(730, 148)
			Me.siticoneButton3.Name = "siticoneButton3"
			Me.siticoneButton3.ShadowDecoration.Parent = Me.siticoneButton3
			Me.siticoneButton3.Size = New System.Drawing.Size(180, 45)
			Me.siticoneButton3.TabIndex = 8
			Me.siticoneButton3.Text = "Remove dead proxies"
'			Me.siticoneButton3.Click += New System.EventHandler(Me.siticoneButton3_Click)
			' 
			' metroLabel15
			' 
			Me.metroLabel15.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.metroLabel15.BackColor = System.Drawing.Color.Transparent
			Me.metroLabel15.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.metroLabel15.Location = New System.Drawing.Point(727, 64)
			Me.metroLabel15.Name = "metroLabel15"
			Me.metroLabel15.Size = New System.Drawing.Size(183, 19)
			Me.metroLabel15.TabIndex = 7
			Me.metroLabel15.Text = "0"
			Me.metroLabel15.TextAlign = System.Drawing.ContentAlignment.TopCenter
			' 
			' metroLabel16
			' 
			Me.metroLabel16.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.metroLabel16.BackColor = System.Drawing.Color.Transparent
			Me.metroLabel16.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.metroLabel16.Location = New System.Drawing.Point(727, 41)
			Me.metroLabel16.Name = "metroLabel16"
			Me.metroLabel16.Size = New System.Drawing.Size(183, 19)
			Me.metroLabel16.TabIndex = 6
			Me.metroLabel16.Text = "Proxies"
			Me.metroLabel16.TextAlign = System.Drawing.ContentAlignment.TopCenter
			' 
			' siticoneButton4
			' 
			Me.siticoneButton4.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.siticoneButton4.BorderRadius = 5
			Me.siticoneButton4.CheckedState.Parent = Me.siticoneButton4
			Me.siticoneButton4.CustomImages.Parent = Me.siticoneButton4
			Me.siticoneButton4.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.siticoneButton4.ForeColor = System.Drawing.Color.White
			Me.siticoneButton4.HoveredState.Parent = Me.siticoneButton4
			Me.siticoneButton4.Location = New System.Drawing.Point(730, 97)
			Me.siticoneButton4.Name = "siticoneButton4"
			Me.siticoneButton4.ShadowDecoration.Parent = Me.siticoneButton4
			Me.siticoneButton4.Size = New System.Drawing.Size(180, 45)
			Me.siticoneButton4.TabIndex = 5
			Me.siticoneButton4.Text = "Reset Proxies"
'			Me.siticoneButton4.Click += New System.EventHandler(Me.siticoneButton4_Click)
			' 
			' siticoneButton2
			' 
			Me.siticoneButton2.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.siticoneButton2.BorderRadius = 5
			Me.siticoneButton2.CheckedState.Parent = Me.siticoneButton2
			Me.siticoneButton2.CustomImages.Parent = Me.siticoneButton2
			Me.siticoneButton2.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.siticoneButton2.ForeColor = System.Drawing.Color.White
			Me.siticoneButton2.HoveredState.Parent = Me.siticoneButton2
			Me.siticoneButton2.Location = New System.Drawing.Point(19, 148)
			Me.siticoneButton2.Name = "siticoneButton2"
			Me.siticoneButton2.ShadowDecoration.Parent = Me.siticoneButton2
			Me.siticoneButton2.Size = New System.Drawing.Size(180, 45)
			Me.siticoneButton2.TabIndex = 4
			Me.siticoneButton2.Text = "Remove dead tokens"
'			Me.siticoneButton2.Click += New System.EventHandler(Me.siticoneButton2_Click)
			' 
			' metroLabel14
			' 
			Me.metroLabel14.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.metroLabel14.BackColor = System.Drawing.Color.Transparent
			Me.metroLabel14.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.metroLabel14.Location = New System.Drawing.Point(16, 64)
			Me.metroLabel14.Name = "metroLabel14"
			Me.metroLabel14.Size = New System.Drawing.Size(183, 19)
			Me.metroLabel14.TabIndex = 3
			Me.metroLabel14.Text = "0"
			Me.metroLabel14.TextAlign = System.Drawing.ContentAlignment.TopCenter
			' 
			' metroLabel13
			' 
			Me.metroLabel13.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.metroLabel13.BackColor = System.Drawing.Color.Transparent
			Me.metroLabel13.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.metroLabel13.Location = New System.Drawing.Point(16, 41)
			Me.metroLabel13.Name = "metroLabel13"
			Me.metroLabel13.Size = New System.Drawing.Size(183, 19)
			Me.metroLabel13.TabIndex = 2
			Me.metroLabel13.Text = "Tokens"
			Me.metroLabel13.TextAlign = System.Drawing.ContentAlignment.TopCenter
			' 
			' siticoneButton1
			' 
			Me.siticoneButton1.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.siticoneButton1.BorderRadius = 5
			Me.siticoneButton1.CheckedState.Parent = Me.siticoneButton1
			Me.siticoneButton1.CustomImages.Parent = Me.siticoneButton1
			Me.siticoneButton1.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.siticoneButton1.ForeColor = System.Drawing.Color.White
			Me.siticoneButton1.HoveredState.Parent = Me.siticoneButton1
			Me.siticoneButton1.Location = New System.Drawing.Point(19, 97)
			Me.siticoneButton1.Name = "siticoneButton1"
			Me.siticoneButton1.ShadowDecoration.Parent = Me.siticoneButton1
			Me.siticoneButton1.Size = New System.Drawing.Size(180, 45)
			Me.siticoneButton1.TabIndex = 1
			Me.siticoneButton1.Text = "Reset Tokens"
'			Me.siticoneButton1.Click += New System.EventHandler(Me.siticoneButton1_Click)
			' 
			' metroLabel1
			' 
			Me.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.metroLabel1.BackColor = System.Drawing.Color.Transparent
			Me.metroLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.metroLabel1.Location = New System.Drawing.Point(-1, 8)
			Me.metroLabel1.Name = "metroLabel1"
			Me.metroLabel1.Size = New System.Drawing.Size(931, 23)
			Me.metroLabel1.TabIndex = 0
			Me.metroLabel1.Text = "Homepage"
			Me.metroLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter
			' 
			' tabPage2
			' 
			Me.tabPage2.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(40)))), (CInt((CByte(40)))), (CInt((CByte(40)))))
			Me.tabPage2.Controls.Add(Me.siticoneCheckBox36)
			Me.tabPage2.Controls.Add(Me.siticoneCheckBox33)
			Me.tabPage2.Controls.Add(Me.gunaButton2)
			Me.tabPage2.Controls.Add(Me.gunaButton1)
			Me.tabPage2.Controls.Add(Me.metroLabel17)
			Me.tabPage2.Controls.Add(Me.siticoneOSToggleSwith1)
			Me.tabPage2.Controls.Add(Me.siticoneCheckBox4)
			Me.tabPage2.Controls.Add(Me.siticoneCheckBox3)
			Me.tabPage2.Controls.Add(Me.siticoneCheckBox2)
			Me.tabPage2.Controls.Add(Me.siticoneCheckBox1)
			Me.tabPage2.Controls.Add(Me.gunaLineTextBox3)
			Me.tabPage2.Controls.Add(Me.gunaLineTextBox2)
			Me.tabPage2.Controls.Add(Me.gunaLineTextBox1)
			Me.tabPage2.Controls.Add(Me.metroLabel2)
			Me.tabPage2.Controls.Add(Me.bunifuHSlider1)
			Me.tabPage2.Font = New System.Drawing.Font("Segoe UI", 10F)
			Me.tabPage2.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(153)))), (CInt((CByte(153)))), (CInt((CByte(153)))))
			Me.tabPage2.Location = New System.Drawing.Point(184, 4)
			Me.tabPage2.Name = "tabPage2"
			Me.tabPage2.Padding = New System.Windows.Forms.Padding(3)
			Me.tabPage2.Size = New System.Drawing.Size(931, 581)
			Me.tabPage2.TabIndex = 1
			Me.tabPage2.Text = "Guild Manager"
			' 
			' siticoneCheckBox36
			' 
			Me.siticoneCheckBox36.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.siticoneCheckBox36.AutoSize = True
			Me.siticoneCheckBox36.CheckedState.BorderColor = System.Drawing.Color.Red
			Me.siticoneCheckBox36.CheckedState.BorderRadius = 2
			Me.siticoneCheckBox36.CheckedState.BorderThickness = 0
			Me.siticoneCheckBox36.CheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.siticoneCheckBox36.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.siticoneCheckBox36.Location = New System.Drawing.Point(144, 354)
			Me.siticoneCheckBox36.Name = "siticoneCheckBox36"
			Me.siticoneCheckBox36.Size = New System.Drawing.Size(298, 17)
			Me.siticoneCheckBox36.TabIndex = 16
			Me.siticoneCheckBox36.Text = "Automatically identify captcha bot challenge channel"
			Me.siticoneCheckBox36.UncheckedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneCheckBox36.UncheckedState.BorderRadius = 2
			Me.siticoneCheckBox36.UncheckedState.BorderThickness = 0
			Me.siticoneCheckBox36.UncheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneCheckBox36.UseVisualStyleBackColor = True
			Me.siticoneCheckBox36.Visible = False
			' 
			' siticoneCheckBox33
			' 
			Me.siticoneCheckBox33.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.siticoneCheckBox33.AutoSize = True
			Me.siticoneCheckBox33.CheckedState.BorderColor = System.Drawing.Color.Red
			Me.siticoneCheckBox33.CheckedState.BorderRadius = 2
			Me.siticoneCheckBox33.CheckedState.BorderThickness = 0
			Me.siticoneCheckBox33.CheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.siticoneCheckBox33.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.siticoneCheckBox33.Location = New System.Drawing.Point(144, 331)
			Me.siticoneCheckBox33.Name = "siticoneCheckBox33"
			Me.siticoneCheckBox33.Size = New System.Drawing.Size(82, 17)
			Me.siticoneCheckBox33.TabIndex = 15
			Me.siticoneCheckBox33.Text = "Raid Mode"
			Me.siticoneCheckBox33.UncheckedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneCheckBox33.UncheckedState.BorderRadius = 2
			Me.siticoneCheckBox33.UncheckedState.BorderThickness = 0
			Me.siticoneCheckBox33.UncheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneCheckBox33.UseVisualStyleBackColor = True
'			Me.siticoneCheckBox33.CheckedChanged += New System.EventHandler(Me.siticoneCheckBox33_CheckedChanged)
			' 
			' gunaButton2
			' 
			Me.gunaButton2.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.gunaButton2.Animated = True
			Me.gunaButton2.AnimationHoverSpeed = 0.07F
			Me.gunaButton2.AnimationSpeed = 0.03F
			Me.gunaButton2.BackColor = System.Drawing.Color.Transparent
			Me.gunaButton2.BaseColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.gunaButton2.BorderColor = System.Drawing.Color.Transparent
			Me.gunaButton2.DialogResult = System.Windows.Forms.DialogResult.None
			Me.gunaButton2.FocusedColor = System.Drawing.Color.Empty
			Me.gunaButton2.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.gunaButton2.ForeColor = System.Drawing.Color.White
			Me.gunaButton2.Image = Nothing
			Me.gunaButton2.ImageSize = New System.Drawing.Size(24, 24)
			Me.gunaButton2.Location = New System.Drawing.Point(467, 474)
			Me.gunaButton2.Name = "gunaButton2"
			Me.gunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black
			Me.gunaButton2.OnHoverForeColor = System.Drawing.Color.White
			Me.gunaButton2.OnHoverImage = Nothing
			Me.gunaButton2.OnPressedColor = System.Drawing.Color.Black
			Me.gunaButton2.Size = New System.Drawing.Size(317, 42)
			Me.gunaButton2.TabIndex = 13
			Me.gunaButton2.Text = "Leave guild"
			Me.gunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
'			Me.gunaButton2.Click += New System.EventHandler(Me.gunaButton2_Click)
			' 
			' gunaButton1
			' 
			Me.gunaButton1.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.gunaButton1.Animated = True
			Me.gunaButton1.AnimationHoverSpeed = 0.07F
			Me.gunaButton1.AnimationSpeed = 0.03F
			Me.gunaButton1.BackColor = System.Drawing.Color.Transparent
			Me.gunaButton1.BaseColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.gunaButton1.BorderColor = System.Drawing.Color.Transparent
			Me.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None
			Me.gunaButton1.FocusedColor = System.Drawing.Color.Empty
			Me.gunaButton1.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.gunaButton1.ForeColor = System.Drawing.Color.White
			Me.gunaButton1.Image = Nothing
			Me.gunaButton1.ImageSize = New System.Drawing.Size(24, 24)
			Me.gunaButton1.Location = New System.Drawing.Point(144, 474)
			Me.gunaButton1.Name = "gunaButton1"
			Me.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black
			Me.gunaButton1.OnHoverForeColor = System.Drawing.Color.White
			Me.gunaButton1.OnHoverImage = Nothing
			Me.gunaButton1.OnPressedColor = System.Drawing.Color.Black
			Me.gunaButton1.Size = New System.Drawing.Size(317, 42)
			Me.gunaButton1.TabIndex = 12
			Me.gunaButton1.Text = "Join guild"
			Me.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
'			Me.gunaButton1.Click += New System.EventHandler(Me.gunaButton1_Click)
			' 
			' metroLabel17
			' 
			Me.metroLabel17.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.metroLabel17.AutoSize = True
			Me.metroLabel17.BackColor = System.Drawing.Color.Transparent
			Me.metroLabel17.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.metroLabel17.Location = New System.Drawing.Point(721, 239)
			Me.metroLabel17.Name = "metroLabel17"
			Me.metroLabel17.Size = New System.Drawing.Size(64, 15)
			Me.metroLabel17.TabIndex = 11
			Me.metroLabel17.Text = "Delay: 0ms"
			Me.metroLabel17.TextAlign = System.Drawing.ContentAlignment.TopRight
			' 
			' siticoneOSToggleSwith1
			' 
			Me.siticoneOSToggleSwith1.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.siticoneOSToggleSwith1.CheckedFillColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.siticoneOSToggleSwith1.Location = New System.Drawing.Point(681, 236)
			Me.siticoneOSToggleSwith1.Name = "siticoneOSToggleSwith1"
			Me.siticoneOSToggleSwith1.Size = New System.Drawing.Size(38, 22)
			Me.siticoneOSToggleSwith1.TabIndex = 10
			' 
			' siticoneCheckBox4
			' 
			Me.siticoneCheckBox4.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.siticoneCheckBox4.AutoSize = True
			Me.siticoneCheckBox4.CheckedState.BorderColor = System.Drawing.Color.Red
			Me.siticoneCheckBox4.CheckedState.BorderRadius = 2
			Me.siticoneCheckBox4.CheckedState.BorderThickness = 0
			Me.siticoneCheckBox4.CheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.siticoneCheckBox4.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.siticoneCheckBox4.Location = New System.Drawing.Point(144, 308)
			Me.siticoneCheckBox4.Name = "siticoneCheckBox4"
			Me.siticoneCheckBox4.Size = New System.Drawing.Size(92, 17)
			Me.siticoneCheckBox4.TabIndex = 8
			Me.siticoneCheckBox4.Text = "Group Mode"
			Me.siticoneCheckBox4.UncheckedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneCheckBox4.UncheckedState.BorderRadius = 2
			Me.siticoneCheckBox4.UncheckedState.BorderThickness = 0
			Me.siticoneCheckBox4.UncheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneCheckBox4.UseVisualStyleBackColor = True
'			Me.siticoneCheckBox4.CheckedChanged += New System.EventHandler(Me.siticoneCheckBox4_CheckedChanged)
			' 
			' siticoneCheckBox3
			' 
			Me.siticoneCheckBox3.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.siticoneCheckBox3.AutoSize = True
			Me.siticoneCheckBox3.CheckedState.BorderColor = System.Drawing.Color.Red
			Me.siticoneCheckBox3.CheckedState.BorderRadius = 2
			Me.siticoneCheckBox3.CheckedState.BorderThickness = 0
			Me.siticoneCheckBox3.CheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.siticoneCheckBox3.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.siticoneCheckBox3.Location = New System.Drawing.Point(144, 285)
			Me.siticoneCheckBox3.Name = "siticoneCheckBox3"
			Me.siticoneCheckBox3.Size = New System.Drawing.Size(148, 17)
			Me.siticoneCheckBox3.TabIndex = 7
			Me.siticoneCheckBox3.Text = "Bypass Text Captcha Bot"
			Me.siticoneCheckBox3.UncheckedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneCheckBox3.UncheckedState.BorderRadius = 2
			Me.siticoneCheckBox3.UncheckedState.BorderThickness = 0
			Me.siticoneCheckBox3.UncheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneCheckBox3.UseVisualStyleBackColor = True
'			Me.siticoneCheckBox3.CheckedChanged += New System.EventHandler(Me.siticoneCheckBox3_CheckedChanged)
			' 
			' siticoneCheckBox2
			' 
			Me.siticoneCheckBox2.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.siticoneCheckBox2.AutoSize = True
			Me.siticoneCheckBox2.CheckedState.BorderColor = System.Drawing.Color.Red
			Me.siticoneCheckBox2.CheckedState.BorderRadius = 2
			Me.siticoneCheckBox2.CheckedState.BorderThickness = 0
			Me.siticoneCheckBox2.CheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.siticoneCheckBox2.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.siticoneCheckBox2.Location = New System.Drawing.Point(144, 262)
			Me.siticoneCheckBox2.Name = "siticoneCheckBox2"
			Me.siticoneCheckBox2.Size = New System.Drawing.Size(168, 17)
			Me.siticoneCheckBox2.TabIndex = 6
			Me.siticoneCheckBox2.Text = "Bypass Reaction verification"
			Me.siticoneCheckBox2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneCheckBox2.UncheckedState.BorderRadius = 2
			Me.siticoneCheckBox2.UncheckedState.BorderThickness = 0
			Me.siticoneCheckBox2.UncheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneCheckBox2.UseVisualStyleBackColor = True
'			Me.siticoneCheckBox2.CheckedChanged += New System.EventHandler(Me.siticoneCheckBox2_CheckedChanged)
			' 
			' siticoneCheckBox1
			' 
			Me.siticoneCheckBox1.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.siticoneCheckBox1.AutoSize = True
			Me.siticoneCheckBox1.CheckedState.BorderColor = System.Drawing.Color.Red
			Me.siticoneCheckBox1.CheckedState.BorderRadius = 2
			Me.siticoneCheckBox1.CheckedState.BorderThickness = 0
			Me.siticoneCheckBox1.CheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.siticoneCheckBox1.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.siticoneCheckBox1.Location = New System.Drawing.Point(144, 239)
			Me.siticoneCheckBox1.Name = "siticoneCheckBox1"
			Me.siticoneCheckBox1.Size = New System.Drawing.Size(254, 17)
			Me.siticoneCheckBox1.TabIndex = 5
			Me.siticoneCheckBox1.Text = "Bypass Discord Community Rules verification"
			Me.siticoneCheckBox1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneCheckBox1.UncheckedState.BorderRadius = 2
			Me.siticoneCheckBox1.UncheckedState.BorderThickness = 0
			Me.siticoneCheckBox1.UncheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneCheckBox1.UseVisualStyleBackColor = True
'			Me.siticoneCheckBox1.CheckedChanged += New System.EventHandler(Me.siticoneCheckBox1_CheckedChanged)
			' 
			' gunaLineTextBox3
			' 
			Me.gunaLineTextBox3.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.gunaLineTextBox3.Animated = True
			Me.gunaLineTextBox3.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(40)))), (CInt((CByte(40)))), (CInt((CByte(40)))))
			Me.gunaLineTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam
			Me.gunaLineTextBox3.FocusedLineColor = System.Drawing.Color.Red
			Me.gunaLineTextBox3.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.gunaLineTextBox3.LineColor = System.Drawing.Color.Gainsboro
			Me.gunaLineTextBox3.LineSize = 1
			Me.gunaLineTextBox3.Location = New System.Drawing.Point(144, 192)
			Me.gunaLineTextBox3.MaxLength = 2147483647
			Me.gunaLineTextBox3.Name = "gunaLineTextBox3"
			Me.gunaLineTextBox3.PasswordChar = ControlChars.NullChar
			Me.gunaLineTextBox3.Size = New System.Drawing.Size(641, 26)
			Me.gunaLineTextBox3.TabIndex = 4
			Me.gunaLineTextBox3.Text = "Insert the ID of the channel where to send the captcha result here."
			Me.gunaLineTextBox3.TextOffsetX = 0
			' 
			' gunaLineTextBox2
			' 
			Me.gunaLineTextBox2.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.gunaLineTextBox2.Animated = True
			Me.gunaLineTextBox2.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(40)))), (CInt((CByte(40)))), (CInt((CByte(40)))))
			Me.gunaLineTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
			Me.gunaLineTextBox2.FocusedLineColor = System.Drawing.Color.Red
			Me.gunaLineTextBox2.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.gunaLineTextBox2.LineColor = System.Drawing.Color.Gainsboro
			Me.gunaLineTextBox2.LineSize = 1
			Me.gunaLineTextBox2.Location = New System.Drawing.Point(144, 160)
			Me.gunaLineTextBox2.MaxLength = 2147483647
			Me.gunaLineTextBox2.Name = "gunaLineTextBox2"
			Me.gunaLineTextBox2.PasswordChar = ControlChars.NullChar
			Me.gunaLineTextBox2.Size = New System.Drawing.Size(641, 26)
			Me.gunaLineTextBox2.TabIndex = 3
			Me.gunaLineTextBox2.Text = "Insert the captcha bot ID to bypass here."
			Me.gunaLineTextBox2.TextOffsetX = 0
			' 
			' gunaLineTextBox1
			' 
			Me.gunaLineTextBox1.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.gunaLineTextBox1.Animated = True
			Me.gunaLineTextBox1.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(40)))), (CInt((CByte(40)))), (CInt((CByte(40)))))
			Me.gunaLineTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
			Me.gunaLineTextBox1.FocusedLineColor = System.Drawing.Color.Red
			Me.gunaLineTextBox1.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.gunaLineTextBox1.LineColor = System.Drawing.Color.Gainsboro
			Me.gunaLineTextBox1.LineSize = 1
			Me.gunaLineTextBox1.Location = New System.Drawing.Point(144, 128)
			Me.gunaLineTextBox1.MaxLength = 2147483647
			Me.gunaLineTextBox1.Name = "gunaLineTextBox1"
			Me.gunaLineTextBox1.PasswordChar = ControlChars.NullChar
			Me.gunaLineTextBox1.Size = New System.Drawing.Size(641, 26)
			Me.gunaLineTextBox1.TabIndex = 2
			Me.gunaLineTextBox1.Text = "Insert the guild invite link / code / ID here."
			Me.gunaLineTextBox1.TextOffsetX = 0
			' 
			' metroLabel2
			' 
			Me.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.metroLabel2.BackColor = System.Drawing.Color.Transparent
			Me.metroLabel2.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.metroLabel2.Location = New System.Drawing.Point(-1, 8)
			Me.metroLabel2.Name = "metroLabel2"
			Me.metroLabel2.Size = New System.Drawing.Size(931, 23)
			Me.metroLabel2.TabIndex = 1
			Me.metroLabel2.Text = "Guild Manager"
			Me.metroLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter
			' 
			' bunifuHSlider1
			' 
			Me.bunifuHSlider1.AllowCursorChanges = True
			Me.bunifuHSlider1.AllowHomeEndKeysDetection = False
			Me.bunifuHSlider1.AllowIncrementalClickMoves = True
			Me.bunifuHSlider1.AllowMouseDownEffects = False
			Me.bunifuHSlider1.AllowMouseHoverEffects = False
			Me.bunifuHSlider1.AllowScrollingAnimations = True
			Me.bunifuHSlider1.AllowScrollKeysDetection = True
			Me.bunifuHSlider1.AllowScrollOptionsMenu = True
			Me.bunifuHSlider1.AllowShrinkingOnFocusLost = False
			Me.bunifuHSlider1.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.bunifuHSlider1.BackColor = System.Drawing.Color.Transparent
			Me.bunifuHSlider1.BackgroundImage = (DirectCast(resources.GetObject("bunifuHSlider1.BackgroundImage"), System.Drawing.Image))
			Me.bunifuHSlider1.BindingContainer = Nothing
			Me.bunifuHSlider1.BorderRadius = 2
			Me.bunifuHSlider1.BorderThickness = 1
			Me.bunifuHSlider1.Cursor = System.Windows.Forms.Cursors.Hand
			Me.bunifuHSlider1.DrawThickBorder = False
			Me.bunifuHSlider1.DurationBeforeShrink = 2000
			Me.bunifuHSlider1.ElapsedColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.bunifuHSlider1.LargeChange = 10
			Me.bunifuHSlider1.Location = New System.Drawing.Point(144, 384)
			Me.bunifuHSlider1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
			Me.bunifuHSlider1.Maximum = 5000
			Me.bunifuHSlider1.Minimum = 0
			Me.bunifuHSlider1.MinimumSize = New System.Drawing.Size(0, 41)
			Me.bunifuHSlider1.MinimumThumbLength = 18
			Me.bunifuHSlider1.Name = "bunifuHSlider1"
			Me.bunifuHSlider1.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver
			Me.bunifuHSlider1.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent
			Me.bunifuHSlider1.OnDisable.ThumbColor = System.Drawing.Color.Silver
			Me.bunifuHSlider1.ScrollBarBorderColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.bunifuHSlider1.ScrollBarColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.bunifuHSlider1.ShrinkSizeLimit = 3
			Me.bunifuHSlider1.Size = New System.Drawing.Size(641, 41)
			Me.bunifuHSlider1.SliderColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.bunifuHSlider1.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin
			Me.bunifuHSlider1.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular
			Me.bunifuHSlider1.SmallChange = 1
			Me.bunifuHSlider1.TabIndex = 14
			Me.bunifuHSlider1.ThumbColor = System.Drawing.Color.Red
			Me.bunifuHSlider1.ThumbFillColor = System.Drawing.Color.Red
			Me.bunifuHSlider1.ThumbLength = 18
			Me.bunifuHSlider1.ThumbMargin = 1
			Me.bunifuHSlider1.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium
			Me.bunifuHSlider1.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Fill
			Me.bunifuHSlider1.Value = 0
'			Me.bunifuHSlider1.Scroll += New System.EventHandler(Of Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs)(Me.bunifuHSlider1_Scroll)
			' 
			' tabPage3
			' 
			Me.tabPage3.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(40)))), (CInt((CByte(40)))), (CInt((CByte(40)))))
			Me.tabPage3.Controls.Add(Me.siticoneCheckBox34)
			Me.tabPage3.Controls.Add(Me.siticoneCheckBox29)
			Me.tabPage3.Controls.Add(Me.siticoneRadioButton5)
			Me.tabPage3.Controls.Add(Me.siticoneRadioButton4)
			Me.tabPage3.Controls.Add(Me.siticoneRadioButton3)
			Me.tabPage3.Controls.Add(Me.gunaButton3)
			Me.tabPage3.Controls.Add(Me.gunaButton4)
			Me.tabPage3.Controls.Add(Me.metroLabel18)
			Me.tabPage3.Controls.Add(Me.siticoneOSToggleSwith2)
			Me.tabPage3.Controls.Add(Me.siticoneCheckBox9)
			Me.tabPage3.Controls.Add(Me.siticoneCheckBox8)
			Me.tabPage3.Controls.Add(Me.siticoneCheckBox7)
			Me.tabPage3.Controls.Add(Me.gunaTextBox1)
			Me.tabPage3.Controls.Add(Me.gunaLineTextBox5)
			Me.tabPage3.Controls.Add(Me.gunaLineTextBox4)
			Me.tabPage3.Controls.Add(Me.metroLabel3)
			Me.tabPage3.Controls.Add(Me.bunifuHSlider2)
			Me.tabPage3.Font = New System.Drawing.Font("Segoe UI", 10F)
			Me.tabPage3.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(153)))), (CInt((CByte(153)))), (CInt((CByte(153)))))
			Me.tabPage3.Location = New System.Drawing.Point(184, 4)
			Me.tabPage3.Name = "tabPage3"
			Me.tabPage3.Padding = New System.Windows.Forms.Padding(3)
			Me.tabPage3.Size = New System.Drawing.Size(931, 581)
			Me.tabPage3.TabIndex = 2
			Me.tabPage3.Text = "Server Spammer"
			' 
			' siticoneCheckBox34
			' 
			Me.siticoneCheckBox34.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.siticoneCheckBox34.AutoSize = True
			Me.siticoneCheckBox34.CheckedState.BorderColor = System.Drawing.Color.Red
			Me.siticoneCheckBox34.CheckedState.BorderRadius = 2
			Me.siticoneCheckBox34.CheckedState.BorderThickness = 0
			Me.siticoneCheckBox34.CheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.siticoneCheckBox34.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.siticoneCheckBox34.Location = New System.Drawing.Point(303, 417)
			Me.siticoneCheckBox34.Name = "siticoneCheckBox34"
			Me.siticoneCheckBox34.Size = New System.Drawing.Size(135, 17)
			Me.siticoneCheckBox34.TabIndex = 22
			Me.siticoneCheckBox34.Text = "Auto Delete Message"
			Me.siticoneCheckBox34.UncheckedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneCheckBox34.UncheckedState.BorderRadius = 2
			Me.siticoneCheckBox34.UncheckedState.BorderThickness = 0
			Me.siticoneCheckBox34.UncheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneCheckBox34.UseVisualStyleBackColor = True
			' 
			' siticoneCheckBox29
			' 
			Me.siticoneCheckBox29.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.siticoneCheckBox29.AutoSize = True
			Me.siticoneCheckBox29.CheckedState.BorderColor = System.Drawing.Color.Red
			Me.siticoneCheckBox29.CheckedState.BorderRadius = 2
			Me.siticoneCheckBox29.CheckedState.BorderThickness = 0
			Me.siticoneCheckBox29.CheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.siticoneCheckBox29.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.siticoneCheckBox29.Location = New System.Drawing.Point(144, 418)
			Me.siticoneCheckBox29.Name = "siticoneCheckBox29"
			Me.siticoneCheckBox29.Size = New System.Drawing.Size(101, 17)
			Me.siticoneCheckBox29.TabIndex = 21
			Me.siticoneCheckBox29.Text = "Roles Mention"
			Me.siticoneCheckBox29.UncheckedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneCheckBox29.UncheckedState.BorderRadius = 2
			Me.siticoneCheckBox29.UncheckedState.BorderThickness = 0
			Me.siticoneCheckBox29.UncheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneCheckBox29.UseVisualStyleBackColor = True
			' 
			' siticoneRadioButton5
			' 
			Me.siticoneRadioButton5.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.siticoneRadioButton5.AutoSize = True
			Me.siticoneRadioButton5.CheckedState.BorderColor = System.Drawing.Color.Red
			Me.siticoneRadioButton5.CheckedState.BorderThickness = 0
			Me.siticoneRadioButton5.CheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.siticoneRadioButton5.CheckedState.InnerColor = System.Drawing.Color.White
			Me.siticoneRadioButton5.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.siticoneRadioButton5.Location = New System.Drawing.Point(303, 394)
			Me.siticoneRadioButton5.Name = "siticoneRadioButton5"
			Me.siticoneRadioButton5.Size = New System.Drawing.Size(103, 17)
			Me.siticoneRadioButton5.TabIndex = 20
			Me.siticoneRadioButton5.Text = "Supreme Mode"
			Me.siticoneRadioButton5.UncheckedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneRadioButton5.UncheckedState.BorderThickness = 2
			Me.siticoneRadioButton5.UncheckedState.FillColor = System.Drawing.Color.Transparent
			Me.siticoneRadioButton5.UncheckedState.InnerColor = System.Drawing.Color.Transparent
			Me.siticoneRadioButton5.UseVisualStyleBackColor = True
			' 
			' siticoneRadioButton4
			' 
			Me.siticoneRadioButton4.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.siticoneRadioButton4.AutoSize = True
			Me.siticoneRadioButton4.CheckedState.BorderColor = System.Drawing.Color.Red
			Me.siticoneRadioButton4.CheckedState.BorderThickness = 0
			Me.siticoneRadioButton4.CheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.siticoneRadioButton4.CheckedState.InnerColor = System.Drawing.Color.White
			Me.siticoneRadioButton4.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.siticoneRadioButton4.Location = New System.Drawing.Point(303, 371)
			Me.siticoneRadioButton4.Name = "siticoneRadioButton4"
			Me.siticoneRadioButton4.Size = New System.Drawing.Size(98, 17)
			Me.siticoneRadioButton4.TabIndex = 19
			Me.siticoneRadioButton4.Text = "Extreme Mode"
			Me.siticoneRadioButton4.UncheckedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneRadioButton4.UncheckedState.BorderThickness = 2
			Me.siticoneRadioButton4.UncheckedState.FillColor = System.Drawing.Color.Transparent
			Me.siticoneRadioButton4.UncheckedState.InnerColor = System.Drawing.Color.Transparent
			Me.siticoneRadioButton4.UseVisualStyleBackColor = True
			' 
			' siticoneRadioButton3
			' 
			Me.siticoneRadioButton3.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.siticoneRadioButton3.AutoSize = True
			Me.siticoneRadioButton3.Checked = True
			Me.siticoneRadioButton3.CheckedState.BorderColor = System.Drawing.Color.Red
			Me.siticoneRadioButton3.CheckedState.BorderThickness = 0
			Me.siticoneRadioButton3.CheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.siticoneRadioButton3.CheckedState.InnerColor = System.Drawing.Color.White
			Me.siticoneRadioButton3.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.siticoneRadioButton3.Location = New System.Drawing.Point(303, 349)
			Me.siticoneRadioButton3.Name = "siticoneRadioButton3"
			Me.siticoneRadioButton3.Size = New System.Drawing.Size(95, 17)
			Me.siticoneRadioButton3.TabIndex = 18
			Me.siticoneRadioButton3.TabStop = True
			Me.siticoneRadioButton3.Text = "Normal Mode"
			Me.siticoneRadioButton3.UncheckedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneRadioButton3.UncheckedState.BorderThickness = 2
			Me.siticoneRadioButton3.UncheckedState.FillColor = System.Drawing.Color.Transparent
			Me.siticoneRadioButton3.UncheckedState.InnerColor = System.Drawing.Color.Transparent
			Me.siticoneRadioButton3.UseVisualStyleBackColor = True
			' 
			' gunaButton3
			' 
			Me.gunaButton3.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.gunaButton3.Animated = True
			Me.gunaButton3.AnimationHoverSpeed = 0.07F
			Me.gunaButton3.AnimationSpeed = 0.03F
			Me.gunaButton3.BackColor = System.Drawing.Color.Transparent
			Me.gunaButton3.BaseColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.gunaButton3.BorderColor = System.Drawing.Color.Transparent
			Me.gunaButton3.DialogResult = System.Windows.Forms.DialogResult.None
			Me.gunaButton3.Enabled = False
			Me.gunaButton3.FocusedColor = System.Drawing.Color.Empty
			Me.gunaButton3.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.gunaButton3.ForeColor = System.Drawing.Color.White
			Me.gunaButton3.Image = Nothing
			Me.gunaButton3.ImageSize = New System.Drawing.Size(24, 24)
			Me.gunaButton3.Location = New System.Drawing.Point(468, 516)
			Me.gunaButton3.Name = "gunaButton3"
			Me.gunaButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.gunaButton3.OnHoverBorderColor = System.Drawing.Color.Black
			Me.gunaButton3.OnHoverForeColor = System.Drawing.Color.White
			Me.gunaButton3.OnHoverImage = Nothing
			Me.gunaButton3.OnPressedColor = System.Drawing.Color.Black
			Me.gunaButton3.Size = New System.Drawing.Size(317, 42)
			Me.gunaButton3.TabIndex = 17
			Me.gunaButton3.Text = "Stop Spamming"
			Me.gunaButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
'			Me.gunaButton3.Click += New System.EventHandler(Me.gunaButton3_Click)
			' 
			' gunaButton4
			' 
			Me.gunaButton4.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.gunaButton4.Animated = True
			Me.gunaButton4.AnimationHoverSpeed = 0.07F
			Me.gunaButton4.AnimationSpeed = 0.03F
			Me.gunaButton4.BackColor = System.Drawing.Color.Transparent
			Me.gunaButton4.BaseColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.gunaButton4.BorderColor = System.Drawing.Color.Transparent
			Me.gunaButton4.DialogResult = System.Windows.Forms.DialogResult.None
			Me.gunaButton4.FocusedColor = System.Drawing.Color.Empty
			Me.gunaButton4.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.gunaButton4.ForeColor = System.Drawing.Color.White
			Me.gunaButton4.Image = Nothing
			Me.gunaButton4.ImageSize = New System.Drawing.Size(24, 24)
			Me.gunaButton4.Location = New System.Drawing.Point(144, 516)
			Me.gunaButton4.Name = "gunaButton4"
			Me.gunaButton4.OnHoverBaseColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.gunaButton4.OnHoverBorderColor = System.Drawing.Color.Black
			Me.gunaButton4.OnHoverForeColor = System.Drawing.Color.White
			Me.gunaButton4.OnHoverImage = Nothing
			Me.gunaButton4.OnPressedColor = System.Drawing.Color.Black
			Me.gunaButton4.Size = New System.Drawing.Size(317, 42)
			Me.gunaButton4.TabIndex = 16
			Me.gunaButton4.Text = "Start Spamming"
			Me.gunaButton4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
'			Me.gunaButton4.Click += New System.EventHandler(Me.gunaButton4_Click)
			' 
			' metroLabel18
			' 
			Me.metroLabel18.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.metroLabel18.AutoSize = True
			Me.metroLabel18.BackColor = System.Drawing.Color.Transparent
			Me.metroLabel18.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.metroLabel18.Location = New System.Drawing.Point(723, 352)
			Me.metroLabel18.Name = "metroLabel18"
			Me.metroLabel18.Size = New System.Drawing.Size(64, 15)
			Me.metroLabel18.TabIndex = 13
			Me.metroLabel18.Text = "Delay: 0ms"
			Me.metroLabel18.TextAlign = System.Drawing.ContentAlignment.TopRight
			' 
			' siticoneOSToggleSwith2
			' 
			Me.siticoneOSToggleSwith2.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.siticoneOSToggleSwith2.CheckedFillColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.siticoneOSToggleSwith2.Location = New System.Drawing.Point(683, 349)
			Me.siticoneOSToggleSwith2.Name = "siticoneOSToggleSwith2"
			Me.siticoneOSToggleSwith2.Size = New System.Drawing.Size(38, 22)
			Me.siticoneOSToggleSwith2.TabIndex = 12
			' 
			' siticoneCheckBox9
			' 
			Me.siticoneCheckBox9.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.siticoneCheckBox9.AutoSize = True
			Me.siticoneCheckBox9.CheckedState.BorderColor = System.Drawing.Color.Red
			Me.siticoneCheckBox9.CheckedState.BorderRadius = 2
			Me.siticoneCheckBox9.CheckedState.BorderThickness = 0
			Me.siticoneCheckBox9.CheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.siticoneCheckBox9.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.siticoneCheckBox9.Location = New System.Drawing.Point(144, 395)
			Me.siticoneCheckBox9.Name = "siticoneCheckBox9"
			Me.siticoneCheckBox9.Size = New System.Drawing.Size(122, 17)
			Me.siticoneCheckBox9.TabIndex = 9
			Me.siticoneCheckBox9.Text = "Multiple Messages"
			Me.siticoneCheckBox9.UncheckedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneCheckBox9.UncheckedState.BorderRadius = 2
			Me.siticoneCheckBox9.UncheckedState.BorderThickness = 0
			Me.siticoneCheckBox9.UncheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneCheckBox9.UseVisualStyleBackColor = True
			' 
			' siticoneCheckBox8
			' 
			Me.siticoneCheckBox8.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.siticoneCheckBox8.AutoSize = True
			Me.siticoneCheckBox8.CheckedState.BorderColor = System.Drawing.Color.Red
			Me.siticoneCheckBox8.CheckedState.BorderRadius = 2
			Me.siticoneCheckBox8.CheckedState.BorderThickness = 0
			Me.siticoneCheckBox8.CheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.siticoneCheckBox8.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.siticoneCheckBox8.Location = New System.Drawing.Point(144, 372)
			Me.siticoneCheckBox8.Name = "siticoneCheckBox8"
			Me.siticoneCheckBox8.Size = New System.Drawing.Size(120, 17)
			Me.siticoneCheckBox8.TabIndex = 8
			Me.siticoneCheckBox8.Text = "Multiple Channels"
			Me.siticoneCheckBox8.UncheckedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneCheckBox8.UncheckedState.BorderRadius = 2
			Me.siticoneCheckBox8.UncheckedState.BorderThickness = 0
			Me.siticoneCheckBox8.UncheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneCheckBox8.UseVisualStyleBackColor = True
			' 
			' siticoneCheckBox7
			' 
			Me.siticoneCheckBox7.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.siticoneCheckBox7.AutoSize = True
			Me.siticoneCheckBox7.CheckedState.BorderColor = System.Drawing.Color.Red
			Me.siticoneCheckBox7.CheckedState.BorderRadius = 2
			Me.siticoneCheckBox7.CheckedState.BorderThickness = 0
			Me.siticoneCheckBox7.CheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.siticoneCheckBox7.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.siticoneCheckBox7.Location = New System.Drawing.Point(144, 349)
			Me.siticoneCheckBox7.Name = "siticoneCheckBox7"
			Me.siticoneCheckBox7.Size = New System.Drawing.Size(99, 17)
			Me.siticoneCheckBox7.TabIndex = 7
			Me.siticoneCheckBox7.Text = "Mass Mention"
			Me.siticoneCheckBox7.UncheckedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneCheckBox7.UncheckedState.BorderRadius = 2
			Me.siticoneCheckBox7.UncheckedState.BorderThickness = 0
			Me.siticoneCheckBox7.UncheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneCheckBox7.UseVisualStyleBackColor = True
			' 
			' gunaTextBox1
			' 
			Me.gunaTextBox1.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.gunaTextBox1.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(40)))), (CInt((CByte(40)))), (CInt((CByte(40)))))
			Me.gunaTextBox1.BaseColor = System.Drawing.Color.FromArgb((CInt((CByte(40)))), (CInt((CByte(40)))), (CInt((CByte(40)))))
			Me.gunaTextBox1.BorderColor = System.Drawing.Color.Silver
			Me.gunaTextBox1.BorderSize = 1
			Me.gunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
			Me.gunaTextBox1.FocusedBaseColor = System.Drawing.Color.FromArgb((CInt((CByte(40)))), (CInt((CByte(40)))), (CInt((CByte(40)))))
			Me.gunaTextBox1.FocusedBorderColor = System.Drawing.Color.Red
			Me.gunaTextBox1.FocusedForeColor = System.Drawing.Color.White
			Me.gunaTextBox1.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.gunaTextBox1.Location = New System.Drawing.Point(144, 192)
			Me.gunaTextBox1.MaxLength = 2147483647
			Me.gunaTextBox1.MultiLine = True
			Me.gunaTextBox1.Name = "gunaTextBox1"
			Me.gunaTextBox1.PasswordChar = ControlChars.NullChar
			Me.gunaTextBox1.Size = New System.Drawing.Size(641, 137)
			Me.gunaTextBox1.TabIndex = 5
			Me.gunaTextBox1.Text = "Insert the message here."
			' 
			' gunaLineTextBox5
			' 
			Me.gunaLineTextBox5.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.gunaLineTextBox5.Animated = True
			Me.gunaLineTextBox5.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(40)))), (CInt((CByte(40)))), (CInt((CByte(40)))))
			Me.gunaLineTextBox5.Cursor = System.Windows.Forms.Cursors.IBeam
			Me.gunaLineTextBox5.FocusedLineColor = System.Drawing.Color.Red
			Me.gunaLineTextBox5.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.gunaLineTextBox5.LineColor = System.Drawing.Color.Gainsboro
			Me.gunaLineTextBox5.LineSize = 1
			Me.gunaLineTextBox5.Location = New System.Drawing.Point(144, 160)
			Me.gunaLineTextBox5.MaxLength = 2147483647
			Me.gunaLineTextBox5.Name = "gunaLineTextBox5"
			Me.gunaLineTextBox5.PasswordChar = ControlChars.NullChar
			Me.gunaLineTextBox5.Size = New System.Drawing.Size(641, 26)
			Me.gunaLineTextBox5.TabIndex = 4
			Me.gunaLineTextBox5.Text = "Insert the message reference here (message ID to reply to, not necessary)."
			Me.gunaLineTextBox5.TextOffsetX = 0
			' 
			' gunaLineTextBox4
			' 
			Me.gunaLineTextBox4.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.gunaLineTextBox4.Animated = True
			Me.gunaLineTextBox4.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(40)))), (CInt((CByte(40)))), (CInt((CByte(40)))))
			Me.gunaLineTextBox4.Cursor = System.Windows.Forms.Cursors.IBeam
			Me.gunaLineTextBox4.FocusedLineColor = System.Drawing.Color.Red
			Me.gunaLineTextBox4.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.gunaLineTextBox4.LineColor = System.Drawing.Color.Gainsboro
			Me.gunaLineTextBox4.LineSize = 1
			Me.gunaLineTextBox4.Location = New System.Drawing.Point(144, 128)
			Me.gunaLineTextBox4.MaxLength = 2147483647
			Me.gunaLineTextBox4.Name = "gunaLineTextBox4"
			Me.gunaLineTextBox4.PasswordChar = ControlChars.NullChar
			Me.gunaLineTextBox4.Size = New System.Drawing.Size(641, 26)
			Me.gunaLineTextBox4.TabIndex = 3
			Me.gunaLineTextBox4.Text = "Insert the channel ID here."
			Me.gunaLineTextBox4.TextOffsetX = 0
			' 
			' metroLabel3
			' 
			Me.metroLabel3.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.metroLabel3.BackColor = System.Drawing.Color.Transparent
			Me.metroLabel3.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.metroLabel3.Location = New System.Drawing.Point(-1, 8)
			Me.metroLabel3.Name = "metroLabel3"
			Me.metroLabel3.Size = New System.Drawing.Size(931, 23)
			Me.metroLabel3.TabIndex = 1
			Me.metroLabel3.Text = "Server Spammer"
			Me.metroLabel3.TextAlign = System.Drawing.ContentAlignment.TopCenter
			' 
			' bunifuHSlider2
			' 
			Me.bunifuHSlider2.AllowCursorChanges = True
			Me.bunifuHSlider2.AllowHomeEndKeysDetection = False
			Me.bunifuHSlider2.AllowIncrementalClickMoves = True
			Me.bunifuHSlider2.AllowMouseDownEffects = False
			Me.bunifuHSlider2.AllowMouseHoverEffects = False
			Me.bunifuHSlider2.AllowScrollingAnimations = True
			Me.bunifuHSlider2.AllowScrollKeysDetection = True
			Me.bunifuHSlider2.AllowScrollOptionsMenu = True
			Me.bunifuHSlider2.AllowShrinkingOnFocusLost = False
			Me.bunifuHSlider2.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.bunifuHSlider2.BackColor = System.Drawing.Color.Transparent
			Me.bunifuHSlider2.BackgroundImage = (DirectCast(resources.GetObject("bunifuHSlider2.BackgroundImage"), System.Drawing.Image))
			Me.bunifuHSlider2.BindingContainer = Nothing
			Me.bunifuHSlider2.BorderRadius = 2
			Me.bunifuHSlider2.BorderThickness = 1
			Me.bunifuHSlider2.Cursor = System.Windows.Forms.Cursors.Hand
			Me.bunifuHSlider2.DrawThickBorder = False
			Me.bunifuHSlider2.DurationBeforeShrink = 2000
			Me.bunifuHSlider2.ElapsedColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.bunifuHSlider2.LargeChange = 10
			Me.bunifuHSlider2.Location = New System.Drawing.Point(144, 454)
			Me.bunifuHSlider2.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
			Me.bunifuHSlider2.Maximum = 5000
			Me.bunifuHSlider2.Minimum = 0
			Me.bunifuHSlider2.MinimumSize = New System.Drawing.Size(0, 54)
			Me.bunifuHSlider2.MinimumThumbLength = 18
			Me.bunifuHSlider2.Name = "bunifuHSlider2"
			Me.bunifuHSlider2.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver
			Me.bunifuHSlider2.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent
			Me.bunifuHSlider2.OnDisable.ThumbColor = System.Drawing.Color.Silver
			Me.bunifuHSlider2.ScrollBarBorderColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.bunifuHSlider2.ScrollBarColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.bunifuHSlider2.ShrinkSizeLimit = 3
			Me.bunifuHSlider2.Size = New System.Drawing.Size(643, 54)
			Me.bunifuHSlider2.SliderColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.bunifuHSlider2.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin
			Me.bunifuHSlider2.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular
			Me.bunifuHSlider2.SmallChange = 1
			Me.bunifuHSlider2.TabIndex = 15
			Me.bunifuHSlider2.ThumbColor = System.Drawing.Color.Red
			Me.bunifuHSlider2.ThumbFillColor = System.Drawing.Color.Red
			Me.bunifuHSlider2.ThumbLength = 18
			Me.bunifuHSlider2.ThumbMargin = 1
			Me.bunifuHSlider2.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium
			Me.bunifuHSlider2.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Fill
			Me.bunifuHSlider2.Value = 0
'			Me.bunifuHSlider2.Scroll += New System.EventHandler(Of Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs)(Me.bunifuHSlider2_Scroll)
			' 
			' tabPage4
			' 
			Me.tabPage4.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(40)))), (CInt((CByte(40)))), (CInt((CByte(40)))))
			Me.tabPage4.Controls.Add(Me.siticoneRadioButton6)
			Me.tabPage4.Controls.Add(Me.siticoneRadioButton7)
			Me.tabPage4.Controls.Add(Me.siticoneRadioButton8)
			Me.tabPage4.Controls.Add(Me.metroLabel19)
			Me.tabPage4.Controls.Add(Me.siticoneOSToggleSwith3)
			Me.tabPage4.Controls.Add(Me.gunaButton6)
			Me.tabPage4.Controls.Add(Me.gunaButton5)
			Me.tabPage4.Controls.Add(Me.siticoneCheckBox12)
			Me.tabPage4.Controls.Add(Me.siticoneCheckBox11)
			Me.tabPage4.Controls.Add(Me.gunaTextBox2)
			Me.tabPage4.Controls.Add(Me.gunaLineTextBox7)
			Me.tabPage4.Controls.Add(Me.gunaLineTextBox6)
			Me.tabPage4.Controls.Add(Me.metroLabel4)
			Me.tabPage4.Controls.Add(Me.bunifuHSlider3)
			Me.tabPage4.Font = New System.Drawing.Font("Segoe UI", 10F)
			Me.tabPage4.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(153)))), (CInt((CByte(153)))), (CInt((CByte(153)))))
			Me.tabPage4.Location = New System.Drawing.Point(184, 4)
			Me.tabPage4.Name = "tabPage4"
			Me.tabPage4.Padding = New System.Windows.Forms.Padding(3)
			Me.tabPage4.Size = New System.Drawing.Size(931, 581)
			Me.tabPage4.TabIndex = 3
			Me.tabPage4.Text = "DM Spammer"
			' 
			' siticoneRadioButton6
			' 
			Me.siticoneRadioButton6.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.siticoneRadioButton6.AutoSize = True
			Me.siticoneRadioButton6.CheckedState.BorderColor = System.Drawing.Color.Red
			Me.siticoneRadioButton6.CheckedState.BorderThickness = 0
			Me.siticoneRadioButton6.CheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.siticoneRadioButton6.CheckedState.InnerColor = System.Drawing.Color.White
			Me.siticoneRadioButton6.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.siticoneRadioButton6.Location = New System.Drawing.Point(303, 394)
			Me.siticoneRadioButton6.Name = "siticoneRadioButton6"
			Me.siticoneRadioButton6.Size = New System.Drawing.Size(103, 17)
			Me.siticoneRadioButton6.TabIndex = 23
			Me.siticoneRadioButton6.Text = "Supreme Mode"
			Me.siticoneRadioButton6.UncheckedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneRadioButton6.UncheckedState.BorderThickness = 2
			Me.siticoneRadioButton6.UncheckedState.FillColor = System.Drawing.Color.Transparent
			Me.siticoneRadioButton6.UncheckedState.InnerColor = System.Drawing.Color.Transparent
			Me.siticoneRadioButton6.UseVisualStyleBackColor = True
			' 
			' siticoneRadioButton7
			' 
			Me.siticoneRadioButton7.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.siticoneRadioButton7.AutoSize = True
			Me.siticoneRadioButton7.CheckedState.BorderColor = System.Drawing.Color.Red
			Me.siticoneRadioButton7.CheckedState.BorderThickness = 0
			Me.siticoneRadioButton7.CheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.siticoneRadioButton7.CheckedState.InnerColor = System.Drawing.Color.White
			Me.siticoneRadioButton7.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.siticoneRadioButton7.Location = New System.Drawing.Point(303, 371)
			Me.siticoneRadioButton7.Name = "siticoneRadioButton7"
			Me.siticoneRadioButton7.Size = New System.Drawing.Size(98, 17)
			Me.siticoneRadioButton7.TabIndex = 22
			Me.siticoneRadioButton7.Text = "Extreme Mode"
			Me.siticoneRadioButton7.UncheckedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneRadioButton7.UncheckedState.BorderThickness = 2
			Me.siticoneRadioButton7.UncheckedState.FillColor = System.Drawing.Color.Transparent
			Me.siticoneRadioButton7.UncheckedState.InnerColor = System.Drawing.Color.Transparent
			Me.siticoneRadioButton7.UseVisualStyleBackColor = True
			' 
			' siticoneRadioButton8
			' 
			Me.siticoneRadioButton8.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.siticoneRadioButton8.AutoSize = True
			Me.siticoneRadioButton8.Checked = True
			Me.siticoneRadioButton8.CheckedState.BorderColor = System.Drawing.Color.Red
			Me.siticoneRadioButton8.CheckedState.BorderThickness = 0
			Me.siticoneRadioButton8.CheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.siticoneRadioButton8.CheckedState.InnerColor = System.Drawing.Color.White
			Me.siticoneRadioButton8.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.siticoneRadioButton8.Location = New System.Drawing.Point(303, 349)
			Me.siticoneRadioButton8.Name = "siticoneRadioButton8"
			Me.siticoneRadioButton8.Size = New System.Drawing.Size(95, 17)
			Me.siticoneRadioButton8.TabIndex = 21
			Me.siticoneRadioButton8.TabStop = True
			Me.siticoneRadioButton8.Text = "Normal Mode"
			Me.siticoneRadioButton8.UncheckedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneRadioButton8.UncheckedState.BorderThickness = 2
			Me.siticoneRadioButton8.UncheckedState.FillColor = System.Drawing.Color.Transparent
			Me.siticoneRadioButton8.UncheckedState.InnerColor = System.Drawing.Color.Transparent
			Me.siticoneRadioButton8.UseVisualStyleBackColor = True
			' 
			' metroLabel19
			' 
			Me.metroLabel19.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.metroLabel19.AutoSize = True
			Me.metroLabel19.BackColor = System.Drawing.Color.Transparent
			Me.metroLabel19.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.metroLabel19.Location = New System.Drawing.Point(723, 352)
			Me.metroLabel19.Name = "metroLabel19"
			Me.metroLabel19.Size = New System.Drawing.Size(64, 15)
			Me.metroLabel19.TabIndex = 20
			Me.metroLabel19.Text = "Delay: 0ms"
			Me.metroLabel19.TextAlign = System.Drawing.ContentAlignment.TopRight
			' 
			' siticoneOSToggleSwith3
			' 
			Me.siticoneOSToggleSwith3.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.siticoneOSToggleSwith3.CheckedFillColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.siticoneOSToggleSwith3.Location = New System.Drawing.Point(683, 349)
			Me.siticoneOSToggleSwith3.Name = "siticoneOSToggleSwith3"
			Me.siticoneOSToggleSwith3.Size = New System.Drawing.Size(38, 22)
			Me.siticoneOSToggleSwith3.TabIndex = 19
			' 
			' gunaButton6
			' 
			Me.gunaButton6.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.gunaButton6.Animated = True
			Me.gunaButton6.AnimationHoverSpeed = 0.07F
			Me.gunaButton6.AnimationSpeed = 0.03F
			Me.gunaButton6.BackColor = System.Drawing.Color.Transparent
			Me.gunaButton6.BaseColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.gunaButton6.BorderColor = System.Drawing.Color.Transparent
			Me.gunaButton6.DialogResult = System.Windows.Forms.DialogResult.None
			Me.gunaButton6.Enabled = False
			Me.gunaButton6.FocusedColor = System.Drawing.Color.Empty
			Me.gunaButton6.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.gunaButton6.ForeColor = System.Drawing.Color.White
			Me.gunaButton6.Image = Nothing
			Me.gunaButton6.ImageSize = New System.Drawing.Size(24, 24)
			Me.gunaButton6.Location = New System.Drawing.Point(468, 503)
			Me.gunaButton6.Name = "gunaButton6"
			Me.gunaButton6.OnHoverBaseColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.gunaButton6.OnHoverBorderColor = System.Drawing.Color.Black
			Me.gunaButton6.OnHoverForeColor = System.Drawing.Color.White
			Me.gunaButton6.OnHoverImage = Nothing
			Me.gunaButton6.OnPressedColor = System.Drawing.Color.Black
			Me.gunaButton6.Size = New System.Drawing.Size(317, 42)
			Me.gunaButton6.TabIndex = 18
			Me.gunaButton6.Text = "Stop Spamming"
			Me.gunaButton6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
'			Me.gunaButton6.Click += New System.EventHandler(Me.gunaButton6_Click)
			' 
			' gunaButton5
			' 
			Me.gunaButton5.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.gunaButton5.Animated = True
			Me.gunaButton5.AnimationHoverSpeed = 0.07F
			Me.gunaButton5.AnimationSpeed = 0.03F
			Me.gunaButton5.BackColor = System.Drawing.Color.Transparent
			Me.gunaButton5.BaseColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.gunaButton5.BorderColor = System.Drawing.Color.Transparent
			Me.gunaButton5.DialogResult = System.Windows.Forms.DialogResult.None
			Me.gunaButton5.FocusedColor = System.Drawing.Color.Empty
			Me.gunaButton5.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.gunaButton5.ForeColor = System.Drawing.Color.White
			Me.gunaButton5.Image = Nothing
			Me.gunaButton5.ImageSize = New System.Drawing.Size(24, 24)
			Me.gunaButton5.Location = New System.Drawing.Point(144, 503)
			Me.gunaButton5.Name = "gunaButton5"
			Me.gunaButton5.OnHoverBaseColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.gunaButton5.OnHoverBorderColor = System.Drawing.Color.Black
			Me.gunaButton5.OnHoverForeColor = System.Drawing.Color.White
			Me.gunaButton5.OnHoverImage = Nothing
			Me.gunaButton5.OnPressedColor = System.Drawing.Color.Black
			Me.gunaButton5.Size = New System.Drawing.Size(317, 42)
			Me.gunaButton5.TabIndex = 17
			Me.gunaButton5.Text = "Start Spamming"
			Me.gunaButton5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
'			Me.gunaButton5.Click += New System.EventHandler(Me.gunaButton5_Click)
			' 
			' siticoneCheckBox12
			' 
			Me.siticoneCheckBox12.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.siticoneCheckBox12.AutoSize = True
			Me.siticoneCheckBox12.CheckedState.BorderColor = System.Drawing.Color.Red
			Me.siticoneCheckBox12.CheckedState.BorderRadius = 2
			Me.siticoneCheckBox12.CheckedState.BorderThickness = 0
			Me.siticoneCheckBox12.CheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.siticoneCheckBox12.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.siticoneCheckBox12.Location = New System.Drawing.Point(144, 372)
			Me.siticoneCheckBox12.Name = "siticoneCheckBox12"
			Me.siticoneCheckBox12.Size = New System.Drawing.Size(122, 17)
			Me.siticoneCheckBox12.TabIndex = 9
			Me.siticoneCheckBox12.Text = "Multiple Messages"
			Me.siticoneCheckBox12.UncheckedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneCheckBox12.UncheckedState.BorderRadius = 2
			Me.siticoneCheckBox12.UncheckedState.BorderThickness = 0
			Me.siticoneCheckBox12.UncheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneCheckBox12.UseVisualStyleBackColor = True
			' 
			' siticoneCheckBox11
			' 
			Me.siticoneCheckBox11.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.siticoneCheckBox11.AutoSize = True
			Me.siticoneCheckBox11.CheckedState.BorderColor = System.Drawing.Color.Red
			Me.siticoneCheckBox11.CheckedState.BorderRadius = 2
			Me.siticoneCheckBox11.CheckedState.BorderThickness = 0
			Me.siticoneCheckBox11.CheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.siticoneCheckBox11.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.siticoneCheckBox11.Location = New System.Drawing.Point(144, 349)
			Me.siticoneCheckBox11.Name = "siticoneCheckBox11"
			Me.siticoneCheckBox11.Size = New System.Drawing.Size(100, 17)
			Me.siticoneCheckBox11.TabIndex = 8
			Me.siticoneCheckBox11.Text = "Multiple Users"
			Me.siticoneCheckBox11.UncheckedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneCheckBox11.UncheckedState.BorderRadius = 2
			Me.siticoneCheckBox11.UncheckedState.BorderThickness = 0
			Me.siticoneCheckBox11.UncheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneCheckBox11.UseVisualStyleBackColor = True
			' 
			' gunaTextBox2
			' 
			Me.gunaTextBox2.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.gunaTextBox2.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(40)))), (CInt((CByte(40)))), (CInt((CByte(40)))))
			Me.gunaTextBox2.BaseColor = System.Drawing.Color.FromArgb((CInt((CByte(40)))), (CInt((CByte(40)))), (CInt((CByte(40)))))
			Me.gunaTextBox2.BorderColor = System.Drawing.Color.Silver
			Me.gunaTextBox2.BorderSize = 1
			Me.gunaTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
			Me.gunaTextBox2.FocusedBaseColor = System.Drawing.Color.FromArgb((CInt((CByte(40)))), (CInt((CByte(40)))), (CInt((CByte(40)))))
			Me.gunaTextBox2.FocusedBorderColor = System.Drawing.Color.Red
			Me.gunaTextBox2.FocusedForeColor = System.Drawing.Color.White
			Me.gunaTextBox2.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.gunaTextBox2.Location = New System.Drawing.Point(144, 192)
			Me.gunaTextBox2.MaxLength = 2147483647
			Me.gunaTextBox2.MultiLine = True
			Me.gunaTextBox2.Name = "gunaTextBox2"
			Me.gunaTextBox2.PasswordChar = ControlChars.NullChar
			Me.gunaTextBox2.Size = New System.Drawing.Size(641, 137)
			Me.gunaTextBox2.TabIndex = 6
			Me.gunaTextBox2.Text = "Insert the message here."
			' 
			' gunaLineTextBox7
			' 
			Me.gunaLineTextBox7.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.gunaLineTextBox7.Animated = True
			Me.gunaLineTextBox7.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(40)))), (CInt((CByte(40)))), (CInt((CByte(40)))))
			Me.gunaLineTextBox7.Cursor = System.Windows.Forms.Cursors.IBeam
			Me.gunaLineTextBox7.FocusedLineColor = System.Drawing.Color.Red
			Me.gunaLineTextBox7.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.gunaLineTextBox7.LineColor = System.Drawing.Color.Gainsboro
			Me.gunaLineTextBox7.LineSize = 1
			Me.gunaLineTextBox7.Location = New System.Drawing.Point(144, 160)
			Me.gunaLineTextBox7.MaxLength = 2147483647
			Me.gunaLineTextBox7.Name = "gunaLineTextBox7"
			Me.gunaLineTextBox7.PasswordChar = ControlChars.NullChar
			Me.gunaLineTextBox7.Size = New System.Drawing.Size(641, 26)
			Me.gunaLineTextBox7.TabIndex = 5
			Me.gunaLineTextBox7.Text = "Insert the message reference here."
			Me.gunaLineTextBox7.TextOffsetX = 0
			' 
			' gunaLineTextBox6
			' 
			Me.gunaLineTextBox6.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.gunaLineTextBox6.Animated = True
			Me.gunaLineTextBox6.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(40)))), (CInt((CByte(40)))), (CInt((CByte(40)))))
			Me.gunaLineTextBox6.Cursor = System.Windows.Forms.Cursors.IBeam
			Me.gunaLineTextBox6.FocusedLineColor = System.Drawing.Color.Red
			Me.gunaLineTextBox6.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.gunaLineTextBox6.LineColor = System.Drawing.Color.Gainsboro
			Me.gunaLineTextBox6.LineSize = 1
			Me.gunaLineTextBox6.Location = New System.Drawing.Point(144, 128)
			Me.gunaLineTextBox6.MaxLength = 2147483647
			Me.gunaLineTextBox6.Name = "gunaLineTextBox6"
			Me.gunaLineTextBox6.PasswordChar = ControlChars.NullChar
			Me.gunaLineTextBox6.Size = New System.Drawing.Size(641, 26)
			Me.gunaLineTextBox6.TabIndex = 4
			Me.gunaLineTextBox6.Text = "Insert the user ID here."
			Me.gunaLineTextBox6.TextOffsetX = 0
			' 
			' metroLabel4
			' 
			Me.metroLabel4.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.metroLabel4.BackColor = System.Drawing.Color.Transparent
			Me.metroLabel4.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.metroLabel4.Location = New System.Drawing.Point(-1, 8)
			Me.metroLabel4.Name = "metroLabel4"
			Me.metroLabel4.Size = New System.Drawing.Size(931, 23)
			Me.metroLabel4.TabIndex = 1
			Me.metroLabel4.Text = "DM Spammer"
			Me.metroLabel4.TextAlign = System.Drawing.ContentAlignment.TopCenter
			' 
			' bunifuHSlider3
			' 
			Me.bunifuHSlider3.AllowCursorChanges = True
			Me.bunifuHSlider3.AllowHomeEndKeysDetection = False
			Me.bunifuHSlider3.AllowIncrementalClickMoves = True
			Me.bunifuHSlider3.AllowMouseDownEffects = False
			Me.bunifuHSlider3.AllowMouseHoverEffects = False
			Me.bunifuHSlider3.AllowScrollingAnimations = True
			Me.bunifuHSlider3.AllowScrollKeysDetection = True
			Me.bunifuHSlider3.AllowScrollOptionsMenu = True
			Me.bunifuHSlider3.AllowShrinkingOnFocusLost = False
			Me.bunifuHSlider3.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.bunifuHSlider3.BackColor = System.Drawing.Color.Transparent
			Me.bunifuHSlider3.BackgroundImage = (DirectCast(resources.GetObject("bunifuHSlider3.BackgroundImage"), System.Drawing.Image))
			Me.bunifuHSlider3.BindingContainer = Nothing
			Me.bunifuHSlider3.BorderRadius = 2
			Me.bunifuHSlider3.BorderThickness = 1
			Me.bunifuHSlider3.Cursor = System.Windows.Forms.Cursors.Hand
			Me.bunifuHSlider3.DrawThickBorder = False
			Me.bunifuHSlider3.DurationBeforeShrink = 2000
			Me.bunifuHSlider3.ElapsedColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.bunifuHSlider3.LargeChange = 10
			Me.bunifuHSlider3.Location = New System.Drawing.Point(144, 422)
			Me.bunifuHSlider3.Margin = New System.Windows.Forms.Padding(3, 7, 3, 7)
			Me.bunifuHSlider3.Maximum = 5000
			Me.bunifuHSlider3.Minimum = 0
			Me.bunifuHSlider3.MinimumSize = New System.Drawing.Size(0, 71)
			Me.bunifuHSlider3.MinimumThumbLength = 18
			Me.bunifuHSlider3.Name = "bunifuHSlider3"
			Me.bunifuHSlider3.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver
			Me.bunifuHSlider3.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent
			Me.bunifuHSlider3.OnDisable.ThumbColor = System.Drawing.Color.Silver
			Me.bunifuHSlider3.ScrollBarBorderColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.bunifuHSlider3.ScrollBarColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.bunifuHSlider3.ShrinkSizeLimit = 3
			Me.bunifuHSlider3.Size = New System.Drawing.Size(641, 71)
			Me.bunifuHSlider3.SliderColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.bunifuHSlider3.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin
			Me.bunifuHSlider3.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular
			Me.bunifuHSlider3.SmallChange = 1
			Me.bunifuHSlider3.TabIndex = 16
			Me.bunifuHSlider3.ThumbColor = System.Drawing.Color.Red
			Me.bunifuHSlider3.ThumbFillColor = System.Drawing.Color.Red
			Me.bunifuHSlider3.ThumbLength = 18
			Me.bunifuHSlider3.ThumbMargin = 1
			Me.bunifuHSlider3.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium
			Me.bunifuHSlider3.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Fill
			Me.bunifuHSlider3.Value = 0
'			Me.bunifuHSlider3.Scroll += New System.EventHandler(Of Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs)(Me.bunifuHSlider3_Scroll)
			' 
			' tabPage5
			' 
			Me.tabPage5.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(40)))), (CInt((CByte(40)))), (CInt((CByte(40)))))
			Me.tabPage5.Controls.Add(Me.siticoneButton7)
			Me.tabPage5.Controls.Add(Me.gunaButton8)
			Me.tabPage5.Controls.Add(Me.gunaButton7)
			Me.tabPage5.Controls.Add(Me.metroLabel20)
			Me.tabPage5.Controls.Add(Me.siticoneOSToggleSwith4)
			Me.tabPage5.Controls.Add(Me.siticoneRadioButton2)
			Me.tabPage5.Controls.Add(Me.siticoneRadioButton1)
			Me.tabPage5.Controls.Add(Me.gunaLineTextBox10)
			Me.tabPage5.Controls.Add(Me.gunaLineTextBox9)
			Me.tabPage5.Controls.Add(Me.gunaLineTextBox8)
			Me.tabPage5.Controls.Add(Me.metroLabel5)
			Me.tabPage5.Controls.Add(Me.bunifuHSlider4)
			Me.tabPage5.Font = New System.Drawing.Font("Segoe UI", 10F)
			Me.tabPage5.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(153)))), (CInt((CByte(153)))), (CInt((CByte(153)))))
			Me.tabPage5.Location = New System.Drawing.Point(184, 4)
			Me.tabPage5.Name = "tabPage5"
			Me.tabPage5.Padding = New System.Windows.Forms.Padding(3)
			Me.tabPage5.Size = New System.Drawing.Size(931, 581)
			Me.tabPage5.TabIndex = 4
			Me.tabPage5.Text = "Reaction Spammer"
			' 
			' siticoneButton7
			' 
			Me.siticoneButton7.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.siticoneButton7.BorderRadius = 15
			Me.siticoneButton7.CheckedState.Parent = Me.siticoneButton7
			Me.siticoneButton7.CustomImages.Parent = Me.siticoneButton7
			Me.siticoneButton7.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.siticoneButton7.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.siticoneButton7.ForeColor = System.Drawing.Color.White
			Me.siticoneButton7.HoveredState.Parent = Me.siticoneButton7
			Me.siticoneButton7.Location = New System.Drawing.Point(584, 119)
			Me.siticoneButton7.Name = "siticoneButton7"
			Me.siticoneButton7.ShadowDecoration.Parent = Me.siticoneButton7
			Me.siticoneButton7.Size = New System.Drawing.Size(204, 45)
			Me.siticoneButton7.TabIndex = 26
			Me.siticoneButton7.Text = "Fetch from message"
'			Me.siticoneButton7.Click += New System.EventHandler(Me.siticoneButton7_Click)
			' 
			' gunaButton8
			' 
			Me.gunaButton8.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.gunaButton8.Animated = True
			Me.gunaButton8.AnimationHoverSpeed = 0.07F
			Me.gunaButton8.AnimationSpeed = 0.03F
			Me.gunaButton8.BackColor = System.Drawing.Color.Transparent
			Me.gunaButton8.BaseColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.gunaButton8.BorderColor = System.Drawing.Color.Transparent
			Me.gunaButton8.DialogResult = System.Windows.Forms.DialogResult.None
			Me.gunaButton8.FocusedColor = System.Drawing.Color.Empty
			Me.gunaButton8.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.gunaButton8.ForeColor = System.Drawing.Color.White
			Me.gunaButton8.Image = Nothing
			Me.gunaButton8.ImageSize = New System.Drawing.Size(24, 24)
			Me.gunaButton8.Location = New System.Drawing.Point(468, 392)
			Me.gunaButton8.Name = "gunaButton8"
			Me.gunaButton8.OnHoverBaseColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.gunaButton8.OnHoverBorderColor = System.Drawing.Color.Black
			Me.gunaButton8.OnHoverForeColor = System.Drawing.Color.White
			Me.gunaButton8.OnHoverImage = Nothing
			Me.gunaButton8.OnPressedColor = System.Drawing.Color.Black
			Me.gunaButton8.Size = New System.Drawing.Size(317, 42)
			Me.gunaButton8.TabIndex = 25
			Me.gunaButton8.Text = "Remove reaction"
			Me.gunaButton8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
'			Me.gunaButton8.Click += New System.EventHandler(Me.gunaButton8_Click)
			' 
			' gunaButton7
			' 
			Me.gunaButton7.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.gunaButton7.Animated = True
			Me.gunaButton7.AnimationHoverSpeed = 0.07F
			Me.gunaButton7.AnimationSpeed = 0.03F
			Me.gunaButton7.BackColor = System.Drawing.Color.Transparent
			Me.gunaButton7.BaseColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.gunaButton7.BorderColor = System.Drawing.Color.Transparent
			Me.gunaButton7.DialogResult = System.Windows.Forms.DialogResult.None
			Me.gunaButton7.FocusedColor = System.Drawing.Color.Empty
			Me.gunaButton7.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.gunaButton7.ForeColor = System.Drawing.Color.White
			Me.gunaButton7.Image = Nothing
			Me.gunaButton7.ImageSize = New System.Drawing.Size(24, 24)
			Me.gunaButton7.Location = New System.Drawing.Point(144, 392)
			Me.gunaButton7.Name = "gunaButton7"
			Me.gunaButton7.OnHoverBaseColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.gunaButton7.OnHoverBorderColor = System.Drawing.Color.Black
			Me.gunaButton7.OnHoverForeColor = System.Drawing.Color.White
			Me.gunaButton7.OnHoverImage = Nothing
			Me.gunaButton7.OnPressedColor = System.Drawing.Color.Black
			Me.gunaButton7.Size = New System.Drawing.Size(317, 42)
			Me.gunaButton7.TabIndex = 24
			Me.gunaButton7.Text = "Add reaction"
			Me.gunaButton7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
'			Me.gunaButton7.Click += New System.EventHandler(Me.gunaButton7_Click)
			' 
			' metroLabel20
			' 
			Me.metroLabel20.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.metroLabel20.AutoSize = True
			Me.metroLabel20.BackColor = System.Drawing.Color.Transparent
			Me.metroLabel20.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.metroLabel20.Location = New System.Drawing.Point(724, 238)
			Me.metroLabel20.Name = "metroLabel20"
			Me.metroLabel20.Size = New System.Drawing.Size(64, 15)
			Me.metroLabel20.TabIndex = 22
			Me.metroLabel20.Text = "Delay: 0ms"
			Me.metroLabel20.TextAlign = System.Drawing.ContentAlignment.TopRight
			' 
			' siticoneOSToggleSwith4
			' 
			Me.siticoneOSToggleSwith4.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.siticoneOSToggleSwith4.CheckedFillColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.siticoneOSToggleSwith4.Location = New System.Drawing.Point(684, 235)
			Me.siticoneOSToggleSwith4.Name = "siticoneOSToggleSwith4"
			Me.siticoneOSToggleSwith4.Size = New System.Drawing.Size(38, 22)
			Me.siticoneOSToggleSwith4.TabIndex = 21
			' 
			' siticoneRadioButton2
			' 
			Me.siticoneRadioButton2.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.siticoneRadioButton2.AutoSize = True
			Me.siticoneRadioButton2.CheckedState.BorderColor = System.Drawing.Color.Red
			Me.siticoneRadioButton2.CheckedState.BorderThickness = 0
			Me.siticoneRadioButton2.CheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.siticoneRadioButton2.CheckedState.InnerColor = System.Drawing.Color.White
			Me.siticoneRadioButton2.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.siticoneRadioButton2.Location = New System.Drawing.Point(144, 258)
			Me.siticoneRadioButton2.Name = "siticoneRadioButton2"
			Me.siticoneRadioButton2.Size = New System.Drawing.Size(90, 17)
			Me.siticoneRadioButton2.TabIndex = 9
			Me.siticoneRadioButton2.Text = "Emote Mode"
			Me.siticoneRadioButton2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneRadioButton2.UncheckedState.BorderThickness = 2
			Me.siticoneRadioButton2.UncheckedState.FillColor = System.Drawing.Color.Transparent
			Me.siticoneRadioButton2.UncheckedState.InnerColor = System.Drawing.Color.Transparent
			Me.siticoneRadioButton2.UseVisualStyleBackColor = True
			' 
			' siticoneRadioButton1
			' 
			Me.siticoneRadioButton1.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.siticoneRadioButton1.AutoSize = True
			Me.siticoneRadioButton1.Checked = True
			Me.siticoneRadioButton1.CheckedState.BorderColor = System.Drawing.Color.Red
			Me.siticoneRadioButton1.CheckedState.BorderThickness = 0
			Me.siticoneRadioButton1.CheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.siticoneRadioButton1.CheckedState.InnerColor = System.Drawing.Color.White
			Me.siticoneRadioButton1.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.siticoneRadioButton1.Location = New System.Drawing.Point(144, 235)
			Me.siticoneRadioButton1.Name = "siticoneRadioButton1"
			Me.siticoneRadioButton1.Size = New System.Drawing.Size(86, 17)
			Me.siticoneRadioButton1.TabIndex = 8
			Me.siticoneRadioButton1.TabStop = True
			Me.siticoneRadioButton1.Text = "Emoji Mode"
			Me.siticoneRadioButton1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneRadioButton1.UncheckedState.BorderThickness = 2
			Me.siticoneRadioButton1.UncheckedState.FillColor = System.Drawing.Color.Transparent
			Me.siticoneRadioButton1.UncheckedState.InnerColor = System.Drawing.Color.Transparent
			Me.siticoneRadioButton1.UseVisualStyleBackColor = True
			' 
			' gunaLineTextBox10
			' 
			Me.gunaLineTextBox10.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.gunaLineTextBox10.Animated = True
			Me.gunaLineTextBox10.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(40)))), (CInt((CByte(40)))), (CInt((CByte(40)))))
			Me.gunaLineTextBox10.Cursor = System.Windows.Forms.Cursors.IBeam
			Me.gunaLineTextBox10.FocusedLineColor = System.Drawing.Color.Red
			Me.gunaLineTextBox10.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.gunaLineTextBox10.LineColor = System.Drawing.Color.Gainsboro
			Me.gunaLineTextBox10.LineSize = 1
			Me.gunaLineTextBox10.Location = New System.Drawing.Point(144, 192)
			Me.gunaLineTextBox10.MaxLength = 2147483647
			Me.gunaLineTextBox10.Name = "gunaLineTextBox10"
			Me.gunaLineTextBox10.PasswordChar = ControlChars.NullChar
			Me.gunaLineTextBox10.Size = New System.Drawing.Size(641, 26)
			Me.gunaLineTextBox10.TabIndex = 7
			Me.gunaLineTextBox10.Text = "Insert the message ID here."
			Me.gunaLineTextBox10.TextOffsetX = 0
			' 
			' gunaLineTextBox9
			' 
			Me.gunaLineTextBox9.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.gunaLineTextBox9.Animated = True
			Me.gunaLineTextBox9.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(40)))), (CInt((CByte(40)))), (CInt((CByte(40)))))
			Me.gunaLineTextBox9.Cursor = System.Windows.Forms.Cursors.IBeam
			Me.gunaLineTextBox9.FocusedLineColor = System.Drawing.Color.Red
			Me.gunaLineTextBox9.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.gunaLineTextBox9.LineColor = System.Drawing.Color.Gainsboro
			Me.gunaLineTextBox9.LineSize = 1
			Me.gunaLineTextBox9.Location = New System.Drawing.Point(144, 160)
			Me.gunaLineTextBox9.MaxLength = 2147483647
			Me.gunaLineTextBox9.Name = "gunaLineTextBox9"
			Me.gunaLineTextBox9.PasswordChar = ControlChars.NullChar
			Me.gunaLineTextBox9.Size = New System.Drawing.Size(641, 26)
			Me.gunaLineTextBox9.TabIndex = 6
			Me.gunaLineTextBox9.Text = "Insert the channel ID here."
			Me.gunaLineTextBox9.TextOffsetX = 0
			' 
			' gunaLineTextBox8
			' 
			Me.gunaLineTextBox8.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.gunaLineTextBox8.Animated = True
			Me.gunaLineTextBox8.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(40)))), (CInt((CByte(40)))), (CInt((CByte(40)))))
			Me.gunaLineTextBox8.Cursor = System.Windows.Forms.Cursors.IBeam
			Me.gunaLineTextBox8.FocusedLineColor = System.Drawing.Color.Red
			Me.gunaLineTextBox8.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.gunaLineTextBox8.LineColor = System.Drawing.Color.Gainsboro
			Me.gunaLineTextBox8.LineSize = 1
			Me.gunaLineTextBox8.Location = New System.Drawing.Point(144, 128)
			Me.gunaLineTextBox8.MaxLength = 2147483647
			Me.gunaLineTextBox8.Name = "gunaLineTextBox8"
			Me.gunaLineTextBox8.PasswordChar = ControlChars.NullChar
			Me.gunaLineTextBox8.Size = New System.Drawing.Size(434, 26)
			Me.gunaLineTextBox8.TabIndex = 5
			Me.gunaLineTextBox8.Text = "Insert the emoji or the <emote_name:emote_id> here."
			Me.gunaLineTextBox8.TextOffsetX = 0
			' 
			' metroLabel5
			' 
			Me.metroLabel5.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.metroLabel5.BackColor = System.Drawing.Color.Transparent
			Me.metroLabel5.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.metroLabel5.Location = New System.Drawing.Point(-1, 8)
			Me.metroLabel5.Name = "metroLabel5"
			Me.metroLabel5.Size = New System.Drawing.Size(931, 23)
			Me.metroLabel5.TabIndex = 1
			Me.metroLabel5.Text = "Reaction Spammer"
			Me.metroLabel5.TextAlign = System.Drawing.ContentAlignment.TopCenter
			' 
			' bunifuHSlider4
			' 
			Me.bunifuHSlider4.AllowCursorChanges = True
			Me.bunifuHSlider4.AllowHomeEndKeysDetection = False
			Me.bunifuHSlider4.AllowIncrementalClickMoves = True
			Me.bunifuHSlider4.AllowMouseDownEffects = False
			Me.bunifuHSlider4.AllowMouseHoverEffects = False
			Me.bunifuHSlider4.AllowScrollingAnimations = True
			Me.bunifuHSlider4.AllowScrollKeysDetection = True
			Me.bunifuHSlider4.AllowScrollOptionsMenu = True
			Me.bunifuHSlider4.AllowShrinkingOnFocusLost = False
			Me.bunifuHSlider4.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.bunifuHSlider4.BackColor = System.Drawing.Color.Transparent
			Me.bunifuHSlider4.BackgroundImage = (DirectCast(resources.GetObject("bunifuHSlider4.BackgroundImage"), System.Drawing.Image))
			Me.bunifuHSlider4.BindingContainer = Nothing
			Me.bunifuHSlider4.BorderRadius = 2
			Me.bunifuHSlider4.BorderThickness = 1
			Me.bunifuHSlider4.Cursor = System.Windows.Forms.Cursors.Hand
			Me.bunifuHSlider4.DrawThickBorder = False
			Me.bunifuHSlider4.DurationBeforeShrink = 2000
			Me.bunifuHSlider4.ElapsedColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.bunifuHSlider4.LargeChange = 10
			Me.bunifuHSlider4.Location = New System.Drawing.Point(144, 287)
			Me.bunifuHSlider4.Margin = New System.Windows.Forms.Padding(3, 9, 3, 9)
			Me.bunifuHSlider4.Maximum = 5000
			Me.bunifuHSlider4.Minimum = 0
			Me.bunifuHSlider4.MinimumSize = New System.Drawing.Size(0, 93)
			Me.bunifuHSlider4.MinimumThumbLength = 18
			Me.bunifuHSlider4.Name = "bunifuHSlider4"
			Me.bunifuHSlider4.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver
			Me.bunifuHSlider4.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent
			Me.bunifuHSlider4.OnDisable.ThumbColor = System.Drawing.Color.Silver
			Me.bunifuHSlider4.ScrollBarBorderColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.bunifuHSlider4.ScrollBarColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.bunifuHSlider4.ShrinkSizeLimit = 3
			Me.bunifuHSlider4.Size = New System.Drawing.Size(644, 93)
			Me.bunifuHSlider4.SliderColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.bunifuHSlider4.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin
			Me.bunifuHSlider4.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular
			Me.bunifuHSlider4.SmallChange = 1
			Me.bunifuHSlider4.TabIndex = 23
			Me.bunifuHSlider4.ThumbColor = System.Drawing.Color.Red
			Me.bunifuHSlider4.ThumbFillColor = System.Drawing.Color.Red
			Me.bunifuHSlider4.ThumbLength = 18
			Me.bunifuHSlider4.ThumbMargin = 1
			Me.bunifuHSlider4.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium
			Me.bunifuHSlider4.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Fill
			Me.bunifuHSlider4.Value = 0
'			Me.bunifuHSlider4.Scroll += New System.EventHandler(Of Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs)(Me.bunifuHSlider4_Scroll)
			' 
			' tabPage6
			' 
			Me.tabPage6.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(40)))), (CInt((CByte(40)))), (CInt((CByte(40)))))
			Me.tabPage6.Controls.Add(Me.siticoneCheckBox35)
			Me.tabPage6.Controls.Add(Me.bunifuHSlider5)
			Me.tabPage6.Controls.Add(Me.gunaButton9)
			Me.tabPage6.Controls.Add(Me.gunaButton10)
			Me.tabPage6.Controls.Add(Me.metroLabel21)
			Me.tabPage6.Controls.Add(Me.siticoneOSToggleSwith5)
			Me.tabPage6.Controls.Add(Me.siticoneCheckBox5)
			Me.tabPage6.Controls.Add(Me.gunaLineTextBox11)
			Me.tabPage6.Controls.Add(Me.metroLabel6)
			Me.tabPage6.Font = New System.Drawing.Font("Segoe UI", 10F)
			Me.tabPage6.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(153)))), (CInt((CByte(153)))), (CInt((CByte(153)))))
			Me.tabPage6.Location = New System.Drawing.Point(184, 4)
			Me.tabPage6.Name = "tabPage6"
			Me.tabPage6.Padding = New System.Windows.Forms.Padding(3)
			Me.tabPage6.Size = New System.Drawing.Size(931, 581)
			Me.tabPage6.TabIndex = 5
			Me.tabPage6.Text = "Friend Spammer"
			' 
			' siticoneCheckBox35
			' 
			Me.siticoneCheckBox35.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.siticoneCheckBox35.AutoSize = True
			Me.siticoneCheckBox35.CheckedState.BorderColor = System.Drawing.Color.Red
			Me.siticoneCheckBox35.CheckedState.BorderRadius = 2
			Me.siticoneCheckBox35.CheckedState.BorderThickness = 0
			Me.siticoneCheckBox35.CheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.siticoneCheckBox35.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.siticoneCheckBox35.Location = New System.Drawing.Point(144, 196)
			Me.siticoneCheckBox35.Name = "siticoneCheckBox35"
			Me.siticoneCheckBox35.Size = New System.Drawing.Size(87, 17)
			Me.siticoneCheckBox35.TabIndex = 29
			Me.siticoneCheckBox35.Text = "Spam Mode"
			Me.siticoneCheckBox35.UncheckedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneCheckBox35.UncheckedState.BorderRadius = 2
			Me.siticoneCheckBox35.UncheckedState.BorderThickness = 0
			Me.siticoneCheckBox35.UncheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneCheckBox35.UseVisualStyleBackColor = True
'			Me.siticoneCheckBox35.CheckedChanged += New System.EventHandler(Me.siticoneCheckBox35_CheckedChanged)
			' 
			' bunifuHSlider5
			' 
			Me.bunifuHSlider5.AllowCursorChanges = True
			Me.bunifuHSlider5.AllowHomeEndKeysDetection = False
			Me.bunifuHSlider5.AllowIncrementalClickMoves = True
			Me.bunifuHSlider5.AllowMouseDownEffects = False
			Me.bunifuHSlider5.AllowMouseHoverEffects = False
			Me.bunifuHSlider5.AllowScrollingAnimations = True
			Me.bunifuHSlider5.AllowScrollKeysDetection = True
			Me.bunifuHSlider5.AllowScrollOptionsMenu = True
			Me.bunifuHSlider5.AllowShrinkingOnFocusLost = False
			Me.bunifuHSlider5.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.bunifuHSlider5.BackColor = System.Drawing.Color.Transparent
			Me.bunifuHSlider5.BackgroundImage = (DirectCast(resources.GetObject("bunifuHSlider5.BackgroundImage"), System.Drawing.Image))
			Me.bunifuHSlider5.BindingContainer = Nothing
			Me.bunifuHSlider5.BorderRadius = 2
			Me.bunifuHSlider5.BorderThickness = 1
			Me.bunifuHSlider5.Cursor = System.Windows.Forms.Cursors.Hand
			Me.bunifuHSlider5.DrawThickBorder = False
			Me.bunifuHSlider5.DurationBeforeShrink = 2000
			Me.bunifuHSlider5.ElapsedColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.bunifuHSlider5.LargeChange = 10
			Me.bunifuHSlider5.Location = New System.Drawing.Point(144, 226)
			Me.bunifuHSlider5.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
			Me.bunifuHSlider5.Maximum = 5000
			Me.bunifuHSlider5.Minimum = 0
			Me.bunifuHSlider5.MinimumSize = New System.Drawing.Size(0, 54)
			Me.bunifuHSlider5.MinimumThumbLength = 18
			Me.bunifuHSlider5.Name = "bunifuHSlider5"
			Me.bunifuHSlider5.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver
			Me.bunifuHSlider5.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent
			Me.bunifuHSlider5.OnDisable.ThumbColor = System.Drawing.Color.Silver
			Me.bunifuHSlider5.ScrollBarBorderColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.bunifuHSlider5.ScrollBarColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.bunifuHSlider5.ShrinkSizeLimit = 3
			Me.bunifuHSlider5.Size = New System.Drawing.Size(644, 54)
			Me.bunifuHSlider5.SliderColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.bunifuHSlider5.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin
			Me.bunifuHSlider5.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular
			Me.bunifuHSlider5.SmallChange = 1
			Me.bunifuHSlider5.TabIndex = 28
			Me.bunifuHSlider5.ThumbColor = System.Drawing.Color.Red
			Me.bunifuHSlider5.ThumbFillColor = System.Drawing.Color.Red
			Me.bunifuHSlider5.ThumbLength = 18
			Me.bunifuHSlider5.ThumbMargin = 1
			Me.bunifuHSlider5.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium
			Me.bunifuHSlider5.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Fill
			Me.bunifuHSlider5.Value = 0
'			Me.bunifuHSlider5.Scroll += New System.EventHandler(Of Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs)(Me.bunifuHSlider5_Scroll)
			' 
			' gunaButton9
			' 
			Me.gunaButton9.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.gunaButton9.Animated = True
			Me.gunaButton9.AnimationHoverSpeed = 0.07F
			Me.gunaButton9.AnimationSpeed = 0.03F
			Me.gunaButton9.BackColor = System.Drawing.Color.Transparent
			Me.gunaButton9.BaseColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.gunaButton9.BorderColor = System.Drawing.Color.Transparent
			Me.gunaButton9.DialogResult = System.Windows.Forms.DialogResult.None
			Me.gunaButton9.FocusedColor = System.Drawing.Color.Empty
			Me.gunaButton9.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.gunaButton9.ForeColor = System.Drawing.Color.White
			Me.gunaButton9.Image = Nothing
			Me.gunaButton9.ImageSize = New System.Drawing.Size(24, 24)
			Me.gunaButton9.Location = New System.Drawing.Point(471, 300)
			Me.gunaButton9.Name = "gunaButton9"
			Me.gunaButton9.OnHoverBaseColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.gunaButton9.OnHoverBorderColor = System.Drawing.Color.Black
			Me.gunaButton9.OnHoverForeColor = System.Drawing.Color.White
			Me.gunaButton9.OnHoverImage = Nothing
			Me.gunaButton9.OnPressedColor = System.Drawing.Color.Black
			Me.gunaButton9.Size = New System.Drawing.Size(317, 42)
			Me.gunaButton9.TabIndex = 27
			Me.gunaButton9.Text = "Remove friend"
			Me.gunaButton9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
'			Me.gunaButton9.Click += New System.EventHandler(Me.gunaButton9_Click)
			' 
			' gunaButton10
			' 
			Me.gunaButton10.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.gunaButton10.Animated = True
			Me.gunaButton10.AnimationHoverSpeed = 0.07F
			Me.gunaButton10.AnimationSpeed = 0.03F
			Me.gunaButton10.BackColor = System.Drawing.Color.Transparent
			Me.gunaButton10.BaseColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.gunaButton10.BorderColor = System.Drawing.Color.Transparent
			Me.gunaButton10.DialogResult = System.Windows.Forms.DialogResult.None
			Me.gunaButton10.FocusedColor = System.Drawing.Color.Empty
			Me.gunaButton10.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.gunaButton10.ForeColor = System.Drawing.Color.White
			Me.gunaButton10.Image = Nothing
			Me.gunaButton10.ImageSize = New System.Drawing.Size(24, 24)
			Me.gunaButton10.Location = New System.Drawing.Point(144, 300)
			Me.gunaButton10.Name = "gunaButton10"
			Me.gunaButton10.OnHoverBaseColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.gunaButton10.OnHoverBorderColor = System.Drawing.Color.Black
			Me.gunaButton10.OnHoverForeColor = System.Drawing.Color.White
			Me.gunaButton10.OnHoverImage = Nothing
			Me.gunaButton10.OnPressedColor = System.Drawing.Color.Black
			Me.gunaButton10.Size = New System.Drawing.Size(317, 42)
			Me.gunaButton10.TabIndex = 26
			Me.gunaButton10.Text = "Add friend"
			Me.gunaButton10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
'			Me.gunaButton10.Click += New System.EventHandler(Me.gunaButton10_Click)
			' 
			' metroLabel21
			' 
			Me.metroLabel21.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.metroLabel21.AutoSize = True
			Me.metroLabel21.BackColor = System.Drawing.Color.Transparent
			Me.metroLabel21.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.metroLabel21.Location = New System.Drawing.Point(724, 176)
			Me.metroLabel21.Name = "metroLabel21"
			Me.metroLabel21.Size = New System.Drawing.Size(64, 15)
			Me.metroLabel21.TabIndex = 24
			Me.metroLabel21.Text = "Delay: 0ms"
			Me.metroLabel21.TextAlign = System.Drawing.ContentAlignment.TopRight
			' 
			' siticoneOSToggleSwith5
			' 
			Me.siticoneOSToggleSwith5.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.siticoneOSToggleSwith5.CheckedFillColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.siticoneOSToggleSwith5.Location = New System.Drawing.Point(684, 173)
			Me.siticoneOSToggleSwith5.Name = "siticoneOSToggleSwith5"
			Me.siticoneOSToggleSwith5.Size = New System.Drawing.Size(38, 22)
			Me.siticoneOSToggleSwith5.TabIndex = 23
			' 
			' siticoneCheckBox5
			' 
			Me.siticoneCheckBox5.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.siticoneCheckBox5.AutoSize = True
			Me.siticoneCheckBox5.CheckedState.BorderColor = System.Drawing.Color.Red
			Me.siticoneCheckBox5.CheckedState.BorderRadius = 2
			Me.siticoneCheckBox5.CheckedState.BorderThickness = 0
			Me.siticoneCheckBox5.CheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.siticoneCheckBox5.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.siticoneCheckBox5.Location = New System.Drawing.Point(144, 173)
			Me.siticoneCheckBox5.Name = "siticoneCheckBox5"
			Me.siticoneCheckBox5.Size = New System.Drawing.Size(110, 17)
			Me.siticoneCheckBox5.TabIndex = 7
			Me.siticoneCheckBox5.Text = "Multiple Friends"
			Me.siticoneCheckBox5.UncheckedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneCheckBox5.UncheckedState.BorderRadius = 2
			Me.siticoneCheckBox5.UncheckedState.BorderThickness = 0
			Me.siticoneCheckBox5.UncheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneCheckBox5.UseVisualStyleBackColor = True
			' 
			' gunaLineTextBox11
			' 
			Me.gunaLineTextBox11.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.gunaLineTextBox11.Animated = True
			Me.gunaLineTextBox11.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(40)))), (CInt((CByte(40)))), (CInt((CByte(40)))))
			Me.gunaLineTextBox11.Cursor = System.Windows.Forms.Cursors.IBeam
			Me.gunaLineTextBox11.FocusedLineColor = System.Drawing.Color.Red
			Me.gunaLineTextBox11.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.gunaLineTextBox11.LineColor = System.Drawing.Color.Gainsboro
			Me.gunaLineTextBox11.LineSize = 1
			Me.gunaLineTextBox11.Location = New System.Drawing.Point(144, 128)
			Me.gunaLineTextBox11.MaxLength = 2147483647
			Me.gunaLineTextBox11.Name = "gunaLineTextBox11"
			Me.gunaLineTextBox11.PasswordChar = ControlChars.NullChar
			Me.gunaLineTextBox11.Size = New System.Drawing.Size(641, 26)
			Me.gunaLineTextBox11.TabIndex = 4
			Me.gunaLineTextBox11.Text = "Insert the username#tag or friend ID here."
			Me.gunaLineTextBox11.TextOffsetX = 0
			' 
			' metroLabel6
			' 
			Me.metroLabel6.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.metroLabel6.BackColor = System.Drawing.Color.Transparent
			Me.metroLabel6.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.metroLabel6.Location = New System.Drawing.Point(-1, 8)
			Me.metroLabel6.Name = "metroLabel6"
			Me.metroLabel6.Size = New System.Drawing.Size(931, 23)
			Me.metroLabel6.TabIndex = 1
			Me.metroLabel6.Text = "Friend Spammer"
			Me.metroLabel6.TextAlign = System.Drawing.ContentAlignment.TopCenter
			' 
			' tabPage7
			' 
			Me.tabPage7.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(40)))), (CInt((CByte(40)))), (CInt((CByte(40)))))
			Me.tabPage7.Controls.Add(Me.bunifuHSlider6)
			Me.tabPage7.Controls.Add(Me.gunaButton12)
			Me.tabPage7.Controls.Add(Me.gunaButton11)
			Me.tabPage7.Controls.Add(Me.metroLabel22)
			Me.tabPage7.Controls.Add(Me.siticoneOSToggleSwith6)
			Me.tabPage7.Controls.Add(Me.siticoneCheckBox13)
			Me.tabPage7.Controls.Add(Me.gunaLineTextBox12)
			Me.tabPage7.Controls.Add(Me.metroLabel7)
			Me.tabPage7.Font = New System.Drawing.Font("Segoe UI", 10F)
			Me.tabPage7.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(153)))), (CInt((CByte(153)))), (CInt((CByte(153)))))
			Me.tabPage7.Location = New System.Drawing.Point(184, 4)
			Me.tabPage7.Name = "tabPage7"
			Me.tabPage7.Padding = New System.Windows.Forms.Padding(3)
			Me.tabPage7.Size = New System.Drawing.Size(931, 581)
			Me.tabPage7.TabIndex = 6
			Me.tabPage7.Text = "Typing Spammer"
			' 
			' bunifuHSlider6
			' 
			Me.bunifuHSlider6.AllowCursorChanges = True
			Me.bunifuHSlider6.AllowHomeEndKeysDetection = False
			Me.bunifuHSlider6.AllowIncrementalClickMoves = True
			Me.bunifuHSlider6.AllowMouseDownEffects = False
			Me.bunifuHSlider6.AllowMouseHoverEffects = False
			Me.bunifuHSlider6.AllowScrollingAnimations = True
			Me.bunifuHSlider6.AllowScrollKeysDetection = True
			Me.bunifuHSlider6.AllowScrollOptionsMenu = True
			Me.bunifuHSlider6.AllowShrinkingOnFocusLost = False
			Me.bunifuHSlider6.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.bunifuHSlider6.BackColor = System.Drawing.Color.Transparent
			Me.bunifuHSlider6.BackgroundImage = (DirectCast(resources.GetObject("bunifuHSlider6.BackgroundImage"), System.Drawing.Image))
			Me.bunifuHSlider6.BindingContainer = Nothing
			Me.bunifuHSlider6.BorderRadius = 2
			Me.bunifuHSlider6.BorderThickness = 1
			Me.bunifuHSlider6.Cursor = System.Windows.Forms.Cursors.Hand
			Me.bunifuHSlider6.DrawThickBorder = False
			Me.bunifuHSlider6.DurationBeforeShrink = 2000
			Me.bunifuHSlider6.ElapsedColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.bunifuHSlider6.LargeChange = 10
			Me.bunifuHSlider6.Location = New System.Drawing.Point(144, 226)
			Me.bunifuHSlider6.Margin = New System.Windows.Forms.Padding(3, 7, 3, 7)
			Me.bunifuHSlider6.Maximum = 5000
			Me.bunifuHSlider6.Minimum = 0
			Me.bunifuHSlider6.MinimumSize = New System.Drawing.Size(0, 71)
			Me.bunifuHSlider6.MinimumThumbLength = 18
			Me.bunifuHSlider6.Name = "bunifuHSlider6"
			Me.bunifuHSlider6.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver
			Me.bunifuHSlider6.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent
			Me.bunifuHSlider6.OnDisable.ThumbColor = System.Drawing.Color.Silver
			Me.bunifuHSlider6.ScrollBarBorderColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.bunifuHSlider6.ScrollBarColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.bunifuHSlider6.ShrinkSizeLimit = 3
			Me.bunifuHSlider6.Size = New System.Drawing.Size(644, 71)
			Me.bunifuHSlider6.SliderColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.bunifuHSlider6.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin
			Me.bunifuHSlider6.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular
			Me.bunifuHSlider6.SmallChange = 1
			Me.bunifuHSlider6.TabIndex = 32
			Me.bunifuHSlider6.ThumbColor = System.Drawing.Color.Red
			Me.bunifuHSlider6.ThumbFillColor = System.Drawing.Color.Red
			Me.bunifuHSlider6.ThumbLength = 18
			Me.bunifuHSlider6.ThumbMargin = 1
			Me.bunifuHSlider6.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium
			Me.bunifuHSlider6.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Fill
			Me.bunifuHSlider6.Value = 0
'			Me.bunifuHSlider6.Scroll += New System.EventHandler(Of Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs)(Me.bunifuHSlider6_Scroll)
			' 
			' gunaButton12
			' 
			Me.gunaButton12.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.gunaButton12.Animated = True
			Me.gunaButton12.AnimationHoverSpeed = 0.07F
			Me.gunaButton12.AnimationSpeed = 0.03F
			Me.gunaButton12.BackColor = System.Drawing.Color.Transparent
			Me.gunaButton12.BaseColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.gunaButton12.BorderColor = System.Drawing.Color.Transparent
			Me.gunaButton12.DialogResult = System.Windows.Forms.DialogResult.None
			Me.gunaButton12.Enabled = False
			Me.gunaButton12.FocusedColor = System.Drawing.Color.Empty
			Me.gunaButton12.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.gunaButton12.ForeColor = System.Drawing.Color.White
			Me.gunaButton12.Image = Nothing
			Me.gunaButton12.ImageSize = New System.Drawing.Size(24, 24)
			Me.gunaButton12.Location = New System.Drawing.Point(471, 300)
			Me.gunaButton12.Name = "gunaButton12"
			Me.gunaButton12.OnHoverBaseColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.gunaButton12.OnHoverBorderColor = System.Drawing.Color.Black
			Me.gunaButton12.OnHoverForeColor = System.Drawing.Color.White
			Me.gunaButton12.OnHoverImage = Nothing
			Me.gunaButton12.OnPressedColor = System.Drawing.Color.Black
			Me.gunaButton12.Size = New System.Drawing.Size(317, 42)
			Me.gunaButton12.TabIndex = 31
			Me.gunaButton12.Text = "Stop Spamming"
			Me.gunaButton12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
'			Me.gunaButton12.Click += New System.EventHandler(Me.gunaButton12_Click)
			' 
			' gunaButton11
			' 
			Me.gunaButton11.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.gunaButton11.Animated = True
			Me.gunaButton11.AnimationHoverSpeed = 0.07F
			Me.gunaButton11.AnimationSpeed = 0.03F
			Me.gunaButton11.BackColor = System.Drawing.Color.Transparent
			Me.gunaButton11.BaseColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.gunaButton11.BorderColor = System.Drawing.Color.Transparent
			Me.gunaButton11.DialogResult = System.Windows.Forms.DialogResult.None
			Me.gunaButton11.FocusedColor = System.Drawing.Color.Empty
			Me.gunaButton11.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.gunaButton11.ForeColor = System.Drawing.Color.White
			Me.gunaButton11.Image = Nothing
			Me.gunaButton11.ImageSize = New System.Drawing.Size(24, 24)
			Me.gunaButton11.Location = New System.Drawing.Point(144, 300)
			Me.gunaButton11.Name = "gunaButton11"
			Me.gunaButton11.OnHoverBaseColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.gunaButton11.OnHoverBorderColor = System.Drawing.Color.Black
			Me.gunaButton11.OnHoverForeColor = System.Drawing.Color.White
			Me.gunaButton11.OnHoverImage = Nothing
			Me.gunaButton11.OnPressedColor = System.Drawing.Color.Black
			Me.gunaButton11.Size = New System.Drawing.Size(317, 42)
			Me.gunaButton11.TabIndex = 30
			Me.gunaButton11.Text = "Start Spamming"
			Me.gunaButton11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
'			Me.gunaButton11.Click += New System.EventHandler(Me.gunaButton11_Click)
			' 
			' metroLabel22
			' 
			Me.metroLabel22.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.metroLabel22.AutoSize = True
			Me.metroLabel22.BackColor = System.Drawing.Color.Transparent
			Me.metroLabel22.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.metroLabel22.Location = New System.Drawing.Point(724, 176)
			Me.metroLabel22.Name = "metroLabel22"
			Me.metroLabel22.Size = New System.Drawing.Size(64, 15)
			Me.metroLabel22.TabIndex = 26
			Me.metroLabel22.Text = "Delay: 0ms"
			Me.metroLabel22.TextAlign = System.Drawing.ContentAlignment.TopRight
			' 
			' siticoneOSToggleSwith6
			' 
			Me.siticoneOSToggleSwith6.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.siticoneOSToggleSwith6.CheckedFillColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.siticoneOSToggleSwith6.Location = New System.Drawing.Point(684, 173)
			Me.siticoneOSToggleSwith6.Name = "siticoneOSToggleSwith6"
			Me.siticoneOSToggleSwith6.Size = New System.Drawing.Size(38, 22)
			Me.siticoneOSToggleSwith6.TabIndex = 25
			' 
			' siticoneCheckBox13
			' 
			Me.siticoneCheckBox13.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.siticoneCheckBox13.AutoSize = True
			Me.siticoneCheckBox13.CheckedState.BorderColor = System.Drawing.Color.Red
			Me.siticoneCheckBox13.CheckedState.BorderRadius = 2
			Me.siticoneCheckBox13.CheckedState.BorderThickness = 0
			Me.siticoneCheckBox13.CheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.siticoneCheckBox13.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.siticoneCheckBox13.Location = New System.Drawing.Point(144, 173)
			Me.siticoneCheckBox13.Name = "siticoneCheckBox13"
			Me.siticoneCheckBox13.Size = New System.Drawing.Size(120, 17)
			Me.siticoneCheckBox13.TabIndex = 8
			Me.siticoneCheckBox13.Text = "Multiple Channels"
			Me.siticoneCheckBox13.UncheckedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneCheckBox13.UncheckedState.BorderRadius = 2
			Me.siticoneCheckBox13.UncheckedState.BorderThickness = 0
			Me.siticoneCheckBox13.UncheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneCheckBox13.UseVisualStyleBackColor = True
			' 
			' gunaLineTextBox12
			' 
			Me.gunaLineTextBox12.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.gunaLineTextBox12.Animated = True
			Me.gunaLineTextBox12.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(40)))), (CInt((CByte(40)))), (CInt((CByte(40)))))
			Me.gunaLineTextBox12.Cursor = System.Windows.Forms.Cursors.IBeam
			Me.gunaLineTextBox12.FocusedLineColor = System.Drawing.Color.Red
			Me.gunaLineTextBox12.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.gunaLineTextBox12.LineColor = System.Drawing.Color.Gainsboro
			Me.gunaLineTextBox12.LineSize = 1
			Me.gunaLineTextBox12.Location = New System.Drawing.Point(144, 128)
			Me.gunaLineTextBox12.MaxLength = 2147483647
			Me.gunaLineTextBox12.Name = "gunaLineTextBox12"
			Me.gunaLineTextBox12.PasswordChar = ControlChars.NullChar
			Me.gunaLineTextBox12.Size = New System.Drawing.Size(641, 26)
			Me.gunaLineTextBox12.TabIndex = 5
			Me.gunaLineTextBox12.Text = "Insert the channel ID here."
			Me.gunaLineTextBox12.TextOffsetX = 0
			' 
			' metroLabel7
			' 
			Me.metroLabel7.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.metroLabel7.BackColor = System.Drawing.Color.Transparent
			Me.metroLabel7.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.metroLabel7.Location = New System.Drawing.Point(-1, 8)
			Me.metroLabel7.Name = "metroLabel7"
			Me.metroLabel7.Size = New System.Drawing.Size(931, 23)
			Me.metroLabel7.TabIndex = 1
			Me.metroLabel7.Text = "Typing Spammer"
			Me.metroLabel7.TextAlign = System.Drawing.ContentAlignment.TopCenter
			' 
			' tabPage9
			' 
			Me.tabPage9.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(40)))), (CInt((CByte(40)))), (CInt((CByte(40)))))
			Me.tabPage9.Controls.Add(Me.gunaLineTextBox16)
			Me.tabPage9.Controls.Add(Me.gunaButton16)
			Me.tabPage9.Controls.Add(Me.gunaButton15)
			Me.tabPage9.Controls.Add(Me.siticoneCheckBox21)
			Me.tabPage9.Controls.Add(Me.siticoneCheckBox20)
			Me.tabPage9.Controls.Add(Me.siticoneCheckBox19)
			Me.tabPage9.Controls.Add(Me.siticoneCheckBox18)
			Me.tabPage9.Controls.Add(Me.siticoneCheckBox17)
			Me.tabPage9.Controls.Add(Me.siticoneCheckBox16)
			Me.tabPage9.Controls.Add(Me.siticoneCheckBox15)
			Me.tabPage9.Controls.Add(Me.siticoneCheckBox14)
			Me.tabPage9.Controls.Add(Me.metroLabel26)
			Me.tabPage9.Controls.Add(Me.siticoneOSToggleSwith10)
			Me.tabPage9.Controls.Add(Me.metroLabel25)
			Me.tabPage9.Controls.Add(Me.siticoneOSToggleSwith9)
			Me.tabPage9.Controls.Add(Me.gunaLineTextBox15)
			Me.tabPage9.Controls.Add(Me.gunaLineTextBox14)
			Me.tabPage9.Controls.Add(Me.metroLabel9)
			Me.tabPage9.Controls.Add(Me.bunifuHSlider10)
			Me.tabPage9.Controls.Add(Me.bunifuHSlider9)
			Me.tabPage9.Font = New System.Drawing.Font("Segoe UI", 10F)
			Me.tabPage9.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(153)))), (CInt((CByte(153)))), (CInt((CByte(153)))))
			Me.tabPage9.Location = New System.Drawing.Point(184, 4)
			Me.tabPage9.Name = "tabPage9"
			Me.tabPage9.Padding = New System.Windows.Forms.Padding(3)
			Me.tabPage9.Size = New System.Drawing.Size(931, 581)
			Me.tabPage9.TabIndex = 8
			Me.tabPage9.Text = "Voice Spammer"
			' 
			' gunaLineTextBox16
			' 
			Me.gunaLineTextBox16.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.gunaLineTextBox16.Animated = True
			Me.gunaLineTextBox16.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(40)))), (CInt((CByte(40)))), (CInt((CByte(40)))))
			Me.gunaLineTextBox16.Cursor = System.Windows.Forms.Cursors.IBeam
			Me.gunaLineTextBox16.FocusedLineColor = System.Drawing.Color.Red
			Me.gunaLineTextBox16.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.gunaLineTextBox16.LineColor = System.Drawing.Color.Gainsboro
			Me.gunaLineTextBox16.LineSize = 1
			Me.gunaLineTextBox16.Location = New System.Drawing.Point(144, 192)
			Me.gunaLineTextBox16.MaxLength = 2147483647
			Me.gunaLineTextBox16.Name = "gunaLineTextBox16"
			Me.gunaLineTextBox16.PasswordChar = ControlChars.NullChar
			Me.gunaLineTextBox16.Size = New System.Drawing.Size(641, 26)
			Me.gunaLineTextBox16.TabIndex = 46
			Me.gunaLineTextBox16.Text = "Insert the user ID where to join go live."
			Me.gunaLineTextBox16.TextOffsetX = 0
			' 
			' gunaButton16
			' 
			Me.gunaButton16.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.gunaButton16.Animated = True
			Me.gunaButton16.AnimationHoverSpeed = 0.07F
			Me.gunaButton16.AnimationSpeed = 0.03F
			Me.gunaButton16.BackColor = System.Drawing.Color.Transparent
			Me.gunaButton16.BaseColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.gunaButton16.BorderColor = System.Drawing.Color.Transparent
			Me.gunaButton16.DialogResult = System.Windows.Forms.DialogResult.None
			Me.gunaButton16.FocusedColor = System.Drawing.Color.Empty
			Me.gunaButton16.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.gunaButton16.ForeColor = System.Drawing.Color.White
			Me.gunaButton16.Image = Nothing
			Me.gunaButton16.ImageSize = New System.Drawing.Size(24, 24)
			Me.gunaButton16.Location = New System.Drawing.Point(468, 522)
			Me.gunaButton16.Name = "gunaButton16"
			Me.gunaButton16.OnHoverBaseColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.gunaButton16.OnHoverBorderColor = System.Drawing.Color.Black
			Me.gunaButton16.OnHoverForeColor = System.Drawing.Color.White
			Me.gunaButton16.OnHoverImage = Nothing
			Me.gunaButton16.OnPressedColor = System.Drawing.Color.Black
			Me.gunaButton16.Size = New System.Drawing.Size(317, 42)
			Me.gunaButton16.TabIndex = 45
			Me.gunaButton16.Text = "Leave voice"
			Me.gunaButton16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
'			Me.gunaButton16.Click += New System.EventHandler(Me.gunaButton16_Click)
			' 
			' gunaButton15
			' 
			Me.gunaButton15.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.gunaButton15.Animated = True
			Me.gunaButton15.AnimationHoverSpeed = 0.07F
			Me.gunaButton15.AnimationSpeed = 0.03F
			Me.gunaButton15.BackColor = System.Drawing.Color.Transparent
			Me.gunaButton15.BaseColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.gunaButton15.BorderColor = System.Drawing.Color.Transparent
			Me.gunaButton15.DialogResult = System.Windows.Forms.DialogResult.None
			Me.gunaButton15.FocusedColor = System.Drawing.Color.Empty
			Me.gunaButton15.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.gunaButton15.ForeColor = System.Drawing.Color.White
			Me.gunaButton15.Image = Nothing
			Me.gunaButton15.ImageSize = New System.Drawing.Size(24, 24)
			Me.gunaButton15.Location = New System.Drawing.Point(144, 522)
			Me.gunaButton15.Name = "gunaButton15"
			Me.gunaButton15.OnHoverBaseColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.gunaButton15.OnHoverBorderColor = System.Drawing.Color.Black
			Me.gunaButton15.OnHoverForeColor = System.Drawing.Color.White
			Me.gunaButton15.OnHoverImage = Nothing
			Me.gunaButton15.OnPressedColor = System.Drawing.Color.Black
			Me.gunaButton15.Size = New System.Drawing.Size(317, 42)
			Me.gunaButton15.TabIndex = 44
			Me.gunaButton15.Text = "Join voice"
			Me.gunaButton15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
'			Me.gunaButton15.Click += New System.EventHandler(Me.gunaButton15_Click)
			' 
			' siticoneCheckBox21
			' 
			Me.siticoneCheckBox21.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.siticoneCheckBox21.AutoSize = True
			Me.siticoneCheckBox21.CheckedState.BorderColor = System.Drawing.Color.Red
			Me.siticoneCheckBox21.CheckedState.BorderRadius = 2
			Me.siticoneCheckBox21.CheckedState.BorderThickness = 0
			Me.siticoneCheckBox21.CheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.siticoneCheckBox21.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.siticoneCheckBox21.Location = New System.Drawing.Point(275, 491)
			Me.siticoneCheckBox21.Name = "siticoneCheckBox21"
			Me.siticoneCheckBox21.Size = New System.Drawing.Size(82, 17)
			Me.siticoneCheckBox21.TabIndex = 43
			Me.siticoneCheckBox21.Text = "Auto Leave"
			Me.siticoneCheckBox21.UncheckedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneCheckBox21.UncheckedState.BorderRadius = 2
			Me.siticoneCheckBox21.UncheckedState.BorderThickness = 0
			Me.siticoneCheckBox21.UncheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneCheckBox21.UseVisualStyleBackColor = True
			' 
			' siticoneCheckBox20
			' 
			Me.siticoneCheckBox20.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.siticoneCheckBox20.AutoSize = True
			Me.siticoneCheckBox20.CheckedState.BorderColor = System.Drawing.Color.Red
			Me.siticoneCheckBox20.CheckedState.BorderRadius = 2
			Me.siticoneCheckBox20.CheckedState.BorderThickness = 0
			Me.siticoneCheckBox20.CheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.siticoneCheckBox20.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.siticoneCheckBox20.Location = New System.Drawing.Point(275, 468)
			Me.siticoneCheckBox20.Name = "siticoneCheckBox20"
			Me.siticoneCheckBox20.Size = New System.Drawing.Size(129, 17)
			Me.siticoneCheckBox20.TabIndex = 42
			Me.siticoneCheckBox20.Text = "Send speak in stage"
			Me.siticoneCheckBox20.UncheckedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneCheckBox20.UncheckedState.BorderRadius = 2
			Me.siticoneCheckBox20.UncheckedState.BorderThickness = 0
			Me.siticoneCheckBox20.UncheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneCheckBox20.UseVisualStyleBackColor = True
			' 
			' siticoneCheckBox19
			' 
			Me.siticoneCheckBox19.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.siticoneCheckBox19.AutoSize = True
			Me.siticoneCheckBox19.CheckedState.BorderColor = System.Drawing.Color.Red
			Me.siticoneCheckBox19.CheckedState.BorderRadius = 2
			Me.siticoneCheckBox19.CheckedState.BorderThickness = 0
			Me.siticoneCheckBox19.CheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.siticoneCheckBox19.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.siticoneCheckBox19.Location = New System.Drawing.Point(275, 445)
			Me.siticoneCheckBox19.Name = "siticoneCheckBox19"
			Me.siticoneCheckBox19.Size = New System.Drawing.Size(108, 17)
			Me.siticoneCheckBox19.TabIndex = 41
			Me.siticoneCheckBox19.Text = "Auto Reconnect"
			Me.siticoneCheckBox19.UncheckedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneCheckBox19.UncheckedState.BorderRadius = 2
			Me.siticoneCheckBox19.UncheckedState.BorderThickness = 0
			Me.siticoneCheckBox19.UncheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneCheckBox19.UseVisualStyleBackColor = True
'			Me.siticoneCheckBox19.CheckedChanged += New System.EventHandler(Me.siticoneCheckBox19_CheckedChanged)
			' 
			' siticoneCheckBox18
			' 
			Me.siticoneCheckBox18.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.siticoneCheckBox18.AutoSize = True
			Me.siticoneCheckBox18.CheckedState.BorderColor = System.Drawing.Color.Red
			Me.siticoneCheckBox18.CheckedState.BorderRadius = 2
			Me.siticoneCheckBox18.CheckedState.BorderThickness = 0
			Me.siticoneCheckBox18.CheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.siticoneCheckBox18.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.siticoneCheckBox18.Location = New System.Drawing.Point(275, 422)
			Me.siticoneCheckBox18.Name = "siticoneCheckBox18"
			Me.siticoneCheckBox18.Size = New System.Drawing.Size(87, 17)
			Me.siticoneCheckBox18.TabIndex = 40
			Me.siticoneCheckBox18.Text = "Join Go Live"
			Me.siticoneCheckBox18.UncheckedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneCheckBox18.UncheckedState.BorderRadius = 2
			Me.siticoneCheckBox18.UncheckedState.BorderThickness = 0
			Me.siticoneCheckBox18.UncheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneCheckBox18.UseVisualStyleBackColor = True
			' 
			' siticoneCheckBox17
			' 
			Me.siticoneCheckBox17.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.siticoneCheckBox17.AutoSize = True
			Me.siticoneCheckBox17.CheckedState.BorderColor = System.Drawing.Color.Red
			Me.siticoneCheckBox17.CheckedState.BorderRadius = 2
			Me.siticoneCheckBox17.CheckedState.BorderThickness = 0
			Me.siticoneCheckBox17.CheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.siticoneCheckBox17.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.siticoneCheckBox17.Location = New System.Drawing.Point(144, 491)
			Me.siticoneCheckBox17.Name = "siticoneCheckBox17"
			Me.siticoneCheckBox17.Size = New System.Drawing.Size(63, 17)
			Me.siticoneCheckBox17.TabIndex = 39
			Me.siticoneCheckBox17.Text = "Go Live"
			Me.siticoneCheckBox17.UncheckedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneCheckBox17.UncheckedState.BorderRadius = 2
			Me.siticoneCheckBox17.UncheckedState.BorderThickness = 0
			Me.siticoneCheckBox17.UncheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneCheckBox17.UseVisualStyleBackColor = True
			' 
			' siticoneCheckBox16
			' 
			Me.siticoneCheckBox16.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.siticoneCheckBox16.AutoSize = True
			Me.siticoneCheckBox16.CheckedState.BorderColor = System.Drawing.Color.Red
			Me.siticoneCheckBox16.CheckedState.BorderRadius = 2
			Me.siticoneCheckBox16.CheckedState.BorderThickness = 0
			Me.siticoneCheckBox16.CheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.siticoneCheckBox16.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.siticoneCheckBox16.Location = New System.Drawing.Point(144, 468)
			Me.siticoneCheckBox16.Name = "siticoneCheckBox16"
			Me.siticoneCheckBox16.Size = New System.Drawing.Size(101, 17)
			Me.siticoneCheckBox16.TabIndex = 38
			Me.siticoneCheckBox16.Text = "Video enabled"
			Me.siticoneCheckBox16.UncheckedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneCheckBox16.UncheckedState.BorderRadius = 2
			Me.siticoneCheckBox16.UncheckedState.BorderThickness = 0
			Me.siticoneCheckBox16.UncheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneCheckBox16.UseVisualStyleBackColor = True
			' 
			' siticoneCheckBox15
			' 
			Me.siticoneCheckBox15.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.siticoneCheckBox15.AutoSize = True
			Me.siticoneCheckBox15.CheckedState.BorderColor = System.Drawing.Color.Red
			Me.siticoneCheckBox15.CheckedState.BorderRadius = 2
			Me.siticoneCheckBox15.CheckedState.BorderThickness = 0
			Me.siticoneCheckBox15.CheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.siticoneCheckBox15.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.siticoneCheckBox15.Location = New System.Drawing.Point(144, 445)
			Me.siticoneCheckBox15.Name = "siticoneCheckBox15"
			Me.siticoneCheckBox15.Size = New System.Drawing.Size(128, 17)
			Me.siticoneCheckBox15.TabIndex = 37
			Me.siticoneCheckBox15.Text = "Headphones muted"
			Me.siticoneCheckBox15.UncheckedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneCheckBox15.UncheckedState.BorderRadius = 2
			Me.siticoneCheckBox15.UncheckedState.BorderThickness = 0
			Me.siticoneCheckBox15.UncheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneCheckBox15.UseVisualStyleBackColor = True
			' 
			' siticoneCheckBox14
			' 
			Me.siticoneCheckBox14.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.siticoneCheckBox14.AutoSize = True
			Me.siticoneCheckBox14.CheckedState.BorderColor = System.Drawing.Color.Red
			Me.siticoneCheckBox14.CheckedState.BorderRadius = 2
			Me.siticoneCheckBox14.CheckedState.BorderThickness = 0
			Me.siticoneCheckBox14.CheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.siticoneCheckBox14.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.siticoneCheckBox14.Location = New System.Drawing.Point(144, 422)
			Me.siticoneCheckBox14.Name = "siticoneCheckBox14"
			Me.siticoneCheckBox14.Size = New System.Drawing.Size(125, 17)
			Me.siticoneCheckBox14.TabIndex = 36
			Me.siticoneCheckBox14.Text = "Microphone muted"
			Me.siticoneCheckBox14.UncheckedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneCheckBox14.UncheckedState.BorderRadius = 2
			Me.siticoneCheckBox14.UncheckedState.BorderThickness = 0
			Me.siticoneCheckBox14.UncheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneCheckBox14.UseVisualStyleBackColor = True
			' 
			' metroLabel26
			' 
			Me.metroLabel26.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.metroLabel26.AutoSize = True
			Me.metroLabel26.BackColor = System.Drawing.Color.Transparent
			Me.metroLabel26.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.metroLabel26.Location = New System.Drawing.Point(721, 322)
			Me.metroLabel26.Name = "metroLabel26"
			Me.metroLabel26.Size = New System.Drawing.Size(91, 15)
			Me.metroLabel26.TabIndex = 33
			Me.metroLabel26.Text = "Auto leave: 0ms"
			Me.metroLabel26.TextAlign = System.Drawing.ContentAlignment.TopRight
			' 
			' siticoneOSToggleSwith10
			' 
			Me.siticoneOSToggleSwith10.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.siticoneOSToggleSwith10.CheckedFillColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.siticoneOSToggleSwith10.Location = New System.Drawing.Point(681, 319)
			Me.siticoneOSToggleSwith10.Name = "siticoneOSToggleSwith10"
			Me.siticoneOSToggleSwith10.Size = New System.Drawing.Size(38, 22)
			Me.siticoneOSToggleSwith10.TabIndex = 32
			' 
			' metroLabel25
			' 
			Me.metroLabel25.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.metroLabel25.AutoSize = True
			Me.metroLabel25.BackColor = System.Drawing.Color.Transparent
			Me.metroLabel25.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.metroLabel25.Location = New System.Drawing.Point(721, 234)
			Me.metroLabel25.Name = "metroLabel25"
			Me.metroLabel25.Size = New System.Drawing.Size(64, 15)
			Me.metroLabel25.TabIndex = 30
			Me.metroLabel25.Text = "Delay: 0ms"
			Me.metroLabel25.TextAlign = System.Drawing.ContentAlignment.TopRight
			' 
			' siticoneOSToggleSwith9
			' 
			Me.siticoneOSToggleSwith9.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.siticoneOSToggleSwith9.CheckedFillColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.siticoneOSToggleSwith9.Location = New System.Drawing.Point(681, 231)
			Me.siticoneOSToggleSwith9.Name = "siticoneOSToggleSwith9"
			Me.siticoneOSToggleSwith9.Size = New System.Drawing.Size(38, 22)
			Me.siticoneOSToggleSwith9.TabIndex = 29
			' 
			' gunaLineTextBox15
			' 
			Me.gunaLineTextBox15.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.gunaLineTextBox15.Animated = True
			Me.gunaLineTextBox15.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(40)))), (CInt((CByte(40)))), (CInt((CByte(40)))))
			Me.gunaLineTextBox15.Cursor = System.Windows.Forms.Cursors.IBeam
			Me.gunaLineTextBox15.FocusedLineColor = System.Drawing.Color.Red
			Me.gunaLineTextBox15.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.gunaLineTextBox15.LineColor = System.Drawing.Color.Gainsboro
			Me.gunaLineTextBox15.LineSize = 1
			Me.gunaLineTextBox15.Location = New System.Drawing.Point(144, 160)
			Me.gunaLineTextBox15.MaxLength = 2147483647
			Me.gunaLineTextBox15.Name = "gunaLineTextBox15"
			Me.gunaLineTextBox15.PasswordChar = ControlChars.NullChar
			Me.gunaLineTextBox15.Size = New System.Drawing.Size(641, 26)
			Me.gunaLineTextBox15.TabIndex = 7
			Me.gunaLineTextBox15.Text = "Insert the channel ID here."
			Me.gunaLineTextBox15.TextOffsetX = 0
			' 
			' gunaLineTextBox14
			' 
			Me.gunaLineTextBox14.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.gunaLineTextBox14.Animated = True
			Me.gunaLineTextBox14.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(40)))), (CInt((CByte(40)))), (CInt((CByte(40)))))
			Me.gunaLineTextBox14.Cursor = System.Windows.Forms.Cursors.IBeam
			Me.gunaLineTextBox14.FocusedLineColor = System.Drawing.Color.Red
			Me.gunaLineTextBox14.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.gunaLineTextBox14.LineColor = System.Drawing.Color.Gainsboro
			Me.gunaLineTextBox14.LineSize = 1
			Me.gunaLineTextBox14.Location = New System.Drawing.Point(144, 128)
			Me.gunaLineTextBox14.MaxLength = 2147483647
			Me.gunaLineTextBox14.Name = "gunaLineTextBox14"
			Me.gunaLineTextBox14.PasswordChar = ControlChars.NullChar
			Me.gunaLineTextBox14.Size = New System.Drawing.Size(641, 26)
			Me.gunaLineTextBox14.TabIndex = 6
			Me.gunaLineTextBox14.Text = "Insert the guild ID here."
			Me.gunaLineTextBox14.TextOffsetX = 0
			' 
			' metroLabel9
			' 
			Me.metroLabel9.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.metroLabel9.BackColor = System.Drawing.Color.Transparent
			Me.metroLabel9.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.metroLabel9.Location = New System.Drawing.Point(-1, 8)
			Me.metroLabel9.Name = "metroLabel9"
			Me.metroLabel9.Size = New System.Drawing.Size(931, 23)
			Me.metroLabel9.TabIndex = 1
			Me.metroLabel9.Text = "Voice Spammer"
			Me.metroLabel9.TextAlign = System.Drawing.ContentAlignment.TopCenter
			' 
			' bunifuHSlider10
			' 
			Me.bunifuHSlider10.AllowCursorChanges = True
			Me.bunifuHSlider10.AllowHomeEndKeysDetection = False
			Me.bunifuHSlider10.AllowIncrementalClickMoves = True
			Me.bunifuHSlider10.AllowMouseDownEffects = False
			Me.bunifuHSlider10.AllowMouseHoverEffects = False
			Me.bunifuHSlider10.AllowScrollingAnimations = True
			Me.bunifuHSlider10.AllowScrollKeysDetection = True
			Me.bunifuHSlider10.AllowScrollOptionsMenu = True
			Me.bunifuHSlider10.AllowShrinkingOnFocusLost = False
			Me.bunifuHSlider10.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.bunifuHSlider10.BackColor = System.Drawing.Color.Transparent
			Me.bunifuHSlider10.BackgroundImage = (DirectCast(resources.GetObject("bunifuHSlider10.BackgroundImage"), System.Drawing.Image))
			Me.bunifuHSlider10.BindingContainer = Nothing
			Me.bunifuHSlider10.BorderRadius = 2
			Me.bunifuHSlider10.BorderThickness = 1
			Me.bunifuHSlider10.Cursor = System.Windows.Forms.Cursors.Hand
			Me.bunifuHSlider10.DrawThickBorder = False
			Me.bunifuHSlider10.DurationBeforeShrink = 2000
			Me.bunifuHSlider10.ElapsedColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.bunifuHSlider10.LargeChange = 10
			Me.bunifuHSlider10.Location = New System.Drawing.Point(144, 349)
			Me.bunifuHSlider10.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
			Me.bunifuHSlider10.Maximum = 5000
			Me.bunifuHSlider10.Minimum = 0
			Me.bunifuHSlider10.MinimumSize = New System.Drawing.Size(0, 54)
			Me.bunifuHSlider10.MinimumThumbLength = 18
			Me.bunifuHSlider10.Name = "bunifuHSlider10"
			Me.bunifuHSlider10.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver
			Me.bunifuHSlider10.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent
			Me.bunifuHSlider10.OnDisable.ThumbColor = System.Drawing.Color.Silver
			Me.bunifuHSlider10.ScrollBarBorderColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.bunifuHSlider10.ScrollBarColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.bunifuHSlider10.ShrinkSizeLimit = 3
			Me.bunifuHSlider10.Size = New System.Drawing.Size(641, 54)
			Me.bunifuHSlider10.SliderColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.bunifuHSlider10.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin
			Me.bunifuHSlider10.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular
			Me.bunifuHSlider10.SmallChange = 1
			Me.bunifuHSlider10.TabIndex = 35
			Me.bunifuHSlider10.ThumbColor = System.Drawing.Color.Red
			Me.bunifuHSlider10.ThumbFillColor = System.Drawing.Color.Red
			Me.bunifuHSlider10.ThumbLength = 18
			Me.bunifuHSlider10.ThumbMargin = 1
			Me.bunifuHSlider10.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium
			Me.bunifuHSlider10.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Fill
			Me.bunifuHSlider10.Value = 0
'			Me.bunifuHSlider10.Scroll += New System.EventHandler(Of Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs)(Me.bunifuHSlider10_Scroll)
			' 
			' bunifuHSlider9
			' 
			Me.bunifuHSlider9.AllowCursorChanges = True
			Me.bunifuHSlider9.AllowHomeEndKeysDetection = False
			Me.bunifuHSlider9.AllowIncrementalClickMoves = True
			Me.bunifuHSlider9.AllowMouseDownEffects = False
			Me.bunifuHSlider9.AllowMouseHoverEffects = False
			Me.bunifuHSlider9.AllowScrollingAnimations = True
			Me.bunifuHSlider9.AllowScrollKeysDetection = True
			Me.bunifuHSlider9.AllowScrollOptionsMenu = True
			Me.bunifuHSlider9.AllowShrinkingOnFocusLost = False
			Me.bunifuHSlider9.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.bunifuHSlider9.BackColor = System.Drawing.Color.Transparent
			Me.bunifuHSlider9.BackgroundImage = (DirectCast(resources.GetObject("bunifuHSlider9.BackgroundImage"), System.Drawing.Image))
			Me.bunifuHSlider9.BindingContainer = Nothing
			Me.bunifuHSlider9.BorderRadius = 2
			Me.bunifuHSlider9.BorderThickness = 1
			Me.bunifuHSlider9.Cursor = System.Windows.Forms.Cursors.Hand
			Me.bunifuHSlider9.DrawThickBorder = False
			Me.bunifuHSlider9.DurationBeforeShrink = 2000
			Me.bunifuHSlider9.ElapsedColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.bunifuHSlider9.LargeChange = 10
			Me.bunifuHSlider9.Location = New System.Drawing.Point(144, 257)
			Me.bunifuHSlider9.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
			Me.bunifuHSlider9.Maximum = 5000
			Me.bunifuHSlider9.Minimum = 0
			Me.bunifuHSlider9.MinimumSize = New System.Drawing.Size(0, 54)
			Me.bunifuHSlider9.MinimumThumbLength = 18
			Me.bunifuHSlider9.Name = "bunifuHSlider9"
			Me.bunifuHSlider9.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver
			Me.bunifuHSlider9.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent
			Me.bunifuHSlider9.OnDisable.ThumbColor = System.Drawing.Color.Silver
			Me.bunifuHSlider9.ScrollBarBorderColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.bunifuHSlider9.ScrollBarColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.bunifuHSlider9.ShrinkSizeLimit = 3
			Me.bunifuHSlider9.Size = New System.Drawing.Size(641, 54)
			Me.bunifuHSlider9.SliderColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.bunifuHSlider9.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin
			Me.bunifuHSlider9.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular
			Me.bunifuHSlider9.SmallChange = 1
			Me.bunifuHSlider9.TabIndex = 34
			Me.bunifuHSlider9.ThumbColor = System.Drawing.Color.Red
			Me.bunifuHSlider9.ThumbFillColor = System.Drawing.Color.Red
			Me.bunifuHSlider9.ThumbLength = 18
			Me.bunifuHSlider9.ThumbMargin = 1
			Me.bunifuHSlider9.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium
			Me.bunifuHSlider9.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Fill
			Me.bunifuHSlider9.Value = 0
'			Me.bunifuHSlider9.Scroll += New System.EventHandler(Of Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs)(Me.bunifuHSlider9_Scroll)
			' 
			' tabPage10
			' 
			Me.tabPage10.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(40)))), (CInt((CByte(40)))), (CInt((CByte(40)))))
			Me.tabPage10.Controls.Add(Me.siticoneRadioButton9)
			Me.tabPage10.Controls.Add(Me.siticoneRadioButton10)
			Me.tabPage10.Controls.Add(Me.siticoneRadioButton11)
			Me.tabPage10.Controls.Add(Me.siticoneCheckBox27)
			Me.tabPage10.Controls.Add(Me.siticoneCheckBox22)
			Me.tabPage10.Controls.Add(Me.gunaButton18)
			Me.tabPage10.Controls.Add(Me.gunaButton17)
			Me.tabPage10.Controls.Add(Me.metroLabel27)
			Me.tabPage10.Controls.Add(Me.siticoneOSToggleSwith11)
			Me.tabPage10.Controls.Add(Me.gunaTextBox3)
			Me.tabPage10.Controls.Add(Me.gunaLineTextBox19)
			Me.tabPage10.Controls.Add(Me.gunaLineTextBox18)
			Me.tabPage10.Controls.Add(Me.gunaLineTextBox17)
			Me.tabPage10.Controls.Add(Me.metroLabel10)
			Me.tabPage10.Controls.Add(Me.bunifuHSlider11)
			Me.tabPage10.Font = New System.Drawing.Font("Segoe UI", 10F)
			Me.tabPage10.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(153)))), (CInt((CByte(153)))), (CInt((CByte(153)))))
			Me.tabPage10.Location = New System.Drawing.Point(184, 4)
			Me.tabPage10.Name = "tabPage10"
			Me.tabPage10.Padding = New System.Windows.Forms.Padding(3)
			Me.tabPage10.Size = New System.Drawing.Size(931, 581)
			Me.tabPage10.TabIndex = 9
			Me.tabPage10.Text = "Webhook Spammer"
			' 
			' siticoneRadioButton9
			' 
			Me.siticoneRadioButton9.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.siticoneRadioButton9.AutoSize = True
			Me.siticoneRadioButton9.CheckedState.BorderColor = System.Drawing.Color.Red
			Me.siticoneRadioButton9.CheckedState.BorderThickness = 0
			Me.siticoneRadioButton9.CheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.siticoneRadioButton9.CheckedState.InnerColor = System.Drawing.Color.White
			Me.siticoneRadioButton9.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.siticoneRadioButton9.Location = New System.Drawing.Point(342, 425)
			Me.siticoneRadioButton9.Name = "siticoneRadioButton9"
			Me.siticoneRadioButton9.Size = New System.Drawing.Size(103, 17)
			Me.siticoneRadioButton9.TabIndex = 40
			Me.siticoneRadioButton9.Text = "Supreme Mode"
			Me.siticoneRadioButton9.UncheckedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneRadioButton9.UncheckedState.BorderThickness = 2
			Me.siticoneRadioButton9.UncheckedState.FillColor = System.Drawing.Color.Transparent
			Me.siticoneRadioButton9.UncheckedState.InnerColor = System.Drawing.Color.Transparent
			Me.siticoneRadioButton9.UseVisualStyleBackColor = True
			' 
			' siticoneRadioButton10
			' 
			Me.siticoneRadioButton10.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.siticoneRadioButton10.AutoSize = True
			Me.siticoneRadioButton10.CheckedState.BorderColor = System.Drawing.Color.Red
			Me.siticoneRadioButton10.CheckedState.BorderThickness = 0
			Me.siticoneRadioButton10.CheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.siticoneRadioButton10.CheckedState.InnerColor = System.Drawing.Color.White
			Me.siticoneRadioButton10.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.siticoneRadioButton10.Location = New System.Drawing.Point(342, 402)
			Me.siticoneRadioButton10.Name = "siticoneRadioButton10"
			Me.siticoneRadioButton10.Size = New System.Drawing.Size(98, 17)
			Me.siticoneRadioButton10.TabIndex = 39
			Me.siticoneRadioButton10.Text = "Extreme Mode"
			Me.siticoneRadioButton10.UncheckedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneRadioButton10.UncheckedState.BorderThickness = 2
			Me.siticoneRadioButton10.UncheckedState.FillColor = System.Drawing.Color.Transparent
			Me.siticoneRadioButton10.UncheckedState.InnerColor = System.Drawing.Color.Transparent
			Me.siticoneRadioButton10.UseVisualStyleBackColor = True
			' 
			' siticoneRadioButton11
			' 
			Me.siticoneRadioButton11.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.siticoneRadioButton11.AutoSize = True
			Me.siticoneRadioButton11.Checked = True
			Me.siticoneRadioButton11.CheckedState.BorderColor = System.Drawing.Color.Red
			Me.siticoneRadioButton11.CheckedState.BorderThickness = 0
			Me.siticoneRadioButton11.CheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.siticoneRadioButton11.CheckedState.InnerColor = System.Drawing.Color.White
			Me.siticoneRadioButton11.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.siticoneRadioButton11.Location = New System.Drawing.Point(342, 380)
			Me.siticoneRadioButton11.Name = "siticoneRadioButton11"
			Me.siticoneRadioButton11.Size = New System.Drawing.Size(95, 17)
			Me.siticoneRadioButton11.TabIndex = 38
			Me.siticoneRadioButton11.TabStop = True
			Me.siticoneRadioButton11.Text = "Normal Mode"
			Me.siticoneRadioButton11.UncheckedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneRadioButton11.UncheckedState.BorderThickness = 2
			Me.siticoneRadioButton11.UncheckedState.FillColor = System.Drawing.Color.Transparent
			Me.siticoneRadioButton11.UncheckedState.InnerColor = System.Drawing.Color.Transparent
			Me.siticoneRadioButton11.UseVisualStyleBackColor = True
			' 
			' siticoneCheckBox27
			' 
			Me.siticoneCheckBox27.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.siticoneCheckBox27.AutoSize = True
			Me.siticoneCheckBox27.CheckedState.BorderColor = System.Drawing.Color.Red
			Me.siticoneCheckBox27.CheckedState.BorderRadius = 2
			Me.siticoneCheckBox27.CheckedState.BorderThickness = 0
			Me.siticoneCheckBox27.CheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.siticoneCheckBox27.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.siticoneCheckBox27.Location = New System.Drawing.Point(144, 405)
			Me.siticoneCheckBox27.Name = "siticoneCheckBox27"
			Me.siticoneCheckBox27.Size = New System.Drawing.Size(122, 17)
			Me.siticoneCheckBox27.TabIndex = 37
			Me.siticoneCheckBox27.Text = "Multiple Messages"
			Me.siticoneCheckBox27.UncheckedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneCheckBox27.UncheckedState.BorderRadius = 2
			Me.siticoneCheckBox27.UncheckedState.BorderThickness = 0
			Me.siticoneCheckBox27.UncheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneCheckBox27.UseVisualStyleBackColor = True
			' 
			' siticoneCheckBox22
			' 
			Me.siticoneCheckBox22.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.siticoneCheckBox22.AutoSize = True
			Me.siticoneCheckBox22.CheckedState.BorderColor = System.Drawing.Color.Red
			Me.siticoneCheckBox22.CheckedState.BorderRadius = 2
			Me.siticoneCheckBox22.CheckedState.BorderThickness = 0
			Me.siticoneCheckBox22.CheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.siticoneCheckBox22.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.siticoneCheckBox22.Location = New System.Drawing.Point(144, 382)
			Me.siticoneCheckBox22.Name = "siticoneCheckBox22"
			Me.siticoneCheckBox22.Size = New System.Drawing.Size(128, 17)
			Me.siticoneCheckBox22.TabIndex = 36
			Me.siticoneCheckBox22.Text = "Multiple Webhooks"
			Me.siticoneCheckBox22.UncheckedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneCheckBox22.UncheckedState.BorderRadius = 2
			Me.siticoneCheckBox22.UncheckedState.BorderThickness = 0
			Me.siticoneCheckBox22.UncheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneCheckBox22.UseVisualStyleBackColor = True
			' 
			' gunaButton18
			' 
			Me.gunaButton18.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.gunaButton18.Animated = True
			Me.gunaButton18.AnimationHoverSpeed = 0.07F
			Me.gunaButton18.AnimationSpeed = 0.03F
			Me.gunaButton18.BackColor = System.Drawing.Color.Transparent
			Me.gunaButton18.BaseColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.gunaButton18.BorderColor = System.Drawing.Color.Transparent
			Me.gunaButton18.DialogResult = System.Windows.Forms.DialogResult.None
			Me.gunaButton18.Enabled = False
			Me.gunaButton18.FocusedColor = System.Drawing.Color.Empty
			Me.gunaButton18.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.gunaButton18.ForeColor = System.Drawing.Color.White
			Me.gunaButton18.Image = Nothing
			Me.gunaButton18.ImageSize = New System.Drawing.Size(24, 24)
			Me.gunaButton18.Location = New System.Drawing.Point(470, 515)
			Me.gunaButton18.Name = "gunaButton18"
			Me.gunaButton18.OnHoverBaseColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.gunaButton18.OnHoverBorderColor = System.Drawing.Color.Black
			Me.gunaButton18.OnHoverForeColor = System.Drawing.Color.White
			Me.gunaButton18.OnHoverImage = Nothing
			Me.gunaButton18.OnPressedColor = System.Drawing.Color.Black
			Me.gunaButton18.Size = New System.Drawing.Size(317, 42)
			Me.gunaButton18.TabIndex = 35
			Me.gunaButton18.Text = "Stop Spamming"
			Me.gunaButton18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
'			Me.gunaButton18.Click += New System.EventHandler(Me.gunaButton18_Click)
			' 
			' gunaButton17
			' 
			Me.gunaButton17.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.gunaButton17.Animated = True
			Me.gunaButton17.AnimationHoverSpeed = 0.07F
			Me.gunaButton17.AnimationSpeed = 0.03F
			Me.gunaButton17.BackColor = System.Drawing.Color.Transparent
			Me.gunaButton17.BaseColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.gunaButton17.BorderColor = System.Drawing.Color.Transparent
			Me.gunaButton17.DialogResult = System.Windows.Forms.DialogResult.None
			Me.gunaButton17.FocusedColor = System.Drawing.Color.Empty
			Me.gunaButton17.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.gunaButton17.ForeColor = System.Drawing.Color.White
			Me.gunaButton17.Image = Nothing
			Me.gunaButton17.ImageSize = New System.Drawing.Size(24, 24)
			Me.gunaButton17.Location = New System.Drawing.Point(144, 515)
			Me.gunaButton17.Name = "gunaButton17"
			Me.gunaButton17.OnHoverBaseColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.gunaButton17.OnHoverBorderColor = System.Drawing.Color.Black
			Me.gunaButton17.OnHoverForeColor = System.Drawing.Color.White
			Me.gunaButton17.OnHoverImage = Nothing
			Me.gunaButton17.OnPressedColor = System.Drawing.Color.Black
			Me.gunaButton17.Size = New System.Drawing.Size(317, 42)
			Me.gunaButton17.TabIndex = 34
			Me.gunaButton17.Text = "Start Spamming"
			Me.gunaButton17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
'			Me.gunaButton17.Click += New System.EventHandler(Me.gunaButton17_Click)
			' 
			' metroLabel27
			' 
			Me.metroLabel27.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.metroLabel27.AutoSize = True
			Me.metroLabel27.BackColor = System.Drawing.Color.Transparent
			Me.metroLabel27.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.metroLabel27.Location = New System.Drawing.Point(723, 381)
			Me.metroLabel27.Name = "metroLabel27"
			Me.metroLabel27.Size = New System.Drawing.Size(64, 15)
			Me.metroLabel27.TabIndex = 32
			Me.metroLabel27.Text = "Delay: 0ms"
			Me.metroLabel27.TextAlign = System.Drawing.ContentAlignment.TopRight
			' 
			' siticoneOSToggleSwith11
			' 
			Me.siticoneOSToggleSwith11.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.siticoneOSToggleSwith11.CheckedFillColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.siticoneOSToggleSwith11.Location = New System.Drawing.Point(683, 378)
			Me.siticoneOSToggleSwith11.Name = "siticoneOSToggleSwith11"
			Me.siticoneOSToggleSwith11.Size = New System.Drawing.Size(38, 22)
			Me.siticoneOSToggleSwith11.TabIndex = 31
			' 
			' gunaTextBox3
			' 
			Me.gunaTextBox3.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.gunaTextBox3.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(40)))), (CInt((CByte(40)))), (CInt((CByte(40)))))
			Me.gunaTextBox3.BaseColor = System.Drawing.Color.FromArgb((CInt((CByte(40)))), (CInt((CByte(40)))), (CInt((CByte(40)))))
			Me.gunaTextBox3.BorderColor = System.Drawing.Color.Silver
			Me.gunaTextBox3.BorderSize = 1
			Me.gunaTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam
			Me.gunaTextBox3.FocusedBaseColor = System.Drawing.Color.FromArgb((CInt((CByte(40)))), (CInt((CByte(40)))), (CInt((CByte(40)))))
			Me.gunaTextBox3.FocusedBorderColor = System.Drawing.Color.Red
			Me.gunaTextBox3.FocusedForeColor = System.Drawing.Color.White
			Me.gunaTextBox3.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.gunaTextBox3.Location = New System.Drawing.Point(144, 224)
			Me.gunaTextBox3.MaxLength = 2147483647
			Me.gunaTextBox3.MultiLine = True
			Me.gunaTextBox3.Name = "gunaTextBox3"
			Me.gunaTextBox3.PasswordChar = ControlChars.NullChar
			Me.gunaTextBox3.Size = New System.Drawing.Size(641, 137)
			Me.gunaTextBox3.TabIndex = 10
			Me.gunaTextBox3.Text = "Insert the message here."
			' 
			' gunaLineTextBox19
			' 
			Me.gunaLineTextBox19.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.gunaLineTextBox19.Animated = True
			Me.gunaLineTextBox19.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(40)))), (CInt((CByte(40)))), (CInt((CByte(40)))))
			Me.gunaLineTextBox19.Cursor = System.Windows.Forms.Cursors.IBeam
			Me.gunaLineTextBox19.FocusedLineColor = System.Drawing.Color.Red
			Me.gunaLineTextBox19.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.gunaLineTextBox19.LineColor = System.Drawing.Color.Gainsboro
			Me.gunaLineTextBox19.LineSize = 1
			Me.gunaLineTextBox19.Location = New System.Drawing.Point(144, 192)
			Me.gunaLineTextBox19.MaxLength = 2147483647
			Me.gunaLineTextBox19.Name = "gunaLineTextBox19"
			Me.gunaLineTextBox19.PasswordChar = ControlChars.NullChar
			Me.gunaLineTextBox19.Size = New System.Drawing.Size(641, 26)
			Me.gunaLineTextBox19.TabIndex = 9
			Me.gunaLineTextBox19.Text = "Insert the avatar URL of the webhook here."
			Me.gunaLineTextBox19.TextOffsetX = 0
			' 
			' gunaLineTextBox18
			' 
			Me.gunaLineTextBox18.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.gunaLineTextBox18.Animated = True
			Me.gunaLineTextBox18.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(40)))), (CInt((CByte(40)))), (CInt((CByte(40)))))
			Me.gunaLineTextBox18.Cursor = System.Windows.Forms.Cursors.IBeam
			Me.gunaLineTextBox18.FocusedLineColor = System.Drawing.Color.Red
			Me.gunaLineTextBox18.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.gunaLineTextBox18.LineColor = System.Drawing.Color.Gainsboro
			Me.gunaLineTextBox18.LineSize = 1
			Me.gunaLineTextBox18.Location = New System.Drawing.Point(144, 160)
			Me.gunaLineTextBox18.MaxLength = 2147483647
			Me.gunaLineTextBox18.Name = "gunaLineTextBox18"
			Me.gunaLineTextBox18.PasswordChar = ControlChars.NullChar
			Me.gunaLineTextBox18.Size = New System.Drawing.Size(641, 26)
			Me.gunaLineTextBox18.TabIndex = 8
			Me.gunaLineTextBox18.Text = "Insert the username of the webhook here."
			Me.gunaLineTextBox18.TextOffsetX = 0
			' 
			' gunaLineTextBox17
			' 
			Me.gunaLineTextBox17.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.gunaLineTextBox17.Animated = True
			Me.gunaLineTextBox17.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(40)))), (CInt((CByte(40)))), (CInt((CByte(40)))))
			Me.gunaLineTextBox17.Cursor = System.Windows.Forms.Cursors.IBeam
			Me.gunaLineTextBox17.FocusedLineColor = System.Drawing.Color.Red
			Me.gunaLineTextBox17.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.gunaLineTextBox17.LineColor = System.Drawing.Color.Gainsboro
			Me.gunaLineTextBox17.LineSize = 1
			Me.gunaLineTextBox17.Location = New System.Drawing.Point(144, 128)
			Me.gunaLineTextBox17.MaxLength = 2147483647
			Me.gunaLineTextBox17.Name = "gunaLineTextBox17"
			Me.gunaLineTextBox17.PasswordChar = ControlChars.NullChar
			Me.gunaLineTextBox17.Size = New System.Drawing.Size(641, 26)
			Me.gunaLineTextBox17.TabIndex = 7
			Me.gunaLineTextBox17.Text = "Insert the webhook link here."
			Me.gunaLineTextBox17.TextOffsetX = 0
			' 
			' metroLabel10
			' 
			Me.metroLabel10.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.metroLabel10.BackColor = System.Drawing.Color.Transparent
			Me.metroLabel10.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.metroLabel10.Location = New System.Drawing.Point(-1, 8)
			Me.metroLabel10.Name = "metroLabel10"
			Me.metroLabel10.Size = New System.Drawing.Size(931, 23)
			Me.metroLabel10.TabIndex = 1
			Me.metroLabel10.Text = "Webhook Spammer"
			Me.metroLabel10.TextAlign = System.Drawing.ContentAlignment.TopCenter
			' 
			' bunifuHSlider11
			' 
			Me.bunifuHSlider11.AllowCursorChanges = True
			Me.bunifuHSlider11.AllowHomeEndKeysDetection = False
			Me.bunifuHSlider11.AllowIncrementalClickMoves = True
			Me.bunifuHSlider11.AllowMouseDownEffects = False
			Me.bunifuHSlider11.AllowMouseHoverEffects = False
			Me.bunifuHSlider11.AllowScrollingAnimations = True
			Me.bunifuHSlider11.AllowScrollKeysDetection = True
			Me.bunifuHSlider11.AllowScrollOptionsMenu = True
			Me.bunifuHSlider11.AllowShrinkingOnFocusLost = False
			Me.bunifuHSlider11.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.bunifuHSlider11.BackColor = System.Drawing.Color.Transparent
			Me.bunifuHSlider11.BackgroundImage = (DirectCast(resources.GetObject("bunifuHSlider11.BackgroundImage"), System.Drawing.Image))
			Me.bunifuHSlider11.BindingContainer = Nothing
			Me.bunifuHSlider11.BorderRadius = 2
			Me.bunifuHSlider11.BorderThickness = 1
			Me.bunifuHSlider11.Cursor = System.Windows.Forms.Cursors.Hand
			Me.bunifuHSlider11.DrawThickBorder = False
			Me.bunifuHSlider11.DurationBeforeShrink = 2000
			Me.bunifuHSlider11.ElapsedColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.bunifuHSlider11.LargeChange = 10
			Me.bunifuHSlider11.Location = New System.Drawing.Point(144, 453)
			Me.bunifuHSlider11.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
			Me.bunifuHSlider11.Maximum = 5000
			Me.bunifuHSlider11.Minimum = 0
			Me.bunifuHSlider11.MinimumSize = New System.Drawing.Size(0, 54)
			Me.bunifuHSlider11.MinimumThumbLength = 18
			Me.bunifuHSlider11.Name = "bunifuHSlider11"
			Me.bunifuHSlider11.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver
			Me.bunifuHSlider11.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent
			Me.bunifuHSlider11.OnDisable.ThumbColor = System.Drawing.Color.Silver
			Me.bunifuHSlider11.ScrollBarBorderColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.bunifuHSlider11.ScrollBarColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.bunifuHSlider11.ShrinkSizeLimit = 3
			Me.bunifuHSlider11.Size = New System.Drawing.Size(643, 54)
			Me.bunifuHSlider11.SliderColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.bunifuHSlider11.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin
			Me.bunifuHSlider11.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular
			Me.bunifuHSlider11.SmallChange = 1
			Me.bunifuHSlider11.TabIndex = 33
			Me.bunifuHSlider11.ThumbColor = System.Drawing.Color.Red
			Me.bunifuHSlider11.ThumbFillColor = System.Drawing.Color.Red
			Me.bunifuHSlider11.ThumbLength = 18
			Me.bunifuHSlider11.ThumbMargin = 1
			Me.bunifuHSlider11.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium
			Me.bunifuHSlider11.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Fill
			Me.bunifuHSlider11.Value = 0
'			Me.bunifuHSlider11.Scroll += New System.EventHandler(Of Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs)(Me.bunifuHSlider11_Scroll)
			' 
			' tabPage11
			' 
			Me.tabPage11.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(40)))), (CInt((CByte(40)))), (CInt((CByte(40)))))
			Me.tabPage11.Controls.Add(Me.siticoneCheckBox28)
			Me.tabPage11.Controls.Add(Me.metroLabel8)
			Me.tabPage11.Controls.Add(Me.gunaButton20)
			Me.tabPage11.Controls.Add(Me.gunaButton19)
			Me.tabPage11.Controls.Add(Me.metroLabel28)
			Me.tabPage11.Controls.Add(Me.siticoneOSToggleSwith12)
			Me.tabPage11.Controls.Add(Me.gunaTextBox4)
			Me.tabPage11.Controls.Add(Me.metroLabel11)
			Me.tabPage11.Controls.Add(Me.bunifuHSlider12)
			Me.tabPage11.Font = New System.Drawing.Font("Segoe UI", 10F)
			Me.tabPage11.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(153)))), (CInt((CByte(153)))), (CInt((CByte(153)))))
			Me.tabPage11.Location = New System.Drawing.Point(184, 4)
			Me.tabPage11.Name = "tabPage11"
			Me.tabPage11.Padding = New System.Windows.Forms.Padding(3)
			Me.tabPage11.Size = New System.Drawing.Size(931, 581)
			Me.tabPage11.TabIndex = 10
			Me.tabPage11.Text = "Mass DM Advertiser"
			' 
			' siticoneCheckBox28
			' 
			Me.siticoneCheckBox28.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.siticoneCheckBox28.AutoSize = True
			Me.siticoneCheckBox28.CheckedState.BorderColor = System.Drawing.Color.Red
			Me.siticoneCheckBox28.CheckedState.BorderRadius = 2
			Me.siticoneCheckBox28.CheckedState.BorderThickness = 0
			Me.siticoneCheckBox28.CheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.siticoneCheckBox28.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.siticoneCheckBox28.Location = New System.Drawing.Point(144, 286)
			Me.siticoneCheckBox28.Name = "siticoneCheckBox28"
			Me.siticoneCheckBox28.Size = New System.Drawing.Size(122, 17)
			Me.siticoneCheckBox28.TabIndex = 37
			Me.siticoneCheckBox28.Text = "Multiple Messages"
			Me.siticoneCheckBox28.UncheckedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneCheckBox28.UncheckedState.BorderRadius = 2
			Me.siticoneCheckBox28.UncheckedState.BorderThickness = 0
			Me.siticoneCheckBox28.UncheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneCheckBox28.UseVisualStyleBackColor = True
			' 
			' metroLabel8
			' 
			Me.metroLabel8.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.metroLabel8.BackColor = System.Drawing.Color.Transparent
			Me.metroLabel8.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.metroLabel8.Location = New System.Drawing.Point(0, 460)
			Me.metroLabel8.Name = "metroLabel8"
			Me.metroLabel8.Size = New System.Drawing.Size(931, 23)
			Me.metroLabel8.TabIndex = 36
			Me.metroLabel8.Text = "Parsed users: 0, completed users: 0"
			Me.metroLabel8.TextAlign = System.Drawing.ContentAlignment.TopCenter
			' 
			' gunaButton20
			' 
			Me.gunaButton20.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.gunaButton20.Animated = True
			Me.gunaButton20.AnimationHoverSpeed = 0.07F
			Me.gunaButton20.AnimationSpeed = 0.03F
			Me.gunaButton20.BackColor = System.Drawing.Color.Transparent
			Me.gunaButton20.BaseColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.gunaButton20.BorderColor = System.Drawing.Color.Transparent
			Me.gunaButton20.DialogResult = System.Windows.Forms.DialogResult.None
			Me.gunaButton20.Enabled = False
			Me.gunaButton20.FocusedColor = System.Drawing.Color.Empty
			Me.gunaButton20.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.gunaButton20.ForeColor = System.Drawing.Color.White
			Me.gunaButton20.Image = Nothing
			Me.gunaButton20.ImageSize = New System.Drawing.Size(24, 24)
			Me.gunaButton20.Location = New System.Drawing.Point(468, 409)
			Me.gunaButton20.Name = "gunaButton20"
			Me.gunaButton20.OnHoverBaseColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.gunaButton20.OnHoverBorderColor = System.Drawing.Color.Black
			Me.gunaButton20.OnHoverForeColor = System.Drawing.Color.White
			Me.gunaButton20.OnHoverImage = Nothing
			Me.gunaButton20.OnPressedColor = System.Drawing.Color.Black
			Me.gunaButton20.Size = New System.Drawing.Size(317, 42)
			Me.gunaButton20.TabIndex = 35
			Me.gunaButton20.Text = "Stop Advertising"
			Me.gunaButton20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
'			Me.gunaButton20.Click += New System.EventHandler(Me.gunaButton20_Click)
			' 
			' gunaButton19
			' 
			Me.gunaButton19.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.gunaButton19.Animated = True
			Me.gunaButton19.AnimationHoverSpeed = 0.07F
			Me.gunaButton19.AnimationSpeed = 0.03F
			Me.gunaButton19.BackColor = System.Drawing.Color.Transparent
			Me.gunaButton19.BaseColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.gunaButton19.BorderColor = System.Drawing.Color.Transparent
			Me.gunaButton19.DialogResult = System.Windows.Forms.DialogResult.None
			Me.gunaButton19.FocusedColor = System.Drawing.Color.Empty
			Me.gunaButton19.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.gunaButton19.ForeColor = System.Drawing.Color.White
			Me.gunaButton19.Image = Nothing
			Me.gunaButton19.ImageSize = New System.Drawing.Size(24, 24)
			Me.gunaButton19.Location = New System.Drawing.Point(144, 409)
			Me.gunaButton19.Name = "gunaButton19"
			Me.gunaButton19.OnHoverBaseColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.gunaButton19.OnHoverBorderColor = System.Drawing.Color.Black
			Me.gunaButton19.OnHoverForeColor = System.Drawing.Color.White
			Me.gunaButton19.OnHoverImage = Nothing
			Me.gunaButton19.OnPressedColor = System.Drawing.Color.Black
			Me.gunaButton19.Size = New System.Drawing.Size(317, 42)
			Me.gunaButton19.TabIndex = 34
			Me.gunaButton19.Text = "Start Advertising"
			Me.gunaButton19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
'			Me.gunaButton19.Click += New System.EventHandler(Me.gunaButton19_Click)
			' 
			' metroLabel28
			' 
			Me.metroLabel28.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.metroLabel28.AutoSize = True
			Me.metroLabel28.BackColor = System.Drawing.Color.Transparent
			Me.metroLabel28.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.metroLabel28.Location = New System.Drawing.Point(724, 286)
			Me.metroLabel28.Name = "metroLabel28"
			Me.metroLabel28.Size = New System.Drawing.Size(64, 15)
			Me.metroLabel28.TabIndex = 32
			Me.metroLabel28.Text = "Delay: 0ms"
			Me.metroLabel28.TextAlign = System.Drawing.ContentAlignment.TopRight
			' 
			' siticoneOSToggleSwith12
			' 
			Me.siticoneOSToggleSwith12.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.siticoneOSToggleSwith12.CheckedFillColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.siticoneOSToggleSwith12.Location = New System.Drawing.Point(684, 283)
			Me.siticoneOSToggleSwith12.Name = "siticoneOSToggleSwith12"
			Me.siticoneOSToggleSwith12.Size = New System.Drawing.Size(38, 22)
			Me.siticoneOSToggleSwith12.TabIndex = 31
			' 
			' gunaTextBox4
			' 
			Me.gunaTextBox4.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.gunaTextBox4.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(40)))), (CInt((CByte(40)))), (CInt((CByte(40)))))
			Me.gunaTextBox4.BaseColor = System.Drawing.Color.FromArgb((CInt((CByte(40)))), (CInt((CByte(40)))), (CInt((CByte(40)))))
			Me.gunaTextBox4.BorderColor = System.Drawing.Color.Silver
			Me.gunaTextBox4.BorderSize = 1
			Me.gunaTextBox4.Cursor = System.Windows.Forms.Cursors.IBeam
			Me.gunaTextBox4.FocusedBaseColor = System.Drawing.Color.FromArgb((CInt((CByte(40)))), (CInt((CByte(40)))), (CInt((CByte(40)))))
			Me.gunaTextBox4.FocusedBorderColor = System.Drawing.Color.Red
			Me.gunaTextBox4.FocusedForeColor = System.Drawing.Color.White
			Me.gunaTextBox4.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.gunaTextBox4.Location = New System.Drawing.Point(144, 128)
			Me.gunaTextBox4.MaxLength = 2147483647
			Me.gunaTextBox4.MultiLine = True
			Me.gunaTextBox4.Name = "gunaTextBox4"
			Me.gunaTextBox4.PasswordChar = ControlChars.NullChar
			Me.gunaTextBox4.Size = New System.Drawing.Size(641, 137)
			Me.gunaTextBox4.TabIndex = 7
			Me.gunaTextBox4.Text = "Insert the message here."
			' 
			' metroLabel11
			' 
			Me.metroLabel11.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.metroLabel11.BackColor = System.Drawing.Color.Transparent
			Me.metroLabel11.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.metroLabel11.Location = New System.Drawing.Point(-1, 8)
			Me.metroLabel11.Name = "metroLabel11"
			Me.metroLabel11.Size = New System.Drawing.Size(931, 23)
			Me.metroLabel11.TabIndex = 1
			Me.metroLabel11.Text = "Mass DM Advertiser"
			Me.metroLabel11.TextAlign = System.Drawing.ContentAlignment.TopCenter
			' 
			' bunifuHSlider12
			' 
			Me.bunifuHSlider12.AllowCursorChanges = True
			Me.bunifuHSlider12.AllowHomeEndKeysDetection = False
			Me.bunifuHSlider12.AllowIncrementalClickMoves = True
			Me.bunifuHSlider12.AllowMouseDownEffects = False
			Me.bunifuHSlider12.AllowMouseHoverEffects = False
			Me.bunifuHSlider12.AllowScrollingAnimations = True
			Me.bunifuHSlider12.AllowScrollKeysDetection = True
			Me.bunifuHSlider12.AllowScrollOptionsMenu = True
			Me.bunifuHSlider12.AllowShrinkingOnFocusLost = False
			Me.bunifuHSlider12.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.bunifuHSlider12.BackColor = System.Drawing.Color.Transparent
			Me.bunifuHSlider12.BackgroundImage = (DirectCast(resources.GetObject("bunifuHSlider12.BackgroundImage"), System.Drawing.Image))
			Me.bunifuHSlider12.BindingContainer = Nothing
			Me.bunifuHSlider12.BorderRadius = 2
			Me.bunifuHSlider12.BorderThickness = 1
			Me.bunifuHSlider12.Cursor = System.Windows.Forms.Cursors.Hand
			Me.bunifuHSlider12.DrawThickBorder = False
			Me.bunifuHSlider12.DurationBeforeShrink = 2000
			Me.bunifuHSlider12.ElapsedColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.bunifuHSlider12.LargeChange = 10
			Me.bunifuHSlider12.Location = New System.Drawing.Point(144, 330)
			Me.bunifuHSlider12.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
			Me.bunifuHSlider12.Maximum = 5000
			Me.bunifuHSlider12.Minimum = 0
			Me.bunifuHSlider12.MinimumSize = New System.Drawing.Size(0, 54)
			Me.bunifuHSlider12.MinimumThumbLength = 18
			Me.bunifuHSlider12.Name = "bunifuHSlider12"
			Me.bunifuHSlider12.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver
			Me.bunifuHSlider12.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent
			Me.bunifuHSlider12.OnDisable.ThumbColor = System.Drawing.Color.Silver
			Me.bunifuHSlider12.ScrollBarBorderColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.bunifuHSlider12.ScrollBarColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.bunifuHSlider12.ShrinkSizeLimit = 3
			Me.bunifuHSlider12.Size = New System.Drawing.Size(644, 54)
			Me.bunifuHSlider12.SliderColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.bunifuHSlider12.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin
			Me.bunifuHSlider12.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular
			Me.bunifuHSlider12.SmallChange = 1
			Me.bunifuHSlider12.TabIndex = 33
			Me.bunifuHSlider12.ThumbColor = System.Drawing.Color.Red
			Me.bunifuHSlider12.ThumbFillColor = System.Drawing.Color.Red
			Me.bunifuHSlider12.ThumbLength = 18
			Me.bunifuHSlider12.ThumbMargin = 1
			Me.bunifuHSlider12.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium
			Me.bunifuHSlider12.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Fill
			Me.bunifuHSlider12.Value = 0
'			Me.bunifuHSlider12.Scroll += New System.EventHandler(Of Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs)(Me.bunifuHSlider12_Scroll)
			' 
			' tabPage12
			' 
			Me.tabPage12.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(40)))), (CInt((CByte(40)))), (CInt((CByte(40)))))
			Me.tabPage12.Controls.Add(Me.siticoneCheckBox32)
			Me.tabPage12.Controls.Add(Me.siticoneCheckBox31)
			Me.tabPage12.Controls.Add(Me.siticoneCheckBox30)
			Me.tabPage12.Controls.Add(Me.siticoneComboBox1)
			Me.tabPage12.Controls.Add(Me.siticoneButton9)
			Me.tabPage12.Controls.Add(Me.siticoneCheckBox26)
			Me.tabPage12.Controls.Add(Me.siticoneCheckBox25)
			Me.tabPage12.Controls.Add(Me.siticoneCheckBox24)
			Me.tabPage12.Controls.Add(Me.siticoneCheckBox10)
			Me.tabPage12.Controls.Add(Me.siticoneCheckBox6)
			Me.tabPage12.Controls.Add(Me.gunaLineTextBox13)
			Me.tabPage12.Controls.Add(Me.gunaTextBox5)
			Me.tabPage12.Controls.Add(Me.siticoneButton12)
			Me.tabPage12.Controls.Add(Me.siticoneComboBox2)
			Me.tabPage12.Controls.Add(Me.siticoneButton11)
			Me.tabPage12.Controls.Add(Me.siticoneButton8)
			Me.tabPage12.Controls.Add(Me.gunaLineTextBox22)
			Me.tabPage12.Controls.Add(Me.gunaLineTextBox21)
			Me.tabPage12.Controls.Add(Me.gunaLinkLabel1)
			Me.tabPage12.Controls.Add(Me.gunaLineTextBox20)
			Me.tabPage12.Controls.Add(Me.metroLabel12)
			Me.tabPage12.Font = New System.Drawing.Font("Segoe UI", 10F)
			Me.tabPage12.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(153)))), (CInt((CByte(153)))), (CInt((CByte(153)))))
			Me.tabPage12.Location = New System.Drawing.Point(184, 4)
			Me.tabPage12.Name = "tabPage12"
			Me.tabPage12.Padding = New System.Windows.Forms.Padding(3)
			Me.tabPage12.Size = New System.Drawing.Size(931, 581)
			Me.tabPage12.TabIndex = 11
			Me.tabPage12.Text = "Settings and Utils"
			' 
			' siticoneCheckBox32
			' 
			Me.siticoneCheckBox32.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.siticoneCheckBox32.AutoSize = True
			Me.siticoneCheckBox32.CheckedState.BorderColor = System.Drawing.Color.Red
			Me.siticoneCheckBox32.CheckedState.BorderRadius = 2
			Me.siticoneCheckBox32.CheckedState.BorderThickness = 0
			Me.siticoneCheckBox32.CheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.siticoneCheckBox32.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.siticoneCheckBox32.Location = New System.Drawing.Point(565, 407)
			Me.siticoneCheckBox32.Name = "siticoneCheckBox32"
			Me.siticoneCheckBox32.Size = New System.Drawing.Size(113, 17)
			Me.siticoneCheckBox32.TabIndex = 33
			Me.siticoneCheckBox32.Text = "Mention all roles"
			Me.siticoneCheckBox32.UncheckedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneCheckBox32.UncheckedState.BorderRadius = 2
			Me.siticoneCheckBox32.UncheckedState.BorderThickness = 0
			Me.siticoneCheckBox32.UncheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneCheckBox32.UseVisualStyleBackColor = True
			' 
			' siticoneCheckBox31
			' 
			Me.siticoneCheckBox31.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.siticoneCheckBox31.AutoSize = True
			Me.siticoneCheckBox31.CheckedState.BorderColor = System.Drawing.Color.Red
			Me.siticoneCheckBox31.CheckedState.BorderRadius = 2
			Me.siticoneCheckBox31.CheckedState.BorderThickness = 0
			Me.siticoneCheckBox31.CheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.siticoneCheckBox31.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.siticoneCheckBox31.Location = New System.Drawing.Point(783, 384)
			Me.siticoneCheckBox31.Name = "siticoneCheckBox31"
			Me.siticoneCheckBox31.Size = New System.Drawing.Size(98, 17)
			Me.siticoneCheckBox31.TabIndex = 32
			Me.siticoneCheckBox31.Text = "Mention roles"
			Me.siticoneCheckBox31.UncheckedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneCheckBox31.UncheckedState.BorderRadius = 2
			Me.siticoneCheckBox31.UncheckedState.BorderThickness = 0
			Me.siticoneCheckBox31.UncheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneCheckBox31.UseVisualStyleBackColor = True
			' 
			' siticoneCheckBox30
			' 
			Me.siticoneCheckBox30.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.siticoneCheckBox30.AutoSize = True
			Me.siticoneCheckBox30.CheckedState.BorderColor = System.Drawing.Color.Red
			Me.siticoneCheckBox30.CheckedState.BorderRadius = 2
			Me.siticoneCheckBox30.CheckedState.BorderThickness = 0
			Me.siticoneCheckBox30.CheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.siticoneCheckBox30.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.siticoneCheckBox30.Location = New System.Drawing.Point(662, 384)
			Me.siticoneCheckBox30.Name = "siticoneCheckBox30"
			Me.siticoneCheckBox30.Size = New System.Drawing.Size(115, 17)
			Me.siticoneCheckBox30.TabIndex = 31
			Me.siticoneCheckBox30.Text = "Mention all users"
			Me.siticoneCheckBox30.UncheckedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneCheckBox30.UncheckedState.BorderRadius = 2
			Me.siticoneCheckBox30.UncheckedState.BorderThickness = 0
			Me.siticoneCheckBox30.UncheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneCheckBox30.UseVisualStyleBackColor = True
			' 
			' siticoneComboBox1
			' 
			Me.siticoneComboBox1.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.siticoneComboBox1.BackColor = System.Drawing.Color.Transparent
			Me.siticoneComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
			Me.siticoneComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.siticoneComboBox1.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(40)))), (CInt((CByte(40)))), (CInt((CByte(40)))))
			Me.siticoneComboBox1.FocusedColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.siticoneComboBox1.Font = New System.Drawing.Font("Segoe UI", 10F)
			Me.siticoneComboBox1.ForeColor = System.Drawing.Color.White
			Me.siticoneComboBox1.FormattingEnabled = True
			Me.siticoneComboBox1.HoveredState.Parent = Me.siticoneComboBox1
			Me.siticoneComboBox1.ItemHeight = 30
			Me.siticoneComboBox1.Items.AddRange(New Object() { "HypeSquad Balance", "HypeSquad Bravery", "HypeSquad Brilliance"})
			Me.siticoneComboBox1.ItemsAppearance.Parent = Me.siticoneComboBox1
			Me.siticoneComboBox1.Location = New System.Drawing.Point(38, 238)
			Me.siticoneComboBox1.Name = "siticoneComboBox1"
			Me.siticoneComboBox1.ShadowDecoration.Parent = Me.siticoneComboBox1
			Me.siticoneComboBox1.Size = New System.Drawing.Size(341, 36)
			Me.siticoneComboBox1.TabIndex = 30
			' 
			' siticoneButton9
			' 
			Me.siticoneButton9.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.siticoneButton9.BorderRadius = 15
			Me.siticoneButton9.CheckedState.Parent = Me.siticoneButton9
			Me.siticoneButton9.CustomImages.Parent = Me.siticoneButton9
			Me.siticoneButton9.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.siticoneButton9.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.siticoneButton9.ForeColor = System.Drawing.Color.White
			Me.siticoneButton9.HoveredState.Parent = Me.siticoneButton9
			Me.siticoneButton9.Location = New System.Drawing.Point(38, 292)
			Me.siticoneButton9.Name = "siticoneButton9"
			Me.siticoneButton9.ShadowDecoration.Parent = Me.siticoneButton9
			Me.siticoneButton9.Size = New System.Drawing.Size(341, 45)
			Me.siticoneButton9.TabIndex = 29
			Me.siticoneButton9.Text = "Set new HypeSquad for all tokens"
'			Me.siticoneButton9.Click += New System.EventHandler(Me.siticoneButton9_Click)
			' 
			' siticoneCheckBox26
			' 
			Me.siticoneCheckBox26.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.siticoneCheckBox26.AutoSize = True
			Me.siticoneCheckBox26.Checked = True
			Me.siticoneCheckBox26.CheckedState.BorderColor = System.Drawing.Color.Red
			Me.siticoneCheckBox26.CheckedState.BorderRadius = 2
			Me.siticoneCheckBox26.CheckedState.BorderThickness = 0
			Me.siticoneCheckBox26.CheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.siticoneCheckBox26.CheckState = System.Windows.Forms.CheckState.Checked
			Me.siticoneCheckBox26.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.siticoneCheckBox26.Location = New System.Drawing.Point(684, 407)
			Me.siticoneCheckBox26.Name = "siticoneCheckBox26"
			Me.siticoneCheckBox26.Size = New System.Drawing.Size(118, 17)
			Me.siticoneCheckBox26.TabIndex = 28
			Me.siticoneCheckBox26.Text = "Copy to clipboard"
			Me.siticoneCheckBox26.UncheckedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneCheckBox26.UncheckedState.BorderRadius = 2
			Me.siticoneCheckBox26.UncheckedState.BorderThickness = 0
			Me.siticoneCheckBox26.UncheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneCheckBox26.UseVisualStyleBackColor = True
			' 
			' siticoneCheckBox25
			' 
			Me.siticoneCheckBox25.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.siticoneCheckBox25.AutoSize = True
			Me.siticoneCheckBox25.CheckedState.BorderColor = System.Drawing.Color.Red
			Me.siticoneCheckBox25.CheckedState.BorderRadius = 2
			Me.siticoneCheckBox25.CheckedState.BorderThickness = 0
			Me.siticoneCheckBox25.CheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.siticoneCheckBox25.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.siticoneCheckBox25.Location = New System.Drawing.Point(565, 384)
			Me.siticoneCheckBox25.Name = "siticoneCheckBox25"
			Me.siticoneCheckBox25.Size = New System.Drawing.Size(91, 17)
			Me.siticoneCheckBox25.TabIndex = 27
			Me.siticoneCheckBox25.Text = "Lag message"
			Me.siticoneCheckBox25.UncheckedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneCheckBox25.UncheckedState.BorderRadius = 2
			Me.siticoneCheckBox25.UncheckedState.BorderThickness = 0
			Me.siticoneCheckBox25.UncheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneCheckBox25.UseVisualStyleBackColor = True
			' 
			' siticoneCheckBox24
			' 
			Me.siticoneCheckBox24.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.siticoneCheckBox24.AutoSize = True
			Me.siticoneCheckBox24.CheckedState.BorderColor = System.Drawing.Color.Red
			Me.siticoneCheckBox24.CheckedState.BorderRadius = 2
			Me.siticoneCheckBox24.CheckedState.BorderThickness = 0
			Me.siticoneCheckBox24.CheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.siticoneCheckBox24.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.siticoneCheckBox24.Location = New System.Drawing.Point(791, 361)
			Me.siticoneCheckBox24.Name = "siticoneCheckBox24"
			Me.siticoneCheckBox24.Size = New System.Drawing.Size(123, 17)
			Me.siticoneCheckBox24.TabIndex = 26
			Me.siticoneCheckBox24.Text = "Mass mention user"
			Me.siticoneCheckBox24.UncheckedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneCheckBox24.UncheckedState.BorderRadius = 2
			Me.siticoneCheckBox24.UncheckedState.BorderThickness = 0
			Me.siticoneCheckBox24.UncheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneCheckBox24.UseVisualStyleBackColor = True
			' 
			' siticoneCheckBox10
			' 
			Me.siticoneCheckBox10.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.siticoneCheckBox10.AutoSize = True
			Me.siticoneCheckBox10.CheckedState.BorderColor = System.Drawing.Color.Red
			Me.siticoneCheckBox10.CheckedState.BorderRadius = 2
			Me.siticoneCheckBox10.CheckedState.BorderThickness = 0
			Me.siticoneCheckBox10.CheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.siticoneCheckBox10.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.siticoneCheckBox10.Location = New System.Drawing.Point(683, 361)
			Me.siticoneCheckBox10.Name = "siticoneCheckBox10"
			Me.siticoneCheckBox10.Size = New System.Drawing.Size(102, 17)
			Me.siticoneCheckBox10.TabIndex = 25
			Me.siticoneCheckBox10.Text = "Random string"
			Me.siticoneCheckBox10.UncheckedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneCheckBox10.UncheckedState.BorderRadius = 2
			Me.siticoneCheckBox10.UncheckedState.BorderThickness = 0
			Me.siticoneCheckBox10.UncheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneCheckBox10.UseVisualStyleBackColor = True
			' 
			' siticoneCheckBox6
			' 
			Me.siticoneCheckBox6.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.siticoneCheckBox6.AutoSize = True
			Me.siticoneCheckBox6.CheckedState.BorderColor = System.Drawing.Color.Red
			Me.siticoneCheckBox6.CheckedState.BorderRadius = 2
			Me.siticoneCheckBox6.CheckedState.BorderThickness = 0
			Me.siticoneCheckBox6.CheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.siticoneCheckBox6.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.siticoneCheckBox6.Location = New System.Drawing.Point(565, 361)
			Me.siticoneCheckBox6.Name = "siticoneCheckBox6"
			Me.siticoneCheckBox6.Size = New System.Drawing.Size(112, 17)
			Me.siticoneCheckBox6.TabIndex = 24
			Me.siticoneCheckBox6.Text = "Random number"
			Me.siticoneCheckBox6.UncheckedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneCheckBox6.UncheckedState.BorderRadius = 2
			Me.siticoneCheckBox6.UncheckedState.BorderThickness = 0
			Me.siticoneCheckBox6.UncheckedState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(125)))), (CInt((CByte(137)))), (CInt((CByte(149)))))
			Me.siticoneCheckBox6.UseVisualStyleBackColor = True
			' 
			' gunaLineTextBox13
			' 
			Me.gunaLineTextBox13.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.gunaLineTextBox13.Animated = True
			Me.gunaLineTextBox13.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(40)))), (CInt((CByte(40)))), (CInt((CByte(40)))))
			Me.gunaLineTextBox13.Cursor = System.Windows.Forms.Cursors.IBeam
			Me.gunaLineTextBox13.FocusedLineColor = System.Drawing.Color.Red
			Me.gunaLineTextBox13.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.gunaLineTextBox13.LineColor = System.Drawing.Color.Gainsboro
			Me.gunaLineTextBox13.LineSize = 1
			Me.gunaLineTextBox13.Location = New System.Drawing.Point(565, 183)
			Me.gunaLineTextBox13.MaxLength = 8
			Me.gunaLineTextBox13.Name = "gunaLineTextBox13"
			Me.gunaLineTextBox13.PasswordChar = ControlChars.NullChar
			Me.gunaLineTextBox13.Size = New System.Drawing.Size(341, 26)
			Me.gunaLineTextBox13.TabIndex = 23
			Me.gunaLineTextBox13.Text = "Insert the number of placeholders here."
			Me.gunaLineTextBox13.TextOffsetX = 0
			' 
			' gunaTextBox5
			' 
			Me.gunaTextBox5.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.gunaTextBox5.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(40)))), (CInt((CByte(40)))), (CInt((CByte(40)))))
			Me.gunaTextBox5.BaseColor = System.Drawing.Color.FromArgb((CInt((CByte(40)))), (CInt((CByte(40)))), (CInt((CByte(40)))))
			Me.gunaTextBox5.BorderColor = System.Drawing.Color.Silver
			Me.gunaTextBox5.BorderSize = 1
			Me.gunaTextBox5.Cursor = System.Windows.Forms.Cursors.IBeam
			Me.gunaTextBox5.FocusedBaseColor = System.Drawing.Color.FromArgb((CInt((CByte(40)))), (CInt((CByte(40)))), (CInt((CByte(40)))))
			Me.gunaTextBox5.FocusedBorderColor = System.Drawing.Color.Red
			Me.gunaTextBox5.FocusedForeColor = System.Drawing.Color.White
			Me.gunaTextBox5.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.gunaTextBox5.Location = New System.Drawing.Point(565, 215)
			Me.gunaTextBox5.MaxLength = 2147483647
			Me.gunaTextBox5.MultiLine = True
			Me.gunaTextBox5.Name = "gunaTextBox5"
			Me.gunaTextBox5.PasswordChar = ControlChars.NullChar
			Me.gunaTextBox5.ReadOnly = True
			Me.gunaTextBox5.Size = New System.Drawing.Size(341, 137)
			Me.gunaTextBox5.TabIndex = 22
			' 
			' siticoneButton12
			' 
			Me.siticoneButton12.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.siticoneButton12.BorderRadius = 15
			Me.siticoneButton12.CheckedState.Parent = Me.siticoneButton12
			Me.siticoneButton12.CustomImages.Parent = Me.siticoneButton12
			Me.siticoneButton12.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.siticoneButton12.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.siticoneButton12.ForeColor = System.Drawing.Color.White
			Me.siticoneButton12.HoveredState.Parent = Me.siticoneButton12
			Me.siticoneButton12.Location = New System.Drawing.Point(565, 432)
			Me.siticoneButton12.Name = "siticoneButton12"
			Me.siticoneButton12.ShadowDecoration.Parent = Me.siticoneButton12
			Me.siticoneButton12.Size = New System.Drawing.Size(341, 45)
			Me.siticoneButton12.TabIndex = 21
			Me.siticoneButton12.Text = "Generate Text"
'			Me.siticoneButton12.Click += New System.EventHandler(Me.siticoneButton12_Click)
			' 
			' siticoneComboBox2
			' 
			Me.siticoneComboBox2.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.siticoneComboBox2.BackColor = System.Drawing.Color.Transparent
			Me.siticoneComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
			Me.siticoneComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.siticoneComboBox2.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(40)))), (CInt((CByte(40)))), (CInt((CByte(40)))))
			Me.siticoneComboBox2.FocusedColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.siticoneComboBox2.Font = New System.Drawing.Font("Segoe UI", 10F)
			Me.siticoneComboBox2.ForeColor = System.Drawing.Color.White
			Me.siticoneComboBox2.FormattingEnabled = True
			Me.siticoneComboBox2.HoveredState.Parent = Me.siticoneComboBox2
			Me.siticoneComboBox2.ItemHeight = 30
			Me.siticoneComboBox2.Items.AddRange(New Object() { "Online", "Idle", "Do Not Disturb", "Invisible"})
			Me.siticoneComboBox2.ItemsAppearance.Parent = Me.siticoneComboBox2
			Me.siticoneComboBox2.Location = New System.Drawing.Point(38, 128)
			Me.siticoneComboBox2.Name = "siticoneComboBox2"
			Me.siticoneComboBox2.ShadowDecoration.Parent = Me.siticoneComboBox2
			Me.siticoneComboBox2.Size = New System.Drawing.Size(341, 36)
			Me.siticoneComboBox2.TabIndex = 20
			' 
			' siticoneButton11
			' 
			Me.siticoneButton11.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.siticoneButton11.BorderRadius = 15
			Me.siticoneButton11.CheckedState.Parent = Me.siticoneButton11
			Me.siticoneButton11.CustomImages.Parent = Me.siticoneButton11
			Me.siticoneButton11.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.siticoneButton11.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.siticoneButton11.ForeColor = System.Drawing.Color.White
			Me.siticoneButton11.HoveredState.Parent = Me.siticoneButton11
			Me.siticoneButton11.Location = New System.Drawing.Point(38, 182)
			Me.siticoneButton11.Name = "siticoneButton11"
			Me.siticoneButton11.ShadowDecoration.Parent = Me.siticoneButton11
			Me.siticoneButton11.Size = New System.Drawing.Size(341, 45)
			Me.siticoneButton11.TabIndex = 19
			Me.siticoneButton11.Text = "Set new online status for all tokens"
'			Me.siticoneButton11.Click += New System.EventHandler(Me.siticoneButton11_Click)
			' 
			' siticoneButton8
			' 
			Me.siticoneButton8.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.siticoneButton8.BorderRadius = 15
			Me.siticoneButton8.CheckedState.Parent = Me.siticoneButton8
			Me.siticoneButton8.CustomImages.Parent = Me.siticoneButton8
			Me.siticoneButton8.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.siticoneButton8.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.siticoneButton8.ForeColor = System.Drawing.Color.White
			Me.siticoneButton8.HoveredState.Parent = Me.siticoneButton8
			Me.siticoneButton8.Location = New System.Drawing.Point(565, 131)
			Me.siticoneButton8.Name = "siticoneButton8"
			Me.siticoneButton8.ShadowDecoration.Parent = Me.siticoneButton8
			Me.siticoneButton8.Size = New System.Drawing.Size(341, 45)
			Me.siticoneButton8.TabIndex = 13
			Me.siticoneButton8.Text = "Set new nickname for all tokens"
'			Me.siticoneButton8.Click += New System.EventHandler(Me.siticoneButton8_Click)
			' 
			' gunaLineTextBox22
			' 
			Me.gunaLineTextBox22.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.gunaLineTextBox22.Animated = True
			Me.gunaLineTextBox22.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(40)))), (CInt((CByte(40)))), (CInt((CByte(40)))))
			Me.gunaLineTextBox22.Cursor = System.Windows.Forms.Cursors.IBeam
			Me.gunaLineTextBox22.FocusedLineColor = System.Drawing.Color.Red
			Me.gunaLineTextBox22.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.gunaLineTextBox22.LineColor = System.Drawing.Color.Gainsboro
			Me.gunaLineTextBox22.LineSize = 1
			Me.gunaLineTextBox22.Location = New System.Drawing.Point(565, 93)
			Me.gunaLineTextBox22.MaxLength = 2147483647
			Me.gunaLineTextBox22.Name = "gunaLineTextBox22"
			Me.gunaLineTextBox22.PasswordChar = ControlChars.NullChar
			Me.gunaLineTextBox22.Size = New System.Drawing.Size(341, 26)
			Me.gunaLineTextBox22.TabIndex = 10
			Me.gunaLineTextBox22.Text = "Insert the new nickname/game here."
			Me.gunaLineTextBox22.TextOffsetX = 0
			' 
			' gunaLineTextBox21
			' 
			Me.gunaLineTextBox21.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.gunaLineTextBox21.Animated = True
			Me.gunaLineTextBox21.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(40)))), (CInt((CByte(40)))), (CInt((CByte(40)))))
			Me.gunaLineTextBox21.Cursor = System.Windows.Forms.Cursors.IBeam
			Me.gunaLineTextBox21.FocusedLineColor = System.Drawing.Color.Red
			Me.gunaLineTextBox21.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.gunaLineTextBox21.LineColor = System.Drawing.Color.Gainsboro
			Me.gunaLineTextBox21.LineSize = 1
			Me.gunaLineTextBox21.Location = New System.Drawing.Point(565, 61)
			Me.gunaLineTextBox21.MaxLength = 2147483647
			Me.gunaLineTextBox21.Name = "gunaLineTextBox21"
			Me.gunaLineTextBox21.PasswordChar = ControlChars.NullChar
			Me.gunaLineTextBox21.Size = New System.Drawing.Size(341, 26)
			Me.gunaLineTextBox21.TabIndex = 9
			Me.gunaLineTextBox21.Text = "Insert the guild id here."
			Me.gunaLineTextBox21.TextOffsetX = 0
			' 
			' gunaLinkLabel1
			' 
			Me.gunaLinkLabel1.ActiveLinkColor = System.Drawing.Color.Gold
			Me.gunaLinkLabel1.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.gunaLinkLabel1.AutoSize = True
			Me.gunaLinkLabel1.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.gunaLinkLabel1.LinkColor = System.Drawing.Color.Yellow
			Me.gunaLinkLabel1.Location = New System.Drawing.Point(35, 96)
			Me.gunaLinkLabel1.Name = "gunaLinkLabel1"
			Me.gunaLinkLabel1.Size = New System.Drawing.Size(127, 15)
			Me.gunaLinkLabel1.TabIndex = 8
			Me.gunaLinkLabel1.TabStop = True
			Me.gunaLinkLabel1.Text = "https://2captcha.com/"
			Me.gunaLinkLabel1.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAlias
			Me.gunaLinkLabel1.VisitedLinkColor = System.Drawing.Color.Yellow
'			Me.gunaLinkLabel1.LinkClicked += New System.Windows.Forms.LinkLabelLinkClickedEventHandler(Me.gunaLinkLabel1_LinkClicked)
			' 
			' gunaLineTextBox20
			' 
			Me.gunaLineTextBox20.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.gunaLineTextBox20.Animated = True
			Me.gunaLineTextBox20.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(40)))), (CInt((CByte(40)))), (CInt((CByte(40)))))
			Me.gunaLineTextBox20.Cursor = System.Windows.Forms.Cursors.IBeam
			Me.gunaLineTextBox20.FocusedLineColor = System.Drawing.Color.Red
			Me.gunaLineTextBox20.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.gunaLineTextBox20.LineColor = System.Drawing.Color.Gainsboro
			Me.gunaLineTextBox20.LineSize = 1
			Me.gunaLineTextBox20.Location = New System.Drawing.Point(38, 61)
			Me.gunaLineTextBox20.MaxLength = 2147483647
			Me.gunaLineTextBox20.Name = "gunaLineTextBox20"
			Me.gunaLineTextBox20.PasswordChar = ControlChars.NullChar
			Me.gunaLineTextBox20.Size = New System.Drawing.Size(341, 26)
			Me.gunaLineTextBox20.TabIndex = 7
			Me.gunaLineTextBox20.Text = "Insert the 2Captcha.com key here."
			Me.gunaLineTextBox20.TextOffsetX = 0
			' 
			' metroLabel12
			' 
			Me.metroLabel12.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.metroLabel12.BackColor = System.Drawing.Color.Transparent
			Me.metroLabel12.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.metroLabel12.Location = New System.Drawing.Point(-1, 8)
			Me.metroLabel12.Name = "metroLabel12"
			Me.metroLabel12.Size = New System.Drawing.Size(931, 23)
			Me.metroLabel12.TabIndex = 1
			Me.metroLabel12.Text = "Settings and Utils"
			Me.metroLabel12.TextAlign = System.Drawing.ContentAlignment.TopCenter
			' 
			' tabPage8
			' 
			Me.tabPage8.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(40)))), (CInt((CByte(40)))), (CInt((CByte(40)))))
			Me.tabPage8.Controls.Add(Me.siticoneButton23)
			Me.tabPage8.Controls.Add(Me.siticoneButton22)
			Me.tabPage8.Controls.Add(Me.siticoneButton21)
			Me.tabPage8.Controls.Add(Me.pictureBox2)
			Me.tabPage8.Controls.Add(Me.siticoneButton20)
			Me.tabPage8.Controls.Add(Me.gunaLineTextBox29)
			Me.tabPage8.Controls.Add(Me.siticoneButton19)
			Me.tabPage8.Controls.Add(Me.gunaLineTextBox28)
			Me.tabPage8.Controls.Add(Me.siticoneButton18)
			Me.tabPage8.Controls.Add(Me.siticoneButton15)
			Me.tabPage8.Controls.Add(Me.siticoneButton16)
			Me.tabPage8.Controls.Add(Me.metroLabel33)
			Me.tabPage8.Controls.Add(Me.metroLabel34)
			Me.tabPage8.Controls.Add(Me.siticoneButton17)
			Me.tabPage8.Controls.Add(Me.gunaLineTextBox27)
			Me.tabPage8.Controls.Add(Me.siticoneButton14)
			Me.tabPage8.Controls.Add(Me.siticoneButton13)
			Me.tabPage8.Controls.Add(Me.metroLabel32)
			Me.tabPage8.Controls.Add(Me.metroLabel31)
			Me.tabPage8.Controls.Add(Me.siticoneButton10)
			Me.tabPage8.Controls.Add(Me.gunaLineTextBox24)
			Me.tabPage8.Controls.Add(Me.gunaLineTextBox25)
			Me.tabPage8.Controls.Add(Me.metroLabel29)
			Me.tabPage8.Font = New System.Drawing.Font("Segoe UI", 10F)
			Me.tabPage8.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(153)))), (CInt((CByte(153)))), (CInt((CByte(153)))))
			Me.tabPage8.Location = New System.Drawing.Point(184, 4)
			Me.tabPage8.Name = "tabPage8"
			Me.tabPage8.Padding = New System.Windows.Forms.Padding(3)
			Me.tabPage8.Size = New System.Drawing.Size(931, 581)
			Me.tabPage8.TabIndex = 12
			Me.tabPage8.Text = "Miscellaneous"
			' 
			' siticoneButton23
			' 
			Me.siticoneButton23.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.siticoneButton23.BorderRadius = 15
			Me.siticoneButton23.CheckedState.Parent = Me.siticoneButton23
			Me.siticoneButton23.CustomImages.Parent = Me.siticoneButton23
			Me.siticoneButton23.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.siticoneButton23.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.siticoneButton23.ForeColor = System.Drawing.Color.White
			Me.siticoneButton23.HoveredState.Parent = Me.siticoneButton23
			Me.siticoneButton23.Location = New System.Drawing.Point(615, 526)
			Me.siticoneButton23.Name = "siticoneButton23"
			Me.siticoneButton23.ShadowDecoration.Parent = Me.siticoneButton23
			Me.siticoneButton23.Size = New System.Drawing.Size(291, 45)
			Me.siticoneButton23.TabIndex = 40
			Me.siticoneButton23.Text = "Reset avatar for all tokens"
'			Me.siticoneButton23.Click += New System.EventHandler(Me.siticoneButton23_Click)
			' 
			' siticoneButton22
			' 
			Me.siticoneButton22.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.siticoneButton22.BorderRadius = 15
			Me.siticoneButton22.CheckedState.Parent = Me.siticoneButton22
			Me.siticoneButton22.CustomImages.Parent = Me.siticoneButton22
			Me.siticoneButton22.Enabled = False
			Me.siticoneButton22.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.siticoneButton22.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.siticoneButton22.ForeColor = System.Drawing.Color.White
			Me.siticoneButton22.HoveredState.Parent = Me.siticoneButton22
			Me.siticoneButton22.Location = New System.Drawing.Point(615, 475)
			Me.siticoneButton22.Name = "siticoneButton22"
			Me.siticoneButton22.ShadowDecoration.Parent = Me.siticoneButton22
			Me.siticoneButton22.Size = New System.Drawing.Size(291, 45)
			Me.siticoneButton22.TabIndex = 39
			Me.siticoneButton22.Text = "Set new avatar image for all tokens"
'			Me.siticoneButton22.Click += New System.EventHandler(Me.siticoneButton22_Click)
			' 
			' siticoneButton21
			' 
			Me.siticoneButton21.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.siticoneButton21.BorderRadius = 15
			Me.siticoneButton21.CheckedState.Parent = Me.siticoneButton21
			Me.siticoneButton21.CustomImages.Parent = Me.siticoneButton21
			Me.siticoneButton21.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.siticoneButton21.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.siticoneButton21.ForeColor = System.Drawing.Color.White
			Me.siticoneButton21.HoveredState.Parent = Me.siticoneButton21
			Me.siticoneButton21.Location = New System.Drawing.Point(615, 424)
			Me.siticoneButton21.Name = "siticoneButton21"
			Me.siticoneButton21.ShadowDecoration.Parent = Me.siticoneButton21
			Me.siticoneButton21.Size = New System.Drawing.Size(291, 45)
			Me.siticoneButton21.TabIndex = 38
			Me.siticoneButton21.Text = "Import new avatar image from file"
'			Me.siticoneButton21.Click += New System.EventHandler(Me.siticoneButton21_Click)
			' 
			' pictureBox2
			' 
			Me.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
			Me.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.pictureBox2.Location = New System.Drawing.Point(702, 281)
			Me.pictureBox2.Name = "pictureBox2"
			Me.pictureBox2.Size = New System.Drawing.Size(128, 128)
			Me.pictureBox2.TabIndex = 37
			Me.pictureBox2.TabStop = False
			' 
			' siticoneButton20
			' 
			Me.siticoneButton20.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.siticoneButton20.BorderRadius = 15
			Me.siticoneButton20.CheckedState.Parent = Me.siticoneButton20
			Me.siticoneButton20.CustomImages.Parent = Me.siticoneButton20
			Me.siticoneButton20.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.siticoneButton20.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.siticoneButton20.ForeColor = System.Drawing.Color.White
			Me.siticoneButton20.HoveredState.Parent = Me.siticoneButton20
			Me.siticoneButton20.Location = New System.Drawing.Point(14, 517)
			Me.siticoneButton20.Name = "siticoneButton20"
			Me.siticoneButton20.ShadowDecoration.Parent = Me.siticoneButton20
			Me.siticoneButton20.Size = New System.Drawing.Size(291, 45)
			Me.siticoneButton20.TabIndex = 36
			Me.siticoneButton20.Text = "Set new custom status for all tokens"
			Me.siticoneButton20.Visible = False
'			Me.siticoneButton20.Click += New System.EventHandler(Me.siticoneButton20_Click)
			' 
			' gunaLineTextBox29
			' 
			Me.gunaLineTextBox29.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.gunaLineTextBox29.Animated = True
			Me.gunaLineTextBox29.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(40)))), (CInt((CByte(40)))), (CInt((CByte(40)))))
			Me.gunaLineTextBox29.Cursor = System.Windows.Forms.Cursors.IBeam
			Me.gunaLineTextBox29.FocusedLineColor = System.Drawing.Color.Red
			Me.gunaLineTextBox29.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.gunaLineTextBox29.LineColor = System.Drawing.Color.Gainsboro
			Me.gunaLineTextBox29.LineSize = 1
			Me.gunaLineTextBox29.Location = New System.Drawing.Point(14, 485)
			Me.gunaLineTextBox29.MaxLength = 2147483647
			Me.gunaLineTextBox29.Name = "gunaLineTextBox29"
			Me.gunaLineTextBox29.PasswordChar = ControlChars.NullChar
			Me.gunaLineTextBox29.Size = New System.Drawing.Size(291, 26)
			Me.gunaLineTextBox29.TabIndex = 35
			Me.gunaLineTextBox29.Text = "Insert the new custom status here."
			Me.gunaLineTextBox29.TextOffsetX = 0
			Me.gunaLineTextBox29.Visible = False
			' 
			' siticoneButton19
			' 
			Me.siticoneButton19.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.siticoneButton19.BorderRadius = 15
			Me.siticoneButton19.CheckedState.Parent = Me.siticoneButton19
			Me.siticoneButton19.CustomImages.Parent = Me.siticoneButton19
			Me.siticoneButton19.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.siticoneButton19.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.siticoneButton19.ForeColor = System.Drawing.Color.White
			Me.siticoneButton19.HoveredState.Parent = Me.siticoneButton19
			Me.siticoneButton19.Location = New System.Drawing.Point(14, 434)
			Me.siticoneButton19.Name = "siticoneButton19"
			Me.siticoneButton19.ShadowDecoration.Parent = Me.siticoneButton19
			Me.siticoneButton19.Size = New System.Drawing.Size(291, 45)
			Me.siticoneButton19.TabIndex = 34
			Me.siticoneButton19.Text = "Set new game for all tokens"
			Me.siticoneButton19.Visible = False
'			Me.siticoneButton19.Click += New System.EventHandler(Me.siticoneButton19_Click)
			' 
			' gunaLineTextBox28
			' 
			Me.gunaLineTextBox28.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.gunaLineTextBox28.Animated = True
			Me.gunaLineTextBox28.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(40)))), (CInt((CByte(40)))), (CInt((CByte(40)))))
			Me.gunaLineTextBox28.Cursor = System.Windows.Forms.Cursors.IBeam
			Me.gunaLineTextBox28.FocusedLineColor = System.Drawing.Color.Red
			Me.gunaLineTextBox28.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.gunaLineTextBox28.LineColor = System.Drawing.Color.Gainsboro
			Me.gunaLineTextBox28.LineSize = 1
			Me.gunaLineTextBox28.Location = New System.Drawing.Point(14, 402)
			Me.gunaLineTextBox28.MaxLength = 2147483647
			Me.gunaLineTextBox28.Name = "gunaLineTextBox28"
			Me.gunaLineTextBox28.PasswordChar = ControlChars.NullChar
			Me.gunaLineTextBox28.Size = New System.Drawing.Size(291, 26)
			Me.gunaLineTextBox28.TabIndex = 33
			Me.gunaLineTextBox28.Text = "Insert the new game here."
			Me.gunaLineTextBox28.TextOffsetX = 0
			Me.gunaLineTextBox28.Visible = False
			' 
			' siticoneButton18
			' 
			Me.siticoneButton18.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.siticoneButton18.BorderRadius = 15
			Me.siticoneButton18.CheckedState.Parent = Me.siticoneButton18
			Me.siticoneButton18.CustomImages.Parent = Me.siticoneButton18
			Me.siticoneButton18.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.siticoneButton18.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.siticoneButton18.ForeColor = System.Drawing.Color.White
			Me.siticoneButton18.HoveredState.Parent = Me.siticoneButton18
			Me.siticoneButton18.Location = New System.Drawing.Point(14, 337)
			Me.siticoneButton18.Name = "siticoneButton18"
			Me.siticoneButton18.ShadowDecoration.Parent = Me.siticoneButton18
			Me.siticoneButton18.Size = New System.Drawing.Size(291, 45)
			Me.siticoneButton18.TabIndex = 32
			Me.siticoneButton18.Text = "Phone Lock all loaded tokens"
'			Me.siticoneButton18.Click += New System.EventHandler(Me.siticoneButton18_Click)
			' 
			' siticoneButton15
			' 
			Me.siticoneButton15.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.siticoneButton15.BorderRadius = 15
			Me.siticoneButton15.CheckedState.Parent = Me.siticoneButton15
			Me.siticoneButton15.CustomImages.Parent = Me.siticoneButton15
			Me.siticoneButton15.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.siticoneButton15.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.siticoneButton15.ForeColor = System.Drawing.Color.White
			Me.siticoneButton15.HoveredState.Parent = Me.siticoneButton15
			Me.siticoneButton15.Location = New System.Drawing.Point(615, 223)
			Me.siticoneButton15.Name = "siticoneButton15"
			Me.siticoneButton15.ShadowDecoration.Parent = Me.siticoneButton15
			Me.siticoneButton15.Size = New System.Drawing.Size(291, 45)
			Me.siticoneButton15.TabIndex = 31
			Me.siticoneButton15.Text = "Import roles from file"
'			Me.siticoneButton15.Click += New System.EventHandler(Me.siticoneButton15_Click)
			' 
			' siticoneButton16
			' 
			Me.siticoneButton16.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.siticoneButton16.BorderRadius = 15
			Me.siticoneButton16.CheckedState.Parent = Me.siticoneButton16
			Me.siticoneButton16.CustomImages.Parent = Me.siticoneButton16
			Me.siticoneButton16.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.siticoneButton16.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.siticoneButton16.ForeColor = System.Drawing.Color.White
			Me.siticoneButton16.HoveredState.Parent = Me.siticoneButton16
			Me.siticoneButton16.Location = New System.Drawing.Point(615, 172)
			Me.siticoneButton16.Name = "siticoneButton16"
			Me.siticoneButton16.ShadowDecoration.Parent = Me.siticoneButton16
			Me.siticoneButton16.Size = New System.Drawing.Size(291, 45)
			Me.siticoneButton16.TabIndex = 30
			Me.siticoneButton16.Text = "Export roles list to file"
'			Me.siticoneButton16.Click += New System.EventHandler(Me.siticoneButton16_Click)
			' 
			' metroLabel33
			' 
			Me.metroLabel33.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.metroLabel33.BackColor = System.Drawing.Color.Transparent
			Me.metroLabel33.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.metroLabel33.Location = New System.Drawing.Point(615, 147)
			Me.metroLabel33.Name = "metroLabel33"
			Me.metroLabel33.Size = New System.Drawing.Size(291, 19)
			Me.metroLabel33.TabIndex = 29
			Me.metroLabel33.Text = "0"
			Me.metroLabel33.TextAlign = System.Drawing.ContentAlignment.TopCenter
			' 
			' metroLabel34
			' 
			Me.metroLabel34.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.metroLabel34.BackColor = System.Drawing.Color.Transparent
			Me.metroLabel34.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.metroLabel34.Location = New System.Drawing.Point(612, 126)
			Me.metroLabel34.Name = "metroLabel34"
			Me.metroLabel34.Size = New System.Drawing.Size(294, 19)
			Me.metroLabel34.TabIndex = 28
			Me.metroLabel34.Text = "Parsed Roles"
			Me.metroLabel34.TextAlign = System.Drawing.ContentAlignment.TopCenter
			' 
			' siticoneButton17
			' 
			Me.siticoneButton17.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.siticoneButton17.BorderRadius = 15
			Me.siticoneButton17.CheckedState.Parent = Me.siticoneButton17
			Me.siticoneButton17.CustomImages.Parent = Me.siticoneButton17
			Me.siticoneButton17.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.siticoneButton17.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.siticoneButton17.ForeColor = System.Drawing.Color.White
			Me.siticoneButton17.HoveredState.Parent = Me.siticoneButton17
			Me.siticoneButton17.Location = New System.Drawing.Point(615, 72)
			Me.siticoneButton17.Name = "siticoneButton17"
			Me.siticoneButton17.ShadowDecoration.Parent = Me.siticoneButton17
			Me.siticoneButton17.Size = New System.Drawing.Size(291, 45)
			Me.siticoneButton17.TabIndex = 27
			Me.siticoneButton17.Text = "Parse Roles for this guild"
'			Me.siticoneButton17.Click += New System.EventHandler(Me.siticoneButton17_Click)
			' 
			' gunaLineTextBox27
			' 
			Me.gunaLineTextBox27.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.gunaLineTextBox27.Animated = True
			Me.gunaLineTextBox27.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(40)))), (CInt((CByte(40)))), (CInt((CByte(40)))))
			Me.gunaLineTextBox27.Cursor = System.Windows.Forms.Cursors.IBeam
			Me.gunaLineTextBox27.FocusedLineColor = System.Drawing.Color.Red
			Me.gunaLineTextBox27.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.gunaLineTextBox27.LineColor = System.Drawing.Color.Gainsboro
			Me.gunaLineTextBox27.LineSize = 1
			Me.gunaLineTextBox27.Location = New System.Drawing.Point(615, 40)
			Me.gunaLineTextBox27.MaxLength = 2147483647
			Me.gunaLineTextBox27.Name = "gunaLineTextBox27"
			Me.gunaLineTextBox27.PasswordChar = ControlChars.NullChar
			Me.gunaLineTextBox27.Size = New System.Drawing.Size(291, 26)
			Me.gunaLineTextBox27.TabIndex = 25
			Me.gunaLineTextBox27.Text = "Insert the guild ID here."
			Me.gunaLineTextBox27.TextOffsetX = 0
			' 
			' siticoneButton14
			' 
			Me.siticoneButton14.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.siticoneButton14.BorderRadius = 15
			Me.siticoneButton14.CheckedState.Parent = Me.siticoneButton14
			Me.siticoneButton14.CustomImages.Parent = Me.siticoneButton14
			Me.siticoneButton14.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.siticoneButton14.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.siticoneButton14.ForeColor = System.Drawing.Color.White
			Me.siticoneButton14.HoveredState.Parent = Me.siticoneButton14
			Me.siticoneButton14.Location = New System.Drawing.Point(14, 258)
			Me.siticoneButton14.Name = "siticoneButton14"
			Me.siticoneButton14.ShadowDecoration.Parent = Me.siticoneButton14
			Me.siticoneButton14.Size = New System.Drawing.Size(291, 45)
			Me.siticoneButton14.TabIndex = 24
			Me.siticoneButton14.Text = "Import users from file"
'			Me.siticoneButton14.Click += New System.EventHandler(Me.siticoneButton14_Click)
			' 
			' siticoneButton13
			' 
			Me.siticoneButton13.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.siticoneButton13.BorderRadius = 15
			Me.siticoneButton13.CheckedState.Parent = Me.siticoneButton13
			Me.siticoneButton13.CustomImages.Parent = Me.siticoneButton13
			Me.siticoneButton13.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.siticoneButton13.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.siticoneButton13.ForeColor = System.Drawing.Color.White
			Me.siticoneButton13.HoveredState.Parent = Me.siticoneButton13
			Me.siticoneButton13.Location = New System.Drawing.Point(14, 207)
			Me.siticoneButton13.Name = "siticoneButton13"
			Me.siticoneButton13.ShadowDecoration.Parent = Me.siticoneButton13
			Me.siticoneButton13.Size = New System.Drawing.Size(291, 45)
			Me.siticoneButton13.TabIndex = 23
			Me.siticoneButton13.Text = "Export users list to file"
'			Me.siticoneButton13.Click += New System.EventHandler(Me.siticoneButton13_Click)
			' 
			' metroLabel32
			' 
			Me.metroLabel32.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.metroLabel32.BackColor = System.Drawing.Color.Transparent
			Me.metroLabel32.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.metroLabel32.Location = New System.Drawing.Point(14, 182)
			Me.metroLabel32.Name = "metroLabel32"
			Me.metroLabel32.Size = New System.Drawing.Size(291, 19)
			Me.metroLabel32.TabIndex = 22
			Me.metroLabel32.Text = "0"
			Me.metroLabel32.TextAlign = System.Drawing.ContentAlignment.TopCenter
			' 
			' metroLabel31
			' 
			Me.metroLabel31.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.metroLabel31.BackColor = System.Drawing.Color.Transparent
			Me.metroLabel31.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.metroLabel31.Location = New System.Drawing.Point(11, 161)
			Me.metroLabel31.Name = "metroLabel31"
			Me.metroLabel31.Size = New System.Drawing.Size(294, 19)
			Me.metroLabel31.TabIndex = 21
			Me.metroLabel31.Text = "Parsed Users"
			Me.metroLabel31.TextAlign = System.Drawing.ContentAlignment.TopCenter
			' 
			' siticoneButton10
			' 
			Me.siticoneButton10.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.siticoneButton10.BorderRadius = 15
			Me.siticoneButton10.CheckedState.Parent = Me.siticoneButton10
			Me.siticoneButton10.CustomImages.Parent = Me.siticoneButton10
			Me.siticoneButton10.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(184)))), (CInt((CByte(44)))), (CInt((CByte(44)))))
			Me.siticoneButton10.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.siticoneButton10.ForeColor = System.Drawing.Color.White
			Me.siticoneButton10.HoveredState.Parent = Me.siticoneButton10
			Me.siticoneButton10.Location = New System.Drawing.Point(14, 107)
			Me.siticoneButton10.Name = "siticoneButton10"
			Me.siticoneButton10.ShadowDecoration.Parent = Me.siticoneButton10
			Me.siticoneButton10.Size = New System.Drawing.Size(291, 45)
			Me.siticoneButton10.TabIndex = 20
			Me.siticoneButton10.Text = "Parse Users for this guild"
'			Me.siticoneButton10.Click += New System.EventHandler(Me.siticoneButton10_Click)
			' 
			' gunaLineTextBox24
			' 
			Me.gunaLineTextBox24.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.gunaLineTextBox24.Animated = True
			Me.gunaLineTextBox24.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(40)))), (CInt((CByte(40)))), (CInt((CByte(40)))))
			Me.gunaLineTextBox24.Cursor = System.Windows.Forms.Cursors.IBeam
			Me.gunaLineTextBox24.FocusedLineColor = System.Drawing.Color.Red
			Me.gunaLineTextBox24.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.gunaLineTextBox24.LineColor = System.Drawing.Color.Gainsboro
			Me.gunaLineTextBox24.LineSize = 1
			Me.gunaLineTextBox24.Location = New System.Drawing.Point(14, 72)
			Me.gunaLineTextBox24.MaxLength = 2147483647
			Me.gunaLineTextBox24.Name = "gunaLineTextBox24"
			Me.gunaLineTextBox24.PasswordChar = ControlChars.NullChar
			Me.gunaLineTextBox24.Size = New System.Drawing.Size(291, 26)
			Me.gunaLineTextBox24.TabIndex = 9
			Me.gunaLineTextBox24.Text = "Insert the channel ID here."
			Me.gunaLineTextBox24.TextOffsetX = 0
			' 
			' gunaLineTextBox25
			' 
			Me.gunaLineTextBox25.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.gunaLineTextBox25.Animated = True
			Me.gunaLineTextBox25.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(40)))), (CInt((CByte(40)))), (CInt((CByte(40)))))
			Me.gunaLineTextBox25.Cursor = System.Windows.Forms.Cursors.IBeam
			Me.gunaLineTextBox25.FocusedLineColor = System.Drawing.Color.Red
			Me.gunaLineTextBox25.Font = New System.Drawing.Font("Segoe UI", 9F)
			Me.gunaLineTextBox25.LineColor = System.Drawing.Color.Gainsboro
			Me.gunaLineTextBox25.LineSize = 1
			Me.gunaLineTextBox25.Location = New System.Drawing.Point(14, 40)
			Me.gunaLineTextBox25.MaxLength = 2147483647
			Me.gunaLineTextBox25.Name = "gunaLineTextBox25"
			Me.gunaLineTextBox25.PasswordChar = ControlChars.NullChar
			Me.gunaLineTextBox25.Size = New System.Drawing.Size(291, 26)
			Me.gunaLineTextBox25.TabIndex = 8
			Me.gunaLineTextBox25.Text = "Insert the guild invite link / code here."
			Me.gunaLineTextBox25.TextOffsetX = 0
			' 
			' metroLabel29
			' 
			Me.metroLabel29.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.metroLabel29.BackColor = System.Drawing.Color.Transparent
			Me.metroLabel29.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.metroLabel29.Location = New System.Drawing.Point(-1, 8)
			Me.metroLabel29.Name = "metroLabel29"
			Me.metroLabel29.Size = New System.Drawing.Size(931, 23)
			Me.metroLabel29.TabIndex = 2
			Me.metroLabel29.Text = "Miscellaneous"
			Me.metroLabel29.TextAlign = System.Drawing.ContentAlignment.TopCenter
			' 
			' tabPage13
			' 
			Me.tabPage13.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(40)))), (CInt((CByte(40)))), (CInt((CByte(40)))))
			Me.tabPage13.Controls.Add(Me.metroLabel24)
			Me.tabPage13.Font = New System.Drawing.Font("Segoe UI", 10F)
			Me.tabPage13.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(153)))), (CInt((CByte(153)))), (CInt((CByte(153)))))
			Me.tabPage13.Location = New System.Drawing.Point(184, 4)
			Me.tabPage13.Name = "tabPage13"
			Me.tabPage13.Padding = New System.Windows.Forms.Padding(3)
			Me.tabPage13.Size = New System.Drawing.Size(931, 581)
			Me.tabPage13.TabIndex = 13
			Me.tabPage13.Text = "Tokens Utils"
			' 
			' metroLabel24
			' 
			Me.metroLabel24.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.metroLabel24.BackColor = System.Drawing.Color.Transparent
			Me.metroLabel24.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.metroLabel24.Location = New System.Drawing.Point(-1, 8)
			Me.metroLabel24.Name = "metroLabel24"
			Me.metroLabel24.Size = New System.Drawing.Size(931, 23)
			Me.metroLabel24.TabIndex = 3
			Me.metroLabel24.Text = "Tokens Utils"
			Me.metroLabel24.TextAlign = System.Drawing.ContentAlignment.TopCenter
			' 
			' openFileDialog3
			' 
			Me.openFileDialog3.Filter = "Text file (*.txt)|*.txt"
			Me.openFileDialog3.Title = "Import users from file"
			' 
			' openFileDialog4
			' 
			Me.openFileDialog4.Filter = "Text file (*.txt)|*.txt"
			Me.openFileDialog4.Title = "Import roles list from file"
			' 
			' saveFileDialog1
			' 
			Me.saveFileDialog1.Filter = "Text file (*.txt)|*.txt"
			Me.saveFileDialog1.Title = "Export users list to file"
			' 
			' saveFileDialog2
			' 
			Me.saveFileDialog2.Filter = "Text file (*.txt)|*.txt"
			Me.saveFileDialog2.Title = "Export roles list to file"
			' 
			' openFileDialog5
			' 
			Me.openFileDialog5.Title = "Import new avatar image from file"
			' 
			' MainForm
			' 
			Me.AccentColor = System.Drawing.Color.Red
			Me.AutoScaleDimensions = New System.Drawing.SizeF(7F, 15F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(40)))), (CInt((CByte(40)))), (CInt((CByte(40)))))
			Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
			Me.ClientSize = New System.Drawing.Size(1124, 634)
			Me.Controls.Add(Me.firefoxMainTabControl1)
			Me.Controls.Add(Me.gunaControlBox3)
			Me.Controls.Add(Me.gunaControlBox2)
			Me.Controls.Add(Me.gunaControlBox1)
			Me.ForeColor = System.Drawing.SystemColors.ControlDark
			Me.Icon = (DirectCast(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.Name = "MainForm"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.State = MetroSuite.MetroForm.FormState.Custom
			Me.Style = MetroSuite.Design.Style.Dark
			Me.Text = "AstarothSpammer XLS V1"
'			Me.FormClosing += New System.Windows.Forms.FormClosingEventHandler(Me.MainForm_FormClosing)
			Me.firefoxMainTabControl1.ResumeLayout(False)
			Me.tabPage1.ResumeLayout(False)
			Me.tabPage1.PerformLayout()
			DirectCast(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.tabPage2.ResumeLayout(False)
			Me.tabPage2.PerformLayout()
			Me.tabPage3.ResumeLayout(False)
			Me.tabPage3.PerformLayout()
			Me.tabPage4.ResumeLayout(False)
			Me.tabPage4.PerformLayout()
			Me.tabPage5.ResumeLayout(False)
			Me.tabPage5.PerformLayout()
			Me.tabPage6.ResumeLayout(False)
			Me.tabPage6.PerformLayout()
			Me.tabPage7.ResumeLayout(False)
			Me.tabPage7.PerformLayout()
			Me.tabPage9.ResumeLayout(False)
			Me.tabPage9.PerformLayout()
			Me.tabPage10.ResumeLayout(False)
			Me.tabPage10.PerformLayout()
			Me.tabPage11.ResumeLayout(False)
			Me.tabPage11.PerformLayout()
			Me.tabPage12.ResumeLayout(False)
			Me.tabPage12.PerformLayout()
			Me.tabPage8.ResumeLayout(False)
			DirectCast(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.tabPage13.ResumeLayout(False)
			Me.ResumeLayout(False)

	End Sub

	Private gunaControlBox1 As Guna.UI.WinForms.GunaControlBox
	Private gunaControlBox2 As Guna.UI.WinForms.GunaControlBox
	Private gunaControlBox3 As Guna.UI.WinForms.GunaControlBox
	Private firefoxMainTabControl1 As FirefoxMainTabControl
	Private tabPage1 As System.Windows.Forms.TabPage
	Private tabPage2 As System.Windows.Forms.TabPage
	Private tabPage3 As System.Windows.Forms.TabPage
	Private tabPage4 As System.Windows.Forms.TabPage
	Private tabPage5 As System.Windows.Forms.TabPage
	Private tabPage6 As System.Windows.Forms.TabPage
	Private tabPage7 As System.Windows.Forms.TabPage
	Private tabPage9 As System.Windows.Forms.TabPage
	Private tabPage10 As System.Windows.Forms.TabPage
	Private tabPage11 As System.Windows.Forms.TabPage
	Private tabPage12 As System.Windows.Forms.TabPage
	Private metroLabel1 As MetroSuite.MetroLabel
	Private WithEvents siticoneButton1 As ns1.SiticoneButton
	Private metroLabel14 As MetroSuite.MetroLabel
	Private metroLabel13 As MetroSuite.MetroLabel
	Private WithEvents siticoneButton2 As ns1.SiticoneButton
	Private WithEvents siticoneButton3 As ns1.SiticoneButton
	Private metroLabel15 As MetroSuite.MetroLabel
	Private metroLabel16 As MetroSuite.MetroLabel
	Private WithEvents siticoneButton4 As ns1.SiticoneButton
	Private pictureBox1 As System.Windows.Forms.PictureBox
	Private WithEvents siticoneButton5 As ns1.SiticoneButton
	Private WithEvents siticoneButton6 As ns1.SiticoneButton
	Private metroLabel2 As MetroSuite.MetroLabel
	Private metroLabel3 As MetroSuite.MetroLabel
	Private metroLabel4 As MetroSuite.MetroLabel
	Private metroLabel5 As MetroSuite.MetroLabel
	Private metroLabel6 As MetroSuite.MetroLabel
	Private metroLabel7 As MetroSuite.MetroLabel
	Private metroLabel9 As MetroSuite.MetroLabel
	Private metroLabel10 As MetroSuite.MetroLabel
	Private metroLabel11 As MetroSuite.MetroLabel
	Private metroLabel12 As MetroSuite.MetroLabel
	Private gunaLineTextBox1 As Guna.UI.WinForms.GunaLineTextBox
	Private gunaLineTextBox2 As Guna.UI.WinForms.GunaLineTextBox
	Private gunaLineTextBox3 As Guna.UI.WinForms.GunaLineTextBox
	Private WithEvents siticoneCheckBox1 As ns1.SiticoneCheckBox
	Private WithEvents siticoneCheckBox2 As ns1.SiticoneCheckBox
	Private WithEvents siticoneCheckBox3 As ns1.SiticoneCheckBox
	Private WithEvents siticoneCheckBox4 As ns1.SiticoneCheckBox
	Private metroLabel17 As MetroSuite.MetroLabel
	Private siticoneOSToggleSwith1 As ns1.SiticoneOSToggleSwith
	Private WithEvents gunaButton1 As Guna.UI.WinForms.GunaButton
	Private WithEvents gunaButton2 As Guna.UI.WinForms.GunaButton
	Private WithEvents bunifuHSlider1 As Bunifu.UI.WinForms.BunifuHSlider
	Private gunaLineTextBox5 As Guna.UI.WinForms.GunaLineTextBox
	Private gunaLineTextBox4 As Guna.UI.WinForms.GunaLineTextBox
	Private gunaTextBox1 As Guna.UI.WinForms.GunaTextBox
	Private siticoneCheckBox9 As ns1.SiticoneCheckBox
	Private siticoneCheckBox8 As ns1.SiticoneCheckBox
	Private siticoneCheckBox7 As ns1.SiticoneCheckBox
	Private metroLabel18 As MetroSuite.MetroLabel
	Private siticoneOSToggleSwith2 As ns1.SiticoneOSToggleSwith
	Private WithEvents bunifuHSlider2 As Bunifu.UI.WinForms.BunifuHSlider
	Private WithEvents gunaButton3 As Guna.UI.WinForms.GunaButton
	Private WithEvents gunaButton4 As Guna.UI.WinForms.GunaButton
	Private gunaTextBox2 As Guna.UI.WinForms.GunaTextBox
	Private gunaLineTextBox7 As Guna.UI.WinForms.GunaLineTextBox
	Private gunaLineTextBox6 As Guna.UI.WinForms.GunaLineTextBox
	Private siticoneCheckBox12 As ns1.SiticoneCheckBox
	Private siticoneCheckBox11 As ns1.SiticoneCheckBox
	Private WithEvents bunifuHSlider3 As Bunifu.UI.WinForms.BunifuHSlider
	Private WithEvents gunaButton6 As Guna.UI.WinForms.GunaButton
	Private WithEvents gunaButton5 As Guna.UI.WinForms.GunaButton
	Private metroLabel19 As MetroSuite.MetroLabel
	Private siticoneOSToggleSwith3 As ns1.SiticoneOSToggleSwith
	Private gunaLineTextBox8 As Guna.UI.WinForms.GunaLineTextBox
	Private gunaLineTextBox10 As Guna.UI.WinForms.GunaLineTextBox
	Private gunaLineTextBox9 As Guna.UI.WinForms.GunaLineTextBox
	Private siticoneRadioButton2 As ns1.SiticoneRadioButton
	Private siticoneRadioButton1 As ns1.SiticoneRadioButton
	Private metroLabel20 As MetroSuite.MetroLabel
	Private siticoneOSToggleSwith4 As ns1.SiticoneOSToggleSwith
	Private WithEvents bunifuHSlider4 As Bunifu.UI.WinForms.BunifuHSlider
	Private WithEvents gunaButton8 As Guna.UI.WinForms.GunaButton
	Private WithEvents gunaButton7 As Guna.UI.WinForms.GunaButton
	Private WithEvents siticoneButton7 As ns1.SiticoneButton
	Private gunaLineTextBox11 As Guna.UI.WinForms.GunaLineTextBox
	Private siticoneCheckBox5 As ns1.SiticoneCheckBox
	Private metroLabel21 As MetroSuite.MetroLabel
	Private siticoneOSToggleSwith5 As ns1.SiticoneOSToggleSwith
	Private WithEvents gunaButton9 As Guna.UI.WinForms.GunaButton
	Private WithEvents gunaButton10 As Guna.UI.WinForms.GunaButton
	Private WithEvents bunifuHSlider5 As Bunifu.UI.WinForms.BunifuHSlider
	Private gunaLineTextBox12 As Guna.UI.WinForms.GunaLineTextBox
	Private metroLabel22 As MetroSuite.MetroLabel
	Private siticoneOSToggleSwith6 As ns1.SiticoneOSToggleSwith
	Private siticoneCheckBox13 As ns1.SiticoneCheckBox
	Private WithEvents gunaButton12 As Guna.UI.WinForms.GunaButton
	Private WithEvents gunaButton11 As Guna.UI.WinForms.GunaButton
	Private WithEvents bunifuHSlider6 As Bunifu.UI.WinForms.BunifuHSlider
	Private gunaLineTextBox15 As Guna.UI.WinForms.GunaLineTextBox
	Private gunaLineTextBox14 As Guna.UI.WinForms.GunaLineTextBox
	Private metroLabel26 As MetroSuite.MetroLabel
	Private siticoneOSToggleSwith10 As ns1.SiticoneOSToggleSwith
	Private metroLabel25 As MetroSuite.MetroLabel
	Private siticoneOSToggleSwith9 As ns1.SiticoneOSToggleSwith
	Private WithEvents bunifuHSlider10 As Bunifu.UI.WinForms.BunifuHSlider
	Private WithEvents bunifuHSlider9 As Bunifu.UI.WinForms.BunifuHSlider
	Private siticoneCheckBox16 As ns1.SiticoneCheckBox
	Private siticoneCheckBox15 As ns1.SiticoneCheckBox
	Private siticoneCheckBox14 As ns1.SiticoneCheckBox
	Private siticoneCheckBox17 As ns1.SiticoneCheckBox
	Private siticoneCheckBox18 As ns1.SiticoneCheckBox
	Private WithEvents siticoneCheckBox19 As ns1.SiticoneCheckBox
	Private siticoneCheckBox20 As ns1.SiticoneCheckBox
	Private siticoneCheckBox21 As ns1.SiticoneCheckBox
	Private WithEvents gunaButton16 As Guna.UI.WinForms.GunaButton
	Private WithEvents gunaButton15 As Guna.UI.WinForms.GunaButton
	Private gunaLineTextBox16 As Guna.UI.WinForms.GunaLineTextBox
	Private gunaLineTextBox17 As Guna.UI.WinForms.GunaLineTextBox
	Private gunaLineTextBox19 As Guna.UI.WinForms.GunaLineTextBox
	Private gunaLineTextBox18 As Guna.UI.WinForms.GunaLineTextBox
	Private gunaTextBox3 As Guna.UI.WinForms.GunaTextBox
	Private metroLabel27 As MetroSuite.MetroLabel
	Private siticoneOSToggleSwith11 As ns1.SiticoneOSToggleSwith
	Private WithEvents bunifuHSlider11 As Bunifu.UI.WinForms.BunifuHSlider
	Private WithEvents gunaButton18 As Guna.UI.WinForms.GunaButton
	Private WithEvents gunaButton17 As Guna.UI.WinForms.GunaButton
	Private gunaTextBox4 As Guna.UI.WinForms.GunaTextBox
	Private metroLabel28 As MetroSuite.MetroLabel
	Private siticoneOSToggleSwith12 As ns1.SiticoneOSToggleSwith
	Private WithEvents bunifuHSlider12 As Bunifu.UI.WinForms.BunifuHSlider
	Private WithEvents gunaButton20 As Guna.UI.WinForms.GunaButton
	Private WithEvents gunaButton19 As Guna.UI.WinForms.GunaButton
	Private gunaLineTextBox20 As Guna.UI.WinForms.GunaLineTextBox
	Private WithEvents gunaLinkLabel1 As Guna.UI.WinForms.GunaLinkLabel
	Private gunaLineTextBox22 As Guna.UI.WinForms.GunaLineTextBox
	Private gunaLineTextBox21 As Guna.UI.WinForms.GunaLineTextBox
	Private WithEvents siticoneButton8 As ns1.SiticoneButton
	Private siticoneComboBox2 As ns1.SiticoneComboBox
	Private WithEvents siticoneButton11 As ns1.SiticoneButton
	Private WithEvents siticoneButton12 As ns1.SiticoneButton
	Private openFileDialog1 As System.Windows.Forms.OpenFileDialog
	Private openFileDialog2 As System.Windows.Forms.OpenFileDialog
	Private siticoneCheckBox23 As ns1.SiticoneCheckBox
	Private siticoneRadioButton5 As ns1.SiticoneRadioButton
	Private siticoneRadioButton4 As ns1.SiticoneRadioButton
	Private siticoneRadioButton3 As ns1.SiticoneRadioButton
	Private siticoneRadioButton6 As ns1.SiticoneRadioButton
	Private siticoneRadioButton7 As ns1.SiticoneRadioButton
	Private siticoneRadioButton8 As ns1.SiticoneRadioButton
	Private gunaLineTextBox13 As Guna.UI.WinForms.GunaLineTextBox
	Private gunaTextBox5 As Guna.UI.WinForms.GunaTextBox
	Private siticoneCheckBox25 As ns1.SiticoneCheckBox
	Private siticoneCheckBox24 As ns1.SiticoneCheckBox
	Private siticoneCheckBox10 As ns1.SiticoneCheckBox
	Private siticoneCheckBox6 As ns1.SiticoneCheckBox
	Private siticoneCheckBox26 As ns1.SiticoneCheckBox
	Private siticoneComboBox1 As ns1.SiticoneComboBox
	Private WithEvents siticoneButton9 As ns1.SiticoneButton
	Private siticoneCheckBox22 As ns1.SiticoneCheckBox
	Private siticoneCheckBox27 As ns1.SiticoneCheckBox
	Private siticoneRadioButton9 As ns1.SiticoneRadioButton
	Private siticoneRadioButton10 As ns1.SiticoneRadioButton
	Private siticoneRadioButton11 As ns1.SiticoneRadioButton
	Private metroLabel8 As MetroSuite.MetroLabel
	Private siticoneCheckBox28 As ns1.SiticoneCheckBox
	Private siticoneCheckBox29 As ns1.SiticoneCheckBox
	Private siticoneCheckBox32 As ns1.SiticoneCheckBox
	Private siticoneCheckBox31 As ns1.SiticoneCheckBox
	Private siticoneCheckBox30 As ns1.SiticoneCheckBox
	Private tabPage8 As System.Windows.Forms.TabPage
	Private metroLabel29 As MetroSuite.MetroLabel
	Private gunaLineTextBox24 As Guna.UI.WinForms.GunaLineTextBox
	Private gunaLineTextBox25 As Guna.UI.WinForms.GunaLineTextBox
	Private WithEvents siticoneButton10 As ns1.SiticoneButton
	Private metroLabel32 As MetroSuite.MetroLabel
	Private metroLabel31 As MetroSuite.MetroLabel
	Private WithEvents siticoneButton14 As ns1.SiticoneButton
	Private WithEvents siticoneButton13 As ns1.SiticoneButton
	Private WithEvents siticoneButton15 As ns1.SiticoneButton
	Private WithEvents siticoneButton16 As ns1.SiticoneButton
	Private metroLabel33 As MetroSuite.MetroLabel
	Private metroLabel34 As MetroSuite.MetroLabel
	Private WithEvents siticoneButton17 As ns1.SiticoneButton
	Private gunaLineTextBox27 As Guna.UI.WinForms.GunaLineTextBox
	Private WithEvents siticoneButton18 As ns1.SiticoneButton
	Private gunaLineTextBox28 As Guna.UI.WinForms.GunaLineTextBox
	Private WithEvents siticoneButton19 As ns1.SiticoneButton
	Private WithEvents siticoneButton20 As ns1.SiticoneButton
	Private gunaLineTextBox29 As Guna.UI.WinForms.GunaLineTextBox
	Private pictureBox2 As System.Windows.Forms.PictureBox
	Private WithEvents siticoneButton21 As ns1.SiticoneButton
	Private WithEvents siticoneButton22 As ns1.SiticoneButton
	Private WithEvents siticoneCheckBox33 As ns1.SiticoneCheckBox
	Private siticoneCheckBox34 As ns1.SiticoneCheckBox
	Private WithEvents siticoneCheckBox35 As ns1.SiticoneCheckBox
	Private siticoneCheckBox36 As ns1.SiticoneCheckBox
	Private gunaLineTextBox23 As Guna.UI.WinForms.GunaLineTextBox
	Private siticoneCheckBox37 As ns1.SiticoneCheckBox
	Private openFileDialog3 As System.Windows.Forms.OpenFileDialog
	Private openFileDialog4 As System.Windows.Forms.OpenFileDialog
	Private saveFileDialog1 As System.Windows.Forms.SaveFileDialog
	Private saveFileDialog2 As System.Windows.Forms.SaveFileDialog
	Private openFileDialog5 As System.Windows.Forms.OpenFileDialog
	Private WithEvents siticoneButton23 As ns1.SiticoneButton
	Private tabPage13 As System.Windows.Forms.TabPage
	Private metroLabel24 As MetroSuite.MetroLabel
End Class