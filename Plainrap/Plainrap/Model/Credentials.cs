using SQLite;
using System;

namespace Plainrap.Model
{
    public class Credentials
    {
        [PrimaryKey]
        private string username { get; }
        private string password { get; }

        public Credentials(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
    }
}
