Imports System.Data.SqlClient

Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmInsert.ShowDialog()
        LoadEtudiant()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadEtudiant()
    End Sub

    Public Sub LoadEtudiant()
        Dim sql As String = ""
        sql = "SELECT * FROM Etudiant"
        Using connection = Connect.GetConnection
            connection.Open()
            Using cmd As New SqlCommand(sql, connection)
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds)
                dgvEtudiant.DataSource = ds.Tables(0)
            End Using
        End Using
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        frmUpdate.lblnum.Text = dgvEtudiant.CurrentRow.Cells(0).Value
        frmUpdate.txtname.Text = dgvEtudiant.CurrentRow.Cells(1).Value
        frmUpdate.txtage.Text = dgvEtudiant.CurrentRow.Cells(2).Value
        frmUpdate.ShowDialog()
        LoadEtudiant()
    End Sub
End Class
