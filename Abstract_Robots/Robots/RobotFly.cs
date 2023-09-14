﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    //כתבו את המחלקה על פי המחלקות הקודמות
    //שימו לב שעליכם להתייחס גם לתעופה
    class RobotFly : RobotSpy
    {
        public RobotFly() : base("Fly") {}

        public override void MoveBackward()
        {
            for (int i = 0; i < 6; i++)
                this.MoveLeg(i, -1);
        }

        public override void MoveForward()
        {
            for (int i = 0; i < 6; i++)
                this.MoveLeg(i, 1);
        }

        public override void TurnLeft()
        {
            this.MoveLeg(0, -1);
            this.MoveLeg(1, -1);
            this.MoveLeg(2, -1);
            this.MoveLeg(3, 1);
            this.MoveLeg(4, 1);
            this.MoveLeg(5, 1);
        }

        public override void TurnRight()
        {
            this.MoveLeg(0, 1);
            this.MoveLeg(1, 1);
            this.MoveLeg(2, 1);
            this.MoveLeg(3, -1);
            this.MoveLeg(2, -1);
            this.MoveLeg(3, -1);
        }

        private void MoveLeg(int legId, int dir)
        {
            this.setBatteryStatus(2);
        }

        private void Fly()
        {
            this.setBatteryStatus(1.5);
        }
    }
}
