using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics.SymbolStore;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicenamespace
{
    public class Practice
    {
		/// <summary>
		/// Q1: 計算 9 與 202 分別是奇數或是偶數
		/// </summary>
		/// <param name="num"></param>
		/// <returns></returns>
		public static bool IsOdd(int num)
        {
            if (num % 2 == 0) return false;
            return true;
        }
		/// <summary>
		/// Q2 :計算並顯示 1 + 2 + 3 + .... + 10 的總和
		/// </summary>
		/// <param name="numStart"></param>
		/// <param name="numEnd"></param>
		/// <returns></returns>
		public static int SumDifferenceOne(int numStart ,int numEnd)
        {
            return((numStart+ numEnd)*((numEnd- numStart)+1) / 2);
		}
		/// <summary>
		/// Q3 : @"$宣告字串變數時使用 @, 包含以下值以及折行, 並用 Console.WriteLine() 將它忠實地呈現在畫面上(呈現時也必需折行)
		///<select>
		///<option value = "1" > 台北 </ option >
		///< option value="2">台中</option>
		///</select>$
		/// </summary>
		/// <returns></returns>
		public static string PrintString()
		{
			return  $@"<select>
<option value=""1"">台北</option>
<option value=""2"">台中</option>
</select>";
		}
		/// <summary>
		/// Q4 :宣告字串變數, 包含以下值, 並用 Console.WriteLine() 將它忠實地呈現在畫面上
		///D:\temp\animal.jpg
		/// </summary>
		/// <returns></returns>
		public static string PrintDirString()
		{
			return $@"D:\temp\animal.jpg";
		}
		/// <summary>
		/// Q5 : 宣告字串變數, 包含以下值, 並用 Console.WriteLine() 將它忠實地呈現在畫面上
		/// 我是一個"好學生", 會乖乖練習寫作業
		/// </summary>
		/// <returns></returns>
		public static string PrintSpecialString()
		{
			return $@"我是一個""好學生"", 會乖乖練習寫作業";
		}
		/// <summary>
		/// Q6-1字串內容是
		///"   abc   "
		///將字串左右空白刪除後, 顯示最後字串長度是多少
		/// </summary>
		/// <returns></returns>
		public static int TrimString(string str = "   abc   ")
		{
			string trimStr = str.Trim();
			return (trimStr.Length);
		}
		/// <summary>
		/// Q6-2
		///將字串"Allen Kuo"
		///轉換成全部大寫"ALLEN KUO"
		/// </summary>
		/// <param name="str"></param>
		/// <returns></returns>
		public static string StringToUpper(string str = "Allen Kuo")
		{
			return str.ToUpper();
		}
		/// <summary>
		///Q6-3
		///將字串
		///"aLLeN kUO"
		///轉換成
		///"Allen Kuo"
		///也就是每一個單字的開頭大寫,其餘小寫
		///
		/// </summary>
		/// <param name="str"></param>
		/// <returns></returns>
		public static string TitleToUpper(string str = "aLLeN kUO")
		{
			//[不明白] 為什麼6-1、6-2可以直接 str.xxx 但這個直接寫 str.ToTitleCase 會報錯。
			TextInfo myTI = new CultureInfo("en-US", false).TextInfo;
			return myTI.ToTitleCase(str);
		}
	}
}
