using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PBLnh2.DAL;
using System.Threading.Tasks;

namespace PBLnh2.BLL
{
    class BLL_DSHokhau
    {
        private static BLL_DSHokhau _Instance;
        public static BLL_DSHokhau Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_DSHokhau();
                }
                return _Instance;
            }
            private set { }
        }
        public List<DSHoKhau> GetHKbySHK(int _id)
        {
            using (var context = new PBLEntities())
            {
                List<DSHoKhau> ls = (from r in context.DSHoKhaus where r.SoSHK == _id select r).ToList();
                return ls;
            }
        }
        public bool CheckChuho(int _SoSHK)
        {
            DSHoKhau ds = new DSHoKhau();
            using(var context = new PBLEntities())
            {
                ds = context.DSHoKhaus.Find(_SoSHK);
            }
            if(ds == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool ThemSHK(DSHoKhau ds)
        {
            try
            {
                PBLEntities context = new PBLEntities();
                context.DSHoKhaus.Add(ds);
                context.SaveChanges();
                return true;
            }
            catch(Exception e)
            { 
                return false;
            }
        }
        public void DelSHK(int _SoSHK)
        {
            PBLEntities context = new PBLEntities();
            DSHoKhau ds = context.DSHoKhaus.Find(_SoSHK);
            context.DSHoKhaus.Remove(ds);
            context.SaveChanges();
        }
    }
}
