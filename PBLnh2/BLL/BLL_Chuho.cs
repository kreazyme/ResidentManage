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
            using (var context = new PBLEntities())
            {
                return (from r in context.QHChuhoes where r.IDQuanhe == m select r.TenQuanhe).FirstOrDefault();
            }
        }
        public int GetIDbyName(string m)
        {
            int _idqh;
            using(var context = new PBLEntities())
            {
                _idqh = (from r in context.QHChuhoes where r.TenQuanhe == m select r.IDQuanhe).First();
            }
            if(_idqh == null)
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
            else
            {
                return _idqh;
            }
        }
    }
}
