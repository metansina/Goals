using System.Globalization;

namespace Goals.Converters;

public class StatusColorConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        return value?.ToString() switch
        {
            "To do" => Color.FromArgb("#78716C"),
            "In progress" => Color.FromArgb("#FB923C"),
            "Done" => Color.FromArgb("#15803D"),
            _ => Color.FromArgb("#6B7280")
        };
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}

public class PriorityColorConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        return value?.ToString() switch
        {
            "High" => Color.FromArgb("#FECACA"),
            "Medium" => Color.FromArgb("#FEF3C7"),
            "Low" => Color.FromArgb("#DCFCE7"),
            _ => Color.FromArgb("#6B7280")
        };
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
