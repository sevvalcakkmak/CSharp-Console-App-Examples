using System;

class MultiplicationTable
{
    public static void Main(string[] args)
    {
        MultiplicationTable obj = new MultiplicationTable();
        Console.WriteLine("MULTIPLICATION TABLE\n--------------------");
        int row;
        Console.Write("Define row number: ");
        row = Convert.ToInt32(Console.ReadLine());
        int column;
        Console.Write("Define column number: ");
        column = Convert.ToInt32(Console.ReadLine());

        int[,] arr = new int[row, column];
        string[,] sArr = new string[row, column];

        obj.multiplication(arr);
        obj.convertIntArrToStringArr(sArr, arr);
        sArr[0, 0] = "X";
        obj.print2DArr(sArr, row, column);
        Console.ReadKey();
    }

    void multiplication(int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            arr[i, 0] = i;
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                arr[0, j] = j;
                if (i * j != 0)
                {
                    arr[i, j] = i * j;
                }
            }
        }
    }

    void convertIntArrToStringArr(string[,] sArr, int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                sArr[i, j] = Convert.ToString(arr[i, j]);
            }
        }
    }

    void print2DArr(string[,] sArr, int row, int column)
    {
        Console.WriteLine();
        int maxLength = sArr[row - 1, column - 1].Length;
        for (int i = 0; i < sArr.GetLength(0); i++)
        {
            for (int j = 0; j < sArr.GetLength(1); j++)
            {
                Console.Write(sArr[i, j] + " ");
                for (int k = 0; k < maxLength - sArr[i, j].Length; k++)
                {
                    Console.Write(" ");
                }

                if (j == 0)
                {
                    Console.Write("| ");
                }
            }
            Console.WriteLine(); 
            if (i == 0)
            {
                for (int a = 0; a < sArr.GetLength(1) * (maxLength + 1); a++)
                {
                    Console.Write("-");
                }
                Console.WriteLine();
            }
        }
    }
}