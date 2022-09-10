using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace BUS
{
    public class DangNhap_BUS
    {
        public bool DangNhap(string tk, string mk)
        {
            using (DataContext db = new DataContext(DatabaseAccessNonEntity.connectionStringEntity))
            {
                var model = db.USERs.Where(c => c.taiKhoan == tk && c.matKhau == mk).FirstOrDefault();
                if (model != null)
                {
                    SessionLogin_BUS.taiKhoan = model.taiKhoan;
                    SessionLogin_BUS.idRoles = model.role;
                    SessionLogin_BUS.idUser = model.ID_User;
                    var getRoleName = db.ROLEs.Where(x => x.ID_Role == model.role).Select(x => x.tenRole);
                    SessionLogin_BUS.roleName = getRoleName.FirstOrDefault().ToString();
                    return true;
                }
                else
                    return false;
            }
        }
    }
}
