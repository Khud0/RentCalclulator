using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rent_Calculator
{
    public partial class FormMain : Form
    {

        // Normal Constructor
        public FormMain()
        {
            InitializeComponent();
        }

        // Overloaded Constructor
        public FormMain(string tt)
        {
            InitializeComponent();
            if (tt != null) this.lblText.Text = tt;
        }

        public Form FormMainRef {
            set;
            get;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormMainRef.Show();
            FormMainRef.Location = this.Location;
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/Khud0");
        }
    }
}
