using Microsoft.UI.Xaml.Data;

namespace Repro.Converters
{
    public class BoolToVisibilityConverter : IValueConverter
    {
        public bool Invert { get; set; }

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if(value is null)
            {
                throw new InvalidOperationException("This should never happen!");
            }

            var boolValue = (bool)value;
            if (!Invert)
            {
                return boolValue ? Visibility.Visible : Visibility.Collapsed;
            }
            else
            {
                return boolValue ? Visibility.Collapsed : Visibility.Visible;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language) => throw new NotImplementedException();
    }
}
