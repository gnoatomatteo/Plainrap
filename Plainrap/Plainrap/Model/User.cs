using SQLite;
using System;
using System.Collections.Generic;

namespace Plainrap.Model
{
    public class User
    {
        [PrimaryKey]
        public int ID { get; }
        private Credentials credentials;
        private Configuration configuration;
        private List<Article> articles;
        private String TYPE_USER { get; }

        private User(Configuration configuration, Credentials credentials)
        {
            this.credentials = credentials;
            this.configuration = configuration;
            this.TYPE_USER = "identified";
        }

        private User(Configuration configuration)
        {
            this.configuration = configuration;
            this.credentials = null;
            this.TYPE_USER = "unidentified";
        }

        public User() { }

    }
}
