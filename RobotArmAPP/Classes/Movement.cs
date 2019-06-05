using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotArmAPP.Classes
{
    class Movement
    {
        public int Laser { get; set; }
        public int Axis3 { get; set; }
        public int Axis2 { get; set; }
        public int Axis1 { get; set; }
        public int Speed { get; set; }
        public int Delay { get; set; }
        public int RepeatTimes { get; set; }

        public Movement(int laser, int axis3, int axis2, int axis1, int speed, int delay, int repeatTimes)
        {
            this.Laser = laser;
            this.Axis3 = axis3;
            this.Axis2 = axis2;
            this.Axis1 = axis1;
            this.Speed = speed;
            this.Delay = delay;
            this.RepeatTimes = repeatTimes;
        }

        public enum StringType
        {
            all,
            allWithInfo,
            onlyAxis
        }

        public enum LaserState
        {
            ON,
            OFF
        }

        public string MovesToString(StringType stringType)
        {
            switch (stringType)
            {
                case StringType.all:
                    return this.Laser + "," + this.Axis3 + "," + this.Axis2 + "," + this.Axis1 + "," + this.Speed + "," + this.Delay;
                case StringType.allWithInfo:
                    return "[" + this.Laser.ToString("000") + "," + this.Axis3.ToString("000") + "," + this.Axis2.ToString("000") + "," + this.Axis1.ToString("000") + "] Speed: " + this.Speed.ToString("000") + ", Delay: " + this.Delay.ToString("000000") + "ms";
                case StringType.onlyAxis:
                    return this.Laser + "," + this.Axis3 + "," + this.Axis2 + "," + this.Axis1;
            }
            return null;
        }

        public int[] MovesToIntVector()
        {
            int[] Move = new int[5];
            Move[0] = this.Laser;
            Move[1] = this.Axis3;
            Move[2] = this.Axis2;
            Move[3] = this.Axis1;
            Move[4] = this.Speed;
            Move[5] = this.Delay;

            return Move;
        }
    }
}
