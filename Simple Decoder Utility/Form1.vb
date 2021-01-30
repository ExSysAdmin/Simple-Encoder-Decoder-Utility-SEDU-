Imports System.Security.Cryptography
Imports System.Text

Public Class SEDUForm
    Private Sub EncodeButton_Click(sender As Object, e As EventArgs) Handles EncodeButton.Click
        Try
            Dim base64Decoded As String = Base64InputTextBox.Text
            Dim base64Encoded As String
            Dim data As Byte()
            data = System.Text.ASCIIEncoding.ASCII.GetBytes(base64Decoded)
            base64Encoded = System.Convert.ToBase64String(data)
            Base64ResultTextBox.Text = base64Encoded
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DecodeButton_Click(sender As Object, e As EventArgs) Handles DecodeButton.Click
        Try
            Dim base64Encoded As String = Base64InputTextBox.Text
            Dim base64Decoded As String
            Dim data() As Byte
            data = System.Convert.FromBase64String(base64Encoded)
            base64Decoded = System.Text.ASCIIEncoding.ASCII.GetString(data)
            Base64ResultTextBox.Text = base64Decoded
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Clear64Button_Click(sender As Object, e As EventArgs) Handles Clear64Button.Click
        Base64InputTextBox.Text = ""
        Base64ResultTextBox.Text = ""
    End Sub

    Private Sub SEDUForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub






    Shared Function GetMD5Hash(theInput As String) As String

        Using hasher As MD5 = MD5.Create()    ' create hash object

            ' Convert to byte array and get hash
            Dim dbytes As Byte() =
             hasher.ComputeHash(Encoding.UTF8.GetBytes(theInput))

            ' sb to create string from bytes
            Dim sBuilder As New StringBuilder()

            ' convert byte data to hex string
            For n As Integer = 0 To dbytes.Length - 1
                sBuilder.Append(dbytes(n).ToString("X2"))
            Next n

            Return sBuilder.ToString()
        End Using

    End Function


    Shared Function GetSHA256Hash(theInput As String) As String

        Using hasher As SHA256 = SHA256.Create()    ' create hash object

            ' Convert to byte array and get hash
            Dim dbytes As Byte() =
             hasher.ComputeHash(Encoding.UTF8.GetBytes(theInput))

            ' sb to create string from bytes
            Dim sBuilder As New StringBuilder()

            ' convert byte data to hex string
            For n As Integer = 0 To dbytes.Length - 1
                sBuilder.Append(dbytes(n).ToString("X2"))
            Next n

            Return sBuilder.ToString()
        End Using

    End Function

    Shared Function GetSHA512Hash(theInput As String) As String

        Using hasher As SHA512 = SHA512.Create()    ' create hash object

            ' Convert to byte array and get hash
            Dim dbytes As Byte() =
             hasher.ComputeHash(Encoding.UTF8.GetBytes(theInput))

            ' sb to create string from bytes
            Dim sBuilder As New StringBuilder()

            ' convert byte data to hex string
            For n As Integer = 0 To dbytes.Length - 1
                sBuilder.Append(dbytes(n).ToString("X2"))
            Next n

            Return sBuilder.ToString()
        End Using

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            HashResultDataGridView.Rows.Clear()
            HashResultDataGridView.Rows.Add("MD5", GetMD5Hash(HashInputTextBox.Text))
            HashResultDataGridView.Rows.Add("SHA256", GetSHA256Hash(HashInputTextBox.Text))
            HashResultDataGridView.Rows.Add("SHA512", GetSHA512Hash(HashInputTextBox.Text))
        Catch ex As Exception

        End Try
    End Sub

    Private Sub HashInputTextBox_DragDrop(sender As Object, e As DragEventArgs) Handles HashInputTextBox.DragDrop
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        For Each path In files
            GroupBox3.Text = "Input: File "
            HashInputTextBox.Text = path
            HashInputTextBox.Enabled = False
        Next
    End Sub

    Private Sub HashInputTextBox_DragEnter(sender As Object, e As DragEventArgs) Handles HashInputTextBox.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub HashInputTextBox_TextChanged(sender As Object, e As EventArgs) Handles HashInputTextBox.TextChanged

    End Sub

    Private Sub ClearHashButton_Click(sender As Object, e As EventArgs) Handles ClearHashButton.Click
        GroupBox3.Text = "Input: Text"
        HashInputTextBox.Text = ""
        HashInputTextBox.Enabled = True
        HashResultDataGridView.Rows.Clear()
    End Sub

    Private Sub Copy64Button_Click(sender As Object, e As EventArgs) Handles Copy64Button.Click
        Try
            My.Computer.Clipboard.SetText(Base64ResultTextBox.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CopyHashButton_Click(sender As Object, e As EventArgs) Handles CopyHashButton.Click
        Try
            Dim ClipText As String = ""
            For Each Row As DataGridViewRow In HashResultDataGridView.SelectedRows
                If ClipText <> "" Then
                    ClipText = ClipText & vbCrLf & Row.Cells(0).Value.ToString() & vbTab & Row.Cells(1).Value.ToString()
                Else
                    ClipText = HashResultDataGridView.Columns(0).HeaderText & vbTab & HashResultDataGridView.Columns(1).HeaderText
                    ClipText = ClipText & vbCrLf & Row.Cells(0).Value.ToString() & vbTab & Row.Cells(1).Value.ToString()
                End If

            Next
            My.Computer.Clipboard.SetText(ClipText)
        Catch ex As Exception

        End Try
    End Sub
End Class
