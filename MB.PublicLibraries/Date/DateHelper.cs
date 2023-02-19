using MD.PersianDateTime.Core;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.PublicLibraries.Date
{
    public class DateHelper
    {
        public string _MiladiToShamsi_Full(DateTime _date)
        {
            PersianCalendar pc = new PersianCalendar();
            try
            {
                string now = "";
                string m = pc.GetMonth(_date) <= 9 ? "0" + pc.GetMonth(_date).ToString() : pc.GetMonth(_date).ToString();
                string d = pc.GetDayOfMonth(_date) <= 9 ? "0" + pc.GetDayOfMonth(_date).ToString() : pc.GetDayOfMonth(_date).ToString();
                now = pc.GetYear(_date).ToString() + "/" + m + "/" + d;
                return now + " ساعت " + _date.ToString("HH:mm");
            }
            catch { return ""; }
        }
        public string _MiladiToShamsi_Date(DateTime _date)
        {
            PersianCalendar pc = new PersianCalendar();
            try
            {
                string now = "";
                string m = pc.GetMonth(_date) <= 9 ? "0" + pc.GetMonth(_date).ToString() : pc.GetMonth(_date).ToString();
                string d = pc.GetDayOfMonth(_date) <= 9 ? "0" + pc.GetDayOfMonth(_date).ToString() : pc.GetDayOfMonth(_date).ToString();
                now = pc.GetYear(_date).ToString() + "/" + m + "/" + d;
                return now;
            }
            catch { return ""; }
        }



        public DateTime _Shamsi2Miladi(string _date)
        {
            try
            {
                var date = _date.Split('/');

                int year = int.Parse(date[0]);
                int month = int.Parse(date[1].Length == 2 ? date[1] : "0" + date[1]);
                int day = int.Parse(date[1].Length == 2 ? date[2] : "0" + date[2]);
                PersianCalendar p = new PersianCalendar();
                DateTime dateMiladi = p.ToDateTime(year, month, day, 0, 0, 0, 0);
                return dateMiladi;
            }
            catch { return DateTime.Now; }
        }
        public string FullShamsiDate(DateTime _date)
        {
            PersianCalendar pc = new PersianCalendar();
            try
            {
                string now = "";
                string weekDay = "";
                switch (pc.GetDayOfWeek(_date).ToString())
                {
                    case "Saturday":
                        weekDay = "شنبه";
                        break;
                    case "Sunday":
                        weekDay = "یکشنبه";
                        break;
                    case "Monday":
                        weekDay = "دوشنبه";
                        break;
                    case "Tuesday":
                        weekDay = "سه شنبه";
                        break;
                    case "Wednesday":
                        weekDay = "چهار شنبه";
                        break;
                    case "Thursday":
                        weekDay = "پنج شنبه";
                        break;
                    case "Friday":
                        weekDay = "جمعه";
                        break;
                }
                string month = "";
                switch (pc.GetMonth(_date))
                {
                    case 1:
                        month = "فروردین ماه";
                        break;
                    case 2:
                        month = "اردیبهشت ماه";
                        break;
                    case 3:
                        month = "خرداد ماه";
                        break;
                    case 4:
                        month = "تیر ماه";
                        break;
                    case 5:
                        month = "مرداد ماه";
                        break;
                    case 6:
                        month = "شهریور ماه";
                        break;
                    case 7:
                        month = "مهر ماه";
                        break;
                    case 8:
                        month = "آبان ماه";
                        break;
                    case 9:
                        month = "آذر ماه";
                        break;
                    case 10:
                        month = "دی ماه";
                        break;
                    case 11:
                        month = "بهمن ماه";
                        break;
                    case 12:
                        month = "اسفند ماه";
                        break;
                }
                string d = pc.GetDayOfMonth(_date) <= 9 ? "0" + pc.GetDayOfMonth(_date).ToString() : pc.GetDayOfMonth(_date).ToString();
                now = weekDay + " " + d + " " + month + " " + pc.GetYear(_date).ToString();
                return now;
            }
            catch { return ""; }
        }
        public string _DateTimeNow_Persian()
        {
            return _MiladiToShamsi_Full(DateTime.Now);
        }


        //public DateTime ConvertShamsiToMiladi(string date)
        //{
        //    PersianDateTime persianDateTime = PersianDateTime.Parse(date);
        //    return persianDateTime.ToDateTime();
        //}

        //public string ConvertMiladiToShamsi(this DateTime? date, string format)
        //{
        //    PersianDateTime persianDateTime = new PersianDateTime(date);
        //    return persianDateTime.ToString(format);
        //}


    }
}
