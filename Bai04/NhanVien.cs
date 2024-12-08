using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai04
{
    public class NhanVien
    {
        public int MSNV { get; set; }
        public string Hoten { get; set; }
        public float Luongcb { get; set; }

        public NhanVien(int msnv, string hoten, float luongcb)
        {
            MSNV = msnv;
            Hoten = hoten;
            Luongcb = luongcb;
        }
    }
}
