using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS2023_DroneSimulator.Test1
{
    [TestFixture]
    public class DroneTest
    {
        [Test]
        public void MoveUp_SuccessfullyMovingUp_Success()
        {
            // ARRANGE
            int[] startCoordinates = { 30, 0, 30 };
            int[] boundaries = { 50, 50, 50 };
            Drone drone = new Drone(startCoordinates, boundaries);

            // ACT
            drone.MoveUp();

            // ASSERT
            Assert.AreEqual(1, drone.coordinates[1]);
        }
    }
}
