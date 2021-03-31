Imports System.Data.SqlClient

Public Class frmUpdate

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sql As String = ""
        sql = "UPDATE  Etudiant set Name=@name,Age =@Age WHERE IdE = @Ide"
        Using connection = Connect.GetConnection
            connection.Open()
            Using cmd As New SqlCommand(sql, connection)
                cmd.Parameters.AddWithValue("@Ide", lblnum.Text)
                cmd.Parameters.AddWithValue("@Name", txtname.Text)
                cmd.Parameters.AddWithValue("@Age", txtage.Text)
                If cmd.ExecuteNonQuery Then
                    MsgBox("تم تعديل الطالب بنجاح", MsgBoxStyle.Information)
                End If
                Me.Close()
            End Using

        End Using
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class