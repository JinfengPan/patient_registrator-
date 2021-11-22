namespace PatientRegistrator.UI.Converters
{
    using System;
    using System.Globalization;
    using System.Windows.Data;

    using PatientRegistrator.Model;

    public class GenderToNanNvConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Gender? val = (Gender?)value;

            if (val.HasValue)
            {
                return val.Value == Gender.Male ? "男" : "女";
            }

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}