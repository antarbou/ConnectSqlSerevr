Imports System.Data.SqlClient
Public Class frmInsert

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sql As String = ""
        sql = "INSERT INTO Etudiant (Name,Age) VALUES (@Name,@Age)"
        Using connection = Connect.GetConnection   ' هنا تم استدعاء الدالة الموجودة الكلاس connect
            connection.Open()
            Using cmd As New SqlCommand(sql, connection)
                cmd.Parameters.AddWithValue("@Name", txtname.Text)
                cmd.Parameters.AddWithValue("@Age", txtage.Text)
                If cmd.ExecuteNonQuery Then
                    MsgBox("تم تسجيل الطالب بنجاح", MsgBoxStyle.Information)
                End If
                Me.Close()
            End Using

        End Using
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class