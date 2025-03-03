using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpisukOtKrainosti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wuwedi chisla:");
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> result = new List<int>();

            int min = nums[0];
            int max = nums[0];

            for (int i = 1; i < nums.Count; i++) 
            {
                if (nums[i] < min) 
                {
                    min = nums[i];
                }
                if (nums[i] > max) 
                {
                    max = nums[i]; 
                }

            }

            for (int index = 0; index < nums.Count; index++)
            {

                if (nums[index] == min || nums[index] == max)
                {
                    result.Add(index);  
                }
            }

            for (int index = 0; result.Count > 0; index++)
            {
                Console.WriteLine(result[index]);
            }

        }
    }
}
