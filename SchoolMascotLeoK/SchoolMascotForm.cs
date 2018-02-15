/*Leo Kay
 * ICS3U
 * This displays schools and their mascots
 * Feb 15, 2018
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolMascotLeoK
{
    public partial class frmMascot : Form
    {
        public frmMascot()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        //Immaculata 
        private void mniImmaculata_Click(object sender, EventArgs e)
        {
            lblSchool.Text = "Immaculata";
            lblMascot.Text = "Saints";
        }
        //Hillcrest
        private void mniHillcrest_Click(object sender, EventArgs e)
        {
            lblSchool.Text = "Hillcrest";
            lblMascot.Text = "Hawks";
        }
        //Cantebury
        private void mniCantubury_Click(object sender, EventArgs e)
        {
            lblSchool.Text = "Cantebury";
            lblMascot.Text = "Chargers";
        }
        //Glebe
        private void mniGlebe_Click(object sender, EventArgs e)
        {
            lblSchool.Text = "Glebe";
            lblMascot.Text = "Gryphons";
        }
    }
}
