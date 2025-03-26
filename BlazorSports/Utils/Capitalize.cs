using System.Globalization;

namespace BlazorSports.Utils;

public static class Capitalize
{
    public static string ToTitle(this string s)
    {
        return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(
            string.Join(" ", s.Split('_')).ToLower());
    }
}