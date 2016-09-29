using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plainrap.App_Code
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
