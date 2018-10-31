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
        string imgLogcation = "";
        public BookForm()
        {
            InitializeComponent();
        }

        private void timeSystem_Tick(object sender, EventArgs e)
        {
            lblTimeSys.Text = " | " + DateTime.Now.ToLongTimeString();
        }

        private void BookForm_Load(object sender, EventArgs e)
        {
            lblAccount.Text = Utility.ACCOUNT;
            setLabel("chưa chọn");
            setButton("", false);
            rbtnFindbySerial.Visible = rbtnFindbyName.Visible = false;
            //set txt source
            //name
            txtName.AutoCompleteMode = txtAuthor.AutoCompleteMode = txtSerial.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtSerial.AutoCompleteSource = AutoCompleteSource.CustomSource;
            var txtNameAutoCompleteCustomsource = new AutoCompleteStringCollection();
            txtNameAutoCompleteCustomsource.AddRange(Book.getBookName());
            txtName.AutoCompleteCustomSource = txtNameAutoCompleteCustomsource;
            //serial
            txtName.AutoCompleteMode = txtAuthor.AutoCompleteMode = txtSerial.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtSerial.AutoCompleteSource = AutoCompleteSource.CustomSource;
            var txtSerialAutoCompleteCustomsource = new AutoCompleteStringCollection();
            txtSerialAutoCompleteCustomsource.AddRange(Book.getBookSerial());
            txtSerial.AutoCompleteCustomSource = txtSerialAutoCompleteCustomsource;
        }

        private void setButton(string btn, bool status)
        {
            switch (btn)
            {
                case "find":
                    //set button
                    btnMode.Enabled = btnReset.Enabled = tsbtnFindMode.Enabled = status; 
                    //set menu strip
                    tsbtnAddMode.Enabled = tsbtnDelMode.Enabled = tsbtnUpdateMode.Enabled = !status;
                    //set tool trip menu
                    thêmToolStripMenuItem.Enabled = xóaToolStripMenuItem.Enabled = sửaToolStripMenuItem.Enabled = btnAddImage.Enabled = !status;
                    //set txt no need
                    txtAmount.Enabled = txtAuthor.Enabled = txtPH.Enabled = txtTag.Enabled = !status;
                    //Set rbtn find
                    rbtnFindbySerial.Select();
                    rbtnFindbyName.Visible = rbtnFindbySerial.Visible = true;
                    break;
                case "add":
                    btnAddImage.Enabled = btnMode.Enabled = btnReset.Enabled = tsbtnAddMode.Enabled = txtAmount.Enabled = status;
                    tsbtnFindMode.Enabled = tsbtnDelMode.Enabled = tsbtnUpdateMode.Enabled = !status;
                    tìmToolStripMenuItem.Enabled = xóaToolStripMenuItem.Enabled = sửaToolStripMenuItem.Enabled = !status;
                    break;
                case "del":
                    btnAddImage.Enabled = btnMode.Enabled = btnReset.Enabled = tsbtnDelMode.Enabled = status;
                    tsbtnAddMode.Enabled = tsbtnFindMode.Enabled = tsbtnUpdateMode.Enabled = !status;
                    thêmToolStripMenuItem.Enabled = tìmToolStripMenuItem.Enabled = sửaToolStripMenuItem.Enabled = txtAmount.Enabled = !status;
                    break;
                case "update":
                    btnAddImage.Enabled = btnMode.Enabled = btnReset.Enabled = tsbtnUpdateMode.Enabled = status;
                    tsbtnAddMode.Enabled = tsbtnDelMode.Enabled = tsbtnFindMode.Enabled = !status;
                    thêmToolStripMenuItem.Enabled = xóaToolStripMenuItem.Enabled = tìmToolStripMenuItem.Enabled = !status;
                    break;
                case "":
                    btnAddImage.Enabled = btnMode.Enabled = btnReset.Enabled = status;
                    tsbtnAddMode.Enabled = tsbtnFindMode.Enabled = tsbtnDelMode.Enabled = tsbtnUpdateMode.Enabled = !status;
                    tìmToolStripMenuItem.Enabled = thêmToolStripMenuItem.Enabled = xóaToolStripMenuItem.Enabled = sửaToolStripMenuItem.Enabled = txtAmount.Enabled = !status;
                    break;
            }

        }

        private void setLabel(string mode)
        {
            btnMode.Text = mode;
            lblMode.Text = "Chế độ " + mode;
        }

        private void clear()
        {
            txtAmount.ResetText();
            txtAuthor.Text = txtName.Text = txtPH.Text = txtSerial.Text = txtTag.Text = "";
            ptbImg.ImageLocation = null;
            ptbImg.Image = ptbImg.InitialImage;
        }

        #region ToolStrip

        private void tsbtnFindMode_Click(object sender, EventArgs e)
        {
            setLabel("Tìm");
            setButton("find", true);
        }

        private void tsbtnAddMode_Click(object sender, EventArgs e)
        {
            setLabel("Thêm");
            setButton("add", true);
        }

        private void tsbtnDelMode_Click(object sender, EventArgs e)
        {
            setLabel("Xóa");
            setButton("del", true);
        }

        private void tsbtnUpdateMode_Click(object sender, EventArgs e)
        {
            setLabel("Sửa");
            setButton("update", true);
        }

        private void tìmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsbtnFindMode_Click(sender, e);
        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsbtnAddMode_Click(sender, e);
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsbtnDelMode_Click(sender, e);
        }

        private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsbtnUpdateMode_Click(sender, e);
        }
        #endregion ToolStrip

        private void ptbImg_Click(object sender, EventArgs e)
        {
            if (btnAddImage.Enabled)
                btnAddImage_Click(sender, e);
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "JPG Files (*.jpg)|*.jpg|JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All Files (*.*)|*.*";
                openFileDialog.Title = "Chọn ảnh";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    imgLogcation = openFileDialog.FileName.ToString();
                    ptbImg.ImageLocation = imgLogcation;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMode_Click(object sender, EventArgs e)
        {
            switch (btnMode.Text)
            {
                case "Tìm":
                    if(rbtnFindbySerial.Checked)
                    {
                        try
                        {
                            DataTable table = Book.findBookBySerial(txtSerial.Text);
                            txtSerial.Text = table.Rows[0][0].ToString();
                            txtName.Text = table.Rows[0][1].ToString();
                            txtAuthor.Text = table.Rows[0][2].ToString();
                            txtPH.Text = table.Rows[0][3].ToString();
                            txtAmount.Text = table.Rows[0][4].ToString();
                            txtTag.Text = table.Rows[0][6].ToString();
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        try
                        {
                            DataTable table = Book.findBookByName(txtName.Text);
                            txtSerial.Text = table.Rows[0][0].ToString();
                            txtName.Text = table.Rows[0][1].ToString();
                            txtAuthor.Text = table.Rows[0][2].ToString();
                            txtPH.Text = table.Rows[0][3].ToString();
                            txtAmount.Text = table.Rows[0][4].ToString();
                            txtTag.Text = table.Rows[0][6].ToString();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Thất bại!");
                        }
                    }
                    break;
                case "Thêm":
                    break;
                case "Xóa":

                    break;
                case "Sửa":

                    break;
                default:
                    break;
            }
        }
        

        private void tsbtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            setLabel("chưa chọn");
            setButton("", false);
            clear();
        }

        private void BookForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((txtAuthor.TextLength + txtName.TextLength + txtPH.TextLength + txtSerial.TextLength + txtTag.TextLength) > 0)
            {
                if (MessageBox.Show("Có vẻ như bạn chưa hoàn thành công việc... \n\n Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    e.Cancel = true;
            }
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đồ án môn Lập trình trên môi trường Windows\n" +
                            "Các thành viên thực hiện\n" +
                            "Nguyễn Thành Long\n" +
                            "Nguyễn Ngọc Thiên Long\n" +
                            "Đoàn Ngọc Thiện", "Thông tin");
        }

        private void rbtnFindbySerial_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnFindbySerial.Checked)
            {
                txtSerial.Enabled = true;
                txtName.Enabled = false;
            }
            else
            {
                txtSerial.Enabled = false;
                txtName.Enabled = true;
            }
        }
    }
}