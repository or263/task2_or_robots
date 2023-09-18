using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Robots_inc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Worker> workers; //אוסף עובדים 
        List<Mission> activeMissions;//אוסף משימות פעילות
        List<RobotSpy> activeRobots; //אוסף רובוטים פעילים

        public MainWindow()
        {
            InitializeComponent();
            sixWorkers();
            eightRobots();
            fiveMissions();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Have a robotic day (-:", "Good bye", MessageBoxButton.OK);
            this.Close();
        }


        //משימה 1
        // : כתבו פעולה המחזירה אוסף של 6 עובדים 
        //מנכ"ל אחד, 2 מנהלי תפעול ו-3 עובדי תפעול
        //כתבו זימון לפעולה שכתבתם בפעולה הבונה של החלון
        public void sixWorkers()
        {
            workers = new List<Worker>();
            workers.Add(new GeneralManager("aaa", "12345678", new DateTime(2000, 01, 01), "pass123", 30000, 37));
            workers.Add(new OperationManager("bbb", "1234567", new DateTime(2000, 09, 25), "pass321", 48, 400, 7));
            workers.Add(new OperationManager("bbc", "123456", new DateTime(2000, 12, 11), "pass456", 48, 500, 11));
            workers.Add(new OperationalWorker("ccc", "12345", new DateTime(2000, 05, 08), "pass654", 42.5, 380));
            workers.Add(new OperationalWorker("ccd", "1234", new DateTime(2000, 09, 05), "pass789", 42.5, 410));
            workers.Add(new OperationalWorker("cdd", "123", new DateTime(2000, 05, 31), "123", 42.5, 350));

        }

        //משימה 2
        //כתבו פעולה המחזירה אוסף של 8 רובוטים
        //כתבו זימון לפעולה שכתבתם בפעולה הבונה של החלון
        public void eightRobots()
        {
            activeRobots = new List<RobotSpy>();
            activeRobots.Add(new RobotQuad());
            activeRobots.Add(new RobotQuad());
            activeRobots.Add(new RobotQuad());
            activeRobots.Add(new RobotWheels());
            activeRobots.Add(new RobotWheels());
            activeRobots.Add(new RobotWheels());
            activeRobots.Add(new RobotFly());
            activeRobots.Add(new RobotFly());

        }

        //משימה 3
        //כתבו פעולה המחזירה אוסף של 5 משימות
        //כתבו זימון לפעולה שכתבתם בפעולה הבונה של החלון       
        public void fiveMissions()
        {
            activeMissions = new List<Mission>();
            activeMissions.Add(new Mission(new DateTime(2023, 09, 10), "aaa"));
            activeMissions.Add(new Mission(new DateTime(2023, 09, 14), "bbb"));
            activeMissions.Add(new Mission(new DateTime(2023, 09, 17), "ccc"));
            activeMissions.Add(new Mission(new DateTime(2023, 09, 17), "ddd"));
            activeMissions.Add(new Mission(new DateTime(2023, 09, 16), "eee"));
        }

        //משימה 4
        //login כתבו פעולה המגיבה לללחיצה על כפתור 
        //אם הפרטים לא תואמים לעובד הקיים באוסף העובדים - תוצג הודעה מתאימה
        //WndMain אם כן, יש ליצור מופע של חלון 
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            //...אם מספר הזיהוי והסיסמה תואמים לעובד ברשימה, אז
            string id = tbxID.Text;
            string pass = tbxPassword.Password;
            bool isReal = false;

            foreach (Worker worker1 in workers)
            {
                if (worker1.getIdNumber().Equals(id) && worker1.getPassword().Equals(pass))
                {
                    isReal = true;
                    WndMain main = new WndMain(worker1, activeMissions, activeRobots, workers);
                    main.ShowDialog();
                }
            }
            if (!isReal) { MessageBox.Show("wrong id or password"); }


        }
    }
}
