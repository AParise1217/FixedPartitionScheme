Public Class FormSimulation

    Private ReadOnly FixedJobSize As Integer = 5


    Private _Controller As IController



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _Controller = Controller.Instance
        intializePartitions()

    End Sub

    Private Sub intializePartitions()
        _Controller.NewPartition(25)
        _Controller.NewPartition(50)
        _Controller.NewPartition(100)
        refreshMemory()
        refreshFreeTable()
        TextBox_CurrentTime.Text = _Controller.getTime()
    End Sub

    Private Sub Button_NewJob_Click(sender As Object, e As EventArgs) Handles Button_NewJob.Click
        NewJob()
    End Sub

    Private Sub refreshMemory()
        Dim usedMemory As String = _Controller.getAvailableMemory()
        Dim memoryCap As String = _Controller.getMemoryCap()
        TextBox_MemoryRatio.Text = usedMemory + "/" + memoryCap
    End Sub

    Private Sub NewPartition()
        If (ListBox_PartitionSize.SelectedItem IsNot Nothing) Then
            Dim partSize As Integer = ListBox_PartitionSize.SelectedItem
            If (_Controller.NewPartition(partSize)) Then
                'if the partition was successfully created (additional errorchecking conducted on controller level that may reject request)
                refreshFreeTable()
                refreshMemory()
            End If
        End If
    End Sub

    Private Sub NewJob()
        'Create a new Job to be inserted into the Queue
        If (ListBox_NewJobSize.SelectedItem IsNot Nothing) Then
            _Controller.NewJob(Convert.ToInt32(ListBox_NewJobSize.SelectedItem))
            refreshJobList()

        End If

    End Sub

    Private Sub refreshFreeTable()
        clearDataGridView(DataGridView_PartitionsFree)
        For Each _Partition As IPartition In _Controller.getPartitionList(Partition.State.Free).OrderByDescending(Function(x) x.getMemorySize()).ToList()
            Dim row As String() = New String() {_Partition.getName, _Partition.getMemorySize}
            DataGridView_PartitionsFree.Rows.Add(row)
        Next
    End Sub

    Private Sub refreshBusyTable()
        clearDataGridView(DataGridView_BusyTable)
        For Each _Partition As IPartition In _Controller.getPartitionList(Partition.State.Busy).OrderByDescending(Function(x) x.getMemorySize()).ToList()
            Dim row As String() = New String() {_Partition.getName, _Partition.getMemorySize, _Partition.getCurJob.getJobID, _Partition.getCurJob.getTimeLeft}
            DataGridView_BusyTable.Rows.Add(row)
        Next
    End Sub

    Private Sub refreshJobList()
        'Refreshes the JobList data view
        clearDataGridView(DataGridView_Jobs)
        For Each _Job As IJob In _Controller.getJobQueue()
            Dim row As String() = New String() {_Job.getJobID, _Job.getJobSize, _Job.getTimeLeft}
            DataGridView_Jobs.Rows.Add(row)
        Next
    End Sub

    Private Sub clearDataGridView(ByRef DataGrid As DataGridView)
        While (Not (DataGrid.Rows.Count = 0))
            DataGrid.Rows.Remove(DataGrid.Rows.Item(0))
        End While
    End Sub

    Private Sub Button_IncrementTime_Click(sender As Object, e As EventArgs) Handles Button_IncrementTime.Click
        IncrementTime()
    End Sub


    Private Sub IncrementTime()
        _Controller.IncrementTime()

        'Update timer
        TextBox_CurrentTime.Text = _Controller.getTime()
        'refresh data boxes
        refreshBusyTable()
        refreshFreeTable()
        refreshJobList()
    End Sub

    Private Sub Button_NewPartition_Click(sender As Object, e As EventArgs) Handles Button_NewPartition.Click
        NewPartition()
    End Sub


End Class
