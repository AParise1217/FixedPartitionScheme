Imports FixedPartitionScheme

Public Class Partition
    Implements IPartition

    Private _Name As String
    Private _MemorySize As Integer
    Private _State As Partition.State
    Private _curJob As IJob

    Public Enum State As Byte
        Free = 1
        Busy = 2
    End Enum

    Public Sub New(ByVal ID As Integer, ByVal MemorySize As Integer)
        _Name = "Partition_" & Convert.ToString(ID)
        _MemorySize = MemorySize
        _State = State.Free
        _curJob = Nothing
    End Sub

    Public Function getState() As Partition.State Implements IPartition.getState
        checkSetState()

        Return _State
    End Function

    Public Function getCurJob() As IJob Implements IPartition.getCurJob
        checkSetState()

        Return _curJob
    End Function

    Public Sub AssignJob(ByRef Job As IJob) Implements IPartition.AssignJob
        _State = State.Busy
        _curJob = Job
    End Sub

    Public Sub ResetPartition() Implements IPartition.ResetPartition
        _State = State.Free
        _curJob = Nothing

    End Sub

    Public Function getMemorySize() As Integer Implements IPartition.getMemorySize
        Return _MemorySize
    End Function

    Public Function getName() As String Implements IPartition.getName
        Return _Name
    End Function


    Private Sub checkSetState()
        If (_curJob Is Nothing) Then
            _State = State.Free
            Return
        End If
        If (_curJob.isComplete) Then
            _State = State.Free
            _curJob = Nothing
        End If
    End Sub


End Class
