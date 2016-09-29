using System;
using Plainrap.App_Code;
using SQLite;
using Plainrap.iOS.Connection;
using System.IO;

[assembly: Xamarin.Forms.Dependency(typeof(SQLite_iOS))]
namespace Plainrap.iOS.Connection
{
    public class SQLite_iOS : ISQLite
    {
        public SQLite_iOS() { }

        public SQLiteConnection GetConnection()
        {
            var sqliteFilename = "nomeDatabaseDaModificare"; // stringa da cambiare dopo l'implementazione del database
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal); // cartella dei documenti nel dispositivo
            string libraryPath = Path.Combine(documentsPath, "..", "library"); // directory per la posizione del db, cambiare i .. con una directory da creare
            var path = Path.Combine(libraryPath, sqliteFilename);

            // adesso che ho tutti i dati creo la connessione al database
            var conn = new SQLite.SQLiteConnection(path);
            return conn;
        }
    }
}