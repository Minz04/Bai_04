using System;
using System.Windows.Forms;

namespace Bai04
{
    public partial class Form2 : Form
    {
        public NhanVien nhanVien { get; set; }

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(NhanVien nhanVien) : this()
        {
            this.nhanVien = nhanVien;
            if (nhanVien != null)
            {
                txt_msnv.Text = nhanVien.MSNV.ToString();
                txt_tennv.Text = nhanVien.Hoten;
                txt_luongcb.Text = nhanVien.Luongcb.ToString();
            }
        }

        private void btn_agree_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_msnv.Text, out int msnv) && !string.IsNullOrWhiteSpace(txt_tennv.Text) && float.TryParse(txt_luongcb.Text, out float luongcb))
            {
                nhanVien = new NhanVien(msnv, txt_tennv.Text, luongcb);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập dữ liệu hợp lệ.");
            }
        }

        private void btn_skip_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
