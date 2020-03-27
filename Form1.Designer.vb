<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
		Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
		Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
		Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
		Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
		Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
		Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
		Me.BarItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
		Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
		Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
		Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
		Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
		Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
		Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
		Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
		Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
		Me.ToolStripButton8 = New System.Windows.Forms.ToolStripButton()
		Me.ToolStripButton9 = New System.Windows.Forms.ToolStripButton()
		Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
		Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
		Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
		CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SplitContainer1.Panel1.SuspendLayout()
		Me.SplitContainer1.Panel2.SuspendLayout()
		Me.SplitContainer1.SuspendLayout()
		Me.ToolStrip1.SuspendLayout()
		Me.ContextMenuStrip1.SuspendLayout()
		CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SplitContainer2.Panel1.SuspendLayout()
		Me.SplitContainer2.Panel2.SuspendLayout()
		Me.SplitContainer2.SuspendLayout()
		Me.SuspendLayout()
		'
		'SplitContainer1
		'
		Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
		Me.SplitContainer1.Name = "SplitContainer1"
		'
		'SplitContainer1.Panel1
		'
		Me.SplitContainer1.Panel1.Controls.Add(Me.RichTextBox1)
		'
		'SplitContainer1.Panel2
		'
		Me.SplitContainer1.Panel2.Controls.Add(Me.WebBrowser1)
		Me.SplitContainer1.Size = New System.Drawing.Size(843, 412)
		Me.SplitContainer1.SplitterDistance = 280
		Me.SplitContainer1.TabIndex = 3
		'
		'ToolStrip1
		'
		Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
		Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripSeparator1, Me.ToolStripButton4, Me.ToolStripButton5, Me.ToolStripButton6, Me.ToolStripButton7, Me.ToolStripButton8, Me.ToolStripSeparator2, Me.ToolStripButton9})
		Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
		Me.ToolStrip1.Name = "ToolStrip1"
		Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
		Me.ToolStrip1.Size = New System.Drawing.Size(843, 25)
		Me.ToolStrip1.TabIndex = 1
		Me.ToolStrip1.Text = "ToolStrip1"
		'
		'ToolStripSeparator1
		'
		Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
		Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
		'
		'RichTextBox1
		'
		Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.RichTextBox1.ContextMenuStrip = Me.ContextMenuStrip1
		Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.RichTextBox1.Location = New System.Drawing.Point(0, 0)
		Me.RichTextBox1.Name = "RichTextBox1"
		Me.RichTextBox1.Size = New System.Drawing.Size(280, 412)
		Me.RichTextBox1.TabIndex = 0
		Me.RichTextBox1.Text = ""
		'
		'ContextMenuStrip1
		'
		Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyToolStripMenuItem, Me.CutToolStripMenuItem, Me.PasteToolStripMenuItem})
		Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
		Me.ContextMenuStrip1.Size = New System.Drawing.Size(103, 70)
		'
		'WebBrowser1
		'
		Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.WebBrowser1.Location = New System.Drawing.Point(0, 0)
		Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
		Me.WebBrowser1.Name = "WebBrowser1"
		Me.WebBrowser1.Size = New System.Drawing.Size(559, 412)
		Me.WebBrowser1.TabIndex = 0
		'
		'BarItem1
		'
		Me.BarItem1.BarName = "BarItem1"
		Me.BarItem1.ID = "New"
		Me.BarItem1.Image = CType(resources.GetObject("BarItem1.Image"), Syncfusion.Windows.Forms.Tools.XPMenus.ImageExt)
		Me.BarItem1.ShowToolTipInPopUp = False
		Me.BarItem1.SizeToFit = True
		Me.BarItem1.Text = "New"
		'
		'ToolStripSeparator2
		'
		Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
		Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
		'
		'ToolStripButton1
		'
		Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.ToolStripButton1.Image = Global.WebWriter.My.Resources.Resources.icons8_new_file_16
		Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.ToolStripButton1.Name = "ToolStripButton1"
		Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
		Me.ToolStripButton1.Text = "New"
		'
		'ToolStripButton2
		'
		Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.ToolStripButton2.Image = Global.WebWriter.My.Resources.Resources.icons8_opened_folder_16
		Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.ToolStripButton2.Name = "ToolStripButton2"
		Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
		Me.ToolStripButton2.Text = "Open"
		'
		'ToolStripButton3
		'
		Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.ToolStripButton3.Image = Global.WebWriter.My.Resources.Resources.icons8_save_16
		Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.ToolStripButton3.Name = "ToolStripButton3"
		Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
		Me.ToolStripButton3.Text = "Save"
		'
		'ToolStripButton4
		'
		Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.ToolStripButton4.Image = Global.WebWriter.My.Resources.Resources.icons8_undo_16
		Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.ToolStripButton4.Name = "ToolStripButton4"
		Me.ToolStripButton4.Size = New System.Drawing.Size(23, 22)
		Me.ToolStripButton4.Text = "Undo"
		'
		'ToolStripButton5
		'
		Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.ToolStripButton5.Image = Global.WebWriter.My.Resources.Resources.icons8_redo_16
		Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.ToolStripButton5.Name = "ToolStripButton5"
		Me.ToolStripButton5.Size = New System.Drawing.Size(23, 22)
		Me.ToolStripButton5.Text = "Redo"
		'
		'ToolStripButton6
		'
		Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.ToolStripButton6.Image = Global.WebWriter.My.Resources.Resources.icons8_copy_16
		Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.ToolStripButton6.Name = "ToolStripButton6"
		Me.ToolStripButton6.Size = New System.Drawing.Size(23, 22)
		Me.ToolStripButton6.Text = "Copy"
		'
		'ToolStripButton7
		'
		Me.ToolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.ToolStripButton7.Image = Global.WebWriter.My.Resources.Resources.icons8_cut_16
		Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.ToolStripButton7.Name = "ToolStripButton7"
		Me.ToolStripButton7.Size = New System.Drawing.Size(23, 22)
		Me.ToolStripButton7.Text = "Cut"
		'
		'ToolStripButton8
		'
		Me.ToolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.ToolStripButton8.Image = Global.WebWriter.My.Resources.Resources.icons8_paste_16
		Me.ToolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.ToolStripButton8.Name = "ToolStripButton8"
		Me.ToolStripButton8.Size = New System.Drawing.Size(23, 22)
		Me.ToolStripButton8.Text = "Paste"
		'
		'ToolStripButton9
		'
		Me.ToolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.ToolStripButton9.Image = Global.WebWriter.My.Resources.Resources.icons8_about_16
		Me.ToolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.ToolStripButton9.Name = "ToolStripButton9"
		Me.ToolStripButton9.Size = New System.Drawing.Size(23, 22)
		Me.ToolStripButton9.Text = "About"
		'
		'CopyToolStripMenuItem
		'
		Me.CopyToolStripMenuItem.Image = Global.WebWriter.My.Resources.Resources.icons8_copy_16
		Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
		Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
		Me.CopyToolStripMenuItem.Text = "Copy"
		'
		'CutToolStripMenuItem
		'
		Me.CutToolStripMenuItem.Image = Global.WebWriter.My.Resources.Resources.icons8_cut_16
		Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
		Me.CutToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
		Me.CutToolStripMenuItem.Text = "Cut"
		'
		'PasteToolStripMenuItem
		'
		Me.PasteToolStripMenuItem.Image = Global.WebWriter.My.Resources.Resources.icons8_paste_16
		Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
		Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
		Me.PasteToolStripMenuItem.Text = "Paste"
		'
		'OpenFileDialog1
		'
		Me.OpenFileDialog1.FileName = "OpenFileDialog1"
		'
		'SplitContainer2
		'
		Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
		Me.SplitContainer2.IsSplitterFixed = True
		Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
		Me.SplitContainer2.Name = "SplitContainer2"
		Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
		'
		'SplitContainer2.Panel1
		'
		Me.SplitContainer2.Panel1.Controls.Add(Me.ToolStrip1)
		'
		'SplitContainer2.Panel2
		'
		Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer1)
		Me.SplitContainer2.Size = New System.Drawing.Size(843, 441)
		Me.SplitContainer2.SplitterDistance = 25
		Me.SplitContainer2.TabIndex = 4
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(843, 441)
		Me.Controls.Add(Me.SplitContainer2)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "Form1"
		Me.Text = "Byoo WebWriter"
		Me.SplitContainer1.Panel1.ResumeLayout(False)
		Me.SplitContainer1.Panel2.ResumeLayout(False)
		CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.SplitContainer1.ResumeLayout(False)
		Me.ToolStrip1.ResumeLayout(False)
		Me.ToolStrip1.PerformLayout()
		Me.ContextMenuStrip1.ResumeLayout(False)
		Me.SplitContainer2.Panel1.ResumeLayout(False)
		Me.SplitContainer2.Panel1.PerformLayout()
		Me.SplitContainer2.Panel2.ResumeLayout(False)
		CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
		Me.SplitContainer2.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents SplitContainer1 As SplitContainer
	Friend WithEvents RichTextBox1 As RichTextBox
	Friend WithEvents WebBrowser1 As WebBrowser
	Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
	Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents CutToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents PasteToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents BarItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
	Friend WithEvents ToolStrip1 As ToolStrip
	Friend WithEvents ToolStripButton1 As ToolStripButton
	Friend WithEvents ToolStripButton2 As ToolStripButton
	Friend WithEvents ToolStripButton3 As ToolStripButton
	Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
	Friend WithEvents ToolStripButton4 As ToolStripButton
	Friend WithEvents ToolStripButton5 As ToolStripButton
	Friend WithEvents ToolStripButton6 As ToolStripButton
	Friend WithEvents ToolStripButton7 As ToolStripButton
	Friend WithEvents ToolStripButton8 As ToolStripButton
	Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
	Friend WithEvents ToolStripButton9 As ToolStripButton
	Friend WithEvents OpenFileDialog1 As OpenFileDialog
	Friend WithEvents SaveFileDialog1 As SaveFileDialog
	Friend WithEvents SplitContainer2 As SplitContainer
End Class
