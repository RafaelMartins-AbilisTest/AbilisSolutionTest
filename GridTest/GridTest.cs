using System;
using WebApplication1.Helpers;
using WebApplication1.Models;
using Xunit;

namespace GridTest
{
    public class GridTest
    {
        [Fact]
        public void GridBuilder_Test()
        {
            int matrixSize = 10;

            string typeDecimal = "Decimal";
            string typeBinary = "Binary";
            string typeHex = "Hex";

            IGrid gridToTest;

            gridToTest = GridBuilder.BuildGrid(matrixSize, typeDecimal);
            Assert.IsType<DecimalGrid>(gridToTest);

            gridToTest = GridBuilder.BuildGrid(matrixSize, typeBinary);
            Assert.IsType<BinaryGrid>(gridToTest);

            gridToTest = GridBuilder.BuildGrid(matrixSize, typeHex);
            Assert.IsType<HexGrid>(gridToTest);
        }

        [Fact]
        public void PrimeNumbers_Test()
        {
            int primeNumber = 13;
            int nonPrimeNumber = 77;

            Assert.True(PrimeNumbersHelper.IsPrime(primeNumber));
            Assert.False(PrimeNumbersHelper.IsPrime(nonPrimeNumber));
        }
    }
}
