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
    public partial class BookForm : DevExpress.XtraEditors.XtraForm
    {
        public BookForm()
        {
            InitializeComponent();
        }

        private void tìmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void timeSystem_Tick(object sender, EventArgs e)
        {
            lblTimeSys.Text = DateTime.Now.ToLongTimeString();
        }

        private void BookForm_Load(object sender, EventArgs e)
        {
            lblAccount.Text = StaticValue.ACCOUNT;
        }
    }
}