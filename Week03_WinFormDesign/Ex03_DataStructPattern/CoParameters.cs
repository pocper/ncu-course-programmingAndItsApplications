using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex03_DataStructPattern
{
    enum RobotStatus { Idle, Moving, Pickup, Place };
    enum RobotPosition { Origin, RedStorage, GreenStorage, Port }

    internal class CoParameters
    {
        /// <summary>
        /// Job. Red=0 ; Green=1
        /// </summary>
        internal int AssignedJob = 0;

        internal int ExecutedJob = 0;

        internal bool isStarted = false;

        internal bool isResetStarted = false;

        internal RobotStatus RobotStatus = RobotStatus.Idle;

        internal RobotPosition RobotPosition = RobotPosition.Origin;

        internal DateTime InitTime = DateTime.Now;
        internal DateTime EndTime = DateTime.Now;
    }
}
