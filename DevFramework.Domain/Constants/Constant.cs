using System;
namespace DevFramework.Domain.Constants
{
    public class Constant
    {
        public const int DefaultCity = 1;
        public const int DefaultPageSize = 8;
        public const int DefaultPageIndex = 0;
        public const string LoginFailed = "نام کاربری و یا پسورد اشتباه می باشد";
        public const string NotFound = "موجود نیست و یا حذف شده است";
        public const string TryAgin = "لطفا مجدا تلاش فرمایید";

        public static string GetNotFoundException(string entityName)
        {
            return entityName + NotFound;
        }

        public static string GetRequiredMessage(string name)
        {
            return $"لطفا نام {name} را وارد نمایید";
        }

    }
}
