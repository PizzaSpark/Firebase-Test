Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Reflection
Imports FireSharp

Public Class Form1

    Dim config = New FirebaseConfig() With {
    .AuthSecret = "vMgSCxFi7hxWxupAX8akTGfqWbxICmJxFXDVj4V2",
    .BasePath = "https://schoolfirebasesample-default-rtdb.asia-southeast1.firebasedatabase.app/"  'This is your Firebase URL
}

    Dim client As IFirebaseClient = New FireSharp.FirebaseClient(config)

    Private Sub pushbtn_Click(sender As Object, e As EventArgs) Handles pushbtn.Click
        Dim data As Object = New With {
            .Value = TextBox2.Text
        }


        Dim response As PushResponse = client.Push("Visual Basic/Push/", data)

        MsgBox(String.Format("Data added successfully with the value of {0}", TextBox2.Text))
    End Sub

    Private Sub setbtn_Click(sender As Object, e As EventArgs) Handles setbtn.Click

        Dim data As Object = New With {
            .Value = TextBox2.Text
        }

        Dim keyName As String = TextBox1.Text

        If String.IsNullOrEmpty(keyName) Then
            keyName = "sample"
        End If

        Dim response As SetResponse = client.Set(String.Format("Visual Basic/Set/{0}", keyName), data)

        MsgBox(String.Format("Data added successfully with the key {0} and the value {1}", keyName, TextBox2.Text))
    End Sub

    Private Sub retrievePush_Click(sender As Object, e As EventArgs) Handles retrievePush.Click
        ListBox1.Items.Clear()
        Try
            Dim response As FirebaseResponse = client.Get("Visual Basic/Push/")
            Dim data As Dictionary(Of String, Object) = response.ResultAs(Of Dictionary(Of String, Object))()

            For Each item In data
                ListBox1.Items.Add(item.Key + " : " + item.Value.ToString())
            Next
        Catch ex As Exception
            MessageBox.Show("No or Slow Internet")
        End Try

    End Sub

    Private Sub retrieveSet_Click(sender As Object, e As EventArgs) Handles retrieveSet.Click


        ListBox1.Items.Clear()
        Try
            Dim response As FirebaseResponse = client.Get("Visual Basic/Set/")
            Dim data As Dictionary(Of String, Object) = response.ResultAs(Of Dictionary(Of String, Object))()

            For Each item In data
                ListBox1.Items.Add(item.Key + " : " + item.Value.ToString())
            Next
        Catch ex As Exception
            MessageBox.Show("No or Slow Internet")
        End Try
    End Sub
End Class
