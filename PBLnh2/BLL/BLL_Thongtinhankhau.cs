﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBLnh2.DAL;
using PBLnh2.BLL;
using System.Data.Entity;
//using System.Data.

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
            int cmnd = 0;
            try
            {
                cmnd= Convert.ToInt32(m);
            }
            catch (Exception)
            {
                return new Thongtinnhankhau();
            }
            using (var context = new PBLEntities())
            {
                var nk = (from r in context.Thongtinnhankhaus where r.CMND == cmnd select r).FirstOrDefault();
                return nk;
            }
        }
        public static bool AddNhankhau(Thongtinnhankhau nk)
        {
            PBLEntities context = new PBLEntities();
            bool isAddDShokhau = true;
            foreach(DSHoKhau i in context.DSHoKhaus.ToList())
            {
                if(i.SoSHK == nk.SoSHK)
                {
                    isAddDShokhau = false;
                    break;
                }
            }
            try
            {
                if(isAddDShokhau == true)
                {
                    DSHoKhau ds = new DSHoKhau(Convert.ToInt32(nk.SoSHK), nk.CMND.ToString());
                    BLL_DSHokhau.Instance.ThemSHK(ds);
                }
                context.Thongtinnhankhaus.Add(nk);
                context.SaveChanges();
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }
        public  List<Thongtinnhankhau> GetThongtinnhankhaus()
        {
            PBLEntities context = new PBLEntities();
            return context.Thongtinnhankhaus.ToList();
        }
        public  List<Thongtinnhankhau> GetNKbySHK(string m)
        {
            int _SHK = 0;
            try
            {
                _SHK = Convert.ToInt32(m);
            }
            catch(Exception e)
            {
                List<Thongtinnhankhau> ls = new List<Thongtinnhankhau>();
                return ls;
            }
            using (var context = new PBLEntities())
            {
                List<Thongtinnhankhau> ls = (from r in context.Thongtinnhankhaus where r.SoSHK == _SHK select r).ToList();
                return ls;
            }
        }
        public  List<Thongtinnhankhau> ListChuho()
        {
            using (var context = new PBLEntities())
            {
                List<Thongtinnhankhau> ls = (from r in context.Thongtinnhankhaus where r.IDQuanhe == 1 select r).ToList();
                return ls;
            }
        }
        public  List<Thongtinnhankhau> GetNKbyTen(string m)
        {
            PBLEntities context = new PBLEntities();
            List<Thongtinnhankhau> ls =  context.Thongtinnhankhaus.Where(r => r.Name.Contains(m)).ToList();
            return ls;
        }
        public  bool UpdateNK(Thongtinnhankhau nk)
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
                //tt.IDtamtru = nk.IDtamtru;
                tt.NgheNghiep = nk.NgheNghiep;
                tt.NguyenQuan = nk.NguyenQuan;
                tt.SoSHK = nk.SoSHK;
                tt.Name = nk.Name;
                tt.SDT = nk.SDT;
                context.SaveChanges();
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
            int _SoSHK = Convert.ToInt32(nk.SoSHK);
            context.Thongtinnhankhaus.Remove(nk);
            BLL_Tamtru.Instance.DelTamtru(cmnd);
            if ((from r in context.Thongtinnhankhaus where r.SoSHK == _SoSHK select r).Count() == 1)
            {
                Console.WriteLine(nk.SoSHK.ToString());
                BLL_DSHokhau.Instance.DelSHK(Convert.ToInt32(nk.SoSHK));
            }
            context.SaveChanges();
        }
        public  bool CheckCMND(int _cmnd)
        {
            PBLEntities context = new PBLEntities();
            Thongtinnhankhau nk = context.Thongtinnhankhaus.Find(_cmnd);
            if (nk == null)
            {
                return false;
            }
            else return true;
        }
        public List<Thongtinnhankhau> SortbyCMND()
        {
            using(var context = new PBLEntities())
            {
                return ((from r in context.Thongtinnhankhaus orderby r.CMND select r).ToList());
            }
        }
        public List<Thongtinnhankhau> SortbyAge()
        {
            using (var context = new PBLEntities())
            {
                return ((from r in context.Thongtinnhankhaus orderby r.dob.Value.Year select r).ToList());
            }
        }
        public List<Thongtinnhankhau> SortbyName()
        {
            using (var context = new PBLEntities())
            {
                return ((from r in context.Thongtinnhankhaus orderby r.Name select r).ToList());
            }
        }
        public int CounNK(int m)
        {
            PBLEntities context = new PBLEntities();
            int coun =  context.Thongtinnhankhaus.Where(r => r.SoSHK == m).Count();
            return coun;
        }
    }
}
