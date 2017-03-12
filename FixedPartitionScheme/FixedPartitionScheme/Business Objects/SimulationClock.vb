Public NotInheritable Class SimulationClock
    'Keep track of the simulation time, and with each tick, notifies each of the Jobs of the change in the time to simplify interactions between objects
    'Observer Pattern: The 'Subject' Class
    'Note: Singleton Pattern used to ensure that there is only one referenced clock in use the lifetime of the simulation

    'Singleton Attributes
    Private Shared ReadOnly _instance As New Lazy(Of SimulationClock)(Function() New SimulationClock(), System.Threading.LazyThreadSafetyMode.ExecutionAndPublication)
    ''

    Private _Time As Integer
    Private _JobList As List(Of IJob)

    Private Sub New()
        'Include Builder Calls here

        'init
        _JobList = New List(Of IJob)
        _Time = 0 'Sets the starting time on the SimulationClock

    End Sub

    Public Sub Attach(ByRef Job As IJob)
        'As Jobs are delegated to a partition, call this method so they can keep track of the SimulationClock
        _JobList.Add(Job)
        Job.setStartTime(_Time)
    End Sub

    Public Sub Detach(ByRef Job As IJob)
        'As Jobs are completed, make sure this method is called to ensure best efficiency
        _JobList.Remove(Job)
    End Sub

    Public Sub Notify()
        For Each Job As IJob In _JobList
            Job.UpdateTime(_Time)
        Next
    End Sub

    Public Sub IncrementClock()
        'Call this method to advance the Simulation forward one unit
        _Time = _Time + 1
        Notify()
    End Sub

    Public Function getTime() As Integer
        'Returns the current time of the clock
        Return _Time
    End Function

    'Singleton Methods
    Public Shared ReadOnly Property Instance() As SimulationClock
        Get
            Return _instance.Value
        End Get
    End Property
    '

End Class
