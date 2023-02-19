using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.PublicLibraries.Number
{    
    public class NumberHelper
    {
        public static bool IsNumeric(object input)
        {
            try
            {
                if (input == null)
                    return false;
                double test;
                return double.TryParse(input.ToString(), out test);
            }
            catch (Exception)
            {
                return false;
            }
        }

        //switch (input)
        //    {
        //        case DateTime:
        //            break;
        //        case Int16:
        //            break;
        //        case Int32:
        //            break;
        //        case Int64:
        //            break;
        //        case Decimal:
        //            break;
        //        case Single:
        //            break;
        //        case Double:
        //            break;
        //        case Boolean:
        //            break;
        //        default:
        //            break;
        //    }
}
}
