using System.Globalization;

namespace Goals.Converters;

public class StatusColorConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        return value?.ToString() switch
        {
            "To do" => Color.FromArgb("#6B7280"),
            "In progress" => Color.FromArgb("#3B82F6"),
            "Done" => Color.FromArgb("#10B981"),
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
            "High" => Color.FromArgb("#EF4444"),
            "Medium" => Color.FromArgb("#FACC15"),
            "Low" => Color.FromArgb("#10B981"),
            _ => Color.FromArgb("#6B7280")
        };
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
