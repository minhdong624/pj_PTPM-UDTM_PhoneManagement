using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Model;

namespace BUS
{
    public class DieuKienKiemTra_BUS
    {
        DataContext db ;
        //Kiểm tra tài khoản xem trùng không
        public bool KiemTraTaiKhoanUser(string str)
        {
            using (var db = new DataContext(DatabaseAccessNonEntity.GetConnectionStringEntity()))
            {
                var model = db.USERs.Where(c => c.taiKhoan == str).FirstOrDefault();
                if (model != null)
                    return true;
                else
                    return false;
            }
        }
        //Kiểm tra chứng minh nhân dân có trùng hay không
        public bool KiemTraCMND(string str)
        {
            using (var db = new DataContext(DatabaseAccessNonEntity.GetConnectionStringEntity()))
            {
                var model = db.KHACHHANGs.Where(c => c.SCMND == str).FirstOrDefault();
                if (model != null)
                    return true;
                else
                    return false;
            }
        }
        //Kiểm tra số điện thoại là số hay không
        public bool KiemTraSoDienThoai(string str)
        {
            if (str.All(char.IsDigit))
                return true;
            else
                return false;
        }
        //Hàm kiểm tra định dạng email
        public bool KiemTraEmail(string str)
        {
            string expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(str, expresion))
            {
                if (Regex.Replace(str, expresion, string.Empty).Length == 0)
                    return true;
                else
                    return false;
            }
            else
            {
                return false;
            }
        }
    }
}
