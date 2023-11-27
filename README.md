# GB_ControlWork1
## Task:
+ Write a program that accepts a string array. As a result, the program should output a new string array containing those elements from the first array that consist of three or less characters.
## Program Description
### Method Main
+ The program starts with this method.
+ Initialize the first string array and call subsequent methods for the operations described below. 
+ Initialize the second array. 
+ At the end, we output arrays in the form corresponding to the requirements of the task.
### Method FindCountOf3Sumbol
+ This method takes the first array as input and returns an integer number. 
+ With the help of a for loop, the method goes through the entire array and checks how many elements are in the source array that match the task condition.
### Method FillArrayElement3Symbol
+ This method takes as input the original string array and the number of matching elements from the previous method, and returns a new filled string array. 
+ The method again checks all the elements from the first array for compliance with the task. 
+ All matching elements are written to a new array.
### Method PrintArray
+ This method takes a string array as input and prints it in the form required by the task condition.