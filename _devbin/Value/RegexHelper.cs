using System.Text.RegularExpressions;

namespace svietnamAPI.Common.Helpers.Value
{
    public static class RegexHelper
    {
        public static string StandardizeFilename(string filename)
        {
            filename = Regex.Replace(filename, "[^a-zA-Z0-9_/-]+", "", RegexOptions.Compiled);
            return filename;
        }
    }
}