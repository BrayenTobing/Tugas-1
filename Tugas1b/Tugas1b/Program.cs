/*
 * Created by SharpDevelop.
 * User: acer
 * Date: 01/03/2022
 * Time: 19:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Tugas1b
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("Nama kamu siapa? ");
			
			string nama = Console.ReadLine();
			Console.WriteLine("Nama kamu"+nama);
			
			Console.Write("Press any key to continue . . .");
			Console.ReadKey(true);
		}
	}
}