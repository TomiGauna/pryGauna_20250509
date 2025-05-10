using pryGauna_20250509.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGauna_20250509
{
    public partial class frmSports : Form
    {
        public frmSports()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTitle.Text = "SPORT IMAGES";
            lblSubtitle.Text = "Choose your sport";
            lblStrength.Text = "Strength";
            lblSkillfulness.Text = "Skillfulness";
            
            cboSports.Items.Clear();
            cboSports.Items.Add("Football");
            cboSports.Items.Add("Tenis");
            cboSports.Items.Add("Golf");

            nudStrength.Minimum = 0;
            nudStrength.Maximum = 10;
            nudSkillfulness.Minimum = 0;
            nudSkillfulness.Maximum = 10;

            btnShow.Enabled = false;
            btnShow.Text = "Show";
            btnRecord.Text = "Record";
        }

        private void cboSports_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSports.SelectedIndex != -1)
            {
                btnShow.Enabled = true;
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            switch (cboSports.Text)
            {
                case "Football":
                    pboImage.Image = Resources.Football;
                    break;

                case "Tenis":
                    pboImage.Image = Resources.Tenis;
                    break;

                case "Golf":
                    pboImage.Image = Resources.Golf;
                    break;

                default:
                    pboImage.Image = Resources.Football;
                    break;
            }
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter("Sports.txt", true);
            writer.WriteLine(cboSports.Text + ": Strength - " + nudStrength.Value + ", Skillfulness - " + nudSkillfulness.Value);
            writer.Close();

            nudSkillfulness.Value = 0;
            nudStrength.Value = 0;
        }
    }
}
