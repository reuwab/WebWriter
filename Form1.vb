Public Class Form1
	Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged
		WebBrowser1.DocumentText = RichTextBox1.Text
	End Sub
	Private Sub Copy()
		RichTextBox1.Copy()
	End Sub
	Private Sub Cut()
		RichTextBox1.Cut()
	End Sub
	Private Sub Paste()
		RichTextBox1.Paste()
	End Sub
	Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
		Copy()
	End Sub

	Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
		Cut()
	End Sub

	Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
		Paste()
	End Sub
	Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
		RichTextBox1.Clear()
		Me.Text = "Byoo WebWriter"
	End Sub

	Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
		Copy()
	End Sub

	Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
		RichTextBox1.Cut()
	End Sub

	Private Sub ToolStripButton8_Click(sender As Object, e As EventArgs) Handles ToolStripButton8.Click
		RichTextBox1.Paste()
	End Sub

	Private Sub ToolStripButton9_Click(sender As Object, e As EventArgs) Handles ToolStripButton9.Click
		AboutBox1.Show()
	End Sub

	Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
		RichTextBox1.Redo()
	End Sub

	Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
		RichTextBox1.Undo()
	End Sub

	Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
		Try
			OpenFileDialog1.Filter = "HTML Document | *.html"
			OpenFileDialog1.FilterIndex = "1"
			OpenFileDialog1.Title = "Open File"
			OpenFileDialog1.ShowDialog()
			OpenFileDialog1.CheckFileExists = True
			OpenFileDialog1.CheckPathExists = True
			OpenFileDialog1.ReadOnlyChecked = False
			RichTextBox1.LoadFile(OpenFileDialog1.FileName)
			Me.Text = (OpenFileDialog1.FileName + " - Byoo WebWriter")
		Catch ex As Exception
			'Do Nothing
		End Try
	End Sub

	Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
		Try
			SaveFileDialog1.Filter = "HTML Document | *.html"
			SaveFileDialog1.FilterIndex = "1"
			SaveFileDialog1.Title = "Save File"
			SaveFileDialog1.AddExtension = True
			SaveFileDialog1.ShowDialog()
			SaveFileDialog1.CheckFileExists = True
			SaveFileDialog1.CheckPathExists = True
			RichTextBox1.SaveFile(SaveFileDialog1.FileName)
			Me.Text = (SaveFileDialog1.FileName + " - Byoo WebWriter")
		Catch ex As Exception
			'Do Nothing
		End Try
	End Sub
End Class
