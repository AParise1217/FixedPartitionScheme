Imports FixedPartitionScheme

Public MustInherit Class Table
    Implements ITable

    'Strategy Pattern: Abstract Compositor Implementation

    Protected _Table As List(Of IPartition)
    Public _Type As Table.Type


    Public Enum Type As Byte
        Free = 0
        Busy = 1
    End Enum


    Public Sub AddPartition(ByRef Partition As IPartition) Implements ITable.AddPartition
        _Table.Add(Partition)
    End Sub

    Public Sub RemovePartition(ByRef Partition As IPartition) Implements ITable.RemovePartition
        _Table.Remove(Partition)
    End Sub

    Public Function getPartition(PartitionName As String) As IPartition Implements ITable.getPartition
        For Each partition In _Table
            If (partition.getName() = PartitionName) Then
                Return partition
            End If
        Next
        Return Nothing
    End Function

    Public Function getPartitionList() As List(Of IPartition) Implements ITable.getPartitionList
        Return _Table
    End Function

    'Abstract Functions:
    Public MustOverride Function getContents() As List(Of String) Implements ITable.getContents
    Public MustOverride Function getTableObj() As ITable Implements ITable.getTableObj
    '

End Class
