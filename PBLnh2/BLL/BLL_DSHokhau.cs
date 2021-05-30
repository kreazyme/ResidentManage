using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    }
}
