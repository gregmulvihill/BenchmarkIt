using System;

namespace BenchmarkIt
{
	public class Tuple<T1, T2>
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }

		public Tuple(T1 oItem1, T2 oItem2)
		{
			Item1 = oItem1;
			Item2 = oItem2;
		}
	}
}