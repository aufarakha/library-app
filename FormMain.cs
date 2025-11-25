using Guna.UI2.WinForms;
using library_app.data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library_app
{
    public partial class FormMain : Form
    {


        private Guna2Button _CurrentActiveButton = new Guna2Button();


        public FormMain()
        {
            InitializeComponent();
        }

        private void _ShowForm(Guna2Button activeBtn, Form frm)
        {
            if (_CurrentActiveButton != null)
                _CurrentActiveButton.Checked = false;

            _CurrentActiveButton = activeBtn;
            _CurrentActiveButton.Checked = true;

            frm.BackColor = pnlContainer.BackColor;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;

            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(frm);

            frm.Show();
        }


        private void btnBooks_Click(object sender, EventArgs e)
        {

        }

        private void btnBorrowings_Click(object sender, EventArgs e)
        {
            _ShowForm((Guna2Button)sender, new FormBuku());
        }
    }
}
