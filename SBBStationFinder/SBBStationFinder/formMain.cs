using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
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
        private StationBoardRoot sbStart;
        private StationBoardRoot sbZiel;

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbStart_TextChanged(object sender, EventArgs e)
        {
            if(timerAutocomplete.Enabled)
            {
                timerAutocomplete.Stop();
                timerAutocomplete.Start();
                return;
            }
            else
            {
                autoComplete();
            }
;       }

        private void autoComplete()
        {
            ComboBox activeControl;
            if(this.ActiveControl is ComboBox)
            {
                activeControl = (ComboBox)this.ActiveControl;
            }
            else
            {
                return;
            }

            string inputText = activeControl.Text;
            if(activeControl.Text.Length >= 3 && !(activeControl.Items.Contains(activeControl.Text)))
            {
                timerAutocomplete.Enabled = true;
                timerAutocomplete.Start();
                try
                {
                    validStations = getValidSations(activeControl.Text);
                    activeControl.Items.Clear();
                    if(validStations != null)
                    {
                        foreach(Station s in validStations.StationList)
                        {
                            activeControl.Items.Add(s.Name);
                        }
                    }
                    activeControl.DroppedDown = true;
                    activeControl.Text = inputText;
                    activeControl.SelectionStart = activeControl.Text.Length;
                }
                catch(Exception)
                {
                    timerAutocomplete.Stop();
                    timerAutocomplete.Enabled = false;
                    CheckNetworkConnection.start();
                }
            }
            dateAndTimeGUIControl();
        }

        private void timerAutocomplete_Tick(object sender, EventArgs e)
        {
            timerAutocomplete.Stop();
            timerAutocomplete.Enabled = false;
            autoComplete();
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

        private void dateAndTimeGUIControl() //Enable & Disables Controls
        {
            if(cbStart.Text != "" && cbZiel.Text != "")
            {
                dtpArrivalDate.Enabled = true;
                dtpArrivalTime.Enabled = true;
                rbTimeEnd.Enabled = true;
                rbTimeStart.Enabled = true;

            }
            else
            {
                dtpArrivalDate.Enabled = false;
                dtpArrivalTime.Enabled = false;
                rbTimeStart.Enabled = false;
                rbTimeEnd.Enabled = false;

            }
        }

        private void formMain_Activated(object sender, EventArgs e)
        {
            dateAndTimeGUIControl();
        }

        private void getDateTimeConnection(string _start, string _end, string _date, string _time, short _isArrival)
        {
            lbVerbindungStart.Items.Clear();
            if(_start == "" || _end == "" || _date == "")
            {
                return;
            }

            iStation = new Transport();
            Connections transportConnection = iStation.GetConnectionByDateTime(_start, _end, convertToAPIDate(_date), _time, _isArrival);

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

        private void getStationConnection(string _start, string _end)
        {
            lbVerbindungStart.Items.Clear();
            if(_start == "" || _end == "")
            {
                return;
            }

            iStation = new Transport();
            Connections transportConnection = iStation.GetConnections(_start, _end);
       
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

        private StationBoardRoot getStationBoard(ComboBox _cbSender, ListBox _lb, TabPage _tb)
        {
            _lb.Items.Clear();
            if(_cbSender.Text != "" && _cbSender.SelectedIndex > -1)
            {
                iStation = new Transport();
                string id = validStations.StationList[_cbSender.SelectedIndex].Id.ToString();
                StationBoardRoot sb = iStation.GetStationBoard(_cbSender.Text, id);

                
                foreach(StationBoard s in sb.Entries)
                {
                    _lb.Items.Add(" Ziel: " + s.To +
                                    "\t - " + s.Name +
                                    "\t - " + s.Stop.Departure.ToString().Remove(s.Stop.Departure.ToString().Length - 3, 3)
                                  );
                }
                _tb.Text = "Ab: " + _cbSender.Text;

                return sb;
            }
            else
            {
                _tb.Text = "Ab: ";
                return null;
            }
        }

        private string convertToAPIDate(string _string)
        {
            var tmpDate = _string.Substring(6, 4);
            tmpDate = tmpDate + "-" + _string.Substring(3, 2);
            tmpDate = tmpDate + "-" + _string.Substring(0, 2);

            return tmpDate;
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInfo f = new frmInfo();
            f.ShowDialog(this);
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            CheckNetworkConnection.start();
        }

        private void btnSuche_Click(object sender, EventArgs e)
        {
            if(btnSuche.Enabled == false)
            {
                return;
            }

            btnSuche.Enabled = false;
            try
            {
                
                sbStart = getStationBoard(cbStart, lbBoardStart, tabStart);
                sbZiel = getStationBoard(cbZiel, lbBoardZiel, tabZiel);
                if(rbTimeOFF.Checked)
                {
                    getStationConnection(cbStart.Text, cbZiel.Text);
                }
                else
                {
                    if(rbTimeStart.Checked)
                    {
                        getDateTimeConnection(cbStart.Text, cbZiel.Text, dtpArrivalDate.Text, dtpArrivalTime.Text, 0);
                    }
                    else
                    {
                        getDateTimeConnection(cbStart.Text, cbZiel.Text, dtpArrivalDate.Text, dtpArrivalTime.Text, 1);
                    }
                }

                if(lbBoardStart.Items.Count > 0 && lbVerbindungStart.Items.Count == 0 && lbBoardZiel.Items.Count == 0)
                {
                    pageControl.SelectedTab = tabStart;
                    pageControl.Focus();
                }
                else if(lbBoardStart.Items.Count == 0 && lbVerbindungStart.Items.Count == 0 && lbBoardZiel.Items.Count > 0)
                {
                    pageControl.SelectedTab = tabZiel;
                    pageControl.Focus();
                }
                else
                {
                    pageControl.SelectedTab = tabVerbindung;
                    pageControl.Focus();
                }

            }
            catch(Exception)
            {
                CheckNetworkConnection.start();
            }
            btnSuche.Enabled = true;
        }

        private void alsMailVersendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMail f = new frmMail(lbVerbindungStart,lbBoardStart,lbBoardZiel);
            f.ShowDialog(this);
        }

        private void openBrowser(string _x, string _y)
        {
            string target = "https://www.google.com/maps/search/?api=1&query="+ _x+","+_y;

            try
            {
                System.Diagnostics.Process.Start(target);
            }
            catch(System.ComponentModel.Win32Exception noBrowser)
            {
                if(noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show("Kein Webbrowser vorhanden. Abbruch!");
            }
            catch(System.Exception other)
            {
                MessageBox.Show(other.Message);
            }
        }

        private void btnMapStart_Click(object sender, EventArgs e)
        {
            if(lbBoardStart.SelectedIndex >= 0)
            {
                if(sbStart != null)
                {
                    double x = sbStart.Station.Coordinate.XCoordinate;
                    double y = sbStart.Station.Coordinate.YCoordinate;
                    openBrowser(x.ToString(),y.ToString());
                }
            }
        }

        private void btnMapZiel_Click(object sender, EventArgs e)
        {
            if(lbBoardZiel.SelectedIndex >= 0)
            {
                if(sbZiel != null)
                {
                    double x = sbZiel.Station.Coordinate.XCoordinate;
                    double y = sbZiel.Station.Coordinate.YCoordinate;
                    openBrowser(x.ToString(), y.ToString());
                }
            }
        }

        private void cbStart_Leave(object sender, EventArgs e)
        {
            if(cbStart.SelectedIndex < 0 && cbStart.Items.Count > 0 && cbStart.Text != "")
            {
                cbStart.SelectedIndex = 0;
            }
        }

        private void cbZiel_Leave(object sender, EventArgs e)
        {
            if(cbZiel.SelectedIndex < 0 && cbZiel.Items.Count > 0 && cbZiel.Text != "")
            {
                cbZiel.SelectedIndex = 0;
            }
        }
    }
}
