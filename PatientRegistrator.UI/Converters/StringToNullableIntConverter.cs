namespace PatientRegistrator.UI.Converters
{
    using System;
    using System.Globalization;
    using System.Windows.Data;

    public class StringToNullableIntConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter,
                              CultureInfo culture)
        {
            int? d = (int?)value;
            if (d.HasValue)
                return d.Value.ToString(culture);
            else
                return String.Empty;
        }

        public object ConvertBack(object value, Type targetType,
                                  object parameter, CultureInfo culture)
        {
            string s = (string)value;
            if (String.IsNullOrEmpty(s))
                return null;
            else
            {
                int result;
                return int.TryParse(s, out result)
                    ? (int?)result
                    : null;
            }
                
        }
    }
}