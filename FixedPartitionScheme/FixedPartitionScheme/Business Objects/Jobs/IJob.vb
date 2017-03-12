Public Interface IJob

    Sub UpdateTime(ByVal CurrentTime As Integer)
    'Moves time forward one unit-- reduces the timeleft attribute by one; eventually leading to the completion of the job
    Sub setStartTime(ByVal CurrentTime As Integer)
    'Sets the Job's StartTime Value


    Function isComplete() As Boolean
    'Checks whether the job is complete or not
    'Return value is a boolean representing the success case
    Function getJobID() As String
    'returns the Job's Identification Name
    Function getJobSize() As Integer
    'Returns the amount of memory the job requires

    Function getTimeLeft() As Integer
    'calculates and returns the time left for the job to be executed in

End Interface
