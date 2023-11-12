# SortAlgorithms-JCA-
Skelton program for creating list functions

## Help on using lists in C#

If you are used to slicing lists in Python using the syntax list[start:count] then the 
nearest equivilent in C# is the GetRange method 

.GetList accepts 2 parameters of type int,  start index and number of element to extract

so if we have a list of 5 items 
list1={1,2,3,4,5}

then 
- list1.GetRange(0,2) will return a list {1,2}
- list1.GetRange(1,4) will return a list {2,3,4,5}

Other methods can be found here
https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-7.0
