using QuanLyDiaOc.DAL;
using QuanLyDiaOc.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiaOc.BLL
{
    class ViTriBLL
    {
        private ViTriDAL ViTriDAL = new ViTriDAL();
        public DataTable LayDanhSachViTri()
        {
            return ViTriDAL.LayDanhSachViTri();
        }

        public bool ThemViTri(ViTriDTO viTriDTO)
        {
            return ViTriDAL.ThemViTri(viTriDTO);
        }

        public bool XoaViTri(int ma)
        {
            return ViTriDAL.XoaViTri(ma);
        }

        public bool SuaViTri(ViTriDTO viTriDTO)
        {
            return ViTriDAL.SuaViTri(viTriDTO);
        }

        public DataTable TimKiemViTriTheoTen(string ten)
        {
            return ViTriDAL.TimKiemViTriTheoTen(ten);
        }
    }
}
