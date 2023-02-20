using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.PublicLibraries.Excel
{
    public class Excel_Helper
    {
        public MemoryStream Export(System.Data.DataTable dt)
        {
            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Right);
                IXLWorksheet worksheet = wb.Worksheets.Add(dt, "data_export");
                worksheet.Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Right);
                worksheet.RightToLeft = true;

                var range = worksheet.Row(1);
                foreach (var cell in range.Cells())
                {
                    cell.Style.Font.FontName = "tahoma";
                    cell.Style.Font.FontSize = 8;
                    cell.Style.Font.FontColor = XLColor.Black;
                    cell.Style.Font.Bold = true;
                }
                //wb.Worksheets.Add(dt);
                MemoryStream _stream = new MemoryStream();
                using (MemoryStream stream = new MemoryStream())
                {
                    wb.SaveAs(stream);
                    return stream;
                }
            }
        }
    }
}
