﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.BS_layer
{
    class BLTaiKhoan
    {
        BLNhanVien dbNV = new BLNhanVien();
        public DataTable LayTaiKhoan()
        {

            QuanLyNhaHangEntities qlnhEntity = new QuanLyNhaHangEntities();
            var dms =
            from p in qlnhEntity.TAIKHOANs
            select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("TenTaiKhoan");
            dt.Columns.Add("MatKhau");
            dt.Columns.Add("MaNV");
            dt.Columns.Add("CapDoQuyen");
            foreach (var p in dms)
            {
                dt.Rows.Add(p.TenTaiKhoan, p.MatKhau, dbNV.MaNV_TenNV(p.MaNV), p.CapDoQuyen);
            }
            return dt;
        }
        public DataTable TimKiemTaiKhoan(string str)
        {
            QuanLyNhaHangEntities qlnhEntity = new QuanLyNhaHangEntities();
            var dms =
            from p in qlnhEntity.TAIKHOANs
            where p.TenTaiKhoan.Contains(str)
            select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("TenTaiKhoan");
            dt.Columns.Add("MatKhau");
            dt.Columns.Add("MaNV");
            dt.Columns.Add("CapDoQuyen");
            foreach (var p in dms)
            {
                dt.Rows.Add(p.TenTaiKhoan, p.MatKhau, dbNV.MaNV_TenNV(p.MaNV), p.CapDoQuyen);
            }
            return dt;
        }
        public bool ThemTaiKhoan(string TenTaiKhoan, string MatKhau, string MaNV, int CapDoQuyen, ref string err)
        {
            QuanLyNhaHangEntities qlnhEntity = new QuanLyNhaHangEntities();
            TAIKHOAN tk = new TAIKHOAN();
            tk.TenTaiKhoan = TenTaiKhoan;
            tk.MatKhau = MatKhau;
            tk.MaNV = MaNV;
            tk.CapDoQuyen = CapDoQuyen;
            try
            {
                qlnhEntity.TAIKHOANs.Add(tk);
                qlnhEntity.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }

        }
        public bool XoaTaiKhoan(string TenTaiKhoan, ref string err)
        {
            QuanLyNhaHangEntities qlnhEntity = new QuanLyNhaHangEntities();
            TAIKHOAN tk = new TAIKHOAN();
            tk.TenTaiKhoan = TenTaiKhoan;
            try
            {
                qlnhEntity.TAIKHOANs.Attach(tk);
                qlnhEntity.TAIKHOANs.Remove(tk);
                qlnhEntity.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }
        public bool XoaTaiKhoanTheoNV(string MaNV, ref string err)
        {
            QuanLyNhaHangEntities qlnhEntity = new QuanLyNhaHangEntities();
            try
            {
                var TaiKhoanList = qlnhEntity.TAIKHOANs.Where(tk => tk.MaNV == MaNV).ToList();

                foreach (var p in TaiKhoanList)
                {
                    qlnhEntity.TAIKHOANs.Remove(p);
                }

                qlnhEntity.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }
        public bool CapNhatTaiKhoan(string TenTaiKhoan, string MatKhau, string MaNV, int CapDoQuyen, ref string err)
        {
            QuanLyNhaHangEntities qlnhEntity = new QuanLyNhaHangEntities();
            var tkQuery = (from tk in qlnhEntity.TAIKHOANs
                           where tk.TenTaiKhoan == TenTaiKhoan
                           select tk).SingleOrDefault();
            try
            {
                if (tkQuery != null)
                {
                    tkQuery.MatKhau = MatKhau;
                    tkQuery.MaNV = MaNV;
                    tkQuery.CapDoQuyen = CapDoQuyen;
                    qlnhEntity.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }


        public bool DangNhap(string TenTaiKhoan, string MatKhau)
        {
            QuanLyNhaHangEntities qlnhEntity = new QuanLyNhaHangEntities();
            List<TAIKHOAN> tkQuery = (from tk in qlnhEntity.TAIKHOANs
                                      where tk.TenTaiKhoan == TenTaiKhoan && tk.MatKhau == MatKhau
                                      select tk).ToList();
            if (tkQuery.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool KT(string TenTaiKhoan)
        {
            QuanLyNhaHangEntities qlnhEntity = new QuanLyNhaHangEntities();
            List<TAIKHOAN> tkQuery = (from tk in qlnhEntity.TAIKHOANs
                                      where tk.TenTaiKhoan == TenTaiKhoan && tk.CapDoQuyen == 1
                                      select tk).ToList();
            if (tkQuery.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string LayQuyen(string str)
        {
            QuanLyNhaHangEntities qlnhEntity = new QuanLyNhaHangEntities();
            var taikhoanList = from tk in qlnhEntity.TAIKHOANs
                               where tk.TenTaiKhoan.Contains(str)
                               select new
                               {
                                   CapDoQuyen = tk.CapDoQuyen
                               };
            string CapDoQuyen = "";
            foreach (var item in taikhoanList)
            {
                CapDoQuyen = item.CapDoQuyen.ToString();
            }
            if (CapDoQuyen == "1") CapDoQuyen = "ADMIN";
            else CapDoQuyen = "Nhân viên quản lý";
            return CapDoQuyen;
        }
        public string TimKiemTen(string str)
        {
            QuanLyNhaHangEntities qlnhEntity = new QuanLyNhaHangEntities();
            var taikhoanList = from tk in qlnhEntity.TAIKHOANs
                               where tk.TenTaiKhoan.Contains(str)
                               select new
                               {
                                   MaNV = tk.MaNV,
                                   CapDoQuyen = tk.CapDoQuyen
                               };
            string tenNV = "";
            foreach (var item in taikhoanList)
            {
                string maNV = item.MaNV.ToString();
                tenNV = dbNV.MaNV_TenNV(maNV).Split('-')[1].Trim();
            }
            return tenNV;
        }
    }
}
