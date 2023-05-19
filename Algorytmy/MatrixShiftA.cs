using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Algorytmy
{
    public class MatrixShiftA
    {

        public static string Encode(string input, string key)
        {
            var Input = input.ToCharArray();
            var Key = new List<int>();
            var LenghtOfKey = 0;
            foreach (var item in key.Split("-"))
            {
                Key.Add(Int32.Parse(item));
            }
            LenghtOfKey = Key.Count;
            StringBuilder result = new StringBuilder();
            var x = (int)Math.Ceiling((decimal)Input.Length / (decimal)LenghtOfKey);
            var temp = 0;
            var matrix = new char[x, LenghtOfKey];

            try
            {
                for (var i = 0; i < x; i++)
                {
                    for (var j = 0; j < LenghtOfKey; j++)
                    {
                        matrix[i, j] = Input[j + temp];
                    }
                    temp += LenghtOfKey;
                }
            }
            catch (Exception ex)
            {

            }
            

            for (var i = 0; i < x; i++)
            {
                foreach (var item in Key)
                {
                    if (matrix[i, item-1] != '\0')
                        result.Append(matrix[i, item - 1]);
                }
            }

            return result.ToString().Replace("\0", "");
        }


        public static string Decode(string input, string key)
        {
            var Input = input.ToCharArray();
            var Key = new List<int>();
            var LenghtOfKey = 0;
            StringBuilder result = new();
            var temp = 0;
            foreach (var item in key.Split("-"))
            {
                Key.Add(Int32.Parse(item));
            }
            LenghtOfKey = Key.Count;
            var x = (int)Math.Ceiling((decimal)Input.Length / (decimal)LenghtOfKey);
            var matrix = new char[x, LenghtOfKey];

            var licz = 0;

            var charCounter = 0;

            for (var i = 0; i < x; i++)
            {
                if (i != x - 1 && Key.Count() != Input.Length - charCounter)
                {
                    foreach (var item in Key)
                    {
                        matrix[i, item - 1] = Input[charCounter];
                        charCounter++;
                    }
                }
                else
                {
                    licz = (Input.Length - charCounter) ;
                    foreach (var item in Key)
                    {
                        if (item <= licz)
                        {
                            matrix[i, item - 1] = Input[charCounter];
                            charCounter++;
                        }
                    }
                }
            }


            foreach (var item in matrix)
            {
                result.Append(item);
            }

            return result.ToString().Replace("\0", "");
        }
    }
}
