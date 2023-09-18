using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    public class OperationManager : Worker
    {
        //1. השלימות את התכונות החסרות
        protected double moneyPerHours;
        protected double houresWorked;
        protected int missionsSucceded;

        public OperationManager(string name, string id, DateTime bDate, string pass, double money, double hours, int missions)
            : base(name, id, bDate, pass)
        {
            //2. השלימו את הקוד החסר לשמירת שכר בתכונה המתאימה
            this.moneyPerHours = money;
            this.houresWorked = hours;
            this.missionsSucceded = missions;
        }

        //3. כתבו פעולה דורסת לחישוב שכר
        public override double Salary()
        {
            double salary = moneyPerHours * houresWorked;
            double bonus = 0;
            for (int i = 0; i < missionsSucceded; i++)
            {
                bonus = bonus + (0.03 * salary);
            }
            return bonus + salary;
        }



    }
}
