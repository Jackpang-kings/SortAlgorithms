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

        static void Main(string[] args){
            List<int> rndList=GenerateList(10,0,100);
            
        }


    }
}