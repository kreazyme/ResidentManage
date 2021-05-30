using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBLnh2.BLL
{
    class BLL_Login
    {
        private static BLL_Login _Instance;
        public static BLL_Login Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_Login();
                }
                return _Instance;
            }
            private set { }
        }
        public static Dangnhap GetUserbyID(string text)
        {
            int _id = Convert.ToInt32(text);
            using (var context = new PBLEntities())
            {
                var Userr = (from r in context.Dangnhaps where r.ID == _id select r).FirstOrDefault();
                return Userr;
            }
        }
        public static bool AddUser(Dangnhap dn)
        {
            try
            {
                PBLEntities context = new PBLEntities();
                context.Dangnhaps.Add(dn);
                context.SaveChanges();
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }
    }
}
