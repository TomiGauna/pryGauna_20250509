using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGauna_20250509
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTitle.Text = "SPORT IMAGES";
            lblSubtitle.Text = "Choose your sport";
            
            cboSports.Items.Clear();
            cboSports.Items.Add("Football");
            cboSports.Items.Add("Tenis");
            cboSports.Items.Add("Golf");

            btnShow.Enabled = false;
        }

        private void cboSports_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSports.SelectedIndex != -1)
            {
                btnShow.Enabled = true;
            }
        }
    }
}
