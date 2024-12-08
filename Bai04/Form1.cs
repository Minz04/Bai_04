using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<NhanVien> dsnv = new List<NhanVien>();
        private void DataFGridView()
        {
            dtgNhanVien.DataSource = null;
            dtgNhanVien.DataSource = dsnv;
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                dsnv.Add(frm.nhanVien);
                DataFGridView();
            }
        }

        private void btn_repair_Click(object sender, EventArgs e)
        {
            if (dtgNhanVien.SelectedRows.Count > 0)
            {
                int index = dtgNhanVien.SelectedRows[0].Index;
                NhanVien selectedEmployee = dsnv[index];
                Form2 frm = new Form2(selectedEmployee);
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        dsnv[index] = frm.nhanVien;
                        DataFGridView();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui long cho mot nhan vien de sua!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dtgNhanVien.SelectedRows.Count > 0)
            {
                int index = dtgNhanVien.SelectedRows[0].Index;
                NhanVien selectedEmployee = dsnv[index];
                dsnv.RemoveAt(index);
                DataFGridView();
            }
            else
            {
                MessageBox.Show("Vui long cho mot nhan vien de xoa");
            }
        }

        private void btn_quick_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        List<Form2> nhanViens = new List<Form2>();
        private void Form1_Load(object sender, EventArgs e)
        {
            dtgNhanVien.DataSource = nhanViens;
        }
    }
}
