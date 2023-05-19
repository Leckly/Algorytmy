using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Algorytmy
{
    public class MatrixShiftB
    {
        public static string Encode(string input, string key)
        {
            #region zmienne 

            bool containsSpaces = input.Contains(" ");
            var inputArray = input.ToCharArray();
            StringBuilder result = new StringBuilder();
            var x = (int)Math.Ceiling((decimal)inputArray.Length / (decimal)key.Length);
            char[,] matrix = new char[x, key.Length];
            int counter = 0;
            var keyArray = key.ToList();
            bool[] arr = new bool[keyArray.Count];
            for (var i = 0; i < keyArray.Count; i++)
            {
                arr[i] = true;
            }
            var sortedKeyArray = key.ToCharArray();
            Array.Sort(sortedKeyArray);

            #endregion
            // Wpisywanie inputu do tablicy
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < key.Length; j++)
                {
                    if (input[counter] == ' ' || input[counter] == '\0')
                    {
                        counter++;
                    }
                    matrix[i, j] = inputArray[counter];
                    counter++;
                    if (counter == input.Length)
                        break;
                }
            }

            //Kodowanie
            foreach (var item in sortedKeyArray)
            {
                var index = 0;
                for (var i = 0; i < keyArray.Count; i++)
                {
                    if (keyArray[i] == item)
                    {
                        if (arr[i] == true)
                        {
                            index = i;
                            arr[index] = false;
                            break;
                        }
                    }
                }
                for (int i = 0; i < x; i++)
                {
                    result.Append(matrix[i, index]);
                }
                
                if(containsSpaces )
                    result.Append(' ');
            }

            // usunięcie ostatniej spacji
            if (containsSpaces)
                result.Remove(result.Length - 1, 1);
            return result.ToString().Replace("\0","");
        }
        public static string Decode(string input, string key)
        {
            var result = new StringBuilder();
            var inputArray = input.ToCharArray();
            var x = (int)Math.Ceiling((decimal)inputArray.Length / (decimal)key.Length);
            char[,] matrix = new char[x, key.Length];
            var keyArray = key.ToList();
            bool[] arr = new bool[keyArray.Count];
            for (var i = 0; i < keyArray.Count; i++)
            {
                arr[i] = true;
            }
            var sortedKeyArray = key.ToCharArray();
            Array.Sort(sortedKeyArray);
            var counter = 0;
            var roznica = input.Length%key.Length;


            
            foreach (var item in sortedKeyArray)
            {
                var index = 0;
                for (var i = 0; i < keyArray.Count; i++)
                {
                    if (keyArray[i] == item)
                    {
                        if (arr[i] == true)
                        {
                            index = i;
                            arr[index] = false;
                            break;
                        }
                    }
                }
                var b = 0;
                if (roznica != 0)
                {
                    if (index + 1 % key.Length > roznica)
                    {
                        b = x - 1;
                    }
                    else
                    {
                        b = x;
                    }
                }
                else
                {
                    b = x;
                }
                for (var i = 0; i < b; i++)
                {
                    matrix[i, index] = inputArray[counter];
                    counter++;
                    if (counter == input.Length)
                        break;
                }
                if (counter == input.Length)
                    break;
            }




            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < key.Length; j++)
                {
                    if (matrix[i,j] != '\0')
                        result.Append(matrix[i,j]);
                }
            }

            return result.ToString().Replace("\0","");
        }
    }
}
