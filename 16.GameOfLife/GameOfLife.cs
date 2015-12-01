using System;
using System.Collections.Generic;

namespace _16.GameOfLife
{
    class GameOfLife
    {
        static int counting(string a, string b, string c, int pos)
        {
            int count = 0;
            if (a.Length > 0)
            {
                if(pos > 0)
                    if (a[pos - 1] == '1') count++;
                if (a[pos] == '1') count++;
                if(pos < 9)
                    if (a[pos + 1] == '1') count++;
            }
            if (pos > 0)
                if (b[pos - 1] == '1') count++;
            if (pos < 9)
                if (b[pos + 1] == '1') count++;
            if (c.Length > 0)
            {
                if (pos > 0)
                    if (c[pos - 1] == '1') count++;
                if (c[pos] == '1') count++;
                if (pos < 9)
                    if (c[pos + 1] == '1') count++;
            }
            return count;
        }
        static string replaceSymbol(string old, int pos, char sym)
        {
            string temp = string.Empty;
            for (int i = 0; i < old.Length; i++)
            {
                if (i == pos)
                {
                    temp += sym;
                }
                else
                {
                    temp += old[i];
                }
            }
            return temp;
        }
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int[,] coord = new int[number, 2];
            for (int i = 0; i < number; i++)
            {
                coord[i, 0] = int.Parse(Console.ReadLine());
                coord[i, 1] = int.Parse(Console.ReadLine());
            }
            List<string> matrix = new List<string>();
            for (int i = 0; i < 10; i++)
            {
                matrix.Add("0000000000");
            }
            for (int i = 0; i < number; i++)
            {
                matrix[coord[i, 0]] = replaceSymbol(matrix[coord[i, 0]], 9 - coord[i, 1], '1');
            }
            List<string> newMatrix = new List<string>();
            for (int i = 0; i < 10; i++)
            {
                string strTemp = matrix[i];
                int strNum = strTemp.Length;
                for (int j = 0; j < strNum; j++)
                {
                    if (counting((i == 0) ? string.Empty : matrix[i - 1], matrix[i], (i == 9) ? string.Empty : matrix[i + 1], j) == 2)
                    {
                        strTemp = replaceSymbol(strTemp, j, strTemp[j]);
                    }
                    else if (counting((i == 0) ? string.Empty : matrix[i - 1], matrix[i], (i == 9) ? string.Empty : matrix[i + 1], j) == 3)
                    {
                        strTemp = replaceSymbol(strTemp, j, '1');
                    }
                    else
                    {
                        strTemp = replaceSymbol(strTemp, j, '0');
                    }
                }
                newMatrix.Add(strTemp);
                strTemp = string.Empty;
            }
            foreach (string v in newMatrix)
            {
                Console.WriteLine(v);
            }
        }
    }
}
