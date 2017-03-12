Imports FixedPartitionScheme

Public NotInheritable Class Controller
    Implements IController

    'Used to handle interactions with the User Interface and control the flow of the simulation
    'Singleton Pattern used to ensure that only one controller is in use

    'Singleton Attributes'
    Private Shared ReadOnly _instance As New Lazy(Of Controller)(Function() New Controller(), System.Threading.LazyThreadSafetyMode.ExecutionAndPublication)
    ''

    'Business Objects
    Private Timer As SimulationClock
    Private BusyTable As BusyTable
    Private FreeTable As FreeTable

    'Containers
    Private JobQueue As List(Of IJob) 'Container to hold Jobs awaiting assignment

    'Local Attributes
    Private _LastJobID As Integer
    Private _LastPartitionID As Integer
    Private _MemoryCap As Integer

    Private Sub New()
        'Builder Method:
        Timer = SimulationClock.Instance
        BusyTable = BusyTable.Instance
        BusyTable = CType(BusyTable, ITable)
        FreeTable = FreeTable.Instance
        FreeTable = CType(FreeTable, ITable)
        JobQueue = New List(Of IJob)
        _LastJobID = 0
        _LastPartitionID = 0
        _MemoryCap = 500
    End Sub

    Public Sub IncrementTime() Implements IController.IncrementTime
        'this functions logic may need to be reworked
        Timer.IncrementClock()
        CleanPartitions()
        AssignJobs()
    End Sub

    Public Sub NewJob(JobSize As Integer) Implements IController.NewJob
        _LastJobID = _LastJobID + 1
        Dim JobRef As IJob = New Job(_LastJobID, JobSize)
        JobQueue.Add(JobRef)
    End Sub

    Public Function NewPartition(PartitionSize As Integer) As Boolean Implements IController.NewPartition
        If (PartitionSize <= getAvailableMemory()) Then
            _LastPartitionID = _LastPartitionID + 1
            Dim PartitionRef As IPartition = New Partition(_LastPartitionID, PartitionSize)
            FreeTable.AddPartition(PartitionRef)
            Return True
        End If
        Return False
    End Function

    Public Function getPartitionList(PartitionType As Partition.State) As List(Of IPartition) Implements IController.getPartitionList
        Dim partList As New List(Of IPartition)
        If (PartitionType = Partition.State.Busy) Then
            partList = BusyTable.getPartitionList()
        Else
            partList = FreeTable.getPartitionList()
        End If

        Return partList
    End Function

    Public Function getMemoryCap() As Integer Implements IController.getMemoryCap
        'Returns the memory cap for partitions 
        Return _MemoryCap
    End Function

    Public Function getAvailableMemory() As Integer Implements IController.getAvailableMemory
        'Checks how much memory is currently taken by partition assignments
        Dim usedMemory As Integer = 0
        For Each partition In getPartitionList(FixedPartitionScheme.Partition.State.Busy)
            usedMemory = usedMemory + partition.getMemorySize()
        Next
        For Each partition In getPartitionList(FixedPartitionScheme.Partition.State.Free)
            usedMemory = usedMemory + partition.getMemorySize()
        Next

        Return (getMemoryCap() - usedMemory)
    End Function

    Private Sub CleanPartitions()
        'Iterates over the list of busy Partitions and checks to see if the job is complete; if so, resets it and moves it to the Free Table
        Try
            For Each _Partition As IPartition In BusyTable.getPartitionList()
                If ((_Partition.getState = Partition.State.Free) OrElse (_Partition.getCurJob().isComplete())) Then
                    If (_Partition.getCurJob() IsNot Nothing) Then
                        Timer.Detach(_Partition.getCurJob())
                    End If
                    _Partition.ResetPartition()
                    FreeTable.AddPartition(_Partition)
                    BusyTable.RemovePartition(_Partition)
                End If
            Next
        Catch ex As Exception
            'an exception get thrown when the collection gets modified-- so recall the function. on the last iteration, it will not modify the collection
            CleanPartitions()
        End Try

    End Sub

    Private Sub AssignJobs()
        'Iterates over the JobQueue and sees if any of the jobs can be assigned into a Partition
        If (JobQueue.Count > 0) Then
            For Each _Job As IJob In JobQueue
                For Each _Partition As IPartition In FreeTable.getPartitionList().OrderBy(Function(x) x.getMemorySize()).ToList()
                    '^This gets the Free Partitions, and sorts them in descending order
                    If (_Partition.getMemorySize() >= _Job.getJobSize()) Then
                        'Found a match! Now, assign the Job to the Partition
                        _Partition.AssignJob(_Job)
                        Timer.Attach(_Job)
                        JobQueue.Remove(_Job)
                        BusyTable.AddPartition(_Partition)
                        FreeTable.RemovePartition(_Partition)

                        'Values need to be reloaded into the lists-- break and restart
                        AssignJobs()
                        Exit Sub '<- included so the loop doesn't continue infinitely
                    End If
                Next
            Next

        End If
    End Sub

    Public Function getJobQueue() As List(Of IJob) Implements IController.getJobQueue
        Return JobQueue
    End Function

    Public Function getTime() As Integer Implements IController.getTime
        Return Timer.getTime()
    End Function

    Public Shared ReadOnly Property Instance() As IController
        Get
            Return _instance.Value
        End Get
    End Property

End Class
