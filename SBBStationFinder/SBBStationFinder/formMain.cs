using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

namespace SBBStationFinder
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private ITransport testee

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            testee = new Transport();
            var stations = testee.GetStations("Sursee,");

            while (!(stations.StationList.))
        }
    }
}
