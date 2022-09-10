using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace BUS
{
    public class DoiMatKhau_BUS
    {
        DataContext db = new DataContext(DatabaseAccessNonEntity.connectionStringEntity);
        public bool KiemTraMatKhau(int id, string pass)
        {
            var mk = db.USERs.Where(x => x.ID_User == id && x.matKhau == pass).FirstOrDefault();
            if (mk != null)
                return true;
            else
                return false;
        }
        public void DoiMatKhau(int id, string pass)
        {
            USER u = db.USERs.Single(x => x.ID_User == id);
            u.matKhau = pass;
            db.SaveChanges();
        }
    }
}
