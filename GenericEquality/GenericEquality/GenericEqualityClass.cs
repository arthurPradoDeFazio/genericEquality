using System;
namespace GenericEquality
{
	public static class GenericEqualityClass
	{
		public static bool Equals<T>(T one, T other) where T: IComparable
		{
			return one.CompareTo(other) == 0;
		}
	}

}

