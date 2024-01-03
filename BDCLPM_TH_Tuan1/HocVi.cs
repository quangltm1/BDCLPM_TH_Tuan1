using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDCLPM_TH_Tuan1
{
    public class HocVi
    {
        private float heSoHocVi;
        private String tenHocVi;
        private String maHV;

        public HocVi(String ma, String ten)
        {
            maHV = ma;
            tenHocVi = ten;
        }

        public string GetHocVi()
        {
            switch(maHV)
            {
                case "PTTH": 
                    tenHocVi ="Pho Thong Trung Hoc";
                        break;
                case "TC":
                    tenHocVi = "Trung Cap";
                    break;
                case "CD":
                    tenHocVi = "Cao Dang";
                    break;
                case "DH":
                    tenHocVi = "Dai Hoc";
                    break;
                case "SDH":
                    tenHocVi = "Sau Dai Hoc";
                    break;
                case "THS":
                    tenHocVi = "Thac Si";
                    break;
                case "TS":
                    tenHocVi = "Tien Si";
                    break;
                default : tenHocVi = "";
                    break;
            }
            return tenHocVi;
        }

        public float GetHSHocVi()
        {
            switch (tenHocVi)
            {
                case "PTTH":
                    return heSoHocVi= 3;
                case "TC":
                    return heSoHocVi = 4;
                case "CD":
                    return heSoHocVi = 5;
                case "DH":
                    return heSoHocVi = 6;
                case "SDH":
                    return heSoHocVi = 7;
                case "THS":
                    return heSoHocVi = 7;
                case "TS":
                    return heSoHocVi = 8.5f;
                default: heSoHocVi = 0;
                    break;
            }
            return heSoHocVi;
        }

       
    }
}
