namespace Logger.Core.Utilities
{
    public static class FileValidator
    {
        public static bool PathExist(string path)
        {
            return Directory.Exists(path);
        }
    }
}
