using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
	public abstract class RobotSpy
	{
		private string model;
		private DateTime creationDate;
		private double batteryStatus; 

		//1. עדכנו את הפעולה הבונה כך שתקבל פרמטרים בהתאם לתכונותV
		public RobotSpy(string model)
		{
			this.model = model;
			this.creationDate = DateTime.Now; 
			this.batteryStatus = 100;
		}
		public string GetModel() { 	return this.model; }
		public DateTime getCreationDate() { return this.creationDate; }
		public double getBatteryStatus() { return this.batteryStatus; }

		public void setBatteryStatus(double battery) { batteryStatus = batteryStatus = battery; }

		//2. השלימו פעולות מאחזרות עבור התכונות הנוספות
		//3. הוסיפו פעולה המעדכנת את מצב הסוללה

		public abstract void MoveForward();
		public abstract void MoveBackward();
		public abstract void TurnLeft();
		public abstract void TurnRight();

		public void TakePicture() 
		{
			this.batteryStatus = this.batteryStatus - 5;
		} //4. הוסיפו התייחסות למצב סוללה
		public void ChargeBattery()
		{
			this.batteryStatus = 100;
		} //5. עדכנו את מצב הסוללה ל-100
	}
}
