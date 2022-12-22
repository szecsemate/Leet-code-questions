using System;

namespace Jackie
{
    class Program
    {
        static void Main(string[] args)
        {

         int[] nums = new int[10];
         int target = 12;   

         for(int i = 0; i < nums.Length; i ++)
         {
            for(int k = i; k < nums.Length; k++)
            {
                if(nums[i] + nums[k] == target)
                {
                    System.Console.WriteLine(new int[] {i,k}); //return new int[] {i,k};
                }
            }
         }
            
        }
    }
}