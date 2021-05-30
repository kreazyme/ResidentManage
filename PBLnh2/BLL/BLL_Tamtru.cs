using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBLnh2.BLL
{
    class BLL_Tamtru
    {
        private static BLL_Tamtru _Instance;
        public static BLL_Tamtru Instance
        {
            get
            {
                if(_Instance == null)
                {
                    _Instance = new BLL_Tamtru();
                }
                return _Instance;
            }
            private set { }
        }
        public Tamtru GetTamtrubyID(string m)
        {
            int _id = Convert.ToInt32(m);
            PBLEntities context = new PBLEntities();
            return context.Tamtrus.Find(_id);
        }
        public static void AddTamtru(Tamtru tt)
        {
            PBLEntities context = new PBLEntities();
            context.Tamtrus.Add(tt);
            context.SaveChanges();
        }
        public static void UpdateTamtru(Tamtru tt)
        {
            PBLEntities context = new PBLEntities();
            Tamtru temp = context.Tamtrus.Find(tt.CMND);
            temp.Noiden = tt.Noiden;
            temp.Noidi = tt.Noidi;
            temp.Ghichu = tt.Ghichu;
            temp.Thoigiandichuyen = tt.Thoigiandichuyen;
            context.SaveChanges();
        }
        public void DelTamtru(int cmnd)
        {
            //int cmnd = Convert.ToInt32(m);
            PBLEntities context = new PBLEntities();
            Tamtru tt = context.Tamtrus.Find(cmnd);
            context.Tamtrus.Remove(tt);
            context.SaveChanges();
        }
    }
}
