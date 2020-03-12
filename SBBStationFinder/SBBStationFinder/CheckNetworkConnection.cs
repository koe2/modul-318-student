using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBBStationFinder
{
    public static class CheckNetworkConnection
    {
        public static bool start()
        {
            short errorLevel = 0;
            try
            {
                Ping myPing = new Ping();
                String host = "transport.opendata.ch";
                byte[] buffer = new byte[32];
                int timeout = 1000;
                PingOptions pingOptions = new PingOptions();
                PingReply reply = myPing.Send(host, timeout, buffer, pingOptions);
                if(reply.Status == IPStatus.Success)
                {
                    errorLevel = 0;
                }
            }
            catch(Exception)
            {
                errorLevel = 1;

                try
                {
                    Ping myPing = new Ping();
                    String host = "google.com";
                    byte[] buffer = new byte[32];
                    int timeout = 1000;
                    PingOptions pingOptions = new PingOptions();
                    PingReply reply = myPing.Send(host, timeout, buffer, pingOptions);
                    if(reply.Status == IPStatus.Success)
                    {
                        errorLevel = 0;
                    }
                }
                catch(Exception)
                {
                    errorLevel = 2;
                }
            }

            if(errorLevel == 1)
            {
                MessageBox.Show("transport.opendata.ch ist nicht erreichbar!");
                return false;
            }
            else if(errorLevel == 2)
            {
                MessageBox.Show("google.com ist nicht erreichbar! Verbindung zum Internet überprüfen!");
                return false;
            }

            return true;
        }


    }
}
