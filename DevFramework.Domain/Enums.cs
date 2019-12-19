using System;
using System.ComponentModel.DataAnnotations;

namespace DevFramework.Domain
{
    public class Enums
    {
        //public enum PaymentStatus
        //{
        //    Succeeded = 1,

        //    Failed = 5
        //}


        public enum OrderByes
        {
            New = 1,
            PriceAs = 2,
            PriceDs = 3
        }

        public enum ThemeTypes
        {
            [Display(Name = "پوسته اول")]
            Theme1 = 0,
            [Display(Name = "پوسته دوم")]
            Theme2 = 1
        }
        public enum ShipingTypes
        {
            [Display(Name = "ارسال رایگان")]
            Free = 1,
            [Display(Name = "ارسال پستی")]
            Post = 2,
            [Display(Name = "ارسال با پیک")]
            Peyk = 3
        }

        public enum IncomeStatus
        {
            [Display(Name = "درخواست")]
            New = 1,
            [Display(Name = "واریز")]
            Done = 2
        }
        public enum PaymentStatus
        {
            Succeeded = 1,

            Failed = 5
        }
        public enum OrderStatus
        {
            [Display(Name = "در انتظار پرداخت")]
            PendingPayment = 1,
            [Display(Name = "پرداخت ناموفق")]
            PaymentFailed = 2,
            [Display(Name = "در حال پردازش")]
            Processing = 3,
            [Display(Name = "ارسال شده")]
            Shipped = 4,
            [Display(Name = "تکمیل شده")]
            Complete = 5
        }
        public enum StoreTypes
        {
            [Display(Name = "دکوراسیون ")]
            Decor = 1,
            [Display(Name = "گل و گیاه")]
            Flower = 2,
            [Display(Name = "فرهنگی و هنری")]
            Culture = 3,
            [Display(Name = "مد و پوشاک")]
            Clothes = 4,
            [Display(Name = "سوپر مارکت")]
            Market = 5,
            [Display(Name = "سایر")]
            Other = 6
        }

        public enum Units
        {
            [Display(Name = "کیلو گرم")]
            Kilo = 1,
            [Display(Name = "گرم")]
            Gram = 2
        }
    }
}
