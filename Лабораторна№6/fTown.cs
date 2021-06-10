using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторна_6
{
    public partial class fTown : Form
    {
        public TheTown TheTown;
        public fTown(TheTown t)
        {
            TheTown = t;
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            TheTown.Name = tbModel.Text.Trim();
            TheTown.Country = tbCountry.Text.Trim();
            TheTown.BikeType = tbBikeType.Text.Trim();
            TheTown.SuspensionType = tbSuspensionType.Text;
            TheTown.Weight = double.Parse(tbWeight.Text.Trim());
            TheTown.Price = double.Parse(tbPrice.Text.Trim());
            TheTown.HasHydraulicBrakes = chbHasHydraulicBrakes.Checked;
            TheTown.HasHydraulicSeatPot = chbHydraulicSetPost.Checked;
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void fTown_Load(object sender, EventArgs e)
        {
            if (TheTown != null)
            {
                tbModel.Text = TheTown.Name;
                tbCountry.Text = TheTown.Country;
                tbBikeType.Text = TheTown.BikeType;
                tbSuspensionType.Text =  TheTown.SuspensionType;
                tbWeight.Text = TheTown.Weight.ToString("0");
                tbPrice.Text = TheTown.Price.ToString("0.00");
                chbHasHydraulicBrakes.Checked = TheTown.HasHydraulicBrakes;
                chbHydraulicSetPost.Checked = TheTown.HasHydraulicSeatPot;
            }
        }

     
     
    }
}
