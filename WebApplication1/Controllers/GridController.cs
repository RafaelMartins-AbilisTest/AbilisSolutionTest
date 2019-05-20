using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class GridController : Controller
    {
        public ActionResult Grid(int? matrix_size, string matrix_base)
        {

            if (matrix_size == null)
            {
                matrix_size = 10;
            }
            if (matrix_base == null)
            {
                matrix_base = "Decimal";
            }

            if(!this.ValidateGridParams(matrix_size, matrix_base))
            {
                matrix_size = 10;
                matrix_base = "Decimal";
                ViewBag.HasErrors = true;
            }
            else
            {
                ViewBag.HasErrors = false;
            }

            IGrid newGrid = GridBuilder.BuildGrid(matrix_size, matrix_base);
            ViewBag.GridType = matrix_base + " Grid";
            ViewBag.GridDimensions = matrix_size + " x " + matrix_size;

            return View(newGrid);
        }

        private bool ValidateGridParams(int? matrix_size, string matrix_base)
        {
            if (matrix_size != null && (matrix_size < 3 || matrix_size > 15))
            {
                return false;
            }
            if (matrix_base != null && (matrix_base != "Decimal" && matrix_base != "Hex" && matrix_base != "Binary"))
            {
                return false;
            }
            return true;
        }
    }
}