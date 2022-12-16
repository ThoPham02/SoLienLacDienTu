using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace Controller
{
    public class LoginController
    {
        Model.EF.SoLienLacDienTuEntities dbContext = new Model.EF.SoLienLacDienTuEntities();
        public int isLogin(string name, string password)
        {
            string adminPassword = "123456";

            if (name.ToLower().Equals("admin") && password.Equals(adminPassword))
            {
                Const.userID = "admin";
                return 0;
            }

            //check bang giao vien
            var user1 = from c in dbContext.giao_vien
                        where c.ma_gv.Equals(name) && c.pass.Equals(password)
                        select c;

            //check bang hoc sinh
            var user2 = from c in dbContext.hoc_sinh
                        where c.ma_hs.Equals(name) && c.pass.Equals(password)
                        select c;


            if (user1.ToList().Count > 0)
            {
                if(user1.ToList()[0].pass.Equals(password))
                {
                    Const.userID = name;
                    return 1;
                }
                return -1;
            }
            else if (user2.ToList().Count > 0)
            {
                if (user2.ToList()[0].pass.Equals(password))
                {
                    Const.userID = name;
                    return 2;
                }
                return -1;
            }
            else
            {
                return -1;
            }

        }
    }
}
