using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDCLPM_TH_Tuan1
{
    public class NhanVien
    {
        private String maNhanVien;
        private String tenNhanVien;
        private int soNguoiPhuThuoc;
        private double tienLe;
        private double tet;
        private DateTime ngayVao;
        private HocVi hocVi;
        private ChucVu chucVu;
        private float LCB = 1800000;

        public NhanVien(String ma, String ten, DateTime ngay, HocVi hv, ChucVu cv,int nguoiphuthuoc)
        {
            maNhanVien = ma;
            tenNhanVien = ten;
            ngayVao = ngay;
            hocVi = hv;
            chucVu = cv;
            soNguoiPhuThuoc = nguoiphuthuoc;
        }

        public float GetHSThamNien()
        {
            DateTime homNay = DateTime.Now;
            int soNam = homNay.Year - ngayVao.Year;
            if (homNay.Month<ngayVao.Month)
                soNam --;
            return soNam*0.1f;
        }

        public double TinhLuong()
        {
            return (LCB * (hocVi.GetHSHocVi() + chucVu.GetHSChucVu() + GetHSThamNien()));
        }

        public double TinhBH()
        {
            return(TinhLuong() * 0.105);

        }

        public double TinhLuong1Ngay()
        {
            return (TinhLuong() / 22);
        }

        public double TinhLuong1Gio()
        {
            return (TinhLuong1Ngay() / 8);
        }

        public double TinhTienPhepKhongLuong(int soNgayNghi)
        {
            double tienConLai=0;
            if(soNgayNghi > 10)
            {
                tienConLai = TinhLuong() - 500000*soNgayNghi;
            }
            return (tienConLai = TinhLuong());
        }

        public double TinhThueTNCN()
        {
            double tienThue = TinhLuong() - 11000000 - TinhBH();

            if (soNguoiPhuThuoc > 0)
            {
                return TinhThueCoNguoiPhuThuoc(tienThue);
            }
            else
            {
                return TinhThueKhongCoNguoiPhuThuoc(tienThue);
            }
        }

        private double TinhThueCoNguoiPhuThuoc(double tienThue)
        {
            double tienThueCoNguoiPT = tienThue - 4400000 * soNguoiPhuThuoc;

            return TinhThueChung(tienThueCoNguoiPT);
        }

        private double TinhThueKhongCoNguoiPhuThuoc(double tienThue)
        {
            return TinhThueChung(tienThue);
        }

        private double TinhThueChung(double tienThue)
        {
            if (tienThue <= 5000000)
            {
                return tienThue * 0.05;
            }
            else if (10000000 >= tienThue && tienThue > 5000000)
            {
                return tienThue * 0.1;
            }
            else if (10000000 < tienThue && tienThue <= 18000000)
            {
                return tienThue * 0.15;
            }
            else if (32000000 >= tienThue && tienThue > 18000000)
            {
                return tienThue * 0.2;
            }
            else if (52000000 >= tienThue && tienThue > 3200000)
            {
                return tienThue * 0.25;
            }
            else if (80000000 >= tienThue && tienThue > 52000000)
            {
                return tienThue * 0.3;
            }
            else if (tienThue > 80000000)
            {
                return tienThue * 0.35;
            }

            return 0; 
        }


        public double TinhLuongThucLanh()
        {
            return (TinhLuong() + tienLe + tet - TinhBH() - TinhThueTNCN() - TinhTienPhepKhongLuong(5) );
        }


    }
}
