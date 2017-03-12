Imports FixedPartitionScheme

Public Class BusyTable
    Inherits Table

    'Strategy Pattern: Composite BusyTable Implementation
    'Singleton Pattern: Instance locked to one to ensure proper handling

    Private Shared ReadOnly _instance As New Lazy(Of BusyTable)(Function() New BusyTable(), System.Threading.LazyThreadSafetyMode.ExecutionAndPublication)

    Private Sub New()
        'Include Builder Calls here
        _Type = Table.Type.Busy
        _Table = New List(Of IPartition)
    End Sub

    Public Overrides Function getContents() As List(Of String)
        Throw New NotImplementedException()
    End Function

    Public Overrides Function getTableObj() As ITable
        Return Instance
    End Function


    'Singleton Methods
    Public Shared ReadOnly Property Instance() As ITable
        Get
            Return _instance.Value
        End Get
    End Property
    '

End Class
