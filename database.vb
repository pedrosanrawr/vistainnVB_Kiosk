Imports System.Configuration

Public Class Database
    Public ReadOnly Property ConnectionString As String
        Get
            Return ConfigurationManager.ConnectionStrings("vistainnVB_Kiosk.My.MySettings.vistainnMSDBConnectionString").ConnectionString
        End Get
    End Property
End Class

