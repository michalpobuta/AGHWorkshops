
namespace App.Core.Database
{
    public interface IPath
    {

        protected const string APP_DB_FILENAME = "database.db";
        protected const string APP_NAME = "App";
        protected const string APP_DB_FOLDER = "Databases";

        string GetDatabasePath(string appName = APP_NAME, string appDbFolder = APP_DB_FOLDER, string filename = APP_DB_FILENAME);

        string GetDatabaseFolder(string appName = APP_NAME, string appDbFolder = APP_DB_FOLDER);

        void DeleteFile(string path);
    }
}
