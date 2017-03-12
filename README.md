# FixedPartitionScheme
VB.NET implementation of a computer's memory allocation scheme of type fixed partition.

This project was completed on 8 Feb 2017.

-------------------------------------------------------------------------------------------

Assignment Description:
"Lab 1 - Fixed Partitions  Due February 10th, 2017

Write a program to simulate the Fixed Partition Memory Scheme. The total memory available should be of size 500. You will need to create the fixed size paritions for the total memory available. But there should be at least 25, 50, and 100 sized partitions. 

Each job will have its name, memory size, and 5 second job execution time. 

For this scheme to work a Free and Busy table are needed. The Free table will include all free partitions while the Busy table will have busy partitions. Both tables are in ascending order based on size. For each row in the Free table there should the partition number, its size, and "FREE". In contrast the Busy table will have the partition number, job name that is occupying the partition, partition size, and "BUSY"

Make sure to create a list of jobs to be completed in the beginning, this will be your waiting queue from which you will take jobs from as soon memory becomes available."
