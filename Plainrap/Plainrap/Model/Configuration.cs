using SQLite;

namespace Plainrap.Model
{
    class Configuration
    {
        private string name { get; set; }
        private string surname { get; set; }
        private Address address { get; set; }
        private string cellular { get; set; }
        private string telephone { get; set; }
        [PrimaryKey]
        private string email { get; set; }
        private string[] competences { get; }

        public Configuration(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }

        public void setAddress(Address address)
        {
            this.address = address;
        }

        public void addCompetences(string competence)
        {
            this.competences[competences.Length +1] = competence;
        }

    }
}
