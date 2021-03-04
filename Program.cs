using System;

namespace MyDictionary
{
	class Program
	{
		static void Main(string[] args)
		{
			MyDictionary<int, string> dictionary1 = new MyDictionary<int, string>();

			dictionary1.Add(1, "Hamza");
			dictionary1.Add(2, "Deres");
			dictionary1.Add(2, "Salata");
			dictionary1.Listele();

		}
	}
}
