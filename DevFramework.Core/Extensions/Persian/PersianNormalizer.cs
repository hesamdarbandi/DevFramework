using System;

namespace DevFramework.Core.Infrastructure.Extensions.Persian
{

     public static class PersianNormalizer
    {
        /// <summary>
        /// Persian Text Normalizer
        /// </summary>
        /// <param name="text"></param>
        /// <param name="normalizers"></param>
        /// <returns></returns>
        public static string NormalizePersianText(this string text, PersianNormalizers normalizers)
        {
            if (string.IsNullOrEmpty(text))
            {
                return string.Empty;
            }

            if (normalizers.HasFlag(PersianNormalizers.ApplyPersianNumbers))
            {
                text = text.ToPersianNumbers();
            }

            if (!text.ContainsFarsi())
            {
                return text;
            }

            if (normalizers.HasFlag(PersianNormalizers.RemoveDiacritics))
            {
                text = text.RemoveDiacritics();
            }

            if (normalizers.HasFlag(PersianNormalizers.ApplyPersianYeKe))
            {
                text = text.ApplyCorrectYeKe();
            }

            if (normalizers.HasFlag(PersianNormalizers.ApplyHalfSpaceRule))
            {
                text = text.ApplyHalfSpaceRule();
            }

            if (normalizers.HasFlag(PersianNormalizers.CleanupZwnj))
            {
                text = text.NormalizeZwnj();
            }

            if (normalizers.HasFlag(PersianNormalizers.FixDashes))
            {
                text = text.NormalizeDashes();
            }

            if (normalizers.HasFlag(PersianNormalizers.ConvertDotsToEllipsis))
            {
                text = text.NormalizeDotsToEllipsis();
            }

            if (normalizers.HasFlag(PersianNormalizers.ConvertEnglishQuotes))
            {
                text = text.NormalizeEnglishQuotes();
            }

            if (normalizers.HasFlag(PersianNormalizers.CleanupExtraMarks))
            {
                text = text.NormalizeExtraMarks();
            }

            if (normalizers.HasFlag(PersianNormalizers.RemoveAllKashida))
            {
                text = text.NormalizeAllKashida();
            }

            if (normalizers.HasFlag(PersianNormalizers.CleanupSpacingAndLineBreaks))
            {
                text = text.NormalizeSpacingAndLineBreaks();
            }

            if (normalizers.HasFlag(PersianNormalizers.RemoveOutsideInsideSpacing))
            {
                text = text.NormalizeOutsideInsideSpacing();
            }

            if (normalizers.HasFlag(PersianNormalizers.RemoveHexadecimalSymbols))
            {
                text = text.RemoveHexadecimalSymbols();
            }

            return text;
        }
    }

    /// <summary>
    /// Persian Text Normalizers
    /// </summary>
    [Flags]
    public enum PersianNormalizers : long
    {
        /// <summary>
        /// None
        /// </summary>
        None = 0,

        /// <summary>
        /// Fixes common writing mistakes caused by using a bad keyboard layout,
        /// such as replacing Arabic Ye with Persian one and so on ...
        /// </summary>
        ApplyPersianYeKe = 1 << 0,

        /// <summary>
        /// ما می توانیم --> ما می‌توانیم
        /// </summary>
        ApplyHalfSpaceRule = 1 << 1,

        /// <summary>
        /// Removes unnecessary zwnj char that are succeeded/preceded by a space
        /// </summary>
        CleanupZwnj = 1 << 2,

        /// <summary>
        /// آزمون--- to آزمون—
        /// </summary>
        FixDashes = 1 << 3,

        /// <summary>
        /// آزمون.... to آزمون…
        /// </summary>
        ConvertDotsToEllipsis = 1 << 4,

        /// <summary>
        /// 'تست' to «تست»
        /// </summary>
        ConvertEnglishQuotes = 1 << 5,

        /// <summary>
        /// Replaces more than one ! or ? mark with just one
        /// </summary>
        CleanupExtraMarks = 1 << 6,

        /// <summary>
        /// سلامـــت to سلامت
        /// </summary>
        RemoveAllKashida = 1 << 7,

        /// <summary>
        /// Replaces more than one space or line break with just a single one
        /// </summary>
        CleanupSpacingAndLineBreaks = 1 << 8,

        /// <summary>
        /// Fixes outside and inside spacing for () [] {}  “” «»
        /// </summary>
        RemoveOutsideInsideSpacing = 1 << 9,

        /// <summary>
        /// Converts English digits of a given number to their equivalent Persian digits
        /// </summary>
        ApplyPersianNumbers = 1 << 10,

        /// <summary>
        /// حذف اعراب از حروف و کلمات
        /// </summary>
        RemoveDiacritics = 1 << 11,

        /// <summary>
        /// There are a lot of symbols which can't be in xml code.
        /// </summary>
        RemoveHexadecimalSymbols = 1 << 12
    }
}