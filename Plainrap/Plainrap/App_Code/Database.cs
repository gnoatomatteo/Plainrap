using Plainrap.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace Plainrap.App_Code
{
    public class Database
    {
        private static object locker = new object();

        SQLiteConnection database;

        public Database()
        {
            database = DependencyService.Get<ISQLite>().GetConnection();
        }

        private string createDatabase(string path)
        {
            try
            {
                database.CreateTable<User>();
                database.CreateTable<Address>();
                database.CreateTable<Configuration>();
                database.CreateTable<Credentials>();
                database.CreateTable<Report>();
                database.CreateTable<Customer>();
                database.CreateTable<Article>();
                return "database created";
            } catch (SQLiteException ex)
            {
                return ex.Message;
            }
        }

        /// <summary>
        /// returns the user from the local database
        /// </summary>
        /// <returns>User</returns>
        public User getUser()
        {
            lock (locker)
            {
                return database.Find<User>(from i in database.Table<User>() select i);
            }
        }

        /// <summary>
        /// back customers from the local database
        /// </summary>
        /// <returns>List<Customer></returns>
        public IEnumerable<Customer> getCostumers()
        {
            lock (locker)
            {
                return (from i in database.Table<Customer>() select i).ToList();
            }
        }

        /// <summary>
        /// returns all reports from the local database
        /// </summary>
        /// <returns>List<Report></returns>
        public IEnumerable<Report> getReports()
        {
            lock (locker)
            {
                return (from i in database.Table<Report>() select i).ToList();
            }
        }

        /// <summary>
        /// returns all the items in the local database
        /// </summary>
        /// <returns>List<Article></returns>
        public IEnumerable<Article> getArticles()
        {
            return (from i in database.Table<Article>() select i).ToList();
        }

        /// <summary>
        /// Save a new report in local database
        /// </summary>
        /// <param name="report"></param>
        /// <returns>return the report ID</returns>
        public int SaveReport(Report report)
        {
            lock (locker)
            {
                if(report.ID != 0)
                {
                    database.Update(report);
                    return report.ID;
                }
                else
                {
                    return database.Insert(report);
                }
            }
        }

        /// <summary>
        /// save the user's changes 
        /// </summary>
        /// <param name="user"></param>
        /// <returns>return the user's ID</returns>
        public int saveUser(User user)
        {
            lock (locker)
            {
                if(user.ID != 0)
                {
                    database.Update(user);
                    return user.ID;
                }
                else
                {
                    return database.Insert(user);
                }
            }
        }
        


    }
}
