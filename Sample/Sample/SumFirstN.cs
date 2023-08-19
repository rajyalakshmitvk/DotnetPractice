using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace First_Ten_No
{
	class SumFirstN
	{
		static void Main(string[] args)
		{
			int sum = 0;
			int n = int.Parse(args[0]);
			for(int i=1;i<=n;i++)
			{
				sum += i;
			}
			Console.WriteLine(sum);
		}
	}
}
