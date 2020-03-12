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
        private string textChanged;

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbStart_TextChanged(object sender, EventArgs e)
        {
           
            ComboBox cbSender;
            if(sender is ComboBox)
            {
                cbSender = (ComboBox)sender;
            }
            else
            {
                return;
            }

            if(textChanged != cbSender.Text)
            {
                try
                {
                    autoComplete(cbSender);
                    textChanged = cbSender.Text;
                }
                catch(Exception)
                {
                    CheckNetworkConnection.start();
                }
            }
;        }

        private void autoComplete(ComboBox _sender)
        {
            string inputText = _sender.Text;
            if(_sender.Text.Length >= 3 && !(_sender.Items.Contains(_sender.Text)))
            {
                validStations = getValidSations(_sender.Text);
                _sender.Items.Clear();
                if(validStations != null)
                {
                    foreach(Station s in validStations.StationList)
                    {
                        _sender.Items.Add(s.Name);
                    }
                }
                _sender.DroppedDown = true;
                _sender.Text = inputText;
                _sender.SelectionStart = _sender.Text.Length;
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
            if(_start == "" || _end == "" || _date == "")
            {
                return;
            }

            iStation = new Transport();
            Connections transportConnection = iStation.GetConnectionByDateTime(_start, _end, convertToAPIDate(_date), _time, _isArrival);

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

        private StationBoardRoot getStationBoard(ComboBox _cbSender, ListBox _lb, TabPage _tb)
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
                pageControl.Focus();
            }
            catch(Exception)
            {
                CheckNetworkConnection.start();
            }
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
            catch
                (
                 System.ComponentModel.Win32Exception noBrowser)
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
    }
}
