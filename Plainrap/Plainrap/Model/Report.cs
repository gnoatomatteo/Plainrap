using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plainrap.Model
{
    public class Report
    {
        // data field
        [PrimaryKey]
        public int ID { get; }
        private Address otherAddress = null;
        private DateTime dateMaintenance;
        private int numberMaintenance;
        private DateTime[] scheduleMorning;
        private DateTime[] scheduleAfternoon;
        private float travelHours;
        private float mileage;
        private float motorway;
        private float parking;
        private float meals;
        private float overnightStay;
        private List<Article> articles;
        private DateTime dateEmission;

        // state information
        private static int CONCLUSO = 1;
        private static int NONCONCLUSO = 2;
        private static int APPROVATO = 3;
        private static int INMODIFICA = 4;

        private int state = 2; // NONCONCLUSO is default state


    }
}
