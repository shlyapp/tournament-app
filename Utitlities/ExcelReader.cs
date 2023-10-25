using Aspose.Cells;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentApp.Model;

namespace TournamentApp.Utitlities
{
    public static class ExcelReader
    {
        public static List<User> GetListUsers(string path)
        {
            Workbook workbook = new Workbook(path);
            Worksheet worksheet = workbook.Worksheets[0];

            List<User> users = new List<User>();

            for (int i = 1; i < worksheet.Cells.MaxDataRow; i++)
            {
                User user = new User(
                    (int)worksheet.Cells[i, 0].Value,
                    (string)worksheet.Cells[i, 1].Value,
                    (string)worksheet.Cells[i, 2].Value,
                    (DateTime)worksheet.Cells[i, 3].Value,
                    (int)worksheet.Cells[i, 4].Value,
                    (int)worksheet.Cells[i, 5].Value,
                    (string)worksheet.Cells[i, 6].Value,
                    (string)worksheet.Cells[i, 7].Value,
                    (string)worksheet.Cells[i, 8].Value
                    );

                users.Add(user);
            }

            return users;
        }
    }
}
