using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Library_Manager
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        public LoginForm()
        {
            InitializeComponent();
            if (!mvvmContext1.IsDesignMode)
                InitializeBindings();
        }

        void InitializeBindings()
        {
            var fluent = mvvmContext1.OfType<MainViewModel>();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtUserName.Select();
        }

        DatabaseConnection databaseConnection;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            databaseConnection = new DatabaseConnection();
            if (databaseConnection.verifyConnection())
                MessageBox.Show("Kết nối thành công đến database!");
            else MessageBox.Show("Không thể kết nối database!");
            Cursor.Current = Cursors.Default;

            this.Hide();
            RouterForm router = new RouterForm();
            router.ShowDialog();
            //router.Activate();
            this.Close();
        }

        private void VerifyInput_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            for (int i = 0; i < textBox.TextLength; i++)
            {
                if (char.IsLetterOrDigit(textBox.Text[i]) == false)
                {
                    textBox.Text = textBox.Text.Remove(i, 1);
                    textBox.SelectionStart = i;
                    textBox.SelectionLength = 0;
                }
            }
        }
    }
}
