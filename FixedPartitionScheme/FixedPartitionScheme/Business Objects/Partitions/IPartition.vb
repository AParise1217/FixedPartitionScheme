Public Interface IPartition
    'The object containing the data and operations associated with the memory partition

    Function getState() As Partition.State
    'gets the Partition's state

    Function getCurJob() As IJob
    'Returns the current job that is occupying the Partition
    ''Note: Only call if isBusy() returns true

    Sub AssignJob(ByRef Job As IJob)
    'Assigns the Job to the Partition

    Sub ResetPartition()
    'Resets all values set by the Last Job to prepare it for a new assignment

    Function getMemorySize() As Integer
    'Returns the memory allocation of the partition

    Function getName() As String
    'Returns the name of the partition


End Interface
