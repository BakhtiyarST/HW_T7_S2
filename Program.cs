namespace HW_T7_S2
{
	internal class Program
	{
		static void DisplayArray1D_Int32(int[] inArr)
		{
			Console.Write("\n");
			for (int i=0;i<inArr.Length;i++)
				Console.Write($"{inArr[i]}\t");
			Console.WriteLine("\n");
		}
		static void DisplayArray2D_Int32(int[,] inArr)
		{
			// Console.WriteLine("\nArray 2D int32:");
			for (int i = 0; i < inArr.GetLength(0); i++)
			{
				Console.Write("\n");
				for (int j = 0; j < inArr.GetLength(1); j++)
				{
					Console.Write($"{inArr[i,j]}\t");
				}
			}
			Console.WriteLine("\n");
		}
		static int[] Convert2DTo1D_Int32(int[,] inArr)
		{
			int[] outArr = new int[inArr.GetLength(0)*inArr.GetLength(1)];
			for (int i = 0; i < inArr.GetLength(0); i++)
			{
				for (int j = 0; j < inArr.GetLength(1); j++)
					outArr[j + i * inArr.GetLength(0)] = inArr[i, j];
			}
			return outArr;
		}

		static int[,] Convert1DTo2D_Int32(int[] inArr, int rowNum, int colNum)
		{
			// Console.WriteLine($"Number of rows = {inArr.Length/colNum}");
			// Console.WriteLine($"Number of columns = {colNum}");
			int[,] outArr = new int[rowNum,colNum];
			int count = 0;
			for (int i = 0;i < rowNum; i++)
			{
				for (int j = 0; j < colNum; j++)
					outArr[i, j] = inArr[count++];
			}
			return outArr;
		}

		static void Sort_Int32(ref int[] inArr)
		{
			int tmpInt = 0;
			for (int i=0;i<inArr.Length;i++)
			{
				for (int j=0;j<inArr.Length-(i+1);j++)
				{
					if (inArr[j] > inArr[j+1])
					{
						tmpInt = inArr[j];
						inArr[j] = inArr[j+1];
						inArr[j+1] = tmpInt;
					}
				}
			}
		}
		static void Main(string[] args)
		{
			int[,] a = { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };
			int[] b = Convert2DTo1D_Int32(a);

			Console.WriteLine("Initial array:");
			DisplayArray2D_Int32(a);
			Console.WriteLine("Linear array:");
			DisplayArray1D_Int32(b);
			Sort_Int32(ref b);
			Console.WriteLine("Linear array (sorted):");
			DisplayArray1D_Int32(b);
			int[,] c = Convert1DTo2D_Int32(b,3,3);
			Console.WriteLine("Reshaped linear array (sorted):");
			DisplayArray2D_Int32(c);
		}
	}
}
