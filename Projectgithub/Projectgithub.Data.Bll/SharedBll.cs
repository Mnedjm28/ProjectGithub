using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectgithub.Data.Bll
{
    public class SharedBll
    {
        public static AppDbContext Db = new AppDbContext("Server=(local);Database=TestDb;Trusted_Connection=Yes;");
    }
}
