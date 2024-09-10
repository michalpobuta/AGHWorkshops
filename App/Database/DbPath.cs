using App.Core.Database;

namespace App.Database
{
    public class DbPath : IPath
    {
        public string GetDatabasePath(string appName, string appDbFolder, string filename)
        {
            return Path.Combine(GetDatabaseFolder(appName, appDbFolder), filename);
        }

        public string GetDatabaseFolder(string appName, string appDbFolder)
        {
            return Path.Combine(FileSystem.Current.AppDataDirectory, appName, appDbFolder);

        }

        public void DeleteFile(string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }
    }
}
