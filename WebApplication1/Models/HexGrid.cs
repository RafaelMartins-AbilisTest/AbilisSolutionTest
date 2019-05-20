using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Helpers;

namespace WebApplication1.Models
{
    public class HexGrid : IGrid
    {
        public string[,] Grid { get; set; }
        public List<string> PrimeNumbers { get; set; }

        public HexGrid(int maxSize)
        {
            this.Grid = new string[maxSize, maxSize];
            this.PrimeNumbers = new List<string>();

            for (int indexX = 1; indexX <= maxSize; indexX++)
            {
                for (int indexY = 1; indexY <= maxSize; indexY++)
                {
                    string valueToAdd = (indexX * indexY).ToString("X");
                    this.Grid[indexX - 1, indexY - 1] = valueToAdd;

                    if (PrimeNumbersHelper.IsPrime(indexX * indexY) && !this.PrimeNumbers.Contains(valueToAdd))
                    {
                        this.PrimeNumbers.Add(valueToAdd);
                    }
                }
            }
        }
    }
}