namespace сcs
{
	class Program
	{
		static void Main(string[] args)
		{
			var array = new int[6];
			var startValue = 1;
			for (int i = 0; i < array.Length; ++i)
			{
				array[i] = startValue++;
			}

			MoveArrayToLeft(array);
			Console.WriteLine("END\r\n");
		}

		private static T[] ConcatinateArray<T>(T[] array1, T[] array2)
		{
			var firstArrayLength = array1.Length;
			var secondArrayLength = array2.Length;
			for (int i = 0; i < firstArrayLength; ++i)
			{
				for (int j = 0; j < secondArrayLength; ++j)
				{
					if ((object)array1[i]! == (object)array2[j]!)
					{
						(array2[j], array2[^0]) = (array2[secondArrayLength - 1], array2[j]);
						secondArrayLength--;
					}
				}
			}

			var result = new T[firstArrayLength + secondArrayLength];
			for (int i = 0; i < firstArrayLength; ++i)
			{
				result[i] = array1[i];
			}
			for (int i = firstArrayLength; i < secondArrayLength; ++i)
			{
				result[i] = array1[i];
			}
			return result;
		}

		private static T[] MoveArrayToLeft<T>(T[] array)
		{
			T firstElement = array[0];
			for (int i = 0; i < array.Length - 1; ++i)
			{
				array[i] = array[i + 1];
			}

			array[^1] = firstElement;
			return array;
		}
		private static double AngleBetweenHourAndMinute(ref int hours, ref int minutes)
		{
			return (hours + (double)minutes / 60) * 30 - minutes * 6;
		}
		private static int MiddleOf3Numbers(int a, int b, int c)
		{
			if ((a >= b && b >= c) || (c >= b && b >= a))
				return b;
			if ((b >= a && a >= c) || (c >= a && a >= b))
				return a;
			return c;
		}
		private static string RemoveStartSpaces(string text)
		{
			var i = 0;
			while (true)
			{
				if (!char.IsWhiteSpace(text[i++])) break;
			}
			return text.Substring(i);

		}
		private static void WriteBoard(int size)
		{
			char symbol = '#';
			char tempSymbol = '.';
			for (int i = 0; i < size; ++i)
			{
				for (int j = 0; j < size; ++j)
				{
					Console.Write((i + j) % 2 == 0 ? "#" : ".");
				}
				Console.WriteLine();
			}
			Console.WriteLine();
		}
		public static int MaxIndex(double[] array)
		{
			int maxIndex = 0;
			for (var i = 1; i != array.Length; ++i)
			{
				if (array[i] == array[maxIndex])
					continue;
				if (array[i] > array[maxIndex])
					maxIndex = i;
			}
			return maxIndex;
		}

		static bool ContainsAtIndex(int[] array, int[] subArray, int i)
		{
			for (int j = 0; j < subArray.Length; ++j)
			{
				if (array[i++] != subArray[j])
					return false;
			}
			return true;
		}
		public static int FindSubarrayStartIndex(int[] array, int[] subArray)
		{
			for (var i = 0; i < array.Length - subArray.Length + 1; i++)
				if (ContainsAtIndex(array, subArray, i))
					return i;
			return -1;
		}


	}

}


