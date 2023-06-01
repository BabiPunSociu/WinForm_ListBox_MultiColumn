using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai6_Trang64
{
    public partial class Form1 : Form
    {
        string str;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Cho phép hiển thị trên nhiều cột
            lstDanhSach.MultiColumn = true;
            //Hiển thị trên 5 cột 
            lstDanhSach.ColumnWidth = lstDanhSach.Width / 5;
            //Cho phép chọn đồng thời nhiều phần tử
            lstDanhSach.SelectionMode = SelectionMode.MultiSimple;
            //Add dữ liệu vào hộp danh sách
            for (int i = 1; i <= 100; i++)
                lstDanhSach.Items.Add("Item " + i.ToString());
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            str = string.Empty;
            if(lstDanhSach.SelectedItems.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn phần tử nào");
                return;
            }    

            foreach (string item in lstDanhSach.SelectedItems)
            {
                str = str + item + ", ";
            }
            //Xóa dấu phẩy và dấu cách thừa ở cuối chuỗi
            str = str.Remove(str.Length - 2, 2);
            MessageBox.Show("Bạn đã chọn các phần tử : " + str,
            "Thông báo", MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        }
    }
}
