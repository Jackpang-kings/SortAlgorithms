using System;
using System.ComponentModel.Design.Serialization;
using System.Reflection;
namespace SortingAlgorithms
{
    class Program
    {
        //generate a random list of integers 
        static List<int> GenerateList(int size, int low, int high){
            Random rand = new Random();
            List<int> retList= new List<int> {};
            for (int i=0; i<size; i++){
                retList.Add(rand.Next(low,high));
            }
            return retList;
        }

        static List<int> MyBubbleSort(List<int> inList){
            List<int> retList=inList;
            bool swap = true;
            int pass = 0;
            int end = retList.Count;
            int temp;
            while (pass < end && swap == true){
                pass++;
                swap = false;
                for (int i=0; i<end-1;i++){
                    if (retList[i] > retList[i+1]){
                        temp = retList[i];
                        retList[i] = retList[i+1];
                        retList[i+1] = temp; 
                        swap = true;
                    }
                }
            }
            return retList;
        }

        
        //Helper function that can merge 2 lists into a new one in sorted order
        static List<int> MyMergeLists(List<int> listA, List<int> listB){
            int pointA = 0;
            int pointB = 0;
            List<int> retList = new List<int>();
            int lenA = listA.Count;
            int lenB = listB.Count;
            while (pointA < lenA || pointB < lenB){
                if (pointA == lenA){
                    retList.Add(listB[pointB]);
                    pointB++;
                }else if (pointB == lenB){
                    retList.Add(listA[pointA]);
                    pointA++;
                }else if (listA[pointA] < listB[pointB]){
                    retList.Add(listA[pointA]);
                    pointA++;
                }else if (listB[pointB] < listA[pointA]){
                    retList.Add(listB[pointB]);
                    pointB++;
                }else if (listA[pointA] == listB[pointB]){
                    retList.Add(listA[pointA]);
                    pointA++;
                }
            }
            return retList;            
        }

        //main function, designed to be used recursively
        static List<int> MyMergeSort(List<int> inList){
            List<int> retList = inList;
            List<int> left;
            List<int> right;
            int len = retList.Count;
            int mid;
            if (len == 1){
                return inList;
            }else{
                mid = retList.Count/2;
                left = MyMergeSort(retList.GetRange(0, mid));
                right = MyMergeSort(retList.GetRange(mid, len-mid));
                retList = MyMergeLists(left, right);
                return retList;
            }

        }

        static void Main(string[] args){

            //create a random list of 10 integers and output to console
            Console.WriteLine("The original list is");
            List<int> rndList=GenerateList(10,0,100);
            foreach (int i in rndList){
                Console.Write($"{i}, ");    
            }
            Console.WriteLine("\nSorted by Bubble sort \n");
            List<int> bubbleList=MyBubbleSort(rndList);
            foreach (int i in bubbleList){
                Console.Write($"{i}, ");    
            }
            Console.WriteLine("\nSorted by Merge sort \n");
            List<int> mergeList=MyMergeSort(rndList);
            foreach (int i in mergeList){
                Console.Write($"{i}, ");    
            }

        }


    }
}