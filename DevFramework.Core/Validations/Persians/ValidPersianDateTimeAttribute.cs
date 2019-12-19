using System;
using System.ComponentModel.DataAnnotations;

namespace DevFramework.Core.Infrastructure.Validations
{
    /// <summary>
    /// Determines whether the specified value of the object is a valid PersianDateTime.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public sealed class ValidPersianDateTimeAttribute : ValidationAttribute
    {
        /// <summary>
        /// Determines whether the specified value of the object is valid.
        /// </summary>
        public override bool IsValid(object value)
        {
            if (value == null)
            {
                return true; // returning false, makes this field required.
            }
            return value.ToString().IsValidPersianDateTime();
        }
    }
}