using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotArmAPP.Classes
{
    static class ControlsIndex
    {
        public const int Axis1 = 0;
        public const int Axis2 = 1;
        public const int Axis3 = 2;
        public const int Laser = 3;
        public const int FrameSpeedBox = 4;
        public const int DelayBox = 5;
        public const int RepeatTimesBox = 6;

        public enum ControlsEnum
        {
            Axis1,
            Axis2,
            Axis3,
            Laser,
            FrameSpeedBox,
            DelayBox,
            RepeatTimesBox
        }
    }
}
