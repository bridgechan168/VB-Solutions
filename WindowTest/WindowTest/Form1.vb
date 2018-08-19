'****************************************************************************************
'Requeset        Date               By              Remarks
'SR180819001     2018-08-19 17:45   Bridge Chan     Draft    
'****************************************************************************************

Public Class Form1
    Dim dsDemo1 As DataSet

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 這行程式碼會將資料載入 'DsDemo.User' 資料表。您可以視需要進行移動或移除。
        Me.UserTableAdapter.Fill(Me.DsDemo.User)
        'TODO: 這行程式碼會將資料載入 'DsDemo.User' 資料表。您可以視需要進行移動或移除。
        Me.UserTableAdapter.Fill(Me.DsDemo.User)


    End Sub

    Private Sub UserBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()

    End Sub
End Class
