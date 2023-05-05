using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Globalization;
namespace SPAexample.Utilitils
{
    public static class DateTimeConvertor
    {
        public static string ToShamsi(this DateTime date)
        {
            PersianCalendar calendar = new PersianCalendar();
            return calendar.GetYear(date) + "/" + calendar.GetMonth(date) + "/" + calendar.GetDayOfMonth(date);
        }

    }
}