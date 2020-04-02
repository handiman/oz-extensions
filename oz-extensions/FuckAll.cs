using System;

namespace OzExtensions
{
    /// <summary>
    /// Sort of like String.IsNullOrEmpty but also works for numeric values. 0 is treated as fuck all.
    /// </summary>
    public static class FuckAll
    {
        public static bool IsFuckAll(this object value)
        {
            return null == value;
        }

        public static bool IsFuckAll(this string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }

        public static bool IsFuckAll(this Guid value)
        {
            return value.Equals(Guid.Empty);
        }

        public static bool IsFuckAll(this sbyte value)
        {
            return value.Equals(default);
        }

        public static bool IsFuckAll(this byte value)
        {
            return value.Equals(default);
        }

        public static bool IsFuckAll(this int value)
        {
            return value.Equals(default);
        }

        public static bool IsFuckAll(this uint value)
        {
            return value.Equals(default);
        }

        public static bool IsFuckAll(this short value)
        {
            return value.Equals(default);
        }

        public static bool IsFuckAll(this ushort value)
        {
            return value.Equals(default);
        }

        public static bool IsFuckAll(this long value)
        {
            return value.Equals(default);
        }

        public static bool IsFuckAll(this ulong value)
        {
            return value.Equals(default);
        }

        public static bool IsFuckAll(this float value)
        {
            return value.Equals(default);
        }

        public static bool IsFuckAll(this double value)
        {
            return value.Equals(default);
        }

        public static bool IsFuckAll(this decimal value)
        {
            return value.Equals(default);
        }

        public static bool IsFuckAll(this Guid? value)
        {
            return IsFuckAll(value.GetValueOrDefault());
        }

        public static bool IsFuckAll(this sbyte? value)
        {
            return IsFuckAll(value.GetValueOrDefault());
        }

        public static bool IsFuckAll(this byte? value)
        {
            return IsFuckAll(value.GetValueOrDefault());
        }

        public static bool IsFuckAll(this int? value)
        {
            return IsFuckAll(value.GetValueOrDefault());
        }

        public static bool IsFuckAll(this uint? value)
        {
            return IsFuckAll(value.GetValueOrDefault());
        }

        public static bool IsFuckAll(this short? value)
        {
            return IsFuckAll(value.GetValueOrDefault());
        }

        public static bool IsFuckAll(this ushort? value)
        {
            return IsFuckAll(value.GetValueOrDefault());
        }

        public static bool IsFuckAll(this long? value)
        {
            return IsFuckAll(value.GetValueOrDefault());
        }

        public static bool IsFuckAll(this ulong? value)
        {
            return IsFuckAll(value.GetValueOrDefault());
        }

        public static bool IsFuckAll(this float? value)
        {
            return IsFuckAll(value.GetValueOrDefault());
        }

        public static bool IsFuckAll(this double? value)
        {
            return IsFuckAll(value.GetValueOrDefault());
        }

        public static bool IsFuckAll(this decimal? value)
        {
            return IsFuckAll(value.GetValueOrDefault());
        }
    }
}
