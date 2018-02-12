namespace DevxTest
{
    public static class Filters
    {
        /// <summary>
        /// Arama kutucuğundan gelen veriyi Güvenlik açığı için temizler
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string FiltReplace(this string value)
        {
            return value.Trim().Replace("--", "").Replace("<", "").Replace(">", "");
        }
    }
}
