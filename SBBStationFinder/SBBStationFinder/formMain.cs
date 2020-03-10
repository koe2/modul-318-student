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

        private ITransport iStation;

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dateAndTimeGUIControl();
        }

        private void cbStart_TextChanged(object sender, EventArgs e) // AutoComplete
        {
            if(timerCombo.Enabled)
            {
                return;
            }

            ComboBox cbSender;
            if(sender is ComboBox)
            {
                cbSender = (ComboBox)sender;
            }
            else
            {
                return;
            }

            string inputText = cbSender.Text;
            if(cbSender.Text.Length >= 3 && !(cbSender.Items.Contains(cbSender.Text)))
            {
                timerCombo.Start();
                Stations validStations = getValidSations(cbSender);
                cbSender.Items.Clear();
                if(validStations != null)
                {
                    foreach(Station _s in validStations.StationList)
                    {
                        cbSender.Items.Add(_s.Name);
                    }
                }
                cbSender.DroppedDown = true;
                cbSender.Text = inputText;
                cbSender.SelectionStart = cbSender.Text.Length;
            }
        }

        private Stations getValidSations(ComboBox _c)
        {
            iStation = new Transport();
            Stations stations = iStation.GetStations(_c.Text);

            if(!(stations.StationList.Count > 0))
            {
                return null;
            }

            for(int i = stations.StationList.Count-1; i >= 0; i--)
            {
                if(stations.StationList[i].Id == null || stations.StationList[i].Name == null)
                {
                    stations.StationList.RemoveAt(i);
                }
            }
            return stations;
        }

        private void timerCombo_Tick(object sender, EventArgs e) //Timer für AutoComplete
        {
            timerCombo.Stop();
            cbStart_TextChanged(ActiveControl, null);
        }

        private void dateAndTimeGUIControl()
        {
            if(cbStart.Text == "")
            {
                rbTimeStart.Enabled = false;
            }
            else
            {
                rbTimeStart.Enabled = true;
            }

            if(cbZiel.Text == "")
            {
                rbTimeEnd.Enabled = false;
            }
            else
            {
                rbTimeEnd.Enabled = true;
            }
            
            if(rbTimeStart.Enabled == true || rbTimeEnd.Enabled == true)
            {
                dtpArrivalDate.Enabled = true;
                dtpArrivalTime.Enabled = true;
            }
            else
            {
                dtpArrivalDate.Enabled = false;
                dtpArrivalTime.Enabled = false;
            }
        }
    }
}
