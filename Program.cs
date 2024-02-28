using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {


        static int[] TwoSum(int[] nums,int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] {i, j};
                    }
                }
            }
            return null;
        }
        static void Main(string[] args)
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            int[] result = TwoSum(nums, target);
            for (int i = 0;i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
            Console.ReadLine();
        }

        
    }
}
