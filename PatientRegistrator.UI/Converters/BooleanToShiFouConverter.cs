namespace PatientRegistrator.UI.Converters
{
    using System;
    using System.Globalization;
    using System.Windows.Data;

    public class BooleanToShiFouConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool? val = (bool?)value;

            if (val.HasValue)
            {
                return val.Value ? "是" : "否";
            }

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}