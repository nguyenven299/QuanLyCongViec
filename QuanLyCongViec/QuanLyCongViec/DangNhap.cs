using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongViec
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
            buttonDangNhap.BackColor = Color.Transparent;
        
       

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDangNhap_Click(object sender, EventArgs e)
        {
            QLCV_DBDataContext qLCV_DBDataContext = new QLCV_DBDataContext();
           
            if(textBoxEmail.Text.Trim().Length==0)
            {
                MessageBox.Show("Vui Lòng Nhập Email");
            }
            else if(textBoxMatKhau.Text.Trim().Length==0)
            {
                MessageBox.Show("Vui Lòng Nhập Mật Khẩu");
            }  
            else
            {
            var dangNhap = (from TaiKhoan in qLCV_DBDataContext.TaiKhoans
                            where TaiKhoan.Email == textBoxEmail.Text
                            where TaiKhoan.Password == textBoxMatKhau.Text
                            join NhanVien in qLCV_DBDataContext.NhanViens
                            on TaiKhoan.MaNhanVien equals NhanVien.MaNhanVien
                            join ChucVu in qLCV_DBDataContext.ChucVus
                            on NhanVien.MaChucVu equals ChucVu.MaChucVu
                            select ChucVu
                            );
                foreach(var chucVu in dangNhap)
            {
                if(chucVu.TenChucVu == "Admin")
                {
                    MessageBox.Show("Chào Admin");
                        Admin formAdmin = new Admin();
                        this.Hide();
                        formAdmin.Show();
                    }
                else if( chucVu.TenChucVu == "Leader")
                {
                    MessageBox.Show("leader");
                }

            }
            }    

            
        }
    }
}
