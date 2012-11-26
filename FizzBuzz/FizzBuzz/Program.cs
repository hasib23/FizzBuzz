using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{

	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("------------------- FIzzBuzz---------------------");
			for(int i = 1; i <= 100; i++)
			{
				if(i % 3 == 0 && i % 5 == 0)
				{
					Console.Write(i + " FizzBuzz" + "\n");
				}
				else if(i % 3 == 0)
				{
					Console.Write(i + " Fizz" + "\n");
				}
				else if(i % 5 == 0)
				{
					Console.Write(i + " Buzz" + "\n");
				}

			}
			Console.ReadLine();
		}

	}
}
