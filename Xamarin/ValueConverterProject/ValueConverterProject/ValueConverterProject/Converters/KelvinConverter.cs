using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace ValueConverterProject.Converters
{
    public class KelvinConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double celcius = 0;
            bool converted = double.TryParse(((string)value), out celcius);
            return converted ? 273.15 + celcius : 273.15;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double kelvin = 0;
            bool converted = double.TryParse(((string)value), out kelvin);
            return converted ? kelvin- 273.15 : 273.15;
        }
    }
}
