
namespace Maui.Apps.Framework.Converters
{
    //  kiểm tra xem một enumeration có chứa bất kỳ element nào hay không và chuyển đổi giá trị thành một boolean.
    public class EnumerationContainsElementConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) =>
            (value as IEnumerable<object>)?.Count() > 0;

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) =>
            throw new NotImplementedException();
    }
}
