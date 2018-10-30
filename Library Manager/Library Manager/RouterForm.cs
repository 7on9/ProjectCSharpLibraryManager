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
            lblAccount.Text = StaticValue.ACCOUNT;
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
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void timeSystem_Tick(object sender, EventArgs e)
        {
            lblTimeSys.Text = DateTime.Now.ToLongTimeString();
        }

        private void sáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imgBook_Click(sender, e);
        }

        private void thẻThưViệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imgUser_Click(sender, e);
        }

        private void dữLiệuHệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imgData_Click(sender, e);
        }

        private void phiếuMượnSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imgBorrow_Click(sender, e);
        }
    }
}