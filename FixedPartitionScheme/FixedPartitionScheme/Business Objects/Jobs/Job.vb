Imports FixedPartitionScheme

Public Class Job
    Implements IJob

    Private _ID As String
    Private _JobSize As Integer
    Private _isComplete As Boolean
    Private _StartTime As Integer
    Private _CurrentTime As Integer
    Private _TaskTime As Integer
    Private _CompletionTime As Integer

    Public Sub New(ByVal ID As Integer, ByVal JobSize As Integer, Optional ByVal TaskTime As Integer = 5)
        _ID = "Job_" & Convert.ToString(ID)
        _isComplete = False
        _TaskTime = TaskTime
        _JobSize = JobSize
    End Sub

    Public Sub UpdateTime(ByVal CurrentTime As Integer) Implements IJob.UpdateTime
        _CurrentTime = CurrentTime

        If (CurrentTime = _CompletionTime) Then
            _isComplete = True
        End If
    End Sub

    Public Function isComplete() As Boolean Implements IJob.isComplete
        Return _isComplete
    End Function

    Public Sub setStartTime(ByVal CurrentTime As Integer) Implements IJob.setStartTime
        _StartTime = CurrentTime
        _CompletionTime = _StartTime + _TaskTime
    End Sub

    Public Function getJobID() As String Implements IJob.getJobID
        Return _ID
    End Function

    Public Function getJobSize() As Integer Implements IJob.getJobSize
        Return _JobSize
    End Function

    Public Function getTimeLeft() As Integer Implements IJob.getTimeLeft
        If (_CurrentTime = Nothing) Then
            'if this hasn't been set, then the job has not been started
            Return _TaskTime
        End If

        Return (_CompletionTime - _CurrentTime)
    End Function
End Class
