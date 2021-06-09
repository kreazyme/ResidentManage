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
            int coun = 0;
            using(var context = new PBLEntities())
            {
                coun = (from r in context.QHChuhoes select r).Count();
            }
            if (m > coun || m < 1)
            {
                return "Khác";
            }
            using (var context = new PBLEntities())
            {
                return (from r in context.QHChuhoes where r.IDQuanhe == m select r.TenQuanhe).FirstOrDefault();
            }
        }
        public int GetIDbyName(string m)
        {
            int _idqh;
            try
            {
                using (var context = new PBLEntities())
                {
                    _idqh = (from r in context.QHChuhoes where r.TenQuanhe == m select r.IDQuanhe).First();
                }
            }
            catch (Exception ex)
            {
                using (var context = new PBLEntities())
                {
                    _idqh = (from r in context.QHChuhoes orderby r.IDQuanhe descending select r.IDQuanhe).First();
                }
                PBLEntities contet = new PBLEntities();
                QHChuho qh = new QHChuho();
                qh.IDQuanhe = _idqh + 1;
                qh.TenQuanhe = m;
                contet.QHChuhoes.Add(qh);
                return _idqh + 1;
            }
                return _idqh;      
        }
    }
}
