using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace SendSMS.Utils
{
    public static class EnumExtensions
    {
        public static string GetDescription<T>(this T source)
        {
            FieldInfo fi = source.GetType().GetField(source.ToString());

            DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(
                typeof(DescriptionAttribute), false);

            if (attributes != null && attributes.Length > 0) return attributes[0].Description;
            else return source.ToString();
        }
        public static T GetEnum<T>(string description) where T : Enum
        {
            var type = typeof(T);

            if (!type.IsEnum)
                throw new ArgumentException();

            var field = type.GetFields().SelectMany(f => f.GetCustomAttributes(typeof(DescriptionAttribute), false), (f, a) => new { Field = f, Att = a })
                            .Where(a => ((DescriptionAttribute)a.Att)
                            .Description.Equals(description)).SingleOrDefault();

            return field == null ? default(T) : (T)field.Field.GetRawConstantValue();
        }
        public static T LikeGetEnum<T>(string description)
        {
            var credentials = Enum.GetValues(typeof(T));

            foreach (var credential in credentials)
            {
                if (GetDescription(credential).Contains(description))
                {
                    return (T)credential;
                }
            }

            return default;
        }
    }
}
