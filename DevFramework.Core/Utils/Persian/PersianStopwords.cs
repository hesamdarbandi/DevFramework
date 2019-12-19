using System;
using System.Collections.Generic;

namespace DevFramework.Core.Infrastructure.Utils.Persian
{
    /// <summary>
    /// A collection of Persian stopwords
    /// </summary>
    public static class PersianStopwords
    {
        /// <summary>
        /// A collection of Persian stopwords
        /// Source: https://github.com/ziaa/Persian-stopwords-collection
        /// </summary>
        public static readonly ISet<string> List = new HashSet<string>(new[]
            {
                "ـ",
                "-",
                "!",
                "\"",
                "#",
                "(",
                ")",
                "*",
                ".",
                "...",
                "....",
                "/",
                ":",
                "[",
                "]",
                "،",
                "؛",
                "؟",
                "«",
                "»",
                "…",
                "ا",
                "ابتدا",
                "اتفاقا",
                "اثر",
                "اثرِ",
                "اجرا",
                "اجراست",
                "احتراما",
                "احتمالا",
                "احیاناً",
                "اخیر",
                "اخیراً",
                "اری",
                "از",
                "از آن پس",
                "از جمله",
                "ازاین رو",
                "ازجمله",
                "ازش",
                "اساسا",
                "اساساً",
                "است",
                "استفاد",
                "استفاده",
                "اسلامی اند",
                "اش",
                "اشتباها",
                "اشکارا",
                "اصلا",
                "اصلاً",
                "اصولا",
                "اصولاً",
                "اعلام",
                "اغلب",
                "افراد",
                "افرادی",
                "افزود",
                "افسوس",
                "اقل",
                "اقلیت",
                "اکثر",
                "اکثرا",
                "اکثراً",
                "اکثریت",
                "اکنون",
                "اگر",
                "اگر چه",
                "اگرچه",
                "اگه",
                "الا",
                "الان",
                "البته",
                "البتّه",
                "الهی",
                "الی",
                "ام",
                "اما",
                "امر",
                "امروز",
                "امروزه",
                "امسال",
                "امشب",
                "امکان",
                "امور",
                "امیدوارم",
                "امیدوارند",
                "امیدواریم",
                "ان",
                "ان شاأالله",
                "انجام",
                "انچنان",
                "اند",
                "اندکی",
                "انشاالله",
                "انصافا",
                "انطور",
                "انقدر",
                "انکه",
                "انگار",
                "انها",
                "او",
                "اوست",
                "اول",
                "اولا",
                "اولاً",
                "اولین",
                "اون",
                "ای",
                "ایا",
                "اید",
                "ایشان",
                "ایم",
                "این",
                "این جوری",
                "این قدر",
                "این گونه",
                "اینان",
                "اینجا",
                "اینجاست",
                "اینچنین",
                "ایند",
                "اینطور",
                "اینقدر",
                "اینک",
                "اینکه",
                "اینگونه",
                "اینو",
                "اینها",
                "اینهاست",
                "آاو و و و",
                "آباد",
                "آخ",
                "آخر",
                "آخرها",
                "آخرین",
                "آخه",
                "آدمهاست",
                "آرام",
                "آرام آرام",
                "آره",
                "آری",
                "آزادانه",
                "آسان",
                "آسیب پذیرند",
                "آشکارا",
                "آشنایند",
                "آقا",
                "آقای",
                "آقایان",
                "آمد",
                "آمدن",
                "آمده",
                "آمده است",
                "آمرانه",
                "آن",
                "آن گاه",
                "آن ها",
                "آنان",
                "آنانی",
                "آنجا",
                "آنچنان",
                "آنچنان که",
                "آنچه",
                "آنرا",
                "آنطور",
                "آنقدر",
                "آنکه",
                "آنگاه",
                "آنها",
                "آنهاست",
                "آور",
                "آورد",
                "آوردن",
                "آورده",
                "آوری",
                "آوه",
                "آهان",
                "آهای",
                "آی",
                "آیا",
                "آید",
                "آیند",
                "ب",
                "با",
                "بااین حال",
                "بااین وجود",
                "بار",
                "بارة",
                "باره",
                "بارها",
                "باز",
                "باز هم",
                "بازهم",
                "بازی کنان",
                "بازیگوشانه",
                "باش",
                "باشد",
                "باشم",
                "باشند",
                "باشی",
                "باشید",
                "باشیم",
                "باعث",
                "بالا",
                "بالاخره",
                "بالاخص",
                "بالاست",
                "بالای",
                "بالایِ",
                "بالطبع",
                "بالعکس",
                "باوجودی که",
                "باورند",
                "باید",
                "بپا",
                "بتدریج",
                "بتوان",
                "بتواند",
                "بتوانی",
                "بتوانیم",
                "بجز",
                "بخش",
                "بخشه",
                "بخشی",
                "بخصوص",
                "بخواه",
                "بخواهد",
                "بخواهم",
                "بخواهند",
                "بخواهی",
                "بخواهید",
                "بخواهیم",
                "بخوبی",
                "بد",
                "بدان",
                "بدانجا",
                "بدانها",
                "بدون",
                "بدهید",
                "بدین",
                "بدین ترتیب",
                "بدینجا",
                "بر",
                "برا",
                "برابر",
                "برابرِ",
                "براحتی",
                "براساس",
                "براستی",
                "برای",
                "برایِ",
                "برایت",
                "برایش",
                "برایشان",
                "برایم",
                "برایمان",
                "برآنند",
                "برخوردار",
                "برخوردارند",
                "برخی",
                "برداری",
                "برعکس",
                "برنامه سازهاست",
                "بروز",
                "بروشنی",
                "بزرگ",
                "بزودی",
                "بس",
                "بسا",
                "بسادگی",
                "بسختی",
                "بسوی",
                "بسی",
                "بسیار",
                "بسیاری",
                "بشدت",
                "بطور",
                "بطوری که",
                "بعد",
                "بعد از این که",
                "بعدا",
                "بعداً",
                "بعدازظهر",
                "بعدها",
                "بعری",
                "بعضا",
                "بعضی",
                "بعضی شان",
                "بعضی ها",
                "بعضیهایشان",
                "بعلاوه",
                "بعید",
                "بفهمی نفهمی",
                "بکار",
                "بکن",
                "بکند",
                "بکنم",
                "بکنند",
                "بکنی",
                "بکنید",
                "بکنیم",
                "بگذاریم",
                "بگو",
                "بگوید",
                "بگویم",
                "بگویند",
                "بگویی",
                "بگویید",
                "بگوییم",
                "بگیر",
                "بگیرد",
                "بگیرم",
                "بگیرند",
                "بگیری",
                "بگیرید",
                "بگیریم",
                "بلافاصله",
                "بلکه",
                "بله",
                "بلی",
                "بماند",
                "بنابراین",
                "بندی",
                "بود",
                "بودم",
                "بودن",
                "بودند",
                "بوده",
                "بوده است",
                "بودی",
                "بودید",
                "بودیم",
                "بویژه",
                "به",
                "به آسانی",
                "به تازگی",
                "به تدریج",
                "به تمامی",
                "به جای",
                "به جز",
                "به خوبی",
                "به درشتی",
                "به دلخواه",
                "به راستی",
                "به رغم",
                "به روشنی",
                "به زودی",
                "به سادگی",
                "به سرعت",
                "به شان",
                "به شدت",
                "به طور کلی",
                "به طوری که",
                "به علاوه",
                "به قدری",
                "به کرات",
                "به گرمی",
                "به مراتب",
                "به ناچار",
                "به وضوح",
                "به ویژه",
                "به هرحال",
                "به هیچ وجه",
                "بهت",
                "بهتر",
                "بهترین",
                "بهش",
                "بی",
                "بی اطلاعند",
                "بی آنکه",
                "بی تردید",
                "بی تفاوتند",
                "بی نیازمندانه",
                "بی هدف",
                "بیا",
                "بیاب",
                "بیابد",
                "بیابم",
                "بیابند",
                "بیابی",
                "بیابید",
                "بیابیم",
                "بیان",
                "بیاور",
                "بیاورد",
                "بیاورم",
                "بیاورند",
                "بیاوری",
                "بیاورید",
                "بیاوریم",
                "بیاید",
                "بیایم",
                "بیایند",
                "بیایی",
                "بیایید",
                "بیاییم",
                "بیرون",
                "بیرونِ",
                "بیست",
                "بیش",
                "بیشتر",
                "بیشتری",
                "بیگمان",
                "بین",
                "پ",
                "پارسال",
                "پارسایانه",
                "پاره ای",
                "پاعینِ",
                "پایین ترند",
                "پخش",
                "پدرانه",
                "پدیده هاست",
                "پر",
                "پرسان",
                "پروردگارا",
                "پریروز",
                "پس",
                "پس از",
                "پس فردا",
                "پشت",
                "پشتوانه اند",
                "پشیمونی",
                "پنج",
                "پهن شده",
                "پی",
                "پی درپی",
                "پیدا",
                "پیداست",
                "پیرامون",
                "پیش",
                "پیشِ",
                "پیشاپیش",
                "پیشتر",
                "پیوسته",
                "ت",
                "تا",
                "تازه",
                "تاکنون",
                "تان",
                "تبدیل",
                "تحت",
                "تحریم هاست",
                "تر",
                "تر  براساس",
                "ترتیب",
                "ترین",
                "تصریحاً",
                "تعداد",
                "تعدادی",
                "تعمدا",
                "تعیین",
                "تغییر",
                "تقریبا",
                "تقریباً",
                "تک تک",
                "تلویحا",
                "تلویحاً",
                "تمام",
                "تمام قد",
                "تماما",
                "تمامشان",
                "تمامی",
                "تند تند",
                "تنها",
                "تو",
                "توان",
                "تواند",
                "توانست",
                "توانستم",
                "توانستن",
                "توانستند",
                "توانسته",
                "توانستی",
                "توانستیم",
                "توانم",
                "توانند",
                "توانی",
                "توانید",
                "توانیم",
                "توسط",
                "تولِ",
                "توؤماً",
                "توی",
                "تویِ",
                "تهیه",
                "ث",
                "ثالثاً",
                "ثانیا",
                "ثانیاً",
                "ج",
                "جا",
                "جاری",
                "جای",
                "جایی",
                "جدا",
                "جداً",
                "جداگانه",
                "جدی",
                "جدید",
                "جدیدا",
                "جرمزاست",
                "جریان",
                "جز",
                "جلو",
                "جلوگیری",
                "جلوی",
                "جلویِ",
                "جمع",
                "جمع اند",
                "جمعا",
                "جمعی",
                "جنابعالی",
                "جناح",
                "جنس اند",
                "جور",
                "جهت",
                "چ",
                "چاپلوسانه",
                "چت",
                "چته",
                "چرا",
                "چرا که",
                "چشم بسته",
                "چطور",
                "چقدر",
                "چکار",
                "چگونه",
                "چنان",
                "چنانچه",
                "چنانکه",
                "چند",
                "چند روزه",
                "چندان",
                "چنده",
                "چندین",
                "چنین",
                "چو",
                "چون",
                "چه",
                "چه بسا",
                "چه طور",
                "چهار",
                "چهارم",
                "چی",
                "چیز",
                "چیزهاست",
                "چیزی",
                "چیزیست",
                "چیست",
                "چیه",
                "ح",
                "حاشیه ای",
                "حاضر",
                "حاضرم",
                "حاکیست",
                "حال",
                "حالا",
                "حالی",
                "حتما",
                "حتماً",
                "حتی",
                "حد",
                "حداقل",
                "حداکثر",
                "حدود",
                "حدودِ",
                "حدودا",
                "حسابگرانه",
                "حضرتعالی",
                "حق",
                "حقیرانه",
                "حقیقتا",
                "حکماً",
                "حل",
                "حول",
                "خ",
                "خارجِ",
                "خاص",
                "خاطرنشان",
                "خالصانه",
                "خب",
                "خداحافظ",
                "خداست",
                "خدمات",
                "خسته ای",
                "خصوص",
                "خصوصا",
                "خصوصاً",
                "خطر",
                "خلاصه",
                "خواست",
                "خواستم",
                "خواستن",
                "خواستند",
                "خواسته",
                "خواستی",
                "خواستید",
                "خواستیم",
                "خواه",
                "خواهد",
                "خواهد بود",
                "خواهد شد",
                "خواهد کرد",
                "خواهم",
                "خواهند",
                "خواهی",
                "خواهید",
                "خواهیم",
                "خوب",
                "خوبی",
                "خود",
                "خود به خود",
                "خودبه خودی",
                "خودت",
                "خودتان",
                "خودتو",
                "خودش",
                "خودشان",
                "خودم",
                "خودمان",
                "خودمو",
                "خوش",
                "خوشبختانه",
                "خویش",
                "خویشتن",
                "خویشتنم",
                "خیاه",
                "خیر",
                "خیره",
                "خیلی",
                "د",
                "دا",
                "داام",
                "دااما",
                "داخل",
                "داد",
                "دادم",
                "دادن",
                "دادند",
                "داده",
                "داده است",
                "دادی",
                "دادید",
                "دادیم",
                "دار",
                "داراست",
                "دارای",
                "دارد",
                "دارم",
                "دارند",
                "داری",
                "دارید",
                "داریم",
                "داشت",
                "داشتم",
                "داشتن",
                "داشتند",
                "داشته",
                "داشته است",
                "داشته باشد",
                "داشته باشند",
                "داشتی",
                "داشتید",
                "داشتیم",
                "دامم",
                "دانست",
                "دانند",
                "دایم",
                "دایما",
                "دچار",
                "در",
                "در باره",
                "در بارهٌ",
                "در ثانی",
                "در کل",
                "در کنار",
                "در مجموع",
                "در نهایت",
                "در واقع",
                "دراین میان",
                "درباره",
                "درحالی که",
                "درحالیکه",
                "درست",
                "درست و حسابی",
                "درسته",
                "درصورتی که",
                "درعین حال",
                "درمجموع",
                "درواقع",
                "درون",
                "دریغ",
                "دریغا",
                "درین",
                "دسته",
                "دسته دسته",
                "دشمنیم",
                "دقیقا",
                "دم",
                "دنبالِ",
                "دو",
                "دو روزه",
                "دوباره",
                "دور",
                "دوم",
                "ده",
                "دهد",
                "دهم",
                "دهند",
                "دهه",
                "دهی",
                "دهید",
                "دهیم",
                "دیده",
                "دیر",
                "دیرت",
                "دیرم",
                "دیروز",
                "دیشب",
                "دیگر",
                "دیگران",
                "دیگری",
                "دیگه",
                "دیوانه ای",
                "دیوی",
                "ذ",
                "ذاتاً",
                "ر",
                "را",
                "راجع به",
                "راحت",
                "راسا",
                "راست",
                "راستی",
                "راه",
                "رسما",
                "رسید",
                "رسیدن",
                "رسیده",
                "رشته",
                "رشد",
                "رفت",
                "رفتارهاست",
                "رفته",
                "رنجند",
                "رو",
                "رواست",
                "روب",
                "روبروست",
                "روبه",
                "روز",
                "روز به روز",
                "روزانه",
                "روزه ای",
                "روزه ایم",
                "روزه ست",
                "روزه م",
                "روزهای",
                "روش",
                "روند",
                "روی",
                "رویِ",
                "رویش",
                "رهگشاست",
                "ریزی",
                "ز",
                "زاده",
                "زشتکارانند",
                "زمان",
                "زمانی",
                "زمینه",
                "زنند",
                "زود",
                "زودتر",
                "زهی",
                "زیاد",
                "زیاده",
                "زیادی",
                "زیر",
                "زیرِ",
                "زیرا",
                "زیرچشمی",
                "ژ",
                "س",
                "سابق",
                "ساخته",
                "ساده اند",
                "ساز",
                "سازی",
                "ساکنند",
                "سالانه",
                "سالته",
                "سالم تر",
                "ساله",
                "سالهاست",
                "سال‌های",
                "سالهای",
                "سالیانه",
                "سایر",
                "سبب",
                "سپس",
                "سخت",
                "سخته",
                "سر",
                "سراپا",
                "سراسر",
                "سرانجام",
                "سری",
                "سریِ",
                "سریع",
                "سریعا",
                "سریعاً",
                "سعی",
                "سمت",
                "سمتِ",
                "سوم",
                "سوی",
                "سویِ",
                "سه",
                "سه باره",
                "سهم",
                "سهواً",
                "سی",
                "سیاه چاله هاست",
                "سیخ",
                "ش",
                "شامل",
                "شان",
                "شاهدند",
                "شاهدیم",
                "شاید",
                "شبهاست",
                "شخصا",
                "شخصاً",
                "شخصی",
                "شد",
                "شدم",
                "شدن",
                "شدند",
                "شده",
                "شده است",
                "شده اند",
                "شده بود",
                "شدی",
                "شدید",
                "شدیدا",
                "شدیداً",
                "شدیم",
                "شروع",
                "شش",
                "شش  نداشته",
                "شما",
                "شمار",
                "شماری",
                "شماست",
                "شمایند",
                "شناسی",
                "شو",
                "شود",
                "شوراست",
                "شوقم",
                "شوم",
                "شوند",
                "شونده",
                "شوی",
                "شوید",
                "شویم",
                "شیرین",
                "شیرینه",
                "شیک",
                "ص",
                "صددرصد",
                "صرف",
                "صرفا",
                "صرفاً",
                "صریحاً",
                "صندوق هاست",
                "صورت",
                "ض",
                "ضدِّ",
                "ضمن",
                "ضمناً",
                "ط",
                "طبعا",
                "طبعاً",
                "طبق",
                "طبقِ",
                "طبیعتا",
                "طرف",
                "طریق",
                "طلبکارانه",
                "طور",
                "طول",
                "طی",
                "ظ",
                "ظاهرا",
                "ظاهراً",
                "ع",
                "عاجزانه",
                "عاقبت",
                "عالی",
                "عبارتند",
                "عجب",
                "عجولانه",
                "عدم",
                "عرفانی",
                "عقب",
                "عقبِ",
                "علاوه",
                "علاوه بر",
                "علاوه بر آن",
                "علاوه برآن",
                "علت",
                "علّتِ",
                "علناً",
                "علی الظاهر",
                "علی رغم",
                "علیرغم",
                "علیه",
                "عمدا",
                "عمداً",
                "عمدتا",
                "عمدتاً",
                "عمده",
                "عمل",
                "عملا",
                "عملاً",
                "عملی اند",
                "عموم",
                "عموما",
                "عموماً",
                "عنقریب",
                "عنوان",
                "عنوانِ",
                "عهده",
                "عین",
                "عیناً",
                "غ",
                "غالبا",
                "غزالان",
                "غیر",
                "غیرقانونی",
                "ف",
                "فاقد",
                "فبها",
                "فر",
                "فرد",
                "فردا",
                "فردی",
                "فعلا",
                "فعلاً",
                "فقط",
                "فکر",
                "فلان",
                "فلذا",
                "فوق",
                "ق",
                "قاالند",
                "قابل",
                "قاطبه",
                "قاطعانه",
                "قاعدتاً",
                "قانوناً",
                "قبل",
                "قبلا",
                "قبلاً",
                "قبلند",
                "قدر",
                "قدری",
                "قصدِ",
                "قضایاست",
                "قطعا",
                "قطعاً",
                "ک",
                "کارند",
                "کاش",
                "کاشکی",
                "کافی",
                "کامل",
                "کاملا",
                "کاملاً",
                "کتبا",
                "کجا",
                "کجاست",
                "کدام",
                "کرد",
                "کردم",
                "کردن",
                "کردند",
                "کرده",
                "کرده است",
                "کرده اند",
                "کرده بود",
                "کردی",
                "کردید",
                "کردیم",
                "کس",
                "کسانی",
                "کسی",
                "کل",
                "کلا",
                "کلی",
                "کلیشه هاست",
                "کلیه",
                "کم",
                "کم کم",
                "کمااینکه",
                "کماکان",
                "کمتر",
                "کمتره",
                "کمتری",
                "کمی",
                "کن",
                "کنار",
                "کنارِ",
                "کنارش",
                "کنایه ای",
                "کند",
                "کنم",
                "کنند",
                "کنندگان",
                "کننده",
                "کنون",
                "کنونی",
                "کنی",
                "کنید",
                "کنیم",
                "کو",
                "کوچک",
                "که",
                "کی",
                "کَی",
                "گ",
                "گاه",
                "گاهی",
                "گذاری",
                "گذاشته",
                "گذشته",
                "گرچه",
                "گردد",
                "گردند",
                "گرفت",
                "گرفتارند",
                "گرفتم",
                "گرفتن",
                "گرفتند",
                "گرفته",
                "گرفته است",
                "گرفتی",
                "گرفتید",
                "گرفتیم",
                "گروهی",
                "گفت",
                "گفتم",
                "گفتن",
                "گفتند",
                "گفته",
                "گفتی",
                "گفتید",
                "گفتیم",
                "گو",
                "گونه",
                "گوی",
                "گویا",
                "گوید",
                "گویم",
                "گویند",
                "گویی",
                "گویید",
                "گوییم",
                "گه",
                "گهگاه",
                "گیر",
                "گیرد",
                "گیرم",
                "گیرند",
                "گیری",
                "گیرید",
                "گیریم",
                "ل",
                "لااقل",
                "لاجرم",
                "لازم",
                "لب",
                "لحاظ",
                "لذا",
                "لزوماً",
                "لطفا",
                "لطفاً",
                "لیکن",
                "م",
                "ما",
                "مادامی",
                "ماست",
                "مامان مامان گویان",
                "مان",
                "مانند",
                "مانندِ",
                "مبادا",
                "متاسفانه",
                "متر",
                "متعاقبا",
                "متفاوت",
                "متفاوتند",
                "متؤسفانه",
                "مثل",
                "مثلِ",
                "مثلا",
                "مجانی",
                "مجبورند",
                "مجددا",
                "مجدداً",
                "مجموعا",
                "مجموعاً",
                "محتاجند",
                "محسوب",
                "محکم",
                "محکم تر",
                "مخالفند",
                "مختلف",
                "مخصوصاً",
                "مدام",
                "مدت",
                "مدتهاست",
                "مدّتی",
                "مذهبی اند",
                "مرا",
                "مربوط",
                "مرتب",
                "مردانه",
                "مردم",
                "مردم اند",
                "مرسی",
                "مستحضرید",
                "مستقیما",
                "مستند",
                "مسلما",
                "مشت",
                "مشترکاً",
                "مشخص",
                "مشغولند",
                "مطمانا",
                "مطمانم",
                "مطمینا",
                "مع الاسف",
                "مع ذلک",
                "معتقدم",
                "معتقدند",
                "معتقدیم",
                "معدود",
                "معذوریم",
                "معلومه",
                "معمولا",
                "معمولاً",
                "معمولی",
                "مغرضانه",
                "مفیدند",
                "مقابل",
                "مقدار",
                "مقصرند",
                "مقصری",
                "مکرر",
                "مکرراً",
                "مگر",
                "مگر این که",
                "مگر آن که",
                "ممکن",
                "ممیزیهاست",
                "من",
                "مناسب",
                "منتهی",
                "منطقی",
                "منظور",
                "منی",
                "مواجه",
                "مواجهند",
                "موارد",
                "موجب",
                "موجودند",
                "مورد",
                "موقتا",
                "مهم",
                "می",
                "می شود",
                "میان",
                "می‌آید",
                "می‌باشد",
                "می‌توان",
                "می‌تواند",
                "می‌توانند",
                "می‌خواهیم",
                "می‌داند",
                "می‌دهد",
                "می‌دهند",
                "می‌رسد",
                "می‌رود",
                "میزان",
                "می‌شد",
                "می‌شود",
                "می‌شوند",
                "می‌کرد",
                "می‌کردند",
                "می‌کند",
                "می‌کنم",
                "می‌کنند",
                "می‌کنیم",
                "می‌گوید",
                "می‌گویند",
                "می‌گیرد",
                "میلیارد",
                "میلیون",
                "می‌یابد",
                "ن",
                "ناامید",
                "ناخواسته",
                "ناراضی اند",
                "ناشی",
                "ناگاه",
                "ناگزیر",
                "ناگهان",
                "ناگهانی",
                "نام",
                "نباید",
                "نبش",
                "نبود",
                "نحوه",
                "نخست",
                "نخستین",
                "نخواهد",
                "نخواهم",
                "نخواهند",
                "نخواهی",
                "نخواهید",
                "نخواهیم",
                "نخودی",
                "ندارد",
                "ندارم",
                "ندارند",
                "نداری",
                "ندارید",
                "نداریم",
                "نداشت",
                "نداشتم",
                "نداشتند",
                "نداشته",
                "نداشتی",
                "نداشتید",
                "نداشتیم",
                "نزد",
                "نزدِ",
                "نزدیک",
                "نزدیکِ",
                "نسبت",
                "نسبتا",
                "نشان",
                "نشده",
                "نشست",
                "نظر",
                "نظیر",
                "نفرند",
                "نکرده",
                "نگاه",
                "نماید",
                "نموده",
                "نمی",
                "نمی‌شود",
                "نمی‌کند",
                "نوع",
                "نوعاً",
                "نوعی",
                "نه",
                "نه تنها",
                "نهایتا",
                "نهایتاً",
                "نیاز",
                "نیازمندند",
                "نیز",
                "نیست",
                "نیستند",
                "نیمه",
                "نیمی",
                "و",
                "و لا غیر",
                "وابسته اند",
                "وارد",
                "واقعا",
                "واقعاً",
                "واقعی",
                "واقفند",
                "وای",
                "وجود",
                "وحشت زده",
                "وسطِ",
                "وضع",
                "وقتی",
                "وقتی که",
                "وقتیکه",
                "وگرنه",
                "وگو",
                "ولی",
                "وی",
                "ویا",
                "ویژه",
                "ه",
                "ّه",
                "ها",
                "های",
                "هایی",
                "هبچ",
                "هر",
                "هر از گاهی",
                "هر چند",
                "هر چند که",
                "هر چه",
                "هرچند",
                "هرچه",
                "هرکس",
                "هرگاه",
                "هرگز",
                "هزار",
                "هست",
                "هستم",
                "هستند",
                "هستی",
                "هستید",
                "هستیم",
                "هفت",
                "هق هق کنان",
                "هم",
                "هم اکنون",
                "هم اینک",
                "همان",
                "همان طور که",
                "همان گونه که",
                "همانند",
                "همانها",
                "همچنان",
                "همچنان که",
                "همچنین",
                "همچون",
                "همچین",
                "همدیگر",
                "همزمان",
                "همگان",
                "همگی",
                "همواره",
                "همه",
                "همهٌ",
                "همه اش",
                "همه روزه",
                "همه ساله",
                "همه شان",
                "همیشه",
                "همین",
                "همین که",
                "هنگام",
                "هنگامِ",
                "هنگامی",
                "هنگامی که",
                "هنوز",
                "هوی",
                "هی",
                "هیچ",
                "هیچ گاه",
                "هیچکدام",
                "هیچکس",
                "هیچگاه",
                "هیچگونه",
                "هیچی",
                "ی",
                "یا",
                "یاب",
                "یابد",
                "یابم",
                "یابند",
                "یابی",
                "یابید",
                "یابیم",
                "یارب",
                "یافت",
                "یافتم",
                "یافتن",
                "یافته",
                "یافته است",
                "یافتی",
                "یافتید",
                "یافتیم",
                "یعنی",
                "یقینا",
                "یقیناً",
                "یک",
                "یک جوری",
                "یک کم",
                "یک کمی",
                "یکدیگر",
                "یکریز",
                "یکسال",
                "یکی",
                "یواش یواش"
            }, StringComparer.OrdinalIgnoreCase);
    }
}