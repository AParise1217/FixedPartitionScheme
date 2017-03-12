Public Interface ITable
    'Strategy Pattern: Composition Interface

    Function getPartition(ByVal PartitionName As String) As IPartition
    'returns the Partition of the given PartitionName

    Sub RemovePartition(ByRef Partition As IPartition)
    'Removes the Partition from the table and returns it

    Sub AddPartition(ByRef Partition As IPartition)
    'Inserts the Partition into the Table

    Function getPartitionList() As List(Of IPartition)
    'Returns a List containing the partitions contained in the Table

    'Abstract Functions
    Function getContents() As List(Of String)
    'Formats and returns the contents of the table
    ''Note: each index of the list contains the details of a row in the Table

    Function getTableObj() As ITable
    'Gets the Table Object and returns it
    ''Note: Necessary due to Singleton nature of the table



End Interface
