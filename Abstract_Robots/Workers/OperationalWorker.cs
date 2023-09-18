using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    public class OperationalWorker : Worker //1. כתבו את המחלקה המתאימה להורשה 
    {
        //2. השלימות את התכונות החסרות
        protected double moneyPerHours;
        protected double houresWorked;

        public OperationalWorker(string name, string id, DateTime bDate, string pass, double money, double hours)
            : base(name, id, bDate, pass)
        {
            //3. השלימו את הקוד החסר לשמירת שכר בתכונה המתאימה
            // ?האם נדרשים פרמטרים נוספים
            this.moneyPerHours = money;
            this.houresWorked = hours;
        }


        //4. כתבו פעולה דורסת לחישוב שכר
        public override double Salary()
        {
            return (moneyPerHours * houresWorked);
        }


    }
}
