using System;
using Plainrap.App_Code;
using SQLite;
using System.IO;
using Plainrap.Droid.Connection;

[assembly: Xamarin.Forms.Dependency(typeof(SQLite_Android))]
namespace Plainrap.Droid.Connection
{
    public class SQLite_Android : ISQLite
    {
        public SQLite_Android() { }

        public SQLiteConnection GetConnection()
        {
            var sqliteFilename = "nomeDatabaseDaModificare"; // stringa da cambiare dopo l'implementazione del database
            string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal); // cartella dei documenti nel dispositivo
            string libraryPath = Path.Combine(documentsPath, ".." , "library"); // directory per la posizione del db
            var path = Path.Combine(libraryPath, sqliteFilename);

            // adesso che ho tutti i dati creo la connessione al database
            var conn = new SQLite.SQLiteConnection(path);
            return conn;
        }
    }
}