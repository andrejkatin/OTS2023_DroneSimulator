using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS2023_DroneSimulator.Test
{
    [TestFixture]
    public class DroneTest
    {
        [Test]
        public void MoveUp_SuccessfullMovingUp_Success()
        {
            // ARRANGE
            int[] startPosition = { 30, 0, 30 };
            int[] boudaries = { 50, 50, 50 };
            Drone drone = new Drone(startPosition, boudaries);

            // ACT
            drone.MoveUp();

            // ASSERT
            Assert.AreEqual(1, drone.coordinates[1]);
        }
    }
}
