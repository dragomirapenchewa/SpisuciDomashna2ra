using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpisukOtChetniChisla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wuwedi chisla: ");
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int index = 0; index < nums.Count; index++)
            {

                if (nums[index] % 2 == 0)
                {
                    Console.WriteLine(nums[index]);
                }

            }


        }
    }
}
