using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public static class GridBuilder
    {
        public static IGrid BuildGrid(int? matrixSize, string matrixBase)
        {
            if(matrixSize == null)
            {
                return null;
            }

            switch (matrixBase)
            {
                case "Hex":
                    return new HexGrid(matrixSize.Value);
                case "Decimal":
                    return new DecimalGrid(matrixSize.Value);
                case "Binary":
                    return new BinaryGrid(matrixSize.Value);
                default:
                    return null;
            }
        } 
    }
}