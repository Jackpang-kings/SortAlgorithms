﻿using System;
using System.ComponentModel.Design.Serialization;
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
            List<int> retList=new List<int>{};


            return retList;
        }

        //Helper function that can merge 2 lists into a new one in sorted order
        static List<int> MyMergeLists(List<int> listA, List<int> listB){
            List<int> retList=new List<int>{};


            return retList;            
        }

        //main function, designed to be used recursively
        static List<int> MyMergeSort(List<int> inList){
            List<int> retList=new List<int>{};


            return retList;
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