using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace WpfValueConversion
{
    public class ValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            bool isenable = true;
            if (string.IsNullOrEmpty(value.ToString()))
            {
                isenable = false;
            }
            return isenable;
        }
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class CheckBoxCheckConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value.ToString().ToUpper() == "MARRIED")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            bool married = System.Convert.ToBoolean(value);
            if (married == true)
                return "Married";
            else
                return "Unmarried";
        }
    }

    // Convert string to a color
    public class ColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value == null) return new SolidColorBrush(Color.FromRgb(0, 0, 0));

            if (value.ToString().ToUpper() == "RED")
            {
                return new SolidColorBrush(Color.FromRgb(255, 0, 0));
            }
            else if (value.ToString().ToUpper() == "GREEN")
            {
                return new SolidColorBrush(Color.FromRgb(0, 255, 0));
            }
            else if (value.ToString().ToUpper() == "BLUE")
            {
                return new SolidColorBrush(Color.FromRgb(0, 0, 255));
            }
            else
            {
                return new SolidColorBrush(Color.FromRgb(0, 0, 0));
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return null;
        }
    }

    // Convert string to an image
    public class ImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            string imgName = "yellow.png";

            Uri resourceUri;

            if (value != null)
            {

                if (value.ToString().ToUpper() == "RED")
                {
                    imgName = "red.png";
                }
                else if (value.ToString().ToUpper() == "GREEN")
                {
                    imgName = "green.png";
                }
                else if (value.ToString().ToUpper() == "BLUE")
                {
                    imgName = "blue.png";
                }
            }
        
             resourceUri = new Uri(string.Format("/Images/{0}", imgName), UriKind.Relative);

            return new BitmapImage(resourceUri);
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return null;
        }
    }


}
