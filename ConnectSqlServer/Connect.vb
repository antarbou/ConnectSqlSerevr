Imports System.Data.SqlClient
Class Connect
    Private Shared ConStr As String
    Private Shared Conn As SqlConnection

    '�� ��� ��������� �� �� ���� �������
    Public Shared Function GetConnection() As SqlConnection
        Return New SqlConnection("Data Source =WILAYA2901;Initial Catalog=ConstRecon;Persist Security Info=True;User ID=ConsRecon;Password=01022021; MultipleActiveResultSets=True")
    End Function

End Class


