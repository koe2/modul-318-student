﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SwissTransport
{
    [TestClass]
    public class TransportTest
    {
        private ITransport testee;

        [TestMethod]
        public void Locations()
        {
            testee = new Transport();
            var stations = testee.GetStations("Sursee,");

            Assert.AreEqual(10, stations.StationList.Count);
        }

        [TestMethod]
        public void StationBoard()
        {
            testee = new Transport();
            var stationBoard = testee.GetStationBoard("Sursee", "8502007");

            Assert.IsNotNull(stationBoard);
        }

        [TestMethod]
        public void Connections()
        {
            testee = new Transport();
            var connections = testee.GetConnections("Sursee", "Luzern");

            Assert.IsNotNull(connections);
        }

        [TestMethod]
        public void ConnectionsByDateTime()
        {
            testee = new Transport();
            var connections = testee.GetConnectionByDateTime("Sursee", "Luzern", "2020-03-12", "", 1);

            Assert.IsNotNull(connections);
        }
    }
}
