
using System.Text.RegularExpressions;

namespace Maui.Apps.Framework.Extensions
{
    // "https://example.com/path/with/characters?param1=value1&param2=value2";
    // Output: https___example_com_path_with_characters_param1_value1_param2_value2
    public static class StringExtensions
    {
        public static string CleanCacheKey(this string uri) =>
       Regex.Replace((new Regex("[\\~#%&*{}/:<>?|\"-]")).Replace(uri, " "), @"\s+", "_");

    }
}
