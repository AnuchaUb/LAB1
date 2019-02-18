Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient

Public Class frmSelectData
    Dim strCon As String = ConfigurationManager.ConnectionStrings("frmMyfirst.My.MySettings.myDB").ConnectionString
    Dim myCon As New SqlConnection
    Dim myDA As New SqlDataAdapter
    Dim myDS As New DataSet
    Dim sqlStr As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If myCon.State = ConnectionState.Open Then
            myCon.Close()
        End If
        myCon.ConnectionString = strCon
        myCon.Open()

        sqlStr = "select * from categories"
        myDA = New SqlDataAdapter(sqlStr, myCon)
        myDA.Fill(myDS, "myPro")
        DataGridView1.DataSource = myDS.Tables("myPro")
    End Sub
End Class