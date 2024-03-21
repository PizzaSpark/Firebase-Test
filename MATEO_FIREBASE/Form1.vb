Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports FireSharp.Config
Imports FireSharp.Interfaces
Imports FireSharp.Response

Public Class Form1

    Dim config = New FirebaseConfig() With
    {
        .AuthSecret = "N3Fr4vFijHk3guqBBv0whTRojywjqn8GDkVtWXbJ",
        .BasePath = "https://dbmateofirebase-default-rtdb.asia-southeast1.firebasedatabase.app/"
    }

    Dim client As IFirebaseClient = New FireSharp.FirebaseClient(config)

    Private Sub setbtn_Click(sender As Object, e As EventArgs) Handles setbtn.Click

        Dim keyName As String = keytxt.Text
        Dim valueName As String = valuetxt.Text

        If String.IsNullOrEmpty(keyName) Or String.IsNullOrEmpty(valueName) Then
            MessageBox.Show("Please fill in the textboxes")
        Else
            Dim data As Object = New With {
                .Value = valueName
            }

            Dim response As SetResponse = client.Set(String.Format("Visual Basic/Assignment/{0}", keyName), data)
            MsgBox(String.Format("Data added successfully with the key {0} and the value {1}", keyName, valuetxt.Text))
        End If
    End Sub

    Private Sub retrievebtn_Click(sender As Object, e As EventArgs) Handles retrievebtn.Click
        ListBox1.Items.Clear()
        Try
            Dim response As FirebaseResponse = client.Get("Visual Basic/Assignment/")
            Dim data As Dictionary(Of String, Object) = response.ResultAs(Of Dictionary(Of String, Object))()

            For Each item In data
                ListBox1.Items.Add(item.Key + " : " + item.Value.ToString())
            Next
        Catch ex As Exception
            MessageBox.Show("No or Slow Connection")
        End Try
    End Sub
End Class
