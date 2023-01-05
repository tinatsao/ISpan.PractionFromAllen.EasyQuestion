using Practicenamespace;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ISpan.PracticeFromAllenEasy.ConsoleApp
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Q06_3_TitleToUpper();
		}

		private static void Q01_IsOddOrEven()
		{
			Console.WriteLine(Practice.IsOdd(9));
			Console.WriteLine(Practice.IsOdd(202));
		}

		private static void Q02_SumDifferenceOne()
		{
			const int sumStart = 1;
			const int sumEnd = 10;

			Console.WriteLine($"{sumStart} + {sumStart+1} + {sumStart+2} + .... + {sumEnd} 的總和是 {Practice.SumDifferenceOne(sumStart, sumEnd)}");
		}
		private static void Q03_Console_WriteLine()
		{
			Console.WriteLine(Practice.PrintString());
		}
		private static void Q04_PrintDirString()
		{
			Console.WriteLine(Practice.PrintDirString());
		}
		private static void Q05_PrintSpecialString()
		{
			Console.WriteLine(Practice.PrintSpecialString());
		}
		private static void Q06_1_TrimString()
		{
			Console.WriteLine($"字串長度為:{Practice.TrimString()}");
		}

		private static void Q06_2_StringToUpper()
		{
			Console.WriteLine(Practice.StringToUpper());
		}
		private static void Q06_3_TitleToUpper() 
		{
			Console.WriteLine(Practice.TitleToUpper());
		}
	}
}
