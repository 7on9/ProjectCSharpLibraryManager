using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Library_Manager
{
    public partial class RouterForm : DevExpress.XtraEditors.XtraForm
    {
        public RouterForm()
        {
            InitializeComponent();
        }

        private void RouterForm_Load(object sender, EventArgs e)
        {
            toolTipBook.SetToolTip(imgBook, "Thao tác với sách");
            toolTipUser.SetToolTip(imgUser, "Thao tác với người dùng");
            toolTipBorrow.SetToolTip(imgBorrow, "Thao tác với thẻ mượn sách");
            toolTipData.SetToolTip(imgData, "Thao tác với dữ liệu");
        }

        private void imgBook_Click(object sender, EventArgs e)
        {
            BookForm bookForm = new BookForm();
            bookForm.Show();
        }

        private void imgUser_Click(object sender, EventArgs e)
        {

        }

        private void imgBorrow_Click(object sender, EventArgs e)
        {

        }

        private void imgData_Click(object sender, EventArgs e)
        {

        }
    }
}