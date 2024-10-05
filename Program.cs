using System;
using System.Data.OleDb;
namespace CnAN_Providers
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Installed OLEDb data providers:");	
			OleDbDataReader rdr = OleDbEnumerator.GetRootEnumerator();
			while (rdr.Read())
			{
				Console.WriteLine(String.Format("Name = {0}, Description = {1}", rdr[0], rdr[2]));
			};
		}
	}
}
