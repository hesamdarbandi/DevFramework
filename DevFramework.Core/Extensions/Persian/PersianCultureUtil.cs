using System;
using System.Globalization;
using DevFramework.Core.Infrastructure.Utils.Persian;

namespace DevFramework.Core.Infrastructure.Extensions.Persian
{
    public static class PersianCultureExtension
    {
         public static int GetPersianDayOfMonth(this DateTime dateTime)
        {
            return PersianCulture.Instance.DateTimeFormat.Calendar.GetDayOfMonth(dateTime);
        }

        /// <summary>
        /// Returns the month part of this <see cref="DateTime"/> localized in Persian calendar.
        /// </summary>
        /// <param name="dateTime">The <see cref="DateTime"/> to extend.</param>
        /// <returns>An integer between 1 and 12 representing the month part of this <see cref="DateTime"/>.</returns>
        public static int GetPersianMonth(this DateTime dateTime)
        {
            return PersianCulture.Instance.DateTimeFormat.Calendar.GetMonth(dateTime);
        }

        /// <summary>
        /// عدد به حروف روزهای شمسی
        /// </summary>
        public static string GetPersianMonthDayNumberName(this int dayNumber)
        {
            if (dayNumber < 1 || dayNumber > 31)
            {
                throw new ArgumentOutOfRangeException($"{nameof(dayNumber)} must be between 1, 31.");
            }
            return PersianCulture.PersianMonthDayNumberNames[dayNumber];
        }

        /// <summary>
        /// نام فارسی ماه‌های شمسی
        /// </summary>
        public static string GetPersianMonthName(this int monthNumber)
        {
            if (monthNumber < 1 || monthNumber > 12)
            {
                throw new ArgumentOutOfRangeException($"{nameof(monthNumber)} must be between 1, 12.");
            }
            return PersianCulture.PersianMonthNames[monthNumber];
        }

          /// <summary>
        /// گرفتن نام فارسی روزهای هفته
        /// </summary>
        public static string GetPersianWeekDayName(this DateTime dt)
        {
            var dateParts = dt.ToPersianYearMonthDay();
            return PersianCulture.PersianDayWeekNames[new PersianCalendar().ToDateTime(dateParts.Year, dateParts.Month, dateParts.Day, dt.Hour, dt.Minute, dt.Second, 0).DayOfWeek];
        }

        /// <summary>
        /// گرفتن نام فارسی روزهای هفته
        /// </summary>
        public static string GetPersianWeekDayName(this DateTime? dt)
        {
            return dt == null ? string.Empty : GetPersianWeekDayName(dt.Value);
        }

        /// <summary>
        /// گرفتن نام فارسی روزهای هفته
        /// </summary>
        /// <param name="dt">تاریخ و زمان</param>
        /// <param name="dateTimeOffsetPart">کدام جزء این وهله مورد استفاده قرار گیرد؟</param>
        public static string GetPersianWeekDayName(this DateTimeOffset? dt, DateTimeOffsetPart dateTimeOffsetPart = DateTimeOffsetPart.IranLocalDateTime)
        {
            return dt == null ? string.Empty : GetPersianWeekDayName(dt.Value.GetDateTimeOffsetPart(dateTimeOffsetPart));
        }

        /// <summary>
        /// گرفتن نام فارسی روزهای هفته
        /// </summary>
        /// <param name="dt">تاریخ و زمان</param>
        /// <param name="dateTimeOffsetPart">کدام جزء این وهله مورد استفاده قرار گیرد؟</param>
        public static string GetPersianWeekDayName(this DateTimeOffset dt, DateTimeOffsetPart dateTimeOffsetPart = DateTimeOffsetPart.IranLocalDateTime)
        {
            return GetPersianWeekDayName(dt.GetDateTimeOffsetPart(dateTimeOffsetPart));
        }

        /// <summary>
        /// Returns the year part of this <see cref="DateTime"/> localized in Persian calendar.
        /// </summary>
        /// <param name="dateTime">The <see cref="DateTime"/> to extend.</param>
        /// <returns>An integer between 1 and 9999 representing the year part of this <see cref="DateTime"/>.</returns>
        public static int GetPersianYear(this DateTime dateTime)
        {
            return PersianCulture.Instance.DateTimeFormat.Calendar.GetYear(dateTime);
        }

        /// <summary>
        /// تاریخ روزهای ابتدا و انتهای سال شمسی را بازگشت می‌دهد
        /// </summary>
        public static PersianYear GetPersianYearStartAndEndDates(this int persianYear)
        {
            var persianCalendar = new PersianCalendar();
            return new PersianYear
            {
                StartDate = persianCalendar.ToDateTime(persianYear, 1, 1, 0, 0, 0, 0),
                EndDate = persianCalendar.ToDateTime(persianYear, 12, persianYear.GetPersianMonthLastDay(12), 23, 59, 59, 0)
            };
        }

        /// <summary>
        /// سال شمسی معادل را محاسبه کرده و سپس
        /// تاریخ روزهای ابتدا و انتهای آن سال شمسی را بازگشت می‌دهد
        /// </summary>
        public static PersianYear GetPersianYearStartAndEndDates(this DateTime dateTime)
        {
            var persianYear = dateTime.GetPersianYear();
            return persianYear.GetPersianYearStartAndEndDates();
        }

        /// <summary>
        /// سال شمسی معادل را محاسبه کرده و سپس
        /// تاریخ روزهای ابتدا و انتهای آن سال شمسی را بازگشت می‌دهد
        /// </summary>
        public static PersianYear GetPersianYearStartAndEndDates(this DateTimeOffset dateTimeOffset, DateTimeOffsetPart dateTimeOffsetPart = DateTimeOffsetPart.IranLocalDateTime)
        {
            var persianYear = dateTimeOffset.GetDateTimeOffsetPart(dateTimeOffsetPart).GetPersianYear();
            return persianYear.GetPersianYearStartAndEndDates();
        }

        /// <summary>
        /// تاریخ روزهای ابتدا و انتهای ماه شمسی را بازگشت می‌دهد
        /// </summary>
        public static PersianMonth GetPersianMonthStartAndEndDates(this int persianYear, int persianMonth)
        {
            var persianCalendar = new PersianCalendar();
            var isLeapYear = persianCalendar.IsLeapYear(persianYear);
            return new PersianMonth
            {
                StartDate = persianCalendar.ToDateTime(persianYear, persianMonth, 1, 0, 0, 0, 0),
                EndDate = persianCalendar.ToDateTime(persianYear, persianMonth, persianYear.GetPersianMonthLastDay(persianMonth), 23, 59, 59, 0)
            };
        }

        /// <summary>
        /// ماه شمسی معادل را محاسبه کرده و سپس
        /// تاریخ روزهای ابتدا و انتهای آن ماه شمسی را بازگشت می‌دهد
        /// </summary>
        public static PersianMonth GetPersianMonthStartAndEndDates(this DateTime dateTime)
        {
            var persianYear = dateTime.GetPersianYear();
            var persianMonth = dateTime.GetPersianMonth();
            return persianYear.GetPersianMonthStartAndEndDates(persianMonth);
        }

        /// <summary>
        /// ماه شمسی معادل را محاسبه کرده و سپس
        /// تاریخ روزهای ابتدا و انتهای آن ماه شمسی را بازگشت می‌دهد
        /// </summary>
        public static PersianMonth GetPersianMonthStartAndEndDates(this DateTimeOffset dateTimeOffset, DateTimeOffsetPart dateTimeOffsetPart = DateTimeOffsetPart.IranLocalDateTime)
        {
            var dateTime = dateTimeOffset.GetDateTimeOffsetPart(dateTimeOffsetPart);
            var persianYear = dateTime.GetPersianYear();
            var persianMonth = dateTime.GetPersianMonth();
            return persianYear.GetPersianMonthStartAndEndDates(persianMonth);
        }

        /// <summary>
        /// شماره آخرین روز ماه شمسی را بر می‌گرداند
        /// </summary>
        /// <param name="persianYear">سال شمسی</param>
        /// <param name="persianMonth">ماه شمسی</param>
        /// <returns>شماره آخرین روز ماه</returns>
        public static int GetPersianMonthLastDay(this int persianYear, int persianMonth)
        {
            if (persianMonth > 12 || persianMonth <= 0)
            {
                throw new ArgumentOutOfRangeException("ماه وارد شده معتبر نیست.");
            }

            if (persianMonth <= 6)
            {
                return 31;
            }

            if (persianMonth == 12)
            {
                var persianCalendar = new PersianCalendar();
                return persianCalendar.IsLeapYear(persianYear) ? 30 : 29;
            }
            return 30;
        }

        /// <summary>
        /// دریافت معادل فارسی نام روز هفته‌ی میلادی
        /// </summary>
        public static string GetPersianWeekDayName(this DayOfWeek dayOfWeek)
        {
            return PersianCulture.PersianDayWeekNames[dayOfWeek];
        }
    }
}
