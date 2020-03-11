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
        private Stations validStations;

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getStationBoard(cbStart, lbBoardStart, tabStart);
            getStationBoard(cbZiel, lbBoardZiel, tabZiel);
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
                timerCombo.Enabled = true;
                timerCombo.Start();
                validStations = getValidSations(cbSender.Text);
                cbSender.Items.Clear();
                if(validStations != null)
                {
                    foreach(Station s in validStations.StationList)
                    {
                        cbSender.Items.Add(s.Name);
                    }
                }
                cbSender.DroppedDown = true;
                cbSender.Text = inputText;
                cbSender.SelectionStart = cbSender.Text.Length;
            }
            dateAndTimeGUIControl();
        }

        private Stations getValidSations(string _s)
        {
            iStation = new Transport();
            Stations stations = iStation.GetStations(_s);

            if(!(stations.StationList.Count > 0))
            {
                return null;
            }

            for(int i = stations.StationList.Count - 1; i >= 0; i--)
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
            timerCombo.Enabled = false;
            cbStart_TextChanged(ActiveControl, null);
        }

        private void dateAndTimeGUIControl() //Enable & Disables Controls
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

        private void formMain_Activated(object sender, EventArgs e)
        {
            dateAndTimeGUIControl();
        }

        private void getStationConnection(string _start, string _end)
        {
            if(_start == "" || _end == "")
            {
                return;
            }

            iStation = new Transport();
            Connections transportConnection = iStation.GetConnections(_start, _end);


            lbVerbindungStart.Items.Clear();
            foreach(Connection c in transportConnection.ConnectionList)
            {
                lbVerbindungStart.Items.Add("Start: " + c.From.Station.Name +
                                        " - " + (DateTime.Parse(c.From.Departure)).ToShortDateString() +
                                        " - " + (DateTime.Parse(c.From.Departure)).ToShortTimeString() +
                                        " - " + c.From.Platform +
                                        "      Ziel: " + c.To.Station.Name +
                                        " - " + (DateTime.Parse(c.To.Arrival)).ToShortDateString() +
                                        " - " + (DateTime.Parse(c.To.Arrival)).ToShortTimeString() +
                                        " - " + c.To.Platform
                                       );
            }
        }

        private void getStationBoard(ComboBox _cbSender, ListBox _lb, TabPage _tb)
        {
            _lb.Items.Clear();
            if(_cbSender.Text != "" && _cbSender.SelectedIndex > 0)
            {
                iStation = new Transport();
                string id = validStations.StationList[_cbSender.SelectedIndex].Id.ToString();
                StationBoardRoot sb = iStation.GetStationBoard(_cbSender.Text, id);


                
                foreach(StationBoard s in sb.Entries)
                {
                    _lb.Items.Add(" Ziel: " + s.To +
                                    " - " + s.Name +
                                    " - " + s.Stop.Departure.ToString().Remove(s.Stop.Departure.ToString().Length - 3, 3)
                                  );
                }
                _tb.Text = "Ab: " + _cbSender.Text;
            }
            else
            {
                _tb.Text = "Ab: ";
            }
        }
    }
}
