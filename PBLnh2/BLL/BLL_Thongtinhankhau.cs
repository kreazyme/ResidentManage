using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBLnh2.BLL;

namespace PBLnh2.BLL
{
    class BLL_Thongtinhankhau
    {
        private static BLL_Thongtinhankhau _Instance;
        public static BLL_Thongtinhankhau Instance
        {
            get
            {
                if(_Instance == null)
                {
                    _Instance = new BLL_Thongtinhankhau();
                }
                return _Instance;
            }
            private set { }
        }
        public static Thongtinnhankhau GetTTNKbyCMND(string m)
        {
            int cmnd = Convert.ToInt32(m);
            using (var context = new PBLEntities())
            {
                var nk = (from r in context.Thongtinnhankhaus where r.CMND == cmnd select r).FirstOrDefault();
                return nk;
            }
        }
        public static bool AddNhankhau(Thongtinnhankhau nk)
        {
            try
            {
                PBLEntities context = new PBLEntities();
                context.Thongtinnhankhaus.Add(nk);
                context.SaveChanges();
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }
        public static List<Thongtinnhankhau> GetThongtinnhankhaus()
        {
            PBLEntities context = new PBLEntities();
            return context.Thongtinnhankhaus.ToList();
        }
        public static List<Thongtinnhankhau> GetNKbyChuho(string m)
        {
            int _idChuho = Convert.ToInt32(m);
            using (var context = new PBLEntities()){
                List<Thongtinnhankhau> ls = (from r in context.Thongtinnhankhaus where r.IDQuanhe == _idChuho select r).ToList();
                return ls;
            }
        }
        public static List<Thongtinnhankhau> GetNKbyTen(string m)
        {

        }
        public static bool UpdateNK(Thongtinnhankhau nk)
        {
            try
            {
                PBLEntities context = new PBLEntities();
                Thongtinnhankhau tt = context.Thongtinnhankhaus.Find(nk.CMND);
                tt.CMND = nk.CMND;
                tt.Dantoc = nk.Dantoc;
                tt.Diachi = nk.Diachi;
                tt.dob = nk.dob;
                tt.Gender = nk.Gender;
                tt.IDQuanhe = nk.IDQuanhe;
                tt.IDtamtru = nk.IDtamtru;
                tt.NgheNghiep = nk.NgheNghiep;
                tt.NguyenQuan = nk.NguyenQuan;
                tt.SoSHK = nk.SoSHK;
                tt.Name = nk.Name;
                tt.SDT = nk.SDT;
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }
        public void DelNK(int m)
        {
            PBLEntities context = new PBLEntities();
            int cmnd = Convert.ToInt32(m);
            Thongtinnhankhau nk = context.Thongtinnhankhaus.Find(cmnd);
            context.Thongtinnhankhaus.Remove(nk);
            BLL_Tamtru.Instance.DelTamtru(cmnd);
            context.SaveChanges();
        }
    }
}
