using System;

namespace svietnamAPI.Common.Helpers.Value
{
    public static class GuidHepler
    {
        public static string GenerateGuid() {
            var guidString = Guid.NewGuid().ToString();
            return guidString;
        }
    }
}