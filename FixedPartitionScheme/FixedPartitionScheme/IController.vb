Public Interface IController
    'Handles all Application level calls

    Sub NewJob(ByVal JobSize As Integer)
    'Creates a new Job

    Function NewPartition(ByVal PartitionSize As Integer) As Boolean
    'Creates a new Partition

    Function getPartitionList(ByVal PartitionType As Partition.State) As List(Of IPartition)
    'returns the list of partitions of the type specified in PartitionType

    Function getJobQueue() As List(Of IJob)
    'Returns a list of jobs that are unassigned

    Sub IncrementTime()
    'Moves the program forward one unit of time

    Function getTime() As Integer
    'Gets the current time of the simulation clock

    Function getMemoryCap() As Integer
    'returns the capacity on the memory for partition allocations

    Function getAvailableMemory() As Integer
    'calculates and returns the amount of memory available for new partition allocation

End Interface
