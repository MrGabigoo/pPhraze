

Imports System.IO

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If File.Exists("input\list.txt") Then

            Dim ioFile As New StreamReader("input\list.txt")    'StreamReader to read the file
            Dim lines As New List(Of String)                    'Just a list to hold the lines
            Dim rnd As New Random()                             'Random Class to generate a random number
            Dim line As Integer                                 'Variable to hold random line number
            While ioFile.Peek <> -1                             'loop through each line of the text file and add all the lines to the list
                lines.Add(ioFile.ReadLine)
            End While

            line = rnd.Next(lines.Count + 1)                    'generate a random number
            RichTextBox1.AppendText(lines(line).Trim() + " ")         'add it to the RichTextBox

            'TODO: remove eventual spaces from the output

            ioFile.Close()
            ioFile.Dispose()

        Else        'If file not found
            MsgBox("Uh-oh." + Environment.NewLine + Environment.NewLine + "I wasn't able to open the file 'input\list.txt'" + Environment.NewLine + Environment.NewLine + "Could you please make sure this file exists?")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        RichTextBox1.Text = ""          'Clears contents of RichTextBox
    End Sub

End Class
