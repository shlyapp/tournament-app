using Aspose.Cells;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentApp.Model;

namespace TournamentApp.Utilities
{
    public static class ExcelReader
    {
        public static List<List<object>> ReadDataFromExcel(string filePath)
        {
            Workbook workbook = new Workbook(filePath);
            Worksheet worksheet = workbook.Worksheets[0];

            List<List<object>> rowData = new List<List<object>>();

            for (int row = 1; row <= worksheet.Cells.MaxDataRow; row++)
            {
                List<object> currentRowData = new List<object>();

                for (int col = 0; col <= worksheet.Cells.MaxDataColumn; col++)
                {
                    Cell cell = worksheet.Cells[row, col];
                    currentRowData.Add(cell.Value);
                }

                rowData.Add(currentRowData);
            }

            return rowData;
        }
    }
}
