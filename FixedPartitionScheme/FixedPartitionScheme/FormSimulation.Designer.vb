<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSimulation
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button_IncrementTime = New System.Windows.Forms.Button()
        Me.Label_Time = New System.Windows.Forms.Label()
        Me.TextBox_CurrentTime = New System.Windows.Forms.TextBox()
        Me.Button_NewJob = New System.Windows.Forms.Button()
        Me.DataGridView_Jobs = New System.Windows.Forms.DataGridView()
        Me.JobName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JobSize = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JobTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView_PartitionsFree = New System.Windows.Forms.DataGridView()
        Me.PartitionNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PartitionSize = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView_BusyTable = New System.Windows.Forms.DataGridView()
        Me.PartitionNumber_BusyTable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PartitionSize_BusyTable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JobName_BusyTable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeLeft_BusyTable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ListBox_NewJobSize = New System.Windows.Forms.ListBox()
        Me.Button_NewPartition = New System.Windows.Forms.Button()
        Me.ListBox_PartitionSize = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox_MemoryRatio = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView_Jobs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView_PartitionsFree, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView_BusyTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button_IncrementTime
        '
        Me.Button_IncrementTime.Location = New System.Drawing.Point(618, 63)
        Me.Button_IncrementTime.Margin = New System.Windows.Forms.Padding(2)
        Me.Button_IncrementTime.Name = "Button_IncrementTime"
        Me.Button_IncrementTime.Size = New System.Drawing.Size(85, 39)
        Me.Button_IncrementTime.TabIndex = 0
        Me.Button_IncrementTime.Text = "Increment Time"
        Me.Button_IncrementTime.UseVisualStyleBackColor = True
        '
        'Label_Time
        '
        Me.Label_Time.AutoSize = True
        Me.Label_Time.Location = New System.Drawing.Point(631, 21)
        Me.Label_Time.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label_Time.Name = "Label_Time"
        Me.Label_Time.Size = New System.Drawing.Size(33, 13)
        Me.Label_Time.TabIndex = 1
        Me.Label_Time.Text = "Time:"
        '
        'TextBox_CurrentTime
        '
        Me.TextBox_CurrentTime.Location = New System.Drawing.Point(668, 21)
        Me.TextBox_CurrentTime.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox_CurrentTime.Name = "TextBox_CurrentTime"
        Me.TextBox_CurrentTime.ReadOnly = True
        Me.TextBox_CurrentTime.Size = New System.Drawing.Size(35, 20)
        Me.TextBox_CurrentTime.TabIndex = 2
        '
        'Button_NewJob
        '
        Me.Button_NewJob.Location = New System.Drawing.Point(176, 235)
        Me.Button_NewJob.Margin = New System.Windows.Forms.Padding(2)
        Me.Button_NewJob.Name = "Button_NewJob"
        Me.Button_NewJob.Size = New System.Drawing.Size(93, 29)
        Me.Button_NewJob.TabIndex = 3
        Me.Button_NewJob.Text = "New Job"
        Me.Button_NewJob.UseVisualStyleBackColor = True
        '
        'DataGridView_Jobs
        '
        Me.DataGridView_Jobs.AllowUserToAddRows = False
        Me.DataGridView_Jobs.AllowUserToDeleteRows = False
        Me.DataGridView_Jobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Jobs.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.JobName, Me.JobSize, Me.JobTime})
        Me.DataGridView_Jobs.Location = New System.Drawing.Point(9, 63)
        Me.DataGridView_Jobs.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView_Jobs.Name = "DataGridView_Jobs"
        Me.DataGridView_Jobs.RowTemplate.Height = 24
        Me.DataGridView_Jobs.Size = New System.Drawing.Size(345, 167)
        Me.DataGridView_Jobs.TabIndex = 4
        '
        'JobName
        '
        Me.JobName.HeaderText = "Name"
        Me.JobName.Name = "JobName"
        Me.JobName.ReadOnly = True
        '
        'JobSize
        '
        Me.JobSize.HeaderText = "Size"
        Me.JobSize.Name = "JobSize"
        Me.JobSize.ReadOnly = True
        '
        'JobTime
        '
        Me.JobTime.HeaderText = "Time"
        Me.JobTime.Name = "JobTime"
        Me.JobTime.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.8!)
        Me.Label1.Location = New System.Drawing.Point(83, 21)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 29)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Jobs"
        '
        'DataGridView_PartitionsFree
        '
        Me.DataGridView_PartitionsFree.AllowUserToAddRows = False
        Me.DataGridView_PartitionsFree.AllowUserToDeleteRows = False
        Me.DataGridView_PartitionsFree.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_PartitionsFree.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PartitionNumber, Me.PartitionSize})
        Me.DataGridView_PartitionsFree.Location = New System.Drawing.Point(11, 412)
        Me.DataGridView_PartitionsFree.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView_PartitionsFree.Name = "DataGridView_PartitionsFree"
        Me.DataGridView_PartitionsFree.RowTemplate.Height = 24
        Me.DataGridView_PartitionsFree.Size = New System.Drawing.Size(244, 167)
        Me.DataGridView_PartitionsFree.TabIndex = 6
        '
        'PartitionNumber
        '
        Me.PartitionNumber.HeaderText = "Partition #"
        Me.PartitionNumber.Name = "PartitionNumber"
        Me.PartitionNumber.ReadOnly = True
        '
        'PartitionSize
        '
        Me.PartitionSize.HeaderText = "Partition Size"
        Me.PartitionSize.Name = "PartitionSize"
        Me.PartitionSize.ReadOnly = True
        '
        'DataGridView_BusyTable
        '
        Me.DataGridView_BusyTable.AllowUserToAddRows = False
        Me.DataGridView_BusyTable.AllowUserToDeleteRows = False
        Me.DataGridView_BusyTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_BusyTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PartitionNumber_BusyTable, Me.PartitionSize_BusyTable, Me.JobName_BusyTable, Me.TimeLeft_BusyTable})
        Me.DataGridView_BusyTable.Location = New System.Drawing.Point(285, 412)
        Me.DataGridView_BusyTable.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView_BusyTable.Name = "DataGridView_BusyTable"
        Me.DataGridView_BusyTable.RowTemplate.Height = 24
        Me.DataGridView_BusyTable.Size = New System.Drawing.Size(445, 167)
        Me.DataGridView_BusyTable.TabIndex = 7
        '
        'PartitionNumber_BusyTable
        '
        Me.PartitionNumber_BusyTable.HeaderText = "Partition #"
        Me.PartitionNumber_BusyTable.Name = "PartitionNumber_BusyTable"
        Me.PartitionNumber_BusyTable.ReadOnly = True
        '
        'PartitionSize_BusyTable
        '
        Me.PartitionSize_BusyTable.HeaderText = "Partition Size"
        Me.PartitionSize_BusyTable.Name = "PartitionSize_BusyTable"
        Me.PartitionSize_BusyTable.ReadOnly = True
        '
        'JobName_BusyTable
        '
        Me.JobName_BusyTable.HeaderText = "Job Name"
        Me.JobName_BusyTable.Name = "JobName_BusyTable"
        Me.JobName_BusyTable.ReadOnly = True
        '
        'TimeLeft_BusyTable
        '
        Me.TimeLeft_BusyTable.HeaderText = "Time Left"
        Me.TimeLeft_BusyTable.Name = "TimeLeft_BusyTable"
        Me.TimeLeft_BusyTable.ReadOnly = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.8!)
        Me.Label2.Location = New System.Drawing.Point(398, 370)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 29)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Busy Table"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.8!)
        Me.Label3.Location = New System.Drawing.Point(49, 370)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 29)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Free Table"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(174, 271)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Job Size:"
        '
        'ListBox_NewJobSize
        '
        Me.ListBox_NewJobSize.FormattingEnabled = True
        Me.ListBox_NewJobSize.Items.AddRange(New Object() {"5", "10", "15", "20", "25", "30", "40", "50", "75", "100", "150", "200", "250", "300", "350", "400", "450"})
        Me.ListBox_NewJobSize.Location = New System.Drawing.Point(228, 271)
        Me.ListBox_NewJobSize.Margin = New System.Windows.Forms.Padding(2)
        Me.ListBox_NewJobSize.Name = "ListBox_NewJobSize"
        Me.ListBox_NewJobSize.Size = New System.Drawing.Size(42, 43)
        Me.ListBox_NewJobSize.TabIndex = 11
        '
        'Button_NewPartition
        '
        Me.Button_NewPartition.Location = New System.Drawing.Point(100, 584)
        Me.Button_NewPartition.Name = "Button_NewPartition"
        Me.Button_NewPartition.Size = New System.Drawing.Size(105, 29)
        Me.Button_NewPartition.TabIndex = 12
        Me.Button_NewPartition.Text = "New Partition"
        Me.Button_NewPartition.UseVisualStyleBackColor = True
        '
        'ListBox_PartitionSize
        '
        Me.ListBox_PartitionSize.FormattingEnabled = True
        Me.ListBox_PartitionSize.Items.AddRange(New Object() {"5", "10", "15", "20", "25", "30", "40", "50", "75", "100", "150", "200", "250", "300", "350", "400", "450"})
        Me.ListBox_PartitionSize.Location = New System.Drawing.Point(151, 620)
        Me.ListBox_PartitionSize.Margin = New System.Windows.Forms.Padding(2)
        Me.ListBox_PartitionSize.Name = "ListBox_PartitionSize"
        Me.ListBox_PartitionSize.Size = New System.Drawing.Size(54, 43)
        Me.ListBox_PartitionSize.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(76, 620)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Partition Size:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 683)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(142, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Available Memory/ Capacity:"
        '
        'TextBox_MemoryRatio
        '
        Me.TextBox_MemoryRatio.Location = New System.Drawing.Point(151, 680)
        Me.TextBox_MemoryRatio.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox_MemoryRatio.Name = "TextBox_MemoryRatio"
        Me.TextBox_MemoryRatio.ReadOnly = True
        Me.TextBox_MemoryRatio.Size = New System.Drawing.Size(47, 20)
        Me.TextBox_MemoryRatio.TabIndex = 16
        '
        'FormSimulation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(758, 776)
        Me.Controls.Add(Me.TextBox_MemoryRatio)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ListBox_PartitionSize)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button_NewPartition)
        Me.Controls.Add(Me.ListBox_NewJobSize)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView_BusyTable)
        Me.Controls.Add(Me.DataGridView_PartitionsFree)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView_Jobs)
        Me.Controls.Add(Me.Button_NewJob)
        Me.Controls.Add(Me.TextBox_CurrentTime)
        Me.Controls.Add(Me.Label_Time)
        Me.Controls.Add(Me.Button_IncrementTime)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormSimulation"
        Me.Text = "Fixed Partition Simulation"
        CType(Me.DataGridView_Jobs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView_PartitionsFree, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView_BusyTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button_IncrementTime As Button
    Friend WithEvents Label_Time As Label
    Friend WithEvents TextBox_CurrentTime As TextBox
    Friend WithEvents Button_NewJob As Button
    Friend WithEvents DataGridView_Jobs As DataGridView
    Friend WithEvents JobName As DataGridViewTextBoxColumn
    Friend WithEvents JobSize As DataGridViewTextBoxColumn
    Friend WithEvents JobTime As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView_PartitionsFree As DataGridView
    Friend WithEvents PartitionNumber As DataGridViewTextBoxColumn
    Friend WithEvents PartitionSize As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView_BusyTable As DataGridView
    Friend WithEvents PartitionNumber_BusyTable As DataGridViewTextBoxColumn
    Friend WithEvents PartitionSize_BusyTable As DataGridViewTextBoxColumn
    Friend WithEvents JobName_BusyTable As DataGridViewTextBoxColumn
    Friend WithEvents TimeLeft_BusyTable As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ListBox_NewJobSize As ListBox
    Friend WithEvents Button_NewPartition As Button
    Friend WithEvents ListBox_PartitionSize As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox_MemoryRatio As TextBox
End Class
