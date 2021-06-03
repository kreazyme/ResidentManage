using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBLnh2.DAL;

namespace PBLnh2.BLL
{
    class BLL_Chuho
    {
        private static BLL_Chuho _Instance;
        public static BLL_Chuho Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_Chuho();
                }
                return _Instance;
            }
            private set { }
        }
        public string GetQhbyID(int m)
        {
            PBLEntities context = new PBLEntities();
            return context.QHChuhoes.Find(m).TenQuanhe;
        }
        public void AddQH(DAL.QHChuho qh)
        {
            PBLEntities context = new PBLEntities();
            context.QHChuhoes.Add(qh);
            context.SaveChanges();
        }
    }
}
