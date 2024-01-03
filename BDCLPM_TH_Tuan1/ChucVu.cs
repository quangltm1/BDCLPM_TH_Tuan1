using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDCLPM_TH_Tuan1
{
    public class ChucVu
    {
        private String tenChucVu;
        private String maChucVu;
        private float heSoChucVu;

        public ChucVu(String ten, String ma)
        {
            tenChucVu = ten;
            maChucVu = ma;
        }

        public string GetTenChucVu()
        {
            switch(maChucVu)
            {
                case "GD":
                    tenChucVu = "Giam Doc";
                    break;
                case "PGD":
                    tenChucVu = "Pho Giam Doc";
                    break;
                case "TP":
                    tenChucVu = "Truong Phong";
                    break;
                case "PP":
                    tenChucVu = "Pho Phong";
                    break;
                case "TT":
                    tenChucVu = "Thu Truong";
                    break;
                case "THP":
                    tenChucVu = "Thu Pho";
                    break;
                case "NV":
                    tenChucVu = "NhanVien";
                    break;
                case "":
                    tenChucVu = "";
                    break;
            }
            return tenChucVu;
        }

        public float GetHSChucVu()
        {
            switch (maChucVu)
            {
                case "GD":
                    return heSoChucVu = 10;
                case "PGD":
                    return heSoChucVu = 8;
                case "TP":
                    return heSoChucVu = 6;
                case "PP":
                    return heSoChucVu = 4.5f;
                case "TT":
                    return heSoChucVu = 3;
                case "THP":
                    return heSoChucVu = 1.5f;
                case "NV":
                    return heSoChucVu = 1;
                case "":
                    heSoChucVu = 0;
                    break;
            }
            return heSoChucVu;
        }
    }
}
