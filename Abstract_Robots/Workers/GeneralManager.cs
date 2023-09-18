using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    public class GeneralManager : Worker
    {
        //1. השלימות את התכונות החסרות
        protected double monthlySalary;
        protected int activeRobots;

        public GeneralManager(string name, string id, DateTime bDate, string pass, double monthlySalary, int activeRobots)
            : base(name, id, bDate, pass)
        {
            //2. השלימו את הקוד החסר לשמירת שכר בתכונה המתאימה
            this.monthlySalary = monthlySalary;
            this.activeRobots = activeRobots;
        }

        //3. כתבו פעולה דורסת לחישוב שכר
        public override double Salary()
        {
            if (this.activeRobots > 30)
                return this.monthlySalary + (this.monthlySalary + this.monthlySalary * 0.15);
            return this.monthlySalary;
        }



    }
}
